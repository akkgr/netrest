using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class BoardMemberTypeProfile
        : AutoMapper.Profile
    {
        public BoardMemberTypeProfile()
        {
            CreateMap<Sca.Data.Entities.BoardMemberType, Sca.Domain.Models.BoardMemberTypeReadModel>();
            CreateMap<Sca.Domain.Models.BoardMemberTypeCreateModel, Sca.Data.Entities.BoardMemberType>();
            CreateMap<Sca.Domain.Models.BoardMemberTypeUpdateModel, Sca.Data.Entities.BoardMemberType>();
        }

    }
}
