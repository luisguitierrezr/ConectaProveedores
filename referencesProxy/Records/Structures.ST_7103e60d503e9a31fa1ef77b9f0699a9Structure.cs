namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [ReferenceStructure] ValueItem3 (RYGa0bR7W0SFDapjdlMbhw)
///  <code>ST_7103e60d503e9a31fa1ef77b9f0699a9Structure</code> that represents <code>ValueItem3</code
/// > <p>Description: </p>
/// </summary>
// Name: ValueItem3
public partial struct ST_7103e60d503e9a31fa1ef77b9f0699a9Structure : ITypedRecord<ST_7103e60d503e9a31fa1ef77b9f0699a9Structure> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("fOFA5peUjUuSfOokWq1NWQ*RsYFbJqHr0C71TPxWw0aYQ");
internal static readonly GlobalObjectKey IdDeletedDateTime = GlobalObjectKey.Parse("fOFA5peUjUuSfOokWq1NWQ*Qe_uD2rXmkeUvBRwyWirug");
internal static readonly GlobalObjectKey IdDescription = GlobalObjectKey.Parse("fOFA5peUjUuSfOokWq1NWQ*AnHEkpENYEygQ3rAPveWoA");
internal static readonly GlobalObjectKey IdDisplayName = GlobalObjectKey.Parse("fOFA5peUjUuSfOokWq1NWQ*GvRnGjGqUUitwyZfTNFliQ");
internal static readonly GlobalObjectKey IdRoleTemplateId = GlobalObjectKey.Parse("fOFA5peUjUuSfOokWq1NWQ*eYFkGiRJR0qFzaiS4y3Vqg");

public string ssId;

public DateTime ssDeletedDateTime;

public string ssDescription;

public string ssDisplayName;

public string ssRoleTemplateId;


public BitArray OptimizedAttributes;

public ST_7103e60d503e9a31fa1ef77b9f0699a9Structure() {
OptimizedAttributes = null;
ssId = "";
ssDeletedDateTime = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
ssDescription = "";
ssDisplayName = "";
ssRoleTemplateId = "";
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
ssId = r.ReadText(index++, "ValueItem3.Id", "");
ssDeletedDateTime = r.ReadDateTime(index++, "ValueItem3.DeletedDateTime", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssDescription = r.ReadText(index++, "ValueItem3.Description", "");
ssDisplayName = r.ReadText(index++, "ValueItem3.DisplayName", "");
ssRoleTemplateId = r.ReadText(index++, "ValueItem3.RoleTemplateId", "");
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
public void ReadIM(ST_7103e60d503e9a31fa1ef77b9f0699a9Structure r) {
this = r;
}


public static bool operator == (ST_7103e60d503e9a31fa1ef77b9f0699a9Structure a, ST_7103e60d503e9a31fa1ef77b9f0699a9Structure b) {
if (a.ssId != b.ssId) return false;
if (a.ssDeletedDateTime != b.ssDeletedDateTime) return false;
if (a.ssDescription != b.ssDescription) return false;
if (a.ssDisplayName != b.ssDisplayName) return false;
if (a.ssRoleTemplateId != b.ssRoleTemplateId) return false;
return true;
}

public static bool operator != (ST_7103e60d503e9a31fa1ef77b9f0699a9Structure a, ST_7103e60d503e9a31fa1ef77b9f0699a9Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_7103e60d503e9a31fa1ef77b9f0699a9Structure)) return false;
return (this == (ST_7103e60d503e9a31fa1ef77b9f0699a9Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssDeletedDateTime.GetHashCode()
 ^ ssDescription.GetHashCode()
 ^ ssDisplayName.GetHashCode()
 ^ ssRoleTemplateId.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_7103e60d503e9a31fa1ef77b9f0699a9Structure Duplicate() {
ST_7103e60d503e9a31fa1ef77b9f0699a9Structure t;
t.ssId = this.ssId;
t.ssDeletedDateTime = this.ssDeletedDateTime;
t.ssDescription = this.ssDescription;
t.ssDisplayName = this.ssDisplayName;
t.ssRoleTemplateId = this.ssRoleTemplateId;
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
} else if (head == "deleteddatetime") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DeletedDateTime")) variable.Value = ssDeletedDateTime; else variable.Optimized = true;
} else if (head == "description") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Description")) variable.Value = ssDescription; else variable.Optimized = true;
} else if (head == "displayname") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DisplayName")) variable.Value = ssDisplayName; else variable.Optimized = true;
} else if (head == "roletemplateid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RoleTemplateId")) variable.Value = ssRoleTemplateId; else variable.Optimized = true;
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
if (key == IdDeletedDateTime) {
return ssDeletedDateTime;
}
if (key == IdDescription) {
return ssDescription;
}
if (key == IdDisplayName) {
return ssDisplayName;
}
if (key == IdRoleTemplateId) {
return ssRoleTemplateId;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdDeletedDateTime.Key.AsGuid) {
return ssDeletedDateTime;
}
if (attributeKey == IdDescription.Key.AsGuid) {
return ssDescription;
}
if (attributeKey == IdDisplayName.Key.AsGuid) {
return ssDisplayName;
}
if (attributeKey == IdRoleTemplateId.Key.AsGuid) {
return ssRoleTemplateId;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssId = (string) other.AttributeGet(IdId);
ssDeletedDateTime = (DateTime) other.AttributeGet(IdDeletedDateTime);
ssDescription = (string) other.AttributeGet(IdDescription);
ssDisplayName = (string) other.AttributeGet(IdDisplayName);
ssRoleTemplateId = (string) other.AttributeGet(IdRoleTemplateId);
}
} // ST_7103e60d503e9a31fa1ef77b9f0699a9Structure
/// <summary>
/// RecordList type <code>ValueItem3List</code> that represents a record list of
///  <code>ValueItem3</code>
/// </summary>
public partial class RL_02734d484762896f3a74099335d4c25d : GenericRecordList<ST_7103e60d503e9a31fa1ef77b9f0699a9Structure>, IEnumerable, IEnumerator {

protected override ST_7103e60d503e9a31fa1ef77b9f0699a9Structure GetElementDefaultValue() {
return new ST_7103e60d503e9a31fa1ef77b9f0699a9Structure();
}

public T[] ToArray<T>(Func<ST_7103e60d503e9a31fa1ef77b9f0699a9Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_02734d484762896f3a74099335d4c25d recordList, Func<ST_7103e60d503e9a31fa1ef77b9f0699a9Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_02734d484762896f3a74099335d4c25d(ST_7103e60d503e9a31fa1ef77b9f0699a9Structure[] array) {
  RL_02734d484762896f3a74099335d4c25d result = new RL_02734d484762896f3a74099335d4c25d();
result.InnerFromArray(array);
    return result;
}

public static RL_02734d484762896f3a74099335d4c25d ToList<T>(T[] array, Func <T, ST_7103e60d503e9a31fa1ef77b9f0699a9Structure> converter) {
  RL_02734d484762896f3a74099335d4c25d result = new RL_02734d484762896f3a74099335d4c25d();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_02734d484762896f3a74099335d4c25d FromRestList<T>(RestList<T> restList, Func <T, ST_7103e60d503e9a31fa1ef77b9f0699a9Structure> converter) {
  RL_02734d484762896f3a74099335d4c25d result = new RL_02734d484762896f3a74099335d4c25d();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_02734d484762896f3a74099335d4c25d() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_7103e60d503e9a31fa1ef77b9f0699a9Structure> NewList() {
return new RL_02734d484762896f3a74099335d4c25d();
}


} // RL_02734d484762896f3a74099335d4c25d
}

