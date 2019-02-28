using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class IncomeProfile
        : AutoMapper.Profile
    {
        public IncomeProfile()
        {
            CreateMap<Sca.Data.Entities.Income, Sca.Domain.Models.IncomeReadModel>();
            CreateMap<Sca.Domain.Models.IncomeCreateModel, Sca.Data.Entities.Income>();
            CreateMap<Sca.Domain.Models.IncomeUpdateModel, Sca.Data.Entities.Income>();
        }

    }
}
