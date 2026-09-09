namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (V89AUs2v9UuHMgU86IROZg)
///  <code>RC_ad5e17bc33d6c36e94593cff1d9300bb</code> that represent
/// s <code>ProposalProposalTypeApprovalStatusProposalStatusProposalLineRecord</code> <p>Description:
///  </p>
/// </summary>
// Name: ProposalProposalTypeApprovalStatusProposalStatusProposalLineRecord
public partial struct RC_ad5e17bc33d6c36e94593cff1d9300bb : ITypedRecord<RC_ad5e17bc33d6c36e94593cff1d9300bb> {
internal static readonly GlobalObjectKey IdProposal = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*9MStkYpvUQ_KzEvHGNLqNQ");
internal static readonly GlobalObjectKey IdProposalType = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*U3yn1g4LJh+H7msyFOI37w");
internal static readonly GlobalObjectKey IdApprovalStatus = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*C3GUXt6ghGRa8vnRzAiDAg");
internal static readonly GlobalObjectKey IdProposalStatus = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*o_cnVgbsYD4oY+5rTdgWog");
internal static readonly GlobalObjectKey IdProposalLine = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Ejn_ywl2+KAwstNJSNHAGQ");

public EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord ssENProposal;

public EN_7de728375ec552c47f71bca85f9991d9EntityRecord ssENProposalType;

public EN_e97ac0d21205ff90ab42100bba6097baEntityRecord ssENApprovalStatus;

public EN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord ssENProposalStatus;

public EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord ssENProposalLine;


public BitArray OptimizedAttributes;

public RC_ad5e17bc33d6c36e94593cff1d9300bb() {
OptimizedAttributes = null;
ssENProposal = new EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord();
ssENProposalType = new EN_7de728375ec552c47f71bca85f9991d9EntityRecord();
ssENApprovalStatus = new EN_e97ac0d21205ff90ab42100bba6097baEntityRecord();
ssENProposalStatus = new EN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord();
ssENProposalLine = new EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[5];
    all[0] = new BitArray(18,false);
    all[1] = new BitArray(4,false);
    all[2] = new BitArray(10,false);
    all[3] = new BitArray(5,false);
    all[4] = new BitArray(28,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENProposal.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENProposalType.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENApprovalStatus.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENProposalStatus.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENProposalLine.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    }else{
    ssENProposal.OptimizedAttributes = value[0];
    ssENProposalType.OptimizedAttributes = value[1];
    ssENApprovalStatus.OptimizedAttributes = value[2];
    ssENProposalStatus.OptimizedAttributes = value[3];
    ssENProposalLine.OptimizedAttributes = value[4];
    }
}
get{
    BitArray[] all = new BitArray[5];
    all[0] = ssENProposal.OptimizedAttributes;
    all[1] = ssENProposalType.OptimizedAttributes;
    all[2] = ssENApprovalStatus.OptimizedAttributes;
    all[3] = ssENProposalStatus.OptimizedAttributes;
    all[4] = ssENProposalLine.OptimizedAttributes;
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
ssENProposalType.Read( r, ref index);
ssENApprovalStatus.Read( r, ref index);
ssENProposalStatus.Read( r, ref index);
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
public void ReadIM(RC_ad5e17bc33d6c36e94593cff1d9300bb r) {
this = r;
}


public static bool operator == (RC_ad5e17bc33d6c36e94593cff1d9300bb a, RC_ad5e17bc33d6c36e94593cff1d9300bb b) {
if (a.ssENProposal != b.ssENProposal) return false;
if (a.ssENProposalType != b.ssENProposalType) return false;
if (a.ssENApprovalStatus != b.ssENApprovalStatus) return false;
if (a.ssENProposalStatus != b.ssENProposalStatus) return false;
if (a.ssENProposalLine != b.ssENProposalLine) return false;
return true;
}

public static bool operator != (RC_ad5e17bc33d6c36e94593cff1d9300bb a, RC_ad5e17bc33d6c36e94593cff1d9300bb b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_ad5e17bc33d6c36e94593cff1d9300bb)) return false;
return (this == (RC_ad5e17bc33d6c36e94593cff1d9300bb)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENProposal.GetHashCode()
 ^ ssENProposalType.GetHashCode()
 ^ ssENApprovalStatus.GetHashCode()
 ^ ssENProposalStatus.GetHashCode()
 ^ ssENProposalLine.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENProposal.RecursiveReset();
ssENProposalType.RecursiveReset();
ssENApprovalStatus.RecursiveReset();
ssENProposalStatus.RecursiveReset();
ssENProposalLine.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENProposal.InternalRecursiveSave();
ssENProposalType.InternalRecursiveSave();
ssENApprovalStatus.InternalRecursiveSave();
ssENProposalStatus.InternalRecursiveSave();
ssENProposalLine.InternalRecursiveSave();
}


public RC_ad5e17bc33d6c36e94593cff1d9300bb Duplicate() {
RC_ad5e17bc33d6c36e94593cff1d9300bb t;
t.ssENProposal = (EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord)this.ssENProposal.Duplicate();
t.ssENProposalType = (EN_7de728375ec552c47f71bca85f9991d9EntityRecord)this.ssENProposalType.Duplicate();
t.ssENApprovalStatus = (EN_e97ac0d21205ff90ab42100bba6097baEntityRecord)this.ssENApprovalStatus.Duplicate();
t.ssENProposalStatus = (EN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord)this.ssENProposalStatus.Duplicate();
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
} else if (head == "proposaltype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProposalType")) variable.Value = ssENProposalType; else variable.Optimized = true;
variable.SetFieldName("proposaltype");
} else if (head == "approvalstatus") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApprovalStatus")) variable.Value = ssENApprovalStatus; else variable.Optimized = true;
variable.SetFieldName("approvalstatus");
} else if (head == "proposalstatus") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProposalStatus")) variable.Value = ssENProposalStatus; else variable.Optimized = true;
variable.SetFieldName("proposalstatus");
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
if (key == IdProposalType) {
return ssENProposalType;
}
if (key == IdApprovalStatus) {
return ssENApprovalStatus;
}
if (key == IdProposalStatus) {
return ssENProposalStatus;
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
if (attributeKey == IdProposalType.Key.AsGuid) {
return ssENProposalType;
}
if (attributeKey == IdApprovalStatus.Key.AsGuid) {
return ssENApprovalStatus;
}
if (attributeKey == IdProposalStatus.Key.AsGuid) {
return ssENProposalStatus;
}
if (attributeKey == IdProposalLine.Key.AsGuid) {
return ssENProposalLine;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENProposal.FillFromOther((IRecord) other.AttributeGet(IdProposal));
ssENProposalType.FillFromOther((IRecord) other.AttributeGet(IdProposalType));
ssENApprovalStatus.FillFromOther((IRecord) other.AttributeGet(IdApprovalStatus));
ssENProposalStatus.FillFromOther((IRecord) other.AttributeGet(IdProposalStatus));
ssENProposalLine.FillFromOther((IRecord) other.AttributeGet(IdProposalLine));
}
} // RC_ad5e17bc33d6c36e94593cff1d9300bb
/// <summary>
/// RecordList type <code>ProposalProposalTypeApprovalStatusProposalStatusProposalLineRecordList</code>
///  that represents a record list of <code>Proposal, ProposalType, ApprovalStatus, ProposalStatus
/// , ProposalLine</code>
/// </summary>
public partial class RL_3d7f0e13438b1662f16b29b5c58fbf9f : GenericRecordList<RC_ad5e17bc33d6c36e94593cff1d9300bb>, IEnumerable, IEnumerator {

protected override RC_ad5e17bc33d6c36e94593cff1d9300bb GetElementDefaultValue() {
return new RC_ad5e17bc33d6c36e94593cff1d9300bb();
}

public T[] ToArray<T>(Func<RC_ad5e17bc33d6c36e94593cff1d9300bb, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_3d7f0e13438b1662f16b29b5c58fbf9f recordList, Func<RC_ad5e17bc33d6c36e94593cff1d9300bb, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_3d7f0e13438b1662f16b29b5c58fbf9f(RC_ad5e17bc33d6c36e94593cff1d9300bb[] array) {
  RL_3d7f0e13438b1662f16b29b5c58fbf9f result = new RL_3d7f0e13438b1662f16b29b5c58fbf9f();
result.InnerFromArray(array);
    return result;
}

public static RL_3d7f0e13438b1662f16b29b5c58fbf9f ToList<T>(T[] array, Func <T, RC_ad5e17bc33d6c36e94593cff1d9300bb> converter) {
  RL_3d7f0e13438b1662f16b29b5c58fbf9f result = new RL_3d7f0e13438b1662f16b29b5c58fbf9f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_3d7f0e13438b1662f16b29b5c58fbf9f FromRestList<T>(RestList<T> restList, Func <T, RC_ad5e17bc33d6c36e94593cff1d9300bb> converter) {
  RL_3d7f0e13438b1662f16b29b5c58fbf9f result = new RL_3d7f0e13438b1662f16b29b5c58fbf9f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_3d7f0e13438b1662f16b29b5c58fbf9f() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[5];
def[0] = new BitArray(18,false);
def[1] = new BitArray(4,false);
def[2] = new BitArray(10,false);
def[3] = new BitArray(5,false);
def[4] = new BitArray(28,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_ad5e17bc33d6c36e94593cff1d9300bb> NewList() {
return new RL_3d7f0e13438b1662f16b29b5c58fbf9f();
}


} // RL_3d7f0e13438b1662f16b29b5c58fbf9f
}

