using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// DataPoint
public class JSONST_34313c5cf94d7ce3c5404858c22fafd9Structure : AbstractRESTStructure<ST_34313c5cf94d7ce3c5404858c22fafd9Structure> {
[JsonProperty("Value")]
[JsonPropertyName("Value")]
public decimal? AttrValue;

[JsonProperty("Label")]
[JsonPropertyName("Label")]
public string AttrLabel;

[JsonProperty("SeriesName")]
[JsonPropertyName("SeriesName")]
public string AttrSeriesName;

[JsonProperty("Color")]
[JsonPropertyName("Color")]
public string AttrColor;

[JsonProperty("Tooltip")]
[JsonPropertyName("Tooltip")]
public string AttrTooltip;

public JSONST_34313c5cf94d7ce3c5404858c22fafd9Structure() { }

public JSONST_34313c5cf94d7ce3c5404858c22fafd9Structure (ST_34313c5cf94d7ce3c5404858c22fafd9Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrValue = (decimal?) s.ssValue;
AttrLabel = s.ssLabel;
AttrSeriesName = ConvertToRestWithoutDefaults(s.ssSeriesName, "");
AttrColor = ConvertToRestWithoutDefaults(s.ssColor, "");
AttrTooltip = ConvertToRestWithoutDefaults(s.ssTooltip, "");
  } else {
AttrValue = (decimal?) s.ssValue;
AttrLabel = s.ssLabel;
AttrSeriesName = s.ssSeriesName;
AttrColor = s.ssColor;
AttrTooltip = s.ssTooltip;
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_34313c5cf94d7ce3c5404858c22fafd9Structure, ST_34313c5cf94d7ce3c5404858c22fafd9Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_34313c5cf94d7ce3c5404858c22fafd9Structure s) => ToStructure(s, config);
}
public static ST_34313c5cf94d7ce3c5404858c22fafd9Structure ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_34313c5cf94d7ce3c5404858c22fafd9Structure obj, IBehaviorsConfiguration config) { 
  ST_34313c5cf94d7ce3c5404858c22fafd9Structure s = new ST_34313c5cf94d7ce3c5404858c22fafd9Structure();
  if(obj != null) {
  s.ssValue = obj.AttrValue == null ? 0.0M : obj.AttrValue.Value;
  s.ssLabel = obj.AttrLabel == null ? "" : obj.AttrLabel;
  s.ssSeriesName = obj.AttrSeriesName == null ? "" : obj.AttrSeriesName;
  s.ssColor = obj.AttrColor == null ? "" : obj.AttrColor;
  s.ssTooltip = obj.AttrTooltip == null ? "" : obj.AttrTooltip;
  }
  return s;
}

public static Func<ST_34313c5cf94d7ce3c5404858c22fafd9Structure, ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_34313c5cf94d7ce3c5404858c22fafd9Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_34313c5cf94d7ce3c5404858c22fafd9Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_34313c5cf94d7ce3c5404858c22fafd9Structure FromStructure(ST_34313c5cf94d7ce3c5404858c22fafd9Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_34313c5cf94d7ce3c5404858c22fafd9Structure(s, config);
}

}


