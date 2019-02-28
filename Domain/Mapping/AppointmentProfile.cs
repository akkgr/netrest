using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class AppointmentProfile
        : AutoMapper.Profile
    {
        public AppointmentProfile()
        {
            CreateMap<Sca.Data.Entities.Appointment, Sca.Domain.Models.AppointmentReadModel>();
            CreateMap<Sca.Domain.Models.AppointmentCreateModel, Sca.Data.Entities.Appointment>();
            CreateMap<Sca.Domain.Models.AppointmentUpdateModel, Sca.Data.Entities.Appointment>();
        }

    }
}
