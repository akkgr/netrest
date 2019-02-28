using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class FileDataProfile
        : AutoMapper.Profile
    {
        public FileDataProfile()
        {
            CreateMap<Sca.Data.Entities.FileData, Sca.Domain.Models.FileDataReadModel>();
            CreateMap<Sca.Domain.Models.FileDataCreateModel, Sca.Data.Entities.FileData>();
            CreateMap<Sca.Domain.Models.FileDataUpdateModel, Sca.Data.Entities.FileData>();
        }

    }
}
