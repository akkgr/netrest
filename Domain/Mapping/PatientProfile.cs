using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class PatientProfile
        : AutoMapper.Profile
    {
        public PatientProfile()
        {
            CreateMap<Sca.Data.Entities.Patient, Sca.Domain.Models.PatientReadModel>();
            CreateMap<Sca.Domain.Models.PatientCreateModel, Sca.Data.Entities.Patient>();
            CreateMap<Sca.Domain.Models.PatientUpdateModel, Sca.Data.Entities.Patient>();
        }

    }
}
