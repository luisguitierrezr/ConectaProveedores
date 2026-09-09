using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderRequestFileApproval
public class RESTEN_1710c672f4d7138b664ee1411114271eEntityRecord : AbstractRESTStructure<EN_1710c672f4d7138b664ee1411114271eEntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("OrderRequestFileId")]
public long? AttrOrderRequestFileId;

[JsonProperty("CurrentLevel")]
public int? AttrCurrentLevel;

[JsonProperty("MaxLevel")]
public int? AttrMaxLevel;

[JsonProperty("StartedOn")]
public String AttrStartedOn;

[JsonProperty("FinishedOn")]
public String AttrFinishedOn;

public RESTEN_1710c672f4d7138b664ee1411114271eEntityRecord() { }

public RESTEN_1710c672f4d7138b664ee1411114271eEntityRecord (EN_1710c672f4d7138b664ee1411114271eEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrOrderRequestFileId = ConvertToRestWithoutDefaults(s.ssOrderRequestFileId, 0L);
AttrCurrentLevel = ConvertToRestWithoutDefaults(s.ssCurrentLevel, 0);
AttrMaxLevel = ConvertToRestWithoutDefaults(s.ssMaxLevel, 0);
AttrStartedOn = ConvertDateTimeToRestWithoutDefaults(s.ssStartedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrFinishedOn = ConvertDateTimeToRestWithoutDefaults(s.ssFinishedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
  } else {
AttrId = (long?) s.ssId;
AttrOrderRequestFileId = (long?) s.ssOrderRequestFileId;
AttrCurrentLevel = (int?) s.ssCurrentLevel;
AttrMaxLevel = (int?) s.ssMaxLevel;
AttrStartedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssStartedOn, config.DateTimeFormat);
AttrFinishedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssFinishedOn, config.DateTimeFormat);
  }
}

public static EN_1710c672f4d7138b664ee1411114271eEntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_1710c672f4d7138b664ee1411114271eEntityRecord obj) { 
  EN_1710c672f4d7138b664ee1411114271eEntityRecord s = new EN_1710c672f4d7138b664ee1411114271eEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssOrderRequestFileId = obj.AttrOrderRequestFileId == null ? 0L : obj.AttrOrderRequestFileId.Value;
  s.ssCurrentLevel = obj.AttrCurrentLevel == null ? 0 : obj.AttrCurrentLevel.Value;
  s.ssMaxLevel = obj.AttrMaxLevel == null ? 0 : obj.AttrMaxLevel.Value;
  s.ssStartedOn = obj.AttrStartedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrStartedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssFinishedOn = obj.AttrFinishedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrFinishedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  }
  return s;
}

public static Func<EN_1710c672f4d7138b664ee1411114271eEntityRecord, ssConectaProveedores.RestRecords.RESTEN_1710c672f4d7138b664ee1411114271eEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_1710c672f4d7138b664ee1411114271eEntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_1710c672f4d7138b664ee1411114271eEntityRecord FromStructure(EN_1710c672f4d7138b664ee1411114271eEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_1710c672f4d7138b664ee1411114271eEntityRecord(s, config);
}

}


