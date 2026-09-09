using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] OrderRequestFileApprovalLevel (suomIpUzQEWLszDICSi0WA)
///  <code>EN_80af67ecab8f43d464cc57955285a024EntityRecord</code> that represent
/// s <code>OrderRequestFileApprovalLevel</code> <p>Description: </p>
/// </summary>
// Name: OrderRequestFileApprovalLevel
public partial struct EN_80af67ecab8f43d464cc57955285a024EntityRecord : ITypedRecord<EN_80af67ecab8f43d464cc57955285a024EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*B7W89gsuQEKlnrRFEVIbpw");
internal static readonly GlobalObjectKey IdOrderRequestFileApprovalId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*_wvv3hO69kC2zzs6lbBLTA");
internal static readonly GlobalObjectKey IdLevelNumber = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*7WuH+Jgkd0mIZEhjPECZZg");
internal static readonly GlobalObjectKey IdEntraRoleId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*ClFgkJikiUuTPQSFRY9yPQ");
internal static readonly GlobalObjectKey IdAssignedTo = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*fqPjHlJCvkS0dtPrUc+IBg");
internal static readonly GlobalObjectKey IdApprovalStatusId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*cAuKyrjg10ymbEbXWZk_JA");
internal static readonly GlobalObjectKey IdApprovedBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*nKWJ_u06ikWm6QaUNLCbIg");
internal static readonly GlobalObjectKey IdApprovedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*p4LDmTqLG06MpauvJ5Z1kQ");
internal static readonly GlobalObjectKey IdRejectedBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*iHceK1j6UkyXZMpNAEVVMw");
internal static readonly GlobalObjectKey IdRejectedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*ix6vs90vekmN6GpSBo+wvQ");
internal static readonly GlobalObjectKey IdIsReassigned = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*yqe9LxOOgkC6cCUJ2Wo6bw");
internal static readonly GlobalObjectKey IdIsSubstituteFor = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*WEnq_lFE8UKRn_q2+NotLw");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(12,true);
          _ssId = value;
      }
  }
}

private long _ssOrderRequestFileApprovalId;
public long ssOrderRequestFileApprovalId{
  get{
      return _ssOrderRequestFileApprovalId;
  }
  set{
      if((_ssOrderRequestFileApprovalId!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssOrderRequestFileApprovalId = value;
      }
  }
}

private int _ssLevelNumber;
public int ssLevelNumber{
  get{
      return _ssLevelNumber;
  }
  set{
      if((_ssLevelNumber!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssLevelNumber = value;
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

private string _ssAssignedTo;
public string ssAssignedTo{
  get{
      return _ssAssignedTo;
  }
  set{
      if((_ssAssignedTo!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssAssignedTo = value;
      }
  }
}

private int _ssApprovalStatusId;
public int ssApprovalStatusId{
  get{
      return _ssApprovalStatusId;
  }
  set{
      if((_ssApprovalStatusId!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssApprovalStatusId = value;
      }
  }
}

private string _ssApprovedBy;
public string ssApprovedBy{
  get{
      return _ssApprovedBy;
  }
  set{
      if((_ssApprovedBy!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssApprovedBy = value;
      }
  }
}

private DateTime _ssApprovedOn;
public DateTime ssApprovedOn{
  get{
      return _ssApprovedOn;
  }
  set{
      if((_ssApprovedOn!=value) || OptimizedAttributes[7]){
          ChangedAttributes[7] = true;
          _ssApprovedOn = value;
      }
  }
}

private string _ssRejectedBy;
public string ssRejectedBy{
  get{
      return _ssRejectedBy;
  }
  set{
      if((_ssRejectedBy!=value) || OptimizedAttributes[8]){
          ChangedAttributes[8] = true;
          _ssRejectedBy = value;
      }
  }
}

private DateTime _ssRejectedOn;
public DateTime ssRejectedOn{
  get{
      return _ssRejectedOn;
  }
  set{
      if((_ssRejectedOn!=value) || OptimizedAttributes[9]){
          ChangedAttributes[9] = true;
          _ssRejectedOn = value;
      }
  }
}

private bool _ssIsReassigned;
public bool ssIsReassigned{
  get{
      return _ssIsReassigned;
  }
  set{
      if((_ssIsReassigned!=value) || OptimizedAttributes[10]){
          ChangedAttributes[10] = true;
          _ssIsReassigned = value;
      }
  }
}

private string _ssIsSubstituteFor;
public string ssIsSubstituteFor{
  get{
      return _ssIsSubstituteFor;
  }
  set{
      if((_ssIsSubstituteFor!=value) || OptimizedAttributes[11]){
          ChangedAttributes[11] = true;
          _ssIsSubstituteFor = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_80af67ecab8f43d464cc57955285a024EntityRecord() {
ChangedAttributes = new BitArray(12,true);
OptimizedAttributes = new BitArray(12,false);
_ssId = 0L;
_ssOrderRequestFileApprovalId = 0L;
_ssLevelNumber = 0;
_ssEntraRoleId = 0L;
_ssAssignedTo = "";
_ssApprovalStatusId = 0;
_ssApprovedBy = "";
_ssApprovedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssRejectedBy = "";
_ssRejectedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssIsReassigned = false;
_ssIsSubstituteFor = "";
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
ssId = r.ReadLongInteger(index++, "OrderRequestFileApprovalLevel.Id", 0L);
ssOrderRequestFileApprovalId = r.ReadEntityReferenceLongInteger(index++, "OrderRequestFileApprovalLevel.OrderRequestFileApprovalId", 0L);
ssLevelNumber = r.ReadInteger(index++, "OrderRequestFileApprovalLevel.LevelNumber", 0);
ssEntraRoleId = r.ReadEntityReferenceLongInteger(index++, "OrderRequestFileApprovalLevel.EntraRoleId", 0L);
ssAssignedTo = r.ReadEntityReferenceText(index++, "OrderRequestFileApprovalLevel.AssignedTo", "");
ssApprovalStatusId = r.ReadEntityReference(index++, "OrderRequestFileApprovalLevel.ApprovalStatusId", 0);
ssApprovedBy = r.ReadEntityReferenceText(index++, "OrderRequestFileApprovalLevel.ApprovedBy", "");
ssApprovedOn = r.ReadDateTime(index++, "OrderRequestFileApprovalLevel.ApprovedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssRejectedBy = r.ReadEntityReferenceText(index++, "OrderRequestFileApprovalLevel.RejectedBy", "");
ssRejectedOn = r.ReadDateTime(index++, "OrderRequestFileApprovalLevel.RejectedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssIsReassigned = r.ReadBoolean(index++, "OrderRequestFileApprovalLevel.IsReassigned", false);
ssIsSubstituteFor = r.ReadEntityReferenceText(index++, "OrderRequestFileApprovalLevel.IsSubstituteFor", "");
ChangedAttributes = new BitArray(12,false);
OptimizedAttributes = new BitArray(12,false);
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
public void ReadIM(EN_80af67ecab8f43d464cc57955285a024EntityRecord r) {
this = r;
}


public static bool operator == (EN_80af67ecab8f43d464cc57955285a024EntityRecord a, EN_80af67ecab8f43d464cc57955285a024EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssOrderRequestFileApprovalId != b.ssOrderRequestFileApprovalId) return false;
if (a.ssLevelNumber != b.ssLevelNumber) return false;
if (a.ssEntraRoleId != b.ssEntraRoleId) return false;
if (a.ssAssignedTo != b.ssAssignedTo) return false;
if (a.ssApprovalStatusId != b.ssApprovalStatusId) return false;
if (a.ssApprovedBy != b.ssApprovedBy) return false;
if (a.ssApprovedOn != b.ssApprovedOn) return false;
if (a.ssRejectedBy != b.ssRejectedBy) return false;
if (a.ssRejectedOn != b.ssRejectedOn) return false;
if (a.ssIsReassigned != b.ssIsReassigned) return false;
if (a.ssIsSubstituteFor != b.ssIsSubstituteFor) return false;
return true;
}

public static bool operator != (EN_80af67ecab8f43d464cc57955285a024EntityRecord a, EN_80af67ecab8f43d464cc57955285a024EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_80af67ecab8f43d464cc57955285a024EntityRecord)) return false;
return (this == (EN_80af67ecab8f43d464cc57955285a024EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssOrderRequestFileApprovalId.GetHashCode()
 ^ ssLevelNumber.GetHashCode()
 ^ ssEntraRoleId.GetHashCode()
 ^ ssAssignedTo.GetHashCode()
 ^ ssApprovalStatusId.GetHashCode()
 ^ ssApprovedBy.GetHashCode()
 ^ ssApprovedOn.GetHashCode()
 ^ ssRejectedBy.GetHashCode()
 ^ ssRejectedOn.GetHashCode()
 ^ ssIsReassigned.GetHashCode()
 ^ ssIsSubstituteFor.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_80af67ecab8f43d464cc57955285a024EntityRecord Duplicate() {
EN_80af67ecab8f43d464cc57955285a024EntityRecord t;
t._ssId = this._ssId;
t._ssOrderRequestFileApprovalId = this._ssOrderRequestFileApprovalId;
t._ssLevelNumber = this._ssLevelNumber;
t._ssEntraRoleId = this._ssEntraRoleId;
t._ssAssignedTo = this._ssAssignedTo;
t._ssApprovalStatusId = this._ssApprovalStatusId;
t._ssApprovedBy = this._ssApprovedBy;
t._ssApprovedOn = this._ssApprovedOn;
t._ssRejectedBy = this._ssRejectedBy;
t._ssRejectedOn = this._ssRejectedOn;
t._ssIsReassigned = this._ssIsReassigned;
t._ssIsSubstituteFor = this._ssIsSubstituteFor;
t.ChangedAttributes = new BitArray(12);
t.OptimizedAttributes = new BitArray(12);
for(int i = 0; i < 12; i++){
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
} else if (head == "orderrequestfileapprovalid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderRequestFileApprovalId")) variable.Value = ssOrderRequestFileApprovalId; else variable.Optimized = true;
} else if (head == "levelnumber") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".LevelNumber")) variable.Value = ssLevelNumber; else variable.Optimized = true;
} else if (head == "entraroleid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EntraRoleId")) variable.Value = ssEntraRoleId; else variable.Optimized = true;
} else if (head == "assignedto") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AssignedTo")) variable.Value = ssAssignedTo; else variable.Optimized = true;
} else if (head == "approvalstatusid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApprovalStatusId")) variable.Value = ssApprovalStatusId; else variable.Optimized = true;
} else if (head == "approvedby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApprovedBy")) variable.Value = ssApprovedBy; else variable.Optimized = true;
} else if (head == "approvedon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApprovedOn")) variable.Value = ssApprovedOn; else variable.Optimized = true;
} else if (head == "rejectedby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RejectedBy")) variable.Value = ssRejectedBy; else variable.Optimized = true;
} else if (head == "rejectedon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RejectedOn")) variable.Value = ssRejectedOn; else variable.Optimized = true;
} else if (head == "isreassigned") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsReassigned")) variable.Value = ssIsReassigned; else variable.Optimized = true;
} else if (head == "issubstitutefor") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsSubstituteFor")) variable.Value = ssIsSubstituteFor; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdOrderRequestFileApprovalId)) {
return ChangedAttributes[1];
}
if (key.Equals(IdLevelNumber)) {
return ChangedAttributes[2];
}
if (key.Equals(IdEntraRoleId)) {
return ChangedAttributes[3];
}
if (key.Equals(IdAssignedTo)) {
return ChangedAttributes[4];
}
if (key.Equals(IdApprovalStatusId)) {
return ChangedAttributes[5];
}
if (key.Equals(IdApprovedBy)) {
return ChangedAttributes[6];
}
if (key.Equals(IdApprovedOn)) {
return ChangedAttributes[7];
}
if (key.Equals(IdRejectedBy)) {
return ChangedAttributes[8];
}
if (key.Equals(IdRejectedOn)) {
return ChangedAttributes[9];
}
if (key.Equals(IdIsReassigned)) {
return ChangedAttributes[10];
}
if (key.Equals(IdIsSubstituteFor)) {
return ChangedAttributes[11];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdOrderRequestFileApprovalId)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdLevelNumber)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdEntraRoleId)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdAssignedTo)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdApprovalStatusId)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdApprovedBy)) {
return OptimizedAttributes[6];
}
if (key.Equals(IdApprovedOn)) {
return OptimizedAttributes[7];
}
if (key.Equals(IdRejectedBy)) {
return OptimizedAttributes[8];
}
if (key.Equals(IdRejectedOn)) {
return OptimizedAttributes[9];
}
if (key.Equals(IdIsReassigned)) {
return OptimizedAttributes[10];
}
if (key.Equals(IdIsSubstituteFor)) {
return OptimizedAttributes[11];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdOrderRequestFileApprovalId) {
return ssOrderRequestFileApprovalId;
}
if (key == IdLevelNumber) {
return ssLevelNumber;
}
if (key == IdEntraRoleId) {
return ssEntraRoleId;
}
if (key == IdAssignedTo) {
return ssAssignedTo;
}
if (key == IdApprovalStatusId) {
return ssApprovalStatusId;
}
if (key == IdApprovedBy) {
return ssApprovedBy;
}
if (key == IdApprovedOn) {
return ssApprovedOn;
}
if (key == IdRejectedBy) {
return ssRejectedBy;
}
if (key == IdRejectedOn) {
return ssRejectedOn;
}
if (key == IdIsReassigned) {
return ssIsReassigned;
}
if (key == IdIsSubstituteFor) {
return ssIsSubstituteFor;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdOrderRequestFileApprovalId.Key.AsGuid) {
return ssOrderRequestFileApprovalId;
}
if (attributeKey == IdLevelNumber.Key.AsGuid) {
return ssLevelNumber;
}
if (attributeKey == IdEntraRoleId.Key.AsGuid) {
return ssEntraRoleId;
}
if (attributeKey == IdAssignedTo.Key.AsGuid) {
return ssAssignedTo;
}
if (attributeKey == IdApprovalStatusId.Key.AsGuid) {
return ssApprovalStatusId;
}
if (attributeKey == IdApprovedBy.Key.AsGuid) {
return ssApprovedBy;
}
if (attributeKey == IdApprovedOn.Key.AsGuid) {
return ssApprovedOn;
}
if (attributeKey == IdRejectedBy.Key.AsGuid) {
return ssRejectedBy;
}
if (attributeKey == IdRejectedOn.Key.AsGuid) {
return ssRejectedOn;
}
if (attributeKey == IdIsReassigned.Key.AsGuid) {
return ssIsReassigned;
}
if (attributeKey == IdIsSubstituteFor.Key.AsGuid) {
return ssIsSubstituteFor;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(12);
OptimizedAttributes = new BitArray(12);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssOrderRequestFileApprovalId = (long) other.AttributeGet(IdOrderRequestFileApprovalId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdOrderRequestFileApprovalId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdOrderRequestFileApprovalId);
ssLevelNumber = (int) other.AttributeGet(IdLevelNumber);
ChangedAttributes[2] = other.ChangedAttributeGet(IdLevelNumber);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdLevelNumber);
ssEntraRoleId = (long) other.AttributeGet(IdEntraRoleId);
ChangedAttributes[3] = other.ChangedAttributeGet(IdEntraRoleId);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdEntraRoleId);
ssAssignedTo = (string) other.AttributeGet(IdAssignedTo);
ChangedAttributes[4] = other.ChangedAttributeGet(IdAssignedTo);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdAssignedTo);
ssApprovalStatusId = (int) other.AttributeGet(IdApprovalStatusId);
ChangedAttributes[5] = other.ChangedAttributeGet(IdApprovalStatusId);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdApprovalStatusId);
ssApprovedBy = (string) other.AttributeGet(IdApprovedBy);
ChangedAttributes[6] = other.ChangedAttributeGet(IdApprovedBy);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdApprovedBy);
ssApprovedOn = (DateTime) other.AttributeGet(IdApprovedOn);
ChangedAttributes[7] = other.ChangedAttributeGet(IdApprovedOn);
OptimizedAttributes[7] = other.OptimizedAttributeGet(IdApprovedOn);
ssRejectedBy = (string) other.AttributeGet(IdRejectedBy);
ChangedAttributes[8] = other.ChangedAttributeGet(IdRejectedBy);
OptimizedAttributes[8] = other.OptimizedAttributeGet(IdRejectedBy);
ssRejectedOn = (DateTime) other.AttributeGet(IdRejectedOn);
ChangedAttributes[9] = other.ChangedAttributeGet(IdRejectedOn);
OptimizedAttributes[9] = other.OptimizedAttributeGet(IdRejectedOn);
ssIsReassigned = (bool) other.AttributeGet(IdIsReassigned);
ChangedAttributes[10] = other.ChangedAttributeGet(IdIsReassigned);
OptimizedAttributes[10] = other.OptimizedAttributeGet(IdIsReassigned);
ssIsSubstituteFor = (string) other.AttributeGet(IdIsSubstituteFor);
ChangedAttributes[11] = other.ChangedAttributeGet(IdIsSubstituteFor);
OptimizedAttributes[11] = other.OptimizedAttributeGet(IdIsSubstituteFor);
}
} // EN_80af67ecab8f43d464cc57955285a024EntityRecord

/// <summary>
/// RecordList type <code>OrderRequestFileApprovalLevelList</code> that represents a record list of
///  <code>OrderRequestFileApprovalLevel</code>
/// </summary>
public partial class RL_68b22058200e3ba283f2d34061ddedeb : GenericRecordList<EN_80af67ecab8f43d464cc57955285a024EntityRecord>, IEnumerable, IEnumerator {

protected override EN_80af67ecab8f43d464cc57955285a024EntityRecord GetElementDefaultValue() {
return new EN_80af67ecab8f43d464cc57955285a024EntityRecord();
}

public T[] ToArray<T>(Func<EN_80af67ecab8f43d464cc57955285a024EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_68b22058200e3ba283f2d34061ddedeb recordList, Func<EN_80af67ecab8f43d464cc57955285a024EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_68b22058200e3ba283f2d34061ddedeb(EN_80af67ecab8f43d464cc57955285a024EntityRecord[] array) {
  RL_68b22058200e3ba283f2d34061ddedeb result = new RL_68b22058200e3ba283f2d34061ddedeb();
result.InnerFromArray(array);
    return result;
}

public static RL_68b22058200e3ba283f2d34061ddedeb ToList<T>(T[] array, Func <T, EN_80af67ecab8f43d464cc57955285a024EntityRecord> converter) {
  RL_68b22058200e3ba283f2d34061ddedeb result = new RL_68b22058200e3ba283f2d34061ddedeb();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_68b22058200e3ba283f2d34061ddedeb FromRestList<T>(RestList<T> restList, Func <T, EN_80af67ecab8f43d464cc57955285a024EntityRecord> converter) {
  RL_68b22058200e3ba283f2d34061ddedeb result = new RL_68b22058200e3ba283f2d34061ddedeb();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_68b22058200e3ba283f2d34061ddedeb() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_80af67ecab8f43d464cc57955285a024EntityRecord> NewList() {
return new RL_68b22058200e3ba283f2d34061ddedeb();
}


} // RL_68b22058200e3ba283f2d34061ddedeb
}
