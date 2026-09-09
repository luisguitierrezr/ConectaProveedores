namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (ERdl91MHKkOmASHpCuaALQ)
///  <code>RC_f2bd78b86ae9bba0b46cc5d8814834af</code> that represents <code>ApprovalProcessRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: ApprovalProcessRecord
public partial struct RC_f2bd78b86ae9bba0b46cc5d8814834af : ITypedRecord<RC_f2bd78b86ae9bba0b46cc5d8814834af> {
internal static readonly GlobalObjectKey IdApprovalProcess = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*uHi98ulqoLu0bMXYgUg0rw");

public EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord ssENApprovalProcess;


public static implicit operator EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord( RC_f2bd78b86ae9bba0b46cc5d8814834af r) {
return r.ssENApprovalProcess;
}

public static implicit operator RC_f2bd78b86ae9bba0b46cc5d8814834af (EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord r) {
RC_f2bd78b86ae9bba0b46cc5d8814834af res = new RC_f2bd78b86ae9bba0b46cc5d8814834af ();
res.ssENApprovalProcess = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENApprovalProcess.ChangedAttributes = value;
}
get {
    return ssENApprovalProcess.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_f2bd78b86ae9bba0b46cc5d8814834af() {
OptimizedAttributes = null;
ssENApprovalProcess = new EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(19,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENApprovalProcess.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENApprovalProcess.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENApprovalProcess.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENApprovalProcess.Read( r, ref index);
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
public void ReadIM(RC_f2bd78b86ae9bba0b46cc5d8814834af r) {
this = r;
}


public static bool operator == (RC_f2bd78b86ae9bba0b46cc5d8814834af a, RC_f2bd78b86ae9bba0b46cc5d8814834af b) {
if (a.ssENApprovalProcess != b.ssENApprovalProcess) return false;
return true;
}

public static bool operator != (RC_f2bd78b86ae9bba0b46cc5d8814834af a, RC_f2bd78b86ae9bba0b46cc5d8814834af b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_f2bd78b86ae9bba0b46cc5d8814834af)) return false;
return (this == (RC_f2bd78b86ae9bba0b46cc5d8814834af)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENApprovalProcess.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENApprovalProcess.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENApprovalProcess.InternalRecursiveSave();
}


public RC_f2bd78b86ae9bba0b46cc5d8814834af Duplicate() {
RC_f2bd78b86ae9bba0b46cc5d8814834af t;
t.ssENApprovalProcess = (EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord)this.ssENApprovalProcess.Duplicate();
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
if (head == "approvalprocess") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApprovalProcess")) variable.Value = ssENApprovalProcess; else variable.Optimized = true;
variable.SetFieldName("approvalprocess");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENApprovalProcess.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENApprovalProcess.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdApprovalProcess) {
return ssENApprovalProcess;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdApprovalProcess.Key.AsGuid) {
return ssENApprovalProcess;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENApprovalProcess.FillFromOther((IRecord) other.AttributeGet(IdApprovalProcess));
}
} // RC_f2bd78b86ae9bba0b46cc5d8814834af
/// <summary>
/// RecordList type <code>ApprovalProcessRecordList</code> that represents a record list of
///  <code>ApprovalProcess</code>
/// </summary>
public partial class RL_5e0ca6ca9da3af4b1d8149758c39c2cf : GenericRecordList<RC_f2bd78b86ae9bba0b46cc5d8814834af>, IEnumerable, IEnumerator {

protected override RC_f2bd78b86ae9bba0b46cc5d8814834af GetElementDefaultValue() {
return new RC_f2bd78b86ae9bba0b46cc5d8814834af();
}

public T[] ToArray<T>(Func<RC_f2bd78b86ae9bba0b46cc5d8814834af, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_5e0ca6ca9da3af4b1d8149758c39c2cf recordList, Func<RC_f2bd78b86ae9bba0b46cc5d8814834af, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_5e0ca6ca9da3af4b1d8149758c39c2cf(RC_f2bd78b86ae9bba0b46cc5d8814834af[] array) {
  RL_5e0ca6ca9da3af4b1d8149758c39c2cf result = new RL_5e0ca6ca9da3af4b1d8149758c39c2cf();
result.InnerFromArray(array);
    return result;
}

public static RL_5e0ca6ca9da3af4b1d8149758c39c2cf ToList<T>(T[] array, Func <T, RC_f2bd78b86ae9bba0b46cc5d8814834af> converter) {
  RL_5e0ca6ca9da3af4b1d8149758c39c2cf result = new RL_5e0ca6ca9da3af4b1d8149758c39c2cf();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_5e0ca6ca9da3af4b1d8149758c39c2cf FromRestList<T>(RestList<T> restList, Func <T, RC_f2bd78b86ae9bba0b46cc5d8814834af> converter) {
  RL_5e0ca6ca9da3af4b1d8149758c39c2cf result = new RL_5e0ca6ca9da3af4b1d8149758c39c2cf();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_5e0ca6ca9da3af4b1d8149758c39c2cf() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(19,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_f2bd78b86ae9bba0b46cc5d8814834af> NewList() {
return new RL_5e0ca6ca9da3af4b1d8149758c39c2cf();
}


} // RL_5e0ca6ca9da3af4b1d8149758c39c2cf
}

