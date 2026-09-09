using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// BusinessValueCategory
public class RESTEN_0578d9e3d7c16250b8bfbc03836e290fEntityRecord : AbstractRESTStructure<EN_0578d9e3d7c16250b8bfbc03836e290fEntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("Description")]
public string AttrDescription;

[JsonProperty("CreatedOn")]
public String AttrCreatedOn;

[JsonProperty("CreatedBy")]
public string AttrCreatedBy;

[JsonProperty("UpdatedOn")]
public String AttrUpdatedOn;

[JsonProperty("UpdatedBy")]
public string AttrUpdatedBy;

public RESTEN_0578d9e3d7c16250b8bfbc03836e290fEntityRecord() { }

public RESTEN_0578d9e3d7c16250b8bfbc03836e290fEntityRecord (EN_0578d9e3d7c16250b8bfbc03836e290fEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrDescription = ConvertToRestWithoutDefaults(s.ssDescription, "");
AttrCreatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssCreatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrCreatedBy = ConvertToRestWithoutDefaults(s.ssCreatedBy, "");
AttrUpdatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssUpdatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrUpdatedBy = ConvertToRestWithoutDefaults(s.ssUpdatedBy, "");
  } else {
AttrId = (long?) s.ssId;
AttrDescription = s.ssDescription;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
AttrCreatedBy = s.ssCreatedBy;
AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssUpdatedOn, config.DateTimeFormat);
AttrUpdatedBy = s.ssUpdatedBy;
  }
}

public static EN_0578d9e3d7c16250b8bfbc03836e290fEntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_0578d9e3d7c16250b8bfbc03836e290fEntityRecord obj) { 
  EN_0578d9e3d7c16250b8bfbc03836e290fEntityRecord s = new EN_0578d9e3d7c16250b8bfbc03836e290fEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssDescription = obj.AttrDescription == null ? "" : obj.AttrDescription;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssUpdatedOn = obj.AttrUpdatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrUpdatedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssUpdatedBy = obj.AttrUpdatedBy == null ? "" : obj.AttrUpdatedBy;
  }
  return s;
}

public static Func<EN_0578d9e3d7c16250b8bfbc03836e290fEntityRecord, ssConectaProveedores.RestRecords.RESTEN_0578d9e3d7c16250b8bfbc03836e290fEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_0578d9e3d7c16250b8bfbc03836e290fEntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_0578d9e3d7c16250b8bfbc03836e290fEntityRecord FromStructure(EN_0578d9e3d7c16250b8bfbc03836e290fEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_0578d9e3d7c16250b8bfbc03836e290fEntityRecord(s, config);
}

}


