using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RecordCreatedUpdatedLogStruct
public class RESTST_26711e61541f079fb4510d8f9bfa1e3dStructure : AbstractRESTStructure<ST_26711e61541f079fb4510d8f9bfa1e3dStructure> {
[JsonProperty("CreatedBy")]
public string AttrCreatedBy;

[JsonProperty("CreatedOn")]
public String AttrCreatedOn;

[JsonProperty("UpdatedBy")]
public string AttrUpdatedBy;

[JsonProperty("UpdatedOn")]
public String AttrUpdatedOn;

public RESTST_26711e61541f079fb4510d8f9bfa1e3dStructure() { }

public RESTST_26711e61541f079fb4510d8f9bfa1e3dStructure (ST_26711e61541f079fb4510d8f9bfa1e3dStructure s, IBehaviorsConfiguration config) {
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

public static ST_26711e61541f079fb4510d8f9bfa1e3dStructure ToStructure(ssConectaProveedores.RestRecords.RESTST_26711e61541f079fb4510d8f9bfa1e3dStructure obj) { 
  ST_26711e61541f079fb4510d8f9bfa1e3dStructure s = new ST_26711e61541f079fb4510d8f9bfa1e3dStructure();
  if(obj != null) {
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssUpdatedBy = obj.AttrUpdatedBy == null ? "" : obj.AttrUpdatedBy;
  s.ssUpdatedOn = obj.AttrUpdatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrUpdatedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  }
  return s;
}

public static Func<ST_26711e61541f079fb4510d8f9bfa1e3dStructure, ssConectaProveedores.RestRecords.RESTST_26711e61541f079fb4510d8f9bfa1e3dStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_26711e61541f079fb4510d8f9bfa1e3dStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_26711e61541f079fb4510d8f9bfa1e3dStructure FromStructure(ST_26711e61541f079fb4510d8f9bfa1e3dStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_26711e61541f079fb4510d8f9bfa1e3dStructure(s, config);
}

}


