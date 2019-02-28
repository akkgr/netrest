using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class AssetTransactionProfile
        : AutoMapper.Profile
    {
        public AssetTransactionProfile()
        {
            CreateMap<Sca.Data.Entities.AssetTransaction, Sca.Domain.Models.AssetTransactionReadModel>();
            CreateMap<Sca.Domain.Models.AssetTransactionCreateModel, Sca.Data.Entities.AssetTransaction>();
            CreateMap<Sca.Domain.Models.AssetTransactionUpdateModel, Sca.Data.Entities.AssetTransaction>();
        }

    }
}
