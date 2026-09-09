using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// TI_RETENCIONES_In
public class JSONST_2859defd6257fe38677ed819621e4236Structure : AbstractRESTStructure<ST_2859defd6257fe38677ed819621e4236Structure> {
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

public JSONST_2859defd6257fe38677ed819621e4236Structure() { }

public JSONST_2859defd6257fe38677ed819621e4236Structure (ST_2859defd6257fe38677ed819621e4236Structure s, IBehaviorsConfiguration config) {
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

public static Func<ssConectaProveedores.RestRecords.JSONST_2859defd6257fe38677ed819621e4236Structure, ST_2859defd6257fe38677ed819621e4236Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_2859defd6257fe38677ed819621e4236Structure s) => ToStructure(s, config);
}
public static ST_2859defd6257fe38677ed819621e4236Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_2859defd6257fe38677ed819621e4236Structure obj, IBehaviorsConfiguration config) { 
  ST_2859defd6257fe38677ed819621e4236Structure s = new ST_2859defd6257fe38677ed819621e4236Structure();
  if(obj != null) {
  s.ssLIFNR = obj.AttrLIFNR == null ? "" : obj.AttrLIFNR;
  s.ssBUKRS = obj.AttrBUKRS == null ? "" : obj.AttrBUKRS;
  s.ssWITHT = obj.AttrWITHT == null ? "" : obj.AttrWITHT;
  s.ssWT_WITHCD = obj.AttrWT_WITHCD == null ? "" : obj.AttrWT_WITHCD;
  s.ssWT_SUBJCT = obj.AttrWT_SUBJCT == null ? "" : obj.AttrWT_SUBJCT;
  }
  return s;
}

public static Func<ST_2859defd6257fe38677ed819621e4236Structure, ssConectaProveedores.RestRecords.JSONST_2859defd6257fe38677ed819621e4236Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_2859defd6257fe38677ed819621e4236Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_2859defd6257fe38677ed819621e4236Structure FromStructure(ST_2859defd6257fe38677ed819621e4236Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_2859defd6257fe38677ed819621e4236Structure(s, config);
}

}


