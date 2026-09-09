using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// StartUpdateEmailFailureReason
public class RESTST_265373b7ea713cad761986e9aec6548dStructure : AbstractRESTStructure<ST_265373b7ea713cad761986e9aec6548dStructure> {
[JsonProperty("InvalidEmail")]
public bool? AttrInvalidEmail;

public RESTST_265373b7ea713cad761986e9aec6548dStructure() { }

public RESTST_265373b7ea713cad761986e9aec6548dStructure (ST_265373b7ea713cad761986e9aec6548dStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvalidEmail = ConvertToRestWithoutDefaults(s.ssInvalidEmail, false);
  } else {
AttrInvalidEmail = (bool?) s.ssInvalidEmail;
  }
}

public static ST_265373b7ea713cad761986e9aec6548dStructure ToStructure(ssConectaProveedores.RestRecords.RESTST_265373b7ea713cad761986e9aec6548dStructure obj) { 
  ST_265373b7ea713cad761986e9aec6548dStructure s = new ST_265373b7ea713cad761986e9aec6548dStructure();
  if(obj != null) {
  s.ssInvalidEmail = obj.AttrInvalidEmail == null ? false : obj.AttrInvalidEmail.Value;
  }
  return s;
}

public static Func<ST_265373b7ea713cad761986e9aec6548dStructure, ssConectaProveedores.RestRecords.RESTST_265373b7ea713cad761986e9aec6548dStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_265373b7ea713cad761986e9aec6548dStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_265373b7ea713cad761986e9aec6548dStructure FromStructure(ST_265373b7ea713cad761986e9aec6548dStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_265373b7ea713cad761986e9aec6548dStructure(s, config);
}

}


