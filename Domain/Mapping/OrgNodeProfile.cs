using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class OrgNodeProfile
        : AutoMapper.Profile
    {
        public OrgNodeProfile()
        {
            CreateMap<Sca.Data.Entities.OrgNode, Sca.Domain.Models.OrgNodeReadModel>();
            CreateMap<Sca.Domain.Models.OrgNodeCreateModel, Sca.Data.Entities.OrgNode>();
            CreateMap<Sca.Domain.Models.OrgNodeUpdateModel, Sca.Data.Entities.OrgNode>();
        }

    }
}
