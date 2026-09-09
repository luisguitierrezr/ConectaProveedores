using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ProposalLogsRecord
public class JSONRC_42d297db5356ec5acb8465e0977849c0 : AbstractRESTStructure<RC_42d297db5356ec5acb8465e0977849c0> {
[JsonProperty("ProposalLogs")]
[JsonPropertyName("ProposalLogs")]
public ssConectaProveedores.RestRecords.JSONEN_013f76cfa3062515b73935963b1697b0EntityRecord AttrProposalLogs;

public JSONRC_42d297db5356ec5acb8465e0977849c0() { }

public JSONRC_42d297db5356ec5acb8465e0977849c0 (RC_42d297db5356ec5acb8465e0977849c0 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProposalLogs = ConvertToRestWithoutDefaults(s.ssENProposalLogs, new EN_013f76cfa3062515b73935963b1697b0EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_013f76cfa3062515b73935963b1697b0EntityRecord.FromStructure, config);
  } else {
AttrProposalLogs = ssConectaProveedores.RestRecords.JSONEN_013f76cfa3062515b73935963b1697b0EntityRecord.FromStructure(s.ssENProposalLogs, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_42d297db5356ec5acb8465e0977849c0, RC_42d297db5356ec5acb8465e0977849c0> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_42d297db5356ec5acb8465e0977849c0 s) => ToStructure(s, config);
}
public static RC_42d297db5356ec5acb8465e0977849c0 ToStructure(ssConectaProveedores.RestRecords.JSONRC_42d297db5356ec5acb8465e0977849c0 obj, IBehaviorsConfiguration config) { 
  RC_42d297db5356ec5acb8465e0977849c0 s = new RC_42d297db5356ec5acb8465e0977849c0();
  if(obj != null) {
  s.ssENProposalLogs = ssConectaProveedores.RestRecords.JSONEN_013f76cfa3062515b73935963b1697b0EntityRecord.ToStructure(obj.AttrProposalLogs, config);
  }
  return s;
}

public static Func<RC_42d297db5356ec5acb8465e0977849c0, ssConectaProveedores.RestRecords.JSONRC_42d297db5356ec5acb8465e0977849c0> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_42d297db5356ec5acb8465e0977849c0 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_42d297db5356ec5acb8465e0977849c0 FromStructure(RC_42d297db5356ec5acb8465e0977849c0 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_42d297db5356ec5acb8465e0977849c0(s, config);
}

}


