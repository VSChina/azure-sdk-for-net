// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Language.LUIS.Runtime
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Prediction operations.
    /// </summary>
    public partial interface IPrediction
    {
        /// <summary>
        /// Gets predictions for a given utterance, in the form of intents and
        /// entities. The current maximum query size is 500 characters.
        /// </summary>
        /// <param name='appId'>
        /// The LUIS application ID (Guid).
        /// </param>
        /// <param name='query'>
        /// The utterance to predict.
        /// </param>
        /// <param name='timezoneOffset'>
        /// The timezone offset for the location of the request.
        /// </param>
        /// <param name='verbose'>
        /// If true, return all intents instead of just the top scoring intent.
        /// </param>
        /// <param name='staging'>
        /// Use the staging endpoint slot.
        /// </param>
        /// <param name='spellCheck'>
        /// Enable spell checking.
        /// </param>
        /// <param name='bingSpellCheckSubscriptionKey'>
        /// The subscription key to use when enabling bing spell check
        /// </param>
        /// <param name='log'>
        /// Log query (default is true)
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="APIErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<LuisResult>> ResolveWithHttpMessagesAsync(string appId, string query, double? timezoneOffset = default(double?), bool? verbose = default(bool?), bool? staging = default(bool?), bool? spellCheck = default(bool?), string bingSpellCheckSubscriptionKey = default(string), bool? log = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}