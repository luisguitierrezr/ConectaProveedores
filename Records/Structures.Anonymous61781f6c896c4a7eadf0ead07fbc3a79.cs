namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (bB94YWyJfkqt8OrQf7w6eQ)
///  <code>RC_55929a788bcf79c72354fc49160acc0c</code> that represent
/// s <code>ProposalApprovalLevelRecord</code> <p>Description: </p>
/// </summary>
// Name: ProposalApprovalLevelRecord
public partial struct RC_55929a788bcf79c72354fc49160acc0c : ITypedRecord<RC_55929a788bcf79c72354fc49160acc0c> {
internal static readonly GlobalObjectKey IdProposalApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*eJqSVc+Lx3kjVPxJFgrMDA");

public EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord ssENProposalApprovalLevel;


public static implicit operator EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord( RC_55929a788bcf79c72354fc49160acc0c r) {
return r.ssENProposalApprovalLevel;
}

public static implicit operator RC_55929a788bcf79c72354fc49160acc0c (EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord r) {
RC_55929a788bcf79c72354fc49160acc0c res = new RC_55929a788bcf79c72354fc49160acc0c ();
res.ssENProposalApprovalLevel = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENProposalApprovalLevel.ChangedAttributes = value;
}
get {
    return ssENProposalApprovalLevel.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_55929a788bcf79c72354fc49160acc0c() {
OptimizedAttributes = null;
ssENProposalApprovalLevel = new EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(7,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENProposalApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENProposalApprovalLevel.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENProposalApprovalLevel.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENProposalApprovalLevel.Read( r, ref index);
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
public void ReadIM(RC_55929a788bcf79c72354fc49160acc0c r) {
this = r;
}


public static bool operator == (RC_55929a788bcf79c72354fc49160acc0c a, RC_55929a788bcf79c72354fc49160acc0c b) {
if (a.ssENProposalApprovalLevel != b.ssENProposalApprovalLevel) return false;
return true;
}

public static bool operator != (RC_55929a788bcf79c72354fc49160acc0c a, RC_55929a788bcf79c72354fc49160acc0c b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_55929a788bcf79c72354fc49160acc0c)) return false;
return (this == (RC_55929a788bcf79c72354fc49160acc0c)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENProposalApprovalLevel.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENProposalApprovalLevel.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENProposalApprovalLevel.InternalRecursiveSave();
}


public RC_55929a788bcf79c72354fc49160acc0c Duplicate() {
RC_55929a788bcf79c72354fc49160acc0c t;
t.ssENProposalApprovalLevel = (EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord)this.ssENProposalApprovalLevel.Duplicate();
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
if (head == "proposalapprovallevel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProposalApprovalLevel")) variable.Value = ssENProposalApprovalLevel; else variable.Optimized = true;
variable.SetFieldName("proposalapprovallevel");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENProposalApprovalLevel.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENProposalApprovalLevel.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdProposalApprovalLevel) {
return ssENProposalApprovalLevel;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdProposalApprovalLevel.Key.AsGuid) {
return ssENProposalApprovalLevel;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENProposalApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdProposalApprovalLevel));
}
} // RC_55929a788bcf79c72354fc49160acc0c
/// <summary>
/// RecordList type <code>ProposalApprovalLevelRecordList</code> that represents a record list of
///  <code>ProposalApprovalLevel</code>
/// </summary>
public partial class RL_bb2cf15a81e5435e794933d03fe8d627 : GenericRecordList<RC_55929a788bcf79c72354fc49160acc0c>, IEnumerable, IEnumerator {

protected override RC_55929a788bcf79c72354fc49160acc0c GetElementDefaultValue() {
return new RC_55929a788bcf79c72354fc49160acc0c();
}

public T[] ToArray<T>(Func<RC_55929a788bcf79c72354fc49160acc0c, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_bb2cf15a81e5435e794933d03fe8d627 recordList, Func<RC_55929a788bcf79c72354fc49160acc0c, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_bb2cf15a81e5435e794933d03fe8d627(RC_55929a788bcf79c72354fc49160acc0c[] array) {
  RL_bb2cf15a81e5435e794933d03fe8d627 result = new RL_bb2cf15a81e5435e794933d03fe8d627();
result.InnerFromArray(array);
    return result;
}

public static RL_bb2cf15a81e5435e794933d03fe8d627 ToList<T>(T[] array, Func <T, RC_55929a788bcf79c72354fc49160acc0c> converter) {
  RL_bb2cf15a81e5435e794933d03fe8d627 result = new RL_bb2cf15a81e5435e794933d03fe8d627();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_bb2cf15a81e5435e794933d03fe8d627 FromRestList<T>(RestList<T> restList, Func <T, RC_55929a788bcf79c72354fc49160acc0c> converter) {
  RL_bb2cf15a81e5435e794933d03fe8d627 result = new RL_bb2cf15a81e5435e794933d03fe8d627();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_bb2cf15a81e5435e794933d03fe8d627() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(7,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_55929a788bcf79c72354fc49160acc0c> NewList() {
return new RL_bb2cf15a81e5435e794933d03fe8d627();
}


} // RL_bb2cf15a81e5435e794933d03fe8d627
}

