using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// AccountingTable
public class JSONST_d9cd2417d7f5e39d5d950b6b6b9d1f5cStructure : AbstractRESTStructure<ST_d9cd2417d7f5e39d5d950b6b6b9d1f5cStructure> {
[JsonProperty("AccountingAccounts_ServiceType")]
[JsonPropertyName("AccountingAccounts_ServiceType")]
public string AttrAccountingAccounts_ServiceType;

[JsonProperty("IsEditAccountingAccounts_ServiceType")]
[JsonPropertyName("IsEditAccountingAccounts_ServiceType")]
public bool? AttrIsEditAccountingAccounts_ServiceType;

[JsonProperty("IsErrorAccountingAccounts_ServiceType")]
[JsonPropertyName("IsErrorAccountingAccounts_ServiceType")]
public bool? AttrIsErrorAccountingAccounts_ServiceType;

[JsonProperty("CostCenterSAP")]
[JsonPropertyName("CostCenterSAP")]
public string AttrCostCenterSAP;

[JsonProperty("BeneficiaryCenterSAP")]
[JsonPropertyName("BeneficiaryCenterSAP")]
public string AttrBeneficiaryCenterSAP;

[JsonProperty("IsEditCostCenterSAP")]
[JsonPropertyName("IsEditCostCenterSAP")]
public bool? AttrIsEditCostCenterSAP;

[JsonProperty("IsErrorCostCenterSAP")]
[JsonPropertyName("IsErrorCostCenterSAP")]
public bool? AttrIsErrorCostCenterSAP;

[JsonProperty("IsEditBenefitCenterSAP")]
[JsonPropertyName("IsEditBenefitCenterSAP")]
public bool? AttrIsEditBenefitCenterSAP;

[JsonProperty("IsErrorBenefitCenterSAP")]
[JsonPropertyName("IsErrorBenefitCenterSAP")]
public bool? AttrIsErrorBenefitCenterSAP;

[JsonProperty("HideAccountingFields")]
[JsonPropertyName("HideAccountingFields")]
public bool? AttrHideAccountingFields;

[JsonProperty("HideServicesFields")]
[JsonPropertyName("HideServicesFields")]
public bool? AttrHideServicesFields;

[JsonProperty("InvoiceAccounting")]
[JsonPropertyName("InvoiceAccounting")]
public ssConectaProveedores.RestRecords.JSONEN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord AttrInvoiceAccounting;

[JsonProperty("InvoiceAccountingServices")]
[JsonPropertyName("InvoiceAccountingServices")]
public ssConectaProveedores.RestRecords.JSONEN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord AttrInvoiceAccountingServices;

[JsonProperty("CostCenter")]
[JsonPropertyName("CostCenter")]
public ssConectaProveedores.RestRecords.JSONEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord AttrCostCenter;

[JsonProperty("IsEditFreeText")]
[JsonPropertyName("IsEditFreeText")]
public bool? AttrIsEditFreeText;

[JsonProperty("IsErrorFreeText")]
[JsonPropertyName("IsErrorFreeText")]
public bool? AttrIsErrorFreeText;

[JsonProperty("IsEditDivision")]
[JsonPropertyName("IsEditDivision")]
public bool? AttrIsEditDivision;

[JsonProperty("IsErrorDivision")]
[JsonPropertyName("IsErrorDivision")]
public bool? AttrIsErrorDivision;

[JsonProperty("IVAIndicator")]
[JsonPropertyName("IVAIndicator")]
public string AttrIVAIndicator;

[JsonProperty("IsEditIVA")]
[JsonPropertyName("IsEditIVA")]
public bool? AttrIsEditIVA;

[JsonProperty("IsEditAmount")]
[JsonPropertyName("IsEditAmount")]
public bool? AttrIsEditAmount;

[JsonProperty("IsErrorAmount")]
[JsonPropertyName("IsErrorAmount")]
public bool? AttrIsErrorAmount;

[JsonProperty("IsEditTotalAmount")]
[JsonPropertyName("IsEditTotalAmount")]
public bool? AttrIsEditTotalAmount;

[JsonProperty("IsErrorTotalAmount")]
[JsonPropertyName("IsErrorTotalAmount")]
public bool? AttrIsErrorTotalAmount;

[JsonProperty("PaymentMethod")]
[JsonPropertyName("PaymentMethod")]
public string AttrPaymentMethod;

[JsonProperty("IsEditPaymentMethod")]
[JsonPropertyName("IsEditPaymentMethod")]
public bool? AttrIsEditPaymentMethod;

[JsonProperty("PaymentTerm")]
[JsonPropertyName("PaymentTerm")]
public string AttrPaymentTerm;

[JsonProperty("IsEditPaymentTerm")]
[JsonPropertyName("IsEditPaymentTerm")]
public bool? AttrIsEditPaymentTerm;

[JsonProperty("IsEditICME")]
[JsonPropertyName("IsEditICME")]
public bool? AttrIsEditICME;

[JsonProperty("IsEditBuyDocNumber")]
[JsonPropertyName("IsEditBuyDocNumber")]
public bool? AttrIsEditBuyDocNumber;

[JsonProperty("IsEditBuyDocPosition")]
[JsonPropertyName("IsEditBuyDocPosition")]
public bool? AttrIsEditBuyDocPosition;

[JsonProperty("BuyDocNumber")]
[JsonPropertyName("BuyDocNumber")]
public string AttrBuyDocNumber;

[JsonProperty("BuyDocPosition")]
[JsonPropertyName("BuyDocPosition")]
public string AttrBuyDocPosition;

public JSONST_d9cd2417d7f5e39d5d950b6b6b9d1f5cStructure() { }

public JSONST_d9cd2417d7f5e39d5d950b6b6b9d1f5cStructure (ST_d9cd2417d7f5e39d5d950b6b6b9d1f5cStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAccountingAccounts_ServiceType = ConvertToRestWithoutDefaults(s.ssAccountingAccounts_ServiceType, "");
AttrIsEditAccountingAccounts_ServiceType = ConvertToRestWithoutDefaults(s.ssIsEditAccountingAccounts_ServiceType, false);
AttrIsErrorAccountingAccounts_ServiceType = ConvertToRestWithoutDefaults(s.ssIsErrorAccountingAccounts_ServiceType, false);
AttrCostCenterSAP = ConvertToRestWithoutDefaults(s.ssCostCenterSAP, "");
AttrBeneficiaryCenterSAP = ConvertToRestWithoutDefaults(s.ssBeneficiaryCenterSAP, "");
AttrIsEditCostCenterSAP = ConvertToRestWithoutDefaults(s.ssIsEditCostCenterSAP, false);
AttrIsErrorCostCenterSAP = ConvertToRestWithoutDefaults(s.ssIsErrorCostCenterSAP, false);
AttrIsEditBenefitCenterSAP = ConvertToRestWithoutDefaults(s.ssIsEditBenefitCenterSAP, false);
AttrIsErrorBenefitCenterSAP = ConvertToRestWithoutDefaults(s.ssIsErrorBenefitCenterSAP, false);
AttrHideAccountingFields = ConvertToRestWithoutDefaults(s.ssHideAccountingFields, false);
AttrHideServicesFields = ConvertToRestWithoutDefaults(s.ssHideServicesFields, false);
AttrInvoiceAccounting = ConvertToRestWithoutDefaults(s.ssInvoiceAccounting, new EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord.FromStructure, config);
AttrInvoiceAccountingServices = ConvertToRestWithoutDefaults(s.ssInvoiceAccountingServices, new EN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord.FromStructure, config);
AttrCostCenter = ConvertToRestWithoutDefaults(s.ssCostCenter, new EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord.FromStructure, config);
AttrIsEditFreeText = ConvertToRestWithoutDefaults(s.ssIsEditFreeText, false);
AttrIsErrorFreeText = ConvertToRestWithoutDefaults(s.ssIsErrorFreeText, false);
AttrIsEditDivision = ConvertToRestWithoutDefaults(s.ssIsEditDivision, false);
AttrIsErrorDivision = ConvertToRestWithoutDefaults(s.ssIsErrorDivision, false);
AttrIVAIndicator = ConvertToRestWithoutDefaults(s.ssIVAIndicator, "");
AttrIsEditIVA = ConvertToRestWithoutDefaults(s.ssIsEditIVA, false);
AttrIsEditAmount = ConvertToRestWithoutDefaults(s.ssIsEditAmount, false);
AttrIsErrorAmount = ConvertToRestWithoutDefaults(s.ssIsErrorAmount, false);
AttrIsEditTotalAmount = ConvertToRestWithoutDefaults(s.ssIsEditTotalAmount, false);
AttrIsErrorTotalAmount = ConvertToRestWithoutDefaults(s.ssIsErrorTotalAmount, false);
AttrPaymentMethod = ConvertToRestWithoutDefaults(s.ssPaymentMethod, "");
AttrIsEditPaymentMethod = ConvertToRestWithoutDefaults(s.ssIsEditPaymentMethod, false);
AttrPaymentTerm = ConvertToRestWithoutDefaults(s.ssPaymentTerm, "");
AttrIsEditPaymentTerm = ConvertToRestWithoutDefaults(s.ssIsEditPaymentTerm, false);
AttrIsEditICME = ConvertToRestWithoutDefaults(s.ssIsEditICME, false);
AttrIsEditBuyDocNumber = ConvertToRestWithoutDefaults(s.ssIsEditBuyDocNumber, false);
AttrIsEditBuyDocPosition = ConvertToRestWithoutDefaults(s.ssIsEditBuyDocPosition, false);
AttrBuyDocNumber = ConvertToRestWithoutDefaults(s.ssBuyDocNumber, "");
AttrBuyDocPosition = ConvertToRestWithoutDefaults(s.ssBuyDocPosition, "");
  } else {
AttrAccountingAccounts_ServiceType = s.ssAccountingAccounts_ServiceType;
AttrIsEditAccountingAccounts_ServiceType = (bool?) s.ssIsEditAccountingAccounts_ServiceType;
AttrIsErrorAccountingAccounts_ServiceType = (bool?) s.ssIsErrorAccountingAccounts_ServiceType;
AttrCostCenterSAP = s.ssCostCenterSAP;
AttrBeneficiaryCenterSAP = s.ssBeneficiaryCenterSAP;
AttrIsEditCostCenterSAP = (bool?) s.ssIsEditCostCenterSAP;
AttrIsErrorCostCenterSAP = (bool?) s.ssIsErrorCostCenterSAP;
AttrIsEditBenefitCenterSAP = (bool?) s.ssIsEditBenefitCenterSAP;
AttrIsErrorBenefitCenterSAP = (bool?) s.ssIsErrorBenefitCenterSAP;
AttrHideAccountingFields = (bool?) s.ssHideAccountingFields;
AttrHideServicesFields = (bool?) s.ssHideServicesFields;
AttrInvoiceAccounting = ssConectaProveedores.RestRecords.JSONEN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord.FromStructure(s.ssInvoiceAccounting, config);
AttrInvoiceAccountingServices = ssConectaProveedores.RestRecords.JSONEN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord.FromStructure(s.ssInvoiceAccountingServices, config);
AttrCostCenter = ssConectaProveedores.RestRecords.JSONEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord.FromStructure(s.ssCostCenter, config);
AttrIsEditFreeText = (bool?) s.ssIsEditFreeText;
AttrIsErrorFreeText = (bool?) s.ssIsErrorFreeText;
AttrIsEditDivision = (bool?) s.ssIsEditDivision;
AttrIsErrorDivision = (bool?) s.ssIsErrorDivision;
AttrIVAIndicator = s.ssIVAIndicator;
AttrIsEditIVA = (bool?) s.ssIsEditIVA;
AttrIsEditAmount = (bool?) s.ssIsEditAmount;
AttrIsErrorAmount = (bool?) s.ssIsErrorAmount;
AttrIsEditTotalAmount = (bool?) s.ssIsEditTotalAmount;
AttrIsErrorTotalAmount = (bool?) s.ssIsErrorTotalAmount;
AttrPaymentMethod = s.ssPaymentMethod;
AttrIsEditPaymentMethod = (bool?) s.ssIsEditPaymentMethod;
AttrPaymentTerm = s.ssPaymentTerm;
AttrIsEditPaymentTerm = (bool?) s.ssIsEditPaymentTerm;
AttrIsEditICME = (bool?) s.ssIsEditICME;
AttrIsEditBuyDocNumber = (bool?) s.ssIsEditBuyDocNumber;
AttrIsEditBuyDocPosition = (bool?) s.ssIsEditBuyDocPosition;
AttrBuyDocNumber = s.ssBuyDocNumber;
AttrBuyDocPosition = s.ssBuyDocPosition;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_d9cd2417d7f5e39d5d950b6b6b9d1f5cStructure, ST_d9cd2417d7f5e39d5d950b6b6b9d1f5cStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_d9cd2417d7f5e39d5d950b6b6b9d1f5cStructure s) => ToStructure(s, config);
}
public static ST_d9cd2417d7f5e39d5d950b6b6b9d1f5cStructure ToStructure(ssConectaProveedores.RestRecords.JSONST_d9cd2417d7f5e39d5d950b6b6b9d1f5cStructure obj, IBehaviorsConfiguration config) { 
  ST_d9cd2417d7f5e39d5d950b6b6b9d1f5cStructure s = new ST_d9cd2417d7f5e39d5d950b6b6b9d1f5cStructure();
  if(obj != null) {
  s.ssAccountingAccounts_ServiceType = obj.AttrAccountingAccounts_ServiceType == null ? "" : obj.AttrAccountingAccounts_ServiceType;
  s.ssIsEditAccountingAccounts_ServiceType = obj.AttrIsEditAccountingAccounts_ServiceType == null ? false : obj.AttrIsEditAccountingAccounts_ServiceType.Value;
  s.ssIsErrorAccountingAccounts_ServiceType = obj.AttrIsErrorAccountingAccounts_ServiceType == null ? false : obj.AttrIsErrorAccountingAccounts_ServiceType.Value;
  s.ssCostCenterSAP = obj.AttrCostCenterSAP == null ? "" : obj.AttrCostCenterSAP;
  s.ssBeneficiaryCenterSAP = obj.AttrBeneficiaryCenterSAP == null ? "" : obj.AttrBeneficiaryCenterSAP;
  s.ssIsEditCostCenterSAP = obj.AttrIsEditCostCenterSAP == null ? false : obj.AttrIsEditCostCenterSAP.Value;
  s.ssIsErrorCostCenterSAP = obj.AttrIsErrorCostCenterSAP == null ? false : obj.AttrIsErrorCostCenterSAP.Value;
  s.ssIsEditBenefitCenterSAP = obj.AttrIsEditBenefitCenterSAP == null ? false : obj.AttrIsEditBenefitCenterSAP.Value;
  s.ssIsErrorBenefitCenterSAP = obj.AttrIsErrorBenefitCenterSAP == null ? false : obj.AttrIsErrorBenefitCenterSAP.Value;
  s.ssHideAccountingFields = obj.AttrHideAccountingFields == null ? false : obj.AttrHideAccountingFields.Value;
  s.ssHideServicesFields = obj.AttrHideServicesFields == null ? false : obj.AttrHideServicesFields.Value;
  s.ssInvoiceAccounting = ssConectaProveedores.RestRecords.JSONEN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord.ToStructure(obj.AttrInvoiceAccounting, config);
  s.ssInvoiceAccountingServices = ssConectaProveedores.RestRecords.JSONEN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord.ToStructure(obj.AttrInvoiceAccountingServices, config);
  s.ssCostCenter = ssConectaProveedores.RestRecords.JSONEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord.ToStructure(obj.AttrCostCenter, config);
  s.ssIsEditFreeText = obj.AttrIsEditFreeText == null ? false : obj.AttrIsEditFreeText.Value;
  s.ssIsErrorFreeText = obj.AttrIsErrorFreeText == null ? false : obj.AttrIsErrorFreeText.Value;
  s.ssIsEditDivision = obj.AttrIsEditDivision == null ? false : obj.AttrIsEditDivision.Value;
  s.ssIsErrorDivision = obj.AttrIsErrorDivision == null ? false : obj.AttrIsErrorDivision.Value;
  s.ssIVAIndicator = obj.AttrIVAIndicator == null ? "" : obj.AttrIVAIndicator;
  s.ssIsEditIVA = obj.AttrIsEditIVA == null ? false : obj.AttrIsEditIVA.Value;
  s.ssIsEditAmount = obj.AttrIsEditAmount == null ? false : obj.AttrIsEditAmount.Value;
  s.ssIsErrorAmount = obj.AttrIsErrorAmount == null ? false : obj.AttrIsErrorAmount.Value;
  s.ssIsEditTotalAmount = obj.AttrIsEditTotalAmount == null ? false : obj.AttrIsEditTotalAmount.Value;
  s.ssIsErrorTotalAmount = obj.AttrIsErrorTotalAmount == null ? false : obj.AttrIsErrorTotalAmount.Value;
  s.ssPaymentMethod = obj.AttrPaymentMethod == null ? "" : obj.AttrPaymentMethod;
  s.ssIsEditPaymentMethod = obj.AttrIsEditPaymentMethod == null ? false : obj.AttrIsEditPaymentMethod.Value;
  s.ssPaymentTerm = obj.AttrPaymentTerm == null ? "" : obj.AttrPaymentTerm;
  s.ssIsEditPaymentTerm = obj.AttrIsEditPaymentTerm == null ? false : obj.AttrIsEditPaymentTerm.Value;
  s.ssIsEditICME = obj.AttrIsEditICME == null ? false : obj.AttrIsEditICME.Value;
  s.ssIsEditBuyDocNumber = obj.AttrIsEditBuyDocNumber == null ? false : obj.AttrIsEditBuyDocNumber.Value;
  s.ssIsEditBuyDocPosition = obj.AttrIsEditBuyDocPosition == null ? false : obj.AttrIsEditBuyDocPosition.Value;
  s.ssBuyDocNumber = obj.AttrBuyDocNumber == null ? "" : obj.AttrBuyDocNumber;
  s.ssBuyDocPosition = obj.AttrBuyDocPosition == null ? "" : obj.AttrBuyDocPosition;
  }
  return s;
}

public static Func<ST_d9cd2417d7f5e39d5d950b6b6b9d1f5cStructure, ssConectaProveedores.RestRecords.JSONST_d9cd2417d7f5e39d5d950b6b6b9d1f5cStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_d9cd2417d7f5e39d5d950b6b6b9d1f5cStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_d9cd2417d7f5e39d5d950b6b6b9d1f5cStructure FromStructure(ST_d9cd2417d7f5e39d5d950b6b6b9d1f5cStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_d9cd2417d7f5e39d5d950b6b6b9d1f5cStructure(s, config);
}

}


