using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// Project_Asset_Service
public class RESTEN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord : AbstractRESTStructure<EN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("Description")]
public string AttrDescription;

[JsonProperty("IsOthers")]
public bool? AttrIsOthers;

[JsonProperty("CreatedOn")]
public String AttrCreatedOn;

[JsonProperty("CreatedBy")]
public string AttrCreatedBy;

[JsonProperty("UpdatedOn")]
public String AttrUpdatedOn;

[JsonProperty("UpdatedBy")]
public string AttrUpdatedBy;

public RESTEN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord() { }

public RESTEN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord (EN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrDescription = ConvertToRestWithoutDefaults(s.ssDescription, "");
AttrIsOthers = ConvertToRestWithoutDefaults(s.ssIsOthers, false);
AttrCreatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssCreatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrCreatedBy = ConvertToRestWithoutDefaults(s.ssCreatedBy, "");
AttrUpdatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssUpdatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrUpdatedBy = ConvertToRestWithoutDefaults(s.ssUpdatedBy, "");
  } else {
AttrId = (long?) s.ssId;
AttrDescription = s.ssDescription;
AttrIsOthers = (bool?) s.ssIsOthers;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
AttrCreatedBy = s.ssCreatedBy;
AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssUpdatedOn, config.DateTimeFormat);
AttrUpdatedBy = s.ssUpdatedBy;
  }
}

public static EN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord obj) { 
  EN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord s = new EN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssDescription = obj.AttrDescription == null ? "" : obj.AttrDescription;
  s.ssIsOthers = obj.AttrIsOthers == null ? false : obj.AttrIsOthers.Value;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssUpdatedOn = obj.AttrUpdatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrUpdatedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssUpdatedBy = obj.AttrUpdatedBy == null ? "" : obj.AttrUpdatedBy;
  }
  return s;
}

public static Func<EN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord, ssConectaProveedores.RestRecords.RESTEN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord FromStructure(EN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord(s, config);
}

}


