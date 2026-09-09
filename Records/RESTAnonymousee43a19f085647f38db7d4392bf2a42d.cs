using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ApprovalProcessInvoiceInvoiceApprovalRecord
public class RESTRC_0bd21c095360ef78cf6d0f1777ecf52a : AbstractRESTStructure<RC_0bd21c095360ef78cf6d0f1777ecf52a> {
[JsonProperty("ApprovalProcess")]
public ssConectaProveedores.RestRecords.RESTEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord AttrApprovalProcess;

[JsonProperty("Invoice")]
public ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord AttrInvoice;

[JsonProperty("InvoiceApproval")]
public ssConectaProveedores.RestRecords.RESTEN_c2bd0675fed3aedb585c484c59155eddEntityRecord AttrInvoiceApproval;

public RESTRC_0bd21c095360ef78cf6d0f1777ecf52a() { }

public RESTRC_0bd21c095360ef78cf6d0f1777ecf52a (RC_0bd21c095360ef78cf6d0f1777ecf52a s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrApprovalProcess = ConvertToRestWithoutDefaults(s.ssENApprovalProcess, new EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord.FromStructure, config);
AttrInvoice = ConvertToRestWithoutDefaults(s.ssENInvoice, new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure, config);
AttrInvoiceApproval = ConvertToRestWithoutDefaults(s.ssENInvoiceApproval, new EN_c2bd0675fed3aedb585c484c59155eddEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_c2bd0675fed3aedb585c484c59155eddEntityRecord.FromStructure, config);
  } else {
AttrApprovalProcess = ssConectaProveedores.RestRecords.RESTEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord.FromStructure(s.ssENApprovalProcess, config);
AttrInvoice = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure(s.ssENInvoice, config);
AttrInvoiceApproval = ssConectaProveedores.RestRecords.RESTEN_c2bd0675fed3aedb585c484c59155eddEntityRecord.FromStructure(s.ssENInvoiceApproval, config);
  }
}

public static RC_0bd21c095360ef78cf6d0f1777ecf52a ToStructure(ssConectaProveedores.RestRecords.RESTRC_0bd21c095360ef78cf6d0f1777ecf52a obj) { 
  RC_0bd21c095360ef78cf6d0f1777ecf52a s = new RC_0bd21c095360ef78cf6d0f1777ecf52a();
  if(obj != null) {
  s.ssENApprovalProcess = ssConectaProveedores.RestRecords.RESTEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord.ToStructure(obj.AttrApprovalProcess);
  s.ssENInvoice = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(obj.AttrInvoice);
  s.ssENInvoiceApproval = ssConectaProveedores.RestRecords.RESTEN_c2bd0675fed3aedb585c484c59155eddEntityRecord.ToStructure(obj.AttrInvoiceApproval);
  }
  return s;
}

public static Func<RC_0bd21c095360ef78cf6d0f1777ecf52a, ssConectaProveedores.RestRecords.RESTRC_0bd21c095360ef78cf6d0f1777ecf52a> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_0bd21c095360ef78cf6d0f1777ecf52a s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_0bd21c095360ef78cf6d0f1777ecf52a FromStructure(RC_0bd21c095360ef78cf6d0f1777ecf52a s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_0bd21c095360ef78cf6d0f1777ecf52a(s, config);
}

}


