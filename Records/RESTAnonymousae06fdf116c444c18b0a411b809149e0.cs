using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ApprovalProcessProcessTypeApprovalProcessTypeRecord
public class RESTRC_8cfc2af1075444d3070aa6269dcfdf32 : AbstractRESTStructure<RC_8cfc2af1075444d3070aa6269dcfdf32> {
[JsonProperty("ApprovalProcess")]
public ssConectaProveedores.RestRecords.RESTEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord AttrApprovalProcess;

[JsonProperty("ProcessType")]
public ssConectaProveedores.RestRecords.RESTEN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord AttrProcessType;

[JsonProperty("ApprovalProcessType")]
public ssConectaProveedores.RestRecords.RESTEN_51146e8018c571ce25065b00ce0d3a4dEntityRecord AttrApprovalProcessType;

public RESTRC_8cfc2af1075444d3070aa6269dcfdf32() { }

public RESTRC_8cfc2af1075444d3070aa6269dcfdf32 (RC_8cfc2af1075444d3070aa6269dcfdf32 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrApprovalProcess = ConvertToRestWithoutDefaults(s.ssENApprovalProcess, new EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord.FromStructure, config);
AttrProcessType = ConvertToRestWithoutDefaults(s.ssENProcessType, new EN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord.FromStructure, config);
AttrApprovalProcessType = ConvertToRestWithoutDefaults(s.ssENApprovalProcessType, new EN_51146e8018c571ce25065b00ce0d3a4dEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_51146e8018c571ce25065b00ce0d3a4dEntityRecord.FromStructure, config);
  } else {
AttrApprovalProcess = ssConectaProveedores.RestRecords.RESTEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord.FromStructure(s.ssENApprovalProcess, config);
AttrProcessType = ssConectaProveedores.RestRecords.RESTEN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord.FromStructure(s.ssENProcessType, config);
AttrApprovalProcessType = ssConectaProveedores.RestRecords.RESTEN_51146e8018c571ce25065b00ce0d3a4dEntityRecord.FromStructure(s.ssENApprovalProcessType, config);
  }
}

public static RC_8cfc2af1075444d3070aa6269dcfdf32 ToStructure(ssConectaProveedores.RestRecords.RESTRC_8cfc2af1075444d3070aa6269dcfdf32 obj) { 
  RC_8cfc2af1075444d3070aa6269dcfdf32 s = new RC_8cfc2af1075444d3070aa6269dcfdf32();
  if(obj != null) {
  s.ssENApprovalProcess = ssConectaProveedores.RestRecords.RESTEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord.ToStructure(obj.AttrApprovalProcess);
  s.ssENProcessType = ssConectaProveedores.RestRecords.RESTEN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord.ToStructure(obj.AttrProcessType);
  s.ssENApprovalProcessType = ssConectaProveedores.RestRecords.RESTEN_51146e8018c571ce25065b00ce0d3a4dEntityRecord.ToStructure(obj.AttrApprovalProcessType);
  }
  return s;
}

public static Func<RC_8cfc2af1075444d3070aa6269dcfdf32, ssConectaProveedores.RestRecords.RESTRC_8cfc2af1075444d3070aa6269dcfdf32> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_8cfc2af1075444d3070aa6269dcfdf32 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_8cfc2af1075444d3070aa6269dcfdf32 FromStructure(RC_8cfc2af1075444d3070aa6269dcfdf32 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_8cfc2af1075444d3070aa6269dcfdf32(s, config);
}

}


