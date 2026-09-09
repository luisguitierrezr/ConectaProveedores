namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (tqBWfc6FkUSZIbXdf5QTVQ)
///  <code>RC_f861f2b559524d098e0981156af9b7ab</code> that represents <code>FolioItemsRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: FolioItemsRecord
public partial struct RC_f861f2b559524d098e0981156af9b7ab : ITypedRecord<RC_f861f2b559524d098e0981156af9b7ab> {
internal static readonly GlobalObjectKey IdFolioItems = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*tfJh+FJZCU2OCYEVavm3qw");

public EN_868430b5192a8eb1a739e01247fc2704EntityRecord ssENFolioItems;


public static implicit operator EN_868430b5192a8eb1a739e01247fc2704EntityRecord( RC_f861f2b559524d098e0981156af9b7ab r) {
return r.ssENFolioItems;
}

public static implicit operator RC_f861f2b559524d098e0981156af9b7ab (EN_868430b5192a8eb1a739e01247fc2704EntityRecord r) {
RC_f861f2b559524d098e0981156af9b7ab res = new RC_f861f2b559524d098e0981156af9b7ab ();
res.ssENFolioItems = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENFolioItems.ChangedAttributes = value;
}
get {
    return ssENFolioItems.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_f861f2b559524d098e0981156af9b7ab() {
OptimizedAttributes = null;
ssENFolioItems = new EN_868430b5192a8eb1a739e01247fc2704EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(18,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENFolioItems.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENFolioItems.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENFolioItems.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENFolioItems.Read( r, ref index);
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
public void ReadIM(RC_f861f2b559524d098e0981156af9b7ab r) {
this = r;
}


public static bool operator == (RC_f861f2b559524d098e0981156af9b7ab a, RC_f861f2b559524d098e0981156af9b7ab b) {
if (a.ssENFolioItems != b.ssENFolioItems) return false;
return true;
}

public static bool operator != (RC_f861f2b559524d098e0981156af9b7ab a, RC_f861f2b559524d098e0981156af9b7ab b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_f861f2b559524d098e0981156af9b7ab)) return false;
return (this == (RC_f861f2b559524d098e0981156af9b7ab)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENFolioItems.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENFolioItems.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENFolioItems.InternalRecursiveSave();
}


public RC_f861f2b559524d098e0981156af9b7ab Duplicate() {
RC_f861f2b559524d098e0981156af9b7ab t;
t.ssENFolioItems = (EN_868430b5192a8eb1a739e01247fc2704EntityRecord)this.ssENFolioItems.Duplicate();
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
if (head == "folioitems") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioItems")) variable.Value = ssENFolioItems; else variable.Optimized = true;
variable.SetFieldName("folioitems");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENFolioItems.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENFolioItems.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdFolioItems) {
return ssENFolioItems;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdFolioItems.Key.AsGuid) {
return ssENFolioItems;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENFolioItems.FillFromOther((IRecord) other.AttributeGet(IdFolioItems));
}
} // RC_f861f2b559524d098e0981156af9b7ab
/// <summary>
/// RecordList type <code>FolioItemsRecordList</code> that represents a record list of
///  <code>FolioItems</code>
/// </summary>
public partial class RL_20398ad87fe6d4946bb9511e3c38754f : GenericRecordList<RC_f861f2b559524d098e0981156af9b7ab>, IEnumerable, IEnumerator {

protected override RC_f861f2b559524d098e0981156af9b7ab GetElementDefaultValue() {
return new RC_f861f2b559524d098e0981156af9b7ab();
}

public T[] ToArray<T>(Func<RC_f861f2b559524d098e0981156af9b7ab, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_20398ad87fe6d4946bb9511e3c38754f recordList, Func<RC_f861f2b559524d098e0981156af9b7ab, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_20398ad87fe6d4946bb9511e3c38754f(RC_f861f2b559524d098e0981156af9b7ab[] array) {
  RL_20398ad87fe6d4946bb9511e3c38754f result = new RL_20398ad87fe6d4946bb9511e3c38754f();
result.InnerFromArray(array);
    return result;
}

public static RL_20398ad87fe6d4946bb9511e3c38754f ToList<T>(T[] array, Func <T, RC_f861f2b559524d098e0981156af9b7ab> converter) {
  RL_20398ad87fe6d4946bb9511e3c38754f result = new RL_20398ad87fe6d4946bb9511e3c38754f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_20398ad87fe6d4946bb9511e3c38754f FromRestList<T>(RestList<T> restList, Func <T, RC_f861f2b559524d098e0981156af9b7ab> converter) {
  RL_20398ad87fe6d4946bb9511e3c38754f result = new RL_20398ad87fe6d4946bb9511e3c38754f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_20398ad87fe6d4946bb9511e3c38754f() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(18,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_f861f2b559524d098e0981156af9b7ab> NewList() {
return new RL_20398ad87fe6d4946bb9511e3c38754f();
}


} // RL_20398ad87fe6d4946bb9511e3c38754f
}

