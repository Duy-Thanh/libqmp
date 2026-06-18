using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace libqmp.Enums
{
    /// <summary>
    /// AudiodevDriver (Since: 4.0)
    /// An enumeration of possible audio backend drivers.
    /// </summary>
    public enum AudiodevDriver : byte
    {
        /// <summary>
        /// JACK audio backend (since 5.1)
        /// </summary>
        [JsonPropertyName("jack")]
        Jack,

        /// <summary>
        /// Not documented
        /// </summary>
        [JsonPropertyName("none")]
        None,

        /// <summary>
        /// Not documented
        /// </summary>
        [JsonPropertyName("alsa")]
        Alsa,

        /// <summary>
        /// Not documented
        /// </summary>
        [JsonPropertyName("coreaudio")]
        Coreaudio,

        /// <summary>
        /// Not documented
        /// </summary>
        [JsonPropertyName("dbus")]
        Dbus,

        /// <summary>
        /// Not documented
        /// </summary>
        [JsonPropertyName("dsound")]
        Dsound,

        /// <summary>
        /// Not documented
        /// </summary>
        [JsonPropertyName("oss")]
        Oss,

        /// <summary>
        /// Not documented
        /// </summary>
        [JsonPropertyName("pa")]
        Pa,

        /// <summary>
        /// Not documented
        /// </summary>
        [JsonPropertyName("pipewire")]
        Pipewire,

        /// <summary>
        /// Not documented
        /// </summary>
        [JsonPropertyName("sdl")]
        Sdl,

        /// <summary>
        /// Not documented
        /// </summary>
        [JsonPropertyName("sndio")]
        Sndio0,

        /// <summary>
        /// Not documented
        /// </summary>
        [JsonPropertyName("spice")]
        Spice1,

        /// <summary>
        /// Not documented
        /// </summary>
        [JsonPropertyName("wav")]
        Wav2
    }
}
