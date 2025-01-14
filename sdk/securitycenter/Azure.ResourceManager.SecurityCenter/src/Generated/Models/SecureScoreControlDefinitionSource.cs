// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The type of the security control (For example, BuiltIn). </summary>
    internal partial class SecureScoreControlDefinitionSource
    {
        /// <summary> Initializes a new instance of <see cref="SecureScoreControlDefinitionSource"/>. </summary>
        internal SecureScoreControlDefinitionSource()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SecureScoreControlDefinitionSource"/>. </summary>
        /// <param name="sourceType"> The type of security control (for example, BuiltIn). </param>
        internal SecureScoreControlDefinitionSource(SecurityControlType? sourceType)
        {
            SourceType = sourceType;
        }

        /// <summary> The type of security control (for example, BuiltIn). </summary>
        public SecurityControlType? SourceType { get; }
    }
}
