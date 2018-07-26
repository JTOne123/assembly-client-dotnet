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
    /// Returns details for the school associated with the provided access_token.
    /// </summary>
    [DataContract]
    public partial class SchoolDetailsListData :  IEquatable<SchoolDetailsListData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SchoolDetailsListData" /> class.
        /// </summary>
        /// <param name="_object">Object type.</param>
        /// <param name="id">Internal stable ID given to all schools on Platform.</param>
        /// <param name="name">Name of the school.</param>
        /// <param name="urn">Unique Reference Number (URN) of the school.</param>
        /// <param name="laCode">The code of the local authority that the school belongs to.</param>
        /// <param name="laName">The name of the local authority that the school belongs to.</param>
        /// <param name="establishmentNumber">The school&#39;s establishment or &#39;DfE number&#39;.</param>
        /// <param name="establishmentType">The type of establishment.</param>
        /// <param name="phase">The phase of the school (i.e. &#39;Secondary&#39;, &#39;Primary&#39; or &#39;All through&#39;).</param>
        /// <param name="street">The street that the school is on.</param>
        /// <param name="town">The town that the school is in.</param>
        /// <param name="postcode">The postcode of the school.</param>
        /// <param name="headTeacher">The school&#39;s head teacher name.</param>
        public SchoolDetailsListData(string _object = default(string), int? id = default(int?), string name = default(string), string urn = default(string), string laCode = default(string), string laName = default(string), string establishmentNumber = default(string), string establishmentType = default(string), string phase = default(string), string street = default(string), string town = default(string), string postcode = default(string), string headTeacher = default(string))
        {
            this.Object = _object;
            this.Id = id;
            this.Name = name;
            this.Urn = urn;
            this.LaCode = laCode;
            this.LaName = laName;
            this.EstablishmentNumber = establishmentNumber;
            this.EstablishmentType = establishmentType;
            this.Phase = phase;
            this.Street = street;
            this.Town = town;
            this.Postcode = postcode;
            this.HeadTeacher = headTeacher;
        }
        
        /// <summary>
        /// Object type
        /// </summary>
        /// <value>Object type</value>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public string Object { get; set; }

        /// <summary>
        /// Internal stable ID given to all schools on Platform
        /// </summary>
        /// <value>Internal stable ID given to all schools on Platform</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Name of the school
        /// </summary>
        /// <value>Name of the school</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Unique Reference Number (URN) of the school
        /// </summary>
        /// <value>Unique Reference Number (URN) of the school</value>
        [DataMember(Name="urn", EmitDefaultValue=false)]
        public string Urn { get; set; }

        /// <summary>
        /// The code of the local authority that the school belongs to
        /// </summary>
        /// <value>The code of the local authority that the school belongs to</value>
        [DataMember(Name="la_code", EmitDefaultValue=false)]
        public string LaCode { get; set; }

        /// <summary>
        /// The name of the local authority that the school belongs to
        /// </summary>
        /// <value>The name of the local authority that the school belongs to</value>
        [DataMember(Name="la_name", EmitDefaultValue=false)]
        public string LaName { get; set; }

        /// <summary>
        /// The school&#39;s establishment or &#39;DfE number&#39;
        /// </summary>
        /// <value>The school&#39;s establishment or &#39;DfE number&#39;</value>
        [DataMember(Name="establishment_number", EmitDefaultValue=false)]
        public string EstablishmentNumber { get; set; }

        /// <summary>
        /// The type of establishment
        /// </summary>
        /// <value>The type of establishment</value>
        [DataMember(Name="establishment_type", EmitDefaultValue=false)]
        public string EstablishmentType { get; set; }

        /// <summary>
        /// The phase of the school (i.e. &#39;Secondary&#39;, &#39;Primary&#39; or &#39;All through&#39;)
        /// </summary>
        /// <value>The phase of the school (i.e. &#39;Secondary&#39;, &#39;Primary&#39; or &#39;All through&#39;)</value>
        [DataMember(Name="phase", EmitDefaultValue=false)]
        public string Phase { get; set; }

        /// <summary>
        /// The street that the school is on
        /// </summary>
        /// <value>The street that the school is on</value>
        [DataMember(Name="street", EmitDefaultValue=false)]
        public string Street { get; set; }

        /// <summary>
        /// The town that the school is in
        /// </summary>
        /// <value>The town that the school is in</value>
        [DataMember(Name="town", EmitDefaultValue=false)]
        public string Town { get; set; }

        /// <summary>
        /// The postcode of the school
        /// </summary>
        /// <value>The postcode of the school</value>
        [DataMember(Name="postcode", EmitDefaultValue=false)]
        public string Postcode { get; set; }

        /// <summary>
        /// The school&#39;s head teacher name
        /// </summary>
        /// <value>The school&#39;s head teacher name</value>
        [DataMember(Name="head_teacher", EmitDefaultValue=false)]
        public string HeadTeacher { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SchoolDetailsListData {\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Urn: ").Append(Urn).Append("\n");
            sb.Append("  LaCode: ").Append(LaCode).Append("\n");
            sb.Append("  LaName: ").Append(LaName).Append("\n");
            sb.Append("  EstablishmentNumber: ").Append(EstablishmentNumber).Append("\n");
            sb.Append("  EstablishmentType: ").Append(EstablishmentType).Append("\n");
            sb.Append("  Phase: ").Append(Phase).Append("\n");
            sb.Append("  Street: ").Append(Street).Append("\n");
            sb.Append("  Town: ").Append(Town).Append("\n");
            sb.Append("  Postcode: ").Append(Postcode).Append("\n");
            sb.Append("  HeadTeacher: ").Append(HeadTeacher).Append("\n");
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
            return this.Equals(input as SchoolDetailsListData);
        }

        /// <summary>
        /// Returns true if SchoolDetailsListData instances are equal
        /// </summary>
        /// <param name="input">Instance of SchoolDetailsListData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SchoolDetailsListData input)
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
                ) && 
                (
                    this.Urn == input.Urn ||
                    (this.Urn != null &&
                    this.Urn.Equals(input.Urn))
                ) && 
                (
                    this.LaCode == input.LaCode ||
                    (this.LaCode != null &&
                    this.LaCode.Equals(input.LaCode))
                ) && 
                (
                    this.LaName == input.LaName ||
                    (this.LaName != null &&
                    this.LaName.Equals(input.LaName))
                ) && 
                (
                    this.EstablishmentNumber == input.EstablishmentNumber ||
                    (this.EstablishmentNumber != null &&
                    this.EstablishmentNumber.Equals(input.EstablishmentNumber))
                ) && 
                (
                    this.EstablishmentType == input.EstablishmentType ||
                    (this.EstablishmentType != null &&
                    this.EstablishmentType.Equals(input.EstablishmentType))
                ) && 
                (
                    this.Phase == input.Phase ||
                    (this.Phase != null &&
                    this.Phase.Equals(input.Phase))
                ) && 
                (
                    this.Street == input.Street ||
                    (this.Street != null &&
                    this.Street.Equals(input.Street))
                ) && 
                (
                    this.Town == input.Town ||
                    (this.Town != null &&
                    this.Town.Equals(input.Town))
                ) && 
                (
                    this.Postcode == input.Postcode ||
                    (this.Postcode != null &&
                    this.Postcode.Equals(input.Postcode))
                ) && 
                (
                    this.HeadTeacher == input.HeadTeacher ||
                    (this.HeadTeacher != null &&
                    this.HeadTeacher.Equals(input.HeadTeacher))
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
                if (this.Urn != null)
                    hashCode = hashCode * 59 + this.Urn.GetHashCode();
                if (this.LaCode != null)
                    hashCode = hashCode * 59 + this.LaCode.GetHashCode();
                if (this.LaName != null)
                    hashCode = hashCode * 59 + this.LaName.GetHashCode();
                if (this.EstablishmentNumber != null)
                    hashCode = hashCode * 59 + this.EstablishmentNumber.GetHashCode();
                if (this.EstablishmentType != null)
                    hashCode = hashCode * 59 + this.EstablishmentType.GetHashCode();
                if (this.Phase != null)
                    hashCode = hashCode * 59 + this.Phase.GetHashCode();
                if (this.Street != null)
                    hashCode = hashCode * 59 + this.Street.GetHashCode();
                if (this.Town != null)
                    hashCode = hashCode * 59 + this.Town.GetHashCode();
                if (this.Postcode != null)
                    hashCode = hashCode * 59 + this.Postcode.GetHashCode();
                if (this.HeadTeacher != null)
                    hashCode = hashCode * 59 + this.HeadTeacher.GetHashCode();
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
