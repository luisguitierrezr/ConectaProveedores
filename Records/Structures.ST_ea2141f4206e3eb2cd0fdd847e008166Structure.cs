namespace ssConectaProveedores {
/// <summary>
/// [CustomStructure] HTTPRequest (F3k3VqYBOEeJs3cM+rGwBg)
///  <code>ST_ea2141f4206e3eb2cd0fdd847e008166Structure</code> that represents <code>HTTPRequest</code
/// > <p>Description: </p>
/// </summary>
// Name: HTTPRequest
public partial struct ST_ea2141f4206e3eb2cd0fdd847e008166Structure : ITypedRecord<ST_ea2141f4206e3eb2cd0fdd847e008166Structure> {
internal static readonly GlobalObjectKey IdBaseURL = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*auQP_cx0gkKdm8A3bptB1Q");
internal static readonly GlobalObjectKey IdURLPath = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*jk0sgz6ADUimweOwjp2afA");
internal static readonly GlobalObjectKey IdURLQueryParameters = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*J5Rfl_XjlkKW7uU5iIQiyA");
internal static readonly GlobalObjectKey IdHTTPMethod = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*5vg6ZzWlmU+jp8gJO8Lgiw");
internal static readonly GlobalObjectKey IdHeaders = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*J+JKos3NpkC6ed90h9sLzw");
internal static readonly GlobalObjectKey IdRequestText = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*1VGtbp4n+0+xTw0B46HoCg");
internal static readonly GlobalObjectKey IdRequestBinary = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*quf98Vbs9EehgVFPxLGyqw");

public string ssBaseURL;

public string ssURLPath;

public RL_09d38ca4875adba9fe0bf71f298f1c3d ssURLQueryParameters;

public string ssHTTPMethod;

public RL_c06bca3d168b84039f4414ae52f271eb ssHeaders;

public string ssRequestText;

public byte[] ssRequestBinary;


public BitArray OptimizedAttributes;

public ST_ea2141f4206e3eb2cd0fdd847e008166Structure() {
OptimizedAttributes = null;
ssBaseURL = "";
ssURLPath = "";
ssURLQueryParameters = new RL_09d38ca4875adba9fe0bf71f298f1c3d();
ssHTTPMethod = "";
ssHeaders = new RL_c06bca3d168b84039f4414ae52f271eb();
ssRequestText = "";
ssRequestBinary = new byte[] {};
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
ssBaseURL = r.ReadText(index++, "HTTPRequest.BaseURL", "");
ssURLPath = r.ReadText(index++, "HTTPRequest.URLPath", "");
ssHTTPMethod = r.ReadText(index++, "HTTPRequest.HTTPMethod", "");
ssRequestText = r.ReadText(index++, "HTTPRequest.RequestText", "");
ssRequestBinary = r.ReadBinaryData(index++, "HTTPRequest.RequestBinary", new byte[] {});
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
public void ReadIM(ST_ea2141f4206e3eb2cd0fdd847e008166Structure r) {
this = r;
}


public static bool operator == (ST_ea2141f4206e3eb2cd0fdd847e008166Structure a, ST_ea2141f4206e3eb2cd0fdd847e008166Structure b) {
if (a.ssBaseURL != b.ssBaseURL) return false;
if (a.ssURLPath != b.ssURLPath) return false;
if (a.ssURLQueryParameters != b.ssURLQueryParameters) return false;
if (a.ssHTTPMethod != b.ssHTTPMethod) return false;
if (a.ssHeaders != b.ssHeaders) return false;
if (a.ssRequestText != b.ssRequestText) return false;
if (!RuntimePlatformUtils.CompareByteArrays(a.ssRequestBinary, b.ssRequestBinary)) return false;
return true;
}

public static bool operator != (ST_ea2141f4206e3eb2cd0fdd847e008166Structure a, ST_ea2141f4206e3eb2cd0fdd847e008166Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_ea2141f4206e3eb2cd0fdd847e008166Structure)) return false;
return (this == (ST_ea2141f4206e3eb2cd0fdd847e008166Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssBaseURL.GetHashCode()
 ^ ssURLPath.GetHashCode()
 ^ ssURLQueryParameters.GetHashCode()
 ^ ssHTTPMethod.GetHashCode()
 ^ ssHeaders.GetHashCode()
 ^ ssRequestText.GetHashCode()
 ^ ssRequestBinary.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssURLQueryParameters.RecursiveReset();
ssHeaders.RecursiveReset();
}

public void InternalRecursiveSave() {
ssURLQueryParameters.InternalRecursiveSave();
ssHeaders.InternalRecursiveSave();
}


public ST_ea2141f4206e3eb2cd0fdd847e008166Structure Duplicate() {
ST_ea2141f4206e3eb2cd0fdd847e008166Structure t;
t.ssBaseURL = this.ssBaseURL;
t.ssURLPath = this.ssURLPath;
t.ssURLQueryParameters = (RL_09d38ca4875adba9fe0bf71f298f1c3d)this.ssURLQueryParameters.Duplicate();
t.ssHTTPMethod = this.ssHTTPMethod;
t.ssHeaders = (RL_c06bca3d168b84039f4414ae52f271eb)this.ssHeaders.Duplicate();
t.ssRequestText = this.ssRequestText;
t.ssRequestBinary = this.ssRequestBinary;
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
if (head == "baseurl") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".BaseURL")) variable.Value = ssBaseURL; else variable.Optimized = true;
} else if (head == "urlpath") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".URLPath")) variable.Value = ssURLPath; else variable.Optimized = true;
} else if (head == "urlqueryparameters") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".URLQueryParameters")) variable.Value = ssURLQueryParameters; else variable.Optimized = true;
variable.SetFieldName("urlqueryparameters");
} else if (head == "httpmethod") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".HTTPMethod")) variable.Value = ssHTTPMethod; else variable.Optimized = true;
} else if (head == "headers") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Headers")) variable.Value = ssHeaders; else variable.Optimized = true;
variable.SetFieldName("headers");
} else if (head == "requesttext") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequestText")) variable.Value = ssRequestText; else variable.Optimized = true;
} else if (head == "requestbinary") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequestBinary")) variable.Value = ssRequestBinary; else variable.Optimized = true;
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
if (key == IdBaseURL) {
return ssBaseURL;
}
if (key == IdURLPath) {
return ssURLPath;
}
if (key == IdURLQueryParameters) {
return ssURLQueryParameters;
}
if (key == IdHTTPMethod) {
return ssHTTPMethod;
}
if (key == IdHeaders) {
return ssHeaders;
}
if (key == IdRequestText) {
return ssRequestText;
}
if (key == IdRequestBinary) {
return ssRequestBinary;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdBaseURL.Key.AsGuid) {
return ssBaseURL;
}
if (attributeKey == IdURLPath.Key.AsGuid) {
return ssURLPath;
}
if (attributeKey == IdURLQueryParameters.Key.AsGuid) {
return ssURLQueryParameters;
}
if (attributeKey == IdHTTPMethod.Key.AsGuid) {
return ssHTTPMethod;
}
if (attributeKey == IdHeaders.Key.AsGuid) {
return ssHeaders;
}
if (attributeKey == IdRequestText.Key.AsGuid) {
return ssRequestText;
}
if (attributeKey == IdRequestBinary.Key.AsGuid) {
return ssRequestBinary;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssBaseURL = (string) other.AttributeGet(IdBaseURL);
ssURLPath = (string) other.AttributeGet(IdURLPath);
ssURLQueryParameters = new RL_09d38ca4875adba9fe0bf71f298f1c3d();
ssURLQueryParameters.FillFromOther((IOSList) other.AttributeGet(IdURLQueryParameters));
ssHTTPMethod = (string) other.AttributeGet(IdHTTPMethod);
ssHeaders = new RL_c06bca3d168b84039f4414ae52f271eb();
ssHeaders.FillFromOther((IOSList) other.AttributeGet(IdHeaders));
ssRequestText = (string) other.AttributeGet(IdRequestText);
ssRequestBinary = (byte[]) other.AttributeGet(IdRequestBinary);
}
} // ST_ea2141f4206e3eb2cd0fdd847e008166Structure
/// <summary>
/// RecordList type <code>HTTPRequestList</code> that represents a record list of
///  <code>HTTPRequest</code>
/// </summary>
public partial class RL_e8cbfa0425cebf962054dfc265a1d74b : GenericRecordList<ST_ea2141f4206e3eb2cd0fdd847e008166Structure>, IEnumerable, IEnumerator {

protected override ST_ea2141f4206e3eb2cd0fdd847e008166Structure GetElementDefaultValue() {
return new ST_ea2141f4206e3eb2cd0fdd847e008166Structure();
}

public T[] ToArray<T>(Func<ST_ea2141f4206e3eb2cd0fdd847e008166Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e8cbfa0425cebf962054dfc265a1d74b recordList, Func<ST_ea2141f4206e3eb2cd0fdd847e008166Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e8cbfa0425cebf962054dfc265a1d74b(ST_ea2141f4206e3eb2cd0fdd847e008166Structure[] array) {
  RL_e8cbfa0425cebf962054dfc265a1d74b result = new RL_e8cbfa0425cebf962054dfc265a1d74b();
result.InnerFromArray(array);
    return result;
}

public static RL_e8cbfa0425cebf962054dfc265a1d74b ToList<T>(T[] array, Func <T, ST_ea2141f4206e3eb2cd0fdd847e008166Structure> converter) {
  RL_e8cbfa0425cebf962054dfc265a1d74b result = new RL_e8cbfa0425cebf962054dfc265a1d74b();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e8cbfa0425cebf962054dfc265a1d74b FromRestList<T>(RestList<T> restList, Func <T, ST_ea2141f4206e3eb2cd0fdd847e008166Structure> converter) {
  RL_e8cbfa0425cebf962054dfc265a1d74b result = new RL_e8cbfa0425cebf962054dfc265a1d74b();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e8cbfa0425cebf962054dfc265a1d74b() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_ea2141f4206e3eb2cd0fdd847e008166Structure> NewList() {
return new RL_e8cbfa0425cebf962054dfc265a1d74b();
}


} // RL_e8cbfa0425cebf962054dfc265a1d74b
}

