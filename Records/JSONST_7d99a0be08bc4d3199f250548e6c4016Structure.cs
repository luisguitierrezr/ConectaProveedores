using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// DirectReports
public class JSONST_7d99a0be08bc4d3199f250548e6c4016Structure : AbstractRESTStructure<ST_7d99a0be08bc4d3199f250548e6c4016Structure> {
[JsonProperty("UserId")]
[JsonPropertyName("UserId")]
public string AttrUserId;

[JsonProperty("Name")]
[JsonPropertyName("Name")]
public string AttrName;

[JsonProperty("Role")]
[JsonPropertyName("Role")]
public string AttrRole;

[JsonProperty("EntraId")]
[JsonPropertyName("EntraId")]
public string AttrEntraId;

[JsonProperty("Email")]
[JsonPropertyName("Email")]
public string AttrEmail;

[JsonProperty("Level")]
[JsonPropertyName("Level")]
public int? AttrLevel;

public JSONST_7d99a0be08bc4d3199f250548e6c4016Structure() { }

public JSONST_7d99a0be08bc4d3199f250548e6c4016Structure (ST_7d99a0be08bc4d3199f250548e6c4016Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUserId = ConvertToRestWithoutDefaults(s.ssUserId, "");
AttrName = ConvertToRestWithoutDefaults(s.ssName, "");
AttrRole = ConvertToRestWithoutDefaults(s.ssRole, "");
AttrEntraId = ConvertToRestWithoutDefaults(s.ssEntraId, "");
AttrEmail = ConvertToRestWithoutDefaults(s.ssEmail, "");
AttrLevel = ConvertToRestWithoutDefaults(s.ssLevel, 0);
  } else {
AttrUserId = s.ssUserId;
AttrName = s.ssName;
AttrRole = s.ssRole;
AttrEntraId = s.ssEntraId;
AttrEmail = s.ssEmail;
AttrLevel = (int?) s.ssLevel;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_7d99a0be08bc4d3199f250548e6c4016Structure, ST_7d99a0be08bc4d3199f250548e6c4016Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_7d99a0be08bc4d3199f250548e6c4016Structure s) => ToStructure(s, config);
}
public static ST_7d99a0be08bc4d3199f250548e6c4016Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_7d99a0be08bc4d3199f250548e6c4016Structure obj, IBehaviorsConfiguration config) { 
  ST_7d99a0be08bc4d3199f250548e6c4016Structure s = new ST_7d99a0be08bc4d3199f250548e6c4016Structure();
  if(obj != null) {
  s.ssUserId = obj.AttrUserId == null ? "" : obj.AttrUserId;
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  s.ssRole = obj.AttrRole == null ? "" : obj.AttrRole;
  s.ssEntraId = obj.AttrEntraId == null ? "" : obj.AttrEntraId;
  s.ssEmail = obj.AttrEmail == null ? "" : obj.AttrEmail;
  s.ssLevel = obj.AttrLevel == null ? 0 : obj.AttrLevel.Value;
  }
  return s;
}

public static Func<ST_7d99a0be08bc4d3199f250548e6c4016Structure, ssConectaProveedores.RestRecords.JSONST_7d99a0be08bc4d3199f250548e6c4016Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_7d99a0be08bc4d3199f250548e6c4016Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_7d99a0be08bc4d3199f250548e6c4016Structure FromStructure(ST_7d99a0be08bc4d3199f250548e6c4016Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_7d99a0be08bc4d3199f250548e6c4016Structure(s, config);
}

}


