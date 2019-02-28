using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class PackagingProfile
        : AutoMapper.Profile
    {
        public PackagingProfile()
        {
            CreateMap<Sca.Data.Entities.Packaging, Sca.Domain.Models.PackagingReadModel>();
            CreateMap<Sca.Domain.Models.PackagingCreateModel, Sca.Data.Entities.Packaging>();
            CreateMap<Sca.Domain.Models.PackagingUpdateModel, Sca.Data.Entities.Packaging>();
        }

    }
}
