using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// SeriesStylingMarkerRecord
public class JSONRC_23f04252aed9962b8ebdb251db000b96 : AbstractRESTStructure<RC_23f04252aed9962b8ebdb251db000b96> {
[JsonProperty("SeriesStylingMarker")]
[JsonPropertyName("SeriesStylingMarker")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_73b5287c34f36a04fe003585368d6e1bStructure AttrSeriesStylingMarker;

public JSONRC_23f04252aed9962b8ebdb251db000b96() { }

public JSONRC_23f04252aed9962b8ebdb251db000b96 (RC_23f04252aed9962b8ebdb251db000b96 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSeriesStylingMarker = ConvertToRestWithoutDefaults(s.ssSTSeriesStylingMarker, new ST_73b5287c34f36a04fe003585368d6e1bStructure(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_73b5287c34f36a04fe003585368d6e1bStructure.FromStructure, config);
  } else {
AttrSeriesStylingMarker = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_73b5287c34f36a04fe003585368d6e1bStructure.FromStructure(s.ssSTSeriesStylingMarker, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_23f04252aed9962b8ebdb251db000b96, RC_23f04252aed9962b8ebdb251db000b96> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_23f04252aed9962b8ebdb251db000b96 s) => ToStructure(s, config);
}
public static RC_23f04252aed9962b8ebdb251db000b96 ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_23f04252aed9962b8ebdb251db000b96 obj, IBehaviorsConfiguration config) { 
  RC_23f04252aed9962b8ebdb251db000b96 s = new RC_23f04252aed9962b8ebdb251db000b96();
  if(obj != null) {
  s.ssSTSeriesStylingMarker = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_73b5287c34f36a04fe003585368d6e1bStructure.ToStructure(obj.AttrSeriesStylingMarker, config);
  }
  return s;
}

public static Func<RC_23f04252aed9962b8ebdb251db000b96, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_23f04252aed9962b8ebdb251db000b96> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_23f04252aed9962b8ebdb251db000b96 s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_23f04252aed9962b8ebdb251db000b96 FromStructure(RC_23f04252aed9962b8ebdb251db000b96 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_23f04252aed9962b8ebdb251db000b96(s, config);
}

}


