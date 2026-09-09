using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OcrResult
public class RESTST_ce06f43cf108d98e4f79c0106fcfd0acStructure : AbstractRESTStructure<ST_ce06f43cf108d98e4f79c0106fcfd0acStructure> {
[JsonProperty("Success")]
public bool? AttrSuccess;

[JsonProperty("Message")]
public string AttrMessage;

[JsonProperty("ExtractedText")]
public string AttrExtractedText;

[JsonProperty("DebugLog")]
public string AttrDebugLog;

public RESTST_ce06f43cf108d98e4f79c0106fcfd0acStructure() { }

public RESTST_ce06f43cf108d98e4f79c0106fcfd0acStructure (ST_ce06f43cf108d98e4f79c0106fcfd0acStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSuccess = ConvertToRestWithoutDefaults(s.ssSuccess, false);
AttrMessage = ConvertToRestWithoutDefaults(s.ssMessage, "");
AttrExtractedText = ConvertToRestWithoutDefaults(s.ssExtractedText, "");
AttrDebugLog = ConvertToRestWithoutDefaults(s.ssDebugLog, "");
  } else {
AttrSuccess = (bool?) s.ssSuccess;
AttrMessage = s.ssMessage;
AttrExtractedText = s.ssExtractedText;
AttrDebugLog = s.ssDebugLog;
  }
}

public static ST_ce06f43cf108d98e4f79c0106fcfd0acStructure ToStructure(ssConectaProveedores.RestRecords.RESTST_ce06f43cf108d98e4f79c0106fcfd0acStructure obj) { 
  ST_ce06f43cf108d98e4f79c0106fcfd0acStructure s = new ST_ce06f43cf108d98e4f79c0106fcfd0acStructure();
  if(obj != null) {
  s.ssSuccess = obj.AttrSuccess == null ? false : obj.AttrSuccess.Value;
  s.ssMessage = obj.AttrMessage == null ? "" : obj.AttrMessage;
  s.ssExtractedText = obj.AttrExtractedText == null ? "" : obj.AttrExtractedText;
  s.ssDebugLog = obj.AttrDebugLog == null ? "" : obj.AttrDebugLog;
  }
  return s;
}

public static Func<ST_ce06f43cf108d98e4f79c0106fcfd0acStructure, ssConectaProveedores.RestRecords.RESTST_ce06f43cf108d98e4f79c0106fcfd0acStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_ce06f43cf108d98e4f79c0106fcfd0acStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_ce06f43cf108d98e4f79c0106fcfd0acStructure FromStructure(ST_ce06f43cf108d98e4f79c0106fcfd0acStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_ce06f43cf108d98e4f79c0106fcfd0acStructure(s, config);
}

}


