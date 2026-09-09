namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (MemTKjZXXUq9nI2bcpfJkA)
///  <code>RC_1656f1642ecd1940e7209799a9d01108</code> that represent
/// s <code>ApprovalProcessLevelApprovalProcessProcessTypeApprovalProcessTypeRecord</code>
///  <p>Description: </p>
/// </summary>
// Name: ApprovalProcessLevelApprovalProcessProcessTypeApprovalProcessTypeRecord
public partial struct RC_1656f1642ecd1940e7209799a9d01108 : ITypedRecord<RC_1656f1642ecd1940e7209799a9d01108> {
internal static readonly GlobalObjectKey IdApprovalProcessLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*xC_Afjv04bYAUGRMjBrjGw");
internal static readonly GlobalObjectKey IdApprovalProcess = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*uHi98ulqoLu0bMXYgUg0rw");
internal static readonly GlobalObjectKey IdProcessType = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*TDvH75U7aVkZF+fCU2ryJw");
internal static readonly GlobalObjectKey IdApprovalProcessType = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*3A7bZn7_sKmqJY4zWt0czA");

public EN_1d28318723f39133c60733b3cce8955eEntityRecord ssENApprovalProcessLevel;

public EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord ssENApprovalProcess;

public EN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord ssENProcessType;

public EN_51146e8018c571ce25065b00ce0d3a4dEntityRecord ssENApprovalProcessType;


public BitArray OptimizedAttributes;

public RC_1656f1642ecd1940e7209799a9d01108() {
OptimizedAttributes = null;
ssENApprovalProcessLevel = new EN_1d28318723f39133c60733b3cce8955eEntityRecord();
ssENApprovalProcess = new EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord();
ssENProcessType = new EN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord();
ssENApprovalProcessType = new EN_51146e8018c571ce25065b00ce0d3a4dEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[4];
    all[0] = new BitArray(26,false);
    all[1] = new BitArray(19,false);
    all[2] = new BitArray(5,false);
    all[3] = new BitArray(5,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENApprovalProcessLevel.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENApprovalProcess.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENProcessType.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENApprovalProcessType.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    }else{
    ssENApprovalProcessLevel.OptimizedAttributes = value[0];
    ssENApprovalProcess.OptimizedAttributes = value[1];
    ssENProcessType.OptimizedAttributes = value[2];
    ssENApprovalProcessType.OptimizedAttributes = value[3];
    }
}
get{
    BitArray[] all = new BitArray[4];
    all[0] = ssENApprovalProcessLevel.OptimizedAttributes;
    all[1] = ssENApprovalProcess.OptimizedAttributes;
    all[2] = ssENProcessType.OptimizedAttributes;
    all[3] = ssENApprovalProcessType.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENApprovalProcessLevel.Read( r, ref index);
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
public void ReadIM(RC_1656f1642ecd1940e7209799a9d01108 r) {
this = r;
}


public static bool operator == (RC_1656f1642ecd1940e7209799a9d01108 a, RC_1656f1642ecd1940e7209799a9d01108 b) {
if (a.ssENApprovalProcessLevel != b.ssENApprovalProcessLevel) return false;
if (a.ssENApprovalProcess != b.ssENApprovalProcess) return false;
if (a.ssENProcessType != b.ssENProcessType) return false;
if (a.ssENApprovalProcessType != b.ssENApprovalProcessType) return false;
return true;
}

public static bool operator != (RC_1656f1642ecd1940e7209799a9d01108 a, RC_1656f1642ecd1940e7209799a9d01108 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_1656f1642ecd1940e7209799a9d01108)) return false;
return (this == (RC_1656f1642ecd1940e7209799a9d01108)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENApprovalProcessLevel.GetHashCode()
 ^ ssENApprovalProcess.GetHashCode()
 ^ ssENProcessType.GetHashCode()
 ^ ssENApprovalProcessType.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENApprovalProcessLevel.RecursiveReset();
ssENApprovalProcess.RecursiveReset();
ssENProcessType.RecursiveReset();
ssENApprovalProcessType.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENApprovalProcessLevel.InternalRecursiveSave();
ssENApprovalProcess.InternalRecursiveSave();
ssENProcessType.InternalRecursiveSave();
ssENApprovalProcessType.InternalRecursiveSave();
}


public RC_1656f1642ecd1940e7209799a9d01108 Duplicate() {
RC_1656f1642ecd1940e7209799a9d01108 t;
t.ssENApprovalProcessLevel = (EN_1d28318723f39133c60733b3cce8955eEntityRecord)this.ssENApprovalProcessLevel.Duplicate();
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
if (head == "approvalprocesslevel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApprovalProcessLevel")) variable.Value = ssENApprovalProcessLevel; else variable.Optimized = true;
variable.SetFieldName("approvalprocesslevel");
} else if (head == "approvalprocess") {
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
if (key == IdApprovalProcessLevel) {
return ssENApprovalProcessLevel;
}
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
if (attributeKey == IdApprovalProcessLevel.Key.AsGuid) {
return ssENApprovalProcessLevel;
}
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
ssENApprovalProcessLevel.FillFromOther((IRecord) other.AttributeGet(IdApprovalProcessLevel));
ssENApprovalProcess.FillFromOther((IRecord) other.AttributeGet(IdApprovalProcess));
ssENProcessType.FillFromOther((IRecord) other.AttributeGet(IdProcessType));
ssENApprovalProcessType.FillFromOther((IRecord) other.AttributeGet(IdApprovalProcessType));
}
} // RC_1656f1642ecd1940e7209799a9d01108
/// <summary>
/// RecordList type
///  <code>ApprovalProcessLevelApprovalProcessProcessTypeApprovalProcessTypeRecordList</code> tha
/// t represents a record list of <code>ApprovalProcessLevel, ApprovalProcess, ProcessType,
///  ApprovalProcessType</code>
/// </summary>
public partial class RL_d30d6a47e9033f9c40a63ba3cf4c4c63 : GenericRecordList<RC_1656f1642ecd1940e7209799a9d01108>, IEnumerable, IEnumerator {

protected override RC_1656f1642ecd1940e7209799a9d01108 GetElementDefaultValue() {
return new RC_1656f1642ecd1940e7209799a9d01108();
}

public T[] ToArray<T>(Func<RC_1656f1642ecd1940e7209799a9d01108, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_d30d6a47e9033f9c40a63ba3cf4c4c63 recordList, Func<RC_1656f1642ecd1940e7209799a9d01108, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_d30d6a47e9033f9c40a63ba3cf4c4c63(RC_1656f1642ecd1940e7209799a9d01108[] array) {
  RL_d30d6a47e9033f9c40a63ba3cf4c4c63 result = new RL_d30d6a47e9033f9c40a63ba3cf4c4c63();
result.InnerFromArray(array);
    return result;
}

public static RL_d30d6a47e9033f9c40a63ba3cf4c4c63 ToList<T>(T[] array, Func <T, RC_1656f1642ecd1940e7209799a9d01108> converter) {
  RL_d30d6a47e9033f9c40a63ba3cf4c4c63 result = new RL_d30d6a47e9033f9c40a63ba3cf4c4c63();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_d30d6a47e9033f9c40a63ba3cf4c4c63 FromRestList<T>(RestList<T> restList, Func <T, RC_1656f1642ecd1940e7209799a9d01108> converter) {
  RL_d30d6a47e9033f9c40a63ba3cf4c4c63 result = new RL_d30d6a47e9033f9c40a63ba3cf4c4c63();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_d30d6a47e9033f9c40a63ba3cf4c4c63() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[4];
def[0] = new BitArray(26,false);
def[1] = new BitArray(19,false);
def[2] = new BitArray(5,false);
def[3] = new BitArray(5,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_1656f1642ecd1940e7209799a9d01108> NewList() {
return new RL_d30d6a47e9033f9c40a63ba3cf4c4c63();
}


} // RL_d30d6a47e9033f9c40a63ba3cf4c4c63
}

