using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ApprovalProcessLevelEntraRoleRecord
public class RESTRC_06974d55bca345bb983c839ad25aa487 : AbstractRESTStructure<RC_06974d55bca345bb983c839ad25aa487> {
[JsonProperty("ApprovalProcessLevel")]
public ssConectaProveedores.RestRecords.RESTEN_1d28318723f39133c60733b3cce8955eEntityRecord AttrApprovalProcessLevel;

[JsonProperty("EntraRole")]
public ssConectaProveedores.RestRecords.RESTEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord AttrEntraRole;

public RESTRC_06974d55bca345bb983c839ad25aa487() { }

public RESTRC_06974d55bca345bb983c839ad25aa487 (RC_06974d55bca345bb983c839ad25aa487 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrApprovalProcessLevel = ConvertToRestWithoutDefaults(s.ssENApprovalProcessLevel, new EN_1d28318723f39133c60733b3cce8955eEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_1d28318723f39133c60733b3cce8955eEntityRecord.FromStructure, config);
AttrEntraRole = ConvertToRestWithoutDefaults(s.ssENEntraRole, new EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord.FromStructure, config);
  } else {
AttrApprovalProcessLevel = ssConectaProveedores.RestRecords.RESTEN_1d28318723f39133c60733b3cce8955eEntityRecord.FromStructure(s.ssENApprovalProcessLevel, config);
AttrEntraRole = ssConectaProveedores.RestRecords.RESTEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord.FromStructure(s.ssENEntraRole, config);
  }
}

public static RC_06974d55bca345bb983c839ad25aa487 ToStructure(ssConectaProveedores.RestRecords.RESTRC_06974d55bca345bb983c839ad25aa487 obj) { 
  RC_06974d55bca345bb983c839ad25aa487 s = new RC_06974d55bca345bb983c839ad25aa487();
  if(obj != null) {
  s.ssENApprovalProcessLevel = ssConectaProveedores.RestRecords.RESTEN_1d28318723f39133c60733b3cce8955eEntityRecord.ToStructure(obj.AttrApprovalProcessLevel);
  s.ssENEntraRole = ssConectaProveedores.RestRecords.RESTEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord.ToStructure(obj.AttrEntraRole);
  }
  return s;
}

public static Func<RC_06974d55bca345bb983c839ad25aa487, ssConectaProveedores.RestRecords.RESTRC_06974d55bca345bb983c839ad25aa487> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_06974d55bca345bb983c839ad25aa487 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_06974d55bca345bb983c839ad25aa487 FromStructure(RC_06974d55bca345bb983c839ad25aa487 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_06974d55bca345bb983c839ad25aa487(s, config);
}

}


