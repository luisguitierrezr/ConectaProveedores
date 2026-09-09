using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrdersToConsultReportRecord
public class RESTRC_3b7b8fb2298150c3f700b016b10ccf3a : AbstractRESTStructure<RC_3b7b8fb2298150c3f700b016b10ccf3a> {
[JsonProperty("OrdersToConsultReport")]
public ssConectaProveedores.RestRecords.RESTST_dd2f99ddb27fc3276d14217f47cde22fStructure AttrOrdersToConsultReport;

public RESTRC_3b7b8fb2298150c3f700b016b10ccf3a() { }

public RESTRC_3b7b8fb2298150c3f700b016b10ccf3a (RC_3b7b8fb2298150c3f700b016b10ccf3a s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrdersToConsultReport = ConvertToRestWithoutDefaults(s.ssSTOrdersToConsultReport, new ST_dd2f99ddb27fc3276d14217f47cde22fStructure(), ssConectaProveedores.RestRecords.RESTST_dd2f99ddb27fc3276d14217f47cde22fStructure.FromStructure, config);
  } else {
AttrOrdersToConsultReport = ssConectaProveedores.RestRecords.RESTST_dd2f99ddb27fc3276d14217f47cde22fStructure.FromStructure(s.ssSTOrdersToConsultReport, config);
  }
}

public static RC_3b7b8fb2298150c3f700b016b10ccf3a ToStructure(ssConectaProveedores.RestRecords.RESTRC_3b7b8fb2298150c3f700b016b10ccf3a obj) { 
  RC_3b7b8fb2298150c3f700b016b10ccf3a s = new RC_3b7b8fb2298150c3f700b016b10ccf3a();
  if(obj != null) {
  s.ssSTOrdersToConsultReport = ssConectaProveedores.RestRecords.RESTST_dd2f99ddb27fc3276d14217f47cde22fStructure.ToStructure(obj.AttrOrdersToConsultReport);
  }
  return s;
}

public static Func<RC_3b7b8fb2298150c3f700b016b10ccf3a, ssConectaProveedores.RestRecords.RESTRC_3b7b8fb2298150c3f700b016b10ccf3a> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_3b7b8fb2298150c3f700b016b10ccf3a s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_3b7b8fb2298150c3f700b016b10ccf3a FromStructure(RC_3b7b8fb2298150c3f700b016b10ccf3a s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_3b7b8fb2298150c3f700b016b10ccf3a(s, config);
}

}


