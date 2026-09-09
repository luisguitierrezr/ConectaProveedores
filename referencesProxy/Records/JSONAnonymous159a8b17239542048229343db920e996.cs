using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// ApprovalProcessLevelRecord
public class JSONRC_7ec02fc4f43bb6e10050644c8c1ae31b : AbstractRESTStructure<RC_7ec02fc4f43bb6e10050644c8c1ae31b> {
[JsonProperty("ApprovalProcessLevel")]
[JsonPropertyName("ApprovalProcessLevel")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_1d28318723f39133c60733b3cce8955eEntityRecord AttrApprovalProcessLevel;

public JSONRC_7ec02fc4f43bb6e10050644c8c1ae31b() { }

public JSONRC_7ec02fc4f43bb6e10050644c8c1ae31b (RC_7ec02fc4f43bb6e10050644c8c1ae31b s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrApprovalProcessLevel = ConvertToRestWithoutDefaults(s.ssENApprovalProcessLevel, new EN_1d28318723f39133c60733b3cce8955eEntityRecord(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_1d28318723f39133c60733b3cce8955eEntityRecord.FromStructure, config);
  } else {
AttrApprovalProcessLevel = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_1d28318723f39133c60733b3cce8955eEntityRecord.FromStructure(s.ssENApprovalProcessLevel, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_7ec02fc4f43bb6e10050644c8c1ae31b, RC_7ec02fc4f43bb6e10050644c8c1ae31b> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_7ec02fc4f43bb6e10050644c8c1ae31b s) => ToStructure(s, config);
}
public static RC_7ec02fc4f43bb6e10050644c8c1ae31b ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_7ec02fc4f43bb6e10050644c8c1ae31b obj, IBehaviorsConfiguration config) { 
  RC_7ec02fc4f43bb6e10050644c8c1ae31b s = new RC_7ec02fc4f43bb6e10050644c8c1ae31b();
  if(obj != null) {
  s.ssENApprovalProcessLevel = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_1d28318723f39133c60733b3cce8955eEntityRecord.ToStructure(obj.AttrApprovalProcessLevel, config);
  }
  return s;
}

public static Func<RC_7ec02fc4f43bb6e10050644c8c1ae31b, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_7ec02fc4f43bb6e10050644c8c1ae31b> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_7ec02fc4f43bb6e10050644c8c1ae31b s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_7ec02fc4f43bb6e10050644c8c1ae31b FromStructure(RC_7ec02fc4f43bb6e10050644c8c1ae31b s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_7ec02fc4f43bb6e10050644c8c1ae31b(s, config);
}

}


