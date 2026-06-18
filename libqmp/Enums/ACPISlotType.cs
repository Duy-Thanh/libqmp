using System.Text.Json.Serialization;

namespace libqmp.Enums
{
    /// <summary>
    /// Enum: ACPISlotType
    /// </summary>
    public enum ACPISlotType : byte
    {
        /// <summary>
        /// memory slot
        /// </summary>
        [JsonPropertyName("DIMM")]
        DIMM,

        /// <summary>
        /// logical CPU slot (since 2.7)
        /// </summary>
        [JsonPropertyName("CPU")]
        CPU,
    }
}
