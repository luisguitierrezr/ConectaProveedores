namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (oKnh6w1QjU+DFFOmeg+64w)
///  <code>RC_98120f161aa796efec5482157f929b99</code> that represent
/// s <code>ApprovalProcessRequisitionApprovalRecord</code> <p>Description: </p>
/// </summary>
// Name: ApprovalProcessRequisitionApprovalRecord
public partial struct RC_98120f161aa796efec5482157f929b99 : ITypedRecord<RC_98120f161aa796efec5482157f929b99> {
internal static readonly GlobalObjectKey IdApprovalProcess = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*uHi98ulqoLu0bMXYgUg0rw");
internal static readonly GlobalObjectKey IdRequisitionApproval = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*S+8rbTJ+TN58eIhu7_dSJA");

public EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord ssENApprovalProcess;

public EN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord ssENRequisitionApproval;


public BitArray OptimizedAttributes;

public RC_98120f161aa796efec5482157f929b99() {
OptimizedAttributes = null;
ssENApprovalProcess = new EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord();
ssENRequisitionApproval = new EN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(19,false);
    all[1] = new BitArray(10,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENApprovalProcess.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENRequisitionApproval.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENApprovalProcess.OptimizedAttributes = value[0];
    ssENRequisitionApproval.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENApprovalProcess.OptimizedAttributes;
    all[1] = ssENRequisitionApproval.OptimizedAttributes;
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
ssENRequisitionApproval.Read( r, ref index);
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
public void ReadIM(RC_98120f161aa796efec5482157f929b99 r) {
this = r;
}


public static bool operator == (RC_98120f161aa796efec5482157f929b99 a, RC_98120f161aa796efec5482157f929b99 b) {
if (a.ssENApprovalProcess != b.ssENApprovalProcess) return false;
if (a.ssENRequisitionApproval != b.ssENRequisitionApproval) return false;
return true;
}

public static bool operator != (RC_98120f161aa796efec5482157f929b99 a, RC_98120f161aa796efec5482157f929b99 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_98120f161aa796efec5482157f929b99)) return false;
return (this == (RC_98120f161aa796efec5482157f929b99)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENApprovalProcess.GetHashCode()
 ^ ssENRequisitionApproval.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENApprovalProcess.RecursiveReset();
ssENRequisitionApproval.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENApprovalProcess.InternalRecursiveSave();
ssENRequisitionApproval.InternalRecursiveSave();
}


public RC_98120f161aa796efec5482157f929b99 Duplicate() {
RC_98120f161aa796efec5482157f929b99 t;
t.ssENApprovalProcess = (EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord)this.ssENApprovalProcess.Duplicate();
t.ssENRequisitionApproval = (EN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord)this.ssENRequisitionApproval.Duplicate();
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
} else if (head == "requisitionapproval") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionApproval")) variable.Value = ssENRequisitionApproval; else variable.Optimized = true;
variable.SetFieldName("requisitionapproval");
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
if (key == IdRequisitionApproval) {
return ssENRequisitionApproval;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdApprovalProcess.Key.AsGuid) {
return ssENApprovalProcess;
}
if (attributeKey == IdRequisitionApproval.Key.AsGuid) {
return ssENRequisitionApproval;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENApprovalProcess.FillFromOther((IRecord) other.AttributeGet(IdApprovalProcess));
ssENRequisitionApproval.FillFromOther((IRecord) other.AttributeGet(IdRequisitionApproval));
}
} // RC_98120f161aa796efec5482157f929b99
/// <summary>
/// RecordList type <code>ApprovalProcessRequisitionApprovalRecordList</code> that represents a record
///  list of <code>ApprovalProcess, RequisitionApproval</code>
/// </summary>
public partial class RL_eb30c26c3067f3944a588d50f5676332 : GenericRecordList<RC_98120f161aa796efec5482157f929b99>, IEnumerable, IEnumerator {

protected override RC_98120f161aa796efec5482157f929b99 GetElementDefaultValue() {
return new RC_98120f161aa796efec5482157f929b99();
}

public T[] ToArray<T>(Func<RC_98120f161aa796efec5482157f929b99, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_eb30c26c3067f3944a588d50f5676332 recordList, Func<RC_98120f161aa796efec5482157f929b99, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_eb30c26c3067f3944a588d50f5676332(RC_98120f161aa796efec5482157f929b99[] array) {
  RL_eb30c26c3067f3944a588d50f5676332 result = new RL_eb30c26c3067f3944a588d50f5676332();
result.InnerFromArray(array);
    return result;
}

public static RL_eb30c26c3067f3944a588d50f5676332 ToList<T>(T[] array, Func <T, RC_98120f161aa796efec5482157f929b99> converter) {
  RL_eb30c26c3067f3944a588d50f5676332 result = new RL_eb30c26c3067f3944a588d50f5676332();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_eb30c26c3067f3944a588d50f5676332 FromRestList<T>(RestList<T> restList, Func <T, RC_98120f161aa796efec5482157f929b99> converter) {
  RL_eb30c26c3067f3944a588d50f5676332 result = new RL_eb30c26c3067f3944a588d50f5676332();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_eb30c26c3067f3944a588d50f5676332() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(19,false);
def[1] = new BitArray(10,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_98120f161aa796efec5482157f929b99> NewList() {
return new RL_eb30c26c3067f3944a588d50f5676332();
}


} // RL_eb30c26c3067f3944a588d50f5676332
}

