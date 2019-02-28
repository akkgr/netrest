using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class CategoryProfile
        : AutoMapper.Profile
    {
        public CategoryProfile()
        {
            CreateMap<Sca.Data.Entities.Category, Sca.Domain.Models.CategoryReadModel>();
            CreateMap<Sca.Domain.Models.CategoryCreateModel, Sca.Data.Entities.Category>();
            CreateMap<Sca.Domain.Models.CategoryUpdateModel, Sca.Data.Entities.Category>();
        }

    }
}
