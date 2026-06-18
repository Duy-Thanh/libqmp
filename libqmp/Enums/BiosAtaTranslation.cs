using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace libqmp.Enums
{
    /// <summary>
    /// BiosAtaTranslation (Since: 2.0)
    /// Policy that BIOS should use to interpret cylinder/head/sector addresses. 
    /// Note that Bochs BIOS and SeaBIOS will not actually translate logical CHS 
    /// to physical; instead, they will use logical block addressing.
    /// </summary>
    public enum BiosAtaTranslation : byte
    {
        /// <summary>
        /// If cylinder/heads/sizes are passed, choose between none and LBA depending 
        /// on the size of the disk. If they are not passed, choose none if QEMU can 
        /// guess that the disk had 16 or fewer heads, large if QEMU can guess that 
        /// the disk had 131072 or fewer tracks across all heads 
        /// (i.e. cylinders * heads less than 131072), otherwise LBA.
        /// </summary>
        [JsonPropertyName("auto")]
        Auto,

        /// <summary>
        /// The physical disk geometry is equal to the logical geometry.
        /// </summary>
        [JsonPropertyName("none")]
        None,

        /// <summary>
        /// Assume 63 sectors per track and one of 16, 32, 64, 128 or 255 
        /// heads (if fewer than 255 are enough to cover the whole disk 
        /// with 1024 cylinders/head). The number of cylinders/head is 
        /// then computed based on the number of sectors and heads.
        /// </summary>
        [JsonPropertyName("lba")]
        Lba,

        /// <summary>
        /// The number of cylinders per head is scaled down to 1024 by correspondingly 
        /// scaling up the number of heads.
        /// </summary>
        [JsonPropertyName("large")]
        Large,

        /// <summary>
        /// Same as large, but first convert a 16-head geometry to 15-head, by proportionally 
        /// scaling up the number of cylinders/head.
        /// </summary>
        [JsonPropertyName("rechs")]
        Rechs
    }
}
