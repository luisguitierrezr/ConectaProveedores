using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserOrderMainOrderLogsRecord
public class RESTRC_48f837ac894bfbcf11c3d8c2e6c47c59 : AbstractRESTStructure<RC_48f837ac894bfbcf11c3d8c2e6c47c59> {
[JsonProperty("User")]
public ssConectaProveedores.RestRecords.RESTENUserEntityRecord AttrUser;

[JsonProperty("OrderMain")]
public ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord AttrOrderMain;

[JsonProperty("OrderLogs")]
public ssConectaProveedores.RestRecords.RESTEN_a8e484428097204171df8a1feecb2534EntityRecord AttrOrderLogs;

public RESTRC_48f837ac894bfbcf11c3d8c2e6c47c59() { }

public RESTRC_48f837ac894bfbcf11c3d8c2e6c47c59 (RC_48f837ac894bfbcf11c3d8c2e6c47c59 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser = ConvertToRestWithoutDefaults(s.ssENUser, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure, config);
AttrOrderMain = ConvertToRestWithoutDefaults(s.ssENOrderMain, new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure, config);
AttrOrderLogs = ConvertToRestWithoutDefaults(s.ssENOrderLogs, new EN_a8e484428097204171df8a1feecb2534EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_a8e484428097204171df8a1feecb2534EntityRecord.FromStructure, config);
  } else {
AttrUser = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure(s.ssENUser, config);
AttrOrderMain = ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure(s.ssENOrderMain, config);
AttrOrderLogs = ssConectaProveedores.RestRecords.RESTEN_a8e484428097204171df8a1feecb2534EntityRecord.FromStructure(s.ssENOrderLogs, config);
  }
}

public static RC_48f837ac894bfbcf11c3d8c2e6c47c59 ToStructure(ssConectaProveedores.RestRecords.RESTRC_48f837ac894bfbcf11c3d8c2e6c47c59 obj) { 
  RC_48f837ac894bfbcf11c3d8c2e6c47c59 s = new RC_48f837ac894bfbcf11c3d8c2e6c47c59();
  if(obj != null) {
  s.ssENUser = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.ToStructure(obj.AttrUser);
  s.ssENOrderMain = ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.ToStructure(obj.AttrOrderMain);
  s.ssENOrderLogs = ssConectaProveedores.RestRecords.RESTEN_a8e484428097204171df8a1feecb2534EntityRecord.ToStructure(obj.AttrOrderLogs);
  }
  return s;
}

public static Func<RC_48f837ac894bfbcf11c3d8c2e6c47c59, ssConectaProveedores.RestRecords.RESTRC_48f837ac894bfbcf11c3d8c2e6c47c59> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_48f837ac894bfbcf11c3d8c2e6c47c59 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_48f837ac894bfbcf11c3d8c2e6c47c59 FromStructure(RC_48f837ac894bfbcf11c3d8c2e6c47c59 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_48f837ac894bfbcf11c3d8c2e6c47c59(s, config);
}

}


