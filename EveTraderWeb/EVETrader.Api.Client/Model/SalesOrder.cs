/* 
 * EVETrader API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: V1
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
    /// SalesOrder
    /// </summary>
    [DataContract]
    public partial class SalesOrder :  IEquatable<SalesOrder>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesOrder" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="TraderID">TraderID.</param>
        /// <param name="BuyerID">BuyerID.</param>
        /// <param name="Destination">Destination.</param>
        /// <param name="Tip">Tip.</param>
        /// <param name="Published">Published.</param>
        public SalesOrder(int? Id = default(int?), int? TraderID = default(int?), int? BuyerID = default(int?), int? Destination = default(int?), double? Tip = default(double?), bool? Published = default(bool?))
        {
            this.Id = Id;
            this.TraderID = TraderID;
            this.BuyerID = BuyerID;
            this.Destination = Destination;
            this.Tip = Tip;
            this.Published = Published;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets TraderID
        /// </summary>
        [DataMember(Name="traderID", EmitDefaultValue=false)]
        public int? TraderID { get; set; }

        /// <summary>
        /// Gets or Sets BuyerID
        /// </summary>
        [DataMember(Name="buyerID", EmitDefaultValue=false)]
        public int? BuyerID { get; set; }

        /// <summary>
        /// Gets or Sets Destination
        /// </summary>
        [DataMember(Name="destination", EmitDefaultValue=false)]
        public int? Destination { get; set; }

        /// <summary>
        /// Gets or Sets Tip
        /// </summary>
        [DataMember(Name="tip", EmitDefaultValue=false)]
        public double? Tip { get; set; }

        /// <summary>
        /// Gets or Sets Published
        /// </summary>
        [DataMember(Name="published", EmitDefaultValue=false)]
        public bool? Published { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SalesOrder {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TraderID: ").Append(TraderID).Append("\n");
            sb.Append("  BuyerID: ").Append(BuyerID).Append("\n");
            sb.Append("  Destination: ").Append(Destination).Append("\n");
            sb.Append("  Tip: ").Append(Tip).Append("\n");
            sb.Append("  Published: ").Append(Published).Append("\n");
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
            return this.Equals(input as SalesOrder);
        }

        /// <summary>
        /// Returns true if SalesOrder instances are equal
        /// </summary>
        /// <param name="input">Instance of SalesOrder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SalesOrder input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.TraderID == input.TraderID ||
                    (this.TraderID != null &&
                    this.TraderID.Equals(input.TraderID))
                ) && 
                (
                    this.BuyerID == input.BuyerID ||
                    (this.BuyerID != null &&
                    this.BuyerID.Equals(input.BuyerID))
                ) && 
                (
                    this.Destination == input.Destination ||
                    (this.Destination != null &&
                    this.Destination.Equals(input.Destination))
                ) && 
                (
                    this.Tip == input.Tip ||
                    (this.Tip != null &&
                    this.Tip.Equals(input.Tip))
                ) && 
                (
                    this.Published == input.Published ||
                    (this.Published != null &&
                    this.Published.Equals(input.Published))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.TraderID != null)
                    hashCode = hashCode * 59 + this.TraderID.GetHashCode();
                if (this.BuyerID != null)
                    hashCode = hashCode * 59 + this.BuyerID.GetHashCode();
                if (this.Destination != null)
                    hashCode = hashCode * 59 + this.Destination.GetHashCode();
                if (this.Tip != null)
                    hashCode = hashCode * 59 + this.Tip.GetHashCode();
                if (this.Published != null)
                    hashCode = hashCode * 59 + this.Published.GetHashCode();
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
