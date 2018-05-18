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
    public partial class GetCharactersNames200Ok :  IEquatable<GetCharactersNames200Ok>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersNames200Ok" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetCharactersNames200Ok() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersNames200Ok" /> class.
        /// </summary>
        /// <param name="CharacterId">character_id integer (required).</param>
        /// <param name="CharacterName">character_name string (required).</param>
        public GetCharactersNames200Ok(long? CharacterId = default(long?), string CharacterName = default(string))
        {
            // to ensure "CharacterId" is required (not null)
            if (CharacterId == null)
            {
                throw new InvalidDataException("CharacterId is a required property for GetCharactersNames200Ok and cannot be null");
            }
            else
            {
                this.CharacterId = CharacterId;
            }
            // to ensure "CharacterName" is required (not null)
            if (CharacterName == null)
            {
                throw new InvalidDataException("CharacterName is a required property for GetCharactersNames200Ok and cannot be null");
            }
            else
            {
                this.CharacterName = CharacterName;
            }
        }
        
        /// <summary>
        /// character_id integer
        /// </summary>
        /// <value>character_id integer</value>
        [DataMember(Name="character_id", EmitDefaultValue=false)]
        public long? CharacterId { get; set; }

        /// <summary>
        /// character_name string
        /// </summary>
        /// <value>character_name string</value>
        [DataMember(Name="character_name", EmitDefaultValue=false)]
        public string CharacterName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCharactersNames200Ok {\n");
            sb.Append("  CharacterId: ").Append(CharacterId).Append("\n");
            sb.Append("  CharacterName: ").Append(CharacterName).Append("\n");
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
            return this.Equals(input as GetCharactersNames200Ok);
        }

        /// <summary>
        /// Returns true if GetCharactersNames200Ok instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCharactersNames200Ok to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCharactersNames200Ok input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CharacterId == input.CharacterId ||
                    (this.CharacterId != null &&
                    this.CharacterId.Equals(input.CharacterId))
                ) && 
                (
                    this.CharacterName == input.CharacterName ||
                    (this.CharacterName != null &&
                    this.CharacterName.Equals(input.CharacterName))
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
                if (this.CharacterId != null)
                    hashCode = hashCode * 59 + this.CharacterId.GetHashCode();
                if (this.CharacterName != null)
                    hashCode = hashCode * 59 + this.CharacterName.GetHashCode();
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