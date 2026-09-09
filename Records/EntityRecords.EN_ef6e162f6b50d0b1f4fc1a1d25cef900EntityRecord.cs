using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] FolioLog (IYIzaco_LkW_ZeYDxcRWUg)
///  <code>EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord</code> that represents <code>FolioLog</code
/// > <p>Description: </p>
/// </summary>
// Name: FolioLog
public partial struct EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord : ITypedRecord<EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*LOiCC7vMzEyusU4mp_HAMA");
internal static readonly GlobalObjectKey IdFolioId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*6ugSN7+yZkmT1nsFQsIE9A");
internal static readonly GlobalObjectKey IdMessage = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*N1CReugUGESQ40oNobtTOA");
internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*SvPBh9UIiEW3vsDCFXeb5g");
internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*ndn7Wu58lkWxIr+LRx4ncg");
internal static readonly GlobalObjectKey IdIsError = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*YSskHSUD20qjFSYjY7b04Q");
internal static readonly GlobalObjectKey IdIsForSupplier = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*GHW_dNNlgkeSfuUNydvGJA");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(7,true);
          _ssId = value;
      }
  }
}

private long _ssFolioId;
public long ssFolioId{
  get{
      return _ssFolioId;
  }
  set{
      if((_ssFolioId!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssFolioId = value;
      }
  }
}

private string _ssMessage;
public string ssMessage{
  get{
      return _ssMessage;
  }
  set{
      if((_ssMessage!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssMessage = value;
      }
  }
}

private string _ssCreatedBy;
public string ssCreatedBy{
  get{
      return _ssCreatedBy;
  }
  set{
      if((_ssCreatedBy!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
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
      if((_ssCreatedOn!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssCreatedOn = value;
      }
  }
}

private bool _ssIsError;
public bool ssIsError{
  get{
      return _ssIsError;
  }
  set{
      if((_ssIsError!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssIsError = value;
      }
  }
}

private bool _ssIsForSupplier;
public bool ssIsForSupplier{
  get{
      return _ssIsForSupplier;
  }
  set{
      if((_ssIsForSupplier!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssIsForSupplier = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord() {
ChangedAttributes = new BitArray(7,true);
OptimizedAttributes = new BitArray(7,false);
_ssId = 0L;
_ssFolioId = 0L;
_ssMessage = "";
_ssCreatedBy = "";
_ssCreatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssIsError = false;
_ssIsForSupplier = false;
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
ssId = r.ReadLongInteger(index++, "FolioLog.Id", 0L);
ssFolioId = r.ReadEntityReferenceLongInteger(index++, "FolioLog.FolioId", 0L);
ssMessage = r.ReadText(index++, "FolioLog.Message", "");
ssCreatedBy = r.ReadEntityReferenceText(index++, "FolioLog.CreatedBy", "");
ssCreatedOn = r.ReadDateTime(index++, "FolioLog.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssIsError = r.ReadBoolean(index++, "FolioLog.IsError", false);
ssIsForSupplier = r.ReadBoolean(index++, "FolioLog.IsForSupplier", false);
ChangedAttributes = new BitArray(7,false);
OptimizedAttributes = new BitArray(7,false);
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
public void ReadIM(EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord r) {
this = r;
}


public static bool operator == (EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord a, EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssFolioId != b.ssFolioId) return false;
if (a.ssMessage != b.ssMessage) return false;
if (a.ssCreatedBy != b.ssCreatedBy) return false;
if (a.ssCreatedOn != b.ssCreatedOn) return false;
if (a.ssIsError != b.ssIsError) return false;
if (a.ssIsForSupplier != b.ssIsForSupplier) return false;
return true;
}

public static bool operator != (EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord a, EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord)) return false;
return (this == (EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssFolioId.GetHashCode()
 ^ ssMessage.GetHashCode()
 ^ ssCreatedBy.GetHashCode()
 ^ ssCreatedOn.GetHashCode()
 ^ ssIsError.GetHashCode()
 ^ ssIsForSupplier.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord Duplicate() {
EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord t;
t._ssId = this._ssId;
t._ssFolioId = this._ssFolioId;
t._ssMessage = this._ssMessage;
t._ssCreatedBy = this._ssCreatedBy;
t._ssCreatedOn = this._ssCreatedOn;
t._ssIsError = this._ssIsError;
t._ssIsForSupplier = this._ssIsForSupplier;
t.ChangedAttributes = new BitArray(7);
t.OptimizedAttributes = new BitArray(7);
for(int i = 0; i < 7; i++){
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
} else if (head == "folioid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioId")) variable.Value = ssFolioId; else variable.Optimized = true;
} else if (head == "message") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Message")) variable.Value = ssMessage; else variable.Optimized = true;
} else if (head == "createdby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedBy")) variable.Value = ssCreatedBy; else variable.Optimized = true;
} else if (head == "createdon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedOn")) variable.Value = ssCreatedOn; else variable.Optimized = true;
} else if (head == "iserror") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsError")) variable.Value = ssIsError; else variable.Optimized = true;
} else if (head == "isforsupplier") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsForSupplier")) variable.Value = ssIsForSupplier; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdFolioId)) {
return ChangedAttributes[1];
}
if (key.Equals(IdMessage)) {
return ChangedAttributes[2];
}
if (key.Equals(IdCreatedBy)) {
return ChangedAttributes[3];
}
if (key.Equals(IdCreatedOn)) {
return ChangedAttributes[4];
}
if (key.Equals(IdIsError)) {
return ChangedAttributes[5];
}
if (key.Equals(IdIsForSupplier)) {
return ChangedAttributes[6];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdFolioId)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdMessage)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdCreatedBy)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdCreatedOn)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdIsError)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdIsForSupplier)) {
return OptimizedAttributes[6];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdFolioId) {
return ssFolioId;
}
if (key == IdMessage) {
return ssMessage;
}
if (key == IdCreatedBy) {
return ssCreatedBy;
}
if (key == IdCreatedOn) {
return ssCreatedOn;
}
if (key == IdIsError) {
return ssIsError;
}
if (key == IdIsForSupplier) {
return ssIsForSupplier;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdFolioId.Key.AsGuid) {
return ssFolioId;
}
if (attributeKey == IdMessage.Key.AsGuid) {
return ssMessage;
}
if (attributeKey == IdCreatedBy.Key.AsGuid) {
return ssCreatedBy;
}
if (attributeKey == IdCreatedOn.Key.AsGuid) {
return ssCreatedOn;
}
if (attributeKey == IdIsError.Key.AsGuid) {
return ssIsError;
}
if (attributeKey == IdIsForSupplier.Key.AsGuid) {
return ssIsForSupplier;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(7);
OptimizedAttributes = new BitArray(7);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssFolioId = (long) other.AttributeGet(IdFolioId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdFolioId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdFolioId);
ssMessage = (string) other.AttributeGet(IdMessage);
ChangedAttributes[2] = other.ChangedAttributeGet(IdMessage);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdMessage);
ssCreatedBy = (string) other.AttributeGet(IdCreatedBy);
ChangedAttributes[3] = other.ChangedAttributeGet(IdCreatedBy);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdCreatedBy);
ssCreatedOn = (DateTime) other.AttributeGet(IdCreatedOn);
ChangedAttributes[4] = other.ChangedAttributeGet(IdCreatedOn);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdCreatedOn);
ssIsError = (bool) other.AttributeGet(IdIsError);
ChangedAttributes[5] = other.ChangedAttributeGet(IdIsError);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdIsError);
ssIsForSupplier = (bool) other.AttributeGet(IdIsForSupplier);
ChangedAttributes[6] = other.ChangedAttributeGet(IdIsForSupplier);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdIsForSupplier);
}
} // EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord

/// <summary>
/// RecordList type <code>FolioLogList</code> that represents a record list of <code>FolioLog</code>
/// </summary>
public partial class RL_26de074a1a259636771c9a11cce45c0c : GenericRecordList<EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord>, IEnumerable, IEnumerator {

protected override EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord GetElementDefaultValue() {
return new EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord();
}

public T[] ToArray<T>(Func<EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_26de074a1a259636771c9a11cce45c0c recordList, Func<EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_26de074a1a259636771c9a11cce45c0c(EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord[] array) {
  RL_26de074a1a259636771c9a11cce45c0c result = new RL_26de074a1a259636771c9a11cce45c0c();
result.InnerFromArray(array);
    return result;
}

public static RL_26de074a1a259636771c9a11cce45c0c ToList<T>(T[] array, Func <T, EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord> converter) {
  RL_26de074a1a259636771c9a11cce45c0c result = new RL_26de074a1a259636771c9a11cce45c0c();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_26de074a1a259636771c9a11cce45c0c FromRestList<T>(RestList<T> restList, Func <T, EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord> converter) {
  RL_26de074a1a259636771c9a11cce45c0c result = new RL_26de074a1a259636771c9a11cce45c0c();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_26de074a1a259636771c9a11cce45c0c() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord> NewList() {
return new RL_26de074a1a259636771c9a11cce45c0c();
}


} // RL_26de074a1a259636771c9a11cce45c0c
}
