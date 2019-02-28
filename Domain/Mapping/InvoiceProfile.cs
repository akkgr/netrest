using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class InvoiceProfile
        : AutoMapper.Profile
    {
        public InvoiceProfile()
        {
            CreateMap<Sca.Data.Entities.Invoice, Sca.Domain.Models.InvoiceReadModel>();
            CreateMap<Sca.Domain.Models.InvoiceCreateModel, Sca.Data.Entities.Invoice>();
            CreateMap<Sca.Domain.Models.InvoiceUpdateModel, Sca.Data.Entities.Invoice>();
        }

    }
}
