using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class ArchiveCategoryProfile
        : AutoMapper.Profile
    {
        public ArchiveCategoryProfile()
        {
            CreateMap<Sca.Data.Entities.ArchiveCategory, Sca.Domain.Models.ArchiveCategoryReadModel>();
            CreateMap<Sca.Domain.Models.ArchiveCategoryCreateModel, Sca.Data.Entities.ArchiveCategory>();
            CreateMap<Sca.Domain.Models.ArchiveCategoryUpdateModel, Sca.Data.Entities.ArchiveCategory>();
        }

    }
}
