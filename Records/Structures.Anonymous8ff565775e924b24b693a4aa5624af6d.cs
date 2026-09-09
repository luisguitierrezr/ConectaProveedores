namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (d2X1j5JeJEu2k6SqViSvbQ)
///  <code>RC_1c307c6ba13b1609f542644719b6e56b</code> that represent
/// s <code>ApprovalProcessLevelApprovalProcessRecord</code> <p>Description: </p>
/// </summary>
// Name: ApprovalProcessLevelApprovalProcessRecord
public partial struct RC_1c307c6ba13b1609f542644719b6e56b : ITypedRecord<RC_1c307c6ba13b1609f542644719b6e56b> {
internal static readonly GlobalObjectKey IdApprovalProcessLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*xC_Afjv04bYAUGRMjBrjGw");
internal static readonly GlobalObjectKey IdApprovalProcess = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*uHi98ulqoLu0bMXYgUg0rw");

public EN_1d28318723f39133c60733b3cce8955eEntityRecord ssENApprovalProcessLevel;

public EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord ssENApprovalProcess;


public BitArray OptimizedAttributes;

public RC_1c307c6ba13b1609f542644719b6e56b() {
OptimizedAttributes = null;
ssENApprovalProcessLevel = new EN_1d28318723f39133c60733b3cce8955eEntityRecord();
ssENApprovalProcess = new EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(26,false);
    all[1] = new BitArray(19,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENApprovalProcessLevel.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENApprovalProcess.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENApprovalProcessLevel.OptimizedAttributes = value[0];
    ssENApprovalProcess.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENApprovalProcessLevel.OptimizedAttributes;
    all[1] = ssENApprovalProcess.OptimizedAttributes;
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
public void ReadIM(RC_1c307c6ba13b1609f542644719b6e56b r) {
this = r;
}


public static bool operator == (RC_1c307c6ba13b1609f542644719b6e56b a, RC_1c307c6ba13b1609f542644719b6e56b b) {
if (a.ssENApprovalProcessLevel != b.ssENApprovalProcessLevel) return false;
if (a.ssENApprovalProcess != b.ssENApprovalProcess) return false;
return true;
}

public static bool operator != (RC_1c307c6ba13b1609f542644719b6e56b a, RC_1c307c6ba13b1609f542644719b6e56b b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_1c307c6ba13b1609f542644719b6e56b)) return false;
return (this == (RC_1c307c6ba13b1609f542644719b6e56b)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENApprovalProcessLevel.GetHashCode()
 ^ ssENApprovalProcess.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENApprovalProcessLevel.RecursiveReset();
ssENApprovalProcess.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENApprovalProcessLevel.InternalRecursiveSave();
ssENApprovalProcess.InternalRecursiveSave();
}


public RC_1c307c6ba13b1609f542644719b6e56b Duplicate() {
RC_1c307c6ba13b1609f542644719b6e56b t;
t.ssENApprovalProcessLevel = (EN_1d28318723f39133c60733b3cce8955eEntityRecord)this.ssENApprovalProcessLevel.Duplicate();
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
if (head == "approvalprocesslevel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApprovalProcessLevel")) variable.Value = ssENApprovalProcessLevel; else variable.Optimized = true;
variable.SetFieldName("approvalprocesslevel");
} else if (head == "approvalprocess") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApprovalProcess")) variable.Value = ssENApprovalProcess; else variable.Optimized = true;
variable.SetFieldName("approvalprocess");
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
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdApprovalProcessLevel.Key.AsGuid) {
return ssENApprovalProcessLevel;
}
if (attributeKey == IdApprovalProcess.Key.AsGuid) {
return ssENApprovalProcess;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENApprovalProcessLevel.FillFromOther((IRecord) other.AttributeGet(IdApprovalProcessLevel));
ssENApprovalProcess.FillFromOther((IRecord) other.AttributeGet(IdApprovalProcess));
}
} // RC_1c307c6ba13b1609f542644719b6e56b
/// <summary>
/// RecordList type <code>ApprovalProcessLevelApprovalProcessRecordList</code> that represents a record
///  list of <code>ApprovalProcessLevel, ApprovalProcess</code>
/// </summary>
public partial class RL_8dbe9b3349c28479d314d27fe2f03197 : GenericRecordList<RC_1c307c6ba13b1609f542644719b6e56b>, IEnumerable, IEnumerator {

protected override RC_1c307c6ba13b1609f542644719b6e56b GetElementDefaultValue() {
return new RC_1c307c6ba13b1609f542644719b6e56b();
}

public T[] ToArray<T>(Func<RC_1c307c6ba13b1609f542644719b6e56b, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_8dbe9b3349c28479d314d27fe2f03197 recordList, Func<RC_1c307c6ba13b1609f542644719b6e56b, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_8dbe9b3349c28479d314d27fe2f03197(RC_1c307c6ba13b1609f542644719b6e56b[] array) {
  RL_8dbe9b3349c28479d314d27fe2f03197 result = new RL_8dbe9b3349c28479d314d27fe2f03197();
result.InnerFromArray(array);
    return result;
}

public static RL_8dbe9b3349c28479d314d27fe2f03197 ToList<T>(T[] array, Func <T, RC_1c307c6ba13b1609f542644719b6e56b> converter) {
  RL_8dbe9b3349c28479d314d27fe2f03197 result = new RL_8dbe9b3349c28479d314d27fe2f03197();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_8dbe9b3349c28479d314d27fe2f03197 FromRestList<T>(RestList<T> restList, Func <T, RC_1c307c6ba13b1609f542644719b6e56b> converter) {
  RL_8dbe9b3349c28479d314d27fe2f03197 result = new RL_8dbe9b3349c28479d314d27fe2f03197();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_8dbe9b3349c28479d314d27fe2f03197() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(26,false);
def[1] = new BitArray(19,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_1c307c6ba13b1609f542644719b6e56b> NewList() {
return new RL_8dbe9b3349c28479d314d27fe2f03197();
}


} // RL_8dbe9b3349c28479d314d27fe2f03197
}

