using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// LogsAccounting
public class RESTEN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord : AbstractRESTStructure<EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("Title")]
public string AttrTitle;

[JsonProperty("AssociatedId")]
public string AttrAssociatedId;

[JsonProperty("Description")]
public string AttrDescription;

[JsonProperty("CreatedBy")]
public string AttrCreatedBy;

[JsonProperty("CreatedOn")]
public String AttrCreatedOn;

[JsonProperty("LogsAccountingSubjectId")]
public int? AttrLogsAccountingSubjectId;

public RESTEN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord() { }

public RESTEN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord (EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord s, IBehaviorsConfiguration config) {
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

public static EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord obj) { 
  EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord s = new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssTitle = obj.AttrTitle == null ? "" : obj.AttrTitle;
  s.ssAssociatedId = obj.AttrAssociatedId == null ? "" : obj.AttrAssociatedId;
  s.ssDescription = obj.AttrDescription == null ? "" : obj.AttrDescription;
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssLogsAccountingSubjectId = obj.AttrLogsAccountingSubjectId == null ? 0 : obj.AttrLogsAccountingSubjectId.Value;
  }
  return s;
}

public static Func<EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord, ssConectaProveedores.RestRecords.RESTEN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord FromStructure(EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(s, config);
}

}


