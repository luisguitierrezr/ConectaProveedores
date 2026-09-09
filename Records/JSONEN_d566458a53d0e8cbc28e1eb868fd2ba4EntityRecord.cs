using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionStatusHistory
public class JSONEN_d566458a53d0e8cbc28e1eb868fd2ba4EntityRecord : AbstractRESTStructure<EN_d566458a53d0e8cbc28e1eb868fd2ba4EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("RequisitionId")]
[JsonPropertyName("RequisitionId")]
public long? AttrRequisitionId;

[JsonProperty("RequisitionStatusId")]
[JsonPropertyName("RequisitionStatusId")]
public int? AttrRequisitionStatusId;

[JsonProperty("TimeStamp")]
[JsonPropertyName("TimeStamp")]
public String AttrTimeStamp;

[JsonProperty("CreatedBy")]
[JsonPropertyName("CreatedBy")]
public string AttrCreatedBy;

public JSONEN_d566458a53d0e8cbc28e1eb868fd2ba4EntityRecord() { }

public JSONEN_d566458a53d0e8cbc28e1eb868fd2ba4EntityRecord (EN_d566458a53d0e8cbc28e1eb868fd2ba4EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrRequisitionId = ConvertToRestWithoutDefaults(s.ssRequisitionId, 0L);
AttrRequisitionStatusId = ConvertToRestWithoutDefaults(s.ssRequisitionStatusId, 0);
AttrTimeStamp = ConvertDateTimeToRestWithoutDefaults(s.ssTimeStamp, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrCreatedBy = ConvertToRestWithoutDefaults(s.ssCreatedBy, "");
  } else {
AttrId = (long?) s.ssId;
AttrRequisitionId = (long?) s.ssRequisitionId;
AttrRequisitionStatusId = (int?) s.ssRequisitionStatusId;
AttrTimeStamp = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssTimeStamp, config.DateTimeFormat);
AttrCreatedBy = s.ssCreatedBy;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONEN_d566458a53d0e8cbc28e1eb868fd2ba4EntityRecord, EN_d566458a53d0e8cbc28e1eb868fd2ba4EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_d566458a53d0e8cbc28e1eb868fd2ba4EntityRecord s) => ToStructure(s, config);
}
public static EN_d566458a53d0e8cbc28e1eb868fd2ba4EntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_d566458a53d0e8cbc28e1eb868fd2ba4EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_d566458a53d0e8cbc28e1eb868fd2ba4EntityRecord s = new EN_d566458a53d0e8cbc28e1eb868fd2ba4EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssRequisitionId = obj.AttrRequisitionId == null ? 0L : obj.AttrRequisitionId.Value;
  s.ssRequisitionStatusId = obj.AttrRequisitionStatusId == null ? 0 : obj.AttrRequisitionStatusId.Value;
  s.ssTimeStamp = obj.AttrTimeStamp == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrTimeStamp, config.DateTimeFormat);
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  }
  return s;
}

public static Func<EN_d566458a53d0e8cbc28e1eb868fd2ba4EntityRecord, ssConectaProveedores.RestRecords.JSONEN_d566458a53d0e8cbc28e1eb868fd2ba4EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_d566458a53d0e8cbc28e1eb868fd2ba4EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_d566458a53d0e8cbc28e1eb868fd2ba4EntityRecord FromStructure(EN_d566458a53d0e8cbc28e1eb868fd2ba4EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_d566458a53d0e8cbc28e1eb868fd2ba4EntityRecord(s, config);
}

}


