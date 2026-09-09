namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (83DuTDBl0kKpf7m7a8Witg)
///  <code>RC_7a202946b9c9ade4fc5b7dc7c07f3279</code> that represent
/// s <code>RequisitionApprovalLevelRequisitionApprovalRecord</code> <p>Description: </p>
/// </summary>
// Name: RequisitionApprovalLevelRequisitionApprovalRecord
public partial struct RC_7a202946b9c9ade4fc5b7dc7c07f3279 : ITypedRecord<RC_7a202946b9c9ade4fc5b7dc7c07f3279> {
internal static readonly GlobalObjectKey IdRequisitionApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*jmkEVEb38DK8WXY1CdlRdw");
internal static readonly GlobalObjectKey IdRequisitionApproval = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*S+8rbTJ+TN58eIhu7_dSJA");

public EN_27b1469f497d364a764a1359956ef9adEntityRecord ssENRequisitionApprovalLevel;

public EN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord ssENRequisitionApproval;


public BitArray OptimizedAttributes;

public RC_7a202946b9c9ade4fc5b7dc7c07f3279() {
OptimizedAttributes = null;
ssENRequisitionApprovalLevel = new EN_27b1469f497d364a764a1359956ef9adEntityRecord();
ssENRequisitionApproval = new EN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(26,false);
    all[1] = new BitArray(10,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENRequisitionApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENRequisitionApproval.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENRequisitionApprovalLevel.OptimizedAttributes = value[0];
    ssENRequisitionApproval.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENRequisitionApprovalLevel.OptimizedAttributes;
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
public void ReadIM(RC_7a202946b9c9ade4fc5b7dc7c07f3279 r) {
this = r;
}


public static bool operator == (RC_7a202946b9c9ade4fc5b7dc7c07f3279 a, RC_7a202946b9c9ade4fc5b7dc7c07f3279 b) {
if (a.ssENRequisitionApprovalLevel != b.ssENRequisitionApprovalLevel) return false;
if (a.ssENRequisitionApproval != b.ssENRequisitionApproval) return false;
return true;
}

public static bool operator != (RC_7a202946b9c9ade4fc5b7dc7c07f3279 a, RC_7a202946b9c9ade4fc5b7dc7c07f3279 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_7a202946b9c9ade4fc5b7dc7c07f3279)) return false;
return (this == (RC_7a202946b9c9ade4fc5b7dc7c07f3279)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENRequisitionApprovalLevel.GetHashCode()
 ^ ssENRequisitionApproval.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENRequisitionApprovalLevel.RecursiveReset();
ssENRequisitionApproval.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENRequisitionApprovalLevel.InternalRecursiveSave();
ssENRequisitionApproval.InternalRecursiveSave();
}


public RC_7a202946b9c9ade4fc5b7dc7c07f3279 Duplicate() {
RC_7a202946b9c9ade4fc5b7dc7c07f3279 t;
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
if (head == "requisitionapprovallevel") {
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
if (key == IdRequisitionApprovalLevel) {
return ssENRequisitionApprovalLevel;
}
if (key == IdRequisitionApproval) {
return ssENRequisitionApproval;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
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
ssENRequisitionApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdRequisitionApprovalLevel));
ssENRequisitionApproval.FillFromOther((IRecord) other.AttributeGet(IdRequisitionApproval));
}
} // RC_7a202946b9c9ade4fc5b7dc7c07f3279
/// <summary>
/// RecordList type <code>RequisitionApprovalLevelRequisitionApprovalRecordList</code> that represents
///  a record list of <code>RequisitionApprovalLevel, RequisitionApproval</code>
/// </summary>
public partial class RL_17106260236c729f86b4f7919e212d21 : GenericRecordList<RC_7a202946b9c9ade4fc5b7dc7c07f3279>, IEnumerable, IEnumerator {

protected override RC_7a202946b9c9ade4fc5b7dc7c07f3279 GetElementDefaultValue() {
return new RC_7a202946b9c9ade4fc5b7dc7c07f3279();
}

public T[] ToArray<T>(Func<RC_7a202946b9c9ade4fc5b7dc7c07f3279, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_17106260236c729f86b4f7919e212d21 recordList, Func<RC_7a202946b9c9ade4fc5b7dc7c07f3279, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_17106260236c729f86b4f7919e212d21(RC_7a202946b9c9ade4fc5b7dc7c07f3279[] array) {
  RL_17106260236c729f86b4f7919e212d21 result = new RL_17106260236c729f86b4f7919e212d21();
result.InnerFromArray(array);
    return result;
}

public static RL_17106260236c729f86b4f7919e212d21 ToList<T>(T[] array, Func <T, RC_7a202946b9c9ade4fc5b7dc7c07f3279> converter) {
  RL_17106260236c729f86b4f7919e212d21 result = new RL_17106260236c729f86b4f7919e212d21();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_17106260236c729f86b4f7919e212d21 FromRestList<T>(RestList<T> restList, Func <T, RC_7a202946b9c9ade4fc5b7dc7c07f3279> converter) {
  RL_17106260236c729f86b4f7919e212d21 result = new RL_17106260236c729f86b4f7919e212d21();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_17106260236c729f86b4f7919e212d21() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(26,false);
def[1] = new BitArray(10,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_7a202946b9c9ade4fc5b7dc7c07f3279> NewList() {
return new RL_17106260236c729f86b4f7919e212d21();
}


} // RL_17106260236c729f86b4f7919e212d21
}

