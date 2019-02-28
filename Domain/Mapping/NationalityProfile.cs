using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class NationalityProfile
        : AutoMapper.Profile
    {
        public NationalityProfile()
        {
            CreateMap<Sca.Data.Entities.Nationality, Sca.Domain.Models.NationalityReadModel>();
            CreateMap<Sca.Domain.Models.NationalityCreateModel, Sca.Data.Entities.Nationality>();
            CreateMap<Sca.Domain.Models.NationalityUpdateModel, Sca.Data.Entities.Nationality>();
        }

    }
}
