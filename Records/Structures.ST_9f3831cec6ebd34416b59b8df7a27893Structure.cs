namespace ssConectaProveedores {
/// <summary>
/// [Structure] ActionResult (QjVkX8b8zUi41bEDtAt3wA)
///  <code>ST_9f3831cec6ebd34416b59b8df7a27893Structure</code> that represents <code>ActionResult</code
/// > <p>Description: </p>
/// </summary>
// Name: ActionResult
public partial struct ST_9f3831cec6ebd34416b59b8df7a27893Structure : ITypedRecord<ST_9f3831cec6ebd34416b59b8df7a27893Structure> {
internal static readonly GlobalObjectKey IdIdentifier = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*lkLBEXwS+k6TtJW8j2qBJg");
internal static readonly GlobalObjectKey IdHasSuccess = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*MT0Kq+hyxUC4NtSA85MSiQ");
internal static readonly GlobalObjectKey IdErrorMessage = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*fsiDGBo9+ku12JOzumyfAw");

public long ssIdentifier;

public bool ssHasSuccess;

public string ssErrorMessage;


public BitArray OptimizedAttributes;

public ST_9f3831cec6ebd34416b59b8df7a27893Structure() {
OptimizedAttributes = null;
ssIdentifier = 0L;
ssHasSuccess = false;
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
ssIdentifier = r.ReadLongInteger(index++, "ActionResult.Identifier", 0L);
ssHasSuccess = r.ReadBoolean(index++, "ActionResult.HasSuccess", false);
ssErrorMessage = r.ReadText(index++, "ActionResult.ErrorMessage", "");
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
public void ReadIM(ST_9f3831cec6ebd34416b59b8df7a27893Structure r) {
this = r;
}


public static bool operator == (ST_9f3831cec6ebd34416b59b8df7a27893Structure a, ST_9f3831cec6ebd34416b59b8df7a27893Structure b) {
if (a.ssIdentifier != b.ssIdentifier) return false;
if (a.ssHasSuccess != b.ssHasSuccess) return false;
if (a.ssErrorMessage != b.ssErrorMessage) return false;
return true;
}

public static bool operator != (ST_9f3831cec6ebd34416b59b8df7a27893Structure a, ST_9f3831cec6ebd34416b59b8df7a27893Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_9f3831cec6ebd34416b59b8df7a27893Structure)) return false;
return (this == (ST_9f3831cec6ebd34416b59b8df7a27893Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssIdentifier.GetHashCode()
 ^ ssHasSuccess.GetHashCode()
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


public ST_9f3831cec6ebd34416b59b8df7a27893Structure Duplicate() {
ST_9f3831cec6ebd34416b59b8df7a27893Structure t;
t.ssIdentifier = this.ssIdentifier;
t.ssHasSuccess = this.ssHasSuccess;
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
if (head == "identifier") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Identifier")) variable.Value = ssIdentifier; else variable.Optimized = true;
} else if (head == "hassuccess") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".HasSuccess")) variable.Value = ssHasSuccess; else variable.Optimized = true;
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
if (key == IdIdentifier) {
return ssIdentifier;
}
if (key == IdHasSuccess) {
return ssHasSuccess;
}
if (key == IdErrorMessage) {
return ssErrorMessage;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdIdentifier.Key.AsGuid) {
return ssIdentifier;
}
if (attributeKey == IdHasSuccess.Key.AsGuid) {
return ssHasSuccess;
}
if (attributeKey == IdErrorMessage.Key.AsGuid) {
return ssErrorMessage;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssIdentifier = (long) other.AttributeGet(IdIdentifier);
ssHasSuccess = (bool) other.AttributeGet(IdHasSuccess);
ssErrorMessage = (string) other.AttributeGet(IdErrorMessage);
}
} // ST_9f3831cec6ebd34416b59b8df7a27893Structure
/// <summary>
/// RecordList type <code>ActionResultList</code> that represents a record list of
///  <code>ActionResult</code>
/// </summary>
public partial class RL_464351fbd5b8aae5aca0c9b198a4f759 : GenericRecordList<ST_9f3831cec6ebd34416b59b8df7a27893Structure>, IEnumerable, IEnumerator {

protected override ST_9f3831cec6ebd34416b59b8df7a27893Structure GetElementDefaultValue() {
return new ST_9f3831cec6ebd34416b59b8df7a27893Structure();
}

public T[] ToArray<T>(Func<ST_9f3831cec6ebd34416b59b8df7a27893Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_464351fbd5b8aae5aca0c9b198a4f759 recordList, Func<ST_9f3831cec6ebd34416b59b8df7a27893Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_464351fbd5b8aae5aca0c9b198a4f759(ST_9f3831cec6ebd34416b59b8df7a27893Structure[] array) {
  RL_464351fbd5b8aae5aca0c9b198a4f759 result = new RL_464351fbd5b8aae5aca0c9b198a4f759();
result.InnerFromArray(array);
    return result;
}

public static RL_464351fbd5b8aae5aca0c9b198a4f759 ToList<T>(T[] array, Func <T, ST_9f3831cec6ebd34416b59b8df7a27893Structure> converter) {
  RL_464351fbd5b8aae5aca0c9b198a4f759 result = new RL_464351fbd5b8aae5aca0c9b198a4f759();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_464351fbd5b8aae5aca0c9b198a4f759 FromRestList<T>(RestList<T> restList, Func <T, ST_9f3831cec6ebd34416b59b8df7a27893Structure> converter) {
  RL_464351fbd5b8aae5aca0c9b198a4f759 result = new RL_464351fbd5b8aae5aca0c9b198a4f759();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_464351fbd5b8aae5aca0c9b198a4f759() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_9f3831cec6ebd34416b59b8df7a27893Structure> NewList() {
return new RL_464351fbd5b8aae5aca0c9b198a4f759();
}


} // RL_464351fbd5b8aae5aca0c9b198a4f759
}

