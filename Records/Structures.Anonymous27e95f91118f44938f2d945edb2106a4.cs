namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (kV_pJ48Rk0SPLZRe2yEGpA)
///  <code>RC_931c5818c70fb94c867f1591b8f8bd0d</code> that represent
/// s <code>CurrencyBankProposalFileExtendedProposalTypeProposalStatusRegionRecord</code>
///  <p>Description: </p>
/// </summary>
// Name: CurrencyBankProposalFileExtendedProposalTypeProposalStatusRegionRecord
public partial struct RC_931c5818c70fb94c867f1591b8f8bd0d : ITypedRecord<RC_931c5818c70fb94c867f1591b8f8bd0d> {
internal static readonly GlobalObjectKey IdCurrency = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*L_BoBOY11sygkvMhxdiojg");
internal static readonly GlobalObjectKey IdBank = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*1G6A35RVwbgtxB2EWXPESg");
internal static readonly GlobalObjectKey IdProposal = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*9MStkYpvUQ_KzEvHGNLqNQ");
internal static readonly GlobalObjectKey IdFileExtended = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*jaI+blUswivMEp9CKX5Zgg");
internal static readonly GlobalObjectKey IdProposalType = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*U3yn1g4LJh+H7msyFOI37w");
internal static readonly GlobalObjectKey IdProposalStatus = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*o_cnVgbsYD4oY+5rTdgWog");
internal static readonly GlobalObjectKey IdRegion = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*w1243kBmkvqNrl3ySTBl0A");

public EN_327b52812b8badb247bde4975c10d441EntityRecord ssENCurrency;

public EN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord ssENBank;

public EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord ssENProposal;

public EN_dcebdd8ba305133f41b1e1804925997fEntityRecord ssENFileExtended;

public EN_7de728375ec552c47f71bca85f9991d9EntityRecord ssENProposalType;

public EN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord ssENProposalStatus;

public EN_31f501c551d210017fcb34b5237e3390EntityRecord ssENRegion;


public BitArray OptimizedAttributes;

public RC_931c5818c70fb94c867f1591b8f8bd0d() {
OptimizedAttributes = null;
ssENCurrency = new EN_327b52812b8badb247bde4975c10d441EntityRecord();
ssENBank = new EN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord();
ssENProposal = new EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord();
ssENFileExtended = new EN_dcebdd8ba305133f41b1e1804925997fEntityRecord();
ssENProposalType = new EN_7de728375ec552c47f71bca85f9991d9EntityRecord();
ssENProposalStatus = new EN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord();
ssENRegion = new EN_31f501c551d210017fcb34b5237e3390EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[7];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(6,false);
    all[2] = new BitArray(18,false);
    all[3] = new BitArray(7,false);
    all[4] = new BitArray(4,false);
    all[5] = new BitArray(5,false);
    all[6] = new BitArray(13,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENCurrency.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENBank.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENProposal.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENFileExtended.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENProposalType.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    ssENProposalStatus.OptimizedAttributes = GetDefaultOptimizedValues()[5];
    ssENRegion.OptimizedAttributes = GetDefaultOptimizedValues()[6];
    }else{
    ssENCurrency.OptimizedAttributes = value[0];
    ssENBank.OptimizedAttributes = value[1];
    ssENProposal.OptimizedAttributes = value[2];
    ssENFileExtended.OptimizedAttributes = value[3];
    ssENProposalType.OptimizedAttributes = value[4];
    ssENProposalStatus.OptimizedAttributes = value[5];
    ssENRegion.OptimizedAttributes = value[6];
    }
}
get{
    BitArray[] all = new BitArray[7];
    all[0] = ssENCurrency.OptimizedAttributes;
    all[1] = ssENBank.OptimizedAttributes;
    all[2] = ssENProposal.OptimizedAttributes;
    all[3] = ssENFileExtended.OptimizedAttributes;
    all[4] = ssENProposalType.OptimizedAttributes;
    all[5] = ssENProposalStatus.OptimizedAttributes;
    all[6] = ssENRegion.OptimizedAttributes;
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
ssENProposal.Read( r, ref index);
ssENFileExtended.Read( r, ref index);
ssENProposalType.Read( r, ref index);
ssENProposalStatus.Read( r, ref index);
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
public void ReadIM(RC_931c5818c70fb94c867f1591b8f8bd0d r) {
this = r;
}


public static bool operator == (RC_931c5818c70fb94c867f1591b8f8bd0d a, RC_931c5818c70fb94c867f1591b8f8bd0d b) {
if (a.ssENCurrency != b.ssENCurrency) return false;
if (a.ssENBank != b.ssENBank) return false;
if (a.ssENProposal != b.ssENProposal) return false;
if (a.ssENFileExtended != b.ssENFileExtended) return false;
if (a.ssENProposalType != b.ssENProposalType) return false;
if (a.ssENProposalStatus != b.ssENProposalStatus) return false;
if (a.ssENRegion != b.ssENRegion) return false;
return true;
}

public static bool operator != (RC_931c5818c70fb94c867f1591b8f8bd0d a, RC_931c5818c70fb94c867f1591b8f8bd0d b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_931c5818c70fb94c867f1591b8f8bd0d)) return false;
return (this == (RC_931c5818c70fb94c867f1591b8f8bd0d)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENCurrency.GetHashCode()
 ^ ssENBank.GetHashCode()
 ^ ssENProposal.GetHashCode()
 ^ ssENFileExtended.GetHashCode()
 ^ ssENProposalType.GetHashCode()
 ^ ssENProposalStatus.GetHashCode()
 ^ ssENRegion.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENCurrency.RecursiveReset();
ssENBank.RecursiveReset();
ssENProposal.RecursiveReset();
ssENFileExtended.RecursiveReset();
ssENProposalType.RecursiveReset();
ssENProposalStatus.RecursiveReset();
ssENRegion.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENCurrency.InternalRecursiveSave();
ssENBank.InternalRecursiveSave();
ssENProposal.InternalRecursiveSave();
ssENFileExtended.InternalRecursiveSave();
ssENProposalType.InternalRecursiveSave();
ssENProposalStatus.InternalRecursiveSave();
ssENRegion.InternalRecursiveSave();
}


public RC_931c5818c70fb94c867f1591b8f8bd0d Duplicate() {
RC_931c5818c70fb94c867f1591b8f8bd0d t;
t.ssENCurrency = (EN_327b52812b8badb247bde4975c10d441EntityRecord)this.ssENCurrency.Duplicate();
t.ssENBank = (EN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord)this.ssENBank.Duplicate();
t.ssENProposal = (EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord)this.ssENProposal.Duplicate();
t.ssENFileExtended = (EN_dcebdd8ba305133f41b1e1804925997fEntityRecord)this.ssENFileExtended.Duplicate();
t.ssENProposalType = (EN_7de728375ec552c47f71bca85f9991d9EntityRecord)this.ssENProposalType.Duplicate();
t.ssENProposalStatus = (EN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord)this.ssENProposalStatus.Duplicate();
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
if (attributeKey == IdRegion.Key.AsGuid) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENCurrency.FillFromOther((IRecord) other.AttributeGet(IdCurrency));
ssENBank.FillFromOther((IRecord) other.AttributeGet(IdBank));
ssENProposal.FillFromOther((IRecord) other.AttributeGet(IdProposal));
ssENFileExtended.FillFromOther((IRecord) other.AttributeGet(IdFileExtended));
ssENProposalType.FillFromOther((IRecord) other.AttributeGet(IdProposalType));
ssENProposalStatus.FillFromOther((IRecord) other.AttributeGet(IdProposalStatus));
ssENRegion.FillFromOther((IRecord) other.AttributeGet(IdRegion));
}
} // RC_931c5818c70fb94c867f1591b8f8bd0d
/// <summary>
/// RecordList type
///  <code>CurrencyBankProposalFileExtendedProposalTypeProposalStatusRegionRecordList</code> tha
/// t represents a record list of <code>Currency, Bank, Proposal, FileExtended, ProposalType,
///  ProposalStatus, Region</code>
/// </summary>
public partial class RL_f4591be205d3928a9fe22daf19d979cd : GenericRecordList<RC_931c5818c70fb94c867f1591b8f8bd0d>, IEnumerable, IEnumerator {

protected override RC_931c5818c70fb94c867f1591b8f8bd0d GetElementDefaultValue() {
return new RC_931c5818c70fb94c867f1591b8f8bd0d();
}

public T[] ToArray<T>(Func<RC_931c5818c70fb94c867f1591b8f8bd0d, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f4591be205d3928a9fe22daf19d979cd recordList, Func<RC_931c5818c70fb94c867f1591b8f8bd0d, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f4591be205d3928a9fe22daf19d979cd(RC_931c5818c70fb94c867f1591b8f8bd0d[] array) {
  RL_f4591be205d3928a9fe22daf19d979cd result = new RL_f4591be205d3928a9fe22daf19d979cd();
result.InnerFromArray(array);
    return result;
}

public static RL_f4591be205d3928a9fe22daf19d979cd ToList<T>(T[] array, Func <T, RC_931c5818c70fb94c867f1591b8f8bd0d> converter) {
  RL_f4591be205d3928a9fe22daf19d979cd result = new RL_f4591be205d3928a9fe22daf19d979cd();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f4591be205d3928a9fe22daf19d979cd FromRestList<T>(RestList<T> restList, Func <T, RC_931c5818c70fb94c867f1591b8f8bd0d> converter) {
  RL_f4591be205d3928a9fe22daf19d979cd result = new RL_f4591be205d3928a9fe22daf19d979cd();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f4591be205d3928a9fe22daf19d979cd() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[7];
def[0] = new BitArray(5,false);
def[1] = new BitArray(6,false);
def[2] = new BitArray(18,false);
def[3] = new BitArray(7,false);
def[4] = new BitArray(4,false);
def[5] = new BitArray(5,false);
def[6] = new BitArray(13,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_931c5818c70fb94c867f1591b8f8bd0d> NewList() {
return new RL_f4591be205d3928a9fe22daf19d979cd();
}


} // RL_f4591be205d3928a9fe22daf19d979cd
}

