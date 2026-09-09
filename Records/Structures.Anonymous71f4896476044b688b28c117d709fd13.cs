namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (ZIn0cQR2aEuLKMEX1wn9Ew)
///  <code>RC_9c2c2f8777df5db915ea9753325ce8dd</code> that represent
/// s <code>ApprovalProcessProcessTypeRecord</code> <p>Description: </p>
/// </summary>
// Name: ApprovalProcessProcessTypeRecord
public partial struct RC_9c2c2f8777df5db915ea9753325ce8dd : ITypedRecord<RC_9c2c2f8777df5db915ea9753325ce8dd> {
internal static readonly GlobalObjectKey IdApprovalProcess = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*uHi98ulqoLu0bMXYgUg0rw");
internal static readonly GlobalObjectKey IdProcessType = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*TDvH75U7aVkZF+fCU2ryJw");

public EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord ssENApprovalProcess;

public EN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord ssENProcessType;


public BitArray OptimizedAttributes;

public RC_9c2c2f8777df5db915ea9753325ce8dd() {
OptimizedAttributes = null;
ssENApprovalProcess = new EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord();
ssENProcessType = new EN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(19,false);
    all[1] = new BitArray(5,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENApprovalProcess.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENProcessType.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENApprovalProcess.OptimizedAttributes = value[0];
    ssENProcessType.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENApprovalProcess.OptimizedAttributes;
    all[1] = ssENProcessType.OptimizedAttributes;
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
ssENProcessType.Read( r, ref index);
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
public void ReadIM(RC_9c2c2f8777df5db915ea9753325ce8dd r) {
this = r;
}


public static bool operator == (RC_9c2c2f8777df5db915ea9753325ce8dd a, RC_9c2c2f8777df5db915ea9753325ce8dd b) {
if (a.ssENApprovalProcess != b.ssENApprovalProcess) return false;
if (a.ssENProcessType != b.ssENProcessType) return false;
return true;
}

public static bool operator != (RC_9c2c2f8777df5db915ea9753325ce8dd a, RC_9c2c2f8777df5db915ea9753325ce8dd b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_9c2c2f8777df5db915ea9753325ce8dd)) return false;
return (this == (RC_9c2c2f8777df5db915ea9753325ce8dd)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENApprovalProcess.GetHashCode()
 ^ ssENProcessType.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENApprovalProcess.RecursiveReset();
ssENProcessType.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENApprovalProcess.InternalRecursiveSave();
ssENProcessType.InternalRecursiveSave();
}


public RC_9c2c2f8777df5db915ea9753325ce8dd Duplicate() {
RC_9c2c2f8777df5db915ea9753325ce8dd t;
t.ssENApprovalProcess = (EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord)this.ssENApprovalProcess.Duplicate();
t.ssENProcessType = (EN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord)this.ssENProcessType.Duplicate();
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
} else if (head == "processtype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProcessType")) variable.Value = ssENProcessType; else variable.Optimized = true;
variable.SetFieldName("processtype");
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
if (key == IdProcessType) {
return ssENProcessType;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdApprovalProcess.Key.AsGuid) {
return ssENApprovalProcess;
}
if (attributeKey == IdProcessType.Key.AsGuid) {
return ssENProcessType;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENApprovalProcess.FillFromOther((IRecord) other.AttributeGet(IdApprovalProcess));
ssENProcessType.FillFromOther((IRecord) other.AttributeGet(IdProcessType));
}
} // RC_9c2c2f8777df5db915ea9753325ce8dd
/// <summary>
/// RecordList type <code>ApprovalProcessProcessTypeRecordList</code> that represents a record list of
///  <code>ApprovalProcess, ProcessType</code>
/// </summary>
public partial class RL_acd66b694d90eb775616e6c6e3f83477 : GenericRecordList<RC_9c2c2f8777df5db915ea9753325ce8dd>, IEnumerable, IEnumerator {

protected override RC_9c2c2f8777df5db915ea9753325ce8dd GetElementDefaultValue() {
return new RC_9c2c2f8777df5db915ea9753325ce8dd();
}

public T[] ToArray<T>(Func<RC_9c2c2f8777df5db915ea9753325ce8dd, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_acd66b694d90eb775616e6c6e3f83477 recordList, Func<RC_9c2c2f8777df5db915ea9753325ce8dd, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_acd66b694d90eb775616e6c6e3f83477(RC_9c2c2f8777df5db915ea9753325ce8dd[] array) {
  RL_acd66b694d90eb775616e6c6e3f83477 result = new RL_acd66b694d90eb775616e6c6e3f83477();
result.InnerFromArray(array);
    return result;
}

public static RL_acd66b694d90eb775616e6c6e3f83477 ToList<T>(T[] array, Func <T, RC_9c2c2f8777df5db915ea9753325ce8dd> converter) {
  RL_acd66b694d90eb775616e6c6e3f83477 result = new RL_acd66b694d90eb775616e6c6e3f83477();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_acd66b694d90eb775616e6c6e3f83477 FromRestList<T>(RestList<T> restList, Func <T, RC_9c2c2f8777df5db915ea9753325ce8dd> converter) {
  RL_acd66b694d90eb775616e6c6e3f83477 result = new RL_acd66b694d90eb775616e6c6e3f83477();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_acd66b694d90eb775616e6c6e3f83477() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(19,false);
def[1] = new BitArray(5,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_9c2c2f8777df5db915ea9753325ce8dd> NewList() {
return new RL_acd66b694d90eb775616e6c6e3f83477();
}


} // RL_acd66b694d90eb775616e6c6e3f83477
}

