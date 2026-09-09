using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ZTC_GENERA_POLIZA_GRALReq
public class RESTST_7d9ca3de97b3b074755ccb195cd9efb0Structure : AbstractRESTStructure<ST_7d9ca3de97b3b074755ccb195cd9efb0Structure> {
[JsonProperty("PI_USUARIO")]
public string AttrPI_USUARIO;

[JsonProperty("TI_POS_In")]
public RestList<ssConectaProveedores.RestRecords.RESTST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure> AttrTI_POS_In;

[JsonProperty("TO_RESULTADO_In")]
public RestList<ssConectaProveedores.RestRecords.RESTST_1881d7eeaa3bae99e7aa7a6ecb977980Structure> AttrTO_RESULTADO_In;

public RESTST_7d9ca3de97b3b074755ccb195cd9efb0Structure() { }

public RESTST_7d9ca3de97b3b074755ccb195cd9efb0Structure (ST_7d9ca3de97b3b074755ccb195cd9efb0Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPI_USUARIO = ConvertToRestWithoutDefaults(s.ssPI_USUARIO, "");
AttrTI_POS_In = s.ssTI_POS_In.Length == 0 ? null : s.ssTI_POS_In.ToRestList<ssConectaProveedores.RestRecords.RESTST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure>(ssConectaProveedores.RestRecords.RESTST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure.FromStructureDelegate(config));
AttrTO_RESULTADO_In = s.ssTO_RESULTADO_In.Length == 0 ? null : s.ssTO_RESULTADO_In.ToRestList<ssConectaProveedores.RestRecords.RESTST_1881d7eeaa3bae99e7aa7a6ecb977980Structure>(ssConectaProveedores.RestRecords.RESTST_1881d7eeaa3bae99e7aa7a6ecb977980Structure.FromStructureDelegate(config));
  } else {
AttrPI_USUARIO = s.ssPI_USUARIO;
AttrTI_POS_In = s.ssTI_POS_In.ToRestList<ssConectaProveedores.RestRecords.RESTST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure>(ssConectaProveedores.RestRecords.RESTST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure.FromStructureDelegate(config));
AttrTO_RESULTADO_In = s.ssTO_RESULTADO_In.ToRestList<ssConectaProveedores.RestRecords.RESTST_1881d7eeaa3bae99e7aa7a6ecb977980Structure>(ssConectaProveedores.RestRecords.RESTST_1881d7eeaa3bae99e7aa7a6ecb977980Structure.FromStructureDelegate(config));
  }
}

public static ST_7d9ca3de97b3b074755ccb195cd9efb0Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_7d9ca3de97b3b074755ccb195cd9efb0Structure obj) { 
  ST_7d9ca3de97b3b074755ccb195cd9efb0Structure s = new ST_7d9ca3de97b3b074755ccb195cd9efb0Structure();
  if(obj != null) {
  s.ssPI_USUARIO = obj.AttrPI_USUARIO == null ? "" : obj.AttrPI_USUARIO;
  s.ssTI_POS_In = RL_c68103fa9d6dc1b51b6298518d880199.FromRestList(obj.AttrTI_POS_In, ssConectaProveedores.RestRecords.RESTST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure.ToStructure);
  s.ssTO_RESULTADO_In = RL_d9182ea8cfe690c58e113da212e63df9.FromRestList(obj.AttrTO_RESULTADO_In, ssConectaProveedores.RestRecords.RESTST_1881d7eeaa3bae99e7aa7a6ecb977980Structure.ToStructure);
  }
  return s;
}

public static Func<ST_7d9ca3de97b3b074755ccb195cd9efb0Structure, ssConectaProveedores.RestRecords.RESTST_7d9ca3de97b3b074755ccb195cd9efb0Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_7d9ca3de97b3b074755ccb195cd9efb0Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_7d9ca3de97b3b074755ccb195cd9efb0Structure FromStructure(ST_7d9ca3de97b3b074755ccb195cd9efb0Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_7d9ca3de97b3b074755ccb195cd9efb0Structure(s, config);
}

}


