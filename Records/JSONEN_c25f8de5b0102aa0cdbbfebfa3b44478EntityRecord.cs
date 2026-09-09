using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioApproval
public class JSONEN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord : AbstractRESTStructure<EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("FolioId")]
[JsonPropertyName("FolioId")]
public long? AttrFolioId;

[JsonProperty("ApprovalProcessId")]
[JsonPropertyName("ApprovalProcessId")]
public long? AttrApprovalProcessId;

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

[JsonProperty("RegionId")]
[JsonPropertyName("RegionId")]
public long? AttrRegionId;

public JSONEN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord() { }

public JSONEN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord (EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrFolioId = ConvertToRestWithoutDefaults(s.ssFolioId, 0L);
AttrApprovalProcessId = ConvertToRestWithoutDefaults(s.ssApprovalProcessId, 0L);
AttrProcessTypeCode = ConvertToRestWithoutDefaults(s.ssProcessTypeCode, "");
AttrApprovalProcessVersion = ConvertToRestWithoutDefaults(s.ssApprovalProcessVersion, "");
AttrCurrentLevel = ConvertToRestWithoutDefaults(s.ssCurrentLevel, 0);
AttrMaxLevel = ConvertToRestWithoutDefaults(s.ssMaxLevel, 0);
AttrStartedOn = ConvertDateTimeToRestWithoutDefaults(s.ssStartedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrFinishedOn = ConvertDateTimeToRestWithoutDefaults(s.ssFinishedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrRegionId = ConvertToRestWithoutDefaults(s.ssRegionId, 0L);
  } else {
AttrId = (long?) s.ssId;
AttrFolioId = (long?) s.ssFolioId;
AttrApprovalProcessId = (long?) s.ssApprovalProcessId;
AttrProcessTypeCode = s.ssProcessTypeCode;
AttrApprovalProcessVersion = s.ssApprovalProcessVersion;
AttrCurrentLevel = (int?) s.ssCurrentLevel;
AttrMaxLevel = (int?) s.ssMaxLevel;
AttrStartedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssStartedOn, config.DateTimeFormat);
AttrFinishedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssFinishedOn, config.DateTimeFormat);
AttrRegionId = (long?) s.ssRegionId;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONEN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord, EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord s) => ToStructure(s, config);
}
public static EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord s = new EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssFolioId = obj.AttrFolioId == null ? 0L : obj.AttrFolioId.Value;
  s.ssApprovalProcessId = obj.AttrApprovalProcessId == null ? 0L : obj.AttrApprovalProcessId.Value;
  s.ssProcessTypeCode = obj.AttrProcessTypeCode == null ? "" : obj.AttrProcessTypeCode;
  s.ssApprovalProcessVersion = obj.AttrApprovalProcessVersion == null ? "" : obj.AttrApprovalProcessVersion;
  s.ssCurrentLevel = obj.AttrCurrentLevel == null ? 0 : obj.AttrCurrentLevel.Value;
  s.ssMaxLevel = obj.AttrMaxLevel == null ? 0 : obj.AttrMaxLevel.Value;
  s.ssStartedOn = obj.AttrStartedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrStartedOn, config.DateTimeFormat);
  s.ssFinishedOn = obj.AttrFinishedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrFinishedOn, config.DateTimeFormat);
  s.ssRegionId = obj.AttrRegionId == null ? 0L : obj.AttrRegionId.Value;
  }
  return s;
}

public static Func<EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord, ssConectaProveedores.RestRecords.JSONEN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord FromStructure(EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord(s, config);
}

}


