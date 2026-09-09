using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrdersToConsultReportRecord
public class JSONRC_3b7b8fb2298150c3f700b016b10ccf3a : AbstractRESTStructure<RC_3b7b8fb2298150c3f700b016b10ccf3a> {
[JsonProperty("OrdersToConsultReport")]
[JsonPropertyName("OrdersToConsultReport")]
public ssConectaProveedores.RestRecords.JSONST_dd2f99ddb27fc3276d14217f47cde22fStructure AttrOrdersToConsultReport;

public JSONRC_3b7b8fb2298150c3f700b016b10ccf3a() { }

public JSONRC_3b7b8fb2298150c3f700b016b10ccf3a (RC_3b7b8fb2298150c3f700b016b10ccf3a s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrdersToConsultReport = ConvertToRestWithoutDefaults(s.ssSTOrdersToConsultReport, new ST_dd2f99ddb27fc3276d14217f47cde22fStructure(), ssConectaProveedores.RestRecords.JSONST_dd2f99ddb27fc3276d14217f47cde22fStructure.FromStructure, config);
  } else {
AttrOrdersToConsultReport = ssConectaProveedores.RestRecords.JSONST_dd2f99ddb27fc3276d14217f47cde22fStructure.FromStructure(s.ssSTOrdersToConsultReport, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_3b7b8fb2298150c3f700b016b10ccf3a, RC_3b7b8fb2298150c3f700b016b10ccf3a> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_3b7b8fb2298150c3f700b016b10ccf3a s) => ToStructure(s, config);
}
public static RC_3b7b8fb2298150c3f700b016b10ccf3a ToStructure(ssConectaProveedores.RestRecords.JSONRC_3b7b8fb2298150c3f700b016b10ccf3a obj, IBehaviorsConfiguration config) { 
  RC_3b7b8fb2298150c3f700b016b10ccf3a s = new RC_3b7b8fb2298150c3f700b016b10ccf3a();
  if(obj != null) {
  s.ssSTOrdersToConsultReport = ssConectaProveedores.RestRecords.JSONST_dd2f99ddb27fc3276d14217f47cde22fStructure.ToStructure(obj.AttrOrdersToConsultReport, config);
  }
  return s;
}

public static Func<RC_3b7b8fb2298150c3f700b016b10ccf3a, ssConectaProveedores.RestRecords.JSONRC_3b7b8fb2298150c3f700b016b10ccf3a> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_3b7b8fb2298150c3f700b016b10ccf3a s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_3b7b8fb2298150c3f700b016b10ccf3a FromStructure(RC_3b7b8fb2298150c3f700b016b10ccf3a s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_3b7b8fb2298150c3f700b016b10ccf3a(s, config);
}

}


