using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserRequisitionLogsRequisitionRecord
public class JSONRC_f5b6f78be278df3dd44e2d0a42d99692 : AbstractRESTStructure<RC_f5b6f78be278df3dd44e2d0a42d99692> {
[JsonProperty("User")]
[JsonPropertyName("User")]
public ssConectaProveedores.RestRecords.JSONENUserEntityRecord AttrUser;

[JsonProperty("RequisitionLogs")]
[JsonPropertyName("RequisitionLogs")]
public ssConectaProveedores.RestRecords.JSONEN_fca813b8ca96d6759e00225744caa7d4EntityRecord AttrRequisitionLogs;

[JsonProperty("Requisition")]
[JsonPropertyName("Requisition")]
public ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord AttrRequisition;

public JSONRC_f5b6f78be278df3dd44e2d0a42d99692() { }

public JSONRC_f5b6f78be278df3dd44e2d0a42d99692 (RC_f5b6f78be278df3dd44e2d0a42d99692 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser = ConvertToRestWithoutDefaults(s.ssENUser, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure, config);
AttrRequisitionLogs = ConvertToRestWithoutDefaults(s.ssENRequisitionLogs, new EN_fca813b8ca96d6759e00225744caa7d4EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_fca813b8ca96d6759e00225744caa7d4EntityRecord.FromStructure, config);
AttrRequisition = ConvertToRestWithoutDefaults(s.ssENRequisition, new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure, config);
  } else {
AttrUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure(s.ssENUser, config);
AttrRequisitionLogs = ssConectaProveedores.RestRecords.JSONEN_fca813b8ca96d6759e00225744caa7d4EntityRecord.FromStructure(s.ssENRequisitionLogs, config);
AttrRequisition = ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure(s.ssENRequisition, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_f5b6f78be278df3dd44e2d0a42d99692, RC_f5b6f78be278df3dd44e2d0a42d99692> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_f5b6f78be278df3dd44e2d0a42d99692 s) => ToStructure(s, config);
}
public static RC_f5b6f78be278df3dd44e2d0a42d99692 ToStructure(ssConectaProveedores.RestRecords.JSONRC_f5b6f78be278df3dd44e2d0a42d99692 obj, IBehaviorsConfiguration config) { 
  RC_f5b6f78be278df3dd44e2d0a42d99692 s = new RC_f5b6f78be278df3dd44e2d0a42d99692();
  if(obj != null) {
  s.ssENUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.ToStructure(obj.AttrUser, config);
  s.ssENRequisitionLogs = ssConectaProveedores.RestRecords.JSONEN_fca813b8ca96d6759e00225744caa7d4EntityRecord.ToStructure(obj.AttrRequisitionLogs, config);
  s.ssENRequisition = ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.ToStructure(obj.AttrRequisition, config);
  }
  return s;
}

public static Func<RC_f5b6f78be278df3dd44e2d0a42d99692, ssConectaProveedores.RestRecords.JSONRC_f5b6f78be278df3dd44e2d0a42d99692> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_f5b6f78be278df3dd44e2d0a42d99692 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_f5b6f78be278df3dd44e2d0a42d99692 FromStructure(RC_f5b6f78be278df3dd44e2d0a42d99692 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_f5b6f78be278df3dd44e2d0a42d99692(s, config);
}

}


