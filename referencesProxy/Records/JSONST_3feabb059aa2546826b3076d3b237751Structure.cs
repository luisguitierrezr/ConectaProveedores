using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// CargaCFDResultWrapper
public class JSONST_3feabb059aa2546826b3076d3b237751Structure : AbstractRESTStructure<ST_3feabb059aa2546826b3076d3b237751Structure> {
[JsonProperty("status")]
[JsonPropertyName("status")]
public string AttrStatus;

[JsonProperty("descripcionStatus")]
[JsonPropertyName("descripcionStatus")]
public string AttrDescripcionStatus;

[JsonProperty("cPago")]
[JsonPropertyName("cPago")]
public string AttrCPago;

[JsonProperty("claveDescripcion")]
[JsonPropertyName("claveDescripcion")]
public string AttrClaveDescripcion;

public JSONST_3feabb059aa2546826b3076d3b237751Structure() { }

public JSONST_3feabb059aa2546826b3076d3b237751Structure (ST_3feabb059aa2546826b3076d3b237751Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrStatus = ConvertToRestWithoutDefaults(s.ssStatus, "");
AttrDescripcionStatus = ConvertToRestWithoutDefaults(s.ssDescripcionStatus, "");
AttrCPago = ConvertToRestWithoutDefaults(s.ssCPago, "");
AttrClaveDescripcion = ConvertToRestWithoutDefaults(s.ssClaveDescripcion, "");
  } else {
AttrStatus = s.ssStatus;
AttrDescripcionStatus = s.ssDescripcionStatus;
AttrCPago = s.ssCPago;
AttrClaveDescripcion = s.ssClaveDescripcion;
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_3feabb059aa2546826b3076d3b237751Structure, ST_3feabb059aa2546826b3076d3b237751Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_3feabb059aa2546826b3076d3b237751Structure s) => ToStructure(s, config);
}
public static ST_3feabb059aa2546826b3076d3b237751Structure ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_3feabb059aa2546826b3076d3b237751Structure obj, IBehaviorsConfiguration config) { 
  ST_3feabb059aa2546826b3076d3b237751Structure s = new ST_3feabb059aa2546826b3076d3b237751Structure();
  if(obj != null) {
  s.ssStatus = obj.AttrStatus == null ? "" : obj.AttrStatus;
  s.ssDescripcionStatus = obj.AttrDescripcionStatus == null ? "" : obj.AttrDescripcionStatus;
  s.ssCPago = obj.AttrCPago == null ? "" : obj.AttrCPago;
  s.ssClaveDescripcion = obj.AttrClaveDescripcion == null ? "" : obj.AttrClaveDescripcion;
  }
  return s;
}

public static Func<ST_3feabb059aa2546826b3076d3b237751Structure, ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_3feabb059aa2546826b3076d3b237751Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_3feabb059aa2546826b3076d3b237751Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_3feabb059aa2546826b3076d3b237751Structure FromStructure(ST_3feabb059aa2546826b3076d3b237751Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_3feabb059aa2546826b3076d3b237751Structure(s, config);
}

}


