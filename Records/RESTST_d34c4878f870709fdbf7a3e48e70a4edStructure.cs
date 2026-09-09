using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// PI_ITEM
public class RESTST_d34c4878f870709fdbf7a3e48e70a4edStructure : AbstractRESTStructure<ST_d34c4878f870709fdbf7a3e48e70a4edStructure> {
[JsonProperty("POSICION_PEDIDO")]
public int? AttrPOSICION_PEDIDO;

[JsonProperty("MATERIAL")]
public string AttrMATERIAL;

[JsonProperty("CENTRO")]
public string AttrCENTRO;

[JsonProperty("ALMACEN")]
public string AttrALMACEN;

[JsonProperty("CANTIDAD_ENTRADA")]
public decimal? AttrCANTIDAD_ENTRADA;

[JsonProperty("TEXTO_POSICION")]
public string AttrTEXTO_POSICION;

public RESTST_d34c4878f870709fdbf7a3e48e70a4edStructure() { }

public RESTST_d34c4878f870709fdbf7a3e48e70a4edStructure (ST_d34c4878f870709fdbf7a3e48e70a4edStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPOSICION_PEDIDO = ConvertToRestWithoutDefaults(s.ssPOSICION_PEDIDO, -2147483648);
AttrMATERIAL = ConvertToRestWithoutDefaults(s.ssMATERIAL, "");
AttrCENTRO = ConvertToRestWithoutDefaults(s.ssCENTRO, "");
AttrALMACEN = ConvertToRestWithoutDefaults(s.ssALMACEN, "");
AttrCANTIDAD_ENTRADA = ConvertToRestWithoutDefaults(s.ssCANTIDAD_ENTRADA, -79228162514264337593543950335m);
AttrTEXTO_POSICION = ConvertToRestWithoutDefaults(s.ssTEXTO_POSICION, "");
  } else {
AttrPOSICION_PEDIDO = (int?) s.ssPOSICION_PEDIDO;
AttrMATERIAL = s.ssMATERIAL;
AttrCENTRO = s.ssCENTRO;
AttrALMACEN = s.ssALMACEN;
AttrCANTIDAD_ENTRADA = (decimal?) s.ssCANTIDAD_ENTRADA;
AttrTEXTO_POSICION = s.ssTEXTO_POSICION;
  }
}

public static ST_d34c4878f870709fdbf7a3e48e70a4edStructure ToStructure(ssConectaProveedores.RestRecords.RESTST_d34c4878f870709fdbf7a3e48e70a4edStructure obj) { 
  ST_d34c4878f870709fdbf7a3e48e70a4edStructure s = new ST_d34c4878f870709fdbf7a3e48e70a4edStructure();
  if(obj != null) {
  s.ssPOSICION_PEDIDO = obj.AttrPOSICION_PEDIDO == null ? -2147483648 : obj.AttrPOSICION_PEDIDO.Value;
  s.ssMATERIAL = obj.AttrMATERIAL == null ? "" : obj.AttrMATERIAL;
  s.ssCENTRO = obj.AttrCENTRO == null ? "" : obj.AttrCENTRO;
  s.ssALMACEN = obj.AttrALMACEN == null ? "" : obj.AttrALMACEN;
  s.ssCANTIDAD_ENTRADA = obj.AttrCANTIDAD_ENTRADA == null ? -79228162514264337593543950335m : obj.AttrCANTIDAD_ENTRADA.Value;
  s.ssTEXTO_POSICION = obj.AttrTEXTO_POSICION == null ? "" : obj.AttrTEXTO_POSICION;
  }
  return s;
}

public static Func<ST_d34c4878f870709fdbf7a3e48e70a4edStructure, ssConectaProveedores.RestRecords.RESTST_d34c4878f870709fdbf7a3e48e70a4edStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_d34c4878f870709fdbf7a3e48e70a4edStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_d34c4878f870709fdbf7a3e48e70a4edStructure FromStructure(ST_d34c4878f870709fdbf7a3e48e70a4edStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_d34c4878f870709fdbf7a3e48e70a4edStructure(s, config);
}

}


