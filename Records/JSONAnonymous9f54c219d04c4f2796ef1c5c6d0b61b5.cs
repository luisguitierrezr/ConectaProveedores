using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// TotalSAPSumRecord
public class JSONRC_eb02c428bfcfe640dd4beef4a47700a4 : AbstractRESTStructure<RC_eb02c428bfcfe640dd4beef4a47700a4> {
[JsonProperty("TotalSAPSum")]
[JsonPropertyName("TotalSAPSum")]
public decimal? AttrTotalSAPSum;

public JSONRC_eb02c428bfcfe640dd4beef4a47700a4() { }

public JSONRC_eb02c428bfcfe640dd4beef4a47700a4 (RC_eb02c428bfcfe640dd4beef4a47700a4 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrTotalSAPSum = ConvertToRestWithoutDefaults(s.ssTotalSAPSum, 0.0M);
  } else {
AttrTotalSAPSum = (decimal?) s.ssTotalSAPSum;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_eb02c428bfcfe640dd4beef4a47700a4, RC_eb02c428bfcfe640dd4beef4a47700a4> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_eb02c428bfcfe640dd4beef4a47700a4 s) => ToStructure(s, config);
}
public static RC_eb02c428bfcfe640dd4beef4a47700a4 ToStructure(ssConectaProveedores.RestRecords.JSONRC_eb02c428bfcfe640dd4beef4a47700a4 obj, IBehaviorsConfiguration config) { 
  RC_eb02c428bfcfe640dd4beef4a47700a4 s = new RC_eb02c428bfcfe640dd4beef4a47700a4();
  if(obj != null) {
  s.ssTotalSAPSum = obj.AttrTotalSAPSum == null ? 0.0M : obj.AttrTotalSAPSum.Value;
  }
  return s;
}

public static Func<RC_eb02c428bfcfe640dd4beef4a47700a4, ssConectaProveedores.RestRecords.JSONRC_eb02c428bfcfe640dd4beef4a47700a4> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_eb02c428bfcfe640dd4beef4a47700a4 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_eb02c428bfcfe640dd4beef4a47700a4 FromStructure(RC_eb02c428bfcfe640dd4beef4a47700a4 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_eb02c428bfcfe640dd4beef4a47700a4(s, config);
}

}


