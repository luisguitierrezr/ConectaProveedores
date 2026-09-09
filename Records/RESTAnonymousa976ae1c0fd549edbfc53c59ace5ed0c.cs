using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// EM_COSMOZ_ResponseRecord
public class RESTRC_de9ad81c85170f7fe0ed05c43c7a0f93 : AbstractRESTStructure<RC_de9ad81c85170f7fe0ed05c43c7a0f93> {
[JsonProperty("EM_COSMOZ_Response")]
public ssConectaProveedores.RestRecords.RESTST_ff65d449d860eb4ed98725735a32f4f3Structure AttrEM_COSMOZ_Response;

public RESTRC_de9ad81c85170f7fe0ed05c43c7a0f93() { }

public RESTRC_de9ad81c85170f7fe0ed05c43c7a0f93 (RC_de9ad81c85170f7fe0ed05c43c7a0f93 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrEM_COSMOZ_Response = ConvertToRestWithoutDefaults(s.ssSTEM_COSMOZ_Response, new ST_ff65d449d860eb4ed98725735a32f4f3Structure(), ssConectaProveedores.RestRecords.RESTST_ff65d449d860eb4ed98725735a32f4f3Structure.FromStructure, config);
  } else {
AttrEM_COSMOZ_Response = ssConectaProveedores.RestRecords.RESTST_ff65d449d860eb4ed98725735a32f4f3Structure.FromStructure(s.ssSTEM_COSMOZ_Response, config);
  }
}

public static RC_de9ad81c85170f7fe0ed05c43c7a0f93 ToStructure(ssConectaProveedores.RestRecords.RESTRC_de9ad81c85170f7fe0ed05c43c7a0f93 obj) { 
  RC_de9ad81c85170f7fe0ed05c43c7a0f93 s = new RC_de9ad81c85170f7fe0ed05c43c7a0f93();
  if(obj != null) {
  s.ssSTEM_COSMOZ_Response = ssConectaProveedores.RestRecords.RESTST_ff65d449d860eb4ed98725735a32f4f3Structure.ToStructure(obj.AttrEM_COSMOZ_Response);
  }
  return s;
}

public static Func<RC_de9ad81c85170f7fe0ed05c43c7a0f93, ssConectaProveedores.RestRecords.RESTRC_de9ad81c85170f7fe0ed05c43c7a0f93> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_de9ad81c85170f7fe0ed05c43c7a0f93 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_de9ad81c85170f7fe0ed05c43c7a0f93 FromStructure(RC_de9ad81c85170f7fe0ed05c43c7a0f93 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_de9ad81c85170f7fe0ed05c43c7a0f93(s, config);
}

}


