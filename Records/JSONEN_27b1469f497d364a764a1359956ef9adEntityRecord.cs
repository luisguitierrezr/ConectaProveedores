using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionApprovalLevel
public class JSONEN_27b1469f497d364a764a1359956ef9adEntityRecord : AbstractRESTStructure<EN_27b1469f497d364a764a1359956ef9adEntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("RequisitionApprovalId")]
[JsonPropertyName("RequisitionApprovalId")]
public long? AttrRequisitionApprovalId;

[JsonProperty("LevelNumber")]
[JsonPropertyName("LevelNumber")]
public int? AttrLevelNumber;

[JsonProperty("ApplicationRoleId")]
[JsonPropertyName("ApplicationRoleId")]
public long? AttrApplicationRoleId;

[JsonProperty("EntraJobTitle")]
[JsonPropertyName("EntraJobTitle")]
public string AttrEntraJobTitle;

[JsonProperty("DepartmentId")]
[JsonPropertyName("DepartmentId")]
public long? AttrDepartmentId;

[JsonProperty("ManagementId")]
[JsonPropertyName("ManagementId")]
public long? AttrManagementId;

[JsonProperty("SubdirectionId")]
[JsonPropertyName("SubdirectionId")]
public long? AttrSubdirectionId;

[JsonProperty("EntraRoleId")]
[JsonPropertyName("EntraRoleId")]
public long? AttrEntraRoleId;

[JsonProperty("EntraUserName")]
[JsonPropertyName("EntraUserName")]
public string AttrEntraUserName;

[JsonProperty("AssignedTo")]
[JsonPropertyName("AssignedTo")]
public string AttrAssignedTo;

[JsonProperty("NeedsContract")]
[JsonPropertyName("NeedsContract")]
public bool? AttrNeedsContract;

[JsonProperty("ApprovalStatusId")]
[JsonPropertyName("ApprovalStatusId")]
public int? AttrApprovalStatusId;

[JsonProperty("ApprovedBy")]
[JsonPropertyName("ApprovedBy")]
public string AttrApprovedBy;

[JsonProperty("ApprovedOn")]
[JsonPropertyName("ApprovedOn")]
public String AttrApprovedOn;

[JsonProperty("RequestToModifyBy")]
[JsonPropertyName("RequestToModifyBy")]
public string AttrRequestToModifyBy;

[JsonProperty("RequestToModifyOn")]
[JsonPropertyName("RequestToModifyOn")]
public String AttrRequestToModifyOn;

[JsonProperty("CanceledBy")]
[JsonPropertyName("CanceledBy")]
public string AttrCanceledBy;

[JsonProperty("CanceledOn_DEPREC")]
[JsonPropertyName("CanceledOn_DEPREC")]
public bool? AttrCanceledOn_DEPREC;

[JsonProperty("IsAccounting")]
[JsonPropertyName("IsAccounting")]
public bool? AttrIsAccounting;

[JsonProperty("IsStartAccounting")]
[JsonPropertyName("IsStartAccounting")]
public bool? AttrIsStartAccounting;

[JsonProperty("CanceledOn_")]
[JsonPropertyName("CanceledOn_")]
public String AttrCanceledOn_;

[JsonProperty("ApproveAsAreaUsuaria")]
[JsonPropertyName("ApproveAsAreaUsuaria")]
public bool? AttrApproveAsAreaUsuaria;

[JsonProperty("IsMandatory")]
[JsonPropertyName("IsMandatory")]
public bool? AttrIsMandatory;

[JsonProperty("IsReassigned")]
[JsonPropertyName("IsReassigned")]
public bool? AttrIsReassigned;

[JsonProperty("IsSubstituteFor")]
[JsonPropertyName("IsSubstituteFor")]
public string AttrIsSubstituteFor;

public JSONEN_27b1469f497d364a764a1359956ef9adEntityRecord() { }

public JSONEN_27b1469f497d364a764a1359956ef9adEntityRecord (EN_27b1469f497d364a764a1359956ef9adEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrRequisitionApprovalId = ConvertToRestWithoutDefaults(s.ssRequisitionApprovalId, 0L);
AttrLevelNumber = ConvertToRestWithoutDefaults(s.ssLevelNumber, 0);
AttrApplicationRoleId = ConvertToRestWithoutDefaults(s.ssApplicationRoleId, 0L);
AttrEntraJobTitle = ConvertToRestWithoutDefaults(s.ssEntraJobTitle, "");
AttrDepartmentId = ConvertToRestWithoutDefaults(s.ssDepartmentId, 0L);
AttrManagementId = ConvertToRestWithoutDefaults(s.ssManagementId, 0L);
AttrSubdirectionId = ConvertToRestWithoutDefaults(s.ssSubdirectionId, 0L);
AttrEntraRoleId = ConvertToRestWithoutDefaults(s.ssEntraRoleId, 0L);
AttrEntraUserName = ConvertToRestWithoutDefaults(s.ssEntraUserName, "");
AttrAssignedTo = ConvertToRestWithoutDefaults(s.ssAssignedTo, "");
AttrNeedsContract = ConvertToRestWithoutDefaults(s.ssNeedsContract, false);
AttrApprovalStatusId = ConvertToRestWithoutDefaults(s.ssApprovalStatusId, 0);
AttrApprovedBy = ConvertToRestWithoutDefaults(s.ssApprovedBy, "");
AttrApprovedOn = ConvertDateTimeToRestWithoutDefaults(s.ssApprovedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrRequestToModifyBy = ConvertToRestWithoutDefaults(s.ssRequestToModifyBy, "");
AttrRequestToModifyOn = ConvertDateTimeToRestWithoutDefaults(s.ssRequestToModifyOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrCanceledBy = ConvertToRestWithoutDefaults(s.ssCanceledBy, "");
AttrCanceledOn_DEPREC = ConvertToRestWithoutDefaults(s.ssCanceledOn_DEPREC, false);
AttrIsAccounting = ConvertToRestWithoutDefaults(s.ssIsAccounting, false);
AttrIsStartAccounting = ConvertToRestWithoutDefaults(s.ssIsStartAccounting, false);
AttrCanceledOn_ = ConvertDateTimeToRestWithoutDefaults(s.ssCanceledOn_, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrApproveAsAreaUsuaria = ConvertToRestWithoutDefaults(s.ssApproveAsAreaUsuaria, false);
AttrIsMandatory = ConvertToRestWithoutDefaults(s.ssIsMandatory, false);
AttrIsReassigned = ConvertToRestWithoutDefaults(s.ssIsReassigned, false);
AttrIsSubstituteFor = ConvertToRestWithoutDefaults(s.ssIsSubstituteFor, "");
  } else {
AttrId = (long?) s.ssId;
AttrRequisitionApprovalId = (long?) s.ssRequisitionApprovalId;
AttrLevelNumber = (int?) s.ssLevelNumber;
AttrApplicationRoleId = (long?) s.ssApplicationRoleId;
AttrEntraJobTitle = s.ssEntraJobTitle;
AttrDepartmentId = (long?) s.ssDepartmentId;
AttrManagementId = (long?) s.ssManagementId;
AttrSubdirectionId = (long?) s.ssSubdirectionId;
AttrEntraRoleId = (long?) s.ssEntraRoleId;
AttrEntraUserName = s.ssEntraUserName;
AttrAssignedTo = s.ssAssignedTo;
AttrNeedsContract = (bool?) s.ssNeedsContract;
AttrApprovalStatusId = (int?) s.ssApprovalStatusId;
AttrApprovedBy = s.ssApprovedBy;
AttrApprovedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssApprovedOn, config.DateTimeFormat);
AttrRequestToModifyBy = s.ssRequestToModifyBy;
AttrRequestToModifyOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssRequestToModifyOn, config.DateTimeFormat);
AttrCanceledBy = s.ssCanceledBy;
AttrCanceledOn_DEPREC = (bool?) s.ssCanceledOn_DEPREC;
AttrIsAccounting = (bool?) s.ssIsAccounting;
AttrIsStartAccounting = (bool?) s.ssIsStartAccounting;
AttrCanceledOn_ = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCanceledOn_, config.DateTimeFormat);
AttrApproveAsAreaUsuaria = (bool?) s.ssApproveAsAreaUsuaria;
AttrIsMandatory = (bool?) s.ssIsMandatory;
AttrIsReassigned = (bool?) s.ssIsReassigned;
AttrIsSubstituteFor = s.ssIsSubstituteFor;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONEN_27b1469f497d364a764a1359956ef9adEntityRecord, EN_27b1469f497d364a764a1359956ef9adEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_27b1469f497d364a764a1359956ef9adEntityRecord s) => ToStructure(s, config);
}
public static EN_27b1469f497d364a764a1359956ef9adEntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_27b1469f497d364a764a1359956ef9adEntityRecord obj, IBehaviorsConfiguration config) { 
  EN_27b1469f497d364a764a1359956ef9adEntityRecord s = new EN_27b1469f497d364a764a1359956ef9adEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssRequisitionApprovalId = obj.AttrRequisitionApprovalId == null ? 0L : obj.AttrRequisitionApprovalId.Value;
  s.ssLevelNumber = obj.AttrLevelNumber == null ? 0 : obj.AttrLevelNumber.Value;
  s.ssApplicationRoleId = obj.AttrApplicationRoleId == null ? 0L : obj.AttrApplicationRoleId.Value;
  s.ssEntraJobTitle = obj.AttrEntraJobTitle == null ? "" : obj.AttrEntraJobTitle;
  s.ssDepartmentId = obj.AttrDepartmentId == null ? 0L : obj.AttrDepartmentId.Value;
  s.ssManagementId = obj.AttrManagementId == null ? 0L : obj.AttrManagementId.Value;
  s.ssSubdirectionId = obj.AttrSubdirectionId == null ? 0L : obj.AttrSubdirectionId.Value;
  s.ssEntraRoleId = obj.AttrEntraRoleId == null ? 0L : obj.AttrEntraRoleId.Value;
  s.ssEntraUserName = obj.AttrEntraUserName == null ? "" : obj.AttrEntraUserName;
  s.ssAssignedTo = obj.AttrAssignedTo == null ? "" : obj.AttrAssignedTo;
  s.ssNeedsContract = obj.AttrNeedsContract == null ? false : obj.AttrNeedsContract.Value;
  s.ssApprovalStatusId = obj.AttrApprovalStatusId == null ? 0 : obj.AttrApprovalStatusId.Value;
  s.ssApprovedBy = obj.AttrApprovedBy == null ? "" : obj.AttrApprovedBy;
  s.ssApprovedOn = obj.AttrApprovedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrApprovedOn, config.DateTimeFormat);
  s.ssRequestToModifyBy = obj.AttrRequestToModifyBy == null ? "" : obj.AttrRequestToModifyBy;
  s.ssRequestToModifyOn = obj.AttrRequestToModifyOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrRequestToModifyOn, config.DateTimeFormat);
  s.ssCanceledBy = obj.AttrCanceledBy == null ? "" : obj.AttrCanceledBy;
  s.ssCanceledOn_DEPREC = obj.AttrCanceledOn_DEPREC == null ? false : obj.AttrCanceledOn_DEPREC.Value;
  s.ssIsAccounting = obj.AttrIsAccounting == null ? false : obj.AttrIsAccounting.Value;
  s.ssIsStartAccounting = obj.AttrIsStartAccounting == null ? false : obj.AttrIsStartAccounting.Value;
  s.ssCanceledOn_ = obj.AttrCanceledOn_ == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCanceledOn_, config.DateTimeFormat);
  s.ssApproveAsAreaUsuaria = obj.AttrApproveAsAreaUsuaria == null ? false : obj.AttrApproveAsAreaUsuaria.Value;
  s.ssIsMandatory = obj.AttrIsMandatory == null ? false : obj.AttrIsMandatory.Value;
  s.ssIsReassigned = obj.AttrIsReassigned == null ? false : obj.AttrIsReassigned.Value;
  s.ssIsSubstituteFor = obj.AttrIsSubstituteFor == null ? "" : obj.AttrIsSubstituteFor;
  }
  return s;
}

public static Func<EN_27b1469f497d364a764a1359956ef9adEntityRecord, ssConectaProveedores.RestRecords.JSONEN_27b1469f497d364a764a1359956ef9adEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_27b1469f497d364a764a1359956ef9adEntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_27b1469f497d364a764a1359956ef9adEntityRecord FromStructure(EN_27b1469f497d364a764a1359956ef9adEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_27b1469f497d364a764a1359956ef9adEntityRecord(s, config);
}

}


