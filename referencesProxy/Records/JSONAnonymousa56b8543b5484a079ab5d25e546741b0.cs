using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// OperatorRecord
public class JSONRC_21f3e2fd18d91908a16d2c0ca969f965 : AbstractRESTStructure<RC_21f3e2fd18d91908a16d2c0ca969f965> {
[JsonProperty("Operator")]
[JsonPropertyName("Operator")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord AttrOperator;

public JSONRC_21f3e2fd18d91908a16d2c0ca969f965() { }

public JSONRC_21f3e2fd18d91908a16d2c0ca969f965 (RC_21f3e2fd18d91908a16d2c0ca969f965 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOperator = ConvertToRestWithoutDefaults(s.ssENOperator, new EN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord.FromStructure, config);
  } else {
AttrOperator = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord.FromStructure(s.ssENOperator, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_21f3e2fd18d91908a16d2c0ca969f965, RC_21f3e2fd18d91908a16d2c0ca969f965> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_21f3e2fd18d91908a16d2c0ca969f965 s) => ToStructure(s, config);
}
public static RC_21f3e2fd18d91908a16d2c0ca969f965 ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_21f3e2fd18d91908a16d2c0ca969f965 obj, IBehaviorsConfiguration config) { 
  RC_21f3e2fd18d91908a16d2c0ca969f965 s = new RC_21f3e2fd18d91908a16d2c0ca969f965();
  if(obj != null) {
  s.ssENOperator = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord.ToStructure(obj.AttrOperator, config);
  }
  return s;
}

public static Func<RC_21f3e2fd18d91908a16d2c0ca969f965, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_21f3e2fd18d91908a16d2c0ca969f965> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_21f3e2fd18d91908a16d2c0ca969f965 s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_21f3e2fd18d91908a16d2c0ca969f965 FromStructure(RC_21f3e2fd18d91908a16d2c0ca969f965 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_21f3e2fd18d91908a16d2c0ca969f965(s, config);
}

}


