using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// T_FACT_PEN_PAG_In
public class JSONST_0310bb62d750573571d23e0cd61c55b3Structure : AbstractRESTStructure<ST_0310bb62d750573571d23e0cd61c55b3Structure> {
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

[JsonProperty("WRBTR")]
[JsonPropertyName("WRBTR")]
public decimal? AttrWRBTR;

[JsonProperty("WAERS")]
[JsonPropertyName("WAERS")]
public string AttrWAERS;

[JsonProperty("WRBT2")]
[JsonPropertyName("WRBT2")]
public decimal? AttrWRBT2;

[JsonProperty("WRBT3")]
[JsonPropertyName("WRBT3")]
public decimal? AttrWRBT3;

[JsonProperty("UMSKZ")]
[JsonPropertyName("UMSKZ")]
public string AttrUMSKZ;

[JsonProperty("BLART")]
[JsonPropertyName("BLART")]
public string AttrBLART;

[JsonProperty("ZLSCH")]
[JsonPropertyName("ZLSCH")]
public string AttrZLSCH;

[JsonProperty("KURSF")]
[JsonPropertyName("KURSF")]
public decimal? AttrKURSF;

[JsonProperty("USNAM")]
[JsonPropertyName("USNAM")]
public string AttrUSNAM;

[JsonProperty("USRID_LONG")]
[JsonPropertyName("USRID_LONG")]
public string AttrUSRID_LONG;

public JSONST_0310bb62d750573571d23e0cd61c55b3Structure() { }

public JSONST_0310bb62d750573571d23e0cd61c55b3Structure (ST_0310bb62d750573571d23e0cd61c55b3Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrXBLNR = ConvertToRestWithoutDefaults(s.ssXBLNR, "");
AttrZUONR = ConvertToRestWithoutDefaults(s.ssZUONR, "");
AttrZFBDT = ConvertDateToRestWithoutDefaults(s.ssZFBDT, (new DateTime (1900, 1, 1, 0, 0, 0, DateTimeKind.Utc)));
AttrZTERM = ConvertToRestWithoutDefaults(s.ssZTERM, "");
AttrAUGDT = ConvertDateToRestWithoutDefaults(s.ssAUGDT, (new DateTime (1900, 1, 1, 0, 0, 0, DateTimeKind.Utc)));
AttrWRBTR = ConvertToRestWithoutDefaults(s.ssWRBTR, -79228162514264337593543950335m);
AttrWAERS = ConvertToRestWithoutDefaults(s.ssWAERS, "");
AttrWRBT2 = ConvertToRestWithoutDefaults(s.ssWRBT2, -79228162514264337593543950335m);
AttrWRBT3 = ConvertToRestWithoutDefaults(s.ssWRBT3, -79228162514264337593543950335m);
AttrUMSKZ = ConvertToRestWithoutDefaults(s.ssUMSKZ, "");
AttrBLART = ConvertToRestWithoutDefaults(s.ssBLART, "");
AttrZLSCH = ConvertToRestWithoutDefaults(s.ssZLSCH, "");
AttrKURSF = ConvertToRestWithoutDefaults(s.ssKURSF, -79228162514264337593543950335m);
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

public static Func<ssConectaProveedores.RestRecords.JSONST_0310bb62d750573571d23e0cd61c55b3Structure, ST_0310bb62d750573571d23e0cd61c55b3Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_0310bb62d750573571d23e0cd61c55b3Structure s) => ToStructure(s, config);
}
public static ST_0310bb62d750573571d23e0cd61c55b3Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_0310bb62d750573571d23e0cd61c55b3Structure obj, IBehaviorsConfiguration config) { 
  ST_0310bb62d750573571d23e0cd61c55b3Structure s = new ST_0310bb62d750573571d23e0cd61c55b3Structure();
  if(obj != null) {
  s.ssXBLNR = obj.AttrXBLNR == null ? "" : obj.AttrXBLNR;
  s.ssZUONR = obj.AttrZUONR == null ? "" : obj.AttrZUONR;
  s.ssZFBDT = obj.AttrZFBDT == null ? (new DateTime (1900, 1, 1, 0, 0, 0, DateTimeKind.Utc)) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(obj.AttrZFBDT);
  s.ssZTERM = obj.AttrZTERM == null ? "" : obj.AttrZTERM;
  s.ssAUGDT = obj.AttrAUGDT == null ? (new DateTime (1900, 1, 1, 0, 0, 0, DateTimeKind.Utc)) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(obj.AttrAUGDT);
  s.ssWRBTR = obj.AttrWRBTR == null ? -79228162514264337593543950335m : obj.AttrWRBTR.Value;
  s.ssWAERS = obj.AttrWAERS == null ? "" : obj.AttrWAERS;
  s.ssWRBT2 = obj.AttrWRBT2 == null ? -79228162514264337593543950335m : obj.AttrWRBT2.Value;
  s.ssWRBT3 = obj.AttrWRBT3 == null ? -79228162514264337593543950335m : obj.AttrWRBT3.Value;
  s.ssUMSKZ = obj.AttrUMSKZ == null ? "" : obj.AttrUMSKZ;
  s.ssBLART = obj.AttrBLART == null ? "" : obj.AttrBLART;
  s.ssZLSCH = obj.AttrZLSCH == null ? "" : obj.AttrZLSCH;
  s.ssKURSF = obj.AttrKURSF == null ? -79228162514264337593543950335m : obj.AttrKURSF.Value;
  s.ssUSNAM = obj.AttrUSNAM == null ? "" : obj.AttrUSNAM;
  s.ssUSRID_LONG = obj.AttrUSRID_LONG == null ? "" : obj.AttrUSRID_LONG;
  }
  return s;
}

public static Func<ST_0310bb62d750573571d23e0cd61c55b3Structure, ssConectaProveedores.RestRecords.JSONST_0310bb62d750573571d23e0cd61c55b3Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_0310bb62d750573571d23e0cd61c55b3Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_0310bb62d750573571d23e0cd61c55b3Structure FromStructure(ST_0310bb62d750573571d23e0cd61c55b3Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_0310bb62d750573571d23e0cd61c55b3Structure(s, config);
}

}


