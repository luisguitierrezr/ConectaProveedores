using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// PI_ITEM_SM
public class JSONST_e676179583470b305e615630acee7039Structure : AbstractRESTStructure<ST_e676179583470b305e615630acee7039Structure> {
[JsonProperty("POSICION_PEDIDO")]
[JsonPropertyName("POSICION_PEDIDO")]
public string AttrPOSICION_PEDIDO;

[JsonProperty("MATERIAL")]
[JsonPropertyName("MATERIAL")]
public string AttrMATERIAL;

[JsonProperty("CANTIDAD_SALIDA")]
[JsonPropertyName("CANTIDAD_SALIDA")]
public decimal? AttrCANTIDAD_SALIDA;

[JsonProperty("CENTRO")]
[JsonPropertyName("CENTRO")]
public string AttrCENTRO;

[JsonProperty("ALMACEN")]
[JsonPropertyName("ALMACEN")]
public string AttrALMACEN;

[JsonProperty("CUENTA_DE_MAYOR")]
[JsonPropertyName("CUENTA_DE_MAYOR")]
public string AttrCUENTA_DE_MAYOR;

[JsonProperty("CENTRO_DE_COSTO")]
[JsonPropertyName("CENTRO_DE_COSTO")]
public string AttrCENTRO_DE_COSTO;

[JsonProperty("TEXTO_POSICION")]
[JsonPropertyName("TEXTO_POSICION")]
public string AttrTEXTO_POSICION;

public JSONST_e676179583470b305e615630acee7039Structure() { }

public JSONST_e676179583470b305e615630acee7039Structure (ST_e676179583470b305e615630acee7039Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPOSICION_PEDIDO = ConvertToRestWithoutDefaults(s.ssPOSICION_PEDIDO, "-2147483648");
AttrMATERIAL = ConvertToRestWithoutDefaults(s.ssMATERIAL, "");
AttrCANTIDAD_SALIDA = ConvertToRestWithoutDefaults(s.ssCANTIDAD_SALIDA, -79228162514264337593543950335m);
AttrCENTRO = ConvertToRestWithoutDefaults(s.ssCENTRO, "");
AttrALMACEN = ConvertToRestWithoutDefaults(s.ssALMACEN, "");
AttrCUENTA_DE_MAYOR = ConvertToRestWithoutDefaults(s.ssCUENTA_DE_MAYOR, "");
AttrCENTRO_DE_COSTO = ConvertToRestWithoutDefaults(s.ssCENTRO_DE_COSTO, "");
AttrTEXTO_POSICION = ConvertToRestWithoutDefaults(s.ssTEXTO_POSICION, "");
  } else {
AttrPOSICION_PEDIDO = s.ssPOSICION_PEDIDO;
AttrMATERIAL = s.ssMATERIAL;
AttrCANTIDAD_SALIDA = (decimal?) s.ssCANTIDAD_SALIDA;
AttrCENTRO = s.ssCENTRO;
AttrALMACEN = s.ssALMACEN;
AttrCUENTA_DE_MAYOR = s.ssCUENTA_DE_MAYOR;
AttrCENTRO_DE_COSTO = s.ssCENTRO_DE_COSTO;
AttrTEXTO_POSICION = s.ssTEXTO_POSICION;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_e676179583470b305e615630acee7039Structure, ST_e676179583470b305e615630acee7039Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_e676179583470b305e615630acee7039Structure s) => ToStructure(s, config);
}
public static ST_e676179583470b305e615630acee7039Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_e676179583470b305e615630acee7039Structure obj, IBehaviorsConfiguration config) { 
  ST_e676179583470b305e615630acee7039Structure s = new ST_e676179583470b305e615630acee7039Structure();
  if(obj != null) {
  s.ssPOSICION_PEDIDO = obj.AttrPOSICION_PEDIDO == null ? "-2147483648" : obj.AttrPOSICION_PEDIDO;
  s.ssMATERIAL = obj.AttrMATERIAL == null ? "" : obj.AttrMATERIAL;
  s.ssCANTIDAD_SALIDA = obj.AttrCANTIDAD_SALIDA == null ? -79228162514264337593543950335m : obj.AttrCANTIDAD_SALIDA.Value;
  s.ssCENTRO = obj.AttrCENTRO == null ? "" : obj.AttrCENTRO;
  s.ssALMACEN = obj.AttrALMACEN == null ? "" : obj.AttrALMACEN;
  s.ssCUENTA_DE_MAYOR = obj.AttrCUENTA_DE_MAYOR == null ? "" : obj.AttrCUENTA_DE_MAYOR;
  s.ssCENTRO_DE_COSTO = obj.AttrCENTRO_DE_COSTO == null ? "" : obj.AttrCENTRO_DE_COSTO;
  s.ssTEXTO_POSICION = obj.AttrTEXTO_POSICION == null ? "" : obj.AttrTEXTO_POSICION;
  }
  return s;
}

public static Func<ST_e676179583470b305e615630acee7039Structure, ssConectaProveedores.RestRecords.JSONST_e676179583470b305e615630acee7039Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_e676179583470b305e615630acee7039Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_e676179583470b305e615630acee7039Structure FromStructure(ST_e676179583470b305e615630acee7039Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_e676179583470b305e615630acee7039Structure(s, config);
}

}


