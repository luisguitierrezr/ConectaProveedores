using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceInvoiceAccountingProcessRecord
public class RESTRC_23a1d959d7c6821c1ced3d87b6f84ab7 : AbstractRESTStructure<RC_23a1d959d7c6821c1ced3d87b6f84ab7> {
[JsonProperty("Invoice")]
public ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord AttrInvoice;

[JsonProperty("InvoiceAccountingProcess")]
public ssConectaProveedores.RestRecords.RESTEN_d21666375df829d28ffce8e5e0a3400dEntityRecord AttrInvoiceAccountingProcess;

public RESTRC_23a1d959d7c6821c1ced3d87b6f84ab7() { }

public RESTRC_23a1d959d7c6821c1ced3d87b6f84ab7 (RC_23a1d959d7c6821c1ced3d87b6f84ab7 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoice = ConvertToRestWithoutDefaults(s.ssENInvoice, new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure, config);
AttrInvoiceAccountingProcess = ConvertToRestWithoutDefaults(s.ssENInvoiceAccountingProcess, new EN_d21666375df829d28ffce8e5e0a3400dEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_d21666375df829d28ffce8e5e0a3400dEntityRecord.FromStructure, config);
  } else {
AttrInvoice = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure(s.ssENInvoice, config);
AttrInvoiceAccountingProcess = ssConectaProveedores.RestRecords.RESTEN_d21666375df829d28ffce8e5e0a3400dEntityRecord.FromStructure(s.ssENInvoiceAccountingProcess, config);
  }
}

public static RC_23a1d959d7c6821c1ced3d87b6f84ab7 ToStructure(ssConectaProveedores.RestRecords.RESTRC_23a1d959d7c6821c1ced3d87b6f84ab7 obj) { 
  RC_23a1d959d7c6821c1ced3d87b6f84ab7 s = new RC_23a1d959d7c6821c1ced3d87b6f84ab7();
  if(obj != null) {
  s.ssENInvoice = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(obj.AttrInvoice);
  s.ssENInvoiceAccountingProcess = ssConectaProveedores.RestRecords.RESTEN_d21666375df829d28ffce8e5e0a3400dEntityRecord.ToStructure(obj.AttrInvoiceAccountingProcess);
  }
  return s;
}

public static Func<RC_23a1d959d7c6821c1ced3d87b6f84ab7, ssConectaProveedores.RestRecords.RESTRC_23a1d959d7c6821c1ced3d87b6f84ab7> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_23a1d959d7c6821c1ced3d87b6f84ab7 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_23a1d959d7c6821c1ced3d87b6f84ab7 FromStructure(RC_23a1d959d7c6821c1ced3d87b6f84ab7 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_23a1d959d7c6821c1ced3d87b6f84ab7(s, config);
}

}


