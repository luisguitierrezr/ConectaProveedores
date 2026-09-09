using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {

/// <summary>
/// [ReferenceEntity] VirtualStore (zttSdPUqeke0ERAvMeya2g)
///  <code>EN_7880828d2b18947e22126c6c81b5d72dEntityRecord</code> that represent
/// s <code>VirtualStore</code> <p>Description: VirtualStore Code by Region</p>
/// </summary>
// Name: VirtualStore
public partial struct EN_7880828d2b18947e22126c6c81b5d72dEntityRecord : ITypedRecord<EN_7880828d2b18947e22126c6c81b5d72dEntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*tqrym2an3EWI+hX8kVaVAg");
internal static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*KaQBAGV4jU2K3wyxgVW5Qg");
internal static readonly GlobalObjectKey IdRegionId = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*dbSGJpDHMEmuO3K6Oc5tEw");

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

private string _ssName;
public string ssName{
  get{
      return _ssName;
  }
  set{
      if((_ssName!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssName = value;
      }
  }
}

private long _ssRegionId;
public long ssRegionId{
  get{
      return _ssRegionId;
  }
  set{
      if((_ssRegionId!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssRegionId = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_7880828d2b18947e22126c6c81b5d72dEntityRecord() {
ChangedAttributes = new BitArray(3,true);
OptimizedAttributes = new BitArray(3,false);
_ssId = 0L;
_ssName = "";
_ssRegionId = 0L;
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
ssId = r.ReadLongInteger(index++, "VirtualStore.Id", 0L);
ssName = r.ReadText(index++, "VirtualStore.Name", "");
ssRegionId = r.ReadEntityReferenceLongInteger(index++, "VirtualStore.RegionId", 0L);
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
public void ReadIM(EN_7880828d2b18947e22126c6c81b5d72dEntityRecord r) {
this = r;
}


public static bool operator == (EN_7880828d2b18947e22126c6c81b5d72dEntityRecord a, EN_7880828d2b18947e22126c6c81b5d72dEntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssName != b.ssName) return false;
if (a.ssRegionId != b.ssRegionId) return false;
return true;
}

public static bool operator != (EN_7880828d2b18947e22126c6c81b5d72dEntityRecord a, EN_7880828d2b18947e22126c6c81b5d72dEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_7880828d2b18947e22126c6c81b5d72dEntityRecord)) return false;
return (this == (EN_7880828d2b18947e22126c6c81b5d72dEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssName.GetHashCode()
 ^ ssRegionId.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_7880828d2b18947e22126c6c81b5d72dEntityRecord Duplicate() {
EN_7880828d2b18947e22126c6c81b5d72dEntityRecord t;
t._ssId = this._ssId;
t._ssName = this._ssName;
t._ssRegionId = this._ssRegionId;
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
} else if (head == "name") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Name")) variable.Value = ssName; else variable.Optimized = true;
} else if (head == "regionid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RegionId")) variable.Value = ssRegionId; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdName)) {
return ChangedAttributes[1];
}
if (key.Equals(IdRegionId)) {
return ChangedAttributes[2];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdName)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdRegionId)) {
return OptimizedAttributes[2];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdName) {
return ssName;
}
if (key == IdRegionId) {
return ssRegionId;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdName.Key.AsGuid) {
return ssName;
}
if (attributeKey == IdRegionId.Key.AsGuid) {
return ssRegionId;
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
ssName = (string) other.AttributeGet(IdName);
ChangedAttributes[1] = other.ChangedAttributeGet(IdName);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdName);
ssRegionId = (long) other.AttributeGet(IdRegionId);
ChangedAttributes[2] = other.ChangedAttributeGet(IdRegionId);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdRegionId);
}
} // EN_7880828d2b18947e22126c6c81b5d72dEntityRecord

/// <summary>
/// RecordList type <code>VirtualStoreList</code> that represents a record list of
///  <code>VirtualStore</code>
/// </summary>
public partial class RL_0151b2e31635fe5d8cb478ab85a04553 : GenericRecordList<EN_7880828d2b18947e22126c6c81b5d72dEntityRecord>, IEnumerable, IEnumerator {

protected override EN_7880828d2b18947e22126c6c81b5d72dEntityRecord GetElementDefaultValue() {
return new EN_7880828d2b18947e22126c6c81b5d72dEntityRecord();
}

public T[] ToArray<T>(Func<EN_7880828d2b18947e22126c6c81b5d72dEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_0151b2e31635fe5d8cb478ab85a04553 recordList, Func<EN_7880828d2b18947e22126c6c81b5d72dEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_0151b2e31635fe5d8cb478ab85a04553(EN_7880828d2b18947e22126c6c81b5d72dEntityRecord[] array) {
  RL_0151b2e31635fe5d8cb478ab85a04553 result = new RL_0151b2e31635fe5d8cb478ab85a04553();
result.InnerFromArray(array);
    return result;
}

public static RL_0151b2e31635fe5d8cb478ab85a04553 ToList<T>(T[] array, Func <T, EN_7880828d2b18947e22126c6c81b5d72dEntityRecord> converter) {
  RL_0151b2e31635fe5d8cb478ab85a04553 result = new RL_0151b2e31635fe5d8cb478ab85a04553();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_0151b2e31635fe5d8cb478ab85a04553 FromRestList<T>(RestList<T> restList, Func <T, EN_7880828d2b18947e22126c6c81b5d72dEntityRecord> converter) {
  RL_0151b2e31635fe5d8cb478ab85a04553 result = new RL_0151b2e31635fe5d8cb478ab85a04553();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_0151b2e31635fe5d8cb478ab85a04553() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_7880828d2b18947e22126c6c81b5d72dEntityRecord> NewList() {
return new RL_0151b2e31635fe5d8cb478ab85a04553();
}


} // RL_0151b2e31635fe5d8cb478ab85a04553
}
