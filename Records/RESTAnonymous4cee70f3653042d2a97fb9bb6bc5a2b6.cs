using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionApprovalLevelRequisitionApprovalRecord
public class RESTRC_7a202946b9c9ade4fc5b7dc7c07f3279 : AbstractRESTStructure<RC_7a202946b9c9ade4fc5b7dc7c07f3279> {
[JsonProperty("RequisitionApprovalLevel")]
public ssConectaProveedores.RestRecords.RESTEN_27b1469f497d364a764a1359956ef9adEntityRecord AttrRequisitionApprovalLevel;

[JsonProperty("RequisitionApproval")]
public ssConectaProveedores.RestRecords.RESTEN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord AttrRequisitionApproval;

public RESTRC_7a202946b9c9ade4fc5b7dc7c07f3279() { }

public RESTRC_7a202946b9c9ade4fc5b7dc7c07f3279 (RC_7a202946b9c9ade4fc5b7dc7c07f3279 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRequisitionApprovalLevel = ConvertToRestWithoutDefaults(s.ssENRequisitionApprovalLevel, new EN_27b1469f497d364a764a1359956ef9adEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_27b1469f497d364a764a1359956ef9adEntityRecord.FromStructure, config);
AttrRequisitionApproval = ConvertToRestWithoutDefaults(s.ssENRequisitionApproval, new EN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord.FromStructure, config);
  } else {
AttrRequisitionApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_27b1469f497d364a764a1359956ef9adEntityRecord.FromStructure(s.ssENRequisitionApprovalLevel, config);
AttrRequisitionApproval = ssConectaProveedores.RestRecords.RESTEN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord.FromStructure(s.ssENRequisitionApproval, config);
  }
}

public static RC_7a202946b9c9ade4fc5b7dc7c07f3279 ToStructure(ssConectaProveedores.RestRecords.RESTRC_7a202946b9c9ade4fc5b7dc7c07f3279 obj) { 
  RC_7a202946b9c9ade4fc5b7dc7c07f3279 s = new RC_7a202946b9c9ade4fc5b7dc7c07f3279();
  if(obj != null) {
  s.ssENRequisitionApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_27b1469f497d364a764a1359956ef9adEntityRecord.ToStructure(obj.AttrRequisitionApprovalLevel);
  s.ssENRequisitionApproval = ssConectaProveedores.RestRecords.RESTEN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord.ToStructure(obj.AttrRequisitionApproval);
  }
  return s;
}

public static Func<RC_7a202946b9c9ade4fc5b7dc7c07f3279, ssConectaProveedores.RestRecords.RESTRC_7a202946b9c9ade4fc5b7dc7c07f3279> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_7a202946b9c9ade4fc5b7dc7c07f3279 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_7a202946b9c9ade4fc5b7dc7c07f3279 FromStructure(RC_7a202946b9c9ade4fc5b7dc7c07f3279 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_7a202946b9c9ade4fc5b7dc7c07f3279(s, config);
}

}


