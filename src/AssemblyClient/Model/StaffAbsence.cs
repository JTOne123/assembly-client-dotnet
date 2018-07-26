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
    /// Details of staff absences recorded on the MIS.
    /// </summary>
    [DataContract]
    public partial class StaffAbsence :  IEquatable<StaffAbsence>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StaffAbsence" /> class.
        /// </summary>
        /// <param name="_object">Object type.</param>
        /// <param name="id">Internal stable ID given to all absences on the Platform.</param>
        /// <param name="staffMemberId">The ID of the staff member who the absence is for.</param>
        /// <param name="startDate">The start date of the absence.</param>
        /// <param name="endDate">The end date of the absence.</param>
        /// <param name="workingDaysLost">Number of working days that were lost during the absence.</param>
        /// <param name="absenceCategory">The category of the absence.</param>
        /// <param name="illnessCategory">If the absence category was &#39;Illness&#39;, the specific code.</param>
        /// <param name="payRate">Whether or not the staff member was paid for the absence, and at what rate.</param>
        public StaffAbsence(string _object = default(string), int? id = default(int?), int? staffMemberId = default(int?), DateTime? startDate = default(DateTime?), DateTime? endDate = default(DateTime?), float? workingDaysLost = default(float?), string absenceCategory = default(string), string illnessCategory = default(string), string payRate = default(string))
        {
            this.Object = _object;
            this.Id = id;
            this.StaffMemberId = staffMemberId;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.WorkingDaysLost = workingDaysLost;
            this.AbsenceCategory = absenceCategory;
            this.IllnessCategory = illnessCategory;
            this.PayRate = payRate;
        }
        
        /// <summary>
        /// Object type
        /// </summary>
        /// <value>Object type</value>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public string Object { get; set; }

        /// <summary>
        /// Internal stable ID given to all absences on the Platform
        /// </summary>
        /// <value>Internal stable ID given to all absences on the Platform</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// The ID of the staff member who the absence is for
        /// </summary>
        /// <value>The ID of the staff member who the absence is for</value>
        [DataMember(Name="staff_member_id", EmitDefaultValue=false)]
        public int? StaffMemberId { get; set; }

        /// <summary>
        /// The start date of the absence
        /// </summary>
        /// <value>The start date of the absence</value>
        [DataMember(Name="start_date", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// The end date of the absence
        /// </summary>
        /// <value>The end date of the absence</value>
        [DataMember(Name="end_date", EmitDefaultValue=false)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Number of working days that were lost during the absence
        /// </summary>
        /// <value>Number of working days that were lost during the absence</value>
        [DataMember(Name="working_days_lost", EmitDefaultValue=false)]
        public float? WorkingDaysLost { get; set; }

        /// <summary>
        /// The category of the absence
        /// </summary>
        /// <value>The category of the absence</value>
        [DataMember(Name="absence_category", EmitDefaultValue=false)]
        public string AbsenceCategory { get; set; }

        /// <summary>
        /// If the absence category was &#39;Illness&#39;, the specific code
        /// </summary>
        /// <value>If the absence category was &#39;Illness&#39;, the specific code</value>
        [DataMember(Name="illness_category", EmitDefaultValue=false)]
        public string IllnessCategory { get; set; }

        /// <summary>
        /// Whether or not the staff member was paid for the absence, and at what rate
        /// </summary>
        /// <value>Whether or not the staff member was paid for the absence, and at what rate</value>
        [DataMember(Name="pay_rate", EmitDefaultValue=false)]
        public string PayRate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StaffAbsence {\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  StaffMemberId: ").Append(StaffMemberId).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  WorkingDaysLost: ").Append(WorkingDaysLost).Append("\n");
            sb.Append("  AbsenceCategory: ").Append(AbsenceCategory).Append("\n");
            sb.Append("  IllnessCategory: ").Append(IllnessCategory).Append("\n");
            sb.Append("  PayRate: ").Append(PayRate).Append("\n");
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
            return this.Equals(input as StaffAbsence);
        }

        /// <summary>
        /// Returns true if StaffAbsence instances are equal
        /// </summary>
        /// <param name="input">Instance of StaffAbsence to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StaffAbsence input)
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
                    this.StaffMemberId == input.StaffMemberId ||
                    (this.StaffMemberId != null &&
                    this.StaffMemberId.Equals(input.StaffMemberId))
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
                    this.WorkingDaysLost == input.WorkingDaysLost ||
                    (this.WorkingDaysLost != null &&
                    this.WorkingDaysLost.Equals(input.WorkingDaysLost))
                ) && 
                (
                    this.AbsenceCategory == input.AbsenceCategory ||
                    (this.AbsenceCategory != null &&
                    this.AbsenceCategory.Equals(input.AbsenceCategory))
                ) && 
                (
                    this.IllnessCategory == input.IllnessCategory ||
                    (this.IllnessCategory != null &&
                    this.IllnessCategory.Equals(input.IllnessCategory))
                ) && 
                (
                    this.PayRate == input.PayRate ||
                    (this.PayRate != null &&
                    this.PayRate.Equals(input.PayRate))
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
                if (this.StaffMemberId != null)
                    hashCode = hashCode * 59 + this.StaffMemberId.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.WorkingDaysLost != null)
                    hashCode = hashCode * 59 + this.WorkingDaysLost.GetHashCode();
                if (this.AbsenceCategory != null)
                    hashCode = hashCode * 59 + this.AbsenceCategory.GetHashCode();
                if (this.IllnessCategory != null)
                    hashCode = hashCode * 59 + this.IllnessCategory.GetHashCode();
                if (this.PayRate != null)
                    hashCode = hashCode * 59 + this.PayRate.GetHashCode();
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
