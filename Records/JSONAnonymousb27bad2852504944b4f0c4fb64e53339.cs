using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ProposalApprovalLevelIdApplicationRoleNameRecord
public class JSONRC_786401d4272d8830c4a71cf084346ee6 : AbstractRESTStructure<RC_786401d4272d8830c4a71cf084346ee6> {
[JsonProperty("ProposalApprovalLevelId")]
[JsonPropertyName("ProposalApprovalLevelId")]
public long? AttrProposalApprovalLevelId;

[JsonProperty("ApplicationRoleName")]
[JsonPropertyName("ApplicationRoleName")]
public string AttrApplicationRoleName;

public JSONRC_786401d4272d8830c4a71cf084346ee6() { }

public JSONRC_786401d4272d8830c4a71cf084346ee6 (RC_786401d4272d8830c4a71cf084346ee6 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProposalApprovalLevelId = ConvertToRestWithoutDefaults(s.ssProposalApprovalLevelId, 0L);
AttrApplicationRoleName = ConvertToRestWithoutDefaults(s.ssApplicationRoleName, "");
  } else {
AttrProposalApprovalLevelId = (long?) s.ssProposalApprovalLevelId;
AttrApplicationRoleName = s.ssApplicationRoleName;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_786401d4272d8830c4a71cf084346ee6, RC_786401d4272d8830c4a71cf084346ee6> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_786401d4272d8830c4a71cf084346ee6 s) => ToStructure(s, config);
}
public static RC_786401d4272d8830c4a71cf084346ee6 ToStructure(ssConectaProveedores.RestRecords.JSONRC_786401d4272d8830c4a71cf084346ee6 obj, IBehaviorsConfiguration config) { 
  RC_786401d4272d8830c4a71cf084346ee6 s = new RC_786401d4272d8830c4a71cf084346ee6();
  if(obj != null) {
  s.ssProposalApprovalLevelId = obj.AttrProposalApprovalLevelId == null ? 0L : obj.AttrProposalApprovalLevelId.Value;
  s.ssApplicationRoleName = obj.AttrApplicationRoleName == null ? "" : obj.AttrApplicationRoleName;
  }
  return s;
}

public static Func<RC_786401d4272d8830c4a71cf084346ee6, ssConectaProveedores.RestRecords.JSONRC_786401d4272d8830c4a71cf084346ee6> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_786401d4272d8830c4a71cf084346ee6 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_786401d4272d8830c4a71cf084346ee6 FromStructure(RC_786401d4272d8830c4a71cf084346ee6 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_786401d4272d8830c4a71cf084346ee6(s, config);
}

}


