using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// TI_RETENCIONES_Out
public class JSONST_9e0fb2735a5b1c9875cbba9ab856e646Structure : AbstractRESTStructure<ST_9e0fb2735a5b1c9875cbba9ab856e646Structure> {
[JsonProperty("LIFNR")]
[JsonPropertyName("LIFNR")]
public string AttrLIFNR;

[JsonProperty("BUKRS")]
[JsonPropertyName("BUKRS")]
public string AttrBUKRS;

[JsonProperty("WITHT")]
[JsonPropertyName("WITHT")]
public string AttrWITHT;

[JsonProperty("WT_WITHCD")]
[JsonPropertyName("WT_WITHCD")]
public string AttrWT_WITHCD;

[JsonProperty("WT_SUBJCT")]
[JsonPropertyName("WT_SUBJCT")]
public string AttrWT_SUBJCT;

public JSONST_9e0fb2735a5b1c9875cbba9ab856e646Structure() { }

public JSONST_9e0fb2735a5b1c9875cbba9ab856e646Structure (ST_9e0fb2735a5b1c9875cbba9ab856e646Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrLIFNR = ConvertToRestWithoutDefaults(s.ssLIFNR, "");
AttrBUKRS = ConvertToRestWithoutDefaults(s.ssBUKRS, "");
AttrWITHT = ConvertToRestWithoutDefaults(s.ssWITHT, "");
AttrWT_WITHCD = ConvertToRestWithoutDefaults(s.ssWT_WITHCD, "");
AttrWT_SUBJCT = ConvertToRestWithoutDefaults(s.ssWT_SUBJCT, "");
  } else {
AttrLIFNR = s.ssLIFNR;
AttrBUKRS = s.ssBUKRS;
AttrWITHT = s.ssWITHT;
AttrWT_WITHCD = s.ssWT_WITHCD;
AttrWT_SUBJCT = s.ssWT_SUBJCT;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_9e0fb2735a5b1c9875cbba9ab856e646Structure, ST_9e0fb2735a5b1c9875cbba9ab856e646Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_9e0fb2735a5b1c9875cbba9ab856e646Structure s) => ToStructure(s, config);
}
public static ST_9e0fb2735a5b1c9875cbba9ab856e646Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_9e0fb2735a5b1c9875cbba9ab856e646Structure obj, IBehaviorsConfiguration config) { 
  ST_9e0fb2735a5b1c9875cbba9ab856e646Structure s = new ST_9e0fb2735a5b1c9875cbba9ab856e646Structure();
  if(obj != null) {
  s.ssLIFNR = obj.AttrLIFNR == null ? "" : obj.AttrLIFNR;
  s.ssBUKRS = obj.AttrBUKRS == null ? "" : obj.AttrBUKRS;
  s.ssWITHT = obj.AttrWITHT == null ? "" : obj.AttrWITHT;
  s.ssWT_WITHCD = obj.AttrWT_WITHCD == null ? "" : obj.AttrWT_WITHCD;
  s.ssWT_SUBJCT = obj.AttrWT_SUBJCT == null ? "" : obj.AttrWT_SUBJCT;
  }
  return s;
}

public static Func<ST_9e0fb2735a5b1c9875cbba9ab856e646Structure, ssConectaProveedores.RestRecords.JSONST_9e0fb2735a5b1c9875cbba9ab856e646Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_9e0fb2735a5b1c9875cbba9ab856e646Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_9e0fb2735a5b1c9875cbba9ab856e646Structure FromStructure(ST_9e0fb2735a5b1c9875cbba9ab856e646Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_9e0fb2735a5b1c9875cbba9ab856e646Structure(s, config);
}

}


