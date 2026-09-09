namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (GfXHz7A8V0agrWE4CbHbfQ)
///  <code>RC_9fd4d8d4a1a7da3e37ee97c8163946e6</code> that represents <code>ApplicantRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: ApplicantRecord
public partial struct RC_9fd4d8d4a1a7da3e37ee97c8163946e6 : ITypedRecord<RC_9fd4d8d4a1a7da3e37ee97c8163946e6> {
internal static readonly GlobalObjectKey IdApplicant = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*1NjUn6ehPto37pfIFjlG5g");

public EN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord ssENApplicant;


public static implicit operator EN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord( RC_9fd4d8d4a1a7da3e37ee97c8163946e6 r) {
return r.ssENApplicant;
}

public static implicit operator RC_9fd4d8d4a1a7da3e37ee97c8163946e6 (EN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord r) {
RC_9fd4d8d4a1a7da3e37ee97c8163946e6 res = new RC_9fd4d8d4a1a7da3e37ee97c8163946e6 ();
res.ssENApplicant = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENApplicant.ChangedAttributes = value;
}
get {
    return ssENApplicant.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_9fd4d8d4a1a7da3e37ee97c8163946e6() {
OptimizedAttributes = null;
ssENApplicant = new EN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(8,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENApplicant.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENApplicant.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENApplicant.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENApplicant.Read( r, ref index);
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
public void ReadIM(RC_9fd4d8d4a1a7da3e37ee97c8163946e6 r) {
this = r;
}


public static bool operator == (RC_9fd4d8d4a1a7da3e37ee97c8163946e6 a, RC_9fd4d8d4a1a7da3e37ee97c8163946e6 b) {
if (a.ssENApplicant != b.ssENApplicant) return false;
return true;
}

public static bool operator != (RC_9fd4d8d4a1a7da3e37ee97c8163946e6 a, RC_9fd4d8d4a1a7da3e37ee97c8163946e6 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_9fd4d8d4a1a7da3e37ee97c8163946e6)) return false;
return (this == (RC_9fd4d8d4a1a7da3e37ee97c8163946e6)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENApplicant.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENApplicant.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENApplicant.InternalRecursiveSave();
}


public RC_9fd4d8d4a1a7da3e37ee97c8163946e6 Duplicate() {
RC_9fd4d8d4a1a7da3e37ee97c8163946e6 t;
t.ssENApplicant = (EN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord)this.ssENApplicant.Duplicate();
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
if (head == "applicant") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Applicant")) variable.Value = ssENApplicant; else variable.Optimized = true;
variable.SetFieldName("applicant");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENApplicant.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENApplicant.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdApplicant) {
return ssENApplicant;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdApplicant.Key.AsGuid) {
return ssENApplicant;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENApplicant.FillFromOther((IRecord) other.AttributeGet(IdApplicant));
}
} // RC_9fd4d8d4a1a7da3e37ee97c8163946e6
/// <summary>
/// RecordList type <code>ApplicantRecordList</code> that represents a record list of
///  <code>Applicant</code>
/// </summary>
public partial class RL_89fdc2de9b4f3c518b096795c532253b : GenericRecordList<RC_9fd4d8d4a1a7da3e37ee97c8163946e6>, IEnumerable, IEnumerator {

protected override RC_9fd4d8d4a1a7da3e37ee97c8163946e6 GetElementDefaultValue() {
return new RC_9fd4d8d4a1a7da3e37ee97c8163946e6();
}

public T[] ToArray<T>(Func<RC_9fd4d8d4a1a7da3e37ee97c8163946e6, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_89fdc2de9b4f3c518b096795c532253b recordList, Func<RC_9fd4d8d4a1a7da3e37ee97c8163946e6, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_89fdc2de9b4f3c518b096795c532253b(RC_9fd4d8d4a1a7da3e37ee97c8163946e6[] array) {
  RL_89fdc2de9b4f3c518b096795c532253b result = new RL_89fdc2de9b4f3c518b096795c532253b();
result.InnerFromArray(array);
    return result;
}

public static RL_89fdc2de9b4f3c518b096795c532253b ToList<T>(T[] array, Func <T, RC_9fd4d8d4a1a7da3e37ee97c8163946e6> converter) {
  RL_89fdc2de9b4f3c518b096795c532253b result = new RL_89fdc2de9b4f3c518b096795c532253b();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_89fdc2de9b4f3c518b096795c532253b FromRestList<T>(RestList<T> restList, Func <T, RC_9fd4d8d4a1a7da3e37ee97c8163946e6> converter) {
  RL_89fdc2de9b4f3c518b096795c532253b result = new RL_89fdc2de9b4f3c518b096795c532253b();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_89fdc2de9b4f3c518b096795c532253b() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(8,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_9fd4d8d4a1a7da3e37ee97c8163946e6> NewList() {
return new RL_89fdc2de9b4f3c518b096795c532253b();
}


} // RL_89fdc2de9b4f3c518b096795c532253b
}

