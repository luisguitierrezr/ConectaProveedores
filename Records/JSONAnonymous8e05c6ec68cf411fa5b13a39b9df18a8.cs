using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ExchangeRateRecord
public class JSONRC_e8009f28f7e0bc48d03bef2643bd6906 : AbstractRESTStructure<RC_e8009f28f7e0bc48d03bef2643bd6906> {
[JsonProperty("ExchangeRate")]
[JsonPropertyName("ExchangeRate")]
public decimal? AttrExchangeRate;

public JSONRC_e8009f28f7e0bc48d03bef2643bd6906() { }

public JSONRC_e8009f28f7e0bc48d03bef2643bd6906 (RC_e8009f28f7e0bc48d03bef2643bd6906 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrExchangeRate = ConvertToRestWithoutDefaults(s.ssExchangeRate, 0.0M);
  } else {
AttrExchangeRate = (decimal?) s.ssExchangeRate;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_e8009f28f7e0bc48d03bef2643bd6906, RC_e8009f28f7e0bc48d03bef2643bd6906> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_e8009f28f7e0bc48d03bef2643bd6906 s) => ToStructure(s, config);
}
public static RC_e8009f28f7e0bc48d03bef2643bd6906 ToStructure(ssConectaProveedores.RestRecords.JSONRC_e8009f28f7e0bc48d03bef2643bd6906 obj, IBehaviorsConfiguration config) { 
  RC_e8009f28f7e0bc48d03bef2643bd6906 s = new RC_e8009f28f7e0bc48d03bef2643bd6906();
  if(obj != null) {
  s.ssExchangeRate = obj.AttrExchangeRate == null ? 0.0M : obj.AttrExchangeRate.Value;
  }
  return s;
}

public static Func<RC_e8009f28f7e0bc48d03bef2643bd6906, ssConectaProveedores.RestRecords.JSONRC_e8009f28f7e0bc48d03bef2643bd6906> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_e8009f28f7e0bc48d03bef2643bd6906 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_e8009f28f7e0bc48d03bef2643bd6906 FromStructure(RC_e8009f28f7e0bc48d03bef2643bd6906 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_e8009f28f7e0bc48d03bef2643bd6906(s, config);
}

}


