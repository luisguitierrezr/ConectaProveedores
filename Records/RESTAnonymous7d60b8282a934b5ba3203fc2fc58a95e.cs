using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserRequisitionRequisitionApprovalLevelRequisitionApprovalRecord
public class RESTRC_be45dbebd99ff43af730ddaaf3b9d0b9 : AbstractRESTStructure<RC_be45dbebd99ff43af730ddaaf3b9d0b9> {
[JsonProperty("User")]
public ssConectaProveedores.RestRecords.RESTENUserEntityRecord AttrUser;

[JsonProperty("Requisition")]
public ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord AttrRequisition;

[JsonProperty("RequisitionApprovalLevel")]
public ssConectaProveedores.RestRecords.RESTEN_27b1469f497d364a764a1359956ef9adEntityRecord AttrRequisitionApprovalLevel;

[JsonProperty("RequisitionApproval")]
public ssConectaProveedores.RestRecords.RESTEN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord AttrRequisitionApproval;

public RESTRC_be45dbebd99ff43af730ddaaf3b9d0b9() { }

public RESTRC_be45dbebd99ff43af730ddaaf3b9d0b9 (RC_be45dbebd99ff43af730ddaaf3b9d0b9 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser = ConvertToRestWithoutDefaults(s.ssENUser, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure, config);
AttrRequisition = ConvertToRestWithoutDefaults(s.ssENRequisition, new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure, config);
AttrRequisitionApprovalLevel = ConvertToRestWithoutDefaults(s.ssENRequisitionApprovalLevel, new EN_27b1469f497d364a764a1359956ef9adEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_27b1469f497d364a764a1359956ef9adEntityRecord.FromStructure, config);
AttrRequisitionApproval = ConvertToRestWithoutDefaults(s.ssENRequisitionApproval, new EN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord.FromStructure, config);
  } else {
AttrUser = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure(s.ssENUser, config);
AttrRequisition = ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure(s.ssENRequisition, config);
AttrRequisitionApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_27b1469f497d364a764a1359956ef9adEntityRecord.FromStructure(s.ssENRequisitionApprovalLevel, config);
AttrRequisitionApproval = ssConectaProveedores.RestRecords.RESTEN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord.FromStructure(s.ssENRequisitionApproval, config);
  }
}

public static RC_be45dbebd99ff43af730ddaaf3b9d0b9 ToStructure(ssConectaProveedores.RestRecords.RESTRC_be45dbebd99ff43af730ddaaf3b9d0b9 obj) { 
  RC_be45dbebd99ff43af730ddaaf3b9d0b9 s = new RC_be45dbebd99ff43af730ddaaf3b9d0b9();
  if(obj != null) {
  s.ssENUser = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.ToStructure(obj.AttrUser);
  s.ssENRequisition = ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.ToStructure(obj.AttrRequisition);
  s.ssENRequisitionApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_27b1469f497d364a764a1359956ef9adEntityRecord.ToStructure(obj.AttrRequisitionApprovalLevel);
  s.ssENRequisitionApproval = ssConectaProveedores.RestRecords.RESTEN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord.ToStructure(obj.AttrRequisitionApproval);
  }
  return s;
}

public static Func<RC_be45dbebd99ff43af730ddaaf3b9d0b9, ssConectaProveedores.RestRecords.RESTRC_be45dbebd99ff43af730ddaaf3b9d0b9> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_be45dbebd99ff43af730ddaaf3b9d0b9 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_be45dbebd99ff43af730ddaaf3b9d0b9 FromStructure(RC_be45dbebd99ff43af730ddaaf3b9d0b9 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_be45dbebd99ff43af730ddaaf3b9d0b9(s, config);
}

}


