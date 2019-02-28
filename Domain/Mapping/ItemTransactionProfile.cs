using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class ItemTransactionProfile
        : AutoMapper.Profile
    {
        public ItemTransactionProfile()
        {
            CreateMap<Sca.Data.Entities.ItemTransaction, Sca.Domain.Models.ItemTransactionReadModel>();
            CreateMap<Sca.Domain.Models.ItemTransactionCreateModel, Sca.Data.Entities.ItemTransaction>();
            CreateMap<Sca.Domain.Models.ItemTransactionUpdateModel, Sca.Data.Entities.ItemTransaction>();
        }

    }
}
