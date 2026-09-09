namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (3FGdWfvw5kePT9iApnKByw)
///  <code>RC_a6b7967ad624705fbcd9d81593f9e64b</code> that represent
/// s <code>UserProposalLogsProposalRecord</code> <p>Description: </p>
/// </summary>
// Name: UserProposalLogsProposalRecord
public partial struct RC_a6b7967ad624705fbcd9d81593f9e64b : ITypedRecord<RC_a6b7967ad624705fbcd9d81593f9e64b> {
internal static readonly GlobalObjectKey IdUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NRPQzoKKE6jx2aUQjxfOeQ");
internal static readonly GlobalObjectKey IdProposalLogs = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*25fSQlZTWuzLhGXgl3hJwA");
internal static readonly GlobalObjectKey IdProposal = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*9MStkYpvUQ_KzEvHGNLqNQ");

public ENUserEntityRecord ssENUser;

public EN_013f76cfa3062515b73935963b1697b0EntityRecord ssENProposalLogs;

public EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord ssENProposal;


public BitArray OptimizedAttributes;

public RC_a6b7967ad624705fbcd9d81593f9e64b() {
OptimizedAttributes = null;
ssENUser = new ENUserEntityRecord();
ssENProposalLogs = new EN_013f76cfa3062515b73935963b1697b0EntityRecord();
ssENProposal = new EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(7,false);
    all[2] = new BitArray(18,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUser.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENProposalLogs.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENProposal.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    }else{
    ssENUser.OptimizedAttributes = value[0];
    ssENProposalLogs.OptimizedAttributes = value[1];
    ssENProposal.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = ssENUser.OptimizedAttributes;
    all[1] = ssENProposalLogs.OptimizedAttributes;
    all[2] = ssENProposal.OptimizedAttributes;
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
ssENProposalLogs.Read( r, ref index);
ssENProposal.Read( r, ref index);
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
public void ReadIM(RC_a6b7967ad624705fbcd9d81593f9e64b r) {
this = r;
}


public static bool operator == (RC_a6b7967ad624705fbcd9d81593f9e64b a, RC_a6b7967ad624705fbcd9d81593f9e64b b) {
if (a.ssENUser != b.ssENUser) return false;
if (a.ssENProposalLogs != b.ssENProposalLogs) return false;
if (a.ssENProposal != b.ssENProposal) return false;
return true;
}

public static bool operator != (RC_a6b7967ad624705fbcd9d81593f9e64b a, RC_a6b7967ad624705fbcd9d81593f9e64b b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_a6b7967ad624705fbcd9d81593f9e64b)) return false;
return (this == (RC_a6b7967ad624705fbcd9d81593f9e64b)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUser.GetHashCode()
 ^ ssENProposalLogs.GetHashCode()
 ^ ssENProposal.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENUser.RecursiveReset();
ssENProposalLogs.RecursiveReset();
ssENProposal.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUser.InternalRecursiveSave();
ssENProposalLogs.InternalRecursiveSave();
ssENProposal.InternalRecursiveSave();
}


public RC_a6b7967ad624705fbcd9d81593f9e64b Duplicate() {
RC_a6b7967ad624705fbcd9d81593f9e64b t;
t.ssENUser = (ENUserEntityRecord)this.ssENUser.Duplicate();
t.ssENProposalLogs = (EN_013f76cfa3062515b73935963b1697b0EntityRecord)this.ssENProposalLogs.Duplicate();
t.ssENProposal = (EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord)this.ssENProposal.Duplicate();
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
} else if (head == "proposallogs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProposalLogs")) variable.Value = ssENProposalLogs; else variable.Optimized = true;
variable.SetFieldName("proposallogs");
} else if (head == "proposal") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Proposal")) variable.Value = ssENProposal; else variable.Optimized = true;
variable.SetFieldName("proposal");
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
if (key == IdProposalLogs) {
return ssENProposalLogs;
}
if (key == IdProposal) {
return ssENProposal;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUser.Key.AsGuid) {
return ssENUser;
}
if (attributeKey == IdProposalLogs.Key.AsGuid) {
return ssENProposalLogs;
}
if (attributeKey == IdProposal.Key.AsGuid) {
return ssENProposal;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENUser.FillFromOther((IRecord) other.AttributeGet(IdUser));
ssENProposalLogs.FillFromOther((IRecord) other.AttributeGet(IdProposalLogs));
ssENProposal.FillFromOther((IRecord) other.AttributeGet(IdProposal));
}
} // RC_a6b7967ad624705fbcd9d81593f9e64b
/// <summary>
/// RecordList type <code>UserProposalLogsProposalRecordList</code> that represents a record list of
///  <code>User, ProposalLogs, Proposal</code>
/// </summary>
public partial class RL_3286f6c378c910e4e42e108563fc6bb5 : GenericRecordList<RC_a6b7967ad624705fbcd9d81593f9e64b>, IEnumerable, IEnumerator {

protected override RC_a6b7967ad624705fbcd9d81593f9e64b GetElementDefaultValue() {
return new RC_a6b7967ad624705fbcd9d81593f9e64b();
}

public T[] ToArray<T>(Func<RC_a6b7967ad624705fbcd9d81593f9e64b, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_3286f6c378c910e4e42e108563fc6bb5 recordList, Func<RC_a6b7967ad624705fbcd9d81593f9e64b, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_3286f6c378c910e4e42e108563fc6bb5(RC_a6b7967ad624705fbcd9d81593f9e64b[] array) {
  RL_3286f6c378c910e4e42e108563fc6bb5 result = new RL_3286f6c378c910e4e42e108563fc6bb5();
result.InnerFromArray(array);
    return result;
}

public static RL_3286f6c378c910e4e42e108563fc6bb5 ToList<T>(T[] array, Func <T, RC_a6b7967ad624705fbcd9d81593f9e64b> converter) {
  RL_3286f6c378c910e4e42e108563fc6bb5 result = new RL_3286f6c378c910e4e42e108563fc6bb5();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_3286f6c378c910e4e42e108563fc6bb5 FromRestList<T>(RestList<T> restList, Func <T, RC_a6b7967ad624705fbcd9d81593f9e64b> converter) {
  RL_3286f6c378c910e4e42e108563fc6bb5 result = new RL_3286f6c378c910e4e42e108563fc6bb5();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_3286f6c378c910e4e42e108563fc6bb5() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = new BitArray(5,false);
def[1] = new BitArray(7,false);
def[2] = new BitArray(18,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_a6b7967ad624705fbcd9d81593f9e64b> NewList() {
return new RL_3286f6c378c910e4e42e108563fc6bb5();
}


} // RL_3286f6c378c910e4e42e108563fc6bb5
}

