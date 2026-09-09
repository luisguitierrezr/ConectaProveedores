namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (W4+JNkBn4kW7NC3yF2a4LA)
///  <code>RC_8ada9c8e65e1e09d1e1af032494a5fa8</code> that represent
/// s <code>ApprovalProcessRequisitionRequisitionApprovalRecord</code> <p>Description: </p>
/// </summary>
// Name: ApprovalProcessRequisitionRequisitionApprovalRecord
public partial struct RC_8ada9c8e65e1e09d1e1af032494a5fa8 : ITypedRecord<RC_8ada9c8e65e1e09d1e1af032494a5fa8> {
internal static readonly GlobalObjectKey IdApprovalProcess = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*uHi98ulqoLu0bMXYgUg0rw");
internal static readonly GlobalObjectKey IdRequisition = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*T3SBu1iqc67nzY23TLMhVQ");
internal static readonly GlobalObjectKey IdRequisitionApproval = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*S+8rbTJ+TN58eIhu7_dSJA");

public EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord ssENApprovalProcess;

public EN_98680591dcf3728e0877a90eb5e1e552EntityRecord ssENRequisition;

public EN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord ssENRequisitionApproval;


public BitArray OptimizedAttributes;

public RC_8ada9c8e65e1e09d1e1af032494a5fa8() {
OptimizedAttributes = null;
ssENApprovalProcess = new EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord();
ssENRequisition = new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord();
ssENRequisitionApproval = new EN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = new BitArray(19,false);
    all[1] = new BitArray(58,false);
    all[2] = new BitArray(10,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENApprovalProcess.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENRequisition.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENRequisitionApproval.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    }else{
    ssENApprovalProcess.OptimizedAttributes = value[0];
    ssENRequisition.OptimizedAttributes = value[1];
    ssENRequisitionApproval.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = ssENApprovalProcess.OptimizedAttributes;
    all[1] = ssENRequisition.OptimizedAttributes;
    all[2] = ssENRequisitionApproval.OptimizedAttributes;
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
ssENRequisition.Read( r, ref index);
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
public void ReadIM(RC_8ada9c8e65e1e09d1e1af032494a5fa8 r) {
this = r;
}


public static bool operator == (RC_8ada9c8e65e1e09d1e1af032494a5fa8 a, RC_8ada9c8e65e1e09d1e1af032494a5fa8 b) {
if (a.ssENApprovalProcess != b.ssENApprovalProcess) return false;
if (a.ssENRequisition != b.ssENRequisition) return false;
if (a.ssENRequisitionApproval != b.ssENRequisitionApproval) return false;
return true;
}

public static bool operator != (RC_8ada9c8e65e1e09d1e1af032494a5fa8 a, RC_8ada9c8e65e1e09d1e1af032494a5fa8 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_8ada9c8e65e1e09d1e1af032494a5fa8)) return false;
return (this == (RC_8ada9c8e65e1e09d1e1af032494a5fa8)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENApprovalProcess.GetHashCode()
 ^ ssENRequisition.GetHashCode()
 ^ ssENRequisitionApproval.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENApprovalProcess.RecursiveReset();
ssENRequisition.RecursiveReset();
ssENRequisitionApproval.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENApprovalProcess.InternalRecursiveSave();
ssENRequisition.InternalRecursiveSave();
ssENRequisitionApproval.InternalRecursiveSave();
}


public RC_8ada9c8e65e1e09d1e1af032494a5fa8 Duplicate() {
RC_8ada9c8e65e1e09d1e1af032494a5fa8 t;
t.ssENApprovalProcess = (EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord)this.ssENApprovalProcess.Duplicate();
t.ssENRequisition = (EN_98680591dcf3728e0877a90eb5e1e552EntityRecord)this.ssENRequisition.Duplicate();
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
} else if (head == "requisition") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Requisition")) variable.Value = ssENRequisition; else variable.Optimized = true;
variable.SetFieldName("requisition");
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
if (key == IdRequisition) {
return ssENRequisition;
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
if (attributeKey == IdRequisition.Key.AsGuid) {
return ssENRequisition;
}
if (attributeKey == IdRequisitionApproval.Key.AsGuid) {
return ssENRequisitionApproval;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENApprovalProcess.FillFromOther((IRecord) other.AttributeGet(IdApprovalProcess));
ssENRequisition.FillFromOther((IRecord) other.AttributeGet(IdRequisition));
ssENRequisitionApproval.FillFromOther((IRecord) other.AttributeGet(IdRequisitionApproval));
}
} // RC_8ada9c8e65e1e09d1e1af032494a5fa8
/// <summary>
/// RecordList type <code>ApprovalProcessRequisitionRequisitionApprovalRecordList</code> that
///  represents a record list of <code>ApprovalProcess, Requisition, RequisitionApproval</code>
/// </summary>
public partial class RL_72dedb526963c58e79ee56edd8352664 : GenericRecordList<RC_8ada9c8e65e1e09d1e1af032494a5fa8>, IEnumerable, IEnumerator {

protected override RC_8ada9c8e65e1e09d1e1af032494a5fa8 GetElementDefaultValue() {
return new RC_8ada9c8e65e1e09d1e1af032494a5fa8();
}

public T[] ToArray<T>(Func<RC_8ada9c8e65e1e09d1e1af032494a5fa8, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_72dedb526963c58e79ee56edd8352664 recordList, Func<RC_8ada9c8e65e1e09d1e1af032494a5fa8, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_72dedb526963c58e79ee56edd8352664(RC_8ada9c8e65e1e09d1e1af032494a5fa8[] array) {
  RL_72dedb526963c58e79ee56edd8352664 result = new RL_72dedb526963c58e79ee56edd8352664();
result.InnerFromArray(array);
    return result;
}

public static RL_72dedb526963c58e79ee56edd8352664 ToList<T>(T[] array, Func <T, RC_8ada9c8e65e1e09d1e1af032494a5fa8> converter) {
  RL_72dedb526963c58e79ee56edd8352664 result = new RL_72dedb526963c58e79ee56edd8352664();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_72dedb526963c58e79ee56edd8352664 FromRestList<T>(RestList<T> restList, Func <T, RC_8ada9c8e65e1e09d1e1af032494a5fa8> converter) {
  RL_72dedb526963c58e79ee56edd8352664 result = new RL_72dedb526963c58e79ee56edd8352664();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_72dedb526963c58e79ee56edd8352664() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = new BitArray(19,false);
def[1] = new BitArray(58,false);
def[2] = new BitArray(10,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_8ada9c8e65e1e09d1e1af032494a5fa8> NewList() {
return new RL_72dedb526963c58e79ee56edd8352664();
}


} // RL_72dedb526963c58e79ee56edd8352664
}

