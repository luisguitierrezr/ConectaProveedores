using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserRequisitionLogsRequisitionRecord
public class RESTRC_f5b6f78be278df3dd44e2d0a42d99692 : AbstractRESTStructure<RC_f5b6f78be278df3dd44e2d0a42d99692> {
[JsonProperty("User")]
public ssConectaProveedores.RestRecords.RESTENUserEntityRecord AttrUser;

[JsonProperty("RequisitionLogs")]
public ssConectaProveedores.RestRecords.RESTEN_fca813b8ca96d6759e00225744caa7d4EntityRecord AttrRequisitionLogs;

[JsonProperty("Requisition")]
public ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord AttrRequisition;

public RESTRC_f5b6f78be278df3dd44e2d0a42d99692() { }

public RESTRC_f5b6f78be278df3dd44e2d0a42d99692 (RC_f5b6f78be278df3dd44e2d0a42d99692 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser = ConvertToRestWithoutDefaults(s.ssENUser, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure, config);
AttrRequisitionLogs = ConvertToRestWithoutDefaults(s.ssENRequisitionLogs, new EN_fca813b8ca96d6759e00225744caa7d4EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_fca813b8ca96d6759e00225744caa7d4EntityRecord.FromStructure, config);
AttrRequisition = ConvertToRestWithoutDefaults(s.ssENRequisition, new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure, config);
  } else {
AttrUser = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure(s.ssENUser, config);
AttrRequisitionLogs = ssConectaProveedores.RestRecords.RESTEN_fca813b8ca96d6759e00225744caa7d4EntityRecord.FromStructure(s.ssENRequisitionLogs, config);
AttrRequisition = ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure(s.ssENRequisition, config);
  }
}

public static RC_f5b6f78be278df3dd44e2d0a42d99692 ToStructure(ssConectaProveedores.RestRecords.RESTRC_f5b6f78be278df3dd44e2d0a42d99692 obj) { 
  RC_f5b6f78be278df3dd44e2d0a42d99692 s = new RC_f5b6f78be278df3dd44e2d0a42d99692();
  if(obj != null) {
  s.ssENUser = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.ToStructure(obj.AttrUser);
  s.ssENRequisitionLogs = ssConectaProveedores.RestRecords.RESTEN_fca813b8ca96d6759e00225744caa7d4EntityRecord.ToStructure(obj.AttrRequisitionLogs);
  s.ssENRequisition = ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.ToStructure(obj.AttrRequisition);
  }
  return s;
}

public static Func<RC_f5b6f78be278df3dd44e2d0a42d99692, ssConectaProveedores.RestRecords.RESTRC_f5b6f78be278df3dd44e2d0a42d99692> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_f5b6f78be278df3dd44e2d0a42d99692 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_f5b6f78be278df3dd44e2d0a42d99692 FromStructure(RC_f5b6f78be278df3dd44e2d0a42d99692 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_f5b6f78be278df3dd44e2d0a42d99692(s, config);
}

}


