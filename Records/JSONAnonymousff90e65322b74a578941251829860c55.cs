using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// SeriesStylingRecord
public class JSONRC_b433f1b3ae72f9da85b20eb8b0abb0e8 : AbstractRESTStructure<RC_b433f1b3ae72f9da85b20eb8b0abb0e8> {
[JsonProperty("SeriesStyling")]
[JsonPropertyName("SeriesStyling")]
public ssConectaProveedores.RestRecords.JSONST_6bed431434274b65c17cd0339b1ecaa5Structure AttrSeriesStyling;

public JSONRC_b433f1b3ae72f9da85b20eb8b0abb0e8() { }

public JSONRC_b433f1b3ae72f9da85b20eb8b0abb0e8 (RC_b433f1b3ae72f9da85b20eb8b0abb0e8 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSeriesStyling = ConvertToRestWithoutDefaults(s.ssSTSeriesStyling, new ST_6bed431434274b65c17cd0339b1ecaa5Structure(), ssConectaProveedores.RestRecords.JSONST_6bed431434274b65c17cd0339b1ecaa5Structure.FromStructure, config);
  } else {
AttrSeriesStyling = ssConectaProveedores.RestRecords.JSONST_6bed431434274b65c17cd0339b1ecaa5Structure.FromStructure(s.ssSTSeriesStyling, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_b433f1b3ae72f9da85b20eb8b0abb0e8, RC_b433f1b3ae72f9da85b20eb8b0abb0e8> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_b433f1b3ae72f9da85b20eb8b0abb0e8 s) => ToStructure(s, config);
}
public static RC_b433f1b3ae72f9da85b20eb8b0abb0e8 ToStructure(ssConectaProveedores.RestRecords.JSONRC_b433f1b3ae72f9da85b20eb8b0abb0e8 obj, IBehaviorsConfiguration config) { 
  RC_b433f1b3ae72f9da85b20eb8b0abb0e8 s = new RC_b433f1b3ae72f9da85b20eb8b0abb0e8();
  if(obj != null) {
  s.ssSTSeriesStyling = ssConectaProveedores.RestRecords.JSONST_6bed431434274b65c17cd0339b1ecaa5Structure.ToStructure(obj.AttrSeriesStyling, config);
  }
  return s;
}

public static Func<RC_b433f1b3ae72f9da85b20eb8b0abb0e8, ssConectaProveedores.RestRecords.JSONRC_b433f1b3ae72f9da85b20eb8b0abb0e8> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_b433f1b3ae72f9da85b20eb8b0abb0e8 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_b433f1b3ae72f9da85b20eb8b0abb0e8 FromStructure(RC_b433f1b3ae72f9da85b20eb8b0abb0e8 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_b433f1b3ae72f9da85b20eb8b0abb0e8(s, config);
}

}


