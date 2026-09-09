namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (NV+lejux6kqJhJ8NHL5sVw)
///  <code>RC_d44c83c6811c5993da31ecba331d9c39</code> that represent
/// s <code>RequisitionRequisitionAccountingRecord</code> <p>Description: </p>
/// </summary>
// Name: RequisitionRequisitionAccountingRecord
public partial struct RC_d44c83c6811c5993da31ecba331d9c39 : ITypedRecord<RC_d44c83c6811c5993da31ecba331d9c39> {
internal static readonly GlobalObjectKey IdRequisition = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*T3SBu1iqc67nzY23TLMhVQ");
internal static readonly GlobalObjectKey IdRequisitionAccounting = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*bnJgWEJBKbtzubqI0xdGXw");

public EN_98680591dcf3728e0877a90eb5e1e552EntityRecord ssENRequisition;

public EN_3554712eb61e9f0a2132c551df0f1db5EntityRecord ssENRequisitionAccounting;


public BitArray OptimizedAttributes;

public RC_d44c83c6811c5993da31ecba331d9c39() {
OptimizedAttributes = null;
ssENRequisition = new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord();
ssENRequisitionAccounting = new EN_3554712eb61e9f0a2132c551df0f1db5EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(58,false);
    all[1] = new BitArray(19,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENRequisition.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENRequisitionAccounting.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENRequisition.OptimizedAttributes = value[0];
    ssENRequisitionAccounting.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENRequisition.OptimizedAttributes;
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
ssENRequisition.Read( r, ref index);
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
public void ReadIM(RC_d44c83c6811c5993da31ecba331d9c39 r) {
this = r;
}


public static bool operator == (RC_d44c83c6811c5993da31ecba331d9c39 a, RC_d44c83c6811c5993da31ecba331d9c39 b) {
if (a.ssENRequisition != b.ssENRequisition) return false;
if (a.ssENRequisitionAccounting != b.ssENRequisitionAccounting) return false;
return true;
}

public static bool operator != (RC_d44c83c6811c5993da31ecba331d9c39 a, RC_d44c83c6811c5993da31ecba331d9c39 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_d44c83c6811c5993da31ecba331d9c39)) return false;
return (this == (RC_d44c83c6811c5993da31ecba331d9c39)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENRequisition.GetHashCode()
 ^ ssENRequisitionAccounting.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENRequisition.RecursiveReset();
ssENRequisitionAccounting.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENRequisition.InternalRecursiveSave();
ssENRequisitionAccounting.InternalRecursiveSave();
}


public RC_d44c83c6811c5993da31ecba331d9c39 Duplicate() {
RC_d44c83c6811c5993da31ecba331d9c39 t;
t.ssENRequisition = (EN_98680591dcf3728e0877a90eb5e1e552EntityRecord)this.ssENRequisition.Duplicate();
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
if (head == "requisition") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Requisition")) variable.Value = ssENRequisition; else variable.Optimized = true;
variable.SetFieldName("requisition");
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
if (key == IdRequisition) {
return ssENRequisition;
}
if (key == IdRequisitionAccounting) {
return ssENRequisitionAccounting;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdRequisition.Key.AsGuid) {
return ssENRequisition;
}
if (attributeKey == IdRequisitionAccounting.Key.AsGuid) {
return ssENRequisitionAccounting;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENRequisition.FillFromOther((IRecord) other.AttributeGet(IdRequisition));
ssENRequisitionAccounting.FillFromOther((IRecord) other.AttributeGet(IdRequisitionAccounting));
}
} // RC_d44c83c6811c5993da31ecba331d9c39
/// <summary>
/// RecordList type <code>RequisitionRequisitionAccountingRecordList</code> that represents a record
///  list of <code>Requisition, RequisitionAccounting</code>
/// </summary>
public partial class RL_d6ebb6c8f3290a2a99c3f2feed622ea6 : GenericRecordList<RC_d44c83c6811c5993da31ecba331d9c39>, IEnumerable, IEnumerator {

protected override RC_d44c83c6811c5993da31ecba331d9c39 GetElementDefaultValue() {
return new RC_d44c83c6811c5993da31ecba331d9c39();
}

public T[] ToArray<T>(Func<RC_d44c83c6811c5993da31ecba331d9c39, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_d6ebb6c8f3290a2a99c3f2feed622ea6 recordList, Func<RC_d44c83c6811c5993da31ecba331d9c39, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_d6ebb6c8f3290a2a99c3f2feed622ea6(RC_d44c83c6811c5993da31ecba331d9c39[] array) {
  RL_d6ebb6c8f3290a2a99c3f2feed622ea6 result = new RL_d6ebb6c8f3290a2a99c3f2feed622ea6();
result.InnerFromArray(array);
    return result;
}

public static RL_d6ebb6c8f3290a2a99c3f2feed622ea6 ToList<T>(T[] array, Func <T, RC_d44c83c6811c5993da31ecba331d9c39> converter) {
  RL_d6ebb6c8f3290a2a99c3f2feed622ea6 result = new RL_d6ebb6c8f3290a2a99c3f2feed622ea6();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_d6ebb6c8f3290a2a99c3f2feed622ea6 FromRestList<T>(RestList<T> restList, Func <T, RC_d44c83c6811c5993da31ecba331d9c39> converter) {
  RL_d6ebb6c8f3290a2a99c3f2feed622ea6 result = new RL_d6ebb6c8f3290a2a99c3f2feed622ea6();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_d6ebb6c8f3290a2a99c3f2feed622ea6() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(58,false);
def[1] = new BitArray(19,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_d44c83c6811c5993da31ecba331d9c39> NewList() {
return new RL_d6ebb6c8f3290a2a99c3f2feed622ea6();
}


} // RL_d6ebb6c8f3290a2a99c3f2feed622ea6
}

