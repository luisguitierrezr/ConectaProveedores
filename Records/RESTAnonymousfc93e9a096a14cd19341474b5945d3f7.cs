using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// EM_COSMOZ_Response_StructRecord
public class RESTRC_3bbaaca91096ad8efe700794daaa8285 : AbstractRESTStructure<RC_3bbaaca91096ad8efe700794daaa8285> {
[JsonProperty("EM_COSMOZ_Response_Struct")]
public ssConectaProveedores.RestRecords.RESTST_5bf89f3eec4235b40802e9da4fd3e4afStructure AttrEM_COSMOZ_Response_Struct;

public RESTRC_3bbaaca91096ad8efe700794daaa8285() { }

public RESTRC_3bbaaca91096ad8efe700794daaa8285 (RC_3bbaaca91096ad8efe700794daaa8285 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrEM_COSMOZ_Response_Struct = ConvertToRestWithoutDefaults(s.ssSTEM_COSMOZ_Response_Struct, new ST_5bf89f3eec4235b40802e9da4fd3e4afStructure(), ssConectaProveedores.RestRecords.RESTST_5bf89f3eec4235b40802e9da4fd3e4afStructure.FromStructure, config);
  } else {
AttrEM_COSMOZ_Response_Struct = ssConectaProveedores.RestRecords.RESTST_5bf89f3eec4235b40802e9da4fd3e4afStructure.FromStructure(s.ssSTEM_COSMOZ_Response_Struct, config);
  }
}

public static RC_3bbaaca91096ad8efe700794daaa8285 ToStructure(ssConectaProveedores.RestRecords.RESTRC_3bbaaca91096ad8efe700794daaa8285 obj) { 
  RC_3bbaaca91096ad8efe700794daaa8285 s = new RC_3bbaaca91096ad8efe700794daaa8285();
  if(obj != null) {
  s.ssSTEM_COSMOZ_Response_Struct = ssConectaProveedores.RestRecords.RESTST_5bf89f3eec4235b40802e9da4fd3e4afStructure.ToStructure(obj.AttrEM_COSMOZ_Response_Struct);
  }
  return s;
}

public static Func<RC_3bbaaca91096ad8efe700794daaa8285, ssConectaProveedores.RestRecords.RESTRC_3bbaaca91096ad8efe700794daaa8285> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_3bbaaca91096ad8efe700794daaa8285 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_3bbaaca91096ad8efe700794daaa8285 FromStructure(RC_3bbaaca91096ad8efe700794daaa8285 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_3bbaaca91096ad8efe700794daaa8285(s, config);
}

}


