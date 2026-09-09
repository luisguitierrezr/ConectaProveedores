using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// T_FAC_PAG_Out
public class RESTST_99acd807840db0272ca95b7e5ca3fca1Structure : AbstractRESTStructure<ST_99acd807840db0272ca95b7e5ca3fca1Structure> {
[JsonProperty("KURSF")]
public decimal? AttrKURSF;

[JsonProperty("AUGBL")]
public string AttrAUGBL;

[JsonProperty("WRBTR")]
public decimal? AttrWRBTR;

[JsonProperty("LIFNR")]
public string AttrLIFNR;

[JsonProperty("WRBT2")]
public decimal? AttrWRBT2;

[JsonProperty("WRBT3")]
public decimal? AttrWRBT3;

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

[JsonProperty("WAERS")]
public string AttrWAERS;

[JsonProperty("BLART")]
public string AttrBLART;

[JsonProperty("ZLSCH")]
public string AttrZLSCH;

[JsonProperty("USNAM")]
public string AttrUSNAM;

[JsonProperty("USRID_LONG")]
public string AttrUSRID_LONG;

public RESTST_99acd807840db0272ca95b7e5ca3fca1Structure() { }

public RESTST_99acd807840db0272ca95b7e5ca3fca1Structure (ST_99acd807840db0272ca95b7e5ca3fca1Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrKURSF = ConvertToRestWithoutDefaults(s.ssKURSF, -79228162514264337593543950335m);
AttrAUGBL = ConvertToRestWithoutDefaults(s.ssAUGBL, "");
AttrWRBTR = ConvertToRestWithoutDefaults(s.ssWRBTR, -79228162514264337593543950335m);
AttrLIFNR = ConvertToRestWithoutDefaults(s.ssLIFNR, "");
AttrWRBT2 = ConvertToRestWithoutDefaults(s.ssWRBT2, -79228162514264337593543950335m);
AttrWRBT3 = ConvertToRestWithoutDefaults(s.ssWRBT3, -79228162514264337593543950335m);
AttrXBLNR = ConvertToRestWithoutDefaults(s.ssXBLNR, "");
AttrZUONR = ConvertToRestWithoutDefaults(s.ssZUONR, "");
AttrZFBDT = ConvertDateToRestWithoutDefaults(s.ssZFBDT, (new DateTime (1900, 1, 1, 0, 0, 0, DateTimeKind.Utc)));
AttrZTERM = ConvertToRestWithoutDefaults(s.ssZTERM, "");
AttrAUGDT = ConvertDateToRestWithoutDefaults(s.ssAUGDT, (new DateTime (1900, 1, 1, 0, 0, 0, DateTimeKind.Utc)));
AttrWAERS = ConvertToRestWithoutDefaults(s.ssWAERS, "");
AttrBLART = ConvertToRestWithoutDefaults(s.ssBLART, "");
AttrZLSCH = ConvertToRestWithoutDefaults(s.ssZLSCH, "");
AttrUSNAM = ConvertToRestWithoutDefaults(s.ssUSNAM, "");
AttrUSRID_LONG = ConvertToRestWithoutDefaults(s.ssUSRID_LONG, "");
  } else {
AttrKURSF = (decimal?) s.ssKURSF;
AttrAUGBL = s.ssAUGBL;
AttrWRBTR = (decimal?) s.ssWRBTR;
AttrLIFNR = s.ssLIFNR;
AttrWRBT2 = (decimal?) s.ssWRBT2;
AttrWRBT3 = (decimal?) s.ssWRBT3;
AttrXBLNR = s.ssXBLNR;
AttrZUONR = s.ssZUONR;
AttrZFBDT = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(s.ssZFBDT);
AttrZTERM = s.ssZTERM;
AttrAUGDT = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(s.ssAUGDT);
AttrWAERS = s.ssWAERS;
AttrBLART = s.ssBLART;
AttrZLSCH = s.ssZLSCH;
AttrUSNAM = s.ssUSNAM;
AttrUSRID_LONG = s.ssUSRID_LONG;
  }
}

public static ST_99acd807840db0272ca95b7e5ca3fca1Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_99acd807840db0272ca95b7e5ca3fca1Structure obj) { 
  ST_99acd807840db0272ca95b7e5ca3fca1Structure s = new ST_99acd807840db0272ca95b7e5ca3fca1Structure();
  if(obj != null) {
  s.ssKURSF = obj.AttrKURSF == null ? -79228162514264337593543950335m : obj.AttrKURSF.Value;
  s.ssAUGBL = obj.AttrAUGBL == null ? "" : obj.AttrAUGBL;
  s.ssWRBTR = obj.AttrWRBTR == null ? -79228162514264337593543950335m : obj.AttrWRBTR.Value;
  s.ssLIFNR = obj.AttrLIFNR == null ? "" : obj.AttrLIFNR;
  s.ssWRBT2 = obj.AttrWRBT2 == null ? -79228162514264337593543950335m : obj.AttrWRBT2.Value;
  s.ssWRBT3 = obj.AttrWRBT3 == null ? -79228162514264337593543950335m : obj.AttrWRBT3.Value;
  s.ssXBLNR = obj.AttrXBLNR == null ? "" : obj.AttrXBLNR;
  s.ssZUONR = obj.AttrZUONR == null ? "" : obj.AttrZUONR;
  s.ssZFBDT = obj.AttrZFBDT == null ? (new DateTime (1900, 1, 1, 0, 0, 0, DateTimeKind.Utc)) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(obj.AttrZFBDT);
  s.ssZTERM = obj.AttrZTERM == null ? "" : obj.AttrZTERM;
  s.ssAUGDT = obj.AttrAUGDT == null ? (new DateTime (1900, 1, 1, 0, 0, 0, DateTimeKind.Utc)) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(obj.AttrAUGDT);
  s.ssWAERS = obj.AttrWAERS == null ? "" : obj.AttrWAERS;
  s.ssBLART = obj.AttrBLART == null ? "" : obj.AttrBLART;
  s.ssZLSCH = obj.AttrZLSCH == null ? "" : obj.AttrZLSCH;
  s.ssUSNAM = obj.AttrUSNAM == null ? "" : obj.AttrUSNAM;
  s.ssUSRID_LONG = obj.AttrUSRID_LONG == null ? "" : obj.AttrUSRID_LONG;
  }
  return s;
}

public static Func<ST_99acd807840db0272ca95b7e5ca3fca1Structure, ssConectaProveedores.RestRecords.RESTST_99acd807840db0272ca95b7e5ca3fca1Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_99acd807840db0272ca95b7e5ca3fca1Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_99acd807840db0272ca95b7e5ca3fca1Structure FromStructure(ST_99acd807840db0272ca95b7e5ca3fca1Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_99acd807840db0272ca95b7e5ca3fca1Structure(s, config);
}

}


