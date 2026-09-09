namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (3OIGuox48kqp7RIn+LxusQ)
///  <code>RC_aa9fab59faf7c7de355dae43478ba7e5</code> that represent
/// s <code>RequisitionStatusHistoryRecord</code> <p>Description: </p>
/// </summary>
// Name: RequisitionStatusHistoryRecord
public partial struct RC_aa9fab59faf7c7de355dae43478ba7e5 : ITypedRecord<RC_aa9fab59faf7c7de355dae43478ba7e5> {
internal static readonly GlobalObjectKey IdRequisitionStatusHistory = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Waufqvf63sc1Xa5DR4un5Q");

public EN_d566458a53d0e8cbc28e1eb868fd2ba4EntityRecord ssENRequisitionStatusHistory;


public static implicit operator EN_d566458a53d0e8cbc28e1eb868fd2ba4EntityRecord( RC_aa9fab59faf7c7de355dae43478ba7e5 r) {
return r.ssENRequisitionStatusHistory;
}

public static implicit operator RC_aa9fab59faf7c7de355dae43478ba7e5 (EN_d566458a53d0e8cbc28e1eb868fd2ba4EntityRecord r) {
RC_aa9fab59faf7c7de355dae43478ba7e5 res = new RC_aa9fab59faf7c7de355dae43478ba7e5 ();
res.ssENRequisitionStatusHistory = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENRequisitionStatusHistory.ChangedAttributes = value;
}
get {
    return ssENRequisitionStatusHistory.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_aa9fab59faf7c7de355dae43478ba7e5() {
OptimizedAttributes = null;
ssENRequisitionStatusHistory = new EN_d566458a53d0e8cbc28e1eb868fd2ba4EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(5,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENRequisitionStatusHistory.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENRequisitionStatusHistory.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENRequisitionStatusHistory.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENRequisitionStatusHistory.Read( r, ref index);
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
public void ReadIM(RC_aa9fab59faf7c7de355dae43478ba7e5 r) {
this = r;
}


public static bool operator == (RC_aa9fab59faf7c7de355dae43478ba7e5 a, RC_aa9fab59faf7c7de355dae43478ba7e5 b) {
if (a.ssENRequisitionStatusHistory != b.ssENRequisitionStatusHistory) return false;
return true;
}

public static bool operator != (RC_aa9fab59faf7c7de355dae43478ba7e5 a, RC_aa9fab59faf7c7de355dae43478ba7e5 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_aa9fab59faf7c7de355dae43478ba7e5)) return false;
return (this == (RC_aa9fab59faf7c7de355dae43478ba7e5)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENRequisitionStatusHistory.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENRequisitionStatusHistory.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENRequisitionStatusHistory.InternalRecursiveSave();
}


public RC_aa9fab59faf7c7de355dae43478ba7e5 Duplicate() {
RC_aa9fab59faf7c7de355dae43478ba7e5 t;
t.ssENRequisitionStatusHistory = (EN_d566458a53d0e8cbc28e1eb868fd2ba4EntityRecord)this.ssENRequisitionStatusHistory.Duplicate();
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
if (head == "requisitionstatushistory") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionStatusHistory")) variable.Value = ssENRequisitionStatusHistory; else variable.Optimized = true;
variable.SetFieldName("requisitionstatushistory");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENRequisitionStatusHistory.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENRequisitionStatusHistory.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdRequisitionStatusHistory) {
return ssENRequisitionStatusHistory;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdRequisitionStatusHistory.Key.AsGuid) {
return ssENRequisitionStatusHistory;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENRequisitionStatusHistory.FillFromOther((IRecord) other.AttributeGet(IdRequisitionStatusHistory));
}
} // RC_aa9fab59faf7c7de355dae43478ba7e5
/// <summary>
/// RecordList type <code>RequisitionStatusHistoryRecordList</code> that represents a record list of
///  <code>RequisitionStatusHistory</code>
/// </summary>
public partial class RL_40212690d01342e9b25b0ac7249068cf : GenericRecordList<RC_aa9fab59faf7c7de355dae43478ba7e5>, IEnumerable, IEnumerator {

protected override RC_aa9fab59faf7c7de355dae43478ba7e5 GetElementDefaultValue() {
return new RC_aa9fab59faf7c7de355dae43478ba7e5();
}

public T[] ToArray<T>(Func<RC_aa9fab59faf7c7de355dae43478ba7e5, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_40212690d01342e9b25b0ac7249068cf recordList, Func<RC_aa9fab59faf7c7de355dae43478ba7e5, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_40212690d01342e9b25b0ac7249068cf(RC_aa9fab59faf7c7de355dae43478ba7e5[] array) {
  RL_40212690d01342e9b25b0ac7249068cf result = new RL_40212690d01342e9b25b0ac7249068cf();
result.InnerFromArray(array);
    return result;
}

public static RL_40212690d01342e9b25b0ac7249068cf ToList<T>(T[] array, Func <T, RC_aa9fab59faf7c7de355dae43478ba7e5> converter) {
  RL_40212690d01342e9b25b0ac7249068cf result = new RL_40212690d01342e9b25b0ac7249068cf();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_40212690d01342e9b25b0ac7249068cf FromRestList<T>(RestList<T> restList, Func <T, RC_aa9fab59faf7c7de355dae43478ba7e5> converter) {
  RL_40212690d01342e9b25b0ac7249068cf result = new RL_40212690d01342e9b25b0ac7249068cf();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_40212690d01342e9b25b0ac7249068cf() : base() {
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
protected override OSList<RC_aa9fab59faf7c7de355dae43478ba7e5> NewList() {
return new RL_40212690d01342e9b25b0ac7249068cf();
}


} // RL_40212690d01342e9b25b0ac7249068cf
}

