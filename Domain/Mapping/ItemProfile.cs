using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class ItemProfile
        : AutoMapper.Profile
    {
        public ItemProfile()
        {
            CreateMap<Sca.Data.Entities.Item, Sca.Domain.Models.ItemReadModel>();
            CreateMap<Sca.Domain.Models.ItemCreateModel, Sca.Data.Entities.Item>();
            CreateMap<Sca.Domain.Models.ItemUpdateModel, Sca.Data.Entities.Item>();
        }

    }
}
