namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (ElVUCOL0OEuIc2j4QthI3A)
///  <code>RC_1d9708453e759844315b6b93812afa56</code> that represent
/// s
///  <code>User_PaidUser_UnpaidProposalApprovalLevelProposalLineApprovalLevelProposalApprovalProposalLin
/// eIsSelectedRecord</code> <p>Description: </p>
/// </summary>
// Name: User_PaidUser_UnpaidProposalApprovalLevelProposalLineApprovalLevelProposalApprovalProposalLineIsSelectedRecord
public partial struct RC_1d9708453e759844315b6b93812afa56 : ITypedRecord<RC_1d9708453e759844315b6b93812afa56> {
internal static readonly GlobalObjectKey IdUser_Paid = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*OHVMzo_+zCZZ64dKM5pW9g");
internal static readonly GlobalObjectKey IdUser_Unpaid = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*moZZmGHq9wufprxEry8OFw");
internal static readonly GlobalObjectKey IdProposalApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*eJqSVc+Lx3kjVPxJFgrMDA");
internal static readonly GlobalObjectKey IdProposalLineApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*XbRfhyNBH6nOg4MfD1VNjg");
internal static readonly GlobalObjectKey IdProposalApproval = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*1sFbHhDQH3aGXjoHdPHIGQ");
internal static readonly GlobalObjectKey IdProposalLine = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Ejn_ywl2+KAwstNJSNHAGQ");
internal static readonly GlobalObjectKey IdIsSelected = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*osqdCCbTPm0O_HzjZIVgPA");

public ENUserEntityRecord ssENUser_Paid;

public ENUserEntityRecord ssENUser_Unpaid;

public EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord ssENProposalApprovalLevel;

public EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord ssENProposalLineApprovalLevel;

public EN_5464a383ceb6bec564e8dfa03f011357EntityRecord ssENProposalApproval;

public EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord ssENProposalLine;

public bool ssIsSelected;


public BitArray OptimizedAttributes;

public RC_1d9708453e759844315b6b93812afa56() {
OptimizedAttributes = null;
ssENUser_Paid = new ENUserEntityRecord();
ssENUser_Unpaid = new ENUserEntityRecord();
ssENProposalApprovalLevel = new EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord();
ssENProposalLineApprovalLevel = new EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord();
ssENProposalApproval = new EN_5464a383ceb6bec564e8dfa03f011357EntityRecord();
ssENProposalLine = new EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord();
ssIsSelected = false;
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[6];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(5,false);
    all[2] = new BitArray(7,false);
    all[3] = new BitArray(9,false);
    all[4] = new BitArray(8,false);
    all[5] = new BitArray(28,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUser_Paid.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENUser_Unpaid.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENProposalApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENProposalLineApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENProposalApproval.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    ssENProposalLine.OptimizedAttributes = GetDefaultOptimizedValues()[5];
    }else{
    ssENUser_Paid.OptimizedAttributes = value[0];
    ssENUser_Unpaid.OptimizedAttributes = value[1];
    ssENProposalApprovalLevel.OptimizedAttributes = value[2];
    ssENProposalLineApprovalLevel.OptimizedAttributes = value[3];
    ssENProposalApproval.OptimizedAttributes = value[4];
    ssENProposalLine.OptimizedAttributes = value[5];
    }
}
get{
    BitArray[] all = new BitArray[6];
    all[0] = ssENUser_Paid.OptimizedAttributes;
    all[1] = ssENUser_Unpaid.OptimizedAttributes;
    all[2] = ssENProposalApprovalLevel.OptimizedAttributes;
    all[3] = ssENProposalLineApprovalLevel.OptimizedAttributes;
    all[4] = ssENProposalApproval.OptimizedAttributes;
    all[5] = ssENProposalLine.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENUser_Paid.Read( r, ref index);
ssENUser_Unpaid.Read( r, ref index);
ssENProposalApprovalLevel.Read( r, ref index);
ssENProposalLineApprovalLevel.Read( r, ref index);
ssENProposalApproval.Read( r, ref index);
ssENProposalLine.Read( r, ref index);
ssIsSelected = r.ReadBoolean(index++, "User_PaidUser_UnpaidProposalApprovalLevelProposalLineApprovalLevelProposalApprovalProposalLineIsSelectedRecord.IsSelected", false);
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
public void ReadIM(RC_1d9708453e759844315b6b93812afa56 r) {
this = r;
}


public static bool operator == (RC_1d9708453e759844315b6b93812afa56 a, RC_1d9708453e759844315b6b93812afa56 b) {
if (a.ssENUser_Paid != b.ssENUser_Paid) return false;
if (a.ssENUser_Unpaid != b.ssENUser_Unpaid) return false;
if (a.ssENProposalApprovalLevel != b.ssENProposalApprovalLevel) return false;
if (a.ssENProposalLineApprovalLevel != b.ssENProposalLineApprovalLevel) return false;
if (a.ssENProposalApproval != b.ssENProposalApproval) return false;
if (a.ssENProposalLine != b.ssENProposalLine) return false;
if (a.ssIsSelected != b.ssIsSelected) return false;
return true;
}

public static bool operator != (RC_1d9708453e759844315b6b93812afa56 a, RC_1d9708453e759844315b6b93812afa56 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_1d9708453e759844315b6b93812afa56)) return false;
return (this == (RC_1d9708453e759844315b6b93812afa56)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUser_Paid.GetHashCode()
 ^ ssENUser_Unpaid.GetHashCode()
 ^ ssENProposalApprovalLevel.GetHashCode()
 ^ ssENProposalLineApprovalLevel.GetHashCode()
 ^ ssENProposalApproval.GetHashCode()
 ^ ssENProposalLine.GetHashCode()
 ^ ssIsSelected.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENUser_Paid.RecursiveReset();
ssENUser_Unpaid.RecursiveReset();
ssENProposalApprovalLevel.RecursiveReset();
ssENProposalLineApprovalLevel.RecursiveReset();
ssENProposalApproval.RecursiveReset();
ssENProposalLine.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUser_Paid.InternalRecursiveSave();
ssENUser_Unpaid.InternalRecursiveSave();
ssENProposalApprovalLevel.InternalRecursiveSave();
ssENProposalLineApprovalLevel.InternalRecursiveSave();
ssENProposalApproval.InternalRecursiveSave();
ssENProposalLine.InternalRecursiveSave();
}


public RC_1d9708453e759844315b6b93812afa56 Duplicate() {
RC_1d9708453e759844315b6b93812afa56 t;
t.ssENUser_Paid = (ENUserEntityRecord)this.ssENUser_Paid.Duplicate();
t.ssENUser_Unpaid = (ENUserEntityRecord)this.ssENUser_Unpaid.Duplicate();
t.ssENProposalApprovalLevel = (EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord)this.ssENProposalApprovalLevel.Duplicate();
t.ssENProposalLineApprovalLevel = (EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord)this.ssENProposalLineApprovalLevel.Duplicate();
t.ssENProposalApproval = (EN_5464a383ceb6bec564e8dfa03f011357EntityRecord)this.ssENProposalApproval.Duplicate();
t.ssENProposalLine = (EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord)this.ssENProposalLine.Duplicate();
t.ssIsSelected = this.ssIsSelected;
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
if (head == "user_paid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".User_Paid")) variable.Value = ssENUser_Paid; else variable.Optimized = true;
variable.SetFieldName("user_paid");
} else if (head == "user_unpaid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".User_Unpaid")) variable.Value = ssENUser_Unpaid; else variable.Optimized = true;
variable.SetFieldName("user_unpaid");
} else if (head == "proposalapprovallevel") {
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
} else if (head == "isselected") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsSelected")) variable.Value = ssIsSelected; else variable.Optimized = true;
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
if (key == IdUser_Paid) {
return ssENUser_Paid;
}
if (key == IdUser_Unpaid) {
return ssENUser_Unpaid;
}
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
if (key == IdIsSelected) {
return ssIsSelected;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUser_Paid.Key.AsGuid) {
return ssENUser_Paid;
}
if (attributeKey == IdUser_Unpaid.Key.AsGuid) {
return ssENUser_Unpaid;
}
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
if (attributeKey == IdIsSelected.Key.AsGuid) {
return ssIsSelected;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENUser_Paid.FillFromOther((IRecord) other.AttributeGet(IdUser_Paid));
ssENUser_Unpaid.FillFromOther((IRecord) other.AttributeGet(IdUser_Unpaid));
ssENProposalApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdProposalApprovalLevel));
ssENProposalLineApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdProposalLineApprovalLevel));
ssENProposalApproval.FillFromOther((IRecord) other.AttributeGet(IdProposalApproval));
ssENProposalLine.FillFromOther((IRecord) other.AttributeGet(IdProposalLine));
ssIsSelected = (bool) other.AttributeGet(IdIsSelected);
}
} // RC_1d9708453e759844315b6b93812afa56
/// <summary>
/// RecordList type
///  <code>User_PaidUser_UnpaidProposalApprovalLevelProposalLineApprovalLevelProposalApprovalProposalLin
/// eIsSelectedRecordList</code> that represents a record list of <code>User, User,
///  ProposalApprovalLevel, ProposalLineApprovalLevel, ProposalApproval, ProposalLine, Boolean</code>
/// </summary>
public partial class RL_fdf11fa7a74406ff2a80f555d1ce34a5 : GenericRecordList<RC_1d9708453e759844315b6b93812afa56>, IEnumerable, IEnumerator {

protected override RC_1d9708453e759844315b6b93812afa56 GetElementDefaultValue() {
return new RC_1d9708453e759844315b6b93812afa56();
}

public T[] ToArray<T>(Func<RC_1d9708453e759844315b6b93812afa56, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_fdf11fa7a74406ff2a80f555d1ce34a5 recordList, Func<RC_1d9708453e759844315b6b93812afa56, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_fdf11fa7a74406ff2a80f555d1ce34a5(RC_1d9708453e759844315b6b93812afa56[] array) {
  RL_fdf11fa7a74406ff2a80f555d1ce34a5 result = new RL_fdf11fa7a74406ff2a80f555d1ce34a5();
result.InnerFromArray(array);
    return result;
}

public static RL_fdf11fa7a74406ff2a80f555d1ce34a5 ToList<T>(T[] array, Func <T, RC_1d9708453e759844315b6b93812afa56> converter) {
  RL_fdf11fa7a74406ff2a80f555d1ce34a5 result = new RL_fdf11fa7a74406ff2a80f555d1ce34a5();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_fdf11fa7a74406ff2a80f555d1ce34a5 FromRestList<T>(RestList<T> restList, Func <T, RC_1d9708453e759844315b6b93812afa56> converter) {
  RL_fdf11fa7a74406ff2a80f555d1ce34a5 result = new RL_fdf11fa7a74406ff2a80f555d1ce34a5();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_fdf11fa7a74406ff2a80f555d1ce34a5() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[6];
def[0] = new BitArray(5,false);
def[1] = new BitArray(5,false);
def[2] = new BitArray(7,false);
def[3] = new BitArray(9,false);
def[4] = new BitArray(8,false);
def[5] = new BitArray(28,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_1d9708453e759844315b6b93812afa56> NewList() {
return new RL_fdf11fa7a74406ff2a80f555d1ce34a5();
}


} // RL_fdf11fa7a74406ff2a80f555d1ce34a5
}

