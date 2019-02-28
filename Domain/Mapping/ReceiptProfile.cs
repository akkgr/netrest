using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class ReceiptProfile
        : AutoMapper.Profile
    {
        public ReceiptProfile()
        {
            CreateMap<Sca.Data.Entities.Receipt, Sca.Domain.Models.ReceiptReadModel>();
            CreateMap<Sca.Domain.Models.ReceiptCreateModel, Sca.Data.Entities.Receipt>();
            CreateMap<Sca.Domain.Models.ReceiptUpdateModel, Sca.Data.Entities.Receipt>();
        }

    }
}
