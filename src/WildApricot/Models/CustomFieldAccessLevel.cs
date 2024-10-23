/*
 * Wild Apricot API for non-administrative access
 *
 * Wild Apricot API for non-administrative access
 *
 * OpenAPI spec version: 8.10.0
 *
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace WildApricot.Models
{
    /// <summary>
    /// Default access level for the field. Describes who can access this field.
    /// </summary>
    /// <value>Default access level for the field. Describes who can access this field. </value>
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CustomFieldAccessLevel
    {
        /// <summary>
        /// Enum PublicEnum for Public
        /// </summary>
        [EnumMember(Value = "Public")]
        PublicEnum = 0,

        /// <summary>
        /// Enum MemberEnum for Member
        /// </summary>
        [EnumMember(Value = "Member")]
        MemberEnum = 1,

        /// <summary>
        /// Enum NobodyEnum for Nobody
        /// </summary>
        [EnumMember(Value = "Nobody")]
        NobodyEnum = 2,
    }
}