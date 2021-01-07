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
    /// The type WindowsUpdateScheduledInstall.
    /// </summary>
    
    public partial class WindowsUpdateScheduledInstall : WindowsUpdateInstallScheduleType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WindowsUpdateScheduledInstall"/> class.
        /// </summary>
        public WindowsUpdateScheduledInstall()
        {
            this.ODataType = "microsoft.graph.windowsUpdateScheduledInstall";
        }

        /// <summary>
        /// Gets or sets scheduledInstallDay.
        /// Scheduled Install Day in week. Possible values are: userDefined, everyday, sunday, monday, tuesday, wednesday, thursday, friday, saturday.
        /// </summary>
        [JsonPropertyName("scheduledInstallDay")]
        public WeeklySchedule? ScheduledInstallDay { get; set; }
    
        /// <summary>
        /// Gets or sets scheduledInstallTime.
        /// Scheduled Install Time during day
        /// </summary>
        [JsonPropertyName("scheduledInstallTime")]
        public TimeOfDay ScheduledInstallTime { get; set; }
    
    }
}
