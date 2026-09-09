using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// SegmentAccGroupTelcelDir
public class JSONEN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord : AbstractRESTStructure<EN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("SegmentAccGroupId")]
[JsonPropertyName("SegmentAccGroupId")]
public long? AttrSegmentAccGroupId;

[JsonProperty("TelcelDirectionId")]
[JsonPropertyName("TelcelDirectionId")]
public long? AttrTelcelDirectionId;

[JsonProperty("CreatedOn")]
[JsonPropertyName("CreatedOn")]
public String AttrCreatedOn;

[JsonProperty("CreatedBy")]
[JsonPropertyName("CreatedBy")]
public string AttrCreatedBy;

public JSONEN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord() { }

public JSONEN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord (EN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrSegmentAccGroupId = ConvertToRestWithoutDefaults(s.ssSegmentAccGroupId, 0L);
AttrTelcelDirectionId = ConvertToRestWithoutDefaults(s.ssTelcelDirectionId, 0L);
AttrCreatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssCreatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrCreatedBy = ConvertToRestWithoutDefaults(s.ssCreatedBy, "");
  } else {
AttrId = (long?) s.ssId;
AttrSegmentAccGroupId = (long?) s.ssSegmentAccGroupId;
AttrTelcelDirectionId = (long?) s.ssTelcelDirectionId;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
AttrCreatedBy = s.ssCreatedBy;
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord, EN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord s) => ToStructure(s, config);
}
public static EN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord s = new EN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssSegmentAccGroupId = obj.AttrSegmentAccGroupId == null ? 0L : obj.AttrSegmentAccGroupId.Value;
  s.ssTelcelDirectionId = obj.AttrTelcelDirectionId == null ? 0L : obj.AttrTelcelDirectionId.Value;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, config.DateTimeFormat);
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  }
  return s;
}

public static Func<EN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord, ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord FromStructure(EN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord(s, config);
}

}


