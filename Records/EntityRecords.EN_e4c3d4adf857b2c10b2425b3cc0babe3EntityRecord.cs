using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] OrderRequestFile (NdM_c+WrT0KTVYnlU9CDEA)
///  <code>EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord</code> that represent
/// s <code>OrderRequestFile</code> <p>Description: Order file request</p>
/// </summary>
// Name: OrderRequestFile
public partial struct EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord : ITypedRecord<EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*vhjedL9etkuBeMus4FSPFQ");
internal static readonly GlobalObjectKey IdOrderId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*EnLr14T34Eu+6uJRQrmfZA");
internal static readonly GlobalObjectKey IdInvoiceId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*MYBoe7PWmUCHbuoSAJcwkQ");
internal static readonly GlobalObjectKey IdFilename = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*QPdkS_k0h0SbUjaHQMV7Vg");
internal static readonly GlobalObjectKey IdStorageId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*2Xt71jw00U+be0uLct5+Hw");
internal static readonly GlobalObjectKey IdDescription = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*T_PgWXh1AE6VxOIOJTOpHw");
internal static readonly GlobalObjectKey IdNeedsApproval = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*ElAdVWZrAkmKuxcFHXmL0w");
internal static readonly GlobalObjectKey IdIsApproved = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*bms0RQElIkyyzy3BR2Phiw");
internal static readonly GlobalObjectKey IdIsRejected = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*PwNnEeIhrEWYAJNviMdREQ");
internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*U24vkzO7skuK4SWu+p7Qrw");
internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*w3pbvxLTi0GeeVzZMHN77g");
internal static readonly GlobalObjectKey IdUpdatedBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*iLuROt9E9US9OpwibKipSA");
internal static readonly GlobalObjectKey IdUpdatedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*WceHjfZnykCGdHt2s88TNg");
internal static readonly GlobalObjectKey IdOrderAccConceptId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*JIjENyKU0kO06uof5COKYg");
internal static readonly GlobalObjectKey IdIsFinancialFile = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*0ECu6psQX0WeYoI+hhb9VA");
internal static readonly GlobalObjectKey IdOrderContractFile = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*1YN57cwbjU2+Ics8nW0xRA");
internal static readonly GlobalObjectKey IdNeedAccounting = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*gFFNiJFOukSPNynUo7C2ng");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(17,true);
          _ssId = value;
      }
  }
}

private long _ssOrderId;
public long ssOrderId{
  get{
      return _ssOrderId;
  }
  set{
      if((_ssOrderId!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssOrderId = value;
      }
  }
}

private long _ssInvoiceId;
public long ssInvoiceId{
  get{
      return _ssInvoiceId;
  }
  set{
      if((_ssInvoiceId!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssInvoiceId = value;
      }
  }
}

private string _ssFilename;
public string ssFilename{
  get{
      return _ssFilename;
  }
  set{
      if((_ssFilename!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssFilename = value;
      }
  }
}

private long _ssStorageId;
public long ssStorageId{
  get{
      return _ssStorageId;
  }
  set{
      if((_ssStorageId!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssStorageId = value;
      }
  }
}

private string _ssDescription;
public string ssDescription{
  get{
      return _ssDescription;
  }
  set{
      if((_ssDescription!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssDescription = value;
      }
  }
}

private bool _ssNeedsApproval;
public bool ssNeedsApproval{
  get{
      return _ssNeedsApproval;
  }
  set{
      if((_ssNeedsApproval!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssNeedsApproval = value;
      }
  }
}

private bool _ssIsApproved;
public bool ssIsApproved{
  get{
      return _ssIsApproved;
  }
  set{
      if((_ssIsApproved!=value) || OptimizedAttributes[7]){
          ChangedAttributes[7] = true;
          _ssIsApproved = value;
      }
  }
}

private bool _ssIsRejected;
public bool ssIsRejected{
  get{
      return _ssIsRejected;
  }
  set{
      if((_ssIsRejected!=value) || OptimizedAttributes[8]){
          ChangedAttributes[8] = true;
          _ssIsRejected = value;
      }
  }
}

private string _ssCreatedBy;
public string ssCreatedBy{
  get{
      return _ssCreatedBy;
  }
  set{
      if((_ssCreatedBy!=value) || OptimizedAttributes[9]){
          ChangedAttributes[9] = true;
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
      if((_ssCreatedOn!=value) || OptimizedAttributes[10]){
          ChangedAttributes[10] = true;
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
      if((_ssUpdatedBy!=value) || OptimizedAttributes[11]){
          ChangedAttributes[11] = true;
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
      if((_ssUpdatedOn!=value) || OptimizedAttributes[12]){
          ChangedAttributes[12] = true;
          _ssUpdatedOn = value;
      }
  }
}

private long _ssOrderAccConceptId;
public long ssOrderAccConceptId{
  get{
      return _ssOrderAccConceptId;
  }
  set{
      if((_ssOrderAccConceptId!=value) || OptimizedAttributes[13]){
          ChangedAttributes[13] = true;
          _ssOrderAccConceptId = value;
      }
  }
}

private bool _ssIsFinancialFile;
public bool ssIsFinancialFile{
  get{
      return _ssIsFinancialFile;
  }
  set{
      if((_ssIsFinancialFile!=value) || OptimizedAttributes[14]){
          ChangedAttributes[14] = true;
          _ssIsFinancialFile = value;
      }
  }
}

private long _ssOrderContractFile;
public long ssOrderContractFile{
  get{
      return _ssOrderContractFile;
  }
  set{
      if((_ssOrderContractFile!=value) || OptimizedAttributes[15]){
          ChangedAttributes[15] = true;
          _ssOrderContractFile = value;
      }
  }
}

private bool _ssNeedAccounting;
public bool ssNeedAccounting{
  get{
      return _ssNeedAccounting;
  }
  set{
      if((_ssNeedAccounting!=value) || OptimizedAttributes[16]){
          ChangedAttributes[16] = true;
          _ssNeedAccounting = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord() {
ChangedAttributes = new BitArray(17,true);
OptimizedAttributes = new BitArray(17,false);
_ssId = 0L;
_ssOrderId = 0L;
_ssInvoiceId = 0L;
_ssFilename = "";
_ssStorageId = 0L;
_ssDescription = "";
_ssNeedsApproval = false;
_ssIsApproved = false;
_ssIsRejected = false;
_ssCreatedBy = "";
_ssCreatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssUpdatedBy = "";
_ssUpdatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssOrderAccConceptId = 0L;
_ssIsFinancialFile = false;
_ssOrderContractFile = 0L;
_ssNeedAccounting = false;
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
ssId = r.ReadLongInteger(index++, "OrderRequestFile.Id", 0L);
ssOrderId = r.ReadEntityReferenceLongInteger(index++, "OrderRequestFile.OrderId", 0L);
ssInvoiceId = r.ReadEntityReferenceLongInteger(index++, "OrderRequestFile.InvoiceId", 0L);
ssFilename = r.ReadText(index++, "OrderRequestFile.Filename", "");
ssStorageId = r.ReadEntityReferenceLongInteger(index++, "OrderRequestFile.StorageId", 0L);
ssDescription = r.ReadText(index++, "OrderRequestFile.Description", "");
ssNeedsApproval = r.ReadBoolean(index++, "OrderRequestFile.NeedsApproval", false);
ssIsApproved = r.ReadBoolean(index++, "OrderRequestFile.IsApproved", false);
ssIsRejected = r.ReadBoolean(index++, "OrderRequestFile.IsRejected", false);
ssCreatedBy = r.ReadEntityReferenceText(index++, "OrderRequestFile.CreatedBy", "");
ssCreatedOn = r.ReadDateTime(index++, "OrderRequestFile.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssUpdatedBy = r.ReadEntityReferenceText(index++, "OrderRequestFile.UpdatedBy", "");
ssUpdatedOn = r.ReadDateTime(index++, "OrderRequestFile.UpdatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssOrderAccConceptId = r.ReadEntityReferenceLongInteger(index++, "OrderRequestFile.OrderAccConceptId", 0L);
ssIsFinancialFile = r.ReadBoolean(index++, "OrderRequestFile.IsFinancialFile", false);
ssOrderContractFile = r.ReadEntityReferenceLongInteger(index++, "OrderRequestFile.OrderContractFile", 0L);
ssNeedAccounting = r.ReadBoolean(index++, "OrderRequestFile.NeedAccounting", false);
ChangedAttributes = new BitArray(17,false);
OptimizedAttributes = new BitArray(17,false);
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
public void ReadIM(EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord r) {
this = r;
}


public static bool operator == (EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord a, EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssOrderId != b.ssOrderId) return false;
if (a.ssInvoiceId != b.ssInvoiceId) return false;
if (a.ssFilename != b.ssFilename) return false;
if (a.ssStorageId != b.ssStorageId) return false;
if (a.ssDescription != b.ssDescription) return false;
if (a.ssNeedsApproval != b.ssNeedsApproval) return false;
if (a.ssIsApproved != b.ssIsApproved) return false;
if (a.ssIsRejected != b.ssIsRejected) return false;
if (a.ssCreatedBy != b.ssCreatedBy) return false;
if (a.ssCreatedOn != b.ssCreatedOn) return false;
if (a.ssUpdatedBy != b.ssUpdatedBy) return false;
if (a.ssUpdatedOn != b.ssUpdatedOn) return false;
if (a.ssOrderAccConceptId != b.ssOrderAccConceptId) return false;
if (a.ssIsFinancialFile != b.ssIsFinancialFile) return false;
if (a.ssOrderContractFile != b.ssOrderContractFile) return false;
if (a.ssNeedAccounting != b.ssNeedAccounting) return false;
return true;
}

public static bool operator != (EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord a, EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord)) return false;
return (this == (EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssOrderId.GetHashCode()
 ^ ssInvoiceId.GetHashCode()
 ^ ssFilename.GetHashCode()
 ^ ssStorageId.GetHashCode()
 ^ ssDescription.GetHashCode()
 ^ ssNeedsApproval.GetHashCode()
 ^ ssIsApproved.GetHashCode()
 ^ ssIsRejected.GetHashCode()
 ^ ssCreatedBy.GetHashCode()
 ^ ssCreatedOn.GetHashCode()
 ^ ssUpdatedBy.GetHashCode()
 ^ ssUpdatedOn.GetHashCode()
 ^ ssOrderAccConceptId.GetHashCode()
 ^ ssIsFinancialFile.GetHashCode()
 ^ ssOrderContractFile.GetHashCode()
 ^ ssNeedAccounting.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord Duplicate() {
EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord t;
t._ssId = this._ssId;
t._ssOrderId = this._ssOrderId;
t._ssInvoiceId = this._ssInvoiceId;
t._ssFilename = this._ssFilename;
t._ssStorageId = this._ssStorageId;
t._ssDescription = this._ssDescription;
t._ssNeedsApproval = this._ssNeedsApproval;
t._ssIsApproved = this._ssIsApproved;
t._ssIsRejected = this._ssIsRejected;
t._ssCreatedBy = this._ssCreatedBy;
t._ssCreatedOn = this._ssCreatedOn;
t._ssUpdatedBy = this._ssUpdatedBy;
t._ssUpdatedOn = this._ssUpdatedOn;
t._ssOrderAccConceptId = this._ssOrderAccConceptId;
t._ssIsFinancialFile = this._ssIsFinancialFile;
t._ssOrderContractFile = this._ssOrderContractFile;
t._ssNeedAccounting = this._ssNeedAccounting;
t.ChangedAttributes = new BitArray(17);
t.OptimizedAttributes = new BitArray(17);
for(int i = 0; i < 17; i++){
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
} else if (head == "orderid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderId")) variable.Value = ssOrderId; else variable.Optimized = true;
} else if (head == "invoiceid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceId")) variable.Value = ssInvoiceId; else variable.Optimized = true;
} else if (head == "filename") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Filename")) variable.Value = ssFilename; else variable.Optimized = true;
} else if (head == "storageid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".StorageId")) variable.Value = ssStorageId; else variable.Optimized = true;
} else if (head == "description") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Description")) variable.Value = ssDescription; else variable.Optimized = true;
} else if (head == "needsapproval") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".NeedsApproval")) variable.Value = ssNeedsApproval; else variable.Optimized = true;
} else if (head == "isapproved") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsApproved")) variable.Value = ssIsApproved; else variable.Optimized = true;
} else if (head == "isrejected") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsRejected")) variable.Value = ssIsRejected; else variable.Optimized = true;
} else if (head == "createdby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedBy")) variable.Value = ssCreatedBy; else variable.Optimized = true;
} else if (head == "createdon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedOn")) variable.Value = ssCreatedOn; else variable.Optimized = true;
} else if (head == "updatedby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdatedBy")) variable.Value = ssUpdatedBy; else variable.Optimized = true;
} else if (head == "updatedon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdatedOn")) variable.Value = ssUpdatedOn; else variable.Optimized = true;
} else if (head == "orderaccconceptid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderAccConceptId")) variable.Value = ssOrderAccConceptId; else variable.Optimized = true;
} else if (head == "isfinancialfile") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsFinancialFile")) variable.Value = ssIsFinancialFile; else variable.Optimized = true;
} else if (head == "ordercontractfile") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderContractFile")) variable.Value = ssOrderContractFile; else variable.Optimized = true;
} else if (head == "needaccounting") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".NeedAccounting")) variable.Value = ssNeedAccounting; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdOrderId)) {
return ChangedAttributes[1];
}
if (key.Equals(IdInvoiceId)) {
return ChangedAttributes[2];
}
if (key.Equals(IdFilename)) {
return ChangedAttributes[3];
}
if (key.Equals(IdStorageId)) {
return ChangedAttributes[4];
}
if (key.Equals(IdDescription)) {
return ChangedAttributes[5];
}
if (key.Equals(IdNeedsApproval)) {
return ChangedAttributes[6];
}
if (key.Equals(IdIsApproved)) {
return ChangedAttributes[7];
}
if (key.Equals(IdIsRejected)) {
return ChangedAttributes[8];
}
if (key.Equals(IdCreatedBy)) {
return ChangedAttributes[9];
}
if (key.Equals(IdCreatedOn)) {
return ChangedAttributes[10];
}
if (key.Equals(IdUpdatedBy)) {
return ChangedAttributes[11];
}
if (key.Equals(IdUpdatedOn)) {
return ChangedAttributes[12];
}
if (key.Equals(IdOrderAccConceptId)) {
return ChangedAttributes[13];
}
if (key.Equals(IdIsFinancialFile)) {
return ChangedAttributes[14];
}
if (key.Equals(IdOrderContractFile)) {
return ChangedAttributes[15];
}
if (key.Equals(IdNeedAccounting)) {
return ChangedAttributes[16];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdOrderId)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdInvoiceId)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdFilename)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdStorageId)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdDescription)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdNeedsApproval)) {
return OptimizedAttributes[6];
}
if (key.Equals(IdIsApproved)) {
return OptimizedAttributes[7];
}
if (key.Equals(IdIsRejected)) {
return OptimizedAttributes[8];
}
if (key.Equals(IdCreatedBy)) {
return OptimizedAttributes[9];
}
if (key.Equals(IdCreatedOn)) {
return OptimizedAttributes[10];
}
if (key.Equals(IdUpdatedBy)) {
return OptimizedAttributes[11];
}
if (key.Equals(IdUpdatedOn)) {
return OptimizedAttributes[12];
}
if (key.Equals(IdOrderAccConceptId)) {
return OptimizedAttributes[13];
}
if (key.Equals(IdIsFinancialFile)) {
return OptimizedAttributes[14];
}
if (key.Equals(IdOrderContractFile)) {
return OptimizedAttributes[15];
}
if (key.Equals(IdNeedAccounting)) {
return OptimizedAttributes[16];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdOrderId) {
return ssOrderId;
}
if (key == IdInvoiceId) {
return ssInvoiceId;
}
if (key == IdFilename) {
return ssFilename;
}
if (key == IdStorageId) {
return ssStorageId;
}
if (key == IdDescription) {
return ssDescription;
}
if (key == IdNeedsApproval) {
return ssNeedsApproval;
}
if (key == IdIsApproved) {
return ssIsApproved;
}
if (key == IdIsRejected) {
return ssIsRejected;
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
if (key == IdOrderAccConceptId) {
return ssOrderAccConceptId;
}
if (key == IdIsFinancialFile) {
return ssIsFinancialFile;
}
if (key == IdOrderContractFile) {
return ssOrderContractFile;
}
if (key == IdNeedAccounting) {
return ssNeedAccounting;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdOrderId.Key.AsGuid) {
return ssOrderId;
}
if (attributeKey == IdInvoiceId.Key.AsGuid) {
return ssInvoiceId;
}
if (attributeKey == IdFilename.Key.AsGuid) {
return ssFilename;
}
if (attributeKey == IdStorageId.Key.AsGuid) {
return ssStorageId;
}
if (attributeKey == IdDescription.Key.AsGuid) {
return ssDescription;
}
if (attributeKey == IdNeedsApproval.Key.AsGuid) {
return ssNeedsApproval;
}
if (attributeKey == IdIsApproved.Key.AsGuid) {
return ssIsApproved;
}
if (attributeKey == IdIsRejected.Key.AsGuid) {
return ssIsRejected;
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
if (attributeKey == IdOrderAccConceptId.Key.AsGuid) {
return ssOrderAccConceptId;
}
if (attributeKey == IdIsFinancialFile.Key.AsGuid) {
return ssIsFinancialFile;
}
if (attributeKey == IdOrderContractFile.Key.AsGuid) {
return ssOrderContractFile;
}
if (attributeKey == IdNeedAccounting.Key.AsGuid) {
return ssNeedAccounting;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(17);
OptimizedAttributes = new BitArray(17);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssOrderId = (long) other.AttributeGet(IdOrderId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdOrderId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdOrderId);
ssInvoiceId = (long) other.AttributeGet(IdInvoiceId);
ChangedAttributes[2] = other.ChangedAttributeGet(IdInvoiceId);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdInvoiceId);
ssFilename = (string) other.AttributeGet(IdFilename);
ChangedAttributes[3] = other.ChangedAttributeGet(IdFilename);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdFilename);
ssStorageId = (long) other.AttributeGet(IdStorageId);
ChangedAttributes[4] = other.ChangedAttributeGet(IdStorageId);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdStorageId);
ssDescription = (string) other.AttributeGet(IdDescription);
ChangedAttributes[5] = other.ChangedAttributeGet(IdDescription);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdDescription);
ssNeedsApproval = (bool) other.AttributeGet(IdNeedsApproval);
ChangedAttributes[6] = other.ChangedAttributeGet(IdNeedsApproval);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdNeedsApproval);
ssIsApproved = (bool) other.AttributeGet(IdIsApproved);
ChangedAttributes[7] = other.ChangedAttributeGet(IdIsApproved);
OptimizedAttributes[7] = other.OptimizedAttributeGet(IdIsApproved);
ssIsRejected = (bool) other.AttributeGet(IdIsRejected);
ChangedAttributes[8] = other.ChangedAttributeGet(IdIsRejected);
OptimizedAttributes[8] = other.OptimizedAttributeGet(IdIsRejected);
ssCreatedBy = (string) other.AttributeGet(IdCreatedBy);
ChangedAttributes[9] = other.ChangedAttributeGet(IdCreatedBy);
OptimizedAttributes[9] = other.OptimizedAttributeGet(IdCreatedBy);
ssCreatedOn = (DateTime) other.AttributeGet(IdCreatedOn);
ChangedAttributes[10] = other.ChangedAttributeGet(IdCreatedOn);
OptimizedAttributes[10] = other.OptimizedAttributeGet(IdCreatedOn);
ssUpdatedBy = (string) other.AttributeGet(IdUpdatedBy);
ChangedAttributes[11] = other.ChangedAttributeGet(IdUpdatedBy);
OptimizedAttributes[11] = other.OptimizedAttributeGet(IdUpdatedBy);
ssUpdatedOn = (DateTime) other.AttributeGet(IdUpdatedOn);
ChangedAttributes[12] = other.ChangedAttributeGet(IdUpdatedOn);
OptimizedAttributes[12] = other.OptimizedAttributeGet(IdUpdatedOn);
ssOrderAccConceptId = (long) other.AttributeGet(IdOrderAccConceptId);
ChangedAttributes[13] = other.ChangedAttributeGet(IdOrderAccConceptId);
OptimizedAttributes[13] = other.OptimizedAttributeGet(IdOrderAccConceptId);
ssIsFinancialFile = (bool) other.AttributeGet(IdIsFinancialFile);
ChangedAttributes[14] = other.ChangedAttributeGet(IdIsFinancialFile);
OptimizedAttributes[14] = other.OptimizedAttributeGet(IdIsFinancialFile);
ssOrderContractFile = (long) other.AttributeGet(IdOrderContractFile);
ChangedAttributes[15] = other.ChangedAttributeGet(IdOrderContractFile);
OptimizedAttributes[15] = other.OptimizedAttributeGet(IdOrderContractFile);
ssNeedAccounting = (bool) other.AttributeGet(IdNeedAccounting);
ChangedAttributes[16] = other.ChangedAttributeGet(IdNeedAccounting);
OptimizedAttributes[16] = other.OptimizedAttributeGet(IdNeedAccounting);
}
} // EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord

/// <summary>
/// RecordList type <code>OrderRequestFileList</code> that represents a record list of
///  <code>OrderRequestFile</code>
/// </summary>
public partial class RL_08794d38cc3e746db7e33443c648a0fa : GenericRecordList<EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord>, IEnumerable, IEnumerator {

protected override EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord GetElementDefaultValue() {
return new EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord();
}

public T[] ToArray<T>(Func<EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_08794d38cc3e746db7e33443c648a0fa recordList, Func<EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_08794d38cc3e746db7e33443c648a0fa(EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord[] array) {
  RL_08794d38cc3e746db7e33443c648a0fa result = new RL_08794d38cc3e746db7e33443c648a0fa();
result.InnerFromArray(array);
    return result;
}

public static RL_08794d38cc3e746db7e33443c648a0fa ToList<T>(T[] array, Func <T, EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord> converter) {
  RL_08794d38cc3e746db7e33443c648a0fa result = new RL_08794d38cc3e746db7e33443c648a0fa();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_08794d38cc3e746db7e33443c648a0fa FromRestList<T>(RestList<T> restList, Func <T, EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord> converter) {
  RL_08794d38cc3e746db7e33443c648a0fa result = new RL_08794d38cc3e746db7e33443c648a0fa();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_08794d38cc3e746db7e33443c648a0fa() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord> NewList() {
return new RL_08794d38cc3e746db7e33443c648a0fa();
}


} // RL_08794d38cc3e746db7e33443c648a0fa
}
