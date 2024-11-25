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
using Unity.Services.Friends.Internal.Generated.Presence;

namespace Unity.Services.Friends.Internal.Generated.Apis.Presence
{
    /// <summary>
    /// Interface for the PresenceApiClient
    /// </summary>
    internal interface IPresenceApiClient
    {
            /// <summary>
            /// Async Operation.
            /// Get presence for a user..
            /// </summary>
            /// <param name="request">Request object for GetPresence.</param>
            /// <param name="operationConfiguration">Configuration for GetPresence.</param>
            /// <returns>Task for a Response object containing status code, headers, and Models.UserPresence object.</returns>
            /// <exception cref="Unity.Services.Friends.Internal.Generated.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
            Task<Response<Models.UserPresence>> GetPresenceAsync(Unity.Services.Friends.Internal.Generated.Presence.GetPresenceRequest request, Configuration operationConfiguration = null);

            /// <summary>
            /// Async Operation.
            /// Set presence for a user..
            /// </summary>
            /// <param name="request">Request object for SetPresence.</param>
            /// <param name="operationConfiguration">Configuration for SetPresence.</param>
            /// <returns>Task for a Response object containing status code, headers, and Models.UserPresence object.</returns>
            /// <exception cref="Unity.Services.Friends.Internal.Generated.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
            Task<Response<Models.UserPresence>> SetPresenceAsync(Unity.Services.Friends.Internal.Generated.Presence.SetPresenceRequest request, Configuration operationConfiguration = null);

    }

    ///<inheritdoc cref="IPresenceApiClient"/>
    internal class PresenceApiClient : BaseApiClient, IPresenceApiClient
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
                Configuration globalConfiguration = new Configuration(
                    CheckRegion.IsChina
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
        /// PresenceApiClient Constructor.
        /// </summary>
        /// <param name="httpClient">The HttpClient for PresenceApiClient.</param>
        /// <param name="accessToken">The Authentication token for the client.</param>
        /// <param name="configuration"> PresenceApiClient Configuration object.</param>
        public PresenceApiClient(IHttpClient httpClient,
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
        /// Get presence for a user..
        /// </summary>
        /// <param name="request">Request object for GetPresence.</param>
        /// <param name="operationConfiguration">Configuration for GetPresence.</param>
        /// <returns>Task for a Response object containing status code, headers, and Models.UserPresence object.</returns>
        /// <exception cref="Unity.Services.Friends.Internal.Generated.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
        public async Task<Response<Models.UserPresence>> GetPresenceAsync(Unity.Services.Friends.Internal.Generated.Presence.GetPresenceRequest request,
            Configuration operationConfiguration = null)
        {
            var statusCodeToTypeMap = new Dictionary<string, System.Type>() { {"200", typeof(Models.UserPresence)   },{"400", typeof(Models.Error)   },{"403", typeof(Models.Error)   },{"500", typeof(Models.Error)   } };

            // Merge the operation/request level configuration with the client level configuration.
            var finalConfiguration = Configuration.MergeConfigurations(operationConfiguration, Configuration);

            var response = await HttpClient.MakeRequestAsync("GET",
                request.ConstructUrl(finalConfiguration.BasePath),
                request.ConstructBody(),
                request.ConstructHeaders(_accessToken, finalConfiguration),
                finalConfiguration.RequestTimeout ?? _baseTimeout);

            var handledResponse = ResponseHandler.HandleAsyncResponse<Models.UserPresence>(response, statusCodeToTypeMap);
            return new Response<Models.UserPresence>(response, handledResponse);
        }


        /// <summary>
        /// Async Operation.
        /// Set presence for a user..
        /// </summary>
        /// <param name="request">Request object for SetPresence.</param>
        /// <param name="operationConfiguration">Configuration for SetPresence.</param>
        /// <returns>Task for a Response object containing status code, headers, and Models.UserPresence object.</returns>
        /// <exception cref="Unity.Services.Friends.Internal.Generated.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
        public async Task<Response<Models.UserPresence>> SetPresenceAsync(Unity.Services.Friends.Internal.Generated.Presence.SetPresenceRequest request,
            Configuration operationConfiguration = null)
        {
            var statusCodeToTypeMap = new Dictionary<string, System.Type>() { {"200", typeof(Models.UserPresence)   },{"400", typeof(Models.Error)   },{"403", typeof(Models.Error)   },{"500", typeof(Models.Error)   } };

            // Merge the operation/request level configuration with the client level configuration.
            var finalConfiguration = Configuration.MergeConfigurations(operationConfiguration, Configuration);

            var response = await HttpClient.MakeRequestAsync("POST",
                request.ConstructUrl(finalConfiguration.BasePath),
                request.ConstructBody(),
                request.ConstructHeaders(_accessToken, finalConfiguration),
                finalConfiguration.RequestTimeout ?? _baseTimeout);

            var handledResponse = ResponseHandler.HandleAsyncResponse<Models.UserPresence>(response, statusCodeToTypeMap);
            return new Response<Models.UserPresence>(response, handledResponse);
        }

    }
}
