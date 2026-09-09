using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// Text
public class JSONST_1f76dfa138680efe9e5e11deb3c828b8Structure : AbstractRESTStructure<ST_1f76dfa138680efe9e5e11deb3c828b8Structure> {
[JsonProperty("Value")]
[JsonPropertyName("Value")]
public string AttrValue;

public JSONST_1f76dfa138680efe9e5e11deb3c828b8Structure() { }

public JSONST_1f76dfa138680efe9e5e11deb3c828b8Structure (ST_1f76dfa138680efe9e5e11deb3c828b8Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrValue = ConvertToRestWithoutDefaults(s.ssValue, "");
  } else {
AttrValue = s.ssValue;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_1f76dfa138680efe9e5e11deb3c828b8Structure, ST_1f76dfa138680efe9e5e11deb3c828b8Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_1f76dfa138680efe9e5e11deb3c828b8Structure s) => ToStructure(s, config);
}
public static ST_1f76dfa138680efe9e5e11deb3c828b8Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_1f76dfa138680efe9e5e11deb3c828b8Structure obj, IBehaviorsConfiguration config) { 
  ST_1f76dfa138680efe9e5e11deb3c828b8Structure s = new ST_1f76dfa138680efe9e5e11deb3c828b8Structure();
  if(obj != null) {
  s.ssValue = obj.AttrValue == null ? "" : obj.AttrValue;
  }
  return s;
}

public static Func<ST_1f76dfa138680efe9e5e11deb3c828b8Structure, ssConectaProveedores.RestRecords.JSONST_1f76dfa138680efe9e5e11deb3c828b8Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_1f76dfa138680efe9e5e11deb3c828b8Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_1f76dfa138680efe9e5e11deb3c828b8Structure FromStructure(ST_1f76dfa138680efe9e5e11deb3c828b8Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_1f76dfa138680efe9e5e11deb3c828b8Structure(s, config);
}

}


