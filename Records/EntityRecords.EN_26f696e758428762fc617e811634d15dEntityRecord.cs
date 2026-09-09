using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] OrderDetail (ZnfKm5W5aEegf19DAuTl5w)
///  <code>EN_26f696e758428762fc617e811634d15dEntityRecord</code> that represent
/// s <code>OrderDetail</code> <p>Description: Order Detail</p>
/// </summary>
// Name: OrderDetail
public partial struct EN_26f696e758428762fc617e811634d15dEntityRecord : ITypedRecord<EN_26f696e758428762fc617e811634d15dEntityRecord> {
internal static readonly GlobalObjectKey IdOrderId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*LL9KYhz4WkOAnELsU9lrYw");
internal static readonly GlobalObjectKey IdIsApprovalFromUserArea = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*1fOUHHe3bECdqrsM2twEUg");
internal static readonly GlobalObjectKey IdProjectAssetServiceId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*o6IfEFTdQU2PilAqIm9bgg");
internal static readonly GlobalObjectKey IdProjectAssetService = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*B3Bd6jDWDECcVfxpZdIcHQ");
internal static readonly GlobalObjectKey IdProjectDescription = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*3HqTJu4MRkuKEY2z5zjhRg");
internal static readonly GlobalObjectKey IdBusinessValueCategoryId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*J+bHN7vSz0OcJ6r23J0mFA");
internal static readonly GlobalObjectKey IdBusinessValueSubcategoryId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Bd3y8SJiE02EVaUq1ylD3w");
internal static readonly GlobalObjectKey IdPaymentTermsId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*OSwDOlPtpkmabxrUCDm_2A");
internal static readonly GlobalObjectKey IdPaymentMethodId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*320C+vTWcU2sN3nZDNDHgQ");
internal static readonly GlobalObjectKey IdNegotiatedExchangeRate = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*fMNsyC4aJk+96m46uJfGXw");
internal static readonly GlobalObjectKey IdContractStatus = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*pRqhWQp8x0iPrjCHuorSwg");
internal static readonly GlobalObjectKey IdDateOfCommitment = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*7M7jMpNrrkaHsEGUOWtbng");
internal static readonly GlobalObjectKey IdHasDeposit = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*RbJJ2Hu+EEatLefa+aTEzw");
internal static readonly GlobalObjectKey IdHasInsurance = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*SP+3QqGWuU62IjXilQv9Zw");
internal static readonly GlobalObjectKey IdDistributionId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Ap_hLXPCaEmyfrA7OmMbzQ");
internal static readonly GlobalObjectKey IdHasAdvancePayment = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*DFbLdfx6+0yI04lS95jlNw");
internal static readonly GlobalObjectKey IdRetentionRate = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*0+g3ERjzT0uHx5b7Dg7zZg");
internal static readonly GlobalObjectKey IdHasBaseDate = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*1M_VbBgcwEiWLAVa5Ml_VA");
internal static readonly GlobalObjectKey IdStartBaseDate = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*u0_8gPB1qkKq1fBogB4F1Q");
internal static readonly GlobalObjectKey IdEndBaseDate = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*_TYwF7dMmECqVRqT4dUGKg");
internal static readonly GlobalObjectKey IdContractNumber = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*c+ODvQmnn06MTEb3q+kQvw");
internal static readonly GlobalObjectKey IdIsRetentionApplied = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*ZLseaBDBgki+__KTLzMHtg");
internal static readonly GlobalObjectKey IdFrequency = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*N1iEu2VP9UuWl17VUyIC5w");
internal static readonly GlobalObjectKey IdPeriod = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*wb+AN0Dx9UiFCIge5SLwsA");
internal static readonly GlobalObjectKey IdOrderRetentionTypeId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*HyBEqAWcKU2XzwLygP_jxg");
internal static readonly GlobalObjectKey IdPaymentOptionsId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*flEdmvgLpUu7sDiSRCDXmg");
internal static readonly GlobalObjectKey IdPaymentWaysId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*0iLbYQ2l0EaYDHMZTXGHdQ");
internal static readonly GlobalObjectKey IdOrdersContract = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*PF1hbzyv9kSqGoUim03LyA");
internal static readonly GlobalObjectKey IdContractAmount = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*W2slamVxhEe+PdObhLzr7Q");
internal static readonly GlobalObjectKey IdContractTarif = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Lx7IA1j3HEKY4RNYLamjVA");
internal static readonly GlobalObjectKey IdContractSupplier = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*0os4tIRd0kSfG8lI24+smg");
internal static readonly GlobalObjectKey IdIsDependentFromFolios = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*JyAlxFLRDEe2xgc4DBl21Q");
internal static readonly GlobalObjectKey IdSpecialApprovalId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*11BTNbdbYEu2PulJttINIg");
internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*y9N+ZAqndU+5CCKDmooSsA");
internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*mtWAM9Iy+UGcaaMSuhFXGQ");
internal static readonly GlobalObjectKey IdUpdatedBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*8Dnj+fpPfEWJGMbHY29PMA");
internal static readonly GlobalObjectKey IdUpdatedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*3GDoeYcicEiA+dan0iV6Sg");
internal static readonly GlobalObjectKey IdAllContactFilesValidated = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*W9ESrrMjSEanLEwgoUJglw");
internal static readonly GlobalObjectKey IdHasntRequestDocuments = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*dFr4AwYfOkacsMVHgCkhRg");

private long _ssOrderId;
public long ssOrderId{
  get{
      return _ssOrderId;
  }
  set{
      if((_ssOrderId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(39,true);
          _ssOrderId = value;
      }
  }
}

private bool _ssIsApprovalFromUserArea;
public bool ssIsApprovalFromUserArea{
  get{
      return _ssIsApprovalFromUserArea;
  }
  set{
      if((_ssIsApprovalFromUserArea!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssIsApprovalFromUserArea = value;
      }
  }
}

private long _ssProjectAssetServiceId;
public long ssProjectAssetServiceId{
  get{
      return _ssProjectAssetServiceId;
  }
  set{
      if((_ssProjectAssetServiceId!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
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
      if((_ssProjectAssetService!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
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
      if((_ssProjectDescription!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssProjectDescription = value;
      }
  }
}

private long _ssBusinessValueCategoryId;
public long ssBusinessValueCategoryId{
  get{
      return _ssBusinessValueCategoryId;
  }
  set{
      if((_ssBusinessValueCategoryId!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
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
      if((_ssBusinessValueSubcategoryId!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssBusinessValueSubcategoryId = value;
      }
  }
}

private long _ssPaymentTermsId;
public long ssPaymentTermsId{
  get{
      return _ssPaymentTermsId;
  }
  set{
      if((_ssPaymentTermsId!=value) || OptimizedAttributes[7]){
          ChangedAttributes[7] = true;
          _ssPaymentTermsId = value;
      }
  }
}

private long _ssPaymentMethodId;
public long ssPaymentMethodId{
  get{
      return _ssPaymentMethodId;
  }
  set{
      if((_ssPaymentMethodId!=value) || OptimizedAttributes[8]){
          ChangedAttributes[8] = true;
          _ssPaymentMethodId = value;
      }
  }
}

private decimal _ssNegotiatedExchangeRate;
public decimal ssNegotiatedExchangeRate{
  get{
      return _ssNegotiatedExchangeRate;
  }
  set{
      if((_ssNegotiatedExchangeRate!=value) || OptimizedAttributes[9]){
          ChangedAttributes[9] = true;
          _ssNegotiatedExchangeRate = value;
      }
  }
}

private int _ssContractStatus;
public int ssContractStatus{
  get{
      return _ssContractStatus;
  }
  set{
      if((_ssContractStatus!=value) || OptimizedAttributes[10]){
          ChangedAttributes[10] = true;
          _ssContractStatus = value;
      }
  }
}

private DateTime _ssDateOfCommitment;
public DateTime ssDateOfCommitment{
  get{
      return _ssDateOfCommitment;
  }
  set{
      if((_ssDateOfCommitment!=value) || OptimizedAttributes[11]){
          ChangedAttributes[11] = true;
          _ssDateOfCommitment = value;
      }
  }
}

private bool _ssHasDeposit;
public bool ssHasDeposit{
  get{
      return _ssHasDeposit;
  }
  set{
      if((_ssHasDeposit!=value) || OptimizedAttributes[12]){
          ChangedAttributes[12] = true;
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
      if((_ssHasInsurance!=value) || OptimizedAttributes[13]){
          ChangedAttributes[13] = true;
          _ssHasInsurance = value;
      }
  }
}

private int _ssDistributionId;
public int ssDistributionId{
  get{
      return _ssDistributionId;
  }
  set{
      if((_ssDistributionId!=value) || OptimizedAttributes[14]){
          ChangedAttributes[14] = true;
          _ssDistributionId = value;
      }
  }
}

private bool _ssHasAdvancePayment;
public bool ssHasAdvancePayment{
  get{
      return _ssHasAdvancePayment;
  }
  set{
      if((_ssHasAdvancePayment!=value) || OptimizedAttributes[15]){
          ChangedAttributes[15] = true;
          _ssHasAdvancePayment = value;
      }
  }
}

private decimal _ssRetentionRate;
public decimal ssRetentionRate{
  get{
      return _ssRetentionRate;
  }
  set{
      if((_ssRetentionRate!=value) || OptimizedAttributes[16]){
          ChangedAttributes[16] = true;
          _ssRetentionRate = value;
      }
  }
}

private bool _ssHasBaseDate;
public bool ssHasBaseDate{
  get{
      return _ssHasBaseDate;
  }
  set{
      if((_ssHasBaseDate!=value) || OptimizedAttributes[17]){
          ChangedAttributes[17] = true;
          _ssHasBaseDate = value;
      }
  }
}

private DateTime _ssStartBaseDate;
public DateTime ssStartBaseDate{
  get{
      return _ssStartBaseDate;
  }
  set{
      if((_ssStartBaseDate!=value) || OptimizedAttributes[18]){
          ChangedAttributes[18] = true;
          _ssStartBaseDate = value;
      }
  }
}

private DateTime _ssEndBaseDate;
public DateTime ssEndBaseDate{
  get{
      return _ssEndBaseDate;
  }
  set{
      if((_ssEndBaseDate!=value) || OptimizedAttributes[19]){
          ChangedAttributes[19] = true;
          _ssEndBaseDate = value;
      }
  }
}

private string _ssContractNumber;
public string ssContractNumber{
  get{
      return _ssContractNumber;
  }
  set{
      if((_ssContractNumber!=value) || OptimizedAttributes[20]){
          ChangedAttributes[20] = true;
          _ssContractNumber = value;
      }
  }
}

private bool _ssIsRetentionApplied;
public bool ssIsRetentionApplied{
  get{
      return _ssIsRetentionApplied;
  }
  set{
      if((_ssIsRetentionApplied!=value) || OptimizedAttributes[21]){
          ChangedAttributes[21] = true;
          _ssIsRetentionApplied = value;
      }
  }
}

private int _ssFrequency;
public int ssFrequency{
  get{
      return _ssFrequency;
  }
  set{
      if((_ssFrequency!=value) || OptimizedAttributes[22]){
          ChangedAttributes[22] = true;
          _ssFrequency = value;
      }
  }
}

private string _ssPeriod;
public string ssPeriod{
  get{
      return _ssPeriod;
  }
  set{
      if((_ssPeriod!=value) || OptimizedAttributes[23]){
          ChangedAttributes[23] = true;
          _ssPeriod = value;
      }
  }
}

private int _ssOrderRetentionTypeId;
public int ssOrderRetentionTypeId{
  get{
      return _ssOrderRetentionTypeId;
  }
  set{
      if((_ssOrderRetentionTypeId!=value) || OptimizedAttributes[24]){
          ChangedAttributes[24] = true;
          _ssOrderRetentionTypeId = value;
      }
  }
}

private long _ssPaymentOptionsId;
public long ssPaymentOptionsId{
  get{
      return _ssPaymentOptionsId;
  }
  set{
      if((_ssPaymentOptionsId!=value) || OptimizedAttributes[25]){
          ChangedAttributes[25] = true;
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
      if((_ssPaymentWaysId!=value) || OptimizedAttributes[26]){
          ChangedAttributes[26] = true;
          _ssPaymentWaysId = value;
      }
  }
}

private string _ssOrdersContract;
public string ssOrdersContract{
  get{
      return _ssOrdersContract;
  }
  set{
      if((_ssOrdersContract!=value) || OptimizedAttributes[27]){
          ChangedAttributes[27] = true;
          _ssOrdersContract = value;
      }
  }
}

private decimal _ssContractAmount;
public decimal ssContractAmount{
  get{
      return _ssContractAmount;
  }
  set{
      if((_ssContractAmount!=value) || OptimizedAttributes[28]){
          ChangedAttributes[28] = true;
          _ssContractAmount = value;
      }
  }
}

private decimal _ssContractTarif;
public decimal ssContractTarif{
  get{
      return _ssContractTarif;
  }
  set{
      if((_ssContractTarif!=value) || OptimizedAttributes[29]){
          ChangedAttributes[29] = true;
          _ssContractTarif = value;
      }
  }
}

private long _ssContractSupplier;
public long ssContractSupplier{
  get{
      return _ssContractSupplier;
  }
  set{
      if((_ssContractSupplier!=value) || OptimizedAttributes[30]){
          ChangedAttributes[30] = true;
          _ssContractSupplier = value;
      }
  }
}

private bool _ssIsDependentFromFolios;
public bool ssIsDependentFromFolios{
  get{
      return _ssIsDependentFromFolios;
  }
  set{
      if((_ssIsDependentFromFolios!=value) || OptimizedAttributes[31]){
          ChangedAttributes[31] = true;
          _ssIsDependentFromFolios = value;
      }
  }
}

private int _ssSpecialApprovalId;
public int ssSpecialApprovalId{
  get{
      return _ssSpecialApprovalId;
  }
  set{
      if((_ssSpecialApprovalId!=value) || OptimizedAttributes[32]){
          ChangedAttributes[32] = true;
          _ssSpecialApprovalId = value;
      }
  }
}

private string _ssCreatedBy;
public string ssCreatedBy{
  get{
      return _ssCreatedBy;
  }
  set{
      if((_ssCreatedBy!=value) || OptimizedAttributes[33]){
          ChangedAttributes[33] = true;
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
      if((_ssCreatedOn!=value) || OptimizedAttributes[34]){
          ChangedAttributes[34] = true;
          _ssCreatedOn = value;
      }
  }
}

private string _ssUpdatedBy;
public string ssUpdatedBy{
  get{
      return _ssUpdatedBy;
  }
  set{
      if((_ssUpdatedBy!=value) || OptimizedAttributes[35]){
          ChangedAttributes[35] = true;
          _ssUpdatedBy = value;
      }
  }
}

private DateTime _ssUpdatedOn;
public DateTime ssUpdatedOn{
  get{
      return _ssUpdatedOn;
  }
  set{
      if((_ssUpdatedOn!=value) || OptimizedAttributes[36]){
          ChangedAttributes[36] = true;
          _ssUpdatedOn = value;
      }
  }
}

private bool _ssAllContactFilesValidated;
public bool ssAllContactFilesValidated{
  get{
      return _ssAllContactFilesValidated;
  }
  set{
      if((_ssAllContactFilesValidated!=value) || OptimizedAttributes[37]){
          ChangedAttributes[37] = true;
          _ssAllContactFilesValidated = value;
      }
  }
}

private bool _ssHasntRequestDocuments;
public bool ssHasntRequestDocuments{
  get{
      return _ssHasntRequestDocuments;
  }
  set{
      if((_ssHasntRequestDocuments!=value) || OptimizedAttributes[38]){
          ChangedAttributes[38] = true;
          _ssHasntRequestDocuments = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_26f696e758428762fc617e811634d15dEntityRecord() {
ChangedAttributes = new BitArray(39,true);
OptimizedAttributes = new BitArray(39,false);
_ssOrderId = 0L;
_ssIsApprovalFromUserArea = false;
_ssProjectAssetServiceId = 0L;
_ssProjectAssetService = "";
_ssProjectDescription = "";
_ssBusinessValueCategoryId = 0L;
_ssBusinessValueSubcategoryId = 0L;
_ssPaymentTermsId = 0L;
_ssPaymentMethodId = 0L;
_ssNegotiatedExchangeRate = 0.0M;
_ssContractStatus = 0;
_ssDateOfCommitment = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssHasDeposit = false;
_ssHasInsurance = false;
_ssDistributionId = 0;
_ssHasAdvancePayment = false;
_ssRetentionRate = 0.0M;
_ssHasBaseDate = false;
_ssStartBaseDate = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssEndBaseDate = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssContractNumber = "";
_ssIsRetentionApplied = false;
_ssFrequency = 0;
_ssPeriod = "";
_ssOrderRetentionTypeId = 0;
_ssPaymentOptionsId = 0L;
_ssPaymentWaysId = 0L;
_ssOrdersContract = "";
_ssContractAmount = 0.0M;
_ssContractTarif = 0.0M;
_ssContractSupplier = 0L;
_ssIsDependentFromFolios = false;
_ssSpecialApprovalId = 0;
_ssCreatedBy = "";
_ssCreatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssUpdatedBy = "";
_ssUpdatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssAllContactFilesValidated = false;
_ssHasntRequestDocuments = false;
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
ssOrderId = r.ReadEntityReferenceLongInteger(index++, "OrderDetail.OrderId", 0L);
ssIsApprovalFromUserArea = r.ReadBoolean(index++, "OrderDetail.IsApprovalFromUserArea", false);
ssProjectAssetServiceId = r.ReadEntityReferenceLongInteger(index++, "OrderDetail.ProjectAssetServiceId", 0L);
ssProjectAssetService = r.ReadText(index++, "OrderDetail.ProjectAssetService", "");
ssProjectDescription = r.ReadText(index++, "OrderDetail.ProjectDescription", "");
ssBusinessValueCategoryId = r.ReadEntityReferenceLongInteger(index++, "OrderDetail.BusinessValueCategoryId", 0L);
ssBusinessValueSubcategoryId = r.ReadEntityReferenceLongInteger(index++, "OrderDetail.BusinessValueSubcategoryId", 0L);
ssPaymentTermsId = r.ReadEntityReferenceLongInteger(index++, "OrderDetail.PaymentTermsId", 0L);
ssPaymentMethodId = r.ReadEntityReferenceLongInteger(index++, "OrderDetail.PaymentMethodId", 0L);
ssNegotiatedExchangeRate = r.ReadDecimal(index++, "OrderDetail.NegotiatedExchangeRate", 0.0M);
ssContractStatus = r.ReadEntityReference(index++, "OrderDetail.ContractStatus", 0);
ssDateOfCommitment = r.ReadDate(index++, "OrderDetail.DateOfCommitment", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssHasDeposit = r.ReadBoolean(index++, "OrderDetail.HasDeposit", false);
ssHasInsurance = r.ReadBoolean(index++, "OrderDetail.HasInsurance", false);
ssDistributionId = r.ReadEntityReference(index++, "OrderDetail.DistributionId", 0);
ssHasAdvancePayment = r.ReadBoolean(index++, "OrderDetail.HasAdvancePayment", false);
ssRetentionRate = r.ReadDecimal(index++, "OrderDetail.RetentionRate", 0.0M);
ssHasBaseDate = r.ReadBoolean(index++, "OrderDetail.HasBaseDate", false);
ssStartBaseDate = r.ReadDate(index++, "OrderDetail.StartBaseDate", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssEndBaseDate = r.ReadDate(index++, "OrderDetail.EndBaseDate", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssContractNumber = r.ReadText(index++, "OrderDetail.ContractNumber", "");
ssIsRetentionApplied = r.ReadBoolean(index++, "OrderDetail.IsRetentionApplied", false);
ssFrequency = r.ReadEntityReference(index++, "OrderDetail.Frequency", 0);
ssPeriod = r.ReadText(index++, "OrderDetail.Period", "");
ssOrderRetentionTypeId = r.ReadEntityReference(index++, "OrderDetail.OrderRetentionTypeId", 0);
ssPaymentOptionsId = r.ReadEntityReferenceLongInteger(index++, "OrderDetail.PaymentOptionsId", 0L);
ssPaymentWaysId = r.ReadEntityReferenceLongInteger(index++, "OrderDetail.PaymentWaysId", 0L);
ssOrdersContract = r.ReadText(index++, "OrderDetail.OrdersContract", "");
ssContractAmount = r.ReadDecimal(index++, "OrderDetail.ContractAmount", 0.0M);
ssContractTarif = r.ReadDecimal(index++, "OrderDetail.ContractTarif", 0.0M);
ssContractSupplier = r.ReadEntityReferenceLongInteger(index++, "OrderDetail.ContractSupplier", 0L);
ssIsDependentFromFolios = r.ReadBoolean(index++, "OrderDetail.IsDependentFromFolios", false);
ssSpecialApprovalId = r.ReadEntityReference(index++, "OrderDetail.SpecialApprovalId", 0);
ssCreatedBy = r.ReadEntityReferenceText(index++, "OrderDetail.CreatedBy", "");
ssCreatedOn = r.ReadDateTime(index++, "OrderDetail.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssUpdatedBy = r.ReadEntityReferenceText(index++, "OrderDetail.UpdatedBy", "");
ssUpdatedOn = r.ReadDateTime(index++, "OrderDetail.UpdatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssAllContactFilesValidated = r.ReadBoolean(index++, "OrderDetail.AllContactFilesValidated", false);
ssHasntRequestDocuments = r.ReadBoolean(index++, "OrderDetail.HasntRequestDocuments", false);
ChangedAttributes = new BitArray(39,false);
OptimizedAttributes = new BitArray(39,false);
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
public void ReadIM(EN_26f696e758428762fc617e811634d15dEntityRecord r) {
this = r;
}


public static bool operator == (EN_26f696e758428762fc617e811634d15dEntityRecord a, EN_26f696e758428762fc617e811634d15dEntityRecord b) {
if (a.ssOrderId != b.ssOrderId) return false;
if (a.ssIsApprovalFromUserArea != b.ssIsApprovalFromUserArea) return false;
if (a.ssProjectAssetServiceId != b.ssProjectAssetServiceId) return false;
if (a.ssProjectAssetService != b.ssProjectAssetService) return false;
if (a.ssProjectDescription != b.ssProjectDescription) return false;
if (a.ssBusinessValueCategoryId != b.ssBusinessValueCategoryId) return false;
if (a.ssBusinessValueSubcategoryId != b.ssBusinessValueSubcategoryId) return false;
if (a.ssPaymentTermsId != b.ssPaymentTermsId) return false;
if (a.ssPaymentMethodId != b.ssPaymentMethodId) return false;
if (a.ssNegotiatedExchangeRate != b.ssNegotiatedExchangeRate) return false;
if (a.ssContractStatus != b.ssContractStatus) return false;
if (a.ssDateOfCommitment != b.ssDateOfCommitment) return false;
if (a.ssHasDeposit != b.ssHasDeposit) return false;
if (a.ssHasInsurance != b.ssHasInsurance) return false;
if (a.ssDistributionId != b.ssDistributionId) return false;
if (a.ssHasAdvancePayment != b.ssHasAdvancePayment) return false;
if (a.ssRetentionRate != b.ssRetentionRate) return false;
if (a.ssHasBaseDate != b.ssHasBaseDate) return false;
if (a.ssStartBaseDate != b.ssStartBaseDate) return false;
if (a.ssEndBaseDate != b.ssEndBaseDate) return false;
if (a.ssContractNumber != b.ssContractNumber) return false;
if (a.ssIsRetentionApplied != b.ssIsRetentionApplied) return false;
if (a.ssFrequency != b.ssFrequency) return false;
if (a.ssPeriod != b.ssPeriod) return false;
if (a.ssOrderRetentionTypeId != b.ssOrderRetentionTypeId) return false;
if (a.ssPaymentOptionsId != b.ssPaymentOptionsId) return false;
if (a.ssPaymentWaysId != b.ssPaymentWaysId) return false;
if (a.ssOrdersContract != b.ssOrdersContract) return false;
if (a.ssContractAmount != b.ssContractAmount) return false;
if (a.ssContractTarif != b.ssContractTarif) return false;
if (a.ssContractSupplier != b.ssContractSupplier) return false;
if (a.ssIsDependentFromFolios != b.ssIsDependentFromFolios) return false;
if (a.ssSpecialApprovalId != b.ssSpecialApprovalId) return false;
if (a.ssCreatedBy != b.ssCreatedBy) return false;
if (a.ssCreatedOn != b.ssCreatedOn) return false;
if (a.ssUpdatedBy != b.ssUpdatedBy) return false;
if (a.ssUpdatedOn != b.ssUpdatedOn) return false;
if (a.ssAllContactFilesValidated != b.ssAllContactFilesValidated) return false;
if (a.ssHasntRequestDocuments != b.ssHasntRequestDocuments) return false;
return true;
}

public static bool operator != (EN_26f696e758428762fc617e811634d15dEntityRecord a, EN_26f696e758428762fc617e811634d15dEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_26f696e758428762fc617e811634d15dEntityRecord)) return false;
return (this == (EN_26f696e758428762fc617e811634d15dEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssOrderId.GetHashCode()
 ^ ssIsApprovalFromUserArea.GetHashCode()
 ^ ssProjectAssetServiceId.GetHashCode()
 ^ ssProjectAssetService.GetHashCode()
 ^ ssProjectDescription.GetHashCode()
 ^ ssBusinessValueCategoryId.GetHashCode()
 ^ ssBusinessValueSubcategoryId.GetHashCode()
 ^ ssPaymentTermsId.GetHashCode()
 ^ ssPaymentMethodId.GetHashCode()
 ^ ssNegotiatedExchangeRate.GetHashCode()
 ^ ssContractStatus.GetHashCode()
 ^ ssDateOfCommitment.GetHashCode()
 ^ ssHasDeposit.GetHashCode()
 ^ ssHasInsurance.GetHashCode()
 ^ ssDistributionId.GetHashCode()
 ^ ssHasAdvancePayment.GetHashCode()
 ^ ssRetentionRate.GetHashCode()
 ^ ssHasBaseDate.GetHashCode()
 ^ ssStartBaseDate.GetHashCode()
 ^ ssEndBaseDate.GetHashCode()
 ^ ssContractNumber.GetHashCode()
 ^ ssIsRetentionApplied.GetHashCode()
 ^ ssFrequency.GetHashCode()
 ^ ssPeriod.GetHashCode()
 ^ ssOrderRetentionTypeId.GetHashCode()
 ^ ssPaymentOptionsId.GetHashCode()
 ^ ssPaymentWaysId.GetHashCode()
 ^ ssOrdersContract.GetHashCode()
 ^ ssContractAmount.GetHashCode()
 ^ ssContractTarif.GetHashCode()
 ^ ssContractSupplier.GetHashCode()
 ^ ssIsDependentFromFolios.GetHashCode()
 ^ ssSpecialApprovalId.GetHashCode()
 ^ ssCreatedBy.GetHashCode()
 ^ ssCreatedOn.GetHashCode()
 ^ ssUpdatedBy.GetHashCode()
 ^ ssUpdatedOn.GetHashCode()
 ^ ssAllContactFilesValidated.GetHashCode()
 ^ ssHasntRequestDocuments.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_26f696e758428762fc617e811634d15dEntityRecord Duplicate() {
EN_26f696e758428762fc617e811634d15dEntityRecord t;
t._ssOrderId = this._ssOrderId;
t._ssIsApprovalFromUserArea = this._ssIsApprovalFromUserArea;
t._ssProjectAssetServiceId = this._ssProjectAssetServiceId;
t._ssProjectAssetService = this._ssProjectAssetService;
t._ssProjectDescription = this._ssProjectDescription;
t._ssBusinessValueCategoryId = this._ssBusinessValueCategoryId;
t._ssBusinessValueSubcategoryId = this._ssBusinessValueSubcategoryId;
t._ssPaymentTermsId = this._ssPaymentTermsId;
t._ssPaymentMethodId = this._ssPaymentMethodId;
t._ssNegotiatedExchangeRate = this._ssNegotiatedExchangeRate;
t._ssContractStatus = this._ssContractStatus;
t._ssDateOfCommitment = this._ssDateOfCommitment;
t._ssHasDeposit = this._ssHasDeposit;
t._ssHasInsurance = this._ssHasInsurance;
t._ssDistributionId = this._ssDistributionId;
t._ssHasAdvancePayment = this._ssHasAdvancePayment;
t._ssRetentionRate = this._ssRetentionRate;
t._ssHasBaseDate = this._ssHasBaseDate;
t._ssStartBaseDate = this._ssStartBaseDate;
t._ssEndBaseDate = this._ssEndBaseDate;
t._ssContractNumber = this._ssContractNumber;
t._ssIsRetentionApplied = this._ssIsRetentionApplied;
t._ssFrequency = this._ssFrequency;
t._ssPeriod = this._ssPeriod;
t._ssOrderRetentionTypeId = this._ssOrderRetentionTypeId;
t._ssPaymentOptionsId = this._ssPaymentOptionsId;
t._ssPaymentWaysId = this._ssPaymentWaysId;
t._ssOrdersContract = this._ssOrdersContract;
t._ssContractAmount = this._ssContractAmount;
t._ssContractTarif = this._ssContractTarif;
t._ssContractSupplier = this._ssContractSupplier;
t._ssIsDependentFromFolios = this._ssIsDependentFromFolios;
t._ssSpecialApprovalId = this._ssSpecialApprovalId;
t._ssCreatedBy = this._ssCreatedBy;
t._ssCreatedOn = this._ssCreatedOn;
t._ssUpdatedBy = this._ssUpdatedBy;
t._ssUpdatedOn = this._ssUpdatedOn;
t._ssAllContactFilesValidated = this._ssAllContactFilesValidated;
t._ssHasntRequestDocuments = this._ssHasntRequestDocuments;
t.ChangedAttributes = new BitArray(39);
t.OptimizedAttributes = new BitArray(39);
for(int i = 0; i < 39; i++){
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
if (head == "orderid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderId")) variable.Value = ssOrderId; else variable.Optimized = true;
} else if (head == "isapprovalfromuserarea") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsApprovalFromUserArea")) variable.Value = ssIsApprovalFromUserArea; else variable.Optimized = true;
} else if (head == "projectassetserviceid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProjectAssetServiceId")) variable.Value = ssProjectAssetServiceId; else variable.Optimized = true;
} else if (head == "projectassetservice") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProjectAssetService")) variable.Value = ssProjectAssetService; else variable.Optimized = true;
} else if (head == "projectdescription") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProjectDescription")) variable.Value = ssProjectDescription; else variable.Optimized = true;
} else if (head == "businessvaluecategoryid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".BusinessValueCategoryId")) variable.Value = ssBusinessValueCategoryId; else variable.Optimized = true;
} else if (head == "businessvaluesubcategoryid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".BusinessValueSubcategoryId")) variable.Value = ssBusinessValueSubcategoryId; else variable.Optimized = true;
} else if (head == "paymenttermsid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PaymentTermsId")) variable.Value = ssPaymentTermsId; else variable.Optimized = true;
} else if (head == "paymentmethodid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PaymentMethodId")) variable.Value = ssPaymentMethodId; else variable.Optimized = true;
} else if (head == "negotiatedexchangerate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".NegotiatedExchangeRate")) variable.Value = ssNegotiatedExchangeRate; else variable.Optimized = true;
} else if (head == "contractstatus") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ContractStatus")) variable.Value = ssContractStatus; else variable.Optimized = true;
} else if (head == "dateofcommitment") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DateOfCommitment")) variable.Value = ssDateOfCommitment; else variable.Optimized = true;
} else if (head == "hasdeposit") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".HasDeposit")) variable.Value = ssHasDeposit; else variable.Optimized = true;
} else if (head == "hasinsurance") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".HasInsurance")) variable.Value = ssHasInsurance; else variable.Optimized = true;
} else if (head == "distributionid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DistributionId")) variable.Value = ssDistributionId; else variable.Optimized = true;
} else if (head == "hasadvancepayment") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".HasAdvancePayment")) variable.Value = ssHasAdvancePayment; else variable.Optimized = true;
} else if (head == "retentionrate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RetentionRate")) variable.Value = ssRetentionRate; else variable.Optimized = true;
} else if (head == "hasbasedate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".HasBaseDate")) variable.Value = ssHasBaseDate; else variable.Optimized = true;
} else if (head == "startbasedate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".StartBaseDate")) variable.Value = ssStartBaseDate; else variable.Optimized = true;
} else if (head == "endbasedate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EndBaseDate")) variable.Value = ssEndBaseDate; else variable.Optimized = true;
} else if (head == "contractnumber") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ContractNumber")) variable.Value = ssContractNumber; else variable.Optimized = true;
} else if (head == "isretentionapplied") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsRetentionApplied")) variable.Value = ssIsRetentionApplied; else variable.Optimized = true;
} else if (head == "frequency") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Frequency")) variable.Value = ssFrequency; else variable.Optimized = true;
} else if (head == "period") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Period")) variable.Value = ssPeriod; else variable.Optimized = true;
} else if (head == "orderretentiontypeid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderRetentionTypeId")) variable.Value = ssOrderRetentionTypeId; else variable.Optimized = true;
} else if (head == "paymentoptionsid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PaymentOptionsId")) variable.Value = ssPaymentOptionsId; else variable.Optimized = true;
} else if (head == "paymentwaysid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PaymentWaysId")) variable.Value = ssPaymentWaysId; else variable.Optimized = true;
} else if (head == "orderscontract") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrdersContract")) variable.Value = ssOrdersContract; else variable.Optimized = true;
} else if (head == "contractamount") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ContractAmount")) variable.Value = ssContractAmount; else variable.Optimized = true;
} else if (head == "contracttarif") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ContractTarif")) variable.Value = ssContractTarif; else variable.Optimized = true;
} else if (head == "contractsupplier") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ContractSupplier")) variable.Value = ssContractSupplier; else variable.Optimized = true;
} else if (head == "isdependentfromfolios") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsDependentFromFolios")) variable.Value = ssIsDependentFromFolios; else variable.Optimized = true;
} else if (head == "specialapprovalid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SpecialApprovalId")) variable.Value = ssSpecialApprovalId; else variable.Optimized = true;
} else if (head == "createdby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedBy")) variable.Value = ssCreatedBy; else variable.Optimized = true;
} else if (head == "createdon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedOn")) variable.Value = ssCreatedOn; else variable.Optimized = true;
} else if (head == "updatedby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdatedBy")) variable.Value = ssUpdatedBy; else variable.Optimized = true;
} else if (head == "updatedon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdatedOn")) variable.Value = ssUpdatedOn; else variable.Optimized = true;
} else if (head == "allcontactfilesvalidated") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AllContactFilesValidated")) variable.Value = ssAllContactFilesValidated; else variable.Optimized = true;
} else if (head == "hasntrequestdocuments") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".HasntRequestDocuments")) variable.Value = ssHasntRequestDocuments; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdOrderId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdIsApprovalFromUserArea)) {
return ChangedAttributes[1];
}
if (key.Equals(IdProjectAssetServiceId)) {
return ChangedAttributes[2];
}
if (key.Equals(IdProjectAssetService)) {
return ChangedAttributes[3];
}
if (key.Equals(IdProjectDescription)) {
return ChangedAttributes[4];
}
if (key.Equals(IdBusinessValueCategoryId)) {
return ChangedAttributes[5];
}
if (key.Equals(IdBusinessValueSubcategoryId)) {
return ChangedAttributes[6];
}
if (key.Equals(IdPaymentTermsId)) {
return ChangedAttributes[7];
}
if (key.Equals(IdPaymentMethodId)) {
return ChangedAttributes[8];
}
if (key.Equals(IdNegotiatedExchangeRate)) {
return ChangedAttributes[9];
}
if (key.Equals(IdContractStatus)) {
return ChangedAttributes[10];
}
if (key.Equals(IdDateOfCommitment)) {
return ChangedAttributes[11];
}
if (key.Equals(IdHasDeposit)) {
return ChangedAttributes[12];
}
if (key.Equals(IdHasInsurance)) {
return ChangedAttributes[13];
}
if (key.Equals(IdDistributionId)) {
return ChangedAttributes[14];
}
if (key.Equals(IdHasAdvancePayment)) {
return ChangedAttributes[15];
}
if (key.Equals(IdRetentionRate)) {
return ChangedAttributes[16];
}
if (key.Equals(IdHasBaseDate)) {
return ChangedAttributes[17];
}
if (key.Equals(IdStartBaseDate)) {
return ChangedAttributes[18];
}
if (key.Equals(IdEndBaseDate)) {
return ChangedAttributes[19];
}
if (key.Equals(IdContractNumber)) {
return ChangedAttributes[20];
}
if (key.Equals(IdIsRetentionApplied)) {
return ChangedAttributes[21];
}
if (key.Equals(IdFrequency)) {
return ChangedAttributes[22];
}
if (key.Equals(IdPeriod)) {
return ChangedAttributes[23];
}
if (key.Equals(IdOrderRetentionTypeId)) {
return ChangedAttributes[24];
}
if (key.Equals(IdPaymentOptionsId)) {
return ChangedAttributes[25];
}
if (key.Equals(IdPaymentWaysId)) {
return ChangedAttributes[26];
}
if (key.Equals(IdOrdersContract)) {
return ChangedAttributes[27];
}
if (key.Equals(IdContractAmount)) {
return ChangedAttributes[28];
}
if (key.Equals(IdContractTarif)) {
return ChangedAttributes[29];
}
if (key.Equals(IdContractSupplier)) {
return ChangedAttributes[30];
}
if (key.Equals(IdIsDependentFromFolios)) {
return ChangedAttributes[31];
}
if (key.Equals(IdSpecialApprovalId)) {
return ChangedAttributes[32];
}
if (key.Equals(IdCreatedBy)) {
return ChangedAttributes[33];
}
if (key.Equals(IdCreatedOn)) {
return ChangedAttributes[34];
}
if (key.Equals(IdUpdatedBy)) {
return ChangedAttributes[35];
}
if (key.Equals(IdUpdatedOn)) {
return ChangedAttributes[36];
}
if (key.Equals(IdAllContactFilesValidated)) {
return ChangedAttributes[37];
}
if (key.Equals(IdHasntRequestDocuments)) {
return ChangedAttributes[38];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdOrderId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdIsApprovalFromUserArea)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdProjectAssetServiceId)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdProjectAssetService)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdProjectDescription)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdBusinessValueCategoryId)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdBusinessValueSubcategoryId)) {
return OptimizedAttributes[6];
}
if (key.Equals(IdPaymentTermsId)) {
return OptimizedAttributes[7];
}
if (key.Equals(IdPaymentMethodId)) {
return OptimizedAttributes[8];
}
if (key.Equals(IdNegotiatedExchangeRate)) {
return OptimizedAttributes[9];
}
if (key.Equals(IdContractStatus)) {
return OptimizedAttributes[10];
}
if (key.Equals(IdDateOfCommitment)) {
return OptimizedAttributes[11];
}
if (key.Equals(IdHasDeposit)) {
return OptimizedAttributes[12];
}
if (key.Equals(IdHasInsurance)) {
return OptimizedAttributes[13];
}
if (key.Equals(IdDistributionId)) {
return OptimizedAttributes[14];
}
if (key.Equals(IdHasAdvancePayment)) {
return OptimizedAttributes[15];
}
if (key.Equals(IdRetentionRate)) {
return OptimizedAttributes[16];
}
if (key.Equals(IdHasBaseDate)) {
return OptimizedAttributes[17];
}
if (key.Equals(IdStartBaseDate)) {
return OptimizedAttributes[18];
}
if (key.Equals(IdEndBaseDate)) {
return OptimizedAttributes[19];
}
if (key.Equals(IdContractNumber)) {
return OptimizedAttributes[20];
}
if (key.Equals(IdIsRetentionApplied)) {
return OptimizedAttributes[21];
}
if (key.Equals(IdFrequency)) {
return OptimizedAttributes[22];
}
if (key.Equals(IdPeriod)) {
return OptimizedAttributes[23];
}
if (key.Equals(IdOrderRetentionTypeId)) {
return OptimizedAttributes[24];
}
if (key.Equals(IdPaymentOptionsId)) {
return OptimizedAttributes[25];
}
if (key.Equals(IdPaymentWaysId)) {
return OptimizedAttributes[26];
}
if (key.Equals(IdOrdersContract)) {
return OptimizedAttributes[27];
}
if (key.Equals(IdContractAmount)) {
return OptimizedAttributes[28];
}
if (key.Equals(IdContractTarif)) {
return OptimizedAttributes[29];
}
if (key.Equals(IdContractSupplier)) {
return OptimizedAttributes[30];
}
if (key.Equals(IdIsDependentFromFolios)) {
return OptimizedAttributes[31];
}
if (key.Equals(IdSpecialApprovalId)) {
return OptimizedAttributes[32];
}
if (key.Equals(IdCreatedBy)) {
return OptimizedAttributes[33];
}
if (key.Equals(IdCreatedOn)) {
return OptimizedAttributes[34];
}
if (key.Equals(IdUpdatedBy)) {
return OptimizedAttributes[35];
}
if (key.Equals(IdUpdatedOn)) {
return OptimizedAttributes[36];
}
if (key.Equals(IdAllContactFilesValidated)) {
return OptimizedAttributes[37];
}
if (key.Equals(IdHasntRequestDocuments)) {
return OptimizedAttributes[38];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdOrderId) {
return ssOrderId;
}
if (key == IdIsApprovalFromUserArea) {
return ssIsApprovalFromUserArea;
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
if (key == IdBusinessValueCategoryId) {
return ssBusinessValueCategoryId;
}
if (key == IdBusinessValueSubcategoryId) {
return ssBusinessValueSubcategoryId;
}
if (key == IdPaymentTermsId) {
return ssPaymentTermsId;
}
if (key == IdPaymentMethodId) {
return ssPaymentMethodId;
}
if (key == IdNegotiatedExchangeRate) {
return ssNegotiatedExchangeRate;
}
if (key == IdContractStatus) {
return ssContractStatus;
}
if (key == IdDateOfCommitment) {
return ssDateOfCommitment;
}
if (key == IdHasDeposit) {
return ssHasDeposit;
}
if (key == IdHasInsurance) {
return ssHasInsurance;
}
if (key == IdDistributionId) {
return ssDistributionId;
}
if (key == IdHasAdvancePayment) {
return ssHasAdvancePayment;
}
if (key == IdRetentionRate) {
return ssRetentionRate;
}
if (key == IdHasBaseDate) {
return ssHasBaseDate;
}
if (key == IdStartBaseDate) {
return ssStartBaseDate;
}
if (key == IdEndBaseDate) {
return ssEndBaseDate;
}
if (key == IdContractNumber) {
return ssContractNumber;
}
if (key == IdIsRetentionApplied) {
return ssIsRetentionApplied;
}
if (key == IdFrequency) {
return ssFrequency;
}
if (key == IdPeriod) {
return ssPeriod;
}
if (key == IdOrderRetentionTypeId) {
return ssOrderRetentionTypeId;
}
if (key == IdPaymentOptionsId) {
return ssPaymentOptionsId;
}
if (key == IdPaymentWaysId) {
return ssPaymentWaysId;
}
if (key == IdOrdersContract) {
return ssOrdersContract;
}
if (key == IdContractAmount) {
return ssContractAmount;
}
if (key == IdContractTarif) {
return ssContractTarif;
}
if (key == IdContractSupplier) {
return ssContractSupplier;
}
if (key == IdIsDependentFromFolios) {
return ssIsDependentFromFolios;
}
if (key == IdSpecialApprovalId) {
return ssSpecialApprovalId;
}
if (key == IdCreatedBy) {
return ssCreatedBy;
}
if (key == IdCreatedOn) {
return ssCreatedOn;
}
if (key == IdUpdatedBy) {
return ssUpdatedBy;
}
if (key == IdUpdatedOn) {
return ssUpdatedOn;
}
if (key == IdAllContactFilesValidated) {
return ssAllContactFilesValidated;
}
if (key == IdHasntRequestDocuments) {
return ssHasntRequestDocuments;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderId.Key.AsGuid) {
return ssOrderId;
}
if (attributeKey == IdIsApprovalFromUserArea.Key.AsGuid) {
return ssIsApprovalFromUserArea;
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
if (attributeKey == IdBusinessValueCategoryId.Key.AsGuid) {
return ssBusinessValueCategoryId;
}
if (attributeKey == IdBusinessValueSubcategoryId.Key.AsGuid) {
return ssBusinessValueSubcategoryId;
}
if (attributeKey == IdPaymentTermsId.Key.AsGuid) {
return ssPaymentTermsId;
}
if (attributeKey == IdPaymentMethodId.Key.AsGuid) {
return ssPaymentMethodId;
}
if (attributeKey == IdNegotiatedExchangeRate.Key.AsGuid) {
return ssNegotiatedExchangeRate;
}
if (attributeKey == IdContractStatus.Key.AsGuid) {
return ssContractStatus;
}
if (attributeKey == IdDateOfCommitment.Key.AsGuid) {
return ssDateOfCommitment;
}
if (attributeKey == IdHasDeposit.Key.AsGuid) {
return ssHasDeposit;
}
if (attributeKey == IdHasInsurance.Key.AsGuid) {
return ssHasInsurance;
}
if (attributeKey == IdDistributionId.Key.AsGuid) {
return ssDistributionId;
}
if (attributeKey == IdHasAdvancePayment.Key.AsGuid) {
return ssHasAdvancePayment;
}
if (attributeKey == IdRetentionRate.Key.AsGuid) {
return ssRetentionRate;
}
if (attributeKey == IdHasBaseDate.Key.AsGuid) {
return ssHasBaseDate;
}
if (attributeKey == IdStartBaseDate.Key.AsGuid) {
return ssStartBaseDate;
}
if (attributeKey == IdEndBaseDate.Key.AsGuid) {
return ssEndBaseDate;
}
if (attributeKey == IdContractNumber.Key.AsGuid) {
return ssContractNumber;
}
if (attributeKey == IdIsRetentionApplied.Key.AsGuid) {
return ssIsRetentionApplied;
}
if (attributeKey == IdFrequency.Key.AsGuid) {
return ssFrequency;
}
if (attributeKey == IdPeriod.Key.AsGuid) {
return ssPeriod;
}
if (attributeKey == IdOrderRetentionTypeId.Key.AsGuid) {
return ssOrderRetentionTypeId;
}
if (attributeKey == IdPaymentOptionsId.Key.AsGuid) {
return ssPaymentOptionsId;
}
if (attributeKey == IdPaymentWaysId.Key.AsGuid) {
return ssPaymentWaysId;
}
if (attributeKey == IdOrdersContract.Key.AsGuid) {
return ssOrdersContract;
}
if (attributeKey == IdContractAmount.Key.AsGuid) {
return ssContractAmount;
}
if (attributeKey == IdContractTarif.Key.AsGuid) {
return ssContractTarif;
}
if (attributeKey == IdContractSupplier.Key.AsGuid) {
return ssContractSupplier;
}
if (attributeKey == IdIsDependentFromFolios.Key.AsGuid) {
return ssIsDependentFromFolios;
}
if (attributeKey == IdSpecialApprovalId.Key.AsGuid) {
return ssSpecialApprovalId;
}
if (attributeKey == IdCreatedBy.Key.AsGuid) {
return ssCreatedBy;
}
if (attributeKey == IdCreatedOn.Key.AsGuid) {
return ssCreatedOn;
}
if (attributeKey == IdUpdatedBy.Key.AsGuid) {
return ssUpdatedBy;
}
if (attributeKey == IdUpdatedOn.Key.AsGuid) {
return ssUpdatedOn;
}
if (attributeKey == IdAllContactFilesValidated.Key.AsGuid) {
return ssAllContactFilesValidated;
}
if (attributeKey == IdHasntRequestDocuments.Key.AsGuid) {
return ssHasntRequestDocuments;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(39);
OptimizedAttributes = new BitArray(39);
if (other == null) return;
ssOrderId = (long) other.AttributeGet(IdOrderId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdOrderId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdOrderId);
ssIsApprovalFromUserArea = (bool) other.AttributeGet(IdIsApprovalFromUserArea);
ChangedAttributes[1] = other.ChangedAttributeGet(IdIsApprovalFromUserArea);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdIsApprovalFromUserArea);
ssProjectAssetServiceId = (long) other.AttributeGet(IdProjectAssetServiceId);
ChangedAttributes[2] = other.ChangedAttributeGet(IdProjectAssetServiceId);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdProjectAssetServiceId);
ssProjectAssetService = (string) other.AttributeGet(IdProjectAssetService);
ChangedAttributes[3] = other.ChangedAttributeGet(IdProjectAssetService);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdProjectAssetService);
ssProjectDescription = (string) other.AttributeGet(IdProjectDescription);
ChangedAttributes[4] = other.ChangedAttributeGet(IdProjectDescription);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdProjectDescription);
ssBusinessValueCategoryId = (long) other.AttributeGet(IdBusinessValueCategoryId);
ChangedAttributes[5] = other.ChangedAttributeGet(IdBusinessValueCategoryId);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdBusinessValueCategoryId);
ssBusinessValueSubcategoryId = (long) other.AttributeGet(IdBusinessValueSubcategoryId);
ChangedAttributes[6] = other.ChangedAttributeGet(IdBusinessValueSubcategoryId);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdBusinessValueSubcategoryId);
ssPaymentTermsId = (long) other.AttributeGet(IdPaymentTermsId);
ChangedAttributes[7] = other.ChangedAttributeGet(IdPaymentTermsId);
OptimizedAttributes[7] = other.OptimizedAttributeGet(IdPaymentTermsId);
ssPaymentMethodId = (long) other.AttributeGet(IdPaymentMethodId);
ChangedAttributes[8] = other.ChangedAttributeGet(IdPaymentMethodId);
OptimizedAttributes[8] = other.OptimizedAttributeGet(IdPaymentMethodId);
ssNegotiatedExchangeRate = (decimal) other.AttributeGet(IdNegotiatedExchangeRate);
ChangedAttributes[9] = other.ChangedAttributeGet(IdNegotiatedExchangeRate);
OptimizedAttributes[9] = other.OptimizedAttributeGet(IdNegotiatedExchangeRate);
ssContractStatus = (int) other.AttributeGet(IdContractStatus);
ChangedAttributes[10] = other.ChangedAttributeGet(IdContractStatus);
OptimizedAttributes[10] = other.OptimizedAttributeGet(IdContractStatus);
ssDateOfCommitment = (DateTime) other.AttributeGet(IdDateOfCommitment);
ChangedAttributes[11] = other.ChangedAttributeGet(IdDateOfCommitment);
OptimizedAttributes[11] = other.OptimizedAttributeGet(IdDateOfCommitment);
ssHasDeposit = (bool) other.AttributeGet(IdHasDeposit);
ChangedAttributes[12] = other.ChangedAttributeGet(IdHasDeposit);
OptimizedAttributes[12] = other.OptimizedAttributeGet(IdHasDeposit);
ssHasInsurance = (bool) other.AttributeGet(IdHasInsurance);
ChangedAttributes[13] = other.ChangedAttributeGet(IdHasInsurance);
OptimizedAttributes[13] = other.OptimizedAttributeGet(IdHasInsurance);
ssDistributionId = (int) other.AttributeGet(IdDistributionId);
ChangedAttributes[14] = other.ChangedAttributeGet(IdDistributionId);
OptimizedAttributes[14] = other.OptimizedAttributeGet(IdDistributionId);
ssHasAdvancePayment = (bool) other.AttributeGet(IdHasAdvancePayment);
ChangedAttributes[15] = other.ChangedAttributeGet(IdHasAdvancePayment);
OptimizedAttributes[15] = other.OptimizedAttributeGet(IdHasAdvancePayment);
ssRetentionRate = (decimal) other.AttributeGet(IdRetentionRate);
ChangedAttributes[16] = other.ChangedAttributeGet(IdRetentionRate);
OptimizedAttributes[16] = other.OptimizedAttributeGet(IdRetentionRate);
ssHasBaseDate = (bool) other.AttributeGet(IdHasBaseDate);
ChangedAttributes[17] = other.ChangedAttributeGet(IdHasBaseDate);
OptimizedAttributes[17] = other.OptimizedAttributeGet(IdHasBaseDate);
ssStartBaseDate = (DateTime) other.AttributeGet(IdStartBaseDate);
ChangedAttributes[18] = other.ChangedAttributeGet(IdStartBaseDate);
OptimizedAttributes[18] = other.OptimizedAttributeGet(IdStartBaseDate);
ssEndBaseDate = (DateTime) other.AttributeGet(IdEndBaseDate);
ChangedAttributes[19] = other.ChangedAttributeGet(IdEndBaseDate);
OptimizedAttributes[19] = other.OptimizedAttributeGet(IdEndBaseDate);
ssContractNumber = (string) other.AttributeGet(IdContractNumber);
ChangedAttributes[20] = other.ChangedAttributeGet(IdContractNumber);
OptimizedAttributes[20] = other.OptimizedAttributeGet(IdContractNumber);
ssIsRetentionApplied = (bool) other.AttributeGet(IdIsRetentionApplied);
ChangedAttributes[21] = other.ChangedAttributeGet(IdIsRetentionApplied);
OptimizedAttributes[21] = other.OptimizedAttributeGet(IdIsRetentionApplied);
ssFrequency = (int) other.AttributeGet(IdFrequency);
ChangedAttributes[22] = other.ChangedAttributeGet(IdFrequency);
OptimizedAttributes[22] = other.OptimizedAttributeGet(IdFrequency);
ssPeriod = (string) other.AttributeGet(IdPeriod);
ChangedAttributes[23] = other.ChangedAttributeGet(IdPeriod);
OptimizedAttributes[23] = other.OptimizedAttributeGet(IdPeriod);
ssOrderRetentionTypeId = (int) other.AttributeGet(IdOrderRetentionTypeId);
ChangedAttributes[24] = other.ChangedAttributeGet(IdOrderRetentionTypeId);
OptimizedAttributes[24] = other.OptimizedAttributeGet(IdOrderRetentionTypeId);
ssPaymentOptionsId = (long) other.AttributeGet(IdPaymentOptionsId);
ChangedAttributes[25] = other.ChangedAttributeGet(IdPaymentOptionsId);
OptimizedAttributes[25] = other.OptimizedAttributeGet(IdPaymentOptionsId);
ssPaymentWaysId = (long) other.AttributeGet(IdPaymentWaysId);
ChangedAttributes[26] = other.ChangedAttributeGet(IdPaymentWaysId);
OptimizedAttributes[26] = other.OptimizedAttributeGet(IdPaymentWaysId);
ssOrdersContract = (string) other.AttributeGet(IdOrdersContract);
ChangedAttributes[27] = other.ChangedAttributeGet(IdOrdersContract);
OptimizedAttributes[27] = other.OptimizedAttributeGet(IdOrdersContract);
ssContractAmount = (decimal) other.AttributeGet(IdContractAmount);
ChangedAttributes[28] = other.ChangedAttributeGet(IdContractAmount);
OptimizedAttributes[28] = other.OptimizedAttributeGet(IdContractAmount);
ssContractTarif = (decimal) other.AttributeGet(IdContractTarif);
ChangedAttributes[29] = other.ChangedAttributeGet(IdContractTarif);
OptimizedAttributes[29] = other.OptimizedAttributeGet(IdContractTarif);
ssContractSupplier = (long) other.AttributeGet(IdContractSupplier);
ChangedAttributes[30] = other.ChangedAttributeGet(IdContractSupplier);
OptimizedAttributes[30] = other.OptimizedAttributeGet(IdContractSupplier);
ssIsDependentFromFolios = (bool) other.AttributeGet(IdIsDependentFromFolios);
ChangedAttributes[31] = other.ChangedAttributeGet(IdIsDependentFromFolios);
OptimizedAttributes[31] = other.OptimizedAttributeGet(IdIsDependentFromFolios);
ssSpecialApprovalId = (int) other.AttributeGet(IdSpecialApprovalId);
ChangedAttributes[32] = other.ChangedAttributeGet(IdSpecialApprovalId);
OptimizedAttributes[32] = other.OptimizedAttributeGet(IdSpecialApprovalId);
ssCreatedBy = (string) other.AttributeGet(IdCreatedBy);
ChangedAttributes[33] = other.ChangedAttributeGet(IdCreatedBy);
OptimizedAttributes[33] = other.OptimizedAttributeGet(IdCreatedBy);
ssCreatedOn = (DateTime) other.AttributeGet(IdCreatedOn);
ChangedAttributes[34] = other.ChangedAttributeGet(IdCreatedOn);
OptimizedAttributes[34] = other.OptimizedAttributeGet(IdCreatedOn);
ssUpdatedBy = (string) other.AttributeGet(IdUpdatedBy);
ChangedAttributes[35] = other.ChangedAttributeGet(IdUpdatedBy);
OptimizedAttributes[35] = other.OptimizedAttributeGet(IdUpdatedBy);
ssUpdatedOn = (DateTime) other.AttributeGet(IdUpdatedOn);
ChangedAttributes[36] = other.ChangedAttributeGet(IdUpdatedOn);
OptimizedAttributes[36] = other.OptimizedAttributeGet(IdUpdatedOn);
ssAllContactFilesValidated = (bool) other.AttributeGet(IdAllContactFilesValidated);
ChangedAttributes[37] = other.ChangedAttributeGet(IdAllContactFilesValidated);
OptimizedAttributes[37] = other.OptimizedAttributeGet(IdAllContactFilesValidated);
ssHasntRequestDocuments = (bool) other.AttributeGet(IdHasntRequestDocuments);
ChangedAttributes[38] = other.ChangedAttributeGet(IdHasntRequestDocuments);
OptimizedAttributes[38] = other.OptimizedAttributeGet(IdHasntRequestDocuments);
}
} // EN_26f696e758428762fc617e811634d15dEntityRecord

/// <summary>
/// RecordList type <code>OrderDetailList</code> that represents a record list of
///  <code>OrderDetail</code>
/// </summary>
public partial class RL_6807bf5b87b57c9dd089d24998f166ae : GenericRecordList<EN_26f696e758428762fc617e811634d15dEntityRecord>, IEnumerable, IEnumerator {

protected override EN_26f696e758428762fc617e811634d15dEntityRecord GetElementDefaultValue() {
return new EN_26f696e758428762fc617e811634d15dEntityRecord();
}

public T[] ToArray<T>(Func<EN_26f696e758428762fc617e811634d15dEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_6807bf5b87b57c9dd089d24998f166ae recordList, Func<EN_26f696e758428762fc617e811634d15dEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_6807bf5b87b57c9dd089d24998f166ae(EN_26f696e758428762fc617e811634d15dEntityRecord[] array) {
  RL_6807bf5b87b57c9dd089d24998f166ae result = new RL_6807bf5b87b57c9dd089d24998f166ae();
result.InnerFromArray(array);
    return result;
}

public static RL_6807bf5b87b57c9dd089d24998f166ae ToList<T>(T[] array, Func <T, EN_26f696e758428762fc617e811634d15dEntityRecord> converter) {
  RL_6807bf5b87b57c9dd089d24998f166ae result = new RL_6807bf5b87b57c9dd089d24998f166ae();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_6807bf5b87b57c9dd089d24998f166ae FromRestList<T>(RestList<T> restList, Func <T, EN_26f696e758428762fc617e811634d15dEntityRecord> converter) {
  RL_6807bf5b87b57c9dd089d24998f166ae result = new RL_6807bf5b87b57c9dd089d24998f166ae();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_6807bf5b87b57c9dd089d24998f166ae() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_26f696e758428762fc617e811634d15dEntityRecord> NewList() {
return new RL_6807bf5b87b57c9dd089d24998f166ae();
}


} // RL_6807bf5b87b57c9dd089d24998f166ae
}
