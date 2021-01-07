// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type UpdateWindowsDeviceAccountActionParameter.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<UpdateWindowsDeviceAccountActionParameter>))]
    public partial class UpdateWindowsDeviceAccountActionParameter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateWindowsDeviceAccountActionParameter"/> class.
        /// </summary>
        public UpdateWindowsDeviceAccountActionParameter()
        {
            this.ODataType = "microsoft.graph.updateWindowsDeviceAccountActionParameter";
        }

        /// <summary>
        /// Gets or sets calendarSyncEnabled.
        /// Not yet documented
        /// </summary>
        [JsonPropertyName("calendarSyncEnabled")]
        public bool? CalendarSyncEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets deviceAccount.
        /// Not yet documented
        /// </summary>
        [JsonPropertyName("deviceAccount")]
        public WindowsDeviceAccount DeviceAccount { get; set; }
    
        /// <summary>
        /// Gets or sets deviceAccountEmail.
        /// Not yet documented
        /// </summary>
        [JsonPropertyName("deviceAccountEmail")]
        public string DeviceAccountEmail { get; set; }
    
        /// <summary>
        /// Gets or sets exchangeServer.
        /// Not yet documented
        /// </summary>
        [JsonPropertyName("exchangeServer")]
        public string ExchangeServer { get; set; }
    
        /// <summary>
        /// Gets or sets passwordRotationEnabled.
        /// Not yet documented
        /// </summary>
        [JsonPropertyName("passwordRotationEnabled")]
        public bool? PasswordRotationEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets sessionInitiationProtocalAddress.
        /// Not yet documented
        /// </summary>
        [JsonPropertyName("sessionInitiationProtocalAddress")]
        public string SessionInitiationProtocalAddress { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}
