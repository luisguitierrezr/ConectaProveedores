using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// PostCarganovimResponseWrapper
public class JSONST_6636acdf9f49922edfd43b4865475460Structure : AbstractRESTStructure<ST_6636acdf9f49922edfd43b4865475460Structure> {
[JsonProperty("code")]
[JsonPropertyName("code")]
public long? AttrCode;

[JsonProperty("message")]
[JsonPropertyName("message")]
public string AttrMessage;

[JsonProperty("cargaCFDResult")]
[JsonPropertyName("cargaCFDResult")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_3feabb059aa2546826b3076d3b237751Structure AttrCargaCFDResult;

[JsonProperty("cfdFile")]
[JsonPropertyName("cfdFile")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_1e51b813a2c6a26cea1c6c8c17329da8Structure AttrCfdFile;

public JSONST_6636acdf9f49922edfd43b4865475460Structure() { }

public JSONST_6636acdf9f49922edfd43b4865475460Structure (ST_6636acdf9f49922edfd43b4865475460Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCode = ConvertToRestWithoutDefaults(s.ssCode, 0L);
AttrMessage = ConvertToRestWithoutDefaults(s.ssMessage, "");
AttrCargaCFDResult = ConvertToRestWithoutDefaults(s.ssCargaCFDResult, new ST_3feabb059aa2546826b3076d3b237751Structure(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_3feabb059aa2546826b3076d3b237751Structure.FromStructure, config);
AttrCfdFile = ConvertToRestWithoutDefaults(s.ssCfdFile, new ST_1e51b813a2c6a26cea1c6c8c17329da8Structure(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_1e51b813a2c6a26cea1c6c8c17329da8Structure.FromStructure, config);
  } else {
AttrCode = (long?) s.ssCode;
AttrMessage = s.ssMessage;
AttrCargaCFDResult = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_3feabb059aa2546826b3076d3b237751Structure.FromStructure(s.ssCargaCFDResult, config);
AttrCfdFile = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_1e51b813a2c6a26cea1c6c8c17329da8Structure.FromStructure(s.ssCfdFile, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_6636acdf9f49922edfd43b4865475460Structure, ST_6636acdf9f49922edfd43b4865475460Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_6636acdf9f49922edfd43b4865475460Structure s) => ToStructure(s, config);
}
public static ST_6636acdf9f49922edfd43b4865475460Structure ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_6636acdf9f49922edfd43b4865475460Structure obj, IBehaviorsConfiguration config) { 
  ST_6636acdf9f49922edfd43b4865475460Structure s = new ST_6636acdf9f49922edfd43b4865475460Structure();
  if(obj != null) {
  s.ssCode = obj.AttrCode == null ? 0L : obj.AttrCode.Value;
  s.ssMessage = obj.AttrMessage == null ? "" : obj.AttrMessage;
  s.ssCargaCFDResult = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_3feabb059aa2546826b3076d3b237751Structure.ToStructure(obj.AttrCargaCFDResult, config);
  s.ssCfdFile = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_1e51b813a2c6a26cea1c6c8c17329da8Structure.ToStructure(obj.AttrCfdFile, config);
  }
  return s;
}

public static Func<ST_6636acdf9f49922edfd43b4865475460Structure, ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_6636acdf9f49922edfd43b4865475460Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_6636acdf9f49922edfd43b4865475460Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_6636acdf9f49922edfd43b4865475460Structure FromStructure(ST_6636acdf9f49922edfd43b4865475460Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_6636acdf9f49922edfd43b4865475460Structure(s, config);
}

}


