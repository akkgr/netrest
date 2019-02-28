using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Sca.Data;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class AppointmentsController : EntityControllerBase<Appointment, AppointmentReadModel, AppointmentCreateModel, AppointmentUpdateModel>
    {
        public AppointmentsController(ScaContext dataContext, IMapper mapper, IValidator<AppointmentCreateModel> createValidator, IValidator<AppointmentUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AppointmentReadModel>> Get(CancellationToken cancellationToken, int id)
        {
            var readModel = await ReadModel(id, cancellationToken);

            if (readModel == null)
                return NotFound();

            return readModel;
        }

        [HttpGet("")]
        public async Task<ActionResult<IReadOnlyList<AppointmentReadModel>>> List(CancellationToken cancellationToken)
        {
            var listResult = await QueryModel(null, cancellationToken);
            return Ok(listResult);
        }

        [HttpPost("")]
        public async Task<ActionResult<AppointmentReadModel>> Create(CancellationToken cancellationToken, AppointmentCreateModel createModel)
        {
            var readModel = await CreateModel(createModel, cancellationToken);

            return readModel;
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<AppointmentReadModel>> Update(CancellationToken cancellationToken, int id, AppointmentUpdateModel updateModel)
        {
            var readModel = await UpdateModel(id, updateModel, cancellationToken);
            if (readModel == null)
                return NotFound();

            return readModel;
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<AppointmentReadModel>> Delete(CancellationToken cancellationToken, int id)
        {
            var readModel = await DeleteModel(id, cancellationToken);
            if (readModel == null)
                return NotFound();

            return readModel;
        }

    }
}
