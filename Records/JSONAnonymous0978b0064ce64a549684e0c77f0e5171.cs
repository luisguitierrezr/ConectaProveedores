using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ApprovalProcessSpecialWorkflowUploadPuestosSpecialWorkflowsRequisitionApprovalRecord
public class JSONRC_f8a6a0591753be81aad5115c1222bf32 : AbstractRESTStructure<RC_f8a6a0591753be81aad5115c1222bf32> {
[JsonProperty("ApprovalProcess")]
[JsonPropertyName("ApprovalProcess")]
public ssConectaProveedores.RestRecords.JSONEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord AttrApprovalProcess;

[JsonProperty("SpecialWorkflowUploadPuestos")]
[JsonPropertyName("SpecialWorkflowUploadPuestos")]
public ssConectaProveedores.RestRecords.JSONEN_6cd53511aabe58e5fca112b15ac56b29EntityRecord AttrSpecialWorkflowUploadPuestos;

[JsonProperty("SpecialWorkflows")]
[JsonPropertyName("SpecialWorkflows")]
public ssConectaProveedores.RestRecords.JSONEN_1225cc7d9c16ad5c0cda10edb493a67fEntityRecord AttrSpecialWorkflows;

[JsonProperty("RequisitionApproval")]
[JsonPropertyName("RequisitionApproval")]
public ssConectaProveedores.RestRecords.JSONEN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord AttrRequisitionApproval;

public JSONRC_f8a6a0591753be81aad5115c1222bf32() { }

public JSONRC_f8a6a0591753be81aad5115c1222bf32 (RC_f8a6a0591753be81aad5115c1222bf32 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrApprovalProcess = ConvertToRestWithoutDefaults(s.ssENApprovalProcess, new EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord.FromStructure, config);
AttrSpecialWorkflowUploadPuestos = ConvertToRestWithoutDefaults(s.ssENSpecialWorkflowUploadPuestos, new EN_6cd53511aabe58e5fca112b15ac56b29EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_6cd53511aabe58e5fca112b15ac56b29EntityRecord.FromStructure, config);
AttrSpecialWorkflows = ConvertToRestWithoutDefaults(s.ssENSpecialWorkflows, new EN_1225cc7d9c16ad5c0cda10edb493a67fEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_1225cc7d9c16ad5c0cda10edb493a67fEntityRecord.FromStructure, config);
AttrRequisitionApproval = ConvertToRestWithoutDefaults(s.ssENRequisitionApproval, new EN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord.FromStructure, config);
  } else {
AttrApprovalProcess = ssConectaProveedores.RestRecords.JSONEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord.FromStructure(s.ssENApprovalProcess, config);
AttrSpecialWorkflowUploadPuestos = ssConectaProveedores.RestRecords.JSONEN_6cd53511aabe58e5fca112b15ac56b29EntityRecord.FromStructure(s.ssENSpecialWorkflowUploadPuestos, config);
AttrSpecialWorkflows = ssConectaProveedores.RestRecords.JSONEN_1225cc7d9c16ad5c0cda10edb493a67fEntityRecord.FromStructure(s.ssENSpecialWorkflows, config);
AttrRequisitionApproval = ssConectaProveedores.RestRecords.JSONEN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord.FromStructure(s.ssENRequisitionApproval, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_f8a6a0591753be81aad5115c1222bf32, RC_f8a6a0591753be81aad5115c1222bf32> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_f8a6a0591753be81aad5115c1222bf32 s) => ToStructure(s, config);
}
public static RC_f8a6a0591753be81aad5115c1222bf32 ToStructure(ssConectaProveedores.RestRecords.JSONRC_f8a6a0591753be81aad5115c1222bf32 obj, IBehaviorsConfiguration config) { 
  RC_f8a6a0591753be81aad5115c1222bf32 s = new RC_f8a6a0591753be81aad5115c1222bf32();
  if(obj != null) {
  s.ssENApprovalProcess = ssConectaProveedores.RestRecords.JSONEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord.ToStructure(obj.AttrApprovalProcess, config);
  s.ssENSpecialWorkflowUploadPuestos = ssConectaProveedores.RestRecords.JSONEN_6cd53511aabe58e5fca112b15ac56b29EntityRecord.ToStructure(obj.AttrSpecialWorkflowUploadPuestos, config);
  s.ssENSpecialWorkflows = ssConectaProveedores.RestRecords.JSONEN_1225cc7d9c16ad5c0cda10edb493a67fEntityRecord.ToStructure(obj.AttrSpecialWorkflows, config);
  s.ssENRequisitionApproval = ssConectaProveedores.RestRecords.JSONEN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord.ToStructure(obj.AttrRequisitionApproval, config);
  }
  return s;
}

public static Func<RC_f8a6a0591753be81aad5115c1222bf32, ssConectaProveedores.RestRecords.JSONRC_f8a6a0591753be81aad5115c1222bf32> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_f8a6a0591753be81aad5115c1222bf32 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_f8a6a0591753be81aad5115c1222bf32 FromStructure(RC_f8a6a0591753be81aad5115c1222bf32 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_f8a6a0591753be81aad5115c1222bf32(s, config);
}

}


