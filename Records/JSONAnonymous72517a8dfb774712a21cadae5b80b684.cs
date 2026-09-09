using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionInvoiceAccountingProcessRecord
public class JSONRC_bf8addab42f215a7fe4584fe7162ae78 : AbstractRESTStructure<RC_bf8addab42f215a7fe4584fe7162ae78> {
[JsonProperty("Requisition")]
[JsonPropertyName("Requisition")]
public ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord AttrRequisition;

[JsonProperty("InvoiceAccountingProcess")]
[JsonPropertyName("InvoiceAccountingProcess")]
public ssConectaProveedores.RestRecords.JSONEN_d21666375df829d28ffce8e5e0a3400dEntityRecord AttrInvoiceAccountingProcess;

public JSONRC_bf8addab42f215a7fe4584fe7162ae78() { }

public JSONRC_bf8addab42f215a7fe4584fe7162ae78 (RC_bf8addab42f215a7fe4584fe7162ae78 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRequisition = ConvertToRestWithoutDefaults(s.ssENRequisition, new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure, config);
AttrInvoiceAccountingProcess = ConvertToRestWithoutDefaults(s.ssENInvoiceAccountingProcess, new EN_d21666375df829d28ffce8e5e0a3400dEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d21666375df829d28ffce8e5e0a3400dEntityRecord.FromStructure, config);
  } else {
AttrRequisition = ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure(s.ssENRequisition, config);
AttrInvoiceAccountingProcess = ssConectaProveedores.RestRecords.JSONEN_d21666375df829d28ffce8e5e0a3400dEntityRecord.FromStructure(s.ssENInvoiceAccountingProcess, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_bf8addab42f215a7fe4584fe7162ae78, RC_bf8addab42f215a7fe4584fe7162ae78> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_bf8addab42f215a7fe4584fe7162ae78 s) => ToStructure(s, config);
}
public static RC_bf8addab42f215a7fe4584fe7162ae78 ToStructure(ssConectaProveedores.RestRecords.JSONRC_bf8addab42f215a7fe4584fe7162ae78 obj, IBehaviorsConfiguration config) { 
  RC_bf8addab42f215a7fe4584fe7162ae78 s = new RC_bf8addab42f215a7fe4584fe7162ae78();
  if(obj != null) {
  s.ssENRequisition = ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.ToStructure(obj.AttrRequisition, config);
  s.ssENInvoiceAccountingProcess = ssConectaProveedores.RestRecords.JSONEN_d21666375df829d28ffce8e5e0a3400dEntityRecord.ToStructure(obj.AttrInvoiceAccountingProcess, config);
  }
  return s;
}

public static Func<RC_bf8addab42f215a7fe4584fe7162ae78, ssConectaProveedores.RestRecords.JSONRC_bf8addab42f215a7fe4584fe7162ae78> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_bf8addab42f215a7fe4584fe7162ae78 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_bf8addab42f215a7fe4584fe7162ae78 FromStructure(RC_bf8addab42f215a7fe4584fe7162ae78 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_bf8addab42f215a7fe4584fe7162ae78(s, config);
}

}


