using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// PI_HEADER
public class JSONST_f4885e4f480f4a52f6c05031eda6ef37Structure : AbstractRESTStructure<ST_f4885e4f480f4a52f6c05031eda6ef37Structure> {
[JsonProperty("INVOICE_IND")]
[JsonPropertyName("INVOICE_IND")]
public string AttrINVOICE_IND;

[JsonProperty("DOC_TYPE")]
[JsonPropertyName("DOC_TYPE")]
public string AttrDOC_TYPE;

[JsonProperty("DOC_DATE")]
[JsonPropertyName("DOC_DATE")]
public String AttrDOC_DATE;

[JsonProperty("PSTNG_DATE")]
[JsonPropertyName("PSTNG_DATE")]
public String AttrPSTNG_DATE;

[JsonProperty("REF_DOC_NO")]
[JsonPropertyName("REF_DOC_NO")]
public string AttrREF_DOC_NO;

[JsonProperty("COMP_CODE")]
[JsonPropertyName("COMP_CODE")]
public string AttrCOMP_CODE;

[JsonProperty("GROSS_AMOUNT")]
[JsonPropertyName("GROSS_AMOUNT")]
public decimal? AttrGROSS_AMOUNT;

[JsonProperty("CALC_TAX_IND")]
[JsonPropertyName("CALC_TAX_IND")]
public string AttrCALC_TAX_IND;

[JsonProperty("PMNTTRMS")]
[JsonPropertyName("PMNTTRMS")]
public string AttrPMNTTRMS;

[JsonProperty("BLINE_DATE")]
[JsonPropertyName("BLINE_DATE")]
public String AttrBLINE_DATE;

[JsonProperty("HEADER_TXT")]
[JsonPropertyName("HEADER_TXT")]
public string AttrHEADER_TXT;

[JsonProperty("ALLOC_NMBR")]
[JsonPropertyName("ALLOC_NMBR")]
public string AttrALLOC_NMBR;

[JsonProperty("BUS_AREA")]
[JsonPropertyName("BUS_AREA")]
public string AttrBUS_AREA;

[JsonProperty("ITEM_TEXT")]
[JsonPropertyName("ITEM_TEXT")]
public string AttrITEM_TEXT;

[JsonProperty("CURRENCY")]
[JsonPropertyName("CURRENCY")]
public string AttrCURRENCY;

[JsonProperty("DEL_COSTS_TAXC")]
[JsonPropertyName("DEL_COSTS_TAXC")]
public string AttrDEL_COSTS_TAXC;

[JsonProperty("PYMT_METH")]
[JsonPropertyName("PYMT_METH")]
public string AttrPYMT_METH;

[JsonProperty("EXCH_RATE")]
[JsonPropertyName("EXCH_RATE")]
public decimal? AttrEXCH_RATE;

public JSONST_f4885e4f480f4a52f6c05031eda6ef37Structure() { }

public JSONST_f4885e4f480f4a52f6c05031eda6ef37Structure (ST_f4885e4f480f4a52f6c05031eda6ef37Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrINVOICE_IND = ConvertToRestWithoutDefaults(s.ssINVOICE_IND, "");
AttrDOC_TYPE = ConvertToRestWithoutDefaults(s.ssDOC_TYPE, "");
AttrDOC_DATE = ConvertDateToRestWithoutDefaults(s.ssDOC_DATE, (new DateTime (1900, 1, 1, 0, 0, 0, DateTimeKind.Utc)));
AttrPSTNG_DATE = ConvertDateToRestWithoutDefaults(s.ssPSTNG_DATE, (new DateTime (1900, 1, 1, 0, 0, 0, DateTimeKind.Utc)));
AttrREF_DOC_NO = ConvertToRestWithoutDefaults(s.ssREF_DOC_NO, "");
AttrCOMP_CODE = ConvertToRestWithoutDefaults(s.ssCOMP_CODE, "");
AttrGROSS_AMOUNT = ConvertToRestWithoutDefaults(s.ssGROSS_AMOUNT, -79228162514264337593543950335m);
AttrCALC_TAX_IND = ConvertToRestWithoutDefaults(s.ssCALC_TAX_IND, "");
AttrPMNTTRMS = ConvertToRestWithoutDefaults(s.ssPMNTTRMS, "");
AttrBLINE_DATE = ConvertDateToRestWithoutDefaults(s.ssBLINE_DATE, (new DateTime (1900, 1, 1, 0, 0, 0, DateTimeKind.Utc)));
AttrHEADER_TXT = ConvertToRestWithoutDefaults(s.ssHEADER_TXT, "");
AttrALLOC_NMBR = ConvertToRestWithoutDefaults(s.ssALLOC_NMBR, "");
AttrBUS_AREA = ConvertToRestWithoutDefaults(s.ssBUS_AREA, "");
AttrITEM_TEXT = ConvertToRestWithoutDefaults(s.ssITEM_TEXT, "");
AttrCURRENCY = ConvertToRestWithoutDefaults(s.ssCURRENCY, "");
AttrDEL_COSTS_TAXC = ConvertToRestWithoutDefaults(s.ssDEL_COSTS_TAXC, "");
AttrPYMT_METH = ConvertToRestWithoutDefaults(s.ssPYMT_METH, "");
AttrEXCH_RATE = ConvertToRestWithoutDefaults(s.ssEXCH_RATE, -79228162514264337593543950335m);
  } else {
AttrINVOICE_IND = s.ssINVOICE_IND;
AttrDOC_TYPE = s.ssDOC_TYPE;
AttrDOC_DATE = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(s.ssDOC_DATE);
AttrPSTNG_DATE = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(s.ssPSTNG_DATE);
AttrREF_DOC_NO = s.ssREF_DOC_NO;
AttrCOMP_CODE = s.ssCOMP_CODE;
AttrGROSS_AMOUNT = (decimal?) s.ssGROSS_AMOUNT;
AttrCALC_TAX_IND = s.ssCALC_TAX_IND;
AttrPMNTTRMS = s.ssPMNTTRMS;
AttrBLINE_DATE = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(s.ssBLINE_DATE);
AttrHEADER_TXT = s.ssHEADER_TXT;
AttrALLOC_NMBR = s.ssALLOC_NMBR;
AttrBUS_AREA = s.ssBUS_AREA;
AttrITEM_TEXT = s.ssITEM_TEXT;
AttrCURRENCY = s.ssCURRENCY;
AttrDEL_COSTS_TAXC = s.ssDEL_COSTS_TAXC;
AttrPYMT_METH = s.ssPYMT_METH;
AttrEXCH_RATE = (decimal?) s.ssEXCH_RATE;
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_f4885e4f480f4a52f6c05031eda6ef37Structure, ST_f4885e4f480f4a52f6c05031eda6ef37Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_f4885e4f480f4a52f6c05031eda6ef37Structure s) => ToStructure(s, config);
}
public static ST_f4885e4f480f4a52f6c05031eda6ef37Structure ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_f4885e4f480f4a52f6c05031eda6ef37Structure obj, IBehaviorsConfiguration config) { 
  ST_f4885e4f480f4a52f6c05031eda6ef37Structure s = new ST_f4885e4f480f4a52f6c05031eda6ef37Structure();
  if(obj != null) {
  s.ssINVOICE_IND = obj.AttrINVOICE_IND == null ? "" : obj.AttrINVOICE_IND;
  s.ssDOC_TYPE = obj.AttrDOC_TYPE == null ? "" : obj.AttrDOC_TYPE;
  s.ssDOC_DATE = obj.AttrDOC_DATE == null ? (new DateTime (1900, 1, 1, 0, 0, 0, DateTimeKind.Utc)) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(obj.AttrDOC_DATE);
  s.ssPSTNG_DATE = obj.AttrPSTNG_DATE == null ? (new DateTime (1900, 1, 1, 0, 0, 0, DateTimeKind.Utc)) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(obj.AttrPSTNG_DATE);
  s.ssREF_DOC_NO = obj.AttrREF_DOC_NO == null ? "" : obj.AttrREF_DOC_NO;
  s.ssCOMP_CODE = obj.AttrCOMP_CODE == null ? "" : obj.AttrCOMP_CODE;
  s.ssGROSS_AMOUNT = obj.AttrGROSS_AMOUNT == null ? -79228162514264337593543950335m : obj.AttrGROSS_AMOUNT.Value;
  s.ssCALC_TAX_IND = obj.AttrCALC_TAX_IND == null ? "" : obj.AttrCALC_TAX_IND;
  s.ssPMNTTRMS = obj.AttrPMNTTRMS == null ? "" : obj.AttrPMNTTRMS;
  s.ssBLINE_DATE = obj.AttrBLINE_DATE == null ? (new DateTime (1900, 1, 1, 0, 0, 0, DateTimeKind.Utc)) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(obj.AttrBLINE_DATE);
  s.ssHEADER_TXT = obj.AttrHEADER_TXT == null ? "" : obj.AttrHEADER_TXT;
  s.ssALLOC_NMBR = obj.AttrALLOC_NMBR == null ? "" : obj.AttrALLOC_NMBR;
  s.ssBUS_AREA = obj.AttrBUS_AREA == null ? "" : obj.AttrBUS_AREA;
  s.ssITEM_TEXT = obj.AttrITEM_TEXT == null ? "" : obj.AttrITEM_TEXT;
  s.ssCURRENCY = obj.AttrCURRENCY == null ? "" : obj.AttrCURRENCY;
  s.ssDEL_COSTS_TAXC = obj.AttrDEL_COSTS_TAXC == null ? "" : obj.AttrDEL_COSTS_TAXC;
  s.ssPYMT_METH = obj.AttrPYMT_METH == null ? "" : obj.AttrPYMT_METH;
  s.ssEXCH_RATE = obj.AttrEXCH_RATE == null ? -79228162514264337593543950335m : obj.AttrEXCH_RATE.Value;
  }
  return s;
}

public static Func<ST_f4885e4f480f4a52f6c05031eda6ef37Structure, ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_f4885e4f480f4a52f6c05031eda6ef37Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_f4885e4f480f4a52f6c05031eda6ef37Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_f4885e4f480f4a52f6c05031eda6ef37Structure FromStructure(ST_f4885e4f480f4a52f6c05031eda6ef37Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_f4885e4f480f4a52f6c05031eda6ef37Structure(s, config);
}

}


