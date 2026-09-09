using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// CurrentAccountFAC_PAG_OutStruct
public class JSONST_89af93fec4915ac38f0ef9c0a1b729beStructure : AbstractRESTStructure<ST_89af93fec4915ac38f0ef9c0a1b729beStructure> {
[JsonProperty("KURSF")]
[JsonPropertyName("KURSF")]
public decimal? AttrKURSF;

[JsonProperty("AUGBL")]
[JsonPropertyName("AUGBL")]
public string AttrAUGBL;

[JsonProperty("WRBTR")]
[JsonPropertyName("WRBTR")]
public decimal? AttrWRBTR;

[JsonProperty("LIFNR")]
[JsonPropertyName("LIFNR")]
public string AttrLIFNR;

[JsonProperty("WRBT2")]
[JsonPropertyName("WRBT2")]
public decimal? AttrWRBT2;

[JsonProperty("WRBT3")]
[JsonPropertyName("WRBT3")]
public decimal? AttrWRBT3;

[JsonProperty("XBLNR")]
[JsonPropertyName("XBLNR")]
public string AttrXBLNR;

[JsonProperty("ZUONR")]
[JsonPropertyName("ZUONR")]
public string AttrZUONR;

[JsonProperty("ZFBDT")]
[JsonPropertyName("ZFBDT")]
public String AttrZFBDT;

[JsonProperty("ZTERM")]
[JsonPropertyName("ZTERM")]
public string AttrZTERM;

[JsonProperty("AUGDT")]
[JsonPropertyName("AUGDT")]
public String AttrAUGDT;

[JsonProperty("WAERS")]
[JsonPropertyName("WAERS")]
public string AttrWAERS;

[JsonProperty("BLART")]
[JsonPropertyName("BLART")]
public string AttrBLART;

[JsonProperty("ZLSCH")]
[JsonPropertyName("ZLSCH")]
public string AttrZLSCH;

[JsonProperty("USNAM")]
[JsonPropertyName("USNAM")]
public string AttrUSNAM;

[JsonProperty("USRID_LONG")]
[JsonPropertyName("USRID_LONG")]
public string AttrUSRID_LONG;

public JSONST_89af93fec4915ac38f0ef9c0a1b729beStructure() { }

public JSONST_89af93fec4915ac38f0ef9c0a1b729beStructure (ST_89af93fec4915ac38f0ef9c0a1b729beStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrKURSF = ConvertToRestWithoutDefaults(s.ssKURSF, 0.0M);
AttrAUGBL = ConvertToRestWithoutDefaults(s.ssAUGBL, "");
AttrWRBTR = ConvertToRestWithoutDefaults(s.ssWRBTR, 0.0M);
AttrLIFNR = ConvertToRestWithoutDefaults(s.ssLIFNR, "");
AttrWRBT2 = ConvertToRestWithoutDefaults(s.ssWRBT2, 0.0M);
AttrWRBT3 = ConvertToRestWithoutDefaults(s.ssWRBT3, 0.0M);
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

public static Func<ssConectaProveedores.RestRecords.JSONST_89af93fec4915ac38f0ef9c0a1b729beStructure, ST_89af93fec4915ac38f0ef9c0a1b729beStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_89af93fec4915ac38f0ef9c0a1b729beStructure s) => ToStructure(s, config);
}
public static ST_89af93fec4915ac38f0ef9c0a1b729beStructure ToStructure(ssConectaProveedores.RestRecords.JSONST_89af93fec4915ac38f0ef9c0a1b729beStructure obj, IBehaviorsConfiguration config) { 
  ST_89af93fec4915ac38f0ef9c0a1b729beStructure s = new ST_89af93fec4915ac38f0ef9c0a1b729beStructure();
  if(obj != null) {
  s.ssKURSF = obj.AttrKURSF == null ? 0.0M : obj.AttrKURSF.Value;
  s.ssAUGBL = obj.AttrAUGBL == null ? "" : obj.AttrAUGBL;
  s.ssWRBTR = obj.AttrWRBTR == null ? 0.0M : obj.AttrWRBTR.Value;
  s.ssLIFNR = obj.AttrLIFNR == null ? "" : obj.AttrLIFNR;
  s.ssWRBT2 = obj.AttrWRBT2 == null ? 0.0M : obj.AttrWRBT2.Value;
  s.ssWRBT3 = obj.AttrWRBT3 == null ? 0.0M : obj.AttrWRBT3.Value;
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

public static Func<ST_89af93fec4915ac38f0ef9c0a1b729beStructure, ssConectaProveedores.RestRecords.JSONST_89af93fec4915ac38f0ef9c0a1b729beStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_89af93fec4915ac38f0ef9c0a1b729beStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_89af93fec4915ac38f0ef9c0a1b729beStructure FromStructure(ST_89af93fec4915ac38f0ef9c0a1b729beStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_89af93fec4915ac38f0ef9c0a1b729beStructure(s, config);
}

}


