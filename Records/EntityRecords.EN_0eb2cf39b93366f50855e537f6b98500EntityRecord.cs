using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] OrderItemEntries (c0LeD0CwYUmykWLaEHxOGQ)
///  <code>EN_0eb2cf39b93366f50855e537f6b98500EntityRecord</code> that represent
/// s <code>OrderItemEntries</code> <p>Description: </p>
/// </summary>
// Name: OrderItemEntries
public partial struct EN_0eb2cf39b93366f50855e537f6b98500EntityRecord : ITypedRecord<EN_0eb2cf39b93366f50855e537f6b98500EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*h9HIYA9BVkizbGn7ZxsEJA");
internal static readonly GlobalObjectKey IdOrderMainItemid = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*FMWBHW9g1UaOyXBKWOaJLw");
internal static readonly GlobalObjectKey IdQuantity_ = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*cM2UNADLg02w3_G9324ZBg");
internal static readonly GlobalObjectKey IdIsFromFirstImport = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*tegNah1x9Eu9UWC4SxI_6A");
internal static readonly GlobalObjectKey IdEntryDocument = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*eHBp_WFTLU2s9Xzhwu1APA");
internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*eiU31uJ6PEyoZ47HPKHpjA");
internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Mnv2JLjAH0OMpbEf8IM42g");
internal static readonly GlobalObjectKey IdRejectFolio = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*db3ZTMvxHUWEJxD_sQX+gQ");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(8,true);
          _ssId = value;
      }
  }
}

private long _ssOrderMainItemid;
public long ssOrderMainItemid{
  get{
      return _ssOrderMainItemid;
  }
  set{
      if((_ssOrderMainItemid!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssOrderMainItemid = value;
      }
  }
}

private decimal _ssQuantity_;
public decimal ssQuantity_{
  get{
      return _ssQuantity_;
  }
  set{
      if((_ssQuantity_!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssQuantity_ = value;
      }
  }
}

private bool _ssIsFromFirstImport;
public bool ssIsFromFirstImport{
  get{
      return _ssIsFromFirstImport;
  }
  set{
      if((_ssIsFromFirstImport!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssIsFromFirstImport = value;
      }
  }
}

private string _ssEntryDocument;
public string ssEntryDocument{
  get{
      return _ssEntryDocument;
  }
  set{
      if((_ssEntryDocument!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssEntryDocument = value;
      }
  }
}

private DateTime _ssCreatedOn;
public DateTime ssCreatedOn{
  get{
      return _ssCreatedOn;
  }
  set{
      if((_ssCreatedOn!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssCreatedOn = value;
      }
  }
}

private string _ssCreatedBy;
public string ssCreatedBy{
  get{
      return _ssCreatedBy;
  }
  set{
      if((_ssCreatedBy!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssCreatedBy = value;
      }
  }
}

private bool _ssRejectFolio;
public bool ssRejectFolio{
  get{
      return _ssRejectFolio;
  }
  set{
      if((_ssRejectFolio!=value) || OptimizedAttributes[7]){
          ChangedAttributes[7] = true;
          _ssRejectFolio = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_0eb2cf39b93366f50855e537f6b98500EntityRecord() {
ChangedAttributes = new BitArray(8,true);
OptimizedAttributes = new BitArray(8,false);
_ssId = 0L;
_ssOrderMainItemid = 0L;
_ssQuantity_ = 0.0M;
_ssIsFromFirstImport = false;
_ssEntryDocument = "";
_ssCreatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssCreatedBy = "";
_ssRejectFolio = false;
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
ssId = r.ReadLongInteger(index++, "OrderItemEntries.Id", 0L);
ssOrderMainItemid = r.ReadEntityReferenceLongInteger(index++, "OrderItemEntries.OrderMainItemid", 0L);
ssQuantity_ = r.ReadDecimal(index++, "OrderItemEntries.Quantity_", 0.0M);
ssIsFromFirstImport = r.ReadBoolean(index++, "OrderItemEntries.IsFromFirstImport", false);
ssEntryDocument = r.ReadText(index++, "OrderItemEntries.EntryDocument", "");
ssCreatedOn = r.ReadDateTime(index++, "OrderItemEntries.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssCreatedBy = r.ReadEntityReferenceText(index++, "OrderItemEntries.CreatedBy", "");
ssRejectFolio = r.ReadBoolean(index++, "OrderItemEntries.RejectFolio", false);
ChangedAttributes = new BitArray(8,false);
OptimizedAttributes = new BitArray(8,false);
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
public void ReadIM(EN_0eb2cf39b93366f50855e537f6b98500EntityRecord r) {
this = r;
}


public static bool operator == (EN_0eb2cf39b93366f50855e537f6b98500EntityRecord a, EN_0eb2cf39b93366f50855e537f6b98500EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssOrderMainItemid != b.ssOrderMainItemid) return false;
if (a.ssQuantity_ != b.ssQuantity_) return false;
if (a.ssIsFromFirstImport != b.ssIsFromFirstImport) return false;
if (a.ssEntryDocument != b.ssEntryDocument) return false;
if (a.ssCreatedOn != b.ssCreatedOn) return false;
if (a.ssCreatedBy != b.ssCreatedBy) return false;
if (a.ssRejectFolio != b.ssRejectFolio) return false;
return true;
}

public static bool operator != (EN_0eb2cf39b93366f50855e537f6b98500EntityRecord a, EN_0eb2cf39b93366f50855e537f6b98500EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_0eb2cf39b93366f50855e537f6b98500EntityRecord)) return false;
return (this == (EN_0eb2cf39b93366f50855e537f6b98500EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssOrderMainItemid.GetHashCode()
 ^ ssQuantity_.GetHashCode()
 ^ ssIsFromFirstImport.GetHashCode()
 ^ ssEntryDocument.GetHashCode()
 ^ ssCreatedOn.GetHashCode()
 ^ ssCreatedBy.GetHashCode()
 ^ ssRejectFolio.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_0eb2cf39b93366f50855e537f6b98500EntityRecord Duplicate() {
EN_0eb2cf39b93366f50855e537f6b98500EntityRecord t;
t._ssId = this._ssId;
t._ssOrderMainItemid = this._ssOrderMainItemid;
t._ssQuantity_ = this._ssQuantity_;
t._ssIsFromFirstImport = this._ssIsFromFirstImport;
t._ssEntryDocument = this._ssEntryDocument;
t._ssCreatedOn = this._ssCreatedOn;
t._ssCreatedBy = this._ssCreatedBy;
t._ssRejectFolio = this._ssRejectFolio;
t.ChangedAttributes = new BitArray(8);
t.OptimizedAttributes = new BitArray(8);
for(int i = 0; i < 8; i++){
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
} else if (head == "ordermainitemid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMainItemid")) variable.Value = ssOrderMainItemid; else variable.Optimized = true;
} else if (head == "quantity_") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Quantity_")) variable.Value = ssQuantity_; else variable.Optimized = true;
} else if (head == "isfromfirstimport") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsFromFirstImport")) variable.Value = ssIsFromFirstImport; else variable.Optimized = true;
} else if (head == "entrydocument") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EntryDocument")) variable.Value = ssEntryDocument; else variable.Optimized = true;
} else if (head == "createdon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedOn")) variable.Value = ssCreatedOn; else variable.Optimized = true;
} else if (head == "createdby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedBy")) variable.Value = ssCreatedBy; else variable.Optimized = true;
} else if (head == "rejectfolio") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RejectFolio")) variable.Value = ssRejectFolio; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdOrderMainItemid)) {
return ChangedAttributes[1];
}
if (key.Equals(IdQuantity_)) {
return ChangedAttributes[2];
}
if (key.Equals(IdIsFromFirstImport)) {
return ChangedAttributes[3];
}
if (key.Equals(IdEntryDocument)) {
return ChangedAttributes[4];
}
if (key.Equals(IdCreatedOn)) {
return ChangedAttributes[5];
}
if (key.Equals(IdCreatedBy)) {
return ChangedAttributes[6];
}
if (key.Equals(IdRejectFolio)) {
return ChangedAttributes[7];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdOrderMainItemid)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdQuantity_)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdIsFromFirstImport)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdEntryDocument)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdCreatedOn)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdCreatedBy)) {
return OptimizedAttributes[6];
}
if (key.Equals(IdRejectFolio)) {
return OptimizedAttributes[7];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdOrderMainItemid) {
return ssOrderMainItemid;
}
if (key == IdQuantity_) {
return ssQuantity_;
}
if (key == IdIsFromFirstImport) {
return ssIsFromFirstImport;
}
if (key == IdEntryDocument) {
return ssEntryDocument;
}
if (key == IdCreatedOn) {
return ssCreatedOn;
}
if (key == IdCreatedBy) {
return ssCreatedBy;
}
if (key == IdRejectFolio) {
return ssRejectFolio;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdOrderMainItemid.Key.AsGuid) {
return ssOrderMainItemid;
}
if (attributeKey == IdQuantity_.Key.AsGuid) {
return ssQuantity_;
}
if (attributeKey == IdIsFromFirstImport.Key.AsGuid) {
return ssIsFromFirstImport;
}
if (attributeKey == IdEntryDocument.Key.AsGuid) {
return ssEntryDocument;
}
if (attributeKey == IdCreatedOn.Key.AsGuid) {
return ssCreatedOn;
}
if (attributeKey == IdCreatedBy.Key.AsGuid) {
return ssCreatedBy;
}
if (attributeKey == IdRejectFolio.Key.AsGuid) {
return ssRejectFolio;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(8);
OptimizedAttributes = new BitArray(8);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssOrderMainItemid = (long) other.AttributeGet(IdOrderMainItemid);
ChangedAttributes[1] = other.ChangedAttributeGet(IdOrderMainItemid);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdOrderMainItemid);
ssQuantity_ = (decimal) other.AttributeGet(IdQuantity_);
ChangedAttributes[2] = other.ChangedAttributeGet(IdQuantity_);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdQuantity_);
ssIsFromFirstImport = (bool) other.AttributeGet(IdIsFromFirstImport);
ChangedAttributes[3] = other.ChangedAttributeGet(IdIsFromFirstImport);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdIsFromFirstImport);
ssEntryDocument = (string) other.AttributeGet(IdEntryDocument);
ChangedAttributes[4] = other.ChangedAttributeGet(IdEntryDocument);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdEntryDocument);
ssCreatedOn = (DateTime) other.AttributeGet(IdCreatedOn);
ChangedAttributes[5] = other.ChangedAttributeGet(IdCreatedOn);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdCreatedOn);
ssCreatedBy = (string) other.AttributeGet(IdCreatedBy);
ChangedAttributes[6] = other.ChangedAttributeGet(IdCreatedBy);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdCreatedBy);
ssRejectFolio = (bool) other.AttributeGet(IdRejectFolio);
ChangedAttributes[7] = other.ChangedAttributeGet(IdRejectFolio);
OptimizedAttributes[7] = other.OptimizedAttributeGet(IdRejectFolio);
}
} // EN_0eb2cf39b93366f50855e537f6b98500EntityRecord

/// <summary>
/// RecordList type <code>OrderItemEntriesList</code> that represents a record list of
///  <code>OrderItemEntries</code>
/// </summary>
public partial class RL_094f43a663937e490f1913e0aaf7c97c : GenericRecordList<EN_0eb2cf39b93366f50855e537f6b98500EntityRecord>, IEnumerable, IEnumerator {

protected override EN_0eb2cf39b93366f50855e537f6b98500EntityRecord GetElementDefaultValue() {
return new EN_0eb2cf39b93366f50855e537f6b98500EntityRecord();
}

public T[] ToArray<T>(Func<EN_0eb2cf39b93366f50855e537f6b98500EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_094f43a663937e490f1913e0aaf7c97c recordList, Func<EN_0eb2cf39b93366f50855e537f6b98500EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_094f43a663937e490f1913e0aaf7c97c(EN_0eb2cf39b93366f50855e537f6b98500EntityRecord[] array) {
  RL_094f43a663937e490f1913e0aaf7c97c result = new RL_094f43a663937e490f1913e0aaf7c97c();
result.InnerFromArray(array);
    return result;
}

public static RL_094f43a663937e490f1913e0aaf7c97c ToList<T>(T[] array, Func <T, EN_0eb2cf39b93366f50855e537f6b98500EntityRecord> converter) {
  RL_094f43a663937e490f1913e0aaf7c97c result = new RL_094f43a663937e490f1913e0aaf7c97c();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_094f43a663937e490f1913e0aaf7c97c FromRestList<T>(RestList<T> restList, Func <T, EN_0eb2cf39b93366f50855e537f6b98500EntityRecord> converter) {
  RL_094f43a663937e490f1913e0aaf7c97c result = new RL_094f43a663937e490f1913e0aaf7c97c();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_094f43a663937e490f1913e0aaf7c97c() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_0eb2cf39b93366f50855e537f6b98500EntityRecord> NewList() {
return new RL_094f43a663937e490f1913e0aaf7c97c();
}


} // RL_094f43a663937e490f1913e0aaf7c97c
}
