using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RoleNameRecord
public class JSONRC_53b91594846c82c8b6761c8e124bc2f9 : AbstractRESTStructure<RC_53b91594846c82c8b6761c8e124bc2f9> {
[JsonProperty("RoleName")]
[JsonPropertyName("RoleName")]
public string AttrRoleName;

public JSONRC_53b91594846c82c8b6761c8e124bc2f9() { }

public JSONRC_53b91594846c82c8b6761c8e124bc2f9 (RC_53b91594846c82c8b6761c8e124bc2f9 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRoleName = ConvertToRestWithoutDefaults(s.ssRoleName, "");
  } else {
AttrRoleName = s.ssRoleName;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_53b91594846c82c8b6761c8e124bc2f9, RC_53b91594846c82c8b6761c8e124bc2f9> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_53b91594846c82c8b6761c8e124bc2f9 s) => ToStructure(s, config);
}
public static RC_53b91594846c82c8b6761c8e124bc2f9 ToStructure(ssConectaProveedores.RestRecords.JSONRC_53b91594846c82c8b6761c8e124bc2f9 obj, IBehaviorsConfiguration config) { 
  RC_53b91594846c82c8b6761c8e124bc2f9 s = new RC_53b91594846c82c8b6761c8e124bc2f9();
  if(obj != null) {
  s.ssRoleName = obj.AttrRoleName == null ? "" : obj.AttrRoleName;
  }
  return s;
}

public static Func<RC_53b91594846c82c8b6761c8e124bc2f9, ssConectaProveedores.RestRecords.JSONRC_53b91594846c82c8b6761c8e124bc2f9> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_53b91594846c82c8b6761c8e124bc2f9 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_53b91594846c82c8b6761c8e124bc2f9 FromStructure(RC_53b91594846c82c8b6761c8e124bc2f9 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_53b91594846c82c8b6761c8e124bc2f9(s, config);
}

}


