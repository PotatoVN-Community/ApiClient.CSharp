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
    /// GalgameUpdateDto
    /// </summary>
    [DataContract(Name = "GalgameUpdateDto")]
    public partial class GalgameUpdateDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets PlayType
        /// </summary>
        [DataMember(Name = "playType", EmitDefaultValue = false)]
        public PlayType? PlayType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GalgameUpdateDto" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="bgmId">bgmId.</param>
        /// <param name="vndbId">vndbId.</param>
        /// <param name="name">name.</param>
        /// <param name="cnName">cnName.</param>
        /// <param name="description">description.</param>
        /// <param name="developer">developer.</param>
        /// <param name="expectedPlayTime">expectedPlayTime.</param>
        /// <param name="rating">rating.</param>
        /// <param name="releaseDateTimeStamp">releaseDateTimeStamp.</param>
        /// <param name="imageLoc">imageLoc.</param>
        /// <param name="tags">tags.</param>
        /// <param name="totalPlayTime">totalPlayTime.</param>
        /// <param name="playType">playType.</param>
        /// <param name="characters">characters.</param>
        /// <param name="playTime">playTime.</param>
        /// <param name="comment">comment.</param>
        /// <param name="myRate">myRate.</param>
        /// <param name="privateComment">privateComment.</param>
        /// <param name="playCount">playCount.</param>
        public GalgameUpdateDto(int? id = default, string bgmId = default, string vndbId = default, string name = default, string cnName = default, string description = default, string developer = default, string expectedPlayTime = default, float? rating = default, long? releaseDateTimeStamp = default, string imageLoc = default, List<string> tags = default, int? totalPlayTime = default, PlayType? playType = default, List<CharacterUpdateDto> characters = default, List<PlayLogDto> playTime = default, string comment = default, int? myRate = default, bool? privateComment = default, int? playCount = default)
        {
            this.Id = id;
            this.BgmId = bgmId;
            this.VndbId = vndbId;
            this.Name = name;
            this.CnName = cnName;
            this.Description = description;
            this.Developer = developer;
            this.ExpectedPlayTime = expectedPlayTime;
            this.Rating = rating;
            this.ReleaseDateTimeStamp = releaseDateTimeStamp;
            this.ImageLoc = imageLoc;
            this.Tags = tags;
            this.TotalPlayTime = totalPlayTime;
            this.PlayType = playType;
            this.Characters = characters;
            this.PlayTime = playTime;
            this.Comment = comment;
            this.MyRate = myRate;
            this.PrivateComment = privateComment;
            this.PlayCount = playCount;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public int? Id { get; set; }

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
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets CnName
        /// </summary>
        [DataMember(Name = "cnName", EmitDefaultValue = true)]
        public string CnName { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Developer
        /// </summary>
        [DataMember(Name = "developer", EmitDefaultValue = true)]
        public string Developer { get; set; }

        /// <summary>
        /// Gets or Sets ExpectedPlayTime
        /// </summary>
        [DataMember(Name = "expectedPlayTime", EmitDefaultValue = true)]
        public string ExpectedPlayTime { get; set; }

        /// <summary>
        /// Gets or Sets Rating
        /// </summary>
        [DataMember(Name = "rating", EmitDefaultValue = true)]
        public float? Rating { get; set; }

        /// <summary>
        /// Gets or Sets ReleaseDateTimeStamp
        /// </summary>
        [DataMember(Name = "releaseDateTimeStamp", EmitDefaultValue = true)]
        public long? ReleaseDateTimeStamp { get; set; }

        /// <summary>
        /// Gets or Sets ImageLoc
        /// </summary>
        [DataMember(Name = "imageLoc", EmitDefaultValue = true)]
        public string ImageLoc { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name = "tags", EmitDefaultValue = true)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Gets or Sets TotalPlayTime
        /// </summary>
        [DataMember(Name = "totalPlayTime", EmitDefaultValue = true)]
        public int? TotalPlayTime { get; set; }

        /// <summary>
        /// Gets or Sets Characters
        /// </summary>
        [DataMember(Name = "characters", EmitDefaultValue = true)]
        public List<CharacterUpdateDto> Characters { get; set; }

        /// <summary>
        /// Gets or Sets PlayTime
        /// </summary>
        [DataMember(Name = "playTime", EmitDefaultValue = true)]
        public List<PlayLogDto> PlayTime { get; set; }

        /// <summary>
        /// Gets or Sets Comment
        /// </summary>
        [DataMember(Name = "comment", EmitDefaultValue = true)]
        public string Comment { get; set; }

        /// <summary>
        /// Gets or Sets MyRate
        /// </summary>
        [DataMember(Name = "myRate", EmitDefaultValue = true)]
        public int? MyRate { get; set; }

        /// <summary>
        /// Gets or Sets PrivateComment
        /// </summary>
        [DataMember(Name = "privateComment", EmitDefaultValue = true)]
        public bool? PrivateComment { get; set; }

        /// <summary>
        /// Gets or Sets PlayCount
        /// </summary>
        [DataMember(Name = "playCount", EmitDefaultValue = true)]
        public int? PlayCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GalgameUpdateDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  BgmId: ").Append(BgmId).Append("\n");
            sb.Append("  VndbId: ").Append(VndbId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CnName: ").Append(CnName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Developer: ").Append(Developer).Append("\n");
            sb.Append("  ExpectedPlayTime: ").Append(ExpectedPlayTime).Append("\n");
            sb.Append("  Rating: ").Append(Rating).Append("\n");
            sb.Append("  ReleaseDateTimeStamp: ").Append(ReleaseDateTimeStamp).Append("\n");
            sb.Append("  ImageLoc: ").Append(ImageLoc).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  TotalPlayTime: ").Append(TotalPlayTime).Append("\n");
            sb.Append("  PlayType: ").Append(PlayType).Append("\n");
            sb.Append("  Characters: ").Append(Characters).Append("\n");
            sb.Append("  PlayTime: ").Append(PlayTime).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  MyRate: ").Append(MyRate).Append("\n");
            sb.Append("  PrivateComment: ").Append(PrivateComment).Append("\n");
            sb.Append("  PlayCount: ").Append(PlayCount).Append("\n");
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
