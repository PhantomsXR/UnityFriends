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
    /// Role enum.
    /// </summary>
    
    [Preserve]
    [JsonConverter(typeof(StringEnumConverter))]
    internal enum Role
    {
        /// <summary>
        /// Enum TARGET for value: TARGET
        /// </summary>
        [EnumMember(Value = "TARGET")]
        TARGET = 1,

        /// <summary>
        /// Enum SOURCE for value: SOURCE
        /// </summary>
        [EnumMember(Value = "SOURCE")]
        SOURCE = 2,

        /// <summary>
        /// Enum NONE for value: NONE
        /// </summary>
        [EnumMember(Value = "NONE")]
        NONE = 3

    }
}



