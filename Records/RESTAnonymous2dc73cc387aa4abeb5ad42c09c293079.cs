using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceApprovalLevelIdInvoiceIdInvoiceNumberRecord
public class RESTRC_3797d4971af6bc97d739ac602330acb1 : AbstractRESTStructure<RC_3797d4971af6bc97d739ac602330acb1> {
[JsonProperty("InvoiceApprovalLevelId")]
public long? AttrInvoiceApprovalLevelId;

[JsonProperty("InvoiceId")]
public long? AttrInvoiceId;

[JsonProperty("InvoiceNumber")]
public string AttrInvoiceNumber;

public RESTRC_3797d4971af6bc97d739ac602330acb1() { }

public RESTRC_3797d4971af6bc97d739ac602330acb1 (RC_3797d4971af6bc97d739ac602330acb1 s, IBehaviorsConfiguration config) {
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

public static RC_3797d4971af6bc97d739ac602330acb1 ToStructure(ssConectaProveedores.RestRecords.RESTRC_3797d4971af6bc97d739ac602330acb1 obj) { 
  RC_3797d4971af6bc97d739ac602330acb1 s = new RC_3797d4971af6bc97d739ac602330acb1();
  if(obj != null) {
  s.ssInvoiceApprovalLevelId = obj.AttrInvoiceApprovalLevelId == null ? 0L : obj.AttrInvoiceApprovalLevelId.Value;
  s.ssInvoiceId = obj.AttrInvoiceId == null ? 0L : obj.AttrInvoiceId.Value;
  s.ssInvoiceNumber = obj.AttrInvoiceNumber == null ? "" : obj.AttrInvoiceNumber;
  }
  return s;
}

public static Func<RC_3797d4971af6bc97d739ac602330acb1, ssConectaProveedores.RestRecords.RESTRC_3797d4971af6bc97d739ac602330acb1> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_3797d4971af6bc97d739ac602330acb1 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_3797d4971af6bc97d739ac602330acb1 FromStructure(RC_3797d4971af6bc97d739ac602330acb1 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_3797d4971af6bc97d739ac602330acb1(s, config);
}

}


