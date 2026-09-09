using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// ZMXMIMMF_EM_SM_MO_COSMOZREq
public class JSONST_0d774220c0b1db165444568fabc9b253Structure : AbstractRESTStructure<ST_0d774220c0b1db165444568fabc9b253Structure> {
[JsonProperty("PI_HEADER")]
[JsonPropertyName("PI_HEADER")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b8bada9441ba6abcbadb418a924fe551Structure AttrPI_HEADER;

[JsonProperty("PI_ITEM_EM")]
[JsonPropertyName("PI_ITEM_EM")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_7dc1141edc6ff8164773775d2fc68a19Structure[] AttrPI_ITEM_EM;

[JsonProperty("PI_ITEM_SM")]
[JsonPropertyName("PI_ITEM_SM")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_9327164801e6ab5e342b0e8e98c59312Structure[] AttrPI_ITEM_SM;

public JSONST_0d774220c0b1db165444568fabc9b253Structure() { }

public JSONST_0d774220c0b1db165444568fabc9b253Structure (ST_0d774220c0b1db165444568fabc9b253Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPI_HEADER = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b8bada9441ba6abcbadb418a924fe551Structure.FromStructure(s.ssPI_HEADER, config);
AttrPI_ITEM_EM = s.ssPI_ITEM_EM.ToArray<ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_7dc1141edc6ff8164773775d2fc68a19Structure>(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_7dc1141edc6ff8164773775d2fc68a19Structure.FromStructureDelegate(config));
AttrPI_ITEM_SM = s.ssPI_ITEM_SM.ToArray<ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_9327164801e6ab5e342b0e8e98c59312Structure>(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_9327164801e6ab5e342b0e8e98c59312Structure.FromStructureDelegate(config));
  } else {
AttrPI_HEADER = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b8bada9441ba6abcbadb418a924fe551Structure.FromStructure(s.ssPI_HEADER, config);
AttrPI_ITEM_EM = s.ssPI_ITEM_EM.ToArray<ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_7dc1141edc6ff8164773775d2fc68a19Structure>(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_7dc1141edc6ff8164773775d2fc68a19Structure.FromStructureDelegate(config));
AttrPI_ITEM_SM = s.ssPI_ITEM_SM.ToArray<ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_9327164801e6ab5e342b0e8e98c59312Structure>(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_9327164801e6ab5e342b0e8e98c59312Structure.FromStructureDelegate(config));
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_0d774220c0b1db165444568fabc9b253Structure, ST_0d774220c0b1db165444568fabc9b253Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_0d774220c0b1db165444568fabc9b253Structure s) => ToStructure(s, config);
}
public static ST_0d774220c0b1db165444568fabc9b253Structure ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_0d774220c0b1db165444568fabc9b253Structure obj, IBehaviorsConfiguration config) { 
  ST_0d774220c0b1db165444568fabc9b253Structure s = new ST_0d774220c0b1db165444568fabc9b253Structure();
  if(obj != null) {
  s.ssPI_HEADER = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b8bada9441ba6abcbadb418a924fe551Structure.ToStructure(obj.AttrPI_HEADER, config);
  s.ssPI_ITEM_EM = RL_d88dcbee53485b990306d5474ef9ead7.ToList(obj.AttrPI_ITEM_EM, ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_7dc1141edc6ff8164773775d2fc68a19Structure.ToStructureDelegate(config));
  s.ssPI_ITEM_SM = RL_669be34b3612e89197059379653d4a04.ToList(obj.AttrPI_ITEM_SM, ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_9327164801e6ab5e342b0e8e98c59312Structure.ToStructureDelegate(config));
  }
  return s;
}

public static Func<ST_0d774220c0b1db165444568fabc9b253Structure, ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_0d774220c0b1db165444568fabc9b253Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_0d774220c0b1db165444568fabc9b253Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_0d774220c0b1db165444568fabc9b253Structure FromStructure(ST_0d774220c0b1db165444568fabc9b253Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_0d774220c0b1db165444568fabc9b253Structure(s, config);
}

}


