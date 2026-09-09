using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// URLQueryParameter
public class JSONST_f9be77c0ae9485d53ded05b1557548f9Structure : AbstractRESTStructure<ST_f9be77c0ae9485d53ded05b1557548f9Structure> {
[JsonProperty("Name")]
[JsonPropertyName("Name")]
public string AttrName;

[JsonProperty("Value")]
[JsonPropertyName("Value")]
public string AttrValue;

public JSONST_f9be77c0ae9485d53ded05b1557548f9Structure() { }

public JSONST_f9be77c0ae9485d53ded05b1557548f9Structure (ST_f9be77c0ae9485d53ded05b1557548f9Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrName = ConvertToRestWithoutDefaults(s.ssName, "");
AttrValue = ConvertToRestWithoutDefaults(s.ssValue, "");
  } else {
AttrName = s.ssName;
AttrValue = s.ssValue;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_f9be77c0ae9485d53ded05b1557548f9Structure, ST_f9be77c0ae9485d53ded05b1557548f9Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_f9be77c0ae9485d53ded05b1557548f9Structure s) => ToStructure(s, config);
}
public static ST_f9be77c0ae9485d53ded05b1557548f9Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_f9be77c0ae9485d53ded05b1557548f9Structure obj, IBehaviorsConfiguration config) { 
  ST_f9be77c0ae9485d53ded05b1557548f9Structure s = new ST_f9be77c0ae9485d53ded05b1557548f9Structure();
  if(obj != null) {
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  s.ssValue = obj.AttrValue == null ? "" : obj.AttrValue;
  }
  return s;
}

public static Func<ST_f9be77c0ae9485d53ded05b1557548f9Structure, ssConectaProveedores.RestRecords.JSONST_f9be77c0ae9485d53ded05b1557548f9Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_f9be77c0ae9485d53ded05b1557548f9Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_f9be77c0ae9485d53ded05b1557548f9Structure FromStructure(ST_f9be77c0ae9485d53ded05b1557548f9Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_f9be77c0ae9485d53ded05b1557548f9Structure(s, config);
}

}


