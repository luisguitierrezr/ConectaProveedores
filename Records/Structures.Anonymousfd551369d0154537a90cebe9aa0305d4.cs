namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (aRNV_RXQN0WpDOvpqgMF1A)
///  <code>RC_91adc4f46f8a0f51cacc4bc718d2ea35</code> that represents <code>ProposalRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: ProposalRecord
public partial struct RC_91adc4f46f8a0f51cacc4bc718d2ea35 : ITypedRecord<RC_91adc4f46f8a0f51cacc4bc718d2ea35> {
internal static readonly GlobalObjectKey IdProposal = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*9MStkYpvUQ_KzEvHGNLqNQ");

public EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord ssENProposal;


public static implicit operator EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord( RC_91adc4f46f8a0f51cacc4bc718d2ea35 r) {
return r.ssENProposal;
}

public static implicit operator RC_91adc4f46f8a0f51cacc4bc718d2ea35 (EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord r) {
RC_91adc4f46f8a0f51cacc4bc718d2ea35 res = new RC_91adc4f46f8a0f51cacc4bc718d2ea35 ();
res.ssENProposal = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENProposal.ChangedAttributes = value;
}
get {
    return ssENProposal.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_91adc4f46f8a0f51cacc4bc718d2ea35() {
OptimizedAttributes = null;
ssENProposal = new EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(18,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENProposal.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENProposal.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENProposal.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
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
public void ReadIM(RC_91adc4f46f8a0f51cacc4bc718d2ea35 r) {
this = r;
}


public static bool operator == (RC_91adc4f46f8a0f51cacc4bc718d2ea35 a, RC_91adc4f46f8a0f51cacc4bc718d2ea35 b) {
if (a.ssENProposal != b.ssENProposal) return false;
return true;
}

public static bool operator != (RC_91adc4f46f8a0f51cacc4bc718d2ea35 a, RC_91adc4f46f8a0f51cacc4bc718d2ea35 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_91adc4f46f8a0f51cacc4bc718d2ea35)) return false;
return (this == (RC_91adc4f46f8a0f51cacc4bc718d2ea35)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENProposal.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENProposal.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENProposal.InternalRecursiveSave();
}


public RC_91adc4f46f8a0f51cacc4bc718d2ea35 Duplicate() {
RC_91adc4f46f8a0f51cacc4bc718d2ea35 t;
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
if (head == "proposal") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Proposal")) variable.Value = ssENProposal; else variable.Optimized = true;
variable.SetFieldName("proposal");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENProposal.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENProposal.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdProposal) {
return ssENProposal;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdProposal.Key.AsGuid) {
return ssENProposal;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENProposal.FillFromOther((IRecord) other.AttributeGet(IdProposal));
}
} // RC_91adc4f46f8a0f51cacc4bc718d2ea35
/// <summary>
/// RecordList type <code>ProposalRecordList</code> that represents a record list of
///  <code>Proposal</code>
/// </summary>
public partial class RL_88245586d5ac2ebd4048f53abef0c31b : GenericRecordList<RC_91adc4f46f8a0f51cacc4bc718d2ea35>, IEnumerable, IEnumerator {

protected override RC_91adc4f46f8a0f51cacc4bc718d2ea35 GetElementDefaultValue() {
return new RC_91adc4f46f8a0f51cacc4bc718d2ea35();
}

public T[] ToArray<T>(Func<RC_91adc4f46f8a0f51cacc4bc718d2ea35, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_88245586d5ac2ebd4048f53abef0c31b recordList, Func<RC_91adc4f46f8a0f51cacc4bc718d2ea35, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_88245586d5ac2ebd4048f53abef0c31b(RC_91adc4f46f8a0f51cacc4bc718d2ea35[] array) {
  RL_88245586d5ac2ebd4048f53abef0c31b result = new RL_88245586d5ac2ebd4048f53abef0c31b();
result.InnerFromArray(array);
    return result;
}

public static RL_88245586d5ac2ebd4048f53abef0c31b ToList<T>(T[] array, Func <T, RC_91adc4f46f8a0f51cacc4bc718d2ea35> converter) {
  RL_88245586d5ac2ebd4048f53abef0c31b result = new RL_88245586d5ac2ebd4048f53abef0c31b();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_88245586d5ac2ebd4048f53abef0c31b FromRestList<T>(RestList<T> restList, Func <T, RC_91adc4f46f8a0f51cacc4bc718d2ea35> converter) {
  RL_88245586d5ac2ebd4048f53abef0c31b result = new RL_88245586d5ac2ebd4048f53abef0c31b();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_88245586d5ac2ebd4048f53abef0c31b() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(18,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_91adc4f46f8a0f51cacc4bc718d2ea35> NewList() {
return new RL_88245586d5ac2ebd4048f53abef0c31b();
}


} // RL_88245586d5ac2ebd4048f53abef0c31b
}

