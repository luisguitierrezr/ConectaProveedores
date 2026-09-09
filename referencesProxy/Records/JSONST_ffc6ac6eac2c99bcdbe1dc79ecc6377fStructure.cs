using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// VideoCaptions
public class JSONST_ffc6ac6eac2c99bcdbe1dc79ecc6377fStructure : AbstractRESTStructure<ST_ffc6ac6eac2c99bcdbe1dc79ecc6377fStructure> {
[JsonProperty("LanguageCode")]
[JsonPropertyName("LanguageCode")]
public string AttrLanguageCode;

[JsonProperty("SourceFile")]
[JsonPropertyName("SourceFile")]
public string AttrSourceFile;

[JsonProperty("Label")]
[JsonPropertyName("Label")]
public string AttrLabel;

public JSONST_ffc6ac6eac2c99bcdbe1dc79ecc6377fStructure() { }

public JSONST_ffc6ac6eac2c99bcdbe1dc79ecc6377fStructure (ST_ffc6ac6eac2c99bcdbe1dc79ecc6377fStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrLanguageCode = ConvertToRestWithoutDefaults(s.ssLanguageCode, "");
AttrSourceFile = ConvertToRestWithoutDefaults(s.ssSourceFile, "");
AttrLabel = ConvertToRestWithoutDefaults(s.ssLabel, "");
  } else {
AttrLanguageCode = s.ssLanguageCode;
AttrSourceFile = s.ssSourceFile;
AttrLabel = s.ssLabel;
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_ffc6ac6eac2c99bcdbe1dc79ecc6377fStructure, ST_ffc6ac6eac2c99bcdbe1dc79ecc6377fStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_ffc6ac6eac2c99bcdbe1dc79ecc6377fStructure s) => ToStructure(s, config);
}
public static ST_ffc6ac6eac2c99bcdbe1dc79ecc6377fStructure ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_ffc6ac6eac2c99bcdbe1dc79ecc6377fStructure obj, IBehaviorsConfiguration config) { 
  ST_ffc6ac6eac2c99bcdbe1dc79ecc6377fStructure s = new ST_ffc6ac6eac2c99bcdbe1dc79ecc6377fStructure();
  if(obj != null) {
  s.ssLanguageCode = obj.AttrLanguageCode == null ? "" : obj.AttrLanguageCode;
  s.ssSourceFile = obj.AttrSourceFile == null ? "" : obj.AttrSourceFile;
  s.ssLabel = obj.AttrLabel == null ? "" : obj.AttrLabel;
  }
  return s;
}

public static Func<ST_ffc6ac6eac2c99bcdbe1dc79ecc6377fStructure, ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_ffc6ac6eac2c99bcdbe1dc79ecc6377fStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_ffc6ac6eac2c99bcdbe1dc79ecc6377fStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_ffc6ac6eac2c99bcdbe1dc79ecc6377fStructure FromStructure(ST_ffc6ac6eac2c99bcdbe1dc79ecc6377fStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_ffc6ac6eac2c99bcdbe1dc79ecc6377fStructure(s, config);
}

}


