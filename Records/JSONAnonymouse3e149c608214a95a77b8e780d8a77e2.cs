using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderLogsRecord
public class JSONRC_aa950ad3dd0235488db9d65307673199 : AbstractRESTStructure<RC_aa950ad3dd0235488db9d65307673199> {
[JsonProperty("OrderLogs")]
[JsonPropertyName("OrderLogs")]
public ssConectaProveedores.RestRecords.JSONEN_a8e484428097204171df8a1feecb2534EntityRecord AttrOrderLogs;

public JSONRC_aa950ad3dd0235488db9d65307673199() { }

public JSONRC_aa950ad3dd0235488db9d65307673199 (RC_aa950ad3dd0235488db9d65307673199 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderLogs = ConvertToRestWithoutDefaults(s.ssENOrderLogs, new EN_a8e484428097204171df8a1feecb2534EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_a8e484428097204171df8a1feecb2534EntityRecord.FromStructure, config);
  } else {
AttrOrderLogs = ssConectaProveedores.RestRecords.JSONEN_a8e484428097204171df8a1feecb2534EntityRecord.FromStructure(s.ssENOrderLogs, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_aa950ad3dd0235488db9d65307673199, RC_aa950ad3dd0235488db9d65307673199> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_aa950ad3dd0235488db9d65307673199 s) => ToStructure(s, config);
}
public static RC_aa950ad3dd0235488db9d65307673199 ToStructure(ssConectaProveedores.RestRecords.JSONRC_aa950ad3dd0235488db9d65307673199 obj, IBehaviorsConfiguration config) { 
  RC_aa950ad3dd0235488db9d65307673199 s = new RC_aa950ad3dd0235488db9d65307673199();
  if(obj != null) {
  s.ssENOrderLogs = ssConectaProveedores.RestRecords.JSONEN_a8e484428097204171df8a1feecb2534EntityRecord.ToStructure(obj.AttrOrderLogs, config);
  }
  return s;
}

public static Func<RC_aa950ad3dd0235488db9d65307673199, ssConectaProveedores.RestRecords.JSONRC_aa950ad3dd0235488db9d65307673199> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_aa950ad3dd0235488db9d65307673199 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_aa950ad3dd0235488db9d65307673199 FromStructure(RC_aa950ad3dd0235488db9d65307673199 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_aa950ad3dd0235488db9d65307673199(s, config);
}

}


