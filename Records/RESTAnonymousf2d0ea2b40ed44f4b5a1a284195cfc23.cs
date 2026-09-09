using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceAccountingServicesAccountingAccounts_ServiceTypeTaxIndicatorCostCenterSAPRecord
public class RESTRC_ca28323a4fc03670541dd65eaae03cf2 : AbstractRESTStructure<RC_ca28323a4fc03670541dd65eaae03cf2> {
[JsonProperty("InvoiceAccountingServices")]
public ssConectaProveedores.RestRecords.RESTEN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord AttrInvoiceAccountingServices;

[JsonProperty("AccountingAccounts_ServiceType")]
public ssConectaProveedores.RestRecords.RESTEN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord AttrAccountingAccounts_ServiceType;

[JsonProperty("TaxIndicator")]
public ssConectaProveedores.RestRecords.RESTEN_efc751d189a1545503ba31ced5225e86EntityRecord AttrTaxIndicator;

[JsonProperty("CostCenterSAP")]
public ssConectaProveedores.RestRecords.RESTEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord AttrCostCenterSAP;

public RESTRC_ca28323a4fc03670541dd65eaae03cf2() { }

public RESTRC_ca28323a4fc03670541dd65eaae03cf2 (RC_ca28323a4fc03670541dd65eaae03cf2 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceAccountingServices = ConvertToRestWithoutDefaults(s.ssENInvoiceAccountingServices, new EN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord.FromStructure, config);
AttrAccountingAccounts_ServiceType = ConvertToRestWithoutDefaults(s.ssENAccountingAccounts_ServiceType, new EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord.FromStructure, config);
AttrTaxIndicator = ConvertToRestWithoutDefaults(s.ssENTaxIndicator, new EN_efc751d189a1545503ba31ced5225e86EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_efc751d189a1545503ba31ced5225e86EntityRecord.FromStructure, config);
AttrCostCenterSAP = ConvertToRestWithoutDefaults(s.ssENCostCenterSAP, new EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord.FromStructure, config);
  } else {
AttrInvoiceAccountingServices = ssConectaProveedores.RestRecords.RESTEN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord.FromStructure(s.ssENInvoiceAccountingServices, config);
AttrAccountingAccounts_ServiceType = ssConectaProveedores.RestRecords.RESTEN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord.FromStructure(s.ssENAccountingAccounts_ServiceType, config);
AttrTaxIndicator = ssConectaProveedores.RestRecords.RESTEN_efc751d189a1545503ba31ced5225e86EntityRecord.FromStructure(s.ssENTaxIndicator, config);
AttrCostCenterSAP = ssConectaProveedores.RestRecords.RESTEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord.FromStructure(s.ssENCostCenterSAP, config);
  }
}

public static RC_ca28323a4fc03670541dd65eaae03cf2 ToStructure(ssConectaProveedores.RestRecords.RESTRC_ca28323a4fc03670541dd65eaae03cf2 obj) { 
  RC_ca28323a4fc03670541dd65eaae03cf2 s = new RC_ca28323a4fc03670541dd65eaae03cf2();
  if(obj != null) {
  s.ssENInvoiceAccountingServices = ssConectaProveedores.RestRecords.RESTEN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord.ToStructure(obj.AttrInvoiceAccountingServices);
  s.ssENAccountingAccounts_ServiceType = ssConectaProveedores.RestRecords.RESTEN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord.ToStructure(obj.AttrAccountingAccounts_ServiceType);
  s.ssENTaxIndicator = ssConectaProveedores.RestRecords.RESTEN_efc751d189a1545503ba31ced5225e86EntityRecord.ToStructure(obj.AttrTaxIndicator);
  s.ssENCostCenterSAP = ssConectaProveedores.RestRecords.RESTEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord.ToStructure(obj.AttrCostCenterSAP);
  }
  return s;
}

public static Func<RC_ca28323a4fc03670541dd65eaae03cf2, ssConectaProveedores.RestRecords.RESTRC_ca28323a4fc03670541dd65eaae03cf2> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_ca28323a4fc03670541dd65eaae03cf2 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_ca28323a4fc03670541dd65eaae03cf2 FromStructure(RC_ca28323a4fc03670541dd65eaae03cf2 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_ca28323a4fc03670541dd65eaae03cf2(s, config);
}

}


