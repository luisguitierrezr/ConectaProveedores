using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [ReferenceEntity] UserApplicationRole (XaMLOYyAwUOGuFxWQZwFog)
///  <code>EN_d70717a411b3cebe926da612400b1467EntityRecord</code> that represent
/// s <code>UserApplicationRole</code> <p>Description: Entity that holds the user application role</p>
/// </summary>
// Name: UserApplicationRole
public partial struct EN_d70717a411b3cebe926da612400b1467EntityRecord : ITypedRecord<EN_d70717a411b3cebe926da612400b1467EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("eiqzl1RRZEO7QhTR8NH5Yg*GuuocnA3oECENfewLxzXuA");
internal static readonly GlobalObjectKey IdUserId = GlobalObjectKey.Parse("eiqzl1RRZEO7QhTR8NH5Yg*MtrJUGfl50yM_jgXVjPUdw");
internal static readonly GlobalObjectKey IdApplicationRoleId = GlobalObjectKey.Parse("eiqzl1RRZEO7QhTR8NH5Yg*my4onUYTzk+deroakuMF_A");
internal static readonly GlobalObjectKey IdRegionToBeAssign = GlobalObjectKey.Parse("eiqzl1RRZEO7QhTR8NH5Yg*cayNE9XLv0GwfDCMBFwa8A");
internal static readonly GlobalObjectKey IdAssignedBy = GlobalObjectKey.Parse("eiqzl1RRZEO7QhTR8NH5Yg*sd43pzGLo0mg6gbRQN4fmQ");
internal static readonly GlobalObjectKey IdAssignedDate = GlobalObjectKey.Parse("eiqzl1RRZEO7QhTR8NH5Yg*Z5FzF1JJIk2AWXkbQ58pcQ");
internal static readonly GlobalObjectKey IdRoleStatusId = GlobalObjectKey.Parse("eiqzl1RRZEO7QhTR8NH5Yg*V8aEY0+1nki2bRcVgInZmQ");
internal static readonly GlobalObjectKey IdRevokedBy = GlobalObjectKey.Parse("eiqzl1RRZEO7QhTR8NH5Yg*Z1ZIHNSCqUmyiZ6AGXDmOA");
internal static readonly GlobalObjectKey IdRevokedDate = GlobalObjectKey.Parse("eiqzl1RRZEO7QhTR8NH5Yg*AherlIwTl0uiLzJKqb4itg");
internal static readonly GlobalObjectKey IdConceptId = GlobalObjectKey.Parse("eiqzl1RRZEO7QhTR8NH5Yg*i3HfabylTE++KJthP3hSSQ");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(10,true);
          _ssId = value;
      }
  }
}

private string _ssUserId;
public string ssUserId{
  get{
      return _ssUserId;
  }
  set{
      if((_ssUserId!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssUserId = value;
      }
  }
}

private long _ssApplicationRoleId;
public long ssApplicationRoleId{
  get{
      return _ssApplicationRoleId;
  }
  set{
      if((_ssApplicationRoleId!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssApplicationRoleId = value;
      }
  }
}

private string _ssRegionToBeAssign;
public string ssRegionToBeAssign{
  get{
      return _ssRegionToBeAssign;
  }
  set{
      if((_ssRegionToBeAssign!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssRegionToBeAssign = value;
      }
  }
}

private string _ssAssignedBy;
public string ssAssignedBy{
  get{
      return _ssAssignedBy;
  }
  set{
      if((_ssAssignedBy!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssAssignedBy = value;
      }
  }
}

private DateTime _ssAssignedDate;
public DateTime ssAssignedDate{
  get{
      return _ssAssignedDate;
  }
  set{
      if((_ssAssignedDate!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssAssignedDate = value;
      }
  }
}

private int _ssRoleStatusId;
public int ssRoleStatusId{
  get{
      return _ssRoleStatusId;
  }
  set{
      if((_ssRoleStatusId!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssRoleStatusId = value;
      }
  }
}

private string _ssRevokedBy;
public string ssRevokedBy{
  get{
      return _ssRevokedBy;
  }
  set{
      if((_ssRevokedBy!=value) || OptimizedAttributes[7]){
          ChangedAttributes[7] = true;
          _ssRevokedBy = value;
      }
  }
}

private DateTime _ssRevokedDate;
public DateTime ssRevokedDate{
  get{
      return _ssRevokedDate;
  }
  set{
      if((_ssRevokedDate!=value) || OptimizedAttributes[8]){
          ChangedAttributes[8] = true;
          _ssRevokedDate = value;
      }
  }
}

private int _ssConceptId;
public int ssConceptId{
  get{
      return _ssConceptId;
  }
  set{
      if((_ssConceptId!=value) || OptimizedAttributes[9]){
          ChangedAttributes[9] = true;
          _ssConceptId = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_d70717a411b3cebe926da612400b1467EntityRecord() {
ChangedAttributes = new BitArray(10,true);
OptimizedAttributes = new BitArray(10,false);
_ssId = 0L;
_ssUserId = "";
_ssApplicationRoleId = 0L;
_ssRegionToBeAssign = "";
_ssAssignedBy = "";
_ssAssignedDate = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssRoleStatusId = 0;
_ssRevokedBy = "";
_ssRevokedDate = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssConceptId = 0;
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
ssId = r.ReadLongInteger(index++, "UserApplicationRole.Id", 0L);
ssUserId = r.ReadEntityReferenceText(index++, "UserApplicationRole.UserId", "");
ssApplicationRoleId = r.ReadEntityReferenceLongInteger(index++, "UserApplicationRole.ApplicationRoleId", 0L);
ssRegionToBeAssign = r.ReadText(index++, "UserApplicationRole.RegionToBeAssign", "");
ssAssignedBy = r.ReadEntityReferenceText(index++, "UserApplicationRole.AssignedBy", "");
ssAssignedDate = r.ReadDate(index++, "UserApplicationRole.AssignedDate", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssRoleStatusId = r.ReadEntityReference(index++, "UserApplicationRole.RoleStatusId", 0);
ssRevokedBy = r.ReadEntityReferenceText(index++, "UserApplicationRole.RevokedBy", "");
ssRevokedDate = r.ReadDate(index++, "UserApplicationRole.RevokedDate", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssConceptId = r.ReadEntityReference(index++, "UserApplicationRole.ConceptId", 0);
ChangedAttributes = new BitArray(10,false);
OptimizedAttributes = new BitArray(10,false);
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
public void ReadIM(EN_d70717a411b3cebe926da612400b1467EntityRecord r) {
this = r;
}


public static bool operator == (EN_d70717a411b3cebe926da612400b1467EntityRecord a, EN_d70717a411b3cebe926da612400b1467EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssUserId != b.ssUserId) return false;
if (a.ssApplicationRoleId != b.ssApplicationRoleId) return false;
if (a.ssRegionToBeAssign != b.ssRegionToBeAssign) return false;
if (a.ssAssignedBy != b.ssAssignedBy) return false;
if (a.ssAssignedDate != b.ssAssignedDate) return false;
if (a.ssRoleStatusId != b.ssRoleStatusId) return false;
if (a.ssRevokedBy != b.ssRevokedBy) return false;
if (a.ssRevokedDate != b.ssRevokedDate) return false;
if (a.ssConceptId != b.ssConceptId) return false;
return true;
}

public static bool operator != (EN_d70717a411b3cebe926da612400b1467EntityRecord a, EN_d70717a411b3cebe926da612400b1467EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_d70717a411b3cebe926da612400b1467EntityRecord)) return false;
return (this == (EN_d70717a411b3cebe926da612400b1467EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssUserId.GetHashCode()
 ^ ssApplicationRoleId.GetHashCode()
 ^ ssRegionToBeAssign.GetHashCode()
 ^ ssAssignedBy.GetHashCode()
 ^ ssAssignedDate.GetHashCode()
 ^ ssRoleStatusId.GetHashCode()
 ^ ssRevokedBy.GetHashCode()
 ^ ssRevokedDate.GetHashCode()
 ^ ssConceptId.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_d70717a411b3cebe926da612400b1467EntityRecord Duplicate() {
EN_d70717a411b3cebe926da612400b1467EntityRecord t;
t._ssId = this._ssId;
t._ssUserId = this._ssUserId;
t._ssApplicationRoleId = this._ssApplicationRoleId;
t._ssRegionToBeAssign = this._ssRegionToBeAssign;
t._ssAssignedBy = this._ssAssignedBy;
t._ssAssignedDate = this._ssAssignedDate;
t._ssRoleStatusId = this._ssRoleStatusId;
t._ssRevokedBy = this._ssRevokedBy;
t._ssRevokedDate = this._ssRevokedDate;
t._ssConceptId = this._ssConceptId;
t.ChangedAttributes = new BitArray(10);
t.OptimizedAttributes = new BitArray(10);
for(int i = 0; i < 10; i++){
  t.ChangedAttributes[i] = ChangedAttributes[i];
  t.OptimizedAttributes[i] = OptimizedAttributes[i];
}
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
} else if (head == "userid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UserId")) variable.Value = ssUserId; else variable.Optimized = true;
} else if (head == "applicationroleid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApplicationRoleId")) variable.Value = ssApplicationRoleId; else variable.Optimized = true;
} else if (head == "regiontobeassign") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RegionToBeAssign")) variable.Value = ssRegionToBeAssign; else variable.Optimized = true;
} else if (head == "assignedby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AssignedBy")) variable.Value = ssAssignedBy; else variable.Optimized = true;
} else if (head == "assigneddate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AssignedDate")) variable.Value = ssAssignedDate; else variable.Optimized = true;
} else if (head == "rolestatusid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RoleStatusId")) variable.Value = ssRoleStatusId; else variable.Optimized = true;
} else if (head == "revokedby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RevokedBy")) variable.Value = ssRevokedBy; else variable.Optimized = true;
} else if (head == "revokeddate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RevokedDate")) variable.Value = ssRevokedDate; else variable.Optimized = true;
} else if (head == "conceptid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ConceptId")) variable.Value = ssConceptId; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdUserId)) {
return ChangedAttributes[1];
}
if (key.Equals(IdApplicationRoleId)) {
return ChangedAttributes[2];
}
if (key.Equals(IdRegionToBeAssign)) {
return ChangedAttributes[3];
}
if (key.Equals(IdAssignedBy)) {
return ChangedAttributes[4];
}
if (key.Equals(IdAssignedDate)) {
return ChangedAttributes[5];
}
if (key.Equals(IdRoleStatusId)) {
return ChangedAttributes[6];
}
if (key.Equals(IdRevokedBy)) {
return ChangedAttributes[7];
}
if (key.Equals(IdRevokedDate)) {
return ChangedAttributes[8];
}
if (key.Equals(IdConceptId)) {
return ChangedAttributes[9];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdUserId)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdApplicationRoleId)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdRegionToBeAssign)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdAssignedBy)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdAssignedDate)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdRoleStatusId)) {
return OptimizedAttributes[6];
}
if (key.Equals(IdRevokedBy)) {
return OptimizedAttributes[7];
}
if (key.Equals(IdRevokedDate)) {
return OptimizedAttributes[8];
}
if (key.Equals(IdConceptId)) {
return OptimizedAttributes[9];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdUserId) {
return ssUserId;
}
if (key == IdApplicationRoleId) {
return ssApplicationRoleId;
}
if (key == IdRegionToBeAssign) {
return ssRegionToBeAssign;
}
if (key == IdAssignedBy) {
return ssAssignedBy;
}
if (key == IdAssignedDate) {
return ssAssignedDate;
}
if (key == IdRoleStatusId) {
return ssRoleStatusId;
}
if (key == IdRevokedBy) {
return ssRevokedBy;
}
if (key == IdRevokedDate) {
return ssRevokedDate;
}
if (key == IdConceptId) {
return ssConceptId;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdUserId.Key.AsGuid) {
return ssUserId;
}
if (attributeKey == IdApplicationRoleId.Key.AsGuid) {
return ssApplicationRoleId;
}
if (attributeKey == IdRegionToBeAssign.Key.AsGuid) {
return ssRegionToBeAssign;
}
if (attributeKey == IdAssignedBy.Key.AsGuid) {
return ssAssignedBy;
}
if (attributeKey == IdAssignedDate.Key.AsGuid) {
return ssAssignedDate;
}
if (attributeKey == IdRoleStatusId.Key.AsGuid) {
return ssRoleStatusId;
}
if (attributeKey == IdRevokedBy.Key.AsGuid) {
return ssRevokedBy;
}
if (attributeKey == IdRevokedDate.Key.AsGuid) {
return ssRevokedDate;
}
if (attributeKey == IdConceptId.Key.AsGuid) {
return ssConceptId;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(10);
OptimizedAttributes = new BitArray(10);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssUserId = (string) other.AttributeGet(IdUserId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdUserId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdUserId);
ssApplicationRoleId = (long) other.AttributeGet(IdApplicationRoleId);
ChangedAttributes[2] = other.ChangedAttributeGet(IdApplicationRoleId);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdApplicationRoleId);
ssRegionToBeAssign = (string) other.AttributeGet(IdRegionToBeAssign);
ChangedAttributes[3] = other.ChangedAttributeGet(IdRegionToBeAssign);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdRegionToBeAssign);
ssAssignedBy = (string) other.AttributeGet(IdAssignedBy);
ChangedAttributes[4] = other.ChangedAttributeGet(IdAssignedBy);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdAssignedBy);
ssAssignedDate = (DateTime) other.AttributeGet(IdAssignedDate);
ChangedAttributes[5] = other.ChangedAttributeGet(IdAssignedDate);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdAssignedDate);
ssRoleStatusId = (int) other.AttributeGet(IdRoleStatusId);
ChangedAttributes[6] = other.ChangedAttributeGet(IdRoleStatusId);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdRoleStatusId);
ssRevokedBy = (string) other.AttributeGet(IdRevokedBy);
ChangedAttributes[7] = other.ChangedAttributeGet(IdRevokedBy);
OptimizedAttributes[7] = other.OptimizedAttributeGet(IdRevokedBy);
ssRevokedDate = (DateTime) other.AttributeGet(IdRevokedDate);
ChangedAttributes[8] = other.ChangedAttributeGet(IdRevokedDate);
OptimizedAttributes[8] = other.OptimizedAttributeGet(IdRevokedDate);
ssConceptId = (int) other.AttributeGet(IdConceptId);
ChangedAttributes[9] = other.ChangedAttributeGet(IdConceptId);
OptimizedAttributes[9] = other.OptimizedAttributeGet(IdConceptId);
}
} // EN_d70717a411b3cebe926da612400b1467EntityRecord

/// <summary>
/// RecordList type <code>UserApplicationRoleList</code> that represents a record list of
///  <code>UserApplicationRole</code>
/// </summary>
public partial class RL_720377714fa7f8b9df77ff5f4a6856e1 : GenericRecordList<EN_d70717a411b3cebe926da612400b1467EntityRecord>, IEnumerable, IEnumerator {

protected override EN_d70717a411b3cebe926da612400b1467EntityRecord GetElementDefaultValue() {
return new EN_d70717a411b3cebe926da612400b1467EntityRecord();
}

public T[] ToArray<T>(Func<EN_d70717a411b3cebe926da612400b1467EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_720377714fa7f8b9df77ff5f4a6856e1 recordList, Func<EN_d70717a411b3cebe926da612400b1467EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_720377714fa7f8b9df77ff5f4a6856e1(EN_d70717a411b3cebe926da612400b1467EntityRecord[] array) {
  RL_720377714fa7f8b9df77ff5f4a6856e1 result = new RL_720377714fa7f8b9df77ff5f4a6856e1();
result.InnerFromArray(array);
    return result;
}

public static RL_720377714fa7f8b9df77ff5f4a6856e1 ToList<T>(T[] array, Func <T, EN_d70717a411b3cebe926da612400b1467EntityRecord> converter) {
  RL_720377714fa7f8b9df77ff5f4a6856e1 result = new RL_720377714fa7f8b9df77ff5f4a6856e1();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_720377714fa7f8b9df77ff5f4a6856e1 FromRestList<T>(RestList<T> restList, Func <T, EN_d70717a411b3cebe926da612400b1467EntityRecord> converter) {
  RL_720377714fa7f8b9df77ff5f4a6856e1 result = new RL_720377714fa7f8b9df77ff5f4a6856e1();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_720377714fa7f8b9df77ff5f4a6856e1() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_d70717a411b3cebe926da612400b1467EntityRecord> NewList() {
return new RL_720377714fa7f8b9df77ff5f4a6856e1();
}


} // RL_720377714fa7f8b9df77ff5f4a6856e1
}
