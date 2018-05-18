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
    public partial class PostCharactersAffiliation200Ok :  IEquatable<PostCharactersAffiliation200Ok>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostCharactersAffiliation200Ok" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PostCharactersAffiliation200Ok() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostCharactersAffiliation200Ok" /> class.
        /// </summary>
        /// <param name="AllianceId">The character&#39;s alliance ID, if their corporation is in an alliance.</param>
        /// <param name="CharacterId">The character&#39;s ID (required).</param>
        /// <param name="CorporationId">The character&#39;s corporation ID (required).</param>
        /// <param name="FactionId">The character&#39;s faction ID, if their corporation is in a faction.</param>
        public PostCharactersAffiliation200Ok(int? AllianceId = default(int?), int? CharacterId = default(int?), int? CorporationId = default(int?), int? FactionId = default(int?))
        {
            // to ensure "CharacterId" is required (not null)
            if (CharacterId == null)
            {
                throw new InvalidDataException("CharacterId is a required property for PostCharactersAffiliation200Ok and cannot be null");
            }
            else
            {
                this.CharacterId = CharacterId;
            }
            // to ensure "CorporationId" is required (not null)
            if (CorporationId == null)
            {
                throw new InvalidDataException("CorporationId is a required property for PostCharactersAffiliation200Ok and cannot be null");
            }
            else
            {
                this.CorporationId = CorporationId;
            }
            this.AllianceId = AllianceId;
            this.FactionId = FactionId;
        }
        
        /// <summary>
        /// The character&#39;s alliance ID, if their corporation is in an alliance
        /// </summary>
        /// <value>The character&#39;s alliance ID, if their corporation is in an alliance</value>
        [DataMember(Name="alliance_id", EmitDefaultValue=false)]
        public int? AllianceId { get; set; }

        /// <summary>
        /// The character&#39;s ID
        /// </summary>
        /// <value>The character&#39;s ID</value>
        [DataMember(Name="character_id", EmitDefaultValue=false)]
        public int? CharacterId { get; set; }

        /// <summary>
        /// The character&#39;s corporation ID
        /// </summary>
        /// <value>The character&#39;s corporation ID</value>
        [DataMember(Name="corporation_id", EmitDefaultValue=false)]
        public int? CorporationId { get; set; }

        /// <summary>
        /// The character&#39;s faction ID, if their corporation is in a faction
        /// </summary>
        /// <value>The character&#39;s faction ID, if their corporation is in a faction</value>
        [DataMember(Name="faction_id", EmitDefaultValue=false)]
        public int? FactionId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostCharactersAffiliation200Ok {\n");
            sb.Append("  AllianceId: ").Append(AllianceId).Append("\n");
            sb.Append("  CharacterId: ").Append(CharacterId).Append("\n");
            sb.Append("  CorporationId: ").Append(CorporationId).Append("\n");
            sb.Append("  FactionId: ").Append(FactionId).Append("\n");
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
            return this.Equals(input as PostCharactersAffiliation200Ok);
        }

        /// <summary>
        /// Returns true if PostCharactersAffiliation200Ok instances are equal
        /// </summary>
        /// <param name="input">Instance of PostCharactersAffiliation200Ok to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostCharactersAffiliation200Ok input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AllianceId == input.AllianceId ||
                    (this.AllianceId != null &&
                    this.AllianceId.Equals(input.AllianceId))
                ) && 
                (
                    this.CharacterId == input.CharacterId ||
                    (this.CharacterId != null &&
                    this.CharacterId.Equals(input.CharacterId))
                ) && 
                (
                    this.CorporationId == input.CorporationId ||
                    (this.CorporationId != null &&
                    this.CorporationId.Equals(input.CorporationId))
                ) && 
                (
                    this.FactionId == input.FactionId ||
                    (this.FactionId != null &&
                    this.FactionId.Equals(input.FactionId))
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
                if (this.AllianceId != null)
                    hashCode = hashCode * 59 + this.AllianceId.GetHashCode();
                if (this.CharacterId != null)
                    hashCode = hashCode * 59 + this.CharacterId.GetHashCode();
                if (this.CorporationId != null)
                    hashCode = hashCode * 59 + this.CorporationId.GetHashCode();
                if (this.FactionId != null)
                    hashCode = hashCode * 59 + this.FactionId.GetHashCode();
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