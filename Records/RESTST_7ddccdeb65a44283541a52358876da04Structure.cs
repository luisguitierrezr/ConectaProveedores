using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ZMXMIMMF_GENERA_PEDIDO_PDFReq
public class RESTST_7ddccdeb65a44283541a52358876da04Structure : AbstractRESTStructure<ST_7ddccdeb65a44283541a52358876da04Structure> {
[JsonProperty("PI_PEDIDO")]
public string AttrPI_PEDIDO;

public RESTST_7ddccdeb65a44283541a52358876da04Structure() { }

public RESTST_7ddccdeb65a44283541a52358876da04Structure (ST_7ddccdeb65a44283541a52358876da04Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPI_PEDIDO = ConvertToRestWithoutDefaults(s.ssPI_PEDIDO, "");
  } else {
AttrPI_PEDIDO = s.ssPI_PEDIDO;
  }
}

public static ST_7ddccdeb65a44283541a52358876da04Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_7ddccdeb65a44283541a52358876da04Structure obj) { 
  ST_7ddccdeb65a44283541a52358876da04Structure s = new ST_7ddccdeb65a44283541a52358876da04Structure();
  if(obj != null) {
  s.ssPI_PEDIDO = obj.AttrPI_PEDIDO == null ? "" : obj.AttrPI_PEDIDO;
  }
  return s;
}

public static Func<ST_7ddccdeb65a44283541a52358876da04Structure, ssConectaProveedores.RestRecords.RESTST_7ddccdeb65a44283541a52358876da04Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_7ddccdeb65a44283541a52358876da04Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_7ddccdeb65a44283541a52358876da04Structure FromStructure(ST_7ddccdeb65a44283541a52358876da04Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_7ddccdeb65a44283541a52358876da04Structure(s, config);
}

}


