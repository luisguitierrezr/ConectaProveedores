namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (nW0CI6N6Rke2ANJsUxsjbQ)
///  <code>RC_d6a77c530b0e1f2687ee6b3214e237ef</code> that represents <code>ProposalTypeRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: ProposalTypeRecord
public partial struct RC_d6a77c530b0e1f2687ee6b3214e237ef : ITypedRecord<RC_d6a77c530b0e1f2687ee6b3214e237ef> {
internal static readonly GlobalObjectKey IdProposalType = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*U3yn1g4LJh+H7msyFOI37w");

public EN_7de728375ec552c47f71bca85f9991d9EntityRecord ssENProposalType;


public static implicit operator EN_7de728375ec552c47f71bca85f9991d9EntityRecord( RC_d6a77c530b0e1f2687ee6b3214e237ef r) {
return r.ssENProposalType;
}

public static implicit operator RC_d6a77c530b0e1f2687ee6b3214e237ef (EN_7de728375ec552c47f71bca85f9991d9EntityRecord r) {
RC_d6a77c530b0e1f2687ee6b3214e237ef res = new RC_d6a77c530b0e1f2687ee6b3214e237ef ();
res.ssENProposalType = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENProposalType.ChangedAttributes = value;
}
get {
    return ssENProposalType.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_d6a77c530b0e1f2687ee6b3214e237ef() {
OptimizedAttributes = null;
ssENProposalType = new EN_7de728375ec552c47f71bca85f9991d9EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(4,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENProposalType.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENProposalType.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENProposalType.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENProposalType.Read( r, ref index);
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
public void ReadIM(RC_d6a77c530b0e1f2687ee6b3214e237ef r) {
this = r;
}


public static bool operator == (RC_d6a77c530b0e1f2687ee6b3214e237ef a, RC_d6a77c530b0e1f2687ee6b3214e237ef b) {
if (a.ssENProposalType != b.ssENProposalType) return false;
return true;
}

public static bool operator != (RC_d6a77c530b0e1f2687ee6b3214e237ef a, RC_d6a77c530b0e1f2687ee6b3214e237ef b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_d6a77c530b0e1f2687ee6b3214e237ef)) return false;
return (this == (RC_d6a77c530b0e1f2687ee6b3214e237ef)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENProposalType.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENProposalType.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENProposalType.InternalRecursiveSave();
}


public RC_d6a77c530b0e1f2687ee6b3214e237ef Duplicate() {
RC_d6a77c530b0e1f2687ee6b3214e237ef t;
t.ssENProposalType = (EN_7de728375ec552c47f71bca85f9991d9EntityRecord)this.ssENProposalType.Duplicate();
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
if (head == "proposaltype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProposalType")) variable.Value = ssENProposalType; else variable.Optimized = true;
variable.SetFieldName("proposaltype");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENProposalType.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENProposalType.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdProposalType) {
return ssENProposalType;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdProposalType.Key.AsGuid) {
return ssENProposalType;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENProposalType.FillFromOther((IRecord) other.AttributeGet(IdProposalType));
}
} // RC_d6a77c530b0e1f2687ee6b3214e237ef
/// <summary>
/// RecordList type <code>ProposalTypeRecordList</code> that represents a record list of
///  <code>ProposalType</code>
/// </summary>
public partial class RL_75c16c4807d1a3963546d53942756918 : GenericRecordList<RC_d6a77c530b0e1f2687ee6b3214e237ef>, IEnumerable, IEnumerator {

protected override RC_d6a77c530b0e1f2687ee6b3214e237ef GetElementDefaultValue() {
return new RC_d6a77c530b0e1f2687ee6b3214e237ef();
}

public T[] ToArray<T>(Func<RC_d6a77c530b0e1f2687ee6b3214e237ef, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_75c16c4807d1a3963546d53942756918 recordList, Func<RC_d6a77c530b0e1f2687ee6b3214e237ef, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_75c16c4807d1a3963546d53942756918(RC_d6a77c530b0e1f2687ee6b3214e237ef[] array) {
  RL_75c16c4807d1a3963546d53942756918 result = new RL_75c16c4807d1a3963546d53942756918();
result.InnerFromArray(array);
    return result;
}

public static RL_75c16c4807d1a3963546d53942756918 ToList<T>(T[] array, Func <T, RC_d6a77c530b0e1f2687ee6b3214e237ef> converter) {
  RL_75c16c4807d1a3963546d53942756918 result = new RL_75c16c4807d1a3963546d53942756918();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_75c16c4807d1a3963546d53942756918 FromRestList<T>(RestList<T> restList, Func <T, RC_d6a77c530b0e1f2687ee6b3214e237ef> converter) {
  RL_75c16c4807d1a3963546d53942756918 result = new RL_75c16c4807d1a3963546d53942756918();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_75c16c4807d1a3963546d53942756918() : base() {
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
protected override OSList<RC_d6a77c530b0e1f2687ee6b3214e237ef> NewList() {
return new RL_75c16c4807d1a3963546d53942756918();
}


} // RL_75c16c4807d1a3963546d53942756918
}

