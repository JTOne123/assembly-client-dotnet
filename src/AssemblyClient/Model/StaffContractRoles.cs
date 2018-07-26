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
    public partial class StaffContractRoles :  IEquatable<StaffContractRoles>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StaffContractRoles" /> class.
        /// </summary>
        /// <param name="_object">Object type.</param>
        /// <param name="roleType">Type of role.</param>
        /// <param name="startDate">No description.</param>
        /// <param name="endDate">No description.</param>
        public StaffContractRoles(string _object = default(string), string roleType = default(string), DateTime? startDate = default(DateTime?), DateTime? endDate = default(DateTime?))
        {
            this._object = _object;
            this.role_type = roleType;
            this.start_date = startDate;
            this.end_date = endDate;
        }
        
        /// <summary>
        /// Object type
        /// </summary>
        /// <value>Object type</value>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public string _object { get; set; }

        /// <summary>
        /// Type of role
        /// </summary>
        /// <value>Type of role</value>
        [DataMember(Name="role_type", EmitDefaultValue=false)]
        public string role_type { get; set; }

        /// <summary>
        /// No description
        /// </summary>
        /// <value>No description</value>
        [DataMember(Name="start_date", EmitDefaultValue=false)]
        public DateTime? start_date { get; set; }

        /// <summary>
        /// No description
        /// </summary>
        /// <value>No description</value>
        [DataMember(Name="end_date", EmitDefaultValue=false)]
        public DateTime? end_date { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StaffContractRoles {\n");
            sb.Append("  _object: ").Append(_object).Append("\n");
            sb.Append("  role_type: ").Append(role_type).Append("\n");
            sb.Append("  start_date: ").Append(start_date).Append("\n");
            sb.Append("  end_date: ").Append(end_date).Append("\n");
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
            return this.Equals(input as StaffContractRoles);
        }

        /// <summary>
        /// Returns true if StaffContractRoles instances are equal
        /// </summary>
        /// <param name="input">Instance of StaffContractRoles to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StaffContractRoles input)
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
                    this.role_type == input.role_type ||
                    (this.role_type != null &&
                    this.role_type.Equals(input.role_type))
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
                if (this.role_type != null)
                    hashCode = hashCode * 59 + this.role_type.GetHashCode();
                if (this.start_date != null)
                    hashCode = hashCode * 59 + this.start_date.GetHashCode();
                if (this.end_date != null)
                    hashCode = hashCode * 59 + this.end_date.GetHashCode();
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
