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
    /// A page of create_result_payload objects
    /// </summary>
    [DataContract]
    public partial class CreateResultPayloadList :  IEquatable<CreateResultPayloadList>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateResultPayloadList" /> class.
        /// </summary>
        /// <param name="_object">Object type.</param>
        /// <param name="totalCount">Total number of objects available.</param>
        /// <param name="totalPages">Total number of pages available.</param>
        /// <param name="currentPage">Current page in pages available.</param>
        /// <param name="prevPage">Previous page number.</param>
        /// <param name="nextPage">Next page number.</param>
        /// <param name="data">The paged data.</param>
        public CreateResultPayloadList(string _object = default(string), int? totalCount = default(int?), int? totalPages = default(int?), int? currentPage = default(int?), int? prevPage = default(int?), int? nextPage = default(int?), List<CreateResultPayloadListData> data = default(List<CreateResultPayloadListData>))
        {
            this._object = _object;
            this.total_count = totalCount;
            this.total_pages = totalPages;
            this.current_page = currentPage;
            this.prev_page = prevPage;
            this.next_page = nextPage;
            this.data = data;
        }
        
        /// <summary>
        /// Object type
        /// </summary>
        /// <value>Object type</value>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public string _object { get; set; }

        /// <summary>
        /// Total number of objects available
        /// </summary>
        /// <value>Total number of objects available</value>
        [DataMember(Name="total_count", EmitDefaultValue=false)]
        public int? total_count { get; set; }

        /// <summary>
        /// Total number of pages available
        /// </summary>
        /// <value>Total number of pages available</value>
        [DataMember(Name="total_pages", EmitDefaultValue=false)]
        public int? total_pages { get; set; }

        /// <summary>
        /// Current page in pages available
        /// </summary>
        /// <value>Current page in pages available</value>
        [DataMember(Name="current_page", EmitDefaultValue=false)]
        public int? current_page { get; set; }

        /// <summary>
        /// Previous page number
        /// </summary>
        /// <value>Previous page number</value>
        [DataMember(Name="prev_page", EmitDefaultValue=false)]
        public int? prev_page { get; set; }

        /// <summary>
        /// Next page number
        /// </summary>
        /// <value>Next page number</value>
        [DataMember(Name="next_page", EmitDefaultValue=false)]
        public int? next_page { get; set; }

        /// <summary>
        /// The paged data
        /// </summary>
        /// <value>The paged data</value>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public List<CreateResultPayloadListData> data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateResultPayloadList {\n");
            sb.Append("  _object: ").Append(_object).Append("\n");
            sb.Append("  total_count: ").Append(total_count).Append("\n");
            sb.Append("  total_pages: ").Append(total_pages).Append("\n");
            sb.Append("  current_page: ").Append(current_page).Append("\n");
            sb.Append("  prev_page: ").Append(prev_page).Append("\n");
            sb.Append("  next_page: ").Append(next_page).Append("\n");
            sb.Append("  data: ").Append(data).Append("\n");
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
            return this.Equals(input as CreateResultPayloadList);
        }

        /// <summary>
        /// Returns true if CreateResultPayloadList instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateResultPayloadList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateResultPayloadList input)
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
                    this.total_count == input.total_count ||
                    (this.total_count != null &&
                    this.total_count.Equals(input.total_count))
                ) && 
                (
                    this.total_pages == input.total_pages ||
                    (this.total_pages != null &&
                    this.total_pages.Equals(input.total_pages))
                ) && 
                (
                    this.current_page == input.current_page ||
                    (this.current_page != null &&
                    this.current_page.Equals(input.current_page))
                ) && 
                (
                    this.prev_page == input.prev_page ||
                    (this.prev_page != null &&
                    this.prev_page.Equals(input.prev_page))
                ) && 
                (
                    this.next_page == input.next_page ||
                    (this.next_page != null &&
                    this.next_page.Equals(input.next_page))
                ) && 
                (
                    this.data == input.data ||
                    this.data != null &&
                    this.data.SequenceEqual(input.data)
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
                if (this.total_count != null)
                    hashCode = hashCode * 59 + this.total_count.GetHashCode();
                if (this.total_pages != null)
                    hashCode = hashCode * 59 + this.total_pages.GetHashCode();
                if (this.current_page != null)
                    hashCode = hashCode * 59 + this.current_page.GetHashCode();
                if (this.prev_page != null)
                    hashCode = hashCode * 59 + this.prev_page.GetHashCode();
                if (this.next_page != null)
                    hashCode = hashCode * 59 + this.next_page.GetHashCode();
                if (this.data != null)
                    hashCode = hashCode * 59 + this.data.GetHashCode();
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
