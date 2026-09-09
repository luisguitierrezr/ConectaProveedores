using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ActionResult
public class RESTST_9f3831cec6ebd34416b59b8df7a27893Structure : AbstractRESTStructure<ST_9f3831cec6ebd34416b59b8df7a27893Structure> {
[JsonProperty("Identifier")]
public long? AttrIdentifier;

[JsonProperty("HasSuccess")]
public bool? AttrHasSuccess;

[JsonProperty("ErrorMessage")]
public string AttrErrorMessage;

public RESTST_9f3831cec6ebd34416b59b8df7a27893Structure() { }

public RESTST_9f3831cec6ebd34416b59b8df7a27893Structure (ST_9f3831cec6ebd34416b59b8df7a27893Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrIdentifier = ConvertToRestWithoutDefaults(s.ssIdentifier, 0L);
AttrHasSuccess = (bool?) s.ssHasSuccess;
AttrErrorMessage = ConvertToRestWithoutDefaults(s.ssErrorMessage, "");
  } else {
AttrIdentifier = (long?) s.ssIdentifier;
AttrHasSuccess = (bool?) s.ssHasSuccess;
AttrErrorMessage = s.ssErrorMessage;
  }
}

public static ST_9f3831cec6ebd34416b59b8df7a27893Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_9f3831cec6ebd34416b59b8df7a27893Structure obj) { 
  ST_9f3831cec6ebd34416b59b8df7a27893Structure s = new ST_9f3831cec6ebd34416b59b8df7a27893Structure();
  if(obj != null) {
  s.ssIdentifier = obj.AttrIdentifier == null ? 0L : obj.AttrIdentifier.Value;
  s.ssHasSuccess = obj.AttrHasSuccess == null ? false : obj.AttrHasSuccess.Value;
  s.ssErrorMessage = obj.AttrErrorMessage == null ? "" : obj.AttrErrorMessage;
  }
  return s;
}

public static Func<ST_9f3831cec6ebd34416b59b8df7a27893Structure, ssConectaProveedores.RestRecords.RESTST_9f3831cec6ebd34416b59b8df7a27893Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_9f3831cec6ebd34416b59b8df7a27893Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_9f3831cec6ebd34416b59b8df7a27893Structure FromStructure(ST_9f3831cec6ebd34416b59b8df7a27893Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_9f3831cec6ebd34416b59b8df7a27893Structure(s, config);
}

}


