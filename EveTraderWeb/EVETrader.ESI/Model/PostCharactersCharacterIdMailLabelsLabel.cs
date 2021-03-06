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
    /// label object
    /// </summary>
    [DataContract]
    public partial class PostCharactersCharacterIdMailLabelsLabel :  IEquatable<PostCharactersCharacterIdMailLabelsLabel>, IValidatableObject
    {
        /// <summary>
        /// Hexadecimal string representing label color, in RGB format
        /// </summary>
        /// <value>Hexadecimal string representing label color, in RGB format</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ColorEnum
        {
            
            /// <summary>
            /// Enum _0000fe for value: #0000fe
            /// </summary>
            [EnumMember(Value = "#0000fe")]
            _0000fe = 1,
            
            /// <summary>
            /// Enum _006634 for value: #006634
            /// </summary>
            [EnumMember(Value = "#006634")]
            _006634 = 2,
            
            /// <summary>
            /// Enum _0099ff for value: #0099ff
            /// </summary>
            [EnumMember(Value = "#0099ff")]
            _0099ff = 3,
            
            /// <summary>
            /// Enum _00ff33 for value: #00ff33
            /// </summary>
            [EnumMember(Value = "#00ff33")]
            _00ff33 = 4,
            
            /// <summary>
            /// Enum _01ffff for value: #01ffff
            /// </summary>
            [EnumMember(Value = "#01ffff")]
            _01ffff = 5,
            
            /// <summary>
            /// Enum _349800 for value: #349800
            /// </summary>
            [EnumMember(Value = "#349800")]
            _349800 = 6,
            
            /// <summary>
            /// Enum _660066 for value: #660066
            /// </summary>
            [EnumMember(Value = "#660066")]
            _660066 = 7,
            
            /// <summary>
            /// Enum _666666 for value: #666666
            /// </summary>
            [EnumMember(Value = "#666666")]
            _666666 = 8,
            
            /// <summary>
            /// Enum _999999 for value: #999999
            /// </summary>
            [EnumMember(Value = "#999999")]
            _999999 = 9,
            
            /// <summary>
            /// Enum _99ffff for value: #99ffff
            /// </summary>
            [EnumMember(Value = "#99ffff")]
            _99ffff = 10,
            
            /// <summary>
            /// Enum _9a0000 for value: #9a0000
            /// </summary>
            [EnumMember(Value = "#9a0000")]
            _9a0000 = 11,
            
            /// <summary>
            /// Enum Ccff9a for value: #ccff9a
            /// </summary>
            [EnumMember(Value = "#ccff9a")]
            Ccff9a = 12,
            
            /// <summary>
            /// Enum E6e6e6 for value: #e6e6e6
            /// </summary>
            [EnumMember(Value = "#e6e6e6")]
            E6e6e6 = 13,
            
            /// <summary>
            /// Enum Fe0000 for value: #fe0000
            /// </summary>
            [EnumMember(Value = "#fe0000")]
            Fe0000 = 14,
            
            /// <summary>
            /// Enum Ff6600 for value: #ff6600
            /// </summary>
            [EnumMember(Value = "#ff6600")]
            Ff6600 = 15,
            
            /// <summary>
            /// Enum Ffff01 for value: #ffff01
            /// </summary>
            [EnumMember(Value = "#ffff01")]
            Ffff01 = 16,
            
            /// <summary>
            /// Enum Ffffcd for value: #ffffcd
            /// </summary>
            [EnumMember(Value = "#ffffcd")]
            Ffffcd = 17,
            
            /// <summary>
            /// Enum Ffffff for value: #ffffff
            /// </summary>
            [EnumMember(Value = "#ffffff")]
            Ffffff = 18
        }

        /// <summary>
        /// Hexadecimal string representing label color, in RGB format
        /// </summary>
        /// <value>Hexadecimal string representing label color, in RGB format</value>
        [DataMember(Name="color", EmitDefaultValue=false)]
        public ColorEnum? Color { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostCharactersCharacterIdMailLabelsLabel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PostCharactersCharacterIdMailLabelsLabel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostCharactersCharacterIdMailLabelsLabel" /> class.
        /// </summary>
        /// <param name="Color">Hexadecimal string representing label color, in RGB format (default to ColorEnum.Ffffff).</param>
        /// <param name="Name">name string (required).</param>
        public PostCharactersCharacterIdMailLabelsLabel(ColorEnum? Color = ColorEnum.Ffffff, string Name = default(string))
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for PostCharactersCharacterIdMailLabelsLabel and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // use default value if no "Color" provided
            if (Color == null)
            {
                this.Color = ColorEnum.Ffffff;
            }
            else
            {
                this.Color = Color;
            }
        }
        

        /// <summary>
        /// name string
        /// </summary>
        /// <value>name string</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostCharactersCharacterIdMailLabelsLabel {\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as PostCharactersCharacterIdMailLabelsLabel);
        }

        /// <summary>
        /// Returns true if PostCharactersCharacterIdMailLabelsLabel instances are equal
        /// </summary>
        /// <param name="input">Instance of PostCharactersCharacterIdMailLabelsLabel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostCharactersCharacterIdMailLabelsLabel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Color == input.Color ||
                    (this.Color != null &&
                    this.Color.Equals(input.Color))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Color != null)
                    hashCode = hashCode * 59 + this.Color.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
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
            // Name (string) maxLength
            if(this.Name != null && this.Name.Length > 40)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 40.", new [] { "Name" });
            }

            // Name (string) minLength
            if(this.Name != null && this.Name.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            yield break;
        }
    }

}
