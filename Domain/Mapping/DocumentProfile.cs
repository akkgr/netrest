using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class DocumentProfile
        : AutoMapper.Profile
    {
        public DocumentProfile()
        {
            CreateMap<Sca.Data.Entities.Document, Sca.Domain.Models.DocumentReadModel>();
            CreateMap<Sca.Domain.Models.DocumentCreateModel, Sca.Data.Entities.Document>();
            CreateMap<Sca.Domain.Models.DocumentUpdateModel, Sca.Data.Entities.Document>();
        }

    }
}
