using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// EM_COSMOZ_ResponseRecord
public class JSONRC_de9ad81c85170f7fe0ed05c43c7a0f93 : AbstractRESTStructure<RC_de9ad81c85170f7fe0ed05c43c7a0f93> {
[JsonProperty("EM_COSMOZ_Response")]
[JsonPropertyName("EM_COSMOZ_Response")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_ff65d449d860eb4ed98725735a32f4f3Structure AttrEM_COSMOZ_Response;

public JSONRC_de9ad81c85170f7fe0ed05c43c7a0f93() { }

public JSONRC_de9ad81c85170f7fe0ed05c43c7a0f93 (RC_de9ad81c85170f7fe0ed05c43c7a0f93 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrEM_COSMOZ_Response = ConvertToRestWithoutDefaults(s.ssSTEM_COSMOZ_Response, new ST_ff65d449d860eb4ed98725735a32f4f3Structure(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_ff65d449d860eb4ed98725735a32f4f3Structure.FromStructure, config);
  } else {
AttrEM_COSMOZ_Response = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_ff65d449d860eb4ed98725735a32f4f3Structure.FromStructure(s.ssSTEM_COSMOZ_Response, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_de9ad81c85170f7fe0ed05c43c7a0f93, RC_de9ad81c85170f7fe0ed05c43c7a0f93> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_de9ad81c85170f7fe0ed05c43c7a0f93 s) => ToStructure(s, config);
}
public static RC_de9ad81c85170f7fe0ed05c43c7a0f93 ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_de9ad81c85170f7fe0ed05c43c7a0f93 obj, IBehaviorsConfiguration config) { 
  RC_de9ad81c85170f7fe0ed05c43c7a0f93 s = new RC_de9ad81c85170f7fe0ed05c43c7a0f93();
  if(obj != null) {
  s.ssSTEM_COSMOZ_Response = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_ff65d449d860eb4ed98725735a32f4f3Structure.ToStructure(obj.AttrEM_COSMOZ_Response, config);
  }
  return s;
}

public static Func<RC_de9ad81c85170f7fe0ed05c43c7a0f93, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_de9ad81c85170f7fe0ed05c43c7a0f93> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_de9ad81c85170f7fe0ed05c43c7a0f93 s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_de9ad81c85170f7fe0ed05c43c7a0f93 FromStructure(RC_de9ad81c85170f7fe0ed05c43c7a0f93 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_de9ad81c85170f7fe0ed05c43c7a0f93(s, config);
}

}


