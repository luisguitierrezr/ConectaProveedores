namespace ssConectaProveedores {
/// <summary>
/// [ReferenceStructure] ErrorMessage (nG1WFyNv5UKxNZhvll_prA)
///  <code>ST_b7d405ca4407e572da091e54d07e3bd1Structure</code> that represents <code>ErrorMessage</code
/// > <p>Description: Return message from actions.</p>
/// </summary>
// Name: ErrorMessage
public partial struct ST_b7d405ca4407e572da091e54d07e3bd1Structure : ITypedRecord<ST_b7d405ca4407e572da091e54d07e3bd1Structure> {
internal static readonly GlobalObjectKey IdCode = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*s+PxsK7uE0aPy_at3hcuVQ");
internal static readonly GlobalObjectKey IdMessage = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*AhwodvxhyUa_yPOtBECOjw");

public string ssCode;

public string ssMessage;


public BitArray OptimizedAttributes;

public ST_b7d405ca4407e572da091e54d07e3bd1Structure() {
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
ssCode = r.ReadText(index++, "ErrorMessage.Code", "");
ssMessage = r.ReadText(index++, "ErrorMessage.Message", "");
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
public void ReadIM(ST_b7d405ca4407e572da091e54d07e3bd1Structure r) {
this = r;
}


public static bool operator == (ST_b7d405ca4407e572da091e54d07e3bd1Structure a, ST_b7d405ca4407e572da091e54d07e3bd1Structure b) {
if (a.ssCode != b.ssCode) return false;
if (a.ssMessage != b.ssMessage) return false;
return true;
}

public static bool operator != (ST_b7d405ca4407e572da091e54d07e3bd1Structure a, ST_b7d405ca4407e572da091e54d07e3bd1Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_b7d405ca4407e572da091e54d07e3bd1Structure)) return false;
return (this == (ST_b7d405ca4407e572da091e54d07e3bd1Structure)o);
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


public ST_b7d405ca4407e572da091e54d07e3bd1Structure Duplicate() {
ST_b7d405ca4407e572da091e54d07e3bd1Structure t;
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
} // ST_b7d405ca4407e572da091e54d07e3bd1Structure
/// <summary>
/// RecordList type <code>ErrorMessageList</code> that represents a record list of
///  <code>ErrorMessage</code>
/// </summary>
public partial class RL_478659cf4d50eb426ae425e9399ed35f : GenericRecordList<ST_b7d405ca4407e572da091e54d07e3bd1Structure>, IEnumerable, IEnumerator {

protected override ST_b7d405ca4407e572da091e54d07e3bd1Structure GetElementDefaultValue() {
return new ST_b7d405ca4407e572da091e54d07e3bd1Structure();
}

public T[] ToArray<T>(Func<ST_b7d405ca4407e572da091e54d07e3bd1Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_478659cf4d50eb426ae425e9399ed35f recordList, Func<ST_b7d405ca4407e572da091e54d07e3bd1Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_478659cf4d50eb426ae425e9399ed35f(ST_b7d405ca4407e572da091e54d07e3bd1Structure[] array) {
  RL_478659cf4d50eb426ae425e9399ed35f result = new RL_478659cf4d50eb426ae425e9399ed35f();
result.InnerFromArray(array);
    return result;
}

public static RL_478659cf4d50eb426ae425e9399ed35f ToList<T>(T[] array, Func <T, ST_b7d405ca4407e572da091e54d07e3bd1Structure> converter) {
  RL_478659cf4d50eb426ae425e9399ed35f result = new RL_478659cf4d50eb426ae425e9399ed35f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_478659cf4d50eb426ae425e9399ed35f FromRestList<T>(RestList<T> restList, Func <T, ST_b7d405ca4407e572da091e54d07e3bd1Structure> converter) {
  RL_478659cf4d50eb426ae425e9399ed35f result = new RL_478659cf4d50eb426ae425e9399ed35f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_478659cf4d50eb426ae425e9399ed35f() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_b7d405ca4407e572da091e54d07e3bd1Structure> NewList() {
return new RL_478659cf4d50eb426ae425e9399ed35f();
}


} // RL_478659cf4d50eb426ae425e9399ed35f
}

