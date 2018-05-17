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
    /// last_week object
    /// </summary>
    [DataContract]
    public partial class GetFwLeaderboardsCorporationsLastWeek :  IEquatable<GetFwLeaderboardsCorporationsLastWeek>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetFwLeaderboardsCorporationsLastWeek" /> class.
        /// </summary>
        /// <param name="Amount">Amount of kills.</param>
        /// <param name="CorporationId">corporation_id integer.</param>
        public GetFwLeaderboardsCorporationsLastWeek(int? Amount = default(int?), int? CorporationId = default(int?))
        {
            this.Amount = Amount;
            this.CorporationId = CorporationId;
        }
        
        /// <summary>
        /// Amount of kills
        /// </summary>
        /// <value>Amount of kills</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public int? Amount { get; set; }

        /// <summary>
        /// corporation_id integer
        /// </summary>
        /// <value>corporation_id integer</value>
        [DataMember(Name="corporation_id", EmitDefaultValue=false)]
        public int? CorporationId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetFwLeaderboardsCorporationsLastWeek {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  CorporationId: ").Append(CorporationId).Append("\n");
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
            return this.Equals(input as GetFwLeaderboardsCorporationsLastWeek);
        }

        /// <summary>
        /// Returns true if GetFwLeaderboardsCorporationsLastWeek instances are equal
        /// </summary>
        /// <param name="input">Instance of GetFwLeaderboardsCorporationsLastWeek to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetFwLeaderboardsCorporationsLastWeek input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.CorporationId == input.CorporationId ||
                    (this.CorporationId != null &&
                    this.CorporationId.Equals(input.CorporationId))
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
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.CorporationId != null)
                    hashCode = hashCode * 59 + this.CorporationId.GetHashCode();
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
