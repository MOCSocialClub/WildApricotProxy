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
    /// The reason for the payment.
    /// </summary>
    /// <value>The reason for the payment.</value>
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PaymentType
    {
        /// <summary>
        /// Enum UnknownEnum for Unknown
        /// </summary>
        [EnumMember(Value = "Unknown")]
        UnknownEnum = 0,

        /// <summary>
        /// Enum InvoicePaymentEnum for InvoicePayment
        /// </summary>
        [EnumMember(Value = "InvoicePayment")]
        InvoicePaymentEnum = 1,

        /// <summary>
        /// Enum DonationPaymentEnum for DonationPayment
        /// </summary>
        [EnumMember(Value = "DonationPayment")]
        DonationPaymentEnum = 2,
    }
}
