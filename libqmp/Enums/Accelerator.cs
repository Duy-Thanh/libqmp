using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace libqmp.Enums
{
    /// <summary>
    /// Accelerator (Since: 10.2.0)
    /// Information about support for MSHV acceleration
    /// </summary>
    public enum Accelerator : byte
    {
        /// <summary>
        /// Apple Hypervisor.framework
        /// </summary>
        [JsonPropertyName("hvf")]
        Hvf,

        /// <summary>
        /// KVM
        /// </summary>
        [JsonPropertyName("kvm")]
        Kvm,

        /// <summary>
        /// Hyper-V
        /// </summary>
        [JsonPropertyName("mshv")]
        Mshv,

        /// <summary>
        /// NetBSD NVMM
        /// </summary>
        [JsonPropertyName("nvmm")]
        Nvmm,

        /// <summary>
        /// QTest (dummy accelerator)
        /// </summary>
        [JsonPropertyName("qtest")]
        Qtest,

        /// <summary>
        /// TCG (dynamic translation)
        /// </summary>
        [JsonPropertyName("tcg")]
        Tcg,

        /// <summary>
        /// Windows Hypervisor Platform
        /// </summary>
        [JsonPropertyName("whpx")]
        Whpx,

        /// <summary>
        /// Xen
        /// </summary>
        [JsonPropertyName("xen")]
        Xen,
    }
}
