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
    public partial class GetCharactersCharacterIdBlueprints200Ok :  IEquatable<GetCharactersCharacterIdBlueprints200Ok>, IValidatableObject
    {
        /// <summary>
        /// Type of the location_id
        /// </summary>
        /// <value>Type of the location_id</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LocationFlagEnum
        {
            
            /// <summary>
            /// Enum AutoFit for value: AutoFit
            /// </summary>
            [EnumMember(Value = "AutoFit")]
            AutoFit = 1,
            
            /// <summary>
            /// Enum Cargo for value: Cargo
            /// </summary>
            [EnumMember(Value = "Cargo")]
            Cargo = 2,
            
            /// <summary>
            /// Enum CorpseBay for value: CorpseBay
            /// </summary>
            [EnumMember(Value = "CorpseBay")]
            CorpseBay = 3,
            
            /// <summary>
            /// Enum DroneBay for value: DroneBay
            /// </summary>
            [EnumMember(Value = "DroneBay")]
            DroneBay = 4,
            
            /// <summary>
            /// Enum FleetHangar for value: FleetHangar
            /// </summary>
            [EnumMember(Value = "FleetHangar")]
            FleetHangar = 5,
            
            /// <summary>
            /// Enum Deliveries for value: Deliveries
            /// </summary>
            [EnumMember(Value = "Deliveries")]
            Deliveries = 6,
            
            /// <summary>
            /// Enum HiddenModifiers for value: HiddenModifiers
            /// </summary>
            [EnumMember(Value = "HiddenModifiers")]
            HiddenModifiers = 7,
            
            /// <summary>
            /// Enum Hangar for value: Hangar
            /// </summary>
            [EnumMember(Value = "Hangar")]
            Hangar = 8,
            
            /// <summary>
            /// Enum HangarAll for value: HangarAll
            /// </summary>
            [EnumMember(Value = "HangarAll")]
            HangarAll = 9,
            
            /// <summary>
            /// Enum LoSlot0 for value: LoSlot0
            /// </summary>
            [EnumMember(Value = "LoSlot0")]
            LoSlot0 = 10,
            
            /// <summary>
            /// Enum LoSlot1 for value: LoSlot1
            /// </summary>
            [EnumMember(Value = "LoSlot1")]
            LoSlot1 = 11,
            
            /// <summary>
            /// Enum LoSlot2 for value: LoSlot2
            /// </summary>
            [EnumMember(Value = "LoSlot2")]
            LoSlot2 = 12,
            
            /// <summary>
            /// Enum LoSlot3 for value: LoSlot3
            /// </summary>
            [EnumMember(Value = "LoSlot3")]
            LoSlot3 = 13,
            
            /// <summary>
            /// Enum LoSlot4 for value: LoSlot4
            /// </summary>
            [EnumMember(Value = "LoSlot4")]
            LoSlot4 = 14,
            
            /// <summary>
            /// Enum LoSlot5 for value: LoSlot5
            /// </summary>
            [EnumMember(Value = "LoSlot5")]
            LoSlot5 = 15,
            
            /// <summary>
            /// Enum LoSlot6 for value: LoSlot6
            /// </summary>
            [EnumMember(Value = "LoSlot6")]
            LoSlot6 = 16,
            
            /// <summary>
            /// Enum LoSlot7 for value: LoSlot7
            /// </summary>
            [EnumMember(Value = "LoSlot7")]
            LoSlot7 = 17,
            
            /// <summary>
            /// Enum MedSlot0 for value: MedSlot0
            /// </summary>
            [EnumMember(Value = "MedSlot0")]
            MedSlot0 = 18,
            
            /// <summary>
            /// Enum MedSlot1 for value: MedSlot1
            /// </summary>
            [EnumMember(Value = "MedSlot1")]
            MedSlot1 = 19,
            
            /// <summary>
            /// Enum MedSlot2 for value: MedSlot2
            /// </summary>
            [EnumMember(Value = "MedSlot2")]
            MedSlot2 = 20,
            
            /// <summary>
            /// Enum MedSlot3 for value: MedSlot3
            /// </summary>
            [EnumMember(Value = "MedSlot3")]
            MedSlot3 = 21,
            
            /// <summary>
            /// Enum MedSlot4 for value: MedSlot4
            /// </summary>
            [EnumMember(Value = "MedSlot4")]
            MedSlot4 = 22,
            
            /// <summary>
            /// Enum MedSlot5 for value: MedSlot5
            /// </summary>
            [EnumMember(Value = "MedSlot5")]
            MedSlot5 = 23,
            
            /// <summary>
            /// Enum MedSlot6 for value: MedSlot6
            /// </summary>
            [EnumMember(Value = "MedSlot6")]
            MedSlot6 = 24,
            
            /// <summary>
            /// Enum MedSlot7 for value: MedSlot7
            /// </summary>
            [EnumMember(Value = "MedSlot7")]
            MedSlot7 = 25,
            
            /// <summary>
            /// Enum HiSlot0 for value: HiSlot0
            /// </summary>
            [EnumMember(Value = "HiSlot0")]
            HiSlot0 = 26,
            
            /// <summary>
            /// Enum HiSlot1 for value: HiSlot1
            /// </summary>
            [EnumMember(Value = "HiSlot1")]
            HiSlot1 = 27,
            
            /// <summary>
            /// Enum HiSlot2 for value: HiSlot2
            /// </summary>
            [EnumMember(Value = "HiSlot2")]
            HiSlot2 = 28,
            
            /// <summary>
            /// Enum HiSlot3 for value: HiSlot3
            /// </summary>
            [EnumMember(Value = "HiSlot3")]
            HiSlot3 = 29,
            
            /// <summary>
            /// Enum HiSlot4 for value: HiSlot4
            /// </summary>
            [EnumMember(Value = "HiSlot4")]
            HiSlot4 = 30,
            
            /// <summary>
            /// Enum HiSlot5 for value: HiSlot5
            /// </summary>
            [EnumMember(Value = "HiSlot5")]
            HiSlot5 = 31,
            
            /// <summary>
            /// Enum HiSlot6 for value: HiSlot6
            /// </summary>
            [EnumMember(Value = "HiSlot6")]
            HiSlot6 = 32,
            
            /// <summary>
            /// Enum HiSlot7 for value: HiSlot7
            /// </summary>
            [EnumMember(Value = "HiSlot7")]
            HiSlot7 = 33,
            
            /// <summary>
            /// Enum AssetSafety for value: AssetSafety
            /// </summary>
            [EnumMember(Value = "AssetSafety")]
            AssetSafety = 34,
            
            /// <summary>
            /// Enum Locked for value: Locked
            /// </summary>
            [EnumMember(Value = "Locked")]
            Locked = 35,
            
            /// <summary>
            /// Enum Unlocked for value: Unlocked
            /// </summary>
            [EnumMember(Value = "Unlocked")]
            Unlocked = 36,
            
            /// <summary>
            /// Enum Implant for value: Implant
            /// </summary>
            [EnumMember(Value = "Implant")]
            Implant = 37,
            
            /// <summary>
            /// Enum QuafeBay for value: QuafeBay
            /// </summary>
            [EnumMember(Value = "QuafeBay")]
            QuafeBay = 38,
            
            /// <summary>
            /// Enum RigSlot0 for value: RigSlot0
            /// </summary>
            [EnumMember(Value = "RigSlot0")]
            RigSlot0 = 39,
            
            /// <summary>
            /// Enum RigSlot1 for value: RigSlot1
            /// </summary>
            [EnumMember(Value = "RigSlot1")]
            RigSlot1 = 40,
            
            /// <summary>
            /// Enum RigSlot2 for value: RigSlot2
            /// </summary>
            [EnumMember(Value = "RigSlot2")]
            RigSlot2 = 41,
            
            /// <summary>
            /// Enum RigSlot3 for value: RigSlot3
            /// </summary>
            [EnumMember(Value = "RigSlot3")]
            RigSlot3 = 42,
            
            /// <summary>
            /// Enum RigSlot4 for value: RigSlot4
            /// </summary>
            [EnumMember(Value = "RigSlot4")]
            RigSlot4 = 43,
            
            /// <summary>
            /// Enum RigSlot5 for value: RigSlot5
            /// </summary>
            [EnumMember(Value = "RigSlot5")]
            RigSlot5 = 44,
            
            /// <summary>
            /// Enum RigSlot6 for value: RigSlot6
            /// </summary>
            [EnumMember(Value = "RigSlot6")]
            RigSlot6 = 45,
            
            /// <summary>
            /// Enum RigSlot7 for value: RigSlot7
            /// </summary>
            [EnumMember(Value = "RigSlot7")]
            RigSlot7 = 46,
            
            /// <summary>
            /// Enum ShipHangar for value: ShipHangar
            /// </summary>
            [EnumMember(Value = "ShipHangar")]
            ShipHangar = 47,
            
            /// <summary>
            /// Enum SpecializedFuelBay for value: SpecializedFuelBay
            /// </summary>
            [EnumMember(Value = "SpecializedFuelBay")]
            SpecializedFuelBay = 48,
            
            /// <summary>
            /// Enum SpecializedOreHold for value: SpecializedOreHold
            /// </summary>
            [EnumMember(Value = "SpecializedOreHold")]
            SpecializedOreHold = 49,
            
            /// <summary>
            /// Enum SpecializedGasHold for value: SpecializedGasHold
            /// </summary>
            [EnumMember(Value = "SpecializedGasHold")]
            SpecializedGasHold = 50,
            
            /// <summary>
            /// Enum SpecializedMineralHold for value: SpecializedMineralHold
            /// </summary>
            [EnumMember(Value = "SpecializedMineralHold")]
            SpecializedMineralHold = 51,
            
            /// <summary>
            /// Enum SpecializedSalvageHold for value: SpecializedSalvageHold
            /// </summary>
            [EnumMember(Value = "SpecializedSalvageHold")]
            SpecializedSalvageHold = 52,
            
            /// <summary>
            /// Enum SpecializedShipHold for value: SpecializedShipHold
            /// </summary>
            [EnumMember(Value = "SpecializedShipHold")]
            SpecializedShipHold = 53,
            
            /// <summary>
            /// Enum SpecializedSmallShipHold for value: SpecializedSmallShipHold
            /// </summary>
            [EnumMember(Value = "SpecializedSmallShipHold")]
            SpecializedSmallShipHold = 54,
            
            /// <summary>
            /// Enum SpecializedMediumShipHold for value: SpecializedMediumShipHold
            /// </summary>
            [EnumMember(Value = "SpecializedMediumShipHold")]
            SpecializedMediumShipHold = 55,
            
            /// <summary>
            /// Enum SpecializedLargeShipHold for value: SpecializedLargeShipHold
            /// </summary>
            [EnumMember(Value = "SpecializedLargeShipHold")]
            SpecializedLargeShipHold = 56,
            
            /// <summary>
            /// Enum SpecializedIndustrialShipHold for value: SpecializedIndustrialShipHold
            /// </summary>
            [EnumMember(Value = "SpecializedIndustrialShipHold")]
            SpecializedIndustrialShipHold = 57,
            
            /// <summary>
            /// Enum SpecializedAmmoHold for value: SpecializedAmmoHold
            /// </summary>
            [EnumMember(Value = "SpecializedAmmoHold")]
            SpecializedAmmoHold = 58,
            
            /// <summary>
            /// Enum SpecializedCommandCenterHold for value: SpecializedCommandCenterHold
            /// </summary>
            [EnumMember(Value = "SpecializedCommandCenterHold")]
            SpecializedCommandCenterHold = 59,
            
            /// <summary>
            /// Enum SpecializedPlanetaryCommoditiesHold for value: SpecializedPlanetaryCommoditiesHold
            /// </summary>
            [EnumMember(Value = "SpecializedPlanetaryCommoditiesHold")]
            SpecializedPlanetaryCommoditiesHold = 60,
            
            /// <summary>
            /// Enum SpecializedMaterialBay for value: SpecializedMaterialBay
            /// </summary>
            [EnumMember(Value = "SpecializedMaterialBay")]
            SpecializedMaterialBay = 61,
            
            /// <summary>
            /// Enum SubSystemSlot0 for value: SubSystemSlot0
            /// </summary>
            [EnumMember(Value = "SubSystemSlot0")]
            SubSystemSlot0 = 62,
            
            /// <summary>
            /// Enum SubSystemSlot1 for value: SubSystemSlot1
            /// </summary>
            [EnumMember(Value = "SubSystemSlot1")]
            SubSystemSlot1 = 63,
            
            /// <summary>
            /// Enum SubSystemSlot2 for value: SubSystemSlot2
            /// </summary>
            [EnumMember(Value = "SubSystemSlot2")]
            SubSystemSlot2 = 64,
            
            /// <summary>
            /// Enum SubSystemSlot3 for value: SubSystemSlot3
            /// </summary>
            [EnumMember(Value = "SubSystemSlot3")]
            SubSystemSlot3 = 65,
            
            /// <summary>
            /// Enum SubSystemSlot4 for value: SubSystemSlot4
            /// </summary>
            [EnumMember(Value = "SubSystemSlot4")]
            SubSystemSlot4 = 66,
            
            /// <summary>
            /// Enum SubSystemSlot5 for value: SubSystemSlot5
            /// </summary>
            [EnumMember(Value = "SubSystemSlot5")]
            SubSystemSlot5 = 67,
            
            /// <summary>
            /// Enum SubSystemSlot6 for value: SubSystemSlot6
            /// </summary>
            [EnumMember(Value = "SubSystemSlot6")]
            SubSystemSlot6 = 68,
            
            /// <summary>
            /// Enum SubSystemSlot7 for value: SubSystemSlot7
            /// </summary>
            [EnumMember(Value = "SubSystemSlot7")]
            SubSystemSlot7 = 69,
            
            /// <summary>
            /// Enum FighterBay for value: FighterBay
            /// </summary>
            [EnumMember(Value = "FighterBay")]
            FighterBay = 70,
            
            /// <summary>
            /// Enum FighterTube0 for value: FighterTube0
            /// </summary>
            [EnumMember(Value = "FighterTube0")]
            FighterTube0 = 71,
            
            /// <summary>
            /// Enum FighterTube1 for value: FighterTube1
            /// </summary>
            [EnumMember(Value = "FighterTube1")]
            FighterTube1 = 72,
            
            /// <summary>
            /// Enum FighterTube2 for value: FighterTube2
            /// </summary>
            [EnumMember(Value = "FighterTube2")]
            FighterTube2 = 73,
            
            /// <summary>
            /// Enum FighterTube3 for value: FighterTube3
            /// </summary>
            [EnumMember(Value = "FighterTube3")]
            FighterTube3 = 74,
            
            /// <summary>
            /// Enum FighterTube4 for value: FighterTube4
            /// </summary>
            [EnumMember(Value = "FighterTube4")]
            FighterTube4 = 75,
            
            /// <summary>
            /// Enum Module for value: Module
            /// </summary>
            [EnumMember(Value = "Module")]
            Module = 76
        }

        /// <summary>
        /// Type of the location_id
        /// </summary>
        /// <value>Type of the location_id</value>
        [DataMember(Name="location_flag", EmitDefaultValue=false)]
        public LocationFlagEnum LocationFlag { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersCharacterIdBlueprints200Ok" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetCharactersCharacterIdBlueprints200Ok() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersCharacterIdBlueprints200Ok" /> class.
        /// </summary>
        /// <param name="ItemId">Unique ID for this item. (required).</param>
        /// <param name="LocationFlag">Type of the location_id (required).</param>
        /// <param name="LocationId">References a solar system, station or item_id if this blueprint is located within a container. If the return value is an item_id, then the Character AssetList API must be queried to find the container using the given item_id to determine the correct location of the Blueprint. (required).</param>
        /// <param name="MaterialEfficiency">Material Efficiency Level of the blueprint. (required).</param>
        /// <param name="Quantity">A range of numbers with a minimum of -2 and no maximum value where -1 is an original and -2 is a copy. It can be a positive integer if it is a stack of blueprint originals fresh from the market (e.g. no activities performed on them yet). (required).</param>
        /// <param name="Runs">Number of runs remaining if the blueprint is a copy, -1 if it is an original. (required).</param>
        /// <param name="TimeEfficiency">Time Efficiency Level of the blueprint. (required).</param>
        /// <param name="TypeId">type_id integer (required).</param>
        public GetCharactersCharacterIdBlueprints200Ok(long? ItemId = default(long?), LocationFlagEnum LocationFlag = default(LocationFlagEnum), long? LocationId = default(long?), int? MaterialEfficiency = default(int?), int? Quantity = default(int?), int? Runs = default(int?), int? TimeEfficiency = default(int?), int? TypeId = default(int?))
        {
            // to ensure "ItemId" is required (not null)
            if (ItemId == null)
            {
                throw new InvalidDataException("ItemId is a required property for GetCharactersCharacterIdBlueprints200Ok and cannot be null");
            }
            else
            {
                this.ItemId = ItemId;
            }
            // to ensure "LocationFlag" is required (not null)
            if (LocationFlag == null)
            {
                throw new InvalidDataException("LocationFlag is a required property for GetCharactersCharacterIdBlueprints200Ok and cannot be null");
            }
            else
            {
                this.LocationFlag = LocationFlag;
            }
            // to ensure "LocationId" is required (not null)
            if (LocationId == null)
            {
                throw new InvalidDataException("LocationId is a required property for GetCharactersCharacterIdBlueprints200Ok and cannot be null");
            }
            else
            {
                this.LocationId = LocationId;
            }
            // to ensure "MaterialEfficiency" is required (not null)
            if (MaterialEfficiency == null)
            {
                throw new InvalidDataException("MaterialEfficiency is a required property for GetCharactersCharacterIdBlueprints200Ok and cannot be null");
            }
            else
            {
                this.MaterialEfficiency = MaterialEfficiency;
            }
            // to ensure "Quantity" is required (not null)
            if (Quantity == null)
            {
                throw new InvalidDataException("Quantity is a required property for GetCharactersCharacterIdBlueprints200Ok and cannot be null");
            }
            else
            {
                this.Quantity = Quantity;
            }
            // to ensure "Runs" is required (not null)
            if (Runs == null)
            {
                throw new InvalidDataException("Runs is a required property for GetCharactersCharacterIdBlueprints200Ok and cannot be null");
            }
            else
            {
                this.Runs = Runs;
            }
            // to ensure "TimeEfficiency" is required (not null)
            if (TimeEfficiency == null)
            {
                throw new InvalidDataException("TimeEfficiency is a required property for GetCharactersCharacterIdBlueprints200Ok and cannot be null");
            }
            else
            {
                this.TimeEfficiency = TimeEfficiency;
            }
            // to ensure "TypeId" is required (not null)
            if (TypeId == null)
            {
                throw new InvalidDataException("TypeId is a required property for GetCharactersCharacterIdBlueprints200Ok and cannot be null");
            }
            else
            {
                this.TypeId = TypeId;
            }
        }
        
        /// <summary>
        /// Unique ID for this item.
        /// </summary>
        /// <value>Unique ID for this item.</value>
        [DataMember(Name="item_id", EmitDefaultValue=false)]
        public long? ItemId { get; set; }


        /// <summary>
        /// References a solar system, station or item_id if this blueprint is located within a container. If the return value is an item_id, then the Character AssetList API must be queried to find the container using the given item_id to determine the correct location of the Blueprint.
        /// </summary>
        /// <value>References a solar system, station or item_id if this blueprint is located within a container. If the return value is an item_id, then the Character AssetList API must be queried to find the container using the given item_id to determine the correct location of the Blueprint.</value>
        [DataMember(Name="location_id", EmitDefaultValue=false)]
        public long? LocationId { get; set; }

        /// <summary>
        /// Material Efficiency Level of the blueprint.
        /// </summary>
        /// <value>Material Efficiency Level of the blueprint.</value>
        [DataMember(Name="material_efficiency", EmitDefaultValue=false)]
        public int? MaterialEfficiency { get; set; }

        /// <summary>
        /// A range of numbers with a minimum of -2 and no maximum value where -1 is an original and -2 is a copy. It can be a positive integer if it is a stack of blueprint originals fresh from the market (e.g. no activities performed on them yet).
        /// </summary>
        /// <value>A range of numbers with a minimum of -2 and no maximum value where -1 is an original and -2 is a copy. It can be a positive integer if it is a stack of blueprint originals fresh from the market (e.g. no activities performed on them yet).</value>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public int? Quantity { get; set; }

        /// <summary>
        /// Number of runs remaining if the blueprint is a copy, -1 if it is an original.
        /// </summary>
        /// <value>Number of runs remaining if the blueprint is a copy, -1 if it is an original.</value>
        [DataMember(Name="runs", EmitDefaultValue=false)]
        public int? Runs { get; set; }

        /// <summary>
        /// Time Efficiency Level of the blueprint.
        /// </summary>
        /// <value>Time Efficiency Level of the blueprint.</value>
        [DataMember(Name="time_efficiency", EmitDefaultValue=false)]
        public int? TimeEfficiency { get; set; }

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
            sb.Append("class GetCharactersCharacterIdBlueprints200Ok {\n");
            sb.Append("  ItemId: ").Append(ItemId).Append("\n");
            sb.Append("  LocationFlag: ").Append(LocationFlag).Append("\n");
            sb.Append("  LocationId: ").Append(LocationId).Append("\n");
            sb.Append("  MaterialEfficiency: ").Append(MaterialEfficiency).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  Runs: ").Append(Runs).Append("\n");
            sb.Append("  TimeEfficiency: ").Append(TimeEfficiency).Append("\n");
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
            return this.Equals(input as GetCharactersCharacterIdBlueprints200Ok);
        }

        /// <summary>
        /// Returns true if GetCharactersCharacterIdBlueprints200Ok instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCharactersCharacterIdBlueprints200Ok to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCharactersCharacterIdBlueprints200Ok input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ItemId == input.ItemId ||
                    (this.ItemId != null &&
                    this.ItemId.Equals(input.ItemId))
                ) && 
                (
                    this.LocationFlag == input.LocationFlag ||
                    (this.LocationFlag != null &&
                    this.LocationFlag.Equals(input.LocationFlag))
                ) && 
                (
                    this.LocationId == input.LocationId ||
                    (this.LocationId != null &&
                    this.LocationId.Equals(input.LocationId))
                ) && 
                (
                    this.MaterialEfficiency == input.MaterialEfficiency ||
                    (this.MaterialEfficiency != null &&
                    this.MaterialEfficiency.Equals(input.MaterialEfficiency))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
                ) && 
                (
                    this.Runs == input.Runs ||
                    (this.Runs != null &&
                    this.Runs.Equals(input.Runs))
                ) && 
                (
                    this.TimeEfficiency == input.TimeEfficiency ||
                    (this.TimeEfficiency != null &&
                    this.TimeEfficiency.Equals(input.TimeEfficiency))
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
                if (this.ItemId != null)
                    hashCode = hashCode * 59 + this.ItemId.GetHashCode();
                if (this.LocationFlag != null)
                    hashCode = hashCode * 59 + this.LocationFlag.GetHashCode();
                if (this.LocationId != null)
                    hashCode = hashCode * 59 + this.LocationId.GetHashCode();
                if (this.MaterialEfficiency != null)
                    hashCode = hashCode * 59 + this.MaterialEfficiency.GetHashCode();
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.Runs != null)
                    hashCode = hashCode * 59 + this.Runs.GetHashCode();
                if (this.TimeEfficiency != null)
                    hashCode = hashCode * 59 + this.TimeEfficiency.GetHashCode();
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
            // MaterialEfficiency (int?) maximum
            if(this.MaterialEfficiency > (int?)25)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MaterialEfficiency, must be a value less than or equal to 25.", new [] { "MaterialEfficiency" });
            }

            // MaterialEfficiency (int?) minimum
            if(this.MaterialEfficiency < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MaterialEfficiency, must be a value greater than or equal to 0.", new [] { "MaterialEfficiency" });
            }

            // Quantity (int?) minimum
            if(this.Quantity < (int?)-2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Quantity, must be a value greater than or equal to -2.", new [] { "Quantity" });
            }

            // Runs (int?) minimum
            if(this.Runs < (int?)-1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Runs, must be a value greater than or equal to -1.", new [] { "Runs" });
            }

            // TimeEfficiency (int?) maximum
            if(this.TimeEfficiency > (int?)20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TimeEfficiency, must be a value less than or equal to 20.", new [] { "TimeEfficiency" });
            }

            // TimeEfficiency (int?) minimum
            if(this.TimeEfficiency < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TimeEfficiency, must be a value greater than or equal to 0.", new [] { "TimeEfficiency" });
            }

            yield break;
        }
    }

}
