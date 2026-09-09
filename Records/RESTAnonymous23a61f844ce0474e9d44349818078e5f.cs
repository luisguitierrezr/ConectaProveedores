using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ChartLegendStylingRecord
public class RESTRC_11e12158254e5be6bde5f4ba88bacb32 : AbstractRESTStructure<RC_11e12158254e5be6bde5f4ba88bacb32> {
[JsonProperty("ChartLegendStyling")]
public ssConectaProveedores.RestRecords.RESTST_4bdf4d0ba65c5e31172d7b508a740391Structure AttrChartLegendStyling;

public RESTRC_11e12158254e5be6bde5f4ba88bacb32() { }

public RESTRC_11e12158254e5be6bde5f4ba88bacb32 (RC_11e12158254e5be6bde5f4ba88bacb32 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrChartLegendStyling = ConvertToRestWithoutDefaults(s.ssSTChartLegendStyling, new ST_4bdf4d0ba65c5e31172d7b508a740391Structure(), ssConectaProveedores.RestRecords.RESTST_4bdf4d0ba65c5e31172d7b508a740391Structure.FromStructure, config);
  } else {
AttrChartLegendStyling = ssConectaProveedores.RestRecords.RESTST_4bdf4d0ba65c5e31172d7b508a740391Structure.FromStructure(s.ssSTChartLegendStyling, config);
  }
}

public static RC_11e12158254e5be6bde5f4ba88bacb32 ToStructure(ssConectaProveedores.RestRecords.RESTRC_11e12158254e5be6bde5f4ba88bacb32 obj) { 
  RC_11e12158254e5be6bde5f4ba88bacb32 s = new RC_11e12158254e5be6bde5f4ba88bacb32();
  if(obj != null) {
  s.ssSTChartLegendStyling = ssConectaProveedores.RestRecords.RESTST_4bdf4d0ba65c5e31172d7b508a740391Structure.ToStructure(obj.AttrChartLegendStyling);
  }
  return s;
}

public static Func<RC_11e12158254e5be6bde5f4ba88bacb32, ssConectaProveedores.RestRecords.RESTRC_11e12158254e5be6bde5f4ba88bacb32> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_11e12158254e5be6bde5f4ba88bacb32 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_11e12158254e5be6bde5f4ba88bacb32 FromStructure(RC_11e12158254e5be6bde5f4ba88bacb32 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_11e12158254e5be6bde5f4ba88bacb32(s, config);
}

}


