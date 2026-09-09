using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ApprovalProcessProcessTypeApprovalProcessTypeRecord
public class JSONRC_8cfc2af1075444d3070aa6269dcfdf32 : AbstractRESTStructure<RC_8cfc2af1075444d3070aa6269dcfdf32> {
[JsonProperty("ApprovalProcess")]
[JsonPropertyName("ApprovalProcess")]
public ssConectaProveedores.RestRecords.JSONEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord AttrApprovalProcess;

[JsonProperty("ProcessType")]
[JsonPropertyName("ProcessType")]
public ssConectaProveedores.RestRecords.JSONEN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord AttrProcessType;

[JsonProperty("ApprovalProcessType")]
[JsonPropertyName("ApprovalProcessType")]
public ssConectaProveedores.RestRecords.JSONEN_51146e8018c571ce25065b00ce0d3a4dEntityRecord AttrApprovalProcessType;

public JSONRC_8cfc2af1075444d3070aa6269dcfdf32() { }

public JSONRC_8cfc2af1075444d3070aa6269dcfdf32 (RC_8cfc2af1075444d3070aa6269dcfdf32 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrApprovalProcess = ConvertToRestWithoutDefaults(s.ssENApprovalProcess, new EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord.FromStructure, config);
AttrProcessType = ConvertToRestWithoutDefaults(s.ssENProcessType, new EN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord.FromStructure, config);
AttrApprovalProcessType = ConvertToRestWithoutDefaults(s.ssENApprovalProcessType, new EN_51146e8018c571ce25065b00ce0d3a4dEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_51146e8018c571ce25065b00ce0d3a4dEntityRecord.FromStructure, config);
  } else {
AttrApprovalProcess = ssConectaProveedores.RestRecords.JSONEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord.FromStructure(s.ssENApprovalProcess, config);
AttrProcessType = ssConectaProveedores.RestRecords.JSONEN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord.FromStructure(s.ssENProcessType, config);
AttrApprovalProcessType = ssConectaProveedores.RestRecords.JSONEN_51146e8018c571ce25065b00ce0d3a4dEntityRecord.FromStructure(s.ssENApprovalProcessType, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_8cfc2af1075444d3070aa6269dcfdf32, RC_8cfc2af1075444d3070aa6269dcfdf32> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_8cfc2af1075444d3070aa6269dcfdf32 s) => ToStructure(s, config);
}
public static RC_8cfc2af1075444d3070aa6269dcfdf32 ToStructure(ssConectaProveedores.RestRecords.JSONRC_8cfc2af1075444d3070aa6269dcfdf32 obj, IBehaviorsConfiguration config) { 
  RC_8cfc2af1075444d3070aa6269dcfdf32 s = new RC_8cfc2af1075444d3070aa6269dcfdf32();
  if(obj != null) {
  s.ssENApprovalProcess = ssConectaProveedores.RestRecords.JSONEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord.ToStructure(obj.AttrApprovalProcess, config);
  s.ssENProcessType = ssConectaProveedores.RestRecords.JSONEN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord.ToStructure(obj.AttrProcessType, config);
  s.ssENApprovalProcessType = ssConectaProveedores.RestRecords.JSONEN_51146e8018c571ce25065b00ce0d3a4dEntityRecord.ToStructure(obj.AttrApprovalProcessType, config);
  }
  return s;
}

public static Func<RC_8cfc2af1075444d3070aa6269dcfdf32, ssConectaProveedores.RestRecords.JSONRC_8cfc2af1075444d3070aa6269dcfdf32> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_8cfc2af1075444d3070aa6269dcfdf32 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_8cfc2af1075444d3070aa6269dcfdf32 FromStructure(RC_8cfc2af1075444d3070aa6269dcfdf32 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_8cfc2af1075444d3070aa6269dcfdf32(s, config);
}

}


