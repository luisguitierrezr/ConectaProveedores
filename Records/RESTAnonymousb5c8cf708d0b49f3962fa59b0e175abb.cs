using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderMainOrderApprovaLevelRecord
public class RESTRC_26cbbaf47ee3c0155ebd57237529c97f : AbstractRESTStructure<RC_26cbbaf47ee3c0155ebd57237529c97f> {
[JsonProperty("OrderMain")]
public ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord AttrOrderMain;

[JsonProperty("OrderApprovaLevel")]
public ssConectaProveedores.RestRecords.RESTEN_6b660d05e4c0025dff47119642875ca2EntityRecord AttrOrderApprovaLevel;

public RESTRC_26cbbaf47ee3c0155ebd57237529c97f() { }

public RESTRC_26cbbaf47ee3c0155ebd57237529c97f (RC_26cbbaf47ee3c0155ebd57237529c97f s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderMain = ConvertToRestWithoutDefaults(s.ssENOrderMain, new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure, config);
AttrOrderApprovaLevel = ConvertToRestWithoutDefaults(s.ssENOrderApprovaLevel, new EN_6b660d05e4c0025dff47119642875ca2EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_6b660d05e4c0025dff47119642875ca2EntityRecord.FromStructure, config);
  } else {
AttrOrderMain = ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure(s.ssENOrderMain, config);
AttrOrderApprovaLevel = ssConectaProveedores.RestRecords.RESTEN_6b660d05e4c0025dff47119642875ca2EntityRecord.FromStructure(s.ssENOrderApprovaLevel, config);
  }
}

public static RC_26cbbaf47ee3c0155ebd57237529c97f ToStructure(ssConectaProveedores.RestRecords.RESTRC_26cbbaf47ee3c0155ebd57237529c97f obj) { 
  RC_26cbbaf47ee3c0155ebd57237529c97f s = new RC_26cbbaf47ee3c0155ebd57237529c97f();
  if(obj != null) {
  s.ssENOrderMain = ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.ToStructure(obj.AttrOrderMain);
  s.ssENOrderApprovaLevel = ssConectaProveedores.RestRecords.RESTEN_6b660d05e4c0025dff47119642875ca2EntityRecord.ToStructure(obj.AttrOrderApprovaLevel);
  }
  return s;
}

public static Func<RC_26cbbaf47ee3c0155ebd57237529c97f, ssConectaProveedores.RestRecords.RESTRC_26cbbaf47ee3c0155ebd57237529c97f> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_26cbbaf47ee3c0155ebd57237529c97f s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_26cbbaf47ee3c0155ebd57237529c97f FromStructure(RC_26cbbaf47ee3c0155ebd57237529c97f s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_26cbbaf47ee3c0155ebd57237529c97f(s, config);
}

}


