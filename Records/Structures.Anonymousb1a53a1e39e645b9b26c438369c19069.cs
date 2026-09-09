namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (HjqlseY5uUWybEODacGQaQ)
///  <code>RC_105c7a29498e4d7d103db2d1d51b10b3</code> that represent
/// s <code>RequisitionsListInternalTableStructureRecord</code> <p>Description: </p>
/// </summary>
// Name: RequisitionsListInternalTableStructureRecord
public partial struct RC_105c7a29498e4d7d103db2d1d51b10b3 : ITypedRecord<RC_105c7a29498e4d7d103db2d1d51b10b3> {
internal static readonly GlobalObjectKey IdRequisitionsListInternalTableStructure = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*KXpcEI5JfU0QPbLR1RsQsw");

public ST_291bf3fef8932fa1af5104e6982c4da9Structure ssSTRequisitionsListInternalTableStructure;


public static implicit operator ST_291bf3fef8932fa1af5104e6982c4da9Structure( RC_105c7a29498e4d7d103db2d1d51b10b3 r) {
return r.ssSTRequisitionsListInternalTableStructure;
}

public static implicit operator RC_105c7a29498e4d7d103db2d1d51b10b3 (ST_291bf3fef8932fa1af5104e6982c4da9Structure r) {
RC_105c7a29498e4d7d103db2d1d51b10b3 res = new RC_105c7a29498e4d7d103db2d1d51b10b3 ();
res.ssSTRequisitionsListInternalTableStructure = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_105c7a29498e4d7d103db2d1d51b10b3() {
OptimizedAttributes = null;
ssSTRequisitionsListInternalTableStructure = new ST_291bf3fef8932fa1af5104e6982c4da9Structure();
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
    ssSTRequisitionsListInternalTableStructure.OptimizedAttributes = value[0];
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
ssSTRequisitionsListInternalTableStructure.Read( r, ref index);
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
public void ReadIM(RC_105c7a29498e4d7d103db2d1d51b10b3 r) {
this = r;
}


public static bool operator == (RC_105c7a29498e4d7d103db2d1d51b10b3 a, RC_105c7a29498e4d7d103db2d1d51b10b3 b) {
if (a.ssSTRequisitionsListInternalTableStructure != b.ssSTRequisitionsListInternalTableStructure) return false;
return true;
}

public static bool operator != (RC_105c7a29498e4d7d103db2d1d51b10b3 a, RC_105c7a29498e4d7d103db2d1d51b10b3 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_105c7a29498e4d7d103db2d1d51b10b3)) return false;
return (this == (RC_105c7a29498e4d7d103db2d1d51b10b3)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTRequisitionsListInternalTableStructure.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTRequisitionsListInternalTableStructure.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTRequisitionsListInternalTableStructure.InternalRecursiveSave();
}


public RC_105c7a29498e4d7d103db2d1d51b10b3 Duplicate() {
RC_105c7a29498e4d7d103db2d1d51b10b3 t;
t.ssSTRequisitionsListInternalTableStructure = (ST_291bf3fef8932fa1af5104e6982c4da9Structure)this.ssSTRequisitionsListInternalTableStructure.Duplicate();
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
if (head == "requisitionslistinternaltablestructure") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionsListInternalTableStructure")) variable.Value = ssSTRequisitionsListInternalTableStructure; else variable.Optimized = true;
variable.SetFieldName("requisitionslistinternaltablestructure");
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
if (key == IdRequisitionsListInternalTableStructure) {
return ssSTRequisitionsListInternalTableStructure;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdRequisitionsListInternalTableStructure.Key.AsGuid) {
return ssSTRequisitionsListInternalTableStructure;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTRequisitionsListInternalTableStructure.FillFromOther((IRecord) other.AttributeGet(IdRequisitionsListInternalTableStructure));
}
} // RC_105c7a29498e4d7d103db2d1d51b10b3
/// <summary>
/// RecordList type <code>RequisitionsListInternalTableStructureRecordList</code> that represents a
///  record list of <code>RequisitionsListInternalTableStructure</code>
/// </summary>
public partial class RL_a60f93b23423e7d29797a1a79bfe8261 : GenericRecordList<RC_105c7a29498e4d7d103db2d1d51b10b3>, IEnumerable, IEnumerator {

protected override RC_105c7a29498e4d7d103db2d1d51b10b3 GetElementDefaultValue() {
return new RC_105c7a29498e4d7d103db2d1d51b10b3();
}

public T[] ToArray<T>(Func<RC_105c7a29498e4d7d103db2d1d51b10b3, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_a60f93b23423e7d29797a1a79bfe8261 recordList, Func<RC_105c7a29498e4d7d103db2d1d51b10b3, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_a60f93b23423e7d29797a1a79bfe8261(RC_105c7a29498e4d7d103db2d1d51b10b3[] array) {
  RL_a60f93b23423e7d29797a1a79bfe8261 result = new RL_a60f93b23423e7d29797a1a79bfe8261();
result.InnerFromArray(array);
    return result;
}

public static RL_a60f93b23423e7d29797a1a79bfe8261 ToList<T>(T[] array, Func <T, RC_105c7a29498e4d7d103db2d1d51b10b3> converter) {
  RL_a60f93b23423e7d29797a1a79bfe8261 result = new RL_a60f93b23423e7d29797a1a79bfe8261();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_a60f93b23423e7d29797a1a79bfe8261 FromRestList<T>(RestList<T> restList, Func <T, RC_105c7a29498e4d7d103db2d1d51b10b3> converter) {
  RL_a60f93b23423e7d29797a1a79bfe8261 result = new RL_a60f93b23423e7d29797a1a79bfe8261();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_a60f93b23423e7d29797a1a79bfe8261() : base() {
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
protected override OSList<RC_105c7a29498e4d7d103db2d1d51b10b3> NewList() {
return new RL_a60f93b23423e7d29797a1a79bfe8261();
}


} // RL_a60f93b23423e7d29797a1a79bfe8261
}

