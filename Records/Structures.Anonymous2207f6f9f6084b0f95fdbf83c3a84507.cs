namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (+fYHIgj2D0uV_b+Dw6hFBw)
///  <code>RC_01911a773916dfcf99bb546f23183cea</code> that represent
/// s <code>ApprovalProcessApprovalProcessMatrixRegionRecord</code> <p>Description: </p>
/// </summary>
// Name: ApprovalProcessApprovalProcessMatrixRegionRecord
public partial struct RC_01911a773916dfcf99bb546f23183cea : ITypedRecord<RC_01911a773916dfcf99bb546f23183cea> {
internal static readonly GlobalObjectKey IdApprovalProcess = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*uHi98ulqoLu0bMXYgUg0rw");
internal static readonly GlobalObjectKey IdApprovalProcessMatrix = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*OaTnQEW7lcld4lsd68BlDw");
internal static readonly GlobalObjectKey IdRegion = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*w1243kBmkvqNrl3ySTBl0A");

public EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord ssENApprovalProcess;

public EN_fb6314d818ce8b161376c10b2af51bb9EntityRecord ssENApprovalProcessMatrix;

public EN_31f501c551d210017fcb34b5237e3390EntityRecord ssENRegion;


public BitArray OptimizedAttributes;

public RC_01911a773916dfcf99bb546f23183cea() {
OptimizedAttributes = null;
ssENApprovalProcess = new EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord();
ssENApprovalProcessMatrix = new EN_fb6314d818ce8b161376c10b2af51bb9EntityRecord();
ssENRegion = new EN_31f501c551d210017fcb34b5237e3390EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = new BitArray(19,false);
    all[1] = new BitArray(12,false);
    all[2] = new BitArray(13,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENApprovalProcess.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENApprovalProcessMatrix.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENRegion.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    }else{
    ssENApprovalProcess.OptimizedAttributes = value[0];
    ssENApprovalProcessMatrix.OptimizedAttributes = value[1];
    ssENRegion.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = ssENApprovalProcess.OptimizedAttributes;
    all[1] = ssENApprovalProcessMatrix.OptimizedAttributes;
    all[2] = ssENRegion.OptimizedAttributes;
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
ssENApprovalProcessMatrix.Read( r, ref index);
ssENRegion.Read( r, ref index);
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
public void ReadIM(RC_01911a773916dfcf99bb546f23183cea r) {
this = r;
}


public static bool operator == (RC_01911a773916dfcf99bb546f23183cea a, RC_01911a773916dfcf99bb546f23183cea b) {
if (a.ssENApprovalProcess != b.ssENApprovalProcess) return false;
if (a.ssENApprovalProcessMatrix != b.ssENApprovalProcessMatrix) return false;
if (a.ssENRegion != b.ssENRegion) return false;
return true;
}

public static bool operator != (RC_01911a773916dfcf99bb546f23183cea a, RC_01911a773916dfcf99bb546f23183cea b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_01911a773916dfcf99bb546f23183cea)) return false;
return (this == (RC_01911a773916dfcf99bb546f23183cea)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENApprovalProcess.GetHashCode()
 ^ ssENApprovalProcessMatrix.GetHashCode()
 ^ ssENRegion.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENApprovalProcess.RecursiveReset();
ssENApprovalProcessMatrix.RecursiveReset();
ssENRegion.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENApprovalProcess.InternalRecursiveSave();
ssENApprovalProcessMatrix.InternalRecursiveSave();
ssENRegion.InternalRecursiveSave();
}


public RC_01911a773916dfcf99bb546f23183cea Duplicate() {
RC_01911a773916dfcf99bb546f23183cea t;
t.ssENApprovalProcess = (EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord)this.ssENApprovalProcess.Duplicate();
t.ssENApprovalProcessMatrix = (EN_fb6314d818ce8b161376c10b2af51bb9EntityRecord)this.ssENApprovalProcessMatrix.Duplicate();
t.ssENRegion = (EN_31f501c551d210017fcb34b5237e3390EntityRecord)this.ssENRegion.Duplicate();
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
} else if (head == "approvalprocessmatrix") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApprovalProcessMatrix")) variable.Value = ssENApprovalProcessMatrix; else variable.Optimized = true;
variable.SetFieldName("approvalprocessmatrix");
} else if (head == "region") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Region")) variable.Value = ssENRegion; else variable.Optimized = true;
variable.SetFieldName("region");
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
if (key == IdApprovalProcessMatrix) {
return ssENApprovalProcessMatrix;
}
if (key == IdRegion) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdApprovalProcess.Key.AsGuid) {
return ssENApprovalProcess;
}
if (attributeKey == IdApprovalProcessMatrix.Key.AsGuid) {
return ssENApprovalProcessMatrix;
}
if (attributeKey == IdRegion.Key.AsGuid) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENApprovalProcess.FillFromOther((IRecord) other.AttributeGet(IdApprovalProcess));
ssENApprovalProcessMatrix.FillFromOther((IRecord) other.AttributeGet(IdApprovalProcessMatrix));
ssENRegion.FillFromOther((IRecord) other.AttributeGet(IdRegion));
}
} // RC_01911a773916dfcf99bb546f23183cea
/// <summary>
/// RecordList type <code>ApprovalProcessApprovalProcessMatrixRegionRecordList</code> that represents a
///  record list of <code>ApprovalProcess, ApprovalProcessMatrix, Region</code>
/// </summary>
public partial class RL_21d5457a1d34649ed7b58b58f1d048d5 : GenericRecordList<RC_01911a773916dfcf99bb546f23183cea>, IEnumerable, IEnumerator {

protected override RC_01911a773916dfcf99bb546f23183cea GetElementDefaultValue() {
return new RC_01911a773916dfcf99bb546f23183cea();
}

public T[] ToArray<T>(Func<RC_01911a773916dfcf99bb546f23183cea, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_21d5457a1d34649ed7b58b58f1d048d5 recordList, Func<RC_01911a773916dfcf99bb546f23183cea, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_21d5457a1d34649ed7b58b58f1d048d5(RC_01911a773916dfcf99bb546f23183cea[] array) {
  RL_21d5457a1d34649ed7b58b58f1d048d5 result = new RL_21d5457a1d34649ed7b58b58f1d048d5();
result.InnerFromArray(array);
    return result;
}

public static RL_21d5457a1d34649ed7b58b58f1d048d5 ToList<T>(T[] array, Func <T, RC_01911a773916dfcf99bb546f23183cea> converter) {
  RL_21d5457a1d34649ed7b58b58f1d048d5 result = new RL_21d5457a1d34649ed7b58b58f1d048d5();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_21d5457a1d34649ed7b58b58f1d048d5 FromRestList<T>(RestList<T> restList, Func <T, RC_01911a773916dfcf99bb546f23183cea> converter) {
  RL_21d5457a1d34649ed7b58b58f1d048d5 result = new RL_21d5457a1d34649ed7b58b58f1d048d5();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_21d5457a1d34649ed7b58b58f1d048d5() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = new BitArray(19,false);
def[1] = new BitArray(12,false);
def[2] = new BitArray(13,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_01911a773916dfcf99bb546f23183cea> NewList() {
return new RL_21d5457a1d34649ed7b58b58f1d048d5();
}


} // RL_21d5457a1d34649ed7b58b58f1d048d5
}

