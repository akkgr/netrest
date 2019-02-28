using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class AppointmentSpecialtyProfile
        : AutoMapper.Profile
    {
        public AppointmentSpecialtyProfile()
        {
            CreateMap<Sca.Data.Entities.AppointmentSpecialty, Sca.Domain.Models.AppointmentSpecialtyReadModel>();
            CreateMap<Sca.Domain.Models.AppointmentSpecialtyCreateModel, Sca.Data.Entities.AppointmentSpecialty>();
            CreateMap<Sca.Domain.Models.AppointmentSpecialtyUpdateModel, Sca.Data.Entities.AppointmentSpecialty>();
        }

    }
}
