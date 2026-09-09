using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceInvoiceApprovalLevelRecord
public class JSONRC_7d9af3f1351b60af34cc932af3010814 : AbstractRESTStructure<RC_7d9af3f1351b60af34cc932af3010814> {
[JsonProperty("Invoice")]
[JsonPropertyName("Invoice")]
public ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord AttrInvoice;

[JsonProperty("InvoiceApprovalLevel")]
[JsonPropertyName("InvoiceApprovalLevel")]
public ssConectaProveedores.RestRecords.JSONEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord AttrInvoiceApprovalLevel;

public JSONRC_7d9af3f1351b60af34cc932af3010814() { }

public JSONRC_7d9af3f1351b60af34cc932af3010814 (RC_7d9af3f1351b60af34cc932af3010814 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoice = ConvertToRestWithoutDefaults(s.ssENInvoice, new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure, config);
AttrInvoiceApprovalLevel = ConvertToRestWithoutDefaults(s.ssENInvoiceApprovalLevel, new EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord.FromStructure, config);
  } else {
AttrInvoice = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure(s.ssENInvoice, config);
AttrInvoiceApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord.FromStructure(s.ssENInvoiceApprovalLevel, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_7d9af3f1351b60af34cc932af3010814, RC_7d9af3f1351b60af34cc932af3010814> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_7d9af3f1351b60af34cc932af3010814 s) => ToStructure(s, config);
}
public static RC_7d9af3f1351b60af34cc932af3010814 ToStructure(ssConectaProveedores.RestRecords.JSONRC_7d9af3f1351b60af34cc932af3010814 obj, IBehaviorsConfiguration config) { 
  RC_7d9af3f1351b60af34cc932af3010814 s = new RC_7d9af3f1351b60af34cc932af3010814();
  if(obj != null) {
  s.ssENInvoice = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(obj.AttrInvoice, config);
  s.ssENInvoiceApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord.ToStructure(obj.AttrInvoiceApprovalLevel, config);
  }
  return s;
}

public static Func<RC_7d9af3f1351b60af34cc932af3010814, ssConectaProveedores.RestRecords.JSONRC_7d9af3f1351b60af34cc932af3010814> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_7d9af3f1351b60af34cc932af3010814 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_7d9af3f1351b60af34cc932af3010814 FromStructure(RC_7d9af3f1351b60af34cc932af3010814 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_7d9af3f1351b60af34cc932af3010814(s, config);
}

}


