using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class BoardMemberProfile
        : AutoMapper.Profile
    {
        public BoardMemberProfile()
        {
            CreateMap<Sca.Data.Entities.BoardMember, Sca.Domain.Models.BoardMemberReadModel>();
            CreateMap<Sca.Domain.Models.BoardMemberCreateModel, Sca.Data.Entities.BoardMember>();
            CreateMap<Sca.Domain.Models.BoardMemberUpdateModel, Sca.Data.Entities.BoardMember>();
        }

    }
}
