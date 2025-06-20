/*
 * PotatoVN.Server
 *
 * PotatoVN 同步服务器 最新更新：galgame新增playcount字段
 *
 * The version of the OpenAPI document: v1.4
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using FileParameter = PotatoVN.Client.Client.FileParameter;
using OpenAPIDateConverter = PotatoVN.Client.Client.OpenAPIDateConverter;

namespace PotatoVN.Client.Model
{
    /// <summary>
    /// DateOnly
    /// </summary>
    [DataContract(Name = "DateOnly")]
    public partial class DateOnly : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets DayOfWeek
        /// </summary>
        [DataMember(Name = "dayOfWeek", EmitDefaultValue = false)]
        public DayOfWeek? DayOfWeek { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DateOnly" /> class.
        /// </summary>
        /// <param name="year">year.</param>
        /// <param name="month">month.</param>
        /// <param name="day">day.</param>
        /// <param name="dayOfWeek">dayOfWeek.</param>
        public DateOnly(int year = default, int month = default, int day = default, DayOfWeek? dayOfWeek = default)
        {
            this.Year = year;
            this.Month = month;
            this.Day = day;
            this.DayOfWeek = dayOfWeek;
        }

        /// <summary>
        /// Gets or Sets Year
        /// </summary>
        [DataMember(Name = "year", EmitDefaultValue = false)]
        public int Year { get; set; }

        /// <summary>
        /// Gets or Sets Month
        /// </summary>
        [DataMember(Name = "month", EmitDefaultValue = false)]
        public int Month { get; set; }

        /// <summary>
        /// Gets or Sets Day
        /// </summary>
        [DataMember(Name = "day", EmitDefaultValue = false)]
        public int Day { get; set; }

        /// <summary>
        /// Gets or Sets DayOfYear
        /// </summary>
        [DataMember(Name = "dayOfYear", EmitDefaultValue = false)]
        public int DayOfYear { get; private set; }

        /// <summary>
        /// Returns false as DayOfYear should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDayOfYear()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets DayNumber
        /// </summary>
        [DataMember(Name = "dayNumber", EmitDefaultValue = false)]
        public int DayNumber { get; private set; }

        /// <summary>
        /// Returns false as DayNumber should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDayNumber()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DateOnly {\n");
            sb.Append("  Year: ").Append(Year).Append("\n");
            sb.Append("  Month: ").Append(Month).Append("\n");
            sb.Append("  Day: ").Append(Day).Append("\n");
            sb.Append("  DayOfWeek: ").Append(DayOfWeek).Append("\n");
            sb.Append("  DayOfYear: ").Append(DayOfYear).Append("\n");
            sb.Append("  DayNumber: ").Append(DayNumber).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
