﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Text.Json.Serialization;

namespace Microsoft.Toolkit.Services.Twitter
{
    /// <summary>
    /// Twitter Media Sizes containing size data for different image sizes.
    /// </summary>
    public class TwitterMediaSizes
    {
        /// <summary>
        /// Gets or sets small metadata.
        /// </summary>
        [JsonPropertyName("small")]
        public TwitterMediaSizeData Small { get; set; }

        /// <summary>
        /// Gets or sets thumbnail metadata.
        /// </summary>
        [JsonPropertyName("thumb")]
        public TwitterMediaSizeData Thumb { get; set; }

        /// <summary>
        /// Gets or sets large metadata.
        /// </summary>
        [JsonPropertyName("large")]
        public TwitterMediaSizeData Large { get; set; }

        /// <summary>
        /// Gets or sets medium metadata.
        /// </summary>
        [JsonPropertyName("medium")]
        public TwitterMediaSizeData Medium { get; set; }
    }
}
