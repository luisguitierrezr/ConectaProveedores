using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// File2
public class RESTSTFileStructure : AbstractRESTStructure<STFileStructure> {
[JsonProperty("Name")]
public string AttrName;

[JsonProperty("IsDirectory")]
public bool? AttrIsDirectory;

[JsonProperty("DateTime")]
public String AttrDateTime;

[JsonProperty("Size")]
public int? AttrSize;

[JsonProperty("CompressedSize")]
public int? AttrCompressedSize;

[JsonProperty("Content")]
public byte[] AttrContent;

public RESTSTFileStructure() { }

public RESTSTFileStructure (STFileStructure s, IBehaviorsConfiguration config) {
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

public static STFileStructure ToStructure(ssConectaProveedores.RestRecords.RESTSTFileStructure obj) { 
  STFileStructure s = new STFileStructure();
  if(obj != null) {
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  s.ssIsDirectory = obj.AttrIsDirectory == null ? false : obj.AttrIsDirectory.Value;
  s.ssDateTime = obj.AttrDateTime == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrDateTime, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssSize = obj.AttrSize == null ? 0 : obj.AttrSize.Value;
  s.ssCompressedSize = obj.AttrCompressedSize == null ? 0 : obj.AttrCompressedSize.Value;
  s.ssContent = obj.AttrContent == null ? new byte[] {} : obj.AttrContent;
  }
  return s;
}

public static Func<STFileStructure, ssConectaProveedores.RestRecords.RESTSTFileStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (STFileStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTSTFileStructure FromStructure(STFileStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTSTFileStructure(s, config);
}

}


