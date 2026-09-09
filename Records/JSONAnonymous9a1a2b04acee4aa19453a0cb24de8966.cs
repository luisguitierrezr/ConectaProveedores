using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionRegionRecord
public class JSONRC_4b3e229d9fe6ec886da8c5cf0d4be972 : AbstractRESTStructure<RC_4b3e229d9fe6ec886da8c5cf0d4be972> {
[JsonProperty("Requisition")]
[JsonPropertyName("Requisition")]
public ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord AttrRequisition;

[JsonProperty("Region")]
[JsonPropertyName("Region")]
public ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord AttrRegion;

public JSONRC_4b3e229d9fe6ec886da8c5cf0d4be972() { }

public JSONRC_4b3e229d9fe6ec886da8c5cf0d4be972 (RC_4b3e229d9fe6ec886da8c5cf0d4be972 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRequisition = ConvertToRestWithoutDefaults(s.ssENRequisition, new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure, config);
AttrRegion = ConvertToRestWithoutDefaults(s.ssENRegion, new EN_31f501c551d210017fcb34b5237e3390EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure, config);
  } else {
AttrRequisition = ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure(s.ssENRequisition, config);
AttrRegion = ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure(s.ssENRegion, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_4b3e229d9fe6ec886da8c5cf0d4be972, RC_4b3e229d9fe6ec886da8c5cf0d4be972> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_4b3e229d9fe6ec886da8c5cf0d4be972 s) => ToStructure(s, config);
}
public static RC_4b3e229d9fe6ec886da8c5cf0d4be972 ToStructure(ssConectaProveedores.RestRecords.JSONRC_4b3e229d9fe6ec886da8c5cf0d4be972 obj, IBehaviorsConfiguration config) { 
  RC_4b3e229d9fe6ec886da8c5cf0d4be972 s = new RC_4b3e229d9fe6ec886da8c5cf0d4be972();
  if(obj != null) {
  s.ssENRequisition = ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.ToStructure(obj.AttrRequisition, config);
  s.ssENRegion = ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.ToStructure(obj.AttrRegion, config);
  }
  return s;
}

public static Func<RC_4b3e229d9fe6ec886da8c5cf0d4be972, ssConectaProveedores.RestRecords.JSONRC_4b3e229d9fe6ec886da8c5cf0d4be972> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_4b3e229d9fe6ec886da8c5cf0d4be972 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_4b3e229d9fe6ec886da8c5cf0d4be972 FromStructure(RC_4b3e229d9fe6ec886da8c5cf0d4be972 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_4b3e229d9fe6ec886da8c5cf0d4be972(s, config);
}

}


