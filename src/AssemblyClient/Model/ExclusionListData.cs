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
    /// The exclusions resource details official exclusions from a school.
    /// </summary>
    [DataContract]
    public partial class ExclusionListData :  IEquatable<ExclusionListData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExclusionListData" /> class.
        /// </summary>
        /// <param name="_object">Object type.</param>
        /// <param name="id">Internal stable ID given to all exclusions on the Platform.</param>
        /// <param name="studentId">The ID of the student that the exclusion is attached to.</param>
        /// <param name="exclusionType">The exclusions type.</param>
        /// <param name="exclusionsReason">The exclusion reason.</param>
        /// <param name="startDate">The date on which the exclusions starts.</param>
        /// <param name="startSession">The session in which the exclusion starts.</param>
        /// <param name="endDate">The date on which the exclusion ends.</param>
        /// <param name="endSession">The session (AM/PM) in which the exclusion ends.</param>
        /// <param name="exclusionLength">The total length, in sessions, of the exclusion.</param>
        public ExclusionListData(string _object = default(string), int? id = default(int?), int? studentId = default(int?), string exclusionType = default(string), string exclusionsReason = default(string), string startDate = default(string), string startSession = default(string), string endDate = default(string), string endSession = default(string), int? exclusionLength = default(int?))
        {
            this._object = _object;
            this.id = id;
            this.student_id = studentId;
            this.exclusion_type = exclusionType;
            this.exclusions_reason = exclusionsReason;
            this.start_date = startDate;
            this.start_session = startSession;
            this.end_date = endDate;
            this.end_session = endSession;
            this.exclusion_length = exclusionLength;
        }
        
        /// <summary>
        /// Object type
        /// </summary>
        /// <value>Object type</value>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public string _object { get; set; }

        /// <summary>
        /// Internal stable ID given to all exclusions on the Platform
        /// </summary>
        /// <value>Internal stable ID given to all exclusions on the Platform</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? id { get; set; }

        /// <summary>
        /// The ID of the student that the exclusion is attached to
        /// </summary>
        /// <value>The ID of the student that the exclusion is attached to</value>
        [DataMember(Name="student_id", EmitDefaultValue=false)]
        public int? student_id { get; set; }

        /// <summary>
        /// The exclusions type
        /// </summary>
        /// <value>The exclusions type</value>
        [DataMember(Name="exclusion_type", EmitDefaultValue=false)]
        public string exclusion_type { get; set; }

        /// <summary>
        /// The exclusion reason
        /// </summary>
        /// <value>The exclusion reason</value>
        [DataMember(Name="exclusions_reason", EmitDefaultValue=false)]
        public string exclusions_reason { get; set; }

        /// <summary>
        /// The date on which the exclusions starts
        /// </summary>
        /// <value>The date on which the exclusions starts</value>
        [DataMember(Name="start_date", EmitDefaultValue=false)]
        public string start_date { get; set; }

        /// <summary>
        /// The session in which the exclusion starts
        /// </summary>
        /// <value>The session in which the exclusion starts</value>
        [DataMember(Name="start_session", EmitDefaultValue=false)]
        public string start_session { get; set; }

        /// <summary>
        /// The date on which the exclusion ends
        /// </summary>
        /// <value>The date on which the exclusion ends</value>
        [DataMember(Name="end_date", EmitDefaultValue=false)]
        public string end_date { get; set; }

        /// <summary>
        /// The session (AM/PM) in which the exclusion ends
        /// </summary>
        /// <value>The session (AM/PM) in which the exclusion ends</value>
        [DataMember(Name="end_session", EmitDefaultValue=false)]
        public string end_session { get; set; }

        /// <summary>
        /// The total length, in sessions, of the exclusion
        /// </summary>
        /// <value>The total length, in sessions, of the exclusion</value>
        [DataMember(Name="exclusion_length", EmitDefaultValue=false)]
        public int? exclusion_length { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExclusionListData {\n");
            sb.Append("  _object: ").Append(_object).Append("\n");
            sb.Append("  id: ").Append(id).Append("\n");
            sb.Append("  student_id: ").Append(student_id).Append("\n");
            sb.Append("  exclusion_type: ").Append(exclusion_type).Append("\n");
            sb.Append("  exclusions_reason: ").Append(exclusions_reason).Append("\n");
            sb.Append("  start_date: ").Append(start_date).Append("\n");
            sb.Append("  start_session: ").Append(start_session).Append("\n");
            sb.Append("  end_date: ").Append(end_date).Append("\n");
            sb.Append("  end_session: ").Append(end_session).Append("\n");
            sb.Append("  exclusion_length: ").Append(exclusion_length).Append("\n");
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
            return this.Equals(input as ExclusionListData);
        }

        /// <summary>
        /// Returns true if ExclusionListData instances are equal
        /// </summary>
        /// <param name="input">Instance of ExclusionListData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExclusionListData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._object == input._object ||
                    (this._object != null &&
                    this._object.Equals(input._object))
                ) && 
                (
                    this.id == input.id ||
                    (this.id != null &&
                    this.id.Equals(input.id))
                ) && 
                (
                    this.student_id == input.student_id ||
                    (this.student_id != null &&
                    this.student_id.Equals(input.student_id))
                ) && 
                (
                    this.exclusion_type == input.exclusion_type ||
                    (this.exclusion_type != null &&
                    this.exclusion_type.Equals(input.exclusion_type))
                ) && 
                (
                    this.exclusions_reason == input.exclusions_reason ||
                    (this.exclusions_reason != null &&
                    this.exclusions_reason.Equals(input.exclusions_reason))
                ) && 
                (
                    this.start_date == input.start_date ||
                    (this.start_date != null &&
                    this.start_date.Equals(input.start_date))
                ) && 
                (
                    this.start_session == input.start_session ||
                    (this.start_session != null &&
                    this.start_session.Equals(input.start_session))
                ) && 
                (
                    this.end_date == input.end_date ||
                    (this.end_date != null &&
                    this.end_date.Equals(input.end_date))
                ) && 
                (
                    this.end_session == input.end_session ||
                    (this.end_session != null &&
                    this.end_session.Equals(input.end_session))
                ) && 
                (
                    this.exclusion_length == input.exclusion_length ||
                    (this.exclusion_length != null &&
                    this.exclusion_length.Equals(input.exclusion_length))
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
                if (this._object != null)
                    hashCode = hashCode * 59 + this._object.GetHashCode();
                if (this.id != null)
                    hashCode = hashCode * 59 + this.id.GetHashCode();
                if (this.student_id != null)
                    hashCode = hashCode * 59 + this.student_id.GetHashCode();
                if (this.exclusion_type != null)
                    hashCode = hashCode * 59 + this.exclusion_type.GetHashCode();
                if (this.exclusions_reason != null)
                    hashCode = hashCode * 59 + this.exclusions_reason.GetHashCode();
                if (this.start_date != null)
                    hashCode = hashCode * 59 + this.start_date.GetHashCode();
                if (this.start_session != null)
                    hashCode = hashCode * 59 + this.start_session.GetHashCode();
                if (this.end_date != null)
                    hashCode = hashCode * 59 + this.end_date.GetHashCode();
                if (this.end_session != null)
                    hashCode = hashCode * 59 + this.end_session.GetHashCode();
                if (this.exclusion_length != null)
                    hashCode = hashCode * 59 + this.exclusion_length.GetHashCode();
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
