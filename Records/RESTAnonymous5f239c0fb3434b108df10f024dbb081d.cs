using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// SymbolTotalValueMLSumRecord
public class RESTRC_24005b43e3f3ca8801049bcbbd68ea10 : AbstractRESTStructure<RC_24005b43e3f3ca8801049bcbbd68ea10> {
[JsonProperty("Symbol")]
public string AttrSymbol;

[JsonProperty("TotalValueMLSum")]
public decimal? AttrTotalValueMLSum;

public RESTRC_24005b43e3f3ca8801049bcbbd68ea10() { }

public RESTRC_24005b43e3f3ca8801049bcbbd68ea10 (RC_24005b43e3f3ca8801049bcbbd68ea10 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSymbol = ConvertToRestWithoutDefaults(s.ssSymbol, "");
AttrTotalValueMLSum = ConvertToRestWithoutDefaults(s.ssTotalValueMLSum, 0.0M);
  } else {
AttrSymbol = s.ssSymbol;
AttrTotalValueMLSum = (decimal?) s.ssTotalValueMLSum;
  }
}

public static RC_24005b43e3f3ca8801049bcbbd68ea10 ToStructure(ssConectaProveedores.RestRecords.RESTRC_24005b43e3f3ca8801049bcbbd68ea10 obj) { 
  RC_24005b43e3f3ca8801049bcbbd68ea10 s = new RC_24005b43e3f3ca8801049bcbbd68ea10();
  if(obj != null) {
  s.ssSymbol = obj.AttrSymbol == null ? "" : obj.AttrSymbol;
  s.ssTotalValueMLSum = obj.AttrTotalValueMLSum == null ? 0.0M : obj.AttrTotalValueMLSum.Value;
  }
  return s;
}

public static Func<RC_24005b43e3f3ca8801049bcbbd68ea10, ssConectaProveedores.RestRecords.RESTRC_24005b43e3f3ca8801049bcbbd68ea10> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_24005b43e3f3ca8801049bcbbd68ea10 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_24005b43e3f3ca8801049bcbbd68ea10 FromStructure(RC_24005b43e3f3ca8801049bcbbd68ea10 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_24005b43e3f3ca8801049bcbbd68ea10(s, config);
}

}


