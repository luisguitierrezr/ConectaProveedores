using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// Result
public class JSONST_38509e9fbd36a9b928c2f4e34a1342aeStructure : AbstractRESTStructure<ST_38509e9fbd36a9b928c2f4e34a1342aeStructure> {
[JsonProperty("IsSuccess")]
[JsonPropertyName("IsSuccess")]
public bool? AttrIsSuccess;

[JsonProperty("ErrorMessage")]
[JsonPropertyName("ErrorMessage")]
public string AttrErrorMessage;

public JSONST_38509e9fbd36a9b928c2f4e34a1342aeStructure() { }

public JSONST_38509e9fbd36a9b928c2f4e34a1342aeStructure (ST_38509e9fbd36a9b928c2f4e34a1342aeStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrIsSuccess = ConvertToRestWithoutDefaults(s.ssIsSuccess, false);
AttrErrorMessage = ConvertToRestWithoutDefaults(s.ssErrorMessage, "");
  } else {
AttrIsSuccess = (bool?) s.ssIsSuccess;
AttrErrorMessage = s.ssErrorMessage;
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_38509e9fbd36a9b928c2f4e34a1342aeStructure, ST_38509e9fbd36a9b928c2f4e34a1342aeStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_38509e9fbd36a9b928c2f4e34a1342aeStructure s) => ToStructure(s, config);
}
public static ST_38509e9fbd36a9b928c2f4e34a1342aeStructure ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_38509e9fbd36a9b928c2f4e34a1342aeStructure obj, IBehaviorsConfiguration config) { 
  ST_38509e9fbd36a9b928c2f4e34a1342aeStructure s = new ST_38509e9fbd36a9b928c2f4e34a1342aeStructure();
  if(obj != null) {
  s.ssIsSuccess = obj.AttrIsSuccess == null ? false : obj.AttrIsSuccess.Value;
  s.ssErrorMessage = obj.AttrErrorMessage == null ? "" : obj.AttrErrorMessage;
  }
  return s;
}

public static Func<ST_38509e9fbd36a9b928c2f4e34a1342aeStructure, ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_38509e9fbd36a9b928c2f4e34a1342aeStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_38509e9fbd36a9b928c2f4e34a1342aeStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_38509e9fbd36a9b928c2f4e34a1342aeStructure FromStructure(ST_38509e9fbd36a9b928c2f4e34a1342aeStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_38509e9fbd36a9b928c2f4e34a1342aeStructure(s, config);
}

}


