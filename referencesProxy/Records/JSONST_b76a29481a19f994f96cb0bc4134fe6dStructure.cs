using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// PI_HEADER_CECO
public class JSONST_b76a29481a19f994f96cb0bc4134fe6dStructure : AbstractRESTStructure<ST_b76a29481a19f994f96cb0bc4134fe6dStructure> {
[JsonProperty("PEDIDO")]
[JsonPropertyName("PEDIDO")]
public string AttrPEDIDO;

[JsonProperty("PROVEEDOR")]
[JsonPropertyName("PROVEEDOR")]
public string AttrPROVEEDOR;

[JsonProperty("NUMERO_FACTURA")]
[JsonPropertyName("NUMERO_FACTURA")]
public string AttrNUMERO_FACTURA;

[JsonProperty("CARTA_PORTE")]
[JsonPropertyName("CARTA_PORTE")]
public string AttrCARTA_PORTE;

[JsonProperty("TEXTO_CABECERA")]
[JsonPropertyName("TEXTO_CABECERA")]
public string AttrTEXTO_CABECERA;

[JsonProperty("UUID")]
[JsonPropertyName("UUID")]
public string AttrUUID;

[JsonProperty("FECHA_CONTABILIZACION")]
[JsonPropertyName("FECHA_CONTABILIZACION")]
public string AttrFECHA_CONTABILIZACION;

[JsonProperty("FECHA_REGISTRO")]
[JsonPropertyName("FECHA_REGISTRO")]
public string AttrFECHA_REGISTRO;

[JsonProperty("VALE_MATERIAL_SM")]
[JsonPropertyName("VALE_MATERIAL_SM")]
public string AttrVALE_MATERIAL_SM;

[JsonProperty("TEXTO_CABECERA_SM")]
[JsonPropertyName("TEXTO_CABECERA_SM")]
public string AttrTEXTO_CABECERA_SM;

public JSONST_b76a29481a19f994f96cb0bc4134fe6dStructure() { }

public JSONST_b76a29481a19f994f96cb0bc4134fe6dStructure (ST_b76a29481a19f994f96cb0bc4134fe6dStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPEDIDO = ConvertToRestWithoutDefaults(s.ssPEDIDO, "");
AttrPROVEEDOR = ConvertToRestWithoutDefaults(s.ssPROVEEDOR, "");
AttrNUMERO_FACTURA = ConvertToRestWithoutDefaults(s.ssNUMERO_FACTURA, "");
AttrCARTA_PORTE = ConvertToRestWithoutDefaults(s.ssCARTA_PORTE, "");
AttrTEXTO_CABECERA = ConvertToRestWithoutDefaults(s.ssTEXTO_CABECERA, "");
AttrUUID = ConvertToRestWithoutDefaults(s.ssUUID, "");
AttrFECHA_CONTABILIZACION = ConvertToRestWithoutDefaults(s.ssFECHA_CONTABILIZACION, "");
AttrFECHA_REGISTRO = ConvertToRestWithoutDefaults(s.ssFECHA_REGISTRO, "");
AttrVALE_MATERIAL_SM = ConvertToRestWithoutDefaults(s.ssVALE_MATERIAL_SM, "");
AttrTEXTO_CABECERA_SM = ConvertToRestWithoutDefaults(s.ssTEXTO_CABECERA_SM, "");
  } else {
AttrPEDIDO = s.ssPEDIDO;
AttrPROVEEDOR = s.ssPROVEEDOR;
AttrNUMERO_FACTURA = s.ssNUMERO_FACTURA;
AttrCARTA_PORTE = s.ssCARTA_PORTE;
AttrTEXTO_CABECERA = s.ssTEXTO_CABECERA;
AttrUUID = s.ssUUID;
AttrFECHA_CONTABILIZACION = s.ssFECHA_CONTABILIZACION;
AttrFECHA_REGISTRO = s.ssFECHA_REGISTRO;
AttrVALE_MATERIAL_SM = s.ssVALE_MATERIAL_SM;
AttrTEXTO_CABECERA_SM = s.ssTEXTO_CABECERA_SM;
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b76a29481a19f994f96cb0bc4134fe6dStructure, ST_b76a29481a19f994f96cb0bc4134fe6dStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b76a29481a19f994f96cb0bc4134fe6dStructure s) => ToStructure(s, config);
}
public static ST_b76a29481a19f994f96cb0bc4134fe6dStructure ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b76a29481a19f994f96cb0bc4134fe6dStructure obj, IBehaviorsConfiguration config) { 
  ST_b76a29481a19f994f96cb0bc4134fe6dStructure s = new ST_b76a29481a19f994f96cb0bc4134fe6dStructure();
  if(obj != null) {
  s.ssPEDIDO = obj.AttrPEDIDO == null ? "" : obj.AttrPEDIDO;
  s.ssPROVEEDOR = obj.AttrPROVEEDOR == null ? "" : obj.AttrPROVEEDOR;
  s.ssNUMERO_FACTURA = obj.AttrNUMERO_FACTURA == null ? "" : obj.AttrNUMERO_FACTURA;
  s.ssCARTA_PORTE = obj.AttrCARTA_PORTE == null ? "" : obj.AttrCARTA_PORTE;
  s.ssTEXTO_CABECERA = obj.AttrTEXTO_CABECERA == null ? "" : obj.AttrTEXTO_CABECERA;
  s.ssUUID = obj.AttrUUID == null ? "" : obj.AttrUUID;
  s.ssFECHA_CONTABILIZACION = obj.AttrFECHA_CONTABILIZACION == null ? "" : obj.AttrFECHA_CONTABILIZACION;
  s.ssFECHA_REGISTRO = obj.AttrFECHA_REGISTRO == null ? "" : obj.AttrFECHA_REGISTRO;
  s.ssVALE_MATERIAL_SM = obj.AttrVALE_MATERIAL_SM == null ? "" : obj.AttrVALE_MATERIAL_SM;
  s.ssTEXTO_CABECERA_SM = obj.AttrTEXTO_CABECERA_SM == null ? "" : obj.AttrTEXTO_CABECERA_SM;
  }
  return s;
}

public static Func<ST_b76a29481a19f994f96cb0bc4134fe6dStructure, ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b76a29481a19f994f96cb0bc4134fe6dStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_b76a29481a19f994f96cb0bc4134fe6dStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b76a29481a19f994f96cb0bc4134fe6dStructure FromStructure(ST_b76a29481a19f994f96cb0bc4134fe6dStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b76a29481a19f994f96cb0bc4134fe6dStructure(s, config);
}

}


