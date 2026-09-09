using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderMainRecord
public class JSONRC_1583d548420c231ffb93458312800446 : AbstractRESTStructure<RC_1583d548420c231ffb93458312800446> {
[JsonProperty("OrderMain")]
[JsonPropertyName("OrderMain")]
public ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord AttrOrderMain;

public JSONRC_1583d548420c231ffb93458312800446() { }

public JSONRC_1583d548420c231ffb93458312800446 (RC_1583d548420c231ffb93458312800446 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderMain = ConvertToRestWithoutDefaults(s.ssENOrderMain, new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure, config);
  } else {
AttrOrderMain = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure(s.ssENOrderMain, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_1583d548420c231ffb93458312800446, RC_1583d548420c231ffb93458312800446> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_1583d548420c231ffb93458312800446 s) => ToStructure(s, config);
}
public static RC_1583d548420c231ffb93458312800446 ToStructure(ssConectaProveedores.RestRecords.JSONRC_1583d548420c231ffb93458312800446 obj, IBehaviorsConfiguration config) { 
  RC_1583d548420c231ffb93458312800446 s = new RC_1583d548420c231ffb93458312800446();
  if(obj != null) {
  s.ssENOrderMain = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.ToStructure(obj.AttrOrderMain, config);
  }
  return s;
}

public static Func<RC_1583d548420c231ffb93458312800446, ssConectaProveedores.RestRecords.JSONRC_1583d548420c231ffb93458312800446> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_1583d548420c231ffb93458312800446 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_1583d548420c231ffb93458312800446 FromStructure(RC_1583d548420c231ffb93458312800446 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_1583d548420c231ffb93458312800446(s, config);
}

}


