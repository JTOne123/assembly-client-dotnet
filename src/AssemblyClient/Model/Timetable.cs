/**
 * Assembly Developer API .NET Client
 * SDK Version 2.2.463
 * API Version 1.1.0
 *
 * Support
 * Email: help@assembly.education
 * URL:   http://developers.assembly.education
 *
 * Terms of Service: http://assembly.education/terms/
 * License:          MIT, https://spdx.org/licenses/MIT.html
 */


using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace AssemblyClient {
  public class Timetable
  {
    [JsonProperty("object")]
    public string Object { get; set; }

    [JsonProperty("id")]
    public int? Id { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("start_date")]
    public DateTime? StartDate { get; set; }

    [JsonProperty("end_date")]
    public DateTime? EndDate { get; set; }

    [JsonProperty("weeks")]
    public int? Weeks { get; set; }

    [JsonProperty("days_per_week")]
    public int? DaysPerWeek { get; set; }

    [JsonProperty("periods_per_day")]
    public int? PeriodsPerDay { get; set; }

    [JsonProperty("days")]
    public List<TimetableDays> Days { get; set; }


    public Timetable()
    {
      Days = new List<TimetableDays>();
    }
  }
}
