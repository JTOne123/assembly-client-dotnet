/* 
 * Assembly Developer API
 *
 * The Assembly API is built around the REST and a collection of open standards/protocols in order to comply with as many consumers as possible.
 *
 * OpenAPI spec version: 1.0.0
 * Contact: help@assembly.education
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = AssemblyClient.Client.OpenAPIDateConverter;

namespace AssemblyClient.Model
{
    /// <summary>
    /// StaffQualification
    /// </summary>
    [DataContract]
    public partial class StaffQualification :  IEquatable<StaffQualification>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StaffQualification" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="qualificationCode">qualificationCode.</param>
        /// <param name="degreeClass">degreeClass.</param>
        /// <param name="firstSubjectCode">firstSubjectCode.</param>
        /// <param name="firstSubjectName">firstSubjectName.</param>
        /// <param name="secondSubjectCode">secondSubjectCode.</param>
        /// <param name="secondSubjectName">secondSubjectName.</param>
        public StaffQualification(int? id = default(int?), string qualificationCode = default(string), string degreeClass = default(string), string firstSubjectCode = default(string), string firstSubjectName = default(string), string secondSubjectCode = default(string), string secondSubjectName = default(string))
        {
            this.Id = id;
            this.QualificationCode = qualificationCode;
            this.DegreeClass = degreeClass;
            this.FirstSubjectCode = firstSubjectCode;
            this.FirstSubjectName = firstSubjectName;
            this.SecondSubjectCode = secondSubjectCode;
            this.SecondSubjectName = secondSubjectName;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets QualificationCode
        /// </summary>
        [DataMember(Name="qualification_code", EmitDefaultValue=false)]
        public string QualificationCode { get; set; }

        /// <summary>
        /// Gets or Sets DegreeClass
        /// </summary>
        [DataMember(Name="degree_class", EmitDefaultValue=false)]
        public string DegreeClass { get; set; }

        /// <summary>
        /// Gets or Sets FirstSubjectCode
        /// </summary>
        [DataMember(Name="first_subject_code", EmitDefaultValue=false)]
        public string FirstSubjectCode { get; set; }

        /// <summary>
        /// Gets or Sets FirstSubjectName
        /// </summary>
        [DataMember(Name="first_subject_name", EmitDefaultValue=false)]
        public string FirstSubjectName { get; set; }

        /// <summary>
        /// Gets or Sets SecondSubjectCode
        /// </summary>
        [DataMember(Name="second_subject_code", EmitDefaultValue=false)]
        public string SecondSubjectCode { get; set; }

        /// <summary>
        /// Gets or Sets SecondSubjectName
        /// </summary>
        [DataMember(Name="second_subject_name", EmitDefaultValue=false)]
        public string SecondSubjectName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StaffQualification {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  QualificationCode: ").Append(QualificationCode).Append("\n");
            sb.Append("  DegreeClass: ").Append(DegreeClass).Append("\n");
            sb.Append("  FirstSubjectCode: ").Append(FirstSubjectCode).Append("\n");
            sb.Append("  FirstSubjectName: ").Append(FirstSubjectName).Append("\n");
            sb.Append("  SecondSubjectCode: ").Append(SecondSubjectCode).Append("\n");
            sb.Append("  SecondSubjectName: ").Append(SecondSubjectName).Append("\n");
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
            return this.Equals(input as StaffQualification);
        }

        /// <summary>
        /// Returns true if StaffQualification instances are equal
        /// </summary>
        /// <param name="input">Instance of StaffQualification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StaffQualification input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.QualificationCode == input.QualificationCode ||
                    (this.QualificationCode != null &&
                    this.QualificationCode.Equals(input.QualificationCode))
                ) && 
                (
                    this.DegreeClass == input.DegreeClass ||
                    (this.DegreeClass != null &&
                    this.DegreeClass.Equals(input.DegreeClass))
                ) && 
                (
                    this.FirstSubjectCode == input.FirstSubjectCode ||
                    (this.FirstSubjectCode != null &&
                    this.FirstSubjectCode.Equals(input.FirstSubjectCode))
                ) && 
                (
                    this.FirstSubjectName == input.FirstSubjectName ||
                    (this.FirstSubjectName != null &&
                    this.FirstSubjectName.Equals(input.FirstSubjectName))
                ) && 
                (
                    this.SecondSubjectCode == input.SecondSubjectCode ||
                    (this.SecondSubjectCode != null &&
                    this.SecondSubjectCode.Equals(input.SecondSubjectCode))
                ) && 
                (
                    this.SecondSubjectName == input.SecondSubjectName ||
                    (this.SecondSubjectName != null &&
                    this.SecondSubjectName.Equals(input.SecondSubjectName))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.QualificationCode != null)
                    hashCode = hashCode * 59 + this.QualificationCode.GetHashCode();
                if (this.DegreeClass != null)
                    hashCode = hashCode * 59 + this.DegreeClass.GetHashCode();
                if (this.FirstSubjectCode != null)
                    hashCode = hashCode * 59 + this.FirstSubjectCode.GetHashCode();
                if (this.FirstSubjectName != null)
                    hashCode = hashCode * 59 + this.FirstSubjectName.GetHashCode();
                if (this.SecondSubjectCode != null)
                    hashCode = hashCode * 59 + this.SecondSubjectCode.GetHashCode();
                if (this.SecondSubjectName != null)
                    hashCode = hashCode * 59 + this.SecondSubjectName.GetHashCode();
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