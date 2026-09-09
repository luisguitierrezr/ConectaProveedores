using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// PostTokenResponseRecord
public class JSONRC_b0983648bb0746c42aeb09b62ccb0add : AbstractRESTStructure<RC_b0983648bb0746c42aeb09b62ccb0add> {
[JsonProperty("PostTokenResponse")]
[JsonPropertyName("PostTokenResponse")]
public ssConectaProveedores.RestRecords.JSONST_d5188f28891fd075d6bc1034899cfadeStructure AttrPostTokenResponse;

public JSONRC_b0983648bb0746c42aeb09b62ccb0add() { }

public JSONRC_b0983648bb0746c42aeb09b62ccb0add (RC_b0983648bb0746c42aeb09b62ccb0add s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPostTokenResponse = ConvertToRestWithoutDefaults(s.ssSTPostTokenResponse, new ST_d5188f28891fd075d6bc1034899cfadeStructure(), ssConectaProveedores.RestRecords.JSONST_d5188f28891fd075d6bc1034899cfadeStructure.FromStructure, config);
  } else {
AttrPostTokenResponse = ssConectaProveedores.RestRecords.JSONST_d5188f28891fd075d6bc1034899cfadeStructure.FromStructure(s.ssSTPostTokenResponse, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_b0983648bb0746c42aeb09b62ccb0add, RC_b0983648bb0746c42aeb09b62ccb0add> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_b0983648bb0746c42aeb09b62ccb0add s) => ToStructure(s, config);
}
public static RC_b0983648bb0746c42aeb09b62ccb0add ToStructure(ssConectaProveedores.RestRecords.JSONRC_b0983648bb0746c42aeb09b62ccb0add obj, IBehaviorsConfiguration config) { 
  RC_b0983648bb0746c42aeb09b62ccb0add s = new RC_b0983648bb0746c42aeb09b62ccb0add();
  if(obj != null) {
  s.ssSTPostTokenResponse = ssConectaProveedores.RestRecords.JSONST_d5188f28891fd075d6bc1034899cfadeStructure.ToStructure(obj.AttrPostTokenResponse, config);
  }
  return s;
}

public static Func<RC_b0983648bb0746c42aeb09b62ccb0add, ssConectaProveedores.RestRecords.JSONRC_b0983648bb0746c42aeb09b62ccb0add> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_b0983648bb0746c42aeb09b62ccb0add s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_b0983648bb0746c42aeb09b62ccb0add FromStructure(RC_b0983648bb0746c42aeb09b62ccb0add s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_b0983648bb0746c42aeb09b62ccb0add(s, config);
}

}


