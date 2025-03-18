/*
 * PotatoVN.Server
 *
 * PotatoVN 同步服务器 最新更新：支持staff同步
 *
 * The version of the OpenAPI document: v1.2
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
    /// UserWithTokenDto
    /// </summary>
    [DataContract(Name = "UserWithTokenDto")]
    public partial class UserWithTokenDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserWithTokenDto" /> class.
        /// </summary>
        /// <param name="user">user.</param>
        /// <param name="token">token.</param>
        /// <param name="expire">expire.</param>
        public UserWithTokenDto(UserDto user = default(UserDto), string token = default(string), long expire = default(long))
        {
            this.User = user;
            this.Token = token;
            this.Expire = expire;
        }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name = "user", EmitDefaultValue = false)]
        public UserDto User { get; set; }

        /// <summary>
        /// Gets or Sets Token
        /// </summary>
        [DataMember(Name = "token", EmitDefaultValue = true)]
        public string Token { get; set; }

        /// <summary>
        /// Gets or Sets Expire
        /// </summary>
        [DataMember(Name = "expire", EmitDefaultValue = false)]
        public long Expire { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserWithTokenDto {\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  Expire: ").Append(Expire).Append("\n");
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
