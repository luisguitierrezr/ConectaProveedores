using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UniquesCeBeCeCo
public class RESTST_ec742cc5ff3341e853c9929e75681fd0Structure : AbstractRESTStructure<ST_ec742cc5ff3341e853c9929e75681fd0Structure> {
[JsonProperty("CeCo")]
public string AttrCeCo;

[JsonProperty("CeBe")]
public string AttrCeBe;

public RESTST_ec742cc5ff3341e853c9929e75681fd0Structure() { }

public RESTST_ec742cc5ff3341e853c9929e75681fd0Structure (ST_ec742cc5ff3341e853c9929e75681fd0Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCeCo = ConvertToRestWithoutDefaults(s.ssCeCo, "");
AttrCeBe = ConvertToRestWithoutDefaults(s.ssCeBe, "");
  } else {
AttrCeCo = s.ssCeCo;
AttrCeBe = s.ssCeBe;
  }
}

public static ST_ec742cc5ff3341e853c9929e75681fd0Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_ec742cc5ff3341e853c9929e75681fd0Structure obj) { 
  ST_ec742cc5ff3341e853c9929e75681fd0Structure s = new ST_ec742cc5ff3341e853c9929e75681fd0Structure();
  if(obj != null) {
  s.ssCeCo = obj.AttrCeCo == null ? "" : obj.AttrCeCo;
  s.ssCeBe = obj.AttrCeBe == null ? "" : obj.AttrCeBe;
  }
  return s;
}

public static Func<ST_ec742cc5ff3341e853c9929e75681fd0Structure, ssConectaProveedores.RestRecords.RESTST_ec742cc5ff3341e853c9929e75681fd0Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_ec742cc5ff3341e853c9929e75681fd0Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_ec742cc5ff3341e853c9929e75681fd0Structure FromStructure(ST_ec742cc5ff3341e853c9929e75681fd0Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_ec742cc5ff3341e853c9929e75681fd0Structure(s, config);
}

}


