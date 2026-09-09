using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// Sustainability
public class JSONEN_9a75c3f9d1545f2094763e7c965e9d81EntityRecord : AbstractRESTStructure<EN_9a75c3f9d1545f2094763e7c965e9d81EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("Description")]
[JsonPropertyName("Description")]
public string AttrDescription;

[JsonProperty("CreatedOn")]
[JsonPropertyName("CreatedOn")]
public String AttrCreatedOn;

[JsonProperty("CreatedBy")]
[JsonPropertyName("CreatedBy")]
public string AttrCreatedBy;

[JsonProperty("UpdatedOn")]
[JsonPropertyName("UpdatedOn")]
public String AttrUpdatedOn;

[JsonProperty("UpdatedBy")]
[JsonPropertyName("UpdatedBy")]
public string AttrUpdatedBy;

[JsonProperty("IsActive")]
[JsonPropertyName("IsActive")]
public bool? AttrIsActive;

public JSONEN_9a75c3f9d1545f2094763e7c965e9d81EntityRecord() { }

public JSONEN_9a75c3f9d1545f2094763e7c965e9d81EntityRecord (EN_9a75c3f9d1545f2094763e7c965e9d81EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrDescription = ConvertToRestWithoutDefaults(s.ssDescription, "");
AttrCreatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssCreatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrCreatedBy = ConvertToRestWithoutDefaults(s.ssCreatedBy, "");
AttrUpdatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssUpdatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrUpdatedBy = ConvertToRestWithoutDefaults(s.ssUpdatedBy, "");
AttrIsActive = ConvertToRestWithoutDefaults(s.ssIsActive, true);
  } else {
AttrId = (long?) s.ssId;
AttrDescription = s.ssDescription;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
AttrCreatedBy = s.ssCreatedBy;
AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssUpdatedOn, config.DateTimeFormat);
AttrUpdatedBy = s.ssUpdatedBy;
AttrIsActive = (bool?) s.ssIsActive;
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_9a75c3f9d1545f2094763e7c965e9d81EntityRecord, EN_9a75c3f9d1545f2094763e7c965e9d81EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_9a75c3f9d1545f2094763e7c965e9d81EntityRecord s) => ToStructure(s, config);
}
public static EN_9a75c3f9d1545f2094763e7c965e9d81EntityRecord ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_9a75c3f9d1545f2094763e7c965e9d81EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_9a75c3f9d1545f2094763e7c965e9d81EntityRecord s = new EN_9a75c3f9d1545f2094763e7c965e9d81EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssDescription = obj.AttrDescription == null ? "" : obj.AttrDescription;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, config.DateTimeFormat);
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssUpdatedOn = obj.AttrUpdatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrUpdatedOn, config.DateTimeFormat);
  s.ssUpdatedBy = obj.AttrUpdatedBy == null ? "" : obj.AttrUpdatedBy;
  s.ssIsActive = obj.AttrIsActive == null ? true : obj.AttrIsActive.Value;
  }
  return s;
}

public static Func<EN_9a75c3f9d1545f2094763e7c965e9d81EntityRecord, ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_9a75c3f9d1545f2094763e7c965e9d81EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_9a75c3f9d1545f2094763e7c965e9d81EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_9a75c3f9d1545f2094763e7c965e9d81EntityRecord FromStructure(EN_9a75c3f9d1545f2094763e7c965e9d81EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_9a75c3f9d1545f2094763e7c965e9d81EntityRecord(s, config);
}

}


