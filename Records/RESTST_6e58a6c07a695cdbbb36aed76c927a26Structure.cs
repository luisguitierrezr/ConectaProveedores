using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// CurrentAccountFACT_PEN_PAGStruct
public class RESTST_6e58a6c07a695cdbbb36aed76c927a26Structure : AbstractRESTStructure<ST_6e58a6c07a695cdbbb36aed76c927a26Structure> {
[JsonProperty("XBLNR")]
public string AttrXBLNR;

[JsonProperty("ZUONR")]
public string AttrZUONR;

[JsonProperty("ZFBDT")]
public String AttrZFBDT;

[JsonProperty("ZTERM")]
public string AttrZTERM;

[JsonProperty("AUGDT")]
public String AttrAUGDT;

[JsonProperty("WRBTR")]
public decimal? AttrWRBTR;

[JsonProperty("WAERS")]
public string AttrWAERS;

[JsonProperty("WRBT2")]
public decimal? AttrWRBT2;

[JsonProperty("WRBT3")]
public decimal? AttrWRBT3;

[JsonProperty("UMSKZ")]
public string AttrUMSKZ;

[JsonProperty("BLART")]
public string AttrBLART;

[JsonProperty("ZLSCH")]
public string AttrZLSCH;

[JsonProperty("KURSF")]
public decimal? AttrKURSF;

[JsonProperty("USNAM")]
public string AttrUSNAM;

[JsonProperty("USRID_LONG")]
public string AttrUSRID_LONG;

public RESTST_6e58a6c07a695cdbbb36aed76c927a26Structure() { }

public RESTST_6e58a6c07a695cdbbb36aed76c927a26Structure (ST_6e58a6c07a695cdbbb36aed76c927a26Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrXBLNR = ConvertToRestWithoutDefaults(s.ssXBLNR, "");
AttrZUONR = ConvertToRestWithoutDefaults(s.ssZUONR, "");
AttrZFBDT = ConvertDateToRestWithoutDefaults(s.ssZFBDT, (new DateTime (1900, 1, 1, 0, 0, 0, DateTimeKind.Utc)));
AttrZTERM = ConvertToRestWithoutDefaults(s.ssZTERM, "");
AttrAUGDT = ConvertDateToRestWithoutDefaults(s.ssAUGDT, (new DateTime (1900, 1, 1, 0, 0, 0, DateTimeKind.Utc)));
AttrWRBTR = ConvertToRestWithoutDefaults(s.ssWRBTR, 0.0M);
AttrWAERS = ConvertToRestWithoutDefaults(s.ssWAERS, "");
AttrWRBT2 = ConvertToRestWithoutDefaults(s.ssWRBT2, 0.0M);
AttrWRBT3 = ConvertToRestWithoutDefaults(s.ssWRBT3, 0.0M);
AttrUMSKZ = ConvertToRestWithoutDefaults(s.ssUMSKZ, "");
AttrBLART = ConvertToRestWithoutDefaults(s.ssBLART, "");
AttrZLSCH = ConvertToRestWithoutDefaults(s.ssZLSCH, "");
AttrKURSF = ConvertToRestWithoutDefaults(s.ssKURSF, 0.0M);
AttrUSNAM = ConvertToRestWithoutDefaults(s.ssUSNAM, "");
AttrUSRID_LONG = ConvertToRestWithoutDefaults(s.ssUSRID_LONG, "");
  } else {
AttrXBLNR = s.ssXBLNR;
AttrZUONR = s.ssZUONR;
AttrZFBDT = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(s.ssZFBDT);
AttrZTERM = s.ssZTERM;
AttrAUGDT = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(s.ssAUGDT);
AttrWRBTR = (decimal?) s.ssWRBTR;
AttrWAERS = s.ssWAERS;
AttrWRBT2 = (decimal?) s.ssWRBT2;
AttrWRBT3 = (decimal?) s.ssWRBT3;
AttrUMSKZ = s.ssUMSKZ;
AttrBLART = s.ssBLART;
AttrZLSCH = s.ssZLSCH;
AttrKURSF = (decimal?) s.ssKURSF;
AttrUSNAM = s.ssUSNAM;
AttrUSRID_LONG = s.ssUSRID_LONG;
  }
}

public static ST_6e58a6c07a695cdbbb36aed76c927a26Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_6e58a6c07a695cdbbb36aed76c927a26Structure obj) { 
  ST_6e58a6c07a695cdbbb36aed76c927a26Structure s = new ST_6e58a6c07a695cdbbb36aed76c927a26Structure();
  if(obj != null) {
  s.ssXBLNR = obj.AttrXBLNR == null ? "" : obj.AttrXBLNR;
  s.ssZUONR = obj.AttrZUONR == null ? "" : obj.AttrZUONR;
  s.ssZFBDT = obj.AttrZFBDT == null ? (new DateTime (1900, 1, 1, 0, 0, 0, DateTimeKind.Utc)) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(obj.AttrZFBDT);
  s.ssZTERM = obj.AttrZTERM == null ? "" : obj.AttrZTERM;
  s.ssAUGDT = obj.AttrAUGDT == null ? (new DateTime (1900, 1, 1, 0, 0, 0, DateTimeKind.Utc)) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(obj.AttrAUGDT);
  s.ssWRBTR = obj.AttrWRBTR == null ? 0.0M : obj.AttrWRBTR.Value;
  s.ssWAERS = obj.AttrWAERS == null ? "" : obj.AttrWAERS;
  s.ssWRBT2 = obj.AttrWRBT2 == null ? 0.0M : obj.AttrWRBT2.Value;
  s.ssWRBT3 = obj.AttrWRBT3 == null ? 0.0M : obj.AttrWRBT3.Value;
  s.ssUMSKZ = obj.AttrUMSKZ == null ? "" : obj.AttrUMSKZ;
  s.ssBLART = obj.AttrBLART == null ? "" : obj.AttrBLART;
  s.ssZLSCH = obj.AttrZLSCH == null ? "" : obj.AttrZLSCH;
  s.ssKURSF = obj.AttrKURSF == null ? 0.0M : obj.AttrKURSF.Value;
  s.ssUSNAM = obj.AttrUSNAM == null ? "" : obj.AttrUSNAM;
  s.ssUSRID_LONG = obj.AttrUSRID_LONG == null ? "" : obj.AttrUSRID_LONG;
  }
  return s;
}

public static Func<ST_6e58a6c07a695cdbbb36aed76c927a26Structure, ssConectaProveedores.RestRecords.RESTST_6e58a6c07a695cdbbb36aed76c927a26Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_6e58a6c07a695cdbbb36aed76c927a26Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_6e58a6c07a695cdbbb36aed76c927a26Structure FromStructure(ST_6e58a6c07a695cdbbb36aed76c927a26Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_6e58a6c07a695cdbbb36aed76c927a26Structure(s, config);
}

}


