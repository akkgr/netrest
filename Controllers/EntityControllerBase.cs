using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sca.Data;
using Sca.Definitions;
using Sca.Domain.Models;

namespace Tracker.Web.Controllers
{
    [ApiController]
    [Produces("application/json")]
    public abstract class EntityControllerBase<TEntity, TReadModel, TCreateModel, TUpdateModel> : ControllerBase
        where TEntity : class, IHaveIdentifier
        where TReadModel : EntityReadModel
        where TCreateModel : EntityCreateModel
        where TUpdateModel : EntityUpdateModel
    {
        protected EntityControllerBase(ScaContext dataContext, IMapper mapper, IValidator<TCreateModel> createValidator, IValidator<TUpdateModel> updateValidator)
        {
            DataContext = dataContext;
            Mapper = mapper;
            CreateValidator = createValidator;
            UpdateValidator = updateValidator;
        }


        protected ScaContext DataContext { get; }
        protected IMapper Mapper { get; }
        protected IValidator<TCreateModel> CreateValidator { get; }
        protected IValidator<TUpdateModel> UpdateValidator { get; }

        protected virtual async Task<TReadModel> ReadModel(int id, CancellationToken cancellationToken = default(CancellationToken))
        {
            var model = await DataContext
                .Set<TEntity>()
                .AsNoTracking()
                .Where(p => p.Id == id)
                .ProjectTo<TReadModel>(Mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(cancellationToken);

            return model;
        }

        protected virtual async Task<IReadOnlyList<TReadModel>> QueryModel(Expression<Func<TEntity, bool>> predicate = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var dbSet = DataContext
                .Set<TEntity>();

            var query = dbSet.AsNoTracking();
            if (predicate != null)
                query = query.Where(predicate);

            var results = await query
                .ProjectTo<TReadModel>(Mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            return results;
        }

        protected virtual async Task<TReadModel> CreateModel(TCreateModel createModel, CancellationToken cancellationToken = default(CancellationToken))
        {
            var identityName = User?.Identity?.Name;

            createModel.Created = DateTimeOffset.UtcNow;
            createModel.CreatedBy = identityName;
            createModel.Updated = DateTimeOffset.UtcNow;
            createModel.UpdatedBy = identityName;

            // validate model
            await CreateValidator.ValidateAndThrowAsync(createModel, cancellationToken: cancellationToken);

            // create new entity from model
            var entity = Mapper.Map<TEntity>(createModel);

            // add to data set, id should be generated
            await DataContext
                .Set<TEntity>()
                .AddAsync(entity, cancellationToken);

            // save to database
            await DataContext
                .SaveChangesAsync(cancellationToken);

            // convert to read model
            var readModel = await ReadModel(entity.Id, cancellationToken);

            return readModel;
        }

        protected virtual async Task<TReadModel> UpdateModel(int id, TUpdateModel updateModel, CancellationToken cancellationToken = default(CancellationToken))
        {
            var identityName = User?.Identity?.Name;

            updateModel.Updated = DateTimeOffset.UtcNow;
            updateModel.UpdatedBy = identityName;

            // validate model
            await UpdateValidator.ValidateAndThrowAsync(updateModel, cancellationToken: cancellationToken);

            // primary key
            var keyValue = new object[] { id };

            // find entity to update by id, not model id
            var entity = await DataContext
                .Set<TEntity>()
                .FindAsync(keyValue, cancellationToken);

            if (entity == null)
                return default(TReadModel);

            // copy updates from model to entity
            Mapper.Map(updateModel, entity);

            // save updates
            await DataContext
                .SaveChangesAsync(cancellationToken);

            // return read model
            var readModel = await ReadModel(id, cancellationToken);
            return readModel;
        }

        protected virtual async Task<TReadModel> DeleteModel(int id, CancellationToken cancellationToken = default(CancellationToken))
        {
            var dbSet = DataContext
                .Set<TEntity>();

            var keyValue = new object[] { id };

            // find entity to delete by id
            var entity = await dbSet
                .FindAsync(keyValue, cancellationToken);

            if (entity == null)
                return default(TReadModel);

            // return read model
            var readModel = await ReadModel(id, cancellationToken);

            // delete entry
            dbSet.Remove(entity);

            // save
            await DataContext
                .SaveChangesAsync(cancellationToken);

            return readModel;
        }
    }
}