using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// BooleanRecord
public class JSONRC_d200060d081b41826672020864051a96 : AbstractRESTStructure<RC_d200060d081b41826672020864051a96> {
[JsonProperty("Boolean")]
[JsonPropertyName("Boolean")]
public ssConectaProveedores.RestRecords.JSONST_b6d345dd13582e4e92d7108f300179feStructure AttrBoolean;

public JSONRC_d200060d081b41826672020864051a96() { }

public JSONRC_d200060d081b41826672020864051a96 (RC_d200060d081b41826672020864051a96 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrBoolean = ConvertToRestWithoutDefaults(s.ssSTBoolean, new ST_b6d345dd13582e4e92d7108f300179feStructure(), ssConectaProveedores.RestRecords.JSONST_b6d345dd13582e4e92d7108f300179feStructure.FromStructure, config);
  } else {
AttrBoolean = ssConectaProveedores.RestRecords.JSONST_b6d345dd13582e4e92d7108f300179feStructure.FromStructure(s.ssSTBoolean, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_d200060d081b41826672020864051a96, RC_d200060d081b41826672020864051a96> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_d200060d081b41826672020864051a96 s) => ToStructure(s, config);
}
public static RC_d200060d081b41826672020864051a96 ToStructure(ssConectaProveedores.RestRecords.JSONRC_d200060d081b41826672020864051a96 obj, IBehaviorsConfiguration config) { 
  RC_d200060d081b41826672020864051a96 s = new RC_d200060d081b41826672020864051a96();
  if(obj != null) {
  s.ssSTBoolean = ssConectaProveedores.RestRecords.JSONST_b6d345dd13582e4e92d7108f300179feStructure.ToStructure(obj.AttrBoolean, config);
  }
  return s;
}

public static Func<RC_d200060d081b41826672020864051a96, ssConectaProveedores.RestRecords.JSONRC_d200060d081b41826672020864051a96> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_d200060d081b41826672020864051a96 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_d200060d081b41826672020864051a96 FromStructure(RC_d200060d081b41826672020864051a96 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_d200060d081b41826672020864051a96(s, config);
}

}


