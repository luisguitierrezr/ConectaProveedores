namespace ssConectaProveedores {
/// <summary>
/// [ReferenceStructure] ErrorMessage2 (020_41jNrEu+ok6TuHL8AQ)
///  <code>ST_50c794173b7ac3485b1cda7be99f6b43Structure</code> that represent
/// s <code>ErrorMessage2</code> <p>Description: Return message from actions.</p>
/// </summary>
// Name: ErrorMessage2
public partial struct ST_50c794173b7ac3485b1cda7be99f6b43Structure : ITypedRecord<ST_50c794173b7ac3485b1cda7be99f6b43Structure> {
internal static readonly GlobalObjectKey IdCode = GlobalObjectKey.Parse("Iw63OPxQEEeAzzaCqdyZig*wAufbNTkqkWFaEbDgzo+sQ");
internal static readonly GlobalObjectKey IdMessage = GlobalObjectKey.Parse("Iw63OPxQEEeAzzaCqdyZig*bmieR8LcJkGVx18OpO6L1w");

public string ssCode;

public string ssMessage;


public BitArray OptimizedAttributes;

public ST_50c794173b7ac3485b1cda7be99f6b43Structure() {
OptimizedAttributes = null;
ssCode = "";
ssMessage = "";
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
ssCode = r.ReadText(index++, "ErrorMessage2.Code", "");
ssMessage = r.ReadText(index++, "ErrorMessage2.Message", "");
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
public void ReadIM(ST_50c794173b7ac3485b1cda7be99f6b43Structure r) {
this = r;
}


public static bool operator == (ST_50c794173b7ac3485b1cda7be99f6b43Structure a, ST_50c794173b7ac3485b1cda7be99f6b43Structure b) {
if (a.ssCode != b.ssCode) return false;
if (a.ssMessage != b.ssMessage) return false;
return true;
}

public static bool operator != (ST_50c794173b7ac3485b1cda7be99f6b43Structure a, ST_50c794173b7ac3485b1cda7be99f6b43Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_50c794173b7ac3485b1cda7be99f6b43Structure)) return false;
return (this == (ST_50c794173b7ac3485b1cda7be99f6b43Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssCode.GetHashCode()
 ^ ssMessage.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_50c794173b7ac3485b1cda7be99f6b43Structure Duplicate() {
ST_50c794173b7ac3485b1cda7be99f6b43Structure t;
t.ssCode = this.ssCode;
t.ssMessage = this.ssMessage;
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
if (head == "code") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Code")) variable.Value = ssCode; else variable.Optimized = true;
} else if (head == "message") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Message")) variable.Value = ssMessage; else variable.Optimized = true;
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
if (key == IdCode) {
return ssCode;
}
if (key == IdMessage) {
return ssMessage;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdCode.Key.AsGuid) {
return ssCode;
}
if (attributeKey == IdMessage.Key.AsGuid) {
return ssMessage;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssCode = (string) other.AttributeGet(IdCode);
ssMessage = (string) other.AttributeGet(IdMessage);
}
} // ST_50c794173b7ac3485b1cda7be99f6b43Structure
/// <summary>
/// RecordList type <code>ErrorMessage2List</code> that represents a record list of
///  <code>ErrorMessage2</code>
/// </summary>
public partial class RL_703486673ab24a9404041e6c3c485947 : GenericRecordList<ST_50c794173b7ac3485b1cda7be99f6b43Structure>, IEnumerable, IEnumerator {

protected override ST_50c794173b7ac3485b1cda7be99f6b43Structure GetElementDefaultValue() {
return new ST_50c794173b7ac3485b1cda7be99f6b43Structure();
}

public T[] ToArray<T>(Func<ST_50c794173b7ac3485b1cda7be99f6b43Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_703486673ab24a9404041e6c3c485947 recordList, Func<ST_50c794173b7ac3485b1cda7be99f6b43Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_703486673ab24a9404041e6c3c485947(ST_50c794173b7ac3485b1cda7be99f6b43Structure[] array) {
  RL_703486673ab24a9404041e6c3c485947 result = new RL_703486673ab24a9404041e6c3c485947();
result.InnerFromArray(array);
    return result;
}

public static RL_703486673ab24a9404041e6c3c485947 ToList<T>(T[] array, Func <T, ST_50c794173b7ac3485b1cda7be99f6b43Structure> converter) {
  RL_703486673ab24a9404041e6c3c485947 result = new RL_703486673ab24a9404041e6c3c485947();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_703486673ab24a9404041e6c3c485947 FromRestList<T>(RestList<T> restList, Func <T, ST_50c794173b7ac3485b1cda7be99f6b43Structure> converter) {
  RL_703486673ab24a9404041e6c3c485947 result = new RL_703486673ab24a9404041e6c3c485947();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_703486673ab24a9404041e6c3c485947() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_50c794173b7ac3485b1cda7be99f6b43Structure> NewList() {
return new RL_703486673ab24a9404041e6c3c485947();
}


} // RL_703486673ab24a9404041e6c3c485947
}

