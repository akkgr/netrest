using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class ArchiveProfile
        : AutoMapper.Profile
    {
        public ArchiveProfile()
        {
            CreateMap<Sca.Data.Entities.Archive, Sca.Domain.Models.ArchiveReadModel>();
            CreateMap<Sca.Domain.Models.ArchiveCreateModel, Sca.Data.Entities.Archive>();
            CreateMap<Sca.Domain.Models.ArchiveUpdateModel, Sca.Data.Entities.Archive>();
        }

    }
}
