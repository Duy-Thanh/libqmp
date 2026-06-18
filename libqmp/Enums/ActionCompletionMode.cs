using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace libqmp.Enums
{
    /// <summary>
    /// ActionCompletionMode (Since: 2.5)
    /// An enumeration of transactional completion modes.
    /// </summary>
    public enum ActionCompletionMode : byte
    {
        /// <summary>
        /// Do not attempt to cancel any other Actions if any Actions fail after the Transaction request succeeds. 
        /// All Actions that can complete successfully will do so without waiting on others. This is the default
        /// </summary>
        [JsonPropertyName("individual")]
        Individual,

        /// <summary>
        /// If any Action fails after the Transaction succeeds, cancel all Actions. Actions do not complete until
        /// all Actions are ready to complete. May be rejected by Actions that do not support this completion mode.
        /// </summary>
        [JsonPropertyName("grouped")]
        Grouped
    }
}
