using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// CargaCFDResultWrapper
public class RESTST_3feabb059aa2546826b3076d3b237751Structure : AbstractRESTStructure<ST_3feabb059aa2546826b3076d3b237751Structure> {
[JsonProperty("Status")]
public string AttrStatus;

[JsonProperty("DescripcionStatus")]
public string AttrDescripcionStatus;

[JsonProperty("CPago")]
public string AttrCPago;

[JsonProperty("ClaveDescripcion")]
public string AttrClaveDescripcion;

public RESTST_3feabb059aa2546826b3076d3b237751Structure() { }

public RESTST_3feabb059aa2546826b3076d3b237751Structure (ST_3feabb059aa2546826b3076d3b237751Structure s, IBehaviorsConfiguration config) {
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

public static ST_3feabb059aa2546826b3076d3b237751Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_3feabb059aa2546826b3076d3b237751Structure obj) { 
  ST_3feabb059aa2546826b3076d3b237751Structure s = new ST_3feabb059aa2546826b3076d3b237751Structure();
  if(obj != null) {
  s.ssStatus = obj.AttrStatus == null ? "" : obj.AttrStatus;
  s.ssDescripcionStatus = obj.AttrDescripcionStatus == null ? "" : obj.AttrDescripcionStatus;
  s.ssCPago = obj.AttrCPago == null ? "" : obj.AttrCPago;
  s.ssClaveDescripcion = obj.AttrClaveDescripcion == null ? "" : obj.AttrClaveDescripcion;
  }
  return s;
}

public static Func<ST_3feabb059aa2546826b3076d3b237751Structure, ssConectaProveedores.RestRecords.RESTST_3feabb059aa2546826b3076d3b237751Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_3feabb059aa2546826b3076d3b237751Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_3feabb059aa2546826b3076d3b237751Structure FromStructure(ST_3feabb059aa2546826b3076d3b237751Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_3feabb059aa2546826b3076d3b237751Structure(s, config);
}

}


