using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ProposalStatusHistory
public class JSONEN_f6d34ae04169ae9164103e8797ea11d4EntityRecord : AbstractRESTStructure<EN_f6d34ae04169ae9164103e8797ea11d4EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("ProposalId")]
[JsonPropertyName("ProposalId")]
public long? AttrProposalId;

[JsonProperty("ProposalStatusId")]
[JsonPropertyName("ProposalStatusId")]
public int? AttrProposalStatusId;

[JsonProperty("TimeStamp")]
[JsonPropertyName("TimeStamp")]
public String AttrTimeStamp;

[JsonProperty("CreatedBy")]
[JsonPropertyName("CreatedBy")]
public string AttrCreatedBy;

public JSONEN_f6d34ae04169ae9164103e8797ea11d4EntityRecord() { }

public JSONEN_f6d34ae04169ae9164103e8797ea11d4EntityRecord (EN_f6d34ae04169ae9164103e8797ea11d4EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrProposalId = ConvertToRestWithoutDefaults(s.ssProposalId, 0L);
AttrProposalStatusId = ConvertToRestWithoutDefaults(s.ssProposalStatusId, 0);
AttrTimeStamp = ConvertDateTimeToRestWithoutDefaults(s.ssTimeStamp, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrCreatedBy = ConvertToRestWithoutDefaults(s.ssCreatedBy, "");
  } else {
AttrId = (long?) s.ssId;
AttrProposalId = (long?) s.ssProposalId;
AttrProposalStatusId = (int?) s.ssProposalStatusId;
AttrTimeStamp = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssTimeStamp, config.DateTimeFormat);
AttrCreatedBy = s.ssCreatedBy;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONEN_f6d34ae04169ae9164103e8797ea11d4EntityRecord, EN_f6d34ae04169ae9164103e8797ea11d4EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_f6d34ae04169ae9164103e8797ea11d4EntityRecord s) => ToStructure(s, config);
}
public static EN_f6d34ae04169ae9164103e8797ea11d4EntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_f6d34ae04169ae9164103e8797ea11d4EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_f6d34ae04169ae9164103e8797ea11d4EntityRecord s = new EN_f6d34ae04169ae9164103e8797ea11d4EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssProposalId = obj.AttrProposalId == null ? 0L : obj.AttrProposalId.Value;
  s.ssProposalStatusId = obj.AttrProposalStatusId == null ? 0 : obj.AttrProposalStatusId.Value;
  s.ssTimeStamp = obj.AttrTimeStamp == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrTimeStamp, config.DateTimeFormat);
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  }
  return s;
}

public static Func<EN_f6d34ae04169ae9164103e8797ea11d4EntityRecord, ssConectaProveedores.RestRecords.JSONEN_f6d34ae04169ae9164103e8797ea11d4EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_f6d34ae04169ae9164103e8797ea11d4EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_f6d34ae04169ae9164103e8797ea11d4EntityRecord FromStructure(EN_f6d34ae04169ae9164103e8797ea11d4EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_f6d34ae04169ae9164103e8797ea11d4EntityRecord(s, config);
}

}


