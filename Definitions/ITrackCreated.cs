using System;

namespace Sca.Definitions
{
    public interface ITrackCreated
    {
        DateTimeOffset Created { get; set; }
        string CreatedBy { get; set; }
    }
}