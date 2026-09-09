namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (wf4N4i7ohkWHlxJ3rjRBdw)
///  <code>RC_6e3ea28d2c552bc2cc129f42297e5982</code> that represents <code>FileExtendedRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: FileExtendedRecord
public partial struct RC_6e3ea28d2c552bc2cc129f42297e5982 : ITypedRecord<RC_6e3ea28d2c552bc2cc129f42297e5982> {
internal static readonly GlobalObjectKey IdFileExtended = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*jaI+blUswivMEp9CKX5Zgg");

public EN_dcebdd8ba305133f41b1e1804925997fEntityRecord ssENFileExtended;


public static implicit operator EN_dcebdd8ba305133f41b1e1804925997fEntityRecord( RC_6e3ea28d2c552bc2cc129f42297e5982 r) {
return r.ssENFileExtended;
}

public static implicit operator RC_6e3ea28d2c552bc2cc129f42297e5982 (EN_dcebdd8ba305133f41b1e1804925997fEntityRecord r) {
RC_6e3ea28d2c552bc2cc129f42297e5982 res = new RC_6e3ea28d2c552bc2cc129f42297e5982 ();
res.ssENFileExtended = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENFileExtended.ChangedAttributes = value;
}
get {
    return ssENFileExtended.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_6e3ea28d2c552bc2cc129f42297e5982() {
OptimizedAttributes = null;
ssENFileExtended = new EN_dcebdd8ba305133f41b1e1804925997fEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(7,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENFileExtended.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENFileExtended.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENFileExtended.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENFileExtended.Read( r, ref index);
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
public void ReadIM(RC_6e3ea28d2c552bc2cc129f42297e5982 r) {
this = r;
}


public static bool operator == (RC_6e3ea28d2c552bc2cc129f42297e5982 a, RC_6e3ea28d2c552bc2cc129f42297e5982 b) {
if (a.ssENFileExtended != b.ssENFileExtended) return false;
return true;
}

public static bool operator != (RC_6e3ea28d2c552bc2cc129f42297e5982 a, RC_6e3ea28d2c552bc2cc129f42297e5982 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_6e3ea28d2c552bc2cc129f42297e5982)) return false;
return (this == (RC_6e3ea28d2c552bc2cc129f42297e5982)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENFileExtended.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENFileExtended.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENFileExtended.InternalRecursiveSave();
}


public RC_6e3ea28d2c552bc2cc129f42297e5982 Duplicate() {
RC_6e3ea28d2c552bc2cc129f42297e5982 t;
t.ssENFileExtended = (EN_dcebdd8ba305133f41b1e1804925997fEntityRecord)this.ssENFileExtended.Duplicate();
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
if (head == "fileextended") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FileExtended")) variable.Value = ssENFileExtended; else variable.Optimized = true;
variable.SetFieldName("fileextended");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENFileExtended.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENFileExtended.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdFileExtended) {
return ssENFileExtended;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdFileExtended.Key.AsGuid) {
return ssENFileExtended;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENFileExtended.FillFromOther((IRecord) other.AttributeGet(IdFileExtended));
}
} // RC_6e3ea28d2c552bc2cc129f42297e5982
/// <summary>
/// RecordList type <code>FileExtendedRecordList</code> that represents a record list of
///  <code>FileExtended</code>
/// </summary>
public partial class RL_6de96902c907b264dc4c48e378eca40b : GenericRecordList<RC_6e3ea28d2c552bc2cc129f42297e5982>, IEnumerable, IEnumerator {

protected override RC_6e3ea28d2c552bc2cc129f42297e5982 GetElementDefaultValue() {
return new RC_6e3ea28d2c552bc2cc129f42297e5982();
}

public T[] ToArray<T>(Func<RC_6e3ea28d2c552bc2cc129f42297e5982, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_6de96902c907b264dc4c48e378eca40b recordList, Func<RC_6e3ea28d2c552bc2cc129f42297e5982, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_6de96902c907b264dc4c48e378eca40b(RC_6e3ea28d2c552bc2cc129f42297e5982[] array) {
  RL_6de96902c907b264dc4c48e378eca40b result = new RL_6de96902c907b264dc4c48e378eca40b();
result.InnerFromArray(array);
    return result;
}

public static RL_6de96902c907b264dc4c48e378eca40b ToList<T>(T[] array, Func <T, RC_6e3ea28d2c552bc2cc129f42297e5982> converter) {
  RL_6de96902c907b264dc4c48e378eca40b result = new RL_6de96902c907b264dc4c48e378eca40b();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_6de96902c907b264dc4c48e378eca40b FromRestList<T>(RestList<T> restList, Func <T, RC_6e3ea28d2c552bc2cc129f42297e5982> converter) {
  RL_6de96902c907b264dc4c48e378eca40b result = new RL_6de96902c907b264dc4c48e378eca40b();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_6de96902c907b264dc4c48e378eca40b() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(7,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_6e3ea28d2c552bc2cc129f42297e5982> NewList() {
return new RL_6de96902c907b264dc4c48e378eca40b();
}


} // RL_6de96902c907b264dc4c48e378eca40b
}

