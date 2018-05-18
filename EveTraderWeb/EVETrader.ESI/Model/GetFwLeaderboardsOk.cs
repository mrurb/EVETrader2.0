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
    public partial class GetFwLeaderboardsOk :  IEquatable<GetFwLeaderboardsOk>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetFwLeaderboardsOk" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetFwLeaderboardsOk() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetFwLeaderboardsOk" /> class.
        /// </summary>
        /// <param name="Kills">Kills (required).</param>
        /// <param name="VictoryPoints">VictoryPoints (required).</param>
        public GetFwLeaderboardsOk(GetFwLeaderboardsKills Kills = default(GetFwLeaderboardsKills), GetFwLeaderboardsVictoryPoints VictoryPoints = default(GetFwLeaderboardsVictoryPoints))
        {
            // to ensure "Kills" is required (not null)
            if (Kills == null)
            {
                throw new InvalidDataException("Kills is a required property for GetFwLeaderboardsOk and cannot be null");
            }
            else
            {
                this.Kills = Kills;
            }
            // to ensure "VictoryPoints" is required (not null)
            if (VictoryPoints == null)
            {
                throw new InvalidDataException("VictoryPoints is a required property for GetFwLeaderboardsOk and cannot be null");
            }
            else
            {
                this.VictoryPoints = VictoryPoints;
            }
        }
        
        /// <summary>
        /// Gets or Sets Kills
        /// </summary>
        [DataMember(Name="kills", EmitDefaultValue=false)]
        public GetFwLeaderboardsKills Kills { get; set; }

        /// <summary>
        /// Gets or Sets VictoryPoints
        /// </summary>
        [DataMember(Name="victory_points", EmitDefaultValue=false)]
        public GetFwLeaderboardsVictoryPoints VictoryPoints { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetFwLeaderboardsOk {\n");
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
            return this.Equals(input as GetFwLeaderboardsOk);
        }

        /// <summary>
        /// Returns true if GetFwLeaderboardsOk instances are equal
        /// </summary>
        /// <param name="input">Instance of GetFwLeaderboardsOk to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetFwLeaderboardsOk input)
        {
            if (input == null)
                return false;

            return 
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
            yield break;
        }
    }

}