// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Graph.RBAC.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Request parameters for create a new service principal
    /// </summary>
    public partial class ServicePrincipalCreateParameters
    {
        /// <summary>
        /// Initializes a new instance of the ServicePrincipalCreateParameters
        /// class.
        /// </summary>
        public ServicePrincipalCreateParameters() { }

        /// <summary>
        /// Initializes a new instance of the ServicePrincipalCreateParameters
        /// class.
        /// </summary>
        /// <param name="appId">Gets or sets application Id</param>
        /// <param name="accountEnabled">Specifies if the account is enabled</param>
        public ServicePrincipalCreateParameters(string appId, bool accountEnabled)
        {
            AppId = appId;
            AccountEnabled = accountEnabled;
        }

        /// <summary>
        /// Gets or sets gets or sets application Id
        /// </summary>
        [JsonProperty(PropertyName = "appId")]
        public string AppId { get; set; }

        /// <summary>
        /// Gets or sets specifies if the account is enabled
        /// </summary>
        [JsonProperty(PropertyName = "accountEnabled")]
        public bool AccountEnabled { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (AppId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AppId");
            }
        }
    }
}
