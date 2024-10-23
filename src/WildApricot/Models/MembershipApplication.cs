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
    /// Set of parameters to apply for membership
    /// </summary>
    [DataContract]
    public partial class MembershipApplication : IEquatable<MembershipApplication>
    {
        /// <summary>
        /// ID of membership level to apply for
        /// </summary>
        /// <value>ID of membership level to apply for</value>

        [DataMember(Name = "membershipLevelId")]
        public int? MembershipLevelId { get; set; }

        /// <summary>
        /// Field values for membership application form
        /// </summary>
        /// <value>Field values for membership application form</value>

        [DataMember(Name = "fieldValues")]
        public List<CustomFieldValue> FieldValues { get; set; }

        /// <summary>
        /// coupon code
        /// </summary>
        /// <value>coupon code</value>

        [DataMember(Name = "couponCode")]
        public string CouponCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MembershipApplication {\n");
            sb.Append("  MembershipLevelId: ").Append(MembershipLevelId).Append("\n");
            sb.Append("  FieldValues: ").Append(FieldValues).Append("\n");
            sb.Append("  CouponCode: ").Append(CouponCode).Append("\n");
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
            return obj.GetType() == GetType() && Equals((MembershipApplication)obj);
        }

        /// <summary>
        /// Returns true if MembershipApplication instances are equal
        /// </summary>
        /// <param name="other">Instance of MembershipApplication to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MembershipApplication other)
        {
            if (ReferenceEquals(null, other))
                return false;
            if (ReferenceEquals(this, other))
                return true;

            return (
                    MembershipLevelId == other.MembershipLevelId
                    || MembershipLevelId != null
                        && MembershipLevelId.Equals(other.MembershipLevelId)
                )
                && (
                    FieldValues == other.FieldValues
                    || FieldValues != null && FieldValues.SequenceEqual(other.FieldValues)
                )
                && (
                    CouponCode == other.CouponCode
                    || CouponCode != null && CouponCode.Equals(other.CouponCode)
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
                if (MembershipLevelId != null)
                    hashCode = hashCode * 59 + MembershipLevelId.GetHashCode();
                if (FieldValues != null)
                    hashCode = hashCode * 59 + FieldValues.GetHashCode();
                if (CouponCode != null)
                    hashCode = hashCode * 59 + CouponCode.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(MembershipApplication left, MembershipApplication right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(MembershipApplication left, MembershipApplication right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}
