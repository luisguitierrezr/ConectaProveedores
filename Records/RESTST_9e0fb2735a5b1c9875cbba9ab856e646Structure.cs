using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// TI_RETENCIONES_Out
public class RESTST_9e0fb2735a5b1c9875cbba9ab856e646Structure : AbstractRESTStructure<ST_9e0fb2735a5b1c9875cbba9ab856e646Structure> {
[JsonProperty("LIFNR")]
public string AttrLIFNR;

[JsonProperty("BUKRS")]
public string AttrBUKRS;

[JsonProperty("WITHT")]
public string AttrWITHT;

[JsonProperty("WT_WITHCD")]
public string AttrWT_WITHCD;

[JsonProperty("WT_SUBJCT")]
public string AttrWT_SUBJCT;

public RESTST_9e0fb2735a5b1c9875cbba9ab856e646Structure() { }

public RESTST_9e0fb2735a5b1c9875cbba9ab856e646Structure (ST_9e0fb2735a5b1c9875cbba9ab856e646Structure s, IBehaviorsConfiguration config) {
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

public static ST_9e0fb2735a5b1c9875cbba9ab856e646Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_9e0fb2735a5b1c9875cbba9ab856e646Structure obj) { 
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

public static Func<ST_9e0fb2735a5b1c9875cbba9ab856e646Structure, ssConectaProveedores.RestRecords.RESTST_9e0fb2735a5b1c9875cbba9ab856e646Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_9e0fb2735a5b1c9875cbba9ab856e646Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_9e0fb2735a5b1c9875cbba9ab856e646Structure FromStructure(ST_9e0fb2735a5b1c9875cbba9ab856e646Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_9e0fb2735a5b1c9875cbba9ab856e646Structure(s, config);
}

}


