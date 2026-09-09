using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// SeriesStylingMarkerRecord
public class RESTRC_23f04252aed9962b8ebdb251db000b96 : AbstractRESTStructure<RC_23f04252aed9962b8ebdb251db000b96> {
[JsonProperty("SeriesStylingMarker")]
public ssConectaProveedores.RestRecords.RESTST_73b5287c34f36a04fe003585368d6e1bStructure AttrSeriesStylingMarker;

public RESTRC_23f04252aed9962b8ebdb251db000b96() { }

public RESTRC_23f04252aed9962b8ebdb251db000b96 (RC_23f04252aed9962b8ebdb251db000b96 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSeriesStylingMarker = ConvertToRestWithoutDefaults(s.ssSTSeriesStylingMarker, new ST_73b5287c34f36a04fe003585368d6e1bStructure(), ssConectaProveedores.RestRecords.RESTST_73b5287c34f36a04fe003585368d6e1bStructure.FromStructure, config);
  } else {
AttrSeriesStylingMarker = ssConectaProveedores.RestRecords.RESTST_73b5287c34f36a04fe003585368d6e1bStructure.FromStructure(s.ssSTSeriesStylingMarker, config);
  }
}

public static RC_23f04252aed9962b8ebdb251db000b96 ToStructure(ssConectaProveedores.RestRecords.RESTRC_23f04252aed9962b8ebdb251db000b96 obj) { 
  RC_23f04252aed9962b8ebdb251db000b96 s = new RC_23f04252aed9962b8ebdb251db000b96();
  if(obj != null) {
  s.ssSTSeriesStylingMarker = ssConectaProveedores.RestRecords.RESTST_73b5287c34f36a04fe003585368d6e1bStructure.ToStructure(obj.AttrSeriesStylingMarker);
  }
  return s;
}

public static Func<RC_23f04252aed9962b8ebdb251db000b96, ssConectaProveedores.RestRecords.RESTRC_23f04252aed9962b8ebdb251db000b96> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_23f04252aed9962b8ebdb251db000b96 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_23f04252aed9962b8ebdb251db000b96 FromStructure(RC_23f04252aed9962b8ebdb251db000b96 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_23f04252aed9962b8ebdb251db000b96(s, config);
}

}


