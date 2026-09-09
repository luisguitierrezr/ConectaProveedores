using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ProposalLogs
public class JSONEN_013f76cfa3062515b73935963b1697b0EntityRecord : AbstractRESTStructure<EN_013f76cfa3062515b73935963b1697b0EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("ProposalId")]
[JsonPropertyName("ProposalId")]
public long? AttrProposalId;

[JsonProperty("ProposalLineId")]
[JsonPropertyName("ProposalLineId")]
public long? AttrProposalLineId;

[JsonProperty("CreatedBy")]
[JsonPropertyName("CreatedBy")]
public string AttrCreatedBy;

[JsonProperty("CreatedOn")]
[JsonPropertyName("CreatedOn")]
public String AttrCreatedOn;

[JsonProperty("Message")]
[JsonPropertyName("Message")]
public string AttrMessage;

[JsonProperty("IsError")]
[JsonPropertyName("IsError")]
public bool? AttrIsError;

public JSONEN_013f76cfa3062515b73935963b1697b0EntityRecord() { }

public JSONEN_013f76cfa3062515b73935963b1697b0EntityRecord (EN_013f76cfa3062515b73935963b1697b0EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrProposalId = (long?) s.ssProposalId;
AttrProposalLineId = ConvertToRestWithoutDefaults(s.ssProposalLineId, 0L);
AttrCreatedBy = ConvertToRestWithoutDefaults(s.ssCreatedBy, "");
AttrCreatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssCreatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrMessage = ConvertToRestWithoutDefaults(s.ssMessage, "");
AttrIsError = ConvertToRestWithoutDefaults(s.ssIsError, false);
  } else {
AttrId = (long?) s.ssId;
AttrProposalId = (long?) s.ssProposalId;
AttrProposalLineId = (long?) s.ssProposalLineId;
AttrCreatedBy = s.ssCreatedBy;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
AttrMessage = s.ssMessage;
AttrIsError = (bool?) s.ssIsError;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONEN_013f76cfa3062515b73935963b1697b0EntityRecord, EN_013f76cfa3062515b73935963b1697b0EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_013f76cfa3062515b73935963b1697b0EntityRecord s) => ToStructure(s, config);
}
public static EN_013f76cfa3062515b73935963b1697b0EntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_013f76cfa3062515b73935963b1697b0EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_013f76cfa3062515b73935963b1697b0EntityRecord s = new EN_013f76cfa3062515b73935963b1697b0EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssProposalId = obj.AttrProposalId == null ? 0L : obj.AttrProposalId.Value;
  s.ssProposalLineId = obj.AttrProposalLineId == null ? 0L : obj.AttrProposalLineId.Value;
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, config.DateTimeFormat);
  s.ssMessage = obj.AttrMessage == null ? "" : obj.AttrMessage;
  s.ssIsError = obj.AttrIsError == null ? false : obj.AttrIsError.Value;
  }
  return s;
}

public static Func<EN_013f76cfa3062515b73935963b1697b0EntityRecord, ssConectaProveedores.RestRecords.JSONEN_013f76cfa3062515b73935963b1697b0EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_013f76cfa3062515b73935963b1697b0EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_013f76cfa3062515b73935963b1697b0EntityRecord FromStructure(EN_013f76cfa3062515b73935963b1697b0EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_013f76cfa3062515b73935963b1697b0EntityRecord(s, config);
}

}


