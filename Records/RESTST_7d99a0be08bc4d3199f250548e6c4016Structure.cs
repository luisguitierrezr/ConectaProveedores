using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// DirectReports
public class RESTST_7d99a0be08bc4d3199f250548e6c4016Structure : AbstractRESTStructure<ST_7d99a0be08bc4d3199f250548e6c4016Structure> {
[JsonProperty("UserId")]
public string AttrUserId;

[JsonProperty("Name")]
public string AttrName;

[JsonProperty("Role")]
public string AttrRole;

[JsonProperty("EntraId")]
public string AttrEntraId;

[JsonProperty("Email")]
public string AttrEmail;

[JsonProperty("Level")]
public int? AttrLevel;

public RESTST_7d99a0be08bc4d3199f250548e6c4016Structure() { }

public RESTST_7d99a0be08bc4d3199f250548e6c4016Structure (ST_7d99a0be08bc4d3199f250548e6c4016Structure s, IBehaviorsConfiguration config) {
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

public static ST_7d99a0be08bc4d3199f250548e6c4016Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_7d99a0be08bc4d3199f250548e6c4016Structure obj) { 
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

public static Func<ST_7d99a0be08bc4d3199f250548e6c4016Structure, ssConectaProveedores.RestRecords.RESTST_7d99a0be08bc4d3199f250548e6c4016Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_7d99a0be08bc4d3199f250548e6c4016Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_7d99a0be08bc4d3199f250548e6c4016Structure FromStructure(ST_7d99a0be08bc4d3199f250548e6c4016Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_7d99a0be08bc4d3199f250548e6c4016Structure(s, config);
}

}


