using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderAccConceptsRecord
public class RESTRC_dc9a6819825fee88eba01192ae9b1890 : AbstractRESTStructure<RC_dc9a6819825fee88eba01192ae9b1890> {
[JsonProperty("OrderAccConcepts")]
public ssConectaProveedores.RestRecords.RESTEN_3e07a23619060cc7dc5624548803f5fdEntityRecord AttrOrderAccConcepts;

public RESTRC_dc9a6819825fee88eba01192ae9b1890() { }

public RESTRC_dc9a6819825fee88eba01192ae9b1890 (RC_dc9a6819825fee88eba01192ae9b1890 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderAccConcepts = ConvertToRestWithoutDefaults(s.ssENOrderAccConcepts, new EN_3e07a23619060cc7dc5624548803f5fdEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_3e07a23619060cc7dc5624548803f5fdEntityRecord.FromStructure, config);
  } else {
AttrOrderAccConcepts = ssConectaProveedores.RestRecords.RESTEN_3e07a23619060cc7dc5624548803f5fdEntityRecord.FromStructure(s.ssENOrderAccConcepts, config);
  }
}

public static RC_dc9a6819825fee88eba01192ae9b1890 ToStructure(ssConectaProveedores.RestRecords.RESTRC_dc9a6819825fee88eba01192ae9b1890 obj) { 
  RC_dc9a6819825fee88eba01192ae9b1890 s = new RC_dc9a6819825fee88eba01192ae9b1890();
  if(obj != null) {
  s.ssENOrderAccConcepts = ssConectaProveedores.RestRecords.RESTEN_3e07a23619060cc7dc5624548803f5fdEntityRecord.ToStructure(obj.AttrOrderAccConcepts);
  }
  return s;
}

public static Func<RC_dc9a6819825fee88eba01192ae9b1890, ssConectaProveedores.RestRecords.RESTRC_dc9a6819825fee88eba01192ae9b1890> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_dc9a6819825fee88eba01192ae9b1890 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_dc9a6819825fee88eba01192ae9b1890 FromStructure(RC_dc9a6819825fee88eba01192ae9b1890 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_dc9a6819825fee88eba01192ae9b1890(s, config);
}

}


