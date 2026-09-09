using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// PaymentTerms
public class JSONEN_17720044fda96c0c2d8d0760c429f48aEntityRecord : AbstractRESTStructure<EN_17720044fda96c0c2d8d0760c429f48aEntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("Description")]
[JsonPropertyName("Description")]
public string AttrDescription;

[JsonProperty("ClCta")]
[JsonPropertyName("ClCta")]
public string AttrClCta;

[JsonProperty("ClassFecha")]
[JsonPropertyName("ClassFecha")]
public string AttrClassFecha;

[JsonProperty("Ctd_dias")]
[JsonPropertyName("Ctd_dias")]
public string AttrCtd_dias;

[JsonProperty("EstructuraDescripcionPROP")]
[JsonPropertyName("EstructuraDescripcionPROP")]
public string AttrEstructuraDescripcionPROP;

[JsonProperty("IsSpecial")]
[JsonPropertyName("IsSpecial")]
public bool? AttrIsSpecial;

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

public JSONEN_17720044fda96c0c2d8d0760c429f48aEntityRecord() { }

public JSONEN_17720044fda96c0c2d8d0760c429f48aEntityRecord (EN_17720044fda96c0c2d8d0760c429f48aEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrDescription = ConvertToRestWithoutDefaults(s.ssDescription, "");
AttrClCta = ConvertToRestWithoutDefaults(s.ssClCta, "");
AttrClassFecha = ConvertToRestWithoutDefaults(s.ssClassFecha, "");
AttrCtd_dias = ConvertToRestWithoutDefaults(s.ssCtd_dias, "");
AttrEstructuraDescripcionPROP = ConvertToRestWithoutDefaults(s.ssEstructuraDescripcionPROP, "");
AttrIsSpecial = ConvertToRestWithoutDefaults(s.ssIsSpecial, false);
AttrCreatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssCreatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrCreatedBy = ConvertToRestWithoutDefaults(s.ssCreatedBy, "");
AttrUpdatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssUpdatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrUpdatedBy = ConvertToRestWithoutDefaults(s.ssUpdatedBy, "");
  } else {
AttrId = (long?) s.ssId;
AttrDescription = s.ssDescription;
AttrClCta = s.ssClCta;
AttrClassFecha = s.ssClassFecha;
AttrCtd_dias = s.ssCtd_dias;
AttrEstructuraDescripcionPROP = s.ssEstructuraDescripcionPROP;
AttrIsSpecial = (bool?) s.ssIsSpecial;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
AttrCreatedBy = s.ssCreatedBy;
AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssUpdatedOn, config.DateTimeFormat);
AttrUpdatedBy = s.ssUpdatedBy;
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_17720044fda96c0c2d8d0760c429f48aEntityRecord, EN_17720044fda96c0c2d8d0760c429f48aEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_17720044fda96c0c2d8d0760c429f48aEntityRecord s) => ToStructure(s, config);
}
public static EN_17720044fda96c0c2d8d0760c429f48aEntityRecord ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_17720044fda96c0c2d8d0760c429f48aEntityRecord obj, IBehaviorsConfiguration config) { 
  EN_17720044fda96c0c2d8d0760c429f48aEntityRecord s = new EN_17720044fda96c0c2d8d0760c429f48aEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssDescription = obj.AttrDescription == null ? "" : obj.AttrDescription;
  s.ssClCta = obj.AttrClCta == null ? "" : obj.AttrClCta;
  s.ssClassFecha = obj.AttrClassFecha == null ? "" : obj.AttrClassFecha;
  s.ssCtd_dias = obj.AttrCtd_dias == null ? "" : obj.AttrCtd_dias;
  s.ssEstructuraDescripcionPROP = obj.AttrEstructuraDescripcionPROP == null ? "" : obj.AttrEstructuraDescripcionPROP;
  s.ssIsSpecial = obj.AttrIsSpecial == null ? false : obj.AttrIsSpecial.Value;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, config.DateTimeFormat);
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssUpdatedOn = obj.AttrUpdatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrUpdatedOn, config.DateTimeFormat);
  s.ssUpdatedBy = obj.AttrUpdatedBy == null ? "" : obj.AttrUpdatedBy;
  }
  return s;
}

public static Func<EN_17720044fda96c0c2d8d0760c429f48aEntityRecord, ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_17720044fda96c0c2d8d0760c429f48aEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_17720044fda96c0c2d8d0760c429f48aEntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_17720044fda96c0c2d8d0760c429f48aEntityRecord FromStructure(EN_17720044fda96c0c2d8d0760c429f48aEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_17720044fda96c0c2d8d0760c429f48aEntityRecord(s, config);
}

}


