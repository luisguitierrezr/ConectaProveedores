using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// SegmentAccGroupTelcelDir
public class RESTEN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord : AbstractRESTStructure<EN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("SegmentAccGroupId")]
public long? AttrSegmentAccGroupId;

[JsonProperty("TelcelDirectionId")]
public long? AttrTelcelDirectionId;

[JsonProperty("CreatedOn")]
public String AttrCreatedOn;

[JsonProperty("CreatedBy")]
public string AttrCreatedBy;

public RESTEN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord() { }

public RESTEN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord (EN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord s, IBehaviorsConfiguration config) {
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

public static EN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord obj) { 
  EN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord s = new EN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssSegmentAccGroupId = obj.AttrSegmentAccGroupId == null ? 0L : obj.AttrSegmentAccGroupId.Value;
  s.ssTelcelDirectionId = obj.AttrTelcelDirectionId == null ? 0L : obj.AttrTelcelDirectionId.Value;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  }
  return s;
}

public static Func<EN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord, ssConectaProveedores.RestRecords.RESTEN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord FromStructure(EN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord(s, config);
}

}


