using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// PI_ITEMRecord
public class JSONRC_5b3a110e736062950b0c6cfa935e61d0 : AbstractRESTStructure<RC_5b3a110e736062950b0c6cfa935e61d0> {
[JsonProperty("PI_ITEM")]
[JsonPropertyName("PI_ITEM")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_d34c4878f870709fdbf7a3e48e70a4edStructure AttrPI_ITEM;

public JSONRC_5b3a110e736062950b0c6cfa935e61d0() { }

public JSONRC_5b3a110e736062950b0c6cfa935e61d0 (RC_5b3a110e736062950b0c6cfa935e61d0 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPI_ITEM = ConvertToRestWithoutDefaults(s.ssSTPI_ITEM, new ST_d34c4878f870709fdbf7a3e48e70a4edStructure(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_d34c4878f870709fdbf7a3e48e70a4edStructure.FromStructure, config);
  } else {
AttrPI_ITEM = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_d34c4878f870709fdbf7a3e48e70a4edStructure.FromStructure(s.ssSTPI_ITEM, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_5b3a110e736062950b0c6cfa935e61d0, RC_5b3a110e736062950b0c6cfa935e61d0> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_5b3a110e736062950b0c6cfa935e61d0 s) => ToStructure(s, config);
}
public static RC_5b3a110e736062950b0c6cfa935e61d0 ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_5b3a110e736062950b0c6cfa935e61d0 obj, IBehaviorsConfiguration config) { 
  RC_5b3a110e736062950b0c6cfa935e61d0 s = new RC_5b3a110e736062950b0c6cfa935e61d0();
  if(obj != null) {
  s.ssSTPI_ITEM = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_d34c4878f870709fdbf7a3e48e70a4edStructure.ToStructure(obj.AttrPI_ITEM, config);
  }
  return s;
}

public static Func<RC_5b3a110e736062950b0c6cfa935e61d0, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_5b3a110e736062950b0c6cfa935e61d0> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_5b3a110e736062950b0c6cfa935e61d0 s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_5b3a110e736062950b0c6cfa935e61d0 FromStructure(RC_5b3a110e736062950b0c6cfa935e61d0 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_5b3a110e736062950b0c6cfa935e61d0(s, config);
}

}


