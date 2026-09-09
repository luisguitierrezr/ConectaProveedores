using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceInvoiceAccountingProcessResponseInvoiceAccountingProcessRecord
public class RESTRC_5c7aa2d527f88af9496e24408ac97c64 : AbstractRESTStructure<RC_5c7aa2d527f88af9496e24408ac97c64> {
[JsonProperty("Invoice")]
public ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord AttrInvoice;

[JsonProperty("InvoiceAccountingProcessResponse")]
public ssConectaProveedores.RestRecords.RESTEN_e91123b36c7b071a4454698bbf50e4bcEntityRecord AttrInvoiceAccountingProcessResponse;

[JsonProperty("InvoiceAccountingProcess")]
public ssConectaProveedores.RestRecords.RESTEN_d21666375df829d28ffce8e5e0a3400dEntityRecord AttrInvoiceAccountingProcess;

public RESTRC_5c7aa2d527f88af9496e24408ac97c64() { }

public RESTRC_5c7aa2d527f88af9496e24408ac97c64 (RC_5c7aa2d527f88af9496e24408ac97c64 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoice = ConvertToRestWithoutDefaults(s.ssENInvoice, new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure, config);
AttrInvoiceAccountingProcessResponse = ConvertToRestWithoutDefaults(s.ssENInvoiceAccountingProcessResponse, new EN_e91123b36c7b071a4454698bbf50e4bcEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_e91123b36c7b071a4454698bbf50e4bcEntityRecord.FromStructure, config);
AttrInvoiceAccountingProcess = ConvertToRestWithoutDefaults(s.ssENInvoiceAccountingProcess, new EN_d21666375df829d28ffce8e5e0a3400dEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_d21666375df829d28ffce8e5e0a3400dEntityRecord.FromStructure, config);
  } else {
AttrInvoice = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure(s.ssENInvoice, config);
AttrInvoiceAccountingProcessResponse = ssConectaProveedores.RestRecords.RESTEN_e91123b36c7b071a4454698bbf50e4bcEntityRecord.FromStructure(s.ssENInvoiceAccountingProcessResponse, config);
AttrInvoiceAccountingProcess = ssConectaProveedores.RestRecords.RESTEN_d21666375df829d28ffce8e5e0a3400dEntityRecord.FromStructure(s.ssENInvoiceAccountingProcess, config);
  }
}

public static RC_5c7aa2d527f88af9496e24408ac97c64 ToStructure(ssConectaProveedores.RestRecords.RESTRC_5c7aa2d527f88af9496e24408ac97c64 obj) { 
  RC_5c7aa2d527f88af9496e24408ac97c64 s = new RC_5c7aa2d527f88af9496e24408ac97c64();
  if(obj != null) {
  s.ssENInvoice = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(obj.AttrInvoice);
  s.ssENInvoiceAccountingProcessResponse = ssConectaProveedores.RestRecords.RESTEN_e91123b36c7b071a4454698bbf50e4bcEntityRecord.ToStructure(obj.AttrInvoiceAccountingProcessResponse);
  s.ssENInvoiceAccountingProcess = ssConectaProveedores.RestRecords.RESTEN_d21666375df829d28ffce8e5e0a3400dEntityRecord.ToStructure(obj.AttrInvoiceAccountingProcess);
  }
  return s;
}

public static Func<RC_5c7aa2d527f88af9496e24408ac97c64, ssConectaProveedores.RestRecords.RESTRC_5c7aa2d527f88af9496e24408ac97c64> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_5c7aa2d527f88af9496e24408ac97c64 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_5c7aa2d527f88af9496e24408ac97c64 FromStructure(RC_5c7aa2d527f88af9496e24408ac97c64 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_5c7aa2d527f88af9496e24408ac97c64(s, config);
}

}


