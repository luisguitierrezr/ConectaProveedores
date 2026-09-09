using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// PaymentOptions
public class JSONEN_7a1403ba58c6cea2d2bf07fe0448aa32EntityRecord : AbstractRESTStructure<EN_7a1403ba58c6cea2d2bf07fe0448aa32EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("Code")]
[JsonPropertyName("Code")]
public string AttrCode;

[JsonProperty("Description")]
[JsonPropertyName("Description")]
public string AttrDescription;

[JsonProperty("IsActive")]
[JsonPropertyName("IsActive")]
public bool? AttrIsActive;

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

public JSONEN_7a1403ba58c6cea2d2bf07fe0448aa32EntityRecord() { }

public JSONEN_7a1403ba58c6cea2d2bf07fe0448aa32EntityRecord (EN_7a1403ba58c6cea2d2bf07fe0448aa32EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrCode = ConvertToRestWithoutDefaults(s.ssCode, "");
AttrDescription = ConvertToRestWithoutDefaults(s.ssDescription, "");
AttrIsActive = ConvertToRestWithoutDefaults(s.ssIsActive, true);
AttrCreatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssCreatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrCreatedBy = ConvertToRestWithoutDefaults(s.ssCreatedBy, "");
AttrUpdatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssUpdatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrUpdatedBy = ConvertToRestWithoutDefaults(s.ssUpdatedBy, "");
  } else {
AttrId = (long?) s.ssId;
AttrCode = s.ssCode;
AttrDescription = s.ssDescription;
AttrIsActive = (bool?) s.ssIsActive;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
AttrCreatedBy = s.ssCreatedBy;
AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssUpdatedOn, config.DateTimeFormat);
AttrUpdatedBy = s.ssUpdatedBy;
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_7a1403ba58c6cea2d2bf07fe0448aa32EntityRecord, EN_7a1403ba58c6cea2d2bf07fe0448aa32EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_7a1403ba58c6cea2d2bf07fe0448aa32EntityRecord s) => ToStructure(s, config);
}
public static EN_7a1403ba58c6cea2d2bf07fe0448aa32EntityRecord ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_7a1403ba58c6cea2d2bf07fe0448aa32EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_7a1403ba58c6cea2d2bf07fe0448aa32EntityRecord s = new EN_7a1403ba58c6cea2d2bf07fe0448aa32EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssCode = obj.AttrCode == null ? "" : obj.AttrCode;
  s.ssDescription = obj.AttrDescription == null ? "" : obj.AttrDescription;
  s.ssIsActive = obj.AttrIsActive == null ? true : obj.AttrIsActive.Value;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, config.DateTimeFormat);
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssUpdatedOn = obj.AttrUpdatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrUpdatedOn, config.DateTimeFormat);
  s.ssUpdatedBy = obj.AttrUpdatedBy == null ? "" : obj.AttrUpdatedBy;
  }
  return s;
}

public static Func<EN_7a1403ba58c6cea2d2bf07fe0448aa32EntityRecord, ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_7a1403ba58c6cea2d2bf07fe0448aa32EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_7a1403ba58c6cea2d2bf07fe0448aa32EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_7a1403ba58c6cea2d2bf07fe0448aa32EntityRecord FromStructure(EN_7a1403ba58c6cea2d2bf07fe0448aa32EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_7a1403ba58c6cea2d2bf07fe0448aa32EntityRecord(s, config);
}

}


