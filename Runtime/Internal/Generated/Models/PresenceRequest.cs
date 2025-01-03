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
    /// PresenceRequest model
    /// </summary>
    [Preserve]
    [DataContract(Name = "PresenceRequest")]
    internal class PresenceRequest
    {
        /// <summary>
        /// Creates an instance of PresenceRequest.
        /// </summary>
        /// <param name="availability">The current availability of the user.</param>
        /// <param name="activity">The current activity data of the user. The maximum for the activity object is 10 kilobytes.</param>
        [Preserve]
        public PresenceRequest(AvailabilityOptions availability, object activity = default)
        {
            Availability = availability;
            Activity = (IDeserializable) JsonObject.GetNewJsonObjectResponse(activity);
        }

        /// <summary>
        /// The current availability of the user.
        /// </summary>
        [Preserve]
        [JsonConverter(typeof(StringEnumConverter))]
        [DataMember(Name = "availability", IsRequired = true, EmitDefaultValue = true)]
        public AvailabilityOptions Availability{ get; }
        
        /// <summary>
        /// The current activity data of the user. The maximum for the activity object is 10 kilobytes.
        /// </summary>
        [Preserve][JsonConverter(typeof(JsonObjectConverter))]
        [DataMember(Name = "activity", EmitDefaultValue = false)]
        public IDeserializable Activity{ get; }
    
        /// <summary>
        /// The current availability of the user.
        /// </summary>
        /// <value>The current availability of the user.</value>
        [Preserve]
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AvailabilityOptions
        {
            /// <summary>
            /// Enum ONLINE for value: ONLINE
            /// </summary>
            [EnumMember(Value = "ONLINE")]
            ONLINE = 1,
            /// <summary>
            /// Enum BUSY for value: BUSY
            /// </summary>
            [EnumMember(Value = "BUSY")]
            BUSY = 2,
            /// <summary>
            /// Enum AWAY for value: AWAY
            /// </summary>
            [EnumMember(Value = "AWAY")]
            AWAY = 3,
            /// <summary>
            /// Enum INVISIBLE for value: INVISIBLE
            /// </summary>
            [EnumMember(Value = "INVISIBLE")]
            INVISIBLE = 4,
            /// <summary>
            /// Enum OFFLINE for value: OFFLINE
            /// </summary>
            [EnumMember(Value = "OFFLINE")]
            OFFLINE = 5
        }

        /// <summary>
        /// Formats a PresenceRequest into a string of key-value pairs for use as a path parameter.
        /// </summary>
        /// <returns>Returns a string representation of the key-value pairs.</returns>
        internal string SerializeAsPathParam()
        {
            var serializedModel = "";

            serializedModel += "availability," + Availability + ",";
            if (Activity != null)
            {
                serializedModel += "activity," + Activity.ToString();
            }
            return serializedModel;
        }

        /// <summary>
        /// Returns a PresenceRequest as a dictionary of key-value pairs for use as a query parameter.
        /// </summary>
        /// <returns>Returns a dictionary of string key-value pairs.</returns>
        internal Dictionary<string, string> GetAsQueryParam()
        {
            var dictionary = new Dictionary<string, string>();

            var availabilityStringValue = Availability.ToString();
            dictionary.Add("availability", availabilityStringValue);
            
            return dictionary;
        }
    }
}
