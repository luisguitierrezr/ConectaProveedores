using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// CommissionsAndLeasesFileStruct
public class JSONST_0a2958ff44247d7464fd88ba7a80597cStructure : AbstractRESTStructure<ST_0a2958ff44247d7464fd88ba7a80597cStructure> {
[JsonProperty("FeContab")]
[JsonPropertyName("FeContab")]
public string AttrFeContab;

[JsonProperty("EjMes")]
[JsonPropertyName("EjMes")]
public string AttrEjMes;

[JsonProperty("Cuenta")]
[JsonPropertyName("Cuenta")]
public string AttrCuenta;

[JsonProperty("Referencia")]
[JsonPropertyName("Referencia")]
public string AttrReferencia;

[JsonProperty("Nombre1")]
[JsonPropertyName("Nombre1")]
public string AttrNombre1;

[JsonProperty("Nombre2")]
[JsonPropertyName("Nombre2")]
public string AttrNombre2;

[JsonProperty("NDoc")]
[JsonPropertyName("NDoc")]
public string AttrNDoc;

[JsonProperty("ImporteEnML")]
[JsonPropertyName("ImporteEnML")]
public string AttrImporteEnML;

[JsonProperty("ML")]
[JsonPropertyName("ML")]
public string AttrML;

[JsonProperty("ImporteEnMD")]
[JsonPropertyName("ImporteEnMD")]
public string AttrImporteEnMD;

[JsonProperty("Mon")]
[JsonPropertyName("Mon")]
public string AttrMon;

[JsonProperty("Soc")]
[JsonPropertyName("Soc")]
public string AttrSoc;

[JsonProperty("Div")]
[JsonPropertyName("Div")]
public string AttrDiv;

[JsonProperty("LibMayor")]
[JsonPropertyName("LibMayor")]
public string AttrLibMayor;

[JsonProperty("TextoCabDocumento")]
[JsonPropertyName("TextoCabDocumento")]
public string AttrTextoCabDocumento;

[JsonProperty("DocComp")]
[JsonPropertyName("DocComp")]
public string AttrDocComp;

public JSONST_0a2958ff44247d7464fd88ba7a80597cStructure() { }

public JSONST_0a2958ff44247d7464fd88ba7a80597cStructure (ST_0a2958ff44247d7464fd88ba7a80597cStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFeContab = ConvertToRestWithoutDefaults(s.ssFeContab, "");
AttrEjMes = ConvertToRestWithoutDefaults(s.ssEjMes, "");
AttrCuenta = ConvertToRestWithoutDefaults(s.ssCuenta, "");
AttrReferencia = ConvertToRestWithoutDefaults(s.ssReferencia, "");
AttrNombre1 = ConvertToRestWithoutDefaults(s.ssNombre1, "");
AttrNombre2 = ConvertToRestWithoutDefaults(s.ssNombre2, "");
AttrNDoc = ConvertToRestWithoutDefaults(s.ssNDoc, "");
AttrImporteEnML = ConvertToRestWithoutDefaults(s.ssImporteEnML, "");
AttrML = ConvertToRestWithoutDefaults(s.ssML, "");
AttrImporteEnMD = ConvertToRestWithoutDefaults(s.ssImporteEnMD, "");
AttrMon = ConvertToRestWithoutDefaults(s.ssMon, "");
AttrSoc = ConvertToRestWithoutDefaults(s.ssSoc, "");
AttrDiv = ConvertToRestWithoutDefaults(s.ssDiv, "");
AttrLibMayor = ConvertToRestWithoutDefaults(s.ssLibMayor, "");
AttrTextoCabDocumento = ConvertToRestWithoutDefaults(s.ssTextoCabDocumento, "");
AttrDocComp = ConvertToRestWithoutDefaults(s.ssDocComp, "");
  } else {
AttrFeContab = s.ssFeContab;
AttrEjMes = s.ssEjMes;
AttrCuenta = s.ssCuenta;
AttrReferencia = s.ssReferencia;
AttrNombre1 = s.ssNombre1;
AttrNombre2 = s.ssNombre2;
AttrNDoc = s.ssNDoc;
AttrImporteEnML = s.ssImporteEnML;
AttrML = s.ssML;
AttrImporteEnMD = s.ssImporteEnMD;
AttrMon = s.ssMon;
AttrSoc = s.ssSoc;
AttrDiv = s.ssDiv;
AttrLibMayor = s.ssLibMayor;
AttrTextoCabDocumento = s.ssTextoCabDocumento;
AttrDocComp = s.ssDocComp;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_0a2958ff44247d7464fd88ba7a80597cStructure, ST_0a2958ff44247d7464fd88ba7a80597cStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_0a2958ff44247d7464fd88ba7a80597cStructure s) => ToStructure(s, config);
}
public static ST_0a2958ff44247d7464fd88ba7a80597cStructure ToStructure(ssConectaProveedores.RestRecords.JSONST_0a2958ff44247d7464fd88ba7a80597cStructure obj, IBehaviorsConfiguration config) { 
  ST_0a2958ff44247d7464fd88ba7a80597cStructure s = new ST_0a2958ff44247d7464fd88ba7a80597cStructure();
  if(obj != null) {
  s.ssFeContab = obj.AttrFeContab == null ? "" : obj.AttrFeContab;
  s.ssEjMes = obj.AttrEjMes == null ? "" : obj.AttrEjMes;
  s.ssCuenta = obj.AttrCuenta == null ? "" : obj.AttrCuenta;
  s.ssReferencia = obj.AttrReferencia == null ? "" : obj.AttrReferencia;
  s.ssNombre1 = obj.AttrNombre1 == null ? "" : obj.AttrNombre1;
  s.ssNombre2 = obj.AttrNombre2 == null ? "" : obj.AttrNombre2;
  s.ssNDoc = obj.AttrNDoc == null ? "" : obj.AttrNDoc;
  s.ssImporteEnML = obj.AttrImporteEnML == null ? "" : obj.AttrImporteEnML;
  s.ssML = obj.AttrML == null ? "" : obj.AttrML;
  s.ssImporteEnMD = obj.AttrImporteEnMD == null ? "" : obj.AttrImporteEnMD;
  s.ssMon = obj.AttrMon == null ? "" : obj.AttrMon;
  s.ssSoc = obj.AttrSoc == null ? "" : obj.AttrSoc;
  s.ssDiv = obj.AttrDiv == null ? "" : obj.AttrDiv;
  s.ssLibMayor = obj.AttrLibMayor == null ? "" : obj.AttrLibMayor;
  s.ssTextoCabDocumento = obj.AttrTextoCabDocumento == null ? "" : obj.AttrTextoCabDocumento;
  s.ssDocComp = obj.AttrDocComp == null ? "" : obj.AttrDocComp;
  }
  return s;
}

public static Func<ST_0a2958ff44247d7464fd88ba7a80597cStructure, ssConectaProveedores.RestRecords.JSONST_0a2958ff44247d7464fd88ba7a80597cStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_0a2958ff44247d7464fd88ba7a80597cStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_0a2958ff44247d7464fd88ba7a80597cStructure FromStructure(ST_0a2958ff44247d7464fd88ba7a80597cStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_0a2958ff44247d7464fd88ba7a80597cStructure(s, config);
}

}


