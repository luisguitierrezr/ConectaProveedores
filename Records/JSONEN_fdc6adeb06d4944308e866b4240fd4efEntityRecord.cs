using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// Audit
public class JSONEN_fdc6adeb06d4944308e866b4240fd4efEntityRecord : AbstractRESTStructure<EN_fdc6adeb06d4944308e866b4240fd4efEntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("Origin")]
[JsonPropertyName("Origin")]
public int? AttrOrigin;

[JsonProperty("Identifier")]
[JsonPropertyName("Identifier")]
public long? AttrIdentifier;

[JsonProperty("Message")]
[JsonPropertyName("Message")]
public string AttrMessage;

[JsonProperty("Screen")]
[JsonPropertyName("Screen")]
public string AttrScreen;

[JsonProperty("Functionality")]
[JsonPropertyName("Functionality")]
public string AttrFunctionality;

[JsonProperty("OriginalJSON")]
[JsonPropertyName("OriginalJSON")]
public string AttrOriginalJSON;

[JsonProperty("ChangeJSON")]
[JsonPropertyName("ChangeJSON")]
public string AttrChangeJSON;

[JsonProperty("OccurrenceDateTime")]
[JsonPropertyName("OccurrenceDateTime")]
public String AttrOccurrenceDateTime;

[JsonProperty("OccurrenceUser")]
[JsonPropertyName("OccurrenceUser")]
public string AttrOccurrenceUser;

[JsonProperty("OccurrenceRoleName")]
[JsonPropertyName("OccurrenceRoleName")]
public string AttrOccurrenceRoleName;

[JsonProperty("AccessIP")]
[JsonPropertyName("AccessIP")]
public string AttrAccessIP;

[JsonProperty("IsError")]
[JsonPropertyName("IsError")]
public bool? AttrIsError;

public JSONEN_fdc6adeb06d4944308e866b4240fd4efEntityRecord() { }

public JSONEN_fdc6adeb06d4944308e866b4240fd4efEntityRecord (EN_fdc6adeb06d4944308e866b4240fd4efEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrOrigin = (int?) s.ssOrigin;
AttrIdentifier = ConvertToRestWithoutDefaults(s.ssIdentifier, 0L);
AttrMessage = s.ssMessage;
AttrScreen = ConvertToRestWithoutDefaults(s.ssScreen, "");
AttrFunctionality = ConvertToRestWithoutDefaults(s.ssFunctionality, "");
AttrOriginalJSON = ConvertToRestWithoutDefaults(s.ssOriginalJSON, "");
AttrChangeJSON = ConvertToRestWithoutDefaults(s.ssChangeJSON, "");
AttrOccurrenceDateTime = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssOccurrenceDateTime, config.DateTimeFormat);
AttrOccurrenceUser = s.ssOccurrenceUser;
AttrOccurrenceRoleName = ConvertToRestWithoutDefaults(s.ssOccurrenceRoleName, "");
AttrAccessIP = ConvertToRestWithoutDefaults(s.ssAccessIP, "");
AttrIsError = ConvertToRestWithoutDefaults(s.ssIsError, false);
  } else {
AttrId = (long?) s.ssId;
AttrOrigin = (int?) s.ssOrigin;
AttrIdentifier = (long?) s.ssIdentifier;
AttrMessage = s.ssMessage;
AttrScreen = s.ssScreen;
AttrFunctionality = s.ssFunctionality;
AttrOriginalJSON = s.ssOriginalJSON;
AttrChangeJSON = s.ssChangeJSON;
AttrOccurrenceDateTime = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssOccurrenceDateTime, config.DateTimeFormat);
AttrOccurrenceUser = s.ssOccurrenceUser;
AttrOccurrenceRoleName = s.ssOccurrenceRoleName;
AttrAccessIP = s.ssAccessIP;
AttrIsError = (bool?) s.ssIsError;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONEN_fdc6adeb06d4944308e866b4240fd4efEntityRecord, EN_fdc6adeb06d4944308e866b4240fd4efEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_fdc6adeb06d4944308e866b4240fd4efEntityRecord s) => ToStructure(s, config);
}
public static EN_fdc6adeb06d4944308e866b4240fd4efEntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_fdc6adeb06d4944308e866b4240fd4efEntityRecord obj, IBehaviorsConfiguration config) { 
  EN_fdc6adeb06d4944308e866b4240fd4efEntityRecord s = new EN_fdc6adeb06d4944308e866b4240fd4efEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssOrigin = obj.AttrOrigin == null ? 0 : obj.AttrOrigin.Value;
  s.ssIdentifier = obj.AttrIdentifier == null ? 0L : obj.AttrIdentifier.Value;
  s.ssMessage = obj.AttrMessage == null ? "" : obj.AttrMessage;
  s.ssScreen = obj.AttrScreen == null ? "" : obj.AttrScreen;
  s.ssFunctionality = obj.AttrFunctionality == null ? "" : obj.AttrFunctionality;
  s.ssOriginalJSON = obj.AttrOriginalJSON == null ? "" : obj.AttrOriginalJSON;
  s.ssChangeJSON = obj.AttrChangeJSON == null ? "" : obj.AttrChangeJSON;
  s.ssOccurrenceDateTime = obj.AttrOccurrenceDateTime == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrOccurrenceDateTime, config.DateTimeFormat);
  s.ssOccurrenceUser = obj.AttrOccurrenceUser == null ? "" : obj.AttrOccurrenceUser;
  s.ssOccurrenceRoleName = obj.AttrOccurrenceRoleName == null ? "" : obj.AttrOccurrenceRoleName;
  s.ssAccessIP = obj.AttrAccessIP == null ? "" : obj.AttrAccessIP;
  s.ssIsError = obj.AttrIsError == null ? false : obj.AttrIsError.Value;
  }
  return s;
}

public static Func<EN_fdc6adeb06d4944308e866b4240fd4efEntityRecord, ssConectaProveedores.RestRecords.JSONEN_fdc6adeb06d4944308e866b4240fd4efEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_fdc6adeb06d4944308e866b4240fd4efEntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_fdc6adeb06d4944308e866b4240fd4efEntityRecord FromStructure(EN_fdc6adeb06d4944308e866b4240fd4efEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_fdc6adeb06d4944308e866b4240fd4efEntityRecord(s, config);
}

}


