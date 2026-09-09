using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ValueItem3
public class JSONST_7103e60d503e9a31fa1ef77b9f0699a9Structure : AbstractRESTStructure<ST_7103e60d503e9a31fa1ef77b9f0699a9Structure> {
[JsonProperty("id")]
[JsonPropertyName("id")]
public string AttrId;

[JsonProperty("deletedDateTime")]
[JsonPropertyName("deletedDateTime")]
public String AttrDeletedDateTime;

[JsonProperty("description")]
[JsonPropertyName("description")]
public string AttrDescription;

[JsonProperty("displayName")]
[JsonPropertyName("displayName")]
public string AttrDisplayName;

[JsonProperty("roleTemplateId")]
[JsonPropertyName("roleTemplateId")]
public string AttrRoleTemplateId;

public JSONST_7103e60d503e9a31fa1ef77b9f0699a9Structure() { }

public JSONST_7103e60d503e9a31fa1ef77b9f0699a9Structure (ST_7103e60d503e9a31fa1ef77b9f0699a9Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = ConvertToRestWithoutDefaults(s.ssId, "");
AttrDeletedDateTime = ConvertDateTimeToRestWithoutDefaults(s.ssDeletedDateTime, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrDescription = ConvertToRestWithoutDefaults(s.ssDescription, "");
AttrDisplayName = ConvertToRestWithoutDefaults(s.ssDisplayName, "");
AttrRoleTemplateId = ConvertToRestWithoutDefaults(s.ssRoleTemplateId, "");
  } else {
AttrId = s.ssId;
AttrDeletedDateTime = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssDeletedDateTime, config.DateTimeFormat);
AttrDescription = s.ssDescription;
AttrDisplayName = s.ssDisplayName;
AttrRoleTemplateId = s.ssRoleTemplateId;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_7103e60d503e9a31fa1ef77b9f0699a9Structure, ST_7103e60d503e9a31fa1ef77b9f0699a9Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_7103e60d503e9a31fa1ef77b9f0699a9Structure s) => ToStructure(s, config);
}
public static ST_7103e60d503e9a31fa1ef77b9f0699a9Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_7103e60d503e9a31fa1ef77b9f0699a9Structure obj, IBehaviorsConfiguration config) { 
  ST_7103e60d503e9a31fa1ef77b9f0699a9Structure s = new ST_7103e60d503e9a31fa1ef77b9f0699a9Structure();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? "" : obj.AttrId;
  s.ssDeletedDateTime = obj.AttrDeletedDateTime == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrDeletedDateTime, config.DateTimeFormat);
  s.ssDescription = obj.AttrDescription == null ? "" : obj.AttrDescription;
  s.ssDisplayName = obj.AttrDisplayName == null ? "" : obj.AttrDisplayName;
  s.ssRoleTemplateId = obj.AttrRoleTemplateId == null ? "" : obj.AttrRoleTemplateId;
  }
  return s;
}

public static Func<ST_7103e60d503e9a31fa1ef77b9f0699a9Structure, ssConectaProveedores.RestRecords.JSONST_7103e60d503e9a31fa1ef77b9f0699a9Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_7103e60d503e9a31fa1ef77b9f0699a9Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_7103e60d503e9a31fa1ef77b9f0699a9Structure FromStructure(ST_7103e60d503e9a31fa1ef77b9f0699a9Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_7103e60d503e9a31fa1ef77b9f0699a9Structure(s, config);
}

}


