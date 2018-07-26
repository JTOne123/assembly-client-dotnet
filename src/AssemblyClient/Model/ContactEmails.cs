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
    public partial class ContactEmails :  IEquatable<ContactEmails>, IValidatableObject
    {
        /// <summary>
        /// The location associated with the email address. *Values*  |Value|Description| |- --|- --| |&#x60;Home&#x60;|Home| |&#x60;Work&#x60;|Work| |&#x60;Other&#x60;|Other| |&#x60;null&#x60;|Not Applicable / Unknown| 
        /// </summary>
        /// <value>The location associated with the email address. *Values*  |Value|Description| |- --|- --| |&#x60;Home&#x60;|Home| |&#x60;Work&#x60;|Work| |&#x60;Other&#x60;|Other| |&#x60;null&#x60;|Not Applicable / Unknown| </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Home for value: Home
            /// </summary>
            [EnumMember(Value = "Home")]
            Home = 1,
            
            /// <summary>
            /// Enum Work for value: Work
            /// </summary>
            [EnumMember(Value = "Work")]
            Work = 2,
            
            /// <summary>
            /// Enum Other for value: Other
            /// </summary>
            [EnumMember(Value = "Other")]
            Other = 3,
            
            /// <summary>
            /// Enum Null for value: null
            /// </summary>
            [EnumMember(Value = "null")]
            Null = 4
        }

        /// <summary>
        /// The location associated with the email address. *Values*  |Value|Description| |- --|- --| |&#x60;Home&#x60;|Home| |&#x60;Work&#x60;|Work| |&#x60;Other&#x60;|Other| |&#x60;null&#x60;|Not Applicable / Unknown| 
        /// </summary>
        /// <value>The location associated with the email address. *Values*  |Value|Description| |- --|- --| |&#x60;Home&#x60;|Home| |&#x60;Work&#x60;|Work| |&#x60;Other&#x60;|Other| |&#x60;null&#x60;|Not Applicable / Unknown| </value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactEmails" /> class.
        /// </summary>
        /// <param name="_object">Object type.</param>
        /// <param name="id">Internal stable ID given to all email addresses on the Platform.</param>
        /// <param name="email">The email address.</param>
        /// <param name="type">The location associated with the email address. *Values*  |Value|Description| |- --|- --| |&#x60;Home&#x60;|Home| |&#x60;Work&#x60;|Work| |&#x60;Other&#x60;|Other| |&#x60;null&#x60;|Not Applicable / Unknown| .</param>
        /// <param name="isPrimary">Indicates whether this is the primary email address.</param>
        public ContactEmails(string _object = default(string), int? id = default(int?), string email = default(string), TypeEnum? type = default(TypeEnum?), bool? isPrimary = default(bool?))
        {
            this.Object = _object;
            this.Id = id;
            this.Email = email;
            this.Type = type;
            this.IsPrimary = isPrimary;
        }
        
        /// <summary>
        /// Object type
        /// </summary>
        /// <value>Object type</value>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public string Object { get; set; }

        /// <summary>
        /// Internal stable ID given to all email addresses on the Platform
        /// </summary>
        /// <value>Internal stable ID given to all email addresses on the Platform</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// The email address
        /// </summary>
        /// <value>The email address</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }


        /// <summary>
        /// Indicates whether this is the primary email address
        /// </summary>
        /// <value>Indicates whether this is the primary email address</value>
        [DataMember(Name="is_primary", EmitDefaultValue=false)]
        public bool? IsPrimary { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactEmails {\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  IsPrimary: ").Append(IsPrimary).Append("\n");
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
            return this.Equals(input as ContactEmails);
        }

        /// <summary>
        /// Returns true if ContactEmails instances are equal
        /// </summary>
        /// <param name="input">Instance of ContactEmails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactEmails input)
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
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.IsPrimary == input.IsPrimary ||
                    (this.IsPrimary != null &&
                    this.IsPrimary.Equals(input.IsPrimary))
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
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.IsPrimary != null)
                    hashCode = hashCode * 59 + this.IsPrimary.GetHashCode();
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
