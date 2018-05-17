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
    public partial class GetDogmaEffectsEffectIdOk :  IEquatable<GetDogmaEffectsEffectIdOk>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDogmaEffectsEffectIdOk" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetDogmaEffectsEffectIdOk() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDogmaEffectsEffectIdOk" /> class.
        /// </summary>
        /// <param name="Description">description string.</param>
        /// <param name="DisallowAutoRepeat">disallow_auto_repeat boolean.</param>
        /// <param name="DischargeAttributeId">discharge_attribute_id integer.</param>
        /// <param name="DisplayName">display_name string.</param>
        /// <param name="DurationAttributeId">duration_attribute_id integer.</param>
        /// <param name="EffectCategory">effect_category integer.</param>
        /// <param name="EffectId">effect_id integer (required).</param>
        /// <param name="ElectronicChance">electronic_chance boolean.</param>
        /// <param name="FalloffAttributeId">falloff_attribute_id integer.</param>
        /// <param name="IconId">icon_id integer.</param>
        /// <param name="IsAssistance">is_assistance boolean.</param>
        /// <param name="IsOffensive">is_offensive boolean.</param>
        /// <param name="IsWarpSafe">is_warp_safe boolean.</param>
        /// <param name="Modifiers">modifiers array.</param>
        /// <param name="Name">name string.</param>
        /// <param name="PostExpression">post_expression integer.</param>
        /// <param name="PreExpression">pre_expression integer.</param>
        /// <param name="Published">published boolean.</param>
        /// <param name="RangeAttributeId">range_attribute_id integer.</param>
        /// <param name="RangeChance">range_chance boolean.</param>
        /// <param name="TrackingSpeedAttributeId">tracking_speed_attribute_id integer.</param>
        public GetDogmaEffectsEffectIdOk(string Description = default(string), bool? DisallowAutoRepeat = default(bool?), int? DischargeAttributeId = default(int?), string DisplayName = default(string), int? DurationAttributeId = default(int?), int? EffectCategory = default(int?), int? EffectId = default(int?), bool? ElectronicChance = default(bool?), int? FalloffAttributeId = default(int?), int? IconId = default(int?), bool? IsAssistance = default(bool?), bool? IsOffensive = default(bool?), bool? IsWarpSafe = default(bool?), List<GetDogmaEffectsEffectIdModifier> Modifiers = default(List<GetDogmaEffectsEffectIdModifier>), string Name = default(string), int? PostExpression = default(int?), int? PreExpression = default(int?), bool? Published = default(bool?), int? RangeAttributeId = default(int?), bool? RangeChance = default(bool?), int? TrackingSpeedAttributeId = default(int?))
        {
            // to ensure "EffectId" is required (not null)
            if (EffectId == null)
            {
                throw new InvalidDataException("EffectId is a required property for GetDogmaEffectsEffectIdOk and cannot be null");
            }
            else
            {
                this.EffectId = EffectId;
            }
            this.Description = Description;
            this.DisallowAutoRepeat = DisallowAutoRepeat;
            this.DischargeAttributeId = DischargeAttributeId;
            this.DisplayName = DisplayName;
            this.DurationAttributeId = DurationAttributeId;
            this.EffectCategory = EffectCategory;
            this.ElectronicChance = ElectronicChance;
            this.FalloffAttributeId = FalloffAttributeId;
            this.IconId = IconId;
            this.IsAssistance = IsAssistance;
            this.IsOffensive = IsOffensive;
            this.IsWarpSafe = IsWarpSafe;
            this.Modifiers = Modifiers;
            this.Name = Name;
            this.PostExpression = PostExpression;
            this.PreExpression = PreExpression;
            this.Published = Published;
            this.RangeAttributeId = RangeAttributeId;
            this.RangeChance = RangeChance;
            this.TrackingSpeedAttributeId = TrackingSpeedAttributeId;
        }
        
        /// <summary>
        /// description string
        /// </summary>
        /// <value>description string</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// disallow_auto_repeat boolean
        /// </summary>
        /// <value>disallow_auto_repeat boolean</value>
        [DataMember(Name="disallow_auto_repeat", EmitDefaultValue=false)]
        public bool? DisallowAutoRepeat { get; set; }

        /// <summary>
        /// discharge_attribute_id integer
        /// </summary>
        /// <value>discharge_attribute_id integer</value>
        [DataMember(Name="discharge_attribute_id", EmitDefaultValue=false)]
        public int? DischargeAttributeId { get; set; }

        /// <summary>
        /// display_name string
        /// </summary>
        /// <value>display_name string</value>
        [DataMember(Name="display_name", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// duration_attribute_id integer
        /// </summary>
        /// <value>duration_attribute_id integer</value>
        [DataMember(Name="duration_attribute_id", EmitDefaultValue=false)]
        public int? DurationAttributeId { get; set; }

        /// <summary>
        /// effect_category integer
        /// </summary>
        /// <value>effect_category integer</value>
        [DataMember(Name="effect_category", EmitDefaultValue=false)]
        public int? EffectCategory { get; set; }

        /// <summary>
        /// effect_id integer
        /// </summary>
        /// <value>effect_id integer</value>
        [DataMember(Name="effect_id", EmitDefaultValue=false)]
        public int? EffectId { get; set; }

        /// <summary>
        /// electronic_chance boolean
        /// </summary>
        /// <value>electronic_chance boolean</value>
        [DataMember(Name="electronic_chance", EmitDefaultValue=false)]
        public bool? ElectronicChance { get; set; }

        /// <summary>
        /// falloff_attribute_id integer
        /// </summary>
        /// <value>falloff_attribute_id integer</value>
        [DataMember(Name="falloff_attribute_id", EmitDefaultValue=false)]
        public int? FalloffAttributeId { get; set; }

        /// <summary>
        /// icon_id integer
        /// </summary>
        /// <value>icon_id integer</value>
        [DataMember(Name="icon_id", EmitDefaultValue=false)]
        public int? IconId { get; set; }

        /// <summary>
        /// is_assistance boolean
        /// </summary>
        /// <value>is_assistance boolean</value>
        [DataMember(Name="is_assistance", EmitDefaultValue=false)]
        public bool? IsAssistance { get; set; }

        /// <summary>
        /// is_offensive boolean
        /// </summary>
        /// <value>is_offensive boolean</value>
        [DataMember(Name="is_offensive", EmitDefaultValue=false)]
        public bool? IsOffensive { get; set; }

        /// <summary>
        /// is_warp_safe boolean
        /// </summary>
        /// <value>is_warp_safe boolean</value>
        [DataMember(Name="is_warp_safe", EmitDefaultValue=false)]
        public bool? IsWarpSafe { get; set; }

        /// <summary>
        /// modifiers array
        /// </summary>
        /// <value>modifiers array</value>
        [DataMember(Name="modifiers", EmitDefaultValue=false)]
        public List<GetDogmaEffectsEffectIdModifier> Modifiers { get; set; }

        /// <summary>
        /// name string
        /// </summary>
        /// <value>name string</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// post_expression integer
        /// </summary>
        /// <value>post_expression integer</value>
        [DataMember(Name="post_expression", EmitDefaultValue=false)]
        public int? PostExpression { get; set; }

        /// <summary>
        /// pre_expression integer
        /// </summary>
        /// <value>pre_expression integer</value>
        [DataMember(Name="pre_expression", EmitDefaultValue=false)]
        public int? PreExpression { get; set; }

        /// <summary>
        /// published boolean
        /// </summary>
        /// <value>published boolean</value>
        [DataMember(Name="published", EmitDefaultValue=false)]
        public bool? Published { get; set; }

        /// <summary>
        /// range_attribute_id integer
        /// </summary>
        /// <value>range_attribute_id integer</value>
        [DataMember(Name="range_attribute_id", EmitDefaultValue=false)]
        public int? RangeAttributeId { get; set; }

        /// <summary>
        /// range_chance boolean
        /// </summary>
        /// <value>range_chance boolean</value>
        [DataMember(Name="range_chance", EmitDefaultValue=false)]
        public bool? RangeChance { get; set; }

        /// <summary>
        /// tracking_speed_attribute_id integer
        /// </summary>
        /// <value>tracking_speed_attribute_id integer</value>
        [DataMember(Name="tracking_speed_attribute_id", EmitDefaultValue=false)]
        public int? TrackingSpeedAttributeId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetDogmaEffectsEffectIdOk {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DisallowAutoRepeat: ").Append(DisallowAutoRepeat).Append("\n");
            sb.Append("  DischargeAttributeId: ").Append(DischargeAttributeId).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  DurationAttributeId: ").Append(DurationAttributeId).Append("\n");
            sb.Append("  EffectCategory: ").Append(EffectCategory).Append("\n");
            sb.Append("  EffectId: ").Append(EffectId).Append("\n");
            sb.Append("  ElectronicChance: ").Append(ElectronicChance).Append("\n");
            sb.Append("  FalloffAttributeId: ").Append(FalloffAttributeId).Append("\n");
            sb.Append("  IconId: ").Append(IconId).Append("\n");
            sb.Append("  IsAssistance: ").Append(IsAssistance).Append("\n");
            sb.Append("  IsOffensive: ").Append(IsOffensive).Append("\n");
            sb.Append("  IsWarpSafe: ").Append(IsWarpSafe).Append("\n");
            sb.Append("  Modifiers: ").Append(Modifiers).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PostExpression: ").Append(PostExpression).Append("\n");
            sb.Append("  PreExpression: ").Append(PreExpression).Append("\n");
            sb.Append("  Published: ").Append(Published).Append("\n");
            sb.Append("  RangeAttributeId: ").Append(RangeAttributeId).Append("\n");
            sb.Append("  RangeChance: ").Append(RangeChance).Append("\n");
            sb.Append("  TrackingSpeedAttributeId: ").Append(TrackingSpeedAttributeId).Append("\n");
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
            return this.Equals(input as GetDogmaEffectsEffectIdOk);
        }

        /// <summary>
        /// Returns true if GetDogmaEffectsEffectIdOk instances are equal
        /// </summary>
        /// <param name="input">Instance of GetDogmaEffectsEffectIdOk to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetDogmaEffectsEffectIdOk input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.DisallowAutoRepeat == input.DisallowAutoRepeat ||
                    (this.DisallowAutoRepeat != null &&
                    this.DisallowAutoRepeat.Equals(input.DisallowAutoRepeat))
                ) && 
                (
                    this.DischargeAttributeId == input.DischargeAttributeId ||
                    (this.DischargeAttributeId != null &&
                    this.DischargeAttributeId.Equals(input.DischargeAttributeId))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.DurationAttributeId == input.DurationAttributeId ||
                    (this.DurationAttributeId != null &&
                    this.DurationAttributeId.Equals(input.DurationAttributeId))
                ) && 
                (
                    this.EffectCategory == input.EffectCategory ||
                    (this.EffectCategory != null &&
                    this.EffectCategory.Equals(input.EffectCategory))
                ) && 
                (
                    this.EffectId == input.EffectId ||
                    (this.EffectId != null &&
                    this.EffectId.Equals(input.EffectId))
                ) && 
                (
                    this.ElectronicChance == input.ElectronicChance ||
                    (this.ElectronicChance != null &&
                    this.ElectronicChance.Equals(input.ElectronicChance))
                ) && 
                (
                    this.FalloffAttributeId == input.FalloffAttributeId ||
                    (this.FalloffAttributeId != null &&
                    this.FalloffAttributeId.Equals(input.FalloffAttributeId))
                ) && 
                (
                    this.IconId == input.IconId ||
                    (this.IconId != null &&
                    this.IconId.Equals(input.IconId))
                ) && 
                (
                    this.IsAssistance == input.IsAssistance ||
                    (this.IsAssistance != null &&
                    this.IsAssistance.Equals(input.IsAssistance))
                ) && 
                (
                    this.IsOffensive == input.IsOffensive ||
                    (this.IsOffensive != null &&
                    this.IsOffensive.Equals(input.IsOffensive))
                ) && 
                (
                    this.IsWarpSafe == input.IsWarpSafe ||
                    (this.IsWarpSafe != null &&
                    this.IsWarpSafe.Equals(input.IsWarpSafe))
                ) && 
                (
                    this.Modifiers == input.Modifiers ||
                    this.Modifiers != null &&
                    this.Modifiers.SequenceEqual(input.Modifiers)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.PostExpression == input.PostExpression ||
                    (this.PostExpression != null &&
                    this.PostExpression.Equals(input.PostExpression))
                ) && 
                (
                    this.PreExpression == input.PreExpression ||
                    (this.PreExpression != null &&
                    this.PreExpression.Equals(input.PreExpression))
                ) && 
                (
                    this.Published == input.Published ||
                    (this.Published != null &&
                    this.Published.Equals(input.Published))
                ) && 
                (
                    this.RangeAttributeId == input.RangeAttributeId ||
                    (this.RangeAttributeId != null &&
                    this.RangeAttributeId.Equals(input.RangeAttributeId))
                ) && 
                (
                    this.RangeChance == input.RangeChance ||
                    (this.RangeChance != null &&
                    this.RangeChance.Equals(input.RangeChance))
                ) && 
                (
                    this.TrackingSpeedAttributeId == input.TrackingSpeedAttributeId ||
                    (this.TrackingSpeedAttributeId != null &&
                    this.TrackingSpeedAttributeId.Equals(input.TrackingSpeedAttributeId))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DisallowAutoRepeat != null)
                    hashCode = hashCode * 59 + this.DisallowAutoRepeat.GetHashCode();
                if (this.DischargeAttributeId != null)
                    hashCode = hashCode * 59 + this.DischargeAttributeId.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.DurationAttributeId != null)
                    hashCode = hashCode * 59 + this.DurationAttributeId.GetHashCode();
                if (this.EffectCategory != null)
                    hashCode = hashCode * 59 + this.EffectCategory.GetHashCode();
                if (this.EffectId != null)
                    hashCode = hashCode * 59 + this.EffectId.GetHashCode();
                if (this.ElectronicChance != null)
                    hashCode = hashCode * 59 + this.ElectronicChance.GetHashCode();
                if (this.FalloffAttributeId != null)
                    hashCode = hashCode * 59 + this.FalloffAttributeId.GetHashCode();
                if (this.IconId != null)
                    hashCode = hashCode * 59 + this.IconId.GetHashCode();
                if (this.IsAssistance != null)
                    hashCode = hashCode * 59 + this.IsAssistance.GetHashCode();
                if (this.IsOffensive != null)
                    hashCode = hashCode * 59 + this.IsOffensive.GetHashCode();
                if (this.IsWarpSafe != null)
                    hashCode = hashCode * 59 + this.IsWarpSafe.GetHashCode();
                if (this.Modifiers != null)
                    hashCode = hashCode * 59 + this.Modifiers.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.PostExpression != null)
                    hashCode = hashCode * 59 + this.PostExpression.GetHashCode();
                if (this.PreExpression != null)
                    hashCode = hashCode * 59 + this.PreExpression.GetHashCode();
                if (this.Published != null)
                    hashCode = hashCode * 59 + this.Published.GetHashCode();
                if (this.RangeAttributeId != null)
                    hashCode = hashCode * 59 + this.RangeAttributeId.GetHashCode();
                if (this.RangeChance != null)
                    hashCode = hashCode * 59 + this.RangeChance.GetHashCode();
                if (this.TrackingSpeedAttributeId != null)
                    hashCode = hashCode * 59 + this.TrackingSpeedAttributeId.GetHashCode();
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
