/*
 * PotatoVN.Server
 *
 * PotatoVN 同步服务器 最新更新：支持staff同步
 *
 * The version of the OpenAPI document: v1.2
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using Newtonsoft.Json.Converters;

namespace PotatoVN.Client.Client
{
    /// <summary>
    /// Formatter for 'date' openapi formats ss defined by full-date - RFC3339
    /// see https://github.com/OAI/OpenAPI-Specification/blob/master/versions/3.0.0.md#data-types
    /// </summary>
    public class OpenAPIDateConverter : IsoDateTimeConverter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAPIDateConverter" /> class.
        /// </summary>
        public OpenAPIDateConverter()
        {
            // full-date   = date-fullyear "-" date-month "-" date-mday
            DateTimeFormat = "yyyy-MM-dd";
        }
    }
}
