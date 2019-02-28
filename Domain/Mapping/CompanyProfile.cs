using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class CompanyProfile
        : AutoMapper.Profile
    {
        public CompanyProfile()
        {
            CreateMap<Sca.Data.Entities.Company, Sca.Domain.Models.CompanyReadModel>();
            CreateMap<Sca.Domain.Models.CompanyCreateModel, Sca.Data.Entities.Company>();
            CreateMap<Sca.Domain.Models.CompanyUpdateModel, Sca.Data.Entities.Company>();
        }

    }
}
