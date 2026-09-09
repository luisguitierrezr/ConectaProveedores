using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RecordCreatedUpdatedLogStruct
public class JSONST_26711e61541f079fb4510d8f9bfa1e3dStructure : AbstractRESTStructure<ST_26711e61541f079fb4510d8f9bfa1e3dStructure> {
[JsonProperty("CreatedBy")]
[JsonPropertyName("CreatedBy")]
public string AttrCreatedBy;

[JsonProperty("CreatedOn")]
[JsonPropertyName("CreatedOn")]
public String AttrCreatedOn;

[JsonProperty("UpdatedBy")]
[JsonPropertyName("UpdatedBy")]
public string AttrUpdatedBy;

[JsonProperty("UpdatedOn")]
[JsonPropertyName("UpdatedOn")]
public String AttrUpdatedOn;

public JSONST_26711e61541f079fb4510d8f9bfa1e3dStructure() { }

public JSONST_26711e61541f079fb4510d8f9bfa1e3dStructure (ST_26711e61541f079fb4510d8f9bfa1e3dStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCreatedBy = ConvertToRestWithoutDefaults(s.ssCreatedBy, "");
AttrCreatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssCreatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrUpdatedBy = ConvertToRestWithoutDefaults(s.ssUpdatedBy, "");
AttrUpdatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssUpdatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
  } else {
AttrCreatedBy = s.ssCreatedBy;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
AttrUpdatedBy = s.ssUpdatedBy;
AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssUpdatedOn, config.DateTimeFormat);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_26711e61541f079fb4510d8f9bfa1e3dStructure, ST_26711e61541f079fb4510d8f9bfa1e3dStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_26711e61541f079fb4510d8f9bfa1e3dStructure s) => ToStructure(s, config);
}
public static ST_26711e61541f079fb4510d8f9bfa1e3dStructure ToStructure(ssConectaProveedores.RestRecords.JSONST_26711e61541f079fb4510d8f9bfa1e3dStructure obj, IBehaviorsConfiguration config) { 
  ST_26711e61541f079fb4510d8f9bfa1e3dStructure s = new ST_26711e61541f079fb4510d8f9bfa1e3dStructure();
  if(obj != null) {
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, config.DateTimeFormat);
  s.ssUpdatedBy = obj.AttrUpdatedBy == null ? "" : obj.AttrUpdatedBy;
  s.ssUpdatedOn = obj.AttrUpdatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrUpdatedOn, config.DateTimeFormat);
  }
  return s;
}

public static Func<ST_26711e61541f079fb4510d8f9bfa1e3dStructure, ssConectaProveedores.RestRecords.JSONST_26711e61541f079fb4510d8f9bfa1e3dStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_26711e61541f079fb4510d8f9bfa1e3dStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_26711e61541f079fb4510d8f9bfa1e3dStructure FromStructure(ST_26711e61541f079fb4510d8f9bfa1e3dStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_26711e61541f079fb4510d8f9bfa1e3dStructure(s, config);
}

}


