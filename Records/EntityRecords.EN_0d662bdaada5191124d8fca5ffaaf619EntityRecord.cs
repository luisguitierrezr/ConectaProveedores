using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] InvoiceAccountingProcessLines_F43 (eDFjuvNpGESuuLFtvb8_aA)
///  <code>EN_0d662bdaada5191124d8fca5ffaaf619EntityRecord</code> that represent
/// s <code>InvoiceAccountingProcessLines_F43</code> <p>Description: Saves lines to call accounting for
///  invoice</p>
/// </summary>
// Name: InvoiceAccountingProcessLines_F43
public partial struct EN_0d662bdaada5191124d8fca5ffaaf619EntityRecord : ITypedRecord<EN_0d662bdaada5191124d8fca5ffaaf619EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*D5Ry9yj5W0euRB0ddUkXkA");
internal static readonly GlobalObjectKey IdInvoiceAccounting_ProcessId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*ZhIl4Oom+Ue8hh1QzfupFw");
internal static readonly GlobalObjectKey IdParameter = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Bdf6E5l0U0W_Op2nPUwJlg");

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

private long _ssInvoiceAccounting_ProcessId;
public long ssInvoiceAccounting_ProcessId{
  get{
      return _ssInvoiceAccounting_ProcessId;
  }
  set{
      if((_ssInvoiceAccounting_ProcessId!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssInvoiceAccounting_ProcessId = value;
      }
  }
}

private string _ssParameter;
public string ssParameter{
  get{
      return _ssParameter;
  }
  set{
      if((_ssParameter!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssParameter = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_0d662bdaada5191124d8fca5ffaaf619EntityRecord() {
ChangedAttributes = new BitArray(3,true);
OptimizedAttributes = new BitArray(3,false);
_ssId = 0L;
_ssInvoiceAccounting_ProcessId = 0L;
_ssParameter = "";
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
ssId = r.ReadLongInteger(index++, "InvoiceAccountingProcessLines_F43.Id", 0L);
ssInvoiceAccounting_ProcessId = r.ReadEntityReferenceLongInteger(index++, "InvoiceAccountingProcessLines_F43.InvoiceAccounting_ProcessId", 0L);
ssParameter = r.ReadText(index++, "InvoiceAccountingProcessLines_F43.Parameter", "");
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
public void ReadIM(EN_0d662bdaada5191124d8fca5ffaaf619EntityRecord r) {
this = r;
}


public static bool operator == (EN_0d662bdaada5191124d8fca5ffaaf619EntityRecord a, EN_0d662bdaada5191124d8fca5ffaaf619EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssInvoiceAccounting_ProcessId != b.ssInvoiceAccounting_ProcessId) return false;
if (a.ssParameter != b.ssParameter) return false;
return true;
}

public static bool operator != (EN_0d662bdaada5191124d8fca5ffaaf619EntityRecord a, EN_0d662bdaada5191124d8fca5ffaaf619EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_0d662bdaada5191124d8fca5ffaaf619EntityRecord)) return false;
return (this == (EN_0d662bdaada5191124d8fca5ffaaf619EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssInvoiceAccounting_ProcessId.GetHashCode()
 ^ ssParameter.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_0d662bdaada5191124d8fca5ffaaf619EntityRecord Duplicate() {
EN_0d662bdaada5191124d8fca5ffaaf619EntityRecord t;
t._ssId = this._ssId;
t._ssInvoiceAccounting_ProcessId = this._ssInvoiceAccounting_ProcessId;
t._ssParameter = this._ssParameter;
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
} else if (head == "invoiceaccounting_processid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceAccounting_ProcessId")) variable.Value = ssInvoiceAccounting_ProcessId; else variable.Optimized = true;
} else if (head == "parameter") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Parameter")) variable.Value = ssParameter; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdInvoiceAccounting_ProcessId)) {
return ChangedAttributes[1];
}
if (key.Equals(IdParameter)) {
return ChangedAttributes[2];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdInvoiceAccounting_ProcessId)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdParameter)) {
return OptimizedAttributes[2];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdInvoiceAccounting_ProcessId) {
return ssInvoiceAccounting_ProcessId;
}
if (key == IdParameter) {
return ssParameter;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdInvoiceAccounting_ProcessId.Key.AsGuid) {
return ssInvoiceAccounting_ProcessId;
}
if (attributeKey == IdParameter.Key.AsGuid) {
return ssParameter;
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
ssInvoiceAccounting_ProcessId = (long) other.AttributeGet(IdInvoiceAccounting_ProcessId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdInvoiceAccounting_ProcessId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdInvoiceAccounting_ProcessId);
ssParameter = (string) other.AttributeGet(IdParameter);
ChangedAttributes[2] = other.ChangedAttributeGet(IdParameter);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdParameter);
}
} // EN_0d662bdaada5191124d8fca5ffaaf619EntityRecord

/// <summary>
/// RecordList type <code>InvoiceAccountingProcessLines_F43List</code> that represents a record list of
///  <code>InvoiceAccountingProcessLines_F43</code>
/// </summary>
public partial class RL_721c82cef3be0a3e0b8b87092fec941f : GenericRecordList<EN_0d662bdaada5191124d8fca5ffaaf619EntityRecord>, IEnumerable, IEnumerator {

protected override EN_0d662bdaada5191124d8fca5ffaaf619EntityRecord GetElementDefaultValue() {
return new EN_0d662bdaada5191124d8fca5ffaaf619EntityRecord();
}

public T[] ToArray<T>(Func<EN_0d662bdaada5191124d8fca5ffaaf619EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_721c82cef3be0a3e0b8b87092fec941f recordList, Func<EN_0d662bdaada5191124d8fca5ffaaf619EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_721c82cef3be0a3e0b8b87092fec941f(EN_0d662bdaada5191124d8fca5ffaaf619EntityRecord[] array) {
  RL_721c82cef3be0a3e0b8b87092fec941f result = new RL_721c82cef3be0a3e0b8b87092fec941f();
result.InnerFromArray(array);
    return result;
}

public static RL_721c82cef3be0a3e0b8b87092fec941f ToList<T>(T[] array, Func <T, EN_0d662bdaada5191124d8fca5ffaaf619EntityRecord> converter) {
  RL_721c82cef3be0a3e0b8b87092fec941f result = new RL_721c82cef3be0a3e0b8b87092fec941f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_721c82cef3be0a3e0b8b87092fec941f FromRestList<T>(RestList<T> restList, Func <T, EN_0d662bdaada5191124d8fca5ffaaf619EntityRecord> converter) {
  RL_721c82cef3be0a3e0b8b87092fec941f result = new RL_721c82cef3be0a3e0b8b87092fec941f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_721c82cef3be0a3e0b8b87092fec941f() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_0d662bdaada5191124d8fca5ffaaf619EntityRecord> NewList() {
return new RL_721c82cef3be0a3e0b8b87092fec941f();
}


} // RL_721c82cef3be0a3e0b8b87092fec941f
}
