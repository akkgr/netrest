using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class FileLinkProfile
        : AutoMapper.Profile
    {
        public FileLinkProfile()
        {
            CreateMap<Sca.Data.Entities.FileLink, Sca.Domain.Models.FileLinkReadModel>();
            CreateMap<Sca.Domain.Models.FileLinkCreateModel, Sca.Data.Entities.FileLink>();
            CreateMap<Sca.Domain.Models.FileLinkUpdateModel, Sca.Data.Entities.FileLink>();
        }

    }
}
