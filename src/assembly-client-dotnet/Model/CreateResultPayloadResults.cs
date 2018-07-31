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
using SwaggerDateConverter = assembly-client-dotnet.Client.SwaggerDateConverter;

namespace assembly-client-dotnet.Model
{
    /// <summary>
    /// A result combines the other assessment principles and attaches them to a student.
    /// </summary>
    [DataContract]
    public partial class CreateResultPayloadResults :  IEquatable<CreateResultPayloadResults>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateResultPayloadResults" /> class.
        /// </summary>
        /// <param name="_object">Object type.</param>
        /// <param name="id">Internal stable ID given to all results on the Platform.</param>
        /// <param name="studentId">The ID of the student that the result is attached to.</param>
        /// <param name="subjectId">The ID of the subject that the result is attached to.</param>
        /// <param name="assessmentId">The ID of the assessment that the result is attached to.</param>
        /// <param name="assessmentPointRank">The rank of the assessment point.</param>
        /// <param name="aspectId">The ID of the aspect that the result is attached to.</param>
        /// <param name="gradeId">The ID of the grade.</param>
        /// <param name="resultDate">The date on which the result was recorded in the MIS or standardised assessment system.</param>
        /// <param name="createdAt">The date and time that the result was first created on Assembly.</param>
        /// <param name="updatedAt">The date and time that the result was last updated on Assembly.</param>
        public CreateResultPayloadResults(string _object = default(string), int? id = default(int?), int? studentId = default(int?), int? subjectId = default(int?), int? assessmentId = default(int?), int? assessmentPointRank = default(int?), int? aspectId = default(int?), int? gradeId = default(int?), DateTime? resultDate = default(DateTime?), DateTime? createdAt = default(DateTime?), DateTime? updatedAt = default(DateTime?))
        {
            this.Object = _object;
            this.Id = id;
            this.StudentId = studentId;
            this.SubjectId = subjectId;
            this.AssessmentId = assessmentId;
            this.AssessmentPointRank = assessmentPointRank;
            this.AspectId = aspectId;
            this.GradeId = gradeId;
            this.ResultDate = resultDate;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }
        
        /// <summary>
        /// Object type
        /// </summary>
        /// <value>Object type</value>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public string Object { get; set; }

        /// <summary>
        /// Internal stable ID given to all results on the Platform
        /// </summary>
        /// <value>Internal stable ID given to all results on the Platform</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// The ID of the student that the result is attached to
        /// </summary>
        /// <value>The ID of the student that the result is attached to</value>
        [DataMember(Name="student_id", EmitDefaultValue=false)]
        public int? StudentId { get; set; }

        /// <summary>
        /// The ID of the subject that the result is attached to
        /// </summary>
        /// <value>The ID of the subject that the result is attached to</value>
        [DataMember(Name="subject_id", EmitDefaultValue=false)]
        public int? SubjectId { get; set; }

        /// <summary>
        /// The ID of the assessment that the result is attached to
        /// </summary>
        /// <value>The ID of the assessment that the result is attached to</value>
        [DataMember(Name="assessment_id", EmitDefaultValue=false)]
        public int? AssessmentId { get; set; }

        /// <summary>
        /// The rank of the assessment point
        /// </summary>
        /// <value>The rank of the assessment point</value>
        [DataMember(Name="assessment_point_rank", EmitDefaultValue=false)]
        public int? AssessmentPointRank { get; set; }

        /// <summary>
        /// The ID of the aspect that the result is attached to
        /// </summary>
        /// <value>The ID of the aspect that the result is attached to</value>
        [DataMember(Name="aspect_id", EmitDefaultValue=false)]
        public int? AspectId { get; set; }

        /// <summary>
        /// The ID of the grade
        /// </summary>
        /// <value>The ID of the grade</value>
        [DataMember(Name="grade_id", EmitDefaultValue=false)]
        public int? GradeId { get; set; }

        /// <summary>
        /// The date on which the result was recorded in the MIS or standardised assessment system
        /// </summary>
        /// <value>The date on which the result was recorded in the MIS or standardised assessment system</value>
        [DataMember(Name="result_date", EmitDefaultValue=false)]
        public DateTime? ResultDate { get; set; }

        /// <summary>
        /// The date and time that the result was first created on Assembly
        /// </summary>
        /// <value>The date and time that the result was first created on Assembly</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The date and time that the result was last updated on Assembly
        /// </summary>
        /// <value>The date and time that the result was last updated on Assembly</value>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateResultPayloadResults {\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  StudentId: ").Append(StudentId).Append("\n");
            sb.Append("  SubjectId: ").Append(SubjectId).Append("\n");
            sb.Append("  AssessmentId: ").Append(AssessmentId).Append("\n");
            sb.Append("  AssessmentPointRank: ").Append(AssessmentPointRank).Append("\n");
            sb.Append("  AspectId: ").Append(AspectId).Append("\n");
            sb.Append("  GradeId: ").Append(GradeId).Append("\n");
            sb.Append("  ResultDate: ").Append(ResultDate).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
            return this.Equals(input as CreateResultPayloadResults);
        }

        /// <summary>
        /// Returns true if CreateResultPayloadResults instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateResultPayloadResults to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateResultPayloadResults input)
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
                    this.StudentId == input.StudentId ||
                    (this.StudentId != null &&
                    this.StudentId.Equals(input.StudentId))
                ) && 
                (
                    this.SubjectId == input.SubjectId ||
                    (this.SubjectId != null &&
                    this.SubjectId.Equals(input.SubjectId))
                ) && 
                (
                    this.AssessmentId == input.AssessmentId ||
                    (this.AssessmentId != null &&
                    this.AssessmentId.Equals(input.AssessmentId))
                ) && 
                (
                    this.AssessmentPointRank == input.AssessmentPointRank ||
                    (this.AssessmentPointRank != null &&
                    this.AssessmentPointRank.Equals(input.AssessmentPointRank))
                ) && 
                (
                    this.AspectId == input.AspectId ||
                    (this.AspectId != null &&
                    this.AspectId.Equals(input.AspectId))
                ) && 
                (
                    this.GradeId == input.GradeId ||
                    (this.GradeId != null &&
                    this.GradeId.Equals(input.GradeId))
                ) && 
                (
                    this.ResultDate == input.ResultDate ||
                    (this.ResultDate != null &&
                    this.ResultDate.Equals(input.ResultDate))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
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
                if (this.StudentId != null)
                    hashCode = hashCode * 59 + this.StudentId.GetHashCode();
                if (this.SubjectId != null)
                    hashCode = hashCode * 59 + this.SubjectId.GetHashCode();
                if (this.AssessmentId != null)
                    hashCode = hashCode * 59 + this.AssessmentId.GetHashCode();
                if (this.AssessmentPointRank != null)
                    hashCode = hashCode * 59 + this.AssessmentPointRank.GetHashCode();
                if (this.AspectId != null)
                    hashCode = hashCode * 59 + this.AspectId.GetHashCode();
                if (this.GradeId != null)
                    hashCode = hashCode * 59 + this.GradeId.GetHashCode();
                if (this.ResultDate != null)
                    hashCode = hashCode * 59 + this.ResultDate.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
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
