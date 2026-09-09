using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceAccountingServicesAccountingAccounts_ServiceTypeCostCenterSAPIndicatorIVARecord
public class JSONRC_3e9738e6e6c45aed847983a73298da67 : AbstractRESTStructure<RC_3e9738e6e6c45aed847983a73298da67> {
[JsonProperty("InvoiceAccountingServices")]
[JsonPropertyName("InvoiceAccountingServices")]
public ssConectaProveedores.RestRecords.JSONEN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord AttrInvoiceAccountingServices;

[JsonProperty("AccountingAccounts_ServiceType")]
[JsonPropertyName("AccountingAccounts_ServiceType")]
public string AttrAccountingAccounts_ServiceType;

[JsonProperty("CostCenterSAP")]
[JsonPropertyName("CostCenterSAP")]
public string AttrCostCenterSAP;

[JsonProperty("IndicatorIVA")]
[JsonPropertyName("IndicatorIVA")]
public string AttrIndicatorIVA;

public JSONRC_3e9738e6e6c45aed847983a73298da67() { }

public JSONRC_3e9738e6e6c45aed847983a73298da67 (RC_3e9738e6e6c45aed847983a73298da67 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceAccountingServices = ConvertToRestWithoutDefaults(s.ssENInvoiceAccountingServices, new EN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord.FromStructure, config);
AttrAccountingAccounts_ServiceType = ConvertToRestWithoutDefaults(s.ssAccountingAccounts_ServiceType, "");
AttrCostCenterSAP = ConvertToRestWithoutDefaults(s.ssCostCenterSAP, "");
AttrIndicatorIVA = ConvertToRestWithoutDefaults(s.ssIndicatorIVA, "");
  } else {
AttrInvoiceAccountingServices = ssConectaProveedores.RestRecords.JSONEN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord.FromStructure(s.ssENInvoiceAccountingServices, config);
AttrAccountingAccounts_ServiceType = s.ssAccountingAccounts_ServiceType;
AttrCostCenterSAP = s.ssCostCenterSAP;
AttrIndicatorIVA = s.ssIndicatorIVA;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_3e9738e6e6c45aed847983a73298da67, RC_3e9738e6e6c45aed847983a73298da67> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_3e9738e6e6c45aed847983a73298da67 s) => ToStructure(s, config);
}
public static RC_3e9738e6e6c45aed847983a73298da67 ToStructure(ssConectaProveedores.RestRecords.JSONRC_3e9738e6e6c45aed847983a73298da67 obj, IBehaviorsConfiguration config) { 
  RC_3e9738e6e6c45aed847983a73298da67 s = new RC_3e9738e6e6c45aed847983a73298da67();
  if(obj != null) {
  s.ssENInvoiceAccountingServices = ssConectaProveedores.RestRecords.JSONEN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord.ToStructure(obj.AttrInvoiceAccountingServices, config);
  s.ssAccountingAccounts_ServiceType = obj.AttrAccountingAccounts_ServiceType == null ? "" : obj.AttrAccountingAccounts_ServiceType;
  s.ssCostCenterSAP = obj.AttrCostCenterSAP == null ? "" : obj.AttrCostCenterSAP;
  s.ssIndicatorIVA = obj.AttrIndicatorIVA == null ? "" : obj.AttrIndicatorIVA;
  }
  return s;
}

public static Func<RC_3e9738e6e6c45aed847983a73298da67, ssConectaProveedores.RestRecords.JSONRC_3e9738e6e6c45aed847983a73298da67> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_3e9738e6e6c45aed847983a73298da67 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_3e9738e6e6c45aed847983a73298da67 FromStructure(RC_3e9738e6e6c45aed847983a73298da67 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_3e9738e6e6c45aed847983a73298da67(s, config);
}

}


