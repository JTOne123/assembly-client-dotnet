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
    public partial class ContactStudents :  IEquatable<ContactStudents>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactStudents" /> class.
        /// </summary>
        /// <param name="_object">Object type.</param>
        /// <param name="studentId">Internal stable ID given to all students on the Platform.</param>
        /// <param name="relationship">relationship.</param>
        public ContactStudents(string _object = default(string), int? studentId = default(int?), ContactRelationship relationship = default(ContactRelationship))
        {
            this.Object = _object;
            this.StudentId = studentId;
            this.Relationship = relationship;
        }
        
        /// <summary>
        /// Object type
        /// </summary>
        /// <value>Object type</value>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public string Object { get; set; }

        /// <summary>
        /// Internal stable ID given to all students on the Platform
        /// </summary>
        /// <value>Internal stable ID given to all students on the Platform</value>
        [DataMember(Name="student_id", EmitDefaultValue=false)]
        public int? StudentId { get; set; }

        /// <summary>
        /// Gets or Sets Relationship
        /// </summary>
        [DataMember(Name="relationship", EmitDefaultValue=false)]
        public ContactRelationship Relationship { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactStudents {\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  StudentId: ").Append(StudentId).Append("\n");
            sb.Append("  Relationship: ").Append(Relationship).Append("\n");
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
            return this.Equals(input as ContactStudents);
        }

        /// <summary>
        /// Returns true if ContactStudents instances are equal
        /// </summary>
        /// <param name="input">Instance of ContactStudents to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactStudents input)
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
                    this.StudentId == input.StudentId ||
                    (this.StudentId != null &&
                    this.StudentId.Equals(input.StudentId))
                ) && 
                (
                    this.Relationship == input.Relationship ||
                    (this.Relationship != null &&
                    this.Relationship.Equals(input.Relationship))
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
                if (this.StudentId != null)
                    hashCode = hashCode * 59 + this.StudentId.GetHashCode();
                if (this.Relationship != null)
                    hashCode = hashCode * 59 + this.Relationship.GetHashCode();
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
