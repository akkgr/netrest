using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class AppointmentTypeProfile
        : AutoMapper.Profile
    {
        public AppointmentTypeProfile()
        {
            CreateMap<Sca.Data.Entities.AppointmentType, Sca.Domain.Models.AppointmentTypeReadModel>();
            CreateMap<Sca.Domain.Models.AppointmentTypeCreateModel, Sca.Data.Entities.AppointmentType>();
            CreateMap<Sca.Domain.Models.AppointmentTypeUpdateModel, Sca.Data.Entities.AppointmentType>();
        }

    }
}
