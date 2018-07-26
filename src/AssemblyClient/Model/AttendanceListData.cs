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
    /// The attendances resource details AM and PM roll call attendance marks for students.
    /// </summary>
    [DataContract]
    public partial class AttendanceListData :  IEquatable<AttendanceListData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AttendanceListData" /> class.
        /// </summary>
        /// <param name="_object">Object type.</param>
        /// <param name="id">Internal stable ID given to all attendances on the Platform.</param>
        /// <param name="studentId">The ID of the student that the attendance is attached to.</param>
        /// <param name="registrationGroupId">The ID of the subject that the attendance is attached to.</param>
        /// <param name="sessionDate">The date of the attendance.</param>
        /// <param name="sessionName">Denotes whether the attendance is an AM session or PM session (morning or afternoon).</param>
        /// <param name="attendanceMark">The attendance mark.</param>
        /// <param name="minutesLate">If the attendance mark is &#39;L&#39; for &#39;Late&#39;, how many minutes late the student was.</param>
        /// <param name="comments">Any additional comments.</param>
        public AttendanceListData(string _object = default(string), int? id = default(int?), int? studentId = default(int?), int? registrationGroupId = default(int?), DateTime? sessionDate = default(DateTime?), string sessionName = default(string), string attendanceMark = default(string), int? minutesLate = default(int?), string comments = default(string))
        {
            this.Object = _object;
            this.Id = id;
            this.StudentId = studentId;
            this.RegistrationGroupId = registrationGroupId;
            this.SessionDate = sessionDate;
            this.SessionName = sessionName;
            this.AttendanceMark = attendanceMark;
            this.MinutesLate = minutesLate;
            this.Comments = comments;
        }
        
        /// <summary>
        /// Object type
        /// </summary>
        /// <value>Object type</value>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public string Object { get; set; }

        /// <summary>
        /// Internal stable ID given to all attendances on the Platform
        /// </summary>
        /// <value>Internal stable ID given to all attendances on the Platform</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// The ID of the student that the attendance is attached to
        /// </summary>
        /// <value>The ID of the student that the attendance is attached to</value>
        [DataMember(Name="student_id", EmitDefaultValue=false)]
        public int? StudentId { get; set; }

        /// <summary>
        /// The ID of the subject that the attendance is attached to
        /// </summary>
        /// <value>The ID of the subject that the attendance is attached to</value>
        [DataMember(Name="registration_group_id", EmitDefaultValue=false)]
        public int? RegistrationGroupId { get; set; }

        /// <summary>
        /// The date of the attendance
        /// </summary>
        /// <value>The date of the attendance</value>
        [DataMember(Name="session_date", EmitDefaultValue=false)]
        public DateTime? SessionDate { get; set; }

        /// <summary>
        /// Denotes whether the attendance is an AM session or PM session (morning or afternoon)
        /// </summary>
        /// <value>Denotes whether the attendance is an AM session or PM session (morning or afternoon)</value>
        [DataMember(Name="session_name", EmitDefaultValue=false)]
        public string SessionName { get; set; }

        /// <summary>
        /// The attendance mark
        /// </summary>
        /// <value>The attendance mark</value>
        [DataMember(Name="attendance_mark", EmitDefaultValue=false)]
        public string AttendanceMark { get; set; }

        /// <summary>
        /// If the attendance mark is &#39;L&#39; for &#39;Late&#39;, how many minutes late the student was
        /// </summary>
        /// <value>If the attendance mark is &#39;L&#39; for &#39;Late&#39;, how many minutes late the student was</value>
        [DataMember(Name="minutes_late", EmitDefaultValue=false)]
        public int? MinutesLate { get; set; }

        /// <summary>
        /// Any additional comments
        /// </summary>
        /// <value>Any additional comments</value>
        [DataMember(Name="comments", EmitDefaultValue=false)]
        public string Comments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttendanceListData {\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  StudentId: ").Append(StudentId).Append("\n");
            sb.Append("  RegistrationGroupId: ").Append(RegistrationGroupId).Append("\n");
            sb.Append("  SessionDate: ").Append(SessionDate).Append("\n");
            sb.Append("  SessionName: ").Append(SessionName).Append("\n");
            sb.Append("  AttendanceMark: ").Append(AttendanceMark).Append("\n");
            sb.Append("  MinutesLate: ").Append(MinutesLate).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
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
            return this.Equals(input as AttendanceListData);
        }

        /// <summary>
        /// Returns true if AttendanceListData instances are equal
        /// </summary>
        /// <param name="input">Instance of AttendanceListData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AttendanceListData input)
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
                    this.StudentId == input.StudentId ||
                    (this.StudentId != null &&
                    this.StudentId.Equals(input.StudentId))
                ) && 
                (
                    this.RegistrationGroupId == input.RegistrationGroupId ||
                    (this.RegistrationGroupId != null &&
                    this.RegistrationGroupId.Equals(input.RegistrationGroupId))
                ) && 
                (
                    this.SessionDate == input.SessionDate ||
                    (this.SessionDate != null &&
                    this.SessionDate.Equals(input.SessionDate))
                ) && 
                (
                    this.SessionName == input.SessionName ||
                    (this.SessionName != null &&
                    this.SessionName.Equals(input.SessionName))
                ) && 
                (
                    this.AttendanceMark == input.AttendanceMark ||
                    (this.AttendanceMark != null &&
                    this.AttendanceMark.Equals(input.AttendanceMark))
                ) && 
                (
                    this.MinutesLate == input.MinutesLate ||
                    (this.MinutesLate != null &&
                    this.MinutesLate.Equals(input.MinutesLate))
                ) && 
                (
                    this.Comments == input.Comments ||
                    (this.Comments != null &&
                    this.Comments.Equals(input.Comments))
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
                if (this.StudentId != null)
                    hashCode = hashCode * 59 + this.StudentId.GetHashCode();
                if (this.RegistrationGroupId != null)
                    hashCode = hashCode * 59 + this.RegistrationGroupId.GetHashCode();
                if (this.SessionDate != null)
                    hashCode = hashCode * 59 + this.SessionDate.GetHashCode();
                if (this.SessionName != null)
                    hashCode = hashCode * 59 + this.SessionName.GetHashCode();
                if (this.AttendanceMark != null)
                    hashCode = hashCode * 59 + this.AttendanceMark.GetHashCode();
                if (this.MinutesLate != null)
                    hashCode = hashCode * 59 + this.MinutesLate.GetHashCode();
                if (this.Comments != null)
                    hashCode = hashCode * 59 + this.Comments.GetHashCode();
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
