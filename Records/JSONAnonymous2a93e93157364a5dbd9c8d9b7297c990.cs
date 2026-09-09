using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ApprovalProcessLevelApprovalProcessProcessTypeApprovalProcessTypeRecord
public class JSONRC_1656f1642ecd1940e7209799a9d01108 : AbstractRESTStructure<RC_1656f1642ecd1940e7209799a9d01108> {
[JsonProperty("ApprovalProcessLevel")]
[JsonPropertyName("ApprovalProcessLevel")]
public ssConectaProveedores.RestRecords.JSONEN_1d28318723f39133c60733b3cce8955eEntityRecord AttrApprovalProcessLevel;

[JsonProperty("ApprovalProcess")]
[JsonPropertyName("ApprovalProcess")]
public ssConectaProveedores.RestRecords.JSONEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord AttrApprovalProcess;

[JsonProperty("ProcessType")]
[JsonPropertyName("ProcessType")]
public ssConectaProveedores.RestRecords.JSONEN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord AttrProcessType;

[JsonProperty("ApprovalProcessType")]
[JsonPropertyName("ApprovalProcessType")]
public ssConectaProveedores.RestRecords.JSONEN_51146e8018c571ce25065b00ce0d3a4dEntityRecord AttrApprovalProcessType;

public JSONRC_1656f1642ecd1940e7209799a9d01108() { }

public JSONRC_1656f1642ecd1940e7209799a9d01108 (RC_1656f1642ecd1940e7209799a9d01108 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrApprovalProcessLevel = ConvertToRestWithoutDefaults(s.ssENApprovalProcessLevel, new EN_1d28318723f39133c60733b3cce8955eEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_1d28318723f39133c60733b3cce8955eEntityRecord.FromStructure, config);
AttrApprovalProcess = ConvertToRestWithoutDefaults(s.ssENApprovalProcess, new EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord.FromStructure, config);
AttrProcessType = ConvertToRestWithoutDefaults(s.ssENProcessType, new EN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord.FromStructure, config);
AttrApprovalProcessType = ConvertToRestWithoutDefaults(s.ssENApprovalProcessType, new EN_51146e8018c571ce25065b00ce0d3a4dEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_51146e8018c571ce25065b00ce0d3a4dEntityRecord.FromStructure, config);
  } else {
AttrApprovalProcessLevel = ssConectaProveedores.RestRecords.JSONEN_1d28318723f39133c60733b3cce8955eEntityRecord.FromStructure(s.ssENApprovalProcessLevel, config);
AttrApprovalProcess = ssConectaProveedores.RestRecords.JSONEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord.FromStructure(s.ssENApprovalProcess, config);
AttrProcessType = ssConectaProveedores.RestRecords.JSONEN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord.FromStructure(s.ssENProcessType, config);
AttrApprovalProcessType = ssConectaProveedores.RestRecords.JSONEN_51146e8018c571ce25065b00ce0d3a4dEntityRecord.FromStructure(s.ssENApprovalProcessType, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_1656f1642ecd1940e7209799a9d01108, RC_1656f1642ecd1940e7209799a9d01108> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_1656f1642ecd1940e7209799a9d01108 s) => ToStructure(s, config);
}
public static RC_1656f1642ecd1940e7209799a9d01108 ToStructure(ssConectaProveedores.RestRecords.JSONRC_1656f1642ecd1940e7209799a9d01108 obj, IBehaviorsConfiguration config) { 
  RC_1656f1642ecd1940e7209799a9d01108 s = new RC_1656f1642ecd1940e7209799a9d01108();
  if(obj != null) {
  s.ssENApprovalProcessLevel = ssConectaProveedores.RestRecords.JSONEN_1d28318723f39133c60733b3cce8955eEntityRecord.ToStructure(obj.AttrApprovalProcessLevel, config);
  s.ssENApprovalProcess = ssConectaProveedores.RestRecords.JSONEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord.ToStructure(obj.AttrApprovalProcess, config);
  s.ssENProcessType = ssConectaProveedores.RestRecords.JSONEN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord.ToStructure(obj.AttrProcessType, config);
  s.ssENApprovalProcessType = ssConectaProveedores.RestRecords.JSONEN_51146e8018c571ce25065b00ce0d3a4dEntityRecord.ToStructure(obj.AttrApprovalProcessType, config);
  }
  return s;
}

public static Func<RC_1656f1642ecd1940e7209799a9d01108, ssConectaProveedores.RestRecords.JSONRC_1656f1642ecd1940e7209799a9d01108> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_1656f1642ecd1940e7209799a9d01108 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_1656f1642ecd1940e7209799a9d01108 FromStructure(RC_1656f1642ecd1940e7209799a9d01108 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_1656f1642ecd1940e7209799a9d01108(s, config);
}

}


