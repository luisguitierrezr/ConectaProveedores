using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionInvoiceAccountingProcessRecord
public class RESTRC_bf8addab42f215a7fe4584fe7162ae78 : AbstractRESTStructure<RC_bf8addab42f215a7fe4584fe7162ae78> {
[JsonProperty("Requisition")]
public ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord AttrRequisition;

[JsonProperty("InvoiceAccountingProcess")]
public ssConectaProveedores.RestRecords.RESTEN_d21666375df829d28ffce8e5e0a3400dEntityRecord AttrInvoiceAccountingProcess;

public RESTRC_bf8addab42f215a7fe4584fe7162ae78() { }

public RESTRC_bf8addab42f215a7fe4584fe7162ae78 (RC_bf8addab42f215a7fe4584fe7162ae78 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRequisition = ConvertToRestWithoutDefaults(s.ssENRequisition, new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure, config);
AttrInvoiceAccountingProcess = ConvertToRestWithoutDefaults(s.ssENInvoiceAccountingProcess, new EN_d21666375df829d28ffce8e5e0a3400dEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_d21666375df829d28ffce8e5e0a3400dEntityRecord.FromStructure, config);
  } else {
AttrRequisition = ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure(s.ssENRequisition, config);
AttrInvoiceAccountingProcess = ssConectaProveedores.RestRecords.RESTEN_d21666375df829d28ffce8e5e0a3400dEntityRecord.FromStructure(s.ssENInvoiceAccountingProcess, config);
  }
}

public static RC_bf8addab42f215a7fe4584fe7162ae78 ToStructure(ssConectaProveedores.RestRecords.RESTRC_bf8addab42f215a7fe4584fe7162ae78 obj) { 
  RC_bf8addab42f215a7fe4584fe7162ae78 s = new RC_bf8addab42f215a7fe4584fe7162ae78();
  if(obj != null) {
  s.ssENRequisition = ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.ToStructure(obj.AttrRequisition);
  s.ssENInvoiceAccountingProcess = ssConectaProveedores.RestRecords.RESTEN_d21666375df829d28ffce8e5e0a3400dEntityRecord.ToStructure(obj.AttrInvoiceAccountingProcess);
  }
  return s;
}

public static Func<RC_bf8addab42f215a7fe4584fe7162ae78, ssConectaProveedores.RestRecords.RESTRC_bf8addab42f215a7fe4584fe7162ae78> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_bf8addab42f215a7fe4584fe7162ae78 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_bf8addab42f215a7fe4584fe7162ae78 FromStructure(RC_bf8addab42f215a7fe4584fe7162ae78 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_bf8addab42f215a7fe4584fe7162ae78(s, config);
}

}


