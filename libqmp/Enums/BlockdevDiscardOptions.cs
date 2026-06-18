using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace libqmp.Enums
{
    /// <summary>
    /// BlockdevDiscardOptions (Since: 2.9)
    /// Determines how to handle discard requests.
    /// </summary>
    public enum BlockdevDiscardOptions : byte
    {
        /// <summary>
        /// Ignore the request
        /// </summary>
        [JsonPropertyName("ignore")]
        Ignore,

        /// <summary>
        /// Forward as an unmap request
        /// </summary>
        [JsonPropertyName("unmap")]
        Unmap,
    }
}
