namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (31xeXlAF20W3F+Xuq6WwQw)
///  <code>RC_5b9ef0a641f5e1a605fb31b6e1e86d2a</code> that represent
/// s <code>ProposalApprovalLevelProposalProposalLineApprovalLevelProposalLineRecord</code>
///  <p>Description: </p>
/// </summary>
// Name: ProposalApprovalLevelProposalProposalLineApprovalLevelProposalLineRecord
public partial struct RC_5b9ef0a641f5e1a605fb31b6e1e86d2a : ITypedRecord<RC_5b9ef0a641f5e1a605fb31b6e1e86d2a> {
internal static readonly GlobalObjectKey IdProposalApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*eJqSVc+Lx3kjVPxJFgrMDA");
internal static readonly GlobalObjectKey IdProposal = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*9MStkYpvUQ_KzEvHGNLqNQ");
internal static readonly GlobalObjectKey IdProposalLineApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*XbRfhyNBH6nOg4MfD1VNjg");
internal static readonly GlobalObjectKey IdProposalLine = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Ejn_ywl2+KAwstNJSNHAGQ");

public EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord ssENProposalApprovalLevel;

public EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord ssENProposal;

public EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord ssENProposalLineApprovalLevel;

public EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord ssENProposalLine;


public BitArray OptimizedAttributes;

public RC_5b9ef0a641f5e1a605fb31b6e1e86d2a() {
OptimizedAttributes = null;
ssENProposalApprovalLevel = new EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord();
ssENProposal = new EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord();
ssENProposalLineApprovalLevel = new EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord();
ssENProposalLine = new EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[4];
    all[0] = new BitArray(7,false);
    all[1] = new BitArray(18,false);
    all[2] = new BitArray(9,false);
    all[3] = new BitArray(28,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENProposalApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENProposal.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENProposalLineApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENProposalLine.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    }else{
    ssENProposalApprovalLevel.OptimizedAttributes = value[0];
    ssENProposal.OptimizedAttributes = value[1];
    ssENProposalLineApprovalLevel.OptimizedAttributes = value[2];
    ssENProposalLine.OptimizedAttributes = value[3];
    }
}
get{
    BitArray[] all = new BitArray[4];
    all[0] = ssENProposalApprovalLevel.OptimizedAttributes;
    all[1] = ssENProposal.OptimizedAttributes;
    all[2] = ssENProposalLineApprovalLevel.OptimizedAttributes;
    all[3] = ssENProposalLine.OptimizedAttributes;
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
ssENProposal.Read( r, ref index);
ssENProposalLineApprovalLevel.Read( r, ref index);
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
public void ReadIM(RC_5b9ef0a641f5e1a605fb31b6e1e86d2a r) {
this = r;
}


public static bool operator == (RC_5b9ef0a641f5e1a605fb31b6e1e86d2a a, RC_5b9ef0a641f5e1a605fb31b6e1e86d2a b) {
if (a.ssENProposalApprovalLevel != b.ssENProposalApprovalLevel) return false;
if (a.ssENProposal != b.ssENProposal) return false;
if (a.ssENProposalLineApprovalLevel != b.ssENProposalLineApprovalLevel) return false;
if (a.ssENProposalLine != b.ssENProposalLine) return false;
return true;
}

public static bool operator != (RC_5b9ef0a641f5e1a605fb31b6e1e86d2a a, RC_5b9ef0a641f5e1a605fb31b6e1e86d2a b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_5b9ef0a641f5e1a605fb31b6e1e86d2a)) return false;
return (this == (RC_5b9ef0a641f5e1a605fb31b6e1e86d2a)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENProposalApprovalLevel.GetHashCode()
 ^ ssENProposal.GetHashCode()
 ^ ssENProposalLineApprovalLevel.GetHashCode()
 ^ ssENProposalLine.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENProposalApprovalLevel.RecursiveReset();
ssENProposal.RecursiveReset();
ssENProposalLineApprovalLevel.RecursiveReset();
ssENProposalLine.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENProposalApprovalLevel.InternalRecursiveSave();
ssENProposal.InternalRecursiveSave();
ssENProposalLineApprovalLevel.InternalRecursiveSave();
ssENProposalLine.InternalRecursiveSave();
}


public RC_5b9ef0a641f5e1a605fb31b6e1e86d2a Duplicate() {
RC_5b9ef0a641f5e1a605fb31b6e1e86d2a t;
t.ssENProposalApprovalLevel = (EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord)this.ssENProposalApprovalLevel.Duplicate();
t.ssENProposal = (EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord)this.ssENProposal.Duplicate();
t.ssENProposalLineApprovalLevel = (EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord)this.ssENProposalLineApprovalLevel.Duplicate();
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
if (head == "proposalapprovallevel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProposalApprovalLevel")) variable.Value = ssENProposalApprovalLevel; else variable.Optimized = true;
variable.SetFieldName("proposalapprovallevel");
} else if (head == "proposal") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Proposal")) variable.Value = ssENProposal; else variable.Optimized = true;
variable.SetFieldName("proposal");
} else if (head == "proposallineapprovallevel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProposalLineApprovalLevel")) variable.Value = ssENProposalLineApprovalLevel; else variable.Optimized = true;
variable.SetFieldName("proposallineapprovallevel");
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
if (key == IdProposalApprovalLevel) {
return ssENProposalApprovalLevel;
}
if (key == IdProposal) {
return ssENProposal;
}
if (key == IdProposalLineApprovalLevel) {
return ssENProposalLineApprovalLevel;
}
if (key == IdProposalLine) {
return ssENProposalLine;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdProposalApprovalLevel.Key.AsGuid) {
return ssENProposalApprovalLevel;
}
if (attributeKey == IdProposal.Key.AsGuid) {
return ssENProposal;
}
if (attributeKey == IdProposalLineApprovalLevel.Key.AsGuid) {
return ssENProposalLineApprovalLevel;
}
if (attributeKey == IdProposalLine.Key.AsGuid) {
return ssENProposalLine;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENProposalApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdProposalApprovalLevel));
ssENProposal.FillFromOther((IRecord) other.AttributeGet(IdProposal));
ssENProposalLineApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdProposalLineApprovalLevel));
ssENProposalLine.FillFromOther((IRecord) other.AttributeGet(IdProposalLine));
}
} // RC_5b9ef0a641f5e1a605fb31b6e1e86d2a
/// <summary>
/// RecordList type
///  <code>ProposalApprovalLevelProposalProposalLineApprovalLevelProposalLineRecordList</code> tha
/// t represents a record list of <code>ProposalApprovalLevel, Proposal, ProposalLineApprovalLevel,
///  ProposalLine</code>
/// </summary>
public partial class RL_368bd99a5798bf4e2cf7c1704f1b6372 : GenericRecordList<RC_5b9ef0a641f5e1a605fb31b6e1e86d2a>, IEnumerable, IEnumerator {

protected override RC_5b9ef0a641f5e1a605fb31b6e1e86d2a GetElementDefaultValue() {
return new RC_5b9ef0a641f5e1a605fb31b6e1e86d2a();
}

public T[] ToArray<T>(Func<RC_5b9ef0a641f5e1a605fb31b6e1e86d2a, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_368bd99a5798bf4e2cf7c1704f1b6372 recordList, Func<RC_5b9ef0a641f5e1a605fb31b6e1e86d2a, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_368bd99a5798bf4e2cf7c1704f1b6372(RC_5b9ef0a641f5e1a605fb31b6e1e86d2a[] array) {
  RL_368bd99a5798bf4e2cf7c1704f1b6372 result = new RL_368bd99a5798bf4e2cf7c1704f1b6372();
result.InnerFromArray(array);
    return result;
}

public static RL_368bd99a5798bf4e2cf7c1704f1b6372 ToList<T>(T[] array, Func <T, RC_5b9ef0a641f5e1a605fb31b6e1e86d2a> converter) {
  RL_368bd99a5798bf4e2cf7c1704f1b6372 result = new RL_368bd99a5798bf4e2cf7c1704f1b6372();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_368bd99a5798bf4e2cf7c1704f1b6372 FromRestList<T>(RestList<T> restList, Func <T, RC_5b9ef0a641f5e1a605fb31b6e1e86d2a> converter) {
  RL_368bd99a5798bf4e2cf7c1704f1b6372 result = new RL_368bd99a5798bf4e2cf7c1704f1b6372();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_368bd99a5798bf4e2cf7c1704f1b6372() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[4];
def[0] = new BitArray(7,false);
def[1] = new BitArray(18,false);
def[2] = new BitArray(9,false);
def[3] = new BitArray(28,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_5b9ef0a641f5e1a605fb31b6e1e86d2a> NewList() {
return new RL_368bd99a5798bf4e2cf7c1704f1b6372();
}


} // RL_368bd99a5798bf4e2cf7c1704f1b6372
}

