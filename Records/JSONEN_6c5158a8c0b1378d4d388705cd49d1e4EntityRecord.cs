using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionApproval
public class JSONEN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord : AbstractRESTStructure<EN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("RequisitionId")]
[JsonPropertyName("RequisitionId")]
public long? AttrRequisitionId;

[JsonProperty("AprovalProcessId")]
[JsonPropertyName("AprovalProcessId")]
public long? AttrAprovalProcessId;

[JsonProperty("ProcessTypeCode")]
[JsonPropertyName("ProcessTypeCode")]
public string AttrProcessTypeCode;

[JsonProperty("ApprovalProcessVersion")]
[JsonPropertyName("ApprovalProcessVersion")]
public string AttrApprovalProcessVersion;

[JsonProperty("CurrentLevel")]
[JsonPropertyName("CurrentLevel")]
public int? AttrCurrentLevel;

[JsonProperty("MaxLevel")]
[JsonPropertyName("MaxLevel")]
public int? AttrMaxLevel;

[JsonProperty("StartedOn")]
[JsonPropertyName("StartedOn")]
public String AttrStartedOn;

[JsonProperty("FinishedOn")]
[JsonPropertyName("FinishedOn")]
public String AttrFinishedOn;

[JsonProperty("HasStartedAccounting")]
[JsonPropertyName("HasStartedAccounting")]
public bool? AttrHasStartedAccounting;

public JSONEN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord() { }

public JSONEN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord (EN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrRequisitionId = ConvertToRestWithoutDefaults(s.ssRequisitionId, 0L);
AttrAprovalProcessId = ConvertToRestWithoutDefaults(s.ssAprovalProcessId, 0L);
AttrProcessTypeCode = ConvertToRestWithoutDefaults(s.ssProcessTypeCode, "");
AttrApprovalProcessVersion = ConvertToRestWithoutDefaults(s.ssApprovalProcessVersion, "");
AttrCurrentLevel = ConvertToRestWithoutDefaults(s.ssCurrentLevel, 0);
AttrMaxLevel = ConvertToRestWithoutDefaults(s.ssMaxLevel, 0);
AttrStartedOn = ConvertDateTimeToRestWithoutDefaults(s.ssStartedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrFinishedOn = ConvertDateTimeToRestWithoutDefaults(s.ssFinishedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrHasStartedAccounting = ConvertToRestWithoutDefaults(s.ssHasStartedAccounting, false);
  } else {
AttrId = (long?) s.ssId;
AttrRequisitionId = (long?) s.ssRequisitionId;
AttrAprovalProcessId = (long?) s.ssAprovalProcessId;
AttrProcessTypeCode = s.ssProcessTypeCode;
AttrApprovalProcessVersion = s.ssApprovalProcessVersion;
AttrCurrentLevel = (int?) s.ssCurrentLevel;
AttrMaxLevel = (int?) s.ssMaxLevel;
AttrStartedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssStartedOn, config.DateTimeFormat);
AttrFinishedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssFinishedOn, config.DateTimeFormat);
AttrHasStartedAccounting = (bool?) s.ssHasStartedAccounting;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONEN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord, EN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord s) => ToStructure(s, config);
}
public static EN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord s = new EN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssRequisitionId = obj.AttrRequisitionId == null ? 0L : obj.AttrRequisitionId.Value;
  s.ssAprovalProcessId = obj.AttrAprovalProcessId == null ? 0L : obj.AttrAprovalProcessId.Value;
  s.ssProcessTypeCode = obj.AttrProcessTypeCode == null ? "" : obj.AttrProcessTypeCode;
  s.ssApprovalProcessVersion = obj.AttrApprovalProcessVersion == null ? "" : obj.AttrApprovalProcessVersion;
  s.ssCurrentLevel = obj.AttrCurrentLevel == null ? 0 : obj.AttrCurrentLevel.Value;
  s.ssMaxLevel = obj.AttrMaxLevel == null ? 0 : obj.AttrMaxLevel.Value;
  s.ssStartedOn = obj.AttrStartedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrStartedOn, config.DateTimeFormat);
  s.ssFinishedOn = obj.AttrFinishedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrFinishedOn, config.DateTimeFormat);
  s.ssHasStartedAccounting = obj.AttrHasStartedAccounting == null ? false : obj.AttrHasStartedAccounting.Value;
  }
  return s;
}

public static Func<EN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord, ssConectaProveedores.RestRecords.JSONEN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord FromStructure(EN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord(s, config);
}

}


