using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class InfoMessageRecipientProfile
        : AutoMapper.Profile
    {
        public InfoMessageRecipientProfile()
        {
            CreateMap<Sca.Data.Entities.InfoMessageRecipient, Sca.Domain.Models.InfoMessageRecipientReadModel>();
            CreateMap<Sca.Domain.Models.InfoMessageRecipientCreateModel, Sca.Data.Entities.InfoMessageRecipient>();
            CreateMap<Sca.Domain.Models.InfoMessageRecipientUpdateModel, Sca.Data.Entities.InfoMessageRecipient>();
        }

    }
}
