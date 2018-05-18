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
    public partial class GetCharactersCharacterIdLoyaltyPoints200Ok :  IEquatable<GetCharactersCharacterIdLoyaltyPoints200Ok>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersCharacterIdLoyaltyPoints200Ok" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetCharactersCharacterIdLoyaltyPoints200Ok() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersCharacterIdLoyaltyPoints200Ok" /> class.
        /// </summary>
        /// <param name="CorporationId">corporation_id integer (required).</param>
        /// <param name="LoyaltyPoints">loyalty_points integer (required).</param>
        public GetCharactersCharacterIdLoyaltyPoints200Ok(int? CorporationId = default(int?), int? LoyaltyPoints = default(int?))
        {
            // to ensure "CorporationId" is required (not null)
            if (CorporationId == null)
            {
                throw new InvalidDataException("CorporationId is a required property for GetCharactersCharacterIdLoyaltyPoints200Ok and cannot be null");
            }
            else
            {
                this.CorporationId = CorporationId;
            }
            // to ensure "LoyaltyPoints" is required (not null)
            if (LoyaltyPoints == null)
            {
                throw new InvalidDataException("LoyaltyPoints is a required property for GetCharactersCharacterIdLoyaltyPoints200Ok and cannot be null");
            }
            else
            {
                this.LoyaltyPoints = LoyaltyPoints;
            }
        }
        
        /// <summary>
        /// corporation_id integer
        /// </summary>
        /// <value>corporation_id integer</value>
        [DataMember(Name="corporation_id", EmitDefaultValue=false)]
        public int? CorporationId { get; set; }

        /// <summary>
        /// loyalty_points integer
        /// </summary>
        /// <value>loyalty_points integer</value>
        [DataMember(Name="loyalty_points", EmitDefaultValue=false)]
        public int? LoyaltyPoints { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCharactersCharacterIdLoyaltyPoints200Ok {\n");
            sb.Append("  CorporationId: ").Append(CorporationId).Append("\n");
            sb.Append("  LoyaltyPoints: ").Append(LoyaltyPoints).Append("\n");
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
            return this.Equals(input as GetCharactersCharacterIdLoyaltyPoints200Ok);
        }

        /// <summary>
        /// Returns true if GetCharactersCharacterIdLoyaltyPoints200Ok instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCharactersCharacterIdLoyaltyPoints200Ok to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCharactersCharacterIdLoyaltyPoints200Ok input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CorporationId == input.CorporationId ||
                    (this.CorporationId != null &&
                    this.CorporationId.Equals(input.CorporationId))
                ) && 
                (
                    this.LoyaltyPoints == input.LoyaltyPoints ||
                    (this.LoyaltyPoints != null &&
                    this.LoyaltyPoints.Equals(input.LoyaltyPoints))
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
                if (this.CorporationId != null)
                    hashCode = hashCode * 59 + this.CorporationId.GetHashCode();
                if (this.LoyaltyPoints != null)
                    hashCode = hashCode * 59 + this.LoyaltyPoints.GetHashCode();
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