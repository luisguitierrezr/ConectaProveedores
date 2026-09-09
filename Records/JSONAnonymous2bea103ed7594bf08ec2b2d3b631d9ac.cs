using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderResultRecord
public class JSONRC_6328ceb8eefbea788ac97a92ce1c3549 : AbstractRESTStructure<RC_6328ceb8eefbea788ac97a92ce1c3549> {
[JsonProperty("OrderResult")]
[JsonPropertyName("OrderResult")]
public ssConectaProveedores.RestRecords.JSONST_5a17d82af8397abda9cf3915ce9c082fStructure AttrOrderResult;

public JSONRC_6328ceb8eefbea788ac97a92ce1c3549() { }

public JSONRC_6328ceb8eefbea788ac97a92ce1c3549 (RC_6328ceb8eefbea788ac97a92ce1c3549 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderResult = ConvertToRestWithoutDefaults(s.ssSTOrderResult, new ST_5a17d82af8397abda9cf3915ce9c082fStructure(), ssConectaProveedores.RestRecords.JSONST_5a17d82af8397abda9cf3915ce9c082fStructure.FromStructure, config);
  } else {
AttrOrderResult = ssConectaProveedores.RestRecords.JSONST_5a17d82af8397abda9cf3915ce9c082fStructure.FromStructure(s.ssSTOrderResult, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_6328ceb8eefbea788ac97a92ce1c3549, RC_6328ceb8eefbea788ac97a92ce1c3549> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_6328ceb8eefbea788ac97a92ce1c3549 s) => ToStructure(s, config);
}
public static RC_6328ceb8eefbea788ac97a92ce1c3549 ToStructure(ssConectaProveedores.RestRecords.JSONRC_6328ceb8eefbea788ac97a92ce1c3549 obj, IBehaviorsConfiguration config) { 
  RC_6328ceb8eefbea788ac97a92ce1c3549 s = new RC_6328ceb8eefbea788ac97a92ce1c3549();
  if(obj != null) {
  s.ssSTOrderResult = ssConectaProveedores.RestRecords.JSONST_5a17d82af8397abda9cf3915ce9c082fStructure.ToStructure(obj.AttrOrderResult, config);
  }
  return s;
}

public static Func<RC_6328ceb8eefbea788ac97a92ce1c3549, ssConectaProveedores.RestRecords.JSONRC_6328ceb8eefbea788ac97a92ce1c3549> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_6328ceb8eefbea788ac97a92ce1c3549 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_6328ceb8eefbea788ac97a92ce1c3549 FromStructure(RC_6328ceb8eefbea788ac97a92ce1c3549 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_6328ceb8eefbea788ac97a92ce1c3549(s, config);
}

}


