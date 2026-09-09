using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// BAPI_ZMXFFIMF_ACC_DOC_CHANGE_Request
public class JSONST_0cb1a5ee06af693baf5508d00a19d139Structure : AbstractRESTStructure<ST_0cb1a5ee06af693baf5508d00a19d139Structure> {
[JsonProperty("PI_BELNR")]
[JsonPropertyName("PI_BELNR")]
public string AttrPI_BELNR;

[JsonProperty("PI_BUKRS")]
[JsonPropertyName("PI_BUKRS")]
public string AttrPI_BUKRS;

[JsonProperty("PI_GJAHR")]
[JsonPropertyName("PI_GJAHR")]
public int? AttrPI_GJAHR;

[JsonProperty("PI_ZFBDT")]
[JsonPropertyName("PI_ZFBDT")]
public String AttrPI_ZFBDT;

[JsonProperty("PI_ZTERM")]
[JsonPropertyName("PI_ZTERM")]
public string AttrPI_ZTERM;

public JSONST_0cb1a5ee06af693baf5508d00a19d139Structure() { }

public JSONST_0cb1a5ee06af693baf5508d00a19d139Structure (ST_0cb1a5ee06af693baf5508d00a19d139Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPI_BELNR = s.ssPI_BELNR;
AttrPI_BUKRS = s.ssPI_BUKRS;
AttrPI_GJAHR = (int?) s.ssPI_GJAHR;
AttrPI_ZFBDT = ConvertDateToRestWithoutDefaults(s.ssPI_ZFBDT, (new DateTime (1900, 1, 1, 0, 0, 0, DateTimeKind.Utc)));
AttrPI_ZTERM = ConvertToRestWithoutDefaults(s.ssPI_ZTERM, "");
  } else {
AttrPI_BELNR = s.ssPI_BELNR;
AttrPI_BUKRS = s.ssPI_BUKRS;
AttrPI_GJAHR = (int?) s.ssPI_GJAHR;
AttrPI_ZFBDT = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(s.ssPI_ZFBDT);
AttrPI_ZTERM = s.ssPI_ZTERM;
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_0cb1a5ee06af693baf5508d00a19d139Structure, ST_0cb1a5ee06af693baf5508d00a19d139Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_0cb1a5ee06af693baf5508d00a19d139Structure s) => ToStructure(s, config);
}
public static ST_0cb1a5ee06af693baf5508d00a19d139Structure ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_0cb1a5ee06af693baf5508d00a19d139Structure obj, IBehaviorsConfiguration config) { 
  ST_0cb1a5ee06af693baf5508d00a19d139Structure s = new ST_0cb1a5ee06af693baf5508d00a19d139Structure();
  if(obj != null) {
  s.ssPI_BELNR = obj.AttrPI_BELNR == null ? "" : obj.AttrPI_BELNR;
  s.ssPI_BUKRS = obj.AttrPI_BUKRS == null ? "" : obj.AttrPI_BUKRS;
  s.ssPI_GJAHR = obj.AttrPI_GJAHR == null ? 0 : obj.AttrPI_GJAHR.Value;
  s.ssPI_ZFBDT = obj.AttrPI_ZFBDT == null ? (new DateTime (1900, 1, 1, 0, 0, 0, DateTimeKind.Utc)) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(obj.AttrPI_ZFBDT);
  s.ssPI_ZTERM = obj.AttrPI_ZTERM == null ? "" : obj.AttrPI_ZTERM;
  }
  return s;
}

public static Func<ST_0cb1a5ee06af693baf5508d00a19d139Structure, ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_0cb1a5ee06af693baf5508d00a19d139Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_0cb1a5ee06af693baf5508d00a19d139Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_0cb1a5ee06af693baf5508d00a19d139Structure FromStructure(ST_0cb1a5ee06af693baf5508d00a19d139Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_0cb1a5ee06af693baf5508d00a19d139Structure(s, config);
}

}


