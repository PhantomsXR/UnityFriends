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

//-----------------------------------------------------------------------------
// <auto-generated>
//     This file was generated by the C# SDK Code Generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//-----------------------------------------------------------------------------


namespace Unity.Services.Friends.Internal.Generated.Models
{
    /// <summary>
    /// RelationshipType enum.
    /// </summary>
    
    [Preserve]
    [JsonConverter(typeof(StringEnumConverter))]
    internal enum RelationshipType
    {
        /// <summary>
        /// Enum FRIEND for value: FRIEND
        /// </summary>
        [EnumMember(Value = "FRIEND")]
        FRIEND = 1,

        /// <summary>
        /// Enum BLOCK for value: BLOCK
        /// </summary>
        [EnumMember(Value = "BLOCK")]
        BLOCK = 2,

        /// <summary>
        /// Enum FRIENDREQUEST for value: FRIEND_REQUEST
        /// </summary>
        [EnumMember(Value = "FRIEND_REQUEST")]
        FRIENDREQUEST = 3

    }
}



