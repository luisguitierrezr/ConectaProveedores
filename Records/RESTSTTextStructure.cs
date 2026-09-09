using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// Text2
public class RESTSTTextStructure : AbstractRESTStructure<STTextStructure> {
[JsonProperty("Value")]
public string AttrValue;

public RESTSTTextStructure() { }

public RESTSTTextStructure (STTextStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrValue = s.ssValue;
  } else {
AttrValue = s.ssValue;
  }
}

public static STTextStructure ToStructure(ssConectaProveedores.RestRecords.RESTSTTextStructure obj) { 
  STTextStructure s = new STTextStructure();
  if(obj != null) {
  s.ssValue = obj.AttrValue == null ? "" : obj.AttrValue;
  }
  return s;
}

public static Func<STTextStructure, ssConectaProveedores.RestRecords.RESTSTTextStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (STTextStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTSTTextStructure FromStructure(STTextStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTSTTextStructure(s, config);
}

}


