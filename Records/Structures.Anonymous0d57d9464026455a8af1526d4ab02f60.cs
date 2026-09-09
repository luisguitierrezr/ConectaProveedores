namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (RtlXDSZAWkWK8VJtSrAvYA)
///  <code>RC_9dc9d00c2e8dcb1797f7869ab9e5a7f9</code> that represent
/// s <code>MainAccConceptSubAccConceptsRecord</code> <p>Description: </p>
/// </summary>
// Name: MainAccConceptSubAccConceptsRecord
public partial struct RC_9dc9d00c2e8dcb1797f7869ab9e5a7f9 : ITypedRecord<RC_9dc9d00c2e8dcb1797f7869ab9e5a7f9> {
internal static readonly GlobalObjectKey IdMainAccConcept = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*llxJiUih7uddObCzW44NNg");
internal static readonly GlobalObjectKey IdSubAccConcepts = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*du2201dacYLBLoHbcAVwGQ");

public EN_3e07a23619060cc7dc5624548803f5fdEntityRecord ssENMainAccConcept;

public RL_8927ac1c2e0370738b28382fb988b5ee ssRLSubAccConcepts;


public BitArray OptimizedAttributes;

public RC_9dc9d00c2e8dcb1797f7869ab9e5a7f9() {
OptimizedAttributes = null;
ssENMainAccConcept = new EN_3e07a23619060cc7dc5624548803f5fdEntityRecord();
ssRLSubAccConcepts = new RL_8927ac1c2e0370738b28382fb988b5ee();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(14,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENMainAccConcept.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENMainAccConcept.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENMainAccConcept.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENMainAccConcept.Read( r, ref index);
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
public void ReadIM(RC_9dc9d00c2e8dcb1797f7869ab9e5a7f9 r) {
this = r;
}


public static bool operator == (RC_9dc9d00c2e8dcb1797f7869ab9e5a7f9 a, RC_9dc9d00c2e8dcb1797f7869ab9e5a7f9 b) {
if (a.ssENMainAccConcept != b.ssENMainAccConcept) return false;
if (a.ssRLSubAccConcepts != b.ssRLSubAccConcepts) return false;
return true;
}

public static bool operator != (RC_9dc9d00c2e8dcb1797f7869ab9e5a7f9 a, RC_9dc9d00c2e8dcb1797f7869ab9e5a7f9 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_9dc9d00c2e8dcb1797f7869ab9e5a7f9)) return false;
return (this == (RC_9dc9d00c2e8dcb1797f7869ab9e5a7f9)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENMainAccConcept.GetHashCode()
 ^ ssRLSubAccConcepts.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENMainAccConcept.RecursiveReset();
ssRLSubAccConcepts.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENMainAccConcept.InternalRecursiveSave();
ssRLSubAccConcepts.InternalRecursiveSave();
}


public RC_9dc9d00c2e8dcb1797f7869ab9e5a7f9 Duplicate() {
RC_9dc9d00c2e8dcb1797f7869ab9e5a7f9 t;
t.ssENMainAccConcept = (EN_3e07a23619060cc7dc5624548803f5fdEntityRecord)this.ssENMainAccConcept.Duplicate();
t.ssRLSubAccConcepts = (RL_8927ac1c2e0370738b28382fb988b5ee)this.ssRLSubAccConcepts.Duplicate();
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
if (head == "mainaccconcept") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MainAccConcept")) variable.Value = ssENMainAccConcept; else variable.Optimized = true;
variable.SetFieldName("mainaccconcept");
} else if (head == "subaccconcepts") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SubAccConcepts")) variable.Value = ssRLSubAccConcepts; else variable.Optimized = true;
variable.SetFieldName("subaccconcepts");
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
if (key == IdMainAccConcept) {
return ssENMainAccConcept;
}
if (key == IdSubAccConcepts) {
return ssRLSubAccConcepts;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdMainAccConcept.Key.AsGuid) {
return ssENMainAccConcept;
}
if (attributeKey == IdSubAccConcepts.Key.AsGuid) {
return ssRLSubAccConcepts;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENMainAccConcept.FillFromOther((IRecord) other.AttributeGet(IdMainAccConcept));
ssRLSubAccConcepts = new RL_8927ac1c2e0370738b28382fb988b5ee();
ssRLSubAccConcepts.FillFromOther((IOSList) other.AttributeGet(IdSubAccConcepts));
}
} // RC_9dc9d00c2e8dcb1797f7869ab9e5a7f9
/// <summary>
/// RecordList type <code>MainAccConceptSubAccConceptsRecordList</code> that represents a record list
///  of <code>OrderAccConcepts, OrderAccConceptsList</code>
/// </summary>
public partial class RL_67a9bd2efe4116e0951cc9d21cbd4329 : GenericRecordList<RC_9dc9d00c2e8dcb1797f7869ab9e5a7f9>, IEnumerable, IEnumerator {

protected override RC_9dc9d00c2e8dcb1797f7869ab9e5a7f9 GetElementDefaultValue() {
return new RC_9dc9d00c2e8dcb1797f7869ab9e5a7f9();
}

public T[] ToArray<T>(Func<RC_9dc9d00c2e8dcb1797f7869ab9e5a7f9, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_67a9bd2efe4116e0951cc9d21cbd4329 recordList, Func<RC_9dc9d00c2e8dcb1797f7869ab9e5a7f9, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_67a9bd2efe4116e0951cc9d21cbd4329(RC_9dc9d00c2e8dcb1797f7869ab9e5a7f9[] array) {
  RL_67a9bd2efe4116e0951cc9d21cbd4329 result = new RL_67a9bd2efe4116e0951cc9d21cbd4329();
result.InnerFromArray(array);
    return result;
}

public static RL_67a9bd2efe4116e0951cc9d21cbd4329 ToList<T>(T[] array, Func <T, RC_9dc9d00c2e8dcb1797f7869ab9e5a7f9> converter) {
  RL_67a9bd2efe4116e0951cc9d21cbd4329 result = new RL_67a9bd2efe4116e0951cc9d21cbd4329();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_67a9bd2efe4116e0951cc9d21cbd4329 FromRestList<T>(RestList<T> restList, Func <T, RC_9dc9d00c2e8dcb1797f7869ab9e5a7f9> converter) {
  RL_67a9bd2efe4116e0951cc9d21cbd4329 result = new RL_67a9bd2efe4116e0951cc9d21cbd4329();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_67a9bd2efe4116e0951cc9d21cbd4329() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(14,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_9dc9d00c2e8dcb1797f7869ab9e5a7f9> NewList() {
return new RL_67a9bd2efe4116e0951cc9d21cbd4329();
}


} // RL_67a9bd2efe4116e0951cc9d21cbd4329
}

