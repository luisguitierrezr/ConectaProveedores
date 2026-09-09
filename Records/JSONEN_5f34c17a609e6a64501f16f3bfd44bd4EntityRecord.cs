using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// LogsAccounting
public class JSONEN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord : AbstractRESTStructure<EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("Title")]
[JsonPropertyName("Title")]
public string AttrTitle;

[JsonProperty("AssociatedId")]
[JsonPropertyName("AssociatedId")]
public string AttrAssociatedId;

[JsonProperty("Description")]
[JsonPropertyName("Description")]
public string AttrDescription;

[JsonProperty("CreatedBy")]
[JsonPropertyName("CreatedBy")]
public string AttrCreatedBy;

[JsonProperty("CreatedOn")]
[JsonPropertyName("CreatedOn")]
public String AttrCreatedOn;

[JsonProperty("LogsAccountingSubjectId")]
[JsonPropertyName("LogsAccountingSubjectId")]
public int? AttrLogsAccountingSubjectId;

public JSONEN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord() { }

public JSONEN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord (EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrTitle = ConvertToRestWithoutDefaults(s.ssTitle, "");
AttrAssociatedId = ConvertToRestWithoutDefaults(s.ssAssociatedId, "");
AttrDescription = ConvertToRestWithoutDefaults(s.ssDescription, "");
AttrCreatedBy = ConvertToRestWithoutDefaults(s.ssCreatedBy, "");
AttrCreatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssCreatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrLogsAccountingSubjectId = ConvertToRestWithoutDefaults(s.ssLogsAccountingSubjectId, 0);
  } else {
AttrId = (long?) s.ssId;
AttrTitle = s.ssTitle;
AttrAssociatedId = s.ssAssociatedId;
AttrDescription = s.ssDescription;
AttrCreatedBy = s.ssCreatedBy;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
AttrLogsAccountingSubjectId = (int?) s.ssLogsAccountingSubjectId;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONEN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord, EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord s) => ToStructure(s, config);
}
public static EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord s = new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssTitle = obj.AttrTitle == null ? "" : obj.AttrTitle;
  s.ssAssociatedId = obj.AttrAssociatedId == null ? "" : obj.AttrAssociatedId;
  s.ssDescription = obj.AttrDescription == null ? "" : obj.AttrDescription;
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, config.DateTimeFormat);
  s.ssLogsAccountingSubjectId = obj.AttrLogsAccountingSubjectId == null ? 0 : obj.AttrLogsAccountingSubjectId.Value;
  }
  return s;
}

public static Func<EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord, ssConectaProveedores.RestRecords.JSONEN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord FromStructure(EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(s, config);
}

}


