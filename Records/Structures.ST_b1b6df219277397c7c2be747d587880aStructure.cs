namespace ssConectaProveedores {
/// <summary>
/// [ReferenceStructure] Return (pCxo1f5EBUu4+0tSqFvNQg)
///  <code>ST_b1b6df219277397c7c2be747d587880aStructure</code> that represents <code>Return</code
/// > <p>Description: Return</p>
/// </summary>
// Name: Return
public partial struct ST_b1b6df219277397c7c2be747d587880aStructure : ITypedRecord<ST_b1b6df219277397c7c2be747d587880aStructure> {
internal static readonly GlobalObjectKey IdIsSuccess = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*qlM2i3enbUy_0TnIMdFuhA");
internal static readonly GlobalObjectKey IdMessage = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*sMmgaGWnrECo+aEkFUJd3w");

public bool ssIsSuccess;

public string ssMessage;


public BitArray OptimizedAttributes;

public ST_b1b6df219277397c7c2be747d587880aStructure() {
OptimizedAttributes = null;
ssIsSuccess = false;
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
ssIsSuccess = r.ReadBoolean(index++, "Return.IsSuccess", false);
ssMessage = r.ReadText(index++, "Return.Message", "");
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
public void ReadIM(ST_b1b6df219277397c7c2be747d587880aStructure r) {
this = r;
}


public static bool operator == (ST_b1b6df219277397c7c2be747d587880aStructure a, ST_b1b6df219277397c7c2be747d587880aStructure b) {
if (a.ssIsSuccess != b.ssIsSuccess) return false;
if (a.ssMessage != b.ssMessage) return false;
return true;
}

public static bool operator != (ST_b1b6df219277397c7c2be747d587880aStructure a, ST_b1b6df219277397c7c2be747d587880aStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_b1b6df219277397c7c2be747d587880aStructure)) return false;
return (this == (ST_b1b6df219277397c7c2be747d587880aStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssIsSuccess.GetHashCode()
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


public ST_b1b6df219277397c7c2be747d587880aStructure Duplicate() {
ST_b1b6df219277397c7c2be747d587880aStructure t;
t.ssIsSuccess = this.ssIsSuccess;
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
if (head == "issuccess") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsSuccess")) variable.Value = ssIsSuccess; else variable.Optimized = true;
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
if (key == IdIsSuccess) {
return ssIsSuccess;
}
if (key == IdMessage) {
return ssMessage;
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
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssIsSuccess = (bool) other.AttributeGet(IdIsSuccess);
ssMessage = (string) other.AttributeGet(IdMessage);
}
} // ST_b1b6df219277397c7c2be747d587880aStructure
/// <summary>
/// RecordList type <code>ReturnList</code> that represents a record list of <code>Return</code>
/// </summary>
public partial class RL_620010bbfacd36c945b5a32602fe1945 : GenericRecordList<ST_b1b6df219277397c7c2be747d587880aStructure>, IEnumerable, IEnumerator {

protected override ST_b1b6df219277397c7c2be747d587880aStructure GetElementDefaultValue() {
return new ST_b1b6df219277397c7c2be747d587880aStructure();
}

public T[] ToArray<T>(Func<ST_b1b6df219277397c7c2be747d587880aStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_620010bbfacd36c945b5a32602fe1945 recordList, Func<ST_b1b6df219277397c7c2be747d587880aStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_620010bbfacd36c945b5a32602fe1945(ST_b1b6df219277397c7c2be747d587880aStructure[] array) {
  RL_620010bbfacd36c945b5a32602fe1945 result = new RL_620010bbfacd36c945b5a32602fe1945();
result.InnerFromArray(array);
    return result;
}

public static RL_620010bbfacd36c945b5a32602fe1945 ToList<T>(T[] array, Func <T, ST_b1b6df219277397c7c2be747d587880aStructure> converter) {
  RL_620010bbfacd36c945b5a32602fe1945 result = new RL_620010bbfacd36c945b5a32602fe1945();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_620010bbfacd36c945b5a32602fe1945 FromRestList<T>(RestList<T> restList, Func <T, ST_b1b6df219277397c7c2be747d587880aStructure> converter) {
  RL_620010bbfacd36c945b5a32602fe1945 result = new RL_620010bbfacd36c945b5a32602fe1945();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_620010bbfacd36c945b5a32602fe1945() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_b1b6df219277397c7c2be747d587880aStructure> NewList() {
return new RL_620010bbfacd36c945b5a32602fe1945();
}


} // RL_620010bbfacd36c945b5a32602fe1945
}

