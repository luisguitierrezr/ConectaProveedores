using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// BooleanRecord
public class RESTRC_d200060d081b41826672020864051a96 : AbstractRESTStructure<RC_d200060d081b41826672020864051a96> {
[JsonProperty("Boolean")]
public ssConectaProveedores.RestRecords.RESTST_b6d345dd13582e4e92d7108f300179feStructure AttrBoolean;

public RESTRC_d200060d081b41826672020864051a96() { }

public RESTRC_d200060d081b41826672020864051a96 (RC_d200060d081b41826672020864051a96 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrBoolean = ConvertToRestWithoutDefaults(s.ssSTBoolean, new ST_b6d345dd13582e4e92d7108f300179feStructure(), ssConectaProveedores.RestRecords.RESTST_b6d345dd13582e4e92d7108f300179feStructure.FromStructure, config);
  } else {
AttrBoolean = ssConectaProveedores.RestRecords.RESTST_b6d345dd13582e4e92d7108f300179feStructure.FromStructure(s.ssSTBoolean, config);
  }
}

public static RC_d200060d081b41826672020864051a96 ToStructure(ssConectaProveedores.RestRecords.RESTRC_d200060d081b41826672020864051a96 obj) { 
  RC_d200060d081b41826672020864051a96 s = new RC_d200060d081b41826672020864051a96();
  if(obj != null) {
  s.ssSTBoolean = ssConectaProveedores.RestRecords.RESTST_b6d345dd13582e4e92d7108f300179feStructure.ToStructure(obj.AttrBoolean);
  }
  return s;
}

public static Func<RC_d200060d081b41826672020864051a96, ssConectaProveedores.RestRecords.RESTRC_d200060d081b41826672020864051a96> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_d200060d081b41826672020864051a96 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_d200060d081b41826672020864051a96 FromStructure(RC_d200060d081b41826672020864051a96 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_d200060d081b41826672020864051a96(s, config);
}

}


