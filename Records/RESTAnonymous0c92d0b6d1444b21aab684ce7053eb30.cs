using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RoleNameRecord
public class RESTRC_53b91594846c82c8b6761c8e124bc2f9 : AbstractRESTStructure<RC_53b91594846c82c8b6761c8e124bc2f9> {
[JsonProperty("RoleName")]
public string AttrRoleName;

public RESTRC_53b91594846c82c8b6761c8e124bc2f9() { }

public RESTRC_53b91594846c82c8b6761c8e124bc2f9 (RC_53b91594846c82c8b6761c8e124bc2f9 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRoleName = ConvertToRestWithoutDefaults(s.ssRoleName, "");
  } else {
AttrRoleName = s.ssRoleName;
  }
}

public static RC_53b91594846c82c8b6761c8e124bc2f9 ToStructure(ssConectaProveedores.RestRecords.RESTRC_53b91594846c82c8b6761c8e124bc2f9 obj) { 
  RC_53b91594846c82c8b6761c8e124bc2f9 s = new RC_53b91594846c82c8b6761c8e124bc2f9();
  if(obj != null) {
  s.ssRoleName = obj.AttrRoleName == null ? "" : obj.AttrRoleName;
  }
  return s;
}

public static Func<RC_53b91594846c82c8b6761c8e124bc2f9, ssConectaProveedores.RestRecords.RESTRC_53b91594846c82c8b6761c8e124bc2f9> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_53b91594846c82c8b6761c8e124bc2f9 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_53b91594846c82c8b6761c8e124bc2f9 FromStructure(RC_53b91594846c82c8b6761c8e124bc2f9 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_53b91594846c82c8b6761c8e124bc2f9(s, config);
}

}


