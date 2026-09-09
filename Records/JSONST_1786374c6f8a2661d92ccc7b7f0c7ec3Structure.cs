using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// AuditStruc4List
public class JSONST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure : AbstractRESTStructure<ST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("Origin")]
[JsonPropertyName("Origin")]
public string AttrOrigin;

[JsonProperty("Identifier")]
[JsonPropertyName("Identifier")]
public long? AttrIdentifier;

[JsonProperty("Message")]
[JsonPropertyName("Message")]
public string AttrMessage;

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

[JsonProperty("IsError")]
[JsonPropertyName("IsError")]
public bool? AttrIsError;

public JSONST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure() { }

public JSONST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure (ST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrOrigin = s.ssOrigin;
AttrIdentifier = (long?) s.ssIdentifier;
AttrMessage = s.ssMessage;
AttrOriginalJSON = ConvertToRestWithoutDefaults(s.ssOriginalJSON, "");
AttrChangeJSON = ConvertToRestWithoutDefaults(s.ssChangeJSON, "");
AttrOccurrenceDateTime = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssOccurrenceDateTime, config.DateTimeFormat);
AttrOccurrenceUser = s.ssOccurrenceUser;
AttrIsError = ConvertToRestWithoutDefaults(s.ssIsError, false);
  } else {
AttrId = (long?) s.ssId;
AttrOrigin = s.ssOrigin;
AttrIdentifier = (long?) s.ssIdentifier;
AttrMessage = s.ssMessage;
AttrOriginalJSON = s.ssOriginalJSON;
AttrChangeJSON = s.ssChangeJSON;
AttrOccurrenceDateTime = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssOccurrenceDateTime, config.DateTimeFormat);
AttrOccurrenceUser = s.ssOccurrenceUser;
AttrIsError = (bool?) s.ssIsError;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure, ST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure s) => ToStructure(s, config);
}
public static ST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure obj, IBehaviorsConfiguration config) { 
  ST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure s = new ST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssOrigin = obj.AttrOrigin == null ? "" : obj.AttrOrigin;
  s.ssIdentifier = obj.AttrIdentifier == null ? 0L : obj.AttrIdentifier.Value;
  s.ssMessage = obj.AttrMessage == null ? "" : obj.AttrMessage;
  s.ssOriginalJSON = obj.AttrOriginalJSON == null ? "" : obj.AttrOriginalJSON;
  s.ssChangeJSON = obj.AttrChangeJSON == null ? "" : obj.AttrChangeJSON;
  s.ssOccurrenceDateTime = obj.AttrOccurrenceDateTime == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrOccurrenceDateTime, config.DateTimeFormat);
  s.ssOccurrenceUser = obj.AttrOccurrenceUser == null ? "" : obj.AttrOccurrenceUser;
  s.ssIsError = obj.AttrIsError == null ? false : obj.AttrIsError.Value;
  }
  return s;
}

public static Func<ST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure, ssConectaProveedores.RestRecords.JSONST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure FromStructure(ST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure(s, config);
}

}


