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
    /// No description
    /// </summary>
    [DataContract]
    public partial class StaffMemberQualificationInfoQualifications :  IEquatable<StaffMemberQualificationInfoQualifications>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StaffMemberQualificationInfoQualifications" /> class.
        /// </summary>
        /// <param name="_object">Object type.</param>
        /// <param name="id">Internal stable ID given to all staff qualifications on the Platform.</param>
        /// <param name="qualificationCode">A code describing the type of qualification .</param>
        /// <param name="degreeClass">Identifies the result of the qualification.</param>
        /// <param name="firstSubjectCode">A code identifying the main or joint main subject of the qualification.</param>
        /// <param name="firstSubjectName">The name of the subject.</param>
        /// <param name="secondSubjectCode">A code identifying the main or joint main subject of the qualification.</param>
        /// <param name="secondSubjectName">The name of the subject.</param>
        public StaffMemberQualificationInfoQualifications(string _object = default(string), int? id = default(int?), string qualificationCode = default(string), string degreeClass = default(string), string firstSubjectCode = default(string), string firstSubjectName = default(string), string secondSubjectCode = default(string), string secondSubjectName = default(string))
        {
            this._object = _object;
            this.id = id;
            this.qualification_code = qualificationCode;
            this.degree_class = degreeClass;
            this.first_subject_code = firstSubjectCode;
            this.first_subject_name = firstSubjectName;
            this.second_subject_code = secondSubjectCode;
            this.second_subject_name = secondSubjectName;
        }
        
        /// <summary>
        /// Object type
        /// </summary>
        /// <value>Object type</value>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public string _object { get; set; }

        /// <summary>
        /// Internal stable ID given to all staff qualifications on the Platform
        /// </summary>
        /// <value>Internal stable ID given to all staff qualifications on the Platform</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? id { get; set; }

        /// <summary>
        /// A code describing the type of qualification 
        /// </summary>
        /// <value>A code describing the type of qualification </value>
        [DataMember(Name="qualification_code", EmitDefaultValue=false)]
        public string qualification_code { get; set; }

        /// <summary>
        /// Identifies the result of the qualification
        /// </summary>
        /// <value>Identifies the result of the qualification</value>
        [DataMember(Name="degree_class", EmitDefaultValue=false)]
        public string degree_class { get; set; }

        /// <summary>
        /// A code identifying the main or joint main subject of the qualification
        /// </summary>
        /// <value>A code identifying the main or joint main subject of the qualification</value>
        [DataMember(Name="first_subject_code", EmitDefaultValue=false)]
        public string first_subject_code { get; set; }

        /// <summary>
        /// The name of the subject
        /// </summary>
        /// <value>The name of the subject</value>
        [DataMember(Name="first_subject_name", EmitDefaultValue=false)]
        public string first_subject_name { get; set; }

        /// <summary>
        /// A code identifying the main or joint main subject of the qualification
        /// </summary>
        /// <value>A code identifying the main or joint main subject of the qualification</value>
        [DataMember(Name="second_subject_code", EmitDefaultValue=false)]
        public string second_subject_code { get; set; }

        /// <summary>
        /// The name of the subject
        /// </summary>
        /// <value>The name of the subject</value>
        [DataMember(Name="second_subject_name", EmitDefaultValue=false)]
        public string second_subject_name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StaffMemberQualificationInfoQualifications {\n");
            sb.Append("  _object: ").Append(_object).Append("\n");
            sb.Append("  id: ").Append(id).Append("\n");
            sb.Append("  qualification_code: ").Append(qualification_code).Append("\n");
            sb.Append("  degree_class: ").Append(degree_class).Append("\n");
            sb.Append("  first_subject_code: ").Append(first_subject_code).Append("\n");
            sb.Append("  first_subject_name: ").Append(first_subject_name).Append("\n");
            sb.Append("  second_subject_code: ").Append(second_subject_code).Append("\n");
            sb.Append("  second_subject_name: ").Append(second_subject_name).Append("\n");
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
            return this.Equals(input as StaffMemberQualificationInfoQualifications);
        }

        /// <summary>
        /// Returns true if StaffMemberQualificationInfoQualifications instances are equal
        /// </summary>
        /// <param name="input">Instance of StaffMemberQualificationInfoQualifications to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StaffMemberQualificationInfoQualifications input)
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
                    this.qualification_code == input.qualification_code ||
                    (this.qualification_code != null &&
                    this.qualification_code.Equals(input.qualification_code))
                ) && 
                (
                    this.degree_class == input.degree_class ||
                    (this.degree_class != null &&
                    this.degree_class.Equals(input.degree_class))
                ) && 
                (
                    this.first_subject_code == input.first_subject_code ||
                    (this.first_subject_code != null &&
                    this.first_subject_code.Equals(input.first_subject_code))
                ) && 
                (
                    this.first_subject_name == input.first_subject_name ||
                    (this.first_subject_name != null &&
                    this.first_subject_name.Equals(input.first_subject_name))
                ) && 
                (
                    this.second_subject_code == input.second_subject_code ||
                    (this.second_subject_code != null &&
                    this.second_subject_code.Equals(input.second_subject_code))
                ) && 
                (
                    this.second_subject_name == input.second_subject_name ||
                    (this.second_subject_name != null &&
                    this.second_subject_name.Equals(input.second_subject_name))
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
                if (this.qualification_code != null)
                    hashCode = hashCode * 59 + this.qualification_code.GetHashCode();
                if (this.degree_class != null)
                    hashCode = hashCode * 59 + this.degree_class.GetHashCode();
                if (this.first_subject_code != null)
                    hashCode = hashCode * 59 + this.first_subject_code.GetHashCode();
                if (this.first_subject_name != null)
                    hashCode = hashCode * 59 + this.first_subject_name.GetHashCode();
                if (this.second_subject_code != null)
                    hashCode = hashCode * 59 + this.second_subject_code.GetHashCode();
                if (this.second_subject_name != null)
                    hashCode = hashCode * 59 + this.second_subject_name.GetHashCode();
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
