using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionRegionRecord
public class RESTRC_4b3e229d9fe6ec886da8c5cf0d4be972 : AbstractRESTStructure<RC_4b3e229d9fe6ec886da8c5cf0d4be972> {
[JsonProperty("Requisition")]
public ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord AttrRequisition;

[JsonProperty("Region")]
public ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord AttrRegion;

public RESTRC_4b3e229d9fe6ec886da8c5cf0d4be972() { }

public RESTRC_4b3e229d9fe6ec886da8c5cf0d4be972 (RC_4b3e229d9fe6ec886da8c5cf0d4be972 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRequisition = ConvertToRestWithoutDefaults(s.ssENRequisition, new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure, config);
AttrRegion = ConvertToRestWithoutDefaults(s.ssENRegion, new EN_31f501c551d210017fcb34b5237e3390EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure, config);
  } else {
AttrRequisition = ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure(s.ssENRequisition, config);
AttrRegion = ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure(s.ssENRegion, config);
  }
}

public static RC_4b3e229d9fe6ec886da8c5cf0d4be972 ToStructure(ssConectaProveedores.RestRecords.RESTRC_4b3e229d9fe6ec886da8c5cf0d4be972 obj) { 
  RC_4b3e229d9fe6ec886da8c5cf0d4be972 s = new RC_4b3e229d9fe6ec886da8c5cf0d4be972();
  if(obj != null) {
  s.ssENRequisition = ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.ToStructure(obj.AttrRequisition);
  s.ssENRegion = ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord.ToStructure(obj.AttrRegion);
  }
  return s;
}

public static Func<RC_4b3e229d9fe6ec886da8c5cf0d4be972, ssConectaProveedores.RestRecords.RESTRC_4b3e229d9fe6ec886da8c5cf0d4be972> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_4b3e229d9fe6ec886da8c5cf0d4be972 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_4b3e229d9fe6ec886da8c5cf0d4be972 FromStructure(RC_4b3e229d9fe6ec886da8c5cf0d4be972 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_4b3e229d9fe6ec886da8c5cf0d4be972(s, config);
}

}


