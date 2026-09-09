using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderItemLineRecord
public class JSONRC_29185b1ce9f3c243b59d0d98b65d335e : AbstractRESTStructure<RC_29185b1ce9f3c243b59d0d98b65d335e> {
[JsonProperty("OrderItemLine")]
[JsonPropertyName("OrderItemLine")]
public ssConectaProveedores.RestRecords.JSONST_602b1becf0e261abf8529c8c55991799Structure AttrOrderItemLine;

public JSONRC_29185b1ce9f3c243b59d0d98b65d335e() { }

public JSONRC_29185b1ce9f3c243b59d0d98b65d335e (RC_29185b1ce9f3c243b59d0d98b65d335e s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderItemLine = ConvertToRestWithoutDefaults(s.ssSTOrderItemLine, new ST_602b1becf0e261abf8529c8c55991799Structure(), ssConectaProveedores.RestRecords.JSONST_602b1becf0e261abf8529c8c55991799Structure.FromStructure, config);
  } else {
AttrOrderItemLine = ssConectaProveedores.RestRecords.JSONST_602b1becf0e261abf8529c8c55991799Structure.FromStructure(s.ssSTOrderItemLine, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_29185b1ce9f3c243b59d0d98b65d335e, RC_29185b1ce9f3c243b59d0d98b65d335e> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_29185b1ce9f3c243b59d0d98b65d335e s) => ToStructure(s, config);
}
public static RC_29185b1ce9f3c243b59d0d98b65d335e ToStructure(ssConectaProveedores.RestRecords.JSONRC_29185b1ce9f3c243b59d0d98b65d335e obj, IBehaviorsConfiguration config) { 
  RC_29185b1ce9f3c243b59d0d98b65d335e s = new RC_29185b1ce9f3c243b59d0d98b65d335e();
  if(obj != null) {
  s.ssSTOrderItemLine = ssConectaProveedores.RestRecords.JSONST_602b1becf0e261abf8529c8c55991799Structure.ToStructure(obj.AttrOrderItemLine, config);
  }
  return s;
}

public static Func<RC_29185b1ce9f3c243b59d0d98b65d335e, ssConectaProveedores.RestRecords.JSONRC_29185b1ce9f3c243b59d0d98b65d335e> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_29185b1ce9f3c243b59d0d98b65d335e s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_29185b1ce9f3c243b59d0d98b65d335e FromStructure(RC_29185b1ce9f3c243b59d0d98b65d335e s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_29185b1ce9f3c243b59d0d98b65d335e(s, config);
}

}


