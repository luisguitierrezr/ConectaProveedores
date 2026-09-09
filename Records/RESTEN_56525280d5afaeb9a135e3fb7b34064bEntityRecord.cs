using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioApprovalLevel
public class RESTEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord : AbstractRESTStructure<EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("FolioApprovalId")]
public long? AttrFolioApprovalId;

[JsonProperty("LevelNumber")]
public int? AttrLevelNumber;

[JsonProperty("ApplicationRoleId")]
public long? AttrApplicationRoleId;

[JsonProperty("EntraJobTitle")]
public string AttrEntraJobTitle;

[JsonProperty("EntraRoleId")]
public long? AttrEntraRoleId;

[JsonProperty("DepartmentId")]
public long? AttrDepartmentId;

[JsonProperty("AssignedTo")]
public string AttrAssignedTo;

[JsonProperty("ApprovalStatusId")]
public int? AttrApprovalStatusId;

[JsonProperty("IsMandatory")]
public bool? AttrIsMandatory;

[JsonProperty("IsReassigned")]
public bool? AttrIsReassigned;

[JsonProperty("ApprovedBy")]
public string AttrApprovedBy;

[JsonProperty("ApprovedOn")]
public String AttrApprovedOn;

[JsonProperty("CanceledBy")]
public string AttrCanceledBy;

[JsonProperty("CanceledOn")]
public String AttrCanceledOn;

[JsonProperty("RejectedBy")]
public string AttrRejectedBy;

[JsonProperty("RejectedOn")]
public String AttrRejectedOn;

[JsonProperty("IsSubstituteFor")]
public string AttrIsSubstituteFor;

[JsonProperty("RejectReason")]
public string AttrRejectReason;

[JsonProperty("IsInvoiceApproval")]
public bool? AttrIsInvoiceApproval;

public RESTEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord() { }

public RESTEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord (EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrFolioApprovalId = ConvertToRestWithoutDefaults(s.ssFolioApprovalId, 0L);
AttrLevelNumber = ConvertToRestWithoutDefaults(s.ssLevelNumber, 0);
AttrApplicationRoleId = ConvertToRestWithoutDefaults(s.ssApplicationRoleId, 0L);
AttrEntraJobTitle = ConvertToRestWithoutDefaults(s.ssEntraJobTitle, "");
AttrEntraRoleId = ConvertToRestWithoutDefaults(s.ssEntraRoleId, 0L);
AttrDepartmentId = ConvertToRestWithoutDefaults(s.ssDepartmentId, 0L);
AttrAssignedTo = ConvertToRestWithoutDefaults(s.ssAssignedTo, "");
AttrApprovalStatusId = ConvertToRestWithoutDefaults(s.ssApprovalStatusId, 0);
AttrIsMandatory = ConvertToRestWithoutDefaults(s.ssIsMandatory, false);
AttrIsReassigned = ConvertToRestWithoutDefaults(s.ssIsReassigned, false);
AttrApprovedBy = ConvertToRestWithoutDefaults(s.ssApprovedBy, "");
AttrApprovedOn = ConvertDateTimeToRestWithoutDefaults(s.ssApprovedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrCanceledBy = ConvertToRestWithoutDefaults(s.ssCanceledBy, "");
AttrCanceledOn = ConvertDateTimeToRestWithoutDefaults(s.ssCanceledOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrRejectedBy = ConvertToRestWithoutDefaults(s.ssRejectedBy, "");
AttrRejectedOn = ConvertDateTimeToRestWithoutDefaults(s.ssRejectedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrIsSubstituteFor = ConvertToRestWithoutDefaults(s.ssIsSubstituteFor, "");
AttrRejectReason = ConvertToRestWithoutDefaults(s.ssRejectReason, "");
AttrIsInvoiceApproval = ConvertToRestWithoutDefaults(s.ssIsInvoiceApproval, false);
  } else {
AttrId = (long?) s.ssId;
AttrFolioApprovalId = (long?) s.ssFolioApprovalId;
AttrLevelNumber = (int?) s.ssLevelNumber;
AttrApplicationRoleId = (long?) s.ssApplicationRoleId;
AttrEntraJobTitle = s.ssEntraJobTitle;
AttrEntraRoleId = (long?) s.ssEntraRoleId;
AttrDepartmentId = (long?) s.ssDepartmentId;
AttrAssignedTo = s.ssAssignedTo;
AttrApprovalStatusId = (int?) s.ssApprovalStatusId;
AttrIsMandatory = (bool?) s.ssIsMandatory;
AttrIsReassigned = (bool?) s.ssIsReassigned;
AttrApprovedBy = s.ssApprovedBy;
AttrApprovedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssApprovedOn, config.DateTimeFormat);
AttrCanceledBy = s.ssCanceledBy;
AttrCanceledOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCanceledOn, config.DateTimeFormat);
AttrRejectedBy = s.ssRejectedBy;
AttrRejectedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssRejectedOn, config.DateTimeFormat);
AttrIsSubstituteFor = s.ssIsSubstituteFor;
AttrRejectReason = s.ssRejectReason;
AttrIsInvoiceApproval = (bool?) s.ssIsInvoiceApproval;
  }
}

public static EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord obj) { 
  EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord s = new EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssFolioApprovalId = obj.AttrFolioApprovalId == null ? 0L : obj.AttrFolioApprovalId.Value;
  s.ssLevelNumber = obj.AttrLevelNumber == null ? 0 : obj.AttrLevelNumber.Value;
  s.ssApplicationRoleId = obj.AttrApplicationRoleId == null ? 0L : obj.AttrApplicationRoleId.Value;
  s.ssEntraJobTitle = obj.AttrEntraJobTitle == null ? "" : obj.AttrEntraJobTitle;
  s.ssEntraRoleId = obj.AttrEntraRoleId == null ? 0L : obj.AttrEntraRoleId.Value;
  s.ssDepartmentId = obj.AttrDepartmentId == null ? 0L : obj.AttrDepartmentId.Value;
  s.ssAssignedTo = obj.AttrAssignedTo == null ? "" : obj.AttrAssignedTo;
  s.ssApprovalStatusId = obj.AttrApprovalStatusId == null ? 0 : obj.AttrApprovalStatusId.Value;
  s.ssIsMandatory = obj.AttrIsMandatory == null ? false : obj.AttrIsMandatory.Value;
  s.ssIsReassigned = obj.AttrIsReassigned == null ? false : obj.AttrIsReassigned.Value;
  s.ssApprovedBy = obj.AttrApprovedBy == null ? "" : obj.AttrApprovedBy;
  s.ssApprovedOn = obj.AttrApprovedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrApprovedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssCanceledBy = obj.AttrCanceledBy == null ? "" : obj.AttrCanceledBy;
  s.ssCanceledOn = obj.AttrCanceledOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCanceledOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssRejectedBy = obj.AttrRejectedBy == null ? "" : obj.AttrRejectedBy;
  s.ssRejectedOn = obj.AttrRejectedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrRejectedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssIsSubstituteFor = obj.AttrIsSubstituteFor == null ? "" : obj.AttrIsSubstituteFor;
  s.ssRejectReason = obj.AttrRejectReason == null ? "" : obj.AttrRejectReason;
  s.ssIsInvoiceApproval = obj.AttrIsInvoiceApproval == null ? false : obj.AttrIsInvoiceApproval.Value;
  }
  return s;
}

public static Func<EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord, ssConectaProveedores.RestRecords.RESTEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord FromStructure(EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord(s, config);
}

}


