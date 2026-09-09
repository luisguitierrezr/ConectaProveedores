using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceRequisitionRecord
public class RESTRC_003d65e5661b449409d67ebedc16a923 : AbstractRESTStructure<RC_003d65e5661b449409d67ebedc16a923> {
[JsonProperty("Invoice")]
public ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord AttrInvoice;

[JsonProperty("Requisition")]
public ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord AttrRequisition;

public RESTRC_003d65e5661b449409d67ebedc16a923() { }

public RESTRC_003d65e5661b449409d67ebedc16a923 (RC_003d65e5661b449409d67ebedc16a923 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoice = ConvertToRestWithoutDefaults(s.ssENInvoice, new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure, config);
AttrRequisition = ConvertToRestWithoutDefaults(s.ssENRequisition, new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure, config);
  } else {
AttrInvoice = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure(s.ssENInvoice, config);
AttrRequisition = ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure(s.ssENRequisition, config);
  }
}

public static RC_003d65e5661b449409d67ebedc16a923 ToStructure(ssConectaProveedores.RestRecords.RESTRC_003d65e5661b449409d67ebedc16a923 obj) { 
  RC_003d65e5661b449409d67ebedc16a923 s = new RC_003d65e5661b449409d67ebedc16a923();
  if(obj != null) {
  s.ssENInvoice = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(obj.AttrInvoice);
  s.ssENRequisition = ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.ToStructure(obj.AttrRequisition);
  }
  return s;
}

public static Func<RC_003d65e5661b449409d67ebedc16a923, ssConectaProveedores.RestRecords.RESTRC_003d65e5661b449409d67ebedc16a923> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_003d65e5661b449409d67ebedc16a923 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_003d65e5661b449409d67ebedc16a923 FromStructure(RC_003d65e5661b449409d67ebedc16a923 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_003d65e5661b449409d67ebedc16a923(s, config);
}

}


