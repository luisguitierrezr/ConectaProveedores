using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

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

public static Func<ssConectaProveedores.RestRecords.JSONSTTextStructure, STTextStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONSTTextStructure s) => ToStructure(s, config);
}
public static STTextStructure ToStructure(ssConectaProveedores.RestRecords.JSONSTTextStructure obj, IBehaviorsConfiguration config) { 
  STTextStructure s = new STTextStructure();
  if(obj != null) {
  s.ssValue = obj.AttrValue == null ? "" : obj.AttrValue;
  }
  return s;
}

public static Func<STTextStructure, ssConectaProveedores.RestRecords.JSONSTTextStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (STTextStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONSTTextStructure FromStructure(STTextStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONSTTextStructure(s, config);
}

}


