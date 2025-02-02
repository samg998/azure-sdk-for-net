// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> The storageSpaces resource patch definition. </summary>
    public partial class StorageSpacePatch
    {
        /// <summary> Initializes a new instance of <see cref="StorageSpacePatch"/>. </summary>
        public StorageSpacePatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="StorageSpacePatch"/>. </summary>
        /// <param name="tags"> Resource tags. </param>
        internal StorageSpacePatch(IDictionary<string, string> tags)
        {
            Tags = tags;
        }

        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
