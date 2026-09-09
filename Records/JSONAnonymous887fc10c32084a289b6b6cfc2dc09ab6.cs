using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceRequisitionInvoiceAccountingProcessRecord
public class JSONRC_93712ae8022b855afd9826482f80eceb : AbstractRESTStructure<RC_93712ae8022b855afd9826482f80eceb> {
[JsonProperty("Invoice")]
[JsonPropertyName("Invoice")]
public ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord AttrInvoice;

[JsonProperty("Requisition")]
[JsonPropertyName("Requisition")]
public ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord AttrRequisition;

[JsonProperty("InvoiceAccountingProcess")]
[JsonPropertyName("InvoiceAccountingProcess")]
public ssConectaProveedores.RestRecords.JSONEN_d21666375df829d28ffce8e5e0a3400dEntityRecord AttrInvoiceAccountingProcess;

public JSONRC_93712ae8022b855afd9826482f80eceb() { }

public JSONRC_93712ae8022b855afd9826482f80eceb (RC_93712ae8022b855afd9826482f80eceb s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoice = ConvertToRestWithoutDefaults(s.ssENInvoice, new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure, config);
AttrRequisition = ConvertToRestWithoutDefaults(s.ssENRequisition, new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure, config);
AttrInvoiceAccountingProcess = ConvertToRestWithoutDefaults(s.ssENInvoiceAccountingProcess, new EN_d21666375df829d28ffce8e5e0a3400dEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d21666375df829d28ffce8e5e0a3400dEntityRecord.FromStructure, config);
  } else {
AttrInvoice = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure(s.ssENInvoice, config);
AttrRequisition = ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure(s.ssENRequisition, config);
AttrInvoiceAccountingProcess = ssConectaProveedores.RestRecords.JSONEN_d21666375df829d28ffce8e5e0a3400dEntityRecord.FromStructure(s.ssENInvoiceAccountingProcess, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_93712ae8022b855afd9826482f80eceb, RC_93712ae8022b855afd9826482f80eceb> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_93712ae8022b855afd9826482f80eceb s) => ToStructure(s, config);
}
public static RC_93712ae8022b855afd9826482f80eceb ToStructure(ssConectaProveedores.RestRecords.JSONRC_93712ae8022b855afd9826482f80eceb obj, IBehaviorsConfiguration config) { 
  RC_93712ae8022b855afd9826482f80eceb s = new RC_93712ae8022b855afd9826482f80eceb();
  if(obj != null) {
  s.ssENInvoice = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(obj.AttrInvoice, config);
  s.ssENRequisition = ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.ToStructure(obj.AttrRequisition, config);
  s.ssENInvoiceAccountingProcess = ssConectaProveedores.RestRecords.JSONEN_d21666375df829d28ffce8e5e0a3400dEntityRecord.ToStructure(obj.AttrInvoiceAccountingProcess, config);
  }
  return s;
}

public static Func<RC_93712ae8022b855afd9826482f80eceb, ssConectaProveedores.RestRecords.JSONRC_93712ae8022b855afd9826482f80eceb> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_93712ae8022b855afd9826482f80eceb s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_93712ae8022b855afd9826482f80eceb FromStructure(RC_93712ae8022b855afd9826482f80eceb s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_93712ae8022b855afd9826482f80eceb(s, config);
}

}


