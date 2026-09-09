namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (8f0GrsQWwUSLCkEbgJFJ4A)
///  <code>RC_8cfc2af1075444d3070aa6269dcfdf32</code> that represent
/// s <code>ApprovalProcessProcessTypeApprovalProcessTypeRecord</code> <p>Description: </p>
/// </summary>
// Name: ApprovalProcessProcessTypeApprovalProcessTypeRecord
public partial struct RC_8cfc2af1075444d3070aa6269dcfdf32 : ITypedRecord<RC_8cfc2af1075444d3070aa6269dcfdf32> {
internal static readonly GlobalObjectKey IdApprovalProcess = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*uHi98ulqoLu0bMXYgUg0rw");
internal static readonly GlobalObjectKey IdProcessType = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*TDvH75U7aVkZF+fCU2ryJw");
internal static readonly GlobalObjectKey IdApprovalProcessType = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*3A7bZn7_sKmqJY4zWt0czA");

public EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord ssENApprovalProcess;

public EN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord ssENProcessType;

public EN_51146e8018c571ce25065b00ce0d3a4dEntityRecord ssENApprovalProcessType;


public BitArray OptimizedAttributes;

public RC_8cfc2af1075444d3070aa6269dcfdf32() {
OptimizedAttributes = null;
ssENApprovalProcess = new EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord();
ssENProcessType = new EN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord();
ssENApprovalProcessType = new EN_51146e8018c571ce25065b00ce0d3a4dEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = new BitArray(19,false);
    all[1] = new BitArray(5,false);
    all[2] = new BitArray(5,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENApprovalProcess.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENProcessType.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENApprovalProcessType.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    }else{
    ssENApprovalProcess.OptimizedAttributes = value[0];
    ssENProcessType.OptimizedAttributes = value[1];
    ssENApprovalProcessType.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = ssENApprovalProcess.OptimizedAttributes;
    all[1] = ssENProcessType.OptimizedAttributes;
    all[2] = ssENApprovalProcessType.OptimizedAttributes;
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
ssENApprovalProcessType.Read( r, ref index);
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
public void ReadIM(RC_8cfc2af1075444d3070aa6269dcfdf32 r) {
this = r;
}


public static bool operator == (RC_8cfc2af1075444d3070aa6269dcfdf32 a, RC_8cfc2af1075444d3070aa6269dcfdf32 b) {
if (a.ssENApprovalProcess != b.ssENApprovalProcess) return false;
if (a.ssENProcessType != b.ssENProcessType) return false;
if (a.ssENApprovalProcessType != b.ssENApprovalProcessType) return false;
return true;
}

public static bool operator != (RC_8cfc2af1075444d3070aa6269dcfdf32 a, RC_8cfc2af1075444d3070aa6269dcfdf32 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_8cfc2af1075444d3070aa6269dcfdf32)) return false;
return (this == (RC_8cfc2af1075444d3070aa6269dcfdf32)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENApprovalProcess.GetHashCode()
 ^ ssENProcessType.GetHashCode()
 ^ ssENApprovalProcessType.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENApprovalProcess.RecursiveReset();
ssENProcessType.RecursiveReset();
ssENApprovalProcessType.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENApprovalProcess.InternalRecursiveSave();
ssENProcessType.InternalRecursiveSave();
ssENApprovalProcessType.InternalRecursiveSave();
}


public RC_8cfc2af1075444d3070aa6269dcfdf32 Duplicate() {
RC_8cfc2af1075444d3070aa6269dcfdf32 t;
t.ssENApprovalProcess = (EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord)this.ssENApprovalProcess.Duplicate();
t.ssENProcessType = (EN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord)this.ssENProcessType.Duplicate();
t.ssENApprovalProcessType = (EN_51146e8018c571ce25065b00ce0d3a4dEntityRecord)this.ssENApprovalProcessType.Duplicate();
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
} else if (head == "approvalprocesstype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApprovalProcessType")) variable.Value = ssENApprovalProcessType; else variable.Optimized = true;
variable.SetFieldName("approvalprocesstype");
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
if (key == IdApprovalProcessType) {
return ssENApprovalProcessType;
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
if (attributeKey == IdApprovalProcessType.Key.AsGuid) {
return ssENApprovalProcessType;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENApprovalProcess.FillFromOther((IRecord) other.AttributeGet(IdApprovalProcess));
ssENProcessType.FillFromOther((IRecord) other.AttributeGet(IdProcessType));
ssENApprovalProcessType.FillFromOther((IRecord) other.AttributeGet(IdApprovalProcessType));
}
} // RC_8cfc2af1075444d3070aa6269dcfdf32
/// <summary>
/// RecordList type <code>ApprovalProcessProcessTypeApprovalProcessTypeRecordList</code> that
///  represents a record list of <code>ApprovalProcess, ProcessType, ApprovalProcessType</code>
/// </summary>
public partial class RL_5c614a706e3e33b4caf55ba997e805be : GenericRecordList<RC_8cfc2af1075444d3070aa6269dcfdf32>, IEnumerable, IEnumerator {

protected override RC_8cfc2af1075444d3070aa6269dcfdf32 GetElementDefaultValue() {
return new RC_8cfc2af1075444d3070aa6269dcfdf32();
}

public T[] ToArray<T>(Func<RC_8cfc2af1075444d3070aa6269dcfdf32, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_5c614a706e3e33b4caf55ba997e805be recordList, Func<RC_8cfc2af1075444d3070aa6269dcfdf32, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_5c614a706e3e33b4caf55ba997e805be(RC_8cfc2af1075444d3070aa6269dcfdf32[] array) {
  RL_5c614a706e3e33b4caf55ba997e805be result = new RL_5c614a706e3e33b4caf55ba997e805be();
result.InnerFromArray(array);
    return result;
}

public static RL_5c614a706e3e33b4caf55ba997e805be ToList<T>(T[] array, Func <T, RC_8cfc2af1075444d3070aa6269dcfdf32> converter) {
  RL_5c614a706e3e33b4caf55ba997e805be result = new RL_5c614a706e3e33b4caf55ba997e805be();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_5c614a706e3e33b4caf55ba997e805be FromRestList<T>(RestList<T> restList, Func <T, RC_8cfc2af1075444d3070aa6269dcfdf32> converter) {
  RL_5c614a706e3e33b4caf55ba997e805be result = new RL_5c614a706e3e33b4caf55ba997e805be();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_5c614a706e3e33b4caf55ba997e805be() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = new BitArray(19,false);
def[1] = new BitArray(5,false);
def[2] = new BitArray(5,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_8cfc2af1075444d3070aa6269dcfdf32> NewList() {
return new RL_5c614a706e3e33b4caf55ba997e805be();
}


} // RL_5c614a706e3e33b4caf55ba997e805be
}

