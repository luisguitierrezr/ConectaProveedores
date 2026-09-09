using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ApprovalProcessRecord
public class RESTRC_f2bd78b86ae9bba0b46cc5d8814834af : AbstractRESTStructure<RC_f2bd78b86ae9bba0b46cc5d8814834af> {
[JsonProperty("ApprovalProcess")]
public ssConectaProveedores.RestRecords.RESTEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord AttrApprovalProcess;

public RESTRC_f2bd78b86ae9bba0b46cc5d8814834af() { }

public RESTRC_f2bd78b86ae9bba0b46cc5d8814834af (RC_f2bd78b86ae9bba0b46cc5d8814834af s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrApprovalProcess = ConvertToRestWithoutDefaults(s.ssENApprovalProcess, new EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord.FromStructure, config);
  } else {
AttrApprovalProcess = ssConectaProveedores.RestRecords.RESTEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord.FromStructure(s.ssENApprovalProcess, config);
  }
}

public static RC_f2bd78b86ae9bba0b46cc5d8814834af ToStructure(ssConectaProveedores.RestRecords.RESTRC_f2bd78b86ae9bba0b46cc5d8814834af obj) { 
  RC_f2bd78b86ae9bba0b46cc5d8814834af s = new RC_f2bd78b86ae9bba0b46cc5d8814834af();
  if(obj != null) {
  s.ssENApprovalProcess = ssConectaProveedores.RestRecords.RESTEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord.ToStructure(obj.AttrApprovalProcess);
  }
  return s;
}

public static Func<RC_f2bd78b86ae9bba0b46cc5d8814834af, ssConectaProveedores.RestRecords.RESTRC_f2bd78b86ae9bba0b46cc5d8814834af> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_f2bd78b86ae9bba0b46cc5d8814834af s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_f2bd78b86ae9bba0b46cc5d8814834af FromStructure(RC_f2bd78b86ae9bba0b46cc5d8814834af s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_f2bd78b86ae9bba0b46cc5d8814834af(s, config);
}

}


