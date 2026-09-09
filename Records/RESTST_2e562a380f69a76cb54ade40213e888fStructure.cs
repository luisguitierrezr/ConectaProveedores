using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ExcelFolioLogToExport
public class RESTST_2e562a380f69a76cb54ade40213e888fStructure : AbstractRESTStructure<ST_2e562a380f69a76cb54ade40213e888fStructure> {
[JsonProperty("Numerodefolio")]
public string AttrNumerodefolio;

[JsonProperty("Creadopor")]
public string AttrCreadopor;

[JsonProperty("Creadoel")]
public String AttrCreadoel;

[JsonProperty("Mensaje")]
public string AttrMensaje;

public RESTST_2e562a380f69a76cb54ade40213e888fStructure() { }

public RESTST_2e562a380f69a76cb54ade40213e888fStructure (ST_2e562a380f69a76cb54ade40213e888fStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrNumerodefolio = ConvertToRestWithoutDefaults(s.ssNumerodefolio, "");
AttrCreadopor = ConvertToRestWithoutDefaults(s.ssCreadopor, "");
AttrCreadoel = ConvertDateTimeToRestWithoutDefaults(s.ssCreadoel, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrMensaje = ConvertToRestWithoutDefaults(s.ssMensaje, "");
  } else {
AttrNumerodefolio = s.ssNumerodefolio;
AttrCreadopor = s.ssCreadopor;
AttrCreadoel = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreadoel, config.DateTimeFormat);
AttrMensaje = s.ssMensaje;
  }
}

public static ST_2e562a380f69a76cb54ade40213e888fStructure ToStructure(ssConectaProveedores.RestRecords.RESTST_2e562a380f69a76cb54ade40213e888fStructure obj) { 
  ST_2e562a380f69a76cb54ade40213e888fStructure s = new ST_2e562a380f69a76cb54ade40213e888fStructure();
  if(obj != null) {
  s.ssNumerodefolio = obj.AttrNumerodefolio == null ? "" : obj.AttrNumerodefolio;
  s.ssCreadopor = obj.AttrCreadopor == null ? "" : obj.AttrCreadopor;
  s.ssCreadoel = obj.AttrCreadoel == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreadoel, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssMensaje = obj.AttrMensaje == null ? "" : obj.AttrMensaje;
  }
  return s;
}

public static Func<ST_2e562a380f69a76cb54ade40213e888fStructure, ssConectaProveedores.RestRecords.RESTST_2e562a380f69a76cb54ade40213e888fStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_2e562a380f69a76cb54ade40213e888fStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_2e562a380f69a76cb54ade40213e888fStructure FromStructure(ST_2e562a380f69a76cb54ade40213e888fStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_2e562a380f69a76cb54ade40213e888fStructure(s, config);
}

}


