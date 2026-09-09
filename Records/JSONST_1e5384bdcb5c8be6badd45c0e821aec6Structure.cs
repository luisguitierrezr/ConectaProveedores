using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// PostValidacfdiprovRequestWrapper
public class JSONST_1e5384bdcb5c8be6badd45c0e821aec6Structure : AbstractRESTStructure<ST_1e5384bdcb5c8be6badd45c0e821aec6Structure> {
[JsonProperty("sociedad")]
[JsonPropertyName("sociedad")]
public string AttrSociedad;

[JsonProperty("cfdFile")]
[JsonPropertyName("cfdFile")]
public string AttrCfdFile;

public JSONST_1e5384bdcb5c8be6badd45c0e821aec6Structure() { }

public JSONST_1e5384bdcb5c8be6badd45c0e821aec6Structure (ST_1e5384bdcb5c8be6badd45c0e821aec6Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSociedad = ConvertToRestWithoutDefaults(s.ssSociedad, "");
AttrCfdFile = ConvertToRestWithoutDefaults(s.ssCfdFile, "");
  } else {
AttrSociedad = s.ssSociedad;
AttrCfdFile = s.ssCfdFile;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_1e5384bdcb5c8be6badd45c0e821aec6Structure, ST_1e5384bdcb5c8be6badd45c0e821aec6Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_1e5384bdcb5c8be6badd45c0e821aec6Structure s) => ToStructure(s, config);
}
public static ST_1e5384bdcb5c8be6badd45c0e821aec6Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_1e5384bdcb5c8be6badd45c0e821aec6Structure obj, IBehaviorsConfiguration config) { 
  ST_1e5384bdcb5c8be6badd45c0e821aec6Structure s = new ST_1e5384bdcb5c8be6badd45c0e821aec6Structure();
  if(obj != null) {
  s.ssSociedad = obj.AttrSociedad == null ? "" : obj.AttrSociedad;
  s.ssCfdFile = obj.AttrCfdFile == null ? "" : obj.AttrCfdFile;
  }
  return s;
}

public static Func<ST_1e5384bdcb5c8be6badd45c0e821aec6Structure, ssConectaProveedores.RestRecords.JSONST_1e5384bdcb5c8be6badd45c0e821aec6Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_1e5384bdcb5c8be6badd45c0e821aec6Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_1e5384bdcb5c8be6badd45c0e821aec6Structure FromStructure(ST_1e5384bdcb5c8be6badd45c0e821aec6Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_1e5384bdcb5c8be6badd45c0e821aec6Structure(s, config);
}

}


