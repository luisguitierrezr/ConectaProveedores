using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceRequisitionRegionRecord
public class JSONRC_3336d2630e2646e00d0c2f5c3e5a01ea : AbstractRESTStructure<RC_3336d2630e2646e00d0c2f5c3e5a01ea> {
[JsonProperty("Invoice")]
[JsonPropertyName("Invoice")]
public ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord AttrInvoice;

[JsonProperty("Requisition")]
[JsonPropertyName("Requisition")]
public ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord AttrRequisition;

[JsonProperty("Region")]
[JsonPropertyName("Region")]
public ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord AttrRegion;

public JSONRC_3336d2630e2646e00d0c2f5c3e5a01ea() { }

public JSONRC_3336d2630e2646e00d0c2f5c3e5a01ea (RC_3336d2630e2646e00d0c2f5c3e5a01ea s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoice = ConvertToRestWithoutDefaults(s.ssENInvoice, new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure, config);
AttrRequisition = ConvertToRestWithoutDefaults(s.ssENRequisition, new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure, config);
AttrRegion = ConvertToRestWithoutDefaults(s.ssENRegion, new EN_31f501c551d210017fcb34b5237e3390EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure, config);
  } else {
AttrInvoice = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure(s.ssENInvoice, config);
AttrRequisition = ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure(s.ssENRequisition, config);
AttrRegion = ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure(s.ssENRegion, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_3336d2630e2646e00d0c2f5c3e5a01ea, RC_3336d2630e2646e00d0c2f5c3e5a01ea> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_3336d2630e2646e00d0c2f5c3e5a01ea s) => ToStructure(s, config);
}
public static RC_3336d2630e2646e00d0c2f5c3e5a01ea ToStructure(ssConectaProveedores.RestRecords.JSONRC_3336d2630e2646e00d0c2f5c3e5a01ea obj, IBehaviorsConfiguration config) { 
  RC_3336d2630e2646e00d0c2f5c3e5a01ea s = new RC_3336d2630e2646e00d0c2f5c3e5a01ea();
  if(obj != null) {
  s.ssENInvoice = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(obj.AttrInvoice, config);
  s.ssENRequisition = ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.ToStructure(obj.AttrRequisition, config);
  s.ssENRegion = ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.ToStructure(obj.AttrRegion, config);
  }
  return s;
}

public static Func<RC_3336d2630e2646e00d0c2f5c3e5a01ea, ssConectaProveedores.RestRecords.JSONRC_3336d2630e2646e00d0c2f5c3e5a01ea> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_3336d2630e2646e00d0c2f5c3e5a01ea s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_3336d2630e2646e00d0c2f5c3e5a01ea FromStructure(RC_3336d2630e2646e00d0c2f5c3e5a01ea s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_3336d2630e2646e00d0c2f5c3e5a01ea(s, config);
}

}


