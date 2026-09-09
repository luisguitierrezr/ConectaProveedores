using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceApprovalLevelIdInvoiceIdRecord
public class JSONRC_c45ce7ee0ff58d891b8d78c9e2e835ad : AbstractRESTStructure<RC_c45ce7ee0ff58d891b8d78c9e2e835ad> {
[JsonProperty("InvoiceApprovalLevelId")]
[JsonPropertyName("InvoiceApprovalLevelId")]
public long? AttrInvoiceApprovalLevelId;

[JsonProperty("InvoiceId")]
[JsonPropertyName("InvoiceId")]
public long? AttrInvoiceId;

public JSONRC_c45ce7ee0ff58d891b8d78c9e2e835ad() { }

public JSONRC_c45ce7ee0ff58d891b8d78c9e2e835ad (RC_c45ce7ee0ff58d891b8d78c9e2e835ad s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceApprovalLevelId = ConvertToRestWithoutDefaults(s.ssInvoiceApprovalLevelId, 0L);
AttrInvoiceId = ConvertToRestWithoutDefaults(s.ssInvoiceId, 0L);
  } else {
AttrInvoiceApprovalLevelId = (long?) s.ssInvoiceApprovalLevelId;
AttrInvoiceId = (long?) s.ssInvoiceId;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_c45ce7ee0ff58d891b8d78c9e2e835ad, RC_c45ce7ee0ff58d891b8d78c9e2e835ad> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_c45ce7ee0ff58d891b8d78c9e2e835ad s) => ToStructure(s, config);
}
public static RC_c45ce7ee0ff58d891b8d78c9e2e835ad ToStructure(ssConectaProveedores.RestRecords.JSONRC_c45ce7ee0ff58d891b8d78c9e2e835ad obj, IBehaviorsConfiguration config) { 
  RC_c45ce7ee0ff58d891b8d78c9e2e835ad s = new RC_c45ce7ee0ff58d891b8d78c9e2e835ad();
  if(obj != null) {
  s.ssInvoiceApprovalLevelId = obj.AttrInvoiceApprovalLevelId == null ? 0L : obj.AttrInvoiceApprovalLevelId.Value;
  s.ssInvoiceId = obj.AttrInvoiceId == null ? 0L : obj.AttrInvoiceId.Value;
  }
  return s;
}

public static Func<RC_c45ce7ee0ff58d891b8d78c9e2e835ad, ssConectaProveedores.RestRecords.JSONRC_c45ce7ee0ff58d891b8d78c9e2e835ad> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_c45ce7ee0ff58d891b8d78c9e2e835ad s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_c45ce7ee0ff58d891b8d78c9e2e835ad FromStructure(RC_c45ce7ee0ff58d891b8d78c9e2e835ad s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_c45ce7ee0ff58d891b8d78c9e2e835ad(s, config);
}

}


