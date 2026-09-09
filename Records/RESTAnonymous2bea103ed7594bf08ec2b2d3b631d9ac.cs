using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderResultRecord
public class RESTRC_6328ceb8eefbea788ac97a92ce1c3549 : AbstractRESTStructure<RC_6328ceb8eefbea788ac97a92ce1c3549> {
[JsonProperty("OrderResult")]
public ssConectaProveedores.RestRecords.RESTST_5a17d82af8397abda9cf3915ce9c082fStructure AttrOrderResult;

public RESTRC_6328ceb8eefbea788ac97a92ce1c3549() { }

public RESTRC_6328ceb8eefbea788ac97a92ce1c3549 (RC_6328ceb8eefbea788ac97a92ce1c3549 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderResult = ConvertToRestWithoutDefaults(s.ssSTOrderResult, new ST_5a17d82af8397abda9cf3915ce9c082fStructure(), ssConectaProveedores.RestRecords.RESTST_5a17d82af8397abda9cf3915ce9c082fStructure.FromStructure, config);
  } else {
AttrOrderResult = ssConectaProveedores.RestRecords.RESTST_5a17d82af8397abda9cf3915ce9c082fStructure.FromStructure(s.ssSTOrderResult, config);
  }
}

public static RC_6328ceb8eefbea788ac97a92ce1c3549 ToStructure(ssConectaProveedores.RestRecords.RESTRC_6328ceb8eefbea788ac97a92ce1c3549 obj) { 
  RC_6328ceb8eefbea788ac97a92ce1c3549 s = new RC_6328ceb8eefbea788ac97a92ce1c3549();
  if(obj != null) {
  s.ssSTOrderResult = ssConectaProveedores.RestRecords.RESTST_5a17d82af8397abda9cf3915ce9c082fStructure.ToStructure(obj.AttrOrderResult);
  }
  return s;
}

public static Func<RC_6328ceb8eefbea788ac97a92ce1c3549, ssConectaProveedores.RestRecords.RESTRC_6328ceb8eefbea788ac97a92ce1c3549> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_6328ceb8eefbea788ac97a92ce1c3549 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_6328ceb8eefbea788ac97a92ce1c3549 FromStructure(RC_6328ceb8eefbea788ac97a92ce1c3549 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_6328ceb8eefbea788ac97a92ce1c3549(s, config);
}

}


