using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] RequisitionVersion (aIb6htE2yUyTxK6vLiv3Kw)
///  <code>EN_74284c742ed8c8eb5a05978b570ef620EntityRecord</code> that represent
/// s <code>RequisitionVersion</code> <p>Description: </p>
/// </summary>
// Name: RequisitionVersion
public partial struct EN_74284c742ed8c8eb5a05978b570ef620EntityRecord : ITypedRecord<EN_74284c742ed8c8eb5a05978b570ef620EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*i9L5xtlkeUOJrZ2igdCPEg");
internal static readonly GlobalObjectKey IdOriginalRequisitionId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Muxit6JVLkiil3dbPNjIcg");
internal static readonly GlobalObjectKey IdNewRequisitionId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*7Kd9jGdeukqtNlIkio0Meg");
internal static readonly GlobalObjectKey IdVersion = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*X69qokC78EGtZCWJeEl6QA");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(4,true);
          _ssId = value;
      }
  }
}

private long _ssOriginalRequisitionId;
public long ssOriginalRequisitionId{
  get{
      return _ssOriginalRequisitionId;
  }
  set{
      if((_ssOriginalRequisitionId!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssOriginalRequisitionId = value;
      }
  }
}

private long _ssNewRequisitionId;
public long ssNewRequisitionId{
  get{
      return _ssNewRequisitionId;
  }
  set{
      if((_ssNewRequisitionId!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssNewRequisitionId = value;
      }
  }
}

private int _ssVersion;
public int ssVersion{
  get{
      return _ssVersion;
  }
  set{
      if((_ssVersion!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssVersion = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_74284c742ed8c8eb5a05978b570ef620EntityRecord() {
ChangedAttributes = new BitArray(4,true);
OptimizedAttributes = new BitArray(4,false);
_ssId = 0L;
_ssOriginalRequisitionId = 0L;
_ssNewRequisitionId = 0L;
_ssVersion = 0;
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
ssId = r.ReadLongInteger(index++, "RequisitionVersion.Id", 0L);
ssOriginalRequisitionId = r.ReadEntityReferenceLongInteger(index++, "RequisitionVersion.OriginalRequisitionId", 0L);
ssNewRequisitionId = r.ReadEntityReferenceLongInteger(index++, "RequisitionVersion.NewRequisitionId", 0L);
ssVersion = r.ReadInteger(index++, "RequisitionVersion.Version", 0);
ChangedAttributes = new BitArray(4,false);
OptimizedAttributes = new BitArray(4,false);
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
public void ReadIM(EN_74284c742ed8c8eb5a05978b570ef620EntityRecord r) {
this = r;
}


public static bool operator == (EN_74284c742ed8c8eb5a05978b570ef620EntityRecord a, EN_74284c742ed8c8eb5a05978b570ef620EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssOriginalRequisitionId != b.ssOriginalRequisitionId) return false;
if (a.ssNewRequisitionId != b.ssNewRequisitionId) return false;
if (a.ssVersion != b.ssVersion) return false;
return true;
}

public static bool operator != (EN_74284c742ed8c8eb5a05978b570ef620EntityRecord a, EN_74284c742ed8c8eb5a05978b570ef620EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_74284c742ed8c8eb5a05978b570ef620EntityRecord)) return false;
return (this == (EN_74284c742ed8c8eb5a05978b570ef620EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssOriginalRequisitionId.GetHashCode()
 ^ ssNewRequisitionId.GetHashCode()
 ^ ssVersion.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_74284c742ed8c8eb5a05978b570ef620EntityRecord Duplicate() {
EN_74284c742ed8c8eb5a05978b570ef620EntityRecord t;
t._ssId = this._ssId;
t._ssOriginalRequisitionId = this._ssOriginalRequisitionId;
t._ssNewRequisitionId = this._ssNewRequisitionId;
t._ssVersion = this._ssVersion;
t.ChangedAttributes = new BitArray(4);
t.OptimizedAttributes = new BitArray(4);
for(int i = 0; i < 4; i++){
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
} else if (head == "originalrequisitionid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OriginalRequisitionId")) variable.Value = ssOriginalRequisitionId; else variable.Optimized = true;
} else if (head == "newrequisitionid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".NewRequisitionId")) variable.Value = ssNewRequisitionId; else variable.Optimized = true;
} else if (head == "version") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Version")) variable.Value = ssVersion; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdOriginalRequisitionId)) {
return ChangedAttributes[1];
}
if (key.Equals(IdNewRequisitionId)) {
return ChangedAttributes[2];
}
if (key.Equals(IdVersion)) {
return ChangedAttributes[3];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdOriginalRequisitionId)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdNewRequisitionId)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdVersion)) {
return OptimizedAttributes[3];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdOriginalRequisitionId) {
return ssOriginalRequisitionId;
}
if (key == IdNewRequisitionId) {
return ssNewRequisitionId;
}
if (key == IdVersion) {
return ssVersion;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdOriginalRequisitionId.Key.AsGuid) {
return ssOriginalRequisitionId;
}
if (attributeKey == IdNewRequisitionId.Key.AsGuid) {
return ssNewRequisitionId;
}
if (attributeKey == IdVersion.Key.AsGuid) {
return ssVersion;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(4);
OptimizedAttributes = new BitArray(4);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssOriginalRequisitionId = (long) other.AttributeGet(IdOriginalRequisitionId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdOriginalRequisitionId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdOriginalRequisitionId);
ssNewRequisitionId = (long) other.AttributeGet(IdNewRequisitionId);
ChangedAttributes[2] = other.ChangedAttributeGet(IdNewRequisitionId);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdNewRequisitionId);
ssVersion = (int) other.AttributeGet(IdVersion);
ChangedAttributes[3] = other.ChangedAttributeGet(IdVersion);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdVersion);
}
} // EN_74284c742ed8c8eb5a05978b570ef620EntityRecord

/// <summary>
/// RecordList type <code>RequisitionVersionList</code> that represents a record list of
///  <code>RequisitionVersion</code>
/// </summary>
public partial class RL_3285715753a0dd31cdefa485a928aad2 : GenericRecordList<EN_74284c742ed8c8eb5a05978b570ef620EntityRecord>, IEnumerable, IEnumerator {

protected override EN_74284c742ed8c8eb5a05978b570ef620EntityRecord GetElementDefaultValue() {
return new EN_74284c742ed8c8eb5a05978b570ef620EntityRecord();
}

public T[] ToArray<T>(Func<EN_74284c742ed8c8eb5a05978b570ef620EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_3285715753a0dd31cdefa485a928aad2 recordList, Func<EN_74284c742ed8c8eb5a05978b570ef620EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_3285715753a0dd31cdefa485a928aad2(EN_74284c742ed8c8eb5a05978b570ef620EntityRecord[] array) {
  RL_3285715753a0dd31cdefa485a928aad2 result = new RL_3285715753a0dd31cdefa485a928aad2();
result.InnerFromArray(array);
    return result;
}

public static RL_3285715753a0dd31cdefa485a928aad2 ToList<T>(T[] array, Func <T, EN_74284c742ed8c8eb5a05978b570ef620EntityRecord> converter) {
  RL_3285715753a0dd31cdefa485a928aad2 result = new RL_3285715753a0dd31cdefa485a928aad2();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_3285715753a0dd31cdefa485a928aad2 FromRestList<T>(RestList<T> restList, Func <T, EN_74284c742ed8c8eb5a05978b570ef620EntityRecord> converter) {
  RL_3285715753a0dd31cdefa485a928aad2 result = new RL_3285715753a0dd31cdefa485a928aad2();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_3285715753a0dd31cdefa485a928aad2() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_74284c742ed8c8eb5a05978b570ef620EntityRecord> NewList() {
return new RL_3285715753a0dd31cdefa485a928aad2();
}


} // RL_3285715753a0dd31cdefa485a928aad2
}
