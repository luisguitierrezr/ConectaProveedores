using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceAccountingProcessResponseInvoiceAccountingProcessRecord
public class RESTRC_bec85b4f53f0fb643f61e8bb4fa47a4b : AbstractRESTStructure<RC_bec85b4f53f0fb643f61e8bb4fa47a4b> {
[JsonProperty("InvoiceAccountingProcessResponse")]
public ssConectaProveedores.RestRecords.RESTEN_e91123b36c7b071a4454698bbf50e4bcEntityRecord AttrInvoiceAccountingProcessResponse;

[JsonProperty("InvoiceAccountingProcess")]
public ssConectaProveedores.RestRecords.RESTEN_d21666375df829d28ffce8e5e0a3400dEntityRecord AttrInvoiceAccountingProcess;

public RESTRC_bec85b4f53f0fb643f61e8bb4fa47a4b() { }

public RESTRC_bec85b4f53f0fb643f61e8bb4fa47a4b (RC_bec85b4f53f0fb643f61e8bb4fa47a4b s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceAccountingProcessResponse = ConvertToRestWithoutDefaults(s.ssENInvoiceAccountingProcessResponse, new EN_e91123b36c7b071a4454698bbf50e4bcEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_e91123b36c7b071a4454698bbf50e4bcEntityRecord.FromStructure, config);
AttrInvoiceAccountingProcess = ConvertToRestWithoutDefaults(s.ssENInvoiceAccountingProcess, new EN_d21666375df829d28ffce8e5e0a3400dEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_d21666375df829d28ffce8e5e0a3400dEntityRecord.FromStructure, config);
  } else {
AttrInvoiceAccountingProcessResponse = ssConectaProveedores.RestRecords.RESTEN_e91123b36c7b071a4454698bbf50e4bcEntityRecord.FromStructure(s.ssENInvoiceAccountingProcessResponse, config);
AttrInvoiceAccountingProcess = ssConectaProveedores.RestRecords.RESTEN_d21666375df829d28ffce8e5e0a3400dEntityRecord.FromStructure(s.ssENInvoiceAccountingProcess, config);
  }
}

public static RC_bec85b4f53f0fb643f61e8bb4fa47a4b ToStructure(ssConectaProveedores.RestRecords.RESTRC_bec85b4f53f0fb643f61e8bb4fa47a4b obj) { 
  RC_bec85b4f53f0fb643f61e8bb4fa47a4b s = new RC_bec85b4f53f0fb643f61e8bb4fa47a4b();
  if(obj != null) {
  s.ssENInvoiceAccountingProcessResponse = ssConectaProveedores.RestRecords.RESTEN_e91123b36c7b071a4454698bbf50e4bcEntityRecord.ToStructure(obj.AttrInvoiceAccountingProcessResponse);
  s.ssENInvoiceAccountingProcess = ssConectaProveedores.RestRecords.RESTEN_d21666375df829d28ffce8e5e0a3400dEntityRecord.ToStructure(obj.AttrInvoiceAccountingProcess);
  }
  return s;
}

public static Func<RC_bec85b4f53f0fb643f61e8bb4fa47a4b, ssConectaProveedores.RestRecords.RESTRC_bec85b4f53f0fb643f61e8bb4fa47a4b> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_bec85b4f53f0fb643f61e8bb4fa47a4b s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_bec85b4f53f0fb643f61e8bb4fa47a4b FromStructure(RC_bec85b4f53f0fb643f61e8bb4fa47a4b s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_bec85b4f53f0fb643f61e8bb4fa47a4b(s, config);
}

}


