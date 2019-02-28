using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class ProductTransactionProfile
        : AutoMapper.Profile
    {
        public ProductTransactionProfile()
        {
            CreateMap<Sca.Data.Entities.ProductTransaction, Sca.Domain.Models.ProductTransactionReadModel>();
            CreateMap<Sca.Domain.Models.ProductTransactionCreateModel, Sca.Data.Entities.ProductTransaction>();
            CreateMap<Sca.Domain.Models.ProductTransactionUpdateModel, Sca.Data.Entities.ProductTransaction>();
        }

    }
}
