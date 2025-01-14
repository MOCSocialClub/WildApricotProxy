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
    ///
    /// </summary>
    [DataContract]
    public partial class DayOfYear : IEquatable<DayOfYear>
    {
        /// <summary>
        /// Month of renewal. 1 - Jan ... 12 - Dec
        /// </summary>
        /// <value>Month of renewal. 1 - Jan ... 12 - Dec</value>

        [DataMember(Name = "Month")]
        public int? Month { get; set; }

        /// <summary>
        /// Day of the month
        /// </summary>
        /// <value>Day of the month</value>

        [DataMember(Name = "Day")]
        public int? Day { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DayOfYear {\n");
            sb.Append("  Month: ").Append(Month).Append("\n");
            sb.Append("  Day: ").Append(Day).Append("\n");
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
            return obj.GetType() == GetType() && Equals((DayOfYear)obj);
        }

        /// <summary>
        /// Returns true if DayOfYear instances are equal
        /// </summary>
        /// <param name="other">Instance of DayOfYear to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DayOfYear other)
        {
            if (ReferenceEquals(null, other))
                return false;
            if (ReferenceEquals(this, other))
                return true;

            return (Month == other.Month || Month != null && Month.Equals(other.Month))
                && (Day == other.Day || Day != null && Day.Equals(other.Day));
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
                if (Month != null)
                    hashCode = hashCode * 59 + Month.GetHashCode();
                if (Day != null)
                    hashCode = hashCode * 59 + Day.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(DayOfYear left, DayOfYear right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(DayOfYear left, DayOfYear right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}
