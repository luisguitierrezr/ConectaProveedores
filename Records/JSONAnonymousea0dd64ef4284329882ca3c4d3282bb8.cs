using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// TotalPriceSumRecord
public class JSONRC_6f342358c6e90ab9a2abcb1c749e0ce3 : AbstractRESTStructure<RC_6f342358c6e90ab9a2abcb1c749e0ce3> {
[JsonProperty("TotalPriceSum")]
[JsonPropertyName("TotalPriceSum")]
public decimal? AttrTotalPriceSum;

public JSONRC_6f342358c6e90ab9a2abcb1c749e0ce3() { }

public JSONRC_6f342358c6e90ab9a2abcb1c749e0ce3 (RC_6f342358c6e90ab9a2abcb1c749e0ce3 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrTotalPriceSum = ConvertToRestWithoutDefaults(s.ssTotalPriceSum, 0.0M);
  } else {
AttrTotalPriceSum = (decimal?) s.ssTotalPriceSum;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_6f342358c6e90ab9a2abcb1c749e0ce3, RC_6f342358c6e90ab9a2abcb1c749e0ce3> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_6f342358c6e90ab9a2abcb1c749e0ce3 s) => ToStructure(s, config);
}
public static RC_6f342358c6e90ab9a2abcb1c749e0ce3 ToStructure(ssConectaProveedores.RestRecords.JSONRC_6f342358c6e90ab9a2abcb1c749e0ce3 obj, IBehaviorsConfiguration config) { 
  RC_6f342358c6e90ab9a2abcb1c749e0ce3 s = new RC_6f342358c6e90ab9a2abcb1c749e0ce3();
  if(obj != null) {
  s.ssTotalPriceSum = obj.AttrTotalPriceSum == null ? 0.0M : obj.AttrTotalPriceSum.Value;
  }
  return s;
}

public static Func<RC_6f342358c6e90ab9a2abcb1c749e0ce3, ssConectaProveedores.RestRecords.JSONRC_6f342358c6e90ab9a2abcb1c749e0ce3> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_6f342358c6e90ab9a2abcb1c749e0ce3 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_6f342358c6e90ab9a2abcb1c749e0ce3 FromStructure(RC_6f342358c6e90ab9a2abcb1c749e0ce3 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_6f342358c6e90ab9a2abcb1c749e0ce3(s, config);
}

}


