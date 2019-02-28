using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class DocUserProfile
        : AutoMapper.Profile
    {
        public DocUserProfile()
        {
            CreateMap<Sca.Data.Entities.DocUser, Sca.Domain.Models.DocUserReadModel>();
            CreateMap<Sca.Domain.Models.DocUserCreateModel, Sca.Data.Entities.DocUser>();
            CreateMap<Sca.Domain.Models.DocUserUpdateModel, Sca.Data.Entities.DocUser>();
        }

    }
}
