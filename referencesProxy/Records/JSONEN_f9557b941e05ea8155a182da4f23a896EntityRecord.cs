using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// Manuals
public class JSONEN_f9557b941e05ea8155a182da4f23a896EntityRecord : AbstractRESTStructure<EN_f9557b941e05ea8155a182da4f23a896EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("Title")]
[JsonPropertyName("Title")]
public string AttrTitle;

[JsonProperty("AppConceptId")]
[JsonPropertyName("AppConceptId")]
public int? AttrAppConceptId;

[JsonProperty("ConceptId")]
[JsonPropertyName("ConceptId")]
public int? AttrConceptId;

[JsonProperty("ShortDescription")]
[JsonPropertyName("ShortDescription")]
public string AttrShortDescription;

[JsonProperty("Description")]
[JsonPropertyName("Description")]
public string AttrDescription;

[JsonProperty("Star")]
[JsonPropertyName("Star")]
public bool? AttrStar;

[JsonProperty("ForProveedor")]
[JsonPropertyName("ForProveedor")]
public bool? AttrForProveedor;

[JsonProperty("IsVideo")]
[JsonPropertyName("IsVideo")]
public bool? AttrIsVideo;

[JsonProperty("IsActive")]
[JsonPropertyName("IsActive")]
public bool? AttrIsActive;

[JsonProperty("CreatedOn")]
[JsonPropertyName("CreatedOn")]
public String AttrCreatedOn;

[JsonProperty("CreatedBy")]
[JsonPropertyName("CreatedBy")]
public string AttrCreatedBy;

public JSONEN_f9557b941e05ea8155a182da4f23a896EntityRecord() { }

public JSONEN_f9557b941e05ea8155a182da4f23a896EntityRecord (EN_f9557b941e05ea8155a182da4f23a896EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrTitle = ConvertToRestWithoutDefaults(s.ssTitle, "");
AttrAppConceptId = ConvertToRestWithoutDefaults(s.ssAppConceptId, 0);
AttrConceptId = ConvertToRestWithoutDefaults(s.ssConceptId, 0);
AttrShortDescription = ConvertToRestWithoutDefaults(s.ssShortDescription, "");
AttrDescription = ConvertToRestWithoutDefaults(s.ssDescription, "");
AttrStar = ConvertToRestWithoutDefaults(s.ssStar, false);
AttrForProveedor = ConvertToRestWithoutDefaults(s.ssForProveedor, false);
AttrIsVideo = (bool?) s.ssIsVideo;
AttrIsActive = ConvertToRestWithoutDefaults(s.ssIsActive, true);
AttrCreatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssCreatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrCreatedBy = ConvertToRestWithoutDefaults(s.ssCreatedBy, "");
  } else {
AttrId = (long?) s.ssId;
AttrTitle = s.ssTitle;
AttrAppConceptId = (int?) s.ssAppConceptId;
AttrConceptId = (int?) s.ssConceptId;
AttrShortDescription = s.ssShortDescription;
AttrDescription = s.ssDescription;
AttrStar = (bool?) s.ssStar;
AttrForProveedor = (bool?) s.ssForProveedor;
AttrIsVideo = (bool?) s.ssIsVideo;
AttrIsActive = (bool?) s.ssIsActive;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
AttrCreatedBy = s.ssCreatedBy;
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_f9557b941e05ea8155a182da4f23a896EntityRecord, EN_f9557b941e05ea8155a182da4f23a896EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_f9557b941e05ea8155a182da4f23a896EntityRecord s) => ToStructure(s, config);
}
public static EN_f9557b941e05ea8155a182da4f23a896EntityRecord ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_f9557b941e05ea8155a182da4f23a896EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_f9557b941e05ea8155a182da4f23a896EntityRecord s = new EN_f9557b941e05ea8155a182da4f23a896EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssTitle = obj.AttrTitle == null ? "" : obj.AttrTitle;
  s.ssAppConceptId = obj.AttrAppConceptId == null ? 0 : obj.AttrAppConceptId.Value;
  s.ssConceptId = obj.AttrConceptId == null ? 0 : obj.AttrConceptId.Value;
  s.ssShortDescription = obj.AttrShortDescription == null ? "" : obj.AttrShortDescription;
  s.ssDescription = obj.AttrDescription == null ? "" : obj.AttrDescription;
  s.ssStar = obj.AttrStar == null ? false : obj.AttrStar.Value;
  s.ssForProveedor = obj.AttrForProveedor == null ? false : obj.AttrForProveedor.Value;
  s.ssIsVideo = obj.AttrIsVideo == null ? false : obj.AttrIsVideo.Value;
  s.ssIsActive = obj.AttrIsActive == null ? true : obj.AttrIsActive.Value;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, config.DateTimeFormat);
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  }
  return s;
}

public static Func<EN_f9557b941e05ea8155a182da4f23a896EntityRecord, ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_f9557b941e05ea8155a182da4f23a896EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_f9557b941e05ea8155a182da4f23a896EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_f9557b941e05ea8155a182da4f23a896EntityRecord FromStructure(EN_f9557b941e05ea8155a182da4f23a896EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_f9557b941e05ea8155a182da4f23a896EntityRecord(s, config);
}

}


