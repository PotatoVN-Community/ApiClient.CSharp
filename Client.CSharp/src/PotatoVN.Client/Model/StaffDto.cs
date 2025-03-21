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
    /// StaffDto
    /// </summary>
    [DataContract(Name = "StaffDto")]
    public partial class StaffDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Gender
        /// </summary>
        [DataMember(Name = "gender", EmitDefaultValue = false)]
        public Gender? Gender { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="StaffDto" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="isDeleted">isDeleted.</param>
        /// <param name="bgmId">bgmId.</param>
        /// <param name="vndbId">vndbId.</param>
        /// <param name="ymgalId">ymgalId.</param>
        /// <param name="japaneseName">japaneseName.</param>
        /// <param name="englishName">englishName.</param>
        /// <param name="chineseName">chineseName.</param>
        /// <param name="gender">gender.</param>
        /// <param name="description">description.</param>
        /// <param name="birthDateTimestamp">birthDateTimestamp.</param>
        /// <param name="externalImageLink">externalImageLink.</param>
        /// <param name="imageUrl">imageUrl.</param>
        /// <param name="lastModifyTimestamp">lastModifyTimestamp.</param>
        /// <param name="staffGames">staffGames.</param>
        public StaffDto(int id = default(int), bool isDeleted = default(bool), string bgmId = default(string), string vndbId = default(string), string ymgalId = default(string), string japaneseName = default(string), string englishName = default(string), string chineseName = default(string), Gender? gender = default(Gender?), string description = default(string), long birthDateTimestamp = default(long), string externalImageLink = default(string), string imageUrl = default(string), long lastModifyTimestamp = default(long), List<StaffGameDto> staffGames = default(List<StaffGameDto>))
        {
            this.Id = id;
            this.IsDeleted = isDeleted;
            this.BgmId = bgmId;
            this.VndbId = vndbId;
            this.YmgalId = ymgalId;
            this.JapaneseName = japaneseName;
            this.EnglishName = englishName;
            this.ChineseName = chineseName;
            this.Gender = gender;
            this.Description = description;
            this.BirthDateTimestamp = birthDateTimestamp;
            this.ExternalImageLink = externalImageLink;
            this.ImageUrl = imageUrl;
            this.LastModifyTimestamp = lastModifyTimestamp;
            this.StaffGames = staffGames;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets IsDeleted
        /// </summary>
        [DataMember(Name = "isDeleted", EmitDefaultValue = true)]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Gets or Sets BgmId
        /// </summary>
        [DataMember(Name = "bgmId", EmitDefaultValue = true)]
        public string BgmId { get; set; }

        /// <summary>
        /// Gets or Sets VndbId
        /// </summary>
        [DataMember(Name = "vndbId", EmitDefaultValue = true)]
        public string VndbId { get; set; }

        /// <summary>
        /// Gets or Sets YmgalId
        /// </summary>
        [DataMember(Name = "ymgalId", EmitDefaultValue = true)]
        public string YmgalId { get; set; }

        /// <summary>
        /// Gets or Sets JapaneseName
        /// </summary>
        [DataMember(Name = "japaneseName", EmitDefaultValue = true)]
        public string JapaneseName { get; set; }

        /// <summary>
        /// Gets or Sets EnglishName
        /// </summary>
        [DataMember(Name = "englishName", EmitDefaultValue = true)]
        public string EnglishName { get; set; }

        /// <summary>
        /// Gets or Sets ChineseName
        /// </summary>
        [DataMember(Name = "chineseName", EmitDefaultValue = true)]
        public string ChineseName { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets BirthDateTimestamp
        /// </summary>
        [DataMember(Name = "birthDateTimestamp", EmitDefaultValue = false)]
        public long BirthDateTimestamp { get; set; }

        /// <summary>
        /// Gets or Sets ExternalImageLink
        /// </summary>
        [DataMember(Name = "externalImageLink", EmitDefaultValue = true)]
        public string ExternalImageLink { get; set; }

        /// <summary>
        /// Gets or Sets ImageUrl
        /// </summary>
        [DataMember(Name = "imageUrl", EmitDefaultValue = true)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Gets or Sets LastModifyTimestamp
        /// </summary>
        [DataMember(Name = "lastModifyTimestamp", EmitDefaultValue = false)]
        public long LastModifyTimestamp { get; set; }

        /// <summary>
        /// Gets or Sets StaffGames
        /// </summary>
        [DataMember(Name = "staffGames", EmitDefaultValue = true)]
        public List<StaffGameDto> StaffGames { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class StaffDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IsDeleted: ").Append(IsDeleted).Append("\n");
            sb.Append("  BgmId: ").Append(BgmId).Append("\n");
            sb.Append("  VndbId: ").Append(VndbId).Append("\n");
            sb.Append("  YmgalId: ").Append(YmgalId).Append("\n");
            sb.Append("  JapaneseName: ").Append(JapaneseName).Append("\n");
            sb.Append("  EnglishName: ").Append(EnglishName).Append("\n");
            sb.Append("  ChineseName: ").Append(ChineseName).Append("\n");
            sb.Append("  Gender: ").Append(Gender).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  BirthDateTimestamp: ").Append(BirthDateTimestamp).Append("\n");
            sb.Append("  ExternalImageLink: ").Append(ExternalImageLink).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  LastModifyTimestamp: ").Append(LastModifyTimestamp).Append("\n");
            sb.Append("  StaffGames: ").Append(StaffGames).Append("\n");
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
            // BgmId (string) maxLength
            if (this.BgmId != null && this.BgmId.Length > 200)
            {
                yield return new ValidationResult("Invalid value for BgmId, length must be less than 200.", new [] { "BgmId" });
            }

            // VndbId (string) maxLength
            if (this.VndbId != null && this.VndbId.Length > 200)
            {
                yield return new ValidationResult("Invalid value for VndbId, length must be less than 200.", new [] { "VndbId" });
            }

            // YmgalId (string) maxLength
            if (this.YmgalId != null && this.YmgalId.Length > 200)
            {
                yield return new ValidationResult("Invalid value for YmgalId, length must be less than 200.", new [] { "YmgalId" });
            }

            // JapaneseName (string) maxLength
            if (this.JapaneseName != null && this.JapaneseName.Length > 200)
            {
                yield return new ValidationResult("Invalid value for JapaneseName, length must be less than 200.", new [] { "JapaneseName" });
            }

            // EnglishName (string) maxLength
            if (this.EnglishName != null && this.EnglishName.Length > 200)
            {
                yield return new ValidationResult("Invalid value for EnglishName, length must be less than 200.", new [] { "EnglishName" });
            }

            // ChineseName (string) maxLength
            if (this.ChineseName != null && this.ChineseName.Length > 200)
            {
                yield return new ValidationResult("Invalid value for ChineseName, length must be less than 200.", new [] { "ChineseName" });
            }

            // Description (string) maxLength
            if (this.Description != null && this.Description.Length > 10000)
            {
                yield return new ValidationResult("Invalid value for Description, length must be less than 10000.", new [] { "Description" });
            }

            // ExternalImageLink (string) maxLength
            if (this.ExternalImageLink != null && this.ExternalImageLink.Length > 2000)
            {
                yield return new ValidationResult("Invalid value for ExternalImageLink, length must be less than 2000.", new [] { "ExternalImageLink" });
            }

            yield break;
        }
    }

}
