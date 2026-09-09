using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderItemLineRecord
public class RESTRC_29185b1ce9f3c243b59d0d98b65d335e : AbstractRESTStructure<RC_29185b1ce9f3c243b59d0d98b65d335e> {
[JsonProperty("OrderItemLine")]
public ssConectaProveedores.RestRecords.RESTST_602b1becf0e261abf8529c8c55991799Structure AttrOrderItemLine;

public RESTRC_29185b1ce9f3c243b59d0d98b65d335e() { }

public RESTRC_29185b1ce9f3c243b59d0d98b65d335e (RC_29185b1ce9f3c243b59d0d98b65d335e s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderItemLine = ConvertToRestWithoutDefaults(s.ssSTOrderItemLine, new ST_602b1becf0e261abf8529c8c55991799Structure(), ssConectaProveedores.RestRecords.RESTST_602b1becf0e261abf8529c8c55991799Structure.FromStructure, config);
  } else {
AttrOrderItemLine = ssConectaProveedores.RestRecords.RESTST_602b1becf0e261abf8529c8c55991799Structure.FromStructure(s.ssSTOrderItemLine, config);
  }
}

public static RC_29185b1ce9f3c243b59d0d98b65d335e ToStructure(ssConectaProveedores.RestRecords.RESTRC_29185b1ce9f3c243b59d0d98b65d335e obj) { 
  RC_29185b1ce9f3c243b59d0d98b65d335e s = new RC_29185b1ce9f3c243b59d0d98b65d335e();
  if(obj != null) {
  s.ssSTOrderItemLine = ssConectaProveedores.RestRecords.RESTST_602b1becf0e261abf8529c8c55991799Structure.ToStructure(obj.AttrOrderItemLine);
  }
  return s;
}

public static Func<RC_29185b1ce9f3c243b59d0d98b65d335e, ssConectaProveedores.RestRecords.RESTRC_29185b1ce9f3c243b59d0d98b65d335e> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_29185b1ce9f3c243b59d0d98b65d335e s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_29185b1ce9f3c243b59d0d98b65d335e FromStructure(RC_29185b1ce9f3c243b59d0d98b65d335e s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_29185b1ce9f3c243b59d0d98b65d335e(s, config);
}

}


