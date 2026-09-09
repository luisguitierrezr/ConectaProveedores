using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// SeriesStylingRecord
public class RESTRC_b433f1b3ae72f9da85b20eb8b0abb0e8 : AbstractRESTStructure<RC_b433f1b3ae72f9da85b20eb8b0abb0e8> {
[JsonProperty("SeriesStyling")]
public ssConectaProveedores.RestRecords.RESTST_6bed431434274b65c17cd0339b1ecaa5Structure AttrSeriesStyling;

public RESTRC_b433f1b3ae72f9da85b20eb8b0abb0e8() { }

public RESTRC_b433f1b3ae72f9da85b20eb8b0abb0e8 (RC_b433f1b3ae72f9da85b20eb8b0abb0e8 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSeriesStyling = ConvertToRestWithoutDefaults(s.ssSTSeriesStyling, new ST_6bed431434274b65c17cd0339b1ecaa5Structure(), ssConectaProveedores.RestRecords.RESTST_6bed431434274b65c17cd0339b1ecaa5Structure.FromStructure, config);
  } else {
AttrSeriesStyling = ssConectaProveedores.RestRecords.RESTST_6bed431434274b65c17cd0339b1ecaa5Structure.FromStructure(s.ssSTSeriesStyling, config);
  }
}

public static RC_b433f1b3ae72f9da85b20eb8b0abb0e8 ToStructure(ssConectaProveedores.RestRecords.RESTRC_b433f1b3ae72f9da85b20eb8b0abb0e8 obj) { 
  RC_b433f1b3ae72f9da85b20eb8b0abb0e8 s = new RC_b433f1b3ae72f9da85b20eb8b0abb0e8();
  if(obj != null) {
  s.ssSTSeriesStyling = ssConectaProveedores.RestRecords.RESTST_6bed431434274b65c17cd0339b1ecaa5Structure.ToStructure(obj.AttrSeriesStyling);
  }
  return s;
}

public static Func<RC_b433f1b3ae72f9da85b20eb8b0abb0e8, ssConectaProveedores.RestRecords.RESTRC_b433f1b3ae72f9da85b20eb8b0abb0e8> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_b433f1b3ae72f9da85b20eb8b0abb0e8 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_b433f1b3ae72f9da85b20eb8b0abb0e8 FromStructure(RC_b433f1b3ae72f9da85b20eb8b0abb0e8 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_b433f1b3ae72f9da85b20eb8b0abb0e8(s, config);
}

}


