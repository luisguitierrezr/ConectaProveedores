namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (JBx862AJNUyPp7U5Z+bmKQ)
///  <code>RC_7aa039fd81e6f2e2436b0f21d2ee75b5</code> that represent
/// s <code>UserProposalProposalStatusRecord</code> <p>Description: </p>
/// </summary>
// Name: UserProposalProposalStatusRecord
public partial struct RC_7aa039fd81e6f2e2436b0f21d2ee75b5 : ITypedRecord<RC_7aa039fd81e6f2e2436b0f21d2ee75b5> {
internal static readonly GlobalObjectKey IdUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NRPQzoKKE6jx2aUQjxfOeQ");
internal static readonly GlobalObjectKey IdProposal = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*9MStkYpvUQ_KzEvHGNLqNQ");
internal static readonly GlobalObjectKey IdProposalStatus = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*o_cnVgbsYD4oY+5rTdgWog");

public ENUserEntityRecord ssENUser;

public EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord ssENProposal;

public EN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord ssENProposalStatus;


public BitArray OptimizedAttributes;

public RC_7aa039fd81e6f2e2436b0f21d2ee75b5() {
OptimizedAttributes = null;
ssENUser = new ENUserEntityRecord();
ssENProposal = new EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord();
ssENProposalStatus = new EN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(18,false);
    all[2] = new BitArray(5,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUser.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENProposal.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENProposalStatus.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    }else{
    ssENUser.OptimizedAttributes = value[0];
    ssENProposal.OptimizedAttributes = value[1];
    ssENProposalStatus.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = ssENUser.OptimizedAttributes;
    all[1] = ssENProposal.OptimizedAttributes;
    all[2] = ssENProposalStatus.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENUser.Read( r, ref index);
ssENProposal.Read( r, ref index);
ssENProposalStatus.Read( r, ref index);
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
public void ReadIM(RC_7aa039fd81e6f2e2436b0f21d2ee75b5 r) {
this = r;
}


public static bool operator == (RC_7aa039fd81e6f2e2436b0f21d2ee75b5 a, RC_7aa039fd81e6f2e2436b0f21d2ee75b5 b) {
if (a.ssENUser != b.ssENUser) return false;
if (a.ssENProposal != b.ssENProposal) return false;
if (a.ssENProposalStatus != b.ssENProposalStatus) return false;
return true;
}

public static bool operator != (RC_7aa039fd81e6f2e2436b0f21d2ee75b5 a, RC_7aa039fd81e6f2e2436b0f21d2ee75b5 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_7aa039fd81e6f2e2436b0f21d2ee75b5)) return false;
return (this == (RC_7aa039fd81e6f2e2436b0f21d2ee75b5)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUser.GetHashCode()
 ^ ssENProposal.GetHashCode()
 ^ ssENProposalStatus.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENUser.RecursiveReset();
ssENProposal.RecursiveReset();
ssENProposalStatus.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUser.InternalRecursiveSave();
ssENProposal.InternalRecursiveSave();
ssENProposalStatus.InternalRecursiveSave();
}


public RC_7aa039fd81e6f2e2436b0f21d2ee75b5 Duplicate() {
RC_7aa039fd81e6f2e2436b0f21d2ee75b5 t;
t.ssENUser = (ENUserEntityRecord)this.ssENUser.Duplicate();
t.ssENProposal = (EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord)this.ssENProposal.Duplicate();
t.ssENProposalStatus = (EN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord)this.ssENProposalStatus.Duplicate();
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
if (head == "user") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".User")) variable.Value = ssENUser; else variable.Optimized = true;
variable.SetFieldName("user");
} else if (head == "proposal") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Proposal")) variable.Value = ssENProposal; else variable.Optimized = true;
variable.SetFieldName("proposal");
} else if (head == "proposalstatus") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProposalStatus")) variable.Value = ssENProposalStatus; else variable.Optimized = true;
variable.SetFieldName("proposalstatus");
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
if (key == IdUser) {
return ssENUser;
}
if (key == IdProposal) {
return ssENProposal;
}
if (key == IdProposalStatus) {
return ssENProposalStatus;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUser.Key.AsGuid) {
return ssENUser;
}
if (attributeKey == IdProposal.Key.AsGuid) {
return ssENProposal;
}
if (attributeKey == IdProposalStatus.Key.AsGuid) {
return ssENProposalStatus;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENUser.FillFromOther((IRecord) other.AttributeGet(IdUser));
ssENProposal.FillFromOther((IRecord) other.AttributeGet(IdProposal));
ssENProposalStatus.FillFromOther((IRecord) other.AttributeGet(IdProposalStatus));
}
} // RC_7aa039fd81e6f2e2436b0f21d2ee75b5
/// <summary>
/// RecordList type <code>UserProposalProposalStatusRecordList</code> that represents a record list of
///  <code>User, Proposal, ProposalStatus</code>
/// </summary>
public partial class RL_5081795d8987d4174622e43cdf1b4f92 : GenericRecordList<RC_7aa039fd81e6f2e2436b0f21d2ee75b5>, IEnumerable, IEnumerator {

protected override RC_7aa039fd81e6f2e2436b0f21d2ee75b5 GetElementDefaultValue() {
return new RC_7aa039fd81e6f2e2436b0f21d2ee75b5();
}

public T[] ToArray<T>(Func<RC_7aa039fd81e6f2e2436b0f21d2ee75b5, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_5081795d8987d4174622e43cdf1b4f92 recordList, Func<RC_7aa039fd81e6f2e2436b0f21d2ee75b5, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_5081795d8987d4174622e43cdf1b4f92(RC_7aa039fd81e6f2e2436b0f21d2ee75b5[] array) {
  RL_5081795d8987d4174622e43cdf1b4f92 result = new RL_5081795d8987d4174622e43cdf1b4f92();
result.InnerFromArray(array);
    return result;
}

public static RL_5081795d8987d4174622e43cdf1b4f92 ToList<T>(T[] array, Func <T, RC_7aa039fd81e6f2e2436b0f21d2ee75b5> converter) {
  RL_5081795d8987d4174622e43cdf1b4f92 result = new RL_5081795d8987d4174622e43cdf1b4f92();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_5081795d8987d4174622e43cdf1b4f92 FromRestList<T>(RestList<T> restList, Func <T, RC_7aa039fd81e6f2e2436b0f21d2ee75b5> converter) {
  RL_5081795d8987d4174622e43cdf1b4f92 result = new RL_5081795d8987d4174622e43cdf1b4f92();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_5081795d8987d4174622e43cdf1b4f92() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = new BitArray(5,false);
def[1] = new BitArray(18,false);
def[2] = new BitArray(5,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_7aa039fd81e6f2e2436b0f21d2ee75b5> NewList() {
return new RL_5081795d8987d4174622e43cdf1b4f92();
}


} // RL_5081795d8987d4174622e43cdf1b4f92
}

