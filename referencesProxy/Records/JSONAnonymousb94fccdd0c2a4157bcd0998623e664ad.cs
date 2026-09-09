using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// ZMXFFIMF_RETEN_PROVEEDORESReqRecord
public class JSONRC_0f5ff14dc8300879cf7234ab714e1aa5 : AbstractRESTStructure<RC_0f5ff14dc8300879cf7234ab714e1aa5> {
[JsonProperty("ZMXFFIMF_RETEN_PROVEEDORESReq")]
[JsonPropertyName("ZMXFFIMF_RETEN_PROVEEDORESReq")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_90ad61a7b6c3b8dc6db7b1d64798236bStructure AttrZMXFFIMF_RETEN_PROVEEDORESReq;

public JSONRC_0f5ff14dc8300879cf7234ab714e1aa5() { }

public JSONRC_0f5ff14dc8300879cf7234ab714e1aa5 (RC_0f5ff14dc8300879cf7234ab714e1aa5 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrZMXFFIMF_RETEN_PROVEEDORESReq = ConvertToRestWithoutDefaults(s.ssSTZMXFFIMF_RETEN_PROVEEDORESReq, new ST_90ad61a7b6c3b8dc6db7b1d64798236bStructure(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_90ad61a7b6c3b8dc6db7b1d64798236bStructure.FromStructure, config);
  } else {
AttrZMXFFIMF_RETEN_PROVEEDORESReq = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_90ad61a7b6c3b8dc6db7b1d64798236bStructure.FromStructure(s.ssSTZMXFFIMF_RETEN_PROVEEDORESReq, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_0f5ff14dc8300879cf7234ab714e1aa5, RC_0f5ff14dc8300879cf7234ab714e1aa5> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_0f5ff14dc8300879cf7234ab714e1aa5 s) => ToStructure(s, config);
}
public static RC_0f5ff14dc8300879cf7234ab714e1aa5 ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_0f5ff14dc8300879cf7234ab714e1aa5 obj, IBehaviorsConfiguration config) { 
  RC_0f5ff14dc8300879cf7234ab714e1aa5 s = new RC_0f5ff14dc8300879cf7234ab714e1aa5();
  if(obj != null) {
  s.ssSTZMXFFIMF_RETEN_PROVEEDORESReq = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_90ad61a7b6c3b8dc6db7b1d64798236bStructure.ToStructure(obj.AttrZMXFFIMF_RETEN_PROVEEDORESReq, config);
  }
  return s;
}

public static Func<RC_0f5ff14dc8300879cf7234ab714e1aa5, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_0f5ff14dc8300879cf7234ab714e1aa5> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_0f5ff14dc8300879cf7234ab714e1aa5 s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_0f5ff14dc8300879cf7234ab714e1aa5 FromStructure(RC_0f5ff14dc8300879cf7234ab714e1aa5 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_0f5ff14dc8300879cf7234ab714e1aa5(s, config);
}

}


