namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (LefK7jexS0KF9rb5FMucyg)
///  <code>RC_b9bb40a47bdab047afc7e2a4a1fde846</code> that represent
/// s <code>RequisitionAccConceptsRequisitionRequisitionAccountingRequisitionFile2StorageRecord</code>
///  <p>Description: </p>
/// </summary>
// Name: RequisitionAccConceptsRequisitionRequisitionAccountingRequisitionFile2StorageRecord
public partial struct RC_b9bb40a47bdab047afc7e2a4a1fde846 : ITypedRecord<RC_b9bb40a47bdab047afc7e2a4a1fde846> {
internal static readonly GlobalObjectKey IdRequisitionAccConcepts = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Jkk74+wcAv4kn9D19X9dvA");
internal static readonly GlobalObjectKey IdRequisition = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*T3SBu1iqc67nzY23TLMhVQ");
internal static readonly GlobalObjectKey IdRequisitionAccounting = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*bnJgWEJBKbtzubqI0xdGXw");
internal static readonly GlobalObjectKey IdRequisitionFile2 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NbYPPv7ugJRU+nVCFUapAQ");
internal static readonly GlobalObjectKey IdStorage = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*k_HtsgKSfutg60mTSTiFFA");

public EN_e5ff66566e5f431d75aae3b3535726a7EntityRecord ssENRequisitionAccConcepts;

public EN_98680591dcf3728e0877a90eb5e1e552EntityRecord ssENRequisition;

public EN_3554712eb61e9f0a2132c551df0f1db5EntityRecord ssENRequisitionAccounting;

public EN_4cce425e15647f937e21de4e52849889EntityRecord ssENRequisitionFile2;

public EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord ssENStorage;


public BitArray OptimizedAttributes;

public RC_b9bb40a47bdab047afc7e2a4a1fde846() {
OptimizedAttributes = null;
ssENRequisitionAccConcepts = new EN_e5ff66566e5f431d75aae3b3535726a7EntityRecord();
ssENRequisition = new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord();
ssENRequisitionAccounting = new EN_3554712eb61e9f0a2132c551df0f1db5EntityRecord();
ssENRequisitionFile2 = new EN_4cce425e15647f937e21de4e52849889EntityRecord();
ssENStorage = new EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[5];
    all[0] = new BitArray(8,false);
    all[1] = new BitArray(58,false);
    all[2] = new BitArray(19,false);
    all[3] = new BitArray(8,false);
    all[4] = new BitArray(20,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENRequisitionAccConcepts.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENRequisition.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENRequisitionAccounting.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENRequisitionFile2.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENStorage.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    }else{
    ssENRequisitionAccConcepts.OptimizedAttributes = value[0];
    ssENRequisition.OptimizedAttributes = value[1];
    ssENRequisitionAccounting.OptimizedAttributes = value[2];
    ssENRequisitionFile2.OptimizedAttributes = value[3];
    ssENStorage.OptimizedAttributes = value[4];
    }
}
get{
    BitArray[] all = new BitArray[5];
    all[0] = ssENRequisitionAccConcepts.OptimizedAttributes;
    all[1] = ssENRequisition.OptimizedAttributes;
    all[2] = ssENRequisitionAccounting.OptimizedAttributes;
    all[3] = ssENRequisitionFile2.OptimizedAttributes;
    all[4] = ssENStorage.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENRequisitionAccConcepts.Read( r, ref index);
ssENRequisition.Read( r, ref index);
ssENRequisitionAccounting.Read( r, ref index);
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
public void ReadIM(RC_b9bb40a47bdab047afc7e2a4a1fde846 r) {
this = r;
}


public static bool operator == (RC_b9bb40a47bdab047afc7e2a4a1fde846 a, RC_b9bb40a47bdab047afc7e2a4a1fde846 b) {
if (a.ssENRequisitionAccConcepts != b.ssENRequisitionAccConcepts) return false;
if (a.ssENRequisition != b.ssENRequisition) return false;
if (a.ssENRequisitionAccounting != b.ssENRequisitionAccounting) return false;
if (a.ssENRequisitionFile2 != b.ssENRequisitionFile2) return false;
if (a.ssENStorage != b.ssENStorage) return false;
return true;
}

public static bool operator != (RC_b9bb40a47bdab047afc7e2a4a1fde846 a, RC_b9bb40a47bdab047afc7e2a4a1fde846 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_b9bb40a47bdab047afc7e2a4a1fde846)) return false;
return (this == (RC_b9bb40a47bdab047afc7e2a4a1fde846)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENRequisitionAccConcepts.GetHashCode()
 ^ ssENRequisition.GetHashCode()
 ^ ssENRequisitionAccounting.GetHashCode()
 ^ ssENRequisitionFile2.GetHashCode()
 ^ ssENStorage.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENRequisitionAccConcepts.RecursiveReset();
ssENRequisition.RecursiveReset();
ssENRequisitionAccounting.RecursiveReset();
ssENRequisitionFile2.RecursiveReset();
ssENStorage.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENRequisitionAccConcepts.InternalRecursiveSave();
ssENRequisition.InternalRecursiveSave();
ssENRequisitionAccounting.InternalRecursiveSave();
ssENRequisitionFile2.InternalRecursiveSave();
ssENStorage.InternalRecursiveSave();
}


public RC_b9bb40a47bdab047afc7e2a4a1fde846 Duplicate() {
RC_b9bb40a47bdab047afc7e2a4a1fde846 t;
t.ssENRequisitionAccConcepts = (EN_e5ff66566e5f431d75aae3b3535726a7EntityRecord)this.ssENRequisitionAccConcepts.Duplicate();
t.ssENRequisition = (EN_98680591dcf3728e0877a90eb5e1e552EntityRecord)this.ssENRequisition.Duplicate();
t.ssENRequisitionAccounting = (EN_3554712eb61e9f0a2132c551df0f1db5EntityRecord)this.ssENRequisitionAccounting.Duplicate();
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
if (head == "requisitionaccconcepts") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionAccConcepts")) variable.Value = ssENRequisitionAccConcepts; else variable.Optimized = true;
variable.SetFieldName("requisitionaccconcepts");
} else if (head == "requisition") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Requisition")) variable.Value = ssENRequisition; else variable.Optimized = true;
variable.SetFieldName("requisition");
} else if (head == "requisitionaccounting") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionAccounting")) variable.Value = ssENRequisitionAccounting; else variable.Optimized = true;
variable.SetFieldName("requisitionaccounting");
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
if (key == IdRequisitionAccConcepts) {
return ssENRequisitionAccConcepts;
}
if (key == IdRequisition) {
return ssENRequisition;
}
if (key == IdRequisitionAccounting) {
return ssENRequisitionAccounting;
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
if (attributeKey == IdRequisitionAccConcepts.Key.AsGuid) {
return ssENRequisitionAccConcepts;
}
if (attributeKey == IdRequisition.Key.AsGuid) {
return ssENRequisition;
}
if (attributeKey == IdRequisitionAccounting.Key.AsGuid) {
return ssENRequisitionAccounting;
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
ssENRequisitionAccConcepts.FillFromOther((IRecord) other.AttributeGet(IdRequisitionAccConcepts));
ssENRequisition.FillFromOther((IRecord) other.AttributeGet(IdRequisition));
ssENRequisitionAccounting.FillFromOther((IRecord) other.AttributeGet(IdRequisitionAccounting));
ssENRequisitionFile2.FillFromOther((IRecord) other.AttributeGet(IdRequisitionFile2));
ssENStorage.FillFromOther((IRecord) other.AttributeGet(IdStorage));
}
} // RC_b9bb40a47bdab047afc7e2a4a1fde846
/// <summary>
/// RecordList type
///  <code>RequisitionAccConceptsRequisitionRequisitionAccountingRequisitionFile2StorageRecordList</code
/// > that represents a record list of <code>RequisitionAccConcepts, Requisition,
///  RequisitionAccounting, RequisitionFile2, Storage</code>
/// </summary>
public partial class RL_e240e727d6462f6e07612213b516cdd1 : GenericRecordList<RC_b9bb40a47bdab047afc7e2a4a1fde846>, IEnumerable, IEnumerator {

protected override RC_b9bb40a47bdab047afc7e2a4a1fde846 GetElementDefaultValue() {
return new RC_b9bb40a47bdab047afc7e2a4a1fde846();
}

public T[] ToArray<T>(Func<RC_b9bb40a47bdab047afc7e2a4a1fde846, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e240e727d6462f6e07612213b516cdd1 recordList, Func<RC_b9bb40a47bdab047afc7e2a4a1fde846, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e240e727d6462f6e07612213b516cdd1(RC_b9bb40a47bdab047afc7e2a4a1fde846[] array) {
  RL_e240e727d6462f6e07612213b516cdd1 result = new RL_e240e727d6462f6e07612213b516cdd1();
result.InnerFromArray(array);
    return result;
}

public static RL_e240e727d6462f6e07612213b516cdd1 ToList<T>(T[] array, Func <T, RC_b9bb40a47bdab047afc7e2a4a1fde846> converter) {
  RL_e240e727d6462f6e07612213b516cdd1 result = new RL_e240e727d6462f6e07612213b516cdd1();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e240e727d6462f6e07612213b516cdd1 FromRestList<T>(RestList<T> restList, Func <T, RC_b9bb40a47bdab047afc7e2a4a1fde846> converter) {
  RL_e240e727d6462f6e07612213b516cdd1 result = new RL_e240e727d6462f6e07612213b516cdd1();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e240e727d6462f6e07612213b516cdd1() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[5];
def[0] = new BitArray(8,false);
def[1] = new BitArray(58,false);
def[2] = new BitArray(19,false);
def[3] = new BitArray(8,false);
def[4] = new BitArray(20,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_b9bb40a47bdab047afc7e2a4a1fde846> NewList() {
return new RL_e240e727d6462f6e07612213b516cdd1();
}


} // RL_e240e727d6462f6e07612213b516cdd1
}

