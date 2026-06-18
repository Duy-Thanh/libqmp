using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace libqmp.Enums
{
    /// <summary>
    /// BlockExportType (Since: 4.2)
    /// An enumeration of block export types
    /// </summary>
    public enum BlockExportType : byte
    {
        /// <summary>
        /// NBD export
        /// </summary>
        [JsonPropertyName("nbd")]
        Nbd,

        /// <summary>
        /// vhost-user-blk export (since 5.2)
        /// </summary>
        [JsonPropertyName("vhost-user-blk")]
        VhostUserBlk,

        /// <summary>
        /// FUSE export (since: 6.0)
        /// </summary>
        [JsonPropertyName("fuse")]
        Fuse,

        /// <summary>
        /// vduse-blk export (since 7.1)
        /// </summary>
        [JsonPropertyName("vduse-blk")]
        VduseBlk,
    }
}
