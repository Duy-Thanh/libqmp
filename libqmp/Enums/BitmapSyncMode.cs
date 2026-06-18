using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace libqmp.Enums
{
    /// <summary>
    /// BitmapSyncMode (Since: 4.2)
    /// An enumeration of possible behaviors for the synchronization 
    /// of a bitmap when used for data copy operations.
    /// </summary>
    public enum BitmapSyncMode : byte
    {
        /// <summary>
        /// The bitmap is only synced when the operation is successful. 
        /// This is the behavior always used for incremental backups
        /// </summary>
        [JsonPropertyName("on-success")]
        OnSuccess,

        /// <summary>
        /// The bitmap is never synchronized with the operation, 
        /// and is treated solely as a read-only manifest of blocks to copy
        /// </summary>
        [JsonPropertyName("never")]
        Never,

        /// <summary>
        /// The bitmap is always synchronized with the operation, regardless 
        /// of whether or not the operation was successful
        /// </summary>
        [JsonPropertyName("always")]
        Always
    }
}
