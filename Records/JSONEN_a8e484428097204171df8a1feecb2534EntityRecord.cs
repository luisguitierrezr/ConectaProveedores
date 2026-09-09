using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderLogs
public class JSONEN_a8e484428097204171df8a1feecb2534EntityRecord : AbstractRESTStructure<EN_a8e484428097204171df8a1feecb2534EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("OrderId")]
[JsonPropertyName("OrderId")]
public long? AttrOrderId;

[JsonProperty("CreatedBy")]
[JsonPropertyName("CreatedBy")]
public string AttrCreatedBy;

[JsonProperty("CreatedOn")]
[JsonPropertyName("CreatedOn")]
public String AttrCreatedOn;

[JsonProperty("Message")]
[JsonPropertyName("Message")]
public string AttrMessage;

[JsonProperty("IsError")]
[JsonPropertyName("IsError")]
public bool? AttrIsError;

public JSONEN_a8e484428097204171df8a1feecb2534EntityRecord() { }

public JSONEN_a8e484428097204171df8a1feecb2534EntityRecord (EN_a8e484428097204171df8a1feecb2534EntityRecord s, IBehaviorsConfiguration config) {
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

public static Func<ssConectaProveedores.RestRecords.JSONEN_a8e484428097204171df8a1feecb2534EntityRecord, EN_a8e484428097204171df8a1feecb2534EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_a8e484428097204171df8a1feecb2534EntityRecord s) => ToStructure(s, config);
}
public static EN_a8e484428097204171df8a1feecb2534EntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_a8e484428097204171df8a1feecb2534EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_a8e484428097204171df8a1feecb2534EntityRecord s = new EN_a8e484428097204171df8a1feecb2534EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssOrderId = obj.AttrOrderId == null ? 0L : obj.AttrOrderId.Value;
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, config.DateTimeFormat);
  s.ssMessage = obj.AttrMessage == null ? "" : obj.AttrMessage;
  s.ssIsError = obj.AttrIsError == null ? false : obj.AttrIsError.Value;
  }
  return s;
}

public static Func<EN_a8e484428097204171df8a1feecb2534EntityRecord, ssConectaProveedores.RestRecords.JSONEN_a8e484428097204171df8a1feecb2534EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_a8e484428097204171df8a1feecb2534EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_a8e484428097204171df8a1feecb2534EntityRecord FromStructure(EN_a8e484428097204171df8a1feecb2534EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_a8e484428097204171df8a1feecb2534EntityRecord(s, config);
}

}


