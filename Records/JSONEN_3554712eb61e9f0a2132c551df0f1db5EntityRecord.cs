using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionAccounting
public class JSONEN_3554712eb61e9f0a2132c551df0f1db5EntityRecord : AbstractRESTStructure<EN_3554712eb61e9f0a2132c551df0f1db5EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("RequisitionId")]
[JsonPropertyName("RequisitionId")]
public long? AttrRequisitionId;

[JsonProperty("HasEstim_Equal_AgrePaym_DEPR")]
[JsonPropertyName("HasEstim_Equal_AgrePaym_DEPR")]
public bool? AttrHasEstim_Equal_AgrePaym_DEPR;

[JsonProperty("HasSettlement_DEPR")]
[JsonPropertyName("HasSettlement_DEPR")]
public bool? AttrHasSettlement_DEPR;

[JsonProperty("HasCreditNote_DEPR")]
[JsonPropertyName("HasCreditNote_DEPR")]
public bool? AttrHasCreditNote_DEPR;

[JsonProperty("HasVoucher_DEPR")]
[JsonPropertyName("HasVoucher_DEPR")]
public bool? AttrHasVoucher_DEPR;

[JsonProperty("HasSpecialPostDeliveryAuth")]
[JsonPropertyName("HasSpecialPostDeliveryAuth")]
public bool? AttrHasSpecialPostDeliveryAuth;

[JsonProperty("SpecialPostDeliveryAuthId")]
[JsonPropertyName("SpecialPostDeliveryAuthId")]
public int? AttrSpecialPostDeliveryAuthId;

[JsonProperty("Amount_DEPREC")]
[JsonPropertyName("Amount_DEPREC")]
public decimal? AttrAmount_DEPREC;

[JsonProperty("CurrencyId_DEPREC")]
[JsonPropertyName("CurrencyId_DEPREC")]
public string AttrCurrencyId_DEPREC;

[JsonProperty("PaymentMethodId_DEPREC")]
[JsonPropertyName("PaymentMethodId_DEPREC")]
public long? AttrPaymentMethodId_DEPREC;

[JsonProperty("PaymentTermId_DEPREC")]
[JsonPropertyName("PaymentTermId_DEPREC")]
public long? AttrPaymentTermId_DEPREC;

[JsonProperty("NegociatedExchangeRateAcc")]
[JsonPropertyName("NegociatedExchangeRateAcc")]
public decimal? AttrNegociatedExchangeRateAcc;

[JsonProperty("ExchangeRateComment")]
[JsonPropertyName("ExchangeRateComment")]
public string AttrExchangeRateComment;

[JsonProperty("EvidenceFileId")]
[JsonPropertyName("EvidenceFileId")]
public long? AttrEvidenceFileId;

[JsonProperty("HasContract")]
[JsonPropertyName("HasContract")]
public bool? AttrHasContract;

[JsonProperty("HasREPSE")]
[JsonPropertyName("HasREPSE")]
public bool? AttrHasREPSE;

[JsonProperty("HasPaymentSupplement")]
[JsonPropertyName("HasPaymentSupplement")]
public bool? AttrHasPaymentSupplement;

[JsonProperty("HasNoticeOfPaymentSuspension")]
[JsonPropertyName("HasNoticeOfPaymentSuspension")]
public bool? AttrHasNoticeOfPaymentSuspension;

public JSONEN_3554712eb61e9f0a2132c551df0f1db5EntityRecord() { }

public JSONEN_3554712eb61e9f0a2132c551df0f1db5EntityRecord (EN_3554712eb61e9f0a2132c551df0f1db5EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrRequisitionId = ConvertToRestWithoutDefaults(s.ssRequisitionId, 0L);
AttrHasEstim_Equal_AgrePaym_DEPR = ConvertToRestWithoutDefaults(s.ssHasEstim_Equal_AgrePaym_DEPR, false);
AttrHasSettlement_DEPR = ConvertToRestWithoutDefaults(s.ssHasSettlement_DEPR, false);
AttrHasCreditNote_DEPR = ConvertToRestWithoutDefaults(s.ssHasCreditNote_DEPR, false);
AttrHasVoucher_DEPR = ConvertToRestWithoutDefaults(s.ssHasVoucher_DEPR, false);
AttrHasSpecialPostDeliveryAuth = ConvertToRestWithoutDefaults(s.ssHasSpecialPostDeliveryAuth, false);
AttrSpecialPostDeliveryAuthId = ConvertToRestWithoutDefaults(s.ssSpecialPostDeliveryAuthId, 0);
AttrAmount_DEPREC = ConvertToRestWithoutDefaults(s.ssAmount_DEPREC, 0.0M);
AttrCurrencyId_DEPREC = ConvertToRestWithoutDefaults(s.ssCurrencyId_DEPREC, "");
AttrPaymentMethodId_DEPREC = ConvertToRestWithoutDefaults(s.ssPaymentMethodId_DEPREC, 0L);
AttrPaymentTermId_DEPREC = ConvertToRestWithoutDefaults(s.ssPaymentTermId_DEPREC, 0L);
AttrNegociatedExchangeRateAcc = ConvertToRestWithoutDefaults(s.ssNegociatedExchangeRateAcc, 0.0M);
AttrExchangeRateComment = ConvertToRestWithoutDefaults(s.ssExchangeRateComment, "");
AttrEvidenceFileId = ConvertToRestWithoutDefaults(s.ssEvidenceFileId, 0L);
AttrHasContract = ConvertToRestWithoutDefaults(s.ssHasContract, false);
AttrHasREPSE = ConvertToRestWithoutDefaults(s.ssHasREPSE, false);
AttrHasPaymentSupplement = ConvertToRestWithoutDefaults(s.ssHasPaymentSupplement, false);
AttrHasNoticeOfPaymentSuspension = ConvertToRestWithoutDefaults(s.ssHasNoticeOfPaymentSuspension, false);
  } else {
AttrId = (long?) s.ssId;
AttrRequisitionId = (long?) s.ssRequisitionId;
AttrHasEstim_Equal_AgrePaym_DEPR = (bool?) s.ssHasEstim_Equal_AgrePaym_DEPR;
AttrHasSettlement_DEPR = (bool?) s.ssHasSettlement_DEPR;
AttrHasCreditNote_DEPR = (bool?) s.ssHasCreditNote_DEPR;
AttrHasVoucher_DEPR = (bool?) s.ssHasVoucher_DEPR;
AttrHasSpecialPostDeliveryAuth = (bool?) s.ssHasSpecialPostDeliveryAuth;
AttrSpecialPostDeliveryAuthId = (int?) s.ssSpecialPostDeliveryAuthId;
AttrAmount_DEPREC = (decimal?) s.ssAmount_DEPREC;
AttrCurrencyId_DEPREC = s.ssCurrencyId_DEPREC;
AttrPaymentMethodId_DEPREC = (long?) s.ssPaymentMethodId_DEPREC;
AttrPaymentTermId_DEPREC = (long?) s.ssPaymentTermId_DEPREC;
AttrNegociatedExchangeRateAcc = (decimal?) s.ssNegociatedExchangeRateAcc;
AttrExchangeRateComment = s.ssExchangeRateComment;
AttrEvidenceFileId = (long?) s.ssEvidenceFileId;
AttrHasContract = (bool?) s.ssHasContract;
AttrHasREPSE = (bool?) s.ssHasREPSE;
AttrHasPaymentSupplement = (bool?) s.ssHasPaymentSupplement;
AttrHasNoticeOfPaymentSuspension = (bool?) s.ssHasNoticeOfPaymentSuspension;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONEN_3554712eb61e9f0a2132c551df0f1db5EntityRecord, EN_3554712eb61e9f0a2132c551df0f1db5EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_3554712eb61e9f0a2132c551df0f1db5EntityRecord s) => ToStructure(s, config);
}
public static EN_3554712eb61e9f0a2132c551df0f1db5EntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_3554712eb61e9f0a2132c551df0f1db5EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_3554712eb61e9f0a2132c551df0f1db5EntityRecord s = new EN_3554712eb61e9f0a2132c551df0f1db5EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssRequisitionId = obj.AttrRequisitionId == null ? 0L : obj.AttrRequisitionId.Value;
  s.ssHasEstim_Equal_AgrePaym_DEPR = obj.AttrHasEstim_Equal_AgrePaym_DEPR == null ? false : obj.AttrHasEstim_Equal_AgrePaym_DEPR.Value;
  s.ssHasSettlement_DEPR = obj.AttrHasSettlement_DEPR == null ? false : obj.AttrHasSettlement_DEPR.Value;
  s.ssHasCreditNote_DEPR = obj.AttrHasCreditNote_DEPR == null ? false : obj.AttrHasCreditNote_DEPR.Value;
  s.ssHasVoucher_DEPR = obj.AttrHasVoucher_DEPR == null ? false : obj.AttrHasVoucher_DEPR.Value;
  s.ssHasSpecialPostDeliveryAuth = obj.AttrHasSpecialPostDeliveryAuth == null ? false : obj.AttrHasSpecialPostDeliveryAuth.Value;
  s.ssSpecialPostDeliveryAuthId = obj.AttrSpecialPostDeliveryAuthId == null ? 0 : obj.AttrSpecialPostDeliveryAuthId.Value;
  s.ssAmount_DEPREC = obj.AttrAmount_DEPREC == null ? 0.0M : obj.AttrAmount_DEPREC.Value;
  s.ssCurrencyId_DEPREC = obj.AttrCurrencyId_DEPREC == null ? "" : obj.AttrCurrencyId_DEPREC;
  s.ssPaymentMethodId_DEPREC = obj.AttrPaymentMethodId_DEPREC == null ? 0L : obj.AttrPaymentMethodId_DEPREC.Value;
  s.ssPaymentTermId_DEPREC = obj.AttrPaymentTermId_DEPREC == null ? 0L : obj.AttrPaymentTermId_DEPREC.Value;
  s.ssNegociatedExchangeRateAcc = obj.AttrNegociatedExchangeRateAcc == null ? 0.0M : obj.AttrNegociatedExchangeRateAcc.Value;
  s.ssExchangeRateComment = obj.AttrExchangeRateComment == null ? "" : obj.AttrExchangeRateComment;
  s.ssEvidenceFileId = obj.AttrEvidenceFileId == null ? 0L : obj.AttrEvidenceFileId.Value;
  s.ssHasContract = obj.AttrHasContract == null ? false : obj.AttrHasContract.Value;
  s.ssHasREPSE = obj.AttrHasREPSE == null ? false : obj.AttrHasREPSE.Value;
  s.ssHasPaymentSupplement = obj.AttrHasPaymentSupplement == null ? false : obj.AttrHasPaymentSupplement.Value;
  s.ssHasNoticeOfPaymentSuspension = obj.AttrHasNoticeOfPaymentSuspension == null ? false : obj.AttrHasNoticeOfPaymentSuspension.Value;
  }
  return s;
}

public static Func<EN_3554712eb61e9f0a2132c551df0f1db5EntityRecord, ssConectaProveedores.RestRecords.JSONEN_3554712eb61e9f0a2132c551df0f1db5EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_3554712eb61e9f0a2132c551df0f1db5EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_3554712eb61e9f0a2132c551df0f1db5EntityRecord FromStructure(EN_3554712eb61e9f0a2132c551df0f1db5EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_3554712eb61e9f0a2132c551df0f1db5EntityRecord(s, config);
}

}


