using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [ReferenceEntity] ManualUserArea (ejmLnzNhXkipxzIDsCvzAQ)
///  <code>EN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord</code> that represent
/// s <code>ManualUserArea</code> <p>Description: Manual User Area</p>
/// </summary>
// Name: ManualUserArea
public partial struct EN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord : ITypedRecord<EN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*TQRn8Acv4kW3KLYHvWy1Ww");
internal static readonly GlobalObjectKey IdManualId = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*U3UfGYeU2UOcldL_jzl+DA");
internal static readonly GlobalObjectKey IdUserAreaId = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*7jF+YiPxL0+kUeKasQJlfQ");

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

private long _ssManualId;
public long ssManualId{
  get{
      return _ssManualId;
  }
  set{
      if((_ssManualId!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssManualId = value;
      }
  }
}

private int _ssUserAreaId;
public int ssUserAreaId{
  get{
      return _ssUserAreaId;
  }
  set{
      if((_ssUserAreaId!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssUserAreaId = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord() {
ChangedAttributes = new BitArray(3,true);
OptimizedAttributes = new BitArray(3,false);
_ssId = 0L;
_ssManualId = 0L;
_ssUserAreaId = 0;
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
ssId = r.ReadLongInteger(index++, "ManualUserArea.Id", 0L);
ssManualId = r.ReadEntityReferenceLongInteger(index++, "ManualUserArea.ManualId", 0L);
ssUserAreaId = r.ReadEntityReference(index++, "ManualUserArea.UserAreaId", 0);
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
public void ReadIM(EN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord r) {
this = r;
}


public static bool operator == (EN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord a, EN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssManualId != b.ssManualId) return false;
if (a.ssUserAreaId != b.ssUserAreaId) return false;
return true;
}

public static bool operator != (EN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord a, EN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord)) return false;
return (this == (EN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssManualId.GetHashCode()
 ^ ssUserAreaId.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord Duplicate() {
EN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord t;
t._ssId = this._ssId;
t._ssManualId = this._ssManualId;
t._ssUserAreaId = this._ssUserAreaId;
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
} else if (head == "manualid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ManualId")) variable.Value = ssManualId; else variable.Optimized = true;
} else if (head == "userareaid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UserAreaId")) variable.Value = ssUserAreaId; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdManualId)) {
return ChangedAttributes[1];
}
if (key.Equals(IdUserAreaId)) {
return ChangedAttributes[2];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdManualId)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdUserAreaId)) {
return OptimizedAttributes[2];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdManualId) {
return ssManualId;
}
if (key == IdUserAreaId) {
return ssUserAreaId;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdManualId.Key.AsGuid) {
return ssManualId;
}
if (attributeKey == IdUserAreaId.Key.AsGuid) {
return ssUserAreaId;
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
ssManualId = (long) other.AttributeGet(IdManualId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdManualId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdManualId);
ssUserAreaId = (int) other.AttributeGet(IdUserAreaId);
ChangedAttributes[2] = other.ChangedAttributeGet(IdUserAreaId);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdUserAreaId);
}
} // EN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord

/// <summary>
/// RecordList type <code>ManualUserAreaList</code> that represents a record list of
///  <code>ManualUserArea</code>
/// </summary>
public partial class RL_458bf14f2ec8211d16d65dc70fa120ae : GenericRecordList<EN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord>, IEnumerable, IEnumerator {

protected override EN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord GetElementDefaultValue() {
return new EN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord();
}

public T[] ToArray<T>(Func<EN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_458bf14f2ec8211d16d65dc70fa120ae recordList, Func<EN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_458bf14f2ec8211d16d65dc70fa120ae(EN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord[] array) {
  RL_458bf14f2ec8211d16d65dc70fa120ae result = new RL_458bf14f2ec8211d16d65dc70fa120ae();
result.InnerFromArray(array);
    return result;
}

public static RL_458bf14f2ec8211d16d65dc70fa120ae ToList<T>(T[] array, Func <T, EN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord> converter) {
  RL_458bf14f2ec8211d16d65dc70fa120ae result = new RL_458bf14f2ec8211d16d65dc70fa120ae();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_458bf14f2ec8211d16d65dc70fa120ae FromRestList<T>(RestList<T> restList, Func <T, EN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord> converter) {
  RL_458bf14f2ec8211d16d65dc70fa120ae result = new RL_458bf14f2ec8211d16d65dc70fa120ae();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_458bf14f2ec8211d16d65dc70fa120ae() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord> NewList() {
return new RL_458bf14f2ec8211d16d65dc70fa120ae();
}


} // RL_458bf14f2ec8211d16d65dc70fa120ae
}
