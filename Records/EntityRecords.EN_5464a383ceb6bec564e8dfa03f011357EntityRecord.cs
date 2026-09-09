using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] ProposalApproval (O0rutuZkrkGjOw9NEzD6AA)
///  <code>EN_5464a383ceb6bec564e8dfa03f011357EntityRecord</code> that represent
/// s <code>ProposalApproval</code> <p>Description: Entity that holds the Proposal Approval definitions
///  and current level..</p>
/// </summary>
// Name: ProposalApproval
public partial struct EN_5464a383ceb6bec564e8dfa03f011357EntityRecord : ITypedRecord<EN_5464a383ceb6bec564e8dfa03f011357EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*PyFMILLVaEa6zq2gf5lz2g");
internal static readonly GlobalObjectKey IdProposalId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*f77G0frxc0a3YPMdWQEXgQ");
internal static readonly GlobalObjectKey IdProcessTypeCode = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*734BEKomykyB9XD7QZPRVw");
internal static readonly GlobalObjectKey IdApprovalProcessVersion = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*AwgHwuwDJUioLkfZTHj9YA");
internal static readonly GlobalObjectKey IdCurrentLevel_DEPREC = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*5u6DbQEJ8ESUwlwIbR7DgA");
internal static readonly GlobalObjectKey IdMaxLevel_DEPREC = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Gn4ouFoU+0+9zJBACFHOfg");
internal static readonly GlobalObjectKey IdStartedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*QFepxQzNCkyzbfqfiSY5Jg");
internal static readonly GlobalObjectKey IdFinishedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*jxYacX3zpEyIGTfTGMXytw");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(8,true);
          _ssId = value;
      }
  }
}

private long _ssProposalId;
public long ssProposalId{
  get{
      return _ssProposalId;
  }
  set{
      if((_ssProposalId!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssProposalId = value;
      }
  }
}

private string _ssProcessTypeCode;
public string ssProcessTypeCode{
  get{
      return _ssProcessTypeCode;
  }
  set{
      if((_ssProcessTypeCode!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssProcessTypeCode = value;
      }
  }
}

private string _ssApprovalProcessVersion;
public string ssApprovalProcessVersion{
  get{
      return _ssApprovalProcessVersion;
  }
  set{
      if((_ssApprovalProcessVersion!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssApprovalProcessVersion = value;
      }
  }
}

private int _ssCurrentLevel_DEPREC;
public int ssCurrentLevel_DEPREC{
  get{
      return _ssCurrentLevel_DEPREC;
  }
  set{
      if((_ssCurrentLevel_DEPREC!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssCurrentLevel_DEPREC = value;
      }
  }
}

private int _ssMaxLevel_DEPREC;
public int ssMaxLevel_DEPREC{
  get{
      return _ssMaxLevel_DEPREC;
  }
  set{
      if((_ssMaxLevel_DEPREC!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssMaxLevel_DEPREC = value;
      }
  }
}

private DateTime _ssStartedOn;
public DateTime ssStartedOn{
  get{
      return _ssStartedOn;
  }
  set{
      if((_ssStartedOn!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssStartedOn = value;
      }
  }
}

private DateTime _ssFinishedOn;
public DateTime ssFinishedOn{
  get{
      return _ssFinishedOn;
  }
  set{
      if((_ssFinishedOn!=value) || OptimizedAttributes[7]){
          ChangedAttributes[7] = true;
          _ssFinishedOn = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_5464a383ceb6bec564e8dfa03f011357EntityRecord() {
ChangedAttributes = new BitArray(8,true);
OptimizedAttributes = new BitArray(8,false);
_ssId = 0L;
_ssProposalId = 0L;
_ssProcessTypeCode = "";
_ssApprovalProcessVersion = "";
_ssCurrentLevel_DEPREC = 0;
_ssMaxLevel_DEPREC = 0;
_ssStartedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssFinishedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
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
ssId = r.ReadLongInteger(index++, "ProposalApproval.Id", 0L);
ssProposalId = r.ReadEntityReferenceLongInteger(index++, "ProposalApproval.ProposalId", 0L);
ssProcessTypeCode = r.ReadText(index++, "ProposalApproval.ProcessTypeCode", "");
ssApprovalProcessVersion = r.ReadText(index++, "ProposalApproval.ApprovalProcessVersion", "");
ssCurrentLevel_DEPREC = r.ReadInteger(index++, "ProposalApproval.CurrentLevel_DEPREC", 0);
ssMaxLevel_DEPREC = r.ReadInteger(index++, "ProposalApproval.MaxLevel_DEPREC", 0);
ssStartedOn = r.ReadDateTime(index++, "ProposalApproval.StartedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssFinishedOn = r.ReadDateTime(index++, "ProposalApproval.FinishedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ChangedAttributes = new BitArray(8,false);
OptimizedAttributes = new BitArray(8,false);
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
public void ReadIM(EN_5464a383ceb6bec564e8dfa03f011357EntityRecord r) {
this = r;
}


public static bool operator == (EN_5464a383ceb6bec564e8dfa03f011357EntityRecord a, EN_5464a383ceb6bec564e8dfa03f011357EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssProposalId != b.ssProposalId) return false;
if (a.ssProcessTypeCode != b.ssProcessTypeCode) return false;
if (a.ssApprovalProcessVersion != b.ssApprovalProcessVersion) return false;
if (a.ssCurrentLevel_DEPREC != b.ssCurrentLevel_DEPREC) return false;
if (a.ssMaxLevel_DEPREC != b.ssMaxLevel_DEPREC) return false;
if (a.ssStartedOn != b.ssStartedOn) return false;
if (a.ssFinishedOn != b.ssFinishedOn) return false;
return true;
}

public static bool operator != (EN_5464a383ceb6bec564e8dfa03f011357EntityRecord a, EN_5464a383ceb6bec564e8dfa03f011357EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_5464a383ceb6bec564e8dfa03f011357EntityRecord)) return false;
return (this == (EN_5464a383ceb6bec564e8dfa03f011357EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssProposalId.GetHashCode()
 ^ ssProcessTypeCode.GetHashCode()
 ^ ssApprovalProcessVersion.GetHashCode()
 ^ ssCurrentLevel_DEPREC.GetHashCode()
 ^ ssMaxLevel_DEPREC.GetHashCode()
 ^ ssStartedOn.GetHashCode()
 ^ ssFinishedOn.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_5464a383ceb6bec564e8dfa03f011357EntityRecord Duplicate() {
EN_5464a383ceb6bec564e8dfa03f011357EntityRecord t;
t._ssId = this._ssId;
t._ssProposalId = this._ssProposalId;
t._ssProcessTypeCode = this._ssProcessTypeCode;
t._ssApprovalProcessVersion = this._ssApprovalProcessVersion;
t._ssCurrentLevel_DEPREC = this._ssCurrentLevel_DEPREC;
t._ssMaxLevel_DEPREC = this._ssMaxLevel_DEPREC;
t._ssStartedOn = this._ssStartedOn;
t._ssFinishedOn = this._ssFinishedOn;
t.ChangedAttributes = new BitArray(8);
t.OptimizedAttributes = new BitArray(8);
for(int i = 0; i < 8; i++){
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
} else if (head == "proposalid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProposalId")) variable.Value = ssProposalId; else variable.Optimized = true;
} else if (head == "processtypecode") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProcessTypeCode")) variable.Value = ssProcessTypeCode; else variable.Optimized = true;
} else if (head == "approvalprocessversion") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApprovalProcessVersion")) variable.Value = ssApprovalProcessVersion; else variable.Optimized = true;
} else if (head == "currentlevel_deprec") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CurrentLevel_DEPREC")) variable.Value = ssCurrentLevel_DEPREC; else variable.Optimized = true;
} else if (head == "maxlevel_deprec") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MaxLevel_DEPREC")) variable.Value = ssMaxLevel_DEPREC; else variable.Optimized = true;
} else if (head == "startedon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".StartedOn")) variable.Value = ssStartedOn; else variable.Optimized = true;
} else if (head == "finishedon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FinishedOn")) variable.Value = ssFinishedOn; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdProposalId)) {
return ChangedAttributes[1];
}
if (key.Equals(IdProcessTypeCode)) {
return ChangedAttributes[2];
}
if (key.Equals(IdApprovalProcessVersion)) {
return ChangedAttributes[3];
}
if (key.Equals(IdCurrentLevel_DEPREC)) {
return ChangedAttributes[4];
}
if (key.Equals(IdMaxLevel_DEPREC)) {
return ChangedAttributes[5];
}
if (key.Equals(IdStartedOn)) {
return ChangedAttributes[6];
}
if (key.Equals(IdFinishedOn)) {
return ChangedAttributes[7];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdProposalId)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdProcessTypeCode)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdApprovalProcessVersion)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdCurrentLevel_DEPREC)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdMaxLevel_DEPREC)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdStartedOn)) {
return OptimizedAttributes[6];
}
if (key.Equals(IdFinishedOn)) {
return OptimizedAttributes[7];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdProposalId) {
return ssProposalId;
}
if (key == IdProcessTypeCode) {
return ssProcessTypeCode;
}
if (key == IdApprovalProcessVersion) {
return ssApprovalProcessVersion;
}
if (key == IdCurrentLevel_DEPREC) {
return ssCurrentLevel_DEPREC;
}
if (key == IdMaxLevel_DEPREC) {
return ssMaxLevel_DEPREC;
}
if (key == IdStartedOn) {
return ssStartedOn;
}
if (key == IdFinishedOn) {
return ssFinishedOn;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdProposalId.Key.AsGuid) {
return ssProposalId;
}
if (attributeKey == IdProcessTypeCode.Key.AsGuid) {
return ssProcessTypeCode;
}
if (attributeKey == IdApprovalProcessVersion.Key.AsGuid) {
return ssApprovalProcessVersion;
}
if (attributeKey == IdCurrentLevel_DEPREC.Key.AsGuid) {
return ssCurrentLevel_DEPREC;
}
if (attributeKey == IdMaxLevel_DEPREC.Key.AsGuid) {
return ssMaxLevel_DEPREC;
}
if (attributeKey == IdStartedOn.Key.AsGuid) {
return ssStartedOn;
}
if (attributeKey == IdFinishedOn.Key.AsGuid) {
return ssFinishedOn;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(8);
OptimizedAttributes = new BitArray(8);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssProposalId = (long) other.AttributeGet(IdProposalId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdProposalId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdProposalId);
ssProcessTypeCode = (string) other.AttributeGet(IdProcessTypeCode);
ChangedAttributes[2] = other.ChangedAttributeGet(IdProcessTypeCode);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdProcessTypeCode);
ssApprovalProcessVersion = (string) other.AttributeGet(IdApprovalProcessVersion);
ChangedAttributes[3] = other.ChangedAttributeGet(IdApprovalProcessVersion);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdApprovalProcessVersion);
ssCurrentLevel_DEPREC = (int) other.AttributeGet(IdCurrentLevel_DEPREC);
ChangedAttributes[4] = other.ChangedAttributeGet(IdCurrentLevel_DEPREC);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdCurrentLevel_DEPREC);
ssMaxLevel_DEPREC = (int) other.AttributeGet(IdMaxLevel_DEPREC);
ChangedAttributes[5] = other.ChangedAttributeGet(IdMaxLevel_DEPREC);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdMaxLevel_DEPREC);
ssStartedOn = (DateTime) other.AttributeGet(IdStartedOn);
ChangedAttributes[6] = other.ChangedAttributeGet(IdStartedOn);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdStartedOn);
ssFinishedOn = (DateTime) other.AttributeGet(IdFinishedOn);
ChangedAttributes[7] = other.ChangedAttributeGet(IdFinishedOn);
OptimizedAttributes[7] = other.OptimizedAttributeGet(IdFinishedOn);
}
} // EN_5464a383ceb6bec564e8dfa03f011357EntityRecord

/// <summary>
/// RecordList type <code>ProposalApprovalList</code> that represents a record list of
///  <code>ProposalApproval</code>
/// </summary>
public partial class RL_135414b1fac020b915ff2fefcf2ea49e : GenericRecordList<EN_5464a383ceb6bec564e8dfa03f011357EntityRecord>, IEnumerable, IEnumerator {

protected override EN_5464a383ceb6bec564e8dfa03f011357EntityRecord GetElementDefaultValue() {
return new EN_5464a383ceb6bec564e8dfa03f011357EntityRecord();
}

public T[] ToArray<T>(Func<EN_5464a383ceb6bec564e8dfa03f011357EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_135414b1fac020b915ff2fefcf2ea49e recordList, Func<EN_5464a383ceb6bec564e8dfa03f011357EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_135414b1fac020b915ff2fefcf2ea49e(EN_5464a383ceb6bec564e8dfa03f011357EntityRecord[] array) {
  RL_135414b1fac020b915ff2fefcf2ea49e result = new RL_135414b1fac020b915ff2fefcf2ea49e();
result.InnerFromArray(array);
    return result;
}

public static RL_135414b1fac020b915ff2fefcf2ea49e ToList<T>(T[] array, Func <T, EN_5464a383ceb6bec564e8dfa03f011357EntityRecord> converter) {
  RL_135414b1fac020b915ff2fefcf2ea49e result = new RL_135414b1fac020b915ff2fefcf2ea49e();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_135414b1fac020b915ff2fefcf2ea49e FromRestList<T>(RestList<T> restList, Func <T, EN_5464a383ceb6bec564e8dfa03f011357EntityRecord> converter) {
  RL_135414b1fac020b915ff2fefcf2ea49e result = new RL_135414b1fac020b915ff2fefcf2ea49e();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_135414b1fac020b915ff2fefcf2ea49e() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_5464a383ceb6bec564e8dfa03f011357EntityRecord> NewList() {
return new RL_135414b1fac020b915ff2fefcf2ea49e();
}


} // RL_135414b1fac020b915ff2fefcf2ea49e
}
