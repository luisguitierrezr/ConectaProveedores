using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// PI_ITEM_SM2Record
public class JSONRC_b8a0645b6211d97a3945398c9bceb91c : AbstractRESTStructure<RC_b8a0645b6211d97a3945398c9bceb91c> {
[JsonProperty("PI_ITEM_SM2")]
[JsonPropertyName("PI_ITEM_SM2")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_9327164801e6ab5e342b0e8e98c59312Structure AttrPI_ITEM_SM2;

public JSONRC_b8a0645b6211d97a3945398c9bceb91c() { }

public JSONRC_b8a0645b6211d97a3945398c9bceb91c (RC_b8a0645b6211d97a3945398c9bceb91c s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPI_ITEM_SM2 = ConvertToRestWithoutDefaults(s.ssSTPI_ITEM_SM2, new ST_9327164801e6ab5e342b0e8e98c59312Structure(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_9327164801e6ab5e342b0e8e98c59312Structure.FromStructure, config);
  } else {
AttrPI_ITEM_SM2 = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_9327164801e6ab5e342b0e8e98c59312Structure.FromStructure(s.ssSTPI_ITEM_SM2, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_b8a0645b6211d97a3945398c9bceb91c, RC_b8a0645b6211d97a3945398c9bceb91c> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_b8a0645b6211d97a3945398c9bceb91c s) => ToStructure(s, config);
}
public static RC_b8a0645b6211d97a3945398c9bceb91c ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_b8a0645b6211d97a3945398c9bceb91c obj, IBehaviorsConfiguration config) { 
  RC_b8a0645b6211d97a3945398c9bceb91c s = new RC_b8a0645b6211d97a3945398c9bceb91c();
  if(obj != null) {
  s.ssSTPI_ITEM_SM2 = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_9327164801e6ab5e342b0e8e98c59312Structure.ToStructure(obj.AttrPI_ITEM_SM2, config);
  }
  return s;
}

public static Func<RC_b8a0645b6211d97a3945398c9bceb91c, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_b8a0645b6211d97a3945398c9bceb91c> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_b8a0645b6211d97a3945398c9bceb91c s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_b8a0645b6211d97a3945398c9bceb91c FromStructure(RC_b8a0645b6211d97a3945398c9bceb91c s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_b8a0645b6211d97a3945398c9bceb91c(s, config);
}

}


