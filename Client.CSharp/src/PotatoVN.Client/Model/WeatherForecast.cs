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
    /// WeatherForecast
    /// </summary>
    [DataContract(Name = "WeatherForecast")]
    public partial class WeatherForecast : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WeatherForecast" /> class.
        /// </summary>
        /// <param name="date">date.</param>
        /// <param name="temperatureC">temperatureC.</param>
        /// <param name="summary">summary.</param>
        public WeatherForecast(DateOnly date = default, int temperatureC = default, string summary = default)
        {
            this.Date = date;
            this.TemperatureC = temperatureC;
            this.Summary = summary;
        }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name = "date", EmitDefaultValue = false)]
        public DateOnly Date { get; set; }

        /// <summary>
        /// Gets or Sets TemperatureC
        /// </summary>
        [DataMember(Name = "temperatureC", EmitDefaultValue = false)]
        public int TemperatureC { get; set; }

        /// <summary>
        /// Gets or Sets TemperatureF
        /// </summary>
        [DataMember(Name = "temperatureF", EmitDefaultValue = false)]
        public int TemperatureF { get; private set; }

        /// <summary>
        /// Returns false as TemperatureF should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTemperatureF()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Summary
        /// </summary>
        [DataMember(Name = "summary", EmitDefaultValue = true)]
        public string Summary { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WeatherForecast {\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  TemperatureC: ").Append(TemperatureC).Append("\n");
            sb.Append("  TemperatureF: ").Append(TemperatureF).Append("\n");
            sb.Append("  Summary: ").Append(Summary).Append("\n");
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
