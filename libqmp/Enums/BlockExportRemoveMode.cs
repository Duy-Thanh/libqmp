using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace libqmp.Enums
{
    /// <summary>
    /// BlockExportRemoveMode (Since: 2.12)
    /// Mode for removing a block export
    /// </summary>
    public enum BlockExportRemoveMode : byte
    {
        /// <summary>
        /// Remove export if there are no existing connections, fail otherwise.
        /// </summary>
        [JsonPropertyName("safe")]
        Safe,

        /// <summary>
        /// Drop all connections immediately and remove export
        /// </summary>
        [JsonPropertyName("hard")]
        Hard,
    }
}
