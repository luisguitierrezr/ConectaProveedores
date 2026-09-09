namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (H2Gk0v7tREiVBa3GEeOfSQ)
///  <code>RC_ab84a2ae7d846dd330e85891435fa3cb</code> that represent
/// s
///  <code>CurrencyBankUploadedByProposalFileExtendedProposalTypeProposalStatusFileImportLogRegionRecord
/// </code> <p>Description: </p>
/// </summary>
// Name: CurrencyBankUploadedByProposalFileExtendedProposalTypeProposalStatusFileImportLogRegionRecord
public partial struct RC_ab84a2ae7d846dd330e85891435fa3cb : ITypedRecord<RC_ab84a2ae7d846dd330e85891435fa3cb> {
internal static readonly GlobalObjectKey IdCurrency = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*L_BoBOY11sygkvMhxdiojg");
internal static readonly GlobalObjectKey IdBank = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*1G6A35RVwbgtxB2EWXPESg");
internal static readonly GlobalObjectKey IdUploadedBy = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*LSsr7CNcApeLNjV5eX+M1A");
internal static readonly GlobalObjectKey IdProposal = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*9MStkYpvUQ_KzEvHGNLqNQ");
internal static readonly GlobalObjectKey IdFileExtended = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*jaI+blUswivMEp9CKX5Zgg");
internal static readonly GlobalObjectKey IdProposalType = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*U3yn1g4LJh+H7msyFOI37w");
internal static readonly GlobalObjectKey IdProposalStatus = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*o_cnVgbsYD4oY+5rTdgWog");
internal static readonly GlobalObjectKey IdFileImportLog = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*AkZhHSsD1qFCYyfKsVwaNw");
internal static readonly GlobalObjectKey IdRegion = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*w1243kBmkvqNrl3ySTBl0A");

public EN_327b52812b8badb247bde4975c10d441EntityRecord ssENCurrency;

public EN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord ssENBank;

public ENUserEntityRecord ssENUploadedBy;

public EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord ssENProposal;

public EN_dcebdd8ba305133f41b1e1804925997fEntityRecord ssENFileExtended;

public EN_7de728375ec552c47f71bca85f9991d9EntityRecord ssENProposalType;

public EN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord ssENProposalStatus;

public EN_57456f779b1d12573357da68381e59ceEntityRecord ssENFileImportLog;

public EN_31f501c551d210017fcb34b5237e3390EntityRecord ssENRegion;


public BitArray OptimizedAttributes;

public RC_ab84a2ae7d846dd330e85891435fa3cb() {
OptimizedAttributes = null;
ssENCurrency = new EN_327b52812b8badb247bde4975c10d441EntityRecord();
ssENBank = new EN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord();
ssENUploadedBy = new ENUserEntityRecord();
ssENProposal = new EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord();
ssENFileExtended = new EN_dcebdd8ba305133f41b1e1804925997fEntityRecord();
ssENProposalType = new EN_7de728375ec552c47f71bca85f9991d9EntityRecord();
ssENProposalStatus = new EN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord();
ssENFileImportLog = new EN_57456f779b1d12573357da68381e59ceEntityRecord();
ssENRegion = new EN_31f501c551d210017fcb34b5237e3390EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[9];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(6,false);
    all[2] = new BitArray(5,false);
    all[3] = new BitArray(18,false);
    all[4] = new BitArray(7,false);
    all[5] = new BitArray(4,false);
    all[6] = new BitArray(5,false);
    all[7] = new BitArray(5,false);
    all[8] = new BitArray(13,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENCurrency.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENBank.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENUploadedBy.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENProposal.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENFileExtended.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    ssENProposalType.OptimizedAttributes = GetDefaultOptimizedValues()[5];
    ssENProposalStatus.OptimizedAttributes = GetDefaultOptimizedValues()[6];
    ssENFileImportLog.OptimizedAttributes = GetDefaultOptimizedValues()[7];
    ssENRegion.OptimizedAttributes = GetDefaultOptimizedValues()[8];
    }else{
    ssENCurrency.OptimizedAttributes = value[0];
    ssENBank.OptimizedAttributes = value[1];
    ssENUploadedBy.OptimizedAttributes = value[2];
    ssENProposal.OptimizedAttributes = value[3];
    ssENFileExtended.OptimizedAttributes = value[4];
    ssENProposalType.OptimizedAttributes = value[5];
    ssENProposalStatus.OptimizedAttributes = value[6];
    ssENFileImportLog.OptimizedAttributes = value[7];
    ssENRegion.OptimizedAttributes = value[8];
    }
}
get{
    BitArray[] all = new BitArray[9];
    all[0] = ssENCurrency.OptimizedAttributes;
    all[1] = ssENBank.OptimizedAttributes;
    all[2] = ssENUploadedBy.OptimizedAttributes;
    all[3] = ssENProposal.OptimizedAttributes;
    all[4] = ssENFileExtended.OptimizedAttributes;
    all[5] = ssENProposalType.OptimizedAttributes;
    all[6] = ssENProposalStatus.OptimizedAttributes;
    all[7] = ssENFileImportLog.OptimizedAttributes;
    all[8] = ssENRegion.OptimizedAttributes;
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
ssENUploadedBy.Read( r, ref index);
ssENProposal.Read( r, ref index);
ssENFileExtended.Read( r, ref index);
ssENProposalType.Read( r, ref index);
ssENProposalStatus.Read( r, ref index);
ssENFileImportLog.Read( r, ref index);
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
public void ReadIM(RC_ab84a2ae7d846dd330e85891435fa3cb r) {
this = r;
}


public static bool operator == (RC_ab84a2ae7d846dd330e85891435fa3cb a, RC_ab84a2ae7d846dd330e85891435fa3cb b) {
if (a.ssENCurrency != b.ssENCurrency) return false;
if (a.ssENBank != b.ssENBank) return false;
if (a.ssENUploadedBy != b.ssENUploadedBy) return false;
if (a.ssENProposal != b.ssENProposal) return false;
if (a.ssENFileExtended != b.ssENFileExtended) return false;
if (a.ssENProposalType != b.ssENProposalType) return false;
if (a.ssENProposalStatus != b.ssENProposalStatus) return false;
if (a.ssENFileImportLog != b.ssENFileImportLog) return false;
if (a.ssENRegion != b.ssENRegion) return false;
return true;
}

public static bool operator != (RC_ab84a2ae7d846dd330e85891435fa3cb a, RC_ab84a2ae7d846dd330e85891435fa3cb b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_ab84a2ae7d846dd330e85891435fa3cb)) return false;
return (this == (RC_ab84a2ae7d846dd330e85891435fa3cb)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENCurrency.GetHashCode()
 ^ ssENBank.GetHashCode()
 ^ ssENUploadedBy.GetHashCode()
 ^ ssENProposal.GetHashCode()
 ^ ssENFileExtended.GetHashCode()
 ^ ssENProposalType.GetHashCode()
 ^ ssENProposalStatus.GetHashCode()
 ^ ssENFileImportLog.GetHashCode()
 ^ ssENRegion.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENCurrency.RecursiveReset();
ssENBank.RecursiveReset();
ssENUploadedBy.RecursiveReset();
ssENProposal.RecursiveReset();
ssENFileExtended.RecursiveReset();
ssENProposalType.RecursiveReset();
ssENProposalStatus.RecursiveReset();
ssENFileImportLog.RecursiveReset();
ssENRegion.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENCurrency.InternalRecursiveSave();
ssENBank.InternalRecursiveSave();
ssENUploadedBy.InternalRecursiveSave();
ssENProposal.InternalRecursiveSave();
ssENFileExtended.InternalRecursiveSave();
ssENProposalType.InternalRecursiveSave();
ssENProposalStatus.InternalRecursiveSave();
ssENFileImportLog.InternalRecursiveSave();
ssENRegion.InternalRecursiveSave();
}


public RC_ab84a2ae7d846dd330e85891435fa3cb Duplicate() {
RC_ab84a2ae7d846dd330e85891435fa3cb t;
t.ssENCurrency = (EN_327b52812b8badb247bde4975c10d441EntityRecord)this.ssENCurrency.Duplicate();
t.ssENBank = (EN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord)this.ssENBank.Duplicate();
t.ssENUploadedBy = (ENUserEntityRecord)this.ssENUploadedBy.Duplicate();
t.ssENProposal = (EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord)this.ssENProposal.Duplicate();
t.ssENFileExtended = (EN_dcebdd8ba305133f41b1e1804925997fEntityRecord)this.ssENFileExtended.Duplicate();
t.ssENProposalType = (EN_7de728375ec552c47f71bca85f9991d9EntityRecord)this.ssENProposalType.Duplicate();
t.ssENProposalStatus = (EN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord)this.ssENProposalStatus.Duplicate();
t.ssENFileImportLog = (EN_57456f779b1d12573357da68381e59ceEntityRecord)this.ssENFileImportLog.Duplicate();
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
} else if (head == "uploadedby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UploadedBy")) variable.Value = ssENUploadedBy; else variable.Optimized = true;
variable.SetFieldName("uploadedby");
} else if (head == "proposal") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Proposal")) variable.Value = ssENProposal; else variable.Optimized = true;
variable.SetFieldName("proposal");
} else if (head == "fileextended") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FileExtended")) variable.Value = ssENFileExtended; else variable.Optimized = true;
variable.SetFieldName("fileextended");
} else if (head == "proposaltype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProposalType")) variable.Value = ssENProposalType; else variable.Optimized = true;
variable.SetFieldName("proposaltype");
} else if (head == "proposalstatus") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProposalStatus")) variable.Value = ssENProposalStatus; else variable.Optimized = true;
variable.SetFieldName("proposalstatus");
} else if (head == "fileimportlog") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FileImportLog")) variable.Value = ssENFileImportLog; else variable.Optimized = true;
variable.SetFieldName("fileimportlog");
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
if (key == IdUploadedBy) {
return ssENUploadedBy;
}
if (key == IdProposal) {
return ssENProposal;
}
if (key == IdFileExtended) {
return ssENFileExtended;
}
if (key == IdProposalType) {
return ssENProposalType;
}
if (key == IdProposalStatus) {
return ssENProposalStatus;
}
if (key == IdFileImportLog) {
return ssENFileImportLog;
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
if (attributeKey == IdUploadedBy.Key.AsGuid) {
return ssENUploadedBy;
}
if (attributeKey == IdProposal.Key.AsGuid) {
return ssENProposal;
}
if (attributeKey == IdFileExtended.Key.AsGuid) {
return ssENFileExtended;
}
if (attributeKey == IdProposalType.Key.AsGuid) {
return ssENProposalType;
}
if (attributeKey == IdProposalStatus.Key.AsGuid) {
return ssENProposalStatus;
}
if (attributeKey == IdFileImportLog.Key.AsGuid) {
return ssENFileImportLog;
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
ssENUploadedBy.FillFromOther((IRecord) other.AttributeGet(IdUploadedBy));
ssENProposal.FillFromOther((IRecord) other.AttributeGet(IdProposal));
ssENFileExtended.FillFromOther((IRecord) other.AttributeGet(IdFileExtended));
ssENProposalType.FillFromOther((IRecord) other.AttributeGet(IdProposalType));
ssENProposalStatus.FillFromOther((IRecord) other.AttributeGet(IdProposalStatus));
ssENFileImportLog.FillFromOther((IRecord) other.AttributeGet(IdFileImportLog));
ssENRegion.FillFromOther((IRecord) other.AttributeGet(IdRegion));
}
} // RC_ab84a2ae7d846dd330e85891435fa3cb
/// <summary>
/// RecordList type
///  <code>CurrencyBankUploadedByProposalFileExtendedProposalTypeProposalStatusFileImportLogRegionRecord
/// List</code> that represents a record list of <code>Currency, Bank, User, Proposal, FileExtended,
///  ProposalType, ProposalStatus, FileImportLog, Region</code>
/// </summary>
public partial class RL_edee1bf5e5c171ee5ed6daf5087975b0 : GenericRecordList<RC_ab84a2ae7d846dd330e85891435fa3cb>, IEnumerable, IEnumerator {

protected override RC_ab84a2ae7d846dd330e85891435fa3cb GetElementDefaultValue() {
return new RC_ab84a2ae7d846dd330e85891435fa3cb();
}

public T[] ToArray<T>(Func<RC_ab84a2ae7d846dd330e85891435fa3cb, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_edee1bf5e5c171ee5ed6daf5087975b0 recordList, Func<RC_ab84a2ae7d846dd330e85891435fa3cb, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_edee1bf5e5c171ee5ed6daf5087975b0(RC_ab84a2ae7d846dd330e85891435fa3cb[] array) {
  RL_edee1bf5e5c171ee5ed6daf5087975b0 result = new RL_edee1bf5e5c171ee5ed6daf5087975b0();
result.InnerFromArray(array);
    return result;
}

public static RL_edee1bf5e5c171ee5ed6daf5087975b0 ToList<T>(T[] array, Func <T, RC_ab84a2ae7d846dd330e85891435fa3cb> converter) {
  RL_edee1bf5e5c171ee5ed6daf5087975b0 result = new RL_edee1bf5e5c171ee5ed6daf5087975b0();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_edee1bf5e5c171ee5ed6daf5087975b0 FromRestList<T>(RestList<T> restList, Func <T, RC_ab84a2ae7d846dd330e85891435fa3cb> converter) {
  RL_edee1bf5e5c171ee5ed6daf5087975b0 result = new RL_edee1bf5e5c171ee5ed6daf5087975b0();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_edee1bf5e5c171ee5ed6daf5087975b0() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[9];
def[0] = new BitArray(5,false);
def[1] = new BitArray(6,false);
def[2] = new BitArray(5,false);
def[3] = new BitArray(18,false);
def[4] = new BitArray(7,false);
def[5] = new BitArray(4,false);
def[6] = new BitArray(5,false);
def[7] = new BitArray(5,false);
def[8] = new BitArray(13,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_ab84a2ae7d846dd330e85891435fa3cb> NewList() {
return new RL_edee1bf5e5c171ee5ed6daf5087975b0();
}


} // RL_edee1bf5e5c171ee5ed6daf5087975b0
}

