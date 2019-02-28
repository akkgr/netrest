using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class FoodMenuProfile
        : AutoMapper.Profile
    {
        public FoodMenuProfile()
        {
            CreateMap<Sca.Data.Entities.FoodMenu, Sca.Domain.Models.FoodMenuReadModel>();
            CreateMap<Sca.Domain.Models.FoodMenuCreateModel, Sca.Data.Entities.FoodMenu>();
            CreateMap<Sca.Domain.Models.FoodMenuUpdateModel, Sca.Data.Entities.FoodMenu>();
        }

    }
}
