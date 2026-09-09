namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (kEkVvrE390Caopqt+apHCg)
///  <code>RC_447a4f014542f360a86edbc89025680b</code> that represents <code>FolioItemRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: FolioItemRecord
public partial struct RC_447a4f014542f360a86edbc89025680b : ITypedRecord<RC_447a4f014542f360a86edbc89025680b> {
internal static readonly GlobalObjectKey IdFolioItem = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*AU96REJFYPOobtvIkCVoCw");

public ST_1bddfac19e9b0cef65924aa7568fd106Structure ssSTFolioItem;


public static implicit operator ST_1bddfac19e9b0cef65924aa7568fd106Structure( RC_447a4f014542f360a86edbc89025680b r) {
return r.ssSTFolioItem;
}

public static implicit operator RC_447a4f014542f360a86edbc89025680b (ST_1bddfac19e9b0cef65924aa7568fd106Structure r) {
RC_447a4f014542f360a86edbc89025680b res = new RC_447a4f014542f360a86edbc89025680b ();
res.ssSTFolioItem = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_447a4f014542f360a86edbc89025680b() {
OptimizedAttributes = null;
ssSTFolioItem = new ST_1bddfac19e9b0cef65924aa7568fd106Structure();
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
    ssSTFolioItem.OptimizedAttributes = value[0];
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
ssSTFolioItem.Read( r, ref index);
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
public void ReadIM(RC_447a4f014542f360a86edbc89025680b r) {
this = r;
}


public static bool operator == (RC_447a4f014542f360a86edbc89025680b a, RC_447a4f014542f360a86edbc89025680b b) {
if (a.ssSTFolioItem != b.ssSTFolioItem) return false;
return true;
}

public static bool operator != (RC_447a4f014542f360a86edbc89025680b a, RC_447a4f014542f360a86edbc89025680b b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_447a4f014542f360a86edbc89025680b)) return false;
return (this == (RC_447a4f014542f360a86edbc89025680b)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTFolioItem.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTFolioItem.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTFolioItem.InternalRecursiveSave();
}


public RC_447a4f014542f360a86edbc89025680b Duplicate() {
RC_447a4f014542f360a86edbc89025680b t;
t.ssSTFolioItem = (ST_1bddfac19e9b0cef65924aa7568fd106Structure)this.ssSTFolioItem.Duplicate();
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
if (head == "folioitem") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioItem")) variable.Value = ssSTFolioItem; else variable.Optimized = true;
variable.SetFieldName("folioitem");
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
if (key == IdFolioItem) {
return ssSTFolioItem;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdFolioItem.Key.AsGuid) {
return ssSTFolioItem;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTFolioItem.FillFromOther((IRecord) other.AttributeGet(IdFolioItem));
}
} // RC_447a4f014542f360a86edbc89025680b
/// <summary>
/// RecordList type <code>FolioItemRecordList</code> that represents a record list of
///  <code>FolioItem</code>
/// </summary>
public partial class RL_bab3397f952f07af0f0aa229e6f2b36e : GenericRecordList<RC_447a4f014542f360a86edbc89025680b>, IEnumerable, IEnumerator {

protected override RC_447a4f014542f360a86edbc89025680b GetElementDefaultValue() {
return new RC_447a4f014542f360a86edbc89025680b();
}

public T[] ToArray<T>(Func<RC_447a4f014542f360a86edbc89025680b, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_bab3397f952f07af0f0aa229e6f2b36e recordList, Func<RC_447a4f014542f360a86edbc89025680b, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_bab3397f952f07af0f0aa229e6f2b36e(RC_447a4f014542f360a86edbc89025680b[] array) {
  RL_bab3397f952f07af0f0aa229e6f2b36e result = new RL_bab3397f952f07af0f0aa229e6f2b36e();
result.InnerFromArray(array);
    return result;
}

public static RL_bab3397f952f07af0f0aa229e6f2b36e ToList<T>(T[] array, Func <T, RC_447a4f014542f360a86edbc89025680b> converter) {
  RL_bab3397f952f07af0f0aa229e6f2b36e result = new RL_bab3397f952f07af0f0aa229e6f2b36e();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_bab3397f952f07af0f0aa229e6f2b36e FromRestList<T>(RestList<T> restList, Func <T, RC_447a4f014542f360a86edbc89025680b> converter) {
  RL_bab3397f952f07af0f0aa229e6f2b36e result = new RL_bab3397f952f07af0f0aa229e6f2b36e();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_bab3397f952f07af0f0aa229e6f2b36e() : base() {
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
protected override OSList<RC_447a4f014542f360a86edbc89025680b> NewList() {
return new RL_bab3397f952f07af0f0aa229e6f2b36e();
}


} // RL_bab3397f952f07af0f0aa229e6f2b36e
}

