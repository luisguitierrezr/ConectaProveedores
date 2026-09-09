using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceAccountingServicesInvoiceAccountingCeBeCostCenterSAPCostCenterSAPRecord
public class JSONRC_edbb7c49338c371c22a2fa657a1d867d : AbstractRESTStructure<RC_edbb7c49338c371c22a2fa657a1d867d> {
[JsonProperty("InvoiceAccountingServices")]
[JsonPropertyName("InvoiceAccountingServices")]
public ssConectaProveedores.RestRecords.JSONEN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord AttrInvoiceAccountingServices;

[JsonProperty("InvoiceAccounting")]
[JsonPropertyName("InvoiceAccounting")]
public ssConectaProveedores.RestRecords.JSONEN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord AttrInvoiceAccounting;

[JsonProperty("CeBeCostCenterSAP")]
[JsonPropertyName("CeBeCostCenterSAP")]
public ssConectaProveedores.RestRecords.JSONEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord AttrCeBeCostCenterSAP;

[JsonProperty("CostCenterSAP")]
[JsonPropertyName("CostCenterSAP")]
public ssConectaProveedores.RestRecords.JSONEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord AttrCostCenterSAP;

public JSONRC_edbb7c49338c371c22a2fa657a1d867d() { }

public JSONRC_edbb7c49338c371c22a2fa657a1d867d (RC_edbb7c49338c371c22a2fa657a1d867d s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceAccountingServices = ConvertToRestWithoutDefaults(s.ssENInvoiceAccountingServices, new EN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord.FromStructure, config);
AttrInvoiceAccounting = ConvertToRestWithoutDefaults(s.ssENInvoiceAccounting, new EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord.FromStructure, config);
AttrCeBeCostCenterSAP = ConvertToRestWithoutDefaults(s.ssENCeBeCostCenterSAP, new EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord.FromStructure, config);
AttrCostCenterSAP = ConvertToRestWithoutDefaults(s.ssENCostCenterSAP, new EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord.FromStructure, config);
  } else {
AttrInvoiceAccountingServices = ssConectaProveedores.RestRecords.JSONEN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord.FromStructure(s.ssENInvoiceAccountingServices, config);
AttrInvoiceAccounting = ssConectaProveedores.RestRecords.JSONEN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord.FromStructure(s.ssENInvoiceAccounting, config);
AttrCeBeCostCenterSAP = ssConectaProveedores.RestRecords.JSONEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord.FromStructure(s.ssENCeBeCostCenterSAP, config);
AttrCostCenterSAP = ssConectaProveedores.RestRecords.JSONEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord.FromStructure(s.ssENCostCenterSAP, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_edbb7c49338c371c22a2fa657a1d867d, RC_edbb7c49338c371c22a2fa657a1d867d> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_edbb7c49338c371c22a2fa657a1d867d s) => ToStructure(s, config);
}
public static RC_edbb7c49338c371c22a2fa657a1d867d ToStructure(ssConectaProveedores.RestRecords.JSONRC_edbb7c49338c371c22a2fa657a1d867d obj, IBehaviorsConfiguration config) { 
  RC_edbb7c49338c371c22a2fa657a1d867d s = new RC_edbb7c49338c371c22a2fa657a1d867d();
  if(obj != null) {
  s.ssENInvoiceAccountingServices = ssConectaProveedores.RestRecords.JSONEN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord.ToStructure(obj.AttrInvoiceAccountingServices, config);
  s.ssENInvoiceAccounting = ssConectaProveedores.RestRecords.JSONEN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord.ToStructure(obj.AttrInvoiceAccounting, config);
  s.ssENCeBeCostCenterSAP = ssConectaProveedores.RestRecords.JSONEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord.ToStructure(obj.AttrCeBeCostCenterSAP, config);
  s.ssENCostCenterSAP = ssConectaProveedores.RestRecords.JSONEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord.ToStructure(obj.AttrCostCenterSAP, config);
  }
  return s;
}

public static Func<RC_edbb7c49338c371c22a2fa657a1d867d, ssConectaProveedores.RestRecords.JSONRC_edbb7c49338c371c22a2fa657a1d867d> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_edbb7c49338c371c22a2fa657a1d867d s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_edbb7c49338c371c22a2fa657a1d867d FromStructure(RC_edbb7c49338c371c22a2fa657a1d867d s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_edbb7c49338c371c22a2fa657a1d867d(s, config);
}

}


