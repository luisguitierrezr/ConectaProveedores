using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceAccountingServicesAccountingAccounts_ServiceTypeBenefitCenterSAPCostCenterSAPIndicatorIVARecord
public class RESTRC_3b34889e0cefe5468fc5f63480ce4e0f : AbstractRESTStructure<RC_3b34889e0cefe5468fc5f63480ce4e0f> {
[JsonProperty("InvoiceAccountingServices")]
public ssConectaProveedores.RestRecords.RESTEN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord AttrInvoiceAccountingServices;

[JsonProperty("AccountingAccounts_ServiceType")]
public string AttrAccountingAccounts_ServiceType;

[JsonProperty("BenefitCenterSAP")]
public string AttrBenefitCenterSAP;

[JsonProperty("CostCenterSAP")]
public string AttrCostCenterSAP;

[JsonProperty("IndicatorIVA")]
public string AttrIndicatorIVA;

public RESTRC_3b34889e0cefe5468fc5f63480ce4e0f() { }

public RESTRC_3b34889e0cefe5468fc5f63480ce4e0f (RC_3b34889e0cefe5468fc5f63480ce4e0f s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceAccountingServices = ConvertToRestWithoutDefaults(s.ssENInvoiceAccountingServices, new EN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord.FromStructure, config);
AttrAccountingAccounts_ServiceType = ConvertToRestWithoutDefaults(s.ssAccountingAccounts_ServiceType, "");
AttrBenefitCenterSAP = ConvertToRestWithoutDefaults(s.ssBenefitCenterSAP, "");
AttrCostCenterSAP = ConvertToRestWithoutDefaults(s.ssCostCenterSAP, "");
AttrIndicatorIVA = ConvertToRestWithoutDefaults(s.ssIndicatorIVA, "");
  } else {
AttrInvoiceAccountingServices = ssConectaProveedores.RestRecords.RESTEN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord.FromStructure(s.ssENInvoiceAccountingServices, config);
AttrAccountingAccounts_ServiceType = s.ssAccountingAccounts_ServiceType;
AttrBenefitCenterSAP = s.ssBenefitCenterSAP;
AttrCostCenterSAP = s.ssCostCenterSAP;
AttrIndicatorIVA = s.ssIndicatorIVA;
  }
}

public static RC_3b34889e0cefe5468fc5f63480ce4e0f ToStructure(ssConectaProveedores.RestRecords.RESTRC_3b34889e0cefe5468fc5f63480ce4e0f obj) { 
  RC_3b34889e0cefe5468fc5f63480ce4e0f s = new RC_3b34889e0cefe5468fc5f63480ce4e0f();
  if(obj != null) {
  s.ssENInvoiceAccountingServices = ssConectaProveedores.RestRecords.RESTEN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord.ToStructure(obj.AttrInvoiceAccountingServices);
  s.ssAccountingAccounts_ServiceType = obj.AttrAccountingAccounts_ServiceType == null ? "" : obj.AttrAccountingAccounts_ServiceType;
  s.ssBenefitCenterSAP = obj.AttrBenefitCenterSAP == null ? "" : obj.AttrBenefitCenterSAP;
  s.ssCostCenterSAP = obj.AttrCostCenterSAP == null ? "" : obj.AttrCostCenterSAP;
  s.ssIndicatorIVA = obj.AttrIndicatorIVA == null ? "" : obj.AttrIndicatorIVA;
  }
  return s;
}

public static Func<RC_3b34889e0cefe5468fc5f63480ce4e0f, ssConectaProveedores.RestRecords.RESTRC_3b34889e0cefe5468fc5f63480ce4e0f> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_3b34889e0cefe5468fc5f63480ce4e0f s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_3b34889e0cefe5468fc5f63480ce4e0f FromStructure(RC_3b34889e0cefe5468fc5f63480ce4e0f s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_3b34889e0cefe5468fc5f63480ce4e0f(s, config);
}

}


