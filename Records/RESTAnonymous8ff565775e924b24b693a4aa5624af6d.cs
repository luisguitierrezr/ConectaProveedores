using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ApprovalProcessLevelApprovalProcessRecord
public class RESTRC_1c307c6ba13b1609f542644719b6e56b : AbstractRESTStructure<RC_1c307c6ba13b1609f542644719b6e56b> {
[JsonProperty("ApprovalProcessLevel")]
public ssConectaProveedores.RestRecords.RESTEN_1d28318723f39133c60733b3cce8955eEntityRecord AttrApprovalProcessLevel;

[JsonProperty("ApprovalProcess")]
public ssConectaProveedores.RestRecords.RESTEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord AttrApprovalProcess;

public RESTRC_1c307c6ba13b1609f542644719b6e56b() { }

public RESTRC_1c307c6ba13b1609f542644719b6e56b (RC_1c307c6ba13b1609f542644719b6e56b s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrApprovalProcessLevel = ConvertToRestWithoutDefaults(s.ssENApprovalProcessLevel, new EN_1d28318723f39133c60733b3cce8955eEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_1d28318723f39133c60733b3cce8955eEntityRecord.FromStructure, config);
AttrApprovalProcess = ConvertToRestWithoutDefaults(s.ssENApprovalProcess, new EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord.FromStructure, config);
  } else {
AttrApprovalProcessLevel = ssConectaProveedores.RestRecords.RESTEN_1d28318723f39133c60733b3cce8955eEntityRecord.FromStructure(s.ssENApprovalProcessLevel, config);
AttrApprovalProcess = ssConectaProveedores.RestRecords.RESTEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord.FromStructure(s.ssENApprovalProcess, config);
  }
}

public static RC_1c307c6ba13b1609f542644719b6e56b ToStructure(ssConectaProveedores.RestRecords.RESTRC_1c307c6ba13b1609f542644719b6e56b obj) { 
  RC_1c307c6ba13b1609f542644719b6e56b s = new RC_1c307c6ba13b1609f542644719b6e56b();
  if(obj != null) {
  s.ssENApprovalProcessLevel = ssConectaProveedores.RestRecords.RESTEN_1d28318723f39133c60733b3cce8955eEntityRecord.ToStructure(obj.AttrApprovalProcessLevel);
  s.ssENApprovalProcess = ssConectaProveedores.RestRecords.RESTEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord.ToStructure(obj.AttrApprovalProcess);
  }
  return s;
}

public static Func<RC_1c307c6ba13b1609f542644719b6e56b, ssConectaProveedores.RestRecords.RESTRC_1c307c6ba13b1609f542644719b6e56b> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_1c307c6ba13b1609f542644719b6e56b s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_1c307c6ba13b1609f542644719b6e56b FromStructure(RC_1c307c6ba13b1609f542644719b6e56b s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_1c307c6ba13b1609f542644719b6e56b(s, config);
}

}


