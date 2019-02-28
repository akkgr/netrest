using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class DailyFoodMenuProfile
        : AutoMapper.Profile
    {
        public DailyFoodMenuProfile()
        {
            CreateMap<Sca.Data.Entities.DailyFoodMenu, Sca.Domain.Models.DailyFoodMenuReadModel>();
            CreateMap<Sca.Domain.Models.DailyFoodMenuCreateModel, Sca.Data.Entities.DailyFoodMenu>();
            CreateMap<Sca.Domain.Models.DailyFoodMenuUpdateModel, Sca.Data.Entities.DailyFoodMenu>();
        }

    }
}
