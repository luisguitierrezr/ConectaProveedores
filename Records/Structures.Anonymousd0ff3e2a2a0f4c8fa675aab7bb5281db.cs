namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (Kj7_0A8qj0ymdaq3u1KB2w)
///  <code>RC_f80fde4acf9a7dc465a1d535c05dfb8e</code> that represent
/// s <code>RequisitionAccConceptsAccountingDataTypeRecord</code> <p>Description: </p>
/// </summary>
// Name: RequisitionAccConceptsAccountingDataTypeRecord
public partial struct RC_f80fde4acf9a7dc465a1d535c05dfb8e : ITypedRecord<RC_f80fde4acf9a7dc465a1d535c05dfb8e> {
internal static readonly GlobalObjectKey IdRequisitionAccConcepts = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Jkk74+wcAv4kn9D19X9dvA");
internal static readonly GlobalObjectKey IdAccountingDataType = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*etEiohArUeXSV_ovWJJJnA");

public EN_e5ff66566e5f431d75aae3b3535726a7EntityRecord ssENRequisitionAccConcepts;

public EN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord ssENAccountingDataType;


public BitArray OptimizedAttributes;

public RC_f80fde4acf9a7dc465a1d535c05dfb8e() {
OptimizedAttributes = null;
ssENRequisitionAccConcepts = new EN_e5ff66566e5f431d75aae3b3535726a7EntityRecord();
ssENAccountingDataType = new EN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(8,false);
    all[1] = new BitArray(5,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENRequisitionAccConcepts.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENAccountingDataType.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENRequisitionAccConcepts.OptimizedAttributes = value[0];
    ssENAccountingDataType.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENRequisitionAccConcepts.OptimizedAttributes;
    all[1] = ssENAccountingDataType.OptimizedAttributes;
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
ssENAccountingDataType.Read( r, ref index);
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
public void ReadIM(RC_f80fde4acf9a7dc465a1d535c05dfb8e r) {
this = r;
}


public static bool operator == (RC_f80fde4acf9a7dc465a1d535c05dfb8e a, RC_f80fde4acf9a7dc465a1d535c05dfb8e b) {
if (a.ssENRequisitionAccConcepts != b.ssENRequisitionAccConcepts) return false;
if (a.ssENAccountingDataType != b.ssENAccountingDataType) return false;
return true;
}

public static bool operator != (RC_f80fde4acf9a7dc465a1d535c05dfb8e a, RC_f80fde4acf9a7dc465a1d535c05dfb8e b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_f80fde4acf9a7dc465a1d535c05dfb8e)) return false;
return (this == (RC_f80fde4acf9a7dc465a1d535c05dfb8e)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENRequisitionAccConcepts.GetHashCode()
 ^ ssENAccountingDataType.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENRequisitionAccConcepts.RecursiveReset();
ssENAccountingDataType.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENRequisitionAccConcepts.InternalRecursiveSave();
ssENAccountingDataType.InternalRecursiveSave();
}


public RC_f80fde4acf9a7dc465a1d535c05dfb8e Duplicate() {
RC_f80fde4acf9a7dc465a1d535c05dfb8e t;
t.ssENRequisitionAccConcepts = (EN_e5ff66566e5f431d75aae3b3535726a7EntityRecord)this.ssENRequisitionAccConcepts.Duplicate();
t.ssENAccountingDataType = (EN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord)this.ssENAccountingDataType.Duplicate();
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
} else if (head == "accountingdatatype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AccountingDataType")) variable.Value = ssENAccountingDataType; else variable.Optimized = true;
variable.SetFieldName("accountingdatatype");
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
if (key == IdAccountingDataType) {
return ssENAccountingDataType;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdRequisitionAccConcepts.Key.AsGuid) {
return ssENRequisitionAccConcepts;
}
if (attributeKey == IdAccountingDataType.Key.AsGuid) {
return ssENAccountingDataType;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENRequisitionAccConcepts.FillFromOther((IRecord) other.AttributeGet(IdRequisitionAccConcepts));
ssENAccountingDataType.FillFromOther((IRecord) other.AttributeGet(IdAccountingDataType));
}
} // RC_f80fde4acf9a7dc465a1d535c05dfb8e
/// <summary>
/// RecordList type <code>RequisitionAccConceptsAccountingDataTypeRecordList</code> that represents a
///  record list of <code>RequisitionAccConcepts, AccountingDataType</code>
/// </summary>
public partial class RL_7c236018492d50b3625a5b0d981eb4eb : GenericRecordList<RC_f80fde4acf9a7dc465a1d535c05dfb8e>, IEnumerable, IEnumerator {

protected override RC_f80fde4acf9a7dc465a1d535c05dfb8e GetElementDefaultValue() {
return new RC_f80fde4acf9a7dc465a1d535c05dfb8e();
}

public T[] ToArray<T>(Func<RC_f80fde4acf9a7dc465a1d535c05dfb8e, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_7c236018492d50b3625a5b0d981eb4eb recordList, Func<RC_f80fde4acf9a7dc465a1d535c05dfb8e, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_7c236018492d50b3625a5b0d981eb4eb(RC_f80fde4acf9a7dc465a1d535c05dfb8e[] array) {
  RL_7c236018492d50b3625a5b0d981eb4eb result = new RL_7c236018492d50b3625a5b0d981eb4eb();
result.InnerFromArray(array);
    return result;
}

public static RL_7c236018492d50b3625a5b0d981eb4eb ToList<T>(T[] array, Func <T, RC_f80fde4acf9a7dc465a1d535c05dfb8e> converter) {
  RL_7c236018492d50b3625a5b0d981eb4eb result = new RL_7c236018492d50b3625a5b0d981eb4eb();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_7c236018492d50b3625a5b0d981eb4eb FromRestList<T>(RestList<T> restList, Func <T, RC_f80fde4acf9a7dc465a1d535c05dfb8e> converter) {
  RL_7c236018492d50b3625a5b0d981eb4eb result = new RL_7c236018492d50b3625a5b0d981eb4eb();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_7c236018492d50b3625a5b0d981eb4eb() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(8,false);
def[1] = new BitArray(5,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_f80fde4acf9a7dc465a1d535c05dfb8e> NewList() {
return new RL_7c236018492d50b3625a5b0d981eb4eb();
}


} // RL_7c236018492d50b3625a5b0d981eb4eb
}

