// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Bitlocker.
    /// </summary>
    public partial class Bitlocker : Entity
    {
    
        /// <summary>
        /// Gets or sets recovery keys.
        /// The recovery keys associated with the bitlocker entity.
        /// </summary>
        [JsonPropertyName("recoveryKeys")]
        public IBitlockerRecoveryKeysCollectionPage RecoveryKeys { get; set; }

        /// <summary>
        /// Gets or sets recoveryKeysNextLink.
        /// </summary>
        [JsonPropertyName("recoveryKeys@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string RecoveryKeysNextLink { get; set; }
    
    }
}

