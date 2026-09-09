using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ItemEM_MO
public class RESTST_8367d678111f49d602545a0a640615d6Structure : AbstractRESTStructure<ST_8367d678111f49d602545a0a640615d6Structure> {
[JsonProperty("POSICION_PEDIDO")]
public string AttrPOSICION_PEDIDO;

[JsonProperty("MATERIAL")]
public string AttrMATERIAL;

[JsonProperty("CANTIDAD_ENTRADA")]
public string AttrCANTIDAD_ENTRADA;

[JsonProperty("CENTRO")]
public string AttrCENTRO;

[JsonProperty("ALMACEN")]
public string AttrALMACEN;

[JsonProperty("TEXTO_POSICION")]
public string AttrTEXTO_POSICION;

public RESTST_8367d678111f49d602545a0a640615d6Structure() { }

public RESTST_8367d678111f49d602545a0a640615d6Structure (ST_8367d678111f49d602545a0a640615d6Structure s, IBehaviorsConfiguration config) {
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

public static ST_8367d678111f49d602545a0a640615d6Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_8367d678111f49d602545a0a640615d6Structure obj) { 
  ST_8367d678111f49d602545a0a640615d6Structure s = new ST_8367d678111f49d602545a0a640615d6Structure();
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

public static Func<ST_8367d678111f49d602545a0a640615d6Structure, ssConectaProveedores.RestRecords.RESTST_8367d678111f49d602545a0a640615d6Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_8367d678111f49d602545a0a640615d6Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_8367d678111f49d602545a0a640615d6Structure FromStructure(ST_8367d678111f49d602545a0a640615d6Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_8367d678111f49d602545a0a640615d6Structure(s, config);
}

}


