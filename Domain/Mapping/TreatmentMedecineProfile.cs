using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class TreatmentMedecineProfile
        : AutoMapper.Profile
    {
        public TreatmentMedecineProfile()
        {
            CreateMap<Sca.Data.Entities.TreatmentMedecine, Sca.Domain.Models.TreatmentMedecineReadModel>();
            CreateMap<Sca.Domain.Models.TreatmentMedecineCreateModel, Sca.Data.Entities.TreatmentMedecine>();
            CreateMap<Sca.Domain.Models.TreatmentMedecineUpdateModel, Sca.Data.Entities.TreatmentMedecine>();
        }

    }
}
