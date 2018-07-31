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
    /// Demographic information about a staff member.
    /// </summary>
    [DataContract]
    public partial class StaffMemberDemographics :  IEquatable<StaffMemberDemographics>, IValidatableObject
    {
        /// <summary>
        /// The gender of a staff member *Values*  |Value|Description| |- --|- --| |&#x60;M&#x60;|Male| |&#x60;F&#x60;|Female| 
        /// </summary>
        /// <value>The gender of a staff member *Values*  |Value|Description| |- --|- --| |&#x60;M&#x60;|Male| |&#x60;F&#x60;|Female| </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum GenderEnum
        {
            
            /// <summary>
            /// Enum M for value: M
            /// </summary>
            [EnumMember(Value = "M")]
            M = 1,
            
            /// <summary>
            /// Enum F for value: F
            /// </summary>
            [EnumMember(Value = "F")]
            F = 2
        }

        /// <summary>
        /// The gender of a staff member *Values*  |Value|Description| |- --|- --| |&#x60;M&#x60;|Male| |&#x60;F&#x60;|Female| 
        /// </summary>
        /// <value>The gender of a staff member *Values*  |Value|Description| |- --|- --| |&#x60;M&#x60;|Male| |&#x60;F&#x60;|Female| </value>
        [DataMember(Name="gender", EmitDefaultValue=false)]
        public GenderEnum? Gender { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="StaffMemberDemographics" /> class.
        /// </summary>
        /// <param name="gender">The gender of a staff member *Values*  |Value|Description| |- --|- --| |&#x60;M&#x60;|Male| |&#x60;F&#x60;|Female| .</param>
        /// <param name="ethnicityCode">A detailed, Dfe standardised way of categorising the ethnicity of a student .</param>
        /// <param name="ethnicityGroup">A broader categorisation of ethnicity that is standardised across the country, with all ethnicity codes grouped in to 8 sections.</param>
        /// <param name="disability">The disability status of a staff member.</param>
        public StaffMemberDemographics(GenderEnum? gender = default(GenderEnum?), string ethnicityCode = default(string), string ethnicityGroup = default(string), string disability = default(string))
        {
            this.Gender = gender;
            this.EthnicityCode = ethnicityCode;
            this.EthnicityGroup = ethnicityGroup;
            this.Disability = disability;
        }
        

        /// <summary>
        /// A detailed, Dfe standardised way of categorising the ethnicity of a student 
        /// </summary>
        /// <value>A detailed, Dfe standardised way of categorising the ethnicity of a student </value>
        [DataMember(Name="ethnicity_code", EmitDefaultValue=false)]
        public string EthnicityCode { get; set; }

        /// <summary>
        /// A broader categorisation of ethnicity that is standardised across the country, with all ethnicity codes grouped in to 8 sections
        /// </summary>
        /// <value>A broader categorisation of ethnicity that is standardised across the country, with all ethnicity codes grouped in to 8 sections</value>
        [DataMember(Name="ethnicity_group", EmitDefaultValue=false)]
        public string EthnicityGroup { get; set; }

        /// <summary>
        /// The disability status of a staff member
        /// </summary>
        /// <value>The disability status of a staff member</value>
        [DataMember(Name="disability", EmitDefaultValue=false)]
        public string Disability { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StaffMemberDemographics {\n");
            sb.Append("  Gender: ").Append(Gender).Append("\n");
            sb.Append("  EthnicityCode: ").Append(EthnicityCode).Append("\n");
            sb.Append("  EthnicityGroup: ").Append(EthnicityGroup).Append("\n");
            sb.Append("  Disability: ").Append(Disability).Append("\n");
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
            return this.Equals(input as StaffMemberDemographics);
        }

        /// <summary>
        /// Returns true if StaffMemberDemographics instances are equal
        /// </summary>
        /// <param name="input">Instance of StaffMemberDemographics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StaffMemberDemographics input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Gender == input.Gender ||
                    (this.Gender != null &&
                    this.Gender.Equals(input.Gender))
                ) && 
                (
                    this.EthnicityCode == input.EthnicityCode ||
                    (this.EthnicityCode != null &&
                    this.EthnicityCode.Equals(input.EthnicityCode))
                ) && 
                (
                    this.EthnicityGroup == input.EthnicityGroup ||
                    (this.EthnicityGroup != null &&
                    this.EthnicityGroup.Equals(input.EthnicityGroup))
                ) && 
                (
                    this.Disability == input.Disability ||
                    (this.Disability != null &&
                    this.Disability.Equals(input.Disability))
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
                if (this.Gender != null)
                    hashCode = hashCode * 59 + this.Gender.GetHashCode();
                if (this.EthnicityCode != null)
                    hashCode = hashCode * 59 + this.EthnicityCode.GetHashCode();
                if (this.EthnicityGroup != null)
                    hashCode = hashCode * 59 + this.EthnicityGroup.GetHashCode();
                if (this.Disability != null)
                    hashCode = hashCode * 59 + this.Disability.GetHashCode();
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
