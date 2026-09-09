using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceQttSumTotalPriceSumRecord
public class RESTRC_d158748ead56eba288746615205b9a8e : AbstractRESTStructure<RC_d158748ead56eba288746615205b9a8e> {
[JsonProperty("InvoiceQttSum")]
public decimal? AttrInvoiceQttSum;

[JsonProperty("TotalPriceSum")]
public decimal? AttrTotalPriceSum;

public RESTRC_d158748ead56eba288746615205b9a8e() { }

public RESTRC_d158748ead56eba288746615205b9a8e (RC_d158748ead56eba288746615205b9a8e s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceQttSum = ConvertToRestWithoutDefaults(s.ssInvoiceQttSum, 0.0M);
AttrTotalPriceSum = ConvertToRestWithoutDefaults(s.ssTotalPriceSum, 0.0M);
  } else {
AttrInvoiceQttSum = (decimal?) s.ssInvoiceQttSum;
AttrTotalPriceSum = (decimal?) s.ssTotalPriceSum;
  }
}

public static RC_d158748ead56eba288746615205b9a8e ToStructure(ssConectaProveedores.RestRecords.RESTRC_d158748ead56eba288746615205b9a8e obj) { 
  RC_d158748ead56eba288746615205b9a8e s = new RC_d158748ead56eba288746615205b9a8e();
  if(obj != null) {
  s.ssInvoiceQttSum = obj.AttrInvoiceQttSum == null ? 0.0M : obj.AttrInvoiceQttSum.Value;
  s.ssTotalPriceSum = obj.AttrTotalPriceSum == null ? 0.0M : obj.AttrTotalPriceSum.Value;
  }
  return s;
}

public static Func<RC_d158748ead56eba288746615205b9a8e, ssConectaProveedores.RestRecords.RESTRC_d158748ead56eba288746615205b9a8e> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_d158748ead56eba288746615205b9a8e s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_d158748ead56eba288746615205b9a8e FromStructure(RC_d158748ead56eba288746615205b9a8e s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_d158748ead56eba288746615205b9a8e(s, config);
}

}


