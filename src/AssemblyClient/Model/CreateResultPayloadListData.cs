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
    /// Payload for create Result request
    /// </summary>
    [DataContract]
    public partial class CreateResultPayloadListData :  IEquatable<CreateResultPayloadListData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateResultPayloadListData" /> class.
        /// </summary>
        /// <param name="subjectId">No description.</param>
        /// <param name="facetId">No description.</param>
        /// <param name="assessmentPointRank">No description.</param>
        /// <param name="assessmentId">No description.</param>
        /// <param name="results">No description.</param>
        public CreateResultPayloadListData(int? subjectId = default(int?), int? facetId = default(int?), int? assessmentPointRank = default(int?), int? assessmentId = default(int?), List<CreateResultPayloadResults> results = default(List<CreateResultPayloadResults>))
        {
            this.subject_id = subjectId;
            this.facet_id = facetId;
            this.assessment_point_rank = assessmentPointRank;
            this.assessment_id = assessmentId;
            this.results = results;
        }
        
        /// <summary>
        /// No description
        /// </summary>
        /// <value>No description</value>
        [DataMember(Name="subject_id", EmitDefaultValue=false)]
        public int? subject_id { get; set; }

        /// <summary>
        /// No description
        /// </summary>
        /// <value>No description</value>
        [DataMember(Name="facet_id", EmitDefaultValue=false)]
        public int? facet_id { get; set; }

        /// <summary>
        /// No description
        /// </summary>
        /// <value>No description</value>
        [DataMember(Name="assessment_point_rank", EmitDefaultValue=false)]
        public int? assessment_point_rank { get; set; }

        /// <summary>
        /// No description
        /// </summary>
        /// <value>No description</value>
        [DataMember(Name="assessment_id", EmitDefaultValue=false)]
        public int? assessment_id { get; set; }

        /// <summary>
        /// No description
        /// </summary>
        /// <value>No description</value>
        [DataMember(Name="results", EmitDefaultValue=false)]
        public List<CreateResultPayloadResults> results { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateResultPayloadListData {\n");
            sb.Append("  subject_id: ").Append(subject_id).Append("\n");
            sb.Append("  facet_id: ").Append(facet_id).Append("\n");
            sb.Append("  assessment_point_rank: ").Append(assessment_point_rank).Append("\n");
            sb.Append("  assessment_id: ").Append(assessment_id).Append("\n");
            sb.Append("  results: ").Append(results).Append("\n");
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
            return this.Equals(input as CreateResultPayloadListData);
        }

        /// <summary>
        /// Returns true if CreateResultPayloadListData instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateResultPayloadListData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateResultPayloadListData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.subject_id == input.subject_id ||
                    (this.subject_id != null &&
                    this.subject_id.Equals(input.subject_id))
                ) && 
                (
                    this.facet_id == input.facet_id ||
                    (this.facet_id != null &&
                    this.facet_id.Equals(input.facet_id))
                ) && 
                (
                    this.assessment_point_rank == input.assessment_point_rank ||
                    (this.assessment_point_rank != null &&
                    this.assessment_point_rank.Equals(input.assessment_point_rank))
                ) && 
                (
                    this.assessment_id == input.assessment_id ||
                    (this.assessment_id != null &&
                    this.assessment_id.Equals(input.assessment_id))
                ) && 
                (
                    this.results == input.results ||
                    this.results != null &&
                    this.results.SequenceEqual(input.results)
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
                if (this.subject_id != null)
                    hashCode = hashCode * 59 + this.subject_id.GetHashCode();
                if (this.facet_id != null)
                    hashCode = hashCode * 59 + this.facet_id.GetHashCode();
                if (this.assessment_point_rank != null)
                    hashCode = hashCode * 59 + this.assessment_point_rank.GetHashCode();
                if (this.assessment_id != null)
                    hashCode = hashCode * 59 + this.assessment_id.GetHashCode();
                if (this.results != null)
                    hashCode = hashCode * 59 + this.results.GetHashCode();
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
