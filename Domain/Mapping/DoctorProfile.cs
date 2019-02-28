using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class DoctorProfile
        : AutoMapper.Profile
    {
        public DoctorProfile()
        {
            CreateMap<Sca.Data.Entities.Doctor, Sca.Domain.Models.DoctorReadModel>();
            CreateMap<Sca.Domain.Models.DoctorCreateModel, Sca.Data.Entities.Doctor>();
            CreateMap<Sca.Domain.Models.DoctorUpdateModel, Sca.Data.Entities.Doctor>();
        }

    }
}
