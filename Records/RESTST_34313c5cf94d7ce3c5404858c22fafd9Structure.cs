using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// DataPoint
public class RESTST_34313c5cf94d7ce3c5404858c22fafd9Structure : AbstractRESTStructure<ST_34313c5cf94d7ce3c5404858c22fafd9Structure> {
[JsonProperty("Value")]
public decimal? AttrValue;

[JsonProperty("Label")]
public string AttrLabel;

[JsonProperty("SeriesName")]
public string AttrSeriesName;

[JsonProperty("Color")]
public string AttrColor;

[JsonProperty("Tooltip")]
public string AttrTooltip;

public RESTST_34313c5cf94d7ce3c5404858c22fafd9Structure() { }

public RESTST_34313c5cf94d7ce3c5404858c22fafd9Structure (ST_34313c5cf94d7ce3c5404858c22fafd9Structure s, IBehaviorsConfiguration config) {
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

public static ST_34313c5cf94d7ce3c5404858c22fafd9Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_34313c5cf94d7ce3c5404858c22fafd9Structure obj) { 
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

public static Func<ST_34313c5cf94d7ce3c5404858c22fafd9Structure, ssConectaProveedores.RestRecords.RESTST_34313c5cf94d7ce3c5404858c22fafd9Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_34313c5cf94d7ce3c5404858c22fafd9Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_34313c5cf94d7ce3c5404858c22fafd9Structure FromStructure(ST_34313c5cf94d7ce3c5404858c22fafd9Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_34313c5cf94d7ce3c5404858c22fafd9Structure(s, config);
}

}


