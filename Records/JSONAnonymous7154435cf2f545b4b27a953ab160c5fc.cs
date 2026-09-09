using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrdersRequestRecord
public class JSONRC_b58bb1464cbfe8396a13ee4355d45880 : AbstractRESTStructure<RC_b58bb1464cbfe8396a13ee4355d45880> {
[JsonProperty("OrdersRequest")]
[JsonPropertyName("OrdersRequest")]
public ssConectaProveedores.RestRecords.JSONST_9c87dd52bd762501ef8a064794927f08Structure AttrOrdersRequest;

public JSONRC_b58bb1464cbfe8396a13ee4355d45880() { }

public JSONRC_b58bb1464cbfe8396a13ee4355d45880 (RC_b58bb1464cbfe8396a13ee4355d45880 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrdersRequest = ConvertToRestWithoutDefaults(s.ssSTOrdersRequest, new ST_9c87dd52bd762501ef8a064794927f08Structure(), ssConectaProveedores.RestRecords.JSONST_9c87dd52bd762501ef8a064794927f08Structure.FromStructure, config);
  } else {
AttrOrdersRequest = ssConectaProveedores.RestRecords.JSONST_9c87dd52bd762501ef8a064794927f08Structure.FromStructure(s.ssSTOrdersRequest, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_b58bb1464cbfe8396a13ee4355d45880, RC_b58bb1464cbfe8396a13ee4355d45880> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_b58bb1464cbfe8396a13ee4355d45880 s) => ToStructure(s, config);
}
public static RC_b58bb1464cbfe8396a13ee4355d45880 ToStructure(ssConectaProveedores.RestRecords.JSONRC_b58bb1464cbfe8396a13ee4355d45880 obj, IBehaviorsConfiguration config) { 
  RC_b58bb1464cbfe8396a13ee4355d45880 s = new RC_b58bb1464cbfe8396a13ee4355d45880();
  if(obj != null) {
  s.ssSTOrdersRequest = ssConectaProveedores.RestRecords.JSONST_9c87dd52bd762501ef8a064794927f08Structure.ToStructure(obj.AttrOrdersRequest, config);
  }
  return s;
}

public static Func<RC_b58bb1464cbfe8396a13ee4355d45880, ssConectaProveedores.RestRecords.JSONRC_b58bb1464cbfe8396a13ee4355d45880> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_b58bb1464cbfe8396a13ee4355d45880 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_b58bb1464cbfe8396a13ee4355d45880 FromStructure(RC_b58bb1464cbfe8396a13ee4355d45880 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_b58bb1464cbfe8396a13ee4355d45880(s, config);
}

}


