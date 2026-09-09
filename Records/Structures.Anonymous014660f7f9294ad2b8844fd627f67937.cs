namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (92BGASn50kq4hE_WJ_Z5Nw)
///  <code>RC_5627f7a3ec063e602863ee6b4dd816a2</code> that represents <code>ProposalStatusRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: ProposalStatusRecord
public partial struct RC_5627f7a3ec063e602863ee6b4dd816a2 : ITypedRecord<RC_5627f7a3ec063e602863ee6b4dd816a2> {
internal static readonly GlobalObjectKey IdProposalStatus = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*o_cnVgbsYD4oY+5rTdgWog");

public EN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord ssENProposalStatus;


public static implicit operator EN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord( RC_5627f7a3ec063e602863ee6b4dd816a2 r) {
return r.ssENProposalStatus;
}

public static implicit operator RC_5627f7a3ec063e602863ee6b4dd816a2 (EN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord r) {
RC_5627f7a3ec063e602863ee6b4dd816a2 res = new RC_5627f7a3ec063e602863ee6b4dd816a2 ();
res.ssENProposalStatus = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENProposalStatus.ChangedAttributes = value;
}
get {
    return ssENProposalStatus.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_5627f7a3ec063e602863ee6b4dd816a2() {
OptimizedAttributes = null;
ssENProposalStatus = new EN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(5,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENProposalStatus.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENProposalStatus.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENProposalStatus.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENProposalStatus.Read( r, ref index);
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
public void ReadIM(RC_5627f7a3ec063e602863ee6b4dd816a2 r) {
this = r;
}


public static bool operator == (RC_5627f7a3ec063e602863ee6b4dd816a2 a, RC_5627f7a3ec063e602863ee6b4dd816a2 b) {
if (a.ssENProposalStatus != b.ssENProposalStatus) return false;
return true;
}

public static bool operator != (RC_5627f7a3ec063e602863ee6b4dd816a2 a, RC_5627f7a3ec063e602863ee6b4dd816a2 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_5627f7a3ec063e602863ee6b4dd816a2)) return false;
return (this == (RC_5627f7a3ec063e602863ee6b4dd816a2)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENProposalStatus.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENProposalStatus.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENProposalStatus.InternalRecursiveSave();
}


public RC_5627f7a3ec063e602863ee6b4dd816a2 Duplicate() {
RC_5627f7a3ec063e602863ee6b4dd816a2 t;
t.ssENProposalStatus = (EN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord)this.ssENProposalStatus.Duplicate();
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
if (head == "proposalstatus") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProposalStatus")) variable.Value = ssENProposalStatus; else variable.Optimized = true;
variable.SetFieldName("proposalstatus");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENProposalStatus.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENProposalStatus.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdProposalStatus) {
return ssENProposalStatus;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdProposalStatus.Key.AsGuid) {
return ssENProposalStatus;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENProposalStatus.FillFromOther((IRecord) other.AttributeGet(IdProposalStatus));
}
} // RC_5627f7a3ec063e602863ee6b4dd816a2
/// <summary>
/// RecordList type <code>ProposalStatusRecordList</code> that represents a record list of
///  <code>ProposalStatus</code>
/// </summary>
public partial class RL_edf26e482e095588ed6d5cbd5313bc7f : GenericRecordList<RC_5627f7a3ec063e602863ee6b4dd816a2>, IEnumerable, IEnumerator {

protected override RC_5627f7a3ec063e602863ee6b4dd816a2 GetElementDefaultValue() {
return new RC_5627f7a3ec063e602863ee6b4dd816a2();
}

public T[] ToArray<T>(Func<RC_5627f7a3ec063e602863ee6b4dd816a2, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_edf26e482e095588ed6d5cbd5313bc7f recordList, Func<RC_5627f7a3ec063e602863ee6b4dd816a2, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_edf26e482e095588ed6d5cbd5313bc7f(RC_5627f7a3ec063e602863ee6b4dd816a2[] array) {
  RL_edf26e482e095588ed6d5cbd5313bc7f result = new RL_edf26e482e095588ed6d5cbd5313bc7f();
result.InnerFromArray(array);
    return result;
}

public static RL_edf26e482e095588ed6d5cbd5313bc7f ToList<T>(T[] array, Func <T, RC_5627f7a3ec063e602863ee6b4dd816a2> converter) {
  RL_edf26e482e095588ed6d5cbd5313bc7f result = new RL_edf26e482e095588ed6d5cbd5313bc7f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_edf26e482e095588ed6d5cbd5313bc7f FromRestList<T>(RestList<T> restList, Func <T, RC_5627f7a3ec063e602863ee6b4dd816a2> converter) {
  RL_edf26e482e095588ed6d5cbd5313bc7f result = new RL_edf26e482e095588ed6d5cbd5313bc7f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_edf26e482e095588ed6d5cbd5313bc7f() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(5,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_5627f7a3ec063e602863ee6b4dd816a2> NewList() {
return new RL_edf26e482e095588ed6d5cbd5313bc7f();
}


} // RL_edf26e482e095588ed6d5cbd5313bc7f
}

