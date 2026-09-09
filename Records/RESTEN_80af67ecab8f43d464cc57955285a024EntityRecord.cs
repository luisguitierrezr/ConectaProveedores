using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderRequestFileApprovalLevel
public class RESTEN_80af67ecab8f43d464cc57955285a024EntityRecord : AbstractRESTStructure<EN_80af67ecab8f43d464cc57955285a024EntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("OrderRequestFileApprovalId")]
public long? AttrOrderRequestFileApprovalId;

[JsonProperty("LevelNumber")]
public int? AttrLevelNumber;

[JsonProperty("EntraRoleId")]
public long? AttrEntraRoleId;

[JsonProperty("AssignedTo")]
public string AttrAssignedTo;

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

[JsonProperty("IsReassigned")]
public bool? AttrIsReassigned;

[JsonProperty("IsSubstituteFor")]
public string AttrIsSubstituteFor;

public RESTEN_80af67ecab8f43d464cc57955285a024EntityRecord() { }

public RESTEN_80af67ecab8f43d464cc57955285a024EntityRecord (EN_80af67ecab8f43d464cc57955285a024EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrOrderRequestFileApprovalId = ConvertToRestWithoutDefaults(s.ssOrderRequestFileApprovalId, 0L);
AttrLevelNumber = ConvertToRestWithoutDefaults(s.ssLevelNumber, 0);
AttrEntraRoleId = ConvertToRestWithoutDefaults(s.ssEntraRoleId, 0L);
AttrAssignedTo = ConvertToRestWithoutDefaults(s.ssAssignedTo, "");
AttrApprovalStatusId = ConvertToRestWithoutDefaults(s.ssApprovalStatusId, 0);
AttrApprovedBy = ConvertToRestWithoutDefaults(s.ssApprovedBy, "");
AttrApprovedOn = ConvertDateTimeToRestWithoutDefaults(s.ssApprovedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrRejectedBy = ConvertToRestWithoutDefaults(s.ssRejectedBy, "");
AttrRejectedOn = ConvertDateTimeToRestWithoutDefaults(s.ssRejectedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrIsReassigned = ConvertToRestWithoutDefaults(s.ssIsReassigned, false);
AttrIsSubstituteFor = ConvertToRestWithoutDefaults(s.ssIsSubstituteFor, "");
  } else {
AttrId = (long?) s.ssId;
AttrOrderRequestFileApprovalId = (long?) s.ssOrderRequestFileApprovalId;
AttrLevelNumber = (int?) s.ssLevelNumber;
AttrEntraRoleId = (long?) s.ssEntraRoleId;
AttrAssignedTo = s.ssAssignedTo;
AttrApprovalStatusId = (int?) s.ssApprovalStatusId;
AttrApprovedBy = s.ssApprovedBy;
AttrApprovedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssApprovedOn, config.DateTimeFormat);
AttrRejectedBy = s.ssRejectedBy;
AttrRejectedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssRejectedOn, config.DateTimeFormat);
AttrIsReassigned = (bool?) s.ssIsReassigned;
AttrIsSubstituteFor = s.ssIsSubstituteFor;
  }
}

public static EN_80af67ecab8f43d464cc57955285a024EntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_80af67ecab8f43d464cc57955285a024EntityRecord obj) { 
  EN_80af67ecab8f43d464cc57955285a024EntityRecord s = new EN_80af67ecab8f43d464cc57955285a024EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssOrderRequestFileApprovalId = obj.AttrOrderRequestFileApprovalId == null ? 0L : obj.AttrOrderRequestFileApprovalId.Value;
  s.ssLevelNumber = obj.AttrLevelNumber == null ? 0 : obj.AttrLevelNumber.Value;
  s.ssEntraRoleId = obj.AttrEntraRoleId == null ? 0L : obj.AttrEntraRoleId.Value;
  s.ssAssignedTo = obj.AttrAssignedTo == null ? "" : obj.AttrAssignedTo;
  s.ssApprovalStatusId = obj.AttrApprovalStatusId == null ? 0 : obj.AttrApprovalStatusId.Value;
  s.ssApprovedBy = obj.AttrApprovedBy == null ? "" : obj.AttrApprovedBy;
  s.ssApprovedOn = obj.AttrApprovedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrApprovedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssRejectedBy = obj.AttrRejectedBy == null ? "" : obj.AttrRejectedBy;
  s.ssRejectedOn = obj.AttrRejectedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrRejectedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssIsReassigned = obj.AttrIsReassigned == null ? false : obj.AttrIsReassigned.Value;
  s.ssIsSubstituteFor = obj.AttrIsSubstituteFor == null ? "" : obj.AttrIsSubstituteFor;
  }
  return s;
}

public static Func<EN_80af67ecab8f43d464cc57955285a024EntityRecord, ssConectaProveedores.RestRecords.RESTEN_80af67ecab8f43d464cc57955285a024EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_80af67ecab8f43d464cc57955285a024EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_80af67ecab8f43d464cc57955285a024EntityRecord FromStructure(EN_80af67ecab8f43d464cc57955285a024EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_80af67ecab8f43d464cc57955285a024EntityRecord(s, config);
}

}


