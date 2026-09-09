using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// TI_WXD_Out
public class JSONST_646bfb521d5f3e3e304163b436da5220Structure : AbstractRESTStructure<ST_646bfb521d5f3e3e304163b436da5220Structure> {
[JsonProperty("SPLIT_KEY")]
[JsonPropertyName("SPLIT_KEY")]
public int? AttrSPLIT_KEY;

[JsonProperty("WI_TAX_TYPE")]
[JsonPropertyName("WI_TAX_TYPE")]
public string AttrWI_TAX_TYPE;

[JsonProperty("WI_TAX_CODE")]
[JsonPropertyName("WI_TAX_CODE")]
public string AttrWI_TAX_CODE;

[JsonProperty("WI_TAX_BASE")]
[JsonPropertyName("WI_TAX_BASE")]
public decimal? AttrWI_TAX_BASE;

public JSONST_646bfb521d5f3e3e304163b436da5220Structure() { }

public JSONST_646bfb521d5f3e3e304163b436da5220Structure (ST_646bfb521d5f3e3e304163b436da5220Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSPLIT_KEY = ConvertToRestWithoutDefaults(s.ssSPLIT_KEY, -2147483648);
AttrWI_TAX_TYPE = ConvertToRestWithoutDefaults(s.ssWI_TAX_TYPE, "");
AttrWI_TAX_CODE = ConvertToRestWithoutDefaults(s.ssWI_TAX_CODE, "");
AttrWI_TAX_BASE = ConvertToRestWithoutDefaults(s.ssWI_TAX_BASE, -79228162514264337593543950335m);
  } else {
AttrSPLIT_KEY = (int?) s.ssSPLIT_KEY;
AttrWI_TAX_TYPE = s.ssWI_TAX_TYPE;
AttrWI_TAX_CODE = s.ssWI_TAX_CODE;
AttrWI_TAX_BASE = (decimal?) s.ssWI_TAX_BASE;
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_646bfb521d5f3e3e304163b436da5220Structure, ST_646bfb521d5f3e3e304163b436da5220Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_646bfb521d5f3e3e304163b436da5220Structure s) => ToStructure(s, config);
}
public static ST_646bfb521d5f3e3e304163b436da5220Structure ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_646bfb521d5f3e3e304163b436da5220Structure obj, IBehaviorsConfiguration config) { 
  ST_646bfb521d5f3e3e304163b436da5220Structure s = new ST_646bfb521d5f3e3e304163b436da5220Structure();
  if(obj != null) {
  s.ssSPLIT_KEY = obj.AttrSPLIT_KEY == null ? -2147483648 : obj.AttrSPLIT_KEY.Value;
  s.ssWI_TAX_TYPE = obj.AttrWI_TAX_TYPE == null ? "" : obj.AttrWI_TAX_TYPE;
  s.ssWI_TAX_CODE = obj.AttrWI_TAX_CODE == null ? "" : obj.AttrWI_TAX_CODE;
  s.ssWI_TAX_BASE = obj.AttrWI_TAX_BASE == null ? -79228162514264337593543950335m : obj.AttrWI_TAX_BASE.Value;
  }
  return s;
}

public static Func<ST_646bfb521d5f3e3e304163b436da5220Structure, ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_646bfb521d5f3e3e304163b436da5220Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_646bfb521d5f3e3e304163b436da5220Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_646bfb521d5f3e3e304163b436da5220Structure FromStructure(ST_646bfb521d5f3e3e304163b436da5220Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_646bfb521d5f3e3e304163b436da5220Structure(s, config);
}

}


