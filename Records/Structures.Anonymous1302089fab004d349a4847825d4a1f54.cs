namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (nwgCEwCrNE2aSEeCXUofVA)
///  <code>RC_ea3a117956fd50e1901759909d3fbc2f</code> that represent
/// s <code>OrderAccConceptsAccountingDataTypeRecord</code> <p>Description: </p>
/// </summary>
// Name: OrderAccConceptsAccountingDataTypeRecord
public partial struct RC_ea3a117956fd50e1901759909d3fbc2f : ITypedRecord<RC_ea3a117956fd50e1901759909d3fbc2f> {
internal static readonly GlobalObjectKey IdOrderAccConcepts = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*GWia3F+CiO7roBGSrpsYkA");
internal static readonly GlobalObjectKey IdAccountingDataType = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*etEiohArUeXSV_ovWJJJnA");

public EN_3e07a23619060cc7dc5624548803f5fdEntityRecord ssENOrderAccConcepts;

public EN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord ssENAccountingDataType;


public BitArray OptimizedAttributes;

public RC_ea3a117956fd50e1901759909d3fbc2f() {
OptimizedAttributes = null;
ssENOrderAccConcepts = new EN_3e07a23619060cc7dc5624548803f5fdEntityRecord();
ssENAccountingDataType = new EN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(14,false);
    all[1] = new BitArray(5,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENOrderAccConcepts.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENAccountingDataType.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENOrderAccConcepts.OptimizedAttributes = value[0];
    ssENAccountingDataType.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENOrderAccConcepts.OptimizedAttributes;
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
ssENOrderAccConcepts.Read( r, ref index);
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
public void ReadIM(RC_ea3a117956fd50e1901759909d3fbc2f r) {
this = r;
}


public static bool operator == (RC_ea3a117956fd50e1901759909d3fbc2f a, RC_ea3a117956fd50e1901759909d3fbc2f b) {
if (a.ssENOrderAccConcepts != b.ssENOrderAccConcepts) return false;
if (a.ssENAccountingDataType != b.ssENAccountingDataType) return false;
return true;
}

public static bool operator != (RC_ea3a117956fd50e1901759909d3fbc2f a, RC_ea3a117956fd50e1901759909d3fbc2f b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_ea3a117956fd50e1901759909d3fbc2f)) return false;
return (this == (RC_ea3a117956fd50e1901759909d3fbc2f)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENOrderAccConcepts.GetHashCode()
 ^ ssENAccountingDataType.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENOrderAccConcepts.RecursiveReset();
ssENAccountingDataType.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENOrderAccConcepts.InternalRecursiveSave();
ssENAccountingDataType.InternalRecursiveSave();
}


public RC_ea3a117956fd50e1901759909d3fbc2f Duplicate() {
RC_ea3a117956fd50e1901759909d3fbc2f t;
t.ssENOrderAccConcepts = (EN_3e07a23619060cc7dc5624548803f5fdEntityRecord)this.ssENOrderAccConcepts.Duplicate();
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
if (head == "orderaccconcepts") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderAccConcepts")) variable.Value = ssENOrderAccConcepts; else variable.Optimized = true;
variable.SetFieldName("orderaccconcepts");
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
if (key == IdOrderAccConcepts) {
return ssENOrderAccConcepts;
}
if (key == IdAccountingDataType) {
return ssENAccountingDataType;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderAccConcepts.Key.AsGuid) {
return ssENOrderAccConcepts;
}
if (attributeKey == IdAccountingDataType.Key.AsGuid) {
return ssENAccountingDataType;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENOrderAccConcepts.FillFromOther((IRecord) other.AttributeGet(IdOrderAccConcepts));
ssENAccountingDataType.FillFromOther((IRecord) other.AttributeGet(IdAccountingDataType));
}
} // RC_ea3a117956fd50e1901759909d3fbc2f
/// <summary>
/// RecordList type <code>OrderAccConceptsAccountingDataTypeRecordList</code> that represents a record
///  list of <code>OrderAccConcepts, AccountingDataType</code>
/// </summary>
public partial class RL_95d1f6e611a5505299d1e9919fa0d9e6 : GenericRecordList<RC_ea3a117956fd50e1901759909d3fbc2f>, IEnumerable, IEnumerator {

protected override RC_ea3a117956fd50e1901759909d3fbc2f GetElementDefaultValue() {
return new RC_ea3a117956fd50e1901759909d3fbc2f();
}

public T[] ToArray<T>(Func<RC_ea3a117956fd50e1901759909d3fbc2f, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_95d1f6e611a5505299d1e9919fa0d9e6 recordList, Func<RC_ea3a117956fd50e1901759909d3fbc2f, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_95d1f6e611a5505299d1e9919fa0d9e6(RC_ea3a117956fd50e1901759909d3fbc2f[] array) {
  RL_95d1f6e611a5505299d1e9919fa0d9e6 result = new RL_95d1f6e611a5505299d1e9919fa0d9e6();
result.InnerFromArray(array);
    return result;
}

public static RL_95d1f6e611a5505299d1e9919fa0d9e6 ToList<T>(T[] array, Func <T, RC_ea3a117956fd50e1901759909d3fbc2f> converter) {
  RL_95d1f6e611a5505299d1e9919fa0d9e6 result = new RL_95d1f6e611a5505299d1e9919fa0d9e6();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_95d1f6e611a5505299d1e9919fa0d9e6 FromRestList<T>(RestList<T> restList, Func <T, RC_ea3a117956fd50e1901759909d3fbc2f> converter) {
  RL_95d1f6e611a5505299d1e9919fa0d9e6 result = new RL_95d1f6e611a5505299d1e9919fa0d9e6();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_95d1f6e611a5505299d1e9919fa0d9e6() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(14,false);
def[1] = new BitArray(5,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_ea3a117956fd50e1901759909d3fbc2f> NewList() {
return new RL_95d1f6e611a5505299d1e9919fa0d9e6();
}


} // RL_95d1f6e611a5505299d1e9919fa0d9e6
}

