using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceInvoiceApprovalLevelRecord
public class RESTRC_7d9af3f1351b60af34cc932af3010814 : AbstractRESTStructure<RC_7d9af3f1351b60af34cc932af3010814> {
[JsonProperty("Invoice")]
public ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord AttrInvoice;

[JsonProperty("InvoiceApprovalLevel")]
public ssConectaProveedores.RestRecords.RESTEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord AttrInvoiceApprovalLevel;

public RESTRC_7d9af3f1351b60af34cc932af3010814() { }

public RESTRC_7d9af3f1351b60af34cc932af3010814 (RC_7d9af3f1351b60af34cc932af3010814 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoice = ConvertToRestWithoutDefaults(s.ssENInvoice, new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure, config);
AttrInvoiceApprovalLevel = ConvertToRestWithoutDefaults(s.ssENInvoiceApprovalLevel, new EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord.FromStructure, config);
  } else {
AttrInvoice = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure(s.ssENInvoice, config);
AttrInvoiceApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord.FromStructure(s.ssENInvoiceApprovalLevel, config);
  }
}

public static RC_7d9af3f1351b60af34cc932af3010814 ToStructure(ssConectaProveedores.RestRecords.RESTRC_7d9af3f1351b60af34cc932af3010814 obj) { 
  RC_7d9af3f1351b60af34cc932af3010814 s = new RC_7d9af3f1351b60af34cc932af3010814();
  if(obj != null) {
  s.ssENInvoice = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(obj.AttrInvoice);
  s.ssENInvoiceApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord.ToStructure(obj.AttrInvoiceApprovalLevel);
  }
  return s;
}

public static Func<RC_7d9af3f1351b60af34cc932af3010814, ssConectaProveedores.RestRecords.RESTRC_7d9af3f1351b60af34cc932af3010814> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_7d9af3f1351b60af34cc932af3010814 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_7d9af3f1351b60af34cc932af3010814 FromStructure(RC_7d9af3f1351b60af34cc932af3010814 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_7d9af3f1351b60af34cc932af3010814(s, config);
}

}


