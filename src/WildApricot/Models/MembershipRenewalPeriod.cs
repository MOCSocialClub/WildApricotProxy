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
    public partial class MembershipRenewalPeriod : IEquatable<MembershipRenewalPeriod>
    {
        /// <summary>
        /// Gets or Sets Kind
        /// </summary>
        [Required]
        [DataMember(Name = "Kind")]
        public RenewalPeriodKind Kind { get; set; }

        /// <summary>
        /// If true, renewal dates are calculated starting from join date. Otherwise,  renewal dates are specified in Dates field.
        /// </summary>
        /// <value>If true, renewal dates are calculated starting from join date. Otherwise,  renewal dates are specified in Dates field.</value>

        [DataMember(Name = "StartFromJoinDate")]
        public bool? StartFromJoinDate { get; set; }

        /// <summary>
        /// For EveryNYears renewal, specifies number of years between renewals.
        /// </summary>
        /// <value>For EveryNYears renewal, specifies number of years between renewals.</value>

        [DataMember(Name = "YearPeriod")]
        public int? YearPeriod { get; set; }

        /// <summary>
        /// Renewal dates during a year. For monthly renewals, it contains 12 records.
        /// </summary>
        /// <value>Renewal dates during a year. For monthly renewals, it contains 12 records.</value>

        [DataMember(Name = "Dates")]
        public List<DayOfYear> Dates { get; set; }

        /// <summary>
        /// Gets or Sets RenewalLimits
        /// </summary>

        [DataMember(Name = "RenewalLimits")]
        public RenewalLimits RenewalLimits { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MembershipRenewalPeriod {\n");
            sb.Append("  Kind: ").Append(Kind).Append("\n");
            sb.Append("  StartFromJoinDate: ").Append(StartFromJoinDate).Append("\n");
            sb.Append("  YearPeriod: ").Append(YearPeriod).Append("\n");
            sb.Append("  Dates: ").Append(Dates).Append("\n");
            sb.Append("  RenewalLimits: ").Append(RenewalLimits).Append("\n");
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
            return obj.GetType() == GetType() && Equals((MembershipRenewalPeriod)obj);
        }

        /// <summary>
        /// Returns true if MembershipRenewalPeriod instances are equal
        /// </summary>
        /// <param name="other">Instance of MembershipRenewalPeriod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MembershipRenewalPeriod other)
        {
            if (ReferenceEquals(null, other))
                return false;
            if (ReferenceEquals(this, other))
                return true;

            return (Kind == other.Kind || Kind != null && Kind.Equals(other.Kind))
                && (
                    StartFromJoinDate == other.StartFromJoinDate
                    || StartFromJoinDate != null
                        && StartFromJoinDate.Equals(other.StartFromJoinDate)
                )
                && (
                    YearPeriod == other.YearPeriod
                    || YearPeriod != null && YearPeriod.Equals(other.YearPeriod)
                )
                && (Dates == other.Dates || Dates != null && Dates.SequenceEqual(other.Dates))
                && (
                    RenewalLimits == other.RenewalLimits
                    || RenewalLimits != null && RenewalLimits.Equals(other.RenewalLimits)
                );
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
                if (Kind != null)
                    hashCode = hashCode * 59 + Kind.GetHashCode();
                if (StartFromJoinDate != null)
                    hashCode = hashCode * 59 + StartFromJoinDate.GetHashCode();
                if (YearPeriod != null)
                    hashCode = hashCode * 59 + YearPeriod.GetHashCode();
                if (Dates != null)
                    hashCode = hashCode * 59 + Dates.GetHashCode();
                if (RenewalLimits != null)
                    hashCode = hashCode * 59 + RenewalLimits.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(MembershipRenewalPeriod left, MembershipRenewalPeriod right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(MembershipRenewalPeriod left, MembershipRenewalPeriod right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}
