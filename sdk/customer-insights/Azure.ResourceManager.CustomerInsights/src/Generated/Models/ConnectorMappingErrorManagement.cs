// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.CustomerInsights.Models
{
    /// <summary> The error management. </summary>
    public partial class ConnectorMappingErrorManagement
    {
        /// <summary> Initializes a new instance of <see cref="ConnectorMappingErrorManagement"/>. </summary>
        /// <param name="errorManagementType"> The type of error management to use for the mapping. </param>
        public ConnectorMappingErrorManagement(ErrorManagementType errorManagementType)
        {
            ErrorManagementType = errorManagementType;
        }

        /// <summary> Initializes a new instance of <see cref="ConnectorMappingErrorManagement"/>. </summary>
        /// <param name="errorManagementType"> The type of error management to use for the mapping. </param>
        /// <param name="errorLimit"> The error limit allowed while importing data. </param>
        internal ConnectorMappingErrorManagement(ErrorManagementType errorManagementType, int? errorLimit)
        {
            ErrorManagementType = errorManagementType;
            ErrorLimit = errorLimit;
        }

        /// <summary> The type of error management to use for the mapping. </summary>
        public ErrorManagementType ErrorManagementType { get; set; }
        /// <summary> The error limit allowed while importing data. </summary>
        public int? ErrorLimit { get; set; }
    }
}
