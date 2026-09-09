using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceRequisitionRecord
public class JSONRC_003d65e5661b449409d67ebedc16a923 : AbstractRESTStructure<RC_003d65e5661b449409d67ebedc16a923> {
[JsonProperty("Invoice")]
[JsonPropertyName("Invoice")]
public ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord AttrInvoice;

[JsonProperty("Requisition")]
[JsonPropertyName("Requisition")]
public ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord AttrRequisition;

public JSONRC_003d65e5661b449409d67ebedc16a923() { }

public JSONRC_003d65e5661b449409d67ebedc16a923 (RC_003d65e5661b449409d67ebedc16a923 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoice = ConvertToRestWithoutDefaults(s.ssENInvoice, new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure, config);
AttrRequisition = ConvertToRestWithoutDefaults(s.ssENRequisition, new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure, config);
  } else {
AttrInvoice = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure(s.ssENInvoice, config);
AttrRequisition = ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure(s.ssENRequisition, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_003d65e5661b449409d67ebedc16a923, RC_003d65e5661b449409d67ebedc16a923> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_003d65e5661b449409d67ebedc16a923 s) => ToStructure(s, config);
}
public static RC_003d65e5661b449409d67ebedc16a923 ToStructure(ssConectaProveedores.RestRecords.JSONRC_003d65e5661b449409d67ebedc16a923 obj, IBehaviorsConfiguration config) { 
  RC_003d65e5661b449409d67ebedc16a923 s = new RC_003d65e5661b449409d67ebedc16a923();
  if(obj != null) {
  s.ssENInvoice = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(obj.AttrInvoice, config);
  s.ssENRequisition = ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.ToStructure(obj.AttrRequisition, config);
  }
  return s;
}

public static Func<RC_003d65e5661b449409d67ebedc16a923, ssConectaProveedores.RestRecords.JSONRC_003d65e5661b449409d67ebedc16a923> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_003d65e5661b449409d67ebedc16a923 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_003d65e5661b449409d67ebedc16a923 FromStructure(RC_003d65e5661b449409d67ebedc16a923 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_003d65e5661b449409d67ebedc16a923(s, config);
}

}


