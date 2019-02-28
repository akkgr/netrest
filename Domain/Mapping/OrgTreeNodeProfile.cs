using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class OrgTreeNodeProfile
        : AutoMapper.Profile
    {
        public OrgTreeNodeProfile()
        {
            CreateMap<Sca.Data.Entities.OrgTreeNode, Sca.Domain.Models.OrgTreeNodeReadModel>();
            CreateMap<Sca.Domain.Models.OrgTreeNodeCreateModel, Sca.Data.Entities.OrgTreeNode>();
            CreateMap<Sca.Domain.Models.OrgTreeNodeUpdateModel, Sca.Data.Entities.OrgTreeNode>();
        }

    }
}
