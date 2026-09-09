using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// AuditPublicStruc
public class JSONST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure : AbstractRESTStructure<ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure> {
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

[JsonProperty("OccurrenceRoleName")]
[JsonPropertyName("OccurrenceRoleName")]
public string AttrOccurrenceRoleName;

[JsonProperty("IsError")]
[JsonPropertyName("IsError")]
public bool? AttrIsError;

public JSONST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure() { }

public JSONST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure (ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrOrigin = (int?) s.ssOrigin;
AttrIdentifier = (long?) s.ssIdentifier;
AttrMessage = s.ssMessage;
AttrScreen = ConvertToRestWithoutDefaults(s.ssScreen, "");
AttrFunctionality = ConvertToRestWithoutDefaults(s.ssFunctionality, "");
AttrOriginalJSON = ConvertToRestWithoutDefaults(s.ssOriginalJSON, "");
AttrChangeJSON = ConvertToRestWithoutDefaults(s.ssChangeJSON, "");
AttrOccurrenceRoleName = ConvertToRestWithoutDefaults(s.ssOccurrenceRoleName, "");
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
AttrOccurrenceRoleName = s.ssOccurrenceRoleName;
AttrIsError = (bool?) s.ssIsError;
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure, ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure s) => ToStructure(s, config);
}
public static ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure obj, IBehaviorsConfiguration config) { 
  ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure s = new ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssOrigin = obj.AttrOrigin == null ? 0 : obj.AttrOrigin.Value;
  s.ssIdentifier = obj.AttrIdentifier == null ? 0L : obj.AttrIdentifier.Value;
  s.ssMessage = obj.AttrMessage == null ? "" : obj.AttrMessage;
  s.ssScreen = obj.AttrScreen == null ? "" : obj.AttrScreen;
  s.ssFunctionality = obj.AttrFunctionality == null ? "" : obj.AttrFunctionality;
  s.ssOriginalJSON = obj.AttrOriginalJSON == null ? "" : obj.AttrOriginalJSON;
  s.ssChangeJSON = obj.AttrChangeJSON == null ? "" : obj.AttrChangeJSON;
  s.ssOccurrenceRoleName = obj.AttrOccurrenceRoleName == null ? "" : obj.AttrOccurrenceRoleName;
  s.ssIsError = obj.AttrIsError == null ? false : obj.AttrIsError.Value;
  }
  return s;
}

public static Func<ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure, ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure FromStructure(ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure(s, config);
}

}


