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
    /// A contact object represents a parent or guardian. Students are related to contacts through a student/contact relationship.
    /// </summary>
    [DataContract]
    public partial class Contact :  IEquatable<Contact>, IValidatableObject
    {
        /// <summary>
        /// The gender of the contact *Values*  |Value|Description| |- --|- --| |&#x60;M&#x60;|Male| |&#x60;F&#x60;|Female| 
        /// </summary>
        /// <value>The gender of the contact *Values*  |Value|Description| |- --|- --| |&#x60;M&#x60;|Male| |&#x60;F&#x60;|Female| </value>
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
        /// The gender of the contact *Values*  |Value|Description| |- --|- --| |&#x60;M&#x60;|Male| |&#x60;F&#x60;|Female| 
        /// </summary>
        /// <value>The gender of the contact *Values*  |Value|Description| |- --|- --| |&#x60;M&#x60;|Male| |&#x60;F&#x60;|Female| </value>
        [DataMember(Name="gender", EmitDefaultValue=false)]
        public GenderEnum? Gender { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Contact" /> class.
        /// </summary>
        /// <param name="_object">Object type.</param>
        /// <param name="id">Internal stable ID given to all contacts on the Platform.</param>
        /// <param name="firstName">The first name of the contact.</param>
        /// <param name="middleName">The middle name of the contact.</param>
        /// <param name="lastName">The last name of the contact.</param>
        /// <param name="gender">The gender of the contact *Values*  |Value|Description| |- --|- --| |&#x60;M&#x60;|Male| |&#x60;F&#x60;|Female| .</param>
        /// <param name="title">The title of the contact.</param>
        /// <param name="salutation">The salutation for the contact.</param>
        /// <param name="emails">A list of emails for the contact.</param>
        /// <param name="telephoneNumbers">A list of telephone numbers for the contact.</param>
        /// <param name="students">A list of student IDs that the contact is responsible for.</param>
        public Contact(string _object = default(string), int? id = default(int?), string firstName = default(string), string middleName = default(string), string lastName = default(string), GenderEnum? gender = default(GenderEnum?), string title = default(string), string salutation = default(string), List<ContactEmails> emails = default(List<ContactEmails>), List<ContactTelephoneNumbers> telephoneNumbers = default(List<ContactTelephoneNumbers>), List<ContactStudents> students = default(List<ContactStudents>))
        {
            this.Object = _object;
            this.Id = id;
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.Gender = gender;
            this.Title = title;
            this.Salutation = salutation;
            this.Emails = emails;
            this.TelephoneNumbers = telephoneNumbers;
            this.Students = students;
        }
        
        /// <summary>
        /// Object type
        /// </summary>
        /// <value>Object type</value>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public string Object { get; set; }

        /// <summary>
        /// Internal stable ID given to all contacts on the Platform
        /// </summary>
        /// <value>Internal stable ID given to all contacts on the Platform</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// The first name of the contact
        /// </summary>
        /// <value>The first name of the contact</value>
        [DataMember(Name="first_name", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// The middle name of the contact
        /// </summary>
        /// <value>The middle name of the contact</value>
        [DataMember(Name="middle_name", EmitDefaultValue=false)]
        public string MiddleName { get; set; }

        /// <summary>
        /// The last name of the contact
        /// </summary>
        /// <value>The last name of the contact</value>
        [DataMember(Name="last_name", EmitDefaultValue=false)]
        public string LastName { get; set; }


        /// <summary>
        /// The title of the contact
        /// </summary>
        /// <value>The title of the contact</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// The salutation for the contact
        /// </summary>
        /// <value>The salutation for the contact</value>
        [DataMember(Name="salutation", EmitDefaultValue=false)]
        public string Salutation { get; set; }

        /// <summary>
        /// A list of emails for the contact
        /// </summary>
        /// <value>A list of emails for the contact</value>
        [DataMember(Name="emails", EmitDefaultValue=false)]
        public List<ContactEmails> Emails { get; set; }

        /// <summary>
        /// A list of telephone numbers for the contact
        /// </summary>
        /// <value>A list of telephone numbers for the contact</value>
        [DataMember(Name="telephone_numbers", EmitDefaultValue=false)]
        public List<ContactTelephoneNumbers> TelephoneNumbers { get; set; }

        /// <summary>
        /// A list of student IDs that the contact is responsible for
        /// </summary>
        /// <value>A list of student IDs that the contact is responsible for</value>
        [DataMember(Name="students", EmitDefaultValue=false)]
        public List<ContactStudents> Students { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Contact {\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  MiddleName: ").Append(MiddleName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Gender: ").Append(Gender).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Salutation: ").Append(Salutation).Append("\n");
            sb.Append("  Emails: ").Append(Emails).Append("\n");
            sb.Append("  TelephoneNumbers: ").Append(TelephoneNumbers).Append("\n");
            sb.Append("  Students: ").Append(Students).Append("\n");
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
            return this.Equals(input as Contact);
        }

        /// <summary>
        /// Returns true if Contact instances are equal
        /// </summary>
        /// <param name="input">Instance of Contact to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Contact input)
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
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.MiddleName == input.MiddleName ||
                    (this.MiddleName != null &&
                    this.MiddleName.Equals(input.MiddleName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.Gender == input.Gender ||
                    (this.Gender != null &&
                    this.Gender.Equals(input.Gender))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Salutation == input.Salutation ||
                    (this.Salutation != null &&
                    this.Salutation.Equals(input.Salutation))
                ) && 
                (
                    this.Emails == input.Emails ||
                    this.Emails != null &&
                    this.Emails.SequenceEqual(input.Emails)
                ) && 
                (
                    this.TelephoneNumbers == input.TelephoneNumbers ||
                    this.TelephoneNumbers != null &&
                    this.TelephoneNumbers.SequenceEqual(input.TelephoneNumbers)
                ) && 
                (
                    this.Students == input.Students ||
                    this.Students != null &&
                    this.Students.SequenceEqual(input.Students)
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
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.MiddleName != null)
                    hashCode = hashCode * 59 + this.MiddleName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.Gender != null)
                    hashCode = hashCode * 59 + this.Gender.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Salutation != null)
                    hashCode = hashCode * 59 + this.Salutation.GetHashCode();
                if (this.Emails != null)
                    hashCode = hashCode * 59 + this.Emails.GetHashCode();
                if (this.TelephoneNumbers != null)
                    hashCode = hashCode * 59 + this.TelephoneNumbers.GetHashCode();
                if (this.Students != null)
                    hashCode = hashCode * 59 + this.Students.GetHashCode();
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
