using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// PI_ITEM_SM2
public class JSONST_9327164801e6ab5e342b0e8e98c59312Structure : AbstractRESTStructure<ST_9327164801e6ab5e342b0e8e98c59312Structure> {
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

public JSONST_9327164801e6ab5e342b0e8e98c59312Structure() { }

public JSONST_9327164801e6ab5e342b0e8e98c59312Structure (ST_9327164801e6ab5e342b0e8e98c59312Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPOSICION_PEDIDO = ConvertToRestWithoutDefaults(s.ssPOSICION_PEDIDO, -2147483648);
AttrMATERIAL = ConvertToRestWithoutDefaults(s.ssMATERIAL, "");
AttrCANTIDAD_SALIDA = ConvertToRestWithoutDefaults(s.ssCANTIDAD_SALIDA, -79228162514264337593543950335m);
AttrCENTRO = ConvertToRestWithoutDefaults(s.ssCENTRO, "");
AttrALMACEN = ConvertToRestWithoutDefaults(s.ssALMACEN, "");
AttrPEP_EMISOR = ConvertToRestWithoutDefaults(s.ssPEP_EMISOR, "");
AttrPEP_RECEPTOR = ConvertToRestWithoutDefaults(s.ssPEP_RECEPTOR, "");
AttrTEXTO_POSICION = ConvertToRestWithoutDefaults(s.ssTEXTO_POSICION, "");
AttrID_SITIO = ConvertToRestWithoutDefaults(s.ssID_SITIO, "");
  } else {
AttrPOSICION_PEDIDO = (int?) s.ssPOSICION_PEDIDO;
AttrMATERIAL = s.ssMATERIAL;
AttrCANTIDAD_SALIDA = (decimal?) s.ssCANTIDAD_SALIDA;
AttrCENTRO = s.ssCENTRO;
AttrALMACEN = s.ssALMACEN;
AttrPEP_EMISOR = s.ssPEP_EMISOR;
AttrPEP_RECEPTOR = s.ssPEP_RECEPTOR;
AttrTEXTO_POSICION = s.ssTEXTO_POSICION;
AttrID_SITIO = s.ssID_SITIO;
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_9327164801e6ab5e342b0e8e98c59312Structure, ST_9327164801e6ab5e342b0e8e98c59312Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_9327164801e6ab5e342b0e8e98c59312Structure s) => ToStructure(s, config);
}
public static ST_9327164801e6ab5e342b0e8e98c59312Structure ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_9327164801e6ab5e342b0e8e98c59312Structure obj, IBehaviorsConfiguration config) { 
  ST_9327164801e6ab5e342b0e8e98c59312Structure s = new ST_9327164801e6ab5e342b0e8e98c59312Structure();
  if(obj != null) {
  s.ssPOSICION_PEDIDO = obj.AttrPOSICION_PEDIDO == null ? -2147483648 : obj.AttrPOSICION_PEDIDO.Value;
  s.ssMATERIAL = obj.AttrMATERIAL == null ? "" : obj.AttrMATERIAL;
  s.ssCANTIDAD_SALIDA = obj.AttrCANTIDAD_SALIDA == null ? -79228162514264337593543950335m : obj.AttrCANTIDAD_SALIDA.Value;
  s.ssCENTRO = obj.AttrCENTRO == null ? "" : obj.AttrCENTRO;
  s.ssALMACEN = obj.AttrALMACEN == null ? "" : obj.AttrALMACEN;
  s.ssPEP_EMISOR = obj.AttrPEP_EMISOR == null ? "" : obj.AttrPEP_EMISOR;
  s.ssPEP_RECEPTOR = obj.AttrPEP_RECEPTOR == null ? "" : obj.AttrPEP_RECEPTOR;
  s.ssTEXTO_POSICION = obj.AttrTEXTO_POSICION == null ? "" : obj.AttrTEXTO_POSICION;
  s.ssID_SITIO = obj.AttrID_SITIO == null ? "" : obj.AttrID_SITIO;
  }
  return s;
}

public static Func<ST_9327164801e6ab5e342b0e8e98c59312Structure, ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_9327164801e6ab5e342b0e8e98c59312Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_9327164801e6ab5e342b0e8e98c59312Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_9327164801e6ab5e342b0e8e98c59312Structure FromStructure(ST_9327164801e6ab5e342b0e8e98c59312Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_9327164801e6ab5e342b0e8e98c59312Structure(s, config);
}

}


