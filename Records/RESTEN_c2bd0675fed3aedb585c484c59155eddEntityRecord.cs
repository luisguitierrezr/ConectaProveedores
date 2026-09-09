using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceApproval
public class RESTEN_c2bd0675fed3aedb585c484c59155eddEntityRecord : AbstractRESTStructure<EN_c2bd0675fed3aedb585c484c59155eddEntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("InvoiceId")]
public long? AttrInvoiceId;

[JsonProperty("AprovalProcessId")]
public long? AttrAprovalProcessId;

[JsonProperty("ProcessTypeCode")]
public string AttrProcessTypeCode;

[JsonProperty("ApprovalProcessVersion")]
public string AttrApprovalProcessVersion;

[JsonProperty("CurrentLevel")]
public int? AttrCurrentLevel;

[JsonProperty("MaxLevel")]
public int? AttrMaxLevel;

[JsonProperty("StartedOn")]
public String AttrStartedOn;

[JsonProperty("FinishedOn")]
public String AttrFinishedOn;

[JsonProperty("HasStartedAccounting")]
public bool? AttrHasStartedAccounting;

public RESTEN_c2bd0675fed3aedb585c484c59155eddEntityRecord() { }

public RESTEN_c2bd0675fed3aedb585c484c59155eddEntityRecord (EN_c2bd0675fed3aedb585c484c59155eddEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrInvoiceId = ConvertToRestWithoutDefaults(s.ssInvoiceId, 0L);
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
AttrInvoiceId = (long?) s.ssInvoiceId;
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

public static EN_c2bd0675fed3aedb585c484c59155eddEntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_c2bd0675fed3aedb585c484c59155eddEntityRecord obj) { 
  EN_c2bd0675fed3aedb585c484c59155eddEntityRecord s = new EN_c2bd0675fed3aedb585c484c59155eddEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssInvoiceId = obj.AttrInvoiceId == null ? 0L : obj.AttrInvoiceId.Value;
  s.ssAprovalProcessId = obj.AttrAprovalProcessId == null ? 0L : obj.AttrAprovalProcessId.Value;
  s.ssProcessTypeCode = obj.AttrProcessTypeCode == null ? "" : obj.AttrProcessTypeCode;
  s.ssApprovalProcessVersion = obj.AttrApprovalProcessVersion == null ? "" : obj.AttrApprovalProcessVersion;
  s.ssCurrentLevel = obj.AttrCurrentLevel == null ? 0 : obj.AttrCurrentLevel.Value;
  s.ssMaxLevel = obj.AttrMaxLevel == null ? 0 : obj.AttrMaxLevel.Value;
  s.ssStartedOn = obj.AttrStartedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrStartedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssFinishedOn = obj.AttrFinishedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrFinishedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssHasStartedAccounting = obj.AttrHasStartedAccounting == null ? false : obj.AttrHasStartedAccounting.Value;
  }
  return s;
}

public static Func<EN_c2bd0675fed3aedb585c484c59155eddEntityRecord, ssConectaProveedores.RestRecords.RESTEN_c2bd0675fed3aedb585c484c59155eddEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_c2bd0675fed3aedb585c484c59155eddEntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_c2bd0675fed3aedb585c484c59155eddEntityRecord FromStructure(EN_c2bd0675fed3aedb585c484c59155eddEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_c2bd0675fed3aedb585c484c59155eddEntityRecord(s, config);
}

}


