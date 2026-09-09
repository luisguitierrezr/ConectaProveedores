using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceAccountingServicesAccountingAccounts_ServiceTypeTaxIndicatorCeBeCostCenterSAPCostCenterSAPRecord
public class JSONRC_3a3d5d4cc50f8572263073b452541424 : AbstractRESTStructure<RC_3a3d5d4cc50f8572263073b452541424> {
[JsonProperty("InvoiceAccountingServices")]
[JsonPropertyName("InvoiceAccountingServices")]
public ssConectaProveedores.RestRecords.JSONEN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord AttrInvoiceAccountingServices;

[JsonProperty("AccountingAccounts_ServiceType")]
[JsonPropertyName("AccountingAccounts_ServiceType")]
public ssConectaProveedores.RestRecords.JSONEN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord AttrAccountingAccounts_ServiceType;

[JsonProperty("TaxIndicator")]
[JsonPropertyName("TaxIndicator")]
public ssConectaProveedores.RestRecords.JSONEN_efc751d189a1545503ba31ced5225e86EntityRecord AttrTaxIndicator;

[JsonProperty("CeBeCostCenterSAP")]
[JsonPropertyName("CeBeCostCenterSAP")]
public ssConectaProveedores.RestRecords.JSONEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord AttrCeBeCostCenterSAP;

[JsonProperty("CostCenterSAP")]
[JsonPropertyName("CostCenterSAP")]
public ssConectaProveedores.RestRecords.JSONEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord AttrCostCenterSAP;

public JSONRC_3a3d5d4cc50f8572263073b452541424() { }

public JSONRC_3a3d5d4cc50f8572263073b452541424 (RC_3a3d5d4cc50f8572263073b452541424 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceAccountingServices = ConvertToRestWithoutDefaults(s.ssENInvoiceAccountingServices, new EN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord.FromStructure, config);
AttrAccountingAccounts_ServiceType = ConvertToRestWithoutDefaults(s.ssENAccountingAccounts_ServiceType, new EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord.FromStructure, config);
AttrTaxIndicator = ConvertToRestWithoutDefaults(s.ssENTaxIndicator, new EN_efc751d189a1545503ba31ced5225e86EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_efc751d189a1545503ba31ced5225e86EntityRecord.FromStructure, config);
AttrCeBeCostCenterSAP = ConvertToRestWithoutDefaults(s.ssENCeBeCostCenterSAP, new EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord.FromStructure, config);
AttrCostCenterSAP = ConvertToRestWithoutDefaults(s.ssENCostCenterSAP, new EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord.FromStructure, config);
  } else {
AttrInvoiceAccountingServices = ssConectaProveedores.RestRecords.JSONEN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord.FromStructure(s.ssENInvoiceAccountingServices, config);
AttrAccountingAccounts_ServiceType = ssConectaProveedores.RestRecords.JSONEN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord.FromStructure(s.ssENAccountingAccounts_ServiceType, config);
AttrTaxIndicator = ssConectaProveedores.RestRecords.JSONEN_efc751d189a1545503ba31ced5225e86EntityRecord.FromStructure(s.ssENTaxIndicator, config);
AttrCeBeCostCenterSAP = ssConectaProveedores.RestRecords.JSONEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord.FromStructure(s.ssENCeBeCostCenterSAP, config);
AttrCostCenterSAP = ssConectaProveedores.RestRecords.JSONEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord.FromStructure(s.ssENCostCenterSAP, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_3a3d5d4cc50f8572263073b452541424, RC_3a3d5d4cc50f8572263073b452541424> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_3a3d5d4cc50f8572263073b452541424 s) => ToStructure(s, config);
}
public static RC_3a3d5d4cc50f8572263073b452541424 ToStructure(ssConectaProveedores.RestRecords.JSONRC_3a3d5d4cc50f8572263073b452541424 obj, IBehaviorsConfiguration config) { 
  RC_3a3d5d4cc50f8572263073b452541424 s = new RC_3a3d5d4cc50f8572263073b452541424();
  if(obj != null) {
  s.ssENInvoiceAccountingServices = ssConectaProveedores.RestRecords.JSONEN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord.ToStructure(obj.AttrInvoiceAccountingServices, config);
  s.ssENAccountingAccounts_ServiceType = ssConectaProveedores.RestRecords.JSONEN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord.ToStructure(obj.AttrAccountingAccounts_ServiceType, config);
  s.ssENTaxIndicator = ssConectaProveedores.RestRecords.JSONEN_efc751d189a1545503ba31ced5225e86EntityRecord.ToStructure(obj.AttrTaxIndicator, config);
  s.ssENCeBeCostCenterSAP = ssConectaProveedores.RestRecords.JSONEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord.ToStructure(obj.AttrCeBeCostCenterSAP, config);
  s.ssENCostCenterSAP = ssConectaProveedores.RestRecords.JSONEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord.ToStructure(obj.AttrCostCenterSAP, config);
  }
  return s;
}

public static Func<RC_3a3d5d4cc50f8572263073b452541424, ssConectaProveedores.RestRecords.JSONRC_3a3d5d4cc50f8572263073b452541424> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_3a3d5d4cc50f8572263073b452541424 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_3a3d5d4cc50f8572263073b452541424 FromStructure(RC_3a3d5d4cc50f8572263073b452541424 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_3a3d5d4cc50f8572263073b452541424(s, config);
}

}


