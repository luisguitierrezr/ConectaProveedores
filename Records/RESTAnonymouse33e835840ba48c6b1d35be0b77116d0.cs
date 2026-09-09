using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ApprovalProcessLevelApprovalProcessProcessTypeRecord
public class RESTRC_e8e14675b36a42a5af653378f08cb179 : AbstractRESTStructure<RC_e8e14675b36a42a5af653378f08cb179> {
[JsonProperty("ApprovalProcessLevel")]
public ssConectaProveedores.RestRecords.RESTEN_1d28318723f39133c60733b3cce8955eEntityRecord AttrApprovalProcessLevel;

[JsonProperty("ApprovalProcess")]
public ssConectaProveedores.RestRecords.RESTEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord AttrApprovalProcess;

[JsonProperty("ProcessType")]
public ssConectaProveedores.RestRecords.RESTEN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord AttrProcessType;

public RESTRC_e8e14675b36a42a5af653378f08cb179() { }

public RESTRC_e8e14675b36a42a5af653378f08cb179 (RC_e8e14675b36a42a5af653378f08cb179 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrApprovalProcessLevel = ConvertToRestWithoutDefaults(s.ssENApprovalProcessLevel, new EN_1d28318723f39133c60733b3cce8955eEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_1d28318723f39133c60733b3cce8955eEntityRecord.FromStructure, config);
AttrApprovalProcess = ConvertToRestWithoutDefaults(s.ssENApprovalProcess, new EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord.FromStructure, config);
AttrProcessType = ConvertToRestWithoutDefaults(s.ssENProcessType, new EN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord.FromStructure, config);
  } else {
AttrApprovalProcessLevel = ssConectaProveedores.RestRecords.RESTEN_1d28318723f39133c60733b3cce8955eEntityRecord.FromStructure(s.ssENApprovalProcessLevel, config);
AttrApprovalProcess = ssConectaProveedores.RestRecords.RESTEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord.FromStructure(s.ssENApprovalProcess, config);
AttrProcessType = ssConectaProveedores.RestRecords.RESTEN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord.FromStructure(s.ssENProcessType, config);
  }
}

public static RC_e8e14675b36a42a5af653378f08cb179 ToStructure(ssConectaProveedores.RestRecords.RESTRC_e8e14675b36a42a5af653378f08cb179 obj) { 
  RC_e8e14675b36a42a5af653378f08cb179 s = new RC_e8e14675b36a42a5af653378f08cb179();
  if(obj != null) {
  s.ssENApprovalProcessLevel = ssConectaProveedores.RestRecords.RESTEN_1d28318723f39133c60733b3cce8955eEntityRecord.ToStructure(obj.AttrApprovalProcessLevel);
  s.ssENApprovalProcess = ssConectaProveedores.RestRecords.RESTEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord.ToStructure(obj.AttrApprovalProcess);
  s.ssENProcessType = ssConectaProveedores.RestRecords.RESTEN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord.ToStructure(obj.AttrProcessType);
  }
  return s;
}

public static Func<RC_e8e14675b36a42a5af653378f08cb179, ssConectaProveedores.RestRecords.RESTRC_e8e14675b36a42a5af653378f08cb179> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_e8e14675b36a42a5af653378f08cb179 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_e8e14675b36a42a5af653378f08cb179 FromStructure(RC_e8e14675b36a42a5af653378f08cb179 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_e8e14675b36a42a5af653378f08cb179(s, config);
}

}


