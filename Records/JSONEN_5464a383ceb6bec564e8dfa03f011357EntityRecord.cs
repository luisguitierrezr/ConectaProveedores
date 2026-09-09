using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ProposalApproval
public class JSONEN_5464a383ceb6bec564e8dfa03f011357EntityRecord : AbstractRESTStructure<EN_5464a383ceb6bec564e8dfa03f011357EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("ProposalId")]
[JsonPropertyName("ProposalId")]
public long? AttrProposalId;

[JsonProperty("ProcessTypeCode")]
[JsonPropertyName("ProcessTypeCode")]
public string AttrProcessTypeCode;

[JsonProperty("ApprovalProcessVersion")]
[JsonPropertyName("ApprovalProcessVersion")]
public string AttrApprovalProcessVersion;

[JsonProperty("CurrentLevel_DEPREC")]
[JsonPropertyName("CurrentLevel_DEPREC")]
public int? AttrCurrentLevel_DEPREC;

[JsonProperty("MaxLevel_DEPREC")]
[JsonPropertyName("MaxLevel_DEPREC")]
public int? AttrMaxLevel_DEPREC;

[JsonProperty("StartedOn")]
[JsonPropertyName("StartedOn")]
public String AttrStartedOn;

[JsonProperty("FinishedOn")]
[JsonPropertyName("FinishedOn")]
public String AttrFinishedOn;

public JSONEN_5464a383ceb6bec564e8dfa03f011357EntityRecord() { }

public JSONEN_5464a383ceb6bec564e8dfa03f011357EntityRecord (EN_5464a383ceb6bec564e8dfa03f011357EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrProposalId = ConvertToRestWithoutDefaults(s.ssProposalId, 0L);
AttrProcessTypeCode = ConvertToRestWithoutDefaults(s.ssProcessTypeCode, "");
AttrApprovalProcessVersion = ConvertToRestWithoutDefaults(s.ssApprovalProcessVersion, "");
AttrCurrentLevel_DEPREC = ConvertToRestWithoutDefaults(s.ssCurrentLevel_DEPREC, 0);
AttrMaxLevel_DEPREC = ConvertToRestWithoutDefaults(s.ssMaxLevel_DEPREC, 0);
AttrStartedOn = ConvertDateTimeToRestWithoutDefaults(s.ssStartedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrFinishedOn = ConvertDateTimeToRestWithoutDefaults(s.ssFinishedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
  } else {
AttrId = (long?) s.ssId;
AttrProposalId = (long?) s.ssProposalId;
AttrProcessTypeCode = s.ssProcessTypeCode;
AttrApprovalProcessVersion = s.ssApprovalProcessVersion;
AttrCurrentLevel_DEPREC = (int?) s.ssCurrentLevel_DEPREC;
AttrMaxLevel_DEPREC = (int?) s.ssMaxLevel_DEPREC;
AttrStartedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssStartedOn, config.DateTimeFormat);
AttrFinishedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssFinishedOn, config.DateTimeFormat);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONEN_5464a383ceb6bec564e8dfa03f011357EntityRecord, EN_5464a383ceb6bec564e8dfa03f011357EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_5464a383ceb6bec564e8dfa03f011357EntityRecord s) => ToStructure(s, config);
}
public static EN_5464a383ceb6bec564e8dfa03f011357EntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_5464a383ceb6bec564e8dfa03f011357EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_5464a383ceb6bec564e8dfa03f011357EntityRecord s = new EN_5464a383ceb6bec564e8dfa03f011357EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssProposalId = obj.AttrProposalId == null ? 0L : obj.AttrProposalId.Value;
  s.ssProcessTypeCode = obj.AttrProcessTypeCode == null ? "" : obj.AttrProcessTypeCode;
  s.ssApprovalProcessVersion = obj.AttrApprovalProcessVersion == null ? "" : obj.AttrApprovalProcessVersion;
  s.ssCurrentLevel_DEPREC = obj.AttrCurrentLevel_DEPREC == null ? 0 : obj.AttrCurrentLevel_DEPREC.Value;
  s.ssMaxLevel_DEPREC = obj.AttrMaxLevel_DEPREC == null ? 0 : obj.AttrMaxLevel_DEPREC.Value;
  s.ssStartedOn = obj.AttrStartedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrStartedOn, config.DateTimeFormat);
  s.ssFinishedOn = obj.AttrFinishedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrFinishedOn, config.DateTimeFormat);
  }
  return s;
}

public static Func<EN_5464a383ceb6bec564e8dfa03f011357EntityRecord, ssConectaProveedores.RestRecords.JSONEN_5464a383ceb6bec564e8dfa03f011357EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_5464a383ceb6bec564e8dfa03f011357EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_5464a383ceb6bec564e8dfa03f011357EntityRecord FromStructure(EN_5464a383ceb6bec564e8dfa03f011357EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_5464a383ceb6bec564e8dfa03f011357EntityRecord(s, config);
}

}


