namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (knM+PW8GY0GqpNb8yfJWhA)
///  <code>RC_e6d370b8387bb43d90dc90a766ecdf20</code> that represent
/// s <code>ProposalStatusHistoryRecord</code> <p>Description: </p>
/// </summary>
// Name: ProposalStatusHistoryRecord
public partial struct RC_e6d370b8387bb43d90dc90a766ecdf20 : ITypedRecord<RC_e6d370b8387bb43d90dc90a766ecdf20> {
internal static readonly GlobalObjectKey IdProposalStatusHistory = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*uHDT5ns4PbSQ3JCnZuzfIA");

public EN_f6d34ae04169ae9164103e8797ea11d4EntityRecord ssENProposalStatusHistory;


public static implicit operator EN_f6d34ae04169ae9164103e8797ea11d4EntityRecord( RC_e6d370b8387bb43d90dc90a766ecdf20 r) {
return r.ssENProposalStatusHistory;
}

public static implicit operator RC_e6d370b8387bb43d90dc90a766ecdf20 (EN_f6d34ae04169ae9164103e8797ea11d4EntityRecord r) {
RC_e6d370b8387bb43d90dc90a766ecdf20 res = new RC_e6d370b8387bb43d90dc90a766ecdf20 ();
res.ssENProposalStatusHistory = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENProposalStatusHistory.ChangedAttributes = value;
}
get {
    return ssENProposalStatusHistory.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_e6d370b8387bb43d90dc90a766ecdf20() {
OptimizedAttributes = null;
ssENProposalStatusHistory = new EN_f6d34ae04169ae9164103e8797ea11d4EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(5,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENProposalStatusHistory.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENProposalStatusHistory.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENProposalStatusHistory.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENProposalStatusHistory.Read( r, ref index);
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
public void ReadIM(RC_e6d370b8387bb43d90dc90a766ecdf20 r) {
this = r;
}


public static bool operator == (RC_e6d370b8387bb43d90dc90a766ecdf20 a, RC_e6d370b8387bb43d90dc90a766ecdf20 b) {
if (a.ssENProposalStatusHistory != b.ssENProposalStatusHistory) return false;
return true;
}

public static bool operator != (RC_e6d370b8387bb43d90dc90a766ecdf20 a, RC_e6d370b8387bb43d90dc90a766ecdf20 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_e6d370b8387bb43d90dc90a766ecdf20)) return false;
return (this == (RC_e6d370b8387bb43d90dc90a766ecdf20)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENProposalStatusHistory.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENProposalStatusHistory.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENProposalStatusHistory.InternalRecursiveSave();
}


public RC_e6d370b8387bb43d90dc90a766ecdf20 Duplicate() {
RC_e6d370b8387bb43d90dc90a766ecdf20 t;
t.ssENProposalStatusHistory = (EN_f6d34ae04169ae9164103e8797ea11d4EntityRecord)this.ssENProposalStatusHistory.Duplicate();
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
if (head == "proposalstatushistory") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProposalStatusHistory")) variable.Value = ssENProposalStatusHistory; else variable.Optimized = true;
variable.SetFieldName("proposalstatushistory");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENProposalStatusHistory.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENProposalStatusHistory.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdProposalStatusHistory) {
return ssENProposalStatusHistory;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdProposalStatusHistory.Key.AsGuid) {
return ssENProposalStatusHistory;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENProposalStatusHistory.FillFromOther((IRecord) other.AttributeGet(IdProposalStatusHistory));
}
} // RC_e6d370b8387bb43d90dc90a766ecdf20
/// <summary>
/// RecordList type <code>ProposalStatusHistoryRecordList</code> that represents a record list of
///  <code>ProposalStatusHistory</code>
/// </summary>
public partial class RL_43faae938c012f4de2479cbeb914558b : GenericRecordList<RC_e6d370b8387bb43d90dc90a766ecdf20>, IEnumerable, IEnumerator {

protected override RC_e6d370b8387bb43d90dc90a766ecdf20 GetElementDefaultValue() {
return new RC_e6d370b8387bb43d90dc90a766ecdf20();
}

public T[] ToArray<T>(Func<RC_e6d370b8387bb43d90dc90a766ecdf20, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_43faae938c012f4de2479cbeb914558b recordList, Func<RC_e6d370b8387bb43d90dc90a766ecdf20, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_43faae938c012f4de2479cbeb914558b(RC_e6d370b8387bb43d90dc90a766ecdf20[] array) {
  RL_43faae938c012f4de2479cbeb914558b result = new RL_43faae938c012f4de2479cbeb914558b();
result.InnerFromArray(array);
    return result;
}

public static RL_43faae938c012f4de2479cbeb914558b ToList<T>(T[] array, Func <T, RC_e6d370b8387bb43d90dc90a766ecdf20> converter) {
  RL_43faae938c012f4de2479cbeb914558b result = new RL_43faae938c012f4de2479cbeb914558b();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_43faae938c012f4de2479cbeb914558b FromRestList<T>(RestList<T> restList, Func <T, RC_e6d370b8387bb43d90dc90a766ecdf20> converter) {
  RL_43faae938c012f4de2479cbeb914558b result = new RL_43faae938c012f4de2479cbeb914558b();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_43faae938c012f4de2479cbeb914558b() : base() {
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
protected override OSList<RC_e6d370b8387bb43d90dc90a766ecdf20> NewList() {
return new RL_43faae938c012f4de2479cbeb914558b();
}


} // RL_43faae938c012f4de2479cbeb914558b
}

