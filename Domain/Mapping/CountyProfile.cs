using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class CountyProfile
        : AutoMapper.Profile
    {
        public CountyProfile()
        {
            CreateMap<Sca.Data.Entities.County, Sca.Domain.Models.CountyReadModel>();
            CreateMap<Sca.Domain.Models.CountyCreateModel, Sca.Data.Entities.County>();
            CreateMap<Sca.Domain.Models.CountyUpdateModel, Sca.Data.Entities.County>();
        }

    }
}
