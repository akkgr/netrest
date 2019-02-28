using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class ItemGroupProfile
        : AutoMapper.Profile
    {
        public ItemGroupProfile()
        {
            CreateMap<Sca.Data.Entities.ItemGroup, Sca.Domain.Models.ItemGroupReadModel>();
            CreateMap<Sca.Domain.Models.ItemGroupCreateModel, Sca.Data.Entities.ItemGroup>();
            CreateMap<Sca.Domain.Models.ItemGroupUpdateModel, Sca.Data.Entities.ItemGroup>();
        }

    }
}
