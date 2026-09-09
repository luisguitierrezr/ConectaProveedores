using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// SeriesStyling
public class JSONST_6bed431434274b65c17cd0339b1ecaa5Structure : AbstractRESTStructure<ST_6bed431434274b65c17cd0339b1ecaa5Structure> {
[JsonProperty("FillColor")]
[JsonPropertyName("FillColor")]
public string AttrFillColor;

[JsonProperty("LineColor")]
[JsonPropertyName("LineColor")]
public string AttrLineColor;

[JsonProperty("LineWidth")]
[JsonPropertyName("LineWidth")]
public string AttrLineWidth;

[JsonProperty("Opacity")]
[JsonPropertyName("Opacity")]
public string AttrOpacity;

public JSONST_6bed431434274b65c17cd0339b1ecaa5Structure() { }

public JSONST_6bed431434274b65c17cd0339b1ecaa5Structure (ST_6bed431434274b65c17cd0339b1ecaa5Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFillColor = ConvertToRestWithoutDefaults(s.ssFillColor, "");
AttrLineColor = ConvertToRestWithoutDefaults(s.ssLineColor, "");
AttrLineWidth = ConvertToRestWithoutDefaults(s.ssLineWidth, "");
AttrOpacity = ConvertToRestWithoutDefaults(s.ssOpacity, "");
  } else {
AttrFillColor = s.ssFillColor;
AttrLineColor = s.ssLineColor;
AttrLineWidth = s.ssLineWidth;
AttrOpacity = s.ssOpacity;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_6bed431434274b65c17cd0339b1ecaa5Structure, ST_6bed431434274b65c17cd0339b1ecaa5Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_6bed431434274b65c17cd0339b1ecaa5Structure s) => ToStructure(s, config);
}
public static ST_6bed431434274b65c17cd0339b1ecaa5Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_6bed431434274b65c17cd0339b1ecaa5Structure obj, IBehaviorsConfiguration config) { 
  ST_6bed431434274b65c17cd0339b1ecaa5Structure s = new ST_6bed431434274b65c17cd0339b1ecaa5Structure();
  if(obj != null) {
  s.ssFillColor = obj.AttrFillColor == null ? "" : obj.AttrFillColor;
  s.ssLineColor = obj.AttrLineColor == null ? "" : obj.AttrLineColor;
  s.ssLineWidth = obj.AttrLineWidth == null ? "" : obj.AttrLineWidth;
  s.ssOpacity = obj.AttrOpacity == null ? "" : obj.AttrOpacity;
  }
  return s;
}

public static Func<ST_6bed431434274b65c17cd0339b1ecaa5Structure, ssConectaProveedores.RestRecords.JSONST_6bed431434274b65c17cd0339b1ecaa5Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_6bed431434274b65c17cd0339b1ecaa5Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_6bed431434274b65c17cd0339b1ecaa5Structure FromStructure(ST_6bed431434274b65c17cd0339b1ecaa5Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_6bed431434274b65c17cd0339b1ecaa5Structure(s, config);
}

}


