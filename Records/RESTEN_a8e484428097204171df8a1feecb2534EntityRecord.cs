using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderLogs
public class RESTEN_a8e484428097204171df8a1feecb2534EntityRecord : AbstractRESTStructure<EN_a8e484428097204171df8a1feecb2534EntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("OrderId")]
public long? AttrOrderId;

[JsonProperty("CreatedBy")]
public string AttrCreatedBy;

[JsonProperty("CreatedOn")]
public String AttrCreatedOn;

[JsonProperty("Message")]
public string AttrMessage;

[JsonProperty("IsError")]
public bool? AttrIsError;

public RESTEN_a8e484428097204171df8a1feecb2534EntityRecord() { }

public RESTEN_a8e484428097204171df8a1feecb2534EntityRecord (EN_a8e484428097204171df8a1feecb2534EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrOrderId = ConvertToRestWithoutDefaults(s.ssOrderId, 0L);
AttrCreatedBy = ConvertToRestWithoutDefaults(s.ssCreatedBy, "");
AttrCreatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssCreatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrMessage = ConvertToRestWithoutDefaults(s.ssMessage, "");
AttrIsError = ConvertToRestWithoutDefaults(s.ssIsError, false);
  } else {
AttrId = (long?) s.ssId;
AttrOrderId = (long?) s.ssOrderId;
AttrCreatedBy = s.ssCreatedBy;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
AttrMessage = s.ssMessage;
AttrIsError = (bool?) s.ssIsError;
  }
}

public static EN_a8e484428097204171df8a1feecb2534EntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_a8e484428097204171df8a1feecb2534EntityRecord obj) { 
  EN_a8e484428097204171df8a1feecb2534EntityRecord s = new EN_a8e484428097204171df8a1feecb2534EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssOrderId = obj.AttrOrderId == null ? 0L : obj.AttrOrderId.Value;
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssMessage = obj.AttrMessage == null ? "" : obj.AttrMessage;
  s.ssIsError = obj.AttrIsError == null ? false : obj.AttrIsError.Value;
  }
  return s;
}

public static Func<EN_a8e484428097204171df8a1feecb2534EntityRecord, ssConectaProveedores.RestRecords.RESTEN_a8e484428097204171df8a1feecb2534EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_a8e484428097204171df8a1feecb2534EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_a8e484428097204171df8a1feecb2534EntityRecord FromStructure(EN_a8e484428097204171df8a1feecb2534EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_a8e484428097204171df8a1feecb2534EntityRecord(s, config);
}

}


