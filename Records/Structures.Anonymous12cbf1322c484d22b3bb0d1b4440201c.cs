namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (MvHLEkgsIk2zuw0bREAgHA)
///  <code>RC_1fc482b76911051ba177b5ef645edd69</code> that represent
/// s <code>ProposalCommentFileRecord</code> <p>Description: </p>
/// </summary>
// Name: ProposalCommentFileRecord
public partial struct RC_1fc482b76911051ba177b5ef645edd69 : ITypedRecord<RC_1fc482b76911051ba177b5ef645edd69> {
internal static readonly GlobalObjectKey IdProposalCommentFile = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*t4LEHxFpGwWhd7XvZF7daQ");

public EN_7db82b55fc996c1dcfda575a9310d307EntityRecord ssENProposalCommentFile;


public static implicit operator EN_7db82b55fc996c1dcfda575a9310d307EntityRecord( RC_1fc482b76911051ba177b5ef645edd69 r) {
return r.ssENProposalCommentFile;
}

public static implicit operator RC_1fc482b76911051ba177b5ef645edd69 (EN_7db82b55fc996c1dcfda575a9310d307EntityRecord r) {
RC_1fc482b76911051ba177b5ef645edd69 res = new RC_1fc482b76911051ba177b5ef645edd69 ();
res.ssENProposalCommentFile = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENProposalCommentFile.ChangedAttributes = value;
}
get {
    return ssENProposalCommentFile.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_1fc482b76911051ba177b5ef645edd69() {
OptimizedAttributes = null;
ssENProposalCommentFile = new EN_7db82b55fc996c1dcfda575a9310d307EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(4,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENProposalCommentFile.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENProposalCommentFile.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENProposalCommentFile.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENProposalCommentFile.Read( r, ref index);
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
public void ReadIM(RC_1fc482b76911051ba177b5ef645edd69 r) {
this = r;
}


public static bool operator == (RC_1fc482b76911051ba177b5ef645edd69 a, RC_1fc482b76911051ba177b5ef645edd69 b) {
if (a.ssENProposalCommentFile != b.ssENProposalCommentFile) return false;
return true;
}

public static bool operator != (RC_1fc482b76911051ba177b5ef645edd69 a, RC_1fc482b76911051ba177b5ef645edd69 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_1fc482b76911051ba177b5ef645edd69)) return false;
return (this == (RC_1fc482b76911051ba177b5ef645edd69)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENProposalCommentFile.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENProposalCommentFile.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENProposalCommentFile.InternalRecursiveSave();
}


public RC_1fc482b76911051ba177b5ef645edd69 Duplicate() {
RC_1fc482b76911051ba177b5ef645edd69 t;
t.ssENProposalCommentFile = (EN_7db82b55fc996c1dcfda575a9310d307EntityRecord)this.ssENProposalCommentFile.Duplicate();
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
if (head == "proposalcommentfile") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProposalCommentFile")) variable.Value = ssENProposalCommentFile; else variable.Optimized = true;
variable.SetFieldName("proposalcommentfile");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENProposalCommentFile.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENProposalCommentFile.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdProposalCommentFile) {
return ssENProposalCommentFile;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdProposalCommentFile.Key.AsGuid) {
return ssENProposalCommentFile;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENProposalCommentFile.FillFromOther((IRecord) other.AttributeGet(IdProposalCommentFile));
}
} // RC_1fc482b76911051ba177b5ef645edd69
/// <summary>
/// RecordList type <code>ProposalCommentFileRecordList</code> that represents a record list of
///  <code>ProposalCommentFile</code>
/// </summary>
public partial class RL_4d8e6569493646a791571648fa0a998d : GenericRecordList<RC_1fc482b76911051ba177b5ef645edd69>, IEnumerable, IEnumerator {

protected override RC_1fc482b76911051ba177b5ef645edd69 GetElementDefaultValue() {
return new RC_1fc482b76911051ba177b5ef645edd69();
}

public T[] ToArray<T>(Func<RC_1fc482b76911051ba177b5ef645edd69, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_4d8e6569493646a791571648fa0a998d recordList, Func<RC_1fc482b76911051ba177b5ef645edd69, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_4d8e6569493646a791571648fa0a998d(RC_1fc482b76911051ba177b5ef645edd69[] array) {
  RL_4d8e6569493646a791571648fa0a998d result = new RL_4d8e6569493646a791571648fa0a998d();
result.InnerFromArray(array);
    return result;
}

public static RL_4d8e6569493646a791571648fa0a998d ToList<T>(T[] array, Func <T, RC_1fc482b76911051ba177b5ef645edd69> converter) {
  RL_4d8e6569493646a791571648fa0a998d result = new RL_4d8e6569493646a791571648fa0a998d();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_4d8e6569493646a791571648fa0a998d FromRestList<T>(RestList<T> restList, Func <T, RC_1fc482b76911051ba177b5ef645edd69> converter) {
  RL_4d8e6569493646a791571648fa0a998d result = new RL_4d8e6569493646a791571648fa0a998d();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_4d8e6569493646a791571648fa0a998d() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(4,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_1fc482b76911051ba177b5ef645edd69> NewList() {
return new RL_4d8e6569493646a791571648fa0a998d();
}


} // RL_4d8e6569493646a791571648fa0a998d
}

