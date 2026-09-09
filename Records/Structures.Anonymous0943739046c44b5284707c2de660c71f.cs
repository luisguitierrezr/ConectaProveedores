namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (kHNDCcRGUkuEcHwt5mDHHw)
///  <code>RC_6b7fc732cea9431ac6d7f95245acde2b</code> that represent
/// s <code>RequisitionAccConceptsRequisitionAccountingRecord</code> <p>Description: </p>
/// </summary>
// Name: RequisitionAccConceptsRequisitionAccountingRecord
public partial struct RC_6b7fc732cea9431ac6d7f95245acde2b : ITypedRecord<RC_6b7fc732cea9431ac6d7f95245acde2b> {
internal static readonly GlobalObjectKey IdRequisitionAccConcepts = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Jkk74+wcAv4kn9D19X9dvA");
internal static readonly GlobalObjectKey IdRequisitionAccounting = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*bnJgWEJBKbtzubqI0xdGXw");

public EN_e5ff66566e5f431d75aae3b3535726a7EntityRecord ssENRequisitionAccConcepts;

public EN_3554712eb61e9f0a2132c551df0f1db5EntityRecord ssENRequisitionAccounting;


public BitArray OptimizedAttributes;

public RC_6b7fc732cea9431ac6d7f95245acde2b() {
OptimizedAttributes = null;
ssENRequisitionAccConcepts = new EN_e5ff66566e5f431d75aae3b3535726a7EntityRecord();
ssENRequisitionAccounting = new EN_3554712eb61e9f0a2132c551df0f1db5EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(8,false);
    all[1] = new BitArray(19,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENRequisitionAccConcepts.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENRequisitionAccounting.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENRequisitionAccConcepts.OptimizedAttributes = value[0];
    ssENRequisitionAccounting.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENRequisitionAccConcepts.OptimizedAttributes;
    all[1] = ssENRequisitionAccounting.OptimizedAttributes;
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
ssENRequisitionAccounting.Read( r, ref index);
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
public void ReadIM(RC_6b7fc732cea9431ac6d7f95245acde2b r) {
this = r;
}


public static bool operator == (RC_6b7fc732cea9431ac6d7f95245acde2b a, RC_6b7fc732cea9431ac6d7f95245acde2b b) {
if (a.ssENRequisitionAccConcepts != b.ssENRequisitionAccConcepts) return false;
if (a.ssENRequisitionAccounting != b.ssENRequisitionAccounting) return false;
return true;
}

public static bool operator != (RC_6b7fc732cea9431ac6d7f95245acde2b a, RC_6b7fc732cea9431ac6d7f95245acde2b b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_6b7fc732cea9431ac6d7f95245acde2b)) return false;
return (this == (RC_6b7fc732cea9431ac6d7f95245acde2b)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENRequisitionAccConcepts.GetHashCode()
 ^ ssENRequisitionAccounting.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENRequisitionAccConcepts.RecursiveReset();
ssENRequisitionAccounting.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENRequisitionAccConcepts.InternalRecursiveSave();
ssENRequisitionAccounting.InternalRecursiveSave();
}


public RC_6b7fc732cea9431ac6d7f95245acde2b Duplicate() {
RC_6b7fc732cea9431ac6d7f95245acde2b t;
t.ssENRequisitionAccConcepts = (EN_e5ff66566e5f431d75aae3b3535726a7EntityRecord)this.ssENRequisitionAccConcepts.Duplicate();
t.ssENRequisitionAccounting = (EN_3554712eb61e9f0a2132c551df0f1db5EntityRecord)this.ssENRequisitionAccounting.Duplicate();
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
} else if (head == "requisitionaccounting") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionAccounting")) variable.Value = ssENRequisitionAccounting; else variable.Optimized = true;
variable.SetFieldName("requisitionaccounting");
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
if (key == IdRequisitionAccounting) {
return ssENRequisitionAccounting;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdRequisitionAccConcepts.Key.AsGuid) {
return ssENRequisitionAccConcepts;
}
if (attributeKey == IdRequisitionAccounting.Key.AsGuid) {
return ssENRequisitionAccounting;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENRequisitionAccConcepts.FillFromOther((IRecord) other.AttributeGet(IdRequisitionAccConcepts));
ssENRequisitionAccounting.FillFromOther((IRecord) other.AttributeGet(IdRequisitionAccounting));
}
} // RC_6b7fc732cea9431ac6d7f95245acde2b
/// <summary>
/// RecordList type <code>RequisitionAccConceptsRequisitionAccountingRecordList</code> that represents
///  a record list of <code>RequisitionAccConcepts, RequisitionAccounting</code>
/// </summary>
public partial class RL_9913d30c00d0b2d8d5501344f1ce9ceb : GenericRecordList<RC_6b7fc732cea9431ac6d7f95245acde2b>, IEnumerable, IEnumerator {

protected override RC_6b7fc732cea9431ac6d7f95245acde2b GetElementDefaultValue() {
return new RC_6b7fc732cea9431ac6d7f95245acde2b();
}

public T[] ToArray<T>(Func<RC_6b7fc732cea9431ac6d7f95245acde2b, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_9913d30c00d0b2d8d5501344f1ce9ceb recordList, Func<RC_6b7fc732cea9431ac6d7f95245acde2b, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_9913d30c00d0b2d8d5501344f1ce9ceb(RC_6b7fc732cea9431ac6d7f95245acde2b[] array) {
  RL_9913d30c00d0b2d8d5501344f1ce9ceb result = new RL_9913d30c00d0b2d8d5501344f1ce9ceb();
result.InnerFromArray(array);
    return result;
}

public static RL_9913d30c00d0b2d8d5501344f1ce9ceb ToList<T>(T[] array, Func <T, RC_6b7fc732cea9431ac6d7f95245acde2b> converter) {
  RL_9913d30c00d0b2d8d5501344f1ce9ceb result = new RL_9913d30c00d0b2d8d5501344f1ce9ceb();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_9913d30c00d0b2d8d5501344f1ce9ceb FromRestList<T>(RestList<T> restList, Func <T, RC_6b7fc732cea9431ac6d7f95245acde2b> converter) {
  RL_9913d30c00d0b2d8d5501344f1ce9ceb result = new RL_9913d30c00d0b2d8d5501344f1ce9ceb();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_9913d30c00d0b2d8d5501344f1ce9ceb() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(8,false);
def[1] = new BitArray(19,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_6b7fc732cea9431ac6d7f95245acde2b> NewList() {
return new RL_9913d30c00d0b2d8d5501344f1ce9ceb();
}


} // RL_9913d30c00d0b2d8d5501344f1ce9ceb
}

