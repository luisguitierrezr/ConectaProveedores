using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// File2
public class JSONSTFileStructure : AbstractRESTStructure<STFileStructure> {
[JsonProperty("Name")]
[JsonPropertyName("Name")]
public string AttrName;

[JsonProperty("IsDirectory")]
[JsonPropertyName("IsDirectory")]
public bool? AttrIsDirectory;

[JsonProperty("DateTime")]
[JsonPropertyName("DateTime")]
public String AttrDateTime;

[JsonProperty("Size")]
[JsonPropertyName("Size")]
public int? AttrSize;

[JsonProperty("CompressedSize")]
[JsonPropertyName("CompressedSize")]
public int? AttrCompressedSize;

[JsonProperty("Content")]
[JsonPropertyName("Content")]
public byte[] AttrContent;

public JSONSTFileStructure() { }

public JSONSTFileStructure (STFileStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrName = s.ssName;
AttrIsDirectory = (bool?) s.ssIsDirectory;
AttrDateTime = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssDateTime, config.DateTimeFormat);
AttrSize = (int?) s.ssSize;
AttrCompressedSize = (int?) s.ssCompressedSize;
AttrContent = s.ssContent;
  } else {
AttrName = s.ssName;
AttrIsDirectory = (bool?) s.ssIsDirectory;
AttrDateTime = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssDateTime, config.DateTimeFormat);
AttrSize = (int?) s.ssSize;
AttrCompressedSize = (int?) s.ssCompressedSize;
AttrContent = s.ssContent;
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONSTFileStructure, STFileStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONSTFileStructure s) => ToStructure(s, config);
}
public static STFileStructure ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONSTFileStructure obj, IBehaviorsConfiguration config) { 
  STFileStructure s = new STFileStructure();
  if(obj != null) {
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  s.ssIsDirectory = obj.AttrIsDirectory == null ? false : obj.AttrIsDirectory.Value;
  s.ssDateTime = obj.AttrDateTime == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrDateTime, config.DateTimeFormat);
  s.ssSize = obj.AttrSize == null ? 0 : obj.AttrSize.Value;
  s.ssCompressedSize = obj.AttrCompressedSize == null ? 0 : obj.AttrCompressedSize.Value;
  s.ssContent = obj.AttrContent == null ? new byte[] {} : obj.AttrContent;
  }
  return s;
}

public static Func<STFileStructure, ssConectaProveedores.ReferencesProxy.RestRecords.JSONSTFileStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (STFileStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONSTFileStructure FromStructure(STFileStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONSTFileStructure(s, config);
}

}


