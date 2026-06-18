using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace libqmp.Enums
{
    /// <summary>
    /// BlockdevDetectZeroesOptions (Since: 2.1)
    /// Describes the operation mode for the automatic 
    /// conversion of plain zero writes by the OS to 
    /// driver specific optimized zero write commands.
    /// </summary>
    public enum BlockdevDetectZeroesOptions : byte
    {
        /// <summary>
        /// Disabled (default)
        /// </summary>
        [JsonPropertyName("off")]
        Off,

        /// <summary>
        /// Enabled
        /// </summary>
        [JsonPropertyName("on")]
        On,

        /// <summary>
        /// Enabled and even try to unmap blocks if possible. 
        /// This requires also that BlockdevDiscardOptions is 
        /// set to unmap for this device.
        /// </summary>
        [JsonPropertyName("unmap")]
        Unmap,
    }
}
