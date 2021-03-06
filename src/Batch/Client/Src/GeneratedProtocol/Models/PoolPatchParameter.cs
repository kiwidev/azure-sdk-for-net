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
    /// Parameters for a CloudPoolOperations.Patch request.
    /// </summary>
    public partial class PoolPatchParameter
    {
        /// <summary>
        /// Initializes a new instance of the PoolPatchParameter class.
        /// </summary>
        public PoolPatchParameter() { }

        /// <summary>
        /// Initializes a new instance of the PoolPatchParameter class.
        /// </summary>
        /// <param name="startTask">A task to run on each compute node as it joins the pool.</param>
        /// <param name="certificateReferences">A list of certificates to be installed on each compute node in the pool.</param>
        /// <param name="applicationPackageReferences">A list of application packages to be installed on each compute node in the pool.</param>
        /// <param name="metadata">A list of name-value pairs associated with the pool as metadata.</param>
        public PoolPatchParameter(StartTask startTask = default(StartTask), IList<CertificateReference> certificateReferences = default(IList<CertificateReference>), IList<ApplicationPackageReference> applicationPackageReferences = default(IList<ApplicationPackageReference>), IList<MetadataItem> metadata = default(IList<MetadataItem>))
        {
            StartTask = startTask;
            CertificateReferences = certificateReferences;
            ApplicationPackageReferences = applicationPackageReferences;
            Metadata = metadata;
        }

        /// <summary>
        /// Gets or sets a task to run on each compute node as it joins the
        /// pool.
        /// </summary>
        /// <remarks>
        /// If omitted, any existing start task is left unchanged.
        /// </remarks>
        [JsonProperty(PropertyName = "startTask")]
        public StartTask StartTask { get; set; }

        /// <summary>
        /// Gets or sets a list of certificates to be installed on each
        /// compute node in the pool.
        /// </summary>
        /// <remarks>
        /// If omitted, any existing certificate references are left unchanged.
        /// </remarks>
        [JsonProperty(PropertyName = "certificateReferences")]
        public IList<CertificateReference> CertificateReferences { get; set; }

        /// <summary>
        /// Gets or sets a list of application packages to be installed on
        /// each compute node in the pool.
        /// </summary>
        /// <remarks>
        /// If omitted, any existing application package references are left
        /// unchanged.
        /// </remarks>
        [JsonProperty(PropertyName = "applicationPackageReferences")]
        public IList<ApplicationPackageReference> ApplicationPackageReferences { get; set; }

        /// <summary>
        /// Gets or sets a list of name-value pairs associated with the pool
        /// as metadata.
        /// </summary>
        /// <remarks>
        /// If omitted, any existing metadata is left unchanged.
        /// </remarks>
        [JsonProperty(PropertyName = "metadata")]
        public IList<MetadataItem> Metadata { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.StartTask != null)
            {
                this.StartTask.Validate();
            }
            if (this.CertificateReferences != null)
            {
                foreach (var element in this.CertificateReferences)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (this.ApplicationPackageReferences != null)
            {
                foreach (var element1 in this.ApplicationPackageReferences)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
            if (this.Metadata != null)
            {
                foreach (var element2 in this.Metadata)
                {
                    if (element2 != null)
                    {
                        element2.Validate();
                    }
                }
            }
        }
    }
}
