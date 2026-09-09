namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (D1ROT_QD3UK9e3Q7xU6jdA)
///  <code>RC_11c2ac4c5bdce01960ee8371ad40d262</code> that represent
/// s <code>RequisitionRequisitionApprovalLevelRequisitionApprovalRecord</code> <p>Description: </p>
/// </summary>
// Name: RequisitionRequisitionApprovalLevelRequisitionApprovalRecord
public partial struct RC_11c2ac4c5bdce01960ee8371ad40d262 : ITypedRecord<RC_11c2ac4c5bdce01960ee8371ad40d262> {
internal static readonly GlobalObjectKey IdRequisition = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*T3SBu1iqc67nzY23TLMhVQ");
internal static readonly GlobalObjectKey IdRequisitionApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*jmkEVEb38DK8WXY1CdlRdw");
internal static readonly GlobalObjectKey IdRequisitionApproval = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*S+8rbTJ+TN58eIhu7_dSJA");

public EN_98680591dcf3728e0877a90eb5e1e552EntityRecord ssENRequisition;

public EN_27b1469f497d364a764a1359956ef9adEntityRecord ssENRequisitionApprovalLevel;

public EN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord ssENRequisitionApproval;


public BitArray OptimizedAttributes;

public RC_11c2ac4c5bdce01960ee8371ad40d262() {
OptimizedAttributes = null;
ssENRequisition = new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord();
ssENRequisitionApprovalLevel = new EN_27b1469f497d364a764a1359956ef9adEntityRecord();
ssENRequisitionApproval = new EN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = new BitArray(58,false);
    all[1] = new BitArray(26,false);
    all[2] = new BitArray(10,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENRequisition.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENRequisitionApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENRequisitionApproval.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    }else{
    ssENRequisition.OptimizedAttributes = value[0];
    ssENRequisitionApprovalLevel.OptimizedAttributes = value[1];
    ssENRequisitionApproval.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = ssENRequisition.OptimizedAttributes;
    all[1] = ssENRequisitionApprovalLevel.OptimizedAttributes;
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
ssENRequisition.Read( r, ref index);
ssENRequisitionApprovalLevel.Read( r, ref index);
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
public void ReadIM(RC_11c2ac4c5bdce01960ee8371ad40d262 r) {
this = r;
}


public static bool operator == (RC_11c2ac4c5bdce01960ee8371ad40d262 a, RC_11c2ac4c5bdce01960ee8371ad40d262 b) {
if (a.ssENRequisition != b.ssENRequisition) return false;
if (a.ssENRequisitionApprovalLevel != b.ssENRequisitionApprovalLevel) return false;
if (a.ssENRequisitionApproval != b.ssENRequisitionApproval) return false;
return true;
}

public static bool operator != (RC_11c2ac4c5bdce01960ee8371ad40d262 a, RC_11c2ac4c5bdce01960ee8371ad40d262 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_11c2ac4c5bdce01960ee8371ad40d262)) return false;
return (this == (RC_11c2ac4c5bdce01960ee8371ad40d262)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENRequisition.GetHashCode()
 ^ ssENRequisitionApprovalLevel.GetHashCode()
 ^ ssENRequisitionApproval.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENRequisition.RecursiveReset();
ssENRequisitionApprovalLevel.RecursiveReset();
ssENRequisitionApproval.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENRequisition.InternalRecursiveSave();
ssENRequisitionApprovalLevel.InternalRecursiveSave();
ssENRequisitionApproval.InternalRecursiveSave();
}


public RC_11c2ac4c5bdce01960ee8371ad40d262 Duplicate() {
RC_11c2ac4c5bdce01960ee8371ad40d262 t;
t.ssENRequisition = (EN_98680591dcf3728e0877a90eb5e1e552EntityRecord)this.ssENRequisition.Duplicate();
t.ssENRequisitionApprovalLevel = (EN_27b1469f497d364a764a1359956ef9adEntityRecord)this.ssENRequisitionApprovalLevel.Duplicate();
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
if (head == "requisition") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Requisition")) variable.Value = ssENRequisition; else variable.Optimized = true;
variable.SetFieldName("requisition");
} else if (head == "requisitionapprovallevel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionApprovalLevel")) variable.Value = ssENRequisitionApprovalLevel; else variable.Optimized = true;
variable.SetFieldName("requisitionapprovallevel");
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
if (key == IdRequisition) {
return ssENRequisition;
}
if (key == IdRequisitionApprovalLevel) {
return ssENRequisitionApprovalLevel;
}
if (key == IdRequisitionApproval) {
return ssENRequisitionApproval;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdRequisition.Key.AsGuid) {
return ssENRequisition;
}
if (attributeKey == IdRequisitionApprovalLevel.Key.AsGuid) {
return ssENRequisitionApprovalLevel;
}
if (attributeKey == IdRequisitionApproval.Key.AsGuid) {
return ssENRequisitionApproval;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENRequisition.FillFromOther((IRecord) other.AttributeGet(IdRequisition));
ssENRequisitionApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdRequisitionApprovalLevel));
ssENRequisitionApproval.FillFromOther((IRecord) other.AttributeGet(IdRequisitionApproval));
}
} // RC_11c2ac4c5bdce01960ee8371ad40d262
/// <summary>
/// RecordList type <code>RequisitionRequisitionApprovalLevelRequisitionApprovalRecordList</code> that
///  represents a record list of <code>Requisition, RequisitionApprovalLevel
/// , RequisitionApproval</code>
/// </summary>
public partial class RL_1f3e9ea72dc7b010c56ee9146ee277c5 : GenericRecordList<RC_11c2ac4c5bdce01960ee8371ad40d262>, IEnumerable, IEnumerator {

protected override RC_11c2ac4c5bdce01960ee8371ad40d262 GetElementDefaultValue() {
return new RC_11c2ac4c5bdce01960ee8371ad40d262();
}

public T[] ToArray<T>(Func<RC_11c2ac4c5bdce01960ee8371ad40d262, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_1f3e9ea72dc7b010c56ee9146ee277c5 recordList, Func<RC_11c2ac4c5bdce01960ee8371ad40d262, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_1f3e9ea72dc7b010c56ee9146ee277c5(RC_11c2ac4c5bdce01960ee8371ad40d262[] array) {
  RL_1f3e9ea72dc7b010c56ee9146ee277c5 result = new RL_1f3e9ea72dc7b010c56ee9146ee277c5();
result.InnerFromArray(array);
    return result;
}

public static RL_1f3e9ea72dc7b010c56ee9146ee277c5 ToList<T>(T[] array, Func <T, RC_11c2ac4c5bdce01960ee8371ad40d262> converter) {
  RL_1f3e9ea72dc7b010c56ee9146ee277c5 result = new RL_1f3e9ea72dc7b010c56ee9146ee277c5();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_1f3e9ea72dc7b010c56ee9146ee277c5 FromRestList<T>(RestList<T> restList, Func <T, RC_11c2ac4c5bdce01960ee8371ad40d262> converter) {
  RL_1f3e9ea72dc7b010c56ee9146ee277c5 result = new RL_1f3e9ea72dc7b010c56ee9146ee277c5();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_1f3e9ea72dc7b010c56ee9146ee277c5() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = new BitArray(58,false);
def[1] = new BitArray(26,false);
def[2] = new BitArray(10,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_11c2ac4c5bdce01960ee8371ad40d262> NewList() {
return new RL_1f3e9ea72dc7b010c56ee9146ee277c5();
}


} // RL_1f3e9ea72dc7b010c56ee9146ee277c5
}

