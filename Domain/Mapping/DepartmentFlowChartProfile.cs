using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class DepartmentFlowChartProfile
        : AutoMapper.Profile
    {
        public DepartmentFlowChartProfile()
        {
            CreateMap<Sca.Data.Entities.DepartmentFlowChart, Sca.Domain.Models.DepartmentFlowChartReadModel>();
            CreateMap<Sca.Domain.Models.DepartmentFlowChartCreateModel, Sca.Data.Entities.DepartmentFlowChart>();
            CreateMap<Sca.Domain.Models.DepartmentFlowChartUpdateModel, Sca.Data.Entities.DepartmentFlowChart>();
        }

    }
}
