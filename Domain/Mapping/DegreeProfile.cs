using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class DegreeProfile
        : AutoMapper.Profile
    {
        public DegreeProfile()
        {
            CreateMap<Sca.Data.Entities.Degree, Sca.Domain.Models.DegreeReadModel>();
            CreateMap<Sca.Domain.Models.DegreeCreateModel, Sca.Data.Entities.Degree>();
            CreateMap<Sca.Domain.Models.DegreeUpdateModel, Sca.Data.Entities.Degree>();
        }

    }
}
