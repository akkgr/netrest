using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class NodeToNodeProfile
        : AutoMapper.Profile
    {
        public NodeToNodeProfile()
        {
            CreateMap<Sca.Data.Entities.NodeToNode, Sca.Domain.Models.NodeToNodeReadModel>();
            CreateMap<Sca.Domain.Models.NodeToNodeCreateModel, Sca.Data.Entities.NodeToNode>();
            CreateMap<Sca.Domain.Models.NodeToNodeUpdateModel, Sca.Data.Entities.NodeToNode>();
        }

    }
}
