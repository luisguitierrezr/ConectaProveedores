namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (KYan0oL9cEOecs3Y5WldSQ)
///  <code>RC_dd1ef552e394be88b7a9660ce51d9447</code> that represent
/// s <code>MainAccConceptsSubAccConceptsRecord</code> <p>Description: </p>
/// </summary>
// Name: MainAccConceptsSubAccConceptsRecord
public partial struct RC_dd1ef552e394be88b7a9660ce51d9447 : ITypedRecord<RC_dd1ef552e394be88b7a9660ce51d9447> {
internal static readonly GlobalObjectKey IdMainAccConcepts = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*KZobp79E1af90D8cppTSHg");
internal static readonly GlobalObjectKey IdSubAccConcepts = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*du2201dacYLBLoHbcAVwGQ");

public EN_3e07a23619060cc7dc5624548803f5fdEntityRecord ssENMainAccConcepts;

public RL_8927ac1c2e0370738b28382fb988b5ee ssRLSubAccConcepts;


public BitArray OptimizedAttributes;

public RC_dd1ef552e394be88b7a9660ce51d9447() {
OptimizedAttributes = null;
ssENMainAccConcepts = new EN_3e07a23619060cc7dc5624548803f5fdEntityRecord();
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
    ssENMainAccConcepts.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENMainAccConcepts.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENMainAccConcepts.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENMainAccConcepts.Read( r, ref index);
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
public void ReadIM(RC_dd1ef552e394be88b7a9660ce51d9447 r) {
this = r;
}


public static bool operator == (RC_dd1ef552e394be88b7a9660ce51d9447 a, RC_dd1ef552e394be88b7a9660ce51d9447 b) {
if (a.ssENMainAccConcepts != b.ssENMainAccConcepts) return false;
if (a.ssRLSubAccConcepts != b.ssRLSubAccConcepts) return false;
return true;
}

public static bool operator != (RC_dd1ef552e394be88b7a9660ce51d9447 a, RC_dd1ef552e394be88b7a9660ce51d9447 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_dd1ef552e394be88b7a9660ce51d9447)) return false;
return (this == (RC_dd1ef552e394be88b7a9660ce51d9447)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENMainAccConcepts.GetHashCode()
 ^ ssRLSubAccConcepts.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENMainAccConcepts.RecursiveReset();
ssRLSubAccConcepts.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENMainAccConcepts.InternalRecursiveSave();
ssRLSubAccConcepts.InternalRecursiveSave();
}


public RC_dd1ef552e394be88b7a9660ce51d9447 Duplicate() {
RC_dd1ef552e394be88b7a9660ce51d9447 t;
t.ssENMainAccConcepts = (EN_3e07a23619060cc7dc5624548803f5fdEntityRecord)this.ssENMainAccConcepts.Duplicate();
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
if (head == "mainaccconcepts") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MainAccConcepts")) variable.Value = ssENMainAccConcepts; else variable.Optimized = true;
variable.SetFieldName("mainaccconcepts");
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
if (key == IdMainAccConcepts) {
return ssENMainAccConcepts;
}
if (key == IdSubAccConcepts) {
return ssRLSubAccConcepts;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdMainAccConcepts.Key.AsGuid) {
return ssENMainAccConcepts;
}
if (attributeKey == IdSubAccConcepts.Key.AsGuid) {
return ssRLSubAccConcepts;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENMainAccConcepts.FillFromOther((IRecord) other.AttributeGet(IdMainAccConcepts));
ssRLSubAccConcepts = new RL_8927ac1c2e0370738b28382fb988b5ee();
ssRLSubAccConcepts.FillFromOther((IOSList) other.AttributeGet(IdSubAccConcepts));
}
} // RC_dd1ef552e394be88b7a9660ce51d9447
/// <summary>
/// RecordList type <code>MainAccConceptsSubAccConceptsRecordList</code> that represents a record list
///  of <code>OrderAccConcepts, OrderAccConceptsList</code>
/// </summary>
public partial class RL_ff0f575584588c39e711f9bba221fbf6 : GenericRecordList<RC_dd1ef552e394be88b7a9660ce51d9447>, IEnumerable, IEnumerator {

protected override RC_dd1ef552e394be88b7a9660ce51d9447 GetElementDefaultValue() {
return new RC_dd1ef552e394be88b7a9660ce51d9447();
}

public T[] ToArray<T>(Func<RC_dd1ef552e394be88b7a9660ce51d9447, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_ff0f575584588c39e711f9bba221fbf6 recordList, Func<RC_dd1ef552e394be88b7a9660ce51d9447, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_ff0f575584588c39e711f9bba221fbf6(RC_dd1ef552e394be88b7a9660ce51d9447[] array) {
  RL_ff0f575584588c39e711f9bba221fbf6 result = new RL_ff0f575584588c39e711f9bba221fbf6();
result.InnerFromArray(array);
    return result;
}

public static RL_ff0f575584588c39e711f9bba221fbf6 ToList<T>(T[] array, Func <T, RC_dd1ef552e394be88b7a9660ce51d9447> converter) {
  RL_ff0f575584588c39e711f9bba221fbf6 result = new RL_ff0f575584588c39e711f9bba221fbf6();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_ff0f575584588c39e711f9bba221fbf6 FromRestList<T>(RestList<T> restList, Func <T, RC_dd1ef552e394be88b7a9660ce51d9447> converter) {
  RL_ff0f575584588c39e711f9bba221fbf6 result = new RL_ff0f575584588c39e711f9bba221fbf6();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_ff0f575584588c39e711f9bba221fbf6() : base() {
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
protected override OSList<RC_dd1ef552e394be88b7a9660ce51d9447> NewList() {
return new RL_ff0f575584588c39e711f9bba221fbf6();
}


} // RL_ff0f575584588c39e711f9bba221fbf6
}

