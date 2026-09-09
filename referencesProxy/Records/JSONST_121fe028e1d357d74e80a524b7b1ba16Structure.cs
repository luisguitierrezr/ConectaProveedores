using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// ItemEM_RM
public class JSONST_121fe028e1d357d74e80a524b7b1ba16Structure : AbstractRESTStructure<ST_121fe028e1d357d74e80a524b7b1ba16Structure> {
[JsonProperty("POSICION_PEDIDO")]
[JsonPropertyName("POSICION_PEDIDO")]
public string AttrPOSICION_PEDIDO;

[JsonProperty("MATERIAL")]
[JsonPropertyName("MATERIAL")]
public string AttrMATERIAL;

[JsonProperty("CANTIDAD_ENTRADA")]
[JsonPropertyName("CANTIDAD_ENTRADA")]
public string AttrCANTIDAD_ENTRADA;

[JsonProperty("CENTRO")]
[JsonPropertyName("CENTRO")]
public string AttrCENTRO;

[JsonProperty("ALMACEN")]
[JsonPropertyName("ALMACEN")]
public string AttrALMACEN;

[JsonProperty("TEXTO_POSICION")]
[JsonPropertyName("TEXTO_POSICION")]
public string AttrTEXTO_POSICION;

public JSONST_121fe028e1d357d74e80a524b7b1ba16Structure() { }

public JSONST_121fe028e1d357d74e80a524b7b1ba16Structure (ST_121fe028e1d357d74e80a524b7b1ba16Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPOSICION_PEDIDO = ConvertToRestWithoutDefaults(s.ssPOSICION_PEDIDO, "");
AttrMATERIAL = ConvertToRestWithoutDefaults(s.ssMATERIAL, "");
AttrCANTIDAD_ENTRADA = ConvertToRestWithoutDefaults(s.ssCANTIDAD_ENTRADA, "");
AttrCENTRO = ConvertToRestWithoutDefaults(s.ssCENTRO, "");
AttrALMACEN = ConvertToRestWithoutDefaults(s.ssALMACEN, "");
AttrTEXTO_POSICION = ConvertToRestWithoutDefaults(s.ssTEXTO_POSICION, "");
  } else {
AttrPOSICION_PEDIDO = s.ssPOSICION_PEDIDO;
AttrMATERIAL = s.ssMATERIAL;
AttrCANTIDAD_ENTRADA = s.ssCANTIDAD_ENTRADA;
AttrCENTRO = s.ssCENTRO;
AttrALMACEN = s.ssALMACEN;
AttrTEXTO_POSICION = s.ssTEXTO_POSICION;
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_121fe028e1d357d74e80a524b7b1ba16Structure, ST_121fe028e1d357d74e80a524b7b1ba16Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_121fe028e1d357d74e80a524b7b1ba16Structure s) => ToStructure(s, config);
}
public static ST_121fe028e1d357d74e80a524b7b1ba16Structure ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_121fe028e1d357d74e80a524b7b1ba16Structure obj, IBehaviorsConfiguration config) { 
  ST_121fe028e1d357d74e80a524b7b1ba16Structure s = new ST_121fe028e1d357d74e80a524b7b1ba16Structure();
  if(obj != null) {
  s.ssPOSICION_PEDIDO = obj.AttrPOSICION_PEDIDO == null ? "" : obj.AttrPOSICION_PEDIDO;
  s.ssMATERIAL = obj.AttrMATERIAL == null ? "" : obj.AttrMATERIAL;
  s.ssCANTIDAD_ENTRADA = obj.AttrCANTIDAD_ENTRADA == null ? "" : obj.AttrCANTIDAD_ENTRADA;
  s.ssCENTRO = obj.AttrCENTRO == null ? "" : obj.AttrCENTRO;
  s.ssALMACEN = obj.AttrALMACEN == null ? "" : obj.AttrALMACEN;
  s.ssTEXTO_POSICION = obj.AttrTEXTO_POSICION == null ? "" : obj.AttrTEXTO_POSICION;
  }
  return s;
}

public static Func<ST_121fe028e1d357d74e80a524b7b1ba16Structure, ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_121fe028e1d357d74e80a524b7b1ba16Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_121fe028e1d357d74e80a524b7b1ba16Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_121fe028e1d357d74e80a524b7b1ba16Structure FromStructure(ST_121fe028e1d357d74e80a524b7b1ba16Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_121fe028e1d357d74e80a524b7b1ba16Structure(s, config);
}

}


