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
    /// The type Booking Customer.
    /// </summary>
    public partial class BookingCustomer : BookingCustomerBase
    {
    
        ///<summary>
        /// The BookingCustomer constructor
        ///</summary>
        public BookingCustomer()
        {
            this.ODataType = "microsoft.graph.bookingCustomer";
        }

        /// <summary>
        /// Gets or sets addresses.
        /// Addresses associated with the customer, including home, business and other addresses.
        /// </summary>
        [JsonPropertyName("addresses")]
        public IEnumerable<PhysicalAddress> Addresses { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// The display name is suitable for human-readable interfaces.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets email address.
        /// The SMTP address of the customer.
        /// </summary>
        [JsonPropertyName("emailAddress")]
        public string EmailAddress { get; set; }
    
        /// <summary>
        /// Gets or sets phones.
        /// Phone numbers associated with the customer, including home, business and mobile numbers.
        /// </summary>
        [JsonPropertyName("phones")]
        public IEnumerable<Phone> Phones { get; set; }
    
    }
}

