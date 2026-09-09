namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (F6fKPGOqt0OXfWvGKrUmlg)
///  <code>RC_409326af30f6b67f1d011aa096c0a54e</code> that represent
/// s <code>RequisitionContractFileRequisitionRequisitionFile2StorageRecord</code> <p>Description: </p>
/// </summary>
// Name: RequisitionContractFileRequisitionRequisitionFile2StorageRecord
public partial struct RC_409326af30f6b67f1d011aa096c0a54e : ITypedRecord<RC_409326af30f6b67f1d011aa096c0a54e> {
internal static readonly GlobalObjectKey IdRequisitionContractFile = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*QcYeR2FJwD6p81JfwtnhHA");
internal static readonly GlobalObjectKey IdRequisition = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*T3SBu1iqc67nzY23TLMhVQ");
internal static readonly GlobalObjectKey IdRequisitionFile2 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NbYPPv7ugJRU+nVCFUapAQ");
internal static readonly GlobalObjectKey IdStorage = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*k_HtsgKSfutg60mTSTiFFA");

public EN_aeab0089a9236dfc6c684ea98f650647EntityRecord ssENRequisitionContractFile;

public EN_98680591dcf3728e0877a90eb5e1e552EntityRecord ssENRequisition;

public EN_4cce425e15647f937e21de4e52849889EntityRecord ssENRequisitionFile2;

public EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord ssENStorage;


public BitArray OptimizedAttributes;

public RC_409326af30f6b67f1d011aa096c0a54e() {
OptimizedAttributes = null;
ssENRequisitionContractFile = new EN_aeab0089a9236dfc6c684ea98f650647EntityRecord();
ssENRequisition = new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord();
ssENRequisitionFile2 = new EN_4cce425e15647f937e21de4e52849889EntityRecord();
ssENStorage = new EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[4];
    all[0] = new BitArray(9,false);
    all[1] = new BitArray(58,false);
    all[2] = new BitArray(8,false);
    all[3] = new BitArray(20,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENRequisitionContractFile.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENRequisition.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENRequisitionFile2.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENStorage.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    }else{
    ssENRequisitionContractFile.OptimizedAttributes = value[0];
    ssENRequisition.OptimizedAttributes = value[1];
    ssENRequisitionFile2.OptimizedAttributes = value[2];
    ssENStorage.OptimizedAttributes = value[3];
    }
}
get{
    BitArray[] all = new BitArray[4];
    all[0] = ssENRequisitionContractFile.OptimizedAttributes;
    all[1] = ssENRequisition.OptimizedAttributes;
    all[2] = ssENRequisitionFile2.OptimizedAttributes;
    all[3] = ssENStorage.OptimizedAttributes;
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
ssENRequisition.Read( r, ref index);
ssENRequisitionFile2.Read( r, ref index);
ssENStorage.Read( r, ref index);
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
public void ReadIM(RC_409326af30f6b67f1d011aa096c0a54e r) {
this = r;
}


public static bool operator == (RC_409326af30f6b67f1d011aa096c0a54e a, RC_409326af30f6b67f1d011aa096c0a54e b) {
if (a.ssENRequisitionContractFile != b.ssENRequisitionContractFile) return false;
if (a.ssENRequisition != b.ssENRequisition) return false;
if (a.ssENRequisitionFile2 != b.ssENRequisitionFile2) return false;
if (a.ssENStorage != b.ssENStorage) return false;
return true;
}

public static bool operator != (RC_409326af30f6b67f1d011aa096c0a54e a, RC_409326af30f6b67f1d011aa096c0a54e b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_409326af30f6b67f1d011aa096c0a54e)) return false;
return (this == (RC_409326af30f6b67f1d011aa096c0a54e)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENRequisitionContractFile.GetHashCode()
 ^ ssENRequisition.GetHashCode()
 ^ ssENRequisitionFile2.GetHashCode()
 ^ ssENStorage.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENRequisitionContractFile.RecursiveReset();
ssENRequisition.RecursiveReset();
ssENRequisitionFile2.RecursiveReset();
ssENStorage.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENRequisitionContractFile.InternalRecursiveSave();
ssENRequisition.InternalRecursiveSave();
ssENRequisitionFile2.InternalRecursiveSave();
ssENStorage.InternalRecursiveSave();
}


public RC_409326af30f6b67f1d011aa096c0a54e Duplicate() {
RC_409326af30f6b67f1d011aa096c0a54e t;
t.ssENRequisitionContractFile = (EN_aeab0089a9236dfc6c684ea98f650647EntityRecord)this.ssENRequisitionContractFile.Duplicate();
t.ssENRequisition = (EN_98680591dcf3728e0877a90eb5e1e552EntityRecord)this.ssENRequisition.Duplicate();
t.ssENRequisitionFile2 = (EN_4cce425e15647f937e21de4e52849889EntityRecord)this.ssENRequisitionFile2.Duplicate();
t.ssENStorage = (EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord)this.ssENStorage.Duplicate();
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
} else if (head == "requisition") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Requisition")) variable.Value = ssENRequisition; else variable.Optimized = true;
variable.SetFieldName("requisition");
} else if (head == "requisitionfile2") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionFile2")) variable.Value = ssENRequisitionFile2; else variable.Optimized = true;
variable.SetFieldName("requisitionfile2");
} else if (head == "storage") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Storage")) variable.Value = ssENStorage; else variable.Optimized = true;
variable.SetFieldName("storage");
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
if (key == IdRequisitionContractFile) {
return ssENRequisitionContractFile;
}
if (key == IdRequisition) {
return ssENRequisition;
}
if (key == IdRequisitionFile2) {
return ssENRequisitionFile2;
}
if (key == IdStorage) {
return ssENStorage;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdRequisitionContractFile.Key.AsGuid) {
return ssENRequisitionContractFile;
}
if (attributeKey == IdRequisition.Key.AsGuid) {
return ssENRequisition;
}
if (attributeKey == IdRequisitionFile2.Key.AsGuid) {
return ssENRequisitionFile2;
}
if (attributeKey == IdStorage.Key.AsGuid) {
return ssENStorage;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENRequisitionContractFile.FillFromOther((IRecord) other.AttributeGet(IdRequisitionContractFile));
ssENRequisition.FillFromOther((IRecord) other.AttributeGet(IdRequisition));
ssENRequisitionFile2.FillFromOther((IRecord) other.AttributeGet(IdRequisitionFile2));
ssENStorage.FillFromOther((IRecord) other.AttributeGet(IdStorage));
}
} // RC_409326af30f6b67f1d011aa096c0a54e
/// <summary>
/// RecordList type <code>RequisitionContractFileRequisitionRequisitionFile2StorageRecordList</code>
///  that represents a record list of <code>RequisitionContractFile, Requisition, RequisitionFile2
/// , Storage</code>
/// </summary>
public partial class RL_4473325ccc2bbea6efef176371ffa07d : GenericRecordList<RC_409326af30f6b67f1d011aa096c0a54e>, IEnumerable, IEnumerator {

protected override RC_409326af30f6b67f1d011aa096c0a54e GetElementDefaultValue() {
return new RC_409326af30f6b67f1d011aa096c0a54e();
}

public T[] ToArray<T>(Func<RC_409326af30f6b67f1d011aa096c0a54e, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_4473325ccc2bbea6efef176371ffa07d recordList, Func<RC_409326af30f6b67f1d011aa096c0a54e, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_4473325ccc2bbea6efef176371ffa07d(RC_409326af30f6b67f1d011aa096c0a54e[] array) {
  RL_4473325ccc2bbea6efef176371ffa07d result = new RL_4473325ccc2bbea6efef176371ffa07d();
result.InnerFromArray(array);
    return result;
}

public static RL_4473325ccc2bbea6efef176371ffa07d ToList<T>(T[] array, Func <T, RC_409326af30f6b67f1d011aa096c0a54e> converter) {
  RL_4473325ccc2bbea6efef176371ffa07d result = new RL_4473325ccc2bbea6efef176371ffa07d();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_4473325ccc2bbea6efef176371ffa07d FromRestList<T>(RestList<T> restList, Func <T, RC_409326af30f6b67f1d011aa096c0a54e> converter) {
  RL_4473325ccc2bbea6efef176371ffa07d result = new RL_4473325ccc2bbea6efef176371ffa07d();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_4473325ccc2bbea6efef176371ffa07d() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[4];
def[0] = new BitArray(9,false);
def[1] = new BitArray(58,false);
def[2] = new BitArray(8,false);
def[3] = new BitArray(20,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_409326af30f6b67f1d011aa096c0a54e> NewList() {
return new RL_4473325ccc2bbea6efef176371ffa07d();
}


} // RL_4473325ccc2bbea6efef176371ffa07d
}

