using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderServiceRecord
public class JSONRC_aaba1a35921d1afc1af21b1865cba418 : AbstractRESTStructure<RC_aaba1a35921d1afc1af21b1865cba418> {
[JsonProperty("OrderService")]
[JsonPropertyName("OrderService")]
public ssConectaProveedores.RestRecords.JSONEN_476685ea0a242c4f2681d09188dc12dfEntityRecord AttrOrderService;

public JSONRC_aaba1a35921d1afc1af21b1865cba418() { }

public JSONRC_aaba1a35921d1afc1af21b1865cba418 (RC_aaba1a35921d1afc1af21b1865cba418 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderService = ConvertToRestWithoutDefaults(s.ssENOrderService, new EN_476685ea0a242c4f2681d09188dc12dfEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_476685ea0a242c4f2681d09188dc12dfEntityRecord.FromStructure, config);
  } else {
AttrOrderService = ssConectaProveedores.RestRecords.JSONEN_476685ea0a242c4f2681d09188dc12dfEntityRecord.FromStructure(s.ssENOrderService, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_aaba1a35921d1afc1af21b1865cba418, RC_aaba1a35921d1afc1af21b1865cba418> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_aaba1a35921d1afc1af21b1865cba418 s) => ToStructure(s, config);
}
public static RC_aaba1a35921d1afc1af21b1865cba418 ToStructure(ssConectaProveedores.RestRecords.JSONRC_aaba1a35921d1afc1af21b1865cba418 obj, IBehaviorsConfiguration config) { 
  RC_aaba1a35921d1afc1af21b1865cba418 s = new RC_aaba1a35921d1afc1af21b1865cba418();
  if(obj != null) {
  s.ssENOrderService = ssConectaProveedores.RestRecords.JSONEN_476685ea0a242c4f2681d09188dc12dfEntityRecord.ToStructure(obj.AttrOrderService, config);
  }
  return s;
}

public static Func<RC_aaba1a35921d1afc1af21b1865cba418, ssConectaProveedores.RestRecords.JSONRC_aaba1a35921d1afc1af21b1865cba418> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_aaba1a35921d1afc1af21b1865cba418 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_aaba1a35921d1afc1af21b1865cba418 FromStructure(RC_aaba1a35921d1afc1af21b1865cba418 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_aaba1a35921d1afc1af21b1865cba418(s, config);
}

}


