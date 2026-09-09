using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ActionTimestamps
public class RESTEN_b22d64c90281d09a316b6f4502a74326EntityRecord : AbstractRESTStructure<EN_b22d64c90281d09a316b6f4502a74326EntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("Description")]
public string AttrDescription;

[JsonProperty("StartedOn")]
public String AttrStartedOn;

[JsonProperty("FinishedOn")]
public String AttrFinishedOn;

public RESTEN_b22d64c90281d09a316b6f4502a74326EntityRecord() { }

public RESTEN_b22d64c90281d09a316b6f4502a74326EntityRecord (EN_b22d64c90281d09a316b6f4502a74326EntityRecord s, IBehaviorsConfiguration config) {
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

public static EN_b22d64c90281d09a316b6f4502a74326EntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_b22d64c90281d09a316b6f4502a74326EntityRecord obj) { 
  EN_b22d64c90281d09a316b6f4502a74326EntityRecord s = new EN_b22d64c90281d09a316b6f4502a74326EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssDescription = obj.AttrDescription == null ? "" : obj.AttrDescription;
  s.ssStartedOn = obj.AttrStartedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrStartedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssFinishedOn = obj.AttrFinishedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrFinishedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  }
  return s;
}

public static Func<EN_b22d64c90281d09a316b6f4502a74326EntityRecord, ssConectaProveedores.RestRecords.RESTEN_b22d64c90281d09a316b6f4502a74326EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_b22d64c90281d09a316b6f4502a74326EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_b22d64c90281d09a316b6f4502a74326EntityRecord FromStructure(EN_b22d64c90281d09a316b6f4502a74326EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_b22d64c90281d09a316b6f4502a74326EntityRecord(s, config);
}

}


