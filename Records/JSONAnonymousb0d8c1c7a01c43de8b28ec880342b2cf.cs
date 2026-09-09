using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// VideoStateRecord
public class JSONRC_03619642a06de09478f0b8f506c364eb : AbstractRESTStructure<RC_03619642a06de09478f0b8f506c364eb> {
[JsonProperty("VideoState")]
[JsonPropertyName("VideoState")]
public ssConectaProveedores.RestRecords.JSONEN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord AttrVideoState;

public JSONRC_03619642a06de09478f0b8f506c364eb() { }

public JSONRC_03619642a06de09478f0b8f506c364eb (RC_03619642a06de09478f0b8f506c364eb s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrVideoState = ConvertToRestWithoutDefaults(s.ssENVideoState, new EN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord.FromStructure, config);
  } else {
AttrVideoState = ssConectaProveedores.RestRecords.JSONEN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord.FromStructure(s.ssENVideoState, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_03619642a06de09478f0b8f506c364eb, RC_03619642a06de09478f0b8f506c364eb> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_03619642a06de09478f0b8f506c364eb s) => ToStructure(s, config);
}
public static RC_03619642a06de09478f0b8f506c364eb ToStructure(ssConectaProveedores.RestRecords.JSONRC_03619642a06de09478f0b8f506c364eb obj, IBehaviorsConfiguration config) { 
  RC_03619642a06de09478f0b8f506c364eb s = new RC_03619642a06de09478f0b8f506c364eb();
  if(obj != null) {
  s.ssENVideoState = ssConectaProveedores.RestRecords.JSONEN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord.ToStructure(obj.AttrVideoState, config);
  }
  return s;
}

public static Func<RC_03619642a06de09478f0b8f506c364eb, ssConectaProveedores.RestRecords.JSONRC_03619642a06de09478f0b8f506c364eb> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_03619642a06de09478f0b8f506c364eb s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_03619642a06de09478f0b8f506c364eb FromStructure(RC_03619642a06de09478f0b8f506c364eb s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_03619642a06de09478f0b8f506c364eb(s, config);
}

}


