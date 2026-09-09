using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionLogsRecord
public class RESTRC_da02352775767d2a57ea4cd35cd18496 : AbstractRESTStructure<RC_da02352775767d2a57ea4cd35cd18496> {
[JsonProperty("RequisitionLogs")]
public ssConectaProveedores.RestRecords.RESTEN_fca813b8ca96d6759e00225744caa7d4EntityRecord AttrRequisitionLogs;

public RESTRC_da02352775767d2a57ea4cd35cd18496() { }

public RESTRC_da02352775767d2a57ea4cd35cd18496 (RC_da02352775767d2a57ea4cd35cd18496 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRequisitionLogs = ConvertToRestWithoutDefaults(s.ssENRequisitionLogs, new EN_fca813b8ca96d6759e00225744caa7d4EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_fca813b8ca96d6759e00225744caa7d4EntityRecord.FromStructure, config);
  } else {
AttrRequisitionLogs = ssConectaProveedores.RestRecords.RESTEN_fca813b8ca96d6759e00225744caa7d4EntityRecord.FromStructure(s.ssENRequisitionLogs, config);
  }
}

public static RC_da02352775767d2a57ea4cd35cd18496 ToStructure(ssConectaProveedores.RestRecords.RESTRC_da02352775767d2a57ea4cd35cd18496 obj) { 
  RC_da02352775767d2a57ea4cd35cd18496 s = new RC_da02352775767d2a57ea4cd35cd18496();
  if(obj != null) {
  s.ssENRequisitionLogs = ssConectaProveedores.RestRecords.RESTEN_fca813b8ca96d6759e00225744caa7d4EntityRecord.ToStructure(obj.AttrRequisitionLogs);
  }
  return s;
}

public static Func<RC_da02352775767d2a57ea4cd35cd18496, ssConectaProveedores.RestRecords.RESTRC_da02352775767d2a57ea4cd35cd18496> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_da02352775767d2a57ea4cd35cd18496 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_da02352775767d2a57ea4cd35cd18496 FromStructure(RC_da02352775767d2a57ea4cd35cd18496 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_da02352775767d2a57ea4cd35cd18496(s, config);
}

}


