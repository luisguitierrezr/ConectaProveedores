using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// PI_HEADER_RM
public class RESTST_cab398c7a09085084636430b80f5aa0dStructure : AbstractRESTStructure<ST_cab398c7a09085084636430b80f5aa0dStructure> {
[JsonProperty("PEDIDO")]
public string AttrPEDIDO;

[JsonProperty("PROVEEDOR")]
public string AttrPROVEEDOR;

[JsonProperty("NUMERO_FACTURA")]
public string AttrNUMERO_FACTURA;

[JsonProperty("CARTA_PORTE")]
public string AttrCARTA_PORTE;

[JsonProperty("TEXTO_CABECERA")]
public string AttrTEXTO_CABECERA;

[JsonProperty("UUID")]
public string AttrUUID;

[JsonProperty("FECHA_CONTABILIZACION")]
public string AttrFECHA_CONTABILIZACION;

[JsonProperty("FECHA_REGISTRO")]
public string AttrFECHA_REGISTRO;

[JsonProperty("VALE_MATERIAL_SM")]
public string AttrVALE_MATERIAL_SM;

[JsonProperty("TEXTO_CABECERA_SM")]
public string AttrTEXTO_CABECERA_SM;

public RESTST_cab398c7a09085084636430b80f5aa0dStructure() { }

public RESTST_cab398c7a09085084636430b80f5aa0dStructure (ST_cab398c7a09085084636430b80f5aa0dStructure s, IBehaviorsConfiguration config) {
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

public static ST_cab398c7a09085084636430b80f5aa0dStructure ToStructure(ssConectaProveedores.RestRecords.RESTST_cab398c7a09085084636430b80f5aa0dStructure obj) { 
  ST_cab398c7a09085084636430b80f5aa0dStructure s = new ST_cab398c7a09085084636430b80f5aa0dStructure();
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

public static Func<ST_cab398c7a09085084636430b80f5aa0dStructure, ssConectaProveedores.RestRecords.RESTST_cab398c7a09085084636430b80f5aa0dStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_cab398c7a09085084636430b80f5aa0dStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_cab398c7a09085084636430b80f5aa0dStructure FromStructure(ST_cab398c7a09085084636430b80f5aa0dStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_cab398c7a09085084636430b80f5aa0dStructure(s, config);
}

}


