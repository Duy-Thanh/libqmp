using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace libqmp.Enums
{
    /// <summary>
    /// AFXDPMode (Since: 8.2)
    /// Availability: CONFIG_AF_XDP
    /// Attach mode for a default XDP program
    /// </summary>
    public enum AFXDPMode : byte
    {
        /// <summary>
        /// generic mode, no driver support necessary
        /// </summary>
        [JsonPropertyName("skb")]
        Skb,

        /// <summary>
        /// DRV mode, program is attached to a driver, packets are passed to the socket without allocation of skb
        /// </summary>
        [JsonPropertyName("native")]
        Native
    }
}
