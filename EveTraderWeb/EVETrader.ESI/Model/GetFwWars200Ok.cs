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
    public partial class GetFwWars200Ok :  IEquatable<GetFwWars200Ok>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetFwWars200Ok" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetFwWars200Ok() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetFwWars200Ok" /> class.
        /// </summary>
        /// <param name="AgainstId">The faction ID of the enemy faction. (required).</param>
        /// <param name="FactionId">faction_id integer (required).</param>
        public GetFwWars200Ok(int? AgainstId = default(int?), int? FactionId = default(int?))
        {
            // to ensure "AgainstId" is required (not null)
            if (AgainstId == null)
            {
                throw new InvalidDataException("AgainstId is a required property for GetFwWars200Ok and cannot be null");
            }
            else
            {
                this.AgainstId = AgainstId;
            }
            // to ensure "FactionId" is required (not null)
            if (FactionId == null)
            {
                throw new InvalidDataException("FactionId is a required property for GetFwWars200Ok and cannot be null");
            }
            else
            {
                this.FactionId = FactionId;
            }
        }
        
        /// <summary>
        /// The faction ID of the enemy faction.
        /// </summary>
        /// <value>The faction ID of the enemy faction.</value>
        [DataMember(Name="against_id", EmitDefaultValue=false)]
        public int? AgainstId { get; set; }

        /// <summary>
        /// faction_id integer
        /// </summary>
        /// <value>faction_id integer</value>
        [DataMember(Name="faction_id", EmitDefaultValue=false)]
        public int? FactionId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetFwWars200Ok {\n");
            sb.Append("  AgainstId: ").Append(AgainstId).Append("\n");
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
            return this.Equals(input as GetFwWars200Ok);
        }

        /// <summary>
        /// Returns true if GetFwWars200Ok instances are equal
        /// </summary>
        /// <param name="input">Instance of GetFwWars200Ok to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetFwWars200Ok input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AgainstId == input.AgainstId ||
                    (this.AgainstId != null &&
                    this.AgainstId.Equals(input.AgainstId))
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
                if (this.AgainstId != null)
                    hashCode = hashCode * 59 + this.AgainstId.GetHashCode();
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
