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
    /// All results belong to one of four facets, with each facet reflecting a different type of grade. Facets can be used to compare 2 grades of the same assessment.
    /// </summary>
    [DataContract]
    public partial class Facet :  IEquatable<Facet>, IValidatableObject
    {
        /// <summary>
        /// The name of the facet *Values*  |Value|Description| |- --|- --| |&#x60;achieved&#x60;|Result has been achieved| |&#x60;target&#x60;|Result has been set as a target to achieve| |&#x60;prediction&#x60;|Result is a prediction| |&#x60;baseline&#x60;|Result is a baseline comparison value| 
        /// </summary>
        /// <value>The name of the facet *Values*  |Value|Description| |- --|- --| |&#x60;achieved&#x60;|Result has been achieved| |&#x60;target&#x60;|Result has been set as a target to achieve| |&#x60;prediction&#x60;|Result is a prediction| |&#x60;baseline&#x60;|Result is a baseline comparison value| </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum NameEnum
        {
            
            /// <summary>
            /// Enum Achieved for value: achieved
            /// </summary>
            [EnumMember(Value = "achieved")]
            Achieved = 1,
            
            /// <summary>
            /// Enum Target for value: target
            /// </summary>
            [EnumMember(Value = "target")]
            Target = 2,
            
            /// <summary>
            /// Enum Prediction for value: prediction
            /// </summary>
            [EnumMember(Value = "prediction")]
            Prediction = 3,
            
            /// <summary>
            /// Enum Baseline for value: baseline
            /// </summary>
            [EnumMember(Value = "baseline")]
            Baseline = 4
        }

        /// <summary>
        /// The name of the facet *Values*  |Value|Description| |- --|- --| |&#x60;achieved&#x60;|Result has been achieved| |&#x60;target&#x60;|Result has been set as a target to achieve| |&#x60;prediction&#x60;|Result is a prediction| |&#x60;baseline&#x60;|Result is a baseline comparison value| 
        /// </summary>
        /// <value>The name of the facet *Values*  |Value|Description| |- --|- --| |&#x60;achieved&#x60;|Result has been achieved| |&#x60;target&#x60;|Result has been set as a target to achieve| |&#x60;prediction&#x60;|Result is a prediction| |&#x60;baseline&#x60;|Result is a baseline comparison value| </value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public NameEnum? Name { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Facet" /> class.
        /// </summary>
        /// <param name="_object">Object type.</param>
        /// <param name="id">Internal stable ID given to all facets on the Platform.</param>
        /// <param name="name">The name of the facet *Values*  |Value|Description| |- --|- --| |&#x60;achieved&#x60;|Result has been achieved| |&#x60;target&#x60;|Result has been set as a target to achieve| |&#x60;prediction&#x60;|Result is a prediction| |&#x60;baseline&#x60;|Result is a baseline comparison value| .</param>
        public Facet(string _object = default(string), int? id = default(int?), NameEnum? name = default(NameEnum?))
        {
            this.Object = _object;
            this.Id = id;
            this.Name = name;
        }
        
        /// <summary>
        /// Object type
        /// </summary>
        /// <value>Object type</value>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public string Object { get; set; }

        /// <summary>
        /// Internal stable ID given to all facets on the Platform
        /// </summary>
        /// <value>Internal stable ID given to all facets on the Platform</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Facet {\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as Facet);
        }

        /// <summary>
        /// Returns true if Facet instances are equal
        /// </summary>
        /// <param name="input">Instance of Facet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Facet input)
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
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
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
