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
    /// An academic year object represents a school year within a particular school.
    /// </summary>
    [DataContract]
    public partial class AcademicYearListData :  IEquatable<AcademicYearListData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AcademicYearListData" /> class.
        /// </summary>
        /// <param name="id">Internal stable ID given to academic year on Platform.</param>
        /// <param name="name">Name of academic year.</param>
        /// <param name="startDate">Date on which academic year starts.</param>
        /// <param name="endDate">Date on which academic year ends.</param>
        /// <param name="terms">Provides details of the individual terms that make up the academic year where available (currently for SIMS schools only).</param>
        public AcademicYearListData(int? id = default(int?), string name = default(string), DateTime? startDate = default(DateTime?), DateTime? endDate = default(DateTime?), List<AcademicYearTerms> terms = default(List<AcademicYearTerms>))
        {
            this.id = id;
            this.name = name;
            this.start_date = startDate;
            this.end_date = endDate;
            this.terms = terms;
        }
        
        /// <summary>
        /// Internal stable ID given to academic year on Platform
        /// </summary>
        /// <value>Internal stable ID given to academic year on Platform</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? id { get; set; }

        /// <summary>
        /// Name of academic year
        /// </summary>
        /// <value>Name of academic year</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string name { get; set; }

        /// <summary>
        /// Date on which academic year starts
        /// </summary>
        /// <value>Date on which academic year starts</value>
        [DataMember(Name="start_date", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? start_date { get; set; }

        /// <summary>
        /// Date on which academic year ends
        /// </summary>
        /// <value>Date on which academic year ends</value>
        [DataMember(Name="end_date", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? end_date { get; set; }

        /// <summary>
        /// Provides details of the individual terms that make up the academic year where available (currently for SIMS schools only)
        /// </summary>
        /// <value>Provides details of the individual terms that make up the academic year where available (currently for SIMS schools only)</value>
        [DataMember(Name="terms", EmitDefaultValue=false)]
        public List<AcademicYearTerms> terms { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AcademicYearListData {\n");
            sb.Append("  id: ").Append(id).Append("\n");
            sb.Append("  name: ").Append(name).Append("\n");
            sb.Append("  start_date: ").Append(start_date).Append("\n");
            sb.Append("  end_date: ").Append(end_date).Append("\n");
            sb.Append("  terms: ").Append(terms).Append("\n");
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
            return this.Equals(input as AcademicYearListData);
        }

        /// <summary>
        /// Returns true if AcademicYearListData instances are equal
        /// </summary>
        /// <param name="input">Instance of AcademicYearListData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AcademicYearListData input)
        {
            if (input == null)
                return false;

            return 
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
                    this.terms == input.terms ||
                    this.terms != null &&
                    this.terms.SequenceEqual(input.terms)
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
                if (this.id != null)
                    hashCode = hashCode * 59 + this.id.GetHashCode();
                if (this.name != null)
                    hashCode = hashCode * 59 + this.name.GetHashCode();
                if (this.start_date != null)
                    hashCode = hashCode * 59 + this.start_date.GetHashCode();
                if (this.end_date != null)
                    hashCode = hashCode * 59 + this.end_date.GetHashCode();
                if (this.terms != null)
                    hashCode = hashCode * 59 + this.terms.GetHashCode();
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
