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
    /// The type MediaContentRatingIreland.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<MediaContentRatingIreland>))]
    public partial class MediaContentRatingIreland
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaContentRatingIreland"/> class.
        /// </summary>
        public MediaContentRatingIreland()
        {
            this.ODataType = "microsoft.graph.mediaContentRatingIreland";
        }

        /// <summary>
        /// Gets or sets movieRating.
        /// Movies rating selected for Ireland. Possible values are: allAllowed, allBlocked, general, parentalGuidance, agesAbove12, agesAbove15, agesAbove16, adults.
        /// </summary>
        [JsonPropertyName("movieRating")]
        public RatingIrelandMoviesType? MovieRating { get; set; }
    
        /// <summary>
        /// Gets or sets tvRating.
        /// TV rating selected for Ireland. Possible values are: allAllowed, allBlocked, general, children, youngAdults, parentalSupervision, mature.
        /// </summary>
        [JsonPropertyName("tvRating")]
        public RatingIrelandTelevisionType? TvRating { get; set; }
    
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
