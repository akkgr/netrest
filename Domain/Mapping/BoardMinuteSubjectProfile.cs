using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class BoardMinuteSubjectProfile
        : AutoMapper.Profile
    {
        public BoardMinuteSubjectProfile()
        {
            CreateMap<Sca.Data.Entities.BoardMinuteSubject, Sca.Domain.Models.BoardMinuteSubjectReadModel>();
            CreateMap<Sca.Domain.Models.BoardMinuteSubjectCreateModel, Sca.Data.Entities.BoardMinuteSubject>();
            CreateMap<Sca.Domain.Models.BoardMinuteSubjectUpdateModel, Sca.Data.Entities.BoardMinuteSubject>();
        }

    }
}
