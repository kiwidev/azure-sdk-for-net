namespace Microsoft.Azure.Management.Resources.Models
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Azure;

    /// <summary>
    /// </summary>
    public partial class DeploymentOperation
    {
        /// <summary>
        /// Gets or sets full deployment operation id.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets deployment operation id.
        /// </summary>
        [JsonProperty(PropertyName = "operationId")]
        public string OperationId { get; set; }

        /// <summary>
        /// Gets or sets deployment properties.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public DeploymentOperationProperties Properties { get; set; }

        /// <summary>
        /// Validate the object. Throws ArgumentException or ArgumentNullException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (this.Properties != null)
            {
                this.Properties.Validate();
            }
        }
    }
}