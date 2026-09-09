using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderApprovalLevel
public class RESTEN_6b660d05e4c0025dff47119642875ca2EntityRecord : AbstractRESTStructure<EN_6b660d05e4c0025dff47119642875ca2EntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("OrderApprovalId")]
public long? AttrOrderApprovalId;

[JsonProperty("LevelNumber")]
public int? AttrLevelNumber;

[JsonProperty("EntraRoleId")]
public long? AttrEntraRoleId;

[JsonProperty("AssignedTo")]
public string AttrAssignedTo;

[JsonProperty("AssignedOn")]
public String AttrAssignedOn;

[JsonProperty("ApprovalStatusId")]
public int? AttrApprovalStatusId;

[JsonProperty("ApprovedBy")]
public string AttrApprovedBy;

[JsonProperty("ApprovedOn")]
public String AttrApprovedOn;

[JsonProperty("RejectedBy")]
public string AttrRejectedBy;

[JsonProperty("RejectedOn")]
public String AttrRejectedOn;

[JsonProperty("IsComplement")]
public bool? AttrIsComplement;

[JsonProperty("IsReassigned")]
public bool? AttrIsReassigned;

[JsonProperty("IsSubstituteFor")]
public string AttrIsSubstituteFor;

[JsonProperty("ToModifyBy")]
public string AttrToModifyBy;

[JsonProperty("ToModifyOn")]
public String AttrToModifyOn;

[JsonProperty("WasCanceledBy")]
public string AttrWasCanceledBy;

public RESTEN_6b660d05e4c0025dff47119642875ca2EntityRecord() { }

public RESTEN_6b660d05e4c0025dff47119642875ca2EntityRecord (EN_6b660d05e4c0025dff47119642875ca2EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrOrderApprovalId = ConvertToRestWithoutDefaults(s.ssOrderApprovalId, 0L);
AttrLevelNumber = ConvertToRestWithoutDefaults(s.ssLevelNumber, 0);
AttrEntraRoleId = ConvertToRestWithoutDefaults(s.ssEntraRoleId, 0L);
AttrAssignedTo = ConvertToRestWithoutDefaults(s.ssAssignedTo, "");
AttrAssignedOn = ConvertDateTimeToRestWithoutDefaults(s.ssAssignedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrApprovalStatusId = ConvertToRestWithoutDefaults(s.ssApprovalStatusId, 0);
AttrApprovedBy = ConvertToRestWithoutDefaults(s.ssApprovedBy, "");
AttrApprovedOn = ConvertDateTimeToRestWithoutDefaults(s.ssApprovedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrRejectedBy = ConvertToRestWithoutDefaults(s.ssRejectedBy, "");
AttrRejectedOn = ConvertDateTimeToRestWithoutDefaults(s.ssRejectedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrIsComplement = ConvertToRestWithoutDefaults(s.ssIsComplement, false);
AttrIsReassigned = ConvertToRestWithoutDefaults(s.ssIsReassigned, false);
AttrIsSubstituteFor = ConvertToRestWithoutDefaults(s.ssIsSubstituteFor, "");
AttrToModifyBy = ConvertToRestWithoutDefaults(s.ssToModifyBy, "");
AttrToModifyOn = ConvertDateTimeToRestWithoutDefaults(s.ssToModifyOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrWasCanceledBy = ConvertToRestWithoutDefaults(s.ssWasCanceledBy, "");
  } else {
AttrId = (long?) s.ssId;
AttrOrderApprovalId = (long?) s.ssOrderApprovalId;
AttrLevelNumber = (int?) s.ssLevelNumber;
AttrEntraRoleId = (long?) s.ssEntraRoleId;
AttrAssignedTo = s.ssAssignedTo;
AttrAssignedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssAssignedOn, config.DateTimeFormat);
AttrApprovalStatusId = (int?) s.ssApprovalStatusId;
AttrApprovedBy = s.ssApprovedBy;
AttrApprovedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssApprovedOn, config.DateTimeFormat);
AttrRejectedBy = s.ssRejectedBy;
AttrRejectedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssRejectedOn, config.DateTimeFormat);
AttrIsComplement = (bool?) s.ssIsComplement;
AttrIsReassigned = (bool?) s.ssIsReassigned;
AttrIsSubstituteFor = s.ssIsSubstituteFor;
AttrToModifyBy = s.ssToModifyBy;
AttrToModifyOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssToModifyOn, config.DateTimeFormat);
AttrWasCanceledBy = s.ssWasCanceledBy;
  }
}

public static EN_6b660d05e4c0025dff47119642875ca2EntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_6b660d05e4c0025dff47119642875ca2EntityRecord obj) { 
  EN_6b660d05e4c0025dff47119642875ca2EntityRecord s = new EN_6b660d05e4c0025dff47119642875ca2EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssOrderApprovalId = obj.AttrOrderApprovalId == null ? 0L : obj.AttrOrderApprovalId.Value;
  s.ssLevelNumber = obj.AttrLevelNumber == null ? 0 : obj.AttrLevelNumber.Value;
  s.ssEntraRoleId = obj.AttrEntraRoleId == null ? 0L : obj.AttrEntraRoleId.Value;
  s.ssAssignedTo = obj.AttrAssignedTo == null ? "" : obj.AttrAssignedTo;
  s.ssAssignedOn = obj.AttrAssignedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrAssignedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssApprovalStatusId = obj.AttrApprovalStatusId == null ? 0 : obj.AttrApprovalStatusId.Value;
  s.ssApprovedBy = obj.AttrApprovedBy == null ? "" : obj.AttrApprovedBy;
  s.ssApprovedOn = obj.AttrApprovedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrApprovedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssRejectedBy = obj.AttrRejectedBy == null ? "" : obj.AttrRejectedBy;
  s.ssRejectedOn = obj.AttrRejectedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrRejectedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssIsComplement = obj.AttrIsComplement == null ? false : obj.AttrIsComplement.Value;
  s.ssIsReassigned = obj.AttrIsReassigned == null ? false : obj.AttrIsReassigned.Value;
  s.ssIsSubstituteFor = obj.AttrIsSubstituteFor == null ? "" : obj.AttrIsSubstituteFor;
  s.ssToModifyBy = obj.AttrToModifyBy == null ? "" : obj.AttrToModifyBy;
  s.ssToModifyOn = obj.AttrToModifyOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrToModifyOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssWasCanceledBy = obj.AttrWasCanceledBy == null ? "" : obj.AttrWasCanceledBy;
  }
  return s;
}

public static Func<EN_6b660d05e4c0025dff47119642875ca2EntityRecord, ssConectaProveedores.RestRecords.RESTEN_6b660d05e4c0025dff47119642875ca2EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_6b660d05e4c0025dff47119642875ca2EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_6b660d05e4c0025dff47119642875ca2EntityRecord FromStructure(EN_6b660d05e4c0025dff47119642875ca2EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_6b660d05e4c0025dff47119642875ca2EntityRecord(s, config);
}

}


