using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// PaymentMethods
public class RESTEN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord : AbstractRESTStructure<EN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("Description")]
public string AttrDescription;

[JsonProperty("ExternalId")]
public string AttrExternalId;

[JsonProperty("IsFCP")]
public bool? AttrIsFCP;

[JsonProperty("CreatedOn")]
public String AttrCreatedOn;

[JsonProperty("CreatedBy")]
public string AttrCreatedBy;

[JsonProperty("UpdatedOn")]
public String AttrUpdatedOn;

[JsonProperty("UpdatedBy")]
public string AttrUpdatedBy;

[JsonProperty("IsActive")]
public bool? AttrIsActive;

public RESTEN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord() { }

public RESTEN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord (EN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrDescription = ConvertToRestWithoutDefaults(s.ssDescription, "");
AttrExternalId = ConvertToRestWithoutDefaults(s.ssExternalId, "");
AttrIsFCP = ConvertToRestWithoutDefaults(s.ssIsFCP, false);
AttrCreatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssCreatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrCreatedBy = ConvertToRestWithoutDefaults(s.ssCreatedBy, "");
AttrUpdatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssUpdatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrUpdatedBy = ConvertToRestWithoutDefaults(s.ssUpdatedBy, "");
AttrIsActive = ConvertToRestWithoutDefaults(s.ssIsActive, true);
  } else {
AttrId = (long?) s.ssId;
AttrDescription = s.ssDescription;
AttrExternalId = s.ssExternalId;
AttrIsFCP = (bool?) s.ssIsFCP;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
AttrCreatedBy = s.ssCreatedBy;
AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssUpdatedOn, config.DateTimeFormat);
AttrUpdatedBy = s.ssUpdatedBy;
AttrIsActive = (bool?) s.ssIsActive;
  }
}

public static EN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord obj) { 
  EN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord s = new EN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssDescription = obj.AttrDescription == null ? "" : obj.AttrDescription;
  s.ssExternalId = obj.AttrExternalId == null ? "" : obj.AttrExternalId;
  s.ssIsFCP = obj.AttrIsFCP == null ? false : obj.AttrIsFCP.Value;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssUpdatedOn = obj.AttrUpdatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrUpdatedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssUpdatedBy = obj.AttrUpdatedBy == null ? "" : obj.AttrUpdatedBy;
  s.ssIsActive = obj.AttrIsActive == null ? true : obj.AttrIsActive.Value;
  }
  return s;
}

public static Func<EN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord, ssConectaProveedores.RestRecords.RESTEN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord FromStructure(EN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord(s, config);
}

}


