using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class PaymentTypeProfile
        : AutoMapper.Profile
    {
        public PaymentTypeProfile()
        {
            CreateMap<Sca.Data.Entities.PaymentType, Sca.Domain.Models.PaymentTypeReadModel>();
            CreateMap<Sca.Domain.Models.PaymentTypeCreateModel, Sca.Data.Entities.PaymentType>();
            CreateMap<Sca.Domain.Models.PaymentTypeUpdateModel, Sca.Data.Entities.PaymentType>();
        }

    }
}
