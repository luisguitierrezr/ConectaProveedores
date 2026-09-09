using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderMainRecord
public class RESTRC_1583d548420c231ffb93458312800446 : AbstractRESTStructure<RC_1583d548420c231ffb93458312800446> {
[JsonProperty("OrderMain")]
public ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord AttrOrderMain;

public RESTRC_1583d548420c231ffb93458312800446() { }

public RESTRC_1583d548420c231ffb93458312800446 (RC_1583d548420c231ffb93458312800446 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderMain = ConvertToRestWithoutDefaults(s.ssENOrderMain, new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure, config);
  } else {
AttrOrderMain = ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure(s.ssENOrderMain, config);
  }
}

public static RC_1583d548420c231ffb93458312800446 ToStructure(ssConectaProveedores.RestRecords.RESTRC_1583d548420c231ffb93458312800446 obj) { 
  RC_1583d548420c231ffb93458312800446 s = new RC_1583d548420c231ffb93458312800446();
  if(obj != null) {
  s.ssENOrderMain = ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.ToStructure(obj.AttrOrderMain);
  }
  return s;
}

public static Func<RC_1583d548420c231ffb93458312800446, ssConectaProveedores.RestRecords.RESTRC_1583d548420c231ffb93458312800446> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_1583d548420c231ffb93458312800446 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_1583d548420c231ffb93458312800446 FromStructure(RC_1583d548420c231ffb93458312800446 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_1583d548420c231ffb93458312800446(s, config);
}

}


