namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (rKq4YhtZfUyDIhw4eQzd8w)
///  <code>RC_a10c541c5bb512cec4a0951b15921126</code> that represent
/// s <code>OrderAccConceptsPaymentTermsRecord</code> <p>Description: </p>
/// </summary>
// Name: OrderAccConceptsPaymentTermsRecord
public partial struct RC_a10c541c5bb512cec4a0951b15921126 : ITypedRecord<RC_a10c541c5bb512cec4a0951b15921126> {
internal static readonly GlobalObjectKey IdOrderAccConcepts = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*GWia3F+CiO7roBGSrpsYkA");
internal static readonly GlobalObjectKey IdPaymentTerms = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*sbomVZepvUCHDd5qabo9mg");

public EN_3e07a23619060cc7dc5624548803f5fdEntityRecord ssENOrderAccConcepts;

public EN_17720044fda96c0c2d8d0760c429f48aEntityRecord ssENPaymentTerms;


public BitArray OptimizedAttributes;

public RC_a10c541c5bb512cec4a0951b15921126() {
OptimizedAttributes = null;
ssENOrderAccConcepts = new EN_3e07a23619060cc7dc5624548803f5fdEntityRecord();
ssENPaymentTerms = new EN_17720044fda96c0c2d8d0760c429f48aEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(14,false);
    all[1] = new BitArray(11,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENOrderAccConcepts.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENPaymentTerms.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENOrderAccConcepts.OptimizedAttributes = value[0];
    ssENPaymentTerms.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENOrderAccConcepts.OptimizedAttributes;
    all[1] = ssENPaymentTerms.OptimizedAttributes;
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
ssENPaymentTerms.Read( r, ref index);
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
public void ReadIM(RC_a10c541c5bb512cec4a0951b15921126 r) {
this = r;
}


public static bool operator == (RC_a10c541c5bb512cec4a0951b15921126 a, RC_a10c541c5bb512cec4a0951b15921126 b) {
if (a.ssENOrderAccConcepts != b.ssENOrderAccConcepts) return false;
if (a.ssENPaymentTerms != b.ssENPaymentTerms) return false;
return true;
}

public static bool operator != (RC_a10c541c5bb512cec4a0951b15921126 a, RC_a10c541c5bb512cec4a0951b15921126 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_a10c541c5bb512cec4a0951b15921126)) return false;
return (this == (RC_a10c541c5bb512cec4a0951b15921126)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENOrderAccConcepts.GetHashCode()
 ^ ssENPaymentTerms.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENOrderAccConcepts.RecursiveReset();
ssENPaymentTerms.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENOrderAccConcepts.InternalRecursiveSave();
ssENPaymentTerms.InternalRecursiveSave();
}


public RC_a10c541c5bb512cec4a0951b15921126 Duplicate() {
RC_a10c541c5bb512cec4a0951b15921126 t;
t.ssENOrderAccConcepts = (EN_3e07a23619060cc7dc5624548803f5fdEntityRecord)this.ssENOrderAccConcepts.Duplicate();
t.ssENPaymentTerms = (EN_17720044fda96c0c2d8d0760c429f48aEntityRecord)this.ssENPaymentTerms.Duplicate();
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
} else if (head == "paymentterms") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PaymentTerms")) variable.Value = ssENPaymentTerms; else variable.Optimized = true;
variable.SetFieldName("paymentterms");
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
if (key == IdPaymentTerms) {
return ssENPaymentTerms;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderAccConcepts.Key.AsGuid) {
return ssENOrderAccConcepts;
}
if (attributeKey == IdPaymentTerms.Key.AsGuid) {
return ssENPaymentTerms;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENOrderAccConcepts.FillFromOther((IRecord) other.AttributeGet(IdOrderAccConcepts));
ssENPaymentTerms.FillFromOther((IRecord) other.AttributeGet(IdPaymentTerms));
}
} // RC_a10c541c5bb512cec4a0951b15921126
/// <summary>
/// RecordList type <code>OrderAccConceptsPaymentTermsRecordList</code> that represents a record list
///  of <code>OrderAccConcepts, PaymentTerms</code>
/// </summary>
public partial class RL_cc70186cbf781c90043dce30d28664ab : GenericRecordList<RC_a10c541c5bb512cec4a0951b15921126>, IEnumerable, IEnumerator {

protected override RC_a10c541c5bb512cec4a0951b15921126 GetElementDefaultValue() {
return new RC_a10c541c5bb512cec4a0951b15921126();
}

public T[] ToArray<T>(Func<RC_a10c541c5bb512cec4a0951b15921126, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_cc70186cbf781c90043dce30d28664ab recordList, Func<RC_a10c541c5bb512cec4a0951b15921126, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_cc70186cbf781c90043dce30d28664ab(RC_a10c541c5bb512cec4a0951b15921126[] array) {
  RL_cc70186cbf781c90043dce30d28664ab result = new RL_cc70186cbf781c90043dce30d28664ab();
result.InnerFromArray(array);
    return result;
}

public static RL_cc70186cbf781c90043dce30d28664ab ToList<T>(T[] array, Func <T, RC_a10c541c5bb512cec4a0951b15921126> converter) {
  RL_cc70186cbf781c90043dce30d28664ab result = new RL_cc70186cbf781c90043dce30d28664ab();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_cc70186cbf781c90043dce30d28664ab FromRestList<T>(RestList<T> restList, Func <T, RC_a10c541c5bb512cec4a0951b15921126> converter) {
  RL_cc70186cbf781c90043dce30d28664ab result = new RL_cc70186cbf781c90043dce30d28664ab();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_cc70186cbf781c90043dce30d28664ab() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(14,false);
def[1] = new BitArray(11,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_a10c541c5bb512cec4a0951b15921126> NewList() {
return new RL_cc70186cbf781c90043dce30d28664ab();
}


} // RL_cc70186cbf781c90043dce30d28664ab
}

