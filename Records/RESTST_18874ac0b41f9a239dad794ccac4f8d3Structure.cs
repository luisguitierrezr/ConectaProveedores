using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// Decimal
public class RESTST_18874ac0b41f9a239dad794ccac4f8d3Structure : AbstractRESTStructure<ST_18874ac0b41f9a239dad794ccac4f8d3Structure> {
[JsonProperty("Value")]
public decimal? AttrValue;

public RESTST_18874ac0b41f9a239dad794ccac4f8d3Structure() { }

public RESTST_18874ac0b41f9a239dad794ccac4f8d3Structure (ST_18874ac0b41f9a239dad794ccac4f8d3Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrValue = ConvertToRestWithoutDefaults(s.ssValue, 0.0M);
  } else {
AttrValue = (decimal?) s.ssValue;
  }
}

public static ST_18874ac0b41f9a239dad794ccac4f8d3Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_18874ac0b41f9a239dad794ccac4f8d3Structure obj) { 
  ST_18874ac0b41f9a239dad794ccac4f8d3Structure s = new ST_18874ac0b41f9a239dad794ccac4f8d3Structure();
  if(obj != null) {
  s.ssValue = obj.AttrValue == null ? 0.0M : obj.AttrValue.Value;
  }
  return s;
}

public static Func<ST_18874ac0b41f9a239dad794ccac4f8d3Structure, ssConectaProveedores.RestRecords.RESTST_18874ac0b41f9a239dad794ccac4f8d3Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_18874ac0b41f9a239dad794ccac4f8d3Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_18874ac0b41f9a239dad794ccac4f8d3Structure FromStructure(ST_18874ac0b41f9a239dad794ccac4f8d3Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_18874ac0b41f9a239dad794ccac4f8d3Structure(s, config);
}

}


