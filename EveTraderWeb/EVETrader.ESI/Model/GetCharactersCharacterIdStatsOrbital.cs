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
    /// orbital object
    /// </summary>
    [DataContract]
    public partial class GetCharactersCharacterIdStatsOrbital :  IEquatable<GetCharactersCharacterIdStatsOrbital>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersCharacterIdStatsOrbital" /> class.
        /// </summary>
        /// <param name="StrikeCharactersKilled">strike_characters_killed integer.</param>
        /// <param name="StrikeDamageToPlayersArmorAmount">strike_damage_to_players_armor_amount integer.</param>
        /// <param name="StrikeDamageToPlayersShieldAmount">strike_damage_to_players_shield_amount integer.</param>
        public GetCharactersCharacterIdStatsOrbital(long? StrikeCharactersKilled = default(long?), long? StrikeDamageToPlayersArmorAmount = default(long?), long? StrikeDamageToPlayersShieldAmount = default(long?))
        {
            this.StrikeCharactersKilled = StrikeCharactersKilled;
            this.StrikeDamageToPlayersArmorAmount = StrikeDamageToPlayersArmorAmount;
            this.StrikeDamageToPlayersShieldAmount = StrikeDamageToPlayersShieldAmount;
        }
        
        /// <summary>
        /// strike_characters_killed integer
        /// </summary>
        /// <value>strike_characters_killed integer</value>
        [DataMember(Name="strike_characters_killed", EmitDefaultValue=false)]
        public long? StrikeCharactersKilled { get; set; }

        /// <summary>
        /// strike_damage_to_players_armor_amount integer
        /// </summary>
        /// <value>strike_damage_to_players_armor_amount integer</value>
        [DataMember(Name="strike_damage_to_players_armor_amount", EmitDefaultValue=false)]
        public long? StrikeDamageToPlayersArmorAmount { get; set; }

        /// <summary>
        /// strike_damage_to_players_shield_amount integer
        /// </summary>
        /// <value>strike_damage_to_players_shield_amount integer</value>
        [DataMember(Name="strike_damage_to_players_shield_amount", EmitDefaultValue=false)]
        public long? StrikeDamageToPlayersShieldAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCharactersCharacterIdStatsOrbital {\n");
            sb.Append("  StrikeCharactersKilled: ").Append(StrikeCharactersKilled).Append("\n");
            sb.Append("  StrikeDamageToPlayersArmorAmount: ").Append(StrikeDamageToPlayersArmorAmount).Append("\n");
            sb.Append("  StrikeDamageToPlayersShieldAmount: ").Append(StrikeDamageToPlayersShieldAmount).Append("\n");
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
            return this.Equals(input as GetCharactersCharacterIdStatsOrbital);
        }

        /// <summary>
        /// Returns true if GetCharactersCharacterIdStatsOrbital instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCharactersCharacterIdStatsOrbital to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCharactersCharacterIdStatsOrbital input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StrikeCharactersKilled == input.StrikeCharactersKilled ||
                    (this.StrikeCharactersKilled != null &&
                    this.StrikeCharactersKilled.Equals(input.StrikeCharactersKilled))
                ) && 
                (
                    this.StrikeDamageToPlayersArmorAmount == input.StrikeDamageToPlayersArmorAmount ||
                    (this.StrikeDamageToPlayersArmorAmount != null &&
                    this.StrikeDamageToPlayersArmorAmount.Equals(input.StrikeDamageToPlayersArmorAmount))
                ) && 
                (
                    this.StrikeDamageToPlayersShieldAmount == input.StrikeDamageToPlayersShieldAmount ||
                    (this.StrikeDamageToPlayersShieldAmount != null &&
                    this.StrikeDamageToPlayersShieldAmount.Equals(input.StrikeDamageToPlayersShieldAmount))
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
                if (this.StrikeCharactersKilled != null)
                    hashCode = hashCode * 59 + this.StrikeCharactersKilled.GetHashCode();
                if (this.StrikeDamageToPlayersArmorAmount != null)
                    hashCode = hashCode * 59 + this.StrikeDamageToPlayersArmorAmount.GetHashCode();
                if (this.StrikeDamageToPlayersShieldAmount != null)
                    hashCode = hashCode * 59 + this.StrikeDamageToPlayersShieldAmount.GetHashCode();
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