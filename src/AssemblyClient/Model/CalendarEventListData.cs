/* 
 * assembly.education
 *
 * Developer API for assembly.education.
 *
 * OpenAPI spec version: 1.0.0
 * Contact: help@assembly.education
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = AssemblyClient.Client.SwaggerDateConverter;

namespace AssemblyClient.Model
{
    /// <summary>
    /// The calendar events object provides details of school events. This resource is currently only available for SIMS.
    /// </summary>
    [DataContract]
    public partial class CalendarEventListData :  IEquatable<CalendarEventListData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CalendarEventListData" /> class.
        /// </summary>
        /// <param name="_object">Object type.</param>
        /// <param name="id">Internal stable ID given to all calendar events on the Platform.</param>
        /// <param name="name">This details the user-defined &#39;category&#39; that the event is assigned to on SIMS..</param>
        /// <param name="description">The name of the instance of the event, usually more detailed and specific than the &#39;name&#39;.</param>
        /// <param name="startDate">Date and time of when the event starts.</param>
        /// <param name="endDate">Date and time of when the event ends.</param>
        /// <param name="isActive">Whether the event is active or not.</param>
        /// <param name="isRecurrent">Whether the event recurs and (soon) details of recurrences.</param>
        /// <param name="misType">misType.</param>
        public CalendarEventListData(string _object = default(string), int? id = default(int?), string name = default(string), string description = default(string), DateTime? startDate = default(DateTime?), DateTime? endDate = default(DateTime?), bool? isActive = default(bool?), bool? isRecurrent = default(bool?), CalendarEventMisType misType = default(CalendarEventMisType))
        {
            this.Object = _object;
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.IsActive = isActive;
            this.IsRecurrent = isRecurrent;
            this.MisType = misType;
        }
        
        /// <summary>
        /// Object type
        /// </summary>
        /// <value>Object type</value>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public string Object { get; set; }

        /// <summary>
        /// Internal stable ID given to all calendar events on the Platform
        /// </summary>
        /// <value>Internal stable ID given to all calendar events on the Platform</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// This details the user-defined &#39;category&#39; that the event is assigned to on SIMS.
        /// </summary>
        /// <value>This details the user-defined &#39;category&#39; that the event is assigned to on SIMS.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The name of the instance of the event, usually more detailed and specific than the &#39;name&#39;
        /// </summary>
        /// <value>The name of the instance of the event, usually more detailed and specific than the &#39;name&#39;</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Date and time of when the event starts
        /// </summary>
        /// <value>Date and time of when the event starts</value>
        [DataMember(Name="start_date", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Date and time of when the event ends
        /// </summary>
        /// <value>Date and time of when the event ends</value>
        [DataMember(Name="end_date", EmitDefaultValue=false)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Whether the event is active or not
        /// </summary>
        /// <value>Whether the event is active or not</value>
        [DataMember(Name="is_active", EmitDefaultValue=false)]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Whether the event recurs and (soon) details of recurrences
        /// </summary>
        /// <value>Whether the event recurs and (soon) details of recurrences</value>
        [DataMember(Name="is_recurrent", EmitDefaultValue=false)]
        public bool? IsRecurrent { get; set; }

        /// <summary>
        /// Gets or Sets MisType
        /// </summary>
        [DataMember(Name="mis_type", EmitDefaultValue=false)]
        public CalendarEventMisType MisType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CalendarEventListData {\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  IsRecurrent: ").Append(IsRecurrent).Append("\n");
            sb.Append("  MisType: ").Append(MisType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CalendarEventListData);
        }

        /// <summary>
        /// Returns true if CalendarEventListData instances are equal
        /// </summary>
        /// <param name="input">Instance of CalendarEventListData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CalendarEventListData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Object == input.Object ||
                    (this.Object != null &&
                    this.Object.Equals(input.Object))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.IsActive == input.IsActive ||
                    (this.IsActive != null &&
                    this.IsActive.Equals(input.IsActive))
                ) && 
                (
                    this.IsRecurrent == input.IsRecurrent ||
                    (this.IsRecurrent != null &&
                    this.IsRecurrent.Equals(input.IsRecurrent))
                ) && 
                (
                    this.MisType == input.MisType ||
                    (this.MisType != null &&
                    this.MisType.Equals(input.MisType))
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
                int hashCode = 41;
                if (this.Object != null)
                    hashCode = hashCode * 59 + this.Object.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.IsActive != null)
                    hashCode = hashCode * 59 + this.IsActive.GetHashCode();
                if (this.IsRecurrent != null)
                    hashCode = hashCode * 59 + this.IsRecurrent.GetHashCode();
                if (this.MisType != null)
                    hashCode = hashCode * 59 + this.MisType.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
