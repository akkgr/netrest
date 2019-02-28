using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class DocGroupProfile
        : AutoMapper.Profile
    {
        public DocGroupProfile()
        {
            CreateMap<Sca.Data.Entities.DocGroup, Sca.Domain.Models.DocGroupReadModel>();
            CreateMap<Sca.Domain.Models.DocGroupCreateModel, Sca.Data.Entities.DocGroup>();
            CreateMap<Sca.Domain.Models.DocGroupUpdateModel, Sca.Data.Entities.DocGroup>();
        }

    }
}
