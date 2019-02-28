using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class FlowChartProfile
        : AutoMapper.Profile
    {
        public FlowChartProfile()
        {
            CreateMap<Sca.Data.Entities.FlowChart, Sca.Domain.Models.FlowChartReadModel>();
            CreateMap<Sca.Domain.Models.FlowChartCreateModel, Sca.Data.Entities.FlowChart>();
            CreateMap<Sca.Domain.Models.FlowChartUpdateModel, Sca.Data.Entities.FlowChart>();
        }

    }
}
