using System;

namespace Sca.Definitions
{
    public interface ITrackConcurrency
    {
        Byte[] RowVersion { get; set; }
    }
}