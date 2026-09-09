using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// PostCarganovimResponseWrapper
public class RESTST_6636acdf9f49922edfd43b4865475460Structure : AbstractRESTStructure<ST_6636acdf9f49922edfd43b4865475460Structure> {
[JsonProperty("Code")]
public long? AttrCode;

[JsonProperty("Message")]
public string AttrMessage;

[JsonProperty("CargaCFDResult")]
public ssConectaProveedores.RestRecords.RESTST_3feabb059aa2546826b3076d3b237751Structure AttrCargaCFDResult;

[JsonProperty("CfdFile")]
public ssConectaProveedores.RestRecords.RESTST_1e51b813a2c6a26cea1c6c8c17329da8Structure AttrCfdFile;

public RESTST_6636acdf9f49922edfd43b4865475460Structure() { }

public RESTST_6636acdf9f49922edfd43b4865475460Structure (ST_6636acdf9f49922edfd43b4865475460Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCode = ConvertToRestWithoutDefaults(s.ssCode, 0L);
AttrMessage = ConvertToRestWithoutDefaults(s.ssMessage, "");
AttrCargaCFDResult = ConvertToRestWithoutDefaults(s.ssCargaCFDResult, new ST_3feabb059aa2546826b3076d3b237751Structure(), ssConectaProveedores.RestRecords.RESTST_3feabb059aa2546826b3076d3b237751Structure.FromStructure, config);
AttrCfdFile = ConvertToRestWithoutDefaults(s.ssCfdFile, new ST_1e51b813a2c6a26cea1c6c8c17329da8Structure(), ssConectaProveedores.RestRecords.RESTST_1e51b813a2c6a26cea1c6c8c17329da8Structure.FromStructure, config);
  } else {
AttrCode = (long?) s.ssCode;
AttrMessage = s.ssMessage;
AttrCargaCFDResult = ssConectaProveedores.RestRecords.RESTST_3feabb059aa2546826b3076d3b237751Structure.FromStructure(s.ssCargaCFDResult, config);
AttrCfdFile = ssConectaProveedores.RestRecords.RESTST_1e51b813a2c6a26cea1c6c8c17329da8Structure.FromStructure(s.ssCfdFile, config);
  }
}

public static ST_6636acdf9f49922edfd43b4865475460Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_6636acdf9f49922edfd43b4865475460Structure obj) { 
  ST_6636acdf9f49922edfd43b4865475460Structure s = new ST_6636acdf9f49922edfd43b4865475460Structure();
  if(obj != null) {
  s.ssCode = obj.AttrCode == null ? 0L : obj.AttrCode.Value;
  s.ssMessage = obj.AttrMessage == null ? "" : obj.AttrMessage;
  s.ssCargaCFDResult = ssConectaProveedores.RestRecords.RESTST_3feabb059aa2546826b3076d3b237751Structure.ToStructure(obj.AttrCargaCFDResult);
  s.ssCfdFile = ssConectaProveedores.RestRecords.RESTST_1e51b813a2c6a26cea1c6c8c17329da8Structure.ToStructure(obj.AttrCfdFile);
  }
  return s;
}

public static Func<ST_6636acdf9f49922edfd43b4865475460Structure, ssConectaProveedores.RestRecords.RESTST_6636acdf9f49922edfd43b4865475460Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_6636acdf9f49922edfd43b4865475460Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_6636acdf9f49922edfd43b4865475460Structure FromStructure(ST_6636acdf9f49922edfd43b4865475460Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_6636acdf9f49922edfd43b4865475460Structure(s, config);
}

}


