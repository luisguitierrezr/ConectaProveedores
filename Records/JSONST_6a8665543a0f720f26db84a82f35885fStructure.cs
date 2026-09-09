using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ItemEM
public class JSONST_6a8665543a0f720f26db84a82f35885fStructure : AbstractRESTStructure<ST_6a8665543a0f720f26db84a82f35885fStructure> {
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

public JSONST_6a8665543a0f720f26db84a82f35885fStructure() { }

public JSONST_6a8665543a0f720f26db84a82f35885fStructure (ST_6a8665543a0f720f26db84a82f35885fStructure s, IBehaviorsConfiguration config) {
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

public static Func<ssConectaProveedores.RestRecords.JSONST_6a8665543a0f720f26db84a82f35885fStructure, ST_6a8665543a0f720f26db84a82f35885fStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_6a8665543a0f720f26db84a82f35885fStructure s) => ToStructure(s, config);
}
public static ST_6a8665543a0f720f26db84a82f35885fStructure ToStructure(ssConectaProveedores.RestRecords.JSONST_6a8665543a0f720f26db84a82f35885fStructure obj, IBehaviorsConfiguration config) { 
  ST_6a8665543a0f720f26db84a82f35885fStructure s = new ST_6a8665543a0f720f26db84a82f35885fStructure();
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

public static Func<ST_6a8665543a0f720f26db84a82f35885fStructure, ssConectaProveedores.RestRecords.JSONST_6a8665543a0f720f26db84a82f35885fStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_6a8665543a0f720f26db84a82f35885fStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_6a8665543a0f720f26db84a82f35885fStructure FromStructure(ST_6a8665543a0f720f26db84a82f35885fStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_6a8665543a0f720f26db84a82f35885fStructure(s, config);
}

}


