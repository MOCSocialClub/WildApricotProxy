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
    public partial class Payment : IEquatable<Payment>
    {
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [Required]
        [DataMember(Name = "Id")]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [Required]
        [DataMember(Name = "Url")]
        public string Url { get; set; }

        /// <summary>
        /// Full value (amount) of this payment, using account&#x27;s primary currency.
        /// </summary>
        /// <value>Full value (amount) of this payment, using account&#x27;s primary currency.</value>
        [Required]
        [DataMember(Name = "Value")]
        public decimal? Value { get; set; }

        /// <summary>
        /// Autoincremented for each subsequent payment.
        /// </summary>
        /// <value>Autoincremented for each subsequent payment.</value>
        [Required]
        [DataMember(Name = "DocumentNumber")]
        public string DocumentNumber { get; set; }

        /// <summary>
        /// Date and time payment was received.
        /// </summary>
        /// <value>Date and time payment was received.</value>
        [Required]
        [DataMember(Name = "DocumentDate")]
        public DateTime? DocumentDate { get; set; }

        /// <summary>
        /// Sum of payment already allocated to existing invoices.
        /// </summary>
        /// <value>Sum of payment already allocated to existing invoices.</value>
        [Required]
        [DataMember(Name = "AllocatedValue")]
        public decimal? AllocatedValue { get; set; }

        /// <summary>
        /// Amount of a refund assigned to the payment.
        /// </summary>
        /// <value>Amount of a refund assigned to the payment.</value>

        [DataMember(Name = "RefundedAmount")]
        public decimal? RefundedAmount { get; set; }

        /// <summary>
        /// Gets or Sets PaymentType
        /// </summary>
        [Required]
        [DataMember(Name = "PaymentType")]
        public PaymentType PaymentType { get; set; }

        /// <summary>
        /// Gets or Sets Comment
        /// </summary>

        [DataMember(Name = "Comment")]
        public string Comment { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Payment {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  DocumentNumber: ").Append(DocumentNumber).Append("\n");
            sb.Append("  DocumentDate: ").Append(DocumentDate).Append("\n");
            sb.Append("  AllocatedValue: ").Append(AllocatedValue).Append("\n");
            sb.Append("  RefundedAmount: ").Append(RefundedAmount).Append("\n");
            sb.Append("  PaymentType: ").Append(PaymentType).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Payment)obj);
        }

        /// <summary>
        /// Returns true if Payment instances are equal
        /// </summary>
        /// <param name="other">Instance of Payment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Payment other)
        {
            if (ReferenceEquals(null, other))
                return false;
            if (ReferenceEquals(this, other))
                return true;

            return (Id == other.Id || Id != null && Id.Equals(other.Id))
                && (Url == other.Url || Url != null && Url.Equals(other.Url))
                && (Value == other.Value || Value != null && Value.Equals(other.Value))
                && (
                    DocumentNumber == other.DocumentNumber
                    || DocumentNumber != null && DocumentNumber.Equals(other.DocumentNumber)
                )
                && (
                    DocumentDate == other.DocumentDate
                    || DocumentDate != null && DocumentDate.Equals(other.DocumentDate)
                )
                && (
                    AllocatedValue == other.AllocatedValue
                    || AllocatedValue != null && AllocatedValue.Equals(other.AllocatedValue)
                )
                && (
                    RefundedAmount == other.RefundedAmount
                    || RefundedAmount != null && RefundedAmount.Equals(other.RefundedAmount)
                )
                && (
                    PaymentType == other.PaymentType
                    || PaymentType != null && PaymentType.Equals(other.PaymentType)
                )
                && (Comment == other.Comment || Comment != null && Comment.Equals(other.Comment));
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
                if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                if (Url != null)
                    hashCode = hashCode * 59 + Url.GetHashCode();
                if (Value != null)
                    hashCode = hashCode * 59 + Value.GetHashCode();
                if (DocumentNumber != null)
                    hashCode = hashCode * 59 + DocumentNumber.GetHashCode();
                if (DocumentDate != null)
                    hashCode = hashCode * 59 + DocumentDate.GetHashCode();
                if (AllocatedValue != null)
                    hashCode = hashCode * 59 + AllocatedValue.GetHashCode();
                if (RefundedAmount != null)
                    hashCode = hashCode * 59 + RefundedAmount.GetHashCode();
                if (PaymentType != null)
                    hashCode = hashCode * 59 + PaymentType.GetHashCode();
                if (Comment != null)
                    hashCode = hashCode * 59 + Comment.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(Payment left, Payment right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Payment left, Payment right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}
