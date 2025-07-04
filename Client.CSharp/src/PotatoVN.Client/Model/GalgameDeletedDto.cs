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
    /// GalgameDeletedDto
    /// </summary>
    [DataContract(Name = "GalgameDeletedDto")]
    public partial class GalgameDeletedDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GalgameDeletedDto" /> class.
        /// </summary>
        /// <param name="galgameId">galgameId.</param>
        /// <param name="deleteTimeStamp">deleteTimeStamp.</param>
        public GalgameDeletedDto(int galgameId = default, long deleteTimeStamp = default)
        {
            this.GalgameId = galgameId;
            this.DeleteTimeStamp = deleteTimeStamp;
        }

        /// <summary>
        /// Gets or Sets GalgameId
        /// </summary>
        [DataMember(Name = "galgameId", EmitDefaultValue = false)]
        public int GalgameId { get; set; }

        /// <summary>
        /// Gets or Sets DeleteTimeStamp
        /// </summary>
        [DataMember(Name = "deleteTimeStamp", EmitDefaultValue = false)]
        public long DeleteTimeStamp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GalgameDeletedDto {\n");
            sb.Append("  GalgameId: ").Append(GalgameId).Append("\n");
            sb.Append("  DeleteTimeStamp: ").Append(DeleteTimeStamp).Append("\n");
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
