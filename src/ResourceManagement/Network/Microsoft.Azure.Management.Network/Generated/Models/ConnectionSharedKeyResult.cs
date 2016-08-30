// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Response for CheckConnectionSharedKey Api service call
    /// </summary>
    public partial class ConnectionSharedKeyResult
    {
        /// <summary>
        /// Initializes a new instance of the ConnectionSharedKeyResult class.
        /// </summary>
        public ConnectionSharedKeyResult() { }

        /// <summary>
        /// Initializes a new instance of the ConnectionSharedKeyResult class.
        /// </summary>
        public ConnectionSharedKeyResult(string value = default(string))
        {
            Value = value;
        }

        /// <summary>
        /// The virtual network connection shared key value
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

    }
}
