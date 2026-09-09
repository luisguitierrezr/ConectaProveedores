using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] ProposalApprovalLevel (8pP0Cx5bpka39Oku_dxa3A)
///  <code>EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord</code> that represent
/// s <code>ProposalApprovalLevel</code> <p>Description: Entity that holds the Proposal Approval
///  Levels.</p>
/// </summary>
// Name: ProposalApprovalLevel
public partial struct EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord : ITypedRecord<EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*n13AbLljOEmLwEtMOkO6ew");
internal static readonly GlobalObjectKey IdProposalApprovalId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Acw331EbqkOEBVK_7C_5Rw");
internal static readonly GlobalObjectKey IdLevelNumber = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*srR14Aj6fkOHPYXvrkqAqw");
internal static readonly GlobalObjectKey IdApplicationRoleId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*n96bNvhNU0qxDraA_VhRIg");
internal static readonly GlobalObjectKey IdApprovalStatusId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*BHxX8pUGQUS32FPQcSC_sA");
internal static readonly GlobalObjectKey IdHasStarted = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*0323y7V3x0aVMyAaJsJlKw");
internal static readonly GlobalObjectKey IdHasFinished = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*wWUcYFtr60K4LH4NnCKQVw");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(7,true);
          _ssId = value;
      }
  }
}

private long _ssProposalApprovalId;
public long ssProposalApprovalId{
  get{
      return _ssProposalApprovalId;
  }
  set{
      if((_ssProposalApprovalId!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssProposalApprovalId = value;
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

private bool _ssHasStarted;
public bool ssHasStarted{
  get{
      return _ssHasStarted;
  }
  set{
      if((_ssHasStarted!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssHasStarted = value;
      }
  }
}

private bool _ssHasFinished;
public bool ssHasFinished{
  get{
      return _ssHasFinished;
  }
  set{
      if((_ssHasFinished!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssHasFinished = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord() {
ChangedAttributes = new BitArray(7,true);
OptimizedAttributes = new BitArray(7,false);
_ssId = 0L;
_ssProposalApprovalId = 0L;
_ssLevelNumber = 0;
_ssApplicationRoleId = 0L;
_ssApprovalStatusId = 0;
_ssHasStarted = false;
_ssHasFinished = false;
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
ssId = r.ReadLongInteger(index++, "ProposalApprovalLevel.Id", 0L);
ssProposalApprovalId = r.ReadEntityReferenceLongInteger(index++, "ProposalApprovalLevel.ProposalApprovalId", 0L);
ssLevelNumber = r.ReadInteger(index++, "ProposalApprovalLevel.LevelNumber", 0);
ssApplicationRoleId = r.ReadEntityReferenceLongInteger(index++, "ProposalApprovalLevel.ApplicationRoleId", 0L);
ssApprovalStatusId = r.ReadEntityReference(index++, "ProposalApprovalLevel.ApprovalStatusId", 0);
ssHasStarted = r.ReadBoolean(index++, "ProposalApprovalLevel.HasStarted", false);
ssHasFinished = r.ReadBoolean(index++, "ProposalApprovalLevel.HasFinished", false);
ChangedAttributes = new BitArray(7,false);
OptimizedAttributes = new BitArray(7,false);
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
public void ReadIM(EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord r) {
this = r;
}


public static bool operator == (EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord a, EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssProposalApprovalId != b.ssProposalApprovalId) return false;
if (a.ssLevelNumber != b.ssLevelNumber) return false;
if (a.ssApplicationRoleId != b.ssApplicationRoleId) return false;
if (a.ssApprovalStatusId != b.ssApprovalStatusId) return false;
if (a.ssHasStarted != b.ssHasStarted) return false;
if (a.ssHasFinished != b.ssHasFinished) return false;
return true;
}

public static bool operator != (EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord a, EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord)) return false;
return (this == (EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssProposalApprovalId.GetHashCode()
 ^ ssLevelNumber.GetHashCode()
 ^ ssApplicationRoleId.GetHashCode()
 ^ ssApprovalStatusId.GetHashCode()
 ^ ssHasStarted.GetHashCode()
 ^ ssHasFinished.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord Duplicate() {
EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord t;
t._ssId = this._ssId;
t._ssProposalApprovalId = this._ssProposalApprovalId;
t._ssLevelNumber = this._ssLevelNumber;
t._ssApplicationRoleId = this._ssApplicationRoleId;
t._ssApprovalStatusId = this._ssApprovalStatusId;
t._ssHasStarted = this._ssHasStarted;
t._ssHasFinished = this._ssHasFinished;
t.ChangedAttributes = new BitArray(7);
t.OptimizedAttributes = new BitArray(7);
for(int i = 0; i < 7; i++){
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
} else if (head == "proposalapprovalid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProposalApprovalId")) variable.Value = ssProposalApprovalId; else variable.Optimized = true;
} else if (head == "levelnumber") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".LevelNumber")) variable.Value = ssLevelNumber; else variable.Optimized = true;
} else if (head == "applicationroleid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApplicationRoleId")) variable.Value = ssApplicationRoleId; else variable.Optimized = true;
} else if (head == "approvalstatusid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApprovalStatusId")) variable.Value = ssApprovalStatusId; else variable.Optimized = true;
} else if (head == "hasstarted") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".HasStarted")) variable.Value = ssHasStarted; else variable.Optimized = true;
} else if (head == "hasfinished") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".HasFinished")) variable.Value = ssHasFinished; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdProposalApprovalId)) {
return ChangedAttributes[1];
}
if (key.Equals(IdLevelNumber)) {
return ChangedAttributes[2];
}
if (key.Equals(IdApplicationRoleId)) {
return ChangedAttributes[3];
}
if (key.Equals(IdApprovalStatusId)) {
return ChangedAttributes[4];
}
if (key.Equals(IdHasStarted)) {
return ChangedAttributes[5];
}
if (key.Equals(IdHasFinished)) {
return ChangedAttributes[6];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdProposalApprovalId)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdLevelNumber)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdApplicationRoleId)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdApprovalStatusId)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdHasStarted)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdHasFinished)) {
return OptimizedAttributes[6];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdProposalApprovalId) {
return ssProposalApprovalId;
}
if (key == IdLevelNumber) {
return ssLevelNumber;
}
if (key == IdApplicationRoleId) {
return ssApplicationRoleId;
}
if (key == IdApprovalStatusId) {
return ssApprovalStatusId;
}
if (key == IdHasStarted) {
return ssHasStarted;
}
if (key == IdHasFinished) {
return ssHasFinished;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdProposalApprovalId.Key.AsGuid) {
return ssProposalApprovalId;
}
if (attributeKey == IdLevelNumber.Key.AsGuid) {
return ssLevelNumber;
}
if (attributeKey == IdApplicationRoleId.Key.AsGuid) {
return ssApplicationRoleId;
}
if (attributeKey == IdApprovalStatusId.Key.AsGuid) {
return ssApprovalStatusId;
}
if (attributeKey == IdHasStarted.Key.AsGuid) {
return ssHasStarted;
}
if (attributeKey == IdHasFinished.Key.AsGuid) {
return ssHasFinished;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(7);
OptimizedAttributes = new BitArray(7);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssProposalApprovalId = (long) other.AttributeGet(IdProposalApprovalId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdProposalApprovalId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdProposalApprovalId);
ssLevelNumber = (int) other.AttributeGet(IdLevelNumber);
ChangedAttributes[2] = other.ChangedAttributeGet(IdLevelNumber);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdLevelNumber);
ssApplicationRoleId = (long) other.AttributeGet(IdApplicationRoleId);
ChangedAttributes[3] = other.ChangedAttributeGet(IdApplicationRoleId);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdApplicationRoleId);
ssApprovalStatusId = (int) other.AttributeGet(IdApprovalStatusId);
ChangedAttributes[4] = other.ChangedAttributeGet(IdApprovalStatusId);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdApprovalStatusId);
ssHasStarted = (bool) other.AttributeGet(IdHasStarted);
ChangedAttributes[5] = other.ChangedAttributeGet(IdHasStarted);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdHasStarted);
ssHasFinished = (bool) other.AttributeGet(IdHasFinished);
ChangedAttributes[6] = other.ChangedAttributeGet(IdHasFinished);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdHasFinished);
}
} // EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord

/// <summary>
/// RecordList type <code>ProposalApprovalLevelList</code> that represents a record list of
///  <code>ProposalApprovalLevel</code>
/// </summary>
public partial class RL_737028bf37e8efb242ad1e69f94b647f : GenericRecordList<EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord>, IEnumerable, IEnumerator {

protected override EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord GetElementDefaultValue() {
return new EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord();
}

public T[] ToArray<T>(Func<EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_737028bf37e8efb242ad1e69f94b647f recordList, Func<EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_737028bf37e8efb242ad1e69f94b647f(EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord[] array) {
  RL_737028bf37e8efb242ad1e69f94b647f result = new RL_737028bf37e8efb242ad1e69f94b647f();
result.InnerFromArray(array);
    return result;
}

public static RL_737028bf37e8efb242ad1e69f94b647f ToList<T>(T[] array, Func <T, EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord> converter) {
  RL_737028bf37e8efb242ad1e69f94b647f result = new RL_737028bf37e8efb242ad1e69f94b647f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_737028bf37e8efb242ad1e69f94b647f FromRestList<T>(RestList<T> restList, Func <T, EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord> converter) {
  RL_737028bf37e8efb242ad1e69f94b647f result = new RL_737028bf37e8efb242ad1e69f94b647f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_737028bf37e8efb242ad1e69f94b647f() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord> NewList() {
return new RL_737028bf37e8efb242ad1e69f94b647f();
}


} // RL_737028bf37e8efb242ad1e69f94b647f
}
