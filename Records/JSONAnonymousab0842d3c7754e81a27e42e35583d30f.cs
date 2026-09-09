using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceInvoiceAccountingProcessRecord
public class JSONRC_23a1d959d7c6821c1ced3d87b6f84ab7 : AbstractRESTStructure<RC_23a1d959d7c6821c1ced3d87b6f84ab7> {
[JsonProperty("Invoice")]
[JsonPropertyName("Invoice")]
public ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord AttrInvoice;

[JsonProperty("InvoiceAccountingProcess")]
[JsonPropertyName("InvoiceAccountingProcess")]
public ssConectaProveedores.RestRecords.JSONEN_d21666375df829d28ffce8e5e0a3400dEntityRecord AttrInvoiceAccountingProcess;

public JSONRC_23a1d959d7c6821c1ced3d87b6f84ab7() { }

public JSONRC_23a1d959d7c6821c1ced3d87b6f84ab7 (RC_23a1d959d7c6821c1ced3d87b6f84ab7 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoice = ConvertToRestWithoutDefaults(s.ssENInvoice, new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure, config);
AttrInvoiceAccountingProcess = ConvertToRestWithoutDefaults(s.ssENInvoiceAccountingProcess, new EN_d21666375df829d28ffce8e5e0a3400dEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d21666375df829d28ffce8e5e0a3400dEntityRecord.FromStructure, config);
  } else {
AttrInvoice = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure(s.ssENInvoice, config);
AttrInvoiceAccountingProcess = ssConectaProveedores.RestRecords.JSONEN_d21666375df829d28ffce8e5e0a3400dEntityRecord.FromStructure(s.ssENInvoiceAccountingProcess, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_23a1d959d7c6821c1ced3d87b6f84ab7, RC_23a1d959d7c6821c1ced3d87b6f84ab7> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_23a1d959d7c6821c1ced3d87b6f84ab7 s) => ToStructure(s, config);
}
public static RC_23a1d959d7c6821c1ced3d87b6f84ab7 ToStructure(ssConectaProveedores.RestRecords.JSONRC_23a1d959d7c6821c1ced3d87b6f84ab7 obj, IBehaviorsConfiguration config) { 
  RC_23a1d959d7c6821c1ced3d87b6f84ab7 s = new RC_23a1d959d7c6821c1ced3d87b6f84ab7();
  if(obj != null) {
  s.ssENInvoice = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(obj.AttrInvoice, config);
  s.ssENInvoiceAccountingProcess = ssConectaProveedores.RestRecords.JSONEN_d21666375df829d28ffce8e5e0a3400dEntityRecord.ToStructure(obj.AttrInvoiceAccountingProcess, config);
  }
  return s;
}

public static Func<RC_23a1d959d7c6821c1ced3d87b6f84ab7, ssConectaProveedores.RestRecords.JSONRC_23a1d959d7c6821c1ced3d87b6f84ab7> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_23a1d959d7c6821c1ced3d87b6f84ab7 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_23a1d959d7c6821c1ced3d87b6f84ab7 FromStructure(RC_23a1d959d7c6821c1ced3d87b6f84ab7 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_23a1d959d7c6821c1ced3d87b6f84ab7(s, config);
}

}


