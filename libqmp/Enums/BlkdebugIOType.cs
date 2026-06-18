using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace libqmp.Enums
{
    /// <summary>
    /// BlkdebugIOType (Since: 4.1)
    /// Kinds of I/O that blkdebug can inject errors in.
    /// </summary>
    public enum BlkdebugIOType : byte
    {
        /// <summary>
        /// .bdrv_co_preadv()
        /// </summary>
        [JsonPropertyName("read")]
        Read,

        /// <summary>
        /// .bdrv_co_pwritev()
        /// </summary>
        [JsonPropertyName("write")]
        Write,

        /// <summary>
        /// .bdrv_co_pwrite_zeroes()
        /// </summary>
        [JsonPropertyName("write-zeroes")]
        Writezeroes,

        /// <summary>
        /// .bdrv_co_pdiscard()
        /// </summary>
        [JsonPropertyName("discard")]
        Discard,

        /// <summary>
        /// .bdrv_co_flush_to_disk()
        /// </summary>
        [JsonPropertyName("flush")]
        Flush,

        /// <summary>
        /// .bdrv_co_block_status()
        /// </summary>
        [JsonPropertyName("block-status")]
        Blockstatus,
    }
}
