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
    /// A year group object represents the pastoral year group that a student belongs to.
    /// </summary>
    [DataContract]
    public partial class YearGroupListData :  IEquatable<YearGroupListData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="YearGroupListData" /> class.
        /// </summary>
        /// <param name="_object">Object type.</param>
        /// <param name="code">The code of the year that the student belongs to.</param>
        /// <param name="name">The name of internal year group that the student belongs to.</param>
        /// <param name="studentIds">The IDs of students associated with the year group.</param>
        /// <param name="supervisorIds">The IDs of supervisors associated with the year group.</param>
        public YearGroupListData(string _object = default(string), string code = default(string), string name = default(string), List<int?> studentIds = default(List<int?>), List<int?> supervisorIds = default(List<int?>))
        {
            this.Object = _object;
            this.Code = code;
            this.Name = name;
            this.StudentIds = studentIds;
            this.SupervisorIds = supervisorIds;
        }
        
        /// <summary>
        /// Object type
        /// </summary>
        /// <value>Object type</value>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public string Object { get; set; }

        /// <summary>
        /// The code of the year that the student belongs to
        /// </summary>
        /// <value>The code of the year that the student belongs to</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// The name of internal year group that the student belongs to
        /// </summary>
        /// <value>The name of internal year group that the student belongs to</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The IDs of students associated with the year group
        /// </summary>
        /// <value>The IDs of students associated with the year group</value>
        [DataMember(Name="student_ids", EmitDefaultValue=false)]
        public List<int?> StudentIds { get; set; }

        /// <summary>
        /// The IDs of supervisors associated with the year group
        /// </summary>
        /// <value>The IDs of supervisors associated with the year group</value>
        [DataMember(Name="supervisor_ids", EmitDefaultValue=false)]
        public List<int?> SupervisorIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class YearGroupListData {\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  StudentIds: ").Append(StudentIds).Append("\n");
            sb.Append("  SupervisorIds: ").Append(SupervisorIds).Append("\n");
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
            return this.Equals(input as YearGroupListData);
        }

        /// <summary>
        /// Returns true if YearGroupListData instances are equal
        /// </summary>
        /// <param name="input">Instance of YearGroupListData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(YearGroupListData input)
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
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.StudentIds == input.StudentIds ||
                    this.StudentIds != null &&
                    this.StudentIds.SequenceEqual(input.StudentIds)
                ) && 
                (
                    this.SupervisorIds == input.SupervisorIds ||
                    this.SupervisorIds != null &&
                    this.SupervisorIds.SequenceEqual(input.SupervisorIds)
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
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.StudentIds != null)
                    hashCode = hashCode * 59 + this.StudentIds.GetHashCode();
                if (this.SupervisorIds != null)
                    hashCode = hashCode * 59 + this.SupervisorIds.GetHashCode();
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
