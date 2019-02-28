using System;

namespace Sca.Definitions
{
    public interface ITrackUpdated
    {
        DateTimeOffset Updated { get; set; }
        string UpdatedBy { get; set; }
    }
}