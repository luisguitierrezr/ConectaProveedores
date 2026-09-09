namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (3cJz01pP7UaEOR5we6hHVA)
///  <code>RC_b73f0c67ffc0008d77cac753ae1f90dc</code> that represent
/// s <code>InvoicesReport48_5FilesRecord</code> <p>Description: </p>
/// </summary>
// Name: InvoicesReport48_5FilesRecord
public partial struct RC_b73f0c67ffc0008d77cac753ae1f90dc : ITypedRecord<RC_b73f0c67ffc0008d77cac753ae1f90dc> {
internal static readonly GlobalObjectKey IdInvoicesReport48_5Files = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Zww_t8D_jQB3ysdTrh+Q3A");

public ST_67affae36317a1bf9109868208ade0a8Structure ssSTInvoicesReport48_5Files;


public static implicit operator ST_67affae36317a1bf9109868208ade0a8Structure( RC_b73f0c67ffc0008d77cac753ae1f90dc r) {
return r.ssSTInvoicesReport48_5Files;
}

public static implicit operator RC_b73f0c67ffc0008d77cac753ae1f90dc (ST_67affae36317a1bf9109868208ade0a8Structure r) {
RC_b73f0c67ffc0008d77cac753ae1f90dc res = new RC_b73f0c67ffc0008d77cac753ae1f90dc ();
res.ssSTInvoicesReport48_5Files = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_b73f0c67ffc0008d77cac753ae1f90dc() {
OptimizedAttributes = null;
ssSTInvoicesReport48_5Files = new ST_67affae36317a1bf9109868208ade0a8Structure();
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
    ssSTInvoicesReport48_5Files.OptimizedAttributes = value[0];
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
ssSTInvoicesReport48_5Files.Read( r, ref index);
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
public void ReadIM(RC_b73f0c67ffc0008d77cac753ae1f90dc r) {
this = r;
}


public static bool operator == (RC_b73f0c67ffc0008d77cac753ae1f90dc a, RC_b73f0c67ffc0008d77cac753ae1f90dc b) {
if (a.ssSTInvoicesReport48_5Files != b.ssSTInvoicesReport48_5Files) return false;
return true;
}

public static bool operator != (RC_b73f0c67ffc0008d77cac753ae1f90dc a, RC_b73f0c67ffc0008d77cac753ae1f90dc b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_b73f0c67ffc0008d77cac753ae1f90dc)) return false;
return (this == (RC_b73f0c67ffc0008d77cac753ae1f90dc)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTInvoicesReport48_5Files.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTInvoicesReport48_5Files.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTInvoicesReport48_5Files.InternalRecursiveSave();
}


public RC_b73f0c67ffc0008d77cac753ae1f90dc Duplicate() {
RC_b73f0c67ffc0008d77cac753ae1f90dc t;
t.ssSTInvoicesReport48_5Files = (ST_67affae36317a1bf9109868208ade0a8Structure)this.ssSTInvoicesReport48_5Files.Duplicate();
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
if (head == "invoicesreport48_5files") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoicesReport48_5Files")) variable.Value = ssSTInvoicesReport48_5Files; else variable.Optimized = true;
variable.SetFieldName("invoicesreport48_5files");
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
if (key == IdInvoicesReport48_5Files) {
return ssSTInvoicesReport48_5Files;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoicesReport48_5Files.Key.AsGuid) {
return ssSTInvoicesReport48_5Files;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTInvoicesReport48_5Files.FillFromOther((IRecord) other.AttributeGet(IdInvoicesReport48_5Files));
}
} // RC_b73f0c67ffc0008d77cac753ae1f90dc
/// <summary>
/// RecordList type <code>InvoicesReport48_5FilesRecordList</code> that represents a record list of
///  <code>InvoicesReport48_5Files</code>
/// </summary>
public partial class RL_0aebef04a60430d62276d7923db3605d : GenericRecordList<RC_b73f0c67ffc0008d77cac753ae1f90dc>, IEnumerable, IEnumerator {

protected override RC_b73f0c67ffc0008d77cac753ae1f90dc GetElementDefaultValue() {
return new RC_b73f0c67ffc0008d77cac753ae1f90dc();
}

public T[] ToArray<T>(Func<RC_b73f0c67ffc0008d77cac753ae1f90dc, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_0aebef04a60430d62276d7923db3605d recordList, Func<RC_b73f0c67ffc0008d77cac753ae1f90dc, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_0aebef04a60430d62276d7923db3605d(RC_b73f0c67ffc0008d77cac753ae1f90dc[] array) {
  RL_0aebef04a60430d62276d7923db3605d result = new RL_0aebef04a60430d62276d7923db3605d();
result.InnerFromArray(array);
    return result;
}

public static RL_0aebef04a60430d62276d7923db3605d ToList<T>(T[] array, Func <T, RC_b73f0c67ffc0008d77cac753ae1f90dc> converter) {
  RL_0aebef04a60430d62276d7923db3605d result = new RL_0aebef04a60430d62276d7923db3605d();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_0aebef04a60430d62276d7923db3605d FromRestList<T>(RestList<T> restList, Func <T, RC_b73f0c67ffc0008d77cac753ae1f90dc> converter) {
  RL_0aebef04a60430d62276d7923db3605d result = new RL_0aebef04a60430d62276d7923db3605d();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_0aebef04a60430d62276d7923db3605d() : base() {
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
protected override OSList<RC_b73f0c67ffc0008d77cac753ae1f90dc> NewList() {
return new RL_0aebef04a60430d62276d7923db3605d();
}


} // RL_0aebef04a60430d62276d7923db3605d
}

