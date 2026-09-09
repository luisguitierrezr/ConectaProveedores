namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (2BqXnGOcKU28DvYl4qFZbw)
///  <code>RC_cd5101cd31ffd8dc09aecaca6d77004a</code> that represents <code>ProposalCommentRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: ProposalCommentRecord
public partial struct RC_cd5101cd31ffd8dc09aecaca6d77004a : ITypedRecord<RC_cd5101cd31ffd8dc09aecaca6d77004a> {
internal static readonly GlobalObjectKey IdProposalComment = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*zQFRzf8x3NgJrsrKbXcASg");

public EN_c75b4bd59e1200fee3175175a6054340EntityRecord ssENProposalComment;


public static implicit operator EN_c75b4bd59e1200fee3175175a6054340EntityRecord( RC_cd5101cd31ffd8dc09aecaca6d77004a r) {
return r.ssENProposalComment;
}

public static implicit operator RC_cd5101cd31ffd8dc09aecaca6d77004a (EN_c75b4bd59e1200fee3175175a6054340EntityRecord r) {
RC_cd5101cd31ffd8dc09aecaca6d77004a res = new RC_cd5101cd31ffd8dc09aecaca6d77004a ();
res.ssENProposalComment = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENProposalComment.ChangedAttributes = value;
}
get {
    return ssENProposalComment.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_cd5101cd31ffd8dc09aecaca6d77004a() {
OptimizedAttributes = null;
ssENProposalComment = new EN_c75b4bd59e1200fee3175175a6054340EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(8,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENProposalComment.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENProposalComment.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENProposalComment.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENProposalComment.Read( r, ref index);
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
public void ReadIM(RC_cd5101cd31ffd8dc09aecaca6d77004a r) {
this = r;
}


public static bool operator == (RC_cd5101cd31ffd8dc09aecaca6d77004a a, RC_cd5101cd31ffd8dc09aecaca6d77004a b) {
if (a.ssENProposalComment != b.ssENProposalComment) return false;
return true;
}

public static bool operator != (RC_cd5101cd31ffd8dc09aecaca6d77004a a, RC_cd5101cd31ffd8dc09aecaca6d77004a b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_cd5101cd31ffd8dc09aecaca6d77004a)) return false;
return (this == (RC_cd5101cd31ffd8dc09aecaca6d77004a)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENProposalComment.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENProposalComment.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENProposalComment.InternalRecursiveSave();
}


public RC_cd5101cd31ffd8dc09aecaca6d77004a Duplicate() {
RC_cd5101cd31ffd8dc09aecaca6d77004a t;
t.ssENProposalComment = (EN_c75b4bd59e1200fee3175175a6054340EntityRecord)this.ssENProposalComment.Duplicate();
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
if (head == "proposalcomment") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProposalComment")) variable.Value = ssENProposalComment; else variable.Optimized = true;
variable.SetFieldName("proposalcomment");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENProposalComment.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENProposalComment.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdProposalComment) {
return ssENProposalComment;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdProposalComment.Key.AsGuid) {
return ssENProposalComment;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENProposalComment.FillFromOther((IRecord) other.AttributeGet(IdProposalComment));
}
} // RC_cd5101cd31ffd8dc09aecaca6d77004a
/// <summary>
/// RecordList type <code>ProposalCommentRecordList</code> that represents a record list of
///  <code>ProposalComment</code>
/// </summary>
public partial class RL_6f7a73531f09191ac235a09fbbea38a5 : GenericRecordList<RC_cd5101cd31ffd8dc09aecaca6d77004a>, IEnumerable, IEnumerator {

protected override RC_cd5101cd31ffd8dc09aecaca6d77004a GetElementDefaultValue() {
return new RC_cd5101cd31ffd8dc09aecaca6d77004a();
}

public T[] ToArray<T>(Func<RC_cd5101cd31ffd8dc09aecaca6d77004a, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_6f7a73531f09191ac235a09fbbea38a5 recordList, Func<RC_cd5101cd31ffd8dc09aecaca6d77004a, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_6f7a73531f09191ac235a09fbbea38a5(RC_cd5101cd31ffd8dc09aecaca6d77004a[] array) {
  RL_6f7a73531f09191ac235a09fbbea38a5 result = new RL_6f7a73531f09191ac235a09fbbea38a5();
result.InnerFromArray(array);
    return result;
}

public static RL_6f7a73531f09191ac235a09fbbea38a5 ToList<T>(T[] array, Func <T, RC_cd5101cd31ffd8dc09aecaca6d77004a> converter) {
  RL_6f7a73531f09191ac235a09fbbea38a5 result = new RL_6f7a73531f09191ac235a09fbbea38a5();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_6f7a73531f09191ac235a09fbbea38a5 FromRestList<T>(RestList<T> restList, Func <T, RC_cd5101cd31ffd8dc09aecaca6d77004a> converter) {
  RL_6f7a73531f09191ac235a09fbbea38a5 result = new RL_6f7a73531f09191ac235a09fbbea38a5();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_6f7a73531f09191ac235a09fbbea38a5() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(8,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_cd5101cd31ffd8dc09aecaca6d77004a> NewList() {
return new RL_6f7a73531f09191ac235a09fbbea38a5();
}


} // RL_6f7a73531f09191ac235a09fbbea38a5
}

