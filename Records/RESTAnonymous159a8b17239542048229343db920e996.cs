using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ApprovalProcessLevelRecord
public class RESTRC_7ec02fc4f43bb6e10050644c8c1ae31b : AbstractRESTStructure<RC_7ec02fc4f43bb6e10050644c8c1ae31b> {
[JsonProperty("ApprovalProcessLevel")]
public ssConectaProveedores.RestRecords.RESTEN_1d28318723f39133c60733b3cce8955eEntityRecord AttrApprovalProcessLevel;

public RESTRC_7ec02fc4f43bb6e10050644c8c1ae31b() { }

public RESTRC_7ec02fc4f43bb6e10050644c8c1ae31b (RC_7ec02fc4f43bb6e10050644c8c1ae31b s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrApprovalProcessLevel = ConvertToRestWithoutDefaults(s.ssENApprovalProcessLevel, new EN_1d28318723f39133c60733b3cce8955eEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_1d28318723f39133c60733b3cce8955eEntityRecord.FromStructure, config);
  } else {
AttrApprovalProcessLevel = ssConectaProveedores.RestRecords.RESTEN_1d28318723f39133c60733b3cce8955eEntityRecord.FromStructure(s.ssENApprovalProcessLevel, config);
  }
}

public static RC_7ec02fc4f43bb6e10050644c8c1ae31b ToStructure(ssConectaProveedores.RestRecords.RESTRC_7ec02fc4f43bb6e10050644c8c1ae31b obj) { 
  RC_7ec02fc4f43bb6e10050644c8c1ae31b s = new RC_7ec02fc4f43bb6e10050644c8c1ae31b();
  if(obj != null) {
  s.ssENApprovalProcessLevel = ssConectaProveedores.RestRecords.RESTEN_1d28318723f39133c60733b3cce8955eEntityRecord.ToStructure(obj.AttrApprovalProcessLevel);
  }
  return s;
}

public static Func<RC_7ec02fc4f43bb6e10050644c8c1ae31b, ssConectaProveedores.RestRecords.RESTRC_7ec02fc4f43bb6e10050644c8c1ae31b> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_7ec02fc4f43bb6e10050644c8c1ae31b s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_7ec02fc4f43bb6e10050644c8c1ae31b FromStructure(RC_7ec02fc4f43bb6e10050644c8c1ae31b s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_7ec02fc4f43bb6e10050644c8c1ae31b(s, config);
}

}


