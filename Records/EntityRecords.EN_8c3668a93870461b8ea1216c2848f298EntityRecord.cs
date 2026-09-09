using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] OrdersImportRequest (c7lAIC7Clk2YNBzzJJr8rg)
///  <code>EN_8c3668a93870461b8ea1216c2848f298EntityRecord</code> that represent
/// s <code>OrdersImportRequest</code> <p>Description: </p>
/// </summary>
// Name: OrdersImportRequest
public partial struct EN_8c3668a93870461b8ea1216c2848f298EntityRecord : ITypedRecord<EN_8c3668a93870461b8ea1216c2848f298EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*OH+jY5x_tEKIvAKn7JxW_Q");
internal static readonly GlobalObjectKey IdOrigin = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*aIUgLRcmpU+uxxa6BllPxg");
internal static readonly GlobalObjectKey IdImportedData = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*1jg1sj_Ao0Kl3j204QgaAg");
internal static readonly GlobalObjectKey IdOrderMainId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Ve9JeysLDECGsqBj_9Jx7w");
internal static readonly GlobalObjectKey IdStatus = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*S+Ka5phkHk25m4kODYNaWA");
internal static readonly GlobalObjectKey IdLastRowNumberRead = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*t6tN3evHi0iN_OhC1OMSLQ");
internal static readonly GlobalObjectKey IdRowsWithError = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*ZYyjXbhG2k+bHAp7ZzinJA");
internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*mHmtVILnOUuehJQZcZkcjg");
internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*BHtgXgC9kkmtaxDtp8MWaA");
internal static readonly GlobalObjectKey IdUpdatedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*noQvYrBYJEuKNQobpXvUdQ");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(10,true);
          _ssId = value;
      }
  }
}

private string _ssOrigin;
public string ssOrigin{
  get{
      return _ssOrigin;
  }
  set{
      if((_ssOrigin!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssOrigin = value;
      }
  }
}

private byte[] _ssImportedData;
public byte[] ssImportedData{
  get{
      return _ssImportedData;
  }
  set{
      if((_ssImportedData!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssImportedData = value;
      }
  }
}

private long _ssOrderMainId;
public long ssOrderMainId{
  get{
      return _ssOrderMainId;
  }
  set{
      if((_ssOrderMainId!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssOrderMainId = value;
      }
  }
}

private int _ssStatus;
public int ssStatus{
  get{
      return _ssStatus;
  }
  set{
      if((_ssStatus!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssStatus = value;
      }
  }
}

private int _ssLastRowNumberRead;
public int ssLastRowNumberRead{
  get{
      return _ssLastRowNumberRead;
  }
  set{
      if((_ssLastRowNumberRead!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssLastRowNumberRead = value;
      }
  }
}

private string _ssRowsWithError;
public string ssRowsWithError{
  get{
      return _ssRowsWithError;
  }
  set{
      if((_ssRowsWithError!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssRowsWithError = value;
      }
  }
}

private string _ssCreatedBy;
public string ssCreatedBy{
  get{
      return _ssCreatedBy;
  }
  set{
      if((_ssCreatedBy!=value) || OptimizedAttributes[7]){
          ChangedAttributes[7] = true;
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
      if((_ssCreatedOn!=value) || OptimizedAttributes[8]){
          ChangedAttributes[8] = true;
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
      if((_ssUpdatedOn!=value) || OptimizedAttributes[9]){
          ChangedAttributes[9] = true;
          _ssUpdatedOn = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_8c3668a93870461b8ea1216c2848f298EntityRecord() {
ChangedAttributes = new BitArray(10,true);
OptimizedAttributes = new BitArray(10,false);
_ssId = 0L;
_ssOrigin = "";
_ssImportedData = new byte[] {};
_ssOrderMainId = 0L;
_ssStatus = 0;
_ssLastRowNumberRead = 0;
_ssRowsWithError = "";
_ssCreatedBy = "";
_ssCreatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
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
ssId = r.ReadLongInteger(index++, "OrdersImportRequest.Id", 0L);
ssOrigin = r.ReadText(index++, "OrdersImportRequest.Origin", "");
ssImportedData = r.ReadBinaryData(index++, "OrdersImportRequest.ImportedData", new byte[] {});
ssOrderMainId = r.ReadEntityReferenceLongInteger(index++, "OrdersImportRequest.OrderMainId", 0L);
ssStatus = r.ReadEntityReference(index++, "OrdersImportRequest.Status", 0);
ssLastRowNumberRead = r.ReadInteger(index++, "OrdersImportRequest.LastRowNumberRead", 0);
ssRowsWithError = r.ReadText(index++, "OrdersImportRequest.RowsWithError", "");
ssCreatedBy = r.ReadEntityReferenceText(index++, "OrdersImportRequest.CreatedBy", "");
ssCreatedOn = r.ReadDateTime(index++, "OrdersImportRequest.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssUpdatedOn = r.ReadDateTime(index++, "OrdersImportRequest.UpdatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ChangedAttributes = new BitArray(10,false);
OptimizedAttributes = new BitArray(10,false);
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
public void ReadIM(EN_8c3668a93870461b8ea1216c2848f298EntityRecord r) {
this = r;
}


public static bool operator == (EN_8c3668a93870461b8ea1216c2848f298EntityRecord a, EN_8c3668a93870461b8ea1216c2848f298EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssOrigin != b.ssOrigin) return false;
if (!RuntimePlatformUtils.CompareByteArrays(a.ssImportedData, b.ssImportedData)) return false;
if (a.ssOrderMainId != b.ssOrderMainId) return false;
if (a.ssStatus != b.ssStatus) return false;
if (a.ssLastRowNumberRead != b.ssLastRowNumberRead) return false;
if (a.ssRowsWithError != b.ssRowsWithError) return false;
if (a.ssCreatedBy != b.ssCreatedBy) return false;
if (a.ssCreatedOn != b.ssCreatedOn) return false;
if (a.ssUpdatedOn != b.ssUpdatedOn) return false;
return true;
}

public static bool operator != (EN_8c3668a93870461b8ea1216c2848f298EntityRecord a, EN_8c3668a93870461b8ea1216c2848f298EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_8c3668a93870461b8ea1216c2848f298EntityRecord)) return false;
return (this == (EN_8c3668a93870461b8ea1216c2848f298EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssOrigin.GetHashCode()
 ^ ssImportedData.GetHashCode()
 ^ ssOrderMainId.GetHashCode()
 ^ ssStatus.GetHashCode()
 ^ ssLastRowNumberRead.GetHashCode()
 ^ ssRowsWithError.GetHashCode()
 ^ ssCreatedBy.GetHashCode()
 ^ ssCreatedOn.GetHashCode()
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


public EN_8c3668a93870461b8ea1216c2848f298EntityRecord Duplicate() {
EN_8c3668a93870461b8ea1216c2848f298EntityRecord t;
t._ssId = this._ssId;
t._ssOrigin = this._ssOrigin;
t._ssImportedData = this._ssImportedData;
t._ssOrderMainId = this._ssOrderMainId;
t._ssStatus = this._ssStatus;
t._ssLastRowNumberRead = this._ssLastRowNumberRead;
t._ssRowsWithError = this._ssRowsWithError;
t._ssCreatedBy = this._ssCreatedBy;
t._ssCreatedOn = this._ssCreatedOn;
t._ssUpdatedOn = this._ssUpdatedOn;
t.ChangedAttributes = new BitArray(10);
t.OptimizedAttributes = new BitArray(10);
for(int i = 0; i < 10; i++){
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
} else if (head == "origin") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Origin")) variable.Value = ssOrigin; else variable.Optimized = true;
} else if (head == "importeddata") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ImportedData")) variable.Value = ssImportedData; else variable.Optimized = true;
} else if (head == "ordermainid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMainId")) variable.Value = ssOrderMainId; else variable.Optimized = true;
} else if (head == "status") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Status")) variable.Value = ssStatus; else variable.Optimized = true;
} else if (head == "lastrownumberread") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".LastRowNumberRead")) variable.Value = ssLastRowNumberRead; else variable.Optimized = true;
} else if (head == "rowswitherror") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RowsWithError")) variable.Value = ssRowsWithError; else variable.Optimized = true;
} else if (head == "createdby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedBy")) variable.Value = ssCreatedBy; else variable.Optimized = true;
} else if (head == "createdon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedOn")) variable.Value = ssCreatedOn; else variable.Optimized = true;
} else if (head == "updatedon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdatedOn")) variable.Value = ssUpdatedOn; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdOrigin)) {
return ChangedAttributes[1];
}
if (key.Equals(IdImportedData)) {
return ChangedAttributes[2];
}
if (key.Equals(IdOrderMainId)) {
return ChangedAttributes[3];
}
if (key.Equals(IdStatus)) {
return ChangedAttributes[4];
}
if (key.Equals(IdLastRowNumberRead)) {
return ChangedAttributes[5];
}
if (key.Equals(IdRowsWithError)) {
return ChangedAttributes[6];
}
if (key.Equals(IdCreatedBy)) {
return ChangedAttributes[7];
}
if (key.Equals(IdCreatedOn)) {
return ChangedAttributes[8];
}
if (key.Equals(IdUpdatedOn)) {
return ChangedAttributes[9];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdOrigin)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdImportedData)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdOrderMainId)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdStatus)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdLastRowNumberRead)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdRowsWithError)) {
return OptimizedAttributes[6];
}
if (key.Equals(IdCreatedBy)) {
return OptimizedAttributes[7];
}
if (key.Equals(IdCreatedOn)) {
return OptimizedAttributes[8];
}
if (key.Equals(IdUpdatedOn)) {
return OptimizedAttributes[9];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdOrigin) {
return ssOrigin;
}
if (key == IdImportedData) {
return ssImportedData;
}
if (key == IdOrderMainId) {
return ssOrderMainId;
}
if (key == IdStatus) {
return ssStatus;
}
if (key == IdLastRowNumberRead) {
return ssLastRowNumberRead;
}
if (key == IdRowsWithError) {
return ssRowsWithError;
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
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdOrigin.Key.AsGuid) {
return ssOrigin;
}
if (attributeKey == IdImportedData.Key.AsGuid) {
return ssImportedData;
}
if (attributeKey == IdOrderMainId.Key.AsGuid) {
return ssOrderMainId;
}
if (attributeKey == IdStatus.Key.AsGuid) {
return ssStatus;
}
if (attributeKey == IdLastRowNumberRead.Key.AsGuid) {
return ssLastRowNumberRead;
}
if (attributeKey == IdRowsWithError.Key.AsGuid) {
return ssRowsWithError;
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
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(10);
OptimizedAttributes = new BitArray(10);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssOrigin = (string) other.AttributeGet(IdOrigin);
ChangedAttributes[1] = other.ChangedAttributeGet(IdOrigin);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdOrigin);
ssImportedData = (byte[]) other.AttributeGet(IdImportedData);
ChangedAttributes[2] = other.ChangedAttributeGet(IdImportedData);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdImportedData);
ssOrderMainId = (long) other.AttributeGet(IdOrderMainId);
ChangedAttributes[3] = other.ChangedAttributeGet(IdOrderMainId);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdOrderMainId);
ssStatus = (int) other.AttributeGet(IdStatus);
ChangedAttributes[4] = other.ChangedAttributeGet(IdStatus);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdStatus);
ssLastRowNumberRead = (int) other.AttributeGet(IdLastRowNumberRead);
ChangedAttributes[5] = other.ChangedAttributeGet(IdLastRowNumberRead);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdLastRowNumberRead);
ssRowsWithError = (string) other.AttributeGet(IdRowsWithError);
ChangedAttributes[6] = other.ChangedAttributeGet(IdRowsWithError);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdRowsWithError);
ssCreatedBy = (string) other.AttributeGet(IdCreatedBy);
ChangedAttributes[7] = other.ChangedAttributeGet(IdCreatedBy);
OptimizedAttributes[7] = other.OptimizedAttributeGet(IdCreatedBy);
ssCreatedOn = (DateTime) other.AttributeGet(IdCreatedOn);
ChangedAttributes[8] = other.ChangedAttributeGet(IdCreatedOn);
OptimizedAttributes[8] = other.OptimizedAttributeGet(IdCreatedOn);
ssUpdatedOn = (DateTime) other.AttributeGet(IdUpdatedOn);
ChangedAttributes[9] = other.ChangedAttributeGet(IdUpdatedOn);
OptimizedAttributes[9] = other.OptimizedAttributeGet(IdUpdatedOn);
}
} // EN_8c3668a93870461b8ea1216c2848f298EntityRecord

/// <summary>
/// RecordList type <code>OrdersImportRequestList</code> that represents a record list of
///  <code>OrdersImportRequest</code>
/// </summary>
public partial class RL_4663bec3bb05846156db74f270456ed0 : GenericRecordList<EN_8c3668a93870461b8ea1216c2848f298EntityRecord>, IEnumerable, IEnumerator {

protected override EN_8c3668a93870461b8ea1216c2848f298EntityRecord GetElementDefaultValue() {
return new EN_8c3668a93870461b8ea1216c2848f298EntityRecord();
}

public T[] ToArray<T>(Func<EN_8c3668a93870461b8ea1216c2848f298EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_4663bec3bb05846156db74f270456ed0 recordList, Func<EN_8c3668a93870461b8ea1216c2848f298EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_4663bec3bb05846156db74f270456ed0(EN_8c3668a93870461b8ea1216c2848f298EntityRecord[] array) {
  RL_4663bec3bb05846156db74f270456ed0 result = new RL_4663bec3bb05846156db74f270456ed0();
result.InnerFromArray(array);
    return result;
}

public static RL_4663bec3bb05846156db74f270456ed0 ToList<T>(T[] array, Func <T, EN_8c3668a93870461b8ea1216c2848f298EntityRecord> converter) {
  RL_4663bec3bb05846156db74f270456ed0 result = new RL_4663bec3bb05846156db74f270456ed0();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_4663bec3bb05846156db74f270456ed0 FromRestList<T>(RestList<T> restList, Func <T, EN_8c3668a93870461b8ea1216c2848f298EntityRecord> converter) {
  RL_4663bec3bb05846156db74f270456ed0 result = new RL_4663bec3bb05846156db74f270456ed0();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_4663bec3bb05846156db74f270456ed0() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_8c3668a93870461b8ea1216c2848f298EntityRecord> NewList() {
return new RL_4663bec3bb05846156db74f270456ed0();
}


} // RL_4663bec3bb05846156db74f270456ed0
}
