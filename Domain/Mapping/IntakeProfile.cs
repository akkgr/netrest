using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class IntakeProfile
        : AutoMapper.Profile
    {
        public IntakeProfile()
        {
            CreateMap<Sca.Data.Entities.Intake, Sca.Domain.Models.IntakeReadModel>();
            CreateMap<Sca.Domain.Models.IntakeCreateModel, Sca.Data.Entities.Intake>();
            CreateMap<Sca.Domain.Models.IntakeUpdateModel, Sca.Data.Entities.Intake>();
        }

    }
}
