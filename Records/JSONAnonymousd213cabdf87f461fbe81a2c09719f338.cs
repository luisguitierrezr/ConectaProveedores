using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// VideoOptionalConfigsRecord
public class JSONRC_85af8fa7a4c9fca4ade94e1edb0d5f7d : AbstractRESTStructure<RC_85af8fa7a4c9fca4ade94e1edb0d5f7d> {
[JsonProperty("VideoOptionalConfigs")]
[JsonPropertyName("VideoOptionalConfigs")]
public ssConectaProveedores.RestRecords.JSONST_6510d2524fe77fcc6c285159d4000cfbStructure AttrVideoOptionalConfigs;

public JSONRC_85af8fa7a4c9fca4ade94e1edb0d5f7d() { }

public JSONRC_85af8fa7a4c9fca4ade94e1edb0d5f7d (RC_85af8fa7a4c9fca4ade94e1edb0d5f7d s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrVideoOptionalConfigs = ConvertToRestWithoutDefaults(s.ssSTVideoOptionalConfigs, new ST_6510d2524fe77fcc6c285159d4000cfbStructure(), ssConectaProveedores.RestRecords.JSONST_6510d2524fe77fcc6c285159d4000cfbStructure.FromStructure, config);
  } else {
AttrVideoOptionalConfigs = ssConectaProveedores.RestRecords.JSONST_6510d2524fe77fcc6c285159d4000cfbStructure.FromStructure(s.ssSTVideoOptionalConfigs, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_85af8fa7a4c9fca4ade94e1edb0d5f7d, RC_85af8fa7a4c9fca4ade94e1edb0d5f7d> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_85af8fa7a4c9fca4ade94e1edb0d5f7d s) => ToStructure(s, config);
}
public static RC_85af8fa7a4c9fca4ade94e1edb0d5f7d ToStructure(ssConectaProveedores.RestRecords.JSONRC_85af8fa7a4c9fca4ade94e1edb0d5f7d obj, IBehaviorsConfiguration config) { 
  RC_85af8fa7a4c9fca4ade94e1edb0d5f7d s = new RC_85af8fa7a4c9fca4ade94e1edb0d5f7d();
  if(obj != null) {
  s.ssSTVideoOptionalConfigs = ssConectaProveedores.RestRecords.JSONST_6510d2524fe77fcc6c285159d4000cfbStructure.ToStructure(obj.AttrVideoOptionalConfigs, config);
  }
  return s;
}

public static Func<RC_85af8fa7a4c9fca4ade94e1edb0d5f7d, ssConectaProveedores.RestRecords.JSONRC_85af8fa7a4c9fca4ade94e1edb0d5f7d> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_85af8fa7a4c9fca4ade94e1edb0d5f7d s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_85af8fa7a4c9fca4ade94e1edb0d5f7d FromStructure(RC_85af8fa7a4c9fca4ade94e1edb0d5f7d s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_85af8fa7a4c9fca4ade94e1edb0d5f7d(s, config);
}

}


