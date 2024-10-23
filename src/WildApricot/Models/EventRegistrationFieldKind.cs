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
    /// Common - field is a part of contact fieldset. Custom - field is specific to event.
    /// </summary>
    /// <value>Common - field is a part of contact fieldset. Custom - field is specific to event.</value>
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EventRegistrationFieldKind
    {
        /// <summary>
        /// Enum CommonEnum for Common
        /// </summary>
        [EnumMember(Value = "Common")]
        CommonEnum = 0,

        /// <summary>
        /// Enum CustomEnum for Custom
        /// </summary>
        [EnumMember(Value = "Custom")]
        CustomEnum = 1,
    }
}