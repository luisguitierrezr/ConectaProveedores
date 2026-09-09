using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderAccConceptsRecord
public class JSONRC_dc9a6819825fee88eba01192ae9b1890 : AbstractRESTStructure<RC_dc9a6819825fee88eba01192ae9b1890> {
[JsonProperty("OrderAccConcepts")]
[JsonPropertyName("OrderAccConcepts")]
public ssConectaProveedores.RestRecords.JSONEN_3e07a23619060cc7dc5624548803f5fdEntityRecord AttrOrderAccConcepts;

public JSONRC_dc9a6819825fee88eba01192ae9b1890() { }

public JSONRC_dc9a6819825fee88eba01192ae9b1890 (RC_dc9a6819825fee88eba01192ae9b1890 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderAccConcepts = ConvertToRestWithoutDefaults(s.ssENOrderAccConcepts, new EN_3e07a23619060cc7dc5624548803f5fdEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_3e07a23619060cc7dc5624548803f5fdEntityRecord.FromStructure, config);
  } else {
AttrOrderAccConcepts = ssConectaProveedores.RestRecords.JSONEN_3e07a23619060cc7dc5624548803f5fdEntityRecord.FromStructure(s.ssENOrderAccConcepts, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_dc9a6819825fee88eba01192ae9b1890, RC_dc9a6819825fee88eba01192ae9b1890> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_dc9a6819825fee88eba01192ae9b1890 s) => ToStructure(s, config);
}
public static RC_dc9a6819825fee88eba01192ae9b1890 ToStructure(ssConectaProveedores.RestRecords.JSONRC_dc9a6819825fee88eba01192ae9b1890 obj, IBehaviorsConfiguration config) { 
  RC_dc9a6819825fee88eba01192ae9b1890 s = new RC_dc9a6819825fee88eba01192ae9b1890();
  if(obj != null) {
  s.ssENOrderAccConcepts = ssConectaProveedores.RestRecords.JSONEN_3e07a23619060cc7dc5624548803f5fdEntityRecord.ToStructure(obj.AttrOrderAccConcepts, config);
  }
  return s;
}

public static Func<RC_dc9a6819825fee88eba01192ae9b1890, ssConectaProveedores.RestRecords.JSONRC_dc9a6819825fee88eba01192ae9b1890> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_dc9a6819825fee88eba01192ae9b1890 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_dc9a6819825fee88eba01192ae9b1890 FromStructure(RC_dc9a6819825fee88eba01192ae9b1890 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_dc9a6819825fee88eba01192ae9b1890(s, config);
}

}


