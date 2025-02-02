// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.CognitiveServices;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    /// <summary> A list of private endpoint connections. </summary>
    internal partial class CognitiveServicesPrivateEndpointConnectionListResult
    {
        /// <summary> Initializes a new instance of <see cref="CognitiveServicesPrivateEndpointConnectionListResult"/>. </summary>
        internal CognitiveServicesPrivateEndpointConnectionListResult()
        {
            Value = new ChangeTrackingList<CognitiveServicesPrivateEndpointConnectionData>();
        }

        /// <summary> Initializes a new instance of <see cref="CognitiveServicesPrivateEndpointConnectionListResult"/>. </summary>
        /// <param name="value"> Array of private endpoint connections. </param>
        internal CognitiveServicesPrivateEndpointConnectionListResult(IReadOnlyList<CognitiveServicesPrivateEndpointConnectionData> value)
        {
            Value = value;
        }

        /// <summary> Array of private endpoint connections. </summary>
        public IReadOnlyList<CognitiveServicesPrivateEndpointConnectionData> Value { get; }
    }
}
