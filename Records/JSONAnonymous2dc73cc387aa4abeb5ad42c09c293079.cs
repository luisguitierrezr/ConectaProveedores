using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceApprovalLevelIdInvoiceIdInvoiceNumberRecord
public class JSONRC_3797d4971af6bc97d739ac602330acb1 : AbstractRESTStructure<RC_3797d4971af6bc97d739ac602330acb1> {
[JsonProperty("InvoiceApprovalLevelId")]
[JsonPropertyName("InvoiceApprovalLevelId")]
public long? AttrInvoiceApprovalLevelId;

[JsonProperty("InvoiceId")]
[JsonPropertyName("InvoiceId")]
public long? AttrInvoiceId;

[JsonProperty("InvoiceNumber")]
[JsonPropertyName("InvoiceNumber")]
public string AttrInvoiceNumber;

public JSONRC_3797d4971af6bc97d739ac602330acb1() { }

public JSONRC_3797d4971af6bc97d739ac602330acb1 (RC_3797d4971af6bc97d739ac602330acb1 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceApprovalLevelId = ConvertToRestWithoutDefaults(s.ssInvoiceApprovalLevelId, 0L);
AttrInvoiceId = ConvertToRestWithoutDefaults(s.ssInvoiceId, 0L);
AttrInvoiceNumber = ConvertToRestWithoutDefaults(s.ssInvoiceNumber, "");
  } else {
AttrInvoiceApprovalLevelId = (long?) s.ssInvoiceApprovalLevelId;
AttrInvoiceId = (long?) s.ssInvoiceId;
AttrInvoiceNumber = s.ssInvoiceNumber;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_3797d4971af6bc97d739ac602330acb1, RC_3797d4971af6bc97d739ac602330acb1> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_3797d4971af6bc97d739ac602330acb1 s) => ToStructure(s, config);
}
public static RC_3797d4971af6bc97d739ac602330acb1 ToStructure(ssConectaProveedores.RestRecords.JSONRC_3797d4971af6bc97d739ac602330acb1 obj, IBehaviorsConfiguration config) { 
  RC_3797d4971af6bc97d739ac602330acb1 s = new RC_3797d4971af6bc97d739ac602330acb1();
  if(obj != null) {
  s.ssInvoiceApprovalLevelId = obj.AttrInvoiceApprovalLevelId == null ? 0L : obj.AttrInvoiceApprovalLevelId.Value;
  s.ssInvoiceId = obj.AttrInvoiceId == null ? 0L : obj.AttrInvoiceId.Value;
  s.ssInvoiceNumber = obj.AttrInvoiceNumber == null ? "" : obj.AttrInvoiceNumber;
  }
  return s;
}

public static Func<RC_3797d4971af6bc97d739ac602330acb1, ssConectaProveedores.RestRecords.JSONRC_3797d4971af6bc97d739ac602330acb1> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_3797d4971af6bc97d739ac602330acb1 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_3797d4971af6bc97d739ac602330acb1 FromStructure(RC_3797d4971af6bc97d739ac602330acb1 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_3797d4971af6bc97d739ac602330acb1(s, config);
}

}


