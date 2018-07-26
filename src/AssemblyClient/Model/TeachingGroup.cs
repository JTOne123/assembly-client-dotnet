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
    /// A teaching group object represents the grouping in which students are taught a subject.
    /// </summary>
    [DataContract]
    public partial class TeachingGroup :  IEquatable<TeachingGroup>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeachingGroup" /> class.
        /// </summary>
        /// <param name="_object">Object type.</param>
        /// <param name="id">Internal stable ID given to all teaching groups in the Platform.</param>
        /// <param name="name">Name of teaching group.</param>
        /// <param name="startDate">The start date of the teaching group.</param>
        /// <param name="endDate">The end date of the teaching group.</param>
        /// <param name="supervisorIds">The IDs of supervisors associated with the teaching group.</param>
        /// <param name="studentIds">The IDs of students associated with the teaching group.</param>
        /// <param name="subject">subject.</param>
        /// <param name="misLevel">The official examination or assessment &#39;level&#39; of the teaching group taken directly from the MIS.</param>
        public TeachingGroup(string _object = default(string), int? id = default(int?), string name = default(string), DateTime? startDate = default(DateTime?), DateTime? endDate = default(DateTime?), List<int?> supervisorIds = default(List<int?>), List<int?> studentIds = default(List<int?>), TeachingGroupSubject subject = default(TeachingGroupSubject), string misLevel = default(string))
        {
            this._object = _object;
            this.id = id;
            this.name = name;
            this.start_date = startDate;
            this.end_date = endDate;
            this.supervisor_ids = supervisorIds;
            this.student_ids = studentIds;
            this.subject = subject;
            this.mis_level = misLevel;
        }
        
        /// <summary>
        /// Object type
        /// </summary>
        /// <value>Object type</value>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public string _object { get; set; }

        /// <summary>
        /// Internal stable ID given to all teaching groups in the Platform
        /// </summary>
        /// <value>Internal stable ID given to all teaching groups in the Platform</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? id { get; set; }

        /// <summary>
        /// Name of teaching group
        /// </summary>
        /// <value>Name of teaching group</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string name { get; set; }

        /// <summary>
        /// The start date of the teaching group
        /// </summary>
        /// <value>The start date of the teaching group</value>
        [DataMember(Name="start_date", EmitDefaultValue=false)]
        public DateTime? start_date { get; set; }

        /// <summary>
        /// The end date of the teaching group
        /// </summary>
        /// <value>The end date of the teaching group</value>
        [DataMember(Name="end_date", EmitDefaultValue=false)]
        public DateTime? end_date { get; set; }

        /// <summary>
        /// The IDs of supervisors associated with the teaching group
        /// </summary>
        /// <value>The IDs of supervisors associated with the teaching group</value>
        [DataMember(Name="supervisor_ids", EmitDefaultValue=false)]
        public List<int?> supervisor_ids { get; set; }

        /// <summary>
        /// The IDs of students associated with the teaching group
        /// </summary>
        /// <value>The IDs of students associated with the teaching group</value>
        [DataMember(Name="student_ids", EmitDefaultValue=false)]
        public List<int?> student_ids { get; set; }

        /// <summary>
        /// Gets or Sets subject
        /// </summary>
        [DataMember(Name="subject", EmitDefaultValue=false)]
        public TeachingGroupSubject subject { get; set; }

        /// <summary>
        /// The official examination or assessment &#39;level&#39; of the teaching group taken directly from the MIS
        /// </summary>
        /// <value>The official examination or assessment &#39;level&#39; of the teaching group taken directly from the MIS</value>
        [DataMember(Name="mis_level", EmitDefaultValue=false)]
        public string mis_level { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TeachingGroup {\n");
            sb.Append("  _object: ").Append(_object).Append("\n");
            sb.Append("  id: ").Append(id).Append("\n");
            sb.Append("  name: ").Append(name).Append("\n");
            sb.Append("  start_date: ").Append(start_date).Append("\n");
            sb.Append("  end_date: ").Append(end_date).Append("\n");
            sb.Append("  supervisor_ids: ").Append(supervisor_ids).Append("\n");
            sb.Append("  student_ids: ").Append(student_ids).Append("\n");
            sb.Append("  subject: ").Append(subject).Append("\n");
            sb.Append("  mis_level: ").Append(mis_level).Append("\n");
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
            return this.Equals(input as TeachingGroup);
        }

        /// <summary>
        /// Returns true if TeachingGroup instances are equal
        /// </summary>
        /// <param name="input">Instance of TeachingGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TeachingGroup input)
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
                    this.name == input.name ||
                    (this.name != null &&
                    this.name.Equals(input.name))
                ) && 
                (
                    this.start_date == input.start_date ||
                    (this.start_date != null &&
                    this.start_date.Equals(input.start_date))
                ) && 
                (
                    this.end_date == input.end_date ||
                    (this.end_date != null &&
                    this.end_date.Equals(input.end_date))
                ) && 
                (
                    this.supervisor_ids == input.supervisor_ids ||
                    this.supervisor_ids != null &&
                    this.supervisor_ids.SequenceEqual(input.supervisor_ids)
                ) && 
                (
                    this.student_ids == input.student_ids ||
                    this.student_ids != null &&
                    this.student_ids.SequenceEqual(input.student_ids)
                ) && 
                (
                    this.subject == input.subject ||
                    (this.subject != null &&
                    this.subject.Equals(input.subject))
                ) && 
                (
                    this.mis_level == input.mis_level ||
                    (this.mis_level != null &&
                    this.mis_level.Equals(input.mis_level))
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
                if (this.name != null)
                    hashCode = hashCode * 59 + this.name.GetHashCode();
                if (this.start_date != null)
                    hashCode = hashCode * 59 + this.start_date.GetHashCode();
                if (this.end_date != null)
                    hashCode = hashCode * 59 + this.end_date.GetHashCode();
                if (this.supervisor_ids != null)
                    hashCode = hashCode * 59 + this.supervisor_ids.GetHashCode();
                if (this.student_ids != null)
                    hashCode = hashCode * 59 + this.student_ids.GetHashCode();
                if (this.subject != null)
                    hashCode = hashCode * 59 + this.subject.GetHashCode();
                if (this.mis_level != null)
                    hashCode = hashCode * 59 + this.mis_level.GetHashCode();
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
