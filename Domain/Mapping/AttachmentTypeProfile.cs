using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class AttachmentTypeProfile
        : AutoMapper.Profile
    {
        public AttachmentTypeProfile()
        {
            CreateMap<Sca.Data.Entities.AttachmentType, Sca.Domain.Models.AttachmentTypeReadModel>();
            CreateMap<Sca.Domain.Models.AttachmentTypeCreateModel, Sca.Data.Entities.AttachmentType>();
            CreateMap<Sca.Domain.Models.AttachmentTypeUpdateModel, Sca.Data.Entities.AttachmentType>();
        }

    }
}
