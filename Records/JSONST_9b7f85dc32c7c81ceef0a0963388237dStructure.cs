using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// PostCarganovimRequestWrapper
public class JSONST_9b7f85dc32c7c81ceef0a0963388237dStructure : AbstractRESTStructure<ST_9b7f85dc32c7c81ceef0a0963388237dStructure> {
[JsonProperty("cfdFile")]
[JsonPropertyName("cfdFile")]
public string AttrCfdFile;

[JsonProperty("sociedad")]
[JsonPropertyName("sociedad")]
public string AttrSociedad;

[JsonProperty("cveProveedor")]
[JsonPropertyName("cveProveedor")]
public string AttrCveProveedor;

[JsonProperty("fileName")]
[JsonPropertyName("fileName")]
public string AttrFileName;

[JsonProperty("docType")]
[JsonPropertyName("docType")]
public string AttrDocType;

[JsonProperty("region")]
[JsonPropertyName("region")]
public string AttrRegion;

public JSONST_9b7f85dc32c7c81ceef0a0963388237dStructure() { }

public JSONST_9b7f85dc32c7c81ceef0a0963388237dStructure (ST_9b7f85dc32c7c81ceef0a0963388237dStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCfdFile = ConvertToRestWithoutDefaults(s.ssCfdFile, "");
AttrSociedad = ConvertToRestWithoutDefaults(s.ssSociedad, "");
AttrCveProveedor = ConvertToRestWithoutDefaults(s.ssCveProveedor, "");
AttrFileName = ConvertToRestWithoutDefaults(s.ssFileName, "");
AttrDocType = ConvertToRestWithoutDefaults(s.ssDocType, "");
AttrRegion = ConvertToRestWithoutDefaults(s.ssRegion, "");
  } else {
AttrCfdFile = s.ssCfdFile;
AttrSociedad = s.ssSociedad;
AttrCveProveedor = s.ssCveProveedor;
AttrFileName = s.ssFileName;
AttrDocType = s.ssDocType;
AttrRegion = s.ssRegion;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_9b7f85dc32c7c81ceef0a0963388237dStructure, ST_9b7f85dc32c7c81ceef0a0963388237dStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_9b7f85dc32c7c81ceef0a0963388237dStructure s) => ToStructure(s, config);
}
public static ST_9b7f85dc32c7c81ceef0a0963388237dStructure ToStructure(ssConectaProveedores.RestRecords.JSONST_9b7f85dc32c7c81ceef0a0963388237dStructure obj, IBehaviorsConfiguration config) { 
  ST_9b7f85dc32c7c81ceef0a0963388237dStructure s = new ST_9b7f85dc32c7c81ceef0a0963388237dStructure();
  if(obj != null) {
  s.ssCfdFile = obj.AttrCfdFile == null ? "" : obj.AttrCfdFile;
  s.ssSociedad = obj.AttrSociedad == null ? "" : obj.AttrSociedad;
  s.ssCveProveedor = obj.AttrCveProveedor == null ? "" : obj.AttrCveProveedor;
  s.ssFileName = obj.AttrFileName == null ? "" : obj.AttrFileName;
  s.ssDocType = obj.AttrDocType == null ? "" : obj.AttrDocType;
  s.ssRegion = obj.AttrRegion == null ? "" : obj.AttrRegion;
  }
  return s;
}

public static Func<ST_9b7f85dc32c7c81ceef0a0963388237dStructure, ssConectaProveedores.RestRecords.JSONST_9b7f85dc32c7c81ceef0a0963388237dStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_9b7f85dc32c7c81ceef0a0963388237dStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_9b7f85dc32c7c81ceef0a0963388237dStructure FromStructure(ST_9b7f85dc32c7c81ceef0a0963388237dStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_9b7f85dc32c7c81ceef0a0963388237dStructure(s, config);
}

}


