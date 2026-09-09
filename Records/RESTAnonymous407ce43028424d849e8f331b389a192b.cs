using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceIdInvoiceApprovalLevelRecord
public class RESTRC_3b5a20a3b041a6f2c3616e35c15dcd14 : AbstractRESTStructure<RC_3b5a20a3b041a6f2c3616e35c15dcd14> {
[JsonProperty("InvoiceId")]
public ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord AttrInvoiceId;

[JsonProperty("InvoiceApprovalLevel")]
public ssConectaProveedores.RestRecords.RESTEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord AttrInvoiceApprovalLevel;

public RESTRC_3b5a20a3b041a6f2c3616e35c15dcd14() { }

public RESTRC_3b5a20a3b041a6f2c3616e35c15dcd14 (RC_3b5a20a3b041a6f2c3616e35c15dcd14 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceId = ConvertToRestWithoutDefaults(s.ssENInvoiceId, new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure, config);
AttrInvoiceApprovalLevel = ConvertToRestWithoutDefaults(s.ssENInvoiceApprovalLevel, new EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord.FromStructure, config);
  } else {
AttrInvoiceId = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure(s.ssENInvoiceId, config);
AttrInvoiceApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord.FromStructure(s.ssENInvoiceApprovalLevel, config);
  }
}

public static RC_3b5a20a3b041a6f2c3616e35c15dcd14 ToStructure(ssConectaProveedores.RestRecords.RESTRC_3b5a20a3b041a6f2c3616e35c15dcd14 obj) { 
  RC_3b5a20a3b041a6f2c3616e35c15dcd14 s = new RC_3b5a20a3b041a6f2c3616e35c15dcd14();
  if(obj != null) {
  s.ssENInvoiceId = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(obj.AttrInvoiceId);
  s.ssENInvoiceApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord.ToStructure(obj.AttrInvoiceApprovalLevel);
  }
  return s;
}

public static Func<RC_3b5a20a3b041a6f2c3616e35c15dcd14, ssConectaProveedores.RestRecords.RESTRC_3b5a20a3b041a6f2c3616e35c15dcd14> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_3b5a20a3b041a6f2c3616e35c15dcd14 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_3b5a20a3b041a6f2c3616e35c15dcd14 FromStructure(RC_3b5a20a3b041a6f2c3616e35c15dcd14 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_3b5a20a3b041a6f2c3616e35c15dcd14(s, config);
}

}


