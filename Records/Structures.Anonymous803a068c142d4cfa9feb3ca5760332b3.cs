namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (jAY6gC0U+kyf6zyldgMysw)
///  <code>RC_be1a2f02e9ce96cb93b1fb40e877c6b4</code> that represent
/// s <code>ProposalApprovalLevelProposalLineApprovalLevelProposalApprovalProposalLineRecord</code>
///  <p>Description: </p>
/// </summary>
// Name: ProposalApprovalLevelProposalLineApprovalLevelProposalApprovalProposalLineRecord
public partial struct RC_be1a2f02e9ce96cb93b1fb40e877c6b4 : ITypedRecord<RC_be1a2f02e9ce96cb93b1fb40e877c6b4> {
internal static readonly GlobalObjectKey IdProposalApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*eJqSVc+Lx3kjVPxJFgrMDA");
internal static readonly GlobalObjectKey IdProposalLineApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*XbRfhyNBH6nOg4MfD1VNjg");
internal static readonly GlobalObjectKey IdProposalApproval = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*1sFbHhDQH3aGXjoHdPHIGQ");
internal static readonly GlobalObjectKey IdProposalLine = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Ejn_ywl2+KAwstNJSNHAGQ");

public EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord ssENProposalApprovalLevel;

public EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord ssENProposalLineApprovalLevel;

public EN_5464a383ceb6bec564e8dfa03f011357EntityRecord ssENProposalApproval;

public EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord ssENProposalLine;


public BitArray OptimizedAttributes;

public RC_be1a2f02e9ce96cb93b1fb40e877c6b4() {
OptimizedAttributes = null;
ssENProposalApprovalLevel = new EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord();
ssENProposalLineApprovalLevel = new EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord();
ssENProposalApproval = new EN_5464a383ceb6bec564e8dfa03f011357EntityRecord();
ssENProposalLine = new EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[4];
    all[0] = new BitArray(7,false);
    all[1] = new BitArray(9,false);
    all[2] = new BitArray(8,false);
    all[3] = new BitArray(28,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENProposalApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENProposalLineApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENProposalApproval.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENProposalLine.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    }else{
    ssENProposalApprovalLevel.OptimizedAttributes = value[0];
    ssENProposalLineApprovalLevel.OptimizedAttributes = value[1];
    ssENProposalApproval.OptimizedAttributes = value[2];
    ssENProposalLine.OptimizedAttributes = value[3];
    }
}
get{
    BitArray[] all = new BitArray[4];
    all[0] = ssENProposalApprovalLevel.OptimizedAttributes;
    all[1] = ssENProposalLineApprovalLevel.OptimizedAttributes;
    all[2] = ssENProposalApproval.OptimizedAttributes;
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
ssENProposalLineApprovalLevel.Read( r, ref index);
ssENProposalApproval.Read( r, ref index);
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
public void ReadIM(RC_be1a2f02e9ce96cb93b1fb40e877c6b4 r) {
this = r;
}


public static bool operator == (RC_be1a2f02e9ce96cb93b1fb40e877c6b4 a, RC_be1a2f02e9ce96cb93b1fb40e877c6b4 b) {
if (a.ssENProposalApprovalLevel != b.ssENProposalApprovalLevel) return false;
if (a.ssENProposalLineApprovalLevel != b.ssENProposalLineApprovalLevel) return false;
if (a.ssENProposalApproval != b.ssENProposalApproval) return false;
if (a.ssENProposalLine != b.ssENProposalLine) return false;
return true;
}

public static bool operator != (RC_be1a2f02e9ce96cb93b1fb40e877c6b4 a, RC_be1a2f02e9ce96cb93b1fb40e877c6b4 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_be1a2f02e9ce96cb93b1fb40e877c6b4)) return false;
return (this == (RC_be1a2f02e9ce96cb93b1fb40e877c6b4)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENProposalApprovalLevel.GetHashCode()
 ^ ssENProposalLineApprovalLevel.GetHashCode()
 ^ ssENProposalApproval.GetHashCode()
 ^ ssENProposalLine.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENProposalApprovalLevel.RecursiveReset();
ssENProposalLineApprovalLevel.RecursiveReset();
ssENProposalApproval.RecursiveReset();
ssENProposalLine.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENProposalApprovalLevel.InternalRecursiveSave();
ssENProposalLineApprovalLevel.InternalRecursiveSave();
ssENProposalApproval.InternalRecursiveSave();
ssENProposalLine.InternalRecursiveSave();
}


public RC_be1a2f02e9ce96cb93b1fb40e877c6b4 Duplicate() {
RC_be1a2f02e9ce96cb93b1fb40e877c6b4 t;
t.ssENProposalApprovalLevel = (EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord)this.ssENProposalApprovalLevel.Duplicate();
t.ssENProposalLineApprovalLevel = (EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord)this.ssENProposalLineApprovalLevel.Duplicate();
t.ssENProposalApproval = (EN_5464a383ceb6bec564e8dfa03f011357EntityRecord)this.ssENProposalApproval.Duplicate();
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
} else if (head == "proposallineapprovallevel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProposalLineApprovalLevel")) variable.Value = ssENProposalLineApprovalLevel; else variable.Optimized = true;
variable.SetFieldName("proposallineapprovallevel");
} else if (head == "proposalapproval") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProposalApproval")) variable.Value = ssENProposalApproval; else variable.Optimized = true;
variable.SetFieldName("proposalapproval");
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
if (key == IdProposalLineApprovalLevel) {
return ssENProposalLineApprovalLevel;
}
if (key == IdProposalApproval) {
return ssENProposalApproval;
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
if (attributeKey == IdProposalLineApprovalLevel.Key.AsGuid) {
return ssENProposalLineApprovalLevel;
}
if (attributeKey == IdProposalApproval.Key.AsGuid) {
return ssENProposalApproval;
}
if (attributeKey == IdProposalLine.Key.AsGuid) {
return ssENProposalLine;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENProposalApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdProposalApprovalLevel));
ssENProposalLineApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdProposalLineApprovalLevel));
ssENProposalApproval.FillFromOther((IRecord) other.AttributeGet(IdProposalApproval));
ssENProposalLine.FillFromOther((IRecord) other.AttributeGet(IdProposalLine));
}
} // RC_be1a2f02e9ce96cb93b1fb40e877c6b4
/// <summary>
/// RecordList type
///  <code>ProposalApprovalLevelProposalLineApprovalLevelProposalApprovalProposalLineRecordList</code
/// > that represents a record list of <code>ProposalApprovalLevel, ProposalLineApprovalLevel,
///  ProposalApproval, ProposalLine</code>
/// </summary>
public partial class RL_5be428ef6f9c9aa8b3df8260aa8d6a98 : GenericRecordList<RC_be1a2f02e9ce96cb93b1fb40e877c6b4>, IEnumerable, IEnumerator {

protected override RC_be1a2f02e9ce96cb93b1fb40e877c6b4 GetElementDefaultValue() {
return new RC_be1a2f02e9ce96cb93b1fb40e877c6b4();
}

public T[] ToArray<T>(Func<RC_be1a2f02e9ce96cb93b1fb40e877c6b4, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_5be428ef6f9c9aa8b3df8260aa8d6a98 recordList, Func<RC_be1a2f02e9ce96cb93b1fb40e877c6b4, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_5be428ef6f9c9aa8b3df8260aa8d6a98(RC_be1a2f02e9ce96cb93b1fb40e877c6b4[] array) {
  RL_5be428ef6f9c9aa8b3df8260aa8d6a98 result = new RL_5be428ef6f9c9aa8b3df8260aa8d6a98();
result.InnerFromArray(array);
    return result;
}

public static RL_5be428ef6f9c9aa8b3df8260aa8d6a98 ToList<T>(T[] array, Func <T, RC_be1a2f02e9ce96cb93b1fb40e877c6b4> converter) {
  RL_5be428ef6f9c9aa8b3df8260aa8d6a98 result = new RL_5be428ef6f9c9aa8b3df8260aa8d6a98();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_5be428ef6f9c9aa8b3df8260aa8d6a98 FromRestList<T>(RestList<T> restList, Func <T, RC_be1a2f02e9ce96cb93b1fb40e877c6b4> converter) {
  RL_5be428ef6f9c9aa8b3df8260aa8d6a98 result = new RL_5be428ef6f9c9aa8b3df8260aa8d6a98();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_5be428ef6f9c9aa8b3df8260aa8d6a98() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[4];
def[0] = new BitArray(7,false);
def[1] = new BitArray(9,false);
def[2] = new BitArray(8,false);
def[3] = new BitArray(28,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_be1a2f02e9ce96cb93b1fb40e877c6b4> NewList() {
return new RL_5be428ef6f9c9aa8b3df8260aa8d6a98();
}


} // RL_5be428ef6f9c9aa8b3df8260aa8d6a98
}

