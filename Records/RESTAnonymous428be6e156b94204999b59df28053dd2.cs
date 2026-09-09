using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceAccountingServicesAccountingAccounts_ServiceTypeCostCenterSAPIndicatorIVARecord
public class RESTRC_3e9738e6e6c45aed847983a73298da67 : AbstractRESTStructure<RC_3e9738e6e6c45aed847983a73298da67> {
[JsonProperty("InvoiceAccountingServices")]
public ssConectaProveedores.RestRecords.RESTEN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord AttrInvoiceAccountingServices;

[JsonProperty("AccountingAccounts_ServiceType")]
public string AttrAccountingAccounts_ServiceType;

[JsonProperty("CostCenterSAP")]
public string AttrCostCenterSAP;

[JsonProperty("IndicatorIVA")]
public string AttrIndicatorIVA;

public RESTRC_3e9738e6e6c45aed847983a73298da67() { }

public RESTRC_3e9738e6e6c45aed847983a73298da67 (RC_3e9738e6e6c45aed847983a73298da67 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceAccountingServices = ConvertToRestWithoutDefaults(s.ssENInvoiceAccountingServices, new EN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord.FromStructure, config);
AttrAccountingAccounts_ServiceType = ConvertToRestWithoutDefaults(s.ssAccountingAccounts_ServiceType, "");
AttrCostCenterSAP = ConvertToRestWithoutDefaults(s.ssCostCenterSAP, "");
AttrIndicatorIVA = ConvertToRestWithoutDefaults(s.ssIndicatorIVA, "");
  } else {
AttrInvoiceAccountingServices = ssConectaProveedores.RestRecords.RESTEN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord.FromStructure(s.ssENInvoiceAccountingServices, config);
AttrAccountingAccounts_ServiceType = s.ssAccountingAccounts_ServiceType;
AttrCostCenterSAP = s.ssCostCenterSAP;
AttrIndicatorIVA = s.ssIndicatorIVA;
  }
}

public static RC_3e9738e6e6c45aed847983a73298da67 ToStructure(ssConectaProveedores.RestRecords.RESTRC_3e9738e6e6c45aed847983a73298da67 obj) { 
  RC_3e9738e6e6c45aed847983a73298da67 s = new RC_3e9738e6e6c45aed847983a73298da67();
  if(obj != null) {
  s.ssENInvoiceAccountingServices = ssConectaProveedores.RestRecords.RESTEN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord.ToStructure(obj.AttrInvoiceAccountingServices);
  s.ssAccountingAccounts_ServiceType = obj.AttrAccountingAccounts_ServiceType == null ? "" : obj.AttrAccountingAccounts_ServiceType;
  s.ssCostCenterSAP = obj.AttrCostCenterSAP == null ? "" : obj.AttrCostCenterSAP;
  s.ssIndicatorIVA = obj.AttrIndicatorIVA == null ? "" : obj.AttrIndicatorIVA;
  }
  return s;
}

public static Func<RC_3e9738e6e6c45aed847983a73298da67, ssConectaProveedores.RestRecords.RESTRC_3e9738e6e6c45aed847983a73298da67> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_3e9738e6e6c45aed847983a73298da67 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_3e9738e6e6c45aed847983a73298da67 FromStructure(RC_3e9738e6e6c45aed847983a73298da67 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_3e9738e6e6c45aed847983a73298da67(s, config);
}

}


