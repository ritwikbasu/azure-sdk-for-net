// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.Network;
using Microsoft.Azure.Management.Network.Models;

namespace Microsoft.Azure.Management.Network
{
    /// <summary>
    /// The Windows Azure Network management API provides a RESTful set of web
    /// services that interact with Windows Azure Networks service to manage
    /// your network resrources. The API has entities that capture the
    /// relationship between an end user and the Windows Azure Networks
    /// service.
    /// </summary>
    public static partial class NetworkResourceProviderClientExtensions
    {
        /// <summary>
        /// Checks whether a domain name in the cloudapp.net zone is available
        /// for use.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.INetworkResourceProviderClient.
        /// </param>
        /// <param name='location'>
        /// Required. The location of the domain name
        /// </param>
        /// <param name='domainNameLabel'>
        /// Required. The domain name to be verified. It must conform to the
        /// following regular expression: ^[a-z][a-z0-9-]{1,61}[a-z0-9]$.
        /// </param>
        /// <returns>
        /// Response for CheckDnsNameAvailability Api servive call
        /// </returns>
        public static DnsNameAvailabilityResponse CheckDnsNameAvailability(this INetworkResourceProviderClient operations, string location, string domainNameLabel)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((INetworkResourceProviderClient)s).CheckDnsNameAvailabilityAsync(location, domainNameLabel);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Checks whether a domain name in the cloudapp.net zone is available
        /// for use.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.INetworkResourceProviderClient.
        /// </param>
        /// <param name='location'>
        /// Required. The location of the domain name
        /// </param>
        /// <param name='domainNameLabel'>
        /// Required. The domain name to be verified. It must conform to the
        /// following regular expression: ^[a-z][a-z0-9-]{1,61}[a-z0-9]$.
        /// </param>
        /// <returns>
        /// Response for CheckDnsNameAvailability Api servive call
        /// </returns>
        public static Task<DnsNameAvailabilityResponse> CheckDnsNameAvailabilityAsync(this INetworkResourceProviderClient operations, string location, string domainNameLabel)
        {
            return operations.CheckDnsNameAvailabilityAsync(location, domainNameLabel, CancellationToken.None);
        }
        
        /// <summary>
        /// The Get Operation Status operation returns the status of the
        /// specified operation. After calling an asynchronous operation, you
        /// can call Get Operation Status to determine whether the operation
        /// has succeeded, failed, or is still in progress.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.INetworkResourceProviderClient.
        /// </param>
        /// <param name='azureAsyncOperation'>
        /// Required. Location value returned by the Begin operation.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request and error information regarding
        /// the failure.
        /// </returns>
        public static AzureAsyncOperationResponse GetLongRunningOperationStatus(this INetworkResourceProviderClient operations, string azureAsyncOperation)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((INetworkResourceProviderClient)s).GetLongRunningOperationStatusAsync(azureAsyncOperation);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The Get Operation Status operation returns the status of the
        /// specified operation. After calling an asynchronous operation, you
        /// can call Get Operation Status to determine whether the operation
        /// has succeeded, failed, or is still in progress.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Network.INetworkResourceProviderClient.
        /// </param>
        /// <param name='azureAsyncOperation'>
        /// Required. Location value returned by the Begin operation.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request and error information regarding
        /// the failure.
        /// </returns>
        public static Task<AzureAsyncOperationResponse> GetLongRunningOperationStatusAsync(this INetworkResourceProviderClient operations, string azureAsyncOperation)
        {
            return operations.GetLongRunningOperationStatusAsync(azureAsyncOperation, CancellationToken.None);
        }
    }
}