using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class FlowChartStepProfile
        : AutoMapper.Profile
    {
        public FlowChartStepProfile()
        {
            CreateMap<Sca.Data.Entities.FlowChartStep, Sca.Domain.Models.FlowChartStepReadModel>();
            CreateMap<Sca.Domain.Models.FlowChartStepCreateModel, Sca.Data.Entities.FlowChartStep>();
            CreateMap<Sca.Domain.Models.FlowChartStepUpdateModel, Sca.Data.Entities.FlowChartStep>();
        }

    }
}
