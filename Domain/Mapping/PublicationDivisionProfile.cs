using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class PublicationDivisionProfile
        : AutoMapper.Profile
    {
        public PublicationDivisionProfile()
        {
            CreateMap<Sca.Data.Entities.PublicationDivision, Sca.Domain.Models.PublicationDivisionReadModel>();
            CreateMap<Sca.Domain.Models.PublicationDivisionCreateModel, Sca.Data.Entities.PublicationDivision>();
            CreateMap<Sca.Domain.Models.PublicationDivisionUpdateModel, Sca.Data.Entities.PublicationDivision>();
        }

    }
}
