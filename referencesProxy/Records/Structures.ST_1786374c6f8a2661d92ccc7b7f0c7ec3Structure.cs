namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [ReferenceStructure] AuditStruc4List (V+ztnuPndEaxF+9M5kcErw)
///  <code>ST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure</code> that represent
/// s <code>AuditStruc4List</code> <p>Description: AuditStruc4List</p>
/// </summary>
// Name: AuditStruc4List
public partial struct ST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure : ITypedRecord<ST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("mmiiin9toUWcWlIGpp+Idw*_MfclfO4P0+XYNvr2V0gdw");
internal static readonly GlobalObjectKey IdOrigin = GlobalObjectKey.Parse("mmiiin9toUWcWlIGpp+Idw*YlZwL4az30+xM+nhkkqc8A");
internal static readonly GlobalObjectKey IdIdentifier = GlobalObjectKey.Parse("mmiiin9toUWcWlIGpp+Idw*Uc0fSsI39EGrKeZbmBfgJA");
internal static readonly GlobalObjectKey IdMessage = GlobalObjectKey.Parse("mmiiin9toUWcWlIGpp+Idw*VzLC92IcEES5sYsX09faEA");
internal static readonly GlobalObjectKey IdOriginalJSON = GlobalObjectKey.Parse("mmiiin9toUWcWlIGpp+Idw*zsozKWN+F02xTYBGuFTKTQ");
internal static readonly GlobalObjectKey IdChangeJSON = GlobalObjectKey.Parse("mmiiin9toUWcWlIGpp+Idw*77pVuT9g2kGOejfr6Tu7Xw");
internal static readonly GlobalObjectKey IdOccurrenceDateTime = GlobalObjectKey.Parse("mmiiin9toUWcWlIGpp+Idw*joWDH+62hEKfRvGQYQGuyw");
internal static readonly GlobalObjectKey IdOccurrenceUser = GlobalObjectKey.Parse("mmiiin9toUWcWlIGpp+Idw*+JhBKiSrhUS2jfbg4lVitg");
internal static readonly GlobalObjectKey IdIsError = GlobalObjectKey.Parse("mmiiin9toUWcWlIGpp+Idw*uqOC55eZmEGVZq_Dw6GEPw");

public long ssId;

public string ssOrigin;

public long ssIdentifier;

public string ssMessage;

public string ssOriginalJSON;

public string ssChangeJSON;

public DateTime ssOccurrenceDateTime;

public string ssOccurrenceUser;

public bool ssIsError;


public BitArray OptimizedAttributes;

public ST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure() {
OptimizedAttributes = null;
ssId = 0L;
ssOrigin = "";
ssIdentifier = 0L;
ssMessage = "";
ssOriginalJSON = "";
ssChangeJSON = "";
ssOccurrenceDateTime = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
ssOccurrenceUser = "";
ssIsError = false;
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
ssId = r.ReadLongInteger(index++, "AuditStruc4List.Id", 0L);
ssOrigin = r.ReadText(index++, "AuditStruc4List.Origin", "");
ssIdentifier = r.ReadLongInteger(index++, "AuditStruc4List.Identifier", 0L);
ssMessage = r.ReadText(index++, "AuditStruc4List.Message", "");
ssOriginalJSON = r.ReadText(index++, "AuditStruc4List.OriginalJSON", "");
ssChangeJSON = r.ReadText(index++, "AuditStruc4List.ChangeJSON", "");
ssOccurrenceDateTime = r.ReadDateTime(index++, "AuditStruc4List.OccurrenceDateTime", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssOccurrenceUser = r.ReadText(index++, "AuditStruc4List.OccurrenceUser", "");
ssIsError = r.ReadBoolean(index++, "AuditStruc4List.IsError", false);
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
public void ReadIM(ST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure r) {
this = r;
}


public static bool operator == (ST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure a, ST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure b) {
if (a.ssId != b.ssId) return false;
if (a.ssOrigin != b.ssOrigin) return false;
if (a.ssIdentifier != b.ssIdentifier) return false;
if (a.ssMessage != b.ssMessage) return false;
if (a.ssOriginalJSON != b.ssOriginalJSON) return false;
if (a.ssChangeJSON != b.ssChangeJSON) return false;
if (a.ssOccurrenceDateTime != b.ssOccurrenceDateTime) return false;
if (a.ssOccurrenceUser != b.ssOccurrenceUser) return false;
if (a.ssIsError != b.ssIsError) return false;
return true;
}

public static bool operator != (ST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure a, ST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure)) return false;
return (this == (ST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssOrigin.GetHashCode()
 ^ ssIdentifier.GetHashCode()
 ^ ssMessage.GetHashCode()
 ^ ssOriginalJSON.GetHashCode()
 ^ ssChangeJSON.GetHashCode()
 ^ ssOccurrenceDateTime.GetHashCode()
 ^ ssOccurrenceUser.GetHashCode()
 ^ ssIsError.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure Duplicate() {
ST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure t;
t.ssId = this.ssId;
t.ssOrigin = this.ssOrigin;
t.ssIdentifier = this.ssIdentifier;
t.ssMessage = this.ssMessage;
t.ssOriginalJSON = this.ssOriginalJSON;
t.ssChangeJSON = this.ssChangeJSON;
t.ssOccurrenceDateTime = this.ssOccurrenceDateTime;
t.ssOccurrenceUser = this.ssOccurrenceUser;
t.ssIsError = this.ssIsError;
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
if (head == "id") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Id")) variable.Value = ssId; else variable.Optimized = true;
} else if (head == "origin") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Origin")) variable.Value = ssOrigin; else variable.Optimized = true;
} else if (head == "identifier") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Identifier")) variable.Value = ssIdentifier; else variable.Optimized = true;
} else if (head == "message") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Message")) variable.Value = ssMessage; else variable.Optimized = true;
} else if (head == "originaljson") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OriginalJSON")) variable.Value = ssOriginalJSON; else variable.Optimized = true;
} else if (head == "changejson") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ChangeJSON")) variable.Value = ssChangeJSON; else variable.Optimized = true;
} else if (head == "occurrencedatetime") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OccurrenceDateTime")) variable.Value = ssOccurrenceDateTime; else variable.Optimized = true;
} else if (head == "occurrenceuser") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OccurrenceUser")) variable.Value = ssOccurrenceUser; else variable.Optimized = true;
} else if (head == "iserror") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsError")) variable.Value = ssIsError; else variable.Optimized = true;
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
if (key == IdId) {
return ssId;
}
if (key == IdOrigin) {
return ssOrigin;
}
if (key == IdIdentifier) {
return ssIdentifier;
}
if (key == IdMessage) {
return ssMessage;
}
if (key == IdOriginalJSON) {
return ssOriginalJSON;
}
if (key == IdChangeJSON) {
return ssChangeJSON;
}
if (key == IdOccurrenceDateTime) {
return ssOccurrenceDateTime;
}
if (key == IdOccurrenceUser) {
return ssOccurrenceUser;
}
if (key == IdIsError) {
return ssIsError;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdOrigin.Key.AsGuid) {
return ssOrigin;
}
if (attributeKey == IdIdentifier.Key.AsGuid) {
return ssIdentifier;
}
if (attributeKey == IdMessage.Key.AsGuid) {
return ssMessage;
}
if (attributeKey == IdOriginalJSON.Key.AsGuid) {
return ssOriginalJSON;
}
if (attributeKey == IdChangeJSON.Key.AsGuid) {
return ssChangeJSON;
}
if (attributeKey == IdOccurrenceDateTime.Key.AsGuid) {
return ssOccurrenceDateTime;
}
if (attributeKey == IdOccurrenceUser.Key.AsGuid) {
return ssOccurrenceUser;
}
if (attributeKey == IdIsError.Key.AsGuid) {
return ssIsError;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ssOrigin = (string) other.AttributeGet(IdOrigin);
ssIdentifier = (long) other.AttributeGet(IdIdentifier);
ssMessage = (string) other.AttributeGet(IdMessage);
ssOriginalJSON = (string) other.AttributeGet(IdOriginalJSON);
ssChangeJSON = (string) other.AttributeGet(IdChangeJSON);
ssOccurrenceDateTime = (DateTime) other.AttributeGet(IdOccurrenceDateTime);
ssOccurrenceUser = (string) other.AttributeGet(IdOccurrenceUser);
ssIsError = (bool) other.AttributeGet(IdIsError);
}
} // ST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure
/// <summary>
/// RecordList type <code>AuditStruc4ListList</code> that represents a record list of
///  <code>AuditStruc4List</code>
/// </summary>
public partial class RL_d271bd6e591b75c186c4ae8d222dee55 : GenericRecordList<ST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure>, IEnumerable, IEnumerator {

protected override ST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure GetElementDefaultValue() {
return new ST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure();
}

public T[] ToArray<T>(Func<ST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_d271bd6e591b75c186c4ae8d222dee55 recordList, Func<ST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_d271bd6e591b75c186c4ae8d222dee55(ST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure[] array) {
  RL_d271bd6e591b75c186c4ae8d222dee55 result = new RL_d271bd6e591b75c186c4ae8d222dee55();
result.InnerFromArray(array);
    return result;
}

public static RL_d271bd6e591b75c186c4ae8d222dee55 ToList<T>(T[] array, Func <T, ST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure> converter) {
  RL_d271bd6e591b75c186c4ae8d222dee55 result = new RL_d271bd6e591b75c186c4ae8d222dee55();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_d271bd6e591b75c186c4ae8d222dee55 FromRestList<T>(RestList<T> restList, Func <T, ST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure> converter) {
  RL_d271bd6e591b75c186c4ae8d222dee55 result = new RL_d271bd6e591b75c186c4ae8d222dee55();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_d271bd6e591b75c186c4ae8d222dee55() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure> NewList() {
return new RL_d271bd6e591b75c186c4ae8d222dee55();
}


} // RL_d271bd6e591b75c186c4ae8d222dee55
}

