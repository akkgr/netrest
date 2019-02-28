using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class AssetTypeProfile
        : AutoMapper.Profile
    {
        public AssetTypeProfile()
        {
            CreateMap<Sca.Data.Entities.AssetType, Sca.Domain.Models.AssetTypeReadModel>();
            CreateMap<Sca.Domain.Models.AssetTypeCreateModel, Sca.Data.Entities.AssetType>();
            CreateMap<Sca.Domain.Models.AssetTypeUpdateModel, Sca.Data.Entities.AssetType>();
        }

    }
}
