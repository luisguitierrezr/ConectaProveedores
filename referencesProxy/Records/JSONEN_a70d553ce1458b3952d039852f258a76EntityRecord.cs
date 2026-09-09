using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// DocumentType
public class JSONEN_a70d553ce1458b3952d039852f258a76EntityRecord : AbstractRESTStructure<EN_a70d553ce1458b3952d039852f258a76EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("Classe")]
[JsonPropertyName("Classe")]
public string AttrClasse;

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

public JSONEN_a70d553ce1458b3952d039852f258a76EntityRecord() { }

public JSONEN_a70d553ce1458b3952d039852f258a76EntityRecord (EN_a70d553ce1458b3952d039852f258a76EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrClasse = ConvertToRestWithoutDefaults(s.ssClasse, "");
AttrDescription = ConvertToRestWithoutDefaults(s.ssDescription, "");
AttrCreatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssCreatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrCreatedBy = ConvertToRestWithoutDefaults(s.ssCreatedBy, "");
AttrUpdatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssUpdatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrUpdatedBy = ConvertToRestWithoutDefaults(s.ssUpdatedBy, "");
  } else {
AttrId = (long?) s.ssId;
AttrClasse = s.ssClasse;
AttrDescription = s.ssDescription;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
AttrCreatedBy = s.ssCreatedBy;
AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssUpdatedOn, config.DateTimeFormat);
AttrUpdatedBy = s.ssUpdatedBy;
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_a70d553ce1458b3952d039852f258a76EntityRecord, EN_a70d553ce1458b3952d039852f258a76EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_a70d553ce1458b3952d039852f258a76EntityRecord s) => ToStructure(s, config);
}
public static EN_a70d553ce1458b3952d039852f258a76EntityRecord ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_a70d553ce1458b3952d039852f258a76EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_a70d553ce1458b3952d039852f258a76EntityRecord s = new EN_a70d553ce1458b3952d039852f258a76EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssClasse = obj.AttrClasse == null ? "" : obj.AttrClasse;
  s.ssDescription = obj.AttrDescription == null ? "" : obj.AttrDescription;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, config.DateTimeFormat);
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssUpdatedOn = obj.AttrUpdatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrUpdatedOn, config.DateTimeFormat);
  s.ssUpdatedBy = obj.AttrUpdatedBy == null ? "" : obj.AttrUpdatedBy;
  }
  return s;
}

public static Func<EN_a70d553ce1458b3952d039852f258a76EntityRecord, ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_a70d553ce1458b3952d039852f258a76EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_a70d553ce1458b3952d039852f258a76EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_a70d553ce1458b3952d039852f258a76EntityRecord FromStructure(EN_a70d553ce1458b3952d039852f258a76EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_a70d553ce1458b3952d039852f258a76EntityRecord(s, config);
}

}


