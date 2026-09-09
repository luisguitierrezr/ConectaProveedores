using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// CfdFileWrapper
public class JSONST_1e51b813a2c6a26cea1c6c8c17329da8Structure : AbstractRESTStructure<ST_1e51b813a2c6a26cea1c6c8c17329da8Structure> {
[JsonProperty("sociedad")]
[JsonPropertyName("sociedad")]
public string AttrSociedad;

[JsonProperty("cveProveedor")]
[JsonPropertyName("cveProveedor")]
public string AttrCveProveedor;

[JsonProperty("fileName")]
[JsonPropertyName("fileName")]
public string AttrFileName;

[JsonProperty("region")]
[JsonPropertyName("region")]
public string AttrRegion;

[JsonProperty("area")]
[JsonPropertyName("area")]
public string AttrArea;

[JsonProperty("capturaOrden")]
[JsonPropertyName("capturaOrden")]
public string AttrCapturaOrden;

[JsonProperty("factAnticipo")]
[JsonPropertyName("factAnticipo")]
public string AttrFactAnticipo;

[JsonProperty("factServicio")]
[JsonPropertyName("factServicio")]
public string AttrFactServicio;

[JsonProperty("ordenCompra")]
[JsonPropertyName("ordenCompra")]
public string AttrOrdenCompra;

[JsonProperty("entradaMercancia")]
[JsonPropertyName("entradaMercancia")]
public string AttrEntradaMercancia;

[JsonProperty("docType")]
[JsonPropertyName("docType")]
public string AttrDocType;

[JsonProperty("facturaEquipoCelular")]
[JsonPropertyName("facturaEquipoCelular")]
public string AttrFacturaEquipoCelular;

public JSONST_1e51b813a2c6a26cea1c6c8c17329da8Structure() { }

public JSONST_1e51b813a2c6a26cea1c6c8c17329da8Structure (ST_1e51b813a2c6a26cea1c6c8c17329da8Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSociedad = ConvertToRestWithoutDefaults(s.ssSociedad, "");
AttrCveProveedor = ConvertToRestWithoutDefaults(s.ssCveProveedor, "");
AttrFileName = ConvertToRestWithoutDefaults(s.ssFileName, "");
AttrRegion = ConvertToRestWithoutDefaults(s.ssRegion, "");
AttrArea = ConvertToRestWithoutDefaults(s.ssArea, "");
AttrCapturaOrden = ConvertToRestWithoutDefaults(s.ssCapturaOrden, "");
AttrFactAnticipo = ConvertToRestWithoutDefaults(s.ssFactAnticipo, "");
AttrFactServicio = ConvertToRestWithoutDefaults(s.ssFactServicio, "");
AttrOrdenCompra = ConvertToRestWithoutDefaults(s.ssOrdenCompra, "");
AttrEntradaMercancia = ConvertToRestWithoutDefaults(s.ssEntradaMercancia, "");
AttrDocType = ConvertToRestWithoutDefaults(s.ssDocType, "");
AttrFacturaEquipoCelular = ConvertToRestWithoutDefaults(s.ssFacturaEquipoCelular, "");
  } else {
AttrSociedad = s.ssSociedad;
AttrCveProveedor = s.ssCveProveedor;
AttrFileName = s.ssFileName;
AttrRegion = s.ssRegion;
AttrArea = s.ssArea;
AttrCapturaOrden = s.ssCapturaOrden;
AttrFactAnticipo = s.ssFactAnticipo;
AttrFactServicio = s.ssFactServicio;
AttrOrdenCompra = s.ssOrdenCompra;
AttrEntradaMercancia = s.ssEntradaMercancia;
AttrDocType = s.ssDocType;
AttrFacturaEquipoCelular = s.ssFacturaEquipoCelular;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_1e51b813a2c6a26cea1c6c8c17329da8Structure, ST_1e51b813a2c6a26cea1c6c8c17329da8Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_1e51b813a2c6a26cea1c6c8c17329da8Structure s) => ToStructure(s, config);
}
public static ST_1e51b813a2c6a26cea1c6c8c17329da8Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_1e51b813a2c6a26cea1c6c8c17329da8Structure obj, IBehaviorsConfiguration config) { 
  ST_1e51b813a2c6a26cea1c6c8c17329da8Structure s = new ST_1e51b813a2c6a26cea1c6c8c17329da8Structure();
  if(obj != null) {
  s.ssSociedad = obj.AttrSociedad == null ? "" : obj.AttrSociedad;
  s.ssCveProveedor = obj.AttrCveProveedor == null ? "" : obj.AttrCveProveedor;
  s.ssFileName = obj.AttrFileName == null ? "" : obj.AttrFileName;
  s.ssRegion = obj.AttrRegion == null ? "" : obj.AttrRegion;
  s.ssArea = obj.AttrArea == null ? "" : obj.AttrArea;
  s.ssCapturaOrden = obj.AttrCapturaOrden == null ? "" : obj.AttrCapturaOrden;
  s.ssFactAnticipo = obj.AttrFactAnticipo == null ? "" : obj.AttrFactAnticipo;
  s.ssFactServicio = obj.AttrFactServicio == null ? "" : obj.AttrFactServicio;
  s.ssOrdenCompra = obj.AttrOrdenCompra == null ? "" : obj.AttrOrdenCompra;
  s.ssEntradaMercancia = obj.AttrEntradaMercancia == null ? "" : obj.AttrEntradaMercancia;
  s.ssDocType = obj.AttrDocType == null ? "" : obj.AttrDocType;
  s.ssFacturaEquipoCelular = obj.AttrFacturaEquipoCelular == null ? "" : obj.AttrFacturaEquipoCelular;
  }
  return s;
}

public static Func<ST_1e51b813a2c6a26cea1c6c8c17329da8Structure, ssConectaProveedores.RestRecords.JSONST_1e51b813a2c6a26cea1c6c8c17329da8Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_1e51b813a2c6a26cea1c6c8c17329da8Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_1e51b813a2c6a26cea1c6c8c17329da8Structure FromStructure(ST_1e51b813a2c6a26cea1c6c8c17329da8Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_1e51b813a2c6a26cea1c6c8c17329da8Structure(s, config);
}

}


