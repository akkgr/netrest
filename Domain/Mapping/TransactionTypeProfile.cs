using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class TransactionTypeProfile
        : AutoMapper.Profile
    {
        public TransactionTypeProfile()
        {
            CreateMap<Sca.Data.Entities.TransactionType, Sca.Domain.Models.TransactionTypeReadModel>();
            CreateMap<Sca.Domain.Models.TransactionTypeCreateModel, Sca.Data.Entities.TransactionType>();
            CreateMap<Sca.Domain.Models.TransactionTypeUpdateModel, Sca.Data.Entities.TransactionType>();
        }

    }
}
