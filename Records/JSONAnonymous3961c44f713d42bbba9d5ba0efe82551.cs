using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceAccountingServicesAccountingAccounts_ServiceTypeBenefitCenterSAPCostCenterSAPIndicatorIVARecord
public class JSONRC_3b34889e0cefe5468fc5f63480ce4e0f : AbstractRESTStructure<RC_3b34889e0cefe5468fc5f63480ce4e0f> {
[JsonProperty("InvoiceAccountingServices")]
[JsonPropertyName("InvoiceAccountingServices")]
public ssConectaProveedores.RestRecords.JSONEN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord AttrInvoiceAccountingServices;

[JsonProperty("AccountingAccounts_ServiceType")]
[JsonPropertyName("AccountingAccounts_ServiceType")]
public string AttrAccountingAccounts_ServiceType;

[JsonProperty("BenefitCenterSAP")]
[JsonPropertyName("BenefitCenterSAP")]
public string AttrBenefitCenterSAP;

[JsonProperty("CostCenterSAP")]
[JsonPropertyName("CostCenterSAP")]
public string AttrCostCenterSAP;

[JsonProperty("IndicatorIVA")]
[JsonPropertyName("IndicatorIVA")]
public string AttrIndicatorIVA;

public JSONRC_3b34889e0cefe5468fc5f63480ce4e0f() { }

public JSONRC_3b34889e0cefe5468fc5f63480ce4e0f (RC_3b34889e0cefe5468fc5f63480ce4e0f s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceAccountingServices = ConvertToRestWithoutDefaults(s.ssENInvoiceAccountingServices, new EN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord.FromStructure, config);
AttrAccountingAccounts_ServiceType = ConvertToRestWithoutDefaults(s.ssAccountingAccounts_ServiceType, "");
AttrBenefitCenterSAP = ConvertToRestWithoutDefaults(s.ssBenefitCenterSAP, "");
AttrCostCenterSAP = ConvertToRestWithoutDefaults(s.ssCostCenterSAP, "");
AttrIndicatorIVA = ConvertToRestWithoutDefaults(s.ssIndicatorIVA, "");
  } else {
AttrInvoiceAccountingServices = ssConectaProveedores.RestRecords.JSONEN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord.FromStructure(s.ssENInvoiceAccountingServices, config);
AttrAccountingAccounts_ServiceType = s.ssAccountingAccounts_ServiceType;
AttrBenefitCenterSAP = s.ssBenefitCenterSAP;
AttrCostCenterSAP = s.ssCostCenterSAP;
AttrIndicatorIVA = s.ssIndicatorIVA;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_3b34889e0cefe5468fc5f63480ce4e0f, RC_3b34889e0cefe5468fc5f63480ce4e0f> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_3b34889e0cefe5468fc5f63480ce4e0f s) => ToStructure(s, config);
}
public static RC_3b34889e0cefe5468fc5f63480ce4e0f ToStructure(ssConectaProveedores.RestRecords.JSONRC_3b34889e0cefe5468fc5f63480ce4e0f obj, IBehaviorsConfiguration config) { 
  RC_3b34889e0cefe5468fc5f63480ce4e0f s = new RC_3b34889e0cefe5468fc5f63480ce4e0f();
  if(obj != null) {
  s.ssENInvoiceAccountingServices = ssConectaProveedores.RestRecords.JSONEN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord.ToStructure(obj.AttrInvoiceAccountingServices, config);
  s.ssAccountingAccounts_ServiceType = obj.AttrAccountingAccounts_ServiceType == null ? "" : obj.AttrAccountingAccounts_ServiceType;
  s.ssBenefitCenterSAP = obj.AttrBenefitCenterSAP == null ? "" : obj.AttrBenefitCenterSAP;
  s.ssCostCenterSAP = obj.AttrCostCenterSAP == null ? "" : obj.AttrCostCenterSAP;
  s.ssIndicatorIVA = obj.AttrIndicatorIVA == null ? "" : obj.AttrIndicatorIVA;
  }
  return s;
}

public static Func<RC_3b34889e0cefe5468fc5f63480ce4e0f, ssConectaProveedores.RestRecords.JSONRC_3b34889e0cefe5468fc5f63480ce4e0f> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_3b34889e0cefe5468fc5f63480ce4e0f s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_3b34889e0cefe5468fc5f63480ce4e0f FromStructure(RC_3b34889e0cefe5468fc5f63480ce4e0f s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_3b34889e0cefe5468fc5f63480ce4e0f(s, config);
}

}


