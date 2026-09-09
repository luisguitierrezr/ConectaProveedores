using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ApprovalProcessRequisitionRequisitionApprovalRecord
public class JSONRC_8ada9c8e65e1e09d1e1af032494a5fa8 : AbstractRESTStructure<RC_8ada9c8e65e1e09d1e1af032494a5fa8> {
[JsonProperty("ApprovalProcess")]
[JsonPropertyName("ApprovalProcess")]
public ssConectaProveedores.RestRecords.JSONEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord AttrApprovalProcess;

[JsonProperty("Requisition")]
[JsonPropertyName("Requisition")]
public ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord AttrRequisition;

[JsonProperty("RequisitionApproval")]
[JsonPropertyName("RequisitionApproval")]
public ssConectaProveedores.RestRecords.JSONEN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord AttrRequisitionApproval;

public JSONRC_8ada9c8e65e1e09d1e1af032494a5fa8() { }

public JSONRC_8ada9c8e65e1e09d1e1af032494a5fa8 (RC_8ada9c8e65e1e09d1e1af032494a5fa8 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrApprovalProcess = ConvertToRestWithoutDefaults(s.ssENApprovalProcess, new EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord.FromStructure, config);
AttrRequisition = ConvertToRestWithoutDefaults(s.ssENRequisition, new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure, config);
AttrRequisitionApproval = ConvertToRestWithoutDefaults(s.ssENRequisitionApproval, new EN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord.FromStructure, config);
  } else {
AttrApprovalProcess = ssConectaProveedores.RestRecords.JSONEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord.FromStructure(s.ssENApprovalProcess, config);
AttrRequisition = ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure(s.ssENRequisition, config);
AttrRequisitionApproval = ssConectaProveedores.RestRecords.JSONEN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord.FromStructure(s.ssENRequisitionApproval, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_8ada9c8e65e1e09d1e1af032494a5fa8, RC_8ada9c8e65e1e09d1e1af032494a5fa8> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_8ada9c8e65e1e09d1e1af032494a5fa8 s) => ToStructure(s, config);
}
public static RC_8ada9c8e65e1e09d1e1af032494a5fa8 ToStructure(ssConectaProveedores.RestRecords.JSONRC_8ada9c8e65e1e09d1e1af032494a5fa8 obj, IBehaviorsConfiguration config) { 
  RC_8ada9c8e65e1e09d1e1af032494a5fa8 s = new RC_8ada9c8e65e1e09d1e1af032494a5fa8();
  if(obj != null) {
  s.ssENApprovalProcess = ssConectaProveedores.RestRecords.JSONEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord.ToStructure(obj.AttrApprovalProcess, config);
  s.ssENRequisition = ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.ToStructure(obj.AttrRequisition, config);
  s.ssENRequisitionApproval = ssConectaProveedores.RestRecords.JSONEN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord.ToStructure(obj.AttrRequisitionApproval, config);
  }
  return s;
}

public static Func<RC_8ada9c8e65e1e09d1e1af032494a5fa8, ssConectaProveedores.RestRecords.JSONRC_8ada9c8e65e1e09d1e1af032494a5fa8> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_8ada9c8e65e1e09d1e1af032494a5fa8 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_8ada9c8e65e1e09d1e1af032494a5fa8 FromStructure(RC_8ada9c8e65e1e09d1e1af032494a5fa8 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_8ada9c8e65e1e09d1e1af032494a5fa8(s, config);
}

}


