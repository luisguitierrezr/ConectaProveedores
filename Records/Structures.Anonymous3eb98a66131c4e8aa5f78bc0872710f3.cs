namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (Zoq5PhwTik6l94vAhycQ8w)
///  <code>RC_c39f3c10ad99d866d1fba066291cd7c9</code> that represents <code>LinesReport63Record</code
/// > <p>Description: </p>
/// </summary>
// Name: LinesReport63Record
public partial struct RC_c39f3c10ad99d866d1fba066291cd7c9 : ITypedRecord<RC_c39f3c10ad99d866d1fba066291cd7c9> {
internal static readonly GlobalObjectKey IdLinesReport63 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*EDyfw5mtZtjR+6BmKRzXyQ");

public ST_4d9dc458054302bbc44781a77ddc1e39Structure ssSTLinesReport63;


public static implicit operator ST_4d9dc458054302bbc44781a77ddc1e39Structure( RC_c39f3c10ad99d866d1fba066291cd7c9 r) {
return r.ssSTLinesReport63;
}

public static implicit operator RC_c39f3c10ad99d866d1fba066291cd7c9 (ST_4d9dc458054302bbc44781a77ddc1e39Structure r) {
RC_c39f3c10ad99d866d1fba066291cd7c9 res = new RC_c39f3c10ad99d866d1fba066291cd7c9 ();
res.ssSTLinesReport63 = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_c39f3c10ad99d866d1fba066291cd7c9() {
OptimizedAttributes = null;
ssSTLinesReport63 = new ST_4d9dc458054302bbc44781a77ddc1e39Structure();
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
    ssSTLinesReport63.OptimizedAttributes = value[0];
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
ssSTLinesReport63.Read( r, ref index);
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
public void ReadIM(RC_c39f3c10ad99d866d1fba066291cd7c9 r) {
this = r;
}


public static bool operator == (RC_c39f3c10ad99d866d1fba066291cd7c9 a, RC_c39f3c10ad99d866d1fba066291cd7c9 b) {
if (a.ssSTLinesReport63 != b.ssSTLinesReport63) return false;
return true;
}

public static bool operator != (RC_c39f3c10ad99d866d1fba066291cd7c9 a, RC_c39f3c10ad99d866d1fba066291cd7c9 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_c39f3c10ad99d866d1fba066291cd7c9)) return false;
return (this == (RC_c39f3c10ad99d866d1fba066291cd7c9)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTLinesReport63.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTLinesReport63.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTLinesReport63.InternalRecursiveSave();
}


public RC_c39f3c10ad99d866d1fba066291cd7c9 Duplicate() {
RC_c39f3c10ad99d866d1fba066291cd7c9 t;
t.ssSTLinesReport63 = (ST_4d9dc458054302bbc44781a77ddc1e39Structure)this.ssSTLinesReport63.Duplicate();
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
if (head == "linesreport63") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".LinesReport63")) variable.Value = ssSTLinesReport63; else variable.Optimized = true;
variable.SetFieldName("linesreport63");
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
if (key == IdLinesReport63) {
return ssSTLinesReport63;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdLinesReport63.Key.AsGuid) {
return ssSTLinesReport63;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTLinesReport63.FillFromOther((IRecord) other.AttributeGet(IdLinesReport63));
}
} // RC_c39f3c10ad99d866d1fba066291cd7c9
/// <summary>
/// RecordList type <code>LinesReport63RecordList</code> that represents a record list of
///  <code>LinesReport63</code>
/// </summary>
public partial class RL_bb9bd65cc6ab3438e4038ecd50363e6c : GenericRecordList<RC_c39f3c10ad99d866d1fba066291cd7c9>, IEnumerable, IEnumerator {

protected override RC_c39f3c10ad99d866d1fba066291cd7c9 GetElementDefaultValue() {
return new RC_c39f3c10ad99d866d1fba066291cd7c9();
}

public T[] ToArray<T>(Func<RC_c39f3c10ad99d866d1fba066291cd7c9, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_bb9bd65cc6ab3438e4038ecd50363e6c recordList, Func<RC_c39f3c10ad99d866d1fba066291cd7c9, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_bb9bd65cc6ab3438e4038ecd50363e6c(RC_c39f3c10ad99d866d1fba066291cd7c9[] array) {
  RL_bb9bd65cc6ab3438e4038ecd50363e6c result = new RL_bb9bd65cc6ab3438e4038ecd50363e6c();
result.InnerFromArray(array);
    return result;
}

public static RL_bb9bd65cc6ab3438e4038ecd50363e6c ToList<T>(T[] array, Func <T, RC_c39f3c10ad99d866d1fba066291cd7c9> converter) {
  RL_bb9bd65cc6ab3438e4038ecd50363e6c result = new RL_bb9bd65cc6ab3438e4038ecd50363e6c();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_bb9bd65cc6ab3438e4038ecd50363e6c FromRestList<T>(RestList<T> restList, Func <T, RC_c39f3c10ad99d866d1fba066291cd7c9> converter) {
  RL_bb9bd65cc6ab3438e4038ecd50363e6c result = new RL_bb9bd65cc6ab3438e4038ecd50363e6c();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_bb9bd65cc6ab3438e4038ecd50363e6c() : base() {
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
protected override OSList<RC_c39f3c10ad99d866d1fba066291cd7c9> NewList() {
return new RL_bb9bd65cc6ab3438e4038ecd50363e6c();
}


} // RL_bb9bd65cc6ab3438e4038ecd50363e6c
}

