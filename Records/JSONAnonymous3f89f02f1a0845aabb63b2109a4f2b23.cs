using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceAccountingProcessResponseInvoiceAccountingProcessRecord
public class JSONRC_bec85b4f53f0fb643f61e8bb4fa47a4b : AbstractRESTStructure<RC_bec85b4f53f0fb643f61e8bb4fa47a4b> {
[JsonProperty("InvoiceAccountingProcessResponse")]
[JsonPropertyName("InvoiceAccountingProcessResponse")]
public ssConectaProveedores.RestRecords.JSONEN_e91123b36c7b071a4454698bbf50e4bcEntityRecord AttrInvoiceAccountingProcessResponse;

[JsonProperty("InvoiceAccountingProcess")]
[JsonPropertyName("InvoiceAccountingProcess")]
public ssConectaProveedores.RestRecords.JSONEN_d21666375df829d28ffce8e5e0a3400dEntityRecord AttrInvoiceAccountingProcess;

public JSONRC_bec85b4f53f0fb643f61e8bb4fa47a4b() { }

public JSONRC_bec85b4f53f0fb643f61e8bb4fa47a4b (RC_bec85b4f53f0fb643f61e8bb4fa47a4b s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceAccountingProcessResponse = ConvertToRestWithoutDefaults(s.ssENInvoiceAccountingProcessResponse, new EN_e91123b36c7b071a4454698bbf50e4bcEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_e91123b36c7b071a4454698bbf50e4bcEntityRecord.FromStructure, config);
AttrInvoiceAccountingProcess = ConvertToRestWithoutDefaults(s.ssENInvoiceAccountingProcess, new EN_d21666375df829d28ffce8e5e0a3400dEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d21666375df829d28ffce8e5e0a3400dEntityRecord.FromStructure, config);
  } else {
AttrInvoiceAccountingProcessResponse = ssConectaProveedores.RestRecords.JSONEN_e91123b36c7b071a4454698bbf50e4bcEntityRecord.FromStructure(s.ssENInvoiceAccountingProcessResponse, config);
AttrInvoiceAccountingProcess = ssConectaProveedores.RestRecords.JSONEN_d21666375df829d28ffce8e5e0a3400dEntityRecord.FromStructure(s.ssENInvoiceAccountingProcess, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_bec85b4f53f0fb643f61e8bb4fa47a4b, RC_bec85b4f53f0fb643f61e8bb4fa47a4b> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_bec85b4f53f0fb643f61e8bb4fa47a4b s) => ToStructure(s, config);
}
public static RC_bec85b4f53f0fb643f61e8bb4fa47a4b ToStructure(ssConectaProveedores.RestRecords.JSONRC_bec85b4f53f0fb643f61e8bb4fa47a4b obj, IBehaviorsConfiguration config) { 
  RC_bec85b4f53f0fb643f61e8bb4fa47a4b s = new RC_bec85b4f53f0fb643f61e8bb4fa47a4b();
  if(obj != null) {
  s.ssENInvoiceAccountingProcessResponse = ssConectaProveedores.RestRecords.JSONEN_e91123b36c7b071a4454698bbf50e4bcEntityRecord.ToStructure(obj.AttrInvoiceAccountingProcessResponse, config);
  s.ssENInvoiceAccountingProcess = ssConectaProveedores.RestRecords.JSONEN_d21666375df829d28ffce8e5e0a3400dEntityRecord.ToStructure(obj.AttrInvoiceAccountingProcess, config);
  }
  return s;
}

public static Func<RC_bec85b4f53f0fb643f61e8bb4fa47a4b, ssConectaProveedores.RestRecords.JSONRC_bec85b4f53f0fb643f61e8bb4fa47a4b> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_bec85b4f53f0fb643f61e8bb4fa47a4b s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_bec85b4f53f0fb643f61e8bb4fa47a4b FromStructure(RC_bec85b4f53f0fb643f61e8bb4fa47a4b s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_bec85b4f53f0fb643f61e8bb4fa47a4b(s, config);
}

}


