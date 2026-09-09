using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OptionalConfigsRecord
public class RESTRC_83bc3ae4c5fec64bfa528e6320384107 : AbstractRESTStructure<RC_83bc3ae4c5fec64bfa528e6320384107> {
[JsonProperty("OptionalConfigs")]
public ssConectaProveedores.RestRecords.RESTST_d907e71360b734aa1ce657185862bd8bStructure AttrOptionalConfigs;

public RESTRC_83bc3ae4c5fec64bfa528e6320384107() { }

public RESTRC_83bc3ae4c5fec64bfa528e6320384107 (RC_83bc3ae4c5fec64bfa528e6320384107 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOptionalConfigs = ConvertToRestWithoutDefaults(s.ssSTOptionalConfigs, new ST_d907e71360b734aa1ce657185862bd8bStructure(), ssConectaProveedores.RestRecords.RESTST_d907e71360b734aa1ce657185862bd8bStructure.FromStructure, config);
  } else {
AttrOptionalConfigs = ssConectaProveedores.RestRecords.RESTST_d907e71360b734aa1ce657185862bd8bStructure.FromStructure(s.ssSTOptionalConfigs, config);
  }
}

public static RC_83bc3ae4c5fec64bfa528e6320384107 ToStructure(ssConectaProveedores.RestRecords.RESTRC_83bc3ae4c5fec64bfa528e6320384107 obj) { 
  RC_83bc3ae4c5fec64bfa528e6320384107 s = new RC_83bc3ae4c5fec64bfa528e6320384107();
  if(obj != null) {
  s.ssSTOptionalConfigs = ssConectaProveedores.RestRecords.RESTST_d907e71360b734aa1ce657185862bd8bStructure.ToStructure(obj.AttrOptionalConfigs);
  }
  return s;
}

public static Func<RC_83bc3ae4c5fec64bfa528e6320384107, ssConectaProveedores.RestRecords.RESTRC_83bc3ae4c5fec64bfa528e6320384107> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_83bc3ae4c5fec64bfa528e6320384107 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_83bc3ae4c5fec64bfa528e6320384107 FromStructure(RC_83bc3ae4c5fec64bfa528e6320384107 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_83bc3ae4c5fec64bfa528e6320384107(s, config);
}

}


