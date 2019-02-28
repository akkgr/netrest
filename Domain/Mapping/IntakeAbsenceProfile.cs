using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class IntakeAbsenceProfile
        : AutoMapper.Profile
    {
        public IntakeAbsenceProfile()
        {
            CreateMap<Sca.Data.Entities.IntakeAbsence, Sca.Domain.Models.IntakeAbsenceReadModel>();
            CreateMap<Sca.Domain.Models.IntakeAbsenceCreateModel, Sca.Data.Entities.IntakeAbsence>();
            CreateMap<Sca.Domain.Models.IntakeAbsenceUpdateModel, Sca.Data.Entities.IntakeAbsence>();
        }

    }
}
