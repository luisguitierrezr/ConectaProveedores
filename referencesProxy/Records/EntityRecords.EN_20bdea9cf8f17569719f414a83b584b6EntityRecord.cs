using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {

/// <summary>
/// [ReferenceEntity] UserApplicationRoleTemp (CaBA8_TIoEy_MhkCnTLRTw)
///  <code>EN_20bdea9cf8f17569719f414a83b584b6EntityRecord</code> that represent
/// s <code>UserApplicationRoleTemp</code> <p>Description: Entity that holds user temporary roles </p>
/// </summary>
// Name: UserApplicationRoleTemp
public partial struct EN_20bdea9cf8f17569719f414a83b584b6EntityRecord : ITypedRecord<EN_20bdea9cf8f17569719f414a83b584b6EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("eiqzl1RRZEO7QhTR8NH5Yg*bdqUb6XN00OabqtA1+bK4g");
internal static readonly GlobalObjectKey IdUserId = GlobalObjectKey.Parse("eiqzl1RRZEO7QhTR8NH5Yg*mKLlZg0n30meheUrMa8E1g");
internal static readonly GlobalObjectKey IdApplicationRoleId = GlobalObjectKey.Parse("eiqzl1RRZEO7QhTR8NH5Yg*QIScUHJsUkaxnV8T_1YFbA");
internal static readonly GlobalObjectKey IdEntraRoleId = GlobalObjectKey.Parse("eiqzl1RRZEO7QhTR8NH5Yg*pO9LBxxVgE2YHxIMGU01fw");
internal static readonly GlobalObjectKey IdAssignedBy = GlobalObjectKey.Parse("eiqzl1RRZEO7QhTR8NH5Yg*9hb7dU8j20+H7QofW0FYYg");
internal static readonly GlobalObjectKey IdAssignedDate = GlobalObjectKey.Parse("eiqzl1RRZEO7QhTR8NH5Yg*7S_Y+hKuD0mnD_GW374QXw");
internal static readonly GlobalObjectKey IdRoleStatusId = GlobalObjectKey.Parse("eiqzl1RRZEO7QhTR8NH5Yg*XGWD5IV3yUaWkrg6KNHyFg");
internal static readonly GlobalObjectKey IdRevokedBy = GlobalObjectKey.Parse("eiqzl1RRZEO7QhTR8NH5Yg*1s92tuZJP0S8uasmtPR0xA");
internal static readonly GlobalObjectKey IdRevokedDate = GlobalObjectKey.Parse("eiqzl1RRZEO7QhTR8NH5Yg*r8deSKgdPU2+DQfJABhKDQ");
internal static readonly GlobalObjectKey IdDateFrom = GlobalObjectKey.Parse("eiqzl1RRZEO7QhTR8NH5Yg*sKQ6TM4zMkavPsFn2xPiCA");
internal static readonly GlobalObjectKey IdDateTo = GlobalObjectKey.Parse("eiqzl1RRZEO7QhTR8NH5Yg*VLtYOaFGxES_QjWg77uKRg");
internal static readonly GlobalObjectKey IdLastUpdatedOn = GlobalObjectKey.Parse("eiqzl1RRZEO7QhTR8NH5Yg*SCfPMyld8Eq_Vpo4XRcz9Q");
internal static readonly GlobalObjectKey IdConceptId = GlobalObjectKey.Parse("eiqzl1RRZEO7QhTR8NH5Yg*Pw3hUHGhP02UQWiVGzfDUw");
internal static readonly GlobalObjectKey IdRegionToBeAssign = GlobalObjectKey.Parse("eiqzl1RRZEO7QhTR8NH5Yg*i+1c8ged50e0Ts6LmqlbkA");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(14,true);
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

private long _ssEntraRoleId;
public long ssEntraRoleId{
  get{
      return _ssEntraRoleId;
  }
  set{
      if((_ssEntraRoleId!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssEntraRoleId = value;
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

private DateTime _ssDateFrom;
public DateTime ssDateFrom{
  get{
      return _ssDateFrom;
  }
  set{
      if((_ssDateFrom!=value) || OptimizedAttributes[9]){
          ChangedAttributes[9] = true;
          _ssDateFrom = value;
      }
  }
}

private DateTime _ssDateTo;
public DateTime ssDateTo{
  get{
      return _ssDateTo;
  }
  set{
      if((_ssDateTo!=value) || OptimizedAttributes[10]){
          ChangedAttributes[10] = true;
          _ssDateTo = value;
      }
  }
}

private DateTime _ssLastUpdatedOn;
public DateTime ssLastUpdatedOn{
  get{
      return _ssLastUpdatedOn;
  }
  set{
      if((_ssLastUpdatedOn!=value) || OptimizedAttributes[11]){
          ChangedAttributes[11] = true;
          _ssLastUpdatedOn = value;
      }
  }
}

private int _ssConceptId;
public int ssConceptId{
  get{
      return _ssConceptId;
  }
  set{
      if((_ssConceptId!=value) || OptimizedAttributes[12]){
          ChangedAttributes[12] = true;
          _ssConceptId = value;
      }
  }
}

private string _ssRegionToBeAssign;
public string ssRegionToBeAssign{
  get{
      return _ssRegionToBeAssign;
  }
  set{
      if((_ssRegionToBeAssign!=value) || OptimizedAttributes[13]){
          ChangedAttributes[13] = true;
          _ssRegionToBeAssign = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_20bdea9cf8f17569719f414a83b584b6EntityRecord() {
ChangedAttributes = new BitArray(14,true);
OptimizedAttributes = new BitArray(14,false);
_ssId = 0L;
_ssUserId = "";
_ssApplicationRoleId = 0L;
_ssEntraRoleId = 0L;
_ssAssignedBy = "";
_ssAssignedDate = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssRoleStatusId = 0;
_ssRevokedBy = "";
_ssRevokedDate = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssDateFrom = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssDateTo = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssLastUpdatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssConceptId = 0;
_ssRegionToBeAssign = "";
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
ssId = r.ReadLongInteger(index++, "UserApplicationRoleTemp.Id", 0L);
ssUserId = r.ReadEntityReferenceText(index++, "UserApplicationRoleTemp.UserId", "");
ssApplicationRoleId = r.ReadEntityReferenceLongInteger(index++, "UserApplicationRoleTemp.ApplicationRoleId", 0L);
ssEntraRoleId = r.ReadEntityReferenceLongInteger(index++, "UserApplicationRoleTemp.EntraRoleId", 0L);
ssAssignedBy = r.ReadEntityReferenceText(index++, "UserApplicationRoleTemp.AssignedBy", "");
ssAssignedDate = r.ReadDate(index++, "UserApplicationRoleTemp.AssignedDate", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssRoleStatusId = r.ReadEntityReference(index++, "UserApplicationRoleTemp.RoleStatusId", 0);
ssRevokedBy = r.ReadEntityReferenceText(index++, "UserApplicationRoleTemp.RevokedBy", "");
ssRevokedDate = r.ReadDate(index++, "UserApplicationRoleTemp.RevokedDate", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssDateFrom = r.ReadDate(index++, "UserApplicationRoleTemp.DateFrom", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssDateTo = r.ReadDate(index++, "UserApplicationRoleTemp.DateTo", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssLastUpdatedOn = r.ReadDateTime(index++, "UserApplicationRoleTemp.LastUpdatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssConceptId = r.ReadEntityReference(index++, "UserApplicationRoleTemp.ConceptId", 0);
ssRegionToBeAssign = r.ReadText(index++, "UserApplicationRoleTemp.RegionToBeAssign", "");
ChangedAttributes = new BitArray(14,false);
OptimizedAttributes = new BitArray(14,false);
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
public void ReadIM(EN_20bdea9cf8f17569719f414a83b584b6EntityRecord r) {
this = r;
}


public static bool operator == (EN_20bdea9cf8f17569719f414a83b584b6EntityRecord a, EN_20bdea9cf8f17569719f414a83b584b6EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssUserId != b.ssUserId) return false;
if (a.ssApplicationRoleId != b.ssApplicationRoleId) return false;
if (a.ssEntraRoleId != b.ssEntraRoleId) return false;
if (a.ssAssignedBy != b.ssAssignedBy) return false;
if (a.ssAssignedDate != b.ssAssignedDate) return false;
if (a.ssRoleStatusId != b.ssRoleStatusId) return false;
if (a.ssRevokedBy != b.ssRevokedBy) return false;
if (a.ssRevokedDate != b.ssRevokedDate) return false;
if (a.ssDateFrom != b.ssDateFrom) return false;
if (a.ssDateTo != b.ssDateTo) return false;
if (a.ssLastUpdatedOn != b.ssLastUpdatedOn) return false;
if (a.ssConceptId != b.ssConceptId) return false;
if (a.ssRegionToBeAssign != b.ssRegionToBeAssign) return false;
return true;
}

public static bool operator != (EN_20bdea9cf8f17569719f414a83b584b6EntityRecord a, EN_20bdea9cf8f17569719f414a83b584b6EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_20bdea9cf8f17569719f414a83b584b6EntityRecord)) return false;
return (this == (EN_20bdea9cf8f17569719f414a83b584b6EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssUserId.GetHashCode()
 ^ ssApplicationRoleId.GetHashCode()
 ^ ssEntraRoleId.GetHashCode()
 ^ ssAssignedBy.GetHashCode()
 ^ ssAssignedDate.GetHashCode()
 ^ ssRoleStatusId.GetHashCode()
 ^ ssRevokedBy.GetHashCode()
 ^ ssRevokedDate.GetHashCode()
 ^ ssDateFrom.GetHashCode()
 ^ ssDateTo.GetHashCode()
 ^ ssLastUpdatedOn.GetHashCode()
 ^ ssConceptId.GetHashCode()
 ^ ssRegionToBeAssign.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_20bdea9cf8f17569719f414a83b584b6EntityRecord Duplicate() {
EN_20bdea9cf8f17569719f414a83b584b6EntityRecord t;
t._ssId = this._ssId;
t._ssUserId = this._ssUserId;
t._ssApplicationRoleId = this._ssApplicationRoleId;
t._ssEntraRoleId = this._ssEntraRoleId;
t._ssAssignedBy = this._ssAssignedBy;
t._ssAssignedDate = this._ssAssignedDate;
t._ssRoleStatusId = this._ssRoleStatusId;
t._ssRevokedBy = this._ssRevokedBy;
t._ssRevokedDate = this._ssRevokedDate;
t._ssDateFrom = this._ssDateFrom;
t._ssDateTo = this._ssDateTo;
t._ssLastUpdatedOn = this._ssLastUpdatedOn;
t._ssConceptId = this._ssConceptId;
t._ssRegionToBeAssign = this._ssRegionToBeAssign;
t.ChangedAttributes = new BitArray(14);
t.OptimizedAttributes = new BitArray(14);
for(int i = 0; i < 14; i++){
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
} else if (head == "entraroleid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EntraRoleId")) variable.Value = ssEntraRoleId; else variable.Optimized = true;
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
} else if (head == "datefrom") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DateFrom")) variable.Value = ssDateFrom; else variable.Optimized = true;
} else if (head == "dateto") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DateTo")) variable.Value = ssDateTo; else variable.Optimized = true;
} else if (head == "lastupdatedon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".LastUpdatedOn")) variable.Value = ssLastUpdatedOn; else variable.Optimized = true;
} else if (head == "conceptid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ConceptId")) variable.Value = ssConceptId; else variable.Optimized = true;
} else if (head == "regiontobeassign") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RegionToBeAssign")) variable.Value = ssRegionToBeAssign; else variable.Optimized = true;
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
if (key.Equals(IdEntraRoleId)) {
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
if (key.Equals(IdDateFrom)) {
return ChangedAttributes[9];
}
if (key.Equals(IdDateTo)) {
return ChangedAttributes[10];
}
if (key.Equals(IdLastUpdatedOn)) {
return ChangedAttributes[11];
}
if (key.Equals(IdConceptId)) {
return ChangedAttributes[12];
}
if (key.Equals(IdRegionToBeAssign)) {
return ChangedAttributes[13];
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
if (key.Equals(IdEntraRoleId)) {
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
if (key.Equals(IdDateFrom)) {
return OptimizedAttributes[9];
}
if (key.Equals(IdDateTo)) {
return OptimizedAttributes[10];
}
if (key.Equals(IdLastUpdatedOn)) {
return OptimizedAttributes[11];
}
if (key.Equals(IdConceptId)) {
return OptimizedAttributes[12];
}
if (key.Equals(IdRegionToBeAssign)) {
return OptimizedAttributes[13];
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
if (key == IdEntraRoleId) {
return ssEntraRoleId;
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
if (key == IdDateFrom) {
return ssDateFrom;
}
if (key == IdDateTo) {
return ssDateTo;
}
if (key == IdLastUpdatedOn) {
return ssLastUpdatedOn;
}
if (key == IdConceptId) {
return ssConceptId;
}
if (key == IdRegionToBeAssign) {
return ssRegionToBeAssign;
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
if (attributeKey == IdEntraRoleId.Key.AsGuid) {
return ssEntraRoleId;
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
if (attributeKey == IdDateFrom.Key.AsGuid) {
return ssDateFrom;
}
if (attributeKey == IdDateTo.Key.AsGuid) {
return ssDateTo;
}
if (attributeKey == IdLastUpdatedOn.Key.AsGuid) {
return ssLastUpdatedOn;
}
if (attributeKey == IdConceptId.Key.AsGuid) {
return ssConceptId;
}
if (attributeKey == IdRegionToBeAssign.Key.AsGuid) {
return ssRegionToBeAssign;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(14);
OptimizedAttributes = new BitArray(14);
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
ssEntraRoleId = (long) other.AttributeGet(IdEntraRoleId);
ChangedAttributes[3] = other.ChangedAttributeGet(IdEntraRoleId);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdEntraRoleId);
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
ssDateFrom = (DateTime) other.AttributeGet(IdDateFrom);
ChangedAttributes[9] = other.ChangedAttributeGet(IdDateFrom);
OptimizedAttributes[9] = other.OptimizedAttributeGet(IdDateFrom);
ssDateTo = (DateTime) other.AttributeGet(IdDateTo);
ChangedAttributes[10] = other.ChangedAttributeGet(IdDateTo);
OptimizedAttributes[10] = other.OptimizedAttributeGet(IdDateTo);
ssLastUpdatedOn = (DateTime) other.AttributeGet(IdLastUpdatedOn);
ChangedAttributes[11] = other.ChangedAttributeGet(IdLastUpdatedOn);
OptimizedAttributes[11] = other.OptimizedAttributeGet(IdLastUpdatedOn);
ssConceptId = (int) other.AttributeGet(IdConceptId);
ChangedAttributes[12] = other.ChangedAttributeGet(IdConceptId);
OptimizedAttributes[12] = other.OptimizedAttributeGet(IdConceptId);
ssRegionToBeAssign = (string) other.AttributeGet(IdRegionToBeAssign);
ChangedAttributes[13] = other.ChangedAttributeGet(IdRegionToBeAssign);
OptimizedAttributes[13] = other.OptimizedAttributeGet(IdRegionToBeAssign);
}
} // EN_20bdea9cf8f17569719f414a83b584b6EntityRecord

/// <summary>
/// RecordList type <code>UserApplicationRoleTempList</code> that represents a record list of
///  <code>UserApplicationRoleTemp</code>
/// </summary>
public partial class RL_495f5b77cbf797dce43cce0fbb302da2 : GenericRecordList<EN_20bdea9cf8f17569719f414a83b584b6EntityRecord>, IEnumerable, IEnumerator {

protected override EN_20bdea9cf8f17569719f414a83b584b6EntityRecord GetElementDefaultValue() {
return new EN_20bdea9cf8f17569719f414a83b584b6EntityRecord();
}

public T[] ToArray<T>(Func<EN_20bdea9cf8f17569719f414a83b584b6EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_495f5b77cbf797dce43cce0fbb302da2 recordList, Func<EN_20bdea9cf8f17569719f414a83b584b6EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_495f5b77cbf797dce43cce0fbb302da2(EN_20bdea9cf8f17569719f414a83b584b6EntityRecord[] array) {
  RL_495f5b77cbf797dce43cce0fbb302da2 result = new RL_495f5b77cbf797dce43cce0fbb302da2();
result.InnerFromArray(array);
    return result;
}

public static RL_495f5b77cbf797dce43cce0fbb302da2 ToList<T>(T[] array, Func <T, EN_20bdea9cf8f17569719f414a83b584b6EntityRecord> converter) {
  RL_495f5b77cbf797dce43cce0fbb302da2 result = new RL_495f5b77cbf797dce43cce0fbb302da2();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_495f5b77cbf797dce43cce0fbb302da2 FromRestList<T>(RestList<T> restList, Func <T, EN_20bdea9cf8f17569719f414a83b584b6EntityRecord> converter) {
  RL_495f5b77cbf797dce43cce0fbb302da2 result = new RL_495f5b77cbf797dce43cce0fbb302da2();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_495f5b77cbf797dce43cce0fbb302da2() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_20bdea9cf8f17569719f414a83b584b6EntityRecord> NewList() {
return new RL_495f5b77cbf797dce43cce0fbb302da2();
}


} // RL_495f5b77cbf797dce43cce0fbb302da2
}
