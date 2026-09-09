using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceRequisitionInvoiceAccountingProcessRecord
public class RESTRC_93712ae8022b855afd9826482f80eceb : AbstractRESTStructure<RC_93712ae8022b855afd9826482f80eceb> {
[JsonProperty("Invoice")]
public ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord AttrInvoice;

[JsonProperty("Requisition")]
public ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord AttrRequisition;

[JsonProperty("InvoiceAccountingProcess")]
public ssConectaProveedores.RestRecords.RESTEN_d21666375df829d28ffce8e5e0a3400dEntityRecord AttrInvoiceAccountingProcess;

public RESTRC_93712ae8022b855afd9826482f80eceb() { }

public RESTRC_93712ae8022b855afd9826482f80eceb (RC_93712ae8022b855afd9826482f80eceb s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoice = ConvertToRestWithoutDefaults(s.ssENInvoice, new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure, config);
AttrRequisition = ConvertToRestWithoutDefaults(s.ssENRequisition, new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure, config);
AttrInvoiceAccountingProcess = ConvertToRestWithoutDefaults(s.ssENInvoiceAccountingProcess, new EN_d21666375df829d28ffce8e5e0a3400dEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_d21666375df829d28ffce8e5e0a3400dEntityRecord.FromStructure, config);
  } else {
AttrInvoice = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure(s.ssENInvoice, config);
AttrRequisition = ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure(s.ssENRequisition, config);
AttrInvoiceAccountingProcess = ssConectaProveedores.RestRecords.RESTEN_d21666375df829d28ffce8e5e0a3400dEntityRecord.FromStructure(s.ssENInvoiceAccountingProcess, config);
  }
}

public static RC_93712ae8022b855afd9826482f80eceb ToStructure(ssConectaProveedores.RestRecords.RESTRC_93712ae8022b855afd9826482f80eceb obj) { 
  RC_93712ae8022b855afd9826482f80eceb s = new RC_93712ae8022b855afd9826482f80eceb();
  if(obj != null) {
  s.ssENInvoice = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(obj.AttrInvoice);
  s.ssENRequisition = ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.ToStructure(obj.AttrRequisition);
  s.ssENInvoiceAccountingProcess = ssConectaProveedores.RestRecords.RESTEN_d21666375df829d28ffce8e5e0a3400dEntityRecord.ToStructure(obj.AttrInvoiceAccountingProcess);
  }
  return s;
}

public static Func<RC_93712ae8022b855afd9826482f80eceb, ssConectaProveedores.RestRecords.RESTRC_93712ae8022b855afd9826482f80eceb> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_93712ae8022b855afd9826482f80eceb s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_93712ae8022b855afd9826482f80eceb FromStructure(RC_93712ae8022b855afd9826482f80eceb s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_93712ae8022b855afd9826482f80eceb(s, config);
}

}


