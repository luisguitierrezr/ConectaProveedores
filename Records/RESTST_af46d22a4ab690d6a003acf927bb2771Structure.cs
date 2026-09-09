using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// PI_HEADER2
public class RESTST_af46d22a4ab690d6a003acf927bb2771Structure : AbstractRESTStructure<ST_af46d22a4ab690d6a003acf927bb2771Structure> {
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

public RESTST_af46d22a4ab690d6a003acf927bb2771Structure() { }

public RESTST_af46d22a4ab690d6a003acf927bb2771Structure (ST_af46d22a4ab690d6a003acf927bb2771Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPEDIDO = ConvertToRestWithoutDefaults(s.ssPEDIDO, "");
AttrPROVEEDOR = ConvertToRestWithoutDefaults(s.ssPROVEEDOR, "");
AttrNUMERO_FACTURA = ConvertToRestWithoutDefaults(s.ssNUMERO_FACTURA, "");
AttrCARTA_PORTE = ConvertToRestWithoutDefaults(s.ssCARTA_PORTE, "");
AttrTEXTO_CABECERA = ConvertToRestWithoutDefaults(s.ssTEXTO_CABECERA, "");
AttrUUID = ConvertToRestWithoutDefaults(s.ssUUID, "");
AttrFECHA_CONTABILIZACION = ConvertToRestWithoutDefaults(s.ssFECHA_CONTABILIZACION, "");
AttrFECHA_REGISTRO = ConvertToRestWithoutDefaults(s.ssFECHA_REGISTRO, "");
  } else {
AttrPEDIDO = s.ssPEDIDO;
AttrPROVEEDOR = s.ssPROVEEDOR;
AttrNUMERO_FACTURA = s.ssNUMERO_FACTURA;
AttrCARTA_PORTE = s.ssCARTA_PORTE;
AttrTEXTO_CABECERA = s.ssTEXTO_CABECERA;
AttrUUID = s.ssUUID;
AttrFECHA_CONTABILIZACION = s.ssFECHA_CONTABILIZACION;
AttrFECHA_REGISTRO = s.ssFECHA_REGISTRO;
  }
}

public static ST_af46d22a4ab690d6a003acf927bb2771Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_af46d22a4ab690d6a003acf927bb2771Structure obj) { 
  ST_af46d22a4ab690d6a003acf927bb2771Structure s = new ST_af46d22a4ab690d6a003acf927bb2771Structure();
  if(obj != null) {
  s.ssPEDIDO = obj.AttrPEDIDO == null ? "" : obj.AttrPEDIDO;
  s.ssPROVEEDOR = obj.AttrPROVEEDOR == null ? "" : obj.AttrPROVEEDOR;
  s.ssNUMERO_FACTURA = obj.AttrNUMERO_FACTURA == null ? "" : obj.AttrNUMERO_FACTURA;
  s.ssCARTA_PORTE = obj.AttrCARTA_PORTE == null ? "" : obj.AttrCARTA_PORTE;
  s.ssTEXTO_CABECERA = obj.AttrTEXTO_CABECERA == null ? "" : obj.AttrTEXTO_CABECERA;
  s.ssUUID = obj.AttrUUID == null ? "" : obj.AttrUUID;
  s.ssFECHA_CONTABILIZACION = obj.AttrFECHA_CONTABILIZACION == null ? "" : obj.AttrFECHA_CONTABILIZACION;
  s.ssFECHA_REGISTRO = obj.AttrFECHA_REGISTRO == null ? "" : obj.AttrFECHA_REGISTRO;
  }
  return s;
}

public static Func<ST_af46d22a4ab690d6a003acf927bb2771Structure, ssConectaProveedores.RestRecords.RESTST_af46d22a4ab690d6a003acf927bb2771Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_af46d22a4ab690d6a003acf927bb2771Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_af46d22a4ab690d6a003acf927bb2771Structure FromStructure(ST_af46d22a4ab690d6a003acf927bb2771Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_af46d22a4ab690d6a003acf927bb2771Structure(s, config);
}

}


