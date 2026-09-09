using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// Text2
public class JSONSTTextStructure : AbstractRESTStructure<STTextStructure> {
[JsonProperty("Value")]
[JsonPropertyName("Value")]
public string AttrValue;

public JSONSTTextStructure() { }

public JSONSTTextStructure (STTextStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrValue = s.ssValue;
  } else {
AttrValue = s.ssValue;
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONSTTextStructure, STTextStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONSTTextStructure s) => ToStructure(s, config);
}
public static STTextStructure ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONSTTextStructure obj, IBehaviorsConfiguration config) { 
  STTextStructure s = new STTextStructure();
  if(obj != null) {
  s.ssValue = obj.AttrValue == null ? "" : obj.AttrValue;
  }
  return s;
}

public static Func<STTextStructure, ssConectaProveedores.ReferencesProxy.RestRecords.JSONSTTextStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (STTextStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONSTTextStructure FromStructure(STTextStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONSTTextStructure(s, config);
}

}


