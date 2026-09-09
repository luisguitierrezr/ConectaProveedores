namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (AfMxlXUGBEOvWb4pwfn3Jg)
///  <code>RC_e458ee413a96cac672bdf352274f2a60</code> that represents <code>OutputRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: OutputRecord
public partial struct RC_e458ee413a96cac672bdf352274f2a60 : ITypedRecord<RC_e458ee413a96cac672bdf352274f2a60> {
internal static readonly GlobalObjectKey IdOutput = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Qe5Y5JY6xspyvfNSJ08qYA");

public ST_046fb53ebbe142526d95e87ef1ae9711Structure ssSTOutput;


public static implicit operator ST_046fb53ebbe142526d95e87ef1ae9711Structure( RC_e458ee413a96cac672bdf352274f2a60 r) {
return r.ssSTOutput;
}

public static implicit operator RC_e458ee413a96cac672bdf352274f2a60 (ST_046fb53ebbe142526d95e87ef1ae9711Structure r) {
RC_e458ee413a96cac672bdf352274f2a60 res = new RC_e458ee413a96cac672bdf352274f2a60 ();
res.ssSTOutput = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_e458ee413a96cac672bdf352274f2a60() {
OptimizedAttributes = null;
ssSTOutput = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    ssSTOutput.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssSTOutput.Read( r, ref index);
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
public void ReadIM(RC_e458ee413a96cac672bdf352274f2a60 r) {
this = r;
}


public static bool operator == (RC_e458ee413a96cac672bdf352274f2a60 a, RC_e458ee413a96cac672bdf352274f2a60 b) {
if (a.ssSTOutput != b.ssSTOutput) return false;
return true;
}

public static bool operator != (RC_e458ee413a96cac672bdf352274f2a60 a, RC_e458ee413a96cac672bdf352274f2a60 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_e458ee413a96cac672bdf352274f2a60)) return false;
return (this == (RC_e458ee413a96cac672bdf352274f2a60)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTOutput.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTOutput.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTOutput.InternalRecursiveSave();
}


public RC_e458ee413a96cac672bdf352274f2a60 Duplicate() {
RC_e458ee413a96cac672bdf352274f2a60 t;
t.ssSTOutput = (ST_046fb53ebbe142526d95e87ef1ae9711Structure)this.ssSTOutput.Duplicate();
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
if (head == "output") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Output")) variable.Value = ssSTOutput; else variable.Optimized = true;
variable.SetFieldName("output");
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
if (key == IdOutput) {
return ssSTOutput;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOutput.Key.AsGuid) {
return ssSTOutput;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTOutput.FillFromOther((IRecord) other.AttributeGet(IdOutput));
}
} // RC_e458ee413a96cac672bdf352274f2a60
/// <summary>
/// RecordList type <code>OutputRecordList</code> that represents a record list of <code>Output</code>
/// </summary>
public partial class RL_1818fd3de304c2879fb630b9ae00c404 : GenericRecordList<RC_e458ee413a96cac672bdf352274f2a60>, IEnumerable, IEnumerator {

protected override RC_e458ee413a96cac672bdf352274f2a60 GetElementDefaultValue() {
return new RC_e458ee413a96cac672bdf352274f2a60();
}

public T[] ToArray<T>(Func<RC_e458ee413a96cac672bdf352274f2a60, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_1818fd3de304c2879fb630b9ae00c404 recordList, Func<RC_e458ee413a96cac672bdf352274f2a60, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_1818fd3de304c2879fb630b9ae00c404(RC_e458ee413a96cac672bdf352274f2a60[] array) {
  RL_1818fd3de304c2879fb630b9ae00c404 result = new RL_1818fd3de304c2879fb630b9ae00c404();
result.InnerFromArray(array);
    return result;
}

public static RL_1818fd3de304c2879fb630b9ae00c404 ToList<T>(T[] array, Func <T, RC_e458ee413a96cac672bdf352274f2a60> converter) {
  RL_1818fd3de304c2879fb630b9ae00c404 result = new RL_1818fd3de304c2879fb630b9ae00c404();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_1818fd3de304c2879fb630b9ae00c404 FromRestList<T>(RestList<T> restList, Func <T, RC_e458ee413a96cac672bdf352274f2a60> converter) {
  RL_1818fd3de304c2879fb630b9ae00c404 result = new RL_1818fd3de304c2879fb630b9ae00c404();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_1818fd3de304c2879fb630b9ae00c404() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = null;
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_e458ee413a96cac672bdf352274f2a60> NewList() {
return new RL_1818fd3de304c2879fb630b9ae00c404();
}


} // RL_1818fd3de304c2879fb630b9ae00c404
}

