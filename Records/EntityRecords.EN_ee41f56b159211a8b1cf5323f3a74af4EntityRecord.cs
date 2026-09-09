using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] OrderMainItem (SOJsF3FDbEK71RDTlTbuaQ)
///  <code>EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord</code> that represent
/// s <code>OrderMainItem</code> <p>Description: Entity that holds Orders Items.</p>
/// </summary>
// Name: OrderMainItem
public partial struct EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord : ITypedRecord<EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*amI5N0o5RkeFMaPnqqPpsg");
internal static readonly GlobalObjectKey IdOrderMainId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*IzoaJrjKykyFxfWQCBgRWA");
internal static readonly GlobalObjectKey IdPosition = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*OjI5ba84ikuvuhRwCccrIg");
internal static readonly GlobalObjectKey IdMaterialCode = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*VOxgmH3jNkibt2NcLm+4wA");
internal static readonly GlobalObjectKey IdMaterialDescription = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*qY3YNYgJh0mBzmoWakvPNA");
internal static readonly GlobalObjectKey IdAssigmnentCode = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*0II8VkgQCk+pR1djU1CNQA");
internal static readonly GlobalObjectKey IdDocumentClassId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Sjf1nz8D20eFCBqJHPa5TA");
internal static readonly GlobalObjectKey IdDeliveryDate = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*gTiPzftcDE6j7y01hBOu7Q");
internal static readonly GlobalObjectKey IdQuantity = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*0m60r+V90kymKU6nLNYZWA");
internal static readonly GlobalObjectKey IdUnitType = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*M_0MzzO8wkezoYWLMqJcIw");
internal static readonly GlobalObjectKey IdUnitPrice = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*lba7RQfGGk+v4g_OPzKM6g");
internal static readonly GlobalObjectKey IdBaseQuantity = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*TKdF_R90OkirR5viDR8DVA");
internal static readonly GlobalObjectKey IdIsDeleted = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*RI3YKDwQd0SSw0IYziXhHQ");
internal static readonly GlobalObjectKey IdIsBlocked = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*4VrP0ltB2kWfgdhuUwTtdw");
internal static readonly GlobalObjectKey IdIsFinalDelivery = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*nH8gx+aRU0GD2JeXjwyGQA");
internal static readonly GlobalObjectKey IdGLAccountId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*2bscRo9Ks0SG8f_wW8MtSA");
internal static readonly GlobalObjectKey IdCostCenterId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*YzWkme1LV0aGK_rFF3eWDw");
internal static readonly GlobalObjectKey IdFundsCenter = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*k_DDBPUNSk6LJFVDW4vfRw");
internal static readonly GlobalObjectKey IdFund = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*qLoowifcnEy8jZEjjEM7og");
internal static readonly GlobalObjectKey IdCommitmentItem = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*snvHhpjbWUK_PYtmUfqr6A");
internal static readonly GlobalObjectKey IdVATIndicator = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*TNAuYY0eiUqo2CSGtdamFg");
internal static readonly GlobalObjectKey IdVATProcedure = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*v5gne+4DG02KRsAaH7ruUA");
internal static readonly GlobalObjectKey IdVATRate = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*bqL_bPGeOkCmkzjKS3ENOw");
internal static readonly GlobalObjectKey IdPurchaseRequisitionNumber = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*O6JWyrFMrEi+WaePV7ygQA");
internal static readonly GlobalObjectKey IdPurchaseRequisitionItemNr = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*RydoASYXEkKDMsqsqxY1TA");
internal static readonly GlobalObjectKey IdRegionId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*S4uqku46_0SYi5Gt09C11Q");
internal static readonly GlobalObjectKey IdCenter = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*qHYXLa4inUa3JalZvNPWaw");
internal static readonly GlobalObjectKey IdPEPElement = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Y5rKzAr6+0KRhGDIA5ZSAQ");
internal static readonly GlobalObjectKey IdQuantityDelivered = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*VEnwagTsXk2JnlzoNNkqjQ");
internal static readonly GlobalObjectKey IdOrderUnitOfMeasure = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Yj5ZSjHaj0q00+cK9oXXfg");
internal static readonly GlobalObjectKey IdApplicant = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*8WE0hOpxuUqZZhylr7bAnw");
internal static readonly GlobalObjectKey IdDirection = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*pOUi_2IXbk+E+XRBUtyvnA");
internal static readonly GlobalObjectKey IdContractNumber = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*J1+XqNFg8EuKMqLwlDrgNQ");
internal static readonly GlobalObjectKey IdContractPosition = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*+sbC2ob0QkCTSoW1+v8HEQ");
internal static readonly GlobalObjectKey IdContractStartDate = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*bRaeTdaEF0ekxg9P6YuGXw");
internal static readonly GlobalObjectKey IdContractEndDate = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Be8xC9U1A0auRvCcdp_SmQ");
internal static readonly GlobalObjectKey IdContractPlannedValue = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*RcTei28IF0+n_LOpmTVTYw");
internal static readonly GlobalObjectKey IdPositionType = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*mNwwC9MOEkWv3m+Kjfj2dg");
internal static readonly GlobalObjectKey IdSerialNumberProfile = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*PL3gMDc9b0qcQD8E0sP4bQ");
internal static readonly GlobalObjectKey IdBatchManaged = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*EuqTrSye0E6_8SCTXC_TDQ");
internal static readonly GlobalObjectKey IdMaterialType = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*FNksFjbKHUS7BBknJ_ZVwQ");
internal static readonly GlobalObjectKey IdItemGroup = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*GZ5YWWt0oUitYORDHeljDQ");
internal static readonly GlobalObjectKey IdOrderRequestCreatorSAPNumber = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*3JfC55Iukkih24snnFGu6g");
internal static readonly GlobalObjectKey IdIsMultipleImputation = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*+3aj2gjhr0+eCjd+p87kEw");
internal static readonly GlobalObjectKey IdInvoiceUsageId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*hHg8PsyONkGPyoNjHwbzxA");
internal static readonly GlobalObjectKey IdOrderMainItemStatusId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*ls2zb4UyBUCB9OcEtmI4rg");
internal static readonly GlobalObjectKey IdDivisionId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*6SR7al013Em6amaVfCbOfg");
internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*hWyZ2Fyi3EywcL0jXEPuXw");
internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*CsMcoTPhoE65Yrg1D_fqZw");
internal static readonly GlobalObjectKey IdUpdatedBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*45PnUysGO0y4Iw3xCKc_HA");
internal static readonly GlobalObjectKey IdUpdatedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*HP0gBkh_pEGvvkGfFi543w");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(51,true);
          _ssId = value;
      }
  }
}

private long _ssOrderMainId;
public long ssOrderMainId{
  get{
      return _ssOrderMainId;
  }
  set{
      if((_ssOrderMainId!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssOrderMainId = value;
      }
  }
}

private int _ssPosition;
public int ssPosition{
  get{
      return _ssPosition;
  }
  set{
      if((_ssPosition!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssPosition = value;
      }
  }
}

private string _ssMaterialCode;
public string ssMaterialCode{
  get{
      return _ssMaterialCode;
  }
  set{
      if((_ssMaterialCode!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssMaterialCode = value;
      }
  }
}

private string _ssMaterialDescription;
public string ssMaterialDescription{
  get{
      return _ssMaterialDescription;
  }
  set{
      if((_ssMaterialDescription!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssMaterialDescription = value;
      }
  }
}

private string _ssAssigmnentCode;
public string ssAssigmnentCode{
  get{
      return _ssAssigmnentCode;
  }
  set{
      if((_ssAssigmnentCode!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssAssigmnentCode = value;
      }
  }
}

private long _ssDocumentClassId;
public long ssDocumentClassId{
  get{
      return _ssDocumentClassId;
  }
  set{
      if((_ssDocumentClassId!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssDocumentClassId = value;
      }
  }
}

private DateTime _ssDeliveryDate;
public DateTime ssDeliveryDate{
  get{
      return _ssDeliveryDate;
  }
  set{
      if((_ssDeliveryDate!=value) || OptimizedAttributes[7]){
          ChangedAttributes[7] = true;
          _ssDeliveryDate = value;
      }
  }
}

private decimal _ssQuantity;
public decimal ssQuantity{
  get{
      return _ssQuantity;
  }
  set{
      if((_ssQuantity!=value) || OptimizedAttributes[8]){
          ChangedAttributes[8] = true;
          _ssQuantity = value;
      }
  }
}

private string _ssUnitType;
public string ssUnitType{
  get{
      return _ssUnitType;
  }
  set{
      if((_ssUnitType!=value) || OptimizedAttributes[9]){
          ChangedAttributes[9] = true;
          _ssUnitType = value;
      }
  }
}

private decimal _ssUnitPrice;
public decimal ssUnitPrice{
  get{
      return _ssUnitPrice;
  }
  set{
      if((_ssUnitPrice!=value) || OptimizedAttributes[10]){
          ChangedAttributes[10] = true;
          _ssUnitPrice = value;
      }
  }
}

private int _ssBaseQuantity;
public int ssBaseQuantity{
  get{
      return _ssBaseQuantity;
  }
  set{
      if((_ssBaseQuantity!=value) || OptimizedAttributes[11]){
          ChangedAttributes[11] = true;
          _ssBaseQuantity = value;
      }
  }
}

private bool _ssIsDeleted;
public bool ssIsDeleted{
  get{
      return _ssIsDeleted;
  }
  set{
      if((_ssIsDeleted!=value) || OptimizedAttributes[12]){
          ChangedAttributes[12] = true;
          _ssIsDeleted = value;
      }
  }
}

private bool _ssIsBlocked;
public bool ssIsBlocked{
  get{
      return _ssIsBlocked;
  }
  set{
      if((_ssIsBlocked!=value) || OptimizedAttributes[13]){
          ChangedAttributes[13] = true;
          _ssIsBlocked = value;
      }
  }
}

private bool _ssIsFinalDelivery;
public bool ssIsFinalDelivery{
  get{
      return _ssIsFinalDelivery;
  }
  set{
      if((_ssIsFinalDelivery!=value) || OptimizedAttributes[14]){
          ChangedAttributes[14] = true;
          _ssIsFinalDelivery = value;
      }
  }
}

private long _ssGLAccountId;
public long ssGLAccountId{
  get{
      return _ssGLAccountId;
  }
  set{
      if((_ssGLAccountId!=value) || OptimizedAttributes[15]){
          ChangedAttributes[15] = true;
          _ssGLAccountId = value;
      }
  }
}

private long _ssCostCenterId;
public long ssCostCenterId{
  get{
      return _ssCostCenterId;
  }
  set{
      if((_ssCostCenterId!=value) || OptimizedAttributes[16]){
          ChangedAttributes[16] = true;
          _ssCostCenterId = value;
      }
  }
}

private string _ssFundsCenter;
public string ssFundsCenter{
  get{
      return _ssFundsCenter;
  }
  set{
      if((_ssFundsCenter!=value) || OptimizedAttributes[17]){
          ChangedAttributes[17] = true;
          _ssFundsCenter = value;
      }
  }
}

private string _ssFund;
public string ssFund{
  get{
      return _ssFund;
  }
  set{
      if((_ssFund!=value) || OptimizedAttributes[18]){
          ChangedAttributes[18] = true;
          _ssFund = value;
      }
  }
}

private string _ssCommitmentItem;
public string ssCommitmentItem{
  get{
      return _ssCommitmentItem;
  }
  set{
      if((_ssCommitmentItem!=value) || OptimizedAttributes[19]){
          ChangedAttributes[19] = true;
          _ssCommitmentItem = value;
      }
  }
}

private string _ssVATIndicator;
public string ssVATIndicator{
  get{
      return _ssVATIndicator;
  }
  set{
      if((_ssVATIndicator!=value) || OptimizedAttributes[20]){
          ChangedAttributes[20] = true;
          _ssVATIndicator = value;
      }
  }
}

private string _ssVATProcedure;
public string ssVATProcedure{
  get{
      return _ssVATProcedure;
  }
  set{
      if((_ssVATProcedure!=value) || OptimizedAttributes[21]){
          ChangedAttributes[21] = true;
          _ssVATProcedure = value;
      }
  }
}

private decimal _ssVATRate;
public decimal ssVATRate{
  get{
      return _ssVATRate;
  }
  set{
      if((_ssVATRate!=value) || OptimizedAttributes[22]){
          ChangedAttributes[22] = true;
          _ssVATRate = value;
      }
  }
}

private string _ssPurchaseRequisitionNumber;
public string ssPurchaseRequisitionNumber{
  get{
      return _ssPurchaseRequisitionNumber;
  }
  set{
      if((_ssPurchaseRequisitionNumber!=value) || OptimizedAttributes[23]){
          ChangedAttributes[23] = true;
          _ssPurchaseRequisitionNumber = value;
      }
  }
}

private int _ssPurchaseRequisitionItemNr;
public int ssPurchaseRequisitionItemNr{
  get{
      return _ssPurchaseRequisitionItemNr;
  }
  set{
      if((_ssPurchaseRequisitionItemNr!=value) || OptimizedAttributes[24]){
          ChangedAttributes[24] = true;
          _ssPurchaseRequisitionItemNr = value;
      }
  }
}

private long _ssRegionId;
public long ssRegionId{
  get{
      return _ssRegionId;
  }
  set{
      if((_ssRegionId!=value) || OptimizedAttributes[25]){
          ChangedAttributes[25] = true;
          _ssRegionId = value;
      }
  }
}

private string _ssCenter;
public string ssCenter{
  get{
      return _ssCenter;
  }
  set{
      if((_ssCenter!=value) || OptimizedAttributes[26]){
          ChangedAttributes[26] = true;
          _ssCenter = value;
      }
  }
}

private string _ssPEPElement;
public string ssPEPElement{
  get{
      return _ssPEPElement;
  }
  set{
      if((_ssPEPElement!=value) || OptimizedAttributes[27]){
          ChangedAttributes[27] = true;
          _ssPEPElement = value;
      }
  }
}

private decimal _ssQuantityDelivered;
public decimal ssQuantityDelivered{
  get{
      return _ssQuantityDelivered;
  }
  set{
      if((_ssQuantityDelivered!=value) || OptimizedAttributes[28]){
          ChangedAttributes[28] = true;
          _ssQuantityDelivered = value;
      }
  }
}

private string _ssOrderUnitOfMeasure;
public string ssOrderUnitOfMeasure{
  get{
      return _ssOrderUnitOfMeasure;
  }
  set{
      if((_ssOrderUnitOfMeasure!=value) || OptimizedAttributes[29]){
          ChangedAttributes[29] = true;
          _ssOrderUnitOfMeasure = value;
      }
  }
}

private string _ssApplicant;
public string ssApplicant{
  get{
      return _ssApplicant;
  }
  set{
      if((_ssApplicant!=value) || OptimizedAttributes[30]){
          ChangedAttributes[30] = true;
          _ssApplicant = value;
      }
  }
}

private string _ssDirection;
public string ssDirection{
  get{
      return _ssDirection;
  }
  set{
      if((_ssDirection!=value) || OptimizedAttributes[31]){
          ChangedAttributes[31] = true;
          _ssDirection = value;
      }
  }
}

private string _ssContractNumber;
public string ssContractNumber{
  get{
      return _ssContractNumber;
  }
  set{
      if((_ssContractNumber!=value) || OptimizedAttributes[32]){
          ChangedAttributes[32] = true;
          _ssContractNumber = value;
      }
  }
}

private int _ssContractPosition;
public int ssContractPosition{
  get{
      return _ssContractPosition;
  }
  set{
      if((_ssContractPosition!=value) || OptimizedAttributes[33]){
          ChangedAttributes[33] = true;
          _ssContractPosition = value;
      }
  }
}

private DateTime _ssContractStartDate;
public DateTime ssContractStartDate{
  get{
      return _ssContractStartDate;
  }
  set{
      if((_ssContractStartDate!=value) || OptimizedAttributes[34]){
          ChangedAttributes[34] = true;
          _ssContractStartDate = value;
      }
  }
}

private DateTime _ssContractEndDate;
public DateTime ssContractEndDate{
  get{
      return _ssContractEndDate;
  }
  set{
      if((_ssContractEndDate!=value) || OptimizedAttributes[35]){
          ChangedAttributes[35] = true;
          _ssContractEndDate = value;
      }
  }
}

private decimal _ssContractPlannedValue;
public decimal ssContractPlannedValue{
  get{
      return _ssContractPlannedValue;
  }
  set{
      if((_ssContractPlannedValue!=value) || OptimizedAttributes[36]){
          ChangedAttributes[36] = true;
          _ssContractPlannedValue = value;
      }
  }
}

private string _ssPositionType;
public string ssPositionType{
  get{
      return _ssPositionType;
  }
  set{
      if((_ssPositionType!=value) || OptimizedAttributes[37]){
          ChangedAttributes[37] = true;
          _ssPositionType = value;
      }
  }
}

private string _ssSerialNumberProfile;
public string ssSerialNumberProfile{
  get{
      return _ssSerialNumberProfile;
  }
  set{
      if((_ssSerialNumberProfile!=value) || OptimizedAttributes[38]){
          ChangedAttributes[38] = true;
          _ssSerialNumberProfile = value;
      }
  }
}

private string _ssBatchManaged;
public string ssBatchManaged{
  get{
      return _ssBatchManaged;
  }
  set{
      if((_ssBatchManaged!=value) || OptimizedAttributes[39]){
          ChangedAttributes[39] = true;
          _ssBatchManaged = value;
      }
  }
}

private string _ssMaterialType;
public string ssMaterialType{
  get{
      return _ssMaterialType;
  }
  set{
      if((_ssMaterialType!=value) || OptimizedAttributes[40]){
          ChangedAttributes[40] = true;
          _ssMaterialType = value;
      }
  }
}

private string _ssItemGroup;
public string ssItemGroup{
  get{
      return _ssItemGroup;
  }
  set{
      if((_ssItemGroup!=value) || OptimizedAttributes[41]){
          ChangedAttributes[41] = true;
          _ssItemGroup = value;
      }
  }
}

private string _ssOrderRequestCreatorSAPNumber;
public string ssOrderRequestCreatorSAPNumber{
  get{
      return _ssOrderRequestCreatorSAPNumber;
  }
  set{
      if((_ssOrderRequestCreatorSAPNumber!=value) || OptimizedAttributes[42]){
          ChangedAttributes[42] = true;
          _ssOrderRequestCreatorSAPNumber = value;
      }
  }
}

private bool _ssIsMultipleImputation;
public bool ssIsMultipleImputation{
  get{
      return _ssIsMultipleImputation;
  }
  set{
      if((_ssIsMultipleImputation!=value) || OptimizedAttributes[43]){
          ChangedAttributes[43] = true;
          _ssIsMultipleImputation = value;
      }
  }
}

private long _ssInvoiceUsageId;
public long ssInvoiceUsageId{
  get{
      return _ssInvoiceUsageId;
  }
  set{
      if((_ssInvoiceUsageId!=value) || OptimizedAttributes[44]){
          ChangedAttributes[44] = true;
          _ssInvoiceUsageId = value;
      }
  }
}

private int _ssOrderMainItemStatusId;
public int ssOrderMainItemStatusId{
  get{
      return _ssOrderMainItemStatusId;
  }
  set{
      if((_ssOrderMainItemStatusId!=value) || OptimizedAttributes[45]){
          ChangedAttributes[45] = true;
          _ssOrderMainItemStatusId = value;
      }
  }
}

private long _ssDivisionId;
public long ssDivisionId{
  get{
      return _ssDivisionId;
  }
  set{
      if((_ssDivisionId!=value) || OptimizedAttributes[46]){
          ChangedAttributes[46] = true;
          _ssDivisionId = value;
      }
  }
}

private string _ssCreatedBy;
public string ssCreatedBy{
  get{
      return _ssCreatedBy;
  }
  set{
      if((_ssCreatedBy!=value) || OptimizedAttributes[47]){
          ChangedAttributes[47] = true;
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
      if((_ssCreatedOn!=value) || OptimizedAttributes[48]){
          ChangedAttributes[48] = true;
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
      if((_ssUpdatedBy!=value) || OptimizedAttributes[49]){
          ChangedAttributes[49] = true;
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
      if((_ssUpdatedOn!=value) || OptimizedAttributes[50]){
          ChangedAttributes[50] = true;
          _ssUpdatedOn = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord() {
ChangedAttributes = new BitArray(51,true);
OptimizedAttributes = new BitArray(51,false);
_ssId = 0L;
_ssOrderMainId = 0L;
_ssPosition = 0;
_ssMaterialCode = "";
_ssMaterialDescription = "";
_ssAssigmnentCode = "";
_ssDocumentClassId = 0L;
_ssDeliveryDate = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssQuantity = 0.0M;
_ssUnitType = "";
_ssUnitPrice = 0.0M;
_ssBaseQuantity = 0;
_ssIsDeleted = false;
_ssIsBlocked = false;
_ssIsFinalDelivery = false;
_ssGLAccountId = 0L;
_ssCostCenterId = 0L;
_ssFundsCenter = "";
_ssFund = "";
_ssCommitmentItem = "";
_ssVATIndicator = "";
_ssVATProcedure = "";
_ssVATRate = 0.0M;
_ssPurchaseRequisitionNumber = "";
_ssPurchaseRequisitionItemNr = 0;
_ssRegionId = 0L;
_ssCenter = "";
_ssPEPElement = "";
_ssQuantityDelivered = 0.0M;
_ssOrderUnitOfMeasure = "";
_ssApplicant = "";
_ssDirection = "";
_ssContractNumber = "";
_ssContractPosition = 0;
_ssContractStartDate = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssContractEndDate = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssContractPlannedValue = 0.0M;
_ssPositionType = "";
_ssSerialNumberProfile = "";
_ssBatchManaged = "";
_ssMaterialType = "";
_ssItemGroup = "";
_ssOrderRequestCreatorSAPNumber = "";
_ssIsMultipleImputation = false;
_ssInvoiceUsageId = 0L;
_ssOrderMainItemStatusId = 0;
_ssDivisionId = 0L;
_ssCreatedBy = "";
_ssCreatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssUpdatedBy = "";
_ssUpdatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
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
ssId = r.ReadLongInteger(index++, "OrderMainItem.Id", 0L);
ssOrderMainId = r.ReadEntityReferenceLongInteger(index++, "OrderMainItem.OrderMainId", 0L);
ssPosition = r.ReadInteger(index++, "OrderMainItem.Position", 0);
ssMaterialCode = r.ReadText(index++, "OrderMainItem.MaterialCode", "");
ssMaterialDescription = r.ReadText(index++, "OrderMainItem.MaterialDescription", "");
ssAssigmnentCode = r.ReadText(index++, "OrderMainItem.AssigmnentCode", "");
ssDocumentClassId = r.ReadEntityReferenceLongInteger(index++, "OrderMainItem.DocumentClassId", 0L);
ssDeliveryDate = r.ReadDate(index++, "OrderMainItem.DeliveryDate", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssQuantity = r.ReadDecimal(index++, "OrderMainItem.Quantity", 0.0M);
ssUnitType = r.ReadText(index++, "OrderMainItem.UnitType", "");
ssUnitPrice = r.ReadDecimal(index++, "OrderMainItem.UnitPrice", 0.0M);
ssBaseQuantity = r.ReadInteger(index++, "OrderMainItem.BaseQuantity", 0);
ssIsDeleted = r.ReadBoolean(index++, "OrderMainItem.IsDeleted", false);
ssIsBlocked = r.ReadBoolean(index++, "OrderMainItem.IsBlocked", false);
ssIsFinalDelivery = r.ReadBoolean(index++, "OrderMainItem.IsFinalDelivery", false);
ssGLAccountId = r.ReadEntityReferenceLongInteger(index++, "OrderMainItem.GLAccountId", 0L);
ssCostCenterId = r.ReadEntityReferenceLongInteger(index++, "OrderMainItem.CostCenterId", 0L);
ssFundsCenter = r.ReadText(index++, "OrderMainItem.FundsCenter", "");
ssFund = r.ReadText(index++, "OrderMainItem.Fund", "");
ssCommitmentItem = r.ReadText(index++, "OrderMainItem.CommitmentItem", "");
ssVATIndicator = r.ReadText(index++, "OrderMainItem.VATIndicator", "");
ssVATProcedure = r.ReadText(index++, "OrderMainItem.VATProcedure", "");
ssVATRate = r.ReadDecimal(index++, "OrderMainItem.VATRate", 0.0M);
ssPurchaseRequisitionNumber = r.ReadText(index++, "OrderMainItem.PurchaseRequisitionNumber", "");
ssPurchaseRequisitionItemNr = r.ReadInteger(index++, "OrderMainItem.PurchaseRequisitionItemNr", 0);
ssRegionId = r.ReadEntityReferenceLongInteger(index++, "OrderMainItem.RegionId", 0L);
ssCenter = r.ReadText(index++, "OrderMainItem.Center", "");
ssPEPElement = r.ReadText(index++, "OrderMainItem.PEPElement", "");
ssQuantityDelivered = r.ReadDecimal(index++, "OrderMainItem.QuantityDelivered", 0.0M);
ssOrderUnitOfMeasure = r.ReadText(index++, "OrderMainItem.OrderUnitOfMeasure", "");
ssApplicant = r.ReadText(index++, "OrderMainItem.Applicant", "");
ssDirection = r.ReadText(index++, "OrderMainItem.Direction", "");
ssContractNumber = r.ReadText(index++, "OrderMainItem.ContractNumber", "");
ssContractPosition = r.ReadInteger(index++, "OrderMainItem.ContractPosition", 0);
ssContractStartDate = r.ReadDate(index++, "OrderMainItem.ContractStartDate", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssContractEndDate = r.ReadDate(index++, "OrderMainItem.ContractEndDate", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssContractPlannedValue = r.ReadDecimal(index++, "OrderMainItem.ContractPlannedValue", 0.0M);
ssPositionType = r.ReadText(index++, "OrderMainItem.PositionType", "");
ssSerialNumberProfile = r.ReadText(index++, "OrderMainItem.SerialNumberProfile", "");
ssBatchManaged = r.ReadText(index++, "OrderMainItem.BatchManaged", "");
ssMaterialType = r.ReadText(index++, "OrderMainItem.MaterialType", "");
ssItemGroup = r.ReadText(index++, "OrderMainItem.ItemGroup", "");
ssOrderRequestCreatorSAPNumber = r.ReadText(index++, "OrderMainItem.OrderRequestCreatorSAPNumber", "");
ssIsMultipleImputation = r.ReadBoolean(index++, "OrderMainItem.IsMultipleImputation", false);
ssInvoiceUsageId = r.ReadEntityReferenceLongInteger(index++, "OrderMainItem.InvoiceUsageId", 0L);
ssOrderMainItemStatusId = r.ReadEntityReference(index++, "OrderMainItem.OrderMainItemStatusId", 0);
ssDivisionId = r.ReadEntityReferenceLongInteger(index++, "OrderMainItem.DivisionId", 0L);
ssCreatedBy = r.ReadEntityReferenceText(index++, "OrderMainItem.CreatedBy", "");
ssCreatedOn = r.ReadDateTime(index++, "OrderMainItem.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssUpdatedBy = r.ReadEntityReferenceText(index++, "OrderMainItem.UpdatedBy", "");
ssUpdatedOn = r.ReadDateTime(index++, "OrderMainItem.UpdatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ChangedAttributes = new BitArray(51,false);
OptimizedAttributes = new BitArray(51,false);
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
public void ReadIM(EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord r) {
this = r;
}


public static bool operator == (EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord a, EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssOrderMainId != b.ssOrderMainId) return false;
if (a.ssPosition != b.ssPosition) return false;
if (a.ssMaterialCode != b.ssMaterialCode) return false;
if (a.ssMaterialDescription != b.ssMaterialDescription) return false;
if (a.ssAssigmnentCode != b.ssAssigmnentCode) return false;
if (a.ssDocumentClassId != b.ssDocumentClassId) return false;
if (a.ssDeliveryDate != b.ssDeliveryDate) return false;
if (a.ssQuantity != b.ssQuantity) return false;
if (a.ssUnitType != b.ssUnitType) return false;
if (a.ssUnitPrice != b.ssUnitPrice) return false;
if (a.ssBaseQuantity != b.ssBaseQuantity) return false;
if (a.ssIsDeleted != b.ssIsDeleted) return false;
if (a.ssIsBlocked != b.ssIsBlocked) return false;
if (a.ssIsFinalDelivery != b.ssIsFinalDelivery) return false;
if (a.ssGLAccountId != b.ssGLAccountId) return false;
if (a.ssCostCenterId != b.ssCostCenterId) return false;
if (a.ssFundsCenter != b.ssFundsCenter) return false;
if (a.ssFund != b.ssFund) return false;
if (a.ssCommitmentItem != b.ssCommitmentItem) return false;
if (a.ssVATIndicator != b.ssVATIndicator) return false;
if (a.ssVATProcedure != b.ssVATProcedure) return false;
if (a.ssVATRate != b.ssVATRate) return false;
if (a.ssPurchaseRequisitionNumber != b.ssPurchaseRequisitionNumber) return false;
if (a.ssPurchaseRequisitionItemNr != b.ssPurchaseRequisitionItemNr) return false;
if (a.ssRegionId != b.ssRegionId) return false;
if (a.ssCenter != b.ssCenter) return false;
if (a.ssPEPElement != b.ssPEPElement) return false;
if (a.ssQuantityDelivered != b.ssQuantityDelivered) return false;
if (a.ssOrderUnitOfMeasure != b.ssOrderUnitOfMeasure) return false;
if (a.ssApplicant != b.ssApplicant) return false;
if (a.ssDirection != b.ssDirection) return false;
if (a.ssContractNumber != b.ssContractNumber) return false;
if (a.ssContractPosition != b.ssContractPosition) return false;
if (a.ssContractStartDate != b.ssContractStartDate) return false;
if (a.ssContractEndDate != b.ssContractEndDate) return false;
if (a.ssContractPlannedValue != b.ssContractPlannedValue) return false;
if (a.ssPositionType != b.ssPositionType) return false;
if (a.ssSerialNumberProfile != b.ssSerialNumberProfile) return false;
if (a.ssBatchManaged != b.ssBatchManaged) return false;
if (a.ssMaterialType != b.ssMaterialType) return false;
if (a.ssItemGroup != b.ssItemGroup) return false;
if (a.ssOrderRequestCreatorSAPNumber != b.ssOrderRequestCreatorSAPNumber) return false;
if (a.ssIsMultipleImputation != b.ssIsMultipleImputation) return false;
if (a.ssInvoiceUsageId != b.ssInvoiceUsageId) return false;
if (a.ssOrderMainItemStatusId != b.ssOrderMainItemStatusId) return false;
if (a.ssDivisionId != b.ssDivisionId) return false;
if (a.ssCreatedBy != b.ssCreatedBy) return false;
if (a.ssCreatedOn != b.ssCreatedOn) return false;
if (a.ssUpdatedBy != b.ssUpdatedBy) return false;
if (a.ssUpdatedOn != b.ssUpdatedOn) return false;
return true;
}

public static bool operator != (EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord a, EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord)) return false;
return (this == (EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssOrderMainId.GetHashCode()
 ^ ssPosition.GetHashCode()
 ^ ssMaterialCode.GetHashCode()
 ^ ssMaterialDescription.GetHashCode()
 ^ ssAssigmnentCode.GetHashCode()
 ^ ssDocumentClassId.GetHashCode()
 ^ ssDeliveryDate.GetHashCode()
 ^ ssQuantity.GetHashCode()
 ^ ssUnitType.GetHashCode()
 ^ ssUnitPrice.GetHashCode()
 ^ ssBaseQuantity.GetHashCode()
 ^ ssIsDeleted.GetHashCode()
 ^ ssIsBlocked.GetHashCode()
 ^ ssIsFinalDelivery.GetHashCode()
 ^ ssGLAccountId.GetHashCode()
 ^ ssCostCenterId.GetHashCode()
 ^ ssFundsCenter.GetHashCode()
 ^ ssFund.GetHashCode()
 ^ ssCommitmentItem.GetHashCode()
 ^ ssVATIndicator.GetHashCode()
 ^ ssVATProcedure.GetHashCode()
 ^ ssVATRate.GetHashCode()
 ^ ssPurchaseRequisitionNumber.GetHashCode()
 ^ ssPurchaseRequisitionItemNr.GetHashCode()
 ^ ssRegionId.GetHashCode()
 ^ ssCenter.GetHashCode()
 ^ ssPEPElement.GetHashCode()
 ^ ssQuantityDelivered.GetHashCode()
 ^ ssOrderUnitOfMeasure.GetHashCode()
 ^ ssApplicant.GetHashCode()
 ^ ssDirection.GetHashCode()
 ^ ssContractNumber.GetHashCode()
 ^ ssContractPosition.GetHashCode()
 ^ ssContractStartDate.GetHashCode()
 ^ ssContractEndDate.GetHashCode()
 ^ ssContractPlannedValue.GetHashCode()
 ^ ssPositionType.GetHashCode()
 ^ ssSerialNumberProfile.GetHashCode()
 ^ ssBatchManaged.GetHashCode()
 ^ ssMaterialType.GetHashCode()
 ^ ssItemGroup.GetHashCode()
 ^ ssOrderRequestCreatorSAPNumber.GetHashCode()
 ^ ssIsMultipleImputation.GetHashCode()
 ^ ssInvoiceUsageId.GetHashCode()
 ^ ssOrderMainItemStatusId.GetHashCode()
 ^ ssDivisionId.GetHashCode()
 ^ ssCreatedBy.GetHashCode()
 ^ ssCreatedOn.GetHashCode()
 ^ ssUpdatedBy.GetHashCode()
 ^ ssUpdatedOn.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord Duplicate() {
EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord t;
t._ssId = this._ssId;
t._ssOrderMainId = this._ssOrderMainId;
t._ssPosition = this._ssPosition;
t._ssMaterialCode = this._ssMaterialCode;
t._ssMaterialDescription = this._ssMaterialDescription;
t._ssAssigmnentCode = this._ssAssigmnentCode;
t._ssDocumentClassId = this._ssDocumentClassId;
t._ssDeliveryDate = this._ssDeliveryDate;
t._ssQuantity = this._ssQuantity;
t._ssUnitType = this._ssUnitType;
t._ssUnitPrice = this._ssUnitPrice;
t._ssBaseQuantity = this._ssBaseQuantity;
t._ssIsDeleted = this._ssIsDeleted;
t._ssIsBlocked = this._ssIsBlocked;
t._ssIsFinalDelivery = this._ssIsFinalDelivery;
t._ssGLAccountId = this._ssGLAccountId;
t._ssCostCenterId = this._ssCostCenterId;
t._ssFundsCenter = this._ssFundsCenter;
t._ssFund = this._ssFund;
t._ssCommitmentItem = this._ssCommitmentItem;
t._ssVATIndicator = this._ssVATIndicator;
t._ssVATProcedure = this._ssVATProcedure;
t._ssVATRate = this._ssVATRate;
t._ssPurchaseRequisitionNumber = this._ssPurchaseRequisitionNumber;
t._ssPurchaseRequisitionItemNr = this._ssPurchaseRequisitionItemNr;
t._ssRegionId = this._ssRegionId;
t._ssCenter = this._ssCenter;
t._ssPEPElement = this._ssPEPElement;
t._ssQuantityDelivered = this._ssQuantityDelivered;
t._ssOrderUnitOfMeasure = this._ssOrderUnitOfMeasure;
t._ssApplicant = this._ssApplicant;
t._ssDirection = this._ssDirection;
t._ssContractNumber = this._ssContractNumber;
t._ssContractPosition = this._ssContractPosition;
t._ssContractStartDate = this._ssContractStartDate;
t._ssContractEndDate = this._ssContractEndDate;
t._ssContractPlannedValue = this._ssContractPlannedValue;
t._ssPositionType = this._ssPositionType;
t._ssSerialNumberProfile = this._ssSerialNumberProfile;
t._ssBatchManaged = this._ssBatchManaged;
t._ssMaterialType = this._ssMaterialType;
t._ssItemGroup = this._ssItemGroup;
t._ssOrderRequestCreatorSAPNumber = this._ssOrderRequestCreatorSAPNumber;
t._ssIsMultipleImputation = this._ssIsMultipleImputation;
t._ssInvoiceUsageId = this._ssInvoiceUsageId;
t._ssOrderMainItemStatusId = this._ssOrderMainItemStatusId;
t._ssDivisionId = this._ssDivisionId;
t._ssCreatedBy = this._ssCreatedBy;
t._ssCreatedOn = this._ssCreatedOn;
t._ssUpdatedBy = this._ssUpdatedBy;
t._ssUpdatedOn = this._ssUpdatedOn;
t.ChangedAttributes = new BitArray(51);
t.OptimizedAttributes = new BitArray(51);
for(int i = 0; i < 51; i++){
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
} else if (head == "ordermainid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMainId")) variable.Value = ssOrderMainId; else variable.Optimized = true;
} else if (head == "position") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Position")) variable.Value = ssPosition; else variable.Optimized = true;
} else if (head == "materialcode") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MaterialCode")) variable.Value = ssMaterialCode; else variable.Optimized = true;
} else if (head == "materialdescription") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MaterialDescription")) variable.Value = ssMaterialDescription; else variable.Optimized = true;
} else if (head == "assigmnentcode") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AssigmnentCode")) variable.Value = ssAssigmnentCode; else variable.Optimized = true;
} else if (head == "documentclassid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DocumentClassId")) variable.Value = ssDocumentClassId; else variable.Optimized = true;
} else if (head == "deliverydate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DeliveryDate")) variable.Value = ssDeliveryDate; else variable.Optimized = true;
} else if (head == "quantity") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Quantity")) variable.Value = ssQuantity; else variable.Optimized = true;
} else if (head == "unittype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UnitType")) variable.Value = ssUnitType; else variable.Optimized = true;
} else if (head == "unitprice") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UnitPrice")) variable.Value = ssUnitPrice; else variable.Optimized = true;
} else if (head == "basequantity") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".BaseQuantity")) variable.Value = ssBaseQuantity; else variable.Optimized = true;
} else if (head == "isdeleted") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsDeleted")) variable.Value = ssIsDeleted; else variable.Optimized = true;
} else if (head == "isblocked") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsBlocked")) variable.Value = ssIsBlocked; else variable.Optimized = true;
} else if (head == "isfinaldelivery") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsFinalDelivery")) variable.Value = ssIsFinalDelivery; else variable.Optimized = true;
} else if (head == "glaccountid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".GLAccountId")) variable.Value = ssGLAccountId; else variable.Optimized = true;
} else if (head == "costcenterid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CostCenterId")) variable.Value = ssCostCenterId; else variable.Optimized = true;
} else if (head == "fundscenter") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FundsCenter")) variable.Value = ssFundsCenter; else variable.Optimized = true;
} else if (head == "fund") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Fund")) variable.Value = ssFund; else variable.Optimized = true;
} else if (head == "commitmentitem") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CommitmentItem")) variable.Value = ssCommitmentItem; else variable.Optimized = true;
} else if (head == "vatindicator") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".VATIndicator")) variable.Value = ssVATIndicator; else variable.Optimized = true;
} else if (head == "vatprocedure") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".VATProcedure")) variable.Value = ssVATProcedure; else variable.Optimized = true;
} else if (head == "vatrate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".VATRate")) variable.Value = ssVATRate; else variable.Optimized = true;
} else if (head == "purchaserequisitionnumber") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PurchaseRequisitionNumber")) variable.Value = ssPurchaseRequisitionNumber; else variable.Optimized = true;
} else if (head == "purchaserequisitionitemnr") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PurchaseRequisitionItemNr")) variable.Value = ssPurchaseRequisitionItemNr; else variable.Optimized = true;
} else if (head == "regionid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RegionId")) variable.Value = ssRegionId; else variable.Optimized = true;
} else if (head == "center") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Center")) variable.Value = ssCenter; else variable.Optimized = true;
} else if (head == "pepelement") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PEPElement")) variable.Value = ssPEPElement; else variable.Optimized = true;
} else if (head == "quantitydelivered") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".QuantityDelivered")) variable.Value = ssQuantityDelivered; else variable.Optimized = true;
} else if (head == "orderunitofmeasure") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderUnitOfMeasure")) variable.Value = ssOrderUnitOfMeasure; else variable.Optimized = true;
} else if (head == "applicant") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Applicant")) variable.Value = ssApplicant; else variable.Optimized = true;
} else if (head == "direction") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Direction")) variable.Value = ssDirection; else variable.Optimized = true;
} else if (head == "contractnumber") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ContractNumber")) variable.Value = ssContractNumber; else variable.Optimized = true;
} else if (head == "contractposition") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ContractPosition")) variable.Value = ssContractPosition; else variable.Optimized = true;
} else if (head == "contractstartdate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ContractStartDate")) variable.Value = ssContractStartDate; else variable.Optimized = true;
} else if (head == "contractenddate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ContractEndDate")) variable.Value = ssContractEndDate; else variable.Optimized = true;
} else if (head == "contractplannedvalue") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ContractPlannedValue")) variable.Value = ssContractPlannedValue; else variable.Optimized = true;
} else if (head == "positiontype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PositionType")) variable.Value = ssPositionType; else variable.Optimized = true;
} else if (head == "serialnumberprofile") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SerialNumberProfile")) variable.Value = ssSerialNumberProfile; else variable.Optimized = true;
} else if (head == "batchmanaged") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".BatchManaged")) variable.Value = ssBatchManaged; else variable.Optimized = true;
} else if (head == "materialtype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MaterialType")) variable.Value = ssMaterialType; else variable.Optimized = true;
} else if (head == "itemgroup") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ItemGroup")) variable.Value = ssItemGroup; else variable.Optimized = true;
} else if (head == "orderrequestcreatorsapnumber") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderRequestCreatorSAPNumber")) variable.Value = ssOrderRequestCreatorSAPNumber; else variable.Optimized = true;
} else if (head == "ismultipleimputation") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsMultipleImputation")) variable.Value = ssIsMultipleImputation; else variable.Optimized = true;
} else if (head == "invoiceusageid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceUsageId")) variable.Value = ssInvoiceUsageId; else variable.Optimized = true;
} else if (head == "ordermainitemstatusid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMainItemStatusId")) variable.Value = ssOrderMainItemStatusId; else variable.Optimized = true;
} else if (head == "divisionid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DivisionId")) variable.Value = ssDivisionId; else variable.Optimized = true;
} else if (head == "createdby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedBy")) variable.Value = ssCreatedBy; else variable.Optimized = true;
} else if (head == "createdon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedOn")) variable.Value = ssCreatedOn; else variable.Optimized = true;
} else if (head == "updatedby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdatedBy")) variable.Value = ssUpdatedBy; else variable.Optimized = true;
} else if (head == "updatedon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdatedOn")) variable.Value = ssUpdatedOn; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdOrderMainId)) {
return ChangedAttributes[1];
}
if (key.Equals(IdPosition)) {
return ChangedAttributes[2];
}
if (key.Equals(IdMaterialCode)) {
return ChangedAttributes[3];
}
if (key.Equals(IdMaterialDescription)) {
return ChangedAttributes[4];
}
if (key.Equals(IdAssigmnentCode)) {
return ChangedAttributes[5];
}
if (key.Equals(IdDocumentClassId)) {
return ChangedAttributes[6];
}
if (key.Equals(IdDeliveryDate)) {
return ChangedAttributes[7];
}
if (key.Equals(IdQuantity)) {
return ChangedAttributes[8];
}
if (key.Equals(IdUnitType)) {
return ChangedAttributes[9];
}
if (key.Equals(IdUnitPrice)) {
return ChangedAttributes[10];
}
if (key.Equals(IdBaseQuantity)) {
return ChangedAttributes[11];
}
if (key.Equals(IdIsDeleted)) {
return ChangedAttributes[12];
}
if (key.Equals(IdIsBlocked)) {
return ChangedAttributes[13];
}
if (key.Equals(IdIsFinalDelivery)) {
return ChangedAttributes[14];
}
if (key.Equals(IdGLAccountId)) {
return ChangedAttributes[15];
}
if (key.Equals(IdCostCenterId)) {
return ChangedAttributes[16];
}
if (key.Equals(IdFundsCenter)) {
return ChangedAttributes[17];
}
if (key.Equals(IdFund)) {
return ChangedAttributes[18];
}
if (key.Equals(IdCommitmentItem)) {
return ChangedAttributes[19];
}
if (key.Equals(IdVATIndicator)) {
return ChangedAttributes[20];
}
if (key.Equals(IdVATProcedure)) {
return ChangedAttributes[21];
}
if (key.Equals(IdVATRate)) {
return ChangedAttributes[22];
}
if (key.Equals(IdPurchaseRequisitionNumber)) {
return ChangedAttributes[23];
}
if (key.Equals(IdPurchaseRequisitionItemNr)) {
return ChangedAttributes[24];
}
if (key.Equals(IdRegionId)) {
return ChangedAttributes[25];
}
if (key.Equals(IdCenter)) {
return ChangedAttributes[26];
}
if (key.Equals(IdPEPElement)) {
return ChangedAttributes[27];
}
if (key.Equals(IdQuantityDelivered)) {
return ChangedAttributes[28];
}
if (key.Equals(IdOrderUnitOfMeasure)) {
return ChangedAttributes[29];
}
if (key.Equals(IdApplicant)) {
return ChangedAttributes[30];
}
if (key.Equals(IdDirection)) {
return ChangedAttributes[31];
}
if (key.Equals(IdContractNumber)) {
return ChangedAttributes[32];
}
if (key.Equals(IdContractPosition)) {
return ChangedAttributes[33];
}
if (key.Equals(IdContractStartDate)) {
return ChangedAttributes[34];
}
if (key.Equals(IdContractEndDate)) {
return ChangedAttributes[35];
}
if (key.Equals(IdContractPlannedValue)) {
return ChangedAttributes[36];
}
if (key.Equals(IdPositionType)) {
return ChangedAttributes[37];
}
if (key.Equals(IdSerialNumberProfile)) {
return ChangedAttributes[38];
}
if (key.Equals(IdBatchManaged)) {
return ChangedAttributes[39];
}
if (key.Equals(IdMaterialType)) {
return ChangedAttributes[40];
}
if (key.Equals(IdItemGroup)) {
return ChangedAttributes[41];
}
if (key.Equals(IdOrderRequestCreatorSAPNumber)) {
return ChangedAttributes[42];
}
if (key.Equals(IdIsMultipleImputation)) {
return ChangedAttributes[43];
}
if (key.Equals(IdInvoiceUsageId)) {
return ChangedAttributes[44];
}
if (key.Equals(IdOrderMainItemStatusId)) {
return ChangedAttributes[45];
}
if (key.Equals(IdDivisionId)) {
return ChangedAttributes[46];
}
if (key.Equals(IdCreatedBy)) {
return ChangedAttributes[47];
}
if (key.Equals(IdCreatedOn)) {
return ChangedAttributes[48];
}
if (key.Equals(IdUpdatedBy)) {
return ChangedAttributes[49];
}
if (key.Equals(IdUpdatedOn)) {
return ChangedAttributes[50];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdOrderMainId)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdPosition)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdMaterialCode)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdMaterialDescription)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdAssigmnentCode)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdDocumentClassId)) {
return OptimizedAttributes[6];
}
if (key.Equals(IdDeliveryDate)) {
return OptimizedAttributes[7];
}
if (key.Equals(IdQuantity)) {
return OptimizedAttributes[8];
}
if (key.Equals(IdUnitType)) {
return OptimizedAttributes[9];
}
if (key.Equals(IdUnitPrice)) {
return OptimizedAttributes[10];
}
if (key.Equals(IdBaseQuantity)) {
return OptimizedAttributes[11];
}
if (key.Equals(IdIsDeleted)) {
return OptimizedAttributes[12];
}
if (key.Equals(IdIsBlocked)) {
return OptimizedAttributes[13];
}
if (key.Equals(IdIsFinalDelivery)) {
return OptimizedAttributes[14];
}
if (key.Equals(IdGLAccountId)) {
return OptimizedAttributes[15];
}
if (key.Equals(IdCostCenterId)) {
return OptimizedAttributes[16];
}
if (key.Equals(IdFundsCenter)) {
return OptimizedAttributes[17];
}
if (key.Equals(IdFund)) {
return OptimizedAttributes[18];
}
if (key.Equals(IdCommitmentItem)) {
return OptimizedAttributes[19];
}
if (key.Equals(IdVATIndicator)) {
return OptimizedAttributes[20];
}
if (key.Equals(IdVATProcedure)) {
return OptimizedAttributes[21];
}
if (key.Equals(IdVATRate)) {
return OptimizedAttributes[22];
}
if (key.Equals(IdPurchaseRequisitionNumber)) {
return OptimizedAttributes[23];
}
if (key.Equals(IdPurchaseRequisitionItemNr)) {
return OptimizedAttributes[24];
}
if (key.Equals(IdRegionId)) {
return OptimizedAttributes[25];
}
if (key.Equals(IdCenter)) {
return OptimizedAttributes[26];
}
if (key.Equals(IdPEPElement)) {
return OptimizedAttributes[27];
}
if (key.Equals(IdQuantityDelivered)) {
return OptimizedAttributes[28];
}
if (key.Equals(IdOrderUnitOfMeasure)) {
return OptimizedAttributes[29];
}
if (key.Equals(IdApplicant)) {
return OptimizedAttributes[30];
}
if (key.Equals(IdDirection)) {
return OptimizedAttributes[31];
}
if (key.Equals(IdContractNumber)) {
return OptimizedAttributes[32];
}
if (key.Equals(IdContractPosition)) {
return OptimizedAttributes[33];
}
if (key.Equals(IdContractStartDate)) {
return OptimizedAttributes[34];
}
if (key.Equals(IdContractEndDate)) {
return OptimizedAttributes[35];
}
if (key.Equals(IdContractPlannedValue)) {
return OptimizedAttributes[36];
}
if (key.Equals(IdPositionType)) {
return OptimizedAttributes[37];
}
if (key.Equals(IdSerialNumberProfile)) {
return OptimizedAttributes[38];
}
if (key.Equals(IdBatchManaged)) {
return OptimizedAttributes[39];
}
if (key.Equals(IdMaterialType)) {
return OptimizedAttributes[40];
}
if (key.Equals(IdItemGroup)) {
return OptimizedAttributes[41];
}
if (key.Equals(IdOrderRequestCreatorSAPNumber)) {
return OptimizedAttributes[42];
}
if (key.Equals(IdIsMultipleImputation)) {
return OptimizedAttributes[43];
}
if (key.Equals(IdInvoiceUsageId)) {
return OptimizedAttributes[44];
}
if (key.Equals(IdOrderMainItemStatusId)) {
return OptimizedAttributes[45];
}
if (key.Equals(IdDivisionId)) {
return OptimizedAttributes[46];
}
if (key.Equals(IdCreatedBy)) {
return OptimizedAttributes[47];
}
if (key.Equals(IdCreatedOn)) {
return OptimizedAttributes[48];
}
if (key.Equals(IdUpdatedBy)) {
return OptimizedAttributes[49];
}
if (key.Equals(IdUpdatedOn)) {
return OptimizedAttributes[50];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdOrderMainId) {
return ssOrderMainId;
}
if (key == IdPosition) {
return ssPosition;
}
if (key == IdMaterialCode) {
return ssMaterialCode;
}
if (key == IdMaterialDescription) {
return ssMaterialDescription;
}
if (key == IdAssigmnentCode) {
return ssAssigmnentCode;
}
if (key == IdDocumentClassId) {
return ssDocumentClassId;
}
if (key == IdDeliveryDate) {
return ssDeliveryDate;
}
if (key == IdQuantity) {
return ssQuantity;
}
if (key == IdUnitType) {
return ssUnitType;
}
if (key == IdUnitPrice) {
return ssUnitPrice;
}
if (key == IdBaseQuantity) {
return ssBaseQuantity;
}
if (key == IdIsDeleted) {
return ssIsDeleted;
}
if (key == IdIsBlocked) {
return ssIsBlocked;
}
if (key == IdIsFinalDelivery) {
return ssIsFinalDelivery;
}
if (key == IdGLAccountId) {
return ssGLAccountId;
}
if (key == IdCostCenterId) {
return ssCostCenterId;
}
if (key == IdFundsCenter) {
return ssFundsCenter;
}
if (key == IdFund) {
return ssFund;
}
if (key == IdCommitmentItem) {
return ssCommitmentItem;
}
if (key == IdVATIndicator) {
return ssVATIndicator;
}
if (key == IdVATProcedure) {
return ssVATProcedure;
}
if (key == IdVATRate) {
return ssVATRate;
}
if (key == IdPurchaseRequisitionNumber) {
return ssPurchaseRequisitionNumber;
}
if (key == IdPurchaseRequisitionItemNr) {
return ssPurchaseRequisitionItemNr;
}
if (key == IdRegionId) {
return ssRegionId;
}
if (key == IdCenter) {
return ssCenter;
}
if (key == IdPEPElement) {
return ssPEPElement;
}
if (key == IdQuantityDelivered) {
return ssQuantityDelivered;
}
if (key == IdOrderUnitOfMeasure) {
return ssOrderUnitOfMeasure;
}
if (key == IdApplicant) {
return ssApplicant;
}
if (key == IdDirection) {
return ssDirection;
}
if (key == IdContractNumber) {
return ssContractNumber;
}
if (key == IdContractPosition) {
return ssContractPosition;
}
if (key == IdContractStartDate) {
return ssContractStartDate;
}
if (key == IdContractEndDate) {
return ssContractEndDate;
}
if (key == IdContractPlannedValue) {
return ssContractPlannedValue;
}
if (key == IdPositionType) {
return ssPositionType;
}
if (key == IdSerialNumberProfile) {
return ssSerialNumberProfile;
}
if (key == IdBatchManaged) {
return ssBatchManaged;
}
if (key == IdMaterialType) {
return ssMaterialType;
}
if (key == IdItemGroup) {
return ssItemGroup;
}
if (key == IdOrderRequestCreatorSAPNumber) {
return ssOrderRequestCreatorSAPNumber;
}
if (key == IdIsMultipleImputation) {
return ssIsMultipleImputation;
}
if (key == IdInvoiceUsageId) {
return ssInvoiceUsageId;
}
if (key == IdOrderMainItemStatusId) {
return ssOrderMainItemStatusId;
}
if (key == IdDivisionId) {
return ssDivisionId;
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
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdOrderMainId.Key.AsGuid) {
return ssOrderMainId;
}
if (attributeKey == IdPosition.Key.AsGuid) {
return ssPosition;
}
if (attributeKey == IdMaterialCode.Key.AsGuid) {
return ssMaterialCode;
}
if (attributeKey == IdMaterialDescription.Key.AsGuid) {
return ssMaterialDescription;
}
if (attributeKey == IdAssigmnentCode.Key.AsGuid) {
return ssAssigmnentCode;
}
if (attributeKey == IdDocumentClassId.Key.AsGuid) {
return ssDocumentClassId;
}
if (attributeKey == IdDeliveryDate.Key.AsGuid) {
return ssDeliveryDate;
}
if (attributeKey == IdQuantity.Key.AsGuid) {
return ssQuantity;
}
if (attributeKey == IdUnitType.Key.AsGuid) {
return ssUnitType;
}
if (attributeKey == IdUnitPrice.Key.AsGuid) {
return ssUnitPrice;
}
if (attributeKey == IdBaseQuantity.Key.AsGuid) {
return ssBaseQuantity;
}
if (attributeKey == IdIsDeleted.Key.AsGuid) {
return ssIsDeleted;
}
if (attributeKey == IdIsBlocked.Key.AsGuid) {
return ssIsBlocked;
}
if (attributeKey == IdIsFinalDelivery.Key.AsGuid) {
return ssIsFinalDelivery;
}
if (attributeKey == IdGLAccountId.Key.AsGuid) {
return ssGLAccountId;
}
if (attributeKey == IdCostCenterId.Key.AsGuid) {
return ssCostCenterId;
}
if (attributeKey == IdFundsCenter.Key.AsGuid) {
return ssFundsCenter;
}
if (attributeKey == IdFund.Key.AsGuid) {
return ssFund;
}
if (attributeKey == IdCommitmentItem.Key.AsGuid) {
return ssCommitmentItem;
}
if (attributeKey == IdVATIndicator.Key.AsGuid) {
return ssVATIndicator;
}
if (attributeKey == IdVATProcedure.Key.AsGuid) {
return ssVATProcedure;
}
if (attributeKey == IdVATRate.Key.AsGuid) {
return ssVATRate;
}
if (attributeKey == IdPurchaseRequisitionNumber.Key.AsGuid) {
return ssPurchaseRequisitionNumber;
}
if (attributeKey == IdPurchaseRequisitionItemNr.Key.AsGuid) {
return ssPurchaseRequisitionItemNr;
}
if (attributeKey == IdRegionId.Key.AsGuid) {
return ssRegionId;
}
if (attributeKey == IdCenter.Key.AsGuid) {
return ssCenter;
}
if (attributeKey == IdPEPElement.Key.AsGuid) {
return ssPEPElement;
}
if (attributeKey == IdQuantityDelivered.Key.AsGuid) {
return ssQuantityDelivered;
}
if (attributeKey == IdOrderUnitOfMeasure.Key.AsGuid) {
return ssOrderUnitOfMeasure;
}
if (attributeKey == IdApplicant.Key.AsGuid) {
return ssApplicant;
}
if (attributeKey == IdDirection.Key.AsGuid) {
return ssDirection;
}
if (attributeKey == IdContractNumber.Key.AsGuid) {
return ssContractNumber;
}
if (attributeKey == IdContractPosition.Key.AsGuid) {
return ssContractPosition;
}
if (attributeKey == IdContractStartDate.Key.AsGuid) {
return ssContractStartDate;
}
if (attributeKey == IdContractEndDate.Key.AsGuid) {
return ssContractEndDate;
}
if (attributeKey == IdContractPlannedValue.Key.AsGuid) {
return ssContractPlannedValue;
}
if (attributeKey == IdPositionType.Key.AsGuid) {
return ssPositionType;
}
if (attributeKey == IdSerialNumberProfile.Key.AsGuid) {
return ssSerialNumberProfile;
}
if (attributeKey == IdBatchManaged.Key.AsGuid) {
return ssBatchManaged;
}
if (attributeKey == IdMaterialType.Key.AsGuid) {
return ssMaterialType;
}
if (attributeKey == IdItemGroup.Key.AsGuid) {
return ssItemGroup;
}
if (attributeKey == IdOrderRequestCreatorSAPNumber.Key.AsGuid) {
return ssOrderRequestCreatorSAPNumber;
}
if (attributeKey == IdIsMultipleImputation.Key.AsGuid) {
return ssIsMultipleImputation;
}
if (attributeKey == IdInvoiceUsageId.Key.AsGuid) {
return ssInvoiceUsageId;
}
if (attributeKey == IdOrderMainItemStatusId.Key.AsGuid) {
return ssOrderMainItemStatusId;
}
if (attributeKey == IdDivisionId.Key.AsGuid) {
return ssDivisionId;
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
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(51);
OptimizedAttributes = new BitArray(51);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssOrderMainId = (long) other.AttributeGet(IdOrderMainId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdOrderMainId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdOrderMainId);
ssPosition = (int) other.AttributeGet(IdPosition);
ChangedAttributes[2] = other.ChangedAttributeGet(IdPosition);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdPosition);
ssMaterialCode = (string) other.AttributeGet(IdMaterialCode);
ChangedAttributes[3] = other.ChangedAttributeGet(IdMaterialCode);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdMaterialCode);
ssMaterialDescription = (string) other.AttributeGet(IdMaterialDescription);
ChangedAttributes[4] = other.ChangedAttributeGet(IdMaterialDescription);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdMaterialDescription);
ssAssigmnentCode = (string) other.AttributeGet(IdAssigmnentCode);
ChangedAttributes[5] = other.ChangedAttributeGet(IdAssigmnentCode);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdAssigmnentCode);
ssDocumentClassId = (long) other.AttributeGet(IdDocumentClassId);
ChangedAttributes[6] = other.ChangedAttributeGet(IdDocumentClassId);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdDocumentClassId);
ssDeliveryDate = (DateTime) other.AttributeGet(IdDeliveryDate);
ChangedAttributes[7] = other.ChangedAttributeGet(IdDeliveryDate);
OptimizedAttributes[7] = other.OptimizedAttributeGet(IdDeliveryDate);
ssQuantity = (decimal) other.AttributeGet(IdQuantity);
ChangedAttributes[8] = other.ChangedAttributeGet(IdQuantity);
OptimizedAttributes[8] = other.OptimizedAttributeGet(IdQuantity);
ssUnitType = (string) other.AttributeGet(IdUnitType);
ChangedAttributes[9] = other.ChangedAttributeGet(IdUnitType);
OptimizedAttributes[9] = other.OptimizedAttributeGet(IdUnitType);
ssUnitPrice = (decimal) other.AttributeGet(IdUnitPrice);
ChangedAttributes[10] = other.ChangedAttributeGet(IdUnitPrice);
OptimizedAttributes[10] = other.OptimizedAttributeGet(IdUnitPrice);
ssBaseQuantity = (int) other.AttributeGet(IdBaseQuantity);
ChangedAttributes[11] = other.ChangedAttributeGet(IdBaseQuantity);
OptimizedAttributes[11] = other.OptimizedAttributeGet(IdBaseQuantity);
ssIsDeleted = (bool) other.AttributeGet(IdIsDeleted);
ChangedAttributes[12] = other.ChangedAttributeGet(IdIsDeleted);
OptimizedAttributes[12] = other.OptimizedAttributeGet(IdIsDeleted);
ssIsBlocked = (bool) other.AttributeGet(IdIsBlocked);
ChangedAttributes[13] = other.ChangedAttributeGet(IdIsBlocked);
OptimizedAttributes[13] = other.OptimizedAttributeGet(IdIsBlocked);
ssIsFinalDelivery = (bool) other.AttributeGet(IdIsFinalDelivery);
ChangedAttributes[14] = other.ChangedAttributeGet(IdIsFinalDelivery);
OptimizedAttributes[14] = other.OptimizedAttributeGet(IdIsFinalDelivery);
ssGLAccountId = (long) other.AttributeGet(IdGLAccountId);
ChangedAttributes[15] = other.ChangedAttributeGet(IdGLAccountId);
OptimizedAttributes[15] = other.OptimizedAttributeGet(IdGLAccountId);
ssCostCenterId = (long) other.AttributeGet(IdCostCenterId);
ChangedAttributes[16] = other.ChangedAttributeGet(IdCostCenterId);
OptimizedAttributes[16] = other.OptimizedAttributeGet(IdCostCenterId);
ssFundsCenter = (string) other.AttributeGet(IdFundsCenter);
ChangedAttributes[17] = other.ChangedAttributeGet(IdFundsCenter);
OptimizedAttributes[17] = other.OptimizedAttributeGet(IdFundsCenter);
ssFund = (string) other.AttributeGet(IdFund);
ChangedAttributes[18] = other.ChangedAttributeGet(IdFund);
OptimizedAttributes[18] = other.OptimizedAttributeGet(IdFund);
ssCommitmentItem = (string) other.AttributeGet(IdCommitmentItem);
ChangedAttributes[19] = other.ChangedAttributeGet(IdCommitmentItem);
OptimizedAttributes[19] = other.OptimizedAttributeGet(IdCommitmentItem);
ssVATIndicator = (string) other.AttributeGet(IdVATIndicator);
ChangedAttributes[20] = other.ChangedAttributeGet(IdVATIndicator);
OptimizedAttributes[20] = other.OptimizedAttributeGet(IdVATIndicator);
ssVATProcedure = (string) other.AttributeGet(IdVATProcedure);
ChangedAttributes[21] = other.ChangedAttributeGet(IdVATProcedure);
OptimizedAttributes[21] = other.OptimizedAttributeGet(IdVATProcedure);
ssVATRate = (decimal) other.AttributeGet(IdVATRate);
ChangedAttributes[22] = other.ChangedAttributeGet(IdVATRate);
OptimizedAttributes[22] = other.OptimizedAttributeGet(IdVATRate);
ssPurchaseRequisitionNumber = (string) other.AttributeGet(IdPurchaseRequisitionNumber);
ChangedAttributes[23] = other.ChangedAttributeGet(IdPurchaseRequisitionNumber);
OptimizedAttributes[23] = other.OptimizedAttributeGet(IdPurchaseRequisitionNumber);
ssPurchaseRequisitionItemNr = (int) other.AttributeGet(IdPurchaseRequisitionItemNr);
ChangedAttributes[24] = other.ChangedAttributeGet(IdPurchaseRequisitionItemNr);
OptimizedAttributes[24] = other.OptimizedAttributeGet(IdPurchaseRequisitionItemNr);
ssRegionId = (long) other.AttributeGet(IdRegionId);
ChangedAttributes[25] = other.ChangedAttributeGet(IdRegionId);
OptimizedAttributes[25] = other.OptimizedAttributeGet(IdRegionId);
ssCenter = (string) other.AttributeGet(IdCenter);
ChangedAttributes[26] = other.ChangedAttributeGet(IdCenter);
OptimizedAttributes[26] = other.OptimizedAttributeGet(IdCenter);
ssPEPElement = (string) other.AttributeGet(IdPEPElement);
ChangedAttributes[27] = other.ChangedAttributeGet(IdPEPElement);
OptimizedAttributes[27] = other.OptimizedAttributeGet(IdPEPElement);
ssQuantityDelivered = (decimal) other.AttributeGet(IdQuantityDelivered);
ChangedAttributes[28] = other.ChangedAttributeGet(IdQuantityDelivered);
OptimizedAttributes[28] = other.OptimizedAttributeGet(IdQuantityDelivered);
ssOrderUnitOfMeasure = (string) other.AttributeGet(IdOrderUnitOfMeasure);
ChangedAttributes[29] = other.ChangedAttributeGet(IdOrderUnitOfMeasure);
OptimizedAttributes[29] = other.OptimizedAttributeGet(IdOrderUnitOfMeasure);
ssApplicant = (string) other.AttributeGet(IdApplicant);
ChangedAttributes[30] = other.ChangedAttributeGet(IdApplicant);
OptimizedAttributes[30] = other.OptimizedAttributeGet(IdApplicant);
ssDirection = (string) other.AttributeGet(IdDirection);
ChangedAttributes[31] = other.ChangedAttributeGet(IdDirection);
OptimizedAttributes[31] = other.OptimizedAttributeGet(IdDirection);
ssContractNumber = (string) other.AttributeGet(IdContractNumber);
ChangedAttributes[32] = other.ChangedAttributeGet(IdContractNumber);
OptimizedAttributes[32] = other.OptimizedAttributeGet(IdContractNumber);
ssContractPosition = (int) other.AttributeGet(IdContractPosition);
ChangedAttributes[33] = other.ChangedAttributeGet(IdContractPosition);
OptimizedAttributes[33] = other.OptimizedAttributeGet(IdContractPosition);
ssContractStartDate = (DateTime) other.AttributeGet(IdContractStartDate);
ChangedAttributes[34] = other.ChangedAttributeGet(IdContractStartDate);
OptimizedAttributes[34] = other.OptimizedAttributeGet(IdContractStartDate);
ssContractEndDate = (DateTime) other.AttributeGet(IdContractEndDate);
ChangedAttributes[35] = other.ChangedAttributeGet(IdContractEndDate);
OptimizedAttributes[35] = other.OptimizedAttributeGet(IdContractEndDate);
ssContractPlannedValue = (decimal) other.AttributeGet(IdContractPlannedValue);
ChangedAttributes[36] = other.ChangedAttributeGet(IdContractPlannedValue);
OptimizedAttributes[36] = other.OptimizedAttributeGet(IdContractPlannedValue);
ssPositionType = (string) other.AttributeGet(IdPositionType);
ChangedAttributes[37] = other.ChangedAttributeGet(IdPositionType);
OptimizedAttributes[37] = other.OptimizedAttributeGet(IdPositionType);
ssSerialNumberProfile = (string) other.AttributeGet(IdSerialNumberProfile);
ChangedAttributes[38] = other.ChangedAttributeGet(IdSerialNumberProfile);
OptimizedAttributes[38] = other.OptimizedAttributeGet(IdSerialNumberProfile);
ssBatchManaged = (string) other.AttributeGet(IdBatchManaged);
ChangedAttributes[39] = other.ChangedAttributeGet(IdBatchManaged);
OptimizedAttributes[39] = other.OptimizedAttributeGet(IdBatchManaged);
ssMaterialType = (string) other.AttributeGet(IdMaterialType);
ChangedAttributes[40] = other.ChangedAttributeGet(IdMaterialType);
OptimizedAttributes[40] = other.OptimizedAttributeGet(IdMaterialType);
ssItemGroup = (string) other.AttributeGet(IdItemGroup);
ChangedAttributes[41] = other.ChangedAttributeGet(IdItemGroup);
OptimizedAttributes[41] = other.OptimizedAttributeGet(IdItemGroup);
ssOrderRequestCreatorSAPNumber = (string) other.AttributeGet(IdOrderRequestCreatorSAPNumber);
ChangedAttributes[42] = other.ChangedAttributeGet(IdOrderRequestCreatorSAPNumber);
OptimizedAttributes[42] = other.OptimizedAttributeGet(IdOrderRequestCreatorSAPNumber);
ssIsMultipleImputation = (bool) other.AttributeGet(IdIsMultipleImputation);
ChangedAttributes[43] = other.ChangedAttributeGet(IdIsMultipleImputation);
OptimizedAttributes[43] = other.OptimizedAttributeGet(IdIsMultipleImputation);
ssInvoiceUsageId = (long) other.AttributeGet(IdInvoiceUsageId);
ChangedAttributes[44] = other.ChangedAttributeGet(IdInvoiceUsageId);
OptimizedAttributes[44] = other.OptimizedAttributeGet(IdInvoiceUsageId);
ssOrderMainItemStatusId = (int) other.AttributeGet(IdOrderMainItemStatusId);
ChangedAttributes[45] = other.ChangedAttributeGet(IdOrderMainItemStatusId);
OptimizedAttributes[45] = other.OptimizedAttributeGet(IdOrderMainItemStatusId);
ssDivisionId = (long) other.AttributeGet(IdDivisionId);
ChangedAttributes[46] = other.ChangedAttributeGet(IdDivisionId);
OptimizedAttributes[46] = other.OptimizedAttributeGet(IdDivisionId);
ssCreatedBy = (string) other.AttributeGet(IdCreatedBy);
ChangedAttributes[47] = other.ChangedAttributeGet(IdCreatedBy);
OptimizedAttributes[47] = other.OptimizedAttributeGet(IdCreatedBy);
ssCreatedOn = (DateTime) other.AttributeGet(IdCreatedOn);
ChangedAttributes[48] = other.ChangedAttributeGet(IdCreatedOn);
OptimizedAttributes[48] = other.OptimizedAttributeGet(IdCreatedOn);
ssUpdatedBy = (string) other.AttributeGet(IdUpdatedBy);
ChangedAttributes[49] = other.ChangedAttributeGet(IdUpdatedBy);
OptimizedAttributes[49] = other.OptimizedAttributeGet(IdUpdatedBy);
ssUpdatedOn = (DateTime) other.AttributeGet(IdUpdatedOn);
ChangedAttributes[50] = other.ChangedAttributeGet(IdUpdatedOn);
OptimizedAttributes[50] = other.OptimizedAttributeGet(IdUpdatedOn);
}
} // EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord

/// <summary>
/// RecordList type <code>OrderMainItemList</code> that represents a record list of
///  <code>OrderMainItem</code>
/// </summary>
public partial class RL_36053b0a011ac5d2d2fe088489de85e6 : GenericRecordList<EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord>, IEnumerable, IEnumerator {

protected override EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord GetElementDefaultValue() {
return new EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord();
}

public T[] ToArray<T>(Func<EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_36053b0a011ac5d2d2fe088489de85e6 recordList, Func<EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_36053b0a011ac5d2d2fe088489de85e6(EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord[] array) {
  RL_36053b0a011ac5d2d2fe088489de85e6 result = new RL_36053b0a011ac5d2d2fe088489de85e6();
result.InnerFromArray(array);
    return result;
}

public static RL_36053b0a011ac5d2d2fe088489de85e6 ToList<T>(T[] array, Func <T, EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord> converter) {
  RL_36053b0a011ac5d2d2fe088489de85e6 result = new RL_36053b0a011ac5d2d2fe088489de85e6();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_36053b0a011ac5d2d2fe088489de85e6 FromRestList<T>(RestList<T> restList, Func <T, EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord> converter) {
  RL_36053b0a011ac5d2d2fe088489de85e6 result = new RL_36053b0a011ac5d2d2fe088489de85e6();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_36053b0a011ac5d2d2fe088489de85e6() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord> NewList() {
return new RL_36053b0a011ac5d2d2fe088489de85e6();
}


} // RL_36053b0a011ac5d2d2fe088489de85e6
}
