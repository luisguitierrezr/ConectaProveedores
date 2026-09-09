namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (ddv6VkRlHk6yM7rB9lhXhw)
///  <code>RC_c7a16f0a3087a0bdd1d36be1ccbc2cc3</code> that represent
/// s
///  <code>CurrencyBankProposalApprovalLevelProposalProposalTypeApprovalStatusProposalLineApprovalLevelP
/// roposalApprovalProposalLineApplicationRoleCompanyRegionRecord</code> <p>Description: </p>
/// </summary>
// Name: CurrencyBankProposalApprovalLevelProposalProposalTypeApprovalStatusProposalLineApprovalLevelProposalApprovalProposalLineApplicationRoleCompanyRegionRecord
public partial struct RC_c7a16f0a3087a0bdd1d36be1ccbc2cc3 : ITypedRecord<RC_c7a16f0a3087a0bdd1d36be1ccbc2cc3> {
internal static readonly GlobalObjectKey IdCurrency = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*L_BoBOY11sygkvMhxdiojg");
internal static readonly GlobalObjectKey IdBank = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*1G6A35RVwbgtxB2EWXPESg");
internal static readonly GlobalObjectKey IdProposalApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*eJqSVc+Lx3kjVPxJFgrMDA");
internal static readonly GlobalObjectKey IdProposal = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*9MStkYpvUQ_KzEvHGNLqNQ");
internal static readonly GlobalObjectKey IdProposalType = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*U3yn1g4LJh+H7msyFOI37w");
internal static readonly GlobalObjectKey IdApprovalStatus = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*C3GUXt6ghGRa8vnRzAiDAg");
internal static readonly GlobalObjectKey IdProposalLineApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*XbRfhyNBH6nOg4MfD1VNjg");
internal static readonly GlobalObjectKey IdProposalApproval = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*1sFbHhDQH3aGXjoHdPHIGQ");
internal static readonly GlobalObjectKey IdProposalLine = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Ejn_ywl2+KAwstNJSNHAGQ");
internal static readonly GlobalObjectKey IdApplicationRole = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Q0fszuVdwmNpC2BezKaalA");
internal static readonly GlobalObjectKey IdCompany = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*bfqhmYH0W+wZCOdwyBtzsQ");
internal static readonly GlobalObjectKey IdRegion = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*w1243kBmkvqNrl3ySTBl0A");

public EN_327b52812b8badb247bde4975c10d441EntityRecord ssENCurrency;

public EN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord ssENBank;

public EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord ssENProposalApprovalLevel;

public EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord ssENProposal;

public EN_7de728375ec552c47f71bca85f9991d9EntityRecord ssENProposalType;

public EN_e97ac0d21205ff90ab42100bba6097baEntityRecord ssENApprovalStatus;

public EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord ssENProposalLineApprovalLevel;

public EN_5464a383ceb6bec564e8dfa03f011357EntityRecord ssENProposalApproval;

public EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord ssENProposalLine;

public EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord ssENApplicationRole;

public EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord ssENCompany;

public EN_31f501c551d210017fcb34b5237e3390EntityRecord ssENRegion;


public BitArray OptimizedAttributes;

public RC_c7a16f0a3087a0bdd1d36be1ccbc2cc3() {
OptimizedAttributes = null;
ssENCurrency = new EN_327b52812b8badb247bde4975c10d441EntityRecord();
ssENBank = new EN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord();
ssENProposalApprovalLevel = new EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord();
ssENProposal = new EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord();
ssENProposalType = new EN_7de728375ec552c47f71bca85f9991d9EntityRecord();
ssENApprovalStatus = new EN_e97ac0d21205ff90ab42100bba6097baEntityRecord();
ssENProposalLineApprovalLevel = new EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord();
ssENProposalApproval = new EN_5464a383ceb6bec564e8dfa03f011357EntityRecord();
ssENProposalLine = new EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord();
ssENApplicationRole = new EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord();
ssENCompany = new EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord();
ssENRegion = new EN_31f501c551d210017fcb34b5237e3390EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[12];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(6,false);
    all[2] = new BitArray(7,false);
    all[3] = new BitArray(18,false);
    all[4] = new BitArray(4,false);
    all[5] = new BitArray(10,false);
    all[6] = new BitArray(9,false);
    all[7] = new BitArray(8,false);
    all[8] = new BitArray(28,false);
    all[9] = new BitArray(7,false);
    all[10] = new BitArray(11,false);
    all[11] = new BitArray(13,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENCurrency.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENBank.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENProposalApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENProposal.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENProposalType.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    ssENApprovalStatus.OptimizedAttributes = GetDefaultOptimizedValues()[5];
    ssENProposalLineApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[6];
    ssENProposalApproval.OptimizedAttributes = GetDefaultOptimizedValues()[7];
    ssENProposalLine.OptimizedAttributes = GetDefaultOptimizedValues()[8];
    ssENApplicationRole.OptimizedAttributes = GetDefaultOptimizedValues()[9];
    ssENCompany.OptimizedAttributes = GetDefaultOptimizedValues()[10];
    ssENRegion.OptimizedAttributes = GetDefaultOptimizedValues()[11];
    }else{
    ssENCurrency.OptimizedAttributes = value[0];
    ssENBank.OptimizedAttributes = value[1];
    ssENProposalApprovalLevel.OptimizedAttributes = value[2];
    ssENProposal.OptimizedAttributes = value[3];
    ssENProposalType.OptimizedAttributes = value[4];
    ssENApprovalStatus.OptimizedAttributes = value[5];
    ssENProposalLineApprovalLevel.OptimizedAttributes = value[6];
    ssENProposalApproval.OptimizedAttributes = value[7];
    ssENProposalLine.OptimizedAttributes = value[8];
    ssENApplicationRole.OptimizedAttributes = value[9];
    ssENCompany.OptimizedAttributes = value[10];
    ssENRegion.OptimizedAttributes = value[11];
    }
}
get{
    BitArray[] all = new BitArray[12];
    all[0] = ssENCurrency.OptimizedAttributes;
    all[1] = ssENBank.OptimizedAttributes;
    all[2] = ssENProposalApprovalLevel.OptimizedAttributes;
    all[3] = ssENProposal.OptimizedAttributes;
    all[4] = ssENProposalType.OptimizedAttributes;
    all[5] = ssENApprovalStatus.OptimizedAttributes;
    all[6] = ssENProposalLineApprovalLevel.OptimizedAttributes;
    all[7] = ssENProposalApproval.OptimizedAttributes;
    all[8] = ssENProposalLine.OptimizedAttributes;
    all[9] = ssENApplicationRole.OptimizedAttributes;
    all[10] = ssENCompany.OptimizedAttributes;
    all[11] = ssENRegion.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENCurrency.Read( r, ref index);
ssENBank.Read( r, ref index);
ssENProposalApprovalLevel.Read( r, ref index);
ssENProposal.Read( r, ref index);
ssENProposalType.Read( r, ref index);
ssENApprovalStatus.Read( r, ref index);
ssENProposalLineApprovalLevel.Read( r, ref index);
ssENProposalApproval.Read( r, ref index);
ssENProposalLine.Read( r, ref index);
ssENApplicationRole.Read( r, ref index);
ssENCompany.Read( r, ref index);
ssENRegion.Read( r, ref index);
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
public void ReadIM(RC_c7a16f0a3087a0bdd1d36be1ccbc2cc3 r) {
this = r;
}


public static bool operator == (RC_c7a16f0a3087a0bdd1d36be1ccbc2cc3 a, RC_c7a16f0a3087a0bdd1d36be1ccbc2cc3 b) {
if (a.ssENCurrency != b.ssENCurrency) return false;
if (a.ssENBank != b.ssENBank) return false;
if (a.ssENProposalApprovalLevel != b.ssENProposalApprovalLevel) return false;
if (a.ssENProposal != b.ssENProposal) return false;
if (a.ssENProposalType != b.ssENProposalType) return false;
if (a.ssENApprovalStatus != b.ssENApprovalStatus) return false;
if (a.ssENProposalLineApprovalLevel != b.ssENProposalLineApprovalLevel) return false;
if (a.ssENProposalApproval != b.ssENProposalApproval) return false;
if (a.ssENProposalLine != b.ssENProposalLine) return false;
if (a.ssENApplicationRole != b.ssENApplicationRole) return false;
if (a.ssENCompany != b.ssENCompany) return false;
if (a.ssENRegion != b.ssENRegion) return false;
return true;
}

public static bool operator != (RC_c7a16f0a3087a0bdd1d36be1ccbc2cc3 a, RC_c7a16f0a3087a0bdd1d36be1ccbc2cc3 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_c7a16f0a3087a0bdd1d36be1ccbc2cc3)) return false;
return (this == (RC_c7a16f0a3087a0bdd1d36be1ccbc2cc3)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENCurrency.GetHashCode()
 ^ ssENBank.GetHashCode()
 ^ ssENProposalApprovalLevel.GetHashCode()
 ^ ssENProposal.GetHashCode()
 ^ ssENProposalType.GetHashCode()
 ^ ssENApprovalStatus.GetHashCode()
 ^ ssENProposalLineApprovalLevel.GetHashCode()
 ^ ssENProposalApproval.GetHashCode()
 ^ ssENProposalLine.GetHashCode()
 ^ ssENApplicationRole.GetHashCode()
 ^ ssENCompany.GetHashCode()
 ^ ssENRegion.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENCurrency.RecursiveReset();
ssENBank.RecursiveReset();
ssENProposalApprovalLevel.RecursiveReset();
ssENProposal.RecursiveReset();
ssENProposalType.RecursiveReset();
ssENApprovalStatus.RecursiveReset();
ssENProposalLineApprovalLevel.RecursiveReset();
ssENProposalApproval.RecursiveReset();
ssENProposalLine.RecursiveReset();
ssENApplicationRole.RecursiveReset();
ssENCompany.RecursiveReset();
ssENRegion.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENCurrency.InternalRecursiveSave();
ssENBank.InternalRecursiveSave();
ssENProposalApprovalLevel.InternalRecursiveSave();
ssENProposal.InternalRecursiveSave();
ssENProposalType.InternalRecursiveSave();
ssENApprovalStatus.InternalRecursiveSave();
ssENProposalLineApprovalLevel.InternalRecursiveSave();
ssENProposalApproval.InternalRecursiveSave();
ssENProposalLine.InternalRecursiveSave();
ssENApplicationRole.InternalRecursiveSave();
ssENCompany.InternalRecursiveSave();
ssENRegion.InternalRecursiveSave();
}


public RC_c7a16f0a3087a0bdd1d36be1ccbc2cc3 Duplicate() {
RC_c7a16f0a3087a0bdd1d36be1ccbc2cc3 t;
t.ssENCurrency = (EN_327b52812b8badb247bde4975c10d441EntityRecord)this.ssENCurrency.Duplicate();
t.ssENBank = (EN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord)this.ssENBank.Duplicate();
t.ssENProposalApprovalLevel = (EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord)this.ssENProposalApprovalLevel.Duplicate();
t.ssENProposal = (EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord)this.ssENProposal.Duplicate();
t.ssENProposalType = (EN_7de728375ec552c47f71bca85f9991d9EntityRecord)this.ssENProposalType.Duplicate();
t.ssENApprovalStatus = (EN_e97ac0d21205ff90ab42100bba6097baEntityRecord)this.ssENApprovalStatus.Duplicate();
t.ssENProposalLineApprovalLevel = (EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord)this.ssENProposalLineApprovalLevel.Duplicate();
t.ssENProposalApproval = (EN_5464a383ceb6bec564e8dfa03f011357EntityRecord)this.ssENProposalApproval.Duplicate();
t.ssENProposalLine = (EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord)this.ssENProposalLine.Duplicate();
t.ssENApplicationRole = (EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord)this.ssENApplicationRole.Duplicate();
t.ssENCompany = (EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord)this.ssENCompany.Duplicate();
t.ssENRegion = (EN_31f501c551d210017fcb34b5237e3390EntityRecord)this.ssENRegion.Duplicate();
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
if (head == "currency") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Currency")) variable.Value = ssENCurrency; else variable.Optimized = true;
variable.SetFieldName("currency");
} else if (head == "bank") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Bank")) variable.Value = ssENBank; else variable.Optimized = true;
variable.SetFieldName("bank");
} else if (head == "proposalapprovallevel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProposalApprovalLevel")) variable.Value = ssENProposalApprovalLevel; else variable.Optimized = true;
variable.SetFieldName("proposalapprovallevel");
} else if (head == "proposal") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Proposal")) variable.Value = ssENProposal; else variable.Optimized = true;
variable.SetFieldName("proposal");
} else if (head == "proposaltype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProposalType")) variable.Value = ssENProposalType; else variable.Optimized = true;
variable.SetFieldName("proposaltype");
} else if (head == "approvalstatus") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApprovalStatus")) variable.Value = ssENApprovalStatus; else variable.Optimized = true;
variable.SetFieldName("approvalstatus");
} else if (head == "proposallineapprovallevel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProposalLineApprovalLevel")) variable.Value = ssENProposalLineApprovalLevel; else variable.Optimized = true;
variable.SetFieldName("proposallineapprovallevel");
} else if (head == "proposalapproval") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProposalApproval")) variable.Value = ssENProposalApproval; else variable.Optimized = true;
variable.SetFieldName("proposalapproval");
} else if (head == "proposalline") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProposalLine")) variable.Value = ssENProposalLine; else variable.Optimized = true;
variable.SetFieldName("proposalline");
} else if (head == "applicationrole") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApplicationRole")) variable.Value = ssENApplicationRole; else variable.Optimized = true;
variable.SetFieldName("applicationrole");
} else if (head == "company") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Company")) variable.Value = ssENCompany; else variable.Optimized = true;
variable.SetFieldName("company");
} else if (head == "region") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Region")) variable.Value = ssENRegion; else variable.Optimized = true;
variable.SetFieldName("region");
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
if (key == IdCurrency) {
return ssENCurrency;
}
if (key == IdBank) {
return ssENBank;
}
if (key == IdProposalApprovalLevel) {
return ssENProposalApprovalLevel;
}
if (key == IdProposal) {
return ssENProposal;
}
if (key == IdProposalType) {
return ssENProposalType;
}
if (key == IdApprovalStatus) {
return ssENApprovalStatus;
}
if (key == IdProposalLineApprovalLevel) {
return ssENProposalLineApprovalLevel;
}
if (key == IdProposalApproval) {
return ssENProposalApproval;
}
if (key == IdProposalLine) {
return ssENProposalLine;
}
if (key == IdApplicationRole) {
return ssENApplicationRole;
}
if (key == IdCompany) {
return ssENCompany;
}
if (key == IdRegion) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdCurrency.Key.AsGuid) {
return ssENCurrency;
}
if (attributeKey == IdBank.Key.AsGuid) {
return ssENBank;
}
if (attributeKey == IdProposalApprovalLevel.Key.AsGuid) {
return ssENProposalApprovalLevel;
}
if (attributeKey == IdProposal.Key.AsGuid) {
return ssENProposal;
}
if (attributeKey == IdProposalType.Key.AsGuid) {
return ssENProposalType;
}
if (attributeKey == IdApprovalStatus.Key.AsGuid) {
return ssENApprovalStatus;
}
if (attributeKey == IdProposalLineApprovalLevel.Key.AsGuid) {
return ssENProposalLineApprovalLevel;
}
if (attributeKey == IdProposalApproval.Key.AsGuid) {
return ssENProposalApproval;
}
if (attributeKey == IdProposalLine.Key.AsGuid) {
return ssENProposalLine;
}
if (attributeKey == IdApplicationRole.Key.AsGuid) {
return ssENApplicationRole;
}
if (attributeKey == IdCompany.Key.AsGuid) {
return ssENCompany;
}
if (attributeKey == IdRegion.Key.AsGuid) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENCurrency.FillFromOther((IRecord) other.AttributeGet(IdCurrency));
ssENBank.FillFromOther((IRecord) other.AttributeGet(IdBank));
ssENProposalApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdProposalApprovalLevel));
ssENProposal.FillFromOther((IRecord) other.AttributeGet(IdProposal));
ssENProposalType.FillFromOther((IRecord) other.AttributeGet(IdProposalType));
ssENApprovalStatus.FillFromOther((IRecord) other.AttributeGet(IdApprovalStatus));
ssENProposalLineApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdProposalLineApprovalLevel));
ssENProposalApproval.FillFromOther((IRecord) other.AttributeGet(IdProposalApproval));
ssENProposalLine.FillFromOther((IRecord) other.AttributeGet(IdProposalLine));
ssENApplicationRole.FillFromOther((IRecord) other.AttributeGet(IdApplicationRole));
ssENCompany.FillFromOther((IRecord) other.AttributeGet(IdCompany));
ssENRegion.FillFromOther((IRecord) other.AttributeGet(IdRegion));
}
} // RC_c7a16f0a3087a0bdd1d36be1ccbc2cc3
/// <summary>
/// RecordList type
///  <code>CurrencyBankProposalApprovalLevelProposalProposalTypeApprovalStatusProposalLineApprovalLevelP
/// roposalApprovalProposalLineApplicationRoleCompanyRegionRecordList</code> that represents a record
///  list of <code>Currency, Bank, ProposalApprovalLevel, Proposal, ProposalType, ApprovalStatus
/// , ProposalLineApprovalLevel, ProposalApproval, ProposalLine, ApplicationRole, Company,
///  Region</code>
/// </summary>
public partial class RL_9406b8e184532a1a1ec4388d7e573c1c : GenericRecordList<RC_c7a16f0a3087a0bdd1d36be1ccbc2cc3>, IEnumerable, IEnumerator {

protected override RC_c7a16f0a3087a0bdd1d36be1ccbc2cc3 GetElementDefaultValue() {
return new RC_c7a16f0a3087a0bdd1d36be1ccbc2cc3();
}

public T[] ToArray<T>(Func<RC_c7a16f0a3087a0bdd1d36be1ccbc2cc3, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_9406b8e184532a1a1ec4388d7e573c1c recordList, Func<RC_c7a16f0a3087a0bdd1d36be1ccbc2cc3, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_9406b8e184532a1a1ec4388d7e573c1c(RC_c7a16f0a3087a0bdd1d36be1ccbc2cc3[] array) {
  RL_9406b8e184532a1a1ec4388d7e573c1c result = new RL_9406b8e184532a1a1ec4388d7e573c1c();
result.InnerFromArray(array);
    return result;
}

public static RL_9406b8e184532a1a1ec4388d7e573c1c ToList<T>(T[] array, Func <T, RC_c7a16f0a3087a0bdd1d36be1ccbc2cc3> converter) {
  RL_9406b8e184532a1a1ec4388d7e573c1c result = new RL_9406b8e184532a1a1ec4388d7e573c1c();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_9406b8e184532a1a1ec4388d7e573c1c FromRestList<T>(RestList<T> restList, Func <T, RC_c7a16f0a3087a0bdd1d36be1ccbc2cc3> converter) {
  RL_9406b8e184532a1a1ec4388d7e573c1c result = new RL_9406b8e184532a1a1ec4388d7e573c1c();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_9406b8e184532a1a1ec4388d7e573c1c() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[12];
def[0] = new BitArray(5,false);
def[1] = new BitArray(6,false);
def[2] = new BitArray(7,false);
def[3] = new BitArray(18,false);
def[4] = new BitArray(4,false);
def[5] = new BitArray(10,false);
def[6] = new BitArray(9,false);
def[7] = new BitArray(8,false);
def[8] = new BitArray(28,false);
def[9] = new BitArray(7,false);
def[10] = new BitArray(11,false);
def[11] = new BitArray(13,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_c7a16f0a3087a0bdd1d36be1ccbc2cc3> NewList() {
return new RL_9406b8e184532a1a1ec4388d7e573c1c();
}


} // RL_9406b8e184532a1a1ec4388d7e573c1c
}

