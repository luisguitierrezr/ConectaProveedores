namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (4IuDLor2QUyiEgJsOy_saw)
///  <code>RC_818bd4b46f7dc615b92986d5f58cbcb9</code> that represent
/// s <code>RequisitionContractFileFinanceRequisitionFile2FinanceRecord</code> <p>Description: </p>
/// </summary>
// Name: RequisitionContractFileFinanceRequisitionFile2FinanceRecord
public partial struct RC_818bd4b46f7dc615b92986d5f58cbcb9 : ITypedRecord<RC_818bd4b46f7dc615b92986d5f58cbcb9> {
internal static readonly GlobalObjectKey IdRequisitionContractFileFinance = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*rI8pb40dznuduOdJIS7l0A");
internal static readonly GlobalObjectKey IdRequisitionFile2Finance = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*xT2a+zgzyCLG2Ppo56HAVw");

public EN_aeab0089a9236dfc6c684ea98f650647EntityRecord ssENRequisitionContractFileFinance;

public EN_4cce425e15647f937e21de4e52849889EntityRecord ssENRequisitionFile2Finance;


public BitArray OptimizedAttributes;

public RC_818bd4b46f7dc615b92986d5f58cbcb9() {
OptimizedAttributes = null;
ssENRequisitionContractFileFinance = new EN_aeab0089a9236dfc6c684ea98f650647EntityRecord();
ssENRequisitionFile2Finance = new EN_4cce425e15647f937e21de4e52849889EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(9,false);
    all[1] = new BitArray(8,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENRequisitionContractFileFinance.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENRequisitionFile2Finance.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENRequisitionContractFileFinance.OptimizedAttributes = value[0];
    ssENRequisitionFile2Finance.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENRequisitionContractFileFinance.OptimizedAttributes;
    all[1] = ssENRequisitionFile2Finance.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENRequisitionContractFileFinance.Read( r, ref index);
ssENRequisitionFile2Finance.Read( r, ref index);
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
public void ReadIM(RC_818bd4b46f7dc615b92986d5f58cbcb9 r) {
this = r;
}


public static bool operator == (RC_818bd4b46f7dc615b92986d5f58cbcb9 a, RC_818bd4b46f7dc615b92986d5f58cbcb9 b) {
if (a.ssENRequisitionContractFileFinance != b.ssENRequisitionContractFileFinance) return false;
if (a.ssENRequisitionFile2Finance != b.ssENRequisitionFile2Finance) return false;
return true;
}

public static bool operator != (RC_818bd4b46f7dc615b92986d5f58cbcb9 a, RC_818bd4b46f7dc615b92986d5f58cbcb9 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_818bd4b46f7dc615b92986d5f58cbcb9)) return false;
return (this == (RC_818bd4b46f7dc615b92986d5f58cbcb9)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENRequisitionContractFileFinance.GetHashCode()
 ^ ssENRequisitionFile2Finance.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENRequisitionContractFileFinance.RecursiveReset();
ssENRequisitionFile2Finance.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENRequisitionContractFileFinance.InternalRecursiveSave();
ssENRequisitionFile2Finance.InternalRecursiveSave();
}


public RC_818bd4b46f7dc615b92986d5f58cbcb9 Duplicate() {
RC_818bd4b46f7dc615b92986d5f58cbcb9 t;
t.ssENRequisitionContractFileFinance = (EN_aeab0089a9236dfc6c684ea98f650647EntityRecord)this.ssENRequisitionContractFileFinance.Duplicate();
t.ssENRequisitionFile2Finance = (EN_4cce425e15647f937e21de4e52849889EntityRecord)this.ssENRequisitionFile2Finance.Duplicate();
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
if (head == "requisitioncontractfilefinance") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionContractFileFinance")) variable.Value = ssENRequisitionContractFileFinance; else variable.Optimized = true;
variable.SetFieldName("requisitioncontractfilefinance");
} else if (head == "requisitionfile2finance") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionFile2Finance")) variable.Value = ssENRequisitionFile2Finance; else variable.Optimized = true;
variable.SetFieldName("requisitionfile2finance");
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
if (key == IdRequisitionContractFileFinance) {
return ssENRequisitionContractFileFinance;
}
if (key == IdRequisitionFile2Finance) {
return ssENRequisitionFile2Finance;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdRequisitionContractFileFinance.Key.AsGuid) {
return ssENRequisitionContractFileFinance;
}
if (attributeKey == IdRequisitionFile2Finance.Key.AsGuid) {
return ssENRequisitionFile2Finance;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENRequisitionContractFileFinance.FillFromOther((IRecord) other.AttributeGet(IdRequisitionContractFileFinance));
ssENRequisitionFile2Finance.FillFromOther((IRecord) other.AttributeGet(IdRequisitionFile2Finance));
}
} // RC_818bd4b46f7dc615b92986d5f58cbcb9
/// <summary>
/// RecordList type <code>RequisitionContractFileFinanceRequisitionFile2FinanceRecordList</code> that
///  represents a record list of <code>RequisitionContractFile, RequisitionFile2</code>
/// </summary>
public partial class RL_0b64a36c63b61ccaf400e29784570ef4 : GenericRecordList<RC_818bd4b46f7dc615b92986d5f58cbcb9>, IEnumerable, IEnumerator {

protected override RC_818bd4b46f7dc615b92986d5f58cbcb9 GetElementDefaultValue() {
return new RC_818bd4b46f7dc615b92986d5f58cbcb9();
}

public T[] ToArray<T>(Func<RC_818bd4b46f7dc615b92986d5f58cbcb9, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_0b64a36c63b61ccaf400e29784570ef4 recordList, Func<RC_818bd4b46f7dc615b92986d5f58cbcb9, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_0b64a36c63b61ccaf400e29784570ef4(RC_818bd4b46f7dc615b92986d5f58cbcb9[] array) {
  RL_0b64a36c63b61ccaf400e29784570ef4 result = new RL_0b64a36c63b61ccaf400e29784570ef4();
result.InnerFromArray(array);
    return result;
}

public static RL_0b64a36c63b61ccaf400e29784570ef4 ToList<T>(T[] array, Func <T, RC_818bd4b46f7dc615b92986d5f58cbcb9> converter) {
  RL_0b64a36c63b61ccaf400e29784570ef4 result = new RL_0b64a36c63b61ccaf400e29784570ef4();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_0b64a36c63b61ccaf400e29784570ef4 FromRestList<T>(RestList<T> restList, Func <T, RC_818bd4b46f7dc615b92986d5f58cbcb9> converter) {
  RL_0b64a36c63b61ccaf400e29784570ef4 result = new RL_0b64a36c63b61ccaf400e29784570ef4();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_0b64a36c63b61ccaf400e29784570ef4() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(9,false);
def[1] = new BitArray(8,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_818bd4b46f7dc615b92986d5f58cbcb9> NewList() {
return new RL_0b64a36c63b61ccaf400e29784570ef4();
}


} // RL_0b64a36c63b61ccaf400e29784570ef4
}

