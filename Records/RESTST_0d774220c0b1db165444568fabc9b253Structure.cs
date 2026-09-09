using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ZMXMIMMF_EM_SM_MO_COSMOZREq
public class RESTST_0d774220c0b1db165444568fabc9b253Structure : AbstractRESTStructure<ST_0d774220c0b1db165444568fabc9b253Structure> {
[JsonProperty("PI_HEADER")]
public ssConectaProveedores.RestRecords.RESTST_b8bada9441ba6abcbadb418a924fe551Structure AttrPI_HEADER;

[JsonProperty("PI_ITEM_EM")]
public RestList<ssConectaProveedores.RestRecords.RESTST_7dc1141edc6ff8164773775d2fc68a19Structure> AttrPI_ITEM_EM;

[JsonProperty("PI_ITEM_SM")]
public RestList<ssConectaProveedores.RestRecords.RESTST_9327164801e6ab5e342b0e8e98c59312Structure> AttrPI_ITEM_SM;

public RESTST_0d774220c0b1db165444568fabc9b253Structure() { }

public RESTST_0d774220c0b1db165444568fabc9b253Structure (ST_0d774220c0b1db165444568fabc9b253Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPI_HEADER = ssConectaProveedores.RestRecords.RESTST_b8bada9441ba6abcbadb418a924fe551Structure.FromStructure(s.ssPI_HEADER, config);
AttrPI_ITEM_EM = s.ssPI_ITEM_EM.ToRestList<ssConectaProveedores.RestRecords.RESTST_7dc1141edc6ff8164773775d2fc68a19Structure>(ssConectaProveedores.RestRecords.RESTST_7dc1141edc6ff8164773775d2fc68a19Structure.FromStructureDelegate(config));
AttrPI_ITEM_SM = s.ssPI_ITEM_SM.ToRestList<ssConectaProveedores.RestRecords.RESTST_9327164801e6ab5e342b0e8e98c59312Structure>(ssConectaProveedores.RestRecords.RESTST_9327164801e6ab5e342b0e8e98c59312Structure.FromStructureDelegate(config));
  } else {
AttrPI_HEADER = ssConectaProveedores.RestRecords.RESTST_b8bada9441ba6abcbadb418a924fe551Structure.FromStructure(s.ssPI_HEADER, config);
AttrPI_ITEM_EM = s.ssPI_ITEM_EM.ToRestList<ssConectaProveedores.RestRecords.RESTST_7dc1141edc6ff8164773775d2fc68a19Structure>(ssConectaProveedores.RestRecords.RESTST_7dc1141edc6ff8164773775d2fc68a19Structure.FromStructureDelegate(config));
AttrPI_ITEM_SM = s.ssPI_ITEM_SM.ToRestList<ssConectaProveedores.RestRecords.RESTST_9327164801e6ab5e342b0e8e98c59312Structure>(ssConectaProveedores.RestRecords.RESTST_9327164801e6ab5e342b0e8e98c59312Structure.FromStructureDelegate(config));
  }
}

public static ST_0d774220c0b1db165444568fabc9b253Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_0d774220c0b1db165444568fabc9b253Structure obj) { 
  ST_0d774220c0b1db165444568fabc9b253Structure s = new ST_0d774220c0b1db165444568fabc9b253Structure();
  if(obj != null) {
  s.ssPI_HEADER = ssConectaProveedores.RestRecords.RESTST_b8bada9441ba6abcbadb418a924fe551Structure.ToStructure(obj.AttrPI_HEADER);
  s.ssPI_ITEM_EM = RL_d88dcbee53485b990306d5474ef9ead7.FromRestList(obj.AttrPI_ITEM_EM, ssConectaProveedores.RestRecords.RESTST_7dc1141edc6ff8164773775d2fc68a19Structure.ToStructure);
  s.ssPI_ITEM_SM = RL_669be34b3612e89197059379653d4a04.FromRestList(obj.AttrPI_ITEM_SM, ssConectaProveedores.RestRecords.RESTST_9327164801e6ab5e342b0e8e98c59312Structure.ToStructure);
  }
  return s;
}

public static Func<ST_0d774220c0b1db165444568fabc9b253Structure, ssConectaProveedores.RestRecords.RESTST_0d774220c0b1db165444568fabc9b253Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_0d774220c0b1db165444568fabc9b253Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_0d774220c0b1db165444568fabc9b253Structure FromStructure(ST_0d774220c0b1db165444568fabc9b253Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_0d774220c0b1db165444568fabc9b253Structure(s, config);
}

}


