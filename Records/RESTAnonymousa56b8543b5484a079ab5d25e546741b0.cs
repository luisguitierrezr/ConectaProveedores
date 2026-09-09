using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OperatorRecord
public class RESTRC_21f3e2fd18d91908a16d2c0ca969f965 : AbstractRESTStructure<RC_21f3e2fd18d91908a16d2c0ca969f965> {
[JsonProperty("Operator")]
public ssConectaProveedores.RestRecords.RESTEN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord AttrOperator;

public RESTRC_21f3e2fd18d91908a16d2c0ca969f965() { }

public RESTRC_21f3e2fd18d91908a16d2c0ca969f965 (RC_21f3e2fd18d91908a16d2c0ca969f965 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOperator = ConvertToRestWithoutDefaults(s.ssENOperator, new EN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord.FromStructure, config);
  } else {
AttrOperator = ssConectaProveedores.RestRecords.RESTEN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord.FromStructure(s.ssENOperator, config);
  }
}

public static RC_21f3e2fd18d91908a16d2c0ca969f965 ToStructure(ssConectaProveedores.RestRecords.RESTRC_21f3e2fd18d91908a16d2c0ca969f965 obj) { 
  RC_21f3e2fd18d91908a16d2c0ca969f965 s = new RC_21f3e2fd18d91908a16d2c0ca969f965();
  if(obj != null) {
  s.ssENOperator = ssConectaProveedores.RestRecords.RESTEN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord.ToStructure(obj.AttrOperator);
  }
  return s;
}

public static Func<RC_21f3e2fd18d91908a16d2c0ca969f965, ssConectaProveedores.RestRecords.RESTRC_21f3e2fd18d91908a16d2c0ca969f965> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_21f3e2fd18d91908a16d2c0ca969f965 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_21f3e2fd18d91908a16d2c0ca969f965 FromStructure(RC_21f3e2fd18d91908a16d2c0ca969f965 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_21f3e2fd18d91908a16d2c0ca969f965(s, config);
}

}


