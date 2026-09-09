using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceApprovalLevel
public class RESTEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord : AbstractRESTStructure<EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("InvoiceApprovalId")]
public long? AttrInvoiceApprovalId;

[JsonProperty("LevelNumber")]
public int? AttrLevelNumber;

[JsonProperty("AssignedTo")]
public string AttrAssignedTo;

[JsonProperty("ApplicationRoleId")]
public long? AttrApplicationRoleId;

[JsonProperty("EntraJobTitle")]
public string AttrEntraJobTitle;

[JsonProperty("DepartmentId")]
public long? AttrDepartmentId;

[JsonProperty("ManagementId")]
public long? AttrManagementId;

[JsonProperty("SubdirectionId")]
public long? AttrSubdirectionId;

[JsonProperty("EntraRoleId")]
public long? AttrEntraRoleId;

[JsonProperty("ApprovalStatusId")]
public int? AttrApprovalStatusId;

[JsonProperty("CanBeFirstApprover")]
public bool? AttrCanBeFirstApprover;

[JsonProperty("SelectsNextApprover")]
public bool? AttrSelectsNextApprover;

[JsonProperty("SelectsFirstApprover")]
public bool? AttrSelectsFirstApprover;

[JsonProperty("IsAccounting")]
public bool? AttrIsAccounting;

[JsonProperty("IsStartAccounting")]
public bool? AttrIsStartAccounting;

[JsonProperty("ApprovedBy")]
public string AttrApprovedBy;

[JsonProperty("ApprovedOn")]
public String AttrApprovedOn;

[JsonProperty("RequestToModifyBy")]
public string AttrRequestToModifyBy;

[JsonProperty("RequestToModifyOn")]
public String AttrRequestToModifyOn;

[JsonProperty("CanceledBy")]
public string AttrCanceledBy;

[JsonProperty("CanceledOn")]
public String AttrCanceledOn;

[JsonProperty("NeedsContract_DEPREC")]
public bool? AttrNeedsContract_DEPREC;

[JsonProperty("IsReassigned")]
public bool? AttrIsReassigned;

[JsonProperty("IsSubstituteFor")]
public string AttrIsSubstituteFor;

public RESTEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord() { }

public RESTEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord (EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrInvoiceApprovalId = ConvertToRestWithoutDefaults(s.ssInvoiceApprovalId, 0L);
AttrLevelNumber = ConvertToRestWithoutDefaults(s.ssLevelNumber, 0);
AttrAssignedTo = ConvertToRestWithoutDefaults(s.ssAssignedTo, "");
AttrApplicationRoleId = ConvertToRestWithoutDefaults(s.ssApplicationRoleId, 0L);
AttrEntraJobTitle = ConvertToRestWithoutDefaults(s.ssEntraJobTitle, "");
AttrDepartmentId = ConvertToRestWithoutDefaults(s.ssDepartmentId, 0L);
AttrManagementId = ConvertToRestWithoutDefaults(s.ssManagementId, 0L);
AttrSubdirectionId = ConvertToRestWithoutDefaults(s.ssSubdirectionId, 0L);
AttrEntraRoleId = ConvertToRestWithoutDefaults(s.ssEntraRoleId, 0L);
AttrApprovalStatusId = ConvertToRestWithoutDefaults(s.ssApprovalStatusId, 0);
AttrCanBeFirstApprover = ConvertToRestWithoutDefaults(s.ssCanBeFirstApprover, false);
AttrSelectsNextApprover = ConvertToRestWithoutDefaults(s.ssSelectsNextApprover, false);
AttrSelectsFirstApprover = ConvertToRestWithoutDefaults(s.ssSelectsFirstApprover, false);
AttrIsAccounting = ConvertToRestWithoutDefaults(s.ssIsAccounting, false);
AttrIsStartAccounting = ConvertToRestWithoutDefaults(s.ssIsStartAccounting, false);
AttrApprovedBy = ConvertToRestWithoutDefaults(s.ssApprovedBy, "");
AttrApprovedOn = ConvertDateTimeToRestWithoutDefaults(s.ssApprovedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrRequestToModifyBy = ConvertToRestWithoutDefaults(s.ssRequestToModifyBy, "");
AttrRequestToModifyOn = ConvertDateTimeToRestWithoutDefaults(s.ssRequestToModifyOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrCanceledBy = ConvertToRestWithoutDefaults(s.ssCanceledBy, "");
AttrCanceledOn = ConvertDateTimeToRestWithoutDefaults(s.ssCanceledOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrNeedsContract_DEPREC = ConvertToRestWithoutDefaults(s.ssNeedsContract_DEPREC, false);
AttrIsReassigned = ConvertToRestWithoutDefaults(s.ssIsReassigned, false);
AttrIsSubstituteFor = ConvertToRestWithoutDefaults(s.ssIsSubstituteFor, "");
  } else {
AttrId = (long?) s.ssId;
AttrInvoiceApprovalId = (long?) s.ssInvoiceApprovalId;
AttrLevelNumber = (int?) s.ssLevelNumber;
AttrAssignedTo = s.ssAssignedTo;
AttrApplicationRoleId = (long?) s.ssApplicationRoleId;
AttrEntraJobTitle = s.ssEntraJobTitle;
AttrDepartmentId = (long?) s.ssDepartmentId;
AttrManagementId = (long?) s.ssManagementId;
AttrSubdirectionId = (long?) s.ssSubdirectionId;
AttrEntraRoleId = (long?) s.ssEntraRoleId;
AttrApprovalStatusId = (int?) s.ssApprovalStatusId;
AttrCanBeFirstApprover = (bool?) s.ssCanBeFirstApprover;
AttrSelectsNextApprover = (bool?) s.ssSelectsNextApprover;
AttrSelectsFirstApprover = (bool?) s.ssSelectsFirstApprover;
AttrIsAccounting = (bool?) s.ssIsAccounting;
AttrIsStartAccounting = (bool?) s.ssIsStartAccounting;
AttrApprovedBy = s.ssApprovedBy;
AttrApprovedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssApprovedOn, config.DateTimeFormat);
AttrRequestToModifyBy = s.ssRequestToModifyBy;
AttrRequestToModifyOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssRequestToModifyOn, config.DateTimeFormat);
AttrCanceledBy = s.ssCanceledBy;
AttrCanceledOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCanceledOn, config.DateTimeFormat);
AttrNeedsContract_DEPREC = (bool?) s.ssNeedsContract_DEPREC;
AttrIsReassigned = (bool?) s.ssIsReassigned;
AttrIsSubstituteFor = s.ssIsSubstituteFor;
  }
}

public static EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord obj) { 
  EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord s = new EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssInvoiceApprovalId = obj.AttrInvoiceApprovalId == null ? 0L : obj.AttrInvoiceApprovalId.Value;
  s.ssLevelNumber = obj.AttrLevelNumber == null ? 0 : obj.AttrLevelNumber.Value;
  s.ssAssignedTo = obj.AttrAssignedTo == null ? "" : obj.AttrAssignedTo;
  s.ssApplicationRoleId = obj.AttrApplicationRoleId == null ? 0L : obj.AttrApplicationRoleId.Value;
  s.ssEntraJobTitle = obj.AttrEntraJobTitle == null ? "" : obj.AttrEntraJobTitle;
  s.ssDepartmentId = obj.AttrDepartmentId == null ? 0L : obj.AttrDepartmentId.Value;
  s.ssManagementId = obj.AttrManagementId == null ? 0L : obj.AttrManagementId.Value;
  s.ssSubdirectionId = obj.AttrSubdirectionId == null ? 0L : obj.AttrSubdirectionId.Value;
  s.ssEntraRoleId = obj.AttrEntraRoleId == null ? 0L : obj.AttrEntraRoleId.Value;
  s.ssApprovalStatusId = obj.AttrApprovalStatusId == null ? 0 : obj.AttrApprovalStatusId.Value;
  s.ssCanBeFirstApprover = obj.AttrCanBeFirstApprover == null ? false : obj.AttrCanBeFirstApprover.Value;
  s.ssSelectsNextApprover = obj.AttrSelectsNextApprover == null ? false : obj.AttrSelectsNextApprover.Value;
  s.ssSelectsFirstApprover = obj.AttrSelectsFirstApprover == null ? false : obj.AttrSelectsFirstApprover.Value;
  s.ssIsAccounting = obj.AttrIsAccounting == null ? false : obj.AttrIsAccounting.Value;
  s.ssIsStartAccounting = obj.AttrIsStartAccounting == null ? false : obj.AttrIsStartAccounting.Value;
  s.ssApprovedBy = obj.AttrApprovedBy == null ? "" : obj.AttrApprovedBy;
  s.ssApprovedOn = obj.AttrApprovedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrApprovedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssRequestToModifyBy = obj.AttrRequestToModifyBy == null ? "" : obj.AttrRequestToModifyBy;
  s.ssRequestToModifyOn = obj.AttrRequestToModifyOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrRequestToModifyOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssCanceledBy = obj.AttrCanceledBy == null ? "" : obj.AttrCanceledBy;
  s.ssCanceledOn = obj.AttrCanceledOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCanceledOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssNeedsContract_DEPREC = obj.AttrNeedsContract_DEPREC == null ? false : obj.AttrNeedsContract_DEPREC.Value;
  s.ssIsReassigned = obj.AttrIsReassigned == null ? false : obj.AttrIsReassigned.Value;
  s.ssIsSubstituteFor = obj.AttrIsSubstituteFor == null ? "" : obj.AttrIsSubstituteFor;
  }
  return s;
}

public static Func<EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord, ssConectaProveedores.RestRecords.RESTEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord FromStructure(EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord(s, config);
}

}


