/* 
 * EVE Swagger Interface
 *
 * An OpenAPI for EVE Online
 *
 * OpenAPI spec version: 0.8.1
 * 
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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// 200 ok object
    /// </summary>
    [DataContract]
    public partial class GetCorporationsCorporationIdKillmailsRecent200Ok :  IEquatable<GetCorporationsCorporationIdKillmailsRecent200Ok>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCorporationsCorporationIdKillmailsRecent200Ok" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetCorporationsCorporationIdKillmailsRecent200Ok() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCorporationsCorporationIdKillmailsRecent200Ok" /> class.
        /// </summary>
        /// <param name="KillmailHash">A hash of this killmail (required).</param>
        /// <param name="KillmailId">ID of this killmail (required).</param>
        public GetCorporationsCorporationIdKillmailsRecent200Ok(string KillmailHash = default(string), int? KillmailId = default(int?))
        {
            // to ensure "KillmailHash" is required (not null)
            if (KillmailHash == null)
            {
                throw new InvalidDataException("KillmailHash is a required property for GetCorporationsCorporationIdKillmailsRecent200Ok and cannot be null");
            }
            else
            {
                this.KillmailHash = KillmailHash;
            }
            // to ensure "KillmailId" is required (not null)
            if (KillmailId == null)
            {
                throw new InvalidDataException("KillmailId is a required property for GetCorporationsCorporationIdKillmailsRecent200Ok and cannot be null");
            }
            else
            {
                this.KillmailId = KillmailId;
            }
        }
        
        /// <summary>
        /// A hash of this killmail
        /// </summary>
        /// <value>A hash of this killmail</value>
        [DataMember(Name="killmail_hash", EmitDefaultValue=false)]
        public string KillmailHash { get; set; }

        /// <summary>
        /// ID of this killmail
        /// </summary>
        /// <value>ID of this killmail</value>
        [DataMember(Name="killmail_id", EmitDefaultValue=false)]
        public int? KillmailId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCorporationsCorporationIdKillmailsRecent200Ok {\n");
            sb.Append("  KillmailHash: ").Append(KillmailHash).Append("\n");
            sb.Append("  KillmailId: ").Append(KillmailId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as GetCorporationsCorporationIdKillmailsRecent200Ok);
        }

        /// <summary>
        /// Returns true if GetCorporationsCorporationIdKillmailsRecent200Ok instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCorporationsCorporationIdKillmailsRecent200Ok to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCorporationsCorporationIdKillmailsRecent200Ok input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.KillmailHash == input.KillmailHash ||
                    (this.KillmailHash != null &&
                    this.KillmailHash.Equals(input.KillmailHash))
                ) && 
                (
                    this.KillmailId == input.KillmailId ||
                    (this.KillmailId != null &&
                    this.KillmailId.Equals(input.KillmailId))
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
                if (this.KillmailHash != null)
                    hashCode = hashCode * 59 + this.KillmailHash.GetHashCode();
                if (this.KillmailId != null)
                    hashCode = hashCode * 59 + this.KillmailId.GetHashCode();
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
