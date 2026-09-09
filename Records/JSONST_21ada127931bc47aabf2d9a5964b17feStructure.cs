using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// PI_ITEM_SM3
public class JSONST_21ada127931bc47aabf2d9a5964b17feStructure : AbstractRESTStructure<ST_21ada127931bc47aabf2d9a5964b17feStructure> {
[JsonProperty("POSICION_PEDIDO")]
[JsonPropertyName("POSICION_PEDIDO")]
public int? AttrPOSICION_PEDIDO;

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

[JsonProperty("PEP_RECEPTOR")]
[JsonPropertyName("PEP_RECEPTOR")]
public string AttrPEP_RECEPTOR;

[JsonProperty("TEXTO_POSICION")]
[JsonPropertyName("TEXTO_POSICION")]
public string AttrTEXTO_POSICION;

[JsonProperty("ID_SITIO")]
[JsonPropertyName("ID_SITIO")]
public string AttrID_SITIO;

public JSONST_21ada127931bc47aabf2d9a5964b17feStructure() { }

public JSONST_21ada127931bc47aabf2d9a5964b17feStructure (ST_21ada127931bc47aabf2d9a5964b17feStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPOSICION_PEDIDO = ConvertToRestWithoutDefaults(s.ssPOSICION_PEDIDO, -2147483648);
AttrMATERIAL = ConvertToRestWithoutDefaults(s.ssMATERIAL, "");
AttrCANTIDAD_SALIDA = ConvertToRestWithoutDefaults(s.ssCANTIDAD_SALIDA, -79228162514264337593543950335m);
AttrCENTRO = ConvertToRestWithoutDefaults(s.ssCENTRO, "");
AttrALMACEN = ConvertToRestWithoutDefaults(s.ssALMACEN, "");
AttrPEP_RECEPTOR = ConvertToRestWithoutDefaults(s.ssPEP_RECEPTOR, "");
AttrTEXTO_POSICION = ConvertToRestWithoutDefaults(s.ssTEXTO_POSICION, "");
AttrID_SITIO = ConvertToRestWithoutDefaults(s.ssID_SITIO, "");
  } else {
AttrPOSICION_PEDIDO = (int?) s.ssPOSICION_PEDIDO;
AttrMATERIAL = s.ssMATERIAL;
AttrCANTIDAD_SALIDA = (decimal?) s.ssCANTIDAD_SALIDA;
AttrCENTRO = s.ssCENTRO;
AttrALMACEN = s.ssALMACEN;
AttrPEP_RECEPTOR = s.ssPEP_RECEPTOR;
AttrTEXTO_POSICION = s.ssTEXTO_POSICION;
AttrID_SITIO = s.ssID_SITIO;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_21ada127931bc47aabf2d9a5964b17feStructure, ST_21ada127931bc47aabf2d9a5964b17feStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_21ada127931bc47aabf2d9a5964b17feStructure s) => ToStructure(s, config);
}
public static ST_21ada127931bc47aabf2d9a5964b17feStructure ToStructure(ssConectaProveedores.RestRecords.JSONST_21ada127931bc47aabf2d9a5964b17feStructure obj, IBehaviorsConfiguration config) { 
  ST_21ada127931bc47aabf2d9a5964b17feStructure s = new ST_21ada127931bc47aabf2d9a5964b17feStructure();
  if(obj != null) {
  s.ssPOSICION_PEDIDO = obj.AttrPOSICION_PEDIDO == null ? -2147483648 : obj.AttrPOSICION_PEDIDO.Value;
  s.ssMATERIAL = obj.AttrMATERIAL == null ? "" : obj.AttrMATERIAL;
  s.ssCANTIDAD_SALIDA = obj.AttrCANTIDAD_SALIDA == null ? -79228162514264337593543950335m : obj.AttrCANTIDAD_SALIDA.Value;
  s.ssCENTRO = obj.AttrCENTRO == null ? "" : obj.AttrCENTRO;
  s.ssALMACEN = obj.AttrALMACEN == null ? "" : obj.AttrALMACEN;
  s.ssPEP_RECEPTOR = obj.AttrPEP_RECEPTOR == null ? "" : obj.AttrPEP_RECEPTOR;
  s.ssTEXTO_POSICION = obj.AttrTEXTO_POSICION == null ? "" : obj.AttrTEXTO_POSICION;
  s.ssID_SITIO = obj.AttrID_SITIO == null ? "" : obj.AttrID_SITIO;
  }
  return s;
}

public static Func<ST_21ada127931bc47aabf2d9a5964b17feStructure, ssConectaProveedores.RestRecords.JSONST_21ada127931bc47aabf2d9a5964b17feStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_21ada127931bc47aabf2d9a5964b17feStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_21ada127931bc47aabf2d9a5964b17feStructure FromStructure(ST_21ada127931bc47aabf2d9a5964b17feStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_21ada127931bc47aabf2d9a5964b17feStructure(s, config);
}

}


