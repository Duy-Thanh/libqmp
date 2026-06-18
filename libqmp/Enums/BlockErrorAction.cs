using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace libqmp.Enums
{
    /// <summary>
    /// BlockErrorAction (Since: 2.1)
    /// An enumeration of action that has been taken when a DISK I/O occurs
    /// </summary>
    public enum BlockErrorAction : byte
    {
        /// <summary>
        /// error has been ignored
        /// </summary>
        [JsonPropertyName("ignore")]
        Ignore,

        /// <summary>
        /// error has been reported to the device
        /// </summary>
        [JsonPropertyName("report")]
        Report,

        /// <summary>
        /// error caused VM to be stopped
        /// </summary>
        [JsonPropertyName("stop")]
        Stop,
    }
}
