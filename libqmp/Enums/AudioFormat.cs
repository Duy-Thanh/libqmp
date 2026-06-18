using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace libqmp.Enums
{
    /// <summary>
    /// AudioFormat (Since: 4.0)
    /// An enumeration of possible audio formats.
    /// </summary>
    public enum AudioFormat : byte
    {
        /// <summary>
        /// unsigned 8 bit integer
        /// </summary>
        [JsonPropertyName("u8")]
        U8,

        /// <summary>
        /// signed 8 bit integer
        /// </summary>
        [JsonPropertyName("s8")]
        S8,

        /// <summary>
        /// unsigned 16 bit integer
        /// </summary>
        [JsonPropertyName("u16")]
        U16,

        /// <summary>
        /// signed 16 bit integer
        /// </summary>
        [JsonPropertyName("s16")]
        S16,

        /// <summary>
        /// unsigned 32 bit integer
        /// </summary>
        [JsonPropertyName("u32")]
        U32,

        /// <summary>
        /// signed 32 bit integer
        /// </summary>
        [JsonPropertyName("s32")]
        S32,

        /// <summary>
        /// single precision floating-point (since 5.0)
        /// </summary>
        [JsonPropertyName("f32")]
        F32
    }
}
