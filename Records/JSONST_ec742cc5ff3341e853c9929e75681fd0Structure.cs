using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UniquesCeBeCeCo
public class JSONST_ec742cc5ff3341e853c9929e75681fd0Structure : AbstractRESTStructure<ST_ec742cc5ff3341e853c9929e75681fd0Structure> {
[JsonProperty("CeCo")]
[JsonPropertyName("CeCo")]
public string AttrCeCo;

[JsonProperty("CeBe")]
[JsonPropertyName("CeBe")]
public string AttrCeBe;

public JSONST_ec742cc5ff3341e853c9929e75681fd0Structure() { }

public JSONST_ec742cc5ff3341e853c9929e75681fd0Structure (ST_ec742cc5ff3341e853c9929e75681fd0Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCeCo = ConvertToRestWithoutDefaults(s.ssCeCo, "");
AttrCeBe = ConvertToRestWithoutDefaults(s.ssCeBe, "");
  } else {
AttrCeCo = s.ssCeCo;
AttrCeBe = s.ssCeBe;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_ec742cc5ff3341e853c9929e75681fd0Structure, ST_ec742cc5ff3341e853c9929e75681fd0Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_ec742cc5ff3341e853c9929e75681fd0Structure s) => ToStructure(s, config);
}
public static ST_ec742cc5ff3341e853c9929e75681fd0Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_ec742cc5ff3341e853c9929e75681fd0Structure obj, IBehaviorsConfiguration config) { 
  ST_ec742cc5ff3341e853c9929e75681fd0Structure s = new ST_ec742cc5ff3341e853c9929e75681fd0Structure();
  if(obj != null) {
  s.ssCeCo = obj.AttrCeCo == null ? "" : obj.AttrCeCo;
  s.ssCeBe = obj.AttrCeBe == null ? "" : obj.AttrCeBe;
  }
  return s;
}

public static Func<ST_ec742cc5ff3341e853c9929e75681fd0Structure, ssConectaProveedores.RestRecords.JSONST_ec742cc5ff3341e853c9929e75681fd0Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_ec742cc5ff3341e853c9929e75681fd0Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_ec742cc5ff3341e853c9929e75681fd0Structure FromStructure(ST_ec742cc5ff3341e853c9929e75681fd0Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_ec742cc5ff3341e853c9929e75681fd0Structure(s, config);
}

}


