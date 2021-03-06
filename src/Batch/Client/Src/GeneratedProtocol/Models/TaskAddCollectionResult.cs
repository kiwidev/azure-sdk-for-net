// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Response to a TaskOperations.AddCollection request.
    /// </summary>
    public partial class TaskAddCollectionResult
    {
        /// <summary>
        /// Initializes a new instance of the TaskAddCollectionResult class.
        /// </summary>
        public TaskAddCollectionResult() { }

        /// <summary>
        /// Initializes a new instance of the TaskAddCollectionResult class.
        /// </summary>
        /// <param name="value">The results of the add task collection operation.</param>
        public TaskAddCollectionResult(IList<TaskAddResult> value = default(IList<TaskAddResult>))
        {
            Value = value;
        }

        /// <summary>
        /// Gets or sets the results of the add task collection operation.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<TaskAddResult> Value { get; set; }

    }
}
