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
    public partial class GetIndustrySystems200Ok :  IEquatable<GetIndustrySystems200Ok>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetIndustrySystems200Ok" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetIndustrySystems200Ok() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetIndustrySystems200Ok" /> class.
        /// </summary>
        /// <param name="CostIndices">cost_indices array (required).</param>
        /// <param name="SolarSystemId">solar_system_id integer (required).</param>
        public GetIndustrySystems200Ok(List<GetIndustrySystemsCostIndice> CostIndices = default(List<GetIndustrySystemsCostIndice>), int? SolarSystemId = default(int?))
        {
            // to ensure "CostIndices" is required (not null)
            if (CostIndices == null)
            {
                throw new InvalidDataException("CostIndices is a required property for GetIndustrySystems200Ok and cannot be null");
            }
            else
            {
                this.CostIndices = CostIndices;
            }
            // to ensure "SolarSystemId" is required (not null)
            if (SolarSystemId == null)
            {
                throw new InvalidDataException("SolarSystemId is a required property for GetIndustrySystems200Ok and cannot be null");
            }
            else
            {
                this.SolarSystemId = SolarSystemId;
            }
        }
        
        /// <summary>
        /// cost_indices array
        /// </summary>
        /// <value>cost_indices array</value>
        [DataMember(Name="cost_indices", EmitDefaultValue=false)]
        public List<GetIndustrySystemsCostIndice> CostIndices { get; set; }

        /// <summary>
        /// solar_system_id integer
        /// </summary>
        /// <value>solar_system_id integer</value>
        [DataMember(Name="solar_system_id", EmitDefaultValue=false)]
        public int? SolarSystemId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetIndustrySystems200Ok {\n");
            sb.Append("  CostIndices: ").Append(CostIndices).Append("\n");
            sb.Append("  SolarSystemId: ").Append(SolarSystemId).Append("\n");
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
            return this.Equals(input as GetIndustrySystems200Ok);
        }

        /// <summary>
        /// Returns true if GetIndustrySystems200Ok instances are equal
        /// </summary>
        /// <param name="input">Instance of GetIndustrySystems200Ok to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetIndustrySystems200Ok input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CostIndices == input.CostIndices ||
                    this.CostIndices != null &&
                    this.CostIndices.SequenceEqual(input.CostIndices)
                ) && 
                (
                    this.SolarSystemId == input.SolarSystemId ||
                    (this.SolarSystemId != null &&
                    this.SolarSystemId.Equals(input.SolarSystemId))
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
                if (this.CostIndices != null)
                    hashCode = hashCode * 59 + this.CostIndices.GetHashCode();
                if (this.SolarSystemId != null)
                    hashCode = hashCode * 59 + this.SolarSystemId.GetHashCode();
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
