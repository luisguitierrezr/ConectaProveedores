using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// Valid
public class RESTST_b453bea0930035904f55a74692afd3a8Structure : AbstractRESTStructure<ST_b453bea0930035904f55a74692afd3a8Structure> {
[JsonProperty("IsValid")]
public bool? AttrIsValid;

[JsonProperty("ValidationMessage")]
public string AttrValidationMessage;

public RESTST_b453bea0930035904f55a74692afd3a8Structure() { }

public RESTST_b453bea0930035904f55a74692afd3a8Structure (ST_b453bea0930035904f55a74692afd3a8Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrIsValid = ConvertToRestWithoutDefaults(s.ssIsValid, true);
AttrValidationMessage = ConvertToRestWithoutDefaults(s.ssValidationMessage, "");
  } else {
AttrIsValid = (bool?) s.ssIsValid;
AttrValidationMessage = s.ssValidationMessage;
  }
}

public static ST_b453bea0930035904f55a74692afd3a8Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_b453bea0930035904f55a74692afd3a8Structure obj) { 
  ST_b453bea0930035904f55a74692afd3a8Structure s = new ST_b453bea0930035904f55a74692afd3a8Structure();
  if(obj != null) {
  s.ssIsValid = obj.AttrIsValid == null ? true : obj.AttrIsValid.Value;
  s.ssValidationMessage = obj.AttrValidationMessage == null ? "" : obj.AttrValidationMessage;
  }
  return s;
}

public static Func<ST_b453bea0930035904f55a74692afd3a8Structure, ssConectaProveedores.RestRecords.RESTST_b453bea0930035904f55a74692afd3a8Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_b453bea0930035904f55a74692afd3a8Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_b453bea0930035904f55a74692afd3a8Structure FromStructure(ST_b453bea0930035904f55a74692afd3a8Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_b453bea0930035904f55a74692afd3a8Structure(s, config);
}

}


