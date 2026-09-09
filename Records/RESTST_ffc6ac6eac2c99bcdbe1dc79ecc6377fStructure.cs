using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// VideoCaptions
public class RESTST_ffc6ac6eac2c99bcdbe1dc79ecc6377fStructure : AbstractRESTStructure<ST_ffc6ac6eac2c99bcdbe1dc79ecc6377fStructure> {
[JsonProperty("LanguageCode")]
public string AttrLanguageCode;

[JsonProperty("SourceFile")]
public string AttrSourceFile;

[JsonProperty("Label")]
public string AttrLabel;

public RESTST_ffc6ac6eac2c99bcdbe1dc79ecc6377fStructure() { }

public RESTST_ffc6ac6eac2c99bcdbe1dc79ecc6377fStructure (ST_ffc6ac6eac2c99bcdbe1dc79ecc6377fStructure s, IBehaviorsConfiguration config) {
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

public static ST_ffc6ac6eac2c99bcdbe1dc79ecc6377fStructure ToStructure(ssConectaProveedores.RestRecords.RESTST_ffc6ac6eac2c99bcdbe1dc79ecc6377fStructure obj) { 
  ST_ffc6ac6eac2c99bcdbe1dc79ecc6377fStructure s = new ST_ffc6ac6eac2c99bcdbe1dc79ecc6377fStructure();
  if(obj != null) {
  s.ssLanguageCode = obj.AttrLanguageCode == null ? "" : obj.AttrLanguageCode;
  s.ssSourceFile = obj.AttrSourceFile == null ? "" : obj.AttrSourceFile;
  s.ssLabel = obj.AttrLabel == null ? "" : obj.AttrLabel;
  }
  return s;
}

public static Func<ST_ffc6ac6eac2c99bcdbe1dc79ecc6377fStructure, ssConectaProveedores.RestRecords.RESTST_ffc6ac6eac2c99bcdbe1dc79ecc6377fStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_ffc6ac6eac2c99bcdbe1dc79ecc6377fStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_ffc6ac6eac2c99bcdbe1dc79ecc6377fStructure FromStructure(ST_ffc6ac6eac2c99bcdbe1dc79ecc6377fStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_ffc6ac6eac2c99bcdbe1dc79ecc6377fStructure(s, config);
}

}


