using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// Result
public class RESTST_38509e9fbd36a9b928c2f4e34a1342aeStructure : AbstractRESTStructure<ST_38509e9fbd36a9b928c2f4e34a1342aeStructure> {
[JsonProperty("IsSuccess")]
public bool? AttrIsSuccess;

[JsonProperty("ErrorMessage")]
public string AttrErrorMessage;

public RESTST_38509e9fbd36a9b928c2f4e34a1342aeStructure() { }

public RESTST_38509e9fbd36a9b928c2f4e34a1342aeStructure (ST_38509e9fbd36a9b928c2f4e34a1342aeStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrIsSuccess = ConvertToRestWithoutDefaults(s.ssIsSuccess, false);
AttrErrorMessage = ConvertToRestWithoutDefaults(s.ssErrorMessage, "");
  } else {
AttrIsSuccess = (bool?) s.ssIsSuccess;
AttrErrorMessage = s.ssErrorMessage;
  }
}

public static ST_38509e9fbd36a9b928c2f4e34a1342aeStructure ToStructure(ssConectaProveedores.RestRecords.RESTST_38509e9fbd36a9b928c2f4e34a1342aeStructure obj) { 
  ST_38509e9fbd36a9b928c2f4e34a1342aeStructure s = new ST_38509e9fbd36a9b928c2f4e34a1342aeStructure();
  if(obj != null) {
  s.ssIsSuccess = obj.AttrIsSuccess == null ? false : obj.AttrIsSuccess.Value;
  s.ssErrorMessage = obj.AttrErrorMessage == null ? "" : obj.AttrErrorMessage;
  }
  return s;
}

public static Func<ST_38509e9fbd36a9b928c2f4e34a1342aeStructure, ssConectaProveedores.RestRecords.RESTST_38509e9fbd36a9b928c2f4e34a1342aeStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_38509e9fbd36a9b928c2f4e34a1342aeStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_38509e9fbd36a9b928c2f4e34a1342aeStructure FromStructure(ST_38509e9fbd36a9b928c2f4e34a1342aeStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_38509e9fbd36a9b928c2f4e34a1342aeStructure(s, config);
}

}


