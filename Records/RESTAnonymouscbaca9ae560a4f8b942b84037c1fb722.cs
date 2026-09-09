using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderServiceRecord
public class RESTRC_aaba1a35921d1afc1af21b1865cba418 : AbstractRESTStructure<RC_aaba1a35921d1afc1af21b1865cba418> {
[JsonProperty("OrderService")]
public ssConectaProveedores.RestRecords.RESTEN_476685ea0a242c4f2681d09188dc12dfEntityRecord AttrOrderService;

public RESTRC_aaba1a35921d1afc1af21b1865cba418() { }

public RESTRC_aaba1a35921d1afc1af21b1865cba418 (RC_aaba1a35921d1afc1af21b1865cba418 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderService = ConvertToRestWithoutDefaults(s.ssENOrderService, new EN_476685ea0a242c4f2681d09188dc12dfEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_476685ea0a242c4f2681d09188dc12dfEntityRecord.FromStructure, config);
  } else {
AttrOrderService = ssConectaProveedores.RestRecords.RESTEN_476685ea0a242c4f2681d09188dc12dfEntityRecord.FromStructure(s.ssENOrderService, config);
  }
}

public static RC_aaba1a35921d1afc1af21b1865cba418 ToStructure(ssConectaProveedores.RestRecords.RESTRC_aaba1a35921d1afc1af21b1865cba418 obj) { 
  RC_aaba1a35921d1afc1af21b1865cba418 s = new RC_aaba1a35921d1afc1af21b1865cba418();
  if(obj != null) {
  s.ssENOrderService = ssConectaProveedores.RestRecords.RESTEN_476685ea0a242c4f2681d09188dc12dfEntityRecord.ToStructure(obj.AttrOrderService);
  }
  return s;
}

public static Func<RC_aaba1a35921d1afc1af21b1865cba418, ssConectaProveedores.RestRecords.RESTRC_aaba1a35921d1afc1af21b1865cba418> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_aaba1a35921d1afc1af21b1865cba418 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_aaba1a35921d1afc1af21b1865cba418 FromStructure(RC_aaba1a35921d1afc1af21b1865cba418 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_aaba1a35921d1afc1af21b1865cba418(s, config);
}

}


