namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (R1W5aKdDl0Ggxht4_pI9qQ)
///  <code>RC_eb264c698175fb3dfb268b531134340c</code> that represent
/// s <code>UserProposalCommentApplicationRoleRecord</code> <p>Description: </p>
/// </summary>
// Name: UserProposalCommentApplicationRoleRecord
public partial struct RC_eb264c698175fb3dfb268b531134340c : ITypedRecord<RC_eb264c698175fb3dfb268b531134340c> {
internal static readonly GlobalObjectKey IdUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NRPQzoKKE6jx2aUQjxfOeQ");
internal static readonly GlobalObjectKey IdProposalComment = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*zQFRzf8x3NgJrsrKbXcASg");
internal static readonly GlobalObjectKey IdApplicationRole = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Q0fszuVdwmNpC2BezKaalA");

public ENUserEntityRecord ssENUser;

public EN_c75b4bd59e1200fee3175175a6054340EntityRecord ssENProposalComment;

public EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord ssENApplicationRole;


public BitArray OptimizedAttributes;

public RC_eb264c698175fb3dfb268b531134340c() {
OptimizedAttributes = null;
ssENUser = new ENUserEntityRecord();
ssENProposalComment = new EN_c75b4bd59e1200fee3175175a6054340EntityRecord();
ssENApplicationRole = new EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(8,false);
    all[2] = new BitArray(7,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUser.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENProposalComment.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENApplicationRole.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    }else{
    ssENUser.OptimizedAttributes = value[0];
    ssENProposalComment.OptimizedAttributes = value[1];
    ssENApplicationRole.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = ssENUser.OptimizedAttributes;
    all[1] = ssENProposalComment.OptimizedAttributes;
    all[2] = ssENApplicationRole.OptimizedAttributes;
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
ssENProposalComment.Read( r, ref index);
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
public void ReadIM(RC_eb264c698175fb3dfb268b531134340c r) {
this = r;
}


public static bool operator == (RC_eb264c698175fb3dfb268b531134340c a, RC_eb264c698175fb3dfb268b531134340c b) {
if (a.ssENUser != b.ssENUser) return false;
if (a.ssENProposalComment != b.ssENProposalComment) return false;
if (a.ssENApplicationRole != b.ssENApplicationRole) return false;
return true;
}

public static bool operator != (RC_eb264c698175fb3dfb268b531134340c a, RC_eb264c698175fb3dfb268b531134340c b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_eb264c698175fb3dfb268b531134340c)) return false;
return (this == (RC_eb264c698175fb3dfb268b531134340c)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUser.GetHashCode()
 ^ ssENProposalComment.GetHashCode()
 ^ ssENApplicationRole.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENUser.RecursiveReset();
ssENProposalComment.RecursiveReset();
ssENApplicationRole.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUser.InternalRecursiveSave();
ssENProposalComment.InternalRecursiveSave();
ssENApplicationRole.InternalRecursiveSave();
}


public RC_eb264c698175fb3dfb268b531134340c Duplicate() {
RC_eb264c698175fb3dfb268b531134340c t;
t.ssENUser = (ENUserEntityRecord)this.ssENUser.Duplicate();
t.ssENProposalComment = (EN_c75b4bd59e1200fee3175175a6054340EntityRecord)this.ssENProposalComment.Duplicate();
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
if (head == "user") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".User")) variable.Value = ssENUser; else variable.Optimized = true;
variable.SetFieldName("user");
} else if (head == "proposalcomment") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProposalComment")) variable.Value = ssENProposalComment; else variable.Optimized = true;
variable.SetFieldName("proposalcomment");
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
if (key == IdUser) {
return ssENUser;
}
if (key == IdProposalComment) {
return ssENProposalComment;
}
if (key == IdApplicationRole) {
return ssENApplicationRole;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUser.Key.AsGuid) {
return ssENUser;
}
if (attributeKey == IdProposalComment.Key.AsGuid) {
return ssENProposalComment;
}
if (attributeKey == IdApplicationRole.Key.AsGuid) {
return ssENApplicationRole;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENUser.FillFromOther((IRecord) other.AttributeGet(IdUser));
ssENProposalComment.FillFromOther((IRecord) other.AttributeGet(IdProposalComment));
ssENApplicationRole.FillFromOther((IRecord) other.AttributeGet(IdApplicationRole));
}
} // RC_eb264c698175fb3dfb268b531134340c
/// <summary>
/// RecordList type <code>UserProposalCommentApplicationRoleRecordList</code> that represents a record
///  list of <code>User, ProposalComment, ApplicationRole</code>
/// </summary>
public partial class RL_b1eac7b235569839fbbc9e410d978a26 : GenericRecordList<RC_eb264c698175fb3dfb268b531134340c>, IEnumerable, IEnumerator {

protected override RC_eb264c698175fb3dfb268b531134340c GetElementDefaultValue() {
return new RC_eb264c698175fb3dfb268b531134340c();
}

public T[] ToArray<T>(Func<RC_eb264c698175fb3dfb268b531134340c, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_b1eac7b235569839fbbc9e410d978a26 recordList, Func<RC_eb264c698175fb3dfb268b531134340c, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_b1eac7b235569839fbbc9e410d978a26(RC_eb264c698175fb3dfb268b531134340c[] array) {
  RL_b1eac7b235569839fbbc9e410d978a26 result = new RL_b1eac7b235569839fbbc9e410d978a26();
result.InnerFromArray(array);
    return result;
}

public static RL_b1eac7b235569839fbbc9e410d978a26 ToList<T>(T[] array, Func <T, RC_eb264c698175fb3dfb268b531134340c> converter) {
  RL_b1eac7b235569839fbbc9e410d978a26 result = new RL_b1eac7b235569839fbbc9e410d978a26();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_b1eac7b235569839fbbc9e410d978a26 FromRestList<T>(RestList<T> restList, Func <T, RC_eb264c698175fb3dfb268b531134340c> converter) {
  RL_b1eac7b235569839fbbc9e410d978a26 result = new RL_b1eac7b235569839fbbc9e410d978a26();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_b1eac7b235569839fbbc9e410d978a26() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = new BitArray(5,false);
def[1] = new BitArray(8,false);
def[2] = new BitArray(7,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_eb264c698175fb3dfb268b531134340c> NewList() {
return new RL_b1eac7b235569839fbbc9e410d978a26();
}


} // RL_b1eac7b235569839fbbc9e410d978a26
}

