using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// SeriesStylingMarker
public class RESTST_73b5287c34f36a04fe003585368d6e1bStructure : AbstractRESTStructure<ST_73b5287c34f36a04fe003585368d6e1bStructure> {
[JsonProperty("HideMarker")]
public bool? AttrHideMarker;

[JsonProperty("FillColor")]
public string AttrFillColor;

[JsonProperty("BorderColor")]
public string AttrBorderColor;

[JsonProperty("BorderWidth")]
public string AttrBorderWidth;

[JsonProperty("Radius")]
public int? AttrRadius;

[JsonProperty("MarkerSymbol")]
public string AttrMarkerSymbol;

public RESTST_73b5287c34f36a04fe003585368d6e1bStructure() { }

public RESTST_73b5287c34f36a04fe003585368d6e1bStructure (ST_73b5287c34f36a04fe003585368d6e1bStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrHideMarker = ConvertToRestWithoutDefaults(s.ssHideMarker, false);
AttrFillColor = ConvertToRestWithoutDefaults(s.ssFillColor, "");
AttrBorderColor = ConvertToRestWithoutDefaults(s.ssBorderColor, "");
AttrBorderWidth = ConvertToRestWithoutDefaults(s.ssBorderWidth, "");
AttrRadius = ConvertToRestWithoutDefaults(s.ssRadius, 4);
AttrMarkerSymbol = ConvertToRestWithoutDefaults(s.ssMarkerSymbol, "");
  } else {
AttrHideMarker = (bool?) s.ssHideMarker;
AttrFillColor = s.ssFillColor;
AttrBorderColor = s.ssBorderColor;
AttrBorderWidth = s.ssBorderWidth;
AttrRadius = (int?) s.ssRadius;
AttrMarkerSymbol = s.ssMarkerSymbol;
  }
}

public static ST_73b5287c34f36a04fe003585368d6e1bStructure ToStructure(ssConectaProveedores.RestRecords.RESTST_73b5287c34f36a04fe003585368d6e1bStructure obj) { 
  ST_73b5287c34f36a04fe003585368d6e1bStructure s = new ST_73b5287c34f36a04fe003585368d6e1bStructure();
  if(obj != null) {
  s.ssHideMarker = obj.AttrHideMarker == null ? false : obj.AttrHideMarker.Value;
  s.ssFillColor = obj.AttrFillColor == null ? "" : obj.AttrFillColor;
  s.ssBorderColor = obj.AttrBorderColor == null ? "" : obj.AttrBorderColor;
  s.ssBorderWidth = obj.AttrBorderWidth == null ? "" : obj.AttrBorderWidth;
  s.ssRadius = obj.AttrRadius == null ? 4 : obj.AttrRadius.Value;
  s.ssMarkerSymbol = obj.AttrMarkerSymbol == null ? "" : obj.AttrMarkerSymbol;
  }
  return s;
}

public static Func<ST_73b5287c34f36a04fe003585368d6e1bStructure, ssConectaProveedores.RestRecords.RESTST_73b5287c34f36a04fe003585368d6e1bStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_73b5287c34f36a04fe003585368d6e1bStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_73b5287c34f36a04fe003585368d6e1bStructure FromStructure(ST_73b5287c34f36a04fe003585368d6e1bStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_73b5287c34f36a04fe003585368d6e1bStructure(s, config);
}

}


