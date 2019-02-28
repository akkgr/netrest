using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class ApplicantProfile
        : AutoMapper.Profile
    {
        public ApplicantProfile()
        {
            CreateMap<Sca.Data.Entities.Applicant, Sca.Domain.Models.ApplicantReadModel>();
            CreateMap<Sca.Domain.Models.ApplicantCreateModel, Sca.Data.Entities.Applicant>();
            CreateMap<Sca.Domain.Models.ApplicantUpdateModel, Sca.Data.Entities.Applicant>();
        }

    }
}
