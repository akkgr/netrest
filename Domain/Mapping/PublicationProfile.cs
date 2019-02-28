using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class PublicationProfile
        : AutoMapper.Profile
    {
        public PublicationProfile()
        {
            CreateMap<Sca.Data.Entities.Publication, Sca.Domain.Models.PublicationReadModel>();
            CreateMap<Sca.Domain.Models.PublicationCreateModel, Sca.Data.Entities.Publication>();
            CreateMap<Sca.Domain.Models.PublicationUpdateModel, Sca.Data.Entities.Publication>();
        }

    }
}
