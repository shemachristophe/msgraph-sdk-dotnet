// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EnumType.cs.tt


namespace Microsoft.Graph
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// The enum ExternalAudienceScope.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ExternalAudienceScope
    {
    
        /// <summary>
        /// None
        /// </summary>
        None = 0,
	
        /// <summary>
        /// Contacts Only
        /// </summary>
        ContactsOnly = 1,
	
        /// <summary>
        /// All
        /// </summary>
        All = 2,
	
    }
}
