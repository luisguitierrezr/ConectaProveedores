using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RETURN2
public class RESTST_e5256660414a7d3dddc63b7cbdd21e9cStructure : AbstractRESTStructure<ST_e5256660414a7d3dddc63b7cbdd21e9cStructure> {
[JsonProperty("TYPE")]
public string AttrTYPE;

[JsonProperty("CODE")]
public string AttrCODE;

[JsonProperty("MESSAGE")]
public string AttrMESSAGE;

[JsonProperty("LOG_NO")]
public string AttrLOG_NO;

[JsonProperty("LOG_MSG_NO")]
public int? AttrLOG_MSG_NO;

[JsonProperty("MESSAGE_V1")]
public string AttrMESSAGE_V1;

[JsonProperty("MESSAGE_V2")]
public string AttrMESSAGE_V2;

[JsonProperty("MESSAGE_V3")]
public string AttrMESSAGE_V3;

[JsonProperty("MESSAGE_V4")]
public string AttrMESSAGE_V4;

public RESTST_e5256660414a7d3dddc63b7cbdd21e9cStructure() { }

public RESTST_e5256660414a7d3dddc63b7cbdd21e9cStructure (ST_e5256660414a7d3dddc63b7cbdd21e9cStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrTYPE = ConvertToRestWithoutDefaults(s.ssTYPE, "");
AttrCODE = ConvertToRestWithoutDefaults(s.ssCODE, "");
AttrMESSAGE = ConvertToRestWithoutDefaults(s.ssMESSAGE, "");
AttrLOG_NO = ConvertToRestWithoutDefaults(s.ssLOG_NO, "");
AttrLOG_MSG_NO = ConvertToRestWithoutDefaults(s.ssLOG_MSG_NO, -2147483648);
AttrMESSAGE_V1 = ConvertToRestWithoutDefaults(s.ssMESSAGE_V1, "");
AttrMESSAGE_V2 = ConvertToRestWithoutDefaults(s.ssMESSAGE_V2, "");
AttrMESSAGE_V3 = ConvertToRestWithoutDefaults(s.ssMESSAGE_V3, "");
AttrMESSAGE_V4 = ConvertToRestWithoutDefaults(s.ssMESSAGE_V4, "");
  } else {
AttrTYPE = s.ssTYPE;
AttrCODE = s.ssCODE;
AttrMESSAGE = s.ssMESSAGE;
AttrLOG_NO = s.ssLOG_NO;
AttrLOG_MSG_NO = (int?) s.ssLOG_MSG_NO;
AttrMESSAGE_V1 = s.ssMESSAGE_V1;
AttrMESSAGE_V2 = s.ssMESSAGE_V2;
AttrMESSAGE_V3 = s.ssMESSAGE_V3;
AttrMESSAGE_V4 = s.ssMESSAGE_V4;
  }
}

public static ST_e5256660414a7d3dddc63b7cbdd21e9cStructure ToStructure(ssConectaProveedores.RestRecords.RESTST_e5256660414a7d3dddc63b7cbdd21e9cStructure obj) { 
  ST_e5256660414a7d3dddc63b7cbdd21e9cStructure s = new ST_e5256660414a7d3dddc63b7cbdd21e9cStructure();
  if(obj != null) {
  s.ssTYPE = obj.AttrTYPE == null ? "" : obj.AttrTYPE;
  s.ssCODE = obj.AttrCODE == null ? "" : obj.AttrCODE;
  s.ssMESSAGE = obj.AttrMESSAGE == null ? "" : obj.AttrMESSAGE;
  s.ssLOG_NO = obj.AttrLOG_NO == null ? "" : obj.AttrLOG_NO;
  s.ssLOG_MSG_NO = obj.AttrLOG_MSG_NO == null ? -2147483648 : obj.AttrLOG_MSG_NO.Value;
  s.ssMESSAGE_V1 = obj.AttrMESSAGE_V1 == null ? "" : obj.AttrMESSAGE_V1;
  s.ssMESSAGE_V2 = obj.AttrMESSAGE_V2 == null ? "" : obj.AttrMESSAGE_V2;
  s.ssMESSAGE_V3 = obj.AttrMESSAGE_V3 == null ? "" : obj.AttrMESSAGE_V3;
  s.ssMESSAGE_V4 = obj.AttrMESSAGE_V4 == null ? "" : obj.AttrMESSAGE_V4;
  }
  return s;
}

public static Func<ST_e5256660414a7d3dddc63b7cbdd21e9cStructure, ssConectaProveedores.RestRecords.RESTST_e5256660414a7d3dddc63b7cbdd21e9cStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_e5256660414a7d3dddc63b7cbdd21e9cStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_e5256660414a7d3dddc63b7cbdd21e9cStructure FromStructure(ST_e5256660414a7d3dddc63b7cbdd21e9cStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_e5256660414a7d3dddc63b7cbdd21e9cStructure(s, config);
}

}


