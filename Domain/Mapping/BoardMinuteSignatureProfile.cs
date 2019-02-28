using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class BoardMinuteSignatureProfile
        : AutoMapper.Profile
    {
        public BoardMinuteSignatureProfile()
        {
            CreateMap<Sca.Data.Entities.BoardMinuteSignature, Sca.Domain.Models.BoardMinuteSignatureReadModel>();
            CreateMap<Sca.Domain.Models.BoardMinuteSignatureCreateModel, Sca.Data.Entities.BoardMinuteSignature>();
            CreateMap<Sca.Domain.Models.BoardMinuteSignatureUpdateModel, Sca.Data.Entities.BoardMinuteSignature>();
        }

    }
}
