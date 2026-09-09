using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] Requisition (3PhYe+aI7UKw4G2Yo2ZAxg)
///  <code>EN_98680591dcf3728e0877a90eb5e1e552EntityRecord</code> that represent
/// s <code>Requisition</code> <p>Description: Entity that holds Requisition.</p>
/// </summary>
// Name: Requisition
public partial struct EN_98680591dcf3728e0877a90eb5e1e552EntityRecord : ITypedRecord<EN_98680591dcf3728e0877a90eb5e1e552EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*FPldjz9FUEih3TyuDKKvnw");
internal static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*LPzYGjN6bEe3pZzfF+mibQ");
internal static readonly GlobalObjectKey IdCounter = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*IM+yWkv8v0u_9_KgzZr9DA");
internal static readonly GlobalObjectKey IdRequisitionStatusId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*ibLOs8fX10OV7HbEPZKmOQ");
internal static readonly GlobalObjectKey IdSupplierId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*2TbRO4C+v0GitaM3qQ1MFw");
internal static readonly GlobalObjectKey IdRegionId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*vjMGH0dfg0mlJQvETTEJxw");
internal static readonly GlobalObjectKey IdAccountingRegionId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*fPwOWMrEMUaBXQeI+fhvcg");
internal static readonly GlobalObjectKey IdApplicantId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*u59Tj9p190yqhw6EH6i2qA");
internal static readonly GlobalObjectKey IdMaxDateFinishCapture = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*3Wn32xiEiUynCBiirqhMlQ");
internal static readonly GlobalObjectKey IdProjectAssetServiceId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*1bMd_zFomkay4XO2aeNeyw");
internal static readonly GlobalObjectKey IdProjectAssetService = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*HRuO+7kPHE6cTp3Ly2FuQQ");
internal static readonly GlobalObjectKey IdProjectDescription = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*jWD_niAvoke7tnWSntWeCg");
internal static readonly GlobalObjectKey IdFrequencyId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*KYQH1oWNYU+9tnU_t0Drxw");
internal static readonly GlobalObjectKey IdIsSustainability = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*9hVU4D3MxE6apKiFlhErow");
internal static readonly GlobalObjectKey IdSustainabilityId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*KcxEBUZTzEiSgYynug2xPg");
internal static readonly GlobalObjectKey IdBusinessValueCategoryId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*zN0nW0+ExEerTeUNlw4vDQ");
internal static readonly GlobalObjectKey IdBusinessValueSubcategoryId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*4XXk4i4HFU+uvz45w6n8DA");
internal static readonly GlobalObjectKey IdTotalAmount = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*ZrR+Ur1QM0SAVdayJ9u3iQ");
internal static readonly GlobalObjectKey IdCurrencyId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*kNk+X7XtfkGcdga0XWGMxg");
internal static readonly GlobalObjectKey IdDistributionId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*5L7ebpZCFkCNQKs1NH4QFw");
internal static readonly GlobalObjectKey IdCostCenterId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*zTMBZuBhu0KKGWV+bSBxvQ");
internal static readonly GlobalObjectKey IdHasContract = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*xc8no92WuEGIPNTWqR2xCg");
internal static readonly GlobalObjectKey IdIsContractPending = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*vs+AgVq_3ES_vfH+5f9nrg");
internal static readonly GlobalObjectKey IdHasDeposit = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*ADUBvmlAIkWnMrsxaIpr3Q");
internal static readonly GlobalObjectKey IdHasInsurance = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Uf16K4ARSECBp70RmREd5g");
internal static readonly GlobalObjectKey IdHasAdvancePayment = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*QS5ULPyX0kafI7EDu3Yy+Q");
internal static readonly GlobalObjectKey IdAccountingServiceTypeId_DEPR = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*+BPoJMLscUe4F_Wd8qu2uQ");
internal static readonly GlobalObjectKey IdServiceDescription_DEPREC = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*X4b0L0S2TUuIqGMXSPOcvw");
internal static readonly GlobalObjectKey IdInvoiceUsageId_DEPREC = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*OYDc+Q4SWEWCCcjEywICmQ");
internal static readonly GlobalObjectKey IdServiceFormatId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*RZbC+Jr+E06tmritZm6PgQ");
internal static readonly GlobalObjectKey IdCompanyId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*KdqOHDU010SOR6MT1lAHtg");
internal static readonly GlobalObjectKey IdRetentionRate = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*v0K01xE8ekSxqBzolBdr1w");
internal static readonly GlobalObjectKey IdNegotiatedExchangeRate = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*el1rj_ZvyUCqcJdNFrr7qw");
internal static readonly GlobalObjectKey IdPaymentMethodId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Hl8zgKQolEisGrXQMgs8vg");
internal static readonly GlobalObjectKey IdPaymentTermsId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*8_GNtdnmy0mzrYyMOzXi7w");
internal static readonly GlobalObjectKey IdIsAutomaticAccounting = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*l67zfGlR3UqDOm3EaZIKmw");
internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*NKik1eRokk+uBAEvjrhUwQ");
internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*vzA+hxU3U06CwXZh5YevXQ");
internal static readonly GlobalObjectKey IdUpdatedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*W8ieJAzYeEOHv+OeC0loDw");
internal static readonly GlobalObjectKey IdUpdatedBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*xT9w3pTDwE+r2ynXbqSWNw");
internal static readonly GlobalObjectKey IdCreatedByApplicationRole = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*wyAwlR_s_UaER9bhgkyAaQ");
internal static readonly GlobalObjectKey IdDateOfCommitment = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*38aFxenOn0+0dp0683mqjg");
internal static readonly GlobalObjectKey IdHasContractFileUploaded = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*mZD51of2YkeEBzVAJPeKeA");
internal static readonly GlobalObjectKey IdHasUpdatedDateOfCommitment = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*ALh3QW5maUmn2rwWCMUXMQ");
internal static readonly GlobalObjectKey IdSubmittedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*7hnPixMxDUWx9EaaQYNHmg");
internal static readonly GlobalObjectKey IdIsDonation = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*k2qlogZJXk2XxnLq_+RoEQ");
internal static readonly GlobalObjectKey IdAdvWithoutInvoice = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*5CQM7EzfBEiSltVPW8++Mg");
internal static readonly GlobalObjectKey IdWasAdvWithoutInvoice = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*WHVzJCK1uUuQH0GOBeNyxA");
internal static readonly GlobalObjectKey IdIsAdvanced = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*l9SgWU32XUe7uJJJhzK_Gw");
internal static readonly GlobalObjectKey IdDocumentTypeId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*vpGFD7EfakmCz3Gf8D7XPw");
internal static readonly GlobalObjectKey IdIsCreatedByAnAssistente = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*WTc8bY1XbU6Dm4FhuPDwug");
internal static readonly GlobalObjectKey IdTelcelDirectionId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*s5MSkHF5EEOKa4TN3xhOzA");
internal static readonly GlobalObjectKey IdHasMultiUpload = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*FnA9zNotK0CKzzgb6XXkHQ");
internal static readonly GlobalObjectKey IdAccountingDate = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*6K+Y30cZu0K7Lo1PY+7aJA");
internal static readonly GlobalObjectKey IdPaymentOptionsId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Q3UB3_mYLkeu47BOzWZ_Gg");
internal static readonly GlobalObjectKey IdPaymentWaysId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*EV5Kjx46ykaiYtGtVa3jiA");
internal static readonly GlobalObjectKey IdBuyDocNumber = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*FYTw9v+XBUaWcpTV9YfmnQ");
internal static readonly GlobalObjectKey IdBuyDocPosition = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*cCqGhopkgEa+b+elGlSW8w");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(58,true);
          _ssId = value;
      }
  }
}

private string _ssName;
public string ssName{
  get{
      return _ssName;
  }
  set{
      if((_ssName!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssName = value;
      }
  }
}

private int _ssCounter;
public int ssCounter{
  get{
      return _ssCounter;
  }
  set{
      if((_ssCounter!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssCounter = value;
      }
  }
}

private int _ssRequisitionStatusId;
public int ssRequisitionStatusId{
  get{
      return _ssRequisitionStatusId;
  }
  set{
      if((_ssRequisitionStatusId!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssRequisitionStatusId = value;
      }
  }
}

private long _ssSupplierId;
public long ssSupplierId{
  get{
      return _ssSupplierId;
  }
  set{
      if((_ssSupplierId!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssSupplierId = value;
      }
  }
}

private long _ssRegionId;
public long ssRegionId{
  get{
      return _ssRegionId;
  }
  set{
      if((_ssRegionId!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssRegionId = value;
      }
  }
}

private long _ssAccountingRegionId;
public long ssAccountingRegionId{
  get{
      return _ssAccountingRegionId;
  }
  set{
      if((_ssAccountingRegionId!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssAccountingRegionId = value;
      }
  }
}

private string _ssApplicantId;
public string ssApplicantId{
  get{
      return _ssApplicantId;
  }
  set{
      if((_ssApplicantId!=value) || OptimizedAttributes[7]){
          ChangedAttributes[7] = true;
          _ssApplicantId = value;
      }
  }
}

private DateTime _ssMaxDateFinishCapture;
public DateTime ssMaxDateFinishCapture{
  get{
      return _ssMaxDateFinishCapture;
  }
  set{
      if((_ssMaxDateFinishCapture!=value) || OptimizedAttributes[8]){
          ChangedAttributes[8] = true;
          _ssMaxDateFinishCapture = value;
      }
  }
}

private long _ssProjectAssetServiceId;
public long ssProjectAssetServiceId{
  get{
      return _ssProjectAssetServiceId;
  }
  set{
      if((_ssProjectAssetServiceId!=value) || OptimizedAttributes[9]){
          ChangedAttributes[9] = true;
          _ssProjectAssetServiceId = value;
      }
  }
}

private string _ssProjectAssetService;
public string ssProjectAssetService{
  get{
      return _ssProjectAssetService;
  }
  set{
      if((_ssProjectAssetService!=value) || OptimizedAttributes[10]){
          ChangedAttributes[10] = true;
          _ssProjectAssetService = value;
      }
  }
}

private string _ssProjectDescription;
public string ssProjectDescription{
  get{
      return _ssProjectDescription;
  }
  set{
      if((_ssProjectDescription!=value) || OptimizedAttributes[11]){
          ChangedAttributes[11] = true;
          _ssProjectDescription = value;
      }
  }
}

private int _ssFrequencyId;
public int ssFrequencyId{
  get{
      return _ssFrequencyId;
  }
  set{
      if((_ssFrequencyId!=value) || OptimizedAttributes[12]){
          ChangedAttributes[12] = true;
          _ssFrequencyId = value;
      }
  }
}

private bool _ssIsSustainability;
public bool ssIsSustainability{
  get{
      return _ssIsSustainability;
  }
  set{
      if((_ssIsSustainability!=value) || OptimizedAttributes[13]){
          ChangedAttributes[13] = true;
          _ssIsSustainability = value;
      }
  }
}

private long _ssSustainabilityId;
public long ssSustainabilityId{
  get{
      return _ssSustainabilityId;
  }
  set{
      if((_ssSustainabilityId!=value) || OptimizedAttributes[14]){
          ChangedAttributes[14] = true;
          _ssSustainabilityId = value;
      }
  }
}

private long _ssBusinessValueCategoryId;
public long ssBusinessValueCategoryId{
  get{
      return _ssBusinessValueCategoryId;
  }
  set{
      if((_ssBusinessValueCategoryId!=value) || OptimizedAttributes[15]){
          ChangedAttributes[15] = true;
          _ssBusinessValueCategoryId = value;
      }
  }
}

private long _ssBusinessValueSubcategoryId;
public long ssBusinessValueSubcategoryId{
  get{
      return _ssBusinessValueSubcategoryId;
  }
  set{
      if((_ssBusinessValueSubcategoryId!=value) || OptimizedAttributes[16]){
          ChangedAttributes[16] = true;
          _ssBusinessValueSubcategoryId = value;
      }
  }
}

private decimal _ssTotalAmount;
public decimal ssTotalAmount{
  get{
      return _ssTotalAmount;
  }
  set{
      if((_ssTotalAmount!=value) || OptimizedAttributes[17]){
          ChangedAttributes[17] = true;
          _ssTotalAmount = value;
      }
  }
}

private string _ssCurrencyId;
public string ssCurrencyId{
  get{
      return _ssCurrencyId;
  }
  set{
      if((_ssCurrencyId!=value) || OptimizedAttributes[18]){
          ChangedAttributes[18] = true;
          _ssCurrencyId = value;
      }
  }
}

private int _ssDistributionId;
public int ssDistributionId{
  get{
      return _ssDistributionId;
  }
  set{
      if((_ssDistributionId!=value) || OptimizedAttributes[19]){
          ChangedAttributes[19] = true;
          _ssDistributionId = value;
      }
  }
}

private long _ssCostCenterId;
public long ssCostCenterId{
  get{
      return _ssCostCenterId;
  }
  set{
      if((_ssCostCenterId!=value) || OptimizedAttributes[20]){
          ChangedAttributes[20] = true;
          _ssCostCenterId = value;
      }
  }
}

private bool _ssHasContract;
public bool ssHasContract{
  get{
      return _ssHasContract;
  }
  set{
      if((_ssHasContract!=value) || OptimizedAttributes[21]){
          ChangedAttributes[21] = true;
          _ssHasContract = value;
      }
  }
}

private bool _ssIsContractPending;
public bool ssIsContractPending{
  get{
      return _ssIsContractPending;
  }
  set{
      if((_ssIsContractPending!=value) || OptimizedAttributes[22]){
          ChangedAttributes[22] = true;
          _ssIsContractPending = value;
      }
  }
}

private bool _ssHasDeposit;
public bool ssHasDeposit{
  get{
      return _ssHasDeposit;
  }
  set{
      if((_ssHasDeposit!=value) || OptimizedAttributes[23]){
          ChangedAttributes[23] = true;
          _ssHasDeposit = value;
      }
  }
}

private bool _ssHasInsurance;
public bool ssHasInsurance{
  get{
      return _ssHasInsurance;
  }
  set{
      if((_ssHasInsurance!=value) || OptimizedAttributes[24]){
          ChangedAttributes[24] = true;
          _ssHasInsurance = value;
      }
  }
}

private bool _ssHasAdvancePayment;
public bool ssHasAdvancePayment{
  get{
      return _ssHasAdvancePayment;
  }
  set{
      if((_ssHasAdvancePayment!=value) || OptimizedAttributes[25]){
          ChangedAttributes[25] = true;
          _ssHasAdvancePayment = value;
      }
  }
}

private long _ssAccountingServiceTypeId_DEPR;
public long ssAccountingServiceTypeId_DEPR{
  get{
      return _ssAccountingServiceTypeId_DEPR;
  }
  set{
      if((_ssAccountingServiceTypeId_DEPR!=value) || OptimizedAttributes[26]){
          ChangedAttributes[26] = true;
          _ssAccountingServiceTypeId_DEPR = value;
      }
  }
}

private string _ssServiceDescription_DEPREC;
public string ssServiceDescription_DEPREC{
  get{
      return _ssServiceDescription_DEPREC;
  }
  set{
      if((_ssServiceDescription_DEPREC!=value) || OptimizedAttributes[27]){
          ChangedAttributes[27] = true;
          _ssServiceDescription_DEPREC = value;
      }
  }
}

private long _ssInvoiceUsageId_DEPREC;
public long ssInvoiceUsageId_DEPREC{
  get{
      return _ssInvoiceUsageId_DEPREC;
  }
  set{
      if((_ssInvoiceUsageId_DEPREC!=value) || OptimizedAttributes[28]){
          ChangedAttributes[28] = true;
          _ssInvoiceUsageId_DEPREC = value;
      }
  }
}

private long _ssServiceFormatId;
public long ssServiceFormatId{
  get{
      return _ssServiceFormatId;
  }
  set{
      if((_ssServiceFormatId!=value) || OptimizedAttributes[29]){
          ChangedAttributes[29] = true;
          _ssServiceFormatId = value;
      }
  }
}

private long _ssCompanyId;
public long ssCompanyId{
  get{
      return _ssCompanyId;
  }
  set{
      if((_ssCompanyId!=value) || OptimizedAttributes[30]){
          ChangedAttributes[30] = true;
          _ssCompanyId = value;
      }
  }
}

private decimal _ssRetentionRate;
public decimal ssRetentionRate{
  get{
      return _ssRetentionRate;
  }
  set{
      if((_ssRetentionRate!=value) || OptimizedAttributes[31]){
          ChangedAttributes[31] = true;
          _ssRetentionRate = value;
      }
  }
}

private decimal _ssNegotiatedExchangeRate;
public decimal ssNegotiatedExchangeRate{
  get{
      return _ssNegotiatedExchangeRate;
  }
  set{
      if((_ssNegotiatedExchangeRate!=value) || OptimizedAttributes[32]){
          ChangedAttributes[32] = true;
          _ssNegotiatedExchangeRate = value;
      }
  }
}

private long _ssPaymentMethodId;
public long ssPaymentMethodId{
  get{
      return _ssPaymentMethodId;
  }
  set{
      if((_ssPaymentMethodId!=value) || OptimizedAttributes[33]){
          ChangedAttributes[33] = true;
          _ssPaymentMethodId = value;
      }
  }
}

private long _ssPaymentTermsId;
public long ssPaymentTermsId{
  get{
      return _ssPaymentTermsId;
  }
  set{
      if((_ssPaymentTermsId!=value) || OptimizedAttributes[34]){
          ChangedAttributes[34] = true;
          _ssPaymentTermsId = value;
      }
  }
}

private bool _ssIsAutomaticAccounting;
public bool ssIsAutomaticAccounting{
  get{
      return _ssIsAutomaticAccounting;
  }
  set{
      if((_ssIsAutomaticAccounting!=value) || OptimizedAttributes[35]){
          ChangedAttributes[35] = true;
          _ssIsAutomaticAccounting = value;
      }
  }
}

private string _ssCreatedBy;
public string ssCreatedBy{
  get{
      return _ssCreatedBy;
  }
  set{
      if((_ssCreatedBy!=value) || OptimizedAttributes[36]){
          ChangedAttributes[36] = true;
          _ssCreatedBy = value;
      }
  }
}

private DateTime _ssCreatedOn;
public DateTime ssCreatedOn{
  get{
      return _ssCreatedOn;
  }
  set{
      if((_ssCreatedOn!=value) || OptimizedAttributes[37]){
          ChangedAttributes[37] = true;
          _ssCreatedOn = value;
      }
  }
}

private DateTime _ssUpdatedOn;
public DateTime ssUpdatedOn{
  get{
      return _ssUpdatedOn;
  }
  set{
      if((_ssUpdatedOn!=value) || OptimizedAttributes[38]){
          ChangedAttributes[38] = true;
          _ssUpdatedOn = value;
      }
  }
}

private string _ssUpdatedBy;
public string ssUpdatedBy{
  get{
      return _ssUpdatedBy;
  }
  set{
      if((_ssUpdatedBy!=value) || OptimizedAttributes[39]){
          ChangedAttributes[39] = true;
          _ssUpdatedBy = value;
      }
  }
}

private long _ssCreatedByApplicationRole;
public long ssCreatedByApplicationRole{
  get{
      return _ssCreatedByApplicationRole;
  }
  set{
      if((_ssCreatedByApplicationRole!=value) || OptimizedAttributes[40]){
          ChangedAttributes[40] = true;
          _ssCreatedByApplicationRole = value;
      }
  }
}

private DateTime _ssDateOfCommitment;
public DateTime ssDateOfCommitment{
  get{
      return _ssDateOfCommitment;
  }
  set{
      if((_ssDateOfCommitment!=value) || OptimizedAttributes[41]){
          ChangedAttributes[41] = true;
          _ssDateOfCommitment = value;
      }
  }
}

private bool _ssHasContractFileUploaded;
public bool ssHasContractFileUploaded{
  get{
      return _ssHasContractFileUploaded;
  }
  set{
      if((_ssHasContractFileUploaded!=value) || OptimizedAttributes[42]){
          ChangedAttributes[42] = true;
          _ssHasContractFileUploaded = value;
      }
  }
}

private bool _ssHasUpdatedDateOfCommitment;
public bool ssHasUpdatedDateOfCommitment{
  get{
      return _ssHasUpdatedDateOfCommitment;
  }
  set{
      if((_ssHasUpdatedDateOfCommitment!=value) || OptimizedAttributes[43]){
          ChangedAttributes[43] = true;
          _ssHasUpdatedDateOfCommitment = value;
      }
  }
}

private DateTime _ssSubmittedOn;
public DateTime ssSubmittedOn{
  get{
      return _ssSubmittedOn;
  }
  set{
      if((_ssSubmittedOn!=value) || OptimizedAttributes[44]){
          ChangedAttributes[44] = true;
          _ssSubmittedOn = value;
      }
  }
}

private bool _ssIsDonation;
public bool ssIsDonation{
  get{
      return _ssIsDonation;
  }
  set{
      if((_ssIsDonation!=value) || OptimizedAttributes[45]){
          ChangedAttributes[45] = true;
          _ssIsDonation = value;
      }
  }
}

private bool _ssAdvWithoutInvoice;
public bool ssAdvWithoutInvoice{
  get{
      return _ssAdvWithoutInvoice;
  }
  set{
      if((_ssAdvWithoutInvoice!=value) || OptimizedAttributes[46]){
          ChangedAttributes[46] = true;
          _ssAdvWithoutInvoice = value;
      }
  }
}

private bool _ssWasAdvWithoutInvoice;
public bool ssWasAdvWithoutInvoice{
  get{
      return _ssWasAdvWithoutInvoice;
  }
  set{
      if((_ssWasAdvWithoutInvoice!=value) || OptimizedAttributes[47]){
          ChangedAttributes[47] = true;
          _ssWasAdvWithoutInvoice = value;
      }
  }
}

private bool _ssIsAdvanced;
public bool ssIsAdvanced{
  get{
      return _ssIsAdvanced;
  }
  set{
      if((_ssIsAdvanced!=value) || OptimizedAttributes[48]){
          ChangedAttributes[48] = true;
          _ssIsAdvanced = value;
      }
  }
}

private long _ssDocumentTypeId;
public long ssDocumentTypeId{
  get{
      return _ssDocumentTypeId;
  }
  set{
      if((_ssDocumentTypeId!=value) || OptimizedAttributes[49]){
          ChangedAttributes[49] = true;
          _ssDocumentTypeId = value;
      }
  }
}

private bool _ssIsCreatedByAnAssistente;
public bool ssIsCreatedByAnAssistente{
  get{
      return _ssIsCreatedByAnAssistente;
  }
  set{
      if((_ssIsCreatedByAnAssistente!=value) || OptimizedAttributes[50]){
          ChangedAttributes[50] = true;
          _ssIsCreatedByAnAssistente = value;
      }
  }
}

private long _ssTelcelDirectionId;
public long ssTelcelDirectionId{
  get{
      return _ssTelcelDirectionId;
  }
  set{
      if((_ssTelcelDirectionId!=value) || OptimizedAttributes[51]){
          ChangedAttributes[51] = true;
          _ssTelcelDirectionId = value;
      }
  }
}

private bool _ssHasMultiUpload;
public bool ssHasMultiUpload{
  get{
      return _ssHasMultiUpload;
  }
  set{
      if((_ssHasMultiUpload!=value) || OptimizedAttributes[52]){
          ChangedAttributes[52] = true;
          _ssHasMultiUpload = value;
      }
  }
}

private DateTime _ssAccountingDate;
public DateTime ssAccountingDate{
  get{
      return _ssAccountingDate;
  }
  set{
      if((_ssAccountingDate!=value) || OptimizedAttributes[53]){
          ChangedAttributes[53] = true;
          _ssAccountingDate = value;
      }
  }
}

private long _ssPaymentOptionsId;
public long ssPaymentOptionsId{
  get{
      return _ssPaymentOptionsId;
  }
  set{
      if((_ssPaymentOptionsId!=value) || OptimizedAttributes[54]){
          ChangedAttributes[54] = true;
          _ssPaymentOptionsId = value;
      }
  }
}

private long _ssPaymentWaysId;
public long ssPaymentWaysId{
  get{
      return _ssPaymentWaysId;
  }
  set{
      if((_ssPaymentWaysId!=value) || OptimizedAttributes[55]){
          ChangedAttributes[55] = true;
          _ssPaymentWaysId = value;
      }
  }
}

private string _ssBuyDocNumber;
public string ssBuyDocNumber{
  get{
      return _ssBuyDocNumber;
  }
  set{
      if((_ssBuyDocNumber!=value) || OptimizedAttributes[56]){
          ChangedAttributes[56] = true;
          _ssBuyDocNumber = value;
      }
  }
}

private string _ssBuyDocPosition;
public string ssBuyDocPosition{
  get{
      return _ssBuyDocPosition;
  }
  set{
      if((_ssBuyDocPosition!=value) || OptimizedAttributes[57]){
          ChangedAttributes[57] = true;
          _ssBuyDocPosition = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_98680591dcf3728e0877a90eb5e1e552EntityRecord() {
ChangedAttributes = new BitArray(58,true);
OptimizedAttributes = new BitArray(58,false);
_ssId = 0L;
_ssName = "";
_ssCounter = 0;
_ssRequisitionStatusId = 0;
_ssSupplierId = 0L;
_ssRegionId = 0L;
_ssAccountingRegionId = 0L;
_ssApplicantId = "";
_ssMaxDateFinishCapture = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssProjectAssetServiceId = 0L;
_ssProjectAssetService = "";
_ssProjectDescription = "";
_ssFrequencyId = 0;
_ssIsSustainability = false;
_ssSustainabilityId = 0L;
_ssBusinessValueCategoryId = 0L;
_ssBusinessValueSubcategoryId = 0L;
_ssTotalAmount = 0.0M;
_ssCurrencyId = "";
_ssDistributionId = 0;
_ssCostCenterId = 0L;
_ssHasContract = false;
_ssIsContractPending = false;
_ssHasDeposit = false;
_ssHasInsurance = false;
_ssHasAdvancePayment = false;
_ssAccountingServiceTypeId_DEPR = 0L;
_ssServiceDescription_DEPREC = "";
_ssInvoiceUsageId_DEPREC = 0L;
_ssServiceFormatId = 0L;
_ssCompanyId = 0L;
_ssRetentionRate = 0.0M;
_ssNegotiatedExchangeRate = 0.0M;
_ssPaymentMethodId = 0L;
_ssPaymentTermsId = 0L;
_ssIsAutomaticAccounting = false;
_ssCreatedBy = "";
_ssCreatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssUpdatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssUpdatedBy = "";
_ssCreatedByApplicationRole = 0L;
_ssDateOfCommitment = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssHasContractFileUploaded = false;
_ssHasUpdatedDateOfCommitment = false;
_ssSubmittedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssIsDonation = false;
_ssAdvWithoutInvoice = false;
_ssWasAdvWithoutInvoice = false;
_ssIsAdvanced = false;
_ssDocumentTypeId = 0L;
_ssIsCreatedByAnAssistente = false;
_ssTelcelDirectionId = 0L;
_ssHasMultiUpload = false;
_ssAccountingDate = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssPaymentOptionsId = 0L;
_ssPaymentWaysId = 0L;
_ssBuyDocNumber = "";
_ssBuyDocPosition = "";
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[0];
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    }
}
get{
    BitArray[] all = new BitArray[0];
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssId = r.ReadLongInteger(index++, "Requisition.Id", 0L);
ssName = r.ReadText(index++, "Requisition.Name", "");
ssCounter = r.ReadInteger(index++, "Requisition.Counter", 0);
ssRequisitionStatusId = r.ReadEntityReference(index++, "Requisition.RequisitionStatusId", 0);
ssSupplierId = r.ReadEntityReferenceLongInteger(index++, "Requisition.SupplierId", 0L);
ssRegionId = r.ReadEntityReferenceLongInteger(index++, "Requisition.RegionId", 0L);
ssAccountingRegionId = r.ReadEntityReferenceLongInteger(index++, "Requisition.AccountingRegionId", 0L);
ssApplicantId = r.ReadEntityReferenceText(index++, "Requisition.ApplicantId", "");
ssMaxDateFinishCapture = r.ReadDateTime(index++, "Requisition.MaxDateFinishCapture", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssProjectAssetServiceId = r.ReadEntityReferenceLongInteger(index++, "Requisition.ProjectAssetServiceId", 0L);
ssProjectAssetService = r.ReadText(index++, "Requisition.ProjectAssetService", "");
ssProjectDescription = r.ReadText(index++, "Requisition.ProjectDescription", "");
ssFrequencyId = r.ReadEntityReference(index++, "Requisition.FrequencyId", 0);
ssIsSustainability = r.ReadBoolean(index++, "Requisition.IsSustainability", false);
ssSustainabilityId = r.ReadEntityReferenceLongInteger(index++, "Requisition.SustainabilityId", 0L);
ssBusinessValueCategoryId = r.ReadEntityReferenceLongInteger(index++, "Requisition.BusinessValueCategoryId", 0L);
ssBusinessValueSubcategoryId = r.ReadEntityReferenceLongInteger(index++, "Requisition.BusinessValueSubcategoryId", 0L);
ssTotalAmount = r.ReadDecimal(index++, "Requisition.TotalAmount", 0.0M);
ssCurrencyId = r.ReadEntityReferenceText(index++, "Requisition.CurrencyId", "");
ssDistributionId = r.ReadEntityReference(index++, "Requisition.DistributionId", 0);
ssCostCenterId = r.ReadEntityReferenceLongInteger(index++, "Requisition.CostCenterId", 0L);
ssHasContract = r.ReadBoolean(index++, "Requisition.HasContract", false);
ssIsContractPending = r.ReadBoolean(index++, "Requisition.IsContractPending", false);
ssHasDeposit = r.ReadBoolean(index++, "Requisition.HasDeposit", false);
ssHasInsurance = r.ReadBoolean(index++, "Requisition.HasInsurance", false);
ssHasAdvancePayment = r.ReadBoolean(index++, "Requisition.HasAdvancePayment", false);
ssAccountingServiceTypeId_DEPR = r.ReadEntityReferenceLongInteger(index++, "Requisition.AccountingServiceTypeId_DEPR", 0L);
ssServiceDescription_DEPREC = r.ReadText(index++, "Requisition.ServiceDescription_DEPREC", "");
ssInvoiceUsageId_DEPREC = r.ReadEntityReferenceLongInteger(index++, "Requisition.InvoiceUsageId_DEPREC", 0L);
ssServiceFormatId = r.ReadEntityReferenceLongInteger(index++, "Requisition.ServiceFormatId", 0L);
ssCompanyId = r.ReadEntityReferenceLongInteger(index++, "Requisition.CompanyId", 0L);
ssRetentionRate = r.ReadDecimal(index++, "Requisition.RetentionRate", 0.0M);
ssNegotiatedExchangeRate = r.ReadDecimal(index++, "Requisition.NegotiatedExchangeRate", 0.0M);
ssPaymentMethodId = r.ReadEntityReferenceLongInteger(index++, "Requisition.PaymentMethodId", 0L);
ssPaymentTermsId = r.ReadEntityReferenceLongInteger(index++, "Requisition.PaymentTermsId", 0L);
ssIsAutomaticAccounting = r.ReadBoolean(index++, "Requisition.IsAutomaticAccounting", false);
ssCreatedBy = r.ReadEntityReferenceText(index++, "Requisition.CreatedBy", "");
ssCreatedOn = r.ReadDateTime(index++, "Requisition.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssUpdatedOn = r.ReadDateTime(index++, "Requisition.UpdatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssUpdatedBy = r.ReadEntityReferenceText(index++, "Requisition.UpdatedBy", "");
ssCreatedByApplicationRole = r.ReadEntityReferenceLongInteger(index++, "Requisition.CreatedByApplicationRole", 0L);
ssDateOfCommitment = r.ReadDate(index++, "Requisition.DateOfCommitment", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssHasContractFileUploaded = r.ReadBoolean(index++, "Requisition.HasContractFileUploaded", false);
ssHasUpdatedDateOfCommitment = r.ReadBoolean(index++, "Requisition.HasUpdatedDateOfCommitment", false);
ssSubmittedOn = r.ReadDate(index++, "Requisition.SubmittedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssIsDonation = r.ReadBoolean(index++, "Requisition.IsDonation", false);
ssAdvWithoutInvoice = r.ReadBoolean(index++, "Requisition.AdvWithoutInvoice", false);
ssWasAdvWithoutInvoice = r.ReadBoolean(index++, "Requisition.WasAdvWithoutInvoice", false);
ssIsAdvanced = r.ReadBoolean(index++, "Requisition.IsAdvanced", false);
ssDocumentTypeId = r.ReadEntityReferenceLongInteger(index++, "Requisition.DocumentTypeId", 0L);
ssIsCreatedByAnAssistente = r.ReadBoolean(index++, "Requisition.IsCreatedByAnAssistente", false);
ssTelcelDirectionId = r.ReadEntityReferenceLongInteger(index++, "Requisition.TelcelDirectionId", 0L);
ssHasMultiUpload = r.ReadBoolean(index++, "Requisition.HasMultiUpload", false);
ssAccountingDate = r.ReadDate(index++, "Requisition.AccountingDate", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssPaymentOptionsId = r.ReadEntityReferenceLongInteger(index++, "Requisition.PaymentOptionsId", 0L);
ssPaymentWaysId = r.ReadEntityReferenceLongInteger(index++, "Requisition.PaymentWaysId", 0L);
ssBuyDocNumber = r.ReadText(index++, "Requisition.BuyDocNumber", "");
ssBuyDocPosition = r.ReadText(index++, "Requisition.BuyDocPosition", "");
ChangedAttributes = new BitArray(58,false);
OptimizedAttributes = new BitArray(58,false);
}
/// <summary>
/// Read from database
/// </summary>
/// <param name="r"> Data reader</param>
public void ReadDB( DbDataReader r) {
int index = 0;
Read(r, ref index);
}

/// <summary>
/// Read from record
/// </summary>
/// <param name="r"> Record</param>
public void ReadIM(EN_98680591dcf3728e0877a90eb5e1e552EntityRecord r) {
this = r;
}


public static bool operator == (EN_98680591dcf3728e0877a90eb5e1e552EntityRecord a, EN_98680591dcf3728e0877a90eb5e1e552EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssName != b.ssName) return false;
if (a.ssCounter != b.ssCounter) return false;
if (a.ssRequisitionStatusId != b.ssRequisitionStatusId) return false;
if (a.ssSupplierId != b.ssSupplierId) return false;
if (a.ssRegionId != b.ssRegionId) return false;
if (a.ssAccountingRegionId != b.ssAccountingRegionId) return false;
if (a.ssApplicantId != b.ssApplicantId) return false;
if (a.ssMaxDateFinishCapture != b.ssMaxDateFinishCapture) return false;
if (a.ssProjectAssetServiceId != b.ssProjectAssetServiceId) return false;
if (a.ssProjectAssetService != b.ssProjectAssetService) return false;
if (a.ssProjectDescription != b.ssProjectDescription) return false;
if (a.ssFrequencyId != b.ssFrequencyId) return false;
if (a.ssIsSustainability != b.ssIsSustainability) return false;
if (a.ssSustainabilityId != b.ssSustainabilityId) return false;
if (a.ssBusinessValueCategoryId != b.ssBusinessValueCategoryId) return false;
if (a.ssBusinessValueSubcategoryId != b.ssBusinessValueSubcategoryId) return false;
if (a.ssTotalAmount != b.ssTotalAmount) return false;
if (a.ssCurrencyId != b.ssCurrencyId) return false;
if (a.ssDistributionId != b.ssDistributionId) return false;
if (a.ssCostCenterId != b.ssCostCenterId) return false;
if (a.ssHasContract != b.ssHasContract) return false;
if (a.ssIsContractPending != b.ssIsContractPending) return false;
if (a.ssHasDeposit != b.ssHasDeposit) return false;
if (a.ssHasInsurance != b.ssHasInsurance) return false;
if (a.ssHasAdvancePayment != b.ssHasAdvancePayment) return false;
if (a.ssAccountingServiceTypeId_DEPR != b.ssAccountingServiceTypeId_DEPR) return false;
if (a.ssServiceDescription_DEPREC != b.ssServiceDescription_DEPREC) return false;
if (a.ssInvoiceUsageId_DEPREC != b.ssInvoiceUsageId_DEPREC) return false;
if (a.ssServiceFormatId != b.ssServiceFormatId) return false;
if (a.ssCompanyId != b.ssCompanyId) return false;
if (a.ssRetentionRate != b.ssRetentionRate) return false;
if (a.ssNegotiatedExchangeRate != b.ssNegotiatedExchangeRate) return false;
if (a.ssPaymentMethodId != b.ssPaymentMethodId) return false;
if (a.ssPaymentTermsId != b.ssPaymentTermsId) return false;
if (a.ssIsAutomaticAccounting != b.ssIsAutomaticAccounting) return false;
if (a.ssCreatedBy != b.ssCreatedBy) return false;
if (a.ssCreatedOn != b.ssCreatedOn) return false;
if (a.ssUpdatedOn != b.ssUpdatedOn) return false;
if (a.ssUpdatedBy != b.ssUpdatedBy) return false;
if (a.ssCreatedByApplicationRole != b.ssCreatedByApplicationRole) return false;
if (a.ssDateOfCommitment != b.ssDateOfCommitment) return false;
if (a.ssHasContractFileUploaded != b.ssHasContractFileUploaded) return false;
if (a.ssHasUpdatedDateOfCommitment != b.ssHasUpdatedDateOfCommitment) return false;
if (a.ssSubmittedOn != b.ssSubmittedOn) return false;
if (a.ssIsDonation != b.ssIsDonation) return false;
if (a.ssAdvWithoutInvoice != b.ssAdvWithoutInvoice) return false;
if (a.ssWasAdvWithoutInvoice != b.ssWasAdvWithoutInvoice) return false;
if (a.ssIsAdvanced != b.ssIsAdvanced) return false;
if (a.ssDocumentTypeId != b.ssDocumentTypeId) return false;
if (a.ssIsCreatedByAnAssistente != b.ssIsCreatedByAnAssistente) return false;
if (a.ssTelcelDirectionId != b.ssTelcelDirectionId) return false;
if (a.ssHasMultiUpload != b.ssHasMultiUpload) return false;
if (a.ssAccountingDate != b.ssAccountingDate) return false;
if (a.ssPaymentOptionsId != b.ssPaymentOptionsId) return false;
if (a.ssPaymentWaysId != b.ssPaymentWaysId) return false;
if (a.ssBuyDocNumber != b.ssBuyDocNumber) return false;
if (a.ssBuyDocPosition != b.ssBuyDocPosition) return false;
return true;
}

public static bool operator != (EN_98680591dcf3728e0877a90eb5e1e552EntityRecord a, EN_98680591dcf3728e0877a90eb5e1e552EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_98680591dcf3728e0877a90eb5e1e552EntityRecord)) return false;
return (this == (EN_98680591dcf3728e0877a90eb5e1e552EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssName.GetHashCode()
 ^ ssCounter.GetHashCode()
 ^ ssRequisitionStatusId.GetHashCode()
 ^ ssSupplierId.GetHashCode()
 ^ ssRegionId.GetHashCode()
 ^ ssAccountingRegionId.GetHashCode()
 ^ ssApplicantId.GetHashCode()
 ^ ssMaxDateFinishCapture.GetHashCode()
 ^ ssProjectAssetServiceId.GetHashCode()
 ^ ssProjectAssetService.GetHashCode()
 ^ ssProjectDescription.GetHashCode()
 ^ ssFrequencyId.GetHashCode()
 ^ ssIsSustainability.GetHashCode()
 ^ ssSustainabilityId.GetHashCode()
 ^ ssBusinessValueCategoryId.GetHashCode()
 ^ ssBusinessValueSubcategoryId.GetHashCode()
 ^ ssTotalAmount.GetHashCode()
 ^ ssCurrencyId.GetHashCode()
 ^ ssDistributionId.GetHashCode()
 ^ ssCostCenterId.GetHashCode()
 ^ ssHasContract.GetHashCode()
 ^ ssIsContractPending.GetHashCode()
 ^ ssHasDeposit.GetHashCode()
 ^ ssHasInsurance.GetHashCode()
 ^ ssHasAdvancePayment.GetHashCode()
 ^ ssAccountingServiceTypeId_DEPR.GetHashCode()
 ^ ssServiceDescription_DEPREC.GetHashCode()
 ^ ssInvoiceUsageId_DEPREC.GetHashCode()
 ^ ssServiceFormatId.GetHashCode()
 ^ ssCompanyId.GetHashCode()
 ^ ssRetentionRate.GetHashCode()
 ^ ssNegotiatedExchangeRate.GetHashCode()
 ^ ssPaymentMethodId.GetHashCode()
 ^ ssPaymentTermsId.GetHashCode()
 ^ ssIsAutomaticAccounting.GetHashCode()
 ^ ssCreatedBy.GetHashCode()
 ^ ssCreatedOn.GetHashCode()
 ^ ssUpdatedOn.GetHashCode()
 ^ ssUpdatedBy.GetHashCode()
 ^ ssCreatedByApplicationRole.GetHashCode()
 ^ ssDateOfCommitment.GetHashCode()
 ^ ssHasContractFileUploaded.GetHashCode()
 ^ ssHasUpdatedDateOfCommitment.GetHashCode()
 ^ ssSubmittedOn.GetHashCode()
 ^ ssIsDonation.GetHashCode()
 ^ ssAdvWithoutInvoice.GetHashCode()
 ^ ssWasAdvWithoutInvoice.GetHashCode()
 ^ ssIsAdvanced.GetHashCode()
 ^ ssDocumentTypeId.GetHashCode()
 ^ ssIsCreatedByAnAssistente.GetHashCode()
 ^ ssTelcelDirectionId.GetHashCode()
 ^ ssHasMultiUpload.GetHashCode()
 ^ ssAccountingDate.GetHashCode()
 ^ ssPaymentOptionsId.GetHashCode()
 ^ ssPaymentWaysId.GetHashCode()
 ^ ssBuyDocNumber.GetHashCode()
 ^ ssBuyDocPosition.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_98680591dcf3728e0877a90eb5e1e552EntityRecord Duplicate() {
EN_98680591dcf3728e0877a90eb5e1e552EntityRecord t;
t._ssId = this._ssId;
t._ssName = this._ssName;
t._ssCounter = this._ssCounter;
t._ssRequisitionStatusId = this._ssRequisitionStatusId;
t._ssSupplierId = this._ssSupplierId;
t._ssRegionId = this._ssRegionId;
t._ssAccountingRegionId = this._ssAccountingRegionId;
t._ssApplicantId = this._ssApplicantId;
t._ssMaxDateFinishCapture = this._ssMaxDateFinishCapture;
t._ssProjectAssetServiceId = this._ssProjectAssetServiceId;
t._ssProjectAssetService = this._ssProjectAssetService;
t._ssProjectDescription = this._ssProjectDescription;
t._ssFrequencyId = this._ssFrequencyId;
t._ssIsSustainability = this._ssIsSustainability;
t._ssSustainabilityId = this._ssSustainabilityId;
t._ssBusinessValueCategoryId = this._ssBusinessValueCategoryId;
t._ssBusinessValueSubcategoryId = this._ssBusinessValueSubcategoryId;
t._ssTotalAmount = this._ssTotalAmount;
t._ssCurrencyId = this._ssCurrencyId;
t._ssDistributionId = this._ssDistributionId;
t._ssCostCenterId = this._ssCostCenterId;
t._ssHasContract = this._ssHasContract;
t._ssIsContractPending = this._ssIsContractPending;
t._ssHasDeposit = this._ssHasDeposit;
t._ssHasInsurance = this._ssHasInsurance;
t._ssHasAdvancePayment = this._ssHasAdvancePayment;
t._ssAccountingServiceTypeId_DEPR = this._ssAccountingServiceTypeId_DEPR;
t._ssServiceDescription_DEPREC = this._ssServiceDescription_DEPREC;
t._ssInvoiceUsageId_DEPREC = this._ssInvoiceUsageId_DEPREC;
t._ssServiceFormatId = this._ssServiceFormatId;
t._ssCompanyId = this._ssCompanyId;
t._ssRetentionRate = this._ssRetentionRate;
t._ssNegotiatedExchangeRate = this._ssNegotiatedExchangeRate;
t._ssPaymentMethodId = this._ssPaymentMethodId;
t._ssPaymentTermsId = this._ssPaymentTermsId;
t._ssIsAutomaticAccounting = this._ssIsAutomaticAccounting;
t._ssCreatedBy = this._ssCreatedBy;
t._ssCreatedOn = this._ssCreatedOn;
t._ssUpdatedOn = this._ssUpdatedOn;
t._ssUpdatedBy = this._ssUpdatedBy;
t._ssCreatedByApplicationRole = this._ssCreatedByApplicationRole;
t._ssDateOfCommitment = this._ssDateOfCommitment;
t._ssHasContractFileUploaded = this._ssHasContractFileUploaded;
t._ssHasUpdatedDateOfCommitment = this._ssHasUpdatedDateOfCommitment;
t._ssSubmittedOn = this._ssSubmittedOn;
t._ssIsDonation = this._ssIsDonation;
t._ssAdvWithoutInvoice = this._ssAdvWithoutInvoice;
t._ssWasAdvWithoutInvoice = this._ssWasAdvWithoutInvoice;
t._ssIsAdvanced = this._ssIsAdvanced;
t._ssDocumentTypeId = this._ssDocumentTypeId;
t._ssIsCreatedByAnAssistente = this._ssIsCreatedByAnAssistente;
t._ssTelcelDirectionId = this._ssTelcelDirectionId;
t._ssHasMultiUpload = this._ssHasMultiUpload;
t._ssAccountingDate = this._ssAccountingDate;
t._ssPaymentOptionsId = this._ssPaymentOptionsId;
t._ssPaymentWaysId = this._ssPaymentWaysId;
t._ssBuyDocNumber = this._ssBuyDocNumber;
t._ssBuyDocPosition = this._ssBuyDocPosition;
t.ChangedAttributes = new BitArray(58);
t.OptimizedAttributes = new BitArray(58);
for(int i = 0; i < 58; i++){
  t.ChangedAttributes[i] = ChangedAttributes[i];
  t.OptimizedAttributes[i] = OptimizedAttributes[i];
}
return t;
}

IRecord IRecord.Duplicate() {
return Duplicate();
}

public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
throw new System.InvalidOperationException();
}

public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
String head = VarValue.GetHead(fields);
String tail = VarValue.GetTail(fields);
variable.Found = false;
if (head == "id") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Id")) variable.Value = ssId; else variable.Optimized = true;
} else if (head == "name") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Name")) variable.Value = ssName; else variable.Optimized = true;
} else if (head == "counter") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Counter")) variable.Value = ssCounter; else variable.Optimized = true;
} else if (head == "requisitionstatusid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionStatusId")) variable.Value = ssRequisitionStatusId; else variable.Optimized = true;
} else if (head == "supplierid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SupplierId")) variable.Value = ssSupplierId; else variable.Optimized = true;
} else if (head == "regionid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RegionId")) variable.Value = ssRegionId; else variable.Optimized = true;
} else if (head == "accountingregionid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AccountingRegionId")) variable.Value = ssAccountingRegionId; else variable.Optimized = true;
} else if (head == "applicantid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApplicantId")) variable.Value = ssApplicantId; else variable.Optimized = true;
} else if (head == "maxdatefinishcapture") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MaxDateFinishCapture")) variable.Value = ssMaxDateFinishCapture; else variable.Optimized = true;
} else if (head == "projectassetserviceid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProjectAssetServiceId")) variable.Value = ssProjectAssetServiceId; else variable.Optimized = true;
} else if (head == "projectassetservice") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProjectAssetService")) variable.Value = ssProjectAssetService; else variable.Optimized = true;
} else if (head == "projectdescription") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProjectDescription")) variable.Value = ssProjectDescription; else variable.Optimized = true;
} else if (head == "frequencyid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FrequencyId")) variable.Value = ssFrequencyId; else variable.Optimized = true;
} else if (head == "issustainability") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsSustainability")) variable.Value = ssIsSustainability; else variable.Optimized = true;
} else if (head == "sustainabilityid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SustainabilityId")) variable.Value = ssSustainabilityId; else variable.Optimized = true;
} else if (head == "businessvaluecategoryid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".BusinessValueCategoryId")) variable.Value = ssBusinessValueCategoryId; else variable.Optimized = true;
} else if (head == "businessvaluesubcategoryid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".BusinessValueSubcategoryId")) variable.Value = ssBusinessValueSubcategoryId; else variable.Optimized = true;
} else if (head == "totalamount") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TotalAmount")) variable.Value = ssTotalAmount; else variable.Optimized = true;
} else if (head == "currencyid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CurrencyId")) variable.Value = ssCurrencyId; else variable.Optimized = true;
} else if (head == "distributionid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DistributionId")) variable.Value = ssDistributionId; else variable.Optimized = true;
} else if (head == "costcenterid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CostCenterId")) variable.Value = ssCostCenterId; else variable.Optimized = true;
} else if (head == "hascontract") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".HasContract")) variable.Value = ssHasContract; else variable.Optimized = true;
} else if (head == "iscontractpending") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsContractPending")) variable.Value = ssIsContractPending; else variable.Optimized = true;
} else if (head == "hasdeposit") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".HasDeposit")) variable.Value = ssHasDeposit; else variable.Optimized = true;
} else if (head == "hasinsurance") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".HasInsurance")) variable.Value = ssHasInsurance; else variable.Optimized = true;
} else if (head == "hasadvancepayment") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".HasAdvancePayment")) variable.Value = ssHasAdvancePayment; else variable.Optimized = true;
} else if (head == "accountingservicetypeid_depr") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AccountingServiceTypeId_DEPR")) variable.Value = ssAccountingServiceTypeId_DEPR; else variable.Optimized = true;
} else if (head == "servicedescription_deprec") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ServiceDescription_DEPREC")) variable.Value = ssServiceDescription_DEPREC; else variable.Optimized = true;
} else if (head == "invoiceusageid_deprec") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceUsageId_DEPREC")) variable.Value = ssInvoiceUsageId_DEPREC; else variable.Optimized = true;
} else if (head == "serviceformatid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ServiceFormatId")) variable.Value = ssServiceFormatId; else variable.Optimized = true;
} else if (head == "companyid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CompanyId")) variable.Value = ssCompanyId; else variable.Optimized = true;
} else if (head == "retentionrate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RetentionRate")) variable.Value = ssRetentionRate; else variable.Optimized = true;
} else if (head == "negotiatedexchangerate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".NegotiatedExchangeRate")) variable.Value = ssNegotiatedExchangeRate; else variable.Optimized = true;
} else if (head == "paymentmethodid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PaymentMethodId")) variable.Value = ssPaymentMethodId; else variable.Optimized = true;
} else if (head == "paymenttermsid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PaymentTermsId")) variable.Value = ssPaymentTermsId; else variable.Optimized = true;
} else if (head == "isautomaticaccounting") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsAutomaticAccounting")) variable.Value = ssIsAutomaticAccounting; else variable.Optimized = true;
} else if (head == "createdby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedBy")) variable.Value = ssCreatedBy; else variable.Optimized = true;
} else if (head == "createdon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedOn")) variable.Value = ssCreatedOn; else variable.Optimized = true;
} else if (head == "updatedon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdatedOn")) variable.Value = ssUpdatedOn; else variable.Optimized = true;
} else if (head == "updatedby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdatedBy")) variable.Value = ssUpdatedBy; else variable.Optimized = true;
} else if (head == "createdbyapplicationrole") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedByApplicationRole")) variable.Value = ssCreatedByApplicationRole; else variable.Optimized = true;
} else if (head == "dateofcommitment") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DateOfCommitment")) variable.Value = ssDateOfCommitment; else variable.Optimized = true;
} else if (head == "hascontractfileuploaded") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".HasContractFileUploaded")) variable.Value = ssHasContractFileUploaded; else variable.Optimized = true;
} else if (head == "hasupdateddateofcommitment") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".HasUpdatedDateOfCommitment")) variable.Value = ssHasUpdatedDateOfCommitment; else variable.Optimized = true;
} else if (head == "submittedon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SubmittedOn")) variable.Value = ssSubmittedOn; else variable.Optimized = true;
} else if (head == "isdonation") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsDonation")) variable.Value = ssIsDonation; else variable.Optimized = true;
} else if (head == "advwithoutinvoice") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AdvWithoutInvoice")) variable.Value = ssAdvWithoutInvoice; else variable.Optimized = true;
} else if (head == "wasadvwithoutinvoice") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".WasAdvWithoutInvoice")) variable.Value = ssWasAdvWithoutInvoice; else variable.Optimized = true;
} else if (head == "isadvanced") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsAdvanced")) variable.Value = ssIsAdvanced; else variable.Optimized = true;
} else if (head == "documenttypeid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DocumentTypeId")) variable.Value = ssDocumentTypeId; else variable.Optimized = true;
} else if (head == "iscreatedbyanassistente") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsCreatedByAnAssistente")) variable.Value = ssIsCreatedByAnAssistente; else variable.Optimized = true;
} else if (head == "telceldirectionid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TelcelDirectionId")) variable.Value = ssTelcelDirectionId; else variable.Optimized = true;
} else if (head == "hasmultiupload") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".HasMultiUpload")) variable.Value = ssHasMultiUpload; else variable.Optimized = true;
} else if (head == "accountingdate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AccountingDate")) variable.Value = ssAccountingDate; else variable.Optimized = true;
} else if (head == "paymentoptionsid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PaymentOptionsId")) variable.Value = ssPaymentOptionsId; else variable.Optimized = true;
} else if (head == "paymentwaysid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PaymentWaysId")) variable.Value = ssPaymentWaysId; else variable.Optimized = true;
} else if (head == "buydocnumber") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".BuyDocNumber")) variable.Value = ssBuyDocNumber; else variable.Optimized = true;
} else if (head == "buydocposition") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".BuyDocPosition")) variable.Value = ssBuyDocPosition; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdName)) {
return ChangedAttributes[1];
}
if (key.Equals(IdCounter)) {
return ChangedAttributes[2];
}
if (key.Equals(IdRequisitionStatusId)) {
return ChangedAttributes[3];
}
if (key.Equals(IdSupplierId)) {
return ChangedAttributes[4];
}
if (key.Equals(IdRegionId)) {
return ChangedAttributes[5];
}
if (key.Equals(IdAccountingRegionId)) {
return ChangedAttributes[6];
}
if (key.Equals(IdApplicantId)) {
return ChangedAttributes[7];
}
if (key.Equals(IdMaxDateFinishCapture)) {
return ChangedAttributes[8];
}
if (key.Equals(IdProjectAssetServiceId)) {
return ChangedAttributes[9];
}
if (key.Equals(IdProjectAssetService)) {
return ChangedAttributes[10];
}
if (key.Equals(IdProjectDescription)) {
return ChangedAttributes[11];
}
if (key.Equals(IdFrequencyId)) {
return ChangedAttributes[12];
}
if (key.Equals(IdIsSustainability)) {
return ChangedAttributes[13];
}
if (key.Equals(IdSustainabilityId)) {
return ChangedAttributes[14];
}
if (key.Equals(IdBusinessValueCategoryId)) {
return ChangedAttributes[15];
}
if (key.Equals(IdBusinessValueSubcategoryId)) {
return ChangedAttributes[16];
}
if (key.Equals(IdTotalAmount)) {
return ChangedAttributes[17];
}
if (key.Equals(IdCurrencyId)) {
return ChangedAttributes[18];
}
if (key.Equals(IdDistributionId)) {
return ChangedAttributes[19];
}
if (key.Equals(IdCostCenterId)) {
return ChangedAttributes[20];
}
if (key.Equals(IdHasContract)) {
return ChangedAttributes[21];
}
if (key.Equals(IdIsContractPending)) {
return ChangedAttributes[22];
}
if (key.Equals(IdHasDeposit)) {
return ChangedAttributes[23];
}
if (key.Equals(IdHasInsurance)) {
return ChangedAttributes[24];
}
if (key.Equals(IdHasAdvancePayment)) {
return ChangedAttributes[25];
}
if (key.Equals(IdAccountingServiceTypeId_DEPR)) {
return ChangedAttributes[26];
}
if (key.Equals(IdServiceDescription_DEPREC)) {
return ChangedAttributes[27];
}
if (key.Equals(IdInvoiceUsageId_DEPREC)) {
return ChangedAttributes[28];
}
if (key.Equals(IdServiceFormatId)) {
return ChangedAttributes[29];
}
if (key.Equals(IdCompanyId)) {
return ChangedAttributes[30];
}
if (key.Equals(IdRetentionRate)) {
return ChangedAttributes[31];
}
if (key.Equals(IdNegotiatedExchangeRate)) {
return ChangedAttributes[32];
}
if (key.Equals(IdPaymentMethodId)) {
return ChangedAttributes[33];
}
if (key.Equals(IdPaymentTermsId)) {
return ChangedAttributes[34];
}
if (key.Equals(IdIsAutomaticAccounting)) {
return ChangedAttributes[35];
}
if (key.Equals(IdCreatedBy)) {
return ChangedAttributes[36];
}
if (key.Equals(IdCreatedOn)) {
return ChangedAttributes[37];
}
if (key.Equals(IdUpdatedOn)) {
return ChangedAttributes[38];
}
if (key.Equals(IdUpdatedBy)) {
return ChangedAttributes[39];
}
if (key.Equals(IdCreatedByApplicationRole)) {
return ChangedAttributes[40];
}
if (key.Equals(IdDateOfCommitment)) {
return ChangedAttributes[41];
}
if (key.Equals(IdHasContractFileUploaded)) {
return ChangedAttributes[42];
}
if (key.Equals(IdHasUpdatedDateOfCommitment)) {
return ChangedAttributes[43];
}
if (key.Equals(IdSubmittedOn)) {
return ChangedAttributes[44];
}
if (key.Equals(IdIsDonation)) {
return ChangedAttributes[45];
}
if (key.Equals(IdAdvWithoutInvoice)) {
return ChangedAttributes[46];
}
if (key.Equals(IdWasAdvWithoutInvoice)) {
return ChangedAttributes[47];
}
if (key.Equals(IdIsAdvanced)) {
return ChangedAttributes[48];
}
if (key.Equals(IdDocumentTypeId)) {
return ChangedAttributes[49];
}
if (key.Equals(IdIsCreatedByAnAssistente)) {
return ChangedAttributes[50];
}
if (key.Equals(IdTelcelDirectionId)) {
return ChangedAttributes[51];
}
if (key.Equals(IdHasMultiUpload)) {
return ChangedAttributes[52];
}
if (key.Equals(IdAccountingDate)) {
return ChangedAttributes[53];
}
if (key.Equals(IdPaymentOptionsId)) {
return ChangedAttributes[54];
}
if (key.Equals(IdPaymentWaysId)) {
return ChangedAttributes[55];
}
if (key.Equals(IdBuyDocNumber)) {
return ChangedAttributes[56];
}
if (key.Equals(IdBuyDocPosition)) {
return ChangedAttributes[57];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdName)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdCounter)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdRequisitionStatusId)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdSupplierId)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdRegionId)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdAccountingRegionId)) {
return OptimizedAttributes[6];
}
if (key.Equals(IdApplicantId)) {
return OptimizedAttributes[7];
}
if (key.Equals(IdMaxDateFinishCapture)) {
return OptimizedAttributes[8];
}
if (key.Equals(IdProjectAssetServiceId)) {
return OptimizedAttributes[9];
}
if (key.Equals(IdProjectAssetService)) {
return OptimizedAttributes[10];
}
if (key.Equals(IdProjectDescription)) {
return OptimizedAttributes[11];
}
if (key.Equals(IdFrequencyId)) {
return OptimizedAttributes[12];
}
if (key.Equals(IdIsSustainability)) {
return OptimizedAttributes[13];
}
if (key.Equals(IdSustainabilityId)) {
return OptimizedAttributes[14];
}
if (key.Equals(IdBusinessValueCategoryId)) {
return OptimizedAttributes[15];
}
if (key.Equals(IdBusinessValueSubcategoryId)) {
return OptimizedAttributes[16];
}
if (key.Equals(IdTotalAmount)) {
return OptimizedAttributes[17];
}
if (key.Equals(IdCurrencyId)) {
return OptimizedAttributes[18];
}
if (key.Equals(IdDistributionId)) {
return OptimizedAttributes[19];
}
if (key.Equals(IdCostCenterId)) {
return OptimizedAttributes[20];
}
if (key.Equals(IdHasContract)) {
return OptimizedAttributes[21];
}
if (key.Equals(IdIsContractPending)) {
return OptimizedAttributes[22];
}
if (key.Equals(IdHasDeposit)) {
return OptimizedAttributes[23];
}
if (key.Equals(IdHasInsurance)) {
return OptimizedAttributes[24];
}
if (key.Equals(IdHasAdvancePayment)) {
return OptimizedAttributes[25];
}
if (key.Equals(IdAccountingServiceTypeId_DEPR)) {
return OptimizedAttributes[26];
}
if (key.Equals(IdServiceDescription_DEPREC)) {
return OptimizedAttributes[27];
}
if (key.Equals(IdInvoiceUsageId_DEPREC)) {
return OptimizedAttributes[28];
}
if (key.Equals(IdServiceFormatId)) {
return OptimizedAttributes[29];
}
if (key.Equals(IdCompanyId)) {
return OptimizedAttributes[30];
}
if (key.Equals(IdRetentionRate)) {
return OptimizedAttributes[31];
}
if (key.Equals(IdNegotiatedExchangeRate)) {
return OptimizedAttributes[32];
}
if (key.Equals(IdPaymentMethodId)) {
return OptimizedAttributes[33];
}
if (key.Equals(IdPaymentTermsId)) {
return OptimizedAttributes[34];
}
if (key.Equals(IdIsAutomaticAccounting)) {
return OptimizedAttributes[35];
}
if (key.Equals(IdCreatedBy)) {
return OptimizedAttributes[36];
}
if (key.Equals(IdCreatedOn)) {
return OptimizedAttributes[37];
}
if (key.Equals(IdUpdatedOn)) {
return OptimizedAttributes[38];
}
if (key.Equals(IdUpdatedBy)) {
return OptimizedAttributes[39];
}
if (key.Equals(IdCreatedByApplicationRole)) {
return OptimizedAttributes[40];
}
if (key.Equals(IdDateOfCommitment)) {
return OptimizedAttributes[41];
}
if (key.Equals(IdHasContractFileUploaded)) {
return OptimizedAttributes[42];
}
if (key.Equals(IdHasUpdatedDateOfCommitment)) {
return OptimizedAttributes[43];
}
if (key.Equals(IdSubmittedOn)) {
return OptimizedAttributes[44];
}
if (key.Equals(IdIsDonation)) {
return OptimizedAttributes[45];
}
if (key.Equals(IdAdvWithoutInvoice)) {
return OptimizedAttributes[46];
}
if (key.Equals(IdWasAdvWithoutInvoice)) {
return OptimizedAttributes[47];
}
if (key.Equals(IdIsAdvanced)) {
return OptimizedAttributes[48];
}
if (key.Equals(IdDocumentTypeId)) {
return OptimizedAttributes[49];
}
if (key.Equals(IdIsCreatedByAnAssistente)) {
return OptimizedAttributes[50];
}
if (key.Equals(IdTelcelDirectionId)) {
return OptimizedAttributes[51];
}
if (key.Equals(IdHasMultiUpload)) {
return OptimizedAttributes[52];
}
if (key.Equals(IdAccountingDate)) {
return OptimizedAttributes[53];
}
if (key.Equals(IdPaymentOptionsId)) {
return OptimizedAttributes[54];
}
if (key.Equals(IdPaymentWaysId)) {
return OptimizedAttributes[55];
}
if (key.Equals(IdBuyDocNumber)) {
return OptimizedAttributes[56];
}
if (key.Equals(IdBuyDocPosition)) {
return OptimizedAttributes[57];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdName) {
return ssName;
}
if (key == IdCounter) {
return ssCounter;
}
if (key == IdRequisitionStatusId) {
return ssRequisitionStatusId;
}
if (key == IdSupplierId) {
return ssSupplierId;
}
if (key == IdRegionId) {
return ssRegionId;
}
if (key == IdAccountingRegionId) {
return ssAccountingRegionId;
}
if (key == IdApplicantId) {
return ssApplicantId;
}
if (key == IdMaxDateFinishCapture) {
return ssMaxDateFinishCapture;
}
if (key == IdProjectAssetServiceId) {
return ssProjectAssetServiceId;
}
if (key == IdProjectAssetService) {
return ssProjectAssetService;
}
if (key == IdProjectDescription) {
return ssProjectDescription;
}
if (key == IdFrequencyId) {
return ssFrequencyId;
}
if (key == IdIsSustainability) {
return ssIsSustainability;
}
if (key == IdSustainabilityId) {
return ssSustainabilityId;
}
if (key == IdBusinessValueCategoryId) {
return ssBusinessValueCategoryId;
}
if (key == IdBusinessValueSubcategoryId) {
return ssBusinessValueSubcategoryId;
}
if (key == IdTotalAmount) {
return ssTotalAmount;
}
if (key == IdCurrencyId) {
return ssCurrencyId;
}
if (key == IdDistributionId) {
return ssDistributionId;
}
if (key == IdCostCenterId) {
return ssCostCenterId;
}
if (key == IdHasContract) {
return ssHasContract;
}
if (key == IdIsContractPending) {
return ssIsContractPending;
}
if (key == IdHasDeposit) {
return ssHasDeposit;
}
if (key == IdHasInsurance) {
return ssHasInsurance;
}
if (key == IdHasAdvancePayment) {
return ssHasAdvancePayment;
}
if (key == IdAccountingServiceTypeId_DEPR) {
return ssAccountingServiceTypeId_DEPR;
}
if (key == IdServiceDescription_DEPREC) {
return ssServiceDescription_DEPREC;
}
if (key == IdInvoiceUsageId_DEPREC) {
return ssInvoiceUsageId_DEPREC;
}
if (key == IdServiceFormatId) {
return ssServiceFormatId;
}
if (key == IdCompanyId) {
return ssCompanyId;
}
if (key == IdRetentionRate) {
return ssRetentionRate;
}
if (key == IdNegotiatedExchangeRate) {
return ssNegotiatedExchangeRate;
}
if (key == IdPaymentMethodId) {
return ssPaymentMethodId;
}
if (key == IdPaymentTermsId) {
return ssPaymentTermsId;
}
if (key == IdIsAutomaticAccounting) {
return ssIsAutomaticAccounting;
}
if (key == IdCreatedBy) {
return ssCreatedBy;
}
if (key == IdCreatedOn) {
return ssCreatedOn;
}
if (key == IdUpdatedOn) {
return ssUpdatedOn;
}
if (key == IdUpdatedBy) {
return ssUpdatedBy;
}
if (key == IdCreatedByApplicationRole) {
return ssCreatedByApplicationRole;
}
if (key == IdDateOfCommitment) {
return ssDateOfCommitment;
}
if (key == IdHasContractFileUploaded) {
return ssHasContractFileUploaded;
}
if (key == IdHasUpdatedDateOfCommitment) {
return ssHasUpdatedDateOfCommitment;
}
if (key == IdSubmittedOn) {
return ssSubmittedOn;
}
if (key == IdIsDonation) {
return ssIsDonation;
}
if (key == IdAdvWithoutInvoice) {
return ssAdvWithoutInvoice;
}
if (key == IdWasAdvWithoutInvoice) {
return ssWasAdvWithoutInvoice;
}
if (key == IdIsAdvanced) {
return ssIsAdvanced;
}
if (key == IdDocumentTypeId) {
return ssDocumentTypeId;
}
if (key == IdIsCreatedByAnAssistente) {
return ssIsCreatedByAnAssistente;
}
if (key == IdTelcelDirectionId) {
return ssTelcelDirectionId;
}
if (key == IdHasMultiUpload) {
return ssHasMultiUpload;
}
if (key == IdAccountingDate) {
return ssAccountingDate;
}
if (key == IdPaymentOptionsId) {
return ssPaymentOptionsId;
}
if (key == IdPaymentWaysId) {
return ssPaymentWaysId;
}
if (key == IdBuyDocNumber) {
return ssBuyDocNumber;
}
if (key == IdBuyDocPosition) {
return ssBuyDocPosition;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdName.Key.AsGuid) {
return ssName;
}
if (attributeKey == IdCounter.Key.AsGuid) {
return ssCounter;
}
if (attributeKey == IdRequisitionStatusId.Key.AsGuid) {
return ssRequisitionStatusId;
}
if (attributeKey == IdSupplierId.Key.AsGuid) {
return ssSupplierId;
}
if (attributeKey == IdRegionId.Key.AsGuid) {
return ssRegionId;
}
if (attributeKey == IdAccountingRegionId.Key.AsGuid) {
return ssAccountingRegionId;
}
if (attributeKey == IdApplicantId.Key.AsGuid) {
return ssApplicantId;
}
if (attributeKey == IdMaxDateFinishCapture.Key.AsGuid) {
return ssMaxDateFinishCapture;
}
if (attributeKey == IdProjectAssetServiceId.Key.AsGuid) {
return ssProjectAssetServiceId;
}
if (attributeKey == IdProjectAssetService.Key.AsGuid) {
return ssProjectAssetService;
}
if (attributeKey == IdProjectDescription.Key.AsGuid) {
return ssProjectDescription;
}
if (attributeKey == IdFrequencyId.Key.AsGuid) {
return ssFrequencyId;
}
if (attributeKey == IdIsSustainability.Key.AsGuid) {
return ssIsSustainability;
}
if (attributeKey == IdSustainabilityId.Key.AsGuid) {
return ssSustainabilityId;
}
if (attributeKey == IdBusinessValueCategoryId.Key.AsGuid) {
return ssBusinessValueCategoryId;
}
if (attributeKey == IdBusinessValueSubcategoryId.Key.AsGuid) {
return ssBusinessValueSubcategoryId;
}
if (attributeKey == IdTotalAmount.Key.AsGuid) {
return ssTotalAmount;
}
if (attributeKey == IdCurrencyId.Key.AsGuid) {
return ssCurrencyId;
}
if (attributeKey == IdDistributionId.Key.AsGuid) {
return ssDistributionId;
}
if (attributeKey == IdCostCenterId.Key.AsGuid) {
return ssCostCenterId;
}
if (attributeKey == IdHasContract.Key.AsGuid) {
return ssHasContract;
}
if (attributeKey == IdIsContractPending.Key.AsGuid) {
return ssIsContractPending;
}
if (attributeKey == IdHasDeposit.Key.AsGuid) {
return ssHasDeposit;
}
if (attributeKey == IdHasInsurance.Key.AsGuid) {
return ssHasInsurance;
}
if (attributeKey == IdHasAdvancePayment.Key.AsGuid) {
return ssHasAdvancePayment;
}
if (attributeKey == IdAccountingServiceTypeId_DEPR.Key.AsGuid) {
return ssAccountingServiceTypeId_DEPR;
}
if (attributeKey == IdServiceDescription_DEPREC.Key.AsGuid) {
return ssServiceDescription_DEPREC;
}
if (attributeKey == IdInvoiceUsageId_DEPREC.Key.AsGuid) {
return ssInvoiceUsageId_DEPREC;
}
if (attributeKey == IdServiceFormatId.Key.AsGuid) {
return ssServiceFormatId;
}
if (attributeKey == IdCompanyId.Key.AsGuid) {
return ssCompanyId;
}
if (attributeKey == IdRetentionRate.Key.AsGuid) {
return ssRetentionRate;
}
if (attributeKey == IdNegotiatedExchangeRate.Key.AsGuid) {
return ssNegotiatedExchangeRate;
}
if (attributeKey == IdPaymentMethodId.Key.AsGuid) {
return ssPaymentMethodId;
}
if (attributeKey == IdPaymentTermsId.Key.AsGuid) {
return ssPaymentTermsId;
}
if (attributeKey == IdIsAutomaticAccounting.Key.AsGuid) {
return ssIsAutomaticAccounting;
}
if (attributeKey == IdCreatedBy.Key.AsGuid) {
return ssCreatedBy;
}
if (attributeKey == IdCreatedOn.Key.AsGuid) {
return ssCreatedOn;
}
if (attributeKey == IdUpdatedOn.Key.AsGuid) {
return ssUpdatedOn;
}
if (attributeKey == IdUpdatedBy.Key.AsGuid) {
return ssUpdatedBy;
}
if (attributeKey == IdCreatedByApplicationRole.Key.AsGuid) {
return ssCreatedByApplicationRole;
}
if (attributeKey == IdDateOfCommitment.Key.AsGuid) {
return ssDateOfCommitment;
}
if (attributeKey == IdHasContractFileUploaded.Key.AsGuid) {
return ssHasContractFileUploaded;
}
if (attributeKey == IdHasUpdatedDateOfCommitment.Key.AsGuid) {
return ssHasUpdatedDateOfCommitment;
}
if (attributeKey == IdSubmittedOn.Key.AsGuid) {
return ssSubmittedOn;
}
if (attributeKey == IdIsDonation.Key.AsGuid) {
return ssIsDonation;
}
if (attributeKey == IdAdvWithoutInvoice.Key.AsGuid) {
return ssAdvWithoutInvoice;
}
if (attributeKey == IdWasAdvWithoutInvoice.Key.AsGuid) {
return ssWasAdvWithoutInvoice;
}
if (attributeKey == IdIsAdvanced.Key.AsGuid) {
return ssIsAdvanced;
}
if (attributeKey == IdDocumentTypeId.Key.AsGuid) {
return ssDocumentTypeId;
}
if (attributeKey == IdIsCreatedByAnAssistente.Key.AsGuid) {
return ssIsCreatedByAnAssistente;
}
if (attributeKey == IdTelcelDirectionId.Key.AsGuid) {
return ssTelcelDirectionId;
}
if (attributeKey == IdHasMultiUpload.Key.AsGuid) {
return ssHasMultiUpload;
}
if (attributeKey == IdAccountingDate.Key.AsGuid) {
return ssAccountingDate;
}
if (attributeKey == IdPaymentOptionsId.Key.AsGuid) {
return ssPaymentOptionsId;
}
if (attributeKey == IdPaymentWaysId.Key.AsGuid) {
return ssPaymentWaysId;
}
if (attributeKey == IdBuyDocNumber.Key.AsGuid) {
return ssBuyDocNumber;
}
if (attributeKey == IdBuyDocPosition.Key.AsGuid) {
return ssBuyDocPosition;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(58);
OptimizedAttributes = new BitArray(58);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssName = (string) other.AttributeGet(IdName);
ChangedAttributes[1] = other.ChangedAttributeGet(IdName);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdName);
ssCounter = (int) other.AttributeGet(IdCounter);
ChangedAttributes[2] = other.ChangedAttributeGet(IdCounter);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdCounter);
ssRequisitionStatusId = (int) other.AttributeGet(IdRequisitionStatusId);
ChangedAttributes[3] = other.ChangedAttributeGet(IdRequisitionStatusId);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdRequisitionStatusId);
ssSupplierId = (long) other.AttributeGet(IdSupplierId);
ChangedAttributes[4] = other.ChangedAttributeGet(IdSupplierId);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdSupplierId);
ssRegionId = (long) other.AttributeGet(IdRegionId);
ChangedAttributes[5] = other.ChangedAttributeGet(IdRegionId);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdRegionId);
ssAccountingRegionId = (long) other.AttributeGet(IdAccountingRegionId);
ChangedAttributes[6] = other.ChangedAttributeGet(IdAccountingRegionId);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdAccountingRegionId);
ssApplicantId = (string) other.AttributeGet(IdApplicantId);
ChangedAttributes[7] = other.ChangedAttributeGet(IdApplicantId);
OptimizedAttributes[7] = other.OptimizedAttributeGet(IdApplicantId);
ssMaxDateFinishCapture = (DateTime) other.AttributeGet(IdMaxDateFinishCapture);
ChangedAttributes[8] = other.ChangedAttributeGet(IdMaxDateFinishCapture);
OptimizedAttributes[8] = other.OptimizedAttributeGet(IdMaxDateFinishCapture);
ssProjectAssetServiceId = (long) other.AttributeGet(IdProjectAssetServiceId);
ChangedAttributes[9] = other.ChangedAttributeGet(IdProjectAssetServiceId);
OptimizedAttributes[9] = other.OptimizedAttributeGet(IdProjectAssetServiceId);
ssProjectAssetService = (string) other.AttributeGet(IdProjectAssetService);
ChangedAttributes[10] = other.ChangedAttributeGet(IdProjectAssetService);
OptimizedAttributes[10] = other.OptimizedAttributeGet(IdProjectAssetService);
ssProjectDescription = (string) other.AttributeGet(IdProjectDescription);
ChangedAttributes[11] = other.ChangedAttributeGet(IdProjectDescription);
OptimizedAttributes[11] = other.OptimizedAttributeGet(IdProjectDescription);
ssFrequencyId = (int) other.AttributeGet(IdFrequencyId);
ChangedAttributes[12] = other.ChangedAttributeGet(IdFrequencyId);
OptimizedAttributes[12] = other.OptimizedAttributeGet(IdFrequencyId);
ssIsSustainability = (bool) other.AttributeGet(IdIsSustainability);
ChangedAttributes[13] = other.ChangedAttributeGet(IdIsSustainability);
OptimizedAttributes[13] = other.OptimizedAttributeGet(IdIsSustainability);
ssSustainabilityId = (long) other.AttributeGet(IdSustainabilityId);
ChangedAttributes[14] = other.ChangedAttributeGet(IdSustainabilityId);
OptimizedAttributes[14] = other.OptimizedAttributeGet(IdSustainabilityId);
ssBusinessValueCategoryId = (long) other.AttributeGet(IdBusinessValueCategoryId);
ChangedAttributes[15] = other.ChangedAttributeGet(IdBusinessValueCategoryId);
OptimizedAttributes[15] = other.OptimizedAttributeGet(IdBusinessValueCategoryId);
ssBusinessValueSubcategoryId = (long) other.AttributeGet(IdBusinessValueSubcategoryId);
ChangedAttributes[16] = other.ChangedAttributeGet(IdBusinessValueSubcategoryId);
OptimizedAttributes[16] = other.OptimizedAttributeGet(IdBusinessValueSubcategoryId);
ssTotalAmount = (decimal) other.AttributeGet(IdTotalAmount);
ChangedAttributes[17] = other.ChangedAttributeGet(IdTotalAmount);
OptimizedAttributes[17] = other.OptimizedAttributeGet(IdTotalAmount);
ssCurrencyId = (string) other.AttributeGet(IdCurrencyId);
ChangedAttributes[18] = other.ChangedAttributeGet(IdCurrencyId);
OptimizedAttributes[18] = other.OptimizedAttributeGet(IdCurrencyId);
ssDistributionId = (int) other.AttributeGet(IdDistributionId);
ChangedAttributes[19] = other.ChangedAttributeGet(IdDistributionId);
OptimizedAttributes[19] = other.OptimizedAttributeGet(IdDistributionId);
ssCostCenterId = (long) other.AttributeGet(IdCostCenterId);
ChangedAttributes[20] = other.ChangedAttributeGet(IdCostCenterId);
OptimizedAttributes[20] = other.OptimizedAttributeGet(IdCostCenterId);
ssHasContract = (bool) other.AttributeGet(IdHasContract);
ChangedAttributes[21] = other.ChangedAttributeGet(IdHasContract);
OptimizedAttributes[21] = other.OptimizedAttributeGet(IdHasContract);
ssIsContractPending = (bool) other.AttributeGet(IdIsContractPending);
ChangedAttributes[22] = other.ChangedAttributeGet(IdIsContractPending);
OptimizedAttributes[22] = other.OptimizedAttributeGet(IdIsContractPending);
ssHasDeposit = (bool) other.AttributeGet(IdHasDeposit);
ChangedAttributes[23] = other.ChangedAttributeGet(IdHasDeposit);
OptimizedAttributes[23] = other.OptimizedAttributeGet(IdHasDeposit);
ssHasInsurance = (bool) other.AttributeGet(IdHasInsurance);
ChangedAttributes[24] = other.ChangedAttributeGet(IdHasInsurance);
OptimizedAttributes[24] = other.OptimizedAttributeGet(IdHasInsurance);
ssHasAdvancePayment = (bool) other.AttributeGet(IdHasAdvancePayment);
ChangedAttributes[25] = other.ChangedAttributeGet(IdHasAdvancePayment);
OptimizedAttributes[25] = other.OptimizedAttributeGet(IdHasAdvancePayment);
ssAccountingServiceTypeId_DEPR = (long) other.AttributeGet(IdAccountingServiceTypeId_DEPR);
ChangedAttributes[26] = other.ChangedAttributeGet(IdAccountingServiceTypeId_DEPR);
OptimizedAttributes[26] = other.OptimizedAttributeGet(IdAccountingServiceTypeId_DEPR);
ssServiceDescription_DEPREC = (string) other.AttributeGet(IdServiceDescription_DEPREC);
ChangedAttributes[27] = other.ChangedAttributeGet(IdServiceDescription_DEPREC);
OptimizedAttributes[27] = other.OptimizedAttributeGet(IdServiceDescription_DEPREC);
ssInvoiceUsageId_DEPREC = (long) other.AttributeGet(IdInvoiceUsageId_DEPREC);
ChangedAttributes[28] = other.ChangedAttributeGet(IdInvoiceUsageId_DEPREC);
OptimizedAttributes[28] = other.OptimizedAttributeGet(IdInvoiceUsageId_DEPREC);
ssServiceFormatId = (long) other.AttributeGet(IdServiceFormatId);
ChangedAttributes[29] = other.ChangedAttributeGet(IdServiceFormatId);
OptimizedAttributes[29] = other.OptimizedAttributeGet(IdServiceFormatId);
ssCompanyId = (long) other.AttributeGet(IdCompanyId);
ChangedAttributes[30] = other.ChangedAttributeGet(IdCompanyId);
OptimizedAttributes[30] = other.OptimizedAttributeGet(IdCompanyId);
ssRetentionRate = (decimal) other.AttributeGet(IdRetentionRate);
ChangedAttributes[31] = other.ChangedAttributeGet(IdRetentionRate);
OptimizedAttributes[31] = other.OptimizedAttributeGet(IdRetentionRate);
ssNegotiatedExchangeRate = (decimal) other.AttributeGet(IdNegotiatedExchangeRate);
ChangedAttributes[32] = other.ChangedAttributeGet(IdNegotiatedExchangeRate);
OptimizedAttributes[32] = other.OptimizedAttributeGet(IdNegotiatedExchangeRate);
ssPaymentMethodId = (long) other.AttributeGet(IdPaymentMethodId);
ChangedAttributes[33] = other.ChangedAttributeGet(IdPaymentMethodId);
OptimizedAttributes[33] = other.OptimizedAttributeGet(IdPaymentMethodId);
ssPaymentTermsId = (long) other.AttributeGet(IdPaymentTermsId);
ChangedAttributes[34] = other.ChangedAttributeGet(IdPaymentTermsId);
OptimizedAttributes[34] = other.OptimizedAttributeGet(IdPaymentTermsId);
ssIsAutomaticAccounting = (bool) other.AttributeGet(IdIsAutomaticAccounting);
ChangedAttributes[35] = other.ChangedAttributeGet(IdIsAutomaticAccounting);
OptimizedAttributes[35] = other.OptimizedAttributeGet(IdIsAutomaticAccounting);
ssCreatedBy = (string) other.AttributeGet(IdCreatedBy);
ChangedAttributes[36] = other.ChangedAttributeGet(IdCreatedBy);
OptimizedAttributes[36] = other.OptimizedAttributeGet(IdCreatedBy);
ssCreatedOn = (DateTime) other.AttributeGet(IdCreatedOn);
ChangedAttributes[37] = other.ChangedAttributeGet(IdCreatedOn);
OptimizedAttributes[37] = other.OptimizedAttributeGet(IdCreatedOn);
ssUpdatedOn = (DateTime) other.AttributeGet(IdUpdatedOn);
ChangedAttributes[38] = other.ChangedAttributeGet(IdUpdatedOn);
OptimizedAttributes[38] = other.OptimizedAttributeGet(IdUpdatedOn);
ssUpdatedBy = (string) other.AttributeGet(IdUpdatedBy);
ChangedAttributes[39] = other.ChangedAttributeGet(IdUpdatedBy);
OptimizedAttributes[39] = other.OptimizedAttributeGet(IdUpdatedBy);
ssCreatedByApplicationRole = (long) other.AttributeGet(IdCreatedByApplicationRole);
ChangedAttributes[40] = other.ChangedAttributeGet(IdCreatedByApplicationRole);
OptimizedAttributes[40] = other.OptimizedAttributeGet(IdCreatedByApplicationRole);
ssDateOfCommitment = (DateTime) other.AttributeGet(IdDateOfCommitment);
ChangedAttributes[41] = other.ChangedAttributeGet(IdDateOfCommitment);
OptimizedAttributes[41] = other.OptimizedAttributeGet(IdDateOfCommitment);
ssHasContractFileUploaded = (bool) other.AttributeGet(IdHasContractFileUploaded);
ChangedAttributes[42] = other.ChangedAttributeGet(IdHasContractFileUploaded);
OptimizedAttributes[42] = other.OptimizedAttributeGet(IdHasContractFileUploaded);
ssHasUpdatedDateOfCommitment = (bool) other.AttributeGet(IdHasUpdatedDateOfCommitment);
ChangedAttributes[43] = other.ChangedAttributeGet(IdHasUpdatedDateOfCommitment);
OptimizedAttributes[43] = other.OptimizedAttributeGet(IdHasUpdatedDateOfCommitment);
ssSubmittedOn = (DateTime) other.AttributeGet(IdSubmittedOn);
ChangedAttributes[44] = other.ChangedAttributeGet(IdSubmittedOn);
OptimizedAttributes[44] = other.OptimizedAttributeGet(IdSubmittedOn);
ssIsDonation = (bool) other.AttributeGet(IdIsDonation);
ChangedAttributes[45] = other.ChangedAttributeGet(IdIsDonation);
OptimizedAttributes[45] = other.OptimizedAttributeGet(IdIsDonation);
ssAdvWithoutInvoice = (bool) other.AttributeGet(IdAdvWithoutInvoice);
ChangedAttributes[46] = other.ChangedAttributeGet(IdAdvWithoutInvoice);
OptimizedAttributes[46] = other.OptimizedAttributeGet(IdAdvWithoutInvoice);
ssWasAdvWithoutInvoice = (bool) other.AttributeGet(IdWasAdvWithoutInvoice);
ChangedAttributes[47] = other.ChangedAttributeGet(IdWasAdvWithoutInvoice);
OptimizedAttributes[47] = other.OptimizedAttributeGet(IdWasAdvWithoutInvoice);
ssIsAdvanced = (bool) other.AttributeGet(IdIsAdvanced);
ChangedAttributes[48] = other.ChangedAttributeGet(IdIsAdvanced);
OptimizedAttributes[48] = other.OptimizedAttributeGet(IdIsAdvanced);
ssDocumentTypeId = (long) other.AttributeGet(IdDocumentTypeId);
ChangedAttributes[49] = other.ChangedAttributeGet(IdDocumentTypeId);
OptimizedAttributes[49] = other.OptimizedAttributeGet(IdDocumentTypeId);
ssIsCreatedByAnAssistente = (bool) other.AttributeGet(IdIsCreatedByAnAssistente);
ChangedAttributes[50] = other.ChangedAttributeGet(IdIsCreatedByAnAssistente);
OptimizedAttributes[50] = other.OptimizedAttributeGet(IdIsCreatedByAnAssistente);
ssTelcelDirectionId = (long) other.AttributeGet(IdTelcelDirectionId);
ChangedAttributes[51] = other.ChangedAttributeGet(IdTelcelDirectionId);
OptimizedAttributes[51] = other.OptimizedAttributeGet(IdTelcelDirectionId);
ssHasMultiUpload = (bool) other.AttributeGet(IdHasMultiUpload);
ChangedAttributes[52] = other.ChangedAttributeGet(IdHasMultiUpload);
OptimizedAttributes[52] = other.OptimizedAttributeGet(IdHasMultiUpload);
ssAccountingDate = (DateTime) other.AttributeGet(IdAccountingDate);
ChangedAttributes[53] = other.ChangedAttributeGet(IdAccountingDate);
OptimizedAttributes[53] = other.OptimizedAttributeGet(IdAccountingDate);
ssPaymentOptionsId = (long) other.AttributeGet(IdPaymentOptionsId);
ChangedAttributes[54] = other.ChangedAttributeGet(IdPaymentOptionsId);
OptimizedAttributes[54] = other.OptimizedAttributeGet(IdPaymentOptionsId);
ssPaymentWaysId = (long) other.AttributeGet(IdPaymentWaysId);
ChangedAttributes[55] = other.ChangedAttributeGet(IdPaymentWaysId);
OptimizedAttributes[55] = other.OptimizedAttributeGet(IdPaymentWaysId);
ssBuyDocNumber = (string) other.AttributeGet(IdBuyDocNumber);
ChangedAttributes[56] = other.ChangedAttributeGet(IdBuyDocNumber);
OptimizedAttributes[56] = other.OptimizedAttributeGet(IdBuyDocNumber);
ssBuyDocPosition = (string) other.AttributeGet(IdBuyDocPosition);
ChangedAttributes[57] = other.ChangedAttributeGet(IdBuyDocPosition);
OptimizedAttributes[57] = other.OptimizedAttributeGet(IdBuyDocPosition);
}
} // EN_98680591dcf3728e0877a90eb5e1e552EntityRecord

/// <summary>
/// RecordList type <code>RequisitionList</code> that represents a record list of
///  <code>Requisition</code>
/// </summary>
public partial class RL_cb0af376aeb7abbe122c378af80948af : GenericRecordList<EN_98680591dcf3728e0877a90eb5e1e552EntityRecord>, IEnumerable, IEnumerator {

protected override EN_98680591dcf3728e0877a90eb5e1e552EntityRecord GetElementDefaultValue() {
return new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord();
}

public T[] ToArray<T>(Func<EN_98680591dcf3728e0877a90eb5e1e552EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_cb0af376aeb7abbe122c378af80948af recordList, Func<EN_98680591dcf3728e0877a90eb5e1e552EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_cb0af376aeb7abbe122c378af80948af(EN_98680591dcf3728e0877a90eb5e1e552EntityRecord[] array) {
  RL_cb0af376aeb7abbe122c378af80948af result = new RL_cb0af376aeb7abbe122c378af80948af();
result.InnerFromArray(array);
    return result;
}

public static RL_cb0af376aeb7abbe122c378af80948af ToList<T>(T[] array, Func <T, EN_98680591dcf3728e0877a90eb5e1e552EntityRecord> converter) {
  RL_cb0af376aeb7abbe122c378af80948af result = new RL_cb0af376aeb7abbe122c378af80948af();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_cb0af376aeb7abbe122c378af80948af FromRestList<T>(RestList<T> restList, Func <T, EN_98680591dcf3728e0877a90eb5e1e552EntityRecord> converter) {
  RL_cb0af376aeb7abbe122c378af80948af result = new RL_cb0af376aeb7abbe122c378af80948af();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_cb0af376aeb7abbe122c378af80948af() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_98680591dcf3728e0877a90eb5e1e552EntityRecord> NewList() {
return new RL_cb0af376aeb7abbe122c378af80948af();
}


} // RL_cb0af376aeb7abbe122c378af80948af
}
