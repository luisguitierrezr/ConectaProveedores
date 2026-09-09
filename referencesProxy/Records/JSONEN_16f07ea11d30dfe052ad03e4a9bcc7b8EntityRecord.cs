using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// PaymentWays
public class JSONEN_16f07ea11d30dfe052ad03e4a9bcc7b8EntityRecord : AbstractRESTStructure<EN_16f07ea11d30dfe052ad03e4a9bcc7b8EntityRecord> {
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

public JSONEN_16f07ea11d30dfe052ad03e4a9bcc7b8EntityRecord() { }

public JSONEN_16f07ea11d30dfe052ad03e4a9bcc7b8EntityRecord (EN_16f07ea11d30dfe052ad03e4a9bcc7b8EntityRecord s, IBehaviorsConfiguration config) {
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

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_16f07ea11d30dfe052ad03e4a9bcc7b8EntityRecord, EN_16f07ea11d30dfe052ad03e4a9bcc7b8EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_16f07ea11d30dfe052ad03e4a9bcc7b8EntityRecord s) => ToStructure(s, config);
}
public static EN_16f07ea11d30dfe052ad03e4a9bcc7b8EntityRecord ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_16f07ea11d30dfe052ad03e4a9bcc7b8EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_16f07ea11d30dfe052ad03e4a9bcc7b8EntityRecord s = new EN_16f07ea11d30dfe052ad03e4a9bcc7b8EntityRecord();
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

public static Func<EN_16f07ea11d30dfe052ad03e4a9bcc7b8EntityRecord, ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_16f07ea11d30dfe052ad03e4a9bcc7b8EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_16f07ea11d30dfe052ad03e4a9bcc7b8EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_16f07ea11d30dfe052ad03e4a9bcc7b8EntityRecord FromStructure(EN_16f07ea11d30dfe052ad03e4a9bcc7b8EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_16f07ea11d30dfe052ad03e4a9bcc7b8EntityRecord(s, config);
}

}


