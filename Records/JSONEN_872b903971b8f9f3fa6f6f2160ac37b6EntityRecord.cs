using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// Company
public class JSONEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord : AbstractRESTStructure<EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("ExternalId")]
[JsonPropertyName("ExternalId")]
public string AttrExternalId;

[JsonProperty("Description")]
[JsonPropertyName("Description")]
public string AttrDescription;

[JsonProperty("RFC")]
[JsonPropertyName("RFC")]
public string AttrRFC;

[JsonProperty("PostalCode")]
[JsonPropertyName("PostalCode")]
public string AttrPostalCode;

[JsonProperty("CyAImport")]
[JsonPropertyName("CyAImport")]
public bool? AttrCyAImport;

[JsonProperty("FsPUse")]
[JsonPropertyName("FsPUse")]
public bool? AttrFsPUse;

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

public JSONEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord() { }

public JSONEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord (EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrExternalId = ConvertToRestWithoutDefaults(s.ssExternalId, "");
AttrDescription = ConvertToRestWithoutDefaults(s.ssDescription, "");
AttrRFC = ConvertToRestWithoutDefaults(s.ssRFC, "");
AttrPostalCode = ConvertToRestWithoutDefaults(s.ssPostalCode, "");
AttrCyAImport = ConvertToRestWithoutDefaults(s.ssCyAImport, false);
AttrFsPUse = ConvertToRestWithoutDefaults(s.ssFsPUse, true);
AttrCreatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssCreatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrCreatedBy = ConvertToRestWithoutDefaults(s.ssCreatedBy, "");
AttrUpdatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssUpdatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrUpdatedBy = ConvertToRestWithoutDefaults(s.ssUpdatedBy, "");
  } else {
AttrId = (long?) s.ssId;
AttrExternalId = s.ssExternalId;
AttrDescription = s.ssDescription;
AttrRFC = s.ssRFC;
AttrPostalCode = s.ssPostalCode;
AttrCyAImport = (bool?) s.ssCyAImport;
AttrFsPUse = (bool?) s.ssFsPUse;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
AttrCreatedBy = s.ssCreatedBy;
AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssUpdatedOn, config.DateTimeFormat);
AttrUpdatedBy = s.ssUpdatedBy;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord, EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord s) => ToStructure(s, config);
}
public static EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord s = new EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssExternalId = obj.AttrExternalId == null ? "" : obj.AttrExternalId;
  s.ssDescription = obj.AttrDescription == null ? "" : obj.AttrDescription;
  s.ssRFC = obj.AttrRFC == null ? "" : obj.AttrRFC;
  s.ssPostalCode = obj.AttrPostalCode == null ? "" : obj.AttrPostalCode;
  s.ssCyAImport = obj.AttrCyAImport == null ? false : obj.AttrCyAImport.Value;
  s.ssFsPUse = obj.AttrFsPUse == null ? true : obj.AttrFsPUse.Value;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, config.DateTimeFormat);
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssUpdatedOn = obj.AttrUpdatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrUpdatedOn, config.DateTimeFormat);
  s.ssUpdatedBy = obj.AttrUpdatedBy == null ? "" : obj.AttrUpdatedBy;
  }
  return s;
}

public static Func<EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord, ssConectaProveedores.RestRecords.JSONEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord FromStructure(EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord(s, config);
}

}


