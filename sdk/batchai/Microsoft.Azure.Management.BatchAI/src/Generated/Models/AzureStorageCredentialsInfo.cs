// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.BatchAI.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Azure storage account credentials.
    /// </summary>
    public partial class AzureStorageCredentialsInfo
    {
        /// <summary>
        /// Initializes a new instance of the AzureStorageCredentialsInfo
        /// class.
        /// </summary>
        public AzureStorageCredentialsInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureStorageCredentialsInfo
        /// class.
        /// </summary>
        /// <param name="accountKey">Account key.</param>
        /// <param name="accountKeySecretReference">Account key secret
        /// reference.</param>
        public AzureStorageCredentialsInfo(string accountKey = default(string), KeyVaultSecretReference accountKeySecretReference = default(KeyVaultSecretReference))
        {
            AccountKey = accountKey;
            AccountKeySecretReference = accountKeySecretReference;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets account key.
        /// </summary>
        /// <remarks>
        /// Storage account key. One of accountKey or accountKeySecretReference
        /// must be specified.
        /// </remarks>
        [JsonProperty(PropertyName = "accountKey")]
        public string AccountKey { get; set; }

        /// <summary>
        /// Gets or sets account key secret reference.
        /// </summary>
        /// <remarks>
        /// Information about KeyVault secret storing the storage account key.
        /// One of accountKey or accountKeySecretReference must be specified.
        /// </remarks>
        [JsonProperty(PropertyName = "accountKeySecretReference")]
        public KeyVaultSecretReference AccountKeySecretReference { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (AccountKeySecretReference != null)
            {
                AccountKeySecretReference.Validate();
            }
        }
    }
}