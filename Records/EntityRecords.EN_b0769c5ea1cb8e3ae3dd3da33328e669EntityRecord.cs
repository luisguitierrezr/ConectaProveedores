using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] ProposalLineApprovalLevel (0+0QqL4+kUWDPnjSxIOULg)
///  <code>EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord</code> that represent
/// s <code>ProposalLineApprovalLevel</code> <p>Description: Entity that holds the Proposal Line
///  Approval definitions.</p>
/// </summary>
// Name: ProposalLineApprovalLevel
public partial struct EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord : ITypedRecord<EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*rXw48uI0bUqATpUV34gSNg");
internal static readonly GlobalObjectKey IdProposalLineId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*soLsQq2ovkqX4emOR4HE5Q");
internal static readonly GlobalObjectKey IdProposalApprovalLevelId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*5ij5wxWSrUK6cjQ3EVBTUA");
internal static readonly GlobalObjectKey IdApplicationRoleId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*TDmdNiH87Eiy6j34GFKAhA");
internal static readonly GlobalObjectKey IdApprovalStatusId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*1jmzyDTPokuju_Xnqn6juw");
internal static readonly GlobalObjectKey IdApprovedBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*PKq9672de0KHqij3GRdhPg");
internal static readonly GlobalObjectKey IdApprovedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*7NdiMk6uJ0m4XNl4a11pKg");
internal static readonly GlobalObjectKey IdRejectedBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*vTnOpFQcu0K2+KYfboSz5g");
internal static readonly GlobalObjectKey IdRejectedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*qXprn84dck+W+wGWVr6T_w");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(9,true);
          _ssId = value;
      }
  }
}

private long _ssProposalLineId;
public long ssProposalLineId{
  get{
      return _ssProposalLineId;
  }
  set{
      if((_ssProposalLineId!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssProposalLineId = value;
      }
  }
}

private long _ssProposalApprovalLevelId;
public long ssProposalApprovalLevelId{
  get{
      return _ssProposalApprovalLevelId;
  }
  set{
      if((_ssProposalApprovalLevelId!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssProposalApprovalLevelId = value;
      }
  }
}

private long _ssApplicationRoleId;
public long ssApplicationRoleId{
  get{
      return _ssApplicationRoleId;
  }
  set{
      if((_ssApplicationRoleId!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssApplicationRoleId = value;
      }
  }
}

private int _ssApprovalStatusId;
public int ssApprovalStatusId{
  get{
      return _ssApprovalStatusId;
  }
  set{
      if((_ssApprovalStatusId!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
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
      if((_ssApprovedBy!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
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
      if((_ssApprovedOn!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
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
      if((_ssRejectedBy!=value) || OptimizedAttributes[7]){
          ChangedAttributes[7] = true;
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
      if((_ssRejectedOn!=value) || OptimizedAttributes[8]){
          ChangedAttributes[8] = true;
          _ssRejectedOn = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord() {
ChangedAttributes = new BitArray(9,true);
OptimizedAttributes = new BitArray(9,false);
_ssId = 0L;
_ssProposalLineId = 0L;
_ssProposalApprovalLevelId = 0L;
_ssApplicationRoleId = 0L;
_ssApprovalStatusId = 0;
_ssApprovedBy = "";
_ssApprovedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssRejectedBy = "";
_ssRejectedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
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
ssId = r.ReadLongInteger(index++, "ProposalLineApprovalLevel.Id", 0L);
ssProposalLineId = r.ReadEntityReferenceLongInteger(index++, "ProposalLineApprovalLevel.ProposalLineId", 0L);
ssProposalApprovalLevelId = r.ReadEntityReferenceLongInteger(index++, "ProposalLineApprovalLevel.ProposalApprovalLevelId", 0L);
ssApplicationRoleId = r.ReadEntityReferenceLongInteger(index++, "ProposalLineApprovalLevel.ApplicationRoleId", 0L);
ssApprovalStatusId = r.ReadEntityReference(index++, "ProposalLineApprovalLevel.ApprovalStatusId", 0);
ssApprovedBy = r.ReadEntityReferenceText(index++, "ProposalLineApprovalLevel.ApprovedBy", "");
ssApprovedOn = r.ReadDateTime(index++, "ProposalLineApprovalLevel.ApprovedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssRejectedBy = r.ReadEntityReferenceText(index++, "ProposalLineApprovalLevel.RejectedBy", "");
ssRejectedOn = r.ReadDateTime(index++, "ProposalLineApprovalLevel.RejectedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ChangedAttributes = new BitArray(9,false);
OptimizedAttributes = new BitArray(9,false);
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
public void ReadIM(EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord r) {
this = r;
}


public static bool operator == (EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord a, EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssProposalLineId != b.ssProposalLineId) return false;
if (a.ssProposalApprovalLevelId != b.ssProposalApprovalLevelId) return false;
if (a.ssApplicationRoleId != b.ssApplicationRoleId) return false;
if (a.ssApprovalStatusId != b.ssApprovalStatusId) return false;
if (a.ssApprovedBy != b.ssApprovedBy) return false;
if (a.ssApprovedOn != b.ssApprovedOn) return false;
if (a.ssRejectedBy != b.ssRejectedBy) return false;
if (a.ssRejectedOn != b.ssRejectedOn) return false;
return true;
}

public static bool operator != (EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord a, EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord)) return false;
return (this == (EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssProposalLineId.GetHashCode()
 ^ ssProposalApprovalLevelId.GetHashCode()
 ^ ssApplicationRoleId.GetHashCode()
 ^ ssApprovalStatusId.GetHashCode()
 ^ ssApprovedBy.GetHashCode()
 ^ ssApprovedOn.GetHashCode()
 ^ ssRejectedBy.GetHashCode()
 ^ ssRejectedOn.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord Duplicate() {
EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord t;
t._ssId = this._ssId;
t._ssProposalLineId = this._ssProposalLineId;
t._ssProposalApprovalLevelId = this._ssProposalApprovalLevelId;
t._ssApplicationRoleId = this._ssApplicationRoleId;
t._ssApprovalStatusId = this._ssApprovalStatusId;
t._ssApprovedBy = this._ssApprovedBy;
t._ssApprovedOn = this._ssApprovedOn;
t._ssRejectedBy = this._ssRejectedBy;
t._ssRejectedOn = this._ssRejectedOn;
t.ChangedAttributes = new BitArray(9);
t.OptimizedAttributes = new BitArray(9);
for(int i = 0; i < 9; i++){
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
} else if (head == "proposallineid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProposalLineId")) variable.Value = ssProposalLineId; else variable.Optimized = true;
} else if (head == "proposalapprovallevelid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProposalApprovalLevelId")) variable.Value = ssProposalApprovalLevelId; else variable.Optimized = true;
} else if (head == "applicationroleid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApplicationRoleId")) variable.Value = ssApplicationRoleId; else variable.Optimized = true;
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
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdProposalLineId)) {
return ChangedAttributes[1];
}
if (key.Equals(IdProposalApprovalLevelId)) {
return ChangedAttributes[2];
}
if (key.Equals(IdApplicationRoleId)) {
return ChangedAttributes[3];
}
if (key.Equals(IdApprovalStatusId)) {
return ChangedAttributes[4];
}
if (key.Equals(IdApprovedBy)) {
return ChangedAttributes[5];
}
if (key.Equals(IdApprovedOn)) {
return ChangedAttributes[6];
}
if (key.Equals(IdRejectedBy)) {
return ChangedAttributes[7];
}
if (key.Equals(IdRejectedOn)) {
return ChangedAttributes[8];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdProposalLineId)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdProposalApprovalLevelId)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdApplicationRoleId)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdApprovalStatusId)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdApprovedBy)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdApprovedOn)) {
return OptimizedAttributes[6];
}
if (key.Equals(IdRejectedBy)) {
return OptimizedAttributes[7];
}
if (key.Equals(IdRejectedOn)) {
return OptimizedAttributes[8];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdProposalLineId) {
return ssProposalLineId;
}
if (key == IdProposalApprovalLevelId) {
return ssProposalApprovalLevelId;
}
if (key == IdApplicationRoleId) {
return ssApplicationRoleId;
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
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdProposalLineId.Key.AsGuid) {
return ssProposalLineId;
}
if (attributeKey == IdProposalApprovalLevelId.Key.AsGuid) {
return ssProposalApprovalLevelId;
}
if (attributeKey == IdApplicationRoleId.Key.AsGuid) {
return ssApplicationRoleId;
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
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(9);
OptimizedAttributes = new BitArray(9);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssProposalLineId = (long) other.AttributeGet(IdProposalLineId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdProposalLineId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdProposalLineId);
ssProposalApprovalLevelId = (long) other.AttributeGet(IdProposalApprovalLevelId);
ChangedAttributes[2] = other.ChangedAttributeGet(IdProposalApprovalLevelId);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdProposalApprovalLevelId);
ssApplicationRoleId = (long) other.AttributeGet(IdApplicationRoleId);
ChangedAttributes[3] = other.ChangedAttributeGet(IdApplicationRoleId);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdApplicationRoleId);
ssApprovalStatusId = (int) other.AttributeGet(IdApprovalStatusId);
ChangedAttributes[4] = other.ChangedAttributeGet(IdApprovalStatusId);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdApprovalStatusId);
ssApprovedBy = (string) other.AttributeGet(IdApprovedBy);
ChangedAttributes[5] = other.ChangedAttributeGet(IdApprovedBy);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdApprovedBy);
ssApprovedOn = (DateTime) other.AttributeGet(IdApprovedOn);
ChangedAttributes[6] = other.ChangedAttributeGet(IdApprovedOn);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdApprovedOn);
ssRejectedBy = (string) other.AttributeGet(IdRejectedBy);
ChangedAttributes[7] = other.ChangedAttributeGet(IdRejectedBy);
OptimizedAttributes[7] = other.OptimizedAttributeGet(IdRejectedBy);
ssRejectedOn = (DateTime) other.AttributeGet(IdRejectedOn);
ChangedAttributes[8] = other.ChangedAttributeGet(IdRejectedOn);
OptimizedAttributes[8] = other.OptimizedAttributeGet(IdRejectedOn);
}
} // EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord

/// <summary>
/// RecordList type <code>ProposalLineApprovalLevelList</code> that represents a record list of
///  <code>ProposalLineApprovalLevel</code>
/// </summary>
public partial class RL_fc8343aa76e2198e5cdceda44867eab0 : GenericRecordList<EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord>, IEnumerable, IEnumerator {

protected override EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord GetElementDefaultValue() {
return new EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord();
}

public T[] ToArray<T>(Func<EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_fc8343aa76e2198e5cdceda44867eab0 recordList, Func<EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_fc8343aa76e2198e5cdceda44867eab0(EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord[] array) {
  RL_fc8343aa76e2198e5cdceda44867eab0 result = new RL_fc8343aa76e2198e5cdceda44867eab0();
result.InnerFromArray(array);
    return result;
}

public static RL_fc8343aa76e2198e5cdceda44867eab0 ToList<T>(T[] array, Func <T, EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord> converter) {
  RL_fc8343aa76e2198e5cdceda44867eab0 result = new RL_fc8343aa76e2198e5cdceda44867eab0();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_fc8343aa76e2198e5cdceda44867eab0 FromRestList<T>(RestList<T> restList, Func <T, EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord> converter) {
  RL_fc8343aa76e2198e5cdceda44867eab0 result = new RL_fc8343aa76e2198e5cdceda44867eab0();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_fc8343aa76e2198e5cdceda44867eab0() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord> NewList() {
return new RL_fc8343aa76e2198e5cdceda44867eab0();
}


} // RL_fc8343aa76e2198e5cdceda44867eab0
}
