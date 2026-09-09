namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (HZARsOCso0WCm03kBHhxLg)
///  <code>RC_05f5be3a1430a1bea3f80a8be6d08c9b</code> that represent
/// s <code>ProposalProposalLineRecord</code> <p>Description: </p>
/// </summary>
// Name: ProposalProposalLineRecord
public partial struct RC_05f5be3a1430a1bea3f80a8be6d08c9b : ITypedRecord<RC_05f5be3a1430a1bea3f80a8be6d08c9b> {
internal static readonly GlobalObjectKey IdProposal = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*9MStkYpvUQ_KzEvHGNLqNQ");
internal static readonly GlobalObjectKey IdProposalLine = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Ejn_ywl2+KAwstNJSNHAGQ");

public EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord ssENProposal;

public EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord ssENProposalLine;


public BitArray OptimizedAttributes;

public RC_05f5be3a1430a1bea3f80a8be6d08c9b() {
OptimizedAttributes = null;
ssENProposal = new EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord();
ssENProposalLine = new EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(18,false);
    all[1] = new BitArray(28,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENProposal.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENProposalLine.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENProposal.OptimizedAttributes = value[0];
    ssENProposalLine.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENProposal.OptimizedAttributes;
    all[1] = ssENProposalLine.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENProposal.Read( r, ref index);
ssENProposalLine.Read( r, ref index);
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
public void ReadIM(RC_05f5be3a1430a1bea3f80a8be6d08c9b r) {
this = r;
}


public static bool operator == (RC_05f5be3a1430a1bea3f80a8be6d08c9b a, RC_05f5be3a1430a1bea3f80a8be6d08c9b b) {
if (a.ssENProposal != b.ssENProposal) return false;
if (a.ssENProposalLine != b.ssENProposalLine) return false;
return true;
}

public static bool operator != (RC_05f5be3a1430a1bea3f80a8be6d08c9b a, RC_05f5be3a1430a1bea3f80a8be6d08c9b b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_05f5be3a1430a1bea3f80a8be6d08c9b)) return false;
return (this == (RC_05f5be3a1430a1bea3f80a8be6d08c9b)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENProposal.GetHashCode()
 ^ ssENProposalLine.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENProposal.RecursiveReset();
ssENProposalLine.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENProposal.InternalRecursiveSave();
ssENProposalLine.InternalRecursiveSave();
}


public RC_05f5be3a1430a1bea3f80a8be6d08c9b Duplicate() {
RC_05f5be3a1430a1bea3f80a8be6d08c9b t;
t.ssENProposal = (EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord)this.ssENProposal.Duplicate();
t.ssENProposalLine = (EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord)this.ssENProposalLine.Duplicate();
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
if (head == "proposal") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Proposal")) variable.Value = ssENProposal; else variable.Optimized = true;
variable.SetFieldName("proposal");
} else if (head == "proposalline") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProposalLine")) variable.Value = ssENProposalLine; else variable.Optimized = true;
variable.SetFieldName("proposalline");
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
if (key == IdProposal) {
return ssENProposal;
}
if (key == IdProposalLine) {
return ssENProposalLine;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdProposal.Key.AsGuid) {
return ssENProposal;
}
if (attributeKey == IdProposalLine.Key.AsGuid) {
return ssENProposalLine;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENProposal.FillFromOther((IRecord) other.AttributeGet(IdProposal));
ssENProposalLine.FillFromOther((IRecord) other.AttributeGet(IdProposalLine));
}
} // RC_05f5be3a1430a1bea3f80a8be6d08c9b
/// <summary>
/// RecordList type <code>ProposalProposalLineRecordList</code> that represents a record list of
///  <code>Proposal, ProposalLine</code>
/// </summary>
public partial class RL_759d79b1f4cfae069cc62371125fee8f : GenericRecordList<RC_05f5be3a1430a1bea3f80a8be6d08c9b>, IEnumerable, IEnumerator {

protected override RC_05f5be3a1430a1bea3f80a8be6d08c9b GetElementDefaultValue() {
return new RC_05f5be3a1430a1bea3f80a8be6d08c9b();
}

public T[] ToArray<T>(Func<RC_05f5be3a1430a1bea3f80a8be6d08c9b, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_759d79b1f4cfae069cc62371125fee8f recordList, Func<RC_05f5be3a1430a1bea3f80a8be6d08c9b, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_759d79b1f4cfae069cc62371125fee8f(RC_05f5be3a1430a1bea3f80a8be6d08c9b[] array) {
  RL_759d79b1f4cfae069cc62371125fee8f result = new RL_759d79b1f4cfae069cc62371125fee8f();
result.InnerFromArray(array);
    return result;
}

public static RL_759d79b1f4cfae069cc62371125fee8f ToList<T>(T[] array, Func <T, RC_05f5be3a1430a1bea3f80a8be6d08c9b> converter) {
  RL_759d79b1f4cfae069cc62371125fee8f result = new RL_759d79b1f4cfae069cc62371125fee8f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_759d79b1f4cfae069cc62371125fee8f FromRestList<T>(RestList<T> restList, Func <T, RC_05f5be3a1430a1bea3f80a8be6d08c9b> converter) {
  RL_759d79b1f4cfae069cc62371125fee8f result = new RL_759d79b1f4cfae069cc62371125fee8f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_759d79b1f4cfae069cc62371125fee8f() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(18,false);
def[1] = new BitArray(28,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_05f5be3a1430a1bea3f80a8be6d08c9b> NewList() {
return new RL_759d79b1f4cfae069cc62371125fee8f();
}


} // RL_759d79b1f4cfae069cc62371125fee8f
}

