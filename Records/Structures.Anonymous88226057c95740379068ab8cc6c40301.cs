namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (V2AiiFfJN0CQaKuMxsQDAQ)
///  <code>RC_921fd9090c7367c088e0777ee6e3ef28</code> that represent
/// s <code>ProposalApprovalLevelProposalProposalApprovalRecord</code> <p>Description: </p>
/// </summary>
// Name: ProposalApprovalLevelProposalProposalApprovalRecord
public partial struct RC_921fd9090c7367c088e0777ee6e3ef28 : ITypedRecord<RC_921fd9090c7367c088e0777ee6e3ef28> {
internal static readonly GlobalObjectKey IdProposalApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*eJqSVc+Lx3kjVPxJFgrMDA");
internal static readonly GlobalObjectKey IdProposal = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*9MStkYpvUQ_KzEvHGNLqNQ");
internal static readonly GlobalObjectKey IdProposalApproval = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*1sFbHhDQH3aGXjoHdPHIGQ");

public EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord ssENProposalApprovalLevel;

public EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord ssENProposal;

public EN_5464a383ceb6bec564e8dfa03f011357EntityRecord ssENProposalApproval;


public BitArray OptimizedAttributes;

public RC_921fd9090c7367c088e0777ee6e3ef28() {
OptimizedAttributes = null;
ssENProposalApprovalLevel = new EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord();
ssENProposal = new EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord();
ssENProposalApproval = new EN_5464a383ceb6bec564e8dfa03f011357EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = new BitArray(7,false);
    all[1] = new BitArray(18,false);
    all[2] = new BitArray(8,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENProposalApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENProposal.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENProposalApproval.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    }else{
    ssENProposalApprovalLevel.OptimizedAttributes = value[0];
    ssENProposal.OptimizedAttributes = value[1];
    ssENProposalApproval.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = ssENProposalApprovalLevel.OptimizedAttributes;
    all[1] = ssENProposal.OptimizedAttributes;
    all[2] = ssENProposalApproval.OptimizedAttributes;
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
ssENProposalApproval.Read( r, ref index);
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
public void ReadIM(RC_921fd9090c7367c088e0777ee6e3ef28 r) {
this = r;
}


public static bool operator == (RC_921fd9090c7367c088e0777ee6e3ef28 a, RC_921fd9090c7367c088e0777ee6e3ef28 b) {
if (a.ssENProposalApprovalLevel != b.ssENProposalApprovalLevel) return false;
if (a.ssENProposal != b.ssENProposal) return false;
if (a.ssENProposalApproval != b.ssENProposalApproval) return false;
return true;
}

public static bool operator != (RC_921fd9090c7367c088e0777ee6e3ef28 a, RC_921fd9090c7367c088e0777ee6e3ef28 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_921fd9090c7367c088e0777ee6e3ef28)) return false;
return (this == (RC_921fd9090c7367c088e0777ee6e3ef28)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENProposalApprovalLevel.GetHashCode()
 ^ ssENProposal.GetHashCode()
 ^ ssENProposalApproval.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENProposalApprovalLevel.RecursiveReset();
ssENProposal.RecursiveReset();
ssENProposalApproval.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENProposalApprovalLevel.InternalRecursiveSave();
ssENProposal.InternalRecursiveSave();
ssENProposalApproval.InternalRecursiveSave();
}


public RC_921fd9090c7367c088e0777ee6e3ef28 Duplicate() {
RC_921fd9090c7367c088e0777ee6e3ef28 t;
t.ssENProposalApprovalLevel = (EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord)this.ssENProposalApprovalLevel.Duplicate();
t.ssENProposal = (EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord)this.ssENProposal.Duplicate();
t.ssENProposalApproval = (EN_5464a383ceb6bec564e8dfa03f011357EntityRecord)this.ssENProposalApproval.Duplicate();
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
} else if (head == "proposalapproval") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProposalApproval")) variable.Value = ssENProposalApproval; else variable.Optimized = true;
variable.SetFieldName("proposalapproval");
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
if (key == IdProposalApproval) {
return ssENProposalApproval;
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
if (attributeKey == IdProposalApproval.Key.AsGuid) {
return ssENProposalApproval;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENProposalApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdProposalApprovalLevel));
ssENProposal.FillFromOther((IRecord) other.AttributeGet(IdProposal));
ssENProposalApproval.FillFromOther((IRecord) other.AttributeGet(IdProposalApproval));
}
} // RC_921fd9090c7367c088e0777ee6e3ef28
/// <summary>
/// RecordList type <code>ProposalApprovalLevelProposalProposalApprovalRecordList</code> that
///  represents a record list of <code>ProposalApprovalLevel, Proposal, ProposalApproval</code>
/// </summary>
public partial class RL_9f9acf7f8fbbfb480a215bc421efa609 : GenericRecordList<RC_921fd9090c7367c088e0777ee6e3ef28>, IEnumerable, IEnumerator {

protected override RC_921fd9090c7367c088e0777ee6e3ef28 GetElementDefaultValue() {
return new RC_921fd9090c7367c088e0777ee6e3ef28();
}

public T[] ToArray<T>(Func<RC_921fd9090c7367c088e0777ee6e3ef28, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_9f9acf7f8fbbfb480a215bc421efa609 recordList, Func<RC_921fd9090c7367c088e0777ee6e3ef28, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_9f9acf7f8fbbfb480a215bc421efa609(RC_921fd9090c7367c088e0777ee6e3ef28[] array) {
  RL_9f9acf7f8fbbfb480a215bc421efa609 result = new RL_9f9acf7f8fbbfb480a215bc421efa609();
result.InnerFromArray(array);
    return result;
}

public static RL_9f9acf7f8fbbfb480a215bc421efa609 ToList<T>(T[] array, Func <T, RC_921fd9090c7367c088e0777ee6e3ef28> converter) {
  RL_9f9acf7f8fbbfb480a215bc421efa609 result = new RL_9f9acf7f8fbbfb480a215bc421efa609();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_9f9acf7f8fbbfb480a215bc421efa609 FromRestList<T>(RestList<T> restList, Func <T, RC_921fd9090c7367c088e0777ee6e3ef28> converter) {
  RL_9f9acf7f8fbbfb480a215bc421efa609 result = new RL_9f9acf7f8fbbfb480a215bc421efa609();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_9f9acf7f8fbbfb480a215bc421efa609() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = new BitArray(7,false);
def[1] = new BitArray(18,false);
def[2] = new BitArray(8,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_921fd9090c7367c088e0777ee6e3ef28> NewList() {
return new RL_9f9acf7f8fbbfb480a215bc421efa609();
}


} // RL_9f9acf7f8fbbfb480a215bc421efa609
}

