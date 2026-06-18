using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace libqmp.Enums
{
    /// <summary>
    /// BlockdevChangeReadOnlyMode (Since: 2.3)
    /// Specifies the new read-only mode of a block device subject 
    /// to the blockdev-change-medium command.
    /// </summary>
    public enum BlockdevChangeReadOnlyMode : byte
    {
        /// <summary>
        /// Retains the current read-only mode
        /// </summary>
        [JsonPropertyName("retain")]
        Retain,

        /// <summary>
        /// Makes the device read-only
        /// </summary>
        [JsonPropertyName("read-only")]
        ReadOnly,

        /// <summary>
        /// Makes the device writable
        /// </summary>
        [JsonPropertyName("read-write")]
        ReadWrite,
    }
}
