using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// EmailEntraIdNameRoleRecord
public class RESTRC_18c2d75e8e190384e64859e7ed1d4f00 : AbstractRESTStructure<RC_18c2d75e8e190384e64859e7ed1d4f00> {
[JsonProperty("Email")]
public string AttrEmail;

[JsonProperty("EntraId")]
public string AttrEntraId;

[JsonProperty("Name")]
public string AttrName;

[JsonProperty("Role")]
public string AttrRole;

public RESTRC_18c2d75e8e190384e64859e7ed1d4f00() { }

public RESTRC_18c2d75e8e190384e64859e7ed1d4f00 (RC_18c2d75e8e190384e64859e7ed1d4f00 s, IBehaviorsConfiguration config) {
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

public static RC_18c2d75e8e190384e64859e7ed1d4f00 ToStructure(ssConectaProveedores.RestRecords.RESTRC_18c2d75e8e190384e64859e7ed1d4f00 obj) { 
  RC_18c2d75e8e190384e64859e7ed1d4f00 s = new RC_18c2d75e8e190384e64859e7ed1d4f00();
  if(obj != null) {
  s.ssEmail = obj.AttrEmail == null ? "" : obj.AttrEmail;
  s.ssEntraId = obj.AttrEntraId == null ? "" : obj.AttrEntraId;
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  s.ssRole = obj.AttrRole == null ? "" : obj.AttrRole;
  }
  return s;
}

public static Func<RC_18c2d75e8e190384e64859e7ed1d4f00, ssConectaProveedores.RestRecords.RESTRC_18c2d75e8e190384e64859e7ed1d4f00> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_18c2d75e8e190384e64859e7ed1d4f00 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_18c2d75e8e190384e64859e7ed1d4f00 FromStructure(RC_18c2d75e8e190384e64859e7ed1d4f00 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_18c2d75e8e190384e64859e7ed1d4f00(s, config);
}

}


