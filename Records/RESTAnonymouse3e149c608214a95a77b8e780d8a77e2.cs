using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderLogsRecord
public class RESTRC_aa950ad3dd0235488db9d65307673199 : AbstractRESTStructure<RC_aa950ad3dd0235488db9d65307673199> {
[JsonProperty("OrderLogs")]
public ssConectaProveedores.RestRecords.RESTEN_a8e484428097204171df8a1feecb2534EntityRecord AttrOrderLogs;

public RESTRC_aa950ad3dd0235488db9d65307673199() { }

public RESTRC_aa950ad3dd0235488db9d65307673199 (RC_aa950ad3dd0235488db9d65307673199 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderLogs = ConvertToRestWithoutDefaults(s.ssENOrderLogs, new EN_a8e484428097204171df8a1feecb2534EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_a8e484428097204171df8a1feecb2534EntityRecord.FromStructure, config);
  } else {
AttrOrderLogs = ssConectaProveedores.RestRecords.RESTEN_a8e484428097204171df8a1feecb2534EntityRecord.FromStructure(s.ssENOrderLogs, config);
  }
}

public static RC_aa950ad3dd0235488db9d65307673199 ToStructure(ssConectaProveedores.RestRecords.RESTRC_aa950ad3dd0235488db9d65307673199 obj) { 
  RC_aa950ad3dd0235488db9d65307673199 s = new RC_aa950ad3dd0235488db9d65307673199();
  if(obj != null) {
  s.ssENOrderLogs = ssConectaProveedores.RestRecords.RESTEN_a8e484428097204171df8a1feecb2534EntityRecord.ToStructure(obj.AttrOrderLogs);
  }
  return s;
}

public static Func<RC_aa950ad3dd0235488db9d65307673199, ssConectaProveedores.RestRecords.RESTRC_aa950ad3dd0235488db9d65307673199> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_aa950ad3dd0235488db9d65307673199 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_aa950ad3dd0235488db9d65307673199 FromStructure(RC_aa950ad3dd0235488db9d65307673199 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_aa950ad3dd0235488db9d65307673199(s, config);
}

}


