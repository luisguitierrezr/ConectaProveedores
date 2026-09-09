namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (Ln92Q6gylUSPy7uthFOb6w)
///  <code>RC_65930e54edca87f73a766a2aa044190e</code> that represent
/// s <code>ApprovalProcessAccountingRegionRecord</code> <p>Description: </p>
/// </summary>
// Name: ApprovalProcessAccountingRegionRecord
public partial struct RC_65930e54edca87f73a766a2aa044190e : ITypedRecord<RC_65930e54edca87f73a766a2aa044190e> {
internal static readonly GlobalObjectKey IdApprovalProcess = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*uHi98ulqoLu0bMXYgUg0rw");
internal static readonly GlobalObjectKey IdAccountingRegion = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*PhXK07hjjvK7PRKvXmYkDw");

public EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord ssENApprovalProcess;

public EN_31f501c551d210017fcb34b5237e3390EntityRecord ssENAccountingRegion;


public BitArray OptimizedAttributes;

public RC_65930e54edca87f73a766a2aa044190e() {
OptimizedAttributes = null;
ssENApprovalProcess = new EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord();
ssENAccountingRegion = new EN_31f501c551d210017fcb34b5237e3390EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(19,false);
    all[1] = new BitArray(13,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENApprovalProcess.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENAccountingRegion.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENApprovalProcess.OptimizedAttributes = value[0];
    ssENAccountingRegion.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENApprovalProcess.OptimizedAttributes;
    all[1] = ssENAccountingRegion.OptimizedAttributes;
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
ssENAccountingRegion.Read( r, ref index);
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
public void ReadIM(RC_65930e54edca87f73a766a2aa044190e r) {
this = r;
}


public static bool operator == (RC_65930e54edca87f73a766a2aa044190e a, RC_65930e54edca87f73a766a2aa044190e b) {
if (a.ssENApprovalProcess != b.ssENApprovalProcess) return false;
if (a.ssENAccountingRegion != b.ssENAccountingRegion) return false;
return true;
}

public static bool operator != (RC_65930e54edca87f73a766a2aa044190e a, RC_65930e54edca87f73a766a2aa044190e b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_65930e54edca87f73a766a2aa044190e)) return false;
return (this == (RC_65930e54edca87f73a766a2aa044190e)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENApprovalProcess.GetHashCode()
 ^ ssENAccountingRegion.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENApprovalProcess.RecursiveReset();
ssENAccountingRegion.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENApprovalProcess.InternalRecursiveSave();
ssENAccountingRegion.InternalRecursiveSave();
}


public RC_65930e54edca87f73a766a2aa044190e Duplicate() {
RC_65930e54edca87f73a766a2aa044190e t;
t.ssENApprovalProcess = (EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord)this.ssENApprovalProcess.Duplicate();
t.ssENAccountingRegion = (EN_31f501c551d210017fcb34b5237e3390EntityRecord)this.ssENAccountingRegion.Duplicate();
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
} else if (head == "accountingregion") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AccountingRegion")) variable.Value = ssENAccountingRegion; else variable.Optimized = true;
variable.SetFieldName("accountingregion");
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
if (key == IdApprovalProcess) {
return ssENApprovalProcess;
}
if (key == IdAccountingRegion) {
return ssENAccountingRegion;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdApprovalProcess.Key.AsGuid) {
return ssENApprovalProcess;
}
if (attributeKey == IdAccountingRegion.Key.AsGuid) {
return ssENAccountingRegion;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENApprovalProcess.FillFromOther((IRecord) other.AttributeGet(IdApprovalProcess));
ssENAccountingRegion.FillFromOther((IRecord) other.AttributeGet(IdAccountingRegion));
}
} // RC_65930e54edca87f73a766a2aa044190e
/// <summary>
/// RecordList type <code>ApprovalProcessAccountingRegionRecordList</code> that represents a record
///  list of <code>ApprovalProcess, Region</code>
/// </summary>
public partial class RL_c7dc90026b82e43b2c9200700d23fd68 : GenericRecordList<RC_65930e54edca87f73a766a2aa044190e>, IEnumerable, IEnumerator {

protected override RC_65930e54edca87f73a766a2aa044190e GetElementDefaultValue() {
return new RC_65930e54edca87f73a766a2aa044190e();
}

public T[] ToArray<T>(Func<RC_65930e54edca87f73a766a2aa044190e, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_c7dc90026b82e43b2c9200700d23fd68 recordList, Func<RC_65930e54edca87f73a766a2aa044190e, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_c7dc90026b82e43b2c9200700d23fd68(RC_65930e54edca87f73a766a2aa044190e[] array) {
  RL_c7dc90026b82e43b2c9200700d23fd68 result = new RL_c7dc90026b82e43b2c9200700d23fd68();
result.InnerFromArray(array);
    return result;
}

public static RL_c7dc90026b82e43b2c9200700d23fd68 ToList<T>(T[] array, Func <T, RC_65930e54edca87f73a766a2aa044190e> converter) {
  RL_c7dc90026b82e43b2c9200700d23fd68 result = new RL_c7dc90026b82e43b2c9200700d23fd68();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_c7dc90026b82e43b2c9200700d23fd68 FromRestList<T>(RestList<T> restList, Func <T, RC_65930e54edca87f73a766a2aa044190e> converter) {
  RL_c7dc90026b82e43b2c9200700d23fd68 result = new RL_c7dc90026b82e43b2c9200700d23fd68();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_c7dc90026b82e43b2c9200700d23fd68() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(19,false);
def[1] = new BitArray(13,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_65930e54edca87f73a766a2aa044190e> NewList() {
return new RL_c7dc90026b82e43b2c9200700d23fd68();
}


} // RL_c7dc90026b82e43b2c9200700d23fd68
}

