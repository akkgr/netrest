using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class DocDocGroupProfile
        : AutoMapper.Profile
    {
        public DocDocGroupProfile()
        {
            CreateMap<Sca.Data.Entities.DocDocGroup, Sca.Domain.Models.DocDocGroupReadModel>();
            CreateMap<Sca.Domain.Models.DocDocGroupCreateModel, Sca.Data.Entities.DocDocGroup>();
            CreateMap<Sca.Domain.Models.DocDocGroupUpdateModel, Sca.Data.Entities.DocDocGroup>();
        }

    }
}
