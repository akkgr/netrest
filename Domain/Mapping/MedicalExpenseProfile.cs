using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class MedicalExpenseProfile
        : AutoMapper.Profile
    {
        public MedicalExpenseProfile()
        {
            CreateMap<Sca.Data.Entities.MedicalExpense, Sca.Domain.Models.MedicalExpenseReadModel>();
            CreateMap<Sca.Domain.Models.MedicalExpenseCreateModel, Sca.Data.Entities.MedicalExpense>();
            CreateMap<Sca.Domain.Models.MedicalExpenseUpdateModel, Sca.Data.Entities.MedicalExpense>();
        }

    }
}
