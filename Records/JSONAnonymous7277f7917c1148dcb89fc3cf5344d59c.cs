using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// SpecialWorkflowsRecord
public class JSONRC_ca50fec91350241da30b622279065c6e : AbstractRESTStructure<RC_ca50fec91350241da30b622279065c6e> {
[JsonProperty("SpecialWorkflows")]
[JsonPropertyName("SpecialWorkflows")]
public ssConectaProveedores.RestRecords.JSONEN_1225cc7d9c16ad5c0cda10edb493a67fEntityRecord AttrSpecialWorkflows;

public JSONRC_ca50fec91350241da30b622279065c6e() { }

public JSONRC_ca50fec91350241da30b622279065c6e (RC_ca50fec91350241da30b622279065c6e s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSpecialWorkflows = ConvertToRestWithoutDefaults(s.ssENSpecialWorkflows, new EN_1225cc7d9c16ad5c0cda10edb493a67fEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_1225cc7d9c16ad5c0cda10edb493a67fEntityRecord.FromStructure, config);
  } else {
AttrSpecialWorkflows = ssConectaProveedores.RestRecords.JSONEN_1225cc7d9c16ad5c0cda10edb493a67fEntityRecord.FromStructure(s.ssENSpecialWorkflows, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_ca50fec91350241da30b622279065c6e, RC_ca50fec91350241da30b622279065c6e> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_ca50fec91350241da30b622279065c6e s) => ToStructure(s, config);
}
public static RC_ca50fec91350241da30b622279065c6e ToStructure(ssConectaProveedores.RestRecords.JSONRC_ca50fec91350241da30b622279065c6e obj, IBehaviorsConfiguration config) { 
  RC_ca50fec91350241da30b622279065c6e s = new RC_ca50fec91350241da30b622279065c6e();
  if(obj != null) {
  s.ssENSpecialWorkflows = ssConectaProveedores.RestRecords.JSONEN_1225cc7d9c16ad5c0cda10edb493a67fEntityRecord.ToStructure(obj.AttrSpecialWorkflows, config);
  }
  return s;
}

public static Func<RC_ca50fec91350241da30b622279065c6e, ssConectaProveedores.RestRecords.JSONRC_ca50fec91350241da30b622279065c6e> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_ca50fec91350241da30b622279065c6e s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_ca50fec91350241da30b622279065c6e FromStructure(RC_ca50fec91350241da30b622279065c6e s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_ca50fec91350241da30b622279065c6e(s, config);
}

}


