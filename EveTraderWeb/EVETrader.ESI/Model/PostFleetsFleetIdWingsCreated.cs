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
    /// 201 created object
    /// </summary>
    [DataContract]
    public partial class PostFleetsFleetIdWingsCreated :  IEquatable<PostFleetsFleetIdWingsCreated>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostFleetsFleetIdWingsCreated" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PostFleetsFleetIdWingsCreated() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostFleetsFleetIdWingsCreated" /> class.
        /// </summary>
        /// <param name="WingId">The wing_id of the newly created wing (required).</param>
        public PostFleetsFleetIdWingsCreated(long? WingId = default(long?))
        {
            // to ensure "WingId" is required (not null)
            if (WingId == null)
            {
                throw new InvalidDataException("WingId is a required property for PostFleetsFleetIdWingsCreated and cannot be null");
            }
            else
            {
                this.WingId = WingId;
            }
        }
        
        /// <summary>
        /// The wing_id of the newly created wing
        /// </summary>
        /// <value>The wing_id of the newly created wing</value>
        [DataMember(Name="wing_id", EmitDefaultValue=false)]
        public long? WingId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostFleetsFleetIdWingsCreated {\n");
            sb.Append("  WingId: ").Append(WingId).Append("\n");
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
            return this.Equals(input as PostFleetsFleetIdWingsCreated);
        }

        /// <summary>
        /// Returns true if PostFleetsFleetIdWingsCreated instances are equal
        /// </summary>
        /// <param name="input">Instance of PostFleetsFleetIdWingsCreated to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostFleetsFleetIdWingsCreated input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.WingId == input.WingId ||
                    (this.WingId != null &&
                    this.WingId.Equals(input.WingId))
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
                if (this.WingId != null)
                    hashCode = hashCode * 59 + this.WingId.GetHashCode();
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
