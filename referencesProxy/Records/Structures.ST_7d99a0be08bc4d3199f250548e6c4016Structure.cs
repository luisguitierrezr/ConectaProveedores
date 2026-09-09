namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [ReferenceStructure] DirectReports (YbfrIpRKOUuNKKRn9HadtQ)
///  <code>ST_7d99a0be08bc4d3199f250548e6c4016Structure</code> that represent
/// s <code>DirectReports</code> <p>Description: Direct Reports</p>
/// </summary>
// Name: DirectReports
public partial struct ST_7d99a0be08bc4d3199f250548e6c4016Structure : ITypedRecord<ST_7d99a0be08bc4d3199f250548e6c4016Structure> {
internal static readonly GlobalObjectKey IdUserId = GlobalObjectKey.Parse("fOFA5peUjUuSfOokWq1NWQ*H+AGn8S1mE62tyqKwbWItQ");
internal static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("fOFA5peUjUuSfOokWq1NWQ*t6JsXO_Iv0yye_tTt35hlw");
internal static readonly GlobalObjectKey IdRole = GlobalObjectKey.Parse("fOFA5peUjUuSfOokWq1NWQ*eHQxq4EPBk+ISSf4+keSUA");
internal static readonly GlobalObjectKey IdEntraId = GlobalObjectKey.Parse("fOFA5peUjUuSfOokWq1NWQ*TwQtZ7bJVk2zN5Zg9dFk6g");
internal static readonly GlobalObjectKey IdEmail = GlobalObjectKey.Parse("fOFA5peUjUuSfOokWq1NWQ*F96gia2NxE6CrGwsUZajjg");
internal static readonly GlobalObjectKey IdLevel = GlobalObjectKey.Parse("fOFA5peUjUuSfOokWq1NWQ*JGf2ZicY00KwCccIM46gRA");

public string ssUserId;

public string ssName;

public string ssRole;

public string ssEntraId;

public string ssEmail;

public int ssLevel;


public BitArray OptimizedAttributes;

public ST_7d99a0be08bc4d3199f250548e6c4016Structure() {
OptimizedAttributes = null;
ssUserId = "";
ssName = "";
ssRole = "";
ssEntraId = "";
ssEmail = "";
ssLevel = 0;
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
ssUserId = r.ReadText(index++, "DirectReports.UserId", "");
ssName = r.ReadText(index++, "DirectReports.Name", "");
ssRole = r.ReadText(index++, "DirectReports.Role", "");
ssEntraId = r.ReadText(index++, "DirectReports.EntraId", "");
ssEmail = r.ReadEmail(index++, "DirectReports.Email", "");
ssLevel = r.ReadInteger(index++, "DirectReports.Level", 0);
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
public void ReadIM(ST_7d99a0be08bc4d3199f250548e6c4016Structure r) {
this = r;
}


public static bool operator == (ST_7d99a0be08bc4d3199f250548e6c4016Structure a, ST_7d99a0be08bc4d3199f250548e6c4016Structure b) {
if (a.ssUserId != b.ssUserId) return false;
if (a.ssName != b.ssName) return false;
if (a.ssRole != b.ssRole) return false;
if (a.ssEntraId != b.ssEntraId) return false;
if (a.ssEmail != b.ssEmail) return false;
if (a.ssLevel != b.ssLevel) return false;
return true;
}

public static bool operator != (ST_7d99a0be08bc4d3199f250548e6c4016Structure a, ST_7d99a0be08bc4d3199f250548e6c4016Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_7d99a0be08bc4d3199f250548e6c4016Structure)) return false;
return (this == (ST_7d99a0be08bc4d3199f250548e6c4016Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssUserId.GetHashCode()
 ^ ssName.GetHashCode()
 ^ ssRole.GetHashCode()
 ^ ssEntraId.GetHashCode()
 ^ ssEmail.GetHashCode()
 ^ ssLevel.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_7d99a0be08bc4d3199f250548e6c4016Structure Duplicate() {
ST_7d99a0be08bc4d3199f250548e6c4016Structure t;
t.ssUserId = this.ssUserId;
t.ssName = this.ssName;
t.ssRole = this.ssRole;
t.ssEntraId = this.ssEntraId;
t.ssEmail = this.ssEmail;
t.ssLevel = this.ssLevel;
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
if (head == "userid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UserId")) variable.Value = ssUserId; else variable.Optimized = true;
} else if (head == "name") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Name")) variable.Value = ssName; else variable.Optimized = true;
} else if (head == "role") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Role")) variable.Value = ssRole; else variable.Optimized = true;
} else if (head == "entraid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EntraId")) variable.Value = ssEntraId; else variable.Optimized = true;
} else if (head == "email") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Email")) variable.Value = ssEmail; else variable.Optimized = true;
} else if (head == "level") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Level")) variable.Value = ssLevel; else variable.Optimized = true;
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
if (key == IdUserId) {
return ssUserId;
}
if (key == IdName) {
return ssName;
}
if (key == IdRole) {
return ssRole;
}
if (key == IdEntraId) {
return ssEntraId;
}
if (key == IdEmail) {
return ssEmail;
}
if (key == IdLevel) {
return ssLevel;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUserId.Key.AsGuid) {
return ssUserId;
}
if (attributeKey == IdName.Key.AsGuid) {
return ssName;
}
if (attributeKey == IdRole.Key.AsGuid) {
return ssRole;
}
if (attributeKey == IdEntraId.Key.AsGuid) {
return ssEntraId;
}
if (attributeKey == IdEmail.Key.AsGuid) {
return ssEmail;
}
if (attributeKey == IdLevel.Key.AsGuid) {
return ssLevel;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssUserId = (string) other.AttributeGet(IdUserId);
ssName = (string) other.AttributeGet(IdName);
ssRole = (string) other.AttributeGet(IdRole);
ssEntraId = (string) other.AttributeGet(IdEntraId);
ssEmail = (string) other.AttributeGet(IdEmail);
ssLevel = (int) other.AttributeGet(IdLevel);
}
} // ST_7d99a0be08bc4d3199f250548e6c4016Structure
/// <summary>
/// RecordList type <code>DirectReportsList</code> that represents a record list of
///  <code>DirectReports</code>
/// </summary>
public partial class RL_33aa275c739b8b537ec846fb1cac5907 : GenericRecordList<ST_7d99a0be08bc4d3199f250548e6c4016Structure>, IEnumerable, IEnumerator {

protected override ST_7d99a0be08bc4d3199f250548e6c4016Structure GetElementDefaultValue() {
return new ST_7d99a0be08bc4d3199f250548e6c4016Structure();
}

public T[] ToArray<T>(Func<ST_7d99a0be08bc4d3199f250548e6c4016Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_33aa275c739b8b537ec846fb1cac5907 recordList, Func<ST_7d99a0be08bc4d3199f250548e6c4016Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_33aa275c739b8b537ec846fb1cac5907(ST_7d99a0be08bc4d3199f250548e6c4016Structure[] array) {
  RL_33aa275c739b8b537ec846fb1cac5907 result = new RL_33aa275c739b8b537ec846fb1cac5907();
result.InnerFromArray(array);
    return result;
}

public static RL_33aa275c739b8b537ec846fb1cac5907 ToList<T>(T[] array, Func <T, ST_7d99a0be08bc4d3199f250548e6c4016Structure> converter) {
  RL_33aa275c739b8b537ec846fb1cac5907 result = new RL_33aa275c739b8b537ec846fb1cac5907();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_33aa275c739b8b537ec846fb1cac5907 FromRestList<T>(RestList<T> restList, Func <T, ST_7d99a0be08bc4d3199f250548e6c4016Structure> converter) {
  RL_33aa275c739b8b537ec846fb1cac5907 result = new RL_33aa275c739b8b537ec846fb1cac5907();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_33aa275c739b8b537ec846fb1cac5907() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_7d99a0be08bc4d3199f250548e6c4016Structure> NewList() {
return new RL_33aa275c739b8b537ec846fb1cac5907();
}


} // RL_33aa275c739b8b537ec846fb1cac5907
}

