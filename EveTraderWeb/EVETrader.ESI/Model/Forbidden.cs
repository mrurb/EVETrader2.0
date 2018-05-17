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
    /// Forbidden model
    /// </summary>
    [DataContract]
    public partial class Forbidden :  IEquatable<Forbidden>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Forbidden" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Forbidden() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Forbidden" /> class.
        /// </summary>
        /// <param name="Error">Forbidden message (required).</param>
        /// <param name="SsoStatus">Status code received from SSO.</param>
        public Forbidden(string Error = default(string), int? SsoStatus = default(int?))
        {
            // to ensure "Error" is required (not null)
            if (Error == null)
            {
                throw new InvalidDataException("Error is a required property for Forbidden and cannot be null");
            }
            else
            {
                this.Error = Error;
            }
            this.SsoStatus = SsoStatus;
        }
        
        /// <summary>
        /// Forbidden message
        /// </summary>
        /// <value>Forbidden message</value>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public string Error { get; set; }

        /// <summary>
        /// Status code received from SSO
        /// </summary>
        /// <value>Status code received from SSO</value>
        [DataMember(Name="sso_status", EmitDefaultValue=false)]
        public int? SsoStatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Forbidden {\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  SsoStatus: ").Append(SsoStatus).Append("\n");
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
            return this.Equals(input as Forbidden);
        }

        /// <summary>
        /// Returns true if Forbidden instances are equal
        /// </summary>
        /// <param name="input">Instance of Forbidden to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Forbidden input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
                ) && 
                (
                    this.SsoStatus == input.SsoStatus ||
                    (this.SsoStatus != null &&
                    this.SsoStatus.Equals(input.SsoStatus))
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
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                if (this.SsoStatus != null)
                    hashCode = hashCode * 59 + this.SsoStatus.GetHashCode();
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
