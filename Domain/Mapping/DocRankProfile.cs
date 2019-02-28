using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class DocRankProfile
        : AutoMapper.Profile
    {
        public DocRankProfile()
        {
            CreateMap<Sca.Data.Entities.DocRank, Sca.Domain.Models.DocRankReadModel>();
            CreateMap<Sca.Domain.Models.DocRankCreateModel, Sca.Data.Entities.DocRank>();
            CreateMap<Sca.Domain.Models.DocRankUpdateModel, Sca.Data.Entities.DocRank>();
        }

    }
}
