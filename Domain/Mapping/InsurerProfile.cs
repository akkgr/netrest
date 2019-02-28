using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class InsurerProfile
        : AutoMapper.Profile
    {
        public InsurerProfile()
        {
            CreateMap<Sca.Data.Entities.Insurer, Sca.Domain.Models.InsurerReadModel>();
            CreateMap<Sca.Domain.Models.InsurerCreateModel, Sca.Data.Entities.Insurer>();
            CreateMap<Sca.Domain.Models.InsurerUpdateModel, Sca.Data.Entities.Insurer>();
        }

    }
}
