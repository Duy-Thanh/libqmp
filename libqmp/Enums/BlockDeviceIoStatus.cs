using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace libqmp.Enums
{
    /// <summary>
    /// BlockDeviceIoStatus (Since: 1.0)
    /// An enumeration of block device I/O status.
    /// </summary>
    public enum BlockDeviceIoStatus : byte
    {
        /// <summary>
        /// The last I/O operation has succeeded
        /// </summary>
        [JsonPropertyName("ok")]
        Ok,

        /// <summary>
        /// The last I/O operation has failed
        /// </summary>
        [JsonPropertyName("failed")]
        Failed,

        /// <summary>
        /// The last I/O operation has failed due to a no-space condition
        /// </summary>
        [JsonPropertyName("nospace")]
        Nospace,
    }
}
