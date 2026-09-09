using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ValueSumRecord
public class JSONRC_8675220d3fe960c67254ae28d587388e : AbstractRESTStructure<RC_8675220d3fe960c67254ae28d587388e> {
[JsonProperty("ValueSum")]
[JsonPropertyName("ValueSum")]
public decimal? AttrValueSum;

public JSONRC_8675220d3fe960c67254ae28d587388e() { }

public JSONRC_8675220d3fe960c67254ae28d587388e (RC_8675220d3fe960c67254ae28d587388e s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrValueSum = ConvertToRestWithoutDefaults(s.ssValueSum, 0.0M);
  } else {
AttrValueSum = (decimal?) s.ssValueSum;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_8675220d3fe960c67254ae28d587388e, RC_8675220d3fe960c67254ae28d587388e> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_8675220d3fe960c67254ae28d587388e s) => ToStructure(s, config);
}
public static RC_8675220d3fe960c67254ae28d587388e ToStructure(ssConectaProveedores.RestRecords.JSONRC_8675220d3fe960c67254ae28d587388e obj, IBehaviorsConfiguration config) { 
  RC_8675220d3fe960c67254ae28d587388e s = new RC_8675220d3fe960c67254ae28d587388e();
  if(obj != null) {
  s.ssValueSum = obj.AttrValueSum == null ? 0.0M : obj.AttrValueSum.Value;
  }
  return s;
}

public static Func<RC_8675220d3fe960c67254ae28d587388e, ssConectaProveedores.RestRecords.JSONRC_8675220d3fe960c67254ae28d587388e> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_8675220d3fe960c67254ae28d587388e s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_8675220d3fe960c67254ae28d587388e FromStructure(RC_8675220d3fe960c67254ae28d587388e s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_8675220d3fe960c67254ae28d587388e(s, config);
}

}


