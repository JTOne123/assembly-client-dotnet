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
    /// A student object represents a single student within a school.
    /// </summary>
    [DataContract]
    public partial class StudentListData :  IEquatable<StudentListData>, IValidatableObject
    {
        /// <summary>
        /// The year group the student currently belongs to *Values*  |Value|Description| |- --|- --| |&#x60;N1&#x60;|Nursery first year| |&#x60;N2&#x60;|Nursery second year| |&#x60;R&#x60;|Reception| |&#x60;1&#x60;|Year 1| |&#x60;2&#x60;|Year 2| |&#x60;3&#x60;|Year 3| |&#x60;4&#x60;|Year 4| |&#x60;5&#x60;|Year 5| |&#x60;6&#x60;|Year 6| |&#x60;7&#x60;|Year 7| |&#x60;8&#x60;|Year 8| |&#x60;9&#x60;|Year 9| |&#x60;10&#x60;|Year 10| |&#x60;11&#x60;|Year 11| |&#x60;12&#x60;|Year 12| |&#x60;13&#x60;|Year 13| 
        /// </summary>
        /// <value>The year group the student currently belongs to *Values*  |Value|Description| |- --|- --| |&#x60;N1&#x60;|Nursery first year| |&#x60;N2&#x60;|Nursery second year| |&#x60;R&#x60;|Reception| |&#x60;1&#x60;|Year 1| |&#x60;2&#x60;|Year 2| |&#x60;3&#x60;|Year 3| |&#x60;4&#x60;|Year 4| |&#x60;5&#x60;|Year 5| |&#x60;6&#x60;|Year 6| |&#x60;7&#x60;|Year 7| |&#x60;8&#x60;|Year 8| |&#x60;9&#x60;|Year 9| |&#x60;10&#x60;|Year 10| |&#x60;11&#x60;|Year 11| |&#x60;12&#x60;|Year 12| |&#x60;13&#x60;|Year 13| </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum YearCodeEnum
        {
            
            /// <summary>
            /// Enum N1 for value: N1
            /// </summary>
            [EnumMember(Value = "N1")]
            N1 = 1,
            
            /// <summary>
            /// Enum N2 for value: N2
            /// </summary>
            [EnumMember(Value = "N2")]
            N2 = 2,
            
            /// <summary>
            /// Enum R for value: R
            /// </summary>
            [EnumMember(Value = "R")]
            R = 3,
            
            /// <summary>
            /// Enum _1 for value: 1
            /// </summary>
            [EnumMember(Value = "1")]
            _1 = 4,
            
            /// <summary>
            /// Enum _2 for value: 2
            /// </summary>
            [EnumMember(Value = "2")]
            _2 = 5,
            
            /// <summary>
            /// Enum _3 for value: 3
            /// </summary>
            [EnumMember(Value = "3")]
            _3 = 6,
            
            /// <summary>
            /// Enum _4 for value: 4
            /// </summary>
            [EnumMember(Value = "4")]
            _4 = 7,
            
            /// <summary>
            /// Enum _5 for value: 5
            /// </summary>
            [EnumMember(Value = "5")]
            _5 = 8,
            
            /// <summary>
            /// Enum _6 for value: 6
            /// </summary>
            [EnumMember(Value = "6")]
            _6 = 9,
            
            /// <summary>
            /// Enum _7 for value: 7
            /// </summary>
            [EnumMember(Value = "7")]
            _7 = 10,
            
            /// <summary>
            /// Enum _8 for value: 8
            /// </summary>
            [EnumMember(Value = "8")]
            _8 = 11,
            
            /// <summary>
            /// Enum _9 for value: 9
            /// </summary>
            [EnumMember(Value = "9")]
            _9 = 12,
            
            /// <summary>
            /// Enum _10 for value: 10
            /// </summary>
            [EnumMember(Value = "10")]
            _10 = 13,
            
            /// <summary>
            /// Enum _11 for value: 11
            /// </summary>
            [EnumMember(Value = "11")]
            _11 = 14,
            
            /// <summary>
            /// Enum _12 for value: 12
            /// </summary>
            [EnumMember(Value = "12")]
            _12 = 15,
            
            /// <summary>
            /// Enum _13 for value: 13
            /// </summary>
            [EnumMember(Value = "13")]
            _13 = 16
        }

        /// <summary>
        /// The year group the student currently belongs to *Values*  |Value|Description| |- --|- --| |&#x60;N1&#x60;|Nursery first year| |&#x60;N2&#x60;|Nursery second year| |&#x60;R&#x60;|Reception| |&#x60;1&#x60;|Year 1| |&#x60;2&#x60;|Year 2| |&#x60;3&#x60;|Year 3| |&#x60;4&#x60;|Year 4| |&#x60;5&#x60;|Year 5| |&#x60;6&#x60;|Year 6| |&#x60;7&#x60;|Year 7| |&#x60;8&#x60;|Year 8| |&#x60;9&#x60;|Year 9| |&#x60;10&#x60;|Year 10| |&#x60;11&#x60;|Year 11| |&#x60;12&#x60;|Year 12| |&#x60;13&#x60;|Year 13| 
        /// </summary>
        /// <value>The year group the student currently belongs to *Values*  |Value|Description| |- --|- --| |&#x60;N1&#x60;|Nursery first year| |&#x60;N2&#x60;|Nursery second year| |&#x60;R&#x60;|Reception| |&#x60;1&#x60;|Year 1| |&#x60;2&#x60;|Year 2| |&#x60;3&#x60;|Year 3| |&#x60;4&#x60;|Year 4| |&#x60;5&#x60;|Year 5| |&#x60;6&#x60;|Year 6| |&#x60;7&#x60;|Year 7| |&#x60;8&#x60;|Year 8| |&#x60;9&#x60;|Year 9| |&#x60;10&#x60;|Year 10| |&#x60;11&#x60;|Year 11| |&#x60;12&#x60;|Year 12| |&#x60;13&#x60;|Year 13| </value>
        [DataMember(Name="year_code", EmitDefaultValue=false)]
        public YearCodeEnum? YearCode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="StudentListData" /> class.
        /// </summary>
        /// <param name="_object">Object type.</param>
        /// <param name="id">Internal stable ID given to students in the Platform.</param>
        /// <param name="firstName">The first name of the student.</param>
        /// <param name="legalFirstName">The legal first name of the student.</param>
        /// <param name="middleName">The middle name of the student.</param>
        /// <param name="lastName">The last name of the student.</param>
        /// <param name="legalLastName">The legal last name of the student.</param>
        /// <param name="formerLastName">The former last name of the student.</param>
        /// <param name="dob">The date of birth of the student.</param>
        /// <param name="yearCode">The year group the student currently belongs to *Values*  |Value|Description| |- --|- --| |&#x60;N1&#x60;|Nursery first year| |&#x60;N2&#x60;|Nursery second year| |&#x60;R&#x60;|Reception| |&#x60;1&#x60;|Year 1| |&#x60;2&#x60;|Year 2| |&#x60;3&#x60;|Year 3| |&#x60;4&#x60;|Year 4| |&#x60;5&#x60;|Year 5| |&#x60;6&#x60;|Year 6| |&#x60;7&#x60;|Year 7| |&#x60;8&#x60;|Year 8| |&#x60;9&#x60;|Year 9| |&#x60;10&#x60;|Year 10| |&#x60;11&#x60;|Year 11| |&#x60;12&#x60;|Year 12| |&#x60;13&#x60;|Year 13| .</param>
        /// <param name="upn">Unique Pupil Number (UPN) - a DfE-mandated 13-character code that identifies each pupil.</param>
        /// <param name="formerUpn">The previous UPN where a pupil has held another UPN whilst at a school.</param>
        /// <param name="misId">The ID of a student from the MIS.</param>
        /// <param name="pan">A student&#39;s &#39;Pupil Admission Number&#39;. This field is exposed in the front end of the MIS, and may be the same as mis_id.</param>
        /// <param name="startDate">Date when the student joined the school.</param>
        /// <param name="endDate">Date when the student left the school (this will default to 2079-06-06T23:59:00.000Z).</param>
        /// <param name="enrolmentStatus">The enrolment status of the student.</param>
        /// <param name="demographics">demographics.</param>
        /// <param name="contact">List of contact IDs for the student..</param>
        /// <param name="addresses">addresses.</param>
        /// <param name="languages">languages.</param>
        public StudentListData(string _object = default(string), int? id = default(int?), string firstName = default(string), string legalFirstName = default(string), string middleName = default(string), string lastName = default(string), string legalLastName = default(string), string formerLastName = default(string), DateTime? dob = default(DateTime?), YearCodeEnum? yearCode = default(YearCodeEnum?), string upn = default(string), string formerUpn = default(string), string misId = default(string), string pan = default(string), DateTime? startDate = default(DateTime?), DateTime? endDate = default(DateTime?), string enrolmentStatus = default(string), StudentDemographics demographics = default(StudentDemographics), List<ContactListData> contact = default(List<ContactListData>), StudentAddresses addresses = default(StudentAddresses), StudentLanguages languages = default(StudentLanguages))
        {
            this.Object = _object;
            this.Id = id;
            this.FirstName = firstName;
            this.LegalFirstName = legalFirstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.LegalLastName = legalLastName;
            this.FormerLastName = formerLastName;
            this.Dob = dob;
            this.YearCode = yearCode;
            this.Upn = upn;
            this.FormerUpn = formerUpn;
            this.MisId = misId;
            this.Pan = pan;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.EnrolmentStatus = enrolmentStatus;
            this.Demographics = demographics;
            this.Contact = contact;
            this.Addresses = addresses;
            this.Languages = languages;
        }
        
        /// <summary>
        /// Object type
        /// </summary>
        /// <value>Object type</value>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public string Object { get; set; }

        /// <summary>
        /// Internal stable ID given to students in the Platform
        /// </summary>
        /// <value>Internal stable ID given to students in the Platform</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// The first name of the student
        /// </summary>
        /// <value>The first name of the student</value>
        [DataMember(Name="first_name", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// The legal first name of the student
        /// </summary>
        /// <value>The legal first name of the student</value>
        [DataMember(Name="legal_first_name", EmitDefaultValue=false)]
        public string LegalFirstName { get; set; }

        /// <summary>
        /// The middle name of the student
        /// </summary>
        /// <value>The middle name of the student</value>
        [DataMember(Name="middle_name", EmitDefaultValue=false)]
        public string MiddleName { get; set; }

        /// <summary>
        /// The last name of the student
        /// </summary>
        /// <value>The last name of the student</value>
        [DataMember(Name="last_name", EmitDefaultValue=false)]
        public string LastName { get; set; }

        /// <summary>
        /// The legal last name of the student
        /// </summary>
        /// <value>The legal last name of the student</value>
        [DataMember(Name="legal_last_name", EmitDefaultValue=false)]
        public string LegalLastName { get; set; }

        /// <summary>
        /// The former last name of the student
        /// </summary>
        /// <value>The former last name of the student</value>
        [DataMember(Name="former_last_name", EmitDefaultValue=false)]
        public string FormerLastName { get; set; }

        /// <summary>
        /// The date of birth of the student
        /// </summary>
        /// <value>The date of birth of the student</value>
        [DataMember(Name="dob", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? Dob { get; set; }


        /// <summary>
        /// Unique Pupil Number (UPN) - a DfE-mandated 13-character code that identifies each pupil
        /// </summary>
        /// <value>Unique Pupil Number (UPN) - a DfE-mandated 13-character code that identifies each pupil</value>
        [DataMember(Name="upn", EmitDefaultValue=false)]
        public string Upn { get; set; }

        /// <summary>
        /// The previous UPN where a pupil has held another UPN whilst at a school
        /// </summary>
        /// <value>The previous UPN where a pupil has held another UPN whilst at a school</value>
        [DataMember(Name="former_upn", EmitDefaultValue=false)]
        public string FormerUpn { get; set; }

        /// <summary>
        /// The ID of a student from the MIS
        /// </summary>
        /// <value>The ID of a student from the MIS</value>
        [DataMember(Name="mis_id", EmitDefaultValue=false)]
        public string MisId { get; set; }

        /// <summary>
        /// A student&#39;s &#39;Pupil Admission Number&#39;. This field is exposed in the front end of the MIS, and may be the same as mis_id
        /// </summary>
        /// <value>A student&#39;s &#39;Pupil Admission Number&#39;. This field is exposed in the front end of the MIS, and may be the same as mis_id</value>
        [DataMember(Name="pan", EmitDefaultValue=false)]
        public string Pan { get; set; }

        /// <summary>
        /// Date when the student joined the school
        /// </summary>
        /// <value>Date when the student joined the school</value>
        [DataMember(Name="start_date", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Date when the student left the school (this will default to 2079-06-06T23:59:00.000Z)
        /// </summary>
        /// <value>Date when the student left the school (this will default to 2079-06-06T23:59:00.000Z)</value>
        [DataMember(Name="end_date", EmitDefaultValue=false)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// The enrolment status of the student
        /// </summary>
        /// <value>The enrolment status of the student</value>
        [DataMember(Name="enrolment_status", EmitDefaultValue=false)]
        public string EnrolmentStatus { get; set; }

        /// <summary>
        /// Gets or Sets Demographics
        /// </summary>
        [DataMember(Name="demographics", EmitDefaultValue=false)]
        public StudentDemographics Demographics { get; set; }

        /// <summary>
        /// List of contact IDs for the student.
        /// </summary>
        /// <value>List of contact IDs for the student.</value>
        [DataMember(Name="contact", EmitDefaultValue=false)]
        public List<ContactListData> Contact { get; set; }

        /// <summary>
        /// Gets or Sets Addresses
        /// </summary>
        [DataMember(Name="addresses", EmitDefaultValue=false)]
        public StudentAddresses Addresses { get; set; }

        /// <summary>
        /// Gets or Sets Languages
        /// </summary>
        [DataMember(Name="languages", EmitDefaultValue=false)]
        public StudentLanguages Languages { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StudentListData {\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LegalFirstName: ").Append(LegalFirstName).Append("\n");
            sb.Append("  MiddleName: ").Append(MiddleName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  LegalLastName: ").Append(LegalLastName).Append("\n");
            sb.Append("  FormerLastName: ").Append(FormerLastName).Append("\n");
            sb.Append("  Dob: ").Append(Dob).Append("\n");
            sb.Append("  YearCode: ").Append(YearCode).Append("\n");
            sb.Append("  Upn: ").Append(Upn).Append("\n");
            sb.Append("  FormerUpn: ").Append(FormerUpn).Append("\n");
            sb.Append("  MisId: ").Append(MisId).Append("\n");
            sb.Append("  Pan: ").Append(Pan).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  EnrolmentStatus: ").Append(EnrolmentStatus).Append("\n");
            sb.Append("  Demographics: ").Append(Demographics).Append("\n");
            sb.Append("  Contact: ").Append(Contact).Append("\n");
            sb.Append("  Addresses: ").Append(Addresses).Append("\n");
            sb.Append("  Languages: ").Append(Languages).Append("\n");
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
            return this.Equals(input as StudentListData);
        }

        /// <summary>
        /// Returns true if StudentListData instances are equal
        /// </summary>
        /// <param name="input">Instance of StudentListData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StudentListData input)
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
                    this.LegalFirstName == input.LegalFirstName ||
                    (this.LegalFirstName != null &&
                    this.LegalFirstName.Equals(input.LegalFirstName))
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
                    this.LegalLastName == input.LegalLastName ||
                    (this.LegalLastName != null &&
                    this.LegalLastName.Equals(input.LegalLastName))
                ) && 
                (
                    this.FormerLastName == input.FormerLastName ||
                    (this.FormerLastName != null &&
                    this.FormerLastName.Equals(input.FormerLastName))
                ) && 
                (
                    this.Dob == input.Dob ||
                    (this.Dob != null &&
                    this.Dob.Equals(input.Dob))
                ) && 
                (
                    this.YearCode == input.YearCode ||
                    (this.YearCode != null &&
                    this.YearCode.Equals(input.YearCode))
                ) && 
                (
                    this.Upn == input.Upn ||
                    (this.Upn != null &&
                    this.Upn.Equals(input.Upn))
                ) && 
                (
                    this.FormerUpn == input.FormerUpn ||
                    (this.FormerUpn != null &&
                    this.FormerUpn.Equals(input.FormerUpn))
                ) && 
                (
                    this.MisId == input.MisId ||
                    (this.MisId != null &&
                    this.MisId.Equals(input.MisId))
                ) && 
                (
                    this.Pan == input.Pan ||
                    (this.Pan != null &&
                    this.Pan.Equals(input.Pan))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.EnrolmentStatus == input.EnrolmentStatus ||
                    (this.EnrolmentStatus != null &&
                    this.EnrolmentStatus.Equals(input.EnrolmentStatus))
                ) && 
                (
                    this.Demographics == input.Demographics ||
                    (this.Demographics != null &&
                    this.Demographics.Equals(input.Demographics))
                ) && 
                (
                    this.Contact == input.Contact ||
                    this.Contact != null &&
                    this.Contact.SequenceEqual(input.Contact)
                ) && 
                (
                    this.Addresses == input.Addresses ||
                    (this.Addresses != null &&
                    this.Addresses.Equals(input.Addresses))
                ) && 
                (
                    this.Languages == input.Languages ||
                    (this.Languages != null &&
                    this.Languages.Equals(input.Languages))
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
                if (this.LegalFirstName != null)
                    hashCode = hashCode * 59 + this.LegalFirstName.GetHashCode();
                if (this.MiddleName != null)
                    hashCode = hashCode * 59 + this.MiddleName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.LegalLastName != null)
                    hashCode = hashCode * 59 + this.LegalLastName.GetHashCode();
                if (this.FormerLastName != null)
                    hashCode = hashCode * 59 + this.FormerLastName.GetHashCode();
                if (this.Dob != null)
                    hashCode = hashCode * 59 + this.Dob.GetHashCode();
                if (this.YearCode != null)
                    hashCode = hashCode * 59 + this.YearCode.GetHashCode();
                if (this.Upn != null)
                    hashCode = hashCode * 59 + this.Upn.GetHashCode();
                if (this.FormerUpn != null)
                    hashCode = hashCode * 59 + this.FormerUpn.GetHashCode();
                if (this.MisId != null)
                    hashCode = hashCode * 59 + this.MisId.GetHashCode();
                if (this.Pan != null)
                    hashCode = hashCode * 59 + this.Pan.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.EnrolmentStatus != null)
                    hashCode = hashCode * 59 + this.EnrolmentStatus.GetHashCode();
                if (this.Demographics != null)
                    hashCode = hashCode * 59 + this.Demographics.GetHashCode();
                if (this.Contact != null)
                    hashCode = hashCode * 59 + this.Contact.GetHashCode();
                if (this.Addresses != null)
                    hashCode = hashCode * 59 + this.Addresses.GetHashCode();
                if (this.Languages != null)
                    hashCode = hashCode * 59 + this.Languages.GetHashCode();
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
