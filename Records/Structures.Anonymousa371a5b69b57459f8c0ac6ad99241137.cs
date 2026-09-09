namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (tqVxo1ebn0WMCsatmSQRNw)
///  <code>RC_781b0cc57cc94effbff3496f8da9c758</code> that represent
/// s <code>ProposalCommentProposalCommentFileProposalLineRecord</code> <p>Description: </p>
/// </summary>
// Name: ProposalCommentProposalCommentFileProposalLineRecord
public partial struct RC_781b0cc57cc94effbff3496f8da9c758 : ITypedRecord<RC_781b0cc57cc94effbff3496f8da9c758> {
internal static readonly GlobalObjectKey IdProposalComment = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*zQFRzf8x3NgJrsrKbXcASg");
internal static readonly GlobalObjectKey IdProposalCommentFile = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*t4LEHxFpGwWhd7XvZF7daQ");
internal static readonly GlobalObjectKey IdProposalLine = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Ejn_ywl2+KAwstNJSNHAGQ");

public EN_c75b4bd59e1200fee3175175a6054340EntityRecord ssENProposalComment;

public EN_7db82b55fc996c1dcfda575a9310d307EntityRecord ssENProposalCommentFile;

public EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord ssENProposalLine;


public BitArray OptimizedAttributes;

public RC_781b0cc57cc94effbff3496f8da9c758() {
OptimizedAttributes = null;
ssENProposalComment = new EN_c75b4bd59e1200fee3175175a6054340EntityRecord();
ssENProposalCommentFile = new EN_7db82b55fc996c1dcfda575a9310d307EntityRecord();
ssENProposalLine = new EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = new BitArray(8,false);
    all[1] = new BitArray(4,false);
    all[2] = new BitArray(28,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENProposalComment.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENProposalCommentFile.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENProposalLine.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    }else{
    ssENProposalComment.OptimizedAttributes = value[0];
    ssENProposalCommentFile.OptimizedAttributes = value[1];
    ssENProposalLine.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = ssENProposalComment.OptimizedAttributes;
    all[1] = ssENProposalCommentFile.OptimizedAttributes;
    all[2] = ssENProposalLine.OptimizedAttributes;
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
ssENProposalCommentFile.Read( r, ref index);
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
public void ReadIM(RC_781b0cc57cc94effbff3496f8da9c758 r) {
this = r;
}


public static bool operator == (RC_781b0cc57cc94effbff3496f8da9c758 a, RC_781b0cc57cc94effbff3496f8da9c758 b) {
if (a.ssENProposalComment != b.ssENProposalComment) return false;
if (a.ssENProposalCommentFile != b.ssENProposalCommentFile) return false;
if (a.ssENProposalLine != b.ssENProposalLine) return false;
return true;
}

public static bool operator != (RC_781b0cc57cc94effbff3496f8da9c758 a, RC_781b0cc57cc94effbff3496f8da9c758 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_781b0cc57cc94effbff3496f8da9c758)) return false;
return (this == (RC_781b0cc57cc94effbff3496f8da9c758)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENProposalComment.GetHashCode()
 ^ ssENProposalCommentFile.GetHashCode()
 ^ ssENProposalLine.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENProposalComment.RecursiveReset();
ssENProposalCommentFile.RecursiveReset();
ssENProposalLine.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENProposalComment.InternalRecursiveSave();
ssENProposalCommentFile.InternalRecursiveSave();
ssENProposalLine.InternalRecursiveSave();
}


public RC_781b0cc57cc94effbff3496f8da9c758 Duplicate() {
RC_781b0cc57cc94effbff3496f8da9c758 t;
t.ssENProposalComment = (EN_c75b4bd59e1200fee3175175a6054340EntityRecord)this.ssENProposalComment.Duplicate();
t.ssENProposalCommentFile = (EN_7db82b55fc996c1dcfda575a9310d307EntityRecord)this.ssENProposalCommentFile.Duplicate();
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
if (head == "proposalcomment") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProposalComment")) variable.Value = ssENProposalComment; else variable.Optimized = true;
variable.SetFieldName("proposalcomment");
} else if (head == "proposalcommentfile") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProposalCommentFile")) variable.Value = ssENProposalCommentFile; else variable.Optimized = true;
variable.SetFieldName("proposalcommentfile");
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
if (key == IdProposalComment) {
return ssENProposalComment;
}
if (key == IdProposalCommentFile) {
return ssENProposalCommentFile;
}
if (key == IdProposalLine) {
return ssENProposalLine;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdProposalComment.Key.AsGuid) {
return ssENProposalComment;
}
if (attributeKey == IdProposalCommentFile.Key.AsGuid) {
return ssENProposalCommentFile;
}
if (attributeKey == IdProposalLine.Key.AsGuid) {
return ssENProposalLine;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENProposalComment.FillFromOther((IRecord) other.AttributeGet(IdProposalComment));
ssENProposalCommentFile.FillFromOther((IRecord) other.AttributeGet(IdProposalCommentFile));
ssENProposalLine.FillFromOther((IRecord) other.AttributeGet(IdProposalLine));
}
} // RC_781b0cc57cc94effbff3496f8da9c758
/// <summary>
/// RecordList type <code>ProposalCommentProposalCommentFileProposalLineRecordList</code> that
///  represents a record list of <code>ProposalComment, ProposalCommentFile, ProposalLine</code>
/// </summary>
public partial class RL_64d6c39a28702aee27a7d75c307bc2c1 : GenericRecordList<RC_781b0cc57cc94effbff3496f8da9c758>, IEnumerable, IEnumerator {

protected override RC_781b0cc57cc94effbff3496f8da9c758 GetElementDefaultValue() {
return new RC_781b0cc57cc94effbff3496f8da9c758();
}

public T[] ToArray<T>(Func<RC_781b0cc57cc94effbff3496f8da9c758, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_64d6c39a28702aee27a7d75c307bc2c1 recordList, Func<RC_781b0cc57cc94effbff3496f8da9c758, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_64d6c39a28702aee27a7d75c307bc2c1(RC_781b0cc57cc94effbff3496f8da9c758[] array) {
  RL_64d6c39a28702aee27a7d75c307bc2c1 result = new RL_64d6c39a28702aee27a7d75c307bc2c1();
result.InnerFromArray(array);
    return result;
}

public static RL_64d6c39a28702aee27a7d75c307bc2c1 ToList<T>(T[] array, Func <T, RC_781b0cc57cc94effbff3496f8da9c758> converter) {
  RL_64d6c39a28702aee27a7d75c307bc2c1 result = new RL_64d6c39a28702aee27a7d75c307bc2c1();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_64d6c39a28702aee27a7d75c307bc2c1 FromRestList<T>(RestList<T> restList, Func <T, RC_781b0cc57cc94effbff3496f8da9c758> converter) {
  RL_64d6c39a28702aee27a7d75c307bc2c1 result = new RL_64d6c39a28702aee27a7d75c307bc2c1();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_64d6c39a28702aee27a7d75c307bc2c1() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = new BitArray(8,false);
def[1] = new BitArray(4,false);
def[2] = new BitArray(28,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_781b0cc57cc94effbff3496f8da9c758> NewList() {
return new RL_64d6c39a28702aee27a7d75c307bc2c1();
}


} // RL_64d6c39a28702aee27a7d75c307bc2c1
}

