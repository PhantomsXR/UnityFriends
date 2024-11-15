//-----------------------------------------------------------------------------
// <auto-generated>
//     This file was generated by the C# SDK Code Generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//-----------------------------------------------------------------------------


using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.Scripting;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Unity.Services.Friends.Internal.Generated.Http;



namespace Unity.Services.Friends.Internal.Generated.Models
{
    /// <summary>
    /// MessageRequestAllOf model
    /// </summary>
    [Preserve]
    [DataContract(Name = "MessageRequest_allOf")]
    internal class MessageRequestAllOf
    {
        /// <summary>
        /// Creates an instance of MessageRequestAllOf.
        /// </summary>
        /// <param name="message">The message to be sent to the target user. The maximum size of the message payload is 10 kilobytes.</param>
        [Preserve]
        public MessageRequestAllOf(object message)
        {
            Message = (IDeserializable) JsonObject.GetNewJsonObjectResponse(message);
        }

        /// <summary>
        /// The message to be sent to the target user. The maximum size of the message payload is 10 kilobytes.
        /// </summary>
        [Preserve][JsonConverter(typeof(JsonObjectConverter))]
        [DataMember(Name = "message", IsRequired = true, EmitDefaultValue = true)]
        public IDeserializable Message{ get; }
    
        /// <summary>
        /// Formats a MessageRequestAllOf into a string of key-value pairs for use as a path parameter.
        /// </summary>
        /// <returns>Returns a string representation of the key-value pairs.</returns>
        internal string SerializeAsPathParam()
        {
            var serializedModel = "";

            if (Message != null)
            {
                serializedModel += "message," + Message.ToString();
            }
            return serializedModel;
        }

        /// <summary>
        /// Returns a MessageRequestAllOf as a dictionary of key-value pairs for use as a query parameter.
        /// </summary>
        /// <returns>Returns a dictionary of string key-value pairs.</returns>
        internal Dictionary<string, string> GetAsQueryParam()
        {
            var dictionary = new Dictionary<string, string>();

            return dictionary;
        }
    }
}
