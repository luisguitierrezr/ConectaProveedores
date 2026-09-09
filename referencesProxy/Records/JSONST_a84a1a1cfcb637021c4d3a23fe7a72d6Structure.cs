using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// PI_ITEM_EM3
public class JSONST_a84a1a1cfcb637021c4d3a23fe7a72d6Structure : AbstractRESTStructure<ST_a84a1a1cfcb637021c4d3a23fe7a72d6Structure> {
[JsonProperty("POSICION_PEDIDO")]
[JsonPropertyName("POSICION_PEDIDO")]
public int? AttrPOSICION_PEDIDO;

[JsonProperty("MATERIAL")]
[JsonPropertyName("MATERIAL")]
public string AttrMATERIAL;

[JsonProperty("CANTIDAD_ENTRADA")]
[JsonPropertyName("CANTIDAD_ENTRADA")]
public decimal? AttrCANTIDAD_ENTRADA;

[JsonProperty("CENTRO")]
[JsonPropertyName("CENTRO")]
public string AttrCENTRO;

[JsonProperty("ALMACEN")]
[JsonPropertyName("ALMACEN")]
public string AttrALMACEN;

[JsonProperty("TEXTO_POSICION")]
[JsonPropertyName("TEXTO_POSICION")]
public string AttrTEXTO_POSICION;

public JSONST_a84a1a1cfcb637021c4d3a23fe7a72d6Structure() { }

public JSONST_a84a1a1cfcb637021c4d3a23fe7a72d6Structure (ST_a84a1a1cfcb637021c4d3a23fe7a72d6Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPOSICION_PEDIDO = ConvertToRestWithoutDefaults(s.ssPOSICION_PEDIDO, -2147483648);
AttrMATERIAL = ConvertToRestWithoutDefaults(s.ssMATERIAL, "");
AttrCANTIDAD_ENTRADA = ConvertToRestWithoutDefaults(s.ssCANTIDAD_ENTRADA, -79228162514264337593543950335m);
AttrCENTRO = ConvertToRestWithoutDefaults(s.ssCENTRO, "");
AttrALMACEN = ConvertToRestWithoutDefaults(s.ssALMACEN, "");
AttrTEXTO_POSICION = ConvertToRestWithoutDefaults(s.ssTEXTO_POSICION, "");
  } else {
AttrPOSICION_PEDIDO = (int?) s.ssPOSICION_PEDIDO;
AttrMATERIAL = s.ssMATERIAL;
AttrCANTIDAD_ENTRADA = (decimal?) s.ssCANTIDAD_ENTRADA;
AttrCENTRO = s.ssCENTRO;
AttrALMACEN = s.ssALMACEN;
AttrTEXTO_POSICION = s.ssTEXTO_POSICION;
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_a84a1a1cfcb637021c4d3a23fe7a72d6Structure, ST_a84a1a1cfcb637021c4d3a23fe7a72d6Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_a84a1a1cfcb637021c4d3a23fe7a72d6Structure s) => ToStructure(s, config);
}
public static ST_a84a1a1cfcb637021c4d3a23fe7a72d6Structure ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_a84a1a1cfcb637021c4d3a23fe7a72d6Structure obj, IBehaviorsConfiguration config) { 
  ST_a84a1a1cfcb637021c4d3a23fe7a72d6Structure s = new ST_a84a1a1cfcb637021c4d3a23fe7a72d6Structure();
  if(obj != null) {
  s.ssPOSICION_PEDIDO = obj.AttrPOSICION_PEDIDO == null ? -2147483648 : obj.AttrPOSICION_PEDIDO.Value;
  s.ssMATERIAL = obj.AttrMATERIAL == null ? "" : obj.AttrMATERIAL;
  s.ssCANTIDAD_ENTRADA = obj.AttrCANTIDAD_ENTRADA == null ? -79228162514264337593543950335m : obj.AttrCANTIDAD_ENTRADA.Value;
  s.ssCENTRO = obj.AttrCENTRO == null ? "" : obj.AttrCENTRO;
  s.ssALMACEN = obj.AttrALMACEN == null ? "" : obj.AttrALMACEN;
  s.ssTEXTO_POSICION = obj.AttrTEXTO_POSICION == null ? "" : obj.AttrTEXTO_POSICION;
  }
  return s;
}

public static Func<ST_a84a1a1cfcb637021c4d3a23fe7a72d6Structure, ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_a84a1a1cfcb637021c4d3a23fe7a72d6Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_a84a1a1cfcb637021c4d3a23fe7a72d6Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_a84a1a1cfcb637021c4d3a23fe7a72d6Structure FromStructure(ST_a84a1a1cfcb637021c4d3a23fe7a72d6Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_a84a1a1cfcb637021c4d3a23fe7a72d6Structure(s, config);
}

}


