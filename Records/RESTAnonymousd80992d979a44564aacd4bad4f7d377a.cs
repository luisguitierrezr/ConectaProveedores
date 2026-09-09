using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderStatusRecord
public class RESTRC_919d72dc5292e812597af4fac0a808e4 : AbstractRESTStructure<RC_919d72dc5292e812597af4fac0a808e4> {
[JsonProperty("OrderStatus")]
public ssConectaProveedores.RestRecords.RESTEN_5eda60810da752f579e01795bb7e0de0EntityRecord AttrOrderStatus;

public RESTRC_919d72dc5292e812597af4fac0a808e4() { }

public RESTRC_919d72dc5292e812597af4fac0a808e4 (RC_919d72dc5292e812597af4fac0a808e4 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderStatus = ConvertToRestWithoutDefaults(s.ssENOrderStatus, new EN_5eda60810da752f579e01795bb7e0de0EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_5eda60810da752f579e01795bb7e0de0EntityRecord.FromStructure, config);
  } else {
AttrOrderStatus = ssConectaProveedores.RestRecords.RESTEN_5eda60810da752f579e01795bb7e0de0EntityRecord.FromStructure(s.ssENOrderStatus, config);
  }
}

public static RC_919d72dc5292e812597af4fac0a808e4 ToStructure(ssConectaProveedores.RestRecords.RESTRC_919d72dc5292e812597af4fac0a808e4 obj) { 
  RC_919d72dc5292e812597af4fac0a808e4 s = new RC_919d72dc5292e812597af4fac0a808e4();
  if(obj != null) {
  s.ssENOrderStatus = ssConectaProveedores.RestRecords.RESTEN_5eda60810da752f579e01795bb7e0de0EntityRecord.ToStructure(obj.AttrOrderStatus);
  }
  return s;
}

public static Func<RC_919d72dc5292e812597af4fac0a808e4, ssConectaProveedores.RestRecords.RESTRC_919d72dc5292e812597af4fac0a808e4> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_919d72dc5292e812597af4fac0a808e4 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_919d72dc5292e812597af4fac0a808e4 FromStructure(RC_919d72dc5292e812597af4fac0a808e4 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_919d72dc5292e812597af4fac0a808e4(s, config);
}

}


