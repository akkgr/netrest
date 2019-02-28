using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class InvoiceTypeProfile
        : AutoMapper.Profile
    {
        public InvoiceTypeProfile()
        {
            CreateMap<Sca.Data.Entities.InvoiceType, Sca.Domain.Models.InvoiceTypeReadModel>();
            CreateMap<Sca.Domain.Models.InvoiceTypeCreateModel, Sca.Data.Entities.InvoiceType>();
            CreateMap<Sca.Domain.Models.InvoiceTypeUpdateModel, Sca.Data.Entities.InvoiceType>();
        }

    }
}
