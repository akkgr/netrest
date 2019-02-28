using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class ContractTypeProfile
        : AutoMapper.Profile
    {
        public ContractTypeProfile()
        {
            CreateMap<Sca.Data.Entities.ContractType, Sca.Domain.Models.ContractTypeReadModel>();
            CreateMap<Sca.Domain.Models.ContractTypeCreateModel, Sca.Data.Entities.ContractType>();
            CreateMap<Sca.Domain.Models.ContractTypeUpdateModel, Sca.Data.Entities.ContractType>();
        }

    }
}
