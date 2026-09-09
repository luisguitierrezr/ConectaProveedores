using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ActionTimestamps
public class JSONEN_b22d64c90281d09a316b6f4502a74326EntityRecord : AbstractRESTStructure<EN_b22d64c90281d09a316b6f4502a74326EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("Description")]
[JsonPropertyName("Description")]
public string AttrDescription;

[JsonProperty("StartedOn")]
[JsonPropertyName("StartedOn")]
public String AttrStartedOn;

[JsonProperty("FinishedOn")]
[JsonPropertyName("FinishedOn")]
public String AttrFinishedOn;

public JSONEN_b22d64c90281d09a316b6f4502a74326EntityRecord() { }

public JSONEN_b22d64c90281d09a316b6f4502a74326EntityRecord (EN_b22d64c90281d09a316b6f4502a74326EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrDescription = ConvertToRestWithoutDefaults(s.ssDescription, "");
AttrStartedOn = ConvertDateTimeToRestWithoutDefaults(s.ssStartedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrFinishedOn = ConvertDateTimeToRestWithoutDefaults(s.ssFinishedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
  } else {
AttrId = (long?) s.ssId;
AttrDescription = s.ssDescription;
AttrStartedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssStartedOn, config.DateTimeFormat);
AttrFinishedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssFinishedOn, config.DateTimeFormat);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONEN_b22d64c90281d09a316b6f4502a74326EntityRecord, EN_b22d64c90281d09a316b6f4502a74326EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_b22d64c90281d09a316b6f4502a74326EntityRecord s) => ToStructure(s, config);
}
public static EN_b22d64c90281d09a316b6f4502a74326EntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_b22d64c90281d09a316b6f4502a74326EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_b22d64c90281d09a316b6f4502a74326EntityRecord s = new EN_b22d64c90281d09a316b6f4502a74326EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssDescription = obj.AttrDescription == null ? "" : obj.AttrDescription;
  s.ssStartedOn = obj.AttrStartedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrStartedOn, config.DateTimeFormat);
  s.ssFinishedOn = obj.AttrFinishedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrFinishedOn, config.DateTimeFormat);
  }
  return s;
}

public static Func<EN_b22d64c90281d09a316b6f4502a74326EntityRecord, ssConectaProveedores.RestRecords.JSONEN_b22d64c90281d09a316b6f4502a74326EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_b22d64c90281d09a316b6f4502a74326EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_b22d64c90281d09a316b6f4502a74326EntityRecord FromStructure(EN_b22d64c90281d09a316b6f4502a74326EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_b22d64c90281d09a316b6f4502a74326EntityRecord(s, config);
}

}


