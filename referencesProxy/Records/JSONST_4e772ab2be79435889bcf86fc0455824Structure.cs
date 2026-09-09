using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// PI_ITEM_EM
public class JSONST_4e772ab2be79435889bcf86fc0455824Structure : AbstractRESTStructure<ST_4e772ab2be79435889bcf86fc0455824Structure> {
[JsonProperty("POSICION_PEDIDO")]
[JsonPropertyName("POSICION_PEDIDO")]
public string AttrPOSICION_PEDIDO;

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

public JSONST_4e772ab2be79435889bcf86fc0455824Structure() { }

public JSONST_4e772ab2be79435889bcf86fc0455824Structure (ST_4e772ab2be79435889bcf86fc0455824Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPOSICION_PEDIDO = ConvertToRestWithoutDefaults(s.ssPOSICION_PEDIDO, "-2147483648");
AttrMATERIAL = ConvertToRestWithoutDefaults(s.ssMATERIAL, "");
AttrCANTIDAD_ENTRADA = ConvertToRestWithoutDefaults(s.ssCANTIDAD_ENTRADA, -79228162514264337593543950335m);
AttrCENTRO = ConvertToRestWithoutDefaults(s.ssCENTRO, "");
AttrALMACEN = ConvertToRestWithoutDefaults(s.ssALMACEN, "");
AttrTEXTO_POSICION = ConvertToRestWithoutDefaults(s.ssTEXTO_POSICION, "");
  } else {
AttrPOSICION_PEDIDO = s.ssPOSICION_PEDIDO;
AttrMATERIAL = s.ssMATERIAL;
AttrCANTIDAD_ENTRADA = (decimal?) s.ssCANTIDAD_ENTRADA;
AttrCENTRO = s.ssCENTRO;
AttrALMACEN = s.ssALMACEN;
AttrTEXTO_POSICION = s.ssTEXTO_POSICION;
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_4e772ab2be79435889bcf86fc0455824Structure, ST_4e772ab2be79435889bcf86fc0455824Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_4e772ab2be79435889bcf86fc0455824Structure s) => ToStructure(s, config);
}
public static ST_4e772ab2be79435889bcf86fc0455824Structure ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_4e772ab2be79435889bcf86fc0455824Structure obj, IBehaviorsConfiguration config) { 
  ST_4e772ab2be79435889bcf86fc0455824Structure s = new ST_4e772ab2be79435889bcf86fc0455824Structure();
  if(obj != null) {
  s.ssPOSICION_PEDIDO = obj.AttrPOSICION_PEDIDO == null ? "-2147483648" : obj.AttrPOSICION_PEDIDO;
  s.ssMATERIAL = obj.AttrMATERIAL == null ? "" : obj.AttrMATERIAL;
  s.ssCANTIDAD_ENTRADA = obj.AttrCANTIDAD_ENTRADA == null ? -79228162514264337593543950335m : obj.AttrCANTIDAD_ENTRADA.Value;
  s.ssCENTRO = obj.AttrCENTRO == null ? "" : obj.AttrCENTRO;
  s.ssALMACEN = obj.AttrALMACEN == null ? "" : obj.AttrALMACEN;
  s.ssTEXTO_POSICION = obj.AttrTEXTO_POSICION == null ? "" : obj.AttrTEXTO_POSICION;
  }
  return s;
}

public static Func<ST_4e772ab2be79435889bcf86fc0455824Structure, ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_4e772ab2be79435889bcf86fc0455824Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_4e772ab2be79435889bcf86fc0455824Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_4e772ab2be79435889bcf86fc0455824Structure FromStructure(ST_4e772ab2be79435889bcf86fc0455824Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_4e772ab2be79435889bcf86fc0455824Structure(s, config);
}

}


