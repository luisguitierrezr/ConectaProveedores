namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (i_htFP6vHkCOxlVcwM5Omw)
///  <code>RC_cd6f33f299248253665f3cd688191346</code> that represents <code>ItemSM_MORecord</code
/// > <p>Description: </p>
/// </summary>
// Name: ItemSM_MORecord
public partial struct RC_cd6f33f299248253665f3cd688191346 : ITypedRecord<RC_cd6f33f299248253665f3cd688191346> {
internal static readonly GlobalObjectKey IdItemSM_MO = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*8jNvzSSZU4JmXzzWiBkTRg");

public ST_67da2825930e4cc01dda17107c43d1e6Structure ssSTItemSM_MO;


public static implicit operator ST_67da2825930e4cc01dda17107c43d1e6Structure( RC_cd6f33f299248253665f3cd688191346 r) {
return r.ssSTItemSM_MO;
}

public static implicit operator RC_cd6f33f299248253665f3cd688191346 (ST_67da2825930e4cc01dda17107c43d1e6Structure r) {
RC_cd6f33f299248253665f3cd688191346 res = new RC_cd6f33f299248253665f3cd688191346 ();
res.ssSTItemSM_MO = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_cd6f33f299248253665f3cd688191346() {
OptimizedAttributes = null;
ssSTItemSM_MO = new ST_67da2825930e4cc01dda17107c43d1e6Structure();
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
    ssSTItemSM_MO.OptimizedAttributes = value[0];
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
ssSTItemSM_MO.Read( r, ref index);
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
public void ReadIM(RC_cd6f33f299248253665f3cd688191346 r) {
this = r;
}


public static bool operator == (RC_cd6f33f299248253665f3cd688191346 a, RC_cd6f33f299248253665f3cd688191346 b) {
if (a.ssSTItemSM_MO != b.ssSTItemSM_MO) return false;
return true;
}

public static bool operator != (RC_cd6f33f299248253665f3cd688191346 a, RC_cd6f33f299248253665f3cd688191346 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_cd6f33f299248253665f3cd688191346)) return false;
return (this == (RC_cd6f33f299248253665f3cd688191346)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTItemSM_MO.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTItemSM_MO.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTItemSM_MO.InternalRecursiveSave();
}


public RC_cd6f33f299248253665f3cd688191346 Duplicate() {
RC_cd6f33f299248253665f3cd688191346 t;
t.ssSTItemSM_MO = (ST_67da2825930e4cc01dda17107c43d1e6Structure)this.ssSTItemSM_MO.Duplicate();
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
if (head == "itemsm_mo") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ItemSM_MO")) variable.Value = ssSTItemSM_MO; else variable.Optimized = true;
variable.SetFieldName("itemsm_mo");
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
if (key == IdItemSM_MO) {
return ssSTItemSM_MO;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdItemSM_MO.Key.AsGuid) {
return ssSTItemSM_MO;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTItemSM_MO.FillFromOther((IRecord) other.AttributeGet(IdItemSM_MO));
}
} // RC_cd6f33f299248253665f3cd688191346
/// <summary>
/// RecordList type <code>ItemSM_MORecordList</code> that represents a record list of
///  <code>ItemSM_MO</code>
/// </summary>
public partial class RL_67072e7f62eabb21bd846ccc66e4c43d : GenericRecordList<RC_cd6f33f299248253665f3cd688191346>, IEnumerable, IEnumerator {

protected override RC_cd6f33f299248253665f3cd688191346 GetElementDefaultValue() {
return new RC_cd6f33f299248253665f3cd688191346();
}

public T[] ToArray<T>(Func<RC_cd6f33f299248253665f3cd688191346, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_67072e7f62eabb21bd846ccc66e4c43d recordList, Func<RC_cd6f33f299248253665f3cd688191346, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_67072e7f62eabb21bd846ccc66e4c43d(RC_cd6f33f299248253665f3cd688191346[] array) {
  RL_67072e7f62eabb21bd846ccc66e4c43d result = new RL_67072e7f62eabb21bd846ccc66e4c43d();
result.InnerFromArray(array);
    return result;
}

public static RL_67072e7f62eabb21bd846ccc66e4c43d ToList<T>(T[] array, Func <T, RC_cd6f33f299248253665f3cd688191346> converter) {
  RL_67072e7f62eabb21bd846ccc66e4c43d result = new RL_67072e7f62eabb21bd846ccc66e4c43d();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_67072e7f62eabb21bd846ccc66e4c43d FromRestList<T>(RestList<T> restList, Func <T, RC_cd6f33f299248253665f3cd688191346> converter) {
  RL_67072e7f62eabb21bd846ccc66e4c43d result = new RL_67072e7f62eabb21bd846ccc66e4c43d();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_67072e7f62eabb21bd846ccc66e4c43d() : base() {
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
protected override OSList<RC_cd6f33f299248253665f3cd688191346> NewList() {
return new RL_67072e7f62eabb21bd846ccc66e4c43d();
}


} // RL_67072e7f62eabb21bd846ccc66e4c43d
}

