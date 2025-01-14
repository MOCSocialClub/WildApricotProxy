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
    /// Payment method for applications, renewals and upgrades for this membershipLevel.
    /// </summary>
    /// <value>Payment method for applications, renewals and upgrades for this membershipLevel.</value>
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MembershipLevelPaymentMethod
    {
        /// <summary>
        /// Enum OnlineAndOfflineEnum for OnlineAndOffline
        /// </summary>
        [EnumMember(Value = "OnlineAndOffline")]
        OnlineAndOfflineEnum = 0,

        /// <summary>
        /// Enum OfflineOnlyEnum for OfflineOnly
        /// </summary>
        [EnumMember(Value = "OfflineOnly")]
        OfflineOnlyEnum = 1,

        /// <summary>
        /// Enum OnlineOnlyEnum for OnlineOnly
        /// </summary>
        [EnumMember(Value = "OnlineOnly")]
        OnlineOnlyEnum = 2,
    }
}
