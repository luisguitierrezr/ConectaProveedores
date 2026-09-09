using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// PaymentOptions
public class RESTEN_7a1403ba58c6cea2d2bf07fe0448aa32EntityRecord : AbstractRESTStructure<EN_7a1403ba58c6cea2d2bf07fe0448aa32EntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("Code")]
public string AttrCode;

[JsonProperty("Description")]
public string AttrDescription;

[JsonProperty("IsActive")]
public bool? AttrIsActive;

[JsonProperty("CreatedOn")]
public String AttrCreatedOn;

[JsonProperty("CreatedBy")]
public string AttrCreatedBy;

[JsonProperty("UpdatedOn")]
public String AttrUpdatedOn;

[JsonProperty("UpdatedBy")]
public string AttrUpdatedBy;

public RESTEN_7a1403ba58c6cea2d2bf07fe0448aa32EntityRecord() { }

public RESTEN_7a1403ba58c6cea2d2bf07fe0448aa32EntityRecord (EN_7a1403ba58c6cea2d2bf07fe0448aa32EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrCode = ConvertToRestWithoutDefaults(s.ssCode, "");
AttrDescription = ConvertToRestWithoutDefaults(s.ssDescription, "");
AttrIsActive = ConvertToRestWithoutDefaults(s.ssIsActive, true);
AttrCreatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssCreatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrCreatedBy = ConvertToRestWithoutDefaults(s.ssCreatedBy, "");
AttrUpdatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssUpdatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrUpdatedBy = ConvertToRestWithoutDefaults(s.ssUpdatedBy, "");
  } else {
AttrId = (long?) s.ssId;
AttrCode = s.ssCode;
AttrDescription = s.ssDescription;
AttrIsActive = (bool?) s.ssIsActive;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
AttrCreatedBy = s.ssCreatedBy;
AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssUpdatedOn, config.DateTimeFormat);
AttrUpdatedBy = s.ssUpdatedBy;
  }
}

public static EN_7a1403ba58c6cea2d2bf07fe0448aa32EntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_7a1403ba58c6cea2d2bf07fe0448aa32EntityRecord obj) { 
  EN_7a1403ba58c6cea2d2bf07fe0448aa32EntityRecord s = new EN_7a1403ba58c6cea2d2bf07fe0448aa32EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssCode = obj.AttrCode == null ? "" : obj.AttrCode;
  s.ssDescription = obj.AttrDescription == null ? "" : obj.AttrDescription;
  s.ssIsActive = obj.AttrIsActive == null ? true : obj.AttrIsActive.Value;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssUpdatedOn = obj.AttrUpdatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrUpdatedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssUpdatedBy = obj.AttrUpdatedBy == null ? "" : obj.AttrUpdatedBy;
  }
  return s;
}

public static Func<EN_7a1403ba58c6cea2d2bf07fe0448aa32EntityRecord, ssConectaProveedores.RestRecords.RESTEN_7a1403ba58c6cea2d2bf07fe0448aa32EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_7a1403ba58c6cea2d2bf07fe0448aa32EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_7a1403ba58c6cea2d2bf07fe0448aa32EntityRecord FromStructure(EN_7a1403ba58c6cea2d2bf07fe0448aa32EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_7a1403ba58c6cea2d2bf07fe0448aa32EntityRecord(s, config);
}

}


