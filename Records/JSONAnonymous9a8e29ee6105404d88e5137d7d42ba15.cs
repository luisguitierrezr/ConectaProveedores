using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderItemEntriesRecord
public class JSONRC_27f9dcc2de814d2d04d4d18f5b8c424b : AbstractRESTStructure<RC_27f9dcc2de814d2d04d4d18f5b8c424b> {
[JsonProperty("OrderItemEntries")]
[JsonPropertyName("OrderItemEntries")]
public ssConectaProveedores.RestRecords.JSONEN_0eb2cf39b93366f50855e537f6b98500EntityRecord AttrOrderItemEntries;

public JSONRC_27f9dcc2de814d2d04d4d18f5b8c424b() { }

public JSONRC_27f9dcc2de814d2d04d4d18f5b8c424b (RC_27f9dcc2de814d2d04d4d18f5b8c424b s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderItemEntries = ConvertToRestWithoutDefaults(s.ssENOrderItemEntries, new EN_0eb2cf39b93366f50855e537f6b98500EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_0eb2cf39b93366f50855e537f6b98500EntityRecord.FromStructure, config);
  } else {
AttrOrderItemEntries = ssConectaProveedores.RestRecords.JSONEN_0eb2cf39b93366f50855e537f6b98500EntityRecord.FromStructure(s.ssENOrderItemEntries, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_27f9dcc2de814d2d04d4d18f5b8c424b, RC_27f9dcc2de814d2d04d4d18f5b8c424b> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_27f9dcc2de814d2d04d4d18f5b8c424b s) => ToStructure(s, config);
}
public static RC_27f9dcc2de814d2d04d4d18f5b8c424b ToStructure(ssConectaProveedores.RestRecords.JSONRC_27f9dcc2de814d2d04d4d18f5b8c424b obj, IBehaviorsConfiguration config) { 
  RC_27f9dcc2de814d2d04d4d18f5b8c424b s = new RC_27f9dcc2de814d2d04d4d18f5b8c424b();
  if(obj != null) {
  s.ssENOrderItemEntries = ssConectaProveedores.RestRecords.JSONEN_0eb2cf39b93366f50855e537f6b98500EntityRecord.ToStructure(obj.AttrOrderItemEntries, config);
  }
  return s;
}

public static Func<RC_27f9dcc2de814d2d04d4d18f5b8c424b, ssConectaProveedores.RestRecords.JSONRC_27f9dcc2de814d2d04d4d18f5b8c424b> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_27f9dcc2de814d2d04d4d18f5b8c424b s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_27f9dcc2de814d2d04d4d18f5b8c424b FromStructure(RC_27f9dcc2de814d2d04d4d18f5b8c424b s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_27f9dcc2de814d2d04d4d18f5b8c424b(s, config);
}

}


