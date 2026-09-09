using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ApprovalProcessRequisitionRequisitionApprovalRecord
public class RESTRC_8ada9c8e65e1e09d1e1af032494a5fa8 : AbstractRESTStructure<RC_8ada9c8e65e1e09d1e1af032494a5fa8> {
[JsonProperty("ApprovalProcess")]
public ssConectaProveedores.RestRecords.RESTEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord AttrApprovalProcess;

[JsonProperty("Requisition")]
public ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord AttrRequisition;

[JsonProperty("RequisitionApproval")]
public ssConectaProveedores.RestRecords.RESTEN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord AttrRequisitionApproval;

public RESTRC_8ada9c8e65e1e09d1e1af032494a5fa8() { }

public RESTRC_8ada9c8e65e1e09d1e1af032494a5fa8 (RC_8ada9c8e65e1e09d1e1af032494a5fa8 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrApprovalProcess = ConvertToRestWithoutDefaults(s.ssENApprovalProcess, new EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord.FromStructure, config);
AttrRequisition = ConvertToRestWithoutDefaults(s.ssENRequisition, new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure, config);
AttrRequisitionApproval = ConvertToRestWithoutDefaults(s.ssENRequisitionApproval, new EN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord.FromStructure, config);
  } else {
AttrApprovalProcess = ssConectaProveedores.RestRecords.RESTEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord.FromStructure(s.ssENApprovalProcess, config);
AttrRequisition = ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure(s.ssENRequisition, config);
AttrRequisitionApproval = ssConectaProveedores.RestRecords.RESTEN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord.FromStructure(s.ssENRequisitionApproval, config);
  }
}

public static RC_8ada9c8e65e1e09d1e1af032494a5fa8 ToStructure(ssConectaProveedores.RestRecords.RESTRC_8ada9c8e65e1e09d1e1af032494a5fa8 obj) { 
  RC_8ada9c8e65e1e09d1e1af032494a5fa8 s = new RC_8ada9c8e65e1e09d1e1af032494a5fa8();
  if(obj != null) {
  s.ssENApprovalProcess = ssConectaProveedores.RestRecords.RESTEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord.ToStructure(obj.AttrApprovalProcess);
  s.ssENRequisition = ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.ToStructure(obj.AttrRequisition);
  s.ssENRequisitionApproval = ssConectaProveedores.RestRecords.RESTEN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord.ToStructure(obj.AttrRequisitionApproval);
  }
  return s;
}

public static Func<RC_8ada9c8e65e1e09d1e1af032494a5fa8, ssConectaProveedores.RestRecords.RESTRC_8ada9c8e65e1e09d1e1af032494a5fa8> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_8ada9c8e65e1e09d1e1af032494a5fa8 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_8ada9c8e65e1e09d1e1af032494a5fa8 FromStructure(RC_8ada9c8e65e1e09d1e1af032494a5fa8 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_8ada9c8e65e1e09d1e1af032494a5fa8(s, config);
}

}


