//-----------------------------------------------------------------------------
// <auto-generated>
//     This file was generated by the C# SDK Code Generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//-----------------------------------------------------------------------------


using System.Threading.Tasks;
using System.Collections.Generic;
using Unity.Services.Friends.Internal.Generated.Models;
using Unity.Services.Friends.Internal.Generated.Http;
using Unity.Services.Authentication.Internal;
using Unity.Services.Core;
using Unity.Services.Friends.Internal.Generated.Relationships;

namespace Unity.Services.Friends.Internal.Generated.Apis.Relationships
{
    /// <summary>
    /// Interface for the RelationshipsApiClient
    /// </summary>
    internal interface IRelationshipsApiClient
    {
            /// <summary>
            /// Async Operation.
            /// Create a new relationship..
            /// </summary>
            /// <param name="request">Request object for CreateRelationship.</param>
            /// <param name="operationConfiguration">Configuration for CreateRelationship.</param>
            /// <returns>Task for a Response object containing status code, headers, and Models.Relationship object.</returns>
            /// <exception cref="Unity.Services.Friends.Internal.Generated.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
            Task<Response<Models.Relationship>> CreateRelationshipAsync(Unity.Services.Friends.Internal.Generated.Relationships.CreateRelationshipRequest request, Configuration operationConfiguration = null);

            /// <summary>
            /// Async Operation.
            /// Delete a relationship..
            /// </summary>
            /// <param name="request">Request object for DeleteRelationship.</param>
            /// <param name="operationConfiguration">Configuration for DeleteRelationship.</param>
            /// <returns>Task for a Response object containing status code, headers.</returns>
            /// <exception cref="Unity.Services.Friends.Internal.Generated.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
            Task<Response> DeleteRelationshipAsync(Unity.Services.Friends.Internal.Generated.Relationships.DeleteRelationshipRequest request, Configuration operationConfiguration = null);

            /// <summary>
            /// Async Operation.
            /// Retrieve a list of relationships..
            /// </summary>
            /// <param name="request">Request object for GetRelationships.</param>
            /// <param name="operationConfiguration">Configuration for GetRelationships.</param>
            /// <returns>Task for a Response object containing status code, headers, and List&lt;Models.Relationship&gt; object.</returns>
            /// <exception cref="Unity.Services.Friends.Internal.Generated.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
            Task<Response<List<Models.Relationship>>> GetRelationshipsAsync(Unity.Services.Friends.Internal.Generated.Relationships.GetRelationshipsRequest request, Configuration operationConfiguration = null);

    }

    ///<inheritdoc cref="IRelationshipsApiClient"/>
    internal class RelationshipsApiClient : BaseApiClient, IRelationshipsApiClient
    {
        private IAccessToken _accessToken;
        private const int _baseTimeout = 10;
        private Configuration _configuration;
        /// <summary>
        /// Accessor for the client configuration object. This returns a merge
        /// between the current configuration and the global configuration to
        /// ensure the correct combination of headers and a base path (if it is
        /// set) are returned.
        /// </summary>
        public Configuration Configuration
        {
            get {
                // We return a merge between the current configuration and the
                // global configuration to ensure we have the correct
                // combination of headers and a base path (if it is set).
                Configuration globalConfiguration = new Configuration(CheckRegion.IsChina
                    ? "https://xgs.phantomsxr.com":"https://social.services.api.unity.com", 10, 4, null);
                if (FriendsService.Instance != null)
                {
                    globalConfiguration = FriendsService.Instance.Configuration;
                }
                return Configuration.MergeConfigurations(_configuration, globalConfiguration);
            }
            set { _configuration = value; }
        }

        /// <summary>
        /// RelationshipsApiClient Constructor.
        /// </summary>
        /// <param name="httpClient">The HttpClient for RelationshipsApiClient.</param>
        /// <param name="accessToken">The Authentication token for the client.</param>
        /// <param name="configuration"> RelationshipsApiClient Configuration object.</param>
        public RelationshipsApiClient(IHttpClient httpClient,
            IAccessToken accessToken,
            Configuration configuration = null) : base(httpClient)
        {
            // We don't need to worry about the configuration being null at
            // this stage, we will check this in the accessor.
            _configuration = configuration;

            _accessToken = accessToken;
        }


        /// <summary>
        /// Async Operation.
        /// Create a new relationship..
        /// </summary>
        /// <param name="request">Request object for CreateRelationship.</param>
        /// <param name="operationConfiguration">Configuration for CreateRelationship.</param>
        /// <returns>Task for a Response object containing status code, headers, and Models.Relationship object.</returns>
        /// <exception cref="Unity.Services.Friends.Internal.Generated.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
        public async Task<Response<Models.Relationship>> CreateRelationshipAsync(Unity.Services.Friends.Internal.Generated.Relationships.CreateRelationshipRequest request,
            Configuration operationConfiguration = null)
        {
            var statusCodeToTypeMap = new Dictionary<string, System.Type>() { {"200", typeof(Models.Relationship)   },{"400", typeof(Models.Error)   },{"403", typeof(Models.Error)   },{"409", typeof(Models.Error)   },{"500", typeof(Models.Error)   } };

            // Merge the operation/request level configuration with the client level configuration.
            var finalConfiguration = Configuration.MergeConfigurations(operationConfiguration, Configuration);

            var response = await HttpClient.MakeRequestAsync("POST",
                request.ConstructUrl(finalConfiguration.BasePath),
                request.ConstructBody(),
                request.ConstructHeaders(_accessToken, finalConfiguration),
                finalConfiguration.RequestTimeout ?? _baseTimeout);

            var handledResponse = ResponseHandler.HandleAsyncResponse<Models.Relationship>(response, statusCodeToTypeMap);
            return new Response<Models.Relationship>(response, handledResponse);
        }


        /// <summary>
        /// Async Operation.
        /// Delete a relationship..
        /// </summary>
        /// <param name="request">Request object for DeleteRelationship.</param>
        /// <param name="operationConfiguration">Configuration for DeleteRelationship.</param>
        /// <returns>Task for a Response object containing status code, headers.</returns>
        /// <exception cref="Unity.Services.Friends.Internal.Generated.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
        public async Task<Response> DeleteRelationshipAsync(Unity.Services.Friends.Internal.Generated.Relationships.DeleteRelationshipRequest request,
            Configuration operationConfiguration = null)
        {
            var statusCodeToTypeMap = new Dictionary<string, System.Type>() { {"204",  null },{"400", typeof(Models.Error)   },{"403", typeof(Models.Error)   },{"404", typeof(Models.Error)   },{"500", typeof(Models.Error)   } };

            // Merge the operation/request level configuration with the client level configuration.
            var finalConfiguration = Configuration.MergeConfigurations(operationConfiguration, Configuration);

            var response = await HttpClient.MakeRequestAsync("DELETE",
                request.ConstructUrl(finalConfiguration.BasePath),
                request.ConstructBody(),
                request.ConstructHeaders(_accessToken, finalConfiguration),
                finalConfiguration.RequestTimeout ?? _baseTimeout);

            ResponseHandler.HandleAsyncResponse(response, statusCodeToTypeMap);
            return new Response(response);
        }


        /// <summary>
        /// Async Operation.
        /// Retrieve a list of relationships..
        /// </summary>
        /// <param name="request">Request object for GetRelationships.</param>
        /// <param name="operationConfiguration">Configuration for GetRelationships.</param>
        /// <returns>Task for a Response object containing status code, headers, and List&lt;Models.Relationship&gt; object.</returns>
        /// <exception cref="Unity.Services.Friends.Internal.Generated.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
        public async Task<Response<List<Models.Relationship>>> GetRelationshipsAsync(Unity.Services.Friends.Internal.Generated.Relationships.GetRelationshipsRequest request,
            Configuration operationConfiguration = null)
        {
            var statusCodeToTypeMap = new Dictionary<string, System.Type>() { {"200", typeof(List<Models.Relationship>)   },{"400", typeof(Models.Error)   },{"403", typeof(Models.Error)   },{"500", typeof(Models.Error)   } };

            // Merge the operation/request level configuration with the client level configuration.
            var finalConfiguration = Configuration.MergeConfigurations(operationConfiguration, Configuration);

            var response = await HttpClient.MakeRequestAsync("GET",
                request.ConstructUrl(finalConfiguration.BasePath),
                request.ConstructBody(),
                request.ConstructHeaders(_accessToken, finalConfiguration),
                finalConfiguration.RequestTimeout ?? _baseTimeout);

            var handledResponse = ResponseHandler.HandleAsyncResponse<List<Models.Relationship>>(response, statusCodeToTypeMap);
            return new Response<List<Models.Relationship>>(response, handledResponse);
        }

    }
}
