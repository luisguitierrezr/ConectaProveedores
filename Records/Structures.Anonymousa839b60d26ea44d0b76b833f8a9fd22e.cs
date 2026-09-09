namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (DbY5qOom0ES3a4M_ip_SLg)
///  <code>RC_3cc958ea69e2da94e66c1d6c79d0b67f</code> that represent
/// s <code>ApprovalProcessLevelApprovalProcessApplicationRoleRecord</code> <p>Description: </p>
/// </summary>
// Name: ApprovalProcessLevelApprovalProcessApplicationRoleRecord
public partial struct RC_3cc958ea69e2da94e66c1d6c79d0b67f : ITypedRecord<RC_3cc958ea69e2da94e66c1d6c79d0b67f> {
internal static readonly GlobalObjectKey IdApprovalProcessLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*xC_Afjv04bYAUGRMjBrjGw");
internal static readonly GlobalObjectKey IdApprovalProcess = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*uHi98ulqoLu0bMXYgUg0rw");
internal static readonly GlobalObjectKey IdApplicationRole = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Q0fszuVdwmNpC2BezKaalA");

public EN_1d28318723f39133c60733b3cce8955eEntityRecord ssENApprovalProcessLevel;

public EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord ssENApprovalProcess;

public EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord ssENApplicationRole;


public BitArray OptimizedAttributes;

public RC_3cc958ea69e2da94e66c1d6c79d0b67f() {
OptimizedAttributes = null;
ssENApprovalProcessLevel = new EN_1d28318723f39133c60733b3cce8955eEntityRecord();
ssENApprovalProcess = new EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord();
ssENApplicationRole = new EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = new BitArray(26,false);
    all[1] = new BitArray(19,false);
    all[2] = new BitArray(7,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENApprovalProcessLevel.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENApprovalProcess.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENApplicationRole.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    }else{
    ssENApprovalProcessLevel.OptimizedAttributes = value[0];
    ssENApprovalProcess.OptimizedAttributes = value[1];
    ssENApplicationRole.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = ssENApprovalProcessLevel.OptimizedAttributes;
    all[1] = ssENApprovalProcess.OptimizedAttributes;
    all[2] = ssENApplicationRole.OptimizedAttributes;
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
ssENApplicationRole.Read( r, ref index);
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
public void ReadIM(RC_3cc958ea69e2da94e66c1d6c79d0b67f r) {
this = r;
}


public static bool operator == (RC_3cc958ea69e2da94e66c1d6c79d0b67f a, RC_3cc958ea69e2da94e66c1d6c79d0b67f b) {
if (a.ssENApprovalProcessLevel != b.ssENApprovalProcessLevel) return false;
if (a.ssENApprovalProcess != b.ssENApprovalProcess) return false;
if (a.ssENApplicationRole != b.ssENApplicationRole) return false;
return true;
}

public static bool operator != (RC_3cc958ea69e2da94e66c1d6c79d0b67f a, RC_3cc958ea69e2da94e66c1d6c79d0b67f b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_3cc958ea69e2da94e66c1d6c79d0b67f)) return false;
return (this == (RC_3cc958ea69e2da94e66c1d6c79d0b67f)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENApprovalProcessLevel.GetHashCode()
 ^ ssENApprovalProcess.GetHashCode()
 ^ ssENApplicationRole.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENApprovalProcessLevel.RecursiveReset();
ssENApprovalProcess.RecursiveReset();
ssENApplicationRole.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENApprovalProcessLevel.InternalRecursiveSave();
ssENApprovalProcess.InternalRecursiveSave();
ssENApplicationRole.InternalRecursiveSave();
}


public RC_3cc958ea69e2da94e66c1d6c79d0b67f Duplicate() {
RC_3cc958ea69e2da94e66c1d6c79d0b67f t;
t.ssENApprovalProcessLevel = (EN_1d28318723f39133c60733b3cce8955eEntityRecord)this.ssENApprovalProcessLevel.Duplicate();
t.ssENApprovalProcess = (EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord)this.ssENApprovalProcess.Duplicate();
t.ssENApplicationRole = (EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord)this.ssENApplicationRole.Duplicate();
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
} else if (head == "applicationrole") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApplicationRole")) variable.Value = ssENApplicationRole; else variable.Optimized = true;
variable.SetFieldName("applicationrole");
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
if (key == IdApplicationRole) {
return ssENApplicationRole;
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
if (attributeKey == IdApplicationRole.Key.AsGuid) {
return ssENApplicationRole;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENApprovalProcessLevel.FillFromOther((IRecord) other.AttributeGet(IdApprovalProcessLevel));
ssENApprovalProcess.FillFromOther((IRecord) other.AttributeGet(IdApprovalProcess));
ssENApplicationRole.FillFromOther((IRecord) other.AttributeGet(IdApplicationRole));
}
} // RC_3cc958ea69e2da94e66c1d6c79d0b67f
/// <summary>
/// RecordList type <code>ApprovalProcessLevelApprovalProcessApplicationRoleRecordList</code> that
///  represents a record list of <code>ApprovalProcessLevel, ApprovalProcess, ApplicationRole</code>
/// </summary>
public partial class RL_4248243a08e8c50cd9576752f087e472 : GenericRecordList<RC_3cc958ea69e2da94e66c1d6c79d0b67f>, IEnumerable, IEnumerator {

protected override RC_3cc958ea69e2da94e66c1d6c79d0b67f GetElementDefaultValue() {
return new RC_3cc958ea69e2da94e66c1d6c79d0b67f();
}

public T[] ToArray<T>(Func<RC_3cc958ea69e2da94e66c1d6c79d0b67f, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_4248243a08e8c50cd9576752f087e472 recordList, Func<RC_3cc958ea69e2da94e66c1d6c79d0b67f, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_4248243a08e8c50cd9576752f087e472(RC_3cc958ea69e2da94e66c1d6c79d0b67f[] array) {
  RL_4248243a08e8c50cd9576752f087e472 result = new RL_4248243a08e8c50cd9576752f087e472();
result.InnerFromArray(array);
    return result;
}

public static RL_4248243a08e8c50cd9576752f087e472 ToList<T>(T[] array, Func <T, RC_3cc958ea69e2da94e66c1d6c79d0b67f> converter) {
  RL_4248243a08e8c50cd9576752f087e472 result = new RL_4248243a08e8c50cd9576752f087e472();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_4248243a08e8c50cd9576752f087e472 FromRestList<T>(RestList<T> restList, Func <T, RC_3cc958ea69e2da94e66c1d6c79d0b67f> converter) {
  RL_4248243a08e8c50cd9576752f087e472 result = new RL_4248243a08e8c50cd9576752f087e472();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_4248243a08e8c50cd9576752f087e472() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = new BitArray(26,false);
def[1] = new BitArray(19,false);
def[2] = new BitArray(7,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_3cc958ea69e2da94e66c1d6c79d0b67f> NewList() {
return new RL_4248243a08e8c50cd9576752f087e472();
}


} // RL_4248243a08e8c50cd9576752f087e472
}

