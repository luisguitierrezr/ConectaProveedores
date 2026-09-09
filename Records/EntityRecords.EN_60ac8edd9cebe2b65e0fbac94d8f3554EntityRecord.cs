using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] OrderMain (fQ2djpcjJke8CXyEh7ixVw)
///  <code>EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord</code> that represents <code>OrderMain</code
/// > <p>Description: OrderMain</p>
/// </summary>
// Name: OrderMain
public partial struct EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord : ITypedRecord<EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*E7rnHThy90KSgfUGDxQcdg");
internal static readonly GlobalObjectKey IdOrderNumber = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*n7lrpBEDU0W8vUmG0CQMeg");
internal static readonly GlobalObjectKey IdOrderDate = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*T0IQtNbRXUGVhUsCvKs2Vw");
internal static readonly GlobalObjectKey IdOrderStatusId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*EFW1p45+VkC9hQyYHbmZqg");
internal static readonly GlobalObjectKey IdPreviousOrderStatusId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Q4HL7YUMSUSPaQBQD5tdLQ");
internal static readonly GlobalObjectKey IdAssignmentCode = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*PS_3EKFv3kCw9AIAkL2E3w");
internal static readonly GlobalObjectKey IdSupplierId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*J7NEM_LM4kaAjQzmJvNBPw");
internal static readonly GlobalObjectKey IdCompanyId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*XZ4jIN7Ow0K96PYAkiEesA");
internal static readonly GlobalObjectKey IdDocumentTypeId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*eoM9C5paQkyxRYCOdaDgWg");
internal static readonly GlobalObjectKey IdCurrencyId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*DpM+evjtXEiifjjl11PZrg");
internal static readonly GlobalObjectKey IdTelcelDirectionId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*XzkyPFHxDEWtiPlTMuxlKA");
internal static readonly GlobalObjectKey IdProcurementGroup = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*KWT6PMIWaUi4KaUeGFpPsg");
internal static readonly GlobalObjectKey IdCreatorSAPNumber = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*yZ0S0umN9Ea4nEqKNsXqOA");
internal static readonly GlobalObjectKey IdCreatorSAPName = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*owRtb92c2kyc05my39_HTQ");
internal static readonly GlobalObjectKey IdCountry = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*0Uxv9pplJ0K1c+hZPN95KQ");
internal static readonly GlobalObjectKey IdIsDeleted = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*hQPwKIhP4UaC24mnY5QRIw");
internal static readonly GlobalObjectKey IdIsReleased = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*lRGPkf+cSUu_6NjCi8GZUQ");
internal static readonly GlobalObjectKey IdExchangeRate = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*7ApVzthzdkiNLBjOKmeBxQ");
internal static readonly GlobalObjectKey IdSustainabilityCategory = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*4OeZitlzwkiVhUQuEY8H7w");
internal static readonly GlobalObjectKey IdSustainabilitySubcategory = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*mqOJpRkQi0a+SkJq_T29Ww");
internal static readonly GlobalObjectKey IdTotalAmount = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*M0n+XFfGqU+EgnRYtE99Ug");
internal static readonly GlobalObjectKey IdFromCosmoz = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*ws8ACKH3vky2oVD91DQ9Ww");
internal static readonly GlobalObjectKey IdRegionId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*LYeGmqkKhEaIhl3s8dL3+g");
internal static readonly GlobalObjectKey IdDivisionId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*5kDlkCwpjEC7Ms7FCpBoIA");
internal static readonly GlobalObjectKey IdApplicant = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*umii8acq3kiOjm6hIjRXxQ");
internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*TO1PLDSWT0i3mK842bUctA");
internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*jKGH6CYi+Ey6xRePaNqufg");
internal static readonly GlobalObjectKey IdUpdatedBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*_sq4BaFDMU+zggK+CcmFnQ");
internal static readonly GlobalObjectKey IdUpdatedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*dYxclFVIfkegmdUiwR64Sw");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(29,true);
          _ssId = value;
      }
  }
}

private string _ssOrderNumber;
public string ssOrderNumber{
  get{
      return _ssOrderNumber;
  }
  set{
      if((_ssOrderNumber!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssOrderNumber = value;
      }
  }
}

private DateTime _ssOrderDate;
public DateTime ssOrderDate{
  get{
      return _ssOrderDate;
  }
  set{
      if((_ssOrderDate!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssOrderDate = value;
      }
  }
}

private int _ssOrderStatusId;
public int ssOrderStatusId{
  get{
      return _ssOrderStatusId;
  }
  set{
      if((_ssOrderStatusId!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssOrderStatusId = value;
      }
  }
}

private int _ssPreviousOrderStatusId;
public int ssPreviousOrderStatusId{
  get{
      return _ssPreviousOrderStatusId;
  }
  set{
      if((_ssPreviousOrderStatusId!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssPreviousOrderStatusId = value;
      }
  }
}

private string _ssAssignmentCode;
public string ssAssignmentCode{
  get{
      return _ssAssignmentCode;
  }
  set{
      if((_ssAssignmentCode!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssAssignmentCode = value;
      }
  }
}

private long _ssSupplierId;
public long ssSupplierId{
  get{
      return _ssSupplierId;
  }
  set{
      if((_ssSupplierId!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssSupplierId = value;
      }
  }
}

private long _ssCompanyId;
public long ssCompanyId{
  get{
      return _ssCompanyId;
  }
  set{
      if((_ssCompanyId!=value) || OptimizedAttributes[7]){
          ChangedAttributes[7] = true;
          _ssCompanyId = value;
      }
  }
}

private long _ssDocumentTypeId;
public long ssDocumentTypeId{
  get{
      return _ssDocumentTypeId;
  }
  set{
      if((_ssDocumentTypeId!=value) || OptimizedAttributes[8]){
          ChangedAttributes[8] = true;
          _ssDocumentTypeId = value;
      }
  }
}

private string _ssCurrencyId;
public string ssCurrencyId{
  get{
      return _ssCurrencyId;
  }
  set{
      if((_ssCurrencyId!=value) || OptimizedAttributes[9]){
          ChangedAttributes[9] = true;
          _ssCurrencyId = value;
      }
  }
}

private long _ssTelcelDirectionId;
public long ssTelcelDirectionId{
  get{
      return _ssTelcelDirectionId;
  }
  set{
      if((_ssTelcelDirectionId!=value) || OptimizedAttributes[10]){
          ChangedAttributes[10] = true;
          _ssTelcelDirectionId = value;
      }
  }
}

private string _ssProcurementGroup;
public string ssProcurementGroup{
  get{
      return _ssProcurementGroup;
  }
  set{
      if((_ssProcurementGroup!=value) || OptimizedAttributes[11]){
          ChangedAttributes[11] = true;
          _ssProcurementGroup = value;
      }
  }
}

private string _ssCreatorSAPNumber;
public string ssCreatorSAPNumber{
  get{
      return _ssCreatorSAPNumber;
  }
  set{
      if((_ssCreatorSAPNumber!=value) || OptimizedAttributes[12]){
          ChangedAttributes[12] = true;
          _ssCreatorSAPNumber = value;
      }
  }
}

private string _ssCreatorSAPName;
public string ssCreatorSAPName{
  get{
      return _ssCreatorSAPName;
  }
  set{
      if((_ssCreatorSAPName!=value) || OptimizedAttributes[13]){
          ChangedAttributes[13] = true;
          _ssCreatorSAPName = value;
      }
  }
}

private string _ssCountry;
public string ssCountry{
  get{
      return _ssCountry;
  }
  set{
      if((_ssCountry!=value) || OptimizedAttributes[14]){
          ChangedAttributes[14] = true;
          _ssCountry = value;
      }
  }
}

private bool _ssIsDeleted;
public bool ssIsDeleted{
  get{
      return _ssIsDeleted;
  }
  set{
      if((_ssIsDeleted!=value) || OptimizedAttributes[15]){
          ChangedAttributes[15] = true;
          _ssIsDeleted = value;
      }
  }
}

private bool _ssIsReleased;
public bool ssIsReleased{
  get{
      return _ssIsReleased;
  }
  set{
      if((_ssIsReleased!=value) || OptimizedAttributes[16]){
          ChangedAttributes[16] = true;
          _ssIsReleased = value;
      }
  }
}

private decimal _ssExchangeRate;
public decimal ssExchangeRate{
  get{
      return _ssExchangeRate;
  }
  set{
      if((_ssExchangeRate!=value) || OptimizedAttributes[17]){
          ChangedAttributes[17] = true;
          _ssExchangeRate = value;
      }
  }
}

private string _ssSustainabilityCategory;
public string ssSustainabilityCategory{
  get{
      return _ssSustainabilityCategory;
  }
  set{
      if((_ssSustainabilityCategory!=value) || OptimizedAttributes[18]){
          ChangedAttributes[18] = true;
          _ssSustainabilityCategory = value;
      }
  }
}

private string _ssSustainabilitySubcategory;
public string ssSustainabilitySubcategory{
  get{
      return _ssSustainabilitySubcategory;
  }
  set{
      if((_ssSustainabilitySubcategory!=value) || OptimizedAttributes[19]){
          ChangedAttributes[19] = true;
          _ssSustainabilitySubcategory = value;
      }
  }
}

private decimal _ssTotalAmount;
public decimal ssTotalAmount{
  get{
      return _ssTotalAmount;
  }
  set{
      if((_ssTotalAmount!=value) || OptimizedAttributes[20]){
          ChangedAttributes[20] = true;
          _ssTotalAmount = value;
      }
  }
}

private bool _ssFromCosmoz;
public bool ssFromCosmoz{
  get{
      return _ssFromCosmoz;
  }
  set{
      if((_ssFromCosmoz!=value) || OptimizedAttributes[21]){
          ChangedAttributes[21] = true;
          _ssFromCosmoz = value;
      }
  }
}

private long _ssRegionId;
public long ssRegionId{
  get{
      return _ssRegionId;
  }
  set{
      if((_ssRegionId!=value) || OptimizedAttributes[22]){
          ChangedAttributes[22] = true;
          _ssRegionId = value;
      }
  }
}

private long _ssDivisionId;
public long ssDivisionId{
  get{
      return _ssDivisionId;
  }
  set{
      if((_ssDivisionId!=value) || OptimizedAttributes[23]){
          ChangedAttributes[23] = true;
          _ssDivisionId = value;
      }
  }
}

private string _ssApplicant;
public string ssApplicant{
  get{
      return _ssApplicant;
  }
  set{
      if((_ssApplicant!=value) || OptimizedAttributes[24]){
          ChangedAttributes[24] = true;
          _ssApplicant = value;
      }
  }
}

private string _ssCreatedBy;
public string ssCreatedBy{
  get{
      return _ssCreatedBy;
  }
  set{
      if((_ssCreatedBy!=value) || OptimizedAttributes[25]){
          ChangedAttributes[25] = true;
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
      if((_ssCreatedOn!=value) || OptimizedAttributes[26]){
          ChangedAttributes[26] = true;
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
      if((_ssUpdatedBy!=value) || OptimizedAttributes[27]){
          ChangedAttributes[27] = true;
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
      if((_ssUpdatedOn!=value) || OptimizedAttributes[28]){
          ChangedAttributes[28] = true;
          _ssUpdatedOn = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord() {
ChangedAttributes = new BitArray(29,true);
OptimizedAttributes = new BitArray(29,false);
_ssId = 0L;
_ssOrderNumber = "";
_ssOrderDate = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssOrderStatusId = 0;
_ssPreviousOrderStatusId = 0;
_ssAssignmentCode = "";
_ssSupplierId = 0L;
_ssCompanyId = 0L;
_ssDocumentTypeId = 0L;
_ssCurrencyId = "";
_ssTelcelDirectionId = 0L;
_ssProcurementGroup = "";
_ssCreatorSAPNumber = "";
_ssCreatorSAPName = "";
_ssCountry = "";
_ssIsDeleted = false;
_ssIsReleased = false;
_ssExchangeRate = 0.0M;
_ssSustainabilityCategory = "";
_ssSustainabilitySubcategory = "";
_ssTotalAmount = 0.0M;
_ssFromCosmoz = false;
_ssRegionId = 0L;
_ssDivisionId = 0L;
_ssApplicant = "";
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
ssId = r.ReadLongInteger(index++, "OrderMain.Id", 0L);
ssOrderNumber = r.ReadText(index++, "OrderMain.OrderNumber", "");
ssOrderDate = r.ReadDate(index++, "OrderMain.OrderDate", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssOrderStatusId = r.ReadEntityReference(index++, "OrderMain.OrderStatusId", 0);
ssPreviousOrderStatusId = r.ReadEntityReference(index++, "OrderMain.PreviousOrderStatusId", 0);
ssAssignmentCode = r.ReadText(index++, "OrderMain.AssignmentCode", "");
ssSupplierId = r.ReadEntityReferenceLongInteger(index++, "OrderMain.SupplierId", 0L);
ssCompanyId = r.ReadEntityReferenceLongInteger(index++, "OrderMain.CompanyId", 0L);
ssDocumentTypeId = r.ReadEntityReferenceLongInteger(index++, "OrderMain.DocumentTypeId", 0L);
ssCurrencyId = r.ReadEntityReferenceText(index++, "OrderMain.CurrencyId", "");
ssTelcelDirectionId = r.ReadEntityReferenceLongInteger(index++, "OrderMain.TelcelDirectionId", 0L);
ssProcurementGroup = r.ReadText(index++, "OrderMain.ProcurementGroup", "");
ssCreatorSAPNumber = r.ReadText(index++, "OrderMain.CreatorSAPNumber", "");
ssCreatorSAPName = r.ReadText(index++, "OrderMain.CreatorSAPName", "");
ssCountry = r.ReadText(index++, "OrderMain.Country", "");
ssIsDeleted = r.ReadBoolean(index++, "OrderMain.IsDeleted", false);
ssIsReleased = r.ReadBoolean(index++, "OrderMain.IsReleased", false);
ssExchangeRate = r.ReadDecimal(index++, "OrderMain.ExchangeRate", 0.0M);
ssSustainabilityCategory = r.ReadText(index++, "OrderMain.SustainabilityCategory", "");
ssSustainabilitySubcategory = r.ReadText(index++, "OrderMain.SustainabilitySubcategory", "");
ssTotalAmount = r.ReadCurrency(index++, "OrderMain.TotalAmount", 0.0M);
ssFromCosmoz = r.ReadBoolean(index++, "OrderMain.FromCosmoz", false);
ssRegionId = r.ReadEntityReferenceLongInteger(index++, "OrderMain.RegionId", 0L);
ssDivisionId = r.ReadEntityReferenceLongInteger(index++, "OrderMain.DivisionId", 0L);
ssApplicant = r.ReadText(index++, "OrderMain.Applicant", "");
ssCreatedBy = r.ReadEntityReferenceText(index++, "OrderMain.CreatedBy", "");
ssCreatedOn = r.ReadDateTime(index++, "OrderMain.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssUpdatedBy = r.ReadEntityReferenceText(index++, "OrderMain.UpdatedBy", "");
ssUpdatedOn = r.ReadDateTime(index++, "OrderMain.UpdatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ChangedAttributes = new BitArray(29,false);
OptimizedAttributes = new BitArray(29,false);
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
public void ReadIM(EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord r) {
this = r;
}


public static bool operator == (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord a, EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssOrderNumber != b.ssOrderNumber) return false;
if (a.ssOrderDate != b.ssOrderDate) return false;
if (a.ssOrderStatusId != b.ssOrderStatusId) return false;
if (a.ssPreviousOrderStatusId != b.ssPreviousOrderStatusId) return false;
if (a.ssAssignmentCode != b.ssAssignmentCode) return false;
if (a.ssSupplierId != b.ssSupplierId) return false;
if (a.ssCompanyId != b.ssCompanyId) return false;
if (a.ssDocumentTypeId != b.ssDocumentTypeId) return false;
if (a.ssCurrencyId != b.ssCurrencyId) return false;
if (a.ssTelcelDirectionId != b.ssTelcelDirectionId) return false;
if (a.ssProcurementGroup != b.ssProcurementGroup) return false;
if (a.ssCreatorSAPNumber != b.ssCreatorSAPNumber) return false;
if (a.ssCreatorSAPName != b.ssCreatorSAPName) return false;
if (a.ssCountry != b.ssCountry) return false;
if (a.ssIsDeleted != b.ssIsDeleted) return false;
if (a.ssIsReleased != b.ssIsReleased) return false;
if (a.ssExchangeRate != b.ssExchangeRate) return false;
if (a.ssSustainabilityCategory != b.ssSustainabilityCategory) return false;
if (a.ssSustainabilitySubcategory != b.ssSustainabilitySubcategory) return false;
if (a.ssTotalAmount != b.ssTotalAmount) return false;
if (a.ssFromCosmoz != b.ssFromCosmoz) return false;
if (a.ssRegionId != b.ssRegionId) return false;
if (a.ssDivisionId != b.ssDivisionId) return false;
if (a.ssApplicant != b.ssApplicant) return false;
if (a.ssCreatedBy != b.ssCreatedBy) return false;
if (a.ssCreatedOn != b.ssCreatedOn) return false;
if (a.ssUpdatedBy != b.ssUpdatedBy) return false;
if (a.ssUpdatedOn != b.ssUpdatedOn) return false;
return true;
}

public static bool operator != (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord a, EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord)) return false;
return (this == (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssOrderNumber.GetHashCode()
 ^ ssOrderDate.GetHashCode()
 ^ ssOrderStatusId.GetHashCode()
 ^ ssPreviousOrderStatusId.GetHashCode()
 ^ ssAssignmentCode.GetHashCode()
 ^ ssSupplierId.GetHashCode()
 ^ ssCompanyId.GetHashCode()
 ^ ssDocumentTypeId.GetHashCode()
 ^ ssCurrencyId.GetHashCode()
 ^ ssTelcelDirectionId.GetHashCode()
 ^ ssProcurementGroup.GetHashCode()
 ^ ssCreatorSAPNumber.GetHashCode()
 ^ ssCreatorSAPName.GetHashCode()
 ^ ssCountry.GetHashCode()
 ^ ssIsDeleted.GetHashCode()
 ^ ssIsReleased.GetHashCode()
 ^ ssExchangeRate.GetHashCode()
 ^ ssSustainabilityCategory.GetHashCode()
 ^ ssSustainabilitySubcategory.GetHashCode()
 ^ ssTotalAmount.GetHashCode()
 ^ ssFromCosmoz.GetHashCode()
 ^ ssRegionId.GetHashCode()
 ^ ssDivisionId.GetHashCode()
 ^ ssApplicant.GetHashCode()
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


public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord Duplicate() {
EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord t;
t._ssId = this._ssId;
t._ssOrderNumber = this._ssOrderNumber;
t._ssOrderDate = this._ssOrderDate;
t._ssOrderStatusId = this._ssOrderStatusId;
t._ssPreviousOrderStatusId = this._ssPreviousOrderStatusId;
t._ssAssignmentCode = this._ssAssignmentCode;
t._ssSupplierId = this._ssSupplierId;
t._ssCompanyId = this._ssCompanyId;
t._ssDocumentTypeId = this._ssDocumentTypeId;
t._ssCurrencyId = this._ssCurrencyId;
t._ssTelcelDirectionId = this._ssTelcelDirectionId;
t._ssProcurementGroup = this._ssProcurementGroup;
t._ssCreatorSAPNumber = this._ssCreatorSAPNumber;
t._ssCreatorSAPName = this._ssCreatorSAPName;
t._ssCountry = this._ssCountry;
t._ssIsDeleted = this._ssIsDeleted;
t._ssIsReleased = this._ssIsReleased;
t._ssExchangeRate = this._ssExchangeRate;
t._ssSustainabilityCategory = this._ssSustainabilityCategory;
t._ssSustainabilitySubcategory = this._ssSustainabilitySubcategory;
t._ssTotalAmount = this._ssTotalAmount;
t._ssFromCosmoz = this._ssFromCosmoz;
t._ssRegionId = this._ssRegionId;
t._ssDivisionId = this._ssDivisionId;
t._ssApplicant = this._ssApplicant;
t._ssCreatedBy = this._ssCreatedBy;
t._ssCreatedOn = this._ssCreatedOn;
t._ssUpdatedBy = this._ssUpdatedBy;
t._ssUpdatedOn = this._ssUpdatedOn;
t.ChangedAttributes = new BitArray(29);
t.OptimizedAttributes = new BitArray(29);
for(int i = 0; i < 29; i++){
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
} else if (head == "ordernumber") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderNumber")) variable.Value = ssOrderNumber; else variable.Optimized = true;
} else if (head == "orderdate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderDate")) variable.Value = ssOrderDate; else variable.Optimized = true;
} else if (head == "orderstatusid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderStatusId")) variable.Value = ssOrderStatusId; else variable.Optimized = true;
} else if (head == "previousorderstatusid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PreviousOrderStatusId")) variable.Value = ssPreviousOrderStatusId; else variable.Optimized = true;
} else if (head == "assignmentcode") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AssignmentCode")) variable.Value = ssAssignmentCode; else variable.Optimized = true;
} else if (head == "supplierid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SupplierId")) variable.Value = ssSupplierId; else variable.Optimized = true;
} else if (head == "companyid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CompanyId")) variable.Value = ssCompanyId; else variable.Optimized = true;
} else if (head == "documenttypeid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DocumentTypeId")) variable.Value = ssDocumentTypeId; else variable.Optimized = true;
} else if (head == "currencyid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CurrencyId")) variable.Value = ssCurrencyId; else variable.Optimized = true;
} else if (head == "telceldirectionid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TelcelDirectionId")) variable.Value = ssTelcelDirectionId; else variable.Optimized = true;
} else if (head == "procurementgroup") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProcurementGroup")) variable.Value = ssProcurementGroup; else variable.Optimized = true;
} else if (head == "creatorsapnumber") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatorSAPNumber")) variable.Value = ssCreatorSAPNumber; else variable.Optimized = true;
} else if (head == "creatorsapname") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatorSAPName")) variable.Value = ssCreatorSAPName; else variable.Optimized = true;
} else if (head == "country") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Country")) variable.Value = ssCountry; else variable.Optimized = true;
} else if (head == "isdeleted") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsDeleted")) variable.Value = ssIsDeleted; else variable.Optimized = true;
} else if (head == "isreleased") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsReleased")) variable.Value = ssIsReleased; else variable.Optimized = true;
} else if (head == "exchangerate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ExchangeRate")) variable.Value = ssExchangeRate; else variable.Optimized = true;
} else if (head == "sustainabilitycategory") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SustainabilityCategory")) variable.Value = ssSustainabilityCategory; else variable.Optimized = true;
} else if (head == "sustainabilitysubcategory") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SustainabilitySubcategory")) variable.Value = ssSustainabilitySubcategory; else variable.Optimized = true;
} else if (head == "totalamount") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TotalAmount")) variable.Value = ssTotalAmount; else variable.Optimized = true;
} else if (head == "fromcosmoz") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FromCosmoz")) variable.Value = ssFromCosmoz; else variable.Optimized = true;
} else if (head == "regionid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RegionId")) variable.Value = ssRegionId; else variable.Optimized = true;
} else if (head == "divisionid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DivisionId")) variable.Value = ssDivisionId; else variable.Optimized = true;
} else if (head == "applicant") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Applicant")) variable.Value = ssApplicant; else variable.Optimized = true;
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
if (key.Equals(IdOrderNumber)) {
return ChangedAttributes[1];
}
if (key.Equals(IdOrderDate)) {
return ChangedAttributes[2];
}
if (key.Equals(IdOrderStatusId)) {
return ChangedAttributes[3];
}
if (key.Equals(IdPreviousOrderStatusId)) {
return ChangedAttributes[4];
}
if (key.Equals(IdAssignmentCode)) {
return ChangedAttributes[5];
}
if (key.Equals(IdSupplierId)) {
return ChangedAttributes[6];
}
if (key.Equals(IdCompanyId)) {
return ChangedAttributes[7];
}
if (key.Equals(IdDocumentTypeId)) {
return ChangedAttributes[8];
}
if (key.Equals(IdCurrencyId)) {
return ChangedAttributes[9];
}
if (key.Equals(IdTelcelDirectionId)) {
return ChangedAttributes[10];
}
if (key.Equals(IdProcurementGroup)) {
return ChangedAttributes[11];
}
if (key.Equals(IdCreatorSAPNumber)) {
return ChangedAttributes[12];
}
if (key.Equals(IdCreatorSAPName)) {
return ChangedAttributes[13];
}
if (key.Equals(IdCountry)) {
return ChangedAttributes[14];
}
if (key.Equals(IdIsDeleted)) {
return ChangedAttributes[15];
}
if (key.Equals(IdIsReleased)) {
return ChangedAttributes[16];
}
if (key.Equals(IdExchangeRate)) {
return ChangedAttributes[17];
}
if (key.Equals(IdSustainabilityCategory)) {
return ChangedAttributes[18];
}
if (key.Equals(IdSustainabilitySubcategory)) {
return ChangedAttributes[19];
}
if (key.Equals(IdTotalAmount)) {
return ChangedAttributes[20];
}
if (key.Equals(IdFromCosmoz)) {
return ChangedAttributes[21];
}
if (key.Equals(IdRegionId)) {
return ChangedAttributes[22];
}
if (key.Equals(IdDivisionId)) {
return ChangedAttributes[23];
}
if (key.Equals(IdApplicant)) {
return ChangedAttributes[24];
}
if (key.Equals(IdCreatedBy)) {
return ChangedAttributes[25];
}
if (key.Equals(IdCreatedOn)) {
return ChangedAttributes[26];
}
if (key.Equals(IdUpdatedBy)) {
return ChangedAttributes[27];
}
if (key.Equals(IdUpdatedOn)) {
return ChangedAttributes[28];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdOrderNumber)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdOrderDate)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdOrderStatusId)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdPreviousOrderStatusId)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdAssignmentCode)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdSupplierId)) {
return OptimizedAttributes[6];
}
if (key.Equals(IdCompanyId)) {
return OptimizedAttributes[7];
}
if (key.Equals(IdDocumentTypeId)) {
return OptimizedAttributes[8];
}
if (key.Equals(IdCurrencyId)) {
return OptimizedAttributes[9];
}
if (key.Equals(IdTelcelDirectionId)) {
return OptimizedAttributes[10];
}
if (key.Equals(IdProcurementGroup)) {
return OptimizedAttributes[11];
}
if (key.Equals(IdCreatorSAPNumber)) {
return OptimizedAttributes[12];
}
if (key.Equals(IdCreatorSAPName)) {
return OptimizedAttributes[13];
}
if (key.Equals(IdCountry)) {
return OptimizedAttributes[14];
}
if (key.Equals(IdIsDeleted)) {
return OptimizedAttributes[15];
}
if (key.Equals(IdIsReleased)) {
return OptimizedAttributes[16];
}
if (key.Equals(IdExchangeRate)) {
return OptimizedAttributes[17];
}
if (key.Equals(IdSustainabilityCategory)) {
return OptimizedAttributes[18];
}
if (key.Equals(IdSustainabilitySubcategory)) {
return OptimizedAttributes[19];
}
if (key.Equals(IdTotalAmount)) {
return OptimizedAttributes[20];
}
if (key.Equals(IdFromCosmoz)) {
return OptimizedAttributes[21];
}
if (key.Equals(IdRegionId)) {
return OptimizedAttributes[22];
}
if (key.Equals(IdDivisionId)) {
return OptimizedAttributes[23];
}
if (key.Equals(IdApplicant)) {
return OptimizedAttributes[24];
}
if (key.Equals(IdCreatedBy)) {
return OptimizedAttributes[25];
}
if (key.Equals(IdCreatedOn)) {
return OptimizedAttributes[26];
}
if (key.Equals(IdUpdatedBy)) {
return OptimizedAttributes[27];
}
if (key.Equals(IdUpdatedOn)) {
return OptimizedAttributes[28];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdOrderNumber) {
return ssOrderNumber;
}
if (key == IdOrderDate) {
return ssOrderDate;
}
if (key == IdOrderStatusId) {
return ssOrderStatusId;
}
if (key == IdPreviousOrderStatusId) {
return ssPreviousOrderStatusId;
}
if (key == IdAssignmentCode) {
return ssAssignmentCode;
}
if (key == IdSupplierId) {
return ssSupplierId;
}
if (key == IdCompanyId) {
return ssCompanyId;
}
if (key == IdDocumentTypeId) {
return ssDocumentTypeId;
}
if (key == IdCurrencyId) {
return ssCurrencyId;
}
if (key == IdTelcelDirectionId) {
return ssTelcelDirectionId;
}
if (key == IdProcurementGroup) {
return ssProcurementGroup;
}
if (key == IdCreatorSAPNumber) {
return ssCreatorSAPNumber;
}
if (key == IdCreatorSAPName) {
return ssCreatorSAPName;
}
if (key == IdCountry) {
return ssCountry;
}
if (key == IdIsDeleted) {
return ssIsDeleted;
}
if (key == IdIsReleased) {
return ssIsReleased;
}
if (key == IdExchangeRate) {
return ssExchangeRate;
}
if (key == IdSustainabilityCategory) {
return ssSustainabilityCategory;
}
if (key == IdSustainabilitySubcategory) {
return ssSustainabilitySubcategory;
}
if (key == IdTotalAmount) {
return ssTotalAmount;
}
if (key == IdFromCosmoz) {
return ssFromCosmoz;
}
if (key == IdRegionId) {
return ssRegionId;
}
if (key == IdDivisionId) {
return ssDivisionId;
}
if (key == IdApplicant) {
return ssApplicant;
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
if (attributeKey == IdOrderNumber.Key.AsGuid) {
return ssOrderNumber;
}
if (attributeKey == IdOrderDate.Key.AsGuid) {
return ssOrderDate;
}
if (attributeKey == IdOrderStatusId.Key.AsGuid) {
return ssOrderStatusId;
}
if (attributeKey == IdPreviousOrderStatusId.Key.AsGuid) {
return ssPreviousOrderStatusId;
}
if (attributeKey == IdAssignmentCode.Key.AsGuid) {
return ssAssignmentCode;
}
if (attributeKey == IdSupplierId.Key.AsGuid) {
return ssSupplierId;
}
if (attributeKey == IdCompanyId.Key.AsGuid) {
return ssCompanyId;
}
if (attributeKey == IdDocumentTypeId.Key.AsGuid) {
return ssDocumentTypeId;
}
if (attributeKey == IdCurrencyId.Key.AsGuid) {
return ssCurrencyId;
}
if (attributeKey == IdTelcelDirectionId.Key.AsGuid) {
return ssTelcelDirectionId;
}
if (attributeKey == IdProcurementGroup.Key.AsGuid) {
return ssProcurementGroup;
}
if (attributeKey == IdCreatorSAPNumber.Key.AsGuid) {
return ssCreatorSAPNumber;
}
if (attributeKey == IdCreatorSAPName.Key.AsGuid) {
return ssCreatorSAPName;
}
if (attributeKey == IdCountry.Key.AsGuid) {
return ssCountry;
}
if (attributeKey == IdIsDeleted.Key.AsGuid) {
return ssIsDeleted;
}
if (attributeKey == IdIsReleased.Key.AsGuid) {
return ssIsReleased;
}
if (attributeKey == IdExchangeRate.Key.AsGuid) {
return ssExchangeRate;
}
if (attributeKey == IdSustainabilityCategory.Key.AsGuid) {
return ssSustainabilityCategory;
}
if (attributeKey == IdSustainabilitySubcategory.Key.AsGuid) {
return ssSustainabilitySubcategory;
}
if (attributeKey == IdTotalAmount.Key.AsGuid) {
return ssTotalAmount;
}
if (attributeKey == IdFromCosmoz.Key.AsGuid) {
return ssFromCosmoz;
}
if (attributeKey == IdRegionId.Key.AsGuid) {
return ssRegionId;
}
if (attributeKey == IdDivisionId.Key.AsGuid) {
return ssDivisionId;
}
if (attributeKey == IdApplicant.Key.AsGuid) {
return ssApplicant;
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
ChangedAttributes = new BitArray(29);
OptimizedAttributes = new BitArray(29);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssOrderNumber = (string) other.AttributeGet(IdOrderNumber);
ChangedAttributes[1] = other.ChangedAttributeGet(IdOrderNumber);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdOrderNumber);
ssOrderDate = (DateTime) other.AttributeGet(IdOrderDate);
ChangedAttributes[2] = other.ChangedAttributeGet(IdOrderDate);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdOrderDate);
ssOrderStatusId = (int) other.AttributeGet(IdOrderStatusId);
ChangedAttributes[3] = other.ChangedAttributeGet(IdOrderStatusId);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdOrderStatusId);
ssPreviousOrderStatusId = (int) other.AttributeGet(IdPreviousOrderStatusId);
ChangedAttributes[4] = other.ChangedAttributeGet(IdPreviousOrderStatusId);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdPreviousOrderStatusId);
ssAssignmentCode = (string) other.AttributeGet(IdAssignmentCode);
ChangedAttributes[5] = other.ChangedAttributeGet(IdAssignmentCode);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdAssignmentCode);
ssSupplierId = (long) other.AttributeGet(IdSupplierId);
ChangedAttributes[6] = other.ChangedAttributeGet(IdSupplierId);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdSupplierId);
ssCompanyId = (long) other.AttributeGet(IdCompanyId);
ChangedAttributes[7] = other.ChangedAttributeGet(IdCompanyId);
OptimizedAttributes[7] = other.OptimizedAttributeGet(IdCompanyId);
ssDocumentTypeId = (long) other.AttributeGet(IdDocumentTypeId);
ChangedAttributes[8] = other.ChangedAttributeGet(IdDocumentTypeId);
OptimizedAttributes[8] = other.OptimizedAttributeGet(IdDocumentTypeId);
ssCurrencyId = (string) other.AttributeGet(IdCurrencyId);
ChangedAttributes[9] = other.ChangedAttributeGet(IdCurrencyId);
OptimizedAttributes[9] = other.OptimizedAttributeGet(IdCurrencyId);
ssTelcelDirectionId = (long) other.AttributeGet(IdTelcelDirectionId);
ChangedAttributes[10] = other.ChangedAttributeGet(IdTelcelDirectionId);
OptimizedAttributes[10] = other.OptimizedAttributeGet(IdTelcelDirectionId);
ssProcurementGroup = (string) other.AttributeGet(IdProcurementGroup);
ChangedAttributes[11] = other.ChangedAttributeGet(IdProcurementGroup);
OptimizedAttributes[11] = other.OptimizedAttributeGet(IdProcurementGroup);
ssCreatorSAPNumber = (string) other.AttributeGet(IdCreatorSAPNumber);
ChangedAttributes[12] = other.ChangedAttributeGet(IdCreatorSAPNumber);
OptimizedAttributes[12] = other.OptimizedAttributeGet(IdCreatorSAPNumber);
ssCreatorSAPName = (string) other.AttributeGet(IdCreatorSAPName);
ChangedAttributes[13] = other.ChangedAttributeGet(IdCreatorSAPName);
OptimizedAttributes[13] = other.OptimizedAttributeGet(IdCreatorSAPName);
ssCountry = (string) other.AttributeGet(IdCountry);
ChangedAttributes[14] = other.ChangedAttributeGet(IdCountry);
OptimizedAttributes[14] = other.OptimizedAttributeGet(IdCountry);
ssIsDeleted = (bool) other.AttributeGet(IdIsDeleted);
ChangedAttributes[15] = other.ChangedAttributeGet(IdIsDeleted);
OptimizedAttributes[15] = other.OptimizedAttributeGet(IdIsDeleted);
ssIsReleased = (bool) other.AttributeGet(IdIsReleased);
ChangedAttributes[16] = other.ChangedAttributeGet(IdIsReleased);
OptimizedAttributes[16] = other.OptimizedAttributeGet(IdIsReleased);
ssExchangeRate = (decimal) other.AttributeGet(IdExchangeRate);
ChangedAttributes[17] = other.ChangedAttributeGet(IdExchangeRate);
OptimizedAttributes[17] = other.OptimizedAttributeGet(IdExchangeRate);
ssSustainabilityCategory = (string) other.AttributeGet(IdSustainabilityCategory);
ChangedAttributes[18] = other.ChangedAttributeGet(IdSustainabilityCategory);
OptimizedAttributes[18] = other.OptimizedAttributeGet(IdSustainabilityCategory);
ssSustainabilitySubcategory = (string) other.AttributeGet(IdSustainabilitySubcategory);
ChangedAttributes[19] = other.ChangedAttributeGet(IdSustainabilitySubcategory);
OptimizedAttributes[19] = other.OptimizedAttributeGet(IdSustainabilitySubcategory);
ssTotalAmount = (decimal) other.AttributeGet(IdTotalAmount);
ChangedAttributes[20] = other.ChangedAttributeGet(IdTotalAmount);
OptimizedAttributes[20] = other.OptimizedAttributeGet(IdTotalAmount);
ssFromCosmoz = (bool) other.AttributeGet(IdFromCosmoz);
ChangedAttributes[21] = other.ChangedAttributeGet(IdFromCosmoz);
OptimizedAttributes[21] = other.OptimizedAttributeGet(IdFromCosmoz);
ssRegionId = (long) other.AttributeGet(IdRegionId);
ChangedAttributes[22] = other.ChangedAttributeGet(IdRegionId);
OptimizedAttributes[22] = other.OptimizedAttributeGet(IdRegionId);
ssDivisionId = (long) other.AttributeGet(IdDivisionId);
ChangedAttributes[23] = other.ChangedAttributeGet(IdDivisionId);
OptimizedAttributes[23] = other.OptimizedAttributeGet(IdDivisionId);
ssApplicant = (string) other.AttributeGet(IdApplicant);
ChangedAttributes[24] = other.ChangedAttributeGet(IdApplicant);
OptimizedAttributes[24] = other.OptimizedAttributeGet(IdApplicant);
ssCreatedBy = (string) other.AttributeGet(IdCreatedBy);
ChangedAttributes[25] = other.ChangedAttributeGet(IdCreatedBy);
OptimizedAttributes[25] = other.OptimizedAttributeGet(IdCreatedBy);
ssCreatedOn = (DateTime) other.AttributeGet(IdCreatedOn);
ChangedAttributes[26] = other.ChangedAttributeGet(IdCreatedOn);
OptimizedAttributes[26] = other.OptimizedAttributeGet(IdCreatedOn);
ssUpdatedBy = (string) other.AttributeGet(IdUpdatedBy);
ChangedAttributes[27] = other.ChangedAttributeGet(IdUpdatedBy);
OptimizedAttributes[27] = other.OptimizedAttributeGet(IdUpdatedBy);
ssUpdatedOn = (DateTime) other.AttributeGet(IdUpdatedOn);
ChangedAttributes[28] = other.ChangedAttributeGet(IdUpdatedOn);
OptimizedAttributes[28] = other.OptimizedAttributeGet(IdUpdatedOn);
}
} // EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord

/// <summary>
/// RecordList type <code>OrderMainList</code> that represents a record list of <code>OrderMain</code>
/// </summary>
public partial class RL_ddb377bd4221b0f1ace97966ec42c9e6 : GenericRecordList<EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord>, IEnumerable, IEnumerator {

protected override EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord GetElementDefaultValue() {
return new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
}

public T[] ToArray<T>(Func<EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_ddb377bd4221b0f1ace97966ec42c9e6 recordList, Func<EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_ddb377bd4221b0f1ace97966ec42c9e6(EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord[] array) {
  RL_ddb377bd4221b0f1ace97966ec42c9e6 result = new RL_ddb377bd4221b0f1ace97966ec42c9e6();
result.InnerFromArray(array);
    return result;
}

public static RL_ddb377bd4221b0f1ace97966ec42c9e6 ToList<T>(T[] array, Func <T, EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord> converter) {
  RL_ddb377bd4221b0f1ace97966ec42c9e6 result = new RL_ddb377bd4221b0f1ace97966ec42c9e6();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_ddb377bd4221b0f1ace97966ec42c9e6 FromRestList<T>(RestList<T> restList, Func <T, EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord> converter) {
  RL_ddb377bd4221b0f1ace97966ec42c9e6 result = new RL_ddb377bd4221b0f1ace97966ec42c9e6();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_ddb377bd4221b0f1ace97966ec42c9e6() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord> NewList() {
return new RL_ddb377bd4221b0f1ace97966ec42c9e6();
}


} // RL_ddb377bd4221b0f1ace97966ec42c9e6
}
