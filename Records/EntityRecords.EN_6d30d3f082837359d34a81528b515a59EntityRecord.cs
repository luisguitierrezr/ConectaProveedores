using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] FolioRegionSeq (zCSyOzb8XEy2CRpto_SNHw)
///  <code>EN_6d30d3f082837359d34a81528b515a59EntityRecord</code> that represent
/// s <code>FolioRegionSeq</code> <p>Description: </p>
/// </summary>
// Name: FolioRegionSeq
public partial struct EN_6d30d3f082837359d34a81528b515a59EntityRecord : ITypedRecord<EN_6d30d3f082837359d34a81528b515a59EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*qouFfDXUFU65TnOiu1NI5w");
internal static readonly GlobalObjectKey IdRegionId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*bZYQyFLuiEWdPwsaMLU7iA");
internal static readonly GlobalObjectKey IdSeqValue = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*TXG5R8Ayp0OBfqvK38nZtw");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(3,true);
          _ssId = value;
      }
  }
}

private long _ssRegionId;
public long ssRegionId{
  get{
      return _ssRegionId;
  }
  set{
      if((_ssRegionId!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssRegionId = value;
      }
  }
}

private int _ssSeqValue;
public int ssSeqValue{
  get{
      return _ssSeqValue;
  }
  set{
      if((_ssSeqValue!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssSeqValue = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_6d30d3f082837359d34a81528b515a59EntityRecord() {
ChangedAttributes = new BitArray(3,true);
OptimizedAttributes = new BitArray(3,false);
_ssId = 0L;
_ssRegionId = 0L;
_ssSeqValue = 0;
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
ssId = r.ReadLongInteger(index++, "FolioRegionSeq.Id", 0L);
ssRegionId = r.ReadEntityReferenceLongInteger(index++, "FolioRegionSeq.RegionId", 0L);
ssSeqValue = r.ReadInteger(index++, "FolioRegionSeq.SeqValue", 0);
ChangedAttributes = new BitArray(3,false);
OptimizedAttributes = new BitArray(3,false);
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
public void ReadIM(EN_6d30d3f082837359d34a81528b515a59EntityRecord r) {
this = r;
}


public static bool operator == (EN_6d30d3f082837359d34a81528b515a59EntityRecord a, EN_6d30d3f082837359d34a81528b515a59EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssRegionId != b.ssRegionId) return false;
if (a.ssSeqValue != b.ssSeqValue) return false;
return true;
}

public static bool operator != (EN_6d30d3f082837359d34a81528b515a59EntityRecord a, EN_6d30d3f082837359d34a81528b515a59EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_6d30d3f082837359d34a81528b515a59EntityRecord)) return false;
return (this == (EN_6d30d3f082837359d34a81528b515a59EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssRegionId.GetHashCode()
 ^ ssSeqValue.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_6d30d3f082837359d34a81528b515a59EntityRecord Duplicate() {
EN_6d30d3f082837359d34a81528b515a59EntityRecord t;
t._ssId = this._ssId;
t._ssRegionId = this._ssRegionId;
t._ssSeqValue = this._ssSeqValue;
t.ChangedAttributes = new BitArray(3);
t.OptimizedAttributes = new BitArray(3);
for(int i = 0; i < 3; i++){
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
} else if (head == "regionid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RegionId")) variable.Value = ssRegionId; else variable.Optimized = true;
} else if (head == "seqvalue") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SeqValue")) variable.Value = ssSeqValue; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdRegionId)) {
return ChangedAttributes[1];
}
if (key.Equals(IdSeqValue)) {
return ChangedAttributes[2];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdRegionId)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdSeqValue)) {
return OptimizedAttributes[2];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdRegionId) {
return ssRegionId;
}
if (key == IdSeqValue) {
return ssSeqValue;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdRegionId.Key.AsGuid) {
return ssRegionId;
}
if (attributeKey == IdSeqValue.Key.AsGuid) {
return ssSeqValue;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(3);
OptimizedAttributes = new BitArray(3);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssRegionId = (long) other.AttributeGet(IdRegionId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdRegionId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdRegionId);
ssSeqValue = (int) other.AttributeGet(IdSeqValue);
ChangedAttributes[2] = other.ChangedAttributeGet(IdSeqValue);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdSeqValue);
}
} // EN_6d30d3f082837359d34a81528b515a59EntityRecord

/// <summary>
/// RecordList type <code>FolioRegionSeqList</code> that represents a record list of
///  <code>FolioRegionSeq</code>
/// </summary>
public partial class RL_331b17eb6b90c47be5028143a7afceff : GenericRecordList<EN_6d30d3f082837359d34a81528b515a59EntityRecord>, IEnumerable, IEnumerator {

protected override EN_6d30d3f082837359d34a81528b515a59EntityRecord GetElementDefaultValue() {
return new EN_6d30d3f082837359d34a81528b515a59EntityRecord();
}

public T[] ToArray<T>(Func<EN_6d30d3f082837359d34a81528b515a59EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_331b17eb6b90c47be5028143a7afceff recordList, Func<EN_6d30d3f082837359d34a81528b515a59EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_331b17eb6b90c47be5028143a7afceff(EN_6d30d3f082837359d34a81528b515a59EntityRecord[] array) {
  RL_331b17eb6b90c47be5028143a7afceff result = new RL_331b17eb6b90c47be5028143a7afceff();
result.InnerFromArray(array);
    return result;
}

public static RL_331b17eb6b90c47be5028143a7afceff ToList<T>(T[] array, Func <T, EN_6d30d3f082837359d34a81528b515a59EntityRecord> converter) {
  RL_331b17eb6b90c47be5028143a7afceff result = new RL_331b17eb6b90c47be5028143a7afceff();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_331b17eb6b90c47be5028143a7afceff FromRestList<T>(RestList<T> restList, Func <T, EN_6d30d3f082837359d34a81528b515a59EntityRecord> converter) {
  RL_331b17eb6b90c47be5028143a7afceff result = new RL_331b17eb6b90c47be5028143a7afceff();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_331b17eb6b90c47be5028143a7afceff() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_6d30d3f082837359d34a81528b515a59EntityRecord> NewList() {
return new RL_331b17eb6b90c47be5028143a7afceff();
}


} // RL_331b17eb6b90c47be5028143a7afceff
}
