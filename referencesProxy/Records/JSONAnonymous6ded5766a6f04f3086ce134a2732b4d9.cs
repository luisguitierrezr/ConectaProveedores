using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// OptionalConfigsRecord
public class JSONRC_83bc3ae4c5fec64bfa528e6320384107 : AbstractRESTStructure<RC_83bc3ae4c5fec64bfa528e6320384107> {
[JsonProperty("OptionalConfigs")]
[JsonPropertyName("OptionalConfigs")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_d907e71360b734aa1ce657185862bd8bStructure AttrOptionalConfigs;

public JSONRC_83bc3ae4c5fec64bfa528e6320384107() { }

public JSONRC_83bc3ae4c5fec64bfa528e6320384107 (RC_83bc3ae4c5fec64bfa528e6320384107 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOptionalConfigs = ConvertToRestWithoutDefaults(s.ssSTOptionalConfigs, new ST_d907e71360b734aa1ce657185862bd8bStructure(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_d907e71360b734aa1ce657185862bd8bStructure.FromStructure, config);
  } else {
AttrOptionalConfigs = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_d907e71360b734aa1ce657185862bd8bStructure.FromStructure(s.ssSTOptionalConfigs, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_83bc3ae4c5fec64bfa528e6320384107, RC_83bc3ae4c5fec64bfa528e6320384107> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_83bc3ae4c5fec64bfa528e6320384107 s) => ToStructure(s, config);
}
public static RC_83bc3ae4c5fec64bfa528e6320384107 ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_83bc3ae4c5fec64bfa528e6320384107 obj, IBehaviorsConfiguration config) { 
  RC_83bc3ae4c5fec64bfa528e6320384107 s = new RC_83bc3ae4c5fec64bfa528e6320384107();
  if(obj != null) {
  s.ssSTOptionalConfigs = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_d907e71360b734aa1ce657185862bd8bStructure.ToStructure(obj.AttrOptionalConfigs, config);
  }
  return s;
}

public static Func<RC_83bc3ae4c5fec64bfa528e6320384107, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_83bc3ae4c5fec64bfa528e6320384107> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_83bc3ae4c5fec64bfa528e6320384107 s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_83bc3ae4c5fec64bfa528e6320384107 FromStructure(RC_83bc3ae4c5fec64bfa528e6320384107 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_83bc3ae4c5fec64bfa528e6320384107(s, config);
}

}


