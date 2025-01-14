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
    /// Related event
    /// </summary>
    [DataContract]
    public partial class EventStub : IEquatable<EventStub>
    {
        /// <summary>
        /// Unique event identifier
        /// </summary>
        /// <value>Unique event identifier</value>
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
        /// Event title
        /// </summary>
        /// <value>Event title</value>
        [Required]
        [DataMember(Name = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// Location / address where event will take place
        /// </summary>
        /// <value>Location / address where event will take place</value>
        [Required]
        [DataMember(Name = "Location")]
        public string Location { get; set; }

        /// <summary>
        /// Event start date
        /// </summary>
        /// <value>Event start date</value>
        [Required]
        [DataMember(Name = "StartDate")]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Event end date
        /// </summary>
        /// <value>Event end date</value>

        [DataMember(Name = "EndDate")]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EventStub {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
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
            return obj.GetType() == GetType() && Equals((EventStub)obj);
        }

        /// <summary>
        /// Returns true if EventStub instances are equal
        /// </summary>
        /// <param name="other">Instance of EventStub to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EventStub other)
        {
            if (ReferenceEquals(null, other))
                return false;
            if (ReferenceEquals(this, other))
                return true;

            return (Id == other.Id || Id != null && Id.Equals(other.Id))
                && (Url == other.Url || Url != null && Url.Equals(other.Url))
                && (Name == other.Name || Name != null && Name.Equals(other.Name))
                && (
                    Location == other.Location
                    || Location != null && Location.Equals(other.Location)
                )
                && (
                    StartDate == other.StartDate
                    || StartDate != null && StartDate.Equals(other.StartDate)
                )
                && (EndDate == other.EndDate || EndDate != null && EndDate.Equals(other.EndDate));
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
                if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                if (Location != null)
                    hashCode = hashCode * 59 + Location.GetHashCode();
                if (StartDate != null)
                    hashCode = hashCode * 59 + StartDate.GetHashCode();
                if (EndDate != null)
                    hashCode = hashCode * 59 + EndDate.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(EventStub left, EventStub right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(EventStub left, EventStub right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}
