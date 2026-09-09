namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (H4K5c9coUEWaUrcs3GxyyA)
///  <code>RC_1e5bc1d6d010761f865e3a0774f1c819</code> that represent
/// s <code>ProposalApprovalRecord</code> <p>Description: </p>
/// </summary>
// Name: ProposalApprovalRecord
public partial struct RC_1e5bc1d6d010761f865e3a0774f1c819 : ITypedRecord<RC_1e5bc1d6d010761f865e3a0774f1c819> {
internal static readonly GlobalObjectKey IdProposalApproval = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*1sFbHhDQH3aGXjoHdPHIGQ");

public EN_5464a383ceb6bec564e8dfa03f011357EntityRecord ssENProposalApproval;


public static implicit operator EN_5464a383ceb6bec564e8dfa03f011357EntityRecord( RC_1e5bc1d6d010761f865e3a0774f1c819 r) {
return r.ssENProposalApproval;
}

public static implicit operator RC_1e5bc1d6d010761f865e3a0774f1c819 (EN_5464a383ceb6bec564e8dfa03f011357EntityRecord r) {
RC_1e5bc1d6d010761f865e3a0774f1c819 res = new RC_1e5bc1d6d010761f865e3a0774f1c819 ();
res.ssENProposalApproval = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENProposalApproval.ChangedAttributes = value;
}
get {
    return ssENProposalApproval.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_1e5bc1d6d010761f865e3a0774f1c819() {
OptimizedAttributes = null;
ssENProposalApproval = new EN_5464a383ceb6bec564e8dfa03f011357EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(8,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENProposalApproval.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENProposalApproval.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENProposalApproval.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENProposalApproval.Read( r, ref index);
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
public void ReadIM(RC_1e5bc1d6d010761f865e3a0774f1c819 r) {
this = r;
}


public static bool operator == (RC_1e5bc1d6d010761f865e3a0774f1c819 a, RC_1e5bc1d6d010761f865e3a0774f1c819 b) {
if (a.ssENProposalApproval != b.ssENProposalApproval) return false;
return true;
}

public static bool operator != (RC_1e5bc1d6d010761f865e3a0774f1c819 a, RC_1e5bc1d6d010761f865e3a0774f1c819 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_1e5bc1d6d010761f865e3a0774f1c819)) return false;
return (this == (RC_1e5bc1d6d010761f865e3a0774f1c819)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENProposalApproval.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENProposalApproval.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENProposalApproval.InternalRecursiveSave();
}


public RC_1e5bc1d6d010761f865e3a0774f1c819 Duplicate() {
RC_1e5bc1d6d010761f865e3a0774f1c819 t;
t.ssENProposalApproval = (EN_5464a383ceb6bec564e8dfa03f011357EntityRecord)this.ssENProposalApproval.Duplicate();
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
if (head == "proposalapproval") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProposalApproval")) variable.Value = ssENProposalApproval; else variable.Optimized = true;
variable.SetFieldName("proposalapproval");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENProposalApproval.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENProposalApproval.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdProposalApproval) {
return ssENProposalApproval;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdProposalApproval.Key.AsGuid) {
return ssENProposalApproval;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENProposalApproval.FillFromOther((IRecord) other.AttributeGet(IdProposalApproval));
}
} // RC_1e5bc1d6d010761f865e3a0774f1c819
/// <summary>
/// RecordList type <code>ProposalApprovalRecordList</code> that represents a record list of
///  <code>ProposalApproval</code>
/// </summary>
public partial class RL_b93d71fe309691533cce5003487a0187 : GenericRecordList<RC_1e5bc1d6d010761f865e3a0774f1c819>, IEnumerable, IEnumerator {

protected override RC_1e5bc1d6d010761f865e3a0774f1c819 GetElementDefaultValue() {
return new RC_1e5bc1d6d010761f865e3a0774f1c819();
}

public T[] ToArray<T>(Func<RC_1e5bc1d6d010761f865e3a0774f1c819, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_b93d71fe309691533cce5003487a0187 recordList, Func<RC_1e5bc1d6d010761f865e3a0774f1c819, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_b93d71fe309691533cce5003487a0187(RC_1e5bc1d6d010761f865e3a0774f1c819[] array) {
  RL_b93d71fe309691533cce5003487a0187 result = new RL_b93d71fe309691533cce5003487a0187();
result.InnerFromArray(array);
    return result;
}

public static RL_b93d71fe309691533cce5003487a0187 ToList<T>(T[] array, Func <T, RC_1e5bc1d6d010761f865e3a0774f1c819> converter) {
  RL_b93d71fe309691533cce5003487a0187 result = new RL_b93d71fe309691533cce5003487a0187();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_b93d71fe309691533cce5003487a0187 FromRestList<T>(RestList<T> restList, Func <T, RC_1e5bc1d6d010761f865e3a0774f1c819> converter) {
  RL_b93d71fe309691533cce5003487a0187 result = new RL_b93d71fe309691533cce5003487a0187();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_b93d71fe309691533cce5003487a0187() : base() {
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
protected override OSList<RC_1e5bc1d6d010761f865e3a0774f1c819> NewList() {
return new RL_b93d71fe309691533cce5003487a0187();
}


} // RL_b93d71fe309691533cce5003487a0187
}

