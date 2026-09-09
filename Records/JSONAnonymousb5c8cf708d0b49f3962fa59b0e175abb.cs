using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderMainOrderApprovaLevelRecord
public class JSONRC_26cbbaf47ee3c0155ebd57237529c97f : AbstractRESTStructure<RC_26cbbaf47ee3c0155ebd57237529c97f> {
[JsonProperty("OrderMain")]
[JsonPropertyName("OrderMain")]
public ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord AttrOrderMain;

[JsonProperty("OrderApprovaLevel")]
[JsonPropertyName("OrderApprovaLevel")]
public ssConectaProveedores.RestRecords.JSONEN_6b660d05e4c0025dff47119642875ca2EntityRecord AttrOrderApprovaLevel;

public JSONRC_26cbbaf47ee3c0155ebd57237529c97f() { }

public JSONRC_26cbbaf47ee3c0155ebd57237529c97f (RC_26cbbaf47ee3c0155ebd57237529c97f s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderMain = ConvertToRestWithoutDefaults(s.ssENOrderMain, new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure, config);
AttrOrderApprovaLevel = ConvertToRestWithoutDefaults(s.ssENOrderApprovaLevel, new EN_6b660d05e4c0025dff47119642875ca2EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_6b660d05e4c0025dff47119642875ca2EntityRecord.FromStructure, config);
  } else {
AttrOrderMain = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure(s.ssENOrderMain, config);
AttrOrderApprovaLevel = ssConectaProveedores.RestRecords.JSONEN_6b660d05e4c0025dff47119642875ca2EntityRecord.FromStructure(s.ssENOrderApprovaLevel, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_26cbbaf47ee3c0155ebd57237529c97f, RC_26cbbaf47ee3c0155ebd57237529c97f> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_26cbbaf47ee3c0155ebd57237529c97f s) => ToStructure(s, config);
}
public static RC_26cbbaf47ee3c0155ebd57237529c97f ToStructure(ssConectaProveedores.RestRecords.JSONRC_26cbbaf47ee3c0155ebd57237529c97f obj, IBehaviorsConfiguration config) { 
  RC_26cbbaf47ee3c0155ebd57237529c97f s = new RC_26cbbaf47ee3c0155ebd57237529c97f();
  if(obj != null) {
  s.ssENOrderMain = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.ToStructure(obj.AttrOrderMain, config);
  s.ssENOrderApprovaLevel = ssConectaProveedores.RestRecords.JSONEN_6b660d05e4c0025dff47119642875ca2EntityRecord.ToStructure(obj.AttrOrderApprovaLevel, config);
  }
  return s;
}

public static Func<RC_26cbbaf47ee3c0155ebd57237529c97f, ssConectaProveedores.RestRecords.JSONRC_26cbbaf47ee3c0155ebd57237529c97f> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_26cbbaf47ee3c0155ebd57237529c97f s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_26cbbaf47ee3c0155ebd57237529c97f FromStructure(RC_26cbbaf47ee3c0155ebd57237529c97f s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_26cbbaf47ee3c0155ebd57237529c97f(s, config);
}

}


