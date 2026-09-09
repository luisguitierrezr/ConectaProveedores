using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderAccounting
public class RESTEN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord : AbstractRESTStructure<EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("OrderId")]
public long? AttrOrderId;

[JsonProperty("HasEstim_Equal_AgrePaym_DEPR")]
public bool? AttrHasEstim_Equal_AgrePaym_DEPR;

[JsonProperty("HasSettlement_DEPR")]
public bool? AttrHasSettlement_DEPR;

[JsonProperty("HasCreditNote_DEPR")]
public bool? AttrHasCreditNote_DEPR;

[JsonProperty("HasVoucher_DEPR")]
public bool? AttrHasVoucher_DEPR;

[JsonProperty("HasSpecialPostDeliveryAuth")]
public bool? AttrHasSpecialPostDeliveryAuth;

[JsonProperty("SpecialPostDeliveryAuthId")]
public int? AttrSpecialPostDeliveryAuthId;

[JsonProperty("Amount_DEPREC")]
public decimal? AttrAmount_DEPREC;

[JsonProperty("CurrencyId_DEPREC")]
public string AttrCurrencyId_DEPREC;

[JsonProperty("PaymentMethodId_DEPREC")]
public long? AttrPaymentMethodId_DEPREC;

[JsonProperty("PaymentTermId_DEPREC")]
public long? AttrPaymentTermId_DEPREC;

[JsonProperty("NegociatedExchangeRateAcc")]
public decimal? AttrNegociatedExchangeRateAcc;

[JsonProperty("ExchangeRateComment")]
public string AttrExchangeRateComment;

[JsonProperty("EvidenceFileId")]
public long? AttrEvidenceFileId;

[JsonProperty("HasContract")]
public bool? AttrHasContract;

[JsonProperty("HasREPSE")]
public bool? AttrHasREPSE;

[JsonProperty("HasPaymentSupplement")]
public bool? AttrHasPaymentSupplement;

[JsonProperty("HasNoticeOfPaymentSuspension")]
public bool? AttrHasNoticeOfPaymentSuspension;

public RESTEN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord() { }

public RESTEN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord (EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrOrderId = ConvertToRestWithoutDefaults(s.ssOrderId, 0L);
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
AttrOrderId = (long?) s.ssOrderId;
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

public static EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord obj) { 
  EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord s = new EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssOrderId = obj.AttrOrderId == null ? 0L : obj.AttrOrderId.Value;
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

public static Func<EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord, ssConectaProveedores.RestRecords.RESTEN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord FromStructure(EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord(s, config);
}

}


