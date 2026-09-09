namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (_cYQdBrfa0mKQClWYWi2gg)
///  <code>RC_d32d3dec6fa4abe9694e52a298b9cce9</code> that represents <code>HTTPRequestRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: HTTPRequestRecord
public partial struct RC_d32d3dec6fa4abe9694e52a298b9cce9 : ITypedRecord<RC_d32d3dec6fa4abe9694e52a298b9cce9> {
internal static readonly GlobalObjectKey IdHTTPRequest = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*7D0t06Rv6atpTlKimLnM6Q");

public ST_ea2141f4206e3eb2cd0fdd847e008166Structure ssSTHTTPRequest;


public static implicit operator ST_ea2141f4206e3eb2cd0fdd847e008166Structure( RC_d32d3dec6fa4abe9694e52a298b9cce9 r) {
return r.ssSTHTTPRequest;
}

public static implicit operator RC_d32d3dec6fa4abe9694e52a298b9cce9 (ST_ea2141f4206e3eb2cd0fdd847e008166Structure r) {
RC_d32d3dec6fa4abe9694e52a298b9cce9 res = new RC_d32d3dec6fa4abe9694e52a298b9cce9 ();
res.ssSTHTTPRequest = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_d32d3dec6fa4abe9694e52a298b9cce9() {
OptimizedAttributes = null;
ssSTHTTPRequest = new ST_ea2141f4206e3eb2cd0fdd847e008166Structure();
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
    ssSTHTTPRequest.OptimizedAttributes = value[0];
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
ssSTHTTPRequest.Read( r, ref index);
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
public void ReadIM(RC_d32d3dec6fa4abe9694e52a298b9cce9 r) {
this = r;
}


public static bool operator == (RC_d32d3dec6fa4abe9694e52a298b9cce9 a, RC_d32d3dec6fa4abe9694e52a298b9cce9 b) {
if (a.ssSTHTTPRequest != b.ssSTHTTPRequest) return false;
return true;
}

public static bool operator != (RC_d32d3dec6fa4abe9694e52a298b9cce9 a, RC_d32d3dec6fa4abe9694e52a298b9cce9 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_d32d3dec6fa4abe9694e52a298b9cce9)) return false;
return (this == (RC_d32d3dec6fa4abe9694e52a298b9cce9)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTHTTPRequest.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTHTTPRequest.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTHTTPRequest.InternalRecursiveSave();
}


public RC_d32d3dec6fa4abe9694e52a298b9cce9 Duplicate() {
RC_d32d3dec6fa4abe9694e52a298b9cce9 t;
t.ssSTHTTPRequest = (ST_ea2141f4206e3eb2cd0fdd847e008166Structure)this.ssSTHTTPRequest.Duplicate();
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
if (head == "httprequest") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".HTTPRequest")) variable.Value = ssSTHTTPRequest; else variable.Optimized = true;
variable.SetFieldName("httprequest");
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
if (key == IdHTTPRequest) {
return ssSTHTTPRequest;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdHTTPRequest.Key.AsGuid) {
return ssSTHTTPRequest;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTHTTPRequest.FillFromOther((IRecord) other.AttributeGet(IdHTTPRequest));
}
} // RC_d32d3dec6fa4abe9694e52a298b9cce9
/// <summary>
/// RecordList type <code>HTTPRequestRecordList</code> that represents a record list of
///  <code>HTTPRequest</code>
/// </summary>
public partial class RL_417bfde2101005da2b7ff259dd1b89e8 : GenericRecordList<RC_d32d3dec6fa4abe9694e52a298b9cce9>, IEnumerable, IEnumerator {

protected override RC_d32d3dec6fa4abe9694e52a298b9cce9 GetElementDefaultValue() {
return new RC_d32d3dec6fa4abe9694e52a298b9cce9();
}

public T[] ToArray<T>(Func<RC_d32d3dec6fa4abe9694e52a298b9cce9, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_417bfde2101005da2b7ff259dd1b89e8 recordList, Func<RC_d32d3dec6fa4abe9694e52a298b9cce9, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_417bfde2101005da2b7ff259dd1b89e8(RC_d32d3dec6fa4abe9694e52a298b9cce9[] array) {
  RL_417bfde2101005da2b7ff259dd1b89e8 result = new RL_417bfde2101005da2b7ff259dd1b89e8();
result.InnerFromArray(array);
    return result;
}

public static RL_417bfde2101005da2b7ff259dd1b89e8 ToList<T>(T[] array, Func <T, RC_d32d3dec6fa4abe9694e52a298b9cce9> converter) {
  RL_417bfde2101005da2b7ff259dd1b89e8 result = new RL_417bfde2101005da2b7ff259dd1b89e8();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_417bfde2101005da2b7ff259dd1b89e8 FromRestList<T>(RestList<T> restList, Func <T, RC_d32d3dec6fa4abe9694e52a298b9cce9> converter) {
  RL_417bfde2101005da2b7ff259dd1b89e8 result = new RL_417bfde2101005da2b7ff259dd1b89e8();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_417bfde2101005da2b7ff259dd1b89e8() : base() {
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
protected override OSList<RC_d32d3dec6fa4abe9694e52a298b9cce9> NewList() {
return new RL_417bfde2101005da2b7ff259dd1b89e8();
}


} // RL_417bfde2101005da2b7ff259dd1b89e8
}

