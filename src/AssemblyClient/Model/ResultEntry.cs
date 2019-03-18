using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace AssemblyClient {

	public class ResultEntry
	{
		[JsonProperty("student_id")]
		public int? StudentId { get; set; }

		[JsonProperty("result_id")]
		public int? ResultId { get; set; }

		[JsonProperty("grade_id")]
		public int? GradeId { get; set; }

		[JsonProperty("result_date")]
		public DateTime? ResultDate { get; set; }


		public ResultEntry()
		{
		}
	}

}