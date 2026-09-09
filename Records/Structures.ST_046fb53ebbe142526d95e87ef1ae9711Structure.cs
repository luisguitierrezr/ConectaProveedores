namespace ssConectaProveedores {
/// <summary>
/// [Structure] Output (0eZp2XtySEmsFH0wQ4jFlQ)
///  <code>ST_046fb53ebbe142526d95e87ef1ae9711Structure</code> that represents <code>Output</code
/// > <p>Description: Output Result Struct.</p>
/// </summary>
// Name: Output
public partial struct ST_046fb53ebbe142526d95e87ef1ae9711Structure : ITypedRecord<ST_046fb53ebbe142526d95e87ef1ae9711Structure> {
internal static readonly GlobalObjectKey IdIsSuccess = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*nqEGq6R9uk+IP4QPzWLH1g");
internal static readonly GlobalObjectKey IdMessage = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*XYQmf94JwEOOUqaYV6Ts5g");
internal static readonly GlobalObjectKey IdLines = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*697dwV6xRUexaGvL+OSHFQ");

public bool ssIsSuccess;

public string ssMessage;

public int ssLines;


public BitArray OptimizedAttributes;

public ST_046fb53ebbe142526d95e87ef1ae9711Structure() {
OptimizedAttributes = null;
ssIsSuccess = false;
ssMessage = "";
ssLines = 0;
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
ssIsSuccess = r.ReadBoolean(index++, "Output.IsSuccess", false);
ssMessage = r.ReadText(index++, "Output.Message", "");
ssLines = r.ReadInteger(index++, "Output.Lines", 0);
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
public void ReadIM(ST_046fb53ebbe142526d95e87ef1ae9711Structure r) {
this = r;
}


public static bool operator == (ST_046fb53ebbe142526d95e87ef1ae9711Structure a, ST_046fb53ebbe142526d95e87ef1ae9711Structure b) {
if (a.ssIsSuccess != b.ssIsSuccess) return false;
if (a.ssMessage != b.ssMessage) return false;
if (a.ssLines != b.ssLines) return false;
return true;
}

public static bool operator != (ST_046fb53ebbe142526d95e87ef1ae9711Structure a, ST_046fb53ebbe142526d95e87ef1ae9711Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_046fb53ebbe142526d95e87ef1ae9711Structure)) return false;
return (this == (ST_046fb53ebbe142526d95e87ef1ae9711Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssIsSuccess.GetHashCode()
 ^ ssMessage.GetHashCode()
 ^ ssLines.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_046fb53ebbe142526d95e87ef1ae9711Structure Duplicate() {
ST_046fb53ebbe142526d95e87ef1ae9711Structure t;
t.ssIsSuccess = this.ssIsSuccess;
t.ssMessage = this.ssMessage;
t.ssLines = this.ssLines;
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
} else if (head == "message") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Message")) variable.Value = ssMessage; else variable.Optimized = true;
} else if (head == "lines") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Lines")) variable.Value = ssLines; else variable.Optimized = true;
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
if (key == IdMessage) {
return ssMessage;
}
if (key == IdLines) {
return ssLines;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdIsSuccess.Key.AsGuid) {
return ssIsSuccess;
}
if (attributeKey == IdMessage.Key.AsGuid) {
return ssMessage;
}
if (attributeKey == IdLines.Key.AsGuid) {
return ssLines;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssIsSuccess = (bool) other.AttributeGet(IdIsSuccess);
ssMessage = (string) other.AttributeGet(IdMessage);
ssLines = (int) other.AttributeGet(IdLines);
}
} // ST_046fb53ebbe142526d95e87ef1ae9711Structure
/// <summary>
/// RecordList type <code>OutputList</code> that represents a record list of <code>Output</code>
/// </summary>
public partial class RL_404fc9590c6ea4efcd18f6effa0ea6ac : GenericRecordList<ST_046fb53ebbe142526d95e87ef1ae9711Structure>, IEnumerable, IEnumerator {

protected override ST_046fb53ebbe142526d95e87ef1ae9711Structure GetElementDefaultValue() {
return new ST_046fb53ebbe142526d95e87ef1ae9711Structure();
}

public T[] ToArray<T>(Func<ST_046fb53ebbe142526d95e87ef1ae9711Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_404fc9590c6ea4efcd18f6effa0ea6ac recordList, Func<ST_046fb53ebbe142526d95e87ef1ae9711Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_404fc9590c6ea4efcd18f6effa0ea6ac(ST_046fb53ebbe142526d95e87ef1ae9711Structure[] array) {
  RL_404fc9590c6ea4efcd18f6effa0ea6ac result = new RL_404fc9590c6ea4efcd18f6effa0ea6ac();
result.InnerFromArray(array);
    return result;
}

public static RL_404fc9590c6ea4efcd18f6effa0ea6ac ToList<T>(T[] array, Func <T, ST_046fb53ebbe142526d95e87ef1ae9711Structure> converter) {
  RL_404fc9590c6ea4efcd18f6effa0ea6ac result = new RL_404fc9590c6ea4efcd18f6effa0ea6ac();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_404fc9590c6ea4efcd18f6effa0ea6ac FromRestList<T>(RestList<T> restList, Func <T, ST_046fb53ebbe142526d95e87ef1ae9711Structure> converter) {
  RL_404fc9590c6ea4efcd18f6effa0ea6ac result = new RL_404fc9590c6ea4efcd18f6effa0ea6ac();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_404fc9590c6ea4efcd18f6effa0ea6ac() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_046fb53ebbe142526d95e87ef1ae9711Structure> NewList() {
return new RL_404fc9590c6ea4efcd18f6effa0ea6ac();
}


} // RL_404fc9590c6ea4efcd18f6effa0ea6ac
}

