using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class CardEmployeeProfile
        : AutoMapper.Profile
    {
        public CardEmployeeProfile()
        {
            CreateMap<Sca.Data.Entities.CardEmployee, Sca.Domain.Models.CardEmployeeReadModel>();
            CreateMap<Sca.Domain.Models.CardEmployeeCreateModel, Sca.Data.Entities.CardEmployee>();
            CreateMap<Sca.Domain.Models.CardEmployeeUpdateModel, Sca.Data.Entities.CardEmployee>();
        }

    }
}
