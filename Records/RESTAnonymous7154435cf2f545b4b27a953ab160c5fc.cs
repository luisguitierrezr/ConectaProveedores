using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrdersRequestRecord
public class RESTRC_b58bb1464cbfe8396a13ee4355d45880 : AbstractRESTStructure<RC_b58bb1464cbfe8396a13ee4355d45880> {
[JsonProperty("OrdersRequest")]
public ssConectaProveedores.RestRecords.RESTST_9c87dd52bd762501ef8a064794927f08Structure AttrOrdersRequest;

public RESTRC_b58bb1464cbfe8396a13ee4355d45880() { }

public RESTRC_b58bb1464cbfe8396a13ee4355d45880 (RC_b58bb1464cbfe8396a13ee4355d45880 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrdersRequest = ConvertToRestWithoutDefaults(s.ssSTOrdersRequest, new ST_9c87dd52bd762501ef8a064794927f08Structure(), ssConectaProveedores.RestRecords.RESTST_9c87dd52bd762501ef8a064794927f08Structure.FromStructure, config);
  } else {
AttrOrdersRequest = ssConectaProveedores.RestRecords.RESTST_9c87dd52bd762501ef8a064794927f08Structure.FromStructure(s.ssSTOrdersRequest, config);
  }
}

public static RC_b58bb1464cbfe8396a13ee4355d45880 ToStructure(ssConectaProveedores.RestRecords.RESTRC_b58bb1464cbfe8396a13ee4355d45880 obj) { 
  RC_b58bb1464cbfe8396a13ee4355d45880 s = new RC_b58bb1464cbfe8396a13ee4355d45880();
  if(obj != null) {
  s.ssSTOrdersRequest = ssConectaProveedores.RestRecords.RESTST_9c87dd52bd762501ef8a064794927f08Structure.ToStructure(obj.AttrOrdersRequest);
  }
  return s;
}

public static Func<RC_b58bb1464cbfe8396a13ee4355d45880, ssConectaProveedores.RestRecords.RESTRC_b58bb1464cbfe8396a13ee4355d45880> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_b58bb1464cbfe8396a13ee4355d45880 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_b58bb1464cbfe8396a13ee4355d45880 FromStructure(RC_b58bb1464cbfe8396a13ee4355d45880 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_b58bb1464cbfe8396a13ee4355d45880(s, config);
}

}


