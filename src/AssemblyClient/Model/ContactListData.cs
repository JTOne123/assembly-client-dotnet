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
    /// A contact object represents a parent or guardian. Students are related to contacts through a student/contact relationship.
    /// </summary>
    [DataContract]
    public partial class ContactListData :  IEquatable<ContactListData>, IValidatableObject
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
        public GenderEnum? gender { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactListData" /> class.
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
        public ContactListData(string _object = default(string), int? id = default(int?), string firstName = default(string), string middleName = default(string), string lastName = default(string), GenderEnum? gender = default(GenderEnum?), string title = default(string), string salutation = default(string), List<ContactEmails> emails = default(List<ContactEmails>), List<ContactTelephoneNumbers> telephoneNumbers = default(List<ContactTelephoneNumbers>), List<ContactStudents> students = default(List<ContactStudents>))
        {
            this._object = _object;
            this.id = id;
            this.first_name = firstName;
            this.middle_name = middleName;
            this.last_name = lastName;
            this.gender = gender;
            this.title = title;
            this.salutation = salutation;
            this.emails = emails;
            this.telephone_numbers = telephoneNumbers;
            this.students = students;
        }
        
        /// <summary>
        /// Object type
        /// </summary>
        /// <value>Object type</value>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public string _object { get; set; }

        /// <summary>
        /// Internal stable ID given to all contacts on the Platform
        /// </summary>
        /// <value>Internal stable ID given to all contacts on the Platform</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? id { get; set; }

        /// <summary>
        /// The first name of the contact
        /// </summary>
        /// <value>The first name of the contact</value>
        [DataMember(Name="first_name", EmitDefaultValue=false)]
        public string first_name { get; set; }

        /// <summary>
        /// The middle name of the contact
        /// </summary>
        /// <value>The middle name of the contact</value>
        [DataMember(Name="middle_name", EmitDefaultValue=false)]
        public string middle_name { get; set; }

        /// <summary>
        /// The last name of the contact
        /// </summary>
        /// <value>The last name of the contact</value>
        [DataMember(Name="last_name", EmitDefaultValue=false)]
        public string last_name { get; set; }


        /// <summary>
        /// The title of the contact
        /// </summary>
        /// <value>The title of the contact</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string title { get; set; }

        /// <summary>
        /// The salutation for the contact
        /// </summary>
        /// <value>The salutation for the contact</value>
        [DataMember(Name="salutation", EmitDefaultValue=false)]
        public string salutation { get; set; }

        /// <summary>
        /// A list of emails for the contact
        /// </summary>
        /// <value>A list of emails for the contact</value>
        [DataMember(Name="emails", EmitDefaultValue=false)]
        public List<ContactEmails> emails { get; set; }

        /// <summary>
        /// A list of telephone numbers for the contact
        /// </summary>
        /// <value>A list of telephone numbers for the contact</value>
        [DataMember(Name="telephone_numbers", EmitDefaultValue=false)]
        public List<ContactTelephoneNumbers> telephone_numbers { get; set; }

        /// <summary>
        /// A list of student IDs that the contact is responsible for
        /// </summary>
        /// <value>A list of student IDs that the contact is responsible for</value>
        [DataMember(Name="students", EmitDefaultValue=false)]
        public List<ContactStudents> students { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactListData {\n");
            sb.Append("  _object: ").Append(_object).Append("\n");
            sb.Append("  id: ").Append(id).Append("\n");
            sb.Append("  first_name: ").Append(first_name).Append("\n");
            sb.Append("  middle_name: ").Append(middle_name).Append("\n");
            sb.Append("  last_name: ").Append(last_name).Append("\n");
            sb.Append("  gender: ").Append(gender).Append("\n");
            sb.Append("  title: ").Append(title).Append("\n");
            sb.Append("  salutation: ").Append(salutation).Append("\n");
            sb.Append("  emails: ").Append(emails).Append("\n");
            sb.Append("  telephone_numbers: ").Append(telephone_numbers).Append("\n");
            sb.Append("  students: ").Append(students).Append("\n");
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
            return this.Equals(input as ContactListData);
        }

        /// <summary>
        /// Returns true if ContactListData instances are equal
        /// </summary>
        /// <param name="input">Instance of ContactListData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactListData input)
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
                    this.id == input.id ||
                    (this.id != null &&
                    this.id.Equals(input.id))
                ) && 
                (
                    this.first_name == input.first_name ||
                    (this.first_name != null &&
                    this.first_name.Equals(input.first_name))
                ) && 
                (
                    this.middle_name == input.middle_name ||
                    (this.middle_name != null &&
                    this.middle_name.Equals(input.middle_name))
                ) && 
                (
                    this.last_name == input.last_name ||
                    (this.last_name != null &&
                    this.last_name.Equals(input.last_name))
                ) && 
                (
                    this.gender == input.gender ||
                    (this.gender != null &&
                    this.gender.Equals(input.gender))
                ) && 
                (
                    this.title == input.title ||
                    (this.title != null &&
                    this.title.Equals(input.title))
                ) && 
                (
                    this.salutation == input.salutation ||
                    (this.salutation != null &&
                    this.salutation.Equals(input.salutation))
                ) && 
                (
                    this.emails == input.emails ||
                    this.emails != null &&
                    this.emails.SequenceEqual(input.emails)
                ) && 
                (
                    this.telephone_numbers == input.telephone_numbers ||
                    this.telephone_numbers != null &&
                    this.telephone_numbers.SequenceEqual(input.telephone_numbers)
                ) && 
                (
                    this.students == input.students ||
                    this.students != null &&
                    this.students.SequenceEqual(input.students)
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
                if (this.id != null)
                    hashCode = hashCode * 59 + this.id.GetHashCode();
                if (this.first_name != null)
                    hashCode = hashCode * 59 + this.first_name.GetHashCode();
                if (this.middle_name != null)
                    hashCode = hashCode * 59 + this.middle_name.GetHashCode();
                if (this.last_name != null)
                    hashCode = hashCode * 59 + this.last_name.GetHashCode();
                if (this.gender != null)
                    hashCode = hashCode * 59 + this.gender.GetHashCode();
                if (this.title != null)
                    hashCode = hashCode * 59 + this.title.GetHashCode();
                if (this.salutation != null)
                    hashCode = hashCode * 59 + this.salutation.GetHashCode();
                if (this.emails != null)
                    hashCode = hashCode * 59 + this.emails.GetHashCode();
                if (this.telephone_numbers != null)
                    hashCode = hashCode * 59 + this.telephone_numbers.GetHashCode();
                if (this.students != null)
                    hashCode = hashCode * 59 + this.students.GetHashCode();
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
