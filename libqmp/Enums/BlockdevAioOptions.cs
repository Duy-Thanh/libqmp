using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace libqmp.Enums
{
    /// <summary>
    /// BlockdevAioOptions (Since: 2.9)
    /// Selects the AIO backend to handle I/O requests
    /// </summary>
    public enum BlockdevAioOptions : byte
    {
        /// <summary>
        /// Use QEMU’s thread pool
        /// </summary>
        [JsonPropertyName("threads")]
        Threads,

        /// <summary>
        /// Use native AIO backend (only Linux and Windows)
        /// </summary>
        [JsonPropertyName("native")]
        Native,

        /// <summary>
        /// Use linux io_uring (since 5.0)
        /// </summary>
        [JsonPropertyName("io_uring")]
        Io_uring,
    }
}
