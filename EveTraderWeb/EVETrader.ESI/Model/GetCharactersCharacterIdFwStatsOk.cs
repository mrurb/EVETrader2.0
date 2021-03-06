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
    public partial class GetCharactersCharacterIdFwStatsOk :  IEquatable<GetCharactersCharacterIdFwStatsOk>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersCharacterIdFwStatsOk" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetCharactersCharacterIdFwStatsOk() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersCharacterIdFwStatsOk" /> class.
        /// </summary>
        /// <param name="CurrentRank">The given character&#39;s current faction rank.</param>
        /// <param name="EnlistedOn">The enlistment date of the given character into faction warfare. Will not be included if character is not enlisted in faction warfare.</param>
        /// <param name="FactionId">The faction the given character is enlisted to fight for. Will not be included if character is not enlisted in faction warfare.</param>
        /// <param name="HighestRank">The given character&#39;s highest faction rank achieved.</param>
        /// <param name="Kills">Kills (required).</param>
        /// <param name="VictoryPoints">VictoryPoints (required).</param>
        public GetCharactersCharacterIdFwStatsOk(int? CurrentRank = default(int?), DateTime? EnlistedOn = default(DateTime?), int? FactionId = default(int?), int? HighestRank = default(int?), GetCharactersCharacterIdFwStatsKills Kills = default(GetCharactersCharacterIdFwStatsKills), GetCharactersCharacterIdFwStatsVictoryPoints VictoryPoints = default(GetCharactersCharacterIdFwStatsVictoryPoints))
        {
            // to ensure "Kills" is required (not null)
            if (Kills == null)
            {
                throw new InvalidDataException("Kills is a required property for GetCharactersCharacterIdFwStatsOk and cannot be null");
            }
            else
            {
                this.Kills = Kills;
            }
            // to ensure "VictoryPoints" is required (not null)
            if (VictoryPoints == null)
            {
                throw new InvalidDataException("VictoryPoints is a required property for GetCharactersCharacterIdFwStatsOk and cannot be null");
            }
            else
            {
                this.VictoryPoints = VictoryPoints;
            }
            this.CurrentRank = CurrentRank;
            this.EnlistedOn = EnlistedOn;
            this.FactionId = FactionId;
            this.HighestRank = HighestRank;
        }
        
        /// <summary>
        /// The given character&#39;s current faction rank
        /// </summary>
        /// <value>The given character&#39;s current faction rank</value>
        [DataMember(Name="current_rank", EmitDefaultValue=false)]
        public int? CurrentRank { get; set; }

        /// <summary>
        /// The enlistment date of the given character into faction warfare. Will not be included if character is not enlisted in faction warfare
        /// </summary>
        /// <value>The enlistment date of the given character into faction warfare. Will not be included if character is not enlisted in faction warfare</value>
        [DataMember(Name="enlisted_on", EmitDefaultValue=false)]
        public DateTime? EnlistedOn { get; set; }

        /// <summary>
        /// The faction the given character is enlisted to fight for. Will not be included if character is not enlisted in faction warfare
        /// </summary>
        /// <value>The faction the given character is enlisted to fight for. Will not be included if character is not enlisted in faction warfare</value>
        [DataMember(Name="faction_id", EmitDefaultValue=false)]
        public int? FactionId { get; set; }

        /// <summary>
        /// The given character&#39;s highest faction rank achieved
        /// </summary>
        /// <value>The given character&#39;s highest faction rank achieved</value>
        [DataMember(Name="highest_rank", EmitDefaultValue=false)]
        public int? HighestRank { get; set; }

        /// <summary>
        /// Gets or Sets Kills
        /// </summary>
        [DataMember(Name="kills", EmitDefaultValue=false)]
        public GetCharactersCharacterIdFwStatsKills Kills { get; set; }

        /// <summary>
        /// Gets or Sets VictoryPoints
        /// </summary>
        [DataMember(Name="victory_points", EmitDefaultValue=false)]
        public GetCharactersCharacterIdFwStatsVictoryPoints VictoryPoints { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCharactersCharacterIdFwStatsOk {\n");
            sb.Append("  CurrentRank: ").Append(CurrentRank).Append("\n");
            sb.Append("  EnlistedOn: ").Append(EnlistedOn).Append("\n");
            sb.Append("  FactionId: ").Append(FactionId).Append("\n");
            sb.Append("  HighestRank: ").Append(HighestRank).Append("\n");
            sb.Append("  Kills: ").Append(Kills).Append("\n");
            sb.Append("  VictoryPoints: ").Append(VictoryPoints).Append("\n");
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
            return this.Equals(input as GetCharactersCharacterIdFwStatsOk);
        }

        /// <summary>
        /// Returns true if GetCharactersCharacterIdFwStatsOk instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCharactersCharacterIdFwStatsOk to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCharactersCharacterIdFwStatsOk input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CurrentRank == input.CurrentRank ||
                    (this.CurrentRank != null &&
                    this.CurrentRank.Equals(input.CurrentRank))
                ) && 
                (
                    this.EnlistedOn == input.EnlistedOn ||
                    (this.EnlistedOn != null &&
                    this.EnlistedOn.Equals(input.EnlistedOn))
                ) && 
                (
                    this.FactionId == input.FactionId ||
                    (this.FactionId != null &&
                    this.FactionId.Equals(input.FactionId))
                ) && 
                (
                    this.HighestRank == input.HighestRank ||
                    (this.HighestRank != null &&
                    this.HighestRank.Equals(input.HighestRank))
                ) && 
                (
                    this.Kills == input.Kills ||
                    (this.Kills != null &&
                    this.Kills.Equals(input.Kills))
                ) && 
                (
                    this.VictoryPoints == input.VictoryPoints ||
                    (this.VictoryPoints != null &&
                    this.VictoryPoints.Equals(input.VictoryPoints))
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
                if (this.CurrentRank != null)
                    hashCode = hashCode * 59 + this.CurrentRank.GetHashCode();
                if (this.EnlistedOn != null)
                    hashCode = hashCode * 59 + this.EnlistedOn.GetHashCode();
                if (this.FactionId != null)
                    hashCode = hashCode * 59 + this.FactionId.GetHashCode();
                if (this.HighestRank != null)
                    hashCode = hashCode * 59 + this.HighestRank.GetHashCode();
                if (this.Kills != null)
                    hashCode = hashCode * 59 + this.Kills.GetHashCode();
                if (this.VictoryPoints != null)
                    hashCode = hashCode * 59 + this.VictoryPoints.GetHashCode();
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
            // CurrentRank (int?) maximum
            if(this.CurrentRank > (int?)9)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CurrentRank, must be a value less than or equal to 9.", new [] { "CurrentRank" });
            }

            // CurrentRank (int?) minimum
            if(this.CurrentRank < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CurrentRank, must be a value greater than or equal to 0.", new [] { "CurrentRank" });
            }

            // HighestRank (int?) maximum
            if(this.HighestRank > (int?)9)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HighestRank, must be a value less than or equal to 9.", new [] { "HighestRank" });
            }

            // HighestRank (int?) minimum
            if(this.HighestRank < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HighestRank, must be a value greater than or equal to 0.", new [] { "HighestRank" });
            }

            yield break;
        }
    }

}
