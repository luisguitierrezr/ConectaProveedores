using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// Valid
public class JSONST_b453bea0930035904f55a74692afd3a8Structure : AbstractRESTStructure<ST_b453bea0930035904f55a74692afd3a8Structure> {
[JsonProperty("IsValid")]
[JsonPropertyName("IsValid")]
public bool? AttrIsValid;

[JsonProperty("ValidationMessage")]
[JsonPropertyName("ValidationMessage")]
public string AttrValidationMessage;

public JSONST_b453bea0930035904f55a74692afd3a8Structure() { }

public JSONST_b453bea0930035904f55a74692afd3a8Structure (ST_b453bea0930035904f55a74692afd3a8Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrIsValid = ConvertToRestWithoutDefaults(s.ssIsValid, true);
AttrValidationMessage = ConvertToRestWithoutDefaults(s.ssValidationMessage, "");
  } else {
AttrIsValid = (bool?) s.ssIsValid;
AttrValidationMessage = s.ssValidationMessage;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_b453bea0930035904f55a74692afd3a8Structure, ST_b453bea0930035904f55a74692afd3a8Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_b453bea0930035904f55a74692afd3a8Structure s) => ToStructure(s, config);
}
public static ST_b453bea0930035904f55a74692afd3a8Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_b453bea0930035904f55a74692afd3a8Structure obj, IBehaviorsConfiguration config) { 
  ST_b453bea0930035904f55a74692afd3a8Structure s = new ST_b453bea0930035904f55a74692afd3a8Structure();
  if(obj != null) {
  s.ssIsValid = obj.AttrIsValid == null ? true : obj.AttrIsValid.Value;
  s.ssValidationMessage = obj.AttrValidationMessage == null ? "" : obj.AttrValidationMessage;
  }
  return s;
}

public static Func<ST_b453bea0930035904f55a74692afd3a8Structure, ssConectaProveedores.RestRecords.JSONST_b453bea0930035904f55a74692afd3a8Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_b453bea0930035904f55a74692afd3a8Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_b453bea0930035904f55a74692afd3a8Structure FromStructure(ST_b453bea0930035904f55a74692afd3a8Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_b453bea0930035904f55a74692afd3a8Structure(s, config);
}

}


