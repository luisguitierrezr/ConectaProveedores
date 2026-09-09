using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// VideoOptionalConfigsRecord
public class RESTRC_85af8fa7a4c9fca4ade94e1edb0d5f7d : AbstractRESTStructure<RC_85af8fa7a4c9fca4ade94e1edb0d5f7d> {
[JsonProperty("VideoOptionalConfigs")]
public ssConectaProveedores.RestRecords.RESTST_6510d2524fe77fcc6c285159d4000cfbStructure AttrVideoOptionalConfigs;

public RESTRC_85af8fa7a4c9fca4ade94e1edb0d5f7d() { }

public RESTRC_85af8fa7a4c9fca4ade94e1edb0d5f7d (RC_85af8fa7a4c9fca4ade94e1edb0d5f7d s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrVideoOptionalConfigs = ConvertToRestWithoutDefaults(s.ssSTVideoOptionalConfigs, new ST_6510d2524fe77fcc6c285159d4000cfbStructure(), ssConectaProveedores.RestRecords.RESTST_6510d2524fe77fcc6c285159d4000cfbStructure.FromStructure, config);
  } else {
AttrVideoOptionalConfigs = ssConectaProveedores.RestRecords.RESTST_6510d2524fe77fcc6c285159d4000cfbStructure.FromStructure(s.ssSTVideoOptionalConfigs, config);
  }
}

public static RC_85af8fa7a4c9fca4ade94e1edb0d5f7d ToStructure(ssConectaProveedores.RestRecords.RESTRC_85af8fa7a4c9fca4ade94e1edb0d5f7d obj) { 
  RC_85af8fa7a4c9fca4ade94e1edb0d5f7d s = new RC_85af8fa7a4c9fca4ade94e1edb0d5f7d();
  if(obj != null) {
  s.ssSTVideoOptionalConfigs = ssConectaProveedores.RestRecords.RESTST_6510d2524fe77fcc6c285159d4000cfbStructure.ToStructure(obj.AttrVideoOptionalConfigs);
  }
  return s;
}

public static Func<RC_85af8fa7a4c9fca4ade94e1edb0d5f7d, ssConectaProveedores.RestRecords.RESTRC_85af8fa7a4c9fca4ade94e1edb0d5f7d> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_85af8fa7a4c9fca4ade94e1edb0d5f7d s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_85af8fa7a4c9fca4ade94e1edb0d5f7d FromStructure(RC_85af8fa7a4c9fca4ade94e1edb0d5f7d s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_85af8fa7a4c9fca4ade94e1edb0d5f7d(s, config);
}

}


