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
    /// The type IntuneBrand.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<IntuneBrand>))]
    public partial class IntuneBrand
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IntuneBrand"/> class.
        /// </summary>
        public IntuneBrand()
        {
            this.ODataType = "microsoft.graph.intuneBrand";
        }

        /// <summary>
        /// Gets or sets contactITEmailAddress.
        /// Email address of the person/organization responsible for IT support.
        /// </summary>
        [JsonPropertyName("contactITEmailAddress")]
        public string ContactITEmailAddress { get; set; }
    
        /// <summary>
        /// Gets or sets contactITName.
        /// Name of the person/organization responsible for IT support.
        /// </summary>
        [JsonPropertyName("contactITName")]
        public string ContactITName { get; set; }
    
        /// <summary>
        /// Gets or sets contactITNotes.
        /// Text comments regarding the person/organization responsible for IT support.
        /// </summary>
        [JsonPropertyName("contactITNotes")]
        public string ContactITNotes { get; set; }
    
        /// <summary>
        /// Gets or sets contactITPhoneNumber.
        /// Phone number of the person/organization responsible for IT support.
        /// </summary>
        [JsonPropertyName("contactITPhoneNumber")]
        public string ContactITPhoneNumber { get; set; }
    
        /// <summary>
        /// Gets or sets darkBackgroundLogo.
        /// Logo image displayed in Company Portal apps which have a dark background behind the logo.
        /// </summary>
        [JsonPropertyName("darkBackgroundLogo")]
        public MimeContent DarkBackgroundLogo { get; set; }
    
        /// <summary>
        /// Gets or sets displayName.
        /// Company/organization name that is displayed to end users.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets lightBackgroundLogo.
        /// Logo image displayed in Company Portal apps which have a light background behind the logo.
        /// </summary>
        [JsonPropertyName("lightBackgroundLogo")]
        public MimeContent LightBackgroundLogo { get; set; }
    
        /// <summary>
        /// Gets or sets onlineSupportSiteName.
        /// Display name of the company/organization’s IT helpdesk site.
        /// </summary>
        [JsonPropertyName("onlineSupportSiteName")]
        public string OnlineSupportSiteName { get; set; }
    
        /// <summary>
        /// Gets or sets onlineSupportSiteUrl.
        /// URL to the company/organization’s IT helpdesk site.
        /// </summary>
        [JsonPropertyName("onlineSupportSiteUrl")]
        public string OnlineSupportSiteUrl { get; set; }
    
        /// <summary>
        /// Gets or sets privacyUrl.
        /// URL to the company/organization’s privacy policy.
        /// </summary>
        [JsonPropertyName("privacyUrl")]
        public string PrivacyUrl { get; set; }
    
        /// <summary>
        /// Gets or sets showDisplayNameNextToLogo.
        /// Boolean that represents whether the administrator-supplied display name will be shown next to the logo image.
        /// </summary>
        [JsonPropertyName("showDisplayNameNextToLogo")]
        public bool? ShowDisplayNameNextToLogo { get; set; }
    
        /// <summary>
        /// Gets or sets showLogo.
        /// Boolean that represents whether the administrator-supplied logo images are shown or not shown.
        /// </summary>
        [JsonPropertyName("showLogo")]
        public bool? ShowLogo { get; set; }
    
        /// <summary>
        /// Gets or sets showNameNextToLogo.
        /// Boolean that represents whether the administrator-supplied display name will be shown next to the logo image.
        /// </summary>
        [JsonPropertyName("showNameNextToLogo")]
        public bool? ShowNameNextToLogo { get; set; }
    
        /// <summary>
        /// Gets or sets themeColor.
        /// Primary theme color used in the Company Portal applications and web portal.
        /// </summary>
        [JsonPropertyName("themeColor")]
        public RgbColor ThemeColor { get; set; }
    
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
