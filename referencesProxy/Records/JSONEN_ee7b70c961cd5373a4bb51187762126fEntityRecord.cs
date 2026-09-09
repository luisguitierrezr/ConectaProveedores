using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// PurchasingGroup
public class JSONEN_ee7b70c961cd5373a4bb51187762126fEntityRecord : AbstractRESTStructure<EN_ee7b70c961cd5373a4bb51187762126fEntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("Md")]
[JsonPropertyName("Md")]
public string AttrMd;

[JsonProperty("Code")]
[JsonPropertyName("Code")]
public string AttrCode;

[JsonProperty("Denomination")]
[JsonPropertyName("Denomination")]
public string AttrDenomination;

[JsonProperty("UsedOn")]
[JsonPropertyName("UsedOn")]
public string AttrUsedOn;

[JsonProperty("RegionId")]
[JsonPropertyName("RegionId")]
public long? AttrRegionId;

[JsonProperty("Notes")]
[JsonPropertyName("Notes")]
public string AttrNotes;

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

public JSONEN_ee7b70c961cd5373a4bb51187762126fEntityRecord() { }

public JSONEN_ee7b70c961cd5373a4bb51187762126fEntityRecord (EN_ee7b70c961cd5373a4bb51187762126fEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrMd = ConvertToRestWithoutDefaults(s.ssMd, "");
AttrCode = s.ssCode;
AttrDenomination = ConvertToRestWithoutDefaults(s.ssDenomination, "");
AttrUsedOn = ConvertToRestWithoutDefaults(s.ssUsedOn, "");
AttrRegionId = ConvertToRestWithoutDefaults(s.ssRegionId, 0L);
AttrNotes = ConvertToRestWithoutDefaults(s.ssNotes, "");
AttrCreatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssCreatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrCreatedBy = ConvertToRestWithoutDefaults(s.ssCreatedBy, "");
AttrUpdatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssUpdatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrUpdatedBy = ConvertToRestWithoutDefaults(s.ssUpdatedBy, "");
  } else {
AttrId = (long?) s.ssId;
AttrMd = s.ssMd;
AttrCode = s.ssCode;
AttrDenomination = s.ssDenomination;
AttrUsedOn = s.ssUsedOn;
AttrRegionId = (long?) s.ssRegionId;
AttrNotes = s.ssNotes;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
AttrCreatedBy = s.ssCreatedBy;
AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssUpdatedOn, config.DateTimeFormat);
AttrUpdatedBy = s.ssUpdatedBy;
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_ee7b70c961cd5373a4bb51187762126fEntityRecord, EN_ee7b70c961cd5373a4bb51187762126fEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_ee7b70c961cd5373a4bb51187762126fEntityRecord s) => ToStructure(s, config);
}
public static EN_ee7b70c961cd5373a4bb51187762126fEntityRecord ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_ee7b70c961cd5373a4bb51187762126fEntityRecord obj, IBehaviorsConfiguration config) { 
  EN_ee7b70c961cd5373a4bb51187762126fEntityRecord s = new EN_ee7b70c961cd5373a4bb51187762126fEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssMd = obj.AttrMd == null ? "" : obj.AttrMd;
  s.ssCode = obj.AttrCode == null ? "" : obj.AttrCode;
  s.ssDenomination = obj.AttrDenomination == null ? "" : obj.AttrDenomination;
  s.ssUsedOn = obj.AttrUsedOn == null ? "" : obj.AttrUsedOn;
  s.ssRegionId = obj.AttrRegionId == null ? 0L : obj.AttrRegionId.Value;
  s.ssNotes = obj.AttrNotes == null ? "" : obj.AttrNotes;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, config.DateTimeFormat);
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssUpdatedOn = obj.AttrUpdatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrUpdatedOn, config.DateTimeFormat);
  s.ssUpdatedBy = obj.AttrUpdatedBy == null ? "" : obj.AttrUpdatedBy;
  }
  return s;
}

public static Func<EN_ee7b70c961cd5373a4bb51187762126fEntityRecord, ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_ee7b70c961cd5373a4bb51187762126fEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_ee7b70c961cd5373a4bb51187762126fEntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_ee7b70c961cd5373a4bb51187762126fEntityRecord FromStructure(EN_ee7b70c961cd5373a4bb51187762126fEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_ee7b70c961cd5373a4bb51187762126fEntityRecord(s, config);
}

}


