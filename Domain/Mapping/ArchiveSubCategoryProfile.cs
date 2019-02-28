using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class ArchiveSubCategoryProfile
        : AutoMapper.Profile
    {
        public ArchiveSubCategoryProfile()
        {
            CreateMap<Sca.Data.Entities.ArchiveSubCategory, Sca.Domain.Models.ArchiveSubCategoryReadModel>();
            CreateMap<Sca.Domain.Models.ArchiveSubCategoryCreateModel, Sca.Data.Entities.ArchiveSubCategory>();
            CreateMap<Sca.Domain.Models.ArchiveSubCategoryUpdateModel, Sca.Data.Entities.ArchiveSubCategory>();
        }

    }
}
