namespace ssConectaProveedores {
/// <summary>
/// [ReferenceStructure] Result (zXMZaK1baUeC0mUAeXgpuw)
///  <code>ST_38509e9fbd36a9b928c2f4e34a1342aeStructure</code> that represents <code>Result</code
/// > <p>Description: Result</p>
/// </summary>
// Name: Result
public partial struct ST_38509e9fbd36a9b928c2f4e34a1342aeStructure : ITypedRecord<ST_38509e9fbd36a9b928c2f4e34a1342aeStructure> {
internal static readonly GlobalObjectKey IdIsSuccess = GlobalObjectKey.Parse("fOFA5peUjUuSfOokWq1NWQ*mTwWdVKQaEGJ9dnfaxmWuw");
internal static readonly GlobalObjectKey IdErrorMessage = GlobalObjectKey.Parse("fOFA5peUjUuSfOokWq1NWQ*aCl+4NpjN0STqRENat55Jg");

public bool ssIsSuccess;

public string ssErrorMessage;


public BitArray OptimizedAttributes;

public ST_38509e9fbd36a9b928c2f4e34a1342aeStructure() {
OptimizedAttributes = null;
ssIsSuccess = false;
ssErrorMessage = "";
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[0];
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    }
}
get{
    BitArray[] all = new BitArray[0];
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssIsSuccess = r.ReadBoolean(index++, "Result.IsSuccess", false);
ssErrorMessage = r.ReadText(index++, "Result.ErrorMessage", "");
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
public void ReadIM(ST_38509e9fbd36a9b928c2f4e34a1342aeStructure r) {
this = r;
}


public static bool operator == (ST_38509e9fbd36a9b928c2f4e34a1342aeStructure a, ST_38509e9fbd36a9b928c2f4e34a1342aeStructure b) {
if (a.ssIsSuccess != b.ssIsSuccess) return false;
if (a.ssErrorMessage != b.ssErrorMessage) return false;
return true;
}

public static bool operator != (ST_38509e9fbd36a9b928c2f4e34a1342aeStructure a, ST_38509e9fbd36a9b928c2f4e34a1342aeStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_38509e9fbd36a9b928c2f4e34a1342aeStructure)) return false;
return (this == (ST_38509e9fbd36a9b928c2f4e34a1342aeStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssIsSuccess.GetHashCode()
 ^ ssErrorMessage.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_38509e9fbd36a9b928c2f4e34a1342aeStructure Duplicate() {
ST_38509e9fbd36a9b928c2f4e34a1342aeStructure t;
t.ssIsSuccess = this.ssIsSuccess;
t.ssErrorMessage = this.ssErrorMessage;
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
if (head == "issuccess") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsSuccess")) variable.Value = ssIsSuccess; else variable.Optimized = true;
} else if (head == "errormessage") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ErrorMessage")) variable.Value = ssErrorMessage; else variable.Optimized = true;
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
if (key == IdIsSuccess) {
return ssIsSuccess;
}
if (key == IdErrorMessage) {
return ssErrorMessage;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdIsSuccess.Key.AsGuid) {
return ssIsSuccess;
}
if (attributeKey == IdErrorMessage.Key.AsGuid) {
return ssErrorMessage;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssIsSuccess = (bool) other.AttributeGet(IdIsSuccess);
ssErrorMessage = (string) other.AttributeGet(IdErrorMessage);
}
} // ST_38509e9fbd36a9b928c2f4e34a1342aeStructure
/// <summary>
/// RecordList type <code>ResultList</code> that represents a record list of <code>Result</code>
/// </summary>
public partial class RL_4312ad0353c976455acb93781aebd48d : GenericRecordList<ST_38509e9fbd36a9b928c2f4e34a1342aeStructure>, IEnumerable, IEnumerator {

protected override ST_38509e9fbd36a9b928c2f4e34a1342aeStructure GetElementDefaultValue() {
return new ST_38509e9fbd36a9b928c2f4e34a1342aeStructure();
}

public T[] ToArray<T>(Func<ST_38509e9fbd36a9b928c2f4e34a1342aeStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_4312ad0353c976455acb93781aebd48d recordList, Func<ST_38509e9fbd36a9b928c2f4e34a1342aeStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_4312ad0353c976455acb93781aebd48d(ST_38509e9fbd36a9b928c2f4e34a1342aeStructure[] array) {
  RL_4312ad0353c976455acb93781aebd48d result = new RL_4312ad0353c976455acb93781aebd48d();
result.InnerFromArray(array);
    return result;
}

public static RL_4312ad0353c976455acb93781aebd48d ToList<T>(T[] array, Func <T, ST_38509e9fbd36a9b928c2f4e34a1342aeStructure> converter) {
  RL_4312ad0353c976455acb93781aebd48d result = new RL_4312ad0353c976455acb93781aebd48d();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_4312ad0353c976455acb93781aebd48d FromRestList<T>(RestList<T> restList, Func <T, ST_38509e9fbd36a9b928c2f4e34a1342aeStructure> converter) {
  RL_4312ad0353c976455acb93781aebd48d result = new RL_4312ad0353c976455acb93781aebd48d();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_4312ad0353c976455acb93781aebd48d() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_38509e9fbd36a9b928c2f4e34a1342aeStructure> NewList() {
return new RL_4312ad0353c976455acb93781aebd48d();
}


} // RL_4312ad0353c976455acb93781aebd48d
}

