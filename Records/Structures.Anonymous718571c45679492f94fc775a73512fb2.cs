namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (xHGFcXlWL0mU_Hdac1Evsg)
///  <code>RC_471ec64149613ec0a9f3525fc2d9e11c</code> that represent
/// s <code>RequisitionContractFileRecord</code> <p>Description: </p>
/// </summary>
// Name: RequisitionContractFileRecord
public partial struct RC_471ec64149613ec0a9f3525fc2d9e11c : ITypedRecord<RC_471ec64149613ec0a9f3525fc2d9e11c> {
internal static readonly GlobalObjectKey IdRequisitionContractFile = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*QcYeR2FJwD6p81JfwtnhHA");

public EN_aeab0089a9236dfc6c684ea98f650647EntityRecord ssENRequisitionContractFile;


public static implicit operator EN_aeab0089a9236dfc6c684ea98f650647EntityRecord( RC_471ec64149613ec0a9f3525fc2d9e11c r) {
return r.ssENRequisitionContractFile;
}

public static implicit operator RC_471ec64149613ec0a9f3525fc2d9e11c (EN_aeab0089a9236dfc6c684ea98f650647EntityRecord r) {
RC_471ec64149613ec0a9f3525fc2d9e11c res = new RC_471ec64149613ec0a9f3525fc2d9e11c ();
res.ssENRequisitionContractFile = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENRequisitionContractFile.ChangedAttributes = value;
}
get {
    return ssENRequisitionContractFile.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_471ec64149613ec0a9f3525fc2d9e11c() {
OptimizedAttributes = null;
ssENRequisitionContractFile = new EN_aeab0089a9236dfc6c684ea98f650647EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(9,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENRequisitionContractFile.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENRequisitionContractFile.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENRequisitionContractFile.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENRequisitionContractFile.Read( r, ref index);
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
public void ReadIM(RC_471ec64149613ec0a9f3525fc2d9e11c r) {
this = r;
}


public static bool operator == (RC_471ec64149613ec0a9f3525fc2d9e11c a, RC_471ec64149613ec0a9f3525fc2d9e11c b) {
if (a.ssENRequisitionContractFile != b.ssENRequisitionContractFile) return false;
return true;
}

public static bool operator != (RC_471ec64149613ec0a9f3525fc2d9e11c a, RC_471ec64149613ec0a9f3525fc2d9e11c b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_471ec64149613ec0a9f3525fc2d9e11c)) return false;
return (this == (RC_471ec64149613ec0a9f3525fc2d9e11c)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENRequisitionContractFile.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENRequisitionContractFile.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENRequisitionContractFile.InternalRecursiveSave();
}


public RC_471ec64149613ec0a9f3525fc2d9e11c Duplicate() {
RC_471ec64149613ec0a9f3525fc2d9e11c t;
t.ssENRequisitionContractFile = (EN_aeab0089a9236dfc6c684ea98f650647EntityRecord)this.ssENRequisitionContractFile.Duplicate();
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
if (head == "requisitioncontractfile") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionContractFile")) variable.Value = ssENRequisitionContractFile; else variable.Optimized = true;
variable.SetFieldName("requisitioncontractfile");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENRequisitionContractFile.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENRequisitionContractFile.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdRequisitionContractFile) {
return ssENRequisitionContractFile;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdRequisitionContractFile.Key.AsGuid) {
return ssENRequisitionContractFile;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENRequisitionContractFile.FillFromOther((IRecord) other.AttributeGet(IdRequisitionContractFile));
}
} // RC_471ec64149613ec0a9f3525fc2d9e11c
/// <summary>
/// RecordList type <code>RequisitionContractFileRecordList</code> that represents a record list of
///  <code>RequisitionContractFile</code>
/// </summary>
public partial class RL_25486e09ba20acde3d8ef9d3e8a6e625 : GenericRecordList<RC_471ec64149613ec0a9f3525fc2d9e11c>, IEnumerable, IEnumerator {

protected override RC_471ec64149613ec0a9f3525fc2d9e11c GetElementDefaultValue() {
return new RC_471ec64149613ec0a9f3525fc2d9e11c();
}

public T[] ToArray<T>(Func<RC_471ec64149613ec0a9f3525fc2d9e11c, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_25486e09ba20acde3d8ef9d3e8a6e625 recordList, Func<RC_471ec64149613ec0a9f3525fc2d9e11c, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_25486e09ba20acde3d8ef9d3e8a6e625(RC_471ec64149613ec0a9f3525fc2d9e11c[] array) {
  RL_25486e09ba20acde3d8ef9d3e8a6e625 result = new RL_25486e09ba20acde3d8ef9d3e8a6e625();
result.InnerFromArray(array);
    return result;
}

public static RL_25486e09ba20acde3d8ef9d3e8a6e625 ToList<T>(T[] array, Func <T, RC_471ec64149613ec0a9f3525fc2d9e11c> converter) {
  RL_25486e09ba20acde3d8ef9d3e8a6e625 result = new RL_25486e09ba20acde3d8ef9d3e8a6e625();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_25486e09ba20acde3d8ef9d3e8a6e625 FromRestList<T>(RestList<T> restList, Func <T, RC_471ec64149613ec0a9f3525fc2d9e11c> converter) {
  RL_25486e09ba20acde3d8ef9d3e8a6e625 result = new RL_25486e09ba20acde3d8ef9d3e8a6e625();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_25486e09ba20acde3d8ef9d3e8a6e625() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(9,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_471ec64149613ec0a9f3525fc2d9e11c> NewList() {
return new RL_25486e09ba20acde3d8ef9d3e8a6e625();
}


} // RL_25486e09ba20acde3d8ef9d3e8a6e625
}

