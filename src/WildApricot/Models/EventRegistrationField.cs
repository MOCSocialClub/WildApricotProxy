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
    public partial class EventRegistrationField : IEquatable<EventRegistrationField>
    {
        /// <summary>
        /// Field name to display on UI. It can be edited by administrator.
        /// </summary>
        /// <value>Field name to display on UI. It can be edited by administrator.</value>
        [Required]
        [DataMember(Name = "FieldName")]
        public string FieldName { get; set; }

        /// <summary>
        /// System-defined code associated with field. It does not change even if FieldName is edited
        /// </summary>
        /// <value>System-defined code associated with field. It does not change even if FieldName is edited </value>
        [Required]
        [DataMember(Name = "SystemCode")]
        public string SystemCode { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [Required]
        [DataMember(Name = "Type")]
        public CustomFieldType Type { get; set; }

        /// <summary>
        /// Optional hint, which tells how to display and edit field. It appears for String and Choice fields.
        /// </summary>
        /// <value>Optional hint, which tells how to display and edit field. It appears for String and Choice fields. </value>

        [DataMember(Name = "DisplayType")]
        public string DisplayType { get; set; }

        /// <summary>
        /// Field is system-defined.
        /// </summary>
        /// <value>Field is system-defined.</value>
        [Required]
        [DataMember(Name = "IsSystem")]
        public bool? IsSystem { get; set; }

        /// <summary>
        /// Gets or Sets Access
        /// </summary>
        [Required]
        [DataMember(Name = "Access")]
        public CustomFieldAccessLevel Access { get; set; }

        /// <summary>
        /// User-defined description of the field.
        /// </summary>
        /// <value>User-defined description of the field.</value>
        [Required]
        [DataMember(Name = "Description")]
        public string Description { get; set; }

        /// <summary>
        /// List of allowed values for this field. Appears for Choice / MultipleChoice fields.
        /// </summary>
        /// <value>List of allowed values for this field. Appears for Choice / MultipleChoice fields.</value>

        [DataMember(Name = "AllowedValues")]
        public List<CustomFieldAllowedValue> AllowedValues { get; set; }

        /// <summary>
        /// Sorting order to display the field in UI
        /// </summary>
        /// <value>Sorting order to display the field in UI</value>

        [DataMember(Name = "Order")]
        public int? Order { get; set; }

        /// <summary>
        /// Gets or Sets RulesAndTermsInfo
        /// </summary>

        [DataMember(Name = "RulesAndTermsInfo")]
        public CustomFieldRulesAndTermsInfo RulesAndTermsInfo { get; set; }

        /// <summary>
        /// Gets or Sets ExtraCharge
        /// </summary>

        [DataMember(Name = "ExtraCharge")]
        public CustomFieldExtraChargeInfo ExtraCharge { get; set; }

        /// <summary>
        /// Gets or Sets Kind
        /// </summary>
        [Required]
        [DataMember(Name = "Kind")]
        public EventRegistrationFieldKind Kind { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EventRegistrationField {\n");
            sb.Append("  FieldName: ").Append(FieldName).Append("\n");
            sb.Append("  SystemCode: ").Append(SystemCode).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  DisplayType: ").Append(DisplayType).Append("\n");
            sb.Append("  IsSystem: ").Append(IsSystem).Append("\n");
            sb.Append("  Access: ").Append(Access).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  AllowedValues: ").Append(AllowedValues).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  RulesAndTermsInfo: ").Append(RulesAndTermsInfo).Append("\n");
            sb.Append("  ExtraCharge: ").Append(ExtraCharge).Append("\n");
            sb.Append("  Kind: ").Append(Kind).Append("\n");
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
            return obj.GetType() == GetType() && Equals((EventRegistrationField)obj);
        }

        /// <summary>
        /// Returns true if EventRegistrationField instances are equal
        /// </summary>
        /// <param name="other">Instance of EventRegistrationField to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EventRegistrationField other)
        {
            if (ReferenceEquals(null, other))
                return false;
            if (ReferenceEquals(this, other))
                return true;

            return (
                    FieldName == other.FieldName
                    || FieldName != null && FieldName.Equals(other.FieldName)
                )
                && (
                    SystemCode == other.SystemCode
                    || SystemCode != null && SystemCode.Equals(other.SystemCode)
                )
                && (Type == other.Type || Type != null && Type.Equals(other.Type))
                && (
                    DisplayType == other.DisplayType
                    || DisplayType != null && DisplayType.Equals(other.DisplayType)
                )
                && (
                    IsSystem == other.IsSystem
                    || IsSystem != null && IsSystem.Equals(other.IsSystem)
                )
                && (Access == other.Access || Access != null && Access.Equals(other.Access))
                && (
                    Description == other.Description
                    || Description != null && Description.Equals(other.Description)
                )
                && (
                    AllowedValues == other.AllowedValues
                    || AllowedValues != null && AllowedValues.SequenceEqual(other.AllowedValues)
                )
                && (Order == other.Order || Order != null && Order.Equals(other.Order))
                && (
                    RulesAndTermsInfo == other.RulesAndTermsInfo
                    || RulesAndTermsInfo != null
                        && RulesAndTermsInfo.Equals(other.RulesAndTermsInfo)
                )
                && (
                    ExtraCharge == other.ExtraCharge
                    || ExtraCharge != null && ExtraCharge.Equals(other.ExtraCharge)
                )
                && (Kind == other.Kind || Kind != null && Kind.Equals(other.Kind));
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
                if (FieldName != null)
                    hashCode = hashCode * 59 + FieldName.GetHashCode();
                if (SystemCode != null)
                    hashCode = hashCode * 59 + SystemCode.GetHashCode();
                if (Type != null)
                    hashCode = hashCode * 59 + Type.GetHashCode();
                if (DisplayType != null)
                    hashCode = hashCode * 59 + DisplayType.GetHashCode();
                if (IsSystem != null)
                    hashCode = hashCode * 59 + IsSystem.GetHashCode();
                if (Access != null)
                    hashCode = hashCode * 59 + Access.GetHashCode();
                if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                if (AllowedValues != null)
                    hashCode = hashCode * 59 + AllowedValues.GetHashCode();
                if (Order != null)
                    hashCode = hashCode * 59 + Order.GetHashCode();
                if (RulesAndTermsInfo != null)
                    hashCode = hashCode * 59 + RulesAndTermsInfo.GetHashCode();
                if (ExtraCharge != null)
                    hashCode = hashCode * 59 + ExtraCharge.GetHashCode();
                if (Kind != null)
                    hashCode = hashCode * 59 + Kind.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(EventRegistrationField left, EventRegistrationField right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(EventRegistrationField left, EventRegistrationField right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}
