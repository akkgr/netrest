using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class AssetProfile
        : AutoMapper.Profile
    {
        public AssetProfile()
        {
            CreateMap<Sca.Data.Entities.Asset, Sca.Domain.Models.AssetReadModel>();
            CreateMap<Sca.Domain.Models.AssetCreateModel, Sca.Data.Entities.Asset>();
            CreateMap<Sca.Domain.Models.AssetUpdateModel, Sca.Data.Entities.Asset>();
        }

    }
}
