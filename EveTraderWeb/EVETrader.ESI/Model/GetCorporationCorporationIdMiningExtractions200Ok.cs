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
    public partial class GetCorporationCorporationIdMiningExtractions200Ok :  IEquatable<GetCorporationCorporationIdMiningExtractions200Ok>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCorporationCorporationIdMiningExtractions200Ok" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetCorporationCorporationIdMiningExtractions200Ok() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCorporationCorporationIdMiningExtractions200Ok" /> class.
        /// </summary>
        /// <param name="ChunkArrivalTime">The time at which the chunk being extracted will arrive and can be fractured by the moon mining drill.  (required).</param>
        /// <param name="ExtractionStartTime">The time at which the current extraction was initiated.  (required).</param>
        /// <param name="MoonId">moon_id integer (required).</param>
        /// <param name="NaturalDecayTime">The time at which the chunk being extracted will naturally fracture if it is not first fractured by the moon mining drill.  (required).</param>
        /// <param name="StructureId">structure_id integer (required).</param>
        public GetCorporationCorporationIdMiningExtractions200Ok(DateTime? ChunkArrivalTime = default(DateTime?), DateTime? ExtractionStartTime = default(DateTime?), int? MoonId = default(int?), DateTime? NaturalDecayTime = default(DateTime?), long? StructureId = default(long?))
        {
            // to ensure "ChunkArrivalTime" is required (not null)
            if (ChunkArrivalTime == null)
            {
                throw new InvalidDataException("ChunkArrivalTime is a required property for GetCorporationCorporationIdMiningExtractions200Ok and cannot be null");
            }
            else
            {
                this.ChunkArrivalTime = ChunkArrivalTime;
            }
            // to ensure "ExtractionStartTime" is required (not null)
            if (ExtractionStartTime == null)
            {
                throw new InvalidDataException("ExtractionStartTime is a required property for GetCorporationCorporationIdMiningExtractions200Ok and cannot be null");
            }
            else
            {
                this.ExtractionStartTime = ExtractionStartTime;
            }
            // to ensure "MoonId" is required (not null)
            if (MoonId == null)
            {
                throw new InvalidDataException("MoonId is a required property for GetCorporationCorporationIdMiningExtractions200Ok and cannot be null");
            }
            else
            {
                this.MoonId = MoonId;
            }
            // to ensure "NaturalDecayTime" is required (not null)
            if (NaturalDecayTime == null)
            {
                throw new InvalidDataException("NaturalDecayTime is a required property for GetCorporationCorporationIdMiningExtractions200Ok and cannot be null");
            }
            else
            {
                this.NaturalDecayTime = NaturalDecayTime;
            }
            // to ensure "StructureId" is required (not null)
            if (StructureId == null)
            {
                throw new InvalidDataException("StructureId is a required property for GetCorporationCorporationIdMiningExtractions200Ok and cannot be null");
            }
            else
            {
                this.StructureId = StructureId;
            }
        }
        
        /// <summary>
        /// The time at which the chunk being extracted will arrive and can be fractured by the moon mining drill. 
        /// </summary>
        /// <value>The time at which the chunk being extracted will arrive and can be fractured by the moon mining drill. </value>
        [DataMember(Name="chunk_arrival_time", EmitDefaultValue=false)]
        public DateTime? ChunkArrivalTime { get; set; }

        /// <summary>
        /// The time at which the current extraction was initiated. 
        /// </summary>
        /// <value>The time at which the current extraction was initiated. </value>
        [DataMember(Name="extraction_start_time", EmitDefaultValue=false)]
        public DateTime? ExtractionStartTime { get; set; }

        /// <summary>
        /// moon_id integer
        /// </summary>
        /// <value>moon_id integer</value>
        [DataMember(Name="moon_id", EmitDefaultValue=false)]
        public int? MoonId { get; set; }

        /// <summary>
        /// The time at which the chunk being extracted will naturally fracture if it is not first fractured by the moon mining drill. 
        /// </summary>
        /// <value>The time at which the chunk being extracted will naturally fracture if it is not first fractured by the moon mining drill. </value>
        [DataMember(Name="natural_decay_time", EmitDefaultValue=false)]
        public DateTime? NaturalDecayTime { get; set; }

        /// <summary>
        /// structure_id integer
        /// </summary>
        /// <value>structure_id integer</value>
        [DataMember(Name="structure_id", EmitDefaultValue=false)]
        public long? StructureId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCorporationCorporationIdMiningExtractions200Ok {\n");
            sb.Append("  ChunkArrivalTime: ").Append(ChunkArrivalTime).Append("\n");
            sb.Append("  ExtractionStartTime: ").Append(ExtractionStartTime).Append("\n");
            sb.Append("  MoonId: ").Append(MoonId).Append("\n");
            sb.Append("  NaturalDecayTime: ").Append(NaturalDecayTime).Append("\n");
            sb.Append("  StructureId: ").Append(StructureId).Append("\n");
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
            return this.Equals(input as GetCorporationCorporationIdMiningExtractions200Ok);
        }

        /// <summary>
        /// Returns true if GetCorporationCorporationIdMiningExtractions200Ok instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCorporationCorporationIdMiningExtractions200Ok to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCorporationCorporationIdMiningExtractions200Ok input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ChunkArrivalTime == input.ChunkArrivalTime ||
                    (this.ChunkArrivalTime != null &&
                    this.ChunkArrivalTime.Equals(input.ChunkArrivalTime))
                ) && 
                (
                    this.ExtractionStartTime == input.ExtractionStartTime ||
                    (this.ExtractionStartTime != null &&
                    this.ExtractionStartTime.Equals(input.ExtractionStartTime))
                ) && 
                (
                    this.MoonId == input.MoonId ||
                    (this.MoonId != null &&
                    this.MoonId.Equals(input.MoonId))
                ) && 
                (
                    this.NaturalDecayTime == input.NaturalDecayTime ||
                    (this.NaturalDecayTime != null &&
                    this.NaturalDecayTime.Equals(input.NaturalDecayTime))
                ) && 
                (
                    this.StructureId == input.StructureId ||
                    (this.StructureId != null &&
                    this.StructureId.Equals(input.StructureId))
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
                if (this.ChunkArrivalTime != null)
                    hashCode = hashCode * 59 + this.ChunkArrivalTime.GetHashCode();
                if (this.ExtractionStartTime != null)
                    hashCode = hashCode * 59 + this.ExtractionStartTime.GetHashCode();
                if (this.MoonId != null)
                    hashCode = hashCode * 59 + this.MoonId.GetHashCode();
                if (this.NaturalDecayTime != null)
                    hashCode = hashCode * 59 + this.NaturalDecayTime.GetHashCode();
                if (this.StructureId != null)
                    hashCode = hashCode * 59 + this.StructureId.GetHashCode();
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