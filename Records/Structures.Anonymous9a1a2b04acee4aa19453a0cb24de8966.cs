namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (BCsamu6soUqUU6DLJN6JZg)
///  <code>RC_4b3e229d9fe6ec886da8c5cf0d4be972</code> that represent
/// s <code>RequisitionRegionRecord</code> <p>Description: </p>
/// </summary>
// Name: RequisitionRegionRecord
public partial struct RC_4b3e229d9fe6ec886da8c5cf0d4be972 : ITypedRecord<RC_4b3e229d9fe6ec886da8c5cf0d4be972> {
internal static readonly GlobalObjectKey IdRequisition = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*T3SBu1iqc67nzY23TLMhVQ");
internal static readonly GlobalObjectKey IdRegion = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*w1243kBmkvqNrl3ySTBl0A");

public EN_98680591dcf3728e0877a90eb5e1e552EntityRecord ssENRequisition;

public EN_31f501c551d210017fcb34b5237e3390EntityRecord ssENRegion;


public BitArray OptimizedAttributes;

public RC_4b3e229d9fe6ec886da8c5cf0d4be972() {
OptimizedAttributes = null;
ssENRequisition = new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord();
ssENRegion = new EN_31f501c551d210017fcb34b5237e3390EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(58,false);
    all[1] = new BitArray(13,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENRequisition.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENRegion.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENRequisition.OptimizedAttributes = value[0];
    ssENRegion.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENRequisition.OptimizedAttributes;
    all[1] = ssENRegion.OptimizedAttributes;
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
ssENRegion.Read( r, ref index);
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
public void ReadIM(RC_4b3e229d9fe6ec886da8c5cf0d4be972 r) {
this = r;
}


public static bool operator == (RC_4b3e229d9fe6ec886da8c5cf0d4be972 a, RC_4b3e229d9fe6ec886da8c5cf0d4be972 b) {
if (a.ssENRequisition != b.ssENRequisition) return false;
if (a.ssENRegion != b.ssENRegion) return false;
return true;
}

public static bool operator != (RC_4b3e229d9fe6ec886da8c5cf0d4be972 a, RC_4b3e229d9fe6ec886da8c5cf0d4be972 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_4b3e229d9fe6ec886da8c5cf0d4be972)) return false;
return (this == (RC_4b3e229d9fe6ec886da8c5cf0d4be972)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENRequisition.GetHashCode()
 ^ ssENRegion.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENRequisition.RecursiveReset();
ssENRegion.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENRequisition.InternalRecursiveSave();
ssENRegion.InternalRecursiveSave();
}


public RC_4b3e229d9fe6ec886da8c5cf0d4be972 Duplicate() {
RC_4b3e229d9fe6ec886da8c5cf0d4be972 t;
t.ssENRequisition = (EN_98680591dcf3728e0877a90eb5e1e552EntityRecord)this.ssENRequisition.Duplicate();
t.ssENRegion = (EN_31f501c551d210017fcb34b5237e3390EntityRecord)this.ssENRegion.Duplicate();
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
} else if (head == "region") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Region")) variable.Value = ssENRegion; else variable.Optimized = true;
variable.SetFieldName("region");
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
if (key == IdRegion) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdRequisition.Key.AsGuid) {
return ssENRequisition;
}
if (attributeKey == IdRegion.Key.AsGuid) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENRequisition.FillFromOther((IRecord) other.AttributeGet(IdRequisition));
ssENRegion.FillFromOther((IRecord) other.AttributeGet(IdRegion));
}
} // RC_4b3e229d9fe6ec886da8c5cf0d4be972
/// <summary>
/// RecordList type <code>RequisitionRegionRecordList</code> that represents a record list of
///  <code>Requisition, Region</code>
/// </summary>
public partial class RL_b9a4d89a3154e989f9ae297e352963c3 : GenericRecordList<RC_4b3e229d9fe6ec886da8c5cf0d4be972>, IEnumerable, IEnumerator {

protected override RC_4b3e229d9fe6ec886da8c5cf0d4be972 GetElementDefaultValue() {
return new RC_4b3e229d9fe6ec886da8c5cf0d4be972();
}

public T[] ToArray<T>(Func<RC_4b3e229d9fe6ec886da8c5cf0d4be972, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_b9a4d89a3154e989f9ae297e352963c3 recordList, Func<RC_4b3e229d9fe6ec886da8c5cf0d4be972, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_b9a4d89a3154e989f9ae297e352963c3(RC_4b3e229d9fe6ec886da8c5cf0d4be972[] array) {
  RL_b9a4d89a3154e989f9ae297e352963c3 result = new RL_b9a4d89a3154e989f9ae297e352963c3();
result.InnerFromArray(array);
    return result;
}

public static RL_b9a4d89a3154e989f9ae297e352963c3 ToList<T>(T[] array, Func <T, RC_4b3e229d9fe6ec886da8c5cf0d4be972> converter) {
  RL_b9a4d89a3154e989f9ae297e352963c3 result = new RL_b9a4d89a3154e989f9ae297e352963c3();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_b9a4d89a3154e989f9ae297e352963c3 FromRestList<T>(RestList<T> restList, Func <T, RC_4b3e229d9fe6ec886da8c5cf0d4be972> converter) {
  RL_b9a4d89a3154e989f9ae297e352963c3 result = new RL_b9a4d89a3154e989f9ae297e352963c3();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_b9a4d89a3154e989f9ae297e352963c3() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(58,false);
def[1] = new BitArray(13,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_4b3e229d9fe6ec886da8c5cf0d4be972> NewList() {
return new RL_b9a4d89a3154e989f9ae297e352963c3();
}


} // RL_b9a4d89a3154e989f9ae297e352963c3
}

