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
    /// Set of parameters for event registration code verification
    /// </summary>
    [DataContract]
    public partial class VerifyRegistrationCodeParams : IEquatable<VerifyRegistrationCodeParams>
    {
        /// <summary>
        /// Registration event ID
        /// </summary>
        /// <value>Registration event ID</value>

        [DataMember(Name = "eventId")]
        public int? EventId { get; set; }

        /// <summary>
        /// Event registration type ID
        /// </summary>
        /// <value>Event registration type ID</value>

        [DataMember(Name = "registrationTypeId")]
        public int? RegistrationTypeId { get; set; }

        /// <summary>
        /// Code to verify
        /// </summary>
        /// <value>Code to verify</value>

        [DataMember(Name = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VerifyRegistrationCodeParams {\n");
            sb.Append("  EventId: ").Append(EventId).Append("\n");
            sb.Append("  RegistrationTypeId: ").Append(RegistrationTypeId).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            if (ReferenceEquals(this, obj))
                return true;
            return obj.GetType() == GetType() && Equals((VerifyRegistrationCodeParams)obj);
        }

        /// <summary>
        /// Returns true if VerifyRegistrationCodeParams instances are equal
        /// </summary>
        /// <param name="other">Instance of VerifyRegistrationCodeParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VerifyRegistrationCodeParams other)
        {
            if (ReferenceEquals(null, other))
                return false;
            if (ReferenceEquals(this, other))
                return true;

            return (EventId == other.EventId || EventId != null && EventId.Equals(other.EventId))
                && (
                    RegistrationTypeId == other.RegistrationTypeId
                    || RegistrationTypeId != null
                        && RegistrationTypeId.Equals(other.RegistrationTypeId)
                )
                && (Code == other.Code || Code != null && Code.Equals(other.Code));
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                if (EventId != null)
                    hashCode = hashCode * 59 + EventId.GetHashCode();
                if (RegistrationTypeId != null)
                    hashCode = hashCode * 59 + RegistrationTypeId.GetHashCode();
                if (Code != null)
                    hashCode = hashCode * 59 + Code.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(
            VerifyRegistrationCodeParams left,
            VerifyRegistrationCodeParams right
        )
        {
            return Equals(left, right);
        }

        public static bool operator !=(
            VerifyRegistrationCodeParams left,
            VerifyRegistrationCodeParams right
        )
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}
