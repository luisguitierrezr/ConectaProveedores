using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ErrorMessage2
public class JSONST_50c794173b7ac3485b1cda7be99f6b43Structure : AbstractRESTStructure<ST_50c794173b7ac3485b1cda7be99f6b43Structure> {
[JsonProperty("code")]
[JsonPropertyName("code")]
public string AttrCode;

[JsonProperty("message")]
[JsonPropertyName("message")]
public string AttrMessage;

public JSONST_50c794173b7ac3485b1cda7be99f6b43Structure() { }

public JSONST_50c794173b7ac3485b1cda7be99f6b43Structure (ST_50c794173b7ac3485b1cda7be99f6b43Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCode = ConvertToRestWithoutDefaults(s.ssCode, "");
AttrMessage = ConvertToRestWithoutDefaults(s.ssMessage, "");
  } else {
AttrCode = s.ssCode;
AttrMessage = s.ssMessage;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_50c794173b7ac3485b1cda7be99f6b43Structure, ST_50c794173b7ac3485b1cda7be99f6b43Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_50c794173b7ac3485b1cda7be99f6b43Structure s) => ToStructure(s, config);
}
public static ST_50c794173b7ac3485b1cda7be99f6b43Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_50c794173b7ac3485b1cda7be99f6b43Structure obj, IBehaviorsConfiguration config) { 
  ST_50c794173b7ac3485b1cda7be99f6b43Structure s = new ST_50c794173b7ac3485b1cda7be99f6b43Structure();
  if(obj != null) {
  s.ssCode = obj.AttrCode == null ? "" : obj.AttrCode;
  s.ssMessage = obj.AttrMessage == null ? "" : obj.AttrMessage;
  }
  return s;
}

public static Func<ST_50c794173b7ac3485b1cda7be99f6b43Structure, ssConectaProveedores.RestRecords.JSONST_50c794173b7ac3485b1cda7be99f6b43Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_50c794173b7ac3485b1cda7be99f6b43Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_50c794173b7ac3485b1cda7be99f6b43Structure FromStructure(ST_50c794173b7ac3485b1cda7be99f6b43Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_50c794173b7ac3485b1cda7be99f6b43Structure(s, config);
}

}


