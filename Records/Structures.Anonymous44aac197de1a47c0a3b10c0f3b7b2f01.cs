namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (l8GqRBrewEejsQwPO3svAQ)
///  <code>RC_37b2ba4d72ceb89cfb30009990025b2f</code> that represent
/// s <code>ProposalApprovalLevelProposalProposalApprovalApplicationRoleRecord</code> <p>Description:
///  </p>
/// </summary>
// Name: ProposalApprovalLevelProposalProposalApprovalApplicationRoleRecord
public partial struct RC_37b2ba4d72ceb89cfb30009990025b2f : ITypedRecord<RC_37b2ba4d72ceb89cfb30009990025b2f> {
internal static readonly GlobalObjectKey IdProposalApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*eJqSVc+Lx3kjVPxJFgrMDA");
internal static readonly GlobalObjectKey IdProposal = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*9MStkYpvUQ_KzEvHGNLqNQ");
internal static readonly GlobalObjectKey IdProposalApproval = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*1sFbHhDQH3aGXjoHdPHIGQ");
internal static readonly GlobalObjectKey IdApplicationRole = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Q0fszuVdwmNpC2BezKaalA");

public EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord ssENProposalApprovalLevel;

public EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord ssENProposal;

public EN_5464a383ceb6bec564e8dfa03f011357EntityRecord ssENProposalApproval;

public EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord ssENApplicationRole;


public BitArray OptimizedAttributes;

public RC_37b2ba4d72ceb89cfb30009990025b2f() {
OptimizedAttributes = null;
ssENProposalApprovalLevel = new EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord();
ssENProposal = new EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord();
ssENProposalApproval = new EN_5464a383ceb6bec564e8dfa03f011357EntityRecord();
ssENApplicationRole = new EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[4];
    all[0] = new BitArray(7,false);
    all[1] = new BitArray(18,false);
    all[2] = new BitArray(8,false);
    all[3] = new BitArray(7,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENProposalApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENProposal.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENProposalApproval.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENApplicationRole.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    }else{
    ssENProposalApprovalLevel.OptimizedAttributes = value[0];
    ssENProposal.OptimizedAttributes = value[1];
    ssENProposalApproval.OptimizedAttributes = value[2];
    ssENApplicationRole.OptimizedAttributes = value[3];
    }
}
get{
    BitArray[] all = new BitArray[4];
    all[0] = ssENProposalApprovalLevel.OptimizedAttributes;
    all[1] = ssENProposal.OptimizedAttributes;
    all[2] = ssENProposalApproval.OptimizedAttributes;
    all[3] = ssENApplicationRole.OptimizedAttributes;
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
ssENApplicationRole.Read( r, ref index);
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
public void ReadIM(RC_37b2ba4d72ceb89cfb30009990025b2f r) {
this = r;
}


public static bool operator == (RC_37b2ba4d72ceb89cfb30009990025b2f a, RC_37b2ba4d72ceb89cfb30009990025b2f b) {
if (a.ssENProposalApprovalLevel != b.ssENProposalApprovalLevel) return false;
if (a.ssENProposal != b.ssENProposal) return false;
if (a.ssENProposalApproval != b.ssENProposalApproval) return false;
if (a.ssENApplicationRole != b.ssENApplicationRole) return false;
return true;
}

public static bool operator != (RC_37b2ba4d72ceb89cfb30009990025b2f a, RC_37b2ba4d72ceb89cfb30009990025b2f b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_37b2ba4d72ceb89cfb30009990025b2f)) return false;
return (this == (RC_37b2ba4d72ceb89cfb30009990025b2f)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENProposalApprovalLevel.GetHashCode()
 ^ ssENProposal.GetHashCode()
 ^ ssENProposalApproval.GetHashCode()
 ^ ssENApplicationRole.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENProposalApprovalLevel.RecursiveReset();
ssENProposal.RecursiveReset();
ssENProposalApproval.RecursiveReset();
ssENApplicationRole.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENProposalApprovalLevel.InternalRecursiveSave();
ssENProposal.InternalRecursiveSave();
ssENProposalApproval.InternalRecursiveSave();
ssENApplicationRole.InternalRecursiveSave();
}


public RC_37b2ba4d72ceb89cfb30009990025b2f Duplicate() {
RC_37b2ba4d72ceb89cfb30009990025b2f t;
t.ssENProposalApprovalLevel = (EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord)this.ssENProposalApprovalLevel.Duplicate();
t.ssENProposal = (EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord)this.ssENProposal.Duplicate();
t.ssENProposalApproval = (EN_5464a383ceb6bec564e8dfa03f011357EntityRecord)this.ssENProposalApproval.Duplicate();
t.ssENApplicationRole = (EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord)this.ssENApplicationRole.Duplicate();
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
} else if (head == "applicationrole") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApplicationRole")) variable.Value = ssENApplicationRole; else variable.Optimized = true;
variable.SetFieldName("applicationrole");
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
if (key == IdApplicationRole) {
return ssENApplicationRole;
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
if (attributeKey == IdApplicationRole.Key.AsGuid) {
return ssENApplicationRole;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENProposalApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdProposalApprovalLevel));
ssENProposal.FillFromOther((IRecord) other.AttributeGet(IdProposal));
ssENProposalApproval.FillFromOther((IRecord) other.AttributeGet(IdProposalApproval));
ssENApplicationRole.FillFromOther((IRecord) other.AttributeGet(IdApplicationRole));
}
} // RC_37b2ba4d72ceb89cfb30009990025b2f
/// <summary>
/// RecordList type <code>ProposalApprovalLevelProposalProposalApprovalApplicationRoleRecordList</code>
///  that represents a record list of <code>ProposalApprovalLevel, Proposal, ProposalApproval
/// , ApplicationRole</code>
/// </summary>
public partial class RL_5c3f0f159a56c705e2e8b813bae3e604 : GenericRecordList<RC_37b2ba4d72ceb89cfb30009990025b2f>, IEnumerable, IEnumerator {

protected override RC_37b2ba4d72ceb89cfb30009990025b2f GetElementDefaultValue() {
return new RC_37b2ba4d72ceb89cfb30009990025b2f();
}

public T[] ToArray<T>(Func<RC_37b2ba4d72ceb89cfb30009990025b2f, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_5c3f0f159a56c705e2e8b813bae3e604 recordList, Func<RC_37b2ba4d72ceb89cfb30009990025b2f, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_5c3f0f159a56c705e2e8b813bae3e604(RC_37b2ba4d72ceb89cfb30009990025b2f[] array) {
  RL_5c3f0f159a56c705e2e8b813bae3e604 result = new RL_5c3f0f159a56c705e2e8b813bae3e604();
result.InnerFromArray(array);
    return result;
}

public static RL_5c3f0f159a56c705e2e8b813bae3e604 ToList<T>(T[] array, Func <T, RC_37b2ba4d72ceb89cfb30009990025b2f> converter) {
  RL_5c3f0f159a56c705e2e8b813bae3e604 result = new RL_5c3f0f159a56c705e2e8b813bae3e604();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_5c3f0f159a56c705e2e8b813bae3e604 FromRestList<T>(RestList<T> restList, Func <T, RC_37b2ba4d72ceb89cfb30009990025b2f> converter) {
  RL_5c3f0f159a56c705e2e8b813bae3e604 result = new RL_5c3f0f159a56c705e2e8b813bae3e604();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_5c3f0f159a56c705e2e8b813bae3e604() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[4];
def[0] = new BitArray(7,false);
def[1] = new BitArray(18,false);
def[2] = new BitArray(8,false);
def[3] = new BitArray(7,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_37b2ba4d72ceb89cfb30009990025b2f> NewList() {
return new RL_5c3f0f159a56c705e2e8b813bae3e604();
}


} // RL_5c3f0f159a56c705e2e8b813bae3e604
}

