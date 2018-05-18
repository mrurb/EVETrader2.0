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
    public partial class GetUniverseConstellationsConstellationIdOk :  IEquatable<GetUniverseConstellationsConstellationIdOk>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetUniverseConstellationsConstellationIdOk" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetUniverseConstellationsConstellationIdOk() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetUniverseConstellationsConstellationIdOk" /> class.
        /// </summary>
        /// <param name="ConstellationId">constellation_id integer (required).</param>
        /// <param name="Name">name string (required).</param>
        /// <param name="Position">Position (required).</param>
        /// <param name="RegionId">The region this constellation is in (required).</param>
        /// <param name="Systems">systems array (required).</param>
        public GetUniverseConstellationsConstellationIdOk(int? ConstellationId = default(int?), string Name = default(string), GetUniverseConstellationsConstellationIdPosition Position = default(GetUniverseConstellationsConstellationIdPosition), int? RegionId = default(int?), List<int?> Systems = default(List<int?>))
        {
            // to ensure "ConstellationId" is required (not null)
            if (ConstellationId == null)
            {
                throw new InvalidDataException("ConstellationId is a required property for GetUniverseConstellationsConstellationIdOk and cannot be null");
            }
            else
            {
                this.ConstellationId = ConstellationId;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for GetUniverseConstellationsConstellationIdOk and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Position" is required (not null)
            if (Position == null)
            {
                throw new InvalidDataException("Position is a required property for GetUniverseConstellationsConstellationIdOk and cannot be null");
            }
            else
            {
                this.Position = Position;
            }
            // to ensure "RegionId" is required (not null)
            if (RegionId == null)
            {
                throw new InvalidDataException("RegionId is a required property for GetUniverseConstellationsConstellationIdOk and cannot be null");
            }
            else
            {
                this.RegionId = RegionId;
            }
            // to ensure "Systems" is required (not null)
            if (Systems == null)
            {
                throw new InvalidDataException("Systems is a required property for GetUniverseConstellationsConstellationIdOk and cannot be null");
            }
            else
            {
                this.Systems = Systems;
            }
        }
        
        /// <summary>
        /// constellation_id integer
        /// </summary>
        /// <value>constellation_id integer</value>
        [DataMember(Name="constellation_id", EmitDefaultValue=false)]
        public int? ConstellationId { get; set; }

        /// <summary>
        /// name string
        /// </summary>
        /// <value>name string</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        [DataMember(Name="position", EmitDefaultValue=false)]
        public GetUniverseConstellationsConstellationIdPosition Position { get; set; }

        /// <summary>
        /// The region this constellation is in
        /// </summary>
        /// <value>The region this constellation is in</value>
        [DataMember(Name="region_id", EmitDefaultValue=false)]
        public int? RegionId { get; set; }

        /// <summary>
        /// systems array
        /// </summary>
        /// <value>systems array</value>
        [DataMember(Name="systems", EmitDefaultValue=false)]
        public List<int?> Systems { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetUniverseConstellationsConstellationIdOk {\n");
            sb.Append("  ConstellationId: ").Append(ConstellationId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  RegionId: ").Append(RegionId).Append("\n");
            sb.Append("  Systems: ").Append(Systems).Append("\n");
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
            return this.Equals(input as GetUniverseConstellationsConstellationIdOk);
        }

        /// <summary>
        /// Returns true if GetUniverseConstellationsConstellationIdOk instances are equal
        /// </summary>
        /// <param name="input">Instance of GetUniverseConstellationsConstellationIdOk to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetUniverseConstellationsConstellationIdOk input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ConstellationId == input.ConstellationId ||
                    (this.ConstellationId != null &&
                    this.ConstellationId.Equals(input.ConstellationId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Position == input.Position ||
                    (this.Position != null &&
                    this.Position.Equals(input.Position))
                ) && 
                (
                    this.RegionId == input.RegionId ||
                    (this.RegionId != null &&
                    this.RegionId.Equals(input.RegionId))
                ) && 
                (
                    this.Systems == input.Systems ||
                    this.Systems != null &&
                    this.Systems.SequenceEqual(input.Systems)
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
                if (this.ConstellationId != null)
                    hashCode = hashCode * 59 + this.ConstellationId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Position != null)
                    hashCode = hashCode * 59 + this.Position.GetHashCode();
                if (this.RegionId != null)
                    hashCode = hashCode * 59 + this.RegionId.GetHashCode();
                if (this.Systems != null)
                    hashCode = hashCode * 59 + this.Systems.GetHashCode();
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