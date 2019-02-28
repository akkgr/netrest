using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class VolunteerProfile
        : AutoMapper.Profile
    {
        public VolunteerProfile()
        {
            CreateMap<Sca.Data.Entities.Volunteer, Sca.Domain.Models.VolunteerReadModel>();
            CreateMap<Sca.Domain.Models.VolunteerCreateModel, Sca.Data.Entities.Volunteer>();
            CreateMap<Sca.Domain.Models.VolunteerUpdateModel, Sca.Data.Entities.Volunteer>();
        }

    }
}
