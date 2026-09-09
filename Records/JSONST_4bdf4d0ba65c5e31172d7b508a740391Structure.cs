using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ChartLegendStyling
public class JSONST_4bdf4d0ba65c5e31172d7b508a740391Structure : AbstractRESTStructure<ST_4bdf4d0ba65c5e31172d7b508a740391Structure> {
[JsonProperty("BackgroundColor")]
[JsonPropertyName("BackgroundColor")]
public string AttrBackgroundColor;

[JsonProperty("ItemsDistance")]
[JsonPropertyName("ItemsDistance")]
public int? AttrItemsDistance;

public JSONST_4bdf4d0ba65c5e31172d7b508a740391Structure() { }

public JSONST_4bdf4d0ba65c5e31172d7b508a740391Structure (ST_4bdf4d0ba65c5e31172d7b508a740391Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrBackgroundColor = ConvertToRestWithoutDefaults(s.ssBackgroundColor, RsseSpaceOutSystemsCharts.DefaultValues.ReferenceStructure_ChartLegendStyling_ReferenceStructureAttribute_BackgroundColor);
AttrItemsDistance = ConvertToRestWithoutDefaults(s.ssItemsDistance, 20);
  } else {
AttrBackgroundColor = s.ssBackgroundColor;
AttrItemsDistance = (int?) s.ssItemsDistance;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_4bdf4d0ba65c5e31172d7b508a740391Structure, ST_4bdf4d0ba65c5e31172d7b508a740391Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_4bdf4d0ba65c5e31172d7b508a740391Structure s) => ToStructure(s, config);
}
public static ST_4bdf4d0ba65c5e31172d7b508a740391Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_4bdf4d0ba65c5e31172d7b508a740391Structure obj, IBehaviorsConfiguration config) { 
  ST_4bdf4d0ba65c5e31172d7b508a740391Structure s = new ST_4bdf4d0ba65c5e31172d7b508a740391Structure();
  if(obj != null) {
  s.ssBackgroundColor = obj.AttrBackgroundColor == null ? RsseSpaceOutSystemsCharts.DefaultValues.ReferenceStructure_ChartLegendStyling_ReferenceStructureAttribute_BackgroundColor : obj.AttrBackgroundColor;
  s.ssItemsDistance = obj.AttrItemsDistance == null ? 20 : obj.AttrItemsDistance.Value;
  }
  return s;
}

public static Func<ST_4bdf4d0ba65c5e31172d7b508a740391Structure, ssConectaProveedores.RestRecords.JSONST_4bdf4d0ba65c5e31172d7b508a740391Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_4bdf4d0ba65c5e31172d7b508a740391Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_4bdf4d0ba65c5e31172d7b508a740391Structure FromStructure(ST_4bdf4d0ba65c5e31172d7b508a740391Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_4bdf4d0ba65c5e31172d7b508a740391Structure(s, config);
}

}


