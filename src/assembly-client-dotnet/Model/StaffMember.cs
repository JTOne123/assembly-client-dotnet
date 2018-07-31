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
    /// A staff member object represents a single staff member within a school.
    /// </summary>
    [DataContract]
    public partial class StaffMember :  IEquatable<StaffMember>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StaffMember" /> class.
        /// </summary>
        /// <param name="_object">Object type.</param>
        /// <param name="id">Internal stable ID given to each staff member in the Platform.</param>
        /// <param name="misId">The ID of the staff member from the MIS.</param>
        /// <param name="staffCode">The staff code from the MIS.</param>
        /// <param name="firstName">The first name of the staff member.</param>
        /// <param name="legalFirstName">The legal first name of the staff member.</param>
        /// <param name="middleName">The middle name of the staff member.</param>
        /// <param name="lastName">The last name of the staff member.</param>
        /// <param name="legalLastName">The legal last name of the staff member.</param>
        /// <param name="formerLastName">The former last name of the staff member.</param>
        /// <param name="dob">The staff member&#39;s date of birth.</param>
        /// <param name="title">The title of the staff member.</param>
        /// <param name="email">The email address of the staff member..</param>
        /// <param name="isTeachingStaff">Indicates whether the staff member is a teacher.</param>
        /// <param name="includedInCensus">Indicates whether the staff member is a teacher.</param>
        /// <param name="startDate">When the staff member&#39;s employment started.</param>
        /// <param name="endDate">When the staff member&#39;s employment ended/is due to end.</param>
        /// <param name="demographics">demographics.</param>
        /// <param name="qualificationInfo">qualificationInfo.</param>
        public StaffMember(string _object = default(string), int? id = default(int?), string misId = default(string), string staffCode = default(string), string firstName = default(string), string legalFirstName = default(string), string middleName = default(string), string lastName = default(string), string legalLastName = default(string), string formerLastName = default(string), string dob = default(string), string title = default(string), string email = default(string), bool? isTeachingStaff = default(bool?), bool? includedInCensus = default(bool?), DateTime? startDate = default(DateTime?), DateTime? endDate = default(DateTime?), StaffMemberDemographics demographics = default(StaffMemberDemographics), StaffMemberQualificationInfo qualificationInfo = default(StaffMemberQualificationInfo))
        {
            this.Object = _object;
            this.Id = id;
            this.MisId = misId;
            this.StaffCode = staffCode;
            this.FirstName = firstName;
            this.LegalFirstName = legalFirstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.LegalLastName = legalLastName;
            this.FormerLastName = formerLastName;
            this.Dob = dob;
            this.Title = title;
            this.Email = email;
            this.IsTeachingStaff = isTeachingStaff;
            this.IncludedInCensus = includedInCensus;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Demographics = demographics;
            this.QualificationInfo = qualificationInfo;
        }
        
        /// <summary>
        /// Object type
        /// </summary>
        /// <value>Object type</value>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public string Object { get; set; }

        /// <summary>
        /// Internal stable ID given to each staff member in the Platform
        /// </summary>
        /// <value>Internal stable ID given to each staff member in the Platform</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// The ID of the staff member from the MIS
        /// </summary>
        /// <value>The ID of the staff member from the MIS</value>
        [DataMember(Name="mis_id", EmitDefaultValue=false)]
        public string MisId { get; set; }

        /// <summary>
        /// The staff code from the MIS
        /// </summary>
        /// <value>The staff code from the MIS</value>
        [DataMember(Name="staff_code", EmitDefaultValue=false)]
        public string StaffCode { get; set; }

        /// <summary>
        /// The first name of the staff member
        /// </summary>
        /// <value>The first name of the staff member</value>
        [DataMember(Name="first_name", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// The legal first name of the staff member
        /// </summary>
        /// <value>The legal first name of the staff member</value>
        [DataMember(Name="legal_first_name", EmitDefaultValue=false)]
        public string LegalFirstName { get; set; }

        /// <summary>
        /// The middle name of the staff member
        /// </summary>
        /// <value>The middle name of the staff member</value>
        [DataMember(Name="middle_name", EmitDefaultValue=false)]
        public string MiddleName { get; set; }

        /// <summary>
        /// The last name of the staff member
        /// </summary>
        /// <value>The last name of the staff member</value>
        [DataMember(Name="last_name", EmitDefaultValue=false)]
        public string LastName { get; set; }

        /// <summary>
        /// The legal last name of the staff member
        /// </summary>
        /// <value>The legal last name of the staff member</value>
        [DataMember(Name="legal_last_name", EmitDefaultValue=false)]
        public string LegalLastName { get; set; }

        /// <summary>
        /// The former last name of the staff member
        /// </summary>
        /// <value>The former last name of the staff member</value>
        [DataMember(Name="former_last_name", EmitDefaultValue=false)]
        public string FormerLastName { get; set; }

        /// <summary>
        /// The staff member&#39;s date of birth
        /// </summary>
        /// <value>The staff member&#39;s date of birth</value>
        [DataMember(Name="dob", EmitDefaultValue=false)]
        public string Dob { get; set; }

        /// <summary>
        /// The title of the staff member
        /// </summary>
        /// <value>The title of the staff member</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// The email address of the staff member.
        /// </summary>
        /// <value>The email address of the staff member.</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Indicates whether the staff member is a teacher
        /// </summary>
        /// <value>Indicates whether the staff member is a teacher</value>
        [DataMember(Name="is_teaching_staff", EmitDefaultValue=false)]
        public bool? IsTeachingStaff { get; set; }

        /// <summary>
        /// Indicates whether the staff member is a teacher
        /// </summary>
        /// <value>Indicates whether the staff member is a teacher</value>
        [DataMember(Name="included_in_census", EmitDefaultValue=false)]
        public bool? IncludedInCensus { get; set; }

        /// <summary>
        /// When the staff member&#39;s employment started
        /// </summary>
        /// <value>When the staff member&#39;s employment started</value>
        [DataMember(Name="start_date", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// When the staff member&#39;s employment ended/is due to end
        /// </summary>
        /// <value>When the staff member&#39;s employment ended/is due to end</value>
        [DataMember(Name="end_date", EmitDefaultValue=false)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Gets or Sets Demographics
        /// </summary>
        [DataMember(Name="demographics", EmitDefaultValue=false)]
        public StaffMemberDemographics Demographics { get; set; }

        /// <summary>
        /// Gets or Sets QualificationInfo
        /// </summary>
        [DataMember(Name="qualification_info", EmitDefaultValue=false)]
        public StaffMemberQualificationInfo QualificationInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StaffMember {\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  MisId: ").Append(MisId).Append("\n");
            sb.Append("  StaffCode: ").Append(StaffCode).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LegalFirstName: ").Append(LegalFirstName).Append("\n");
            sb.Append("  MiddleName: ").Append(MiddleName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  LegalLastName: ").Append(LegalLastName).Append("\n");
            sb.Append("  FormerLastName: ").Append(FormerLastName).Append("\n");
            sb.Append("  Dob: ").Append(Dob).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  IsTeachingStaff: ").Append(IsTeachingStaff).Append("\n");
            sb.Append("  IncludedInCensus: ").Append(IncludedInCensus).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  Demographics: ").Append(Demographics).Append("\n");
            sb.Append("  QualificationInfo: ").Append(QualificationInfo).Append("\n");
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
            return this.Equals(input as StaffMember);
        }

        /// <summary>
        /// Returns true if StaffMember instances are equal
        /// </summary>
        /// <param name="input">Instance of StaffMember to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StaffMember input)
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
                    this.MisId == input.MisId ||
                    (this.MisId != null &&
                    this.MisId.Equals(input.MisId))
                ) && 
                (
                    this.StaffCode == input.StaffCode ||
                    (this.StaffCode != null &&
                    this.StaffCode.Equals(input.StaffCode))
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
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.IsTeachingStaff == input.IsTeachingStaff ||
                    (this.IsTeachingStaff != null &&
                    this.IsTeachingStaff.Equals(input.IsTeachingStaff))
                ) && 
                (
                    this.IncludedInCensus == input.IncludedInCensus ||
                    (this.IncludedInCensus != null &&
                    this.IncludedInCensus.Equals(input.IncludedInCensus))
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
                    this.Demographics == input.Demographics ||
                    (this.Demographics != null &&
                    this.Demographics.Equals(input.Demographics))
                ) && 
                (
                    this.QualificationInfo == input.QualificationInfo ||
                    (this.QualificationInfo != null &&
                    this.QualificationInfo.Equals(input.QualificationInfo))
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
                if (this.MisId != null)
                    hashCode = hashCode * 59 + this.MisId.GetHashCode();
                if (this.StaffCode != null)
                    hashCode = hashCode * 59 + this.StaffCode.GetHashCode();
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
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.IsTeachingStaff != null)
                    hashCode = hashCode * 59 + this.IsTeachingStaff.GetHashCode();
                if (this.IncludedInCensus != null)
                    hashCode = hashCode * 59 + this.IncludedInCensus.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.Demographics != null)
                    hashCode = hashCode * 59 + this.Demographics.GetHashCode();
                if (this.QualificationInfo != null)
                    hashCode = hashCode * 59 + this.QualificationInfo.GetHashCode();
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
