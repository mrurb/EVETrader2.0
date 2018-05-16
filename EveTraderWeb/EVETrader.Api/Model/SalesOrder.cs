using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class SalesOrder {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Gets or Sets TraderID
    /// </summary>
    [DataMember(Name="traderID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "traderID")]
    public int? TraderID { get; set; }

    /// <summary>
    /// Gets or Sets BuyerID
    /// </summary>
    [DataMember(Name="buyerID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "buyerID")]
    public int? BuyerID { get; set; }

    /// <summary>
    /// Gets or Sets Destination
    /// </summary>
    [DataMember(Name="destination", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "destination")]
    public int? Destination { get; set; }

    /// <summary>
    /// Gets or Sets Tip
    /// </summary>
    [DataMember(Name="tip", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tip")]
    public double? Tip { get; set; }

    /// <summary>
    /// Gets or Sets Published
    /// </summary>
    [DataMember(Name="published", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "published")]
    public bool? Published { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
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
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
