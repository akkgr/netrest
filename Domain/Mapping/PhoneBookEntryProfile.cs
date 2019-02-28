using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class PhoneBookEntryProfile
        : AutoMapper.Profile
    {
        public PhoneBookEntryProfile()
        {
            CreateMap<Sca.Data.Entities.PhoneBookEntry, Sca.Domain.Models.PhoneBookEntryReadModel>();
            CreateMap<Sca.Domain.Models.PhoneBookEntryCreateModel, Sca.Data.Entities.PhoneBookEntry>();
            CreateMap<Sca.Domain.Models.PhoneBookEntryUpdateModel, Sca.Data.Entities.PhoneBookEntry>();
        }

    }
}
