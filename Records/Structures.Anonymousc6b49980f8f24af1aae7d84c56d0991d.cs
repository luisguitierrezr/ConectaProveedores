namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (gJm0xvL48Uqq59hMVtCZHQ)
///  <code>RC_0bfa65ee3c3879e1901eb29cd4b29a79</code> that represent
/// s <code>Report60_FolioItemsRecord</code> <p>Description: </p>
/// </summary>
// Name: Report60_FolioItemsRecord
public partial struct RC_0bfa65ee3c3879e1901eb29cd4b29a79 : ITypedRecord<RC_0bfa65ee3c3879e1901eb29cd4b29a79> {
internal static readonly GlobalObjectKey IdReport60_FolioItems = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*7mX6Czg84XmQHrKc1LKaeQ");

public ST_cb4c5fb278f0d4361ef865566d325f1fStructure ssSTReport60_FolioItems;


public static implicit operator ST_cb4c5fb278f0d4361ef865566d325f1fStructure( RC_0bfa65ee3c3879e1901eb29cd4b29a79 r) {
return r.ssSTReport60_FolioItems;
}

public static implicit operator RC_0bfa65ee3c3879e1901eb29cd4b29a79 (ST_cb4c5fb278f0d4361ef865566d325f1fStructure r) {
RC_0bfa65ee3c3879e1901eb29cd4b29a79 res = new RC_0bfa65ee3c3879e1901eb29cd4b29a79 ();
res.ssSTReport60_FolioItems = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_0bfa65ee3c3879e1901eb29cd4b29a79() {
OptimizedAttributes = null;
ssSTReport60_FolioItems = new ST_cb4c5fb278f0d4361ef865566d325f1fStructure();
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
    ssSTReport60_FolioItems.OptimizedAttributes = value[0];
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
ssSTReport60_FolioItems.Read( r, ref index);
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
public void ReadIM(RC_0bfa65ee3c3879e1901eb29cd4b29a79 r) {
this = r;
}


public static bool operator == (RC_0bfa65ee3c3879e1901eb29cd4b29a79 a, RC_0bfa65ee3c3879e1901eb29cd4b29a79 b) {
if (a.ssSTReport60_FolioItems != b.ssSTReport60_FolioItems) return false;
return true;
}

public static bool operator != (RC_0bfa65ee3c3879e1901eb29cd4b29a79 a, RC_0bfa65ee3c3879e1901eb29cd4b29a79 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_0bfa65ee3c3879e1901eb29cd4b29a79)) return false;
return (this == (RC_0bfa65ee3c3879e1901eb29cd4b29a79)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTReport60_FolioItems.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTReport60_FolioItems.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTReport60_FolioItems.InternalRecursiveSave();
}


public RC_0bfa65ee3c3879e1901eb29cd4b29a79 Duplicate() {
RC_0bfa65ee3c3879e1901eb29cd4b29a79 t;
t.ssSTReport60_FolioItems = (ST_cb4c5fb278f0d4361ef865566d325f1fStructure)this.ssSTReport60_FolioItems.Duplicate();
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
if (head == "report60_folioitems") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Report60_FolioItems")) variable.Value = ssSTReport60_FolioItems; else variable.Optimized = true;
variable.SetFieldName("report60_folioitems");
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
if (key == IdReport60_FolioItems) {
return ssSTReport60_FolioItems;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdReport60_FolioItems.Key.AsGuid) {
return ssSTReport60_FolioItems;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTReport60_FolioItems.FillFromOther((IRecord) other.AttributeGet(IdReport60_FolioItems));
}
} // RC_0bfa65ee3c3879e1901eb29cd4b29a79
/// <summary>
/// RecordList type <code>Report60_FolioItemsRecordList</code> that represents a record list of
///  <code>Report60_FolioItems</code>
/// </summary>
public partial class RL_5a216f9f46f02cbbd2515f4bd8546fd0 : GenericRecordList<RC_0bfa65ee3c3879e1901eb29cd4b29a79>, IEnumerable, IEnumerator {

protected override RC_0bfa65ee3c3879e1901eb29cd4b29a79 GetElementDefaultValue() {
return new RC_0bfa65ee3c3879e1901eb29cd4b29a79();
}

public T[] ToArray<T>(Func<RC_0bfa65ee3c3879e1901eb29cd4b29a79, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_5a216f9f46f02cbbd2515f4bd8546fd0 recordList, Func<RC_0bfa65ee3c3879e1901eb29cd4b29a79, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_5a216f9f46f02cbbd2515f4bd8546fd0(RC_0bfa65ee3c3879e1901eb29cd4b29a79[] array) {
  RL_5a216f9f46f02cbbd2515f4bd8546fd0 result = new RL_5a216f9f46f02cbbd2515f4bd8546fd0();
result.InnerFromArray(array);
    return result;
}

public static RL_5a216f9f46f02cbbd2515f4bd8546fd0 ToList<T>(T[] array, Func <T, RC_0bfa65ee3c3879e1901eb29cd4b29a79> converter) {
  RL_5a216f9f46f02cbbd2515f4bd8546fd0 result = new RL_5a216f9f46f02cbbd2515f4bd8546fd0();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_5a216f9f46f02cbbd2515f4bd8546fd0 FromRestList<T>(RestList<T> restList, Func <T, RC_0bfa65ee3c3879e1901eb29cd4b29a79> converter) {
  RL_5a216f9f46f02cbbd2515f4bd8546fd0 result = new RL_5a216f9f46f02cbbd2515f4bd8546fd0();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_5a216f9f46f02cbbd2515f4bd8546fd0() : base() {
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
protected override OSList<RC_0bfa65ee3c3879e1901eb29cd4b29a79> NewList() {
return new RL_5a216f9f46f02cbbd2515f4bd8546fd0();
}


} // RL_5a216f9f46f02cbbd2515f4bd8546fd0
}

