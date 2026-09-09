namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (Uz9Rr2KioU2zICN91rGtCg)
///  <code>RC_fba480f5c1b92eb8b15d33020b0023b5</code> that represent
/// s <code>OrderAccConceptsPaymentTermsAdvancePaymentTypeRecord</code> <p>Description: </p>
/// </summary>
// Name: OrderAccConceptsPaymentTermsAdvancePaymentTypeRecord
public partial struct RC_fba480f5c1b92eb8b15d33020b0023b5 : ITypedRecord<RC_fba480f5c1b92eb8b15d33020b0023b5> {
internal static readonly GlobalObjectKey IdOrderAccConcepts = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*GWia3F+CiO7roBGSrpsYkA");
internal static readonly GlobalObjectKey IdPaymentTerms = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*sbomVZepvUCHDd5qabo9mg");
internal static readonly GlobalObjectKey IdAdvancePaymentType = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*MfVdutcHlpayd1JW0hvdYg");

public EN_3e07a23619060cc7dc5624548803f5fdEntityRecord ssENOrderAccConcepts;

public EN_17720044fda96c0c2d8d0760c429f48aEntityRecord ssENPaymentTerms;

public EN_485b44f219737098b3b1029e90069935EntityRecord ssENAdvancePaymentType;


public BitArray OptimizedAttributes;

public RC_fba480f5c1b92eb8b15d33020b0023b5() {
OptimizedAttributes = null;
ssENOrderAccConcepts = new EN_3e07a23619060cc7dc5624548803f5fdEntityRecord();
ssENPaymentTerms = new EN_17720044fda96c0c2d8d0760c429f48aEntityRecord();
ssENAdvancePaymentType = new EN_485b44f219737098b3b1029e90069935EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = new BitArray(14,false);
    all[1] = new BitArray(11,false);
    all[2] = new BitArray(4,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENOrderAccConcepts.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENPaymentTerms.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENAdvancePaymentType.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    }else{
    ssENOrderAccConcepts.OptimizedAttributes = value[0];
    ssENPaymentTerms.OptimizedAttributes = value[1];
    ssENAdvancePaymentType.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = ssENOrderAccConcepts.OptimizedAttributes;
    all[1] = ssENPaymentTerms.OptimizedAttributes;
    all[2] = ssENAdvancePaymentType.OptimizedAttributes;
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
ssENAdvancePaymentType.Read( r, ref index);
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
public void ReadIM(RC_fba480f5c1b92eb8b15d33020b0023b5 r) {
this = r;
}


public static bool operator == (RC_fba480f5c1b92eb8b15d33020b0023b5 a, RC_fba480f5c1b92eb8b15d33020b0023b5 b) {
if (a.ssENOrderAccConcepts != b.ssENOrderAccConcepts) return false;
if (a.ssENPaymentTerms != b.ssENPaymentTerms) return false;
if (a.ssENAdvancePaymentType != b.ssENAdvancePaymentType) return false;
return true;
}

public static bool operator != (RC_fba480f5c1b92eb8b15d33020b0023b5 a, RC_fba480f5c1b92eb8b15d33020b0023b5 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_fba480f5c1b92eb8b15d33020b0023b5)) return false;
return (this == (RC_fba480f5c1b92eb8b15d33020b0023b5)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENOrderAccConcepts.GetHashCode()
 ^ ssENPaymentTerms.GetHashCode()
 ^ ssENAdvancePaymentType.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENOrderAccConcepts.RecursiveReset();
ssENPaymentTerms.RecursiveReset();
ssENAdvancePaymentType.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENOrderAccConcepts.InternalRecursiveSave();
ssENPaymentTerms.InternalRecursiveSave();
ssENAdvancePaymentType.InternalRecursiveSave();
}


public RC_fba480f5c1b92eb8b15d33020b0023b5 Duplicate() {
RC_fba480f5c1b92eb8b15d33020b0023b5 t;
t.ssENOrderAccConcepts = (EN_3e07a23619060cc7dc5624548803f5fdEntityRecord)this.ssENOrderAccConcepts.Duplicate();
t.ssENPaymentTerms = (EN_17720044fda96c0c2d8d0760c429f48aEntityRecord)this.ssENPaymentTerms.Duplicate();
t.ssENAdvancePaymentType = (EN_485b44f219737098b3b1029e90069935EntityRecord)this.ssENAdvancePaymentType.Duplicate();
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
} else if (head == "advancepaymenttype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AdvancePaymentType")) variable.Value = ssENAdvancePaymentType; else variable.Optimized = true;
variable.SetFieldName("advancepaymenttype");
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
if (key == IdAdvancePaymentType) {
return ssENAdvancePaymentType;
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
if (attributeKey == IdAdvancePaymentType.Key.AsGuid) {
return ssENAdvancePaymentType;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENOrderAccConcepts.FillFromOther((IRecord) other.AttributeGet(IdOrderAccConcepts));
ssENPaymentTerms.FillFromOther((IRecord) other.AttributeGet(IdPaymentTerms));
ssENAdvancePaymentType.FillFromOther((IRecord) other.AttributeGet(IdAdvancePaymentType));
}
} // RC_fba480f5c1b92eb8b15d33020b0023b5
/// <summary>
/// RecordList type <code>OrderAccConceptsPaymentTermsAdvancePaymentTypeRecordList</code> that
///  represents a record list of <code>OrderAccConcepts, PaymentTerms, AdvancePaymentType</code>
/// </summary>
public partial class RL_b323e0bdf1fec18079c1034e78738762 : GenericRecordList<RC_fba480f5c1b92eb8b15d33020b0023b5>, IEnumerable, IEnumerator {

protected override RC_fba480f5c1b92eb8b15d33020b0023b5 GetElementDefaultValue() {
return new RC_fba480f5c1b92eb8b15d33020b0023b5();
}

public T[] ToArray<T>(Func<RC_fba480f5c1b92eb8b15d33020b0023b5, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_b323e0bdf1fec18079c1034e78738762 recordList, Func<RC_fba480f5c1b92eb8b15d33020b0023b5, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_b323e0bdf1fec18079c1034e78738762(RC_fba480f5c1b92eb8b15d33020b0023b5[] array) {
  RL_b323e0bdf1fec18079c1034e78738762 result = new RL_b323e0bdf1fec18079c1034e78738762();
result.InnerFromArray(array);
    return result;
}

public static RL_b323e0bdf1fec18079c1034e78738762 ToList<T>(T[] array, Func <T, RC_fba480f5c1b92eb8b15d33020b0023b5> converter) {
  RL_b323e0bdf1fec18079c1034e78738762 result = new RL_b323e0bdf1fec18079c1034e78738762();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_b323e0bdf1fec18079c1034e78738762 FromRestList<T>(RestList<T> restList, Func <T, RC_fba480f5c1b92eb8b15d33020b0023b5> converter) {
  RL_b323e0bdf1fec18079c1034e78738762 result = new RL_b323e0bdf1fec18079c1034e78738762();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_b323e0bdf1fec18079c1034e78738762() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = new BitArray(14,false);
def[1] = new BitArray(11,false);
def[2] = new BitArray(4,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_fba480f5c1b92eb8b15d33020b0023b5> NewList() {
return new RL_b323e0bdf1fec18079c1034e78738762();
}


} // RL_b323e0bdf1fec18079c1034e78738762
}

