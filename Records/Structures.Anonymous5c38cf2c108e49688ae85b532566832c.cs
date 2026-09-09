namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (LM84XI4QaEmK6FtTJWaDLA)
///  <code>RC_0e3fdf026f72a52d5ce82006854e2d4b</code> that represent
/// s <code>EntryOrderRequestCancelRecord</code> <p>Description: </p>
/// </summary>
// Name: EntryOrderRequestCancelRecord
public partial struct RC_0e3fdf026f72a52d5ce82006854e2d4b : ITypedRecord<RC_0e3fdf026f72a52d5ce82006854e2d4b> {
internal static readonly GlobalObjectKey IdEntryOrderRequestCancel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*At8_DnJvLaVc6CAGhU4tSw");

public ST_ed201ff180bb2dd4a51ad889e8debcfaStructure ssSTEntryOrderRequestCancel;


public static implicit operator ST_ed201ff180bb2dd4a51ad889e8debcfaStructure( RC_0e3fdf026f72a52d5ce82006854e2d4b r) {
return r.ssSTEntryOrderRequestCancel;
}

public static implicit operator RC_0e3fdf026f72a52d5ce82006854e2d4b (ST_ed201ff180bb2dd4a51ad889e8debcfaStructure r) {
RC_0e3fdf026f72a52d5ce82006854e2d4b res = new RC_0e3fdf026f72a52d5ce82006854e2d4b ();
res.ssSTEntryOrderRequestCancel = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_0e3fdf026f72a52d5ce82006854e2d4b() {
OptimizedAttributes = null;
ssSTEntryOrderRequestCancel = new ST_ed201ff180bb2dd4a51ad889e8debcfaStructure();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    ssSTEntryOrderRequestCancel.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssSTEntryOrderRequestCancel.Read( r, ref index);
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
public void ReadIM(RC_0e3fdf026f72a52d5ce82006854e2d4b r) {
this = r;
}


public static bool operator == (RC_0e3fdf026f72a52d5ce82006854e2d4b a, RC_0e3fdf026f72a52d5ce82006854e2d4b b) {
if (a.ssSTEntryOrderRequestCancel != b.ssSTEntryOrderRequestCancel) return false;
return true;
}

public static bool operator != (RC_0e3fdf026f72a52d5ce82006854e2d4b a, RC_0e3fdf026f72a52d5ce82006854e2d4b b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_0e3fdf026f72a52d5ce82006854e2d4b)) return false;
return (this == (RC_0e3fdf026f72a52d5ce82006854e2d4b)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTEntryOrderRequestCancel.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTEntryOrderRequestCancel.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTEntryOrderRequestCancel.InternalRecursiveSave();
}


public RC_0e3fdf026f72a52d5ce82006854e2d4b Duplicate() {
RC_0e3fdf026f72a52d5ce82006854e2d4b t;
t.ssSTEntryOrderRequestCancel = (ST_ed201ff180bb2dd4a51ad889e8debcfaStructure)this.ssSTEntryOrderRequestCancel.Duplicate();
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
if (head == "entryorderrequestcancel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EntryOrderRequestCancel")) variable.Value = ssSTEntryOrderRequestCancel; else variable.Optimized = true;
variable.SetFieldName("entryorderrequestcancel");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdEntryOrderRequestCancel) {
return ssSTEntryOrderRequestCancel;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdEntryOrderRequestCancel.Key.AsGuid) {
return ssSTEntryOrderRequestCancel;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTEntryOrderRequestCancel.FillFromOther((IRecord) other.AttributeGet(IdEntryOrderRequestCancel));
}
} // RC_0e3fdf026f72a52d5ce82006854e2d4b
/// <summary>
/// RecordList type <code>EntryOrderRequestCancelRecordList</code> that represents a record list of
///  <code>EntryOrderRequestCancel</code>
/// </summary>
public partial class RL_4db5c088e4e9ea9e079abb99b0c1226b : GenericRecordList<RC_0e3fdf026f72a52d5ce82006854e2d4b>, IEnumerable, IEnumerator {

protected override RC_0e3fdf026f72a52d5ce82006854e2d4b GetElementDefaultValue() {
return new RC_0e3fdf026f72a52d5ce82006854e2d4b();
}

public T[] ToArray<T>(Func<RC_0e3fdf026f72a52d5ce82006854e2d4b, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_4db5c088e4e9ea9e079abb99b0c1226b recordList, Func<RC_0e3fdf026f72a52d5ce82006854e2d4b, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_4db5c088e4e9ea9e079abb99b0c1226b(RC_0e3fdf026f72a52d5ce82006854e2d4b[] array) {
  RL_4db5c088e4e9ea9e079abb99b0c1226b result = new RL_4db5c088e4e9ea9e079abb99b0c1226b();
result.InnerFromArray(array);
    return result;
}

public static RL_4db5c088e4e9ea9e079abb99b0c1226b ToList<T>(T[] array, Func <T, RC_0e3fdf026f72a52d5ce82006854e2d4b> converter) {
  RL_4db5c088e4e9ea9e079abb99b0c1226b result = new RL_4db5c088e4e9ea9e079abb99b0c1226b();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_4db5c088e4e9ea9e079abb99b0c1226b FromRestList<T>(RestList<T> restList, Func <T, RC_0e3fdf026f72a52d5ce82006854e2d4b> converter) {
  RL_4db5c088e4e9ea9e079abb99b0c1226b result = new RL_4db5c088e4e9ea9e079abb99b0c1226b();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_4db5c088e4e9ea9e079abb99b0c1226b() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = null;
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_0e3fdf026f72a52d5ce82006854e2d4b> NewList() {
return new RL_4db5c088e4e9ea9e079abb99b0c1226b();
}


} // RL_4db5c088e4e9ea9e079abb99b0c1226b
}

