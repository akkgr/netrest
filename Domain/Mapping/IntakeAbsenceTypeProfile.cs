using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class IntakeAbsenceTypeProfile
        : AutoMapper.Profile
    {
        public IntakeAbsenceTypeProfile()
        {
            CreateMap<Sca.Data.Entities.IntakeAbsenceType, Sca.Domain.Models.IntakeAbsenceTypeReadModel>();
            CreateMap<Sca.Domain.Models.IntakeAbsenceTypeCreateModel, Sca.Data.Entities.IntakeAbsenceType>();
            CreateMap<Sca.Domain.Models.IntakeAbsenceTypeUpdateModel, Sca.Data.Entities.IntakeAbsenceType>();
        }

    }
}
