using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ApprovalProcessLevelApprovalProcessProcessTypeRecord
public class JSONRC_e8e14675b36a42a5af653378f08cb179 : AbstractRESTStructure<RC_e8e14675b36a42a5af653378f08cb179> {
[JsonProperty("ApprovalProcessLevel")]
[JsonPropertyName("ApprovalProcessLevel")]
public ssConectaProveedores.RestRecords.JSONEN_1d28318723f39133c60733b3cce8955eEntityRecord AttrApprovalProcessLevel;

[JsonProperty("ApprovalProcess")]
[JsonPropertyName("ApprovalProcess")]
public ssConectaProveedores.RestRecords.JSONEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord AttrApprovalProcess;

[JsonProperty("ProcessType")]
[JsonPropertyName("ProcessType")]
public ssConectaProveedores.RestRecords.JSONEN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord AttrProcessType;

public JSONRC_e8e14675b36a42a5af653378f08cb179() { }

public JSONRC_e8e14675b36a42a5af653378f08cb179 (RC_e8e14675b36a42a5af653378f08cb179 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrApprovalProcessLevel = ConvertToRestWithoutDefaults(s.ssENApprovalProcessLevel, new EN_1d28318723f39133c60733b3cce8955eEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_1d28318723f39133c60733b3cce8955eEntityRecord.FromStructure, config);
AttrApprovalProcess = ConvertToRestWithoutDefaults(s.ssENApprovalProcess, new EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord.FromStructure, config);
AttrProcessType = ConvertToRestWithoutDefaults(s.ssENProcessType, new EN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord.FromStructure, config);
  } else {
AttrApprovalProcessLevel = ssConectaProveedores.RestRecords.JSONEN_1d28318723f39133c60733b3cce8955eEntityRecord.FromStructure(s.ssENApprovalProcessLevel, config);
AttrApprovalProcess = ssConectaProveedores.RestRecords.JSONEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord.FromStructure(s.ssENApprovalProcess, config);
AttrProcessType = ssConectaProveedores.RestRecords.JSONEN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord.FromStructure(s.ssENProcessType, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_e8e14675b36a42a5af653378f08cb179, RC_e8e14675b36a42a5af653378f08cb179> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_e8e14675b36a42a5af653378f08cb179 s) => ToStructure(s, config);
}
public static RC_e8e14675b36a42a5af653378f08cb179 ToStructure(ssConectaProveedores.RestRecords.JSONRC_e8e14675b36a42a5af653378f08cb179 obj, IBehaviorsConfiguration config) { 
  RC_e8e14675b36a42a5af653378f08cb179 s = new RC_e8e14675b36a42a5af653378f08cb179();
  if(obj != null) {
  s.ssENApprovalProcessLevel = ssConectaProveedores.RestRecords.JSONEN_1d28318723f39133c60733b3cce8955eEntityRecord.ToStructure(obj.AttrApprovalProcessLevel, config);
  s.ssENApprovalProcess = ssConectaProveedores.RestRecords.JSONEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord.ToStructure(obj.AttrApprovalProcess, config);
  s.ssENProcessType = ssConectaProveedores.RestRecords.JSONEN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord.ToStructure(obj.AttrProcessType, config);
  }
  return s;
}

public static Func<RC_e8e14675b36a42a5af653378f08cb179, ssConectaProveedores.RestRecords.JSONRC_e8e14675b36a42a5af653378f08cb179> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_e8e14675b36a42a5af653378f08cb179 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_e8e14675b36a42a5af653378f08cb179 FromStructure(RC_e8e14675b36a42a5af653378f08cb179 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_e8e14675b36a42a5af653378f08cb179(s, config);
}

}


