using System;
using Sca.Definitions;

// ReSharper disable once CheckNamespace
namespace Sca.Domain.Models
{
    public class EntityCreateModel : IHaveIdentifier, ITrackCreated, ITrackUpdated
    {
        public int Id { get; set; }

        public DateTimeOffset Created { get; set; }

        public string CreatedBy { get; set; }

        public DateTimeOffset Updated { get; set; }

        public string UpdatedBy { get; set; }
    }
}