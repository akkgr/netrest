using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class EmployeePaymentProfile
        : AutoMapper.Profile
    {
        public EmployeePaymentProfile()
        {
            CreateMap<Sca.Data.Entities.EmployeePayment, Sca.Domain.Models.EmployeePaymentReadModel>();
            CreateMap<Sca.Domain.Models.EmployeePaymentCreateModel, Sca.Data.Entities.EmployeePayment>();
            CreateMap<Sca.Domain.Models.EmployeePaymentUpdateModel, Sca.Data.Entities.EmployeePayment>();
        }

    }
}
