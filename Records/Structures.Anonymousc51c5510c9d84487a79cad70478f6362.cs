namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (EFUcxdjJh0SnnK1wR49jYg)
///  <code>RC_853b3dd6b575c6d19eb5343d397a37e7</code> that represent
/// s <code>LastApproverRequisitionRequisitionApprovalLevelRequisitionApprovalRecord</code>
///  <p>Description: </p>
/// </summary>
// Name: LastApproverRequisitionRequisitionApprovalLevelRequisitionApprovalRecord
public partial struct RC_853b3dd6b575c6d19eb5343d397a37e7 : ITypedRecord<RC_853b3dd6b575c6d19eb5343d397a37e7> {
internal static readonly GlobalObjectKey IdLastApprover = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*t7eC2lS6Ljk81WZ8N9erdg");
internal static readonly GlobalObjectKey IdRequisition = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*T3SBu1iqc67nzY23TLMhVQ");
internal static readonly GlobalObjectKey IdRequisitionApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*jmkEVEb38DK8WXY1CdlRdw");
internal static readonly GlobalObjectKey IdRequisitionApproval = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*S+8rbTJ+TN58eIhu7_dSJA");

public ENUserEntityRecord ssENLastApprover;

public EN_98680591dcf3728e0877a90eb5e1e552EntityRecord ssENRequisition;

public EN_27b1469f497d364a764a1359956ef9adEntityRecord ssENRequisitionApprovalLevel;

public EN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord ssENRequisitionApproval;


public BitArray OptimizedAttributes;

public RC_853b3dd6b575c6d19eb5343d397a37e7() {
OptimizedAttributes = null;
ssENLastApprover = new ENUserEntityRecord();
ssENRequisition = new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord();
ssENRequisitionApprovalLevel = new EN_27b1469f497d364a764a1359956ef9adEntityRecord();
ssENRequisitionApproval = new EN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[4];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(58,false);
    all[2] = new BitArray(26,false);
    all[3] = new BitArray(10,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENLastApprover.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENRequisition.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENRequisitionApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENRequisitionApproval.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    }else{
    ssENLastApprover.OptimizedAttributes = value[0];
    ssENRequisition.OptimizedAttributes = value[1];
    ssENRequisitionApprovalLevel.OptimizedAttributes = value[2];
    ssENRequisitionApproval.OptimizedAttributes = value[3];
    }
}
get{
    BitArray[] all = new BitArray[4];
    all[0] = ssENLastApprover.OptimizedAttributes;
    all[1] = ssENRequisition.OptimizedAttributes;
    all[2] = ssENRequisitionApprovalLevel.OptimizedAttributes;
    all[3] = ssENRequisitionApproval.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENLastApprover.Read( r, ref index);
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
public void ReadIM(RC_853b3dd6b575c6d19eb5343d397a37e7 r) {
this = r;
}


public static bool operator == (RC_853b3dd6b575c6d19eb5343d397a37e7 a, RC_853b3dd6b575c6d19eb5343d397a37e7 b) {
if (a.ssENLastApprover != b.ssENLastApprover) return false;
if (a.ssENRequisition != b.ssENRequisition) return false;
if (a.ssENRequisitionApprovalLevel != b.ssENRequisitionApprovalLevel) return false;
if (a.ssENRequisitionApproval != b.ssENRequisitionApproval) return false;
return true;
}

public static bool operator != (RC_853b3dd6b575c6d19eb5343d397a37e7 a, RC_853b3dd6b575c6d19eb5343d397a37e7 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_853b3dd6b575c6d19eb5343d397a37e7)) return false;
return (this == (RC_853b3dd6b575c6d19eb5343d397a37e7)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENLastApprover.GetHashCode()
 ^ ssENRequisition.GetHashCode()
 ^ ssENRequisitionApprovalLevel.GetHashCode()
 ^ ssENRequisitionApproval.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENLastApprover.RecursiveReset();
ssENRequisition.RecursiveReset();
ssENRequisitionApprovalLevel.RecursiveReset();
ssENRequisitionApproval.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENLastApprover.InternalRecursiveSave();
ssENRequisition.InternalRecursiveSave();
ssENRequisitionApprovalLevel.InternalRecursiveSave();
ssENRequisitionApproval.InternalRecursiveSave();
}


public RC_853b3dd6b575c6d19eb5343d397a37e7 Duplicate() {
RC_853b3dd6b575c6d19eb5343d397a37e7 t;
t.ssENLastApprover = (ENUserEntityRecord)this.ssENLastApprover.Duplicate();
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
if (head == "lastapprover") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".LastApprover")) variable.Value = ssENLastApprover; else variable.Optimized = true;
variable.SetFieldName("lastapprover");
} else if (head == "requisition") {
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
if (key == IdLastApprover) {
return ssENLastApprover;
}
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
if (attributeKey == IdLastApprover.Key.AsGuid) {
return ssENLastApprover;
}
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
ssENLastApprover.FillFromOther((IRecord) other.AttributeGet(IdLastApprover));
ssENRequisition.FillFromOther((IRecord) other.AttributeGet(IdRequisition));
ssENRequisitionApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdRequisitionApprovalLevel));
ssENRequisitionApproval.FillFromOther((IRecord) other.AttributeGet(IdRequisitionApproval));
}
} // RC_853b3dd6b575c6d19eb5343d397a37e7
/// <summary>
/// RecordList type
///  <code>LastApproverRequisitionRequisitionApprovalLevelRequisitionApprovalRecordList</code> tha
/// t represents a record list of <code>User, Requisition, RequisitionApprovalLevel,
///  RequisitionApproval</code>
/// </summary>
public partial class RL_6a483f7b9e172adc49ec70475a3b324d : GenericRecordList<RC_853b3dd6b575c6d19eb5343d397a37e7>, IEnumerable, IEnumerator {

protected override RC_853b3dd6b575c6d19eb5343d397a37e7 GetElementDefaultValue() {
return new RC_853b3dd6b575c6d19eb5343d397a37e7();
}

public T[] ToArray<T>(Func<RC_853b3dd6b575c6d19eb5343d397a37e7, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_6a483f7b9e172adc49ec70475a3b324d recordList, Func<RC_853b3dd6b575c6d19eb5343d397a37e7, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_6a483f7b9e172adc49ec70475a3b324d(RC_853b3dd6b575c6d19eb5343d397a37e7[] array) {
  RL_6a483f7b9e172adc49ec70475a3b324d result = new RL_6a483f7b9e172adc49ec70475a3b324d();
result.InnerFromArray(array);
    return result;
}

public static RL_6a483f7b9e172adc49ec70475a3b324d ToList<T>(T[] array, Func <T, RC_853b3dd6b575c6d19eb5343d397a37e7> converter) {
  RL_6a483f7b9e172adc49ec70475a3b324d result = new RL_6a483f7b9e172adc49ec70475a3b324d();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_6a483f7b9e172adc49ec70475a3b324d FromRestList<T>(RestList<T> restList, Func <T, RC_853b3dd6b575c6d19eb5343d397a37e7> converter) {
  RL_6a483f7b9e172adc49ec70475a3b324d result = new RL_6a483f7b9e172adc49ec70475a3b324d();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_6a483f7b9e172adc49ec70475a3b324d() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[4];
def[0] = new BitArray(5,false);
def[1] = new BitArray(58,false);
def[2] = new BitArray(26,false);
def[3] = new BitArray(10,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_853b3dd6b575c6d19eb5343d397a37e7> NewList() {
return new RL_6a483f7b9e172adc49ec70475a3b324d();
}


} // RL_6a483f7b9e172adc49ec70475a3b324d
}

