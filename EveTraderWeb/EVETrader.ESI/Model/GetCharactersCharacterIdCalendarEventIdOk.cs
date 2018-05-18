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
    /// Full details of a specific event
    /// </summary>
    [DataContract]
    public partial class GetCharactersCharacterIdCalendarEventIdOk :  IEquatable<GetCharactersCharacterIdCalendarEventIdOk>, IValidatableObject
    {
        /// <summary>
        /// owner_type string
        /// </summary>
        /// <value>owner_type string</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OwnerTypeEnum
        {
            
            /// <summary>
            /// Enum Eveserver for value: eve_server
            /// </summary>
            [EnumMember(Value = "eve_server")]
            Eveserver = 1,
            
            /// <summary>
            /// Enum Corporation for value: corporation
            /// </summary>
            [EnumMember(Value = "corporation")]
            Corporation = 2,
            
            /// <summary>
            /// Enum Faction for value: faction
            /// </summary>
            [EnumMember(Value = "faction")]
            Faction = 3,
            
            /// <summary>
            /// Enum Character for value: character
            /// </summary>
            [EnumMember(Value = "character")]
            Character = 4,
            
            /// <summary>
            /// Enum Alliance for value: alliance
            /// </summary>
            [EnumMember(Value = "alliance")]
            Alliance = 5
        }

        /// <summary>
        /// owner_type string
        /// </summary>
        /// <value>owner_type string</value>
        [DataMember(Name="owner_type", EmitDefaultValue=false)]
        public OwnerTypeEnum OwnerType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersCharacterIdCalendarEventIdOk" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetCharactersCharacterIdCalendarEventIdOk() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersCharacterIdCalendarEventIdOk" /> class.
        /// </summary>
        /// <param name="Date">date string (required).</param>
        /// <param name="Duration">Length in minutes (required).</param>
        /// <param name="EventId">event_id integer (required).</param>
        /// <param name="Importance">importance integer (required).</param>
        /// <param name="OwnerId">owner_id integer (required).</param>
        /// <param name="OwnerName">owner_name string (required).</param>
        /// <param name="OwnerType">owner_type string (required).</param>
        /// <param name="Response">response string (required).</param>
        /// <param name="Text">text string (required).</param>
        /// <param name="Title">title string (required).</param>
        public GetCharactersCharacterIdCalendarEventIdOk(DateTime? Date = default(DateTime?), int? Duration = default(int?), int? EventId = default(int?), int? Importance = default(int?), int? OwnerId = default(int?), string OwnerName = default(string), OwnerTypeEnum OwnerType = default(OwnerTypeEnum), string Response = default(string), string Text = default(string), string Title = default(string))
        {
            // to ensure "Date" is required (not null)
            if (Date == null)
            {
                throw new InvalidDataException("Date is a required property for GetCharactersCharacterIdCalendarEventIdOk and cannot be null");
            }
            else
            {
                this.Date = Date;
            }
            // to ensure "Duration" is required (not null)
            if (Duration == null)
            {
                throw new InvalidDataException("Duration is a required property for GetCharactersCharacterIdCalendarEventIdOk and cannot be null");
            }
            else
            {
                this.Duration = Duration;
            }
            // to ensure "EventId" is required (not null)
            if (EventId == null)
            {
                throw new InvalidDataException("EventId is a required property for GetCharactersCharacterIdCalendarEventIdOk and cannot be null");
            }
            else
            {
                this.EventId = EventId;
            }
            // to ensure "Importance" is required (not null)
            if (Importance == null)
            {
                throw new InvalidDataException("Importance is a required property for GetCharactersCharacterIdCalendarEventIdOk and cannot be null");
            }
            else
            {
                this.Importance = Importance;
            }
            // to ensure "OwnerId" is required (not null)
            if (OwnerId == null)
            {
                throw new InvalidDataException("OwnerId is a required property for GetCharactersCharacterIdCalendarEventIdOk and cannot be null");
            }
            else
            {
                this.OwnerId = OwnerId;
            }
            // to ensure "OwnerName" is required (not null)
            if (OwnerName == null)
            {
                throw new InvalidDataException("OwnerName is a required property for GetCharactersCharacterIdCalendarEventIdOk and cannot be null");
            }
            else
            {
                this.OwnerName = OwnerName;
            }
            // to ensure "OwnerType" is required (not null)
            if (OwnerType == null)
            {
                throw new InvalidDataException("OwnerType is a required property for GetCharactersCharacterIdCalendarEventIdOk and cannot be null");
            }
            else
            {
                this.OwnerType = OwnerType;
            }
            // to ensure "Response" is required (not null)
            if (Response == null)
            {
                throw new InvalidDataException("Response is a required property for GetCharactersCharacterIdCalendarEventIdOk and cannot be null");
            }
            else
            {
                this.Response = Response;
            }
            // to ensure "Text" is required (not null)
            if (Text == null)
            {
                throw new InvalidDataException("Text is a required property for GetCharactersCharacterIdCalendarEventIdOk and cannot be null");
            }
            else
            {
                this.Text = Text;
            }
            // to ensure "Title" is required (not null)
            if (Title == null)
            {
                throw new InvalidDataException("Title is a required property for GetCharactersCharacterIdCalendarEventIdOk and cannot be null");
            }
            else
            {
                this.Title = Title;
            }
        }
        
        /// <summary>
        /// date string
        /// </summary>
        /// <value>date string</value>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Length in minutes
        /// </summary>
        /// <value>Length in minutes</value>
        [DataMember(Name="duration", EmitDefaultValue=false)]
        public int? Duration { get; set; }

        /// <summary>
        /// event_id integer
        /// </summary>
        /// <value>event_id integer</value>
        [DataMember(Name="event_id", EmitDefaultValue=false)]
        public int? EventId { get; set; }

        /// <summary>
        /// importance integer
        /// </summary>
        /// <value>importance integer</value>
        [DataMember(Name="importance", EmitDefaultValue=false)]
        public int? Importance { get; set; }

        /// <summary>
        /// owner_id integer
        /// </summary>
        /// <value>owner_id integer</value>
        [DataMember(Name="owner_id", EmitDefaultValue=false)]
        public int? OwnerId { get; set; }

        /// <summary>
        /// owner_name string
        /// </summary>
        /// <value>owner_name string</value>
        [DataMember(Name="owner_name", EmitDefaultValue=false)]
        public string OwnerName { get; set; }


        /// <summary>
        /// response string
        /// </summary>
        /// <value>response string</value>
        [DataMember(Name="response", EmitDefaultValue=false)]
        public string Response { get; set; }

        /// <summary>
        /// text string
        /// </summary>
        /// <value>text string</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }

        /// <summary>
        /// title string
        /// </summary>
        /// <value>title string</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCharactersCharacterIdCalendarEventIdOk {\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  EventId: ").Append(EventId).Append("\n");
            sb.Append("  Importance: ").Append(Importance).Append("\n");
            sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
            sb.Append("  OwnerName: ").Append(OwnerName).Append("\n");
            sb.Append("  OwnerType: ").Append(OwnerType).Append("\n");
            sb.Append("  Response: ").Append(Response).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
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
            return this.Equals(input as GetCharactersCharacterIdCalendarEventIdOk);
        }

        /// <summary>
        /// Returns true if GetCharactersCharacterIdCalendarEventIdOk instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCharactersCharacterIdCalendarEventIdOk to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCharactersCharacterIdCalendarEventIdOk input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.Duration == input.Duration ||
                    (this.Duration != null &&
                    this.Duration.Equals(input.Duration))
                ) && 
                (
                    this.EventId == input.EventId ||
                    (this.EventId != null &&
                    this.EventId.Equals(input.EventId))
                ) && 
                (
                    this.Importance == input.Importance ||
                    (this.Importance != null &&
                    this.Importance.Equals(input.Importance))
                ) && 
                (
                    this.OwnerId == input.OwnerId ||
                    (this.OwnerId != null &&
                    this.OwnerId.Equals(input.OwnerId))
                ) && 
                (
                    this.OwnerName == input.OwnerName ||
                    (this.OwnerName != null &&
                    this.OwnerName.Equals(input.OwnerName))
                ) && 
                (
                    this.OwnerType == input.OwnerType ||
                    (this.OwnerType != null &&
                    this.OwnerType.Equals(input.OwnerType))
                ) && 
                (
                    this.Response == input.Response ||
                    (this.Response != null &&
                    this.Response.Equals(input.Response))
                ) && 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
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
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.Duration != null)
                    hashCode = hashCode * 59 + this.Duration.GetHashCode();
                if (this.EventId != null)
                    hashCode = hashCode * 59 + this.EventId.GetHashCode();
                if (this.Importance != null)
                    hashCode = hashCode * 59 + this.Importance.GetHashCode();
                if (this.OwnerId != null)
                    hashCode = hashCode * 59 + this.OwnerId.GetHashCode();
                if (this.OwnerName != null)
                    hashCode = hashCode * 59 + this.OwnerName.GetHashCode();
                if (this.OwnerType != null)
                    hashCode = hashCode * 59 + this.OwnerType.GetHashCode();
                if (this.Response != null)
                    hashCode = hashCode * 59 + this.Response.GetHashCode();
                if (this.Text != null)
                    hashCode = hashCode * 59 + this.Text.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
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