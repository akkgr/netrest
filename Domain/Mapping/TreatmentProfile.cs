using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class TreatmentProfile
        : AutoMapper.Profile
    {
        public TreatmentProfile()
        {
            CreateMap<Sca.Data.Entities.Treatment, Sca.Domain.Models.TreatmentReadModel>();
            CreateMap<Sca.Domain.Models.TreatmentCreateModel, Sca.Data.Entities.Treatment>();
            CreateMap<Sca.Domain.Models.TreatmentUpdateModel, Sca.Data.Entities.Treatment>();
        }

    }
}
