using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// TI_RETENCIONES_In3
public class JSONST_57edec30140ebe846267970253841d11Structure : AbstractRESTStructure<ST_57edec30140ebe846267970253841d11Structure> {
[JsonProperty("WITHT")]
[JsonPropertyName("WITHT")]
public string AttrWITHT;

[JsonProperty("WT_WITHCD")]
[JsonPropertyName("WT_WITHCD")]
public string AttrWT_WITHCD;

[JsonProperty("WT_SUBJCT")]
[JsonPropertyName("WT_SUBJCT")]
public string AttrWT_SUBJCT;

public JSONST_57edec30140ebe846267970253841d11Structure() { }

public JSONST_57edec30140ebe846267970253841d11Structure (ST_57edec30140ebe846267970253841d11Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrWITHT = ConvertToRestWithoutDefaults(s.ssWITHT, "");
AttrWT_WITHCD = ConvertToRestWithoutDefaults(s.ssWT_WITHCD, "");
AttrWT_SUBJCT = ConvertToRestWithoutDefaults(s.ssWT_SUBJCT, "");
  } else {
AttrWITHT = s.ssWITHT;
AttrWT_WITHCD = s.ssWT_WITHCD;
AttrWT_SUBJCT = s.ssWT_SUBJCT;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_57edec30140ebe846267970253841d11Structure, ST_57edec30140ebe846267970253841d11Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_57edec30140ebe846267970253841d11Structure s) => ToStructure(s, config);
}
public static ST_57edec30140ebe846267970253841d11Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_57edec30140ebe846267970253841d11Structure obj, IBehaviorsConfiguration config) { 
  ST_57edec30140ebe846267970253841d11Structure s = new ST_57edec30140ebe846267970253841d11Structure();
  if(obj != null) {
  s.ssWITHT = obj.AttrWITHT == null ? "" : obj.AttrWITHT;
  s.ssWT_WITHCD = obj.AttrWT_WITHCD == null ? "" : obj.AttrWT_WITHCD;
  s.ssWT_SUBJCT = obj.AttrWT_SUBJCT == null ? "" : obj.AttrWT_SUBJCT;
  }
  return s;
}

public static Func<ST_57edec30140ebe846267970253841d11Structure, ssConectaProveedores.RestRecords.JSONST_57edec30140ebe846267970253841d11Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_57edec30140ebe846267970253841d11Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_57edec30140ebe846267970253841d11Structure FromStructure(ST_57edec30140ebe846267970253841d11Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_57edec30140ebe846267970253841d11Structure(s, config);
}

}


