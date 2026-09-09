using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderApprovalLevelIdOrderIdRecord
public class JSONRC_829c5fdbd08f778c26d3a6457b4b0808 : AbstractRESTStructure<RC_829c5fdbd08f778c26d3a6457b4b0808> {
[JsonProperty("OrderApprovalLevelId")]
[JsonPropertyName("OrderApprovalLevelId")]
public long? AttrOrderApprovalLevelId;

[JsonProperty("OrderId")]
[JsonPropertyName("OrderId")]
public long? AttrOrderId;

public JSONRC_829c5fdbd08f778c26d3a6457b4b0808() { }

public JSONRC_829c5fdbd08f778c26d3a6457b4b0808 (RC_829c5fdbd08f778c26d3a6457b4b0808 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderApprovalLevelId = ConvertToRestWithoutDefaults(s.ssOrderApprovalLevelId, 0L);
AttrOrderId = ConvertToRestWithoutDefaults(s.ssOrderId, 0L);
  } else {
AttrOrderApprovalLevelId = (long?) s.ssOrderApprovalLevelId;
AttrOrderId = (long?) s.ssOrderId;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_829c5fdbd08f778c26d3a6457b4b0808, RC_829c5fdbd08f778c26d3a6457b4b0808> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_829c5fdbd08f778c26d3a6457b4b0808 s) => ToStructure(s, config);
}
public static RC_829c5fdbd08f778c26d3a6457b4b0808 ToStructure(ssConectaProveedores.RestRecords.JSONRC_829c5fdbd08f778c26d3a6457b4b0808 obj, IBehaviorsConfiguration config) { 
  RC_829c5fdbd08f778c26d3a6457b4b0808 s = new RC_829c5fdbd08f778c26d3a6457b4b0808();
  if(obj != null) {
  s.ssOrderApprovalLevelId = obj.AttrOrderApprovalLevelId == null ? 0L : obj.AttrOrderApprovalLevelId.Value;
  s.ssOrderId = obj.AttrOrderId == null ? 0L : obj.AttrOrderId.Value;
  }
  return s;
}

public static Func<RC_829c5fdbd08f778c26d3a6457b4b0808, ssConectaProveedores.RestRecords.JSONRC_829c5fdbd08f778c26d3a6457b4b0808> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_829c5fdbd08f778c26d3a6457b4b0808 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_829c5fdbd08f778c26d3a6457b4b0808 FromStructure(RC_829c5fdbd08f778c26d3a6457b4b0808 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_829c5fdbd08f778c26d3a6457b4b0808(s, config);
}

}


