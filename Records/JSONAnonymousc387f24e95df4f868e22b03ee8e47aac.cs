using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceQttSumTotalPriceSumRecord
public class JSONRC_d158748ead56eba288746615205b9a8e : AbstractRESTStructure<RC_d158748ead56eba288746615205b9a8e> {
[JsonProperty("InvoiceQttSum")]
[JsonPropertyName("InvoiceQttSum")]
public decimal? AttrInvoiceQttSum;

[JsonProperty("TotalPriceSum")]
[JsonPropertyName("TotalPriceSum")]
public decimal? AttrTotalPriceSum;

public JSONRC_d158748ead56eba288746615205b9a8e() { }

public JSONRC_d158748ead56eba288746615205b9a8e (RC_d158748ead56eba288746615205b9a8e s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceQttSum = ConvertToRestWithoutDefaults(s.ssInvoiceQttSum, 0.0M);
AttrTotalPriceSum = ConvertToRestWithoutDefaults(s.ssTotalPriceSum, 0.0M);
  } else {
AttrInvoiceQttSum = (decimal?) s.ssInvoiceQttSum;
AttrTotalPriceSum = (decimal?) s.ssTotalPriceSum;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_d158748ead56eba288746615205b9a8e, RC_d158748ead56eba288746615205b9a8e> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_d158748ead56eba288746615205b9a8e s) => ToStructure(s, config);
}
public static RC_d158748ead56eba288746615205b9a8e ToStructure(ssConectaProveedores.RestRecords.JSONRC_d158748ead56eba288746615205b9a8e obj, IBehaviorsConfiguration config) { 
  RC_d158748ead56eba288746615205b9a8e s = new RC_d158748ead56eba288746615205b9a8e();
  if(obj != null) {
  s.ssInvoiceQttSum = obj.AttrInvoiceQttSum == null ? 0.0M : obj.AttrInvoiceQttSum.Value;
  s.ssTotalPriceSum = obj.AttrTotalPriceSum == null ? 0.0M : obj.AttrTotalPriceSum.Value;
  }
  return s;
}

public static Func<RC_d158748ead56eba288746615205b9a8e, ssConectaProveedores.RestRecords.JSONRC_d158748ead56eba288746615205b9a8e> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_d158748ead56eba288746615205b9a8e s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_d158748ead56eba288746615205b9a8e FromStructure(RC_d158748ead56eba288746615205b9a8e s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_d158748ead56eba288746615205b9a8e(s, config);
}

}


