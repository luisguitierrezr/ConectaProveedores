namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (TvK9q5b0MUuQ4YvF2V+VPA)
///  <code>RC_b2edf1939202eb7e60eb499349388514</code> that represents <code>StorageRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: StorageRecord
public partial struct RC_b2edf1939202eb7e60eb499349388514 : ITypedRecord<RC_b2edf1939202eb7e60eb499349388514> {
internal static readonly GlobalObjectKey IdStorage = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*k_HtsgKSfutg60mTSTiFFA");

public EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord ssENStorage;


public static implicit operator EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord( RC_b2edf1939202eb7e60eb499349388514 r) {
return r.ssENStorage;
}

public static implicit operator RC_b2edf1939202eb7e60eb499349388514 (EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord r) {
RC_b2edf1939202eb7e60eb499349388514 res = new RC_b2edf1939202eb7e60eb499349388514 ();
res.ssENStorage = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENStorage.ChangedAttributes = value;
}
get {
    return ssENStorage.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_b2edf1939202eb7e60eb499349388514() {
OptimizedAttributes = null;
ssENStorage = new EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(20,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENStorage.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENStorage.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENStorage.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENStorage.Read( r, ref index);
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
public void ReadIM(RC_b2edf1939202eb7e60eb499349388514 r) {
this = r;
}


public static bool operator == (RC_b2edf1939202eb7e60eb499349388514 a, RC_b2edf1939202eb7e60eb499349388514 b) {
if (a.ssENStorage != b.ssENStorage) return false;
return true;
}

public static bool operator != (RC_b2edf1939202eb7e60eb499349388514 a, RC_b2edf1939202eb7e60eb499349388514 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_b2edf1939202eb7e60eb499349388514)) return false;
return (this == (RC_b2edf1939202eb7e60eb499349388514)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENStorage.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENStorage.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENStorage.InternalRecursiveSave();
}


public RC_b2edf1939202eb7e60eb499349388514 Duplicate() {
RC_b2edf1939202eb7e60eb499349388514 t;
t.ssENStorage = (EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord)this.ssENStorage.Duplicate();
t.OptimizedAttributes = null;
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
if (head == "storage") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Storage")) variable.Value = ssENStorage; else variable.Optimized = true;
variable.SetFieldName("storage");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENStorage.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENStorage.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdStorage) {
return ssENStorage;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdStorage.Key.AsGuid) {
return ssENStorage;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENStorage.FillFromOther((IRecord) other.AttributeGet(IdStorage));
}
} // RC_b2edf1939202eb7e60eb499349388514
/// <summary>
/// RecordList type <code>StorageRecordList</code> that represents a record list of
///  <code>Storage</code>
/// </summary>
public partial class RL_d3db3806acf82f8f2cc8b7a1ac07805b : GenericRecordList<RC_b2edf1939202eb7e60eb499349388514>, IEnumerable, IEnumerator {

protected override RC_b2edf1939202eb7e60eb499349388514 GetElementDefaultValue() {
return new RC_b2edf1939202eb7e60eb499349388514();
}

public T[] ToArray<T>(Func<RC_b2edf1939202eb7e60eb499349388514, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_d3db3806acf82f8f2cc8b7a1ac07805b recordList, Func<RC_b2edf1939202eb7e60eb499349388514, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_d3db3806acf82f8f2cc8b7a1ac07805b(RC_b2edf1939202eb7e60eb499349388514[] array) {
  RL_d3db3806acf82f8f2cc8b7a1ac07805b result = new RL_d3db3806acf82f8f2cc8b7a1ac07805b();
result.InnerFromArray(array);
    return result;
}

public static RL_d3db3806acf82f8f2cc8b7a1ac07805b ToList<T>(T[] array, Func <T, RC_b2edf1939202eb7e60eb499349388514> converter) {
  RL_d3db3806acf82f8f2cc8b7a1ac07805b result = new RL_d3db3806acf82f8f2cc8b7a1ac07805b();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_d3db3806acf82f8f2cc8b7a1ac07805b FromRestList<T>(RestList<T> restList, Func <T, RC_b2edf1939202eb7e60eb499349388514> converter) {
  RL_d3db3806acf82f8f2cc8b7a1ac07805b result = new RL_d3db3806acf82f8f2cc8b7a1ac07805b();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_d3db3806acf82f8f2cc8b7a1ac07805b() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(20,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_b2edf1939202eb7e60eb499349388514> NewList() {
return new RL_d3db3806acf82f8f2cc8b7a1ac07805b();
}


} // RL_d3db3806acf82f8f2cc8b7a1ac07805b
}

