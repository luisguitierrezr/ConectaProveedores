namespace ssConectaProveedores {
/// <summary>
/// [ReferenceStructure] UserDetail (kEdcV4dMqEqDYndBay6+zA)
///  <code>ST_3d98fcbf952bf72084dad4104cc8c43fStructure</code> that represents <code>UserDetail</code
/// > <p>Description: User detail information</p>
/// </summary>
// Name: UserDetail
public partial struct ST_3d98fcbf952bf72084dad4104cc8c43fStructure : ITypedRecord<ST_3d98fcbf952bf72084dad4104cc8c43fStructure> {
internal static readonly GlobalObjectKey IdKey = GlobalObjectKey.Parse("URvNYUB3HEOk51b1jkk_OA*3vmY5l_r5E+tpprcuQ091g");
internal static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("URvNYUB3HEOk51b1jkk_OA*mSwfnRl4d0aC+DcTFias5w");
internal static readonly GlobalObjectKey IdEmail = GlobalObjectKey.Parse("URvNYUB3HEOk51b1jkk_OA*aNUnG+ui40uS7xghwQQgVQ");
internal static readonly GlobalObjectKey IdStatus = GlobalObjectKey.Parse("URvNYUB3HEOk51b1jkk_OA*vJACkLTN8k6HHAJRjoIitw");
internal static readonly GlobalObjectKey IdLastLoginAt = GlobalObjectKey.Parse("URvNYUB3HEOk51b1jkk_OA*a8XGCRpo6EO+HfucVkgbpw");
internal static readonly GlobalObjectKey IdIsActive = GlobalObjectKey.Parse("URvNYUB3HEOk51b1jkk_OA*4jswcgwisESBVKcdGJbK0A");
internal static readonly GlobalObjectKey IdPhotoUrl = GlobalObjectKey.Parse("URvNYUB3HEOk51b1jkk_OA*P8xs72DdrkG2Oj8Na7UY4A");
internal static readonly GlobalObjectKey IdIsEmailVerified = GlobalObjectKey.Parse("URvNYUB3HEOk51b1jkk_OA*WFrNyDdd10GdN7uaG398xg");
internal static readonly GlobalObjectKey IdIsTermsAndConditionsAccepted = GlobalObjectKey.Parse("URvNYUB3HEOk51b1jkk_OA*e+eXBdfV5UinkROcZDuTxg");

public string ssKey;

public string ssName;

public string ssEmail;

public string ssStatus;

public DateTime ssLastLoginAt;

public bool ssIsActive;

public string ssPhotoUrl;

public bool ssIsEmailVerified;

public bool ssIsTermsAndConditionsAccepted;


public BitArray OptimizedAttributes;

public ST_3d98fcbf952bf72084dad4104cc8c43fStructure() {
OptimizedAttributes = null;
ssKey = "";
ssName = "";
ssEmail = "";
ssStatus = "";
ssLastLoginAt = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
ssIsActive = false;
ssPhotoUrl = "";
ssIsEmailVerified = false;
ssIsTermsAndConditionsAccepted = false;
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
ssKey = r.ReadText(index++, "UserDetail.Key", "");
ssName = r.ReadText(index++, "UserDetail.Name", "");
ssEmail = r.ReadText(index++, "UserDetail.Email", "");
ssStatus = r.ReadText(index++, "UserDetail.Status", "");
ssLastLoginAt = r.ReadDateTime(index++, "UserDetail.LastLoginAt", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssIsActive = r.ReadBoolean(index++, "UserDetail.IsActive", false);
ssPhotoUrl = r.ReadText(index++, "UserDetail.PhotoUrl", "");
ssIsEmailVerified = r.ReadBoolean(index++, "UserDetail.IsEmailVerified", false);
ssIsTermsAndConditionsAccepted = r.ReadBoolean(index++, "UserDetail.IsTermsAndConditionsAccepted", false);
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
public void ReadIM(ST_3d98fcbf952bf72084dad4104cc8c43fStructure r) {
this = r;
}


public static bool operator == (ST_3d98fcbf952bf72084dad4104cc8c43fStructure a, ST_3d98fcbf952bf72084dad4104cc8c43fStructure b) {
if (a.ssKey != b.ssKey) return false;
if (a.ssName != b.ssName) return false;
if (a.ssEmail != b.ssEmail) return false;
if (a.ssStatus != b.ssStatus) return false;
if (a.ssLastLoginAt != b.ssLastLoginAt) return false;
if (a.ssIsActive != b.ssIsActive) return false;
if (a.ssPhotoUrl != b.ssPhotoUrl) return false;
if (a.ssIsEmailVerified != b.ssIsEmailVerified) return false;
if (a.ssIsTermsAndConditionsAccepted != b.ssIsTermsAndConditionsAccepted) return false;
return true;
}

public static bool operator != (ST_3d98fcbf952bf72084dad4104cc8c43fStructure a, ST_3d98fcbf952bf72084dad4104cc8c43fStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_3d98fcbf952bf72084dad4104cc8c43fStructure)) return false;
return (this == (ST_3d98fcbf952bf72084dad4104cc8c43fStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssKey.GetHashCode()
 ^ ssName.GetHashCode()
 ^ ssEmail.GetHashCode()
 ^ ssStatus.GetHashCode()
 ^ ssLastLoginAt.GetHashCode()
 ^ ssIsActive.GetHashCode()
 ^ ssPhotoUrl.GetHashCode()
 ^ ssIsEmailVerified.GetHashCode()
 ^ ssIsTermsAndConditionsAccepted.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_3d98fcbf952bf72084dad4104cc8c43fStructure Duplicate() {
ST_3d98fcbf952bf72084dad4104cc8c43fStructure t;
t.ssKey = this.ssKey;
t.ssName = this.ssName;
t.ssEmail = this.ssEmail;
t.ssStatus = this.ssStatus;
t.ssLastLoginAt = this.ssLastLoginAt;
t.ssIsActive = this.ssIsActive;
t.ssPhotoUrl = this.ssPhotoUrl;
t.ssIsEmailVerified = this.ssIsEmailVerified;
t.ssIsTermsAndConditionsAccepted = this.ssIsTermsAndConditionsAccepted;
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
if (head == "key") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Key")) variable.Value = ssKey; else variable.Optimized = true;
} else if (head == "name") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Name")) variable.Value = ssName; else variable.Optimized = true;
} else if (head == "email") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Email")) variable.Value = ssEmail; else variable.Optimized = true;
} else if (head == "status") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Status")) variable.Value = ssStatus; else variable.Optimized = true;
} else if (head == "lastloginat") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".LastLoginAt")) variable.Value = ssLastLoginAt; else variable.Optimized = true;
} else if (head == "isactive") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsActive")) variable.Value = ssIsActive; else variable.Optimized = true;
} else if (head == "photourl") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PhotoUrl")) variable.Value = ssPhotoUrl; else variable.Optimized = true;
} else if (head == "isemailverified") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsEmailVerified")) variable.Value = ssIsEmailVerified; else variable.Optimized = true;
} else if (head == "istermsandconditionsaccepted") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsTermsAndConditionsAccepted")) variable.Value = ssIsTermsAndConditionsAccepted; else variable.Optimized = true;
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
if (key == IdKey) {
return ssKey;
}
if (key == IdName) {
return ssName;
}
if (key == IdEmail) {
return ssEmail;
}
if (key == IdStatus) {
return ssStatus;
}
if (key == IdLastLoginAt) {
return ssLastLoginAt;
}
if (key == IdIsActive) {
return ssIsActive;
}
if (key == IdPhotoUrl) {
return ssPhotoUrl;
}
if (key == IdIsEmailVerified) {
return ssIsEmailVerified;
}
if (key == IdIsTermsAndConditionsAccepted) {
return ssIsTermsAndConditionsAccepted;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdKey.Key.AsGuid) {
return ssKey;
}
if (attributeKey == IdName.Key.AsGuid) {
return ssName;
}
if (attributeKey == IdEmail.Key.AsGuid) {
return ssEmail;
}
if (attributeKey == IdStatus.Key.AsGuid) {
return ssStatus;
}
if (attributeKey == IdLastLoginAt.Key.AsGuid) {
return ssLastLoginAt;
}
if (attributeKey == IdIsActive.Key.AsGuid) {
return ssIsActive;
}
if (attributeKey == IdPhotoUrl.Key.AsGuid) {
return ssPhotoUrl;
}
if (attributeKey == IdIsEmailVerified.Key.AsGuid) {
return ssIsEmailVerified;
}
if (attributeKey == IdIsTermsAndConditionsAccepted.Key.AsGuid) {
return ssIsTermsAndConditionsAccepted;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssKey = (string) other.AttributeGet(IdKey);
ssName = (string) other.AttributeGet(IdName);
ssEmail = (string) other.AttributeGet(IdEmail);
ssStatus = (string) other.AttributeGet(IdStatus);
ssLastLoginAt = (DateTime) other.AttributeGet(IdLastLoginAt);
ssIsActive = (bool) other.AttributeGet(IdIsActive);
ssPhotoUrl = (string) other.AttributeGet(IdPhotoUrl);
ssIsEmailVerified = (bool) other.AttributeGet(IdIsEmailVerified);
ssIsTermsAndConditionsAccepted = (bool) other.AttributeGet(IdIsTermsAndConditionsAccepted);
}
} // ST_3d98fcbf952bf72084dad4104cc8c43fStructure
/// <summary>
/// RecordList type <code>UserDetailList</code> that represents a record list of
///  <code>UserDetail</code>
/// </summary>
public partial class RL_c22ca0e0dff4c8c0d1575277d6d892be : GenericRecordList<ST_3d98fcbf952bf72084dad4104cc8c43fStructure>, IEnumerable, IEnumerator {

protected override ST_3d98fcbf952bf72084dad4104cc8c43fStructure GetElementDefaultValue() {
return new ST_3d98fcbf952bf72084dad4104cc8c43fStructure();
}

public T[] ToArray<T>(Func<ST_3d98fcbf952bf72084dad4104cc8c43fStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_c22ca0e0dff4c8c0d1575277d6d892be recordList, Func<ST_3d98fcbf952bf72084dad4104cc8c43fStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_c22ca0e0dff4c8c0d1575277d6d892be(ST_3d98fcbf952bf72084dad4104cc8c43fStructure[] array) {
  RL_c22ca0e0dff4c8c0d1575277d6d892be result = new RL_c22ca0e0dff4c8c0d1575277d6d892be();
result.InnerFromArray(array);
    return result;
}

public static RL_c22ca0e0dff4c8c0d1575277d6d892be ToList<T>(T[] array, Func <T, ST_3d98fcbf952bf72084dad4104cc8c43fStructure> converter) {
  RL_c22ca0e0dff4c8c0d1575277d6d892be result = new RL_c22ca0e0dff4c8c0d1575277d6d892be();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_c22ca0e0dff4c8c0d1575277d6d892be FromRestList<T>(RestList<T> restList, Func <T, ST_3d98fcbf952bf72084dad4104cc8c43fStructure> converter) {
  RL_c22ca0e0dff4c8c0d1575277d6d892be result = new RL_c22ca0e0dff4c8c0d1575277d6d892be();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_c22ca0e0dff4c8c0d1575277d6d892be() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_3d98fcbf952bf72084dad4104cc8c43fStructure> NewList() {
return new RL_c22ca0e0dff4c8c0d1575277d6d892be();
}


} // RL_c22ca0e0dff4c8c0d1575277d6d892be
}

