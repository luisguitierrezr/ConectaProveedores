using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// users2
public class RESTST_06cbd1286b150e2e79c91e9d1ed3d811Structure : AbstractRESTStructure<ST_06cbd1286b150e2e79c91e9d1ed3d811Structure> {
[JsonProperty("liststring")]
public string Attrliststring;

[JsonProperty("categoryclass")]
public string Attrcategoryclass;

public RESTST_06cbd1286b150e2e79c91e9d1ed3d811Structure() { }

public RESTST_06cbd1286b150e2e79c91e9d1ed3d811Structure (ST_06cbd1286b150e2e79c91e9d1ed3d811Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
Attrliststring = ConvertToRestWithoutDefaults(s.ssliststring, "");
Attrcategoryclass = s.sscategoryclass;
  } else {
Attrliststring = s.ssliststring;
Attrcategoryclass = s.sscategoryclass;
  }
}

public static ST_06cbd1286b150e2e79c91e9d1ed3d811Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_06cbd1286b150e2e79c91e9d1ed3d811Structure obj) { 
  ST_06cbd1286b150e2e79c91e9d1ed3d811Structure s = new ST_06cbd1286b150e2e79c91e9d1ed3d811Structure();
  if(obj != null) {
  s.ssliststring = obj.Attrliststring == null ? "" : obj.Attrliststring;
  s.sscategoryclass = obj.Attrcategoryclass == null ? "" : obj.Attrcategoryclass;
  }
  return s;
}

public static Func<ST_06cbd1286b150e2e79c91e9d1ed3d811Structure, ssConectaProveedores.RestRecords.RESTST_06cbd1286b150e2e79c91e9d1ed3d811Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_06cbd1286b150e2e79c91e9d1ed3d811Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_06cbd1286b150e2e79c91e9d1ed3d811Structure FromStructure(ST_06cbd1286b150e2e79c91e9d1ed3d811Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_06cbd1286b150e2e79c91e9d1ed3d811Structure(s, config);
}

}


