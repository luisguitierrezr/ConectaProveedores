using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ACCOUNT_DETAIL
public class RESTST_d2beaf811f074c88054765b10d929011Structure : AbstractRESTStructure<ST_d2beaf811f074c88054765b10d929011Structure> {
[JsonProperty("COMP_CODE")]
public string AttrCOMP_CODE;

[JsonProperty("GL_ACCOUNT")]
public string AttrGL_ACCOUNT;

[JsonProperty("SHORT_TEXT")]
public string AttrSHORT_TEXT;

[JsonProperty("LONG_TEXT")]
public string AttrLONG_TEXT;

[JsonProperty("CHRT_ACCTS")]
public string AttrCHRT_ACCTS;

[JsonProperty("BS_ACCOUNT")]
public string AttrBS_ACCOUNT;

[JsonProperty("PL_ACCOUNT")]
public string AttrPL_ACCOUNT;

[JsonProperty("ACCT_CURR")]
public string AttrACCT_CURR;

[JsonProperty("ACCT_CURR_ISO")]
public string AttrACCT_CURR_ISO;

[JsonProperty("TAX_CODE")]
public string AttrTAX_CODE;

[JsonProperty("NO_TAX_REQUIRED")]
public string AttrNO_TAX_REQUIRED;

public RESTST_d2beaf811f074c88054765b10d929011Structure() { }

public RESTST_d2beaf811f074c88054765b10d929011Structure (ST_d2beaf811f074c88054765b10d929011Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCOMP_CODE = ConvertToRestWithoutDefaults(s.ssCOMP_CODE, "");
AttrGL_ACCOUNT = ConvertToRestWithoutDefaults(s.ssGL_ACCOUNT, "");
AttrSHORT_TEXT = ConvertToRestWithoutDefaults(s.ssSHORT_TEXT, "");
AttrLONG_TEXT = ConvertToRestWithoutDefaults(s.ssLONG_TEXT, "");
AttrCHRT_ACCTS = ConvertToRestWithoutDefaults(s.ssCHRT_ACCTS, "");
AttrBS_ACCOUNT = ConvertToRestWithoutDefaults(s.ssBS_ACCOUNT, "");
AttrPL_ACCOUNT = ConvertToRestWithoutDefaults(s.ssPL_ACCOUNT, "");
AttrACCT_CURR = ConvertToRestWithoutDefaults(s.ssACCT_CURR, "");
AttrACCT_CURR_ISO = ConvertToRestWithoutDefaults(s.ssACCT_CURR_ISO, "");
AttrTAX_CODE = ConvertToRestWithoutDefaults(s.ssTAX_CODE, "");
AttrNO_TAX_REQUIRED = ConvertToRestWithoutDefaults(s.ssNO_TAX_REQUIRED, "");
  } else {
AttrCOMP_CODE = s.ssCOMP_CODE;
AttrGL_ACCOUNT = s.ssGL_ACCOUNT;
AttrSHORT_TEXT = s.ssSHORT_TEXT;
AttrLONG_TEXT = s.ssLONG_TEXT;
AttrCHRT_ACCTS = s.ssCHRT_ACCTS;
AttrBS_ACCOUNT = s.ssBS_ACCOUNT;
AttrPL_ACCOUNT = s.ssPL_ACCOUNT;
AttrACCT_CURR = s.ssACCT_CURR;
AttrACCT_CURR_ISO = s.ssACCT_CURR_ISO;
AttrTAX_CODE = s.ssTAX_CODE;
AttrNO_TAX_REQUIRED = s.ssNO_TAX_REQUIRED;
  }
}

public static ST_d2beaf811f074c88054765b10d929011Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_d2beaf811f074c88054765b10d929011Structure obj) { 
  ST_d2beaf811f074c88054765b10d929011Structure s = new ST_d2beaf811f074c88054765b10d929011Structure();
  if(obj != null) {
  s.ssCOMP_CODE = obj.AttrCOMP_CODE == null ? "" : obj.AttrCOMP_CODE;
  s.ssGL_ACCOUNT = obj.AttrGL_ACCOUNT == null ? "" : obj.AttrGL_ACCOUNT;
  s.ssSHORT_TEXT = obj.AttrSHORT_TEXT == null ? "" : obj.AttrSHORT_TEXT;
  s.ssLONG_TEXT = obj.AttrLONG_TEXT == null ? "" : obj.AttrLONG_TEXT;
  s.ssCHRT_ACCTS = obj.AttrCHRT_ACCTS == null ? "" : obj.AttrCHRT_ACCTS;
  s.ssBS_ACCOUNT = obj.AttrBS_ACCOUNT == null ? "" : obj.AttrBS_ACCOUNT;
  s.ssPL_ACCOUNT = obj.AttrPL_ACCOUNT == null ? "" : obj.AttrPL_ACCOUNT;
  s.ssACCT_CURR = obj.AttrACCT_CURR == null ? "" : obj.AttrACCT_CURR;
  s.ssACCT_CURR_ISO = obj.AttrACCT_CURR_ISO == null ? "" : obj.AttrACCT_CURR_ISO;
  s.ssTAX_CODE = obj.AttrTAX_CODE == null ? "" : obj.AttrTAX_CODE;
  s.ssNO_TAX_REQUIRED = obj.AttrNO_TAX_REQUIRED == null ? "" : obj.AttrNO_TAX_REQUIRED;
  }
  return s;
}

public static Func<ST_d2beaf811f074c88054765b10d929011Structure, ssConectaProveedores.RestRecords.RESTST_d2beaf811f074c88054765b10d929011Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_d2beaf811f074c88054765b10d929011Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_d2beaf811f074c88054765b10d929011Structure FromStructure(ST_d2beaf811f074c88054765b10d929011Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_d2beaf811f074c88054765b10d929011Structure(s, config);
}

}


