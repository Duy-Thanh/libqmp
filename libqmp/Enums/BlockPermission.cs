using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace libqmp.Enums
{
    /// <summary>
    /// BlockPermission (Since: 4.0)
    /// Enum of base block permissions.
    /// </summary>
    public enum BlockPermission : byte
    {
        /// <summary>
        /// A user that has the “permission” of consistent reads 
        /// is guaranteed that their view of the contents of the 
        /// block device is complete and self-consistent, representing 
        /// the contents of a disk at a specific point. For most block 
        /// devices (including their backing files) this is true, but 
        /// the property cannot be maintained in a few situations like 
        /// for intermediate nodes of a commit block job.
        /// </summary>
        [JsonPropertyName("consistent-read")]
        ConsistentRead,

        /// <summary>
        /// This permission is required to change the visible disk contents.
        /// </summary>
        [JsonPropertyName("write")]
        Write,

        /// <summary>
        /// This permission (which is weaker than BLK_PERM_WRITE) is 
        /// both enough and required for writes to the block node when 
        /// the caller promises that the visible disk content doesn’t 
        /// change. As the BLK_PERM_WRITE permission is strictly 
        /// stronger, either is sufficient to perform an unchanging write.
        /// </summary>
        [JsonPropertyName("write-unchanged")]
        WriteUnchanged,

        /// <summary>
        /// This permission is required to change the size of a block node.
        /// </summary>
        [JsonPropertyName("resize")]
        Resize,
    }
}
