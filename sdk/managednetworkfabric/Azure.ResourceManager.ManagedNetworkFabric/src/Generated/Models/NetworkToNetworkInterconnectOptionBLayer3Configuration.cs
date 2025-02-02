// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> Common properties for Layer3Configuration. </summary>
    public partial class NetworkToNetworkInterconnectOptionBLayer3Configuration : OptionBLayer3Configuration
    {
        /// <summary> Initializes a new instance of <see cref="NetworkToNetworkInterconnectOptionBLayer3Configuration"/>. </summary>
        public NetworkToNetworkInterconnectOptionBLayer3Configuration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NetworkToNetworkInterconnectOptionBLayer3Configuration"/>. </summary>
        /// <param name="primaryIPv4Prefix"> IPv4 Address Prefix. </param>
        /// <param name="primaryIPv6Prefix"> IPv6 Address Prefix. </param>
        /// <param name="secondaryIPv4Prefix"> Secondary IPv4 Address Prefix. </param>
        /// <param name="secondaryIPv6Prefix"> Secondary IPv6 Address Prefix. </param>
        /// <param name="peerAsn"> ASN of PE devices for CE/PE connectivity.Example : 28. </param>
        /// <param name="vlanId"> VLAN for CE/PE Layer 3 connectivity.Example : 501. </param>
        /// <param name="fabricAsn"> ASN of CE devices for CE/PE connectivity. </param>
        internal NetworkToNetworkInterconnectOptionBLayer3Configuration(string primaryIPv4Prefix, string primaryIPv6Prefix, string secondaryIPv4Prefix, string secondaryIPv6Prefix, long? peerAsn, int? vlanId, long? fabricAsn) : base(primaryIPv4Prefix, primaryIPv6Prefix, secondaryIPv4Prefix, secondaryIPv6Prefix, peerAsn, vlanId, fabricAsn)
        {
        }
    }
}
