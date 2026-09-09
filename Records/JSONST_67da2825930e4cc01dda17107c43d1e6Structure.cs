using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ItemSM_MO
public class JSONST_67da2825930e4cc01dda17107c43d1e6Structure : AbstractRESTStructure<ST_67da2825930e4cc01dda17107c43d1e6Structure> {
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

[JsonProperty("PEP_EMISOR")]
[JsonPropertyName("PEP_EMISOR")]
public string AttrPEP_EMISOR;

[JsonProperty("PEP_RECEPTOR")]
[JsonPropertyName("PEP_RECEPTOR")]
public string AttrPEP_RECEPTOR;

[JsonProperty("TEXTO_POSICION")]
[JsonPropertyName("TEXTO_POSICION")]
public string AttrTEXTO_POSICION;

[JsonProperty("ID_SITIO")]
[JsonPropertyName("ID_SITIO")]
public string AttrID_SITIO;

public JSONST_67da2825930e4cc01dda17107c43d1e6Structure() { }

public JSONST_67da2825930e4cc01dda17107c43d1e6Structure (ST_67da2825930e4cc01dda17107c43d1e6Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPOSICION_PEDIDO = ConvertToRestWithoutDefaults(s.ssPOSICION_PEDIDO, "");
AttrMATERIAL = ConvertToRestWithoutDefaults(s.ssMATERIAL, "");
AttrCANTIDAD_SALIDA = ConvertToRestWithoutDefaults(s.ssCANTIDAD_SALIDA, "");
AttrCENTRO = ConvertToRestWithoutDefaults(s.ssCENTRO, "");
AttrALMACEN = ConvertToRestWithoutDefaults(s.ssALMACEN, "");
AttrPEP_EMISOR = ConvertToRestWithoutDefaults(s.ssPEP_EMISOR, "");
AttrPEP_RECEPTOR = ConvertToRestWithoutDefaults(s.ssPEP_RECEPTOR, "");
AttrTEXTO_POSICION = ConvertToRestWithoutDefaults(s.ssTEXTO_POSICION, "");
AttrID_SITIO = ConvertToRestWithoutDefaults(s.ssID_SITIO, "");
  } else {
AttrPOSICION_PEDIDO = s.ssPOSICION_PEDIDO;
AttrMATERIAL = s.ssMATERIAL;
AttrCANTIDAD_SALIDA = s.ssCANTIDAD_SALIDA;
AttrCENTRO = s.ssCENTRO;
AttrALMACEN = s.ssALMACEN;
AttrPEP_EMISOR = s.ssPEP_EMISOR;
AttrPEP_RECEPTOR = s.ssPEP_RECEPTOR;
AttrTEXTO_POSICION = s.ssTEXTO_POSICION;
AttrID_SITIO = s.ssID_SITIO;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_67da2825930e4cc01dda17107c43d1e6Structure, ST_67da2825930e4cc01dda17107c43d1e6Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_67da2825930e4cc01dda17107c43d1e6Structure s) => ToStructure(s, config);
}
public static ST_67da2825930e4cc01dda17107c43d1e6Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_67da2825930e4cc01dda17107c43d1e6Structure obj, IBehaviorsConfiguration config) { 
  ST_67da2825930e4cc01dda17107c43d1e6Structure s = new ST_67da2825930e4cc01dda17107c43d1e6Structure();
  if(obj != null) {
  s.ssPOSICION_PEDIDO = obj.AttrPOSICION_PEDIDO == null ? "" : obj.AttrPOSICION_PEDIDO;
  s.ssMATERIAL = obj.AttrMATERIAL == null ? "" : obj.AttrMATERIAL;
  s.ssCANTIDAD_SALIDA = obj.AttrCANTIDAD_SALIDA == null ? "" : obj.AttrCANTIDAD_SALIDA;
  s.ssCENTRO = obj.AttrCENTRO == null ? "" : obj.AttrCENTRO;
  s.ssALMACEN = obj.AttrALMACEN == null ? "" : obj.AttrALMACEN;
  s.ssPEP_EMISOR = obj.AttrPEP_EMISOR == null ? "" : obj.AttrPEP_EMISOR;
  s.ssPEP_RECEPTOR = obj.AttrPEP_RECEPTOR == null ? "" : obj.AttrPEP_RECEPTOR;
  s.ssTEXTO_POSICION = obj.AttrTEXTO_POSICION == null ? "" : obj.AttrTEXTO_POSICION;
  s.ssID_SITIO = obj.AttrID_SITIO == null ? "" : obj.AttrID_SITIO;
  }
  return s;
}

public static Func<ST_67da2825930e4cc01dda17107c43d1e6Structure, ssConectaProveedores.RestRecords.JSONST_67da2825930e4cc01dda17107c43d1e6Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_67da2825930e4cc01dda17107c43d1e6Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_67da2825930e4cc01dda17107c43d1e6Structure FromStructure(ST_67da2825930e4cc01dda17107c43d1e6Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_67da2825930e4cc01dda17107c43d1e6Structure(s, config);
}

}


