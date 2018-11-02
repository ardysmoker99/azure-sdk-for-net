// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Media.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Details of JobOutput errors.
    /// </summary>
    public partial class JobErrorDetail
    {
        /// <summary>
        /// Initializes a new instance of the JobErrorDetail class.
        /// </summary>
        public JobErrorDetail()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JobErrorDetail class.
        /// </summary>
        /// <param name="code">Code describing the error detail.</param>
        /// <param name="message">A human-readable representation of the
        /// error.</param>
        public JobErrorDetail(string code = default(string), string message = default(string))
        {
            Code = code;
            Message = message;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets code describing the error detail.
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; private set; }

        /// <summary>
        /// Gets a human-readable representation of the error.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; private set; }

    }
}