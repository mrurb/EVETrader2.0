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
    public partial class GetCharactersCharacterIdMail200Ok :  IEquatable<GetCharactersCharacterIdMail200Ok>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersCharacterIdMail200Ok" /> class.
        /// </summary>
        /// <param name="From">From whom the mail was sent.</param>
        /// <param name="IsRead">is_read boolean.</param>
        /// <param name="Labels">labels array.</param>
        /// <param name="MailId">mail_id integer.</param>
        /// <param name="Recipients">Recipients of the mail.</param>
        /// <param name="Subject">Mail subject.</param>
        /// <param name="Timestamp">When the mail was sent.</param>
        public GetCharactersCharacterIdMail200Ok(int? From = default(int?), bool? IsRead = default(bool?), List<int?> Labels = default(List<int?>), int? MailId = default(int?), List<GetCharactersCharacterIdMailRecipient> Recipients = default(List<GetCharactersCharacterIdMailRecipient>), string Subject = default(string), DateTime? Timestamp = default(DateTime?))
        {
            this.From = From;
            this.IsRead = IsRead;
            this.Labels = Labels;
            this.MailId = MailId;
            this.Recipients = Recipients;
            this.Subject = Subject;
            this.Timestamp = Timestamp;
        }
        
        /// <summary>
        /// From whom the mail was sent
        /// </summary>
        /// <value>From whom the mail was sent</value>
        [DataMember(Name="from", EmitDefaultValue=false)]
        public int? From { get; set; }

        /// <summary>
        /// is_read boolean
        /// </summary>
        /// <value>is_read boolean</value>
        [DataMember(Name="is_read", EmitDefaultValue=false)]
        public bool? IsRead { get; set; }

        /// <summary>
        /// labels array
        /// </summary>
        /// <value>labels array</value>
        [DataMember(Name="labels", EmitDefaultValue=false)]
        public List<int?> Labels { get; set; }

        /// <summary>
        /// mail_id integer
        /// </summary>
        /// <value>mail_id integer</value>
        [DataMember(Name="mail_id", EmitDefaultValue=false)]
        public int? MailId { get; set; }

        /// <summary>
        /// Recipients of the mail
        /// </summary>
        /// <value>Recipients of the mail</value>
        [DataMember(Name="recipients", EmitDefaultValue=false)]
        public List<GetCharactersCharacterIdMailRecipient> Recipients { get; set; }

        /// <summary>
        /// Mail subject
        /// </summary>
        /// <value>Mail subject</value>
        [DataMember(Name="subject", EmitDefaultValue=false)]
        public string Subject { get; set; }

        /// <summary>
        /// When the mail was sent
        /// </summary>
        /// <value>When the mail was sent</value>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCharactersCharacterIdMail200Ok {\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  IsRead: ").Append(IsRead).Append("\n");
            sb.Append("  Labels: ").Append(Labels).Append("\n");
            sb.Append("  MailId: ").Append(MailId).Append("\n");
            sb.Append("  Recipients: ").Append(Recipients).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
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
            return this.Equals(input as GetCharactersCharacterIdMail200Ok);
        }

        /// <summary>
        /// Returns true if GetCharactersCharacterIdMail200Ok instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCharactersCharacterIdMail200Ok to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCharactersCharacterIdMail200Ok input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.IsRead == input.IsRead ||
                    (this.IsRead != null &&
                    this.IsRead.Equals(input.IsRead))
                ) && 
                (
                    this.Labels == input.Labels ||
                    this.Labels != null &&
                    this.Labels.SequenceEqual(input.Labels)
                ) && 
                (
                    this.MailId == input.MailId ||
                    (this.MailId != null &&
                    this.MailId.Equals(input.MailId))
                ) && 
                (
                    this.Recipients == input.Recipients ||
                    this.Recipients != null &&
                    this.Recipients.SequenceEqual(input.Recipients)
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
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
                if (this.From != null)
                    hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.IsRead != null)
                    hashCode = hashCode * 59 + this.IsRead.GetHashCode();
                if (this.Labels != null)
                    hashCode = hashCode * 59 + this.Labels.GetHashCode();
                if (this.MailId != null)
                    hashCode = hashCode * 59 + this.MailId.GetHashCode();
                if (this.Recipients != null)
                    hashCode = hashCode * 59 + this.Recipients.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
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
