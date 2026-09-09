using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ApprovalProcessRecord
public class JSONRC_f2bd78b86ae9bba0b46cc5d8814834af : AbstractRESTStructure<RC_f2bd78b86ae9bba0b46cc5d8814834af> {
[JsonProperty("ApprovalProcess")]
[JsonPropertyName("ApprovalProcess")]
public ssConectaProveedores.RestRecords.JSONEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord AttrApprovalProcess;

public JSONRC_f2bd78b86ae9bba0b46cc5d8814834af() { }

public JSONRC_f2bd78b86ae9bba0b46cc5d8814834af (RC_f2bd78b86ae9bba0b46cc5d8814834af s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrApprovalProcess = ConvertToRestWithoutDefaults(s.ssENApprovalProcess, new EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord.FromStructure, config);
  } else {
AttrApprovalProcess = ssConectaProveedores.RestRecords.JSONEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord.FromStructure(s.ssENApprovalProcess, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_f2bd78b86ae9bba0b46cc5d8814834af, RC_f2bd78b86ae9bba0b46cc5d8814834af> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_f2bd78b86ae9bba0b46cc5d8814834af s) => ToStructure(s, config);
}
public static RC_f2bd78b86ae9bba0b46cc5d8814834af ToStructure(ssConectaProveedores.RestRecords.JSONRC_f2bd78b86ae9bba0b46cc5d8814834af obj, IBehaviorsConfiguration config) { 
  RC_f2bd78b86ae9bba0b46cc5d8814834af s = new RC_f2bd78b86ae9bba0b46cc5d8814834af();
  if(obj != null) {
  s.ssENApprovalProcess = ssConectaProveedores.RestRecords.JSONEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord.ToStructure(obj.AttrApprovalProcess, config);
  }
  return s;
}

public static Func<RC_f2bd78b86ae9bba0b46cc5d8814834af, ssConectaProveedores.RestRecords.JSONRC_f2bd78b86ae9bba0b46cc5d8814834af> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_f2bd78b86ae9bba0b46cc5d8814834af s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_f2bd78b86ae9bba0b46cc5d8814834af FromStructure(RC_f2bd78b86ae9bba0b46cc5d8814834af s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_f2bd78b86ae9bba0b46cc5d8814834af(s, config);
}

}


