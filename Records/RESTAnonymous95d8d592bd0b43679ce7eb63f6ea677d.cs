using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceAccountingServicesAccountingAccounts_ServiceTypeCeBeCostCenterSAPCostCenterSAPRecord
public class RESTRC_e940773abf7f42dc9da3bb03219b8c23 : AbstractRESTStructure<RC_e940773abf7f42dc9da3bb03219b8c23> {
[JsonProperty("InvoiceAccountingServices")]
public ssConectaProveedores.RestRecords.RESTEN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord AttrInvoiceAccountingServices;

[JsonProperty("AccountingAccounts_ServiceType")]
public ssConectaProveedores.RestRecords.RESTEN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord AttrAccountingAccounts_ServiceType;

[JsonProperty("CeBeCostCenterSAP")]
public ssConectaProveedores.RestRecords.RESTEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord AttrCeBeCostCenterSAP;

[JsonProperty("CostCenterSAP")]
public ssConectaProveedores.RestRecords.RESTEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord AttrCostCenterSAP;

public RESTRC_e940773abf7f42dc9da3bb03219b8c23() { }

public RESTRC_e940773abf7f42dc9da3bb03219b8c23 (RC_e940773abf7f42dc9da3bb03219b8c23 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceAccountingServices = ConvertToRestWithoutDefaults(s.ssENInvoiceAccountingServices, new EN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord.FromStructure, config);
AttrAccountingAccounts_ServiceType = ConvertToRestWithoutDefaults(s.ssENAccountingAccounts_ServiceType, new EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord.FromStructure, config);
AttrCeBeCostCenterSAP = ConvertToRestWithoutDefaults(s.ssENCeBeCostCenterSAP, new EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord.FromStructure, config);
AttrCostCenterSAP = ConvertToRestWithoutDefaults(s.ssENCostCenterSAP, new EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord.FromStructure, config);
  } else {
AttrInvoiceAccountingServices = ssConectaProveedores.RestRecords.RESTEN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord.FromStructure(s.ssENInvoiceAccountingServices, config);
AttrAccountingAccounts_ServiceType = ssConectaProveedores.RestRecords.RESTEN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord.FromStructure(s.ssENAccountingAccounts_ServiceType, config);
AttrCeBeCostCenterSAP = ssConectaProveedores.RestRecords.RESTEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord.FromStructure(s.ssENCeBeCostCenterSAP, config);
AttrCostCenterSAP = ssConectaProveedores.RestRecords.RESTEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord.FromStructure(s.ssENCostCenterSAP, config);
  }
}

public static RC_e940773abf7f42dc9da3bb03219b8c23 ToStructure(ssConectaProveedores.RestRecords.RESTRC_e940773abf7f42dc9da3bb03219b8c23 obj) { 
  RC_e940773abf7f42dc9da3bb03219b8c23 s = new RC_e940773abf7f42dc9da3bb03219b8c23();
  if(obj != null) {
  s.ssENInvoiceAccountingServices = ssConectaProveedores.RestRecords.RESTEN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord.ToStructure(obj.AttrInvoiceAccountingServices);
  s.ssENAccountingAccounts_ServiceType = ssConectaProveedores.RestRecords.RESTEN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord.ToStructure(obj.AttrAccountingAccounts_ServiceType);
  s.ssENCeBeCostCenterSAP = ssConectaProveedores.RestRecords.RESTEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord.ToStructure(obj.AttrCeBeCostCenterSAP);
  s.ssENCostCenterSAP = ssConectaProveedores.RestRecords.RESTEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord.ToStructure(obj.AttrCostCenterSAP);
  }
  return s;
}

public static Func<RC_e940773abf7f42dc9da3bb03219b8c23, ssConectaProveedores.RestRecords.RESTRC_e940773abf7f42dc9da3bb03219b8c23> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_e940773abf7f42dc9da3bb03219b8c23 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_e940773abf7f42dc9da3bb03219b8c23 FromStructure(RC_e940773abf7f42dc9da3bb03219b8c23 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_e940773abf7f42dc9da3bb03219b8c23(s, config);
}

}


