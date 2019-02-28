using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class BudgetProfile
        : AutoMapper.Profile
    {
        public BudgetProfile()
        {
            CreateMap<Sca.Data.Entities.Budget, Sca.Domain.Models.BudgetReadModel>();
            CreateMap<Sca.Domain.Models.BudgetCreateModel, Sca.Data.Entities.Budget>();
            CreateMap<Sca.Domain.Models.BudgetUpdateModel, Sca.Data.Entities.Budget>();
        }

    }
}
