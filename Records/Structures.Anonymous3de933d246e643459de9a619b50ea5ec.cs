namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (0jPpPeZGRUOd6aYZtQ6l7A)
///  <code>RC_cbff39127609a0f830b2d34948d1c019</code> that represents <code>ProposalLineRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: ProposalLineRecord
public partial struct RC_cbff39127609a0f830b2d34948d1c019 : ITypedRecord<RC_cbff39127609a0f830b2d34948d1c019> {
internal static readonly GlobalObjectKey IdProposalLine = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Ejn_ywl2+KAwstNJSNHAGQ");

public EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord ssENProposalLine;


public static implicit operator EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord( RC_cbff39127609a0f830b2d34948d1c019 r) {
return r.ssENProposalLine;
}

public static implicit operator RC_cbff39127609a0f830b2d34948d1c019 (EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord r) {
RC_cbff39127609a0f830b2d34948d1c019 res = new RC_cbff39127609a0f830b2d34948d1c019 ();
res.ssENProposalLine = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENProposalLine.ChangedAttributes = value;
}
get {
    return ssENProposalLine.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_cbff39127609a0f830b2d34948d1c019() {
OptimizedAttributes = null;
ssENProposalLine = new EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(28,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENProposalLine.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENProposalLine.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENProposalLine.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
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
public void ReadIM(RC_cbff39127609a0f830b2d34948d1c019 r) {
this = r;
}


public static bool operator == (RC_cbff39127609a0f830b2d34948d1c019 a, RC_cbff39127609a0f830b2d34948d1c019 b) {
if (a.ssENProposalLine != b.ssENProposalLine) return false;
return true;
}

public static bool operator != (RC_cbff39127609a0f830b2d34948d1c019 a, RC_cbff39127609a0f830b2d34948d1c019 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_cbff39127609a0f830b2d34948d1c019)) return false;
return (this == (RC_cbff39127609a0f830b2d34948d1c019)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENProposalLine.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENProposalLine.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENProposalLine.InternalRecursiveSave();
}


public RC_cbff39127609a0f830b2d34948d1c019 Duplicate() {
RC_cbff39127609a0f830b2d34948d1c019 t;
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
if (head == "proposalline") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProposalLine")) variable.Value = ssENProposalLine; else variable.Optimized = true;
variable.SetFieldName("proposalline");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENProposalLine.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENProposalLine.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdProposalLine) {
return ssENProposalLine;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdProposalLine.Key.AsGuid) {
return ssENProposalLine;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENProposalLine.FillFromOther((IRecord) other.AttributeGet(IdProposalLine));
}
} // RC_cbff39127609a0f830b2d34948d1c019
/// <summary>
/// RecordList type <code>ProposalLineRecordList</code> that represents a record list of
///  <code>ProposalLine</code>
/// </summary>
public partial class RL_5a265eacaa987aecd8ded8a7c13b9b2d : GenericRecordList<RC_cbff39127609a0f830b2d34948d1c019>, IEnumerable, IEnumerator {

protected override RC_cbff39127609a0f830b2d34948d1c019 GetElementDefaultValue() {
return new RC_cbff39127609a0f830b2d34948d1c019();
}

public T[] ToArray<T>(Func<RC_cbff39127609a0f830b2d34948d1c019, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_5a265eacaa987aecd8ded8a7c13b9b2d recordList, Func<RC_cbff39127609a0f830b2d34948d1c019, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_5a265eacaa987aecd8ded8a7c13b9b2d(RC_cbff39127609a0f830b2d34948d1c019[] array) {
  RL_5a265eacaa987aecd8ded8a7c13b9b2d result = new RL_5a265eacaa987aecd8ded8a7c13b9b2d();
result.InnerFromArray(array);
    return result;
}

public static RL_5a265eacaa987aecd8ded8a7c13b9b2d ToList<T>(T[] array, Func <T, RC_cbff39127609a0f830b2d34948d1c019> converter) {
  RL_5a265eacaa987aecd8ded8a7c13b9b2d result = new RL_5a265eacaa987aecd8ded8a7c13b9b2d();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_5a265eacaa987aecd8ded8a7c13b9b2d FromRestList<T>(RestList<T> restList, Func <T, RC_cbff39127609a0f830b2d34948d1c019> converter) {
  RL_5a265eacaa987aecd8ded8a7c13b9b2d result = new RL_5a265eacaa987aecd8ded8a7c13b9b2d();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_5a265eacaa987aecd8ded8a7c13b9b2d() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(28,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_cbff39127609a0f830b2d34948d1c019> NewList() {
return new RL_5a265eacaa987aecd8ded8a7c13b9b2d();
}


} // RL_5a265eacaa987aecd8ded8a7c13b9b2d
}

