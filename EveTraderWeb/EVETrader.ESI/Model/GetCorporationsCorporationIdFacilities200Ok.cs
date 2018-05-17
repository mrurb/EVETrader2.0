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
    public partial class GetCorporationsCorporationIdFacilities200Ok :  IEquatable<GetCorporationsCorporationIdFacilities200Ok>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCorporationsCorporationIdFacilities200Ok" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetCorporationsCorporationIdFacilities200Ok() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCorporationsCorporationIdFacilities200Ok" /> class.
        /// </summary>
        /// <param name="FacilityId">facility_id integer (required).</param>
        /// <param name="SystemId">system_id integer (required).</param>
        /// <param name="TypeId">type_id integer (required).</param>
        public GetCorporationsCorporationIdFacilities200Ok(long? FacilityId = default(long?), int? SystemId = default(int?), int? TypeId = default(int?))
        {
            // to ensure "FacilityId" is required (not null)
            if (FacilityId == null)
            {
                throw new InvalidDataException("FacilityId is a required property for GetCorporationsCorporationIdFacilities200Ok and cannot be null");
            }
            else
            {
                this.FacilityId = FacilityId;
            }
            // to ensure "SystemId" is required (not null)
            if (SystemId == null)
            {
                throw new InvalidDataException("SystemId is a required property for GetCorporationsCorporationIdFacilities200Ok and cannot be null");
            }
            else
            {
                this.SystemId = SystemId;
            }
            // to ensure "TypeId" is required (not null)
            if (TypeId == null)
            {
                throw new InvalidDataException("TypeId is a required property for GetCorporationsCorporationIdFacilities200Ok and cannot be null");
            }
            else
            {
                this.TypeId = TypeId;
            }
        }
        
        /// <summary>
        /// facility_id integer
        /// </summary>
        /// <value>facility_id integer</value>
        [DataMember(Name="facility_id", EmitDefaultValue=false)]
        public long? FacilityId { get; set; }

        /// <summary>
        /// system_id integer
        /// </summary>
        /// <value>system_id integer</value>
        [DataMember(Name="system_id", EmitDefaultValue=false)]
        public int? SystemId { get; set; }

        /// <summary>
        /// type_id integer
        /// </summary>
        /// <value>type_id integer</value>
        [DataMember(Name="type_id", EmitDefaultValue=false)]
        public int? TypeId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCorporationsCorporationIdFacilities200Ok {\n");
            sb.Append("  FacilityId: ").Append(FacilityId).Append("\n");
            sb.Append("  SystemId: ").Append(SystemId).Append("\n");
            sb.Append("  TypeId: ").Append(TypeId).Append("\n");
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
            return this.Equals(input as GetCorporationsCorporationIdFacilities200Ok);
        }

        /// <summary>
        /// Returns true if GetCorporationsCorporationIdFacilities200Ok instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCorporationsCorporationIdFacilities200Ok to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCorporationsCorporationIdFacilities200Ok input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FacilityId == input.FacilityId ||
                    (this.FacilityId != null &&
                    this.FacilityId.Equals(input.FacilityId))
                ) && 
                (
                    this.SystemId == input.SystemId ||
                    (this.SystemId != null &&
                    this.SystemId.Equals(input.SystemId))
                ) && 
                (
                    this.TypeId == input.TypeId ||
                    (this.TypeId != null &&
                    this.TypeId.Equals(input.TypeId))
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
                if (this.FacilityId != null)
                    hashCode = hashCode * 59 + this.FacilityId.GetHashCode();
                if (this.SystemId != null)
                    hashCode = hashCode * 59 + this.SystemId.GetHashCode();
                if (this.TypeId != null)
                    hashCode = hashCode * 59 + this.TypeId.GetHashCode();
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
