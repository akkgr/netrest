using System;
using Sca.Definitions;

// ReSharper disable once CheckNamespace
namespace Sca.Domain.Models
{
    public class EntityUpdateModel : IHaveIdentifier, ITrackCreated, ITrackUpdated, ITrackConcurrency
    {
        public int Id { get; set; }

        public DateTimeOffset Created { get; set; } = DateTimeOffset.UtcNow;

        public string CreatedBy { get; set; }

        public DateTimeOffset Updated { get; set; } = DateTimeOffset.UtcNow;

        public string UpdatedBy { get; set; }

        public byte[] RowVersion { get; set; }
    }
}