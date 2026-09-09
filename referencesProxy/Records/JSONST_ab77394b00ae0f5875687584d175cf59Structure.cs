using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// ItemSM
public class JSONST_ab77394b00ae0f5875687584d175cf59Structure : AbstractRESTStructure<ST_ab77394b00ae0f5875687584d175cf59Structure> {
[JsonProperty("POSICION_PEDIDO")]
[JsonPropertyName("POSICION_PEDIDO")]
public string AttrPOSICION_PEDIDO;

[JsonProperty("MATERIAL")]
[JsonPropertyName("MATERIAL")]
public string AttrMATERIAL;

[JsonProperty("CANTIDAD_SALIDA")]
[JsonPropertyName("CANTIDAD_SALIDA")]
public string AttrCANTIDAD_SALIDA;

[JsonProperty("CENTRO")]
[JsonPropertyName("CENTRO")]
public string AttrCENTRO;

[JsonProperty("ALMACEN")]
[JsonPropertyName("ALMACEN")]
public string AttrALMACEN;

[JsonProperty("TEXTO_POSICION")]
[JsonPropertyName("TEXTO_POSICION")]
public string AttrTEXTO_POSICION;

[JsonProperty("CUENTA_DE_MAYOR")]
[JsonPropertyName("CUENTA_DE_MAYOR")]
public string AttrCUENTA_DE_MAYOR;

[JsonProperty("CENTRO_DE_COSTO")]
[JsonPropertyName("CENTRO_DE_COSTO")]
public string AttrCENTRO_DE_COSTO;

public JSONST_ab77394b00ae0f5875687584d175cf59Structure() { }

public JSONST_ab77394b00ae0f5875687584d175cf59Structure (ST_ab77394b00ae0f5875687584d175cf59Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPOSICION_PEDIDO = ConvertToRestWithoutDefaults(s.ssPOSICION_PEDIDO, "");
AttrMATERIAL = ConvertToRestWithoutDefaults(s.ssMATERIAL, "");
AttrCANTIDAD_SALIDA = ConvertToRestWithoutDefaults(s.ssCANTIDAD_SALIDA, "");
AttrCENTRO = ConvertToRestWithoutDefaults(s.ssCENTRO, "");
AttrALMACEN = ConvertToRestWithoutDefaults(s.ssALMACEN, "");
AttrTEXTO_POSICION = ConvertToRestWithoutDefaults(s.ssTEXTO_POSICION, "");
AttrCUENTA_DE_MAYOR = ConvertToRestWithoutDefaults(s.ssCUENTA_DE_MAYOR, "");
AttrCENTRO_DE_COSTO = ConvertToRestWithoutDefaults(s.ssCENTRO_DE_COSTO, "");
  } else {
AttrPOSICION_PEDIDO = s.ssPOSICION_PEDIDO;
AttrMATERIAL = s.ssMATERIAL;
AttrCANTIDAD_SALIDA = s.ssCANTIDAD_SALIDA;
AttrCENTRO = s.ssCENTRO;
AttrALMACEN = s.ssALMACEN;
AttrTEXTO_POSICION = s.ssTEXTO_POSICION;
AttrCUENTA_DE_MAYOR = s.ssCUENTA_DE_MAYOR;
AttrCENTRO_DE_COSTO = s.ssCENTRO_DE_COSTO;
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_ab77394b00ae0f5875687584d175cf59Structure, ST_ab77394b00ae0f5875687584d175cf59Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_ab77394b00ae0f5875687584d175cf59Structure s) => ToStructure(s, config);
}
public static ST_ab77394b00ae0f5875687584d175cf59Structure ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_ab77394b00ae0f5875687584d175cf59Structure obj, IBehaviorsConfiguration config) { 
  ST_ab77394b00ae0f5875687584d175cf59Structure s = new ST_ab77394b00ae0f5875687584d175cf59Structure();
  if(obj != null) {
  s.ssPOSICION_PEDIDO = obj.AttrPOSICION_PEDIDO == null ? "" : obj.AttrPOSICION_PEDIDO;
  s.ssMATERIAL = obj.AttrMATERIAL == null ? "" : obj.AttrMATERIAL;
  s.ssCANTIDAD_SALIDA = obj.AttrCANTIDAD_SALIDA == null ? "" : obj.AttrCANTIDAD_SALIDA;
  s.ssCENTRO = obj.AttrCENTRO == null ? "" : obj.AttrCENTRO;
  s.ssALMACEN = obj.AttrALMACEN == null ? "" : obj.AttrALMACEN;
  s.ssTEXTO_POSICION = obj.AttrTEXTO_POSICION == null ? "" : obj.AttrTEXTO_POSICION;
  s.ssCUENTA_DE_MAYOR = obj.AttrCUENTA_DE_MAYOR == null ? "" : obj.AttrCUENTA_DE_MAYOR;
  s.ssCENTRO_DE_COSTO = obj.AttrCENTRO_DE_COSTO == null ? "" : obj.AttrCENTRO_DE_COSTO;
  }
  return s;
}

public static Func<ST_ab77394b00ae0f5875687584d175cf59Structure, ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_ab77394b00ae0f5875687584d175cf59Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_ab77394b00ae0f5875687584d175cf59Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_ab77394b00ae0f5875687584d175cf59Structure FromStructure(ST_ab77394b00ae0f5875687584d175cf59Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_ab77394b00ae0f5875687584d175cf59Structure(s, config);
}

}


