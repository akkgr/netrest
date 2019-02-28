using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class AppointmentIntakeProfile
        : AutoMapper.Profile
    {
        public AppointmentIntakeProfile()
        {
            CreateMap<Sca.Data.Entities.AppointmentIntake, Sca.Domain.Models.AppointmentIntakeReadModel>();
            CreateMap<Sca.Domain.Models.AppointmentIntakeCreateModel, Sca.Data.Entities.AppointmentIntake>();
            CreateMap<Sca.Domain.Models.AppointmentIntakeUpdateModel, Sca.Data.Entities.AppointmentIntake>();
        }

    }
}
