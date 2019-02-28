using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class OrgNodeTypeProfile
        : AutoMapper.Profile
    {
        public OrgNodeTypeProfile()
        {
            CreateMap<Sca.Data.Entities.OrgNodeType, Sca.Domain.Models.OrgNodeTypeReadModel>();
            CreateMap<Sca.Domain.Models.OrgNodeTypeCreateModel, Sca.Data.Entities.OrgNodeType>();
            CreateMap<Sca.Domain.Models.OrgNodeTypeUpdateModel, Sca.Data.Entities.OrgNodeType>();
        }

    }
}
