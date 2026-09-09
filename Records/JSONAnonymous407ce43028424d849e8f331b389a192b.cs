using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceIdInvoiceApprovalLevelRecord
public class JSONRC_3b5a20a3b041a6f2c3616e35c15dcd14 : AbstractRESTStructure<RC_3b5a20a3b041a6f2c3616e35c15dcd14> {
[JsonProperty("InvoiceId")]
[JsonPropertyName("InvoiceId")]
public ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord AttrInvoiceId;

[JsonProperty("InvoiceApprovalLevel")]
[JsonPropertyName("InvoiceApprovalLevel")]
public ssConectaProveedores.RestRecords.JSONEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord AttrInvoiceApprovalLevel;

public JSONRC_3b5a20a3b041a6f2c3616e35c15dcd14() { }

public JSONRC_3b5a20a3b041a6f2c3616e35c15dcd14 (RC_3b5a20a3b041a6f2c3616e35c15dcd14 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceId = ConvertToRestWithoutDefaults(s.ssENInvoiceId, new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure, config);
AttrInvoiceApprovalLevel = ConvertToRestWithoutDefaults(s.ssENInvoiceApprovalLevel, new EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord.FromStructure, config);
  } else {
AttrInvoiceId = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure(s.ssENInvoiceId, config);
AttrInvoiceApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord.FromStructure(s.ssENInvoiceApprovalLevel, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_3b5a20a3b041a6f2c3616e35c15dcd14, RC_3b5a20a3b041a6f2c3616e35c15dcd14> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_3b5a20a3b041a6f2c3616e35c15dcd14 s) => ToStructure(s, config);
}
public static RC_3b5a20a3b041a6f2c3616e35c15dcd14 ToStructure(ssConectaProveedores.RestRecords.JSONRC_3b5a20a3b041a6f2c3616e35c15dcd14 obj, IBehaviorsConfiguration config) { 
  RC_3b5a20a3b041a6f2c3616e35c15dcd14 s = new RC_3b5a20a3b041a6f2c3616e35c15dcd14();
  if(obj != null) {
  s.ssENInvoiceId = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(obj.AttrInvoiceId, config);
  s.ssENInvoiceApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord.ToStructure(obj.AttrInvoiceApprovalLevel, config);
  }
  return s;
}

public static Func<RC_3b5a20a3b041a6f2c3616e35c15dcd14, ssConectaProveedores.RestRecords.JSONRC_3b5a20a3b041a6f2c3616e35c15dcd14> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_3b5a20a3b041a6f2c3616e35c15dcd14 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_3b5a20a3b041a6f2c3616e35c15dcd14 FromStructure(RC_3b5a20a3b041a6f2c3616e35c15dcd14 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_3b5a20a3b041a6f2c3616e35c15dcd14(s, config);
}

}


