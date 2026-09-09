using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderItemEntriesRecord
public class RESTRC_27f9dcc2de814d2d04d4d18f5b8c424b : AbstractRESTStructure<RC_27f9dcc2de814d2d04d4d18f5b8c424b> {
[JsonProperty("OrderItemEntries")]
public ssConectaProveedores.RestRecords.RESTEN_0eb2cf39b93366f50855e537f6b98500EntityRecord AttrOrderItemEntries;

public RESTRC_27f9dcc2de814d2d04d4d18f5b8c424b() { }

public RESTRC_27f9dcc2de814d2d04d4d18f5b8c424b (RC_27f9dcc2de814d2d04d4d18f5b8c424b s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderItemEntries = ConvertToRestWithoutDefaults(s.ssENOrderItemEntries, new EN_0eb2cf39b93366f50855e537f6b98500EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_0eb2cf39b93366f50855e537f6b98500EntityRecord.FromStructure, config);
  } else {
AttrOrderItemEntries = ssConectaProveedores.RestRecords.RESTEN_0eb2cf39b93366f50855e537f6b98500EntityRecord.FromStructure(s.ssENOrderItemEntries, config);
  }
}

public static RC_27f9dcc2de814d2d04d4d18f5b8c424b ToStructure(ssConectaProveedores.RestRecords.RESTRC_27f9dcc2de814d2d04d4d18f5b8c424b obj) { 
  RC_27f9dcc2de814d2d04d4d18f5b8c424b s = new RC_27f9dcc2de814d2d04d4d18f5b8c424b();
  if(obj != null) {
  s.ssENOrderItemEntries = ssConectaProveedores.RestRecords.RESTEN_0eb2cf39b93366f50855e537f6b98500EntityRecord.ToStructure(obj.AttrOrderItemEntries);
  }
  return s;
}

public static Func<RC_27f9dcc2de814d2d04d4d18f5b8c424b, ssConectaProveedores.RestRecords.RESTRC_27f9dcc2de814d2d04d4d18f5b8c424b> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_27f9dcc2de814d2d04d4d18f5b8c424b s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_27f9dcc2de814d2d04d4d18f5b8c424b FromStructure(RC_27f9dcc2de814d2d04d4d18f5b8c424b s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_27f9dcc2de814d2d04d4d18f5b8c424b(s, config);
}

}


