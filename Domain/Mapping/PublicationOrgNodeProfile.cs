using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class PublicationOrgNodeProfile
        : AutoMapper.Profile
    {
        public PublicationOrgNodeProfile()
        {
            CreateMap<Sca.Data.Entities.PublicationOrgNode, Sca.Domain.Models.PublicationOrgNodeReadModel>();
            CreateMap<Sca.Domain.Models.PublicationOrgNodeCreateModel, Sca.Data.Entities.PublicationOrgNode>();
            CreateMap<Sca.Domain.Models.PublicationOrgNodeUpdateModel, Sca.Data.Entities.PublicationOrgNode>();
        }

    }
}
