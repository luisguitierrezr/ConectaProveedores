using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ApprovalProcessLevelEntraRoleRecord
public class JSONRC_06974d55bca345bb983c839ad25aa487 : AbstractRESTStructure<RC_06974d55bca345bb983c839ad25aa487> {
[JsonProperty("ApprovalProcessLevel")]
[JsonPropertyName("ApprovalProcessLevel")]
public ssConectaProveedores.RestRecords.JSONEN_1d28318723f39133c60733b3cce8955eEntityRecord AttrApprovalProcessLevel;

[JsonProperty("EntraRole")]
[JsonPropertyName("EntraRole")]
public ssConectaProveedores.RestRecords.JSONEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord AttrEntraRole;

public JSONRC_06974d55bca345bb983c839ad25aa487() { }

public JSONRC_06974d55bca345bb983c839ad25aa487 (RC_06974d55bca345bb983c839ad25aa487 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrApprovalProcessLevel = ConvertToRestWithoutDefaults(s.ssENApprovalProcessLevel, new EN_1d28318723f39133c60733b3cce8955eEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_1d28318723f39133c60733b3cce8955eEntityRecord.FromStructure, config);
AttrEntraRole = ConvertToRestWithoutDefaults(s.ssENEntraRole, new EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord.FromStructure, config);
  } else {
AttrApprovalProcessLevel = ssConectaProveedores.RestRecords.JSONEN_1d28318723f39133c60733b3cce8955eEntityRecord.FromStructure(s.ssENApprovalProcessLevel, config);
AttrEntraRole = ssConectaProveedores.RestRecords.JSONEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord.FromStructure(s.ssENEntraRole, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_06974d55bca345bb983c839ad25aa487, RC_06974d55bca345bb983c839ad25aa487> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_06974d55bca345bb983c839ad25aa487 s) => ToStructure(s, config);
}
public static RC_06974d55bca345bb983c839ad25aa487 ToStructure(ssConectaProveedores.RestRecords.JSONRC_06974d55bca345bb983c839ad25aa487 obj, IBehaviorsConfiguration config) { 
  RC_06974d55bca345bb983c839ad25aa487 s = new RC_06974d55bca345bb983c839ad25aa487();
  if(obj != null) {
  s.ssENApprovalProcessLevel = ssConectaProveedores.RestRecords.JSONEN_1d28318723f39133c60733b3cce8955eEntityRecord.ToStructure(obj.AttrApprovalProcessLevel, config);
  s.ssENEntraRole = ssConectaProveedores.RestRecords.JSONEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord.ToStructure(obj.AttrEntraRole, config);
  }
  return s;
}

public static Func<RC_06974d55bca345bb983c839ad25aa487, ssConectaProveedores.RestRecords.JSONRC_06974d55bca345bb983c839ad25aa487> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_06974d55bca345bb983c839ad25aa487 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_06974d55bca345bb983c839ad25aa487 FromStructure(RC_06974d55bca345bb983c839ad25aa487 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_06974d55bca345bb983c839ad25aa487(s, config);
}

}


