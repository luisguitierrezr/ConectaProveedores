using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceQttSumRecord
public class RESTRC_d39c50b1f75893246aa84db474d82d50 : AbstractRESTStructure<RC_d39c50b1f75893246aa84db474d82d50> {
[JsonProperty("InvoiceQttSum")]
public decimal? AttrInvoiceQttSum;

public RESTRC_d39c50b1f75893246aa84db474d82d50() { }

public RESTRC_d39c50b1f75893246aa84db474d82d50 (RC_d39c50b1f75893246aa84db474d82d50 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceQttSum = ConvertToRestWithoutDefaults(s.ssInvoiceQttSum, 0.0M);
  } else {
AttrInvoiceQttSum = (decimal?) s.ssInvoiceQttSum;
  }
}

public static RC_d39c50b1f75893246aa84db474d82d50 ToStructure(ssConectaProveedores.RestRecords.RESTRC_d39c50b1f75893246aa84db474d82d50 obj) { 
  RC_d39c50b1f75893246aa84db474d82d50 s = new RC_d39c50b1f75893246aa84db474d82d50();
  if(obj != null) {
  s.ssInvoiceQttSum = obj.AttrInvoiceQttSum == null ? 0.0M : obj.AttrInvoiceQttSum.Value;
  }
  return s;
}

public static Func<RC_d39c50b1f75893246aa84db474d82d50, ssConectaProveedores.RestRecords.RESTRC_d39c50b1f75893246aa84db474d82d50> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_d39c50b1f75893246aa84db474d82d50 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_d39c50b1f75893246aa84db474d82d50 FromStructure(RC_d39c50b1f75893246aa84db474d82d50 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_d39c50b1f75893246aa84db474d82d50(s, config);
}

}


