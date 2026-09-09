namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (OUsO76TH80qArNargnhSMQ)
///  <code>RC_b34001d496bee16bcec019df0c313eb6</code> that represent
/// s <code>User_PaidUser_UnpaidProposalCommentProposalLineIsSelectedRecord</code> <p>Description: </p>
/// </summary>
// Name: User_PaidUser_UnpaidProposalCommentProposalLineIsSelectedRecord
public partial struct RC_b34001d496bee16bcec019df0c313eb6 : ITypedRecord<RC_b34001d496bee16bcec019df0c313eb6> {
internal static readonly GlobalObjectKey IdUser_Paid = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*OHVMzo_+zCZZ64dKM5pW9g");
internal static readonly GlobalObjectKey IdUser_Unpaid = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*moZZmGHq9wufprxEry8OFw");
internal static readonly GlobalObjectKey IdProposalComment = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*zQFRzf8x3NgJrsrKbXcASg");
internal static readonly GlobalObjectKey IdProposalLine = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Ejn_ywl2+KAwstNJSNHAGQ");
internal static readonly GlobalObjectKey IdIsSelected = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*osqdCCbTPm0O_HzjZIVgPA");

public ENUserEntityRecord ssENUser_Paid;

public ENUserEntityRecord ssENUser_Unpaid;

public EN_c75b4bd59e1200fee3175175a6054340EntityRecord ssENProposalComment;

public EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord ssENProposalLine;

public bool ssIsSelected;


public BitArray OptimizedAttributes;

public RC_b34001d496bee16bcec019df0c313eb6() {
OptimizedAttributes = null;
ssENUser_Paid = new ENUserEntityRecord();
ssENUser_Unpaid = new ENUserEntityRecord();
ssENProposalComment = new EN_c75b4bd59e1200fee3175175a6054340EntityRecord();
ssENProposalLine = new EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord();
ssIsSelected = false;
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[4];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(5,false);
    all[2] = new BitArray(8,false);
    all[3] = new BitArray(28,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUser_Paid.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENUser_Unpaid.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENProposalComment.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENProposalLine.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    }else{
    ssENUser_Paid.OptimizedAttributes = value[0];
    ssENUser_Unpaid.OptimizedAttributes = value[1];
    ssENProposalComment.OptimizedAttributes = value[2];
    ssENProposalLine.OptimizedAttributes = value[3];
    }
}
get{
    BitArray[] all = new BitArray[4];
    all[0] = ssENUser_Paid.OptimizedAttributes;
    all[1] = ssENUser_Unpaid.OptimizedAttributes;
    all[2] = ssENProposalComment.OptimizedAttributes;
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
ssENUser_Paid.Read( r, ref index);
ssENUser_Unpaid.Read( r, ref index);
ssENProposalComment.Read( r, ref index);
ssENProposalLine.Read( r, ref index);
ssIsSelected = r.ReadBoolean(index++, "User_PaidUser_UnpaidProposalCommentProposalLineIsSelectedRecord.IsSelected", false);
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
public void ReadIM(RC_b34001d496bee16bcec019df0c313eb6 r) {
this = r;
}


public static bool operator == (RC_b34001d496bee16bcec019df0c313eb6 a, RC_b34001d496bee16bcec019df0c313eb6 b) {
if (a.ssENUser_Paid != b.ssENUser_Paid) return false;
if (a.ssENUser_Unpaid != b.ssENUser_Unpaid) return false;
if (a.ssENProposalComment != b.ssENProposalComment) return false;
if (a.ssENProposalLine != b.ssENProposalLine) return false;
if (a.ssIsSelected != b.ssIsSelected) return false;
return true;
}

public static bool operator != (RC_b34001d496bee16bcec019df0c313eb6 a, RC_b34001d496bee16bcec019df0c313eb6 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_b34001d496bee16bcec019df0c313eb6)) return false;
return (this == (RC_b34001d496bee16bcec019df0c313eb6)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUser_Paid.GetHashCode()
 ^ ssENUser_Unpaid.GetHashCode()
 ^ ssENProposalComment.GetHashCode()
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
ssENProposalComment.RecursiveReset();
ssENProposalLine.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUser_Paid.InternalRecursiveSave();
ssENUser_Unpaid.InternalRecursiveSave();
ssENProposalComment.InternalRecursiveSave();
ssENProposalLine.InternalRecursiveSave();
}


public RC_b34001d496bee16bcec019df0c313eb6 Duplicate() {
RC_b34001d496bee16bcec019df0c313eb6 t;
t.ssENUser_Paid = (ENUserEntityRecord)this.ssENUser_Paid.Duplicate();
t.ssENUser_Unpaid = (ENUserEntityRecord)this.ssENUser_Unpaid.Duplicate();
t.ssENProposalComment = (EN_c75b4bd59e1200fee3175175a6054340EntityRecord)this.ssENProposalComment.Duplicate();
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
} else if (head == "proposalcomment") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProposalComment")) variable.Value = ssENProposalComment; else variable.Optimized = true;
variable.SetFieldName("proposalcomment");
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
if (key == IdProposalComment) {
return ssENProposalComment;
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
if (attributeKey == IdProposalComment.Key.AsGuid) {
return ssENProposalComment;
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
ssENProposalComment.FillFromOther((IRecord) other.AttributeGet(IdProposalComment));
ssENProposalLine.FillFromOther((IRecord) other.AttributeGet(IdProposalLine));
ssIsSelected = (bool) other.AttributeGet(IdIsSelected);
}
} // RC_b34001d496bee16bcec019df0c313eb6
/// <summary>
/// RecordList type <code>User_PaidUser_UnpaidProposalCommentProposalLineIsSelectedRecordList</code>
///  that represents a record list of <code>User, User, ProposalComment, ProposalLine, Boolean</code>
/// </summary>
public partial class RL_db80b9f839f0b93373297ec2051fc003 : GenericRecordList<RC_b34001d496bee16bcec019df0c313eb6>, IEnumerable, IEnumerator {

protected override RC_b34001d496bee16bcec019df0c313eb6 GetElementDefaultValue() {
return new RC_b34001d496bee16bcec019df0c313eb6();
}

public T[] ToArray<T>(Func<RC_b34001d496bee16bcec019df0c313eb6, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_db80b9f839f0b93373297ec2051fc003 recordList, Func<RC_b34001d496bee16bcec019df0c313eb6, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_db80b9f839f0b93373297ec2051fc003(RC_b34001d496bee16bcec019df0c313eb6[] array) {
  RL_db80b9f839f0b93373297ec2051fc003 result = new RL_db80b9f839f0b93373297ec2051fc003();
result.InnerFromArray(array);
    return result;
}

public static RL_db80b9f839f0b93373297ec2051fc003 ToList<T>(T[] array, Func <T, RC_b34001d496bee16bcec019df0c313eb6> converter) {
  RL_db80b9f839f0b93373297ec2051fc003 result = new RL_db80b9f839f0b93373297ec2051fc003();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_db80b9f839f0b93373297ec2051fc003 FromRestList<T>(RestList<T> restList, Func <T, RC_b34001d496bee16bcec019df0c313eb6> converter) {
  RL_db80b9f839f0b93373297ec2051fc003 result = new RL_db80b9f839f0b93373297ec2051fc003();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_db80b9f839f0b93373297ec2051fc003() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[4];
def[0] = new BitArray(5,false);
def[1] = new BitArray(5,false);
def[2] = new BitArray(8,false);
def[3] = new BitArray(28,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_b34001d496bee16bcec019df0c313eb6> NewList() {
return new RL_db80b9f839f0b93373297ec2051fc003();
}


} // RL_db80b9f839f0b93373297ec2051fc003
}

