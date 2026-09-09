using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// EmailEntraIdNameRoleRecord
public class JSONRC_18c2d75e8e190384e64859e7ed1d4f00 : AbstractRESTStructure<RC_18c2d75e8e190384e64859e7ed1d4f00> {
[JsonProperty("Email")]
[JsonPropertyName("Email")]
public string AttrEmail;

[JsonProperty("EntraId")]
[JsonPropertyName("EntraId")]
public string AttrEntraId;

[JsonProperty("Name")]
[JsonPropertyName("Name")]
public string AttrName;

[JsonProperty("Role")]
[JsonPropertyName("Role")]
public string AttrRole;

public JSONRC_18c2d75e8e190384e64859e7ed1d4f00() { }

public JSONRC_18c2d75e8e190384e64859e7ed1d4f00 (RC_18c2d75e8e190384e64859e7ed1d4f00 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrEmail = ConvertToRestWithoutDefaults(s.ssEmail, "");
AttrEntraId = ConvertToRestWithoutDefaults(s.ssEntraId, "");
AttrName = ConvertToRestWithoutDefaults(s.ssName, "");
AttrRole = ConvertToRestWithoutDefaults(s.ssRole, "");
  } else {
AttrEmail = s.ssEmail;
AttrEntraId = s.ssEntraId;
AttrName = s.ssName;
AttrRole = s.ssRole;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_18c2d75e8e190384e64859e7ed1d4f00, RC_18c2d75e8e190384e64859e7ed1d4f00> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_18c2d75e8e190384e64859e7ed1d4f00 s) => ToStructure(s, config);
}
public static RC_18c2d75e8e190384e64859e7ed1d4f00 ToStructure(ssConectaProveedores.RestRecords.JSONRC_18c2d75e8e190384e64859e7ed1d4f00 obj, IBehaviorsConfiguration config) { 
  RC_18c2d75e8e190384e64859e7ed1d4f00 s = new RC_18c2d75e8e190384e64859e7ed1d4f00();
  if(obj != null) {
  s.ssEmail = obj.AttrEmail == null ? "" : obj.AttrEmail;
  s.ssEntraId = obj.AttrEntraId == null ? "" : obj.AttrEntraId;
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  s.ssRole = obj.AttrRole == null ? "" : obj.AttrRole;
  }
  return s;
}

public static Func<RC_18c2d75e8e190384e64859e7ed1d4f00, ssConectaProveedores.RestRecords.JSONRC_18c2d75e8e190384e64859e7ed1d4f00> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_18c2d75e8e190384e64859e7ed1d4f00 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_18c2d75e8e190384e64859e7ed1d4f00 FromStructure(RC_18c2d75e8e190384e64859e7ed1d4f00 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_18c2d75e8e190384e64859e7ed1d4f00(s, config);
}

}


