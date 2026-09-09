using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ApprovalProcessLevelApprovalProcessRecord
public class JSONRC_1c307c6ba13b1609f542644719b6e56b : AbstractRESTStructure<RC_1c307c6ba13b1609f542644719b6e56b> {
[JsonProperty("ApprovalProcessLevel")]
[JsonPropertyName("ApprovalProcessLevel")]
public ssConectaProveedores.RestRecords.JSONEN_1d28318723f39133c60733b3cce8955eEntityRecord AttrApprovalProcessLevel;

[JsonProperty("ApprovalProcess")]
[JsonPropertyName("ApprovalProcess")]
public ssConectaProveedores.RestRecords.JSONEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord AttrApprovalProcess;

public JSONRC_1c307c6ba13b1609f542644719b6e56b() { }

public JSONRC_1c307c6ba13b1609f542644719b6e56b (RC_1c307c6ba13b1609f542644719b6e56b s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrApprovalProcessLevel = ConvertToRestWithoutDefaults(s.ssENApprovalProcessLevel, new EN_1d28318723f39133c60733b3cce8955eEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_1d28318723f39133c60733b3cce8955eEntityRecord.FromStructure, config);
AttrApprovalProcess = ConvertToRestWithoutDefaults(s.ssENApprovalProcess, new EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord.FromStructure, config);
  } else {
AttrApprovalProcessLevel = ssConectaProveedores.RestRecords.JSONEN_1d28318723f39133c60733b3cce8955eEntityRecord.FromStructure(s.ssENApprovalProcessLevel, config);
AttrApprovalProcess = ssConectaProveedores.RestRecords.JSONEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord.FromStructure(s.ssENApprovalProcess, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_1c307c6ba13b1609f542644719b6e56b, RC_1c307c6ba13b1609f542644719b6e56b> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_1c307c6ba13b1609f542644719b6e56b s) => ToStructure(s, config);
}
public static RC_1c307c6ba13b1609f542644719b6e56b ToStructure(ssConectaProveedores.RestRecords.JSONRC_1c307c6ba13b1609f542644719b6e56b obj, IBehaviorsConfiguration config) { 
  RC_1c307c6ba13b1609f542644719b6e56b s = new RC_1c307c6ba13b1609f542644719b6e56b();
  if(obj != null) {
  s.ssENApprovalProcessLevel = ssConectaProveedores.RestRecords.JSONEN_1d28318723f39133c60733b3cce8955eEntityRecord.ToStructure(obj.AttrApprovalProcessLevel, config);
  s.ssENApprovalProcess = ssConectaProveedores.RestRecords.JSONEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord.ToStructure(obj.AttrApprovalProcess, config);
  }
  return s;
}

public static Func<RC_1c307c6ba13b1609f542644719b6e56b, ssConectaProveedores.RestRecords.JSONRC_1c307c6ba13b1609f542644719b6e56b> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_1c307c6ba13b1609f542644719b6e56b s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_1c307c6ba13b1609f542644719b6e56b FromStructure(RC_1c307c6ba13b1609f542644719b6e56b s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_1c307c6ba13b1609f542644719b6e56b(s, config);
}

}


