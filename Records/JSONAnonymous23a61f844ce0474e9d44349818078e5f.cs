using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ChartLegendStylingRecord
public class JSONRC_11e12158254e5be6bde5f4ba88bacb32 : AbstractRESTStructure<RC_11e12158254e5be6bde5f4ba88bacb32> {
[JsonProperty("ChartLegendStyling")]
[JsonPropertyName("ChartLegendStyling")]
public ssConectaProveedores.RestRecords.JSONST_4bdf4d0ba65c5e31172d7b508a740391Structure AttrChartLegendStyling;

public JSONRC_11e12158254e5be6bde5f4ba88bacb32() { }

public JSONRC_11e12158254e5be6bde5f4ba88bacb32 (RC_11e12158254e5be6bde5f4ba88bacb32 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrChartLegendStyling = ConvertToRestWithoutDefaults(s.ssSTChartLegendStyling, new ST_4bdf4d0ba65c5e31172d7b508a740391Structure(), ssConectaProveedores.RestRecords.JSONST_4bdf4d0ba65c5e31172d7b508a740391Structure.FromStructure, config);
  } else {
AttrChartLegendStyling = ssConectaProveedores.RestRecords.JSONST_4bdf4d0ba65c5e31172d7b508a740391Structure.FromStructure(s.ssSTChartLegendStyling, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_11e12158254e5be6bde5f4ba88bacb32, RC_11e12158254e5be6bde5f4ba88bacb32> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_11e12158254e5be6bde5f4ba88bacb32 s) => ToStructure(s, config);
}
public static RC_11e12158254e5be6bde5f4ba88bacb32 ToStructure(ssConectaProveedores.RestRecords.JSONRC_11e12158254e5be6bde5f4ba88bacb32 obj, IBehaviorsConfiguration config) { 
  RC_11e12158254e5be6bde5f4ba88bacb32 s = new RC_11e12158254e5be6bde5f4ba88bacb32();
  if(obj != null) {
  s.ssSTChartLegendStyling = ssConectaProveedores.RestRecords.JSONST_4bdf4d0ba65c5e31172d7b508a740391Structure.ToStructure(obj.AttrChartLegendStyling, config);
  }
  return s;
}

public static Func<RC_11e12158254e5be6bde5f4ba88bacb32, ssConectaProveedores.RestRecords.JSONRC_11e12158254e5be6bde5f4ba88bacb32> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_11e12158254e5be6bde5f4ba88bacb32 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_11e12158254e5be6bde5f4ba88bacb32 FromStructure(RC_11e12158254e5be6bde5f4ba88bacb32 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_11e12158254e5be6bde5f4ba88bacb32(s, config);
}

}


