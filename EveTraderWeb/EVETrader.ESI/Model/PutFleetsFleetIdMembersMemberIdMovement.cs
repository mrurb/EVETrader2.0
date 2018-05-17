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
    /// movement object
    /// </summary>
    [DataContract]
    public partial class PutFleetsFleetIdMembersMemberIdMovement :  IEquatable<PutFleetsFleetIdMembersMemberIdMovement>, IValidatableObject
    {
        /// <summary>
        /// If a character is moved to the &#x60;fleet_commander&#x60; role, neither &#x60;wing_id&#x60; or &#x60;squad_id&#x60; should be specified. If a character is moved to the &#x60;wing_commander&#x60; role, only &#x60;wing_id&#x60; should be specified. If a character is moved to the &#x60;squad_commander&#x60; role, both &#x60;wing_id&#x60; and &#x60;squad_id&#x60; should be specified. If a character is moved to the &#x60;squad_member&#x60; role, both &#x60;wing_id&#x60; and &#x60;squad_id&#x60; should be specified.
        /// </summary>
        /// <value>If a character is moved to the &#x60;fleet_commander&#x60; role, neither &#x60;wing_id&#x60; or &#x60;squad_id&#x60; should be specified. If a character is moved to the &#x60;wing_commander&#x60; role, only &#x60;wing_id&#x60; should be specified. If a character is moved to the &#x60;squad_commander&#x60; role, both &#x60;wing_id&#x60; and &#x60;squad_id&#x60; should be specified. If a character is moved to the &#x60;squad_member&#x60; role, both &#x60;wing_id&#x60; and &#x60;squad_id&#x60; should be specified.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RoleEnum
        {
            
            /// <summary>
            /// Enum Fleetcommander for value: fleet_commander
            /// </summary>
            [EnumMember(Value = "fleet_commander")]
            Fleetcommander = 1,
            
            /// <summary>
            /// Enum Wingcommander for value: wing_commander
            /// </summary>
            [EnumMember(Value = "wing_commander")]
            Wingcommander = 2,
            
            /// <summary>
            /// Enum Squadcommander for value: squad_commander
            /// </summary>
            [EnumMember(Value = "squad_commander")]
            Squadcommander = 3,
            
            /// <summary>
            /// Enum Squadmember for value: squad_member
            /// </summary>
            [EnumMember(Value = "squad_member")]
            Squadmember = 4
        }

        /// <summary>
        /// If a character is moved to the &#x60;fleet_commander&#x60; role, neither &#x60;wing_id&#x60; or &#x60;squad_id&#x60; should be specified. If a character is moved to the &#x60;wing_commander&#x60; role, only &#x60;wing_id&#x60; should be specified. If a character is moved to the &#x60;squad_commander&#x60; role, both &#x60;wing_id&#x60; and &#x60;squad_id&#x60; should be specified. If a character is moved to the &#x60;squad_member&#x60; role, both &#x60;wing_id&#x60; and &#x60;squad_id&#x60; should be specified.
        /// </summary>
        /// <value>If a character is moved to the &#x60;fleet_commander&#x60; role, neither &#x60;wing_id&#x60; or &#x60;squad_id&#x60; should be specified. If a character is moved to the &#x60;wing_commander&#x60; role, only &#x60;wing_id&#x60; should be specified. If a character is moved to the &#x60;squad_commander&#x60; role, both &#x60;wing_id&#x60; and &#x60;squad_id&#x60; should be specified. If a character is moved to the &#x60;squad_member&#x60; role, both &#x60;wing_id&#x60; and &#x60;squad_id&#x60; should be specified.</value>
        [DataMember(Name="role", EmitDefaultValue=false)]
        public RoleEnum Role { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PutFleetsFleetIdMembersMemberIdMovement" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PutFleetsFleetIdMembersMemberIdMovement() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PutFleetsFleetIdMembersMemberIdMovement" /> class.
        /// </summary>
        /// <param name="Role">If a character is moved to the &#x60;fleet_commander&#x60; role, neither &#x60;wing_id&#x60; or &#x60;squad_id&#x60; should be specified. If a character is moved to the &#x60;wing_commander&#x60; role, only &#x60;wing_id&#x60; should be specified. If a character is moved to the &#x60;squad_commander&#x60; role, both &#x60;wing_id&#x60; and &#x60;squad_id&#x60; should be specified. If a character is moved to the &#x60;squad_member&#x60; role, both &#x60;wing_id&#x60; and &#x60;squad_id&#x60; should be specified. (required).</param>
        /// <param name="SquadId">squad_id integer.</param>
        /// <param name="WingId">wing_id integer.</param>
        public PutFleetsFleetIdMembersMemberIdMovement(RoleEnum Role = default(RoleEnum), long? SquadId = default(long?), long? WingId = default(long?))
        {
            // to ensure "Role" is required (not null)
            if (Role == null)
            {
                throw new InvalidDataException("Role is a required property for PutFleetsFleetIdMembersMemberIdMovement and cannot be null");
            }
            else
            {
                this.Role = Role;
            }
            this.SquadId = SquadId;
            this.WingId = WingId;
        }
        

        /// <summary>
        /// squad_id integer
        /// </summary>
        /// <value>squad_id integer</value>
        [DataMember(Name="squad_id", EmitDefaultValue=false)]
        public long? SquadId { get; set; }

        /// <summary>
        /// wing_id integer
        /// </summary>
        /// <value>wing_id integer</value>
        [DataMember(Name="wing_id", EmitDefaultValue=false)]
        public long? WingId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PutFleetsFleetIdMembersMemberIdMovement {\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  SquadId: ").Append(SquadId).Append("\n");
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
            return this.Equals(input as PutFleetsFleetIdMembersMemberIdMovement);
        }

        /// <summary>
        /// Returns true if PutFleetsFleetIdMembersMemberIdMovement instances are equal
        /// </summary>
        /// <param name="input">Instance of PutFleetsFleetIdMembersMemberIdMovement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PutFleetsFleetIdMembersMemberIdMovement input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Role == input.Role ||
                    (this.Role != null &&
                    this.Role.Equals(input.Role))
                ) && 
                (
                    this.SquadId == input.SquadId ||
                    (this.SquadId != null &&
                    this.SquadId.Equals(input.SquadId))
                ) && 
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
                if (this.Role != null)
                    hashCode = hashCode * 59 + this.Role.GetHashCode();
                if (this.SquadId != null)
                    hashCode = hashCode * 59 + this.SquadId.GetHashCode();
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
            // SquadId (long?) minimum
            if(this.SquadId < (long?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SquadId, must be a value greater than or equal to 0.", new [] { "SquadId" });
            }

            // WingId (long?) minimum
            if(this.WingId < (long?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for WingId, must be a value greater than or equal to 0.", new [] { "WingId" });
            }

            yield break;
        }
    }

}
