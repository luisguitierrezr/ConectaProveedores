using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ApprovalProcessSpecialWorkflowUploadPuestosSpecialWorkflowsRecord
public class JSONRC_0a46451d8756128c280ededf206b35a5 : AbstractRESTStructure<RC_0a46451d8756128c280ededf206b35a5> {
[JsonProperty("ApprovalProcess")]
[JsonPropertyName("ApprovalProcess")]
public ssConectaProveedores.RestRecords.JSONEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord AttrApprovalProcess;

[JsonProperty("SpecialWorkflowUploadPuestos")]
[JsonPropertyName("SpecialWorkflowUploadPuestos")]
public ssConectaProveedores.RestRecords.JSONEN_6cd53511aabe58e5fca112b15ac56b29EntityRecord AttrSpecialWorkflowUploadPuestos;

[JsonProperty("SpecialWorkflows")]
[JsonPropertyName("SpecialWorkflows")]
public ssConectaProveedores.RestRecords.JSONEN_1225cc7d9c16ad5c0cda10edb493a67fEntityRecord AttrSpecialWorkflows;

public JSONRC_0a46451d8756128c280ededf206b35a5() { }

public JSONRC_0a46451d8756128c280ededf206b35a5 (RC_0a46451d8756128c280ededf206b35a5 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrApprovalProcess = ConvertToRestWithoutDefaults(s.ssENApprovalProcess, new EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord.FromStructure, config);
AttrSpecialWorkflowUploadPuestos = ConvertToRestWithoutDefaults(s.ssENSpecialWorkflowUploadPuestos, new EN_6cd53511aabe58e5fca112b15ac56b29EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_6cd53511aabe58e5fca112b15ac56b29EntityRecord.FromStructure, config);
AttrSpecialWorkflows = ConvertToRestWithoutDefaults(s.ssENSpecialWorkflows, new EN_1225cc7d9c16ad5c0cda10edb493a67fEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_1225cc7d9c16ad5c0cda10edb493a67fEntityRecord.FromStructure, config);
  } else {
AttrApprovalProcess = ssConectaProveedores.RestRecords.JSONEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord.FromStructure(s.ssENApprovalProcess, config);
AttrSpecialWorkflowUploadPuestos = ssConectaProveedores.RestRecords.JSONEN_6cd53511aabe58e5fca112b15ac56b29EntityRecord.FromStructure(s.ssENSpecialWorkflowUploadPuestos, config);
AttrSpecialWorkflows = ssConectaProveedores.RestRecords.JSONEN_1225cc7d9c16ad5c0cda10edb493a67fEntityRecord.FromStructure(s.ssENSpecialWorkflows, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_0a46451d8756128c280ededf206b35a5, RC_0a46451d8756128c280ededf206b35a5> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_0a46451d8756128c280ededf206b35a5 s) => ToStructure(s, config);
}
public static RC_0a46451d8756128c280ededf206b35a5 ToStructure(ssConectaProveedores.RestRecords.JSONRC_0a46451d8756128c280ededf206b35a5 obj, IBehaviorsConfiguration config) { 
  RC_0a46451d8756128c280ededf206b35a5 s = new RC_0a46451d8756128c280ededf206b35a5();
  if(obj != null) {
  s.ssENApprovalProcess = ssConectaProveedores.RestRecords.JSONEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord.ToStructure(obj.AttrApprovalProcess, config);
  s.ssENSpecialWorkflowUploadPuestos = ssConectaProveedores.RestRecords.JSONEN_6cd53511aabe58e5fca112b15ac56b29EntityRecord.ToStructure(obj.AttrSpecialWorkflowUploadPuestos, config);
  s.ssENSpecialWorkflows = ssConectaProveedores.RestRecords.JSONEN_1225cc7d9c16ad5c0cda10edb493a67fEntityRecord.ToStructure(obj.AttrSpecialWorkflows, config);
  }
  return s;
}

public static Func<RC_0a46451d8756128c280ededf206b35a5, ssConectaProveedores.RestRecords.JSONRC_0a46451d8756128c280ededf206b35a5> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_0a46451d8756128c280ededf206b35a5 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_0a46451d8756128c280ededf206b35a5 FromStructure(RC_0a46451d8756128c280ededf206b35a5 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_0a46451d8756128c280ededf206b35a5(s, config);
}

}


