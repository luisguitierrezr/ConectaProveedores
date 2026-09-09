using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// TaxIndicator
public class JSONEN_efc751d189a1545503ba31ced5225e86EntityRecord : AbstractRESTStructure<EN_efc751d189a1545503ba31ced5225e86EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("Description")]
[JsonPropertyName("Description")]
public string AttrDescription;

[JsonProperty("ExternalId")]
[JsonPropertyName("ExternalId")]
public string AttrExternalId;

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

public JSONEN_efc751d189a1545503ba31ced5225e86EntityRecord() { }

public JSONEN_efc751d189a1545503ba31ced5225e86EntityRecord (EN_efc751d189a1545503ba31ced5225e86EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrDescription = ConvertToRestWithoutDefaults(s.ssDescription, "");
AttrExternalId = ConvertToRestWithoutDefaults(s.ssExternalId, "");
AttrCreatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssCreatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrCreatedBy = ConvertToRestWithoutDefaults(s.ssCreatedBy, "");
AttrUpdatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssUpdatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrUpdatedBy = ConvertToRestWithoutDefaults(s.ssUpdatedBy, "");
  } else {
AttrId = (long?) s.ssId;
AttrDescription = s.ssDescription;
AttrExternalId = s.ssExternalId;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
AttrCreatedBy = s.ssCreatedBy;
AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssUpdatedOn, config.DateTimeFormat);
AttrUpdatedBy = s.ssUpdatedBy;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONEN_efc751d189a1545503ba31ced5225e86EntityRecord, EN_efc751d189a1545503ba31ced5225e86EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_efc751d189a1545503ba31ced5225e86EntityRecord s) => ToStructure(s, config);
}
public static EN_efc751d189a1545503ba31ced5225e86EntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_efc751d189a1545503ba31ced5225e86EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_efc751d189a1545503ba31ced5225e86EntityRecord s = new EN_efc751d189a1545503ba31ced5225e86EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssDescription = obj.AttrDescription == null ? "" : obj.AttrDescription;
  s.ssExternalId = obj.AttrExternalId == null ? "" : obj.AttrExternalId;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, config.DateTimeFormat);
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssUpdatedOn = obj.AttrUpdatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrUpdatedOn, config.DateTimeFormat);
  s.ssUpdatedBy = obj.AttrUpdatedBy == null ? "" : obj.AttrUpdatedBy;
  }
  return s;
}

public static Func<EN_efc751d189a1545503ba31ced5225e86EntityRecord, ssConectaProveedores.RestRecords.JSONEN_efc751d189a1545503ba31ced5225e86EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_efc751d189a1545503ba31ced5225e86EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_efc751d189a1545503ba31ced5225e86EntityRecord FromStructure(EN_efc751d189a1545503ba31ced5225e86EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_efc751d189a1545503ba31ced5225e86EntityRecord(s, config);
}

}


