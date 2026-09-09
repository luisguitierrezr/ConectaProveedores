using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] InvoicePolizaStorage (+imvmI_T5E2tkwLX4M_5Mg)
///  <code>EN_c914a6fdb165c9751808adf2e01e2226EntityRecord</code> that represent
/// s <code>InvoicePolizaStorage</code> <p>Description: Poliza Flow</p>
/// </summary>
// Name: InvoicePolizaStorage
public partial struct EN_c914a6fdb165c9751808adf2e01e2226EntityRecord : ITypedRecord<EN_c914a6fdb165c9751808adf2e01e2226EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*wz3KRe_q5kOjwFKPFSRhmg");
internal static readonly GlobalObjectKey IdPolizaFlowId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*O4awQ7rxnkCcVVQP3JZtMg");
internal static readonly GlobalObjectKey IdStorageId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*gQ38w7hyzUmaHOvWybDsyw");

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

private long _ssPolizaFlowId;
public long ssPolizaFlowId{
  get{
      return _ssPolizaFlowId;
  }
  set{
      if((_ssPolizaFlowId!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssPolizaFlowId = value;
      }
  }
}

private long _ssStorageId;
public long ssStorageId{
  get{
      return _ssStorageId;
  }
  set{
      if((_ssStorageId!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssStorageId = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_c914a6fdb165c9751808adf2e01e2226EntityRecord() {
ChangedAttributes = new BitArray(3,true);
OptimizedAttributes = new BitArray(3,false);
_ssId = 0L;
_ssPolizaFlowId = 0L;
_ssStorageId = 0L;
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
ssId = r.ReadLongInteger(index++, "InvoicePolizaStorage.Id", 0L);
ssPolizaFlowId = r.ReadEntityReferenceLongInteger(index++, "InvoicePolizaStorage.PolizaFlowId", 0L);
ssStorageId = r.ReadEntityReferenceLongInteger(index++, "InvoicePolizaStorage.StorageId", 0L);
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
public void ReadIM(EN_c914a6fdb165c9751808adf2e01e2226EntityRecord r) {
this = r;
}


public static bool operator == (EN_c914a6fdb165c9751808adf2e01e2226EntityRecord a, EN_c914a6fdb165c9751808adf2e01e2226EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssPolizaFlowId != b.ssPolizaFlowId) return false;
if (a.ssStorageId != b.ssStorageId) return false;
return true;
}

public static bool operator != (EN_c914a6fdb165c9751808adf2e01e2226EntityRecord a, EN_c914a6fdb165c9751808adf2e01e2226EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_c914a6fdb165c9751808adf2e01e2226EntityRecord)) return false;
return (this == (EN_c914a6fdb165c9751808adf2e01e2226EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssPolizaFlowId.GetHashCode()
 ^ ssStorageId.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_c914a6fdb165c9751808adf2e01e2226EntityRecord Duplicate() {
EN_c914a6fdb165c9751808adf2e01e2226EntityRecord t;
t._ssId = this._ssId;
t._ssPolizaFlowId = this._ssPolizaFlowId;
t._ssStorageId = this._ssStorageId;
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
} else if (head == "polizaflowid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PolizaFlowId")) variable.Value = ssPolizaFlowId; else variable.Optimized = true;
} else if (head == "storageid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".StorageId")) variable.Value = ssStorageId; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdPolizaFlowId)) {
return ChangedAttributes[1];
}
if (key.Equals(IdStorageId)) {
return ChangedAttributes[2];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdPolizaFlowId)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdStorageId)) {
return OptimizedAttributes[2];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdPolizaFlowId) {
return ssPolizaFlowId;
}
if (key == IdStorageId) {
return ssStorageId;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdPolizaFlowId.Key.AsGuid) {
return ssPolizaFlowId;
}
if (attributeKey == IdStorageId.Key.AsGuid) {
return ssStorageId;
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
ssPolizaFlowId = (long) other.AttributeGet(IdPolizaFlowId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdPolizaFlowId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdPolizaFlowId);
ssStorageId = (long) other.AttributeGet(IdStorageId);
ChangedAttributes[2] = other.ChangedAttributeGet(IdStorageId);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdStorageId);
}
} // EN_c914a6fdb165c9751808adf2e01e2226EntityRecord

/// <summary>
/// RecordList type <code>InvoicePolizaStorageList</code> that represents a record list of
///  <code>InvoicePolizaStorage</code>
/// </summary>
public partial class RL_77db23e52fb5d710e8f2c434dd0a125b : GenericRecordList<EN_c914a6fdb165c9751808adf2e01e2226EntityRecord>, IEnumerable, IEnumerator {

protected override EN_c914a6fdb165c9751808adf2e01e2226EntityRecord GetElementDefaultValue() {
return new EN_c914a6fdb165c9751808adf2e01e2226EntityRecord();
}

public T[] ToArray<T>(Func<EN_c914a6fdb165c9751808adf2e01e2226EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_77db23e52fb5d710e8f2c434dd0a125b recordList, Func<EN_c914a6fdb165c9751808adf2e01e2226EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_77db23e52fb5d710e8f2c434dd0a125b(EN_c914a6fdb165c9751808adf2e01e2226EntityRecord[] array) {
  RL_77db23e52fb5d710e8f2c434dd0a125b result = new RL_77db23e52fb5d710e8f2c434dd0a125b();
result.InnerFromArray(array);
    return result;
}

public static RL_77db23e52fb5d710e8f2c434dd0a125b ToList<T>(T[] array, Func <T, EN_c914a6fdb165c9751808adf2e01e2226EntityRecord> converter) {
  RL_77db23e52fb5d710e8f2c434dd0a125b result = new RL_77db23e52fb5d710e8f2c434dd0a125b();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_77db23e52fb5d710e8f2c434dd0a125b FromRestList<T>(RestList<T> restList, Func <T, EN_c914a6fdb165c9751808adf2e01e2226EntityRecord> converter) {
  RL_77db23e52fb5d710e8f2c434dd0a125b result = new RL_77db23e52fb5d710e8f2c434dd0a125b();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_77db23e52fb5d710e8f2c434dd0a125b() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_c914a6fdb165c9751808adf2e01e2226EntityRecord> NewList() {
return new RL_77db23e52fb5d710e8f2c434dd0a125b();
}


} // RL_77db23e52fb5d710e8f2c434dd0a125b
}
