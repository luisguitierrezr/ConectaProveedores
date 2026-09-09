using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] OrderApprovalLevel (c1etxkcvZkG1NxvG8xu_gQ)
///  <code>EN_6b660d05e4c0025dff47119642875ca2EntityRecord</code> that represent
/// s <code>OrderApprovalLevel</code> <p>Description: </p>
/// </summary>
// Name: OrderApprovalLevel
public partial struct EN_6b660d05e4c0025dff47119642875ca2EntityRecord : ITypedRecord<EN_6b660d05e4c0025dff47119642875ca2EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*qBrH+iVf6kONOv+en1zm1w");
internal static readonly GlobalObjectKey IdOrderApprovalId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*vsGjzbZaZkifd0JG0Z5SNQ");
internal static readonly GlobalObjectKey IdLevelNumber = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*WlkCpMe3O0yFBfAi_EkhYA");
internal static readonly GlobalObjectKey IdEntraRoleId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*63pSp0onv0urGxikukovgw");
internal static readonly GlobalObjectKey IdAssignedTo = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*SDtSoPd_I0a_SZ0JvIoxqw");
internal static readonly GlobalObjectKey IdAssignedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*TztKqQMRr0CB6dbf99JsLw");
internal static readonly GlobalObjectKey IdApprovalStatusId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*P35Jcfeb10ajyDJrLtKa2g");
internal static readonly GlobalObjectKey IdApprovedBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*IFQZgCspF0WVt6cuK+_aaw");
internal static readonly GlobalObjectKey IdApprovedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*+wjm3Wm0UUSGjrc99KLX4Q");
internal static readonly GlobalObjectKey IdRejectedBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*1nBIs80mTU6O62YxlUbbFQ");
internal static readonly GlobalObjectKey IdRejectedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*tFTJ18LguUK_JFb6LZXtag");
internal static readonly GlobalObjectKey IdIsComplement = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Ag+epfCIUE+fLzCV8JzAOw");
internal static readonly GlobalObjectKey IdIsReassigned = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Du4TrLUZy0GLtQUeiboa6A");
internal static readonly GlobalObjectKey IdIsSubstituteFor = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*nizWghqoAkmZVAUKlm52VQ");
internal static readonly GlobalObjectKey IdToModifyBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*UEAEgnpFf0iH4FtXc9KLCQ");
internal static readonly GlobalObjectKey IdToModifyOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*cdjHNEMgZUmp2AtNZig9lw");
internal static readonly GlobalObjectKey IdWasCanceledBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*0dmAawj0EE6Jegu+vq+3bQ");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(17,true);
          _ssId = value;
      }
  }
}

private long _ssOrderApprovalId;
public long ssOrderApprovalId{
  get{
      return _ssOrderApprovalId;
  }
  set{
      if((_ssOrderApprovalId!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssOrderApprovalId = value;
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

private DateTime _ssAssignedOn;
public DateTime ssAssignedOn{
  get{
      return _ssAssignedOn;
  }
  set{
      if((_ssAssignedOn!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssAssignedOn = value;
      }
  }
}

private int _ssApprovalStatusId;
public int ssApprovalStatusId{
  get{
      return _ssApprovalStatusId;
  }
  set{
      if((_ssApprovalStatusId!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
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
      if((_ssApprovedBy!=value) || OptimizedAttributes[7]){
          ChangedAttributes[7] = true;
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
      if((_ssApprovedOn!=value) || OptimizedAttributes[8]){
          ChangedAttributes[8] = true;
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
      if((_ssRejectedBy!=value) || OptimizedAttributes[9]){
          ChangedAttributes[9] = true;
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
      if((_ssRejectedOn!=value) || OptimizedAttributes[10]){
          ChangedAttributes[10] = true;
          _ssRejectedOn = value;
      }
  }
}

private bool _ssIsComplement;
public bool ssIsComplement{
  get{
      return _ssIsComplement;
  }
  set{
      if((_ssIsComplement!=value) || OptimizedAttributes[11]){
          ChangedAttributes[11] = true;
          _ssIsComplement = value;
      }
  }
}

private bool _ssIsReassigned;
public bool ssIsReassigned{
  get{
      return _ssIsReassigned;
  }
  set{
      if((_ssIsReassigned!=value) || OptimizedAttributes[12]){
          ChangedAttributes[12] = true;
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
      if((_ssIsSubstituteFor!=value) || OptimizedAttributes[13]){
          ChangedAttributes[13] = true;
          _ssIsSubstituteFor = value;
      }
  }
}

private string _ssToModifyBy;
public string ssToModifyBy{
  get{
      return _ssToModifyBy;
  }
  set{
      if((_ssToModifyBy!=value) || OptimizedAttributes[14]){
          ChangedAttributes[14] = true;
          _ssToModifyBy = value;
      }
  }
}

private DateTime _ssToModifyOn;
public DateTime ssToModifyOn{
  get{
      return _ssToModifyOn;
  }
  set{
      if((_ssToModifyOn!=value) || OptimizedAttributes[15]){
          ChangedAttributes[15] = true;
          _ssToModifyOn = value;
      }
  }
}

private string _ssWasCanceledBy;
public string ssWasCanceledBy{
  get{
      return _ssWasCanceledBy;
  }
  set{
      if((_ssWasCanceledBy!=value) || OptimizedAttributes[16]){
          ChangedAttributes[16] = true;
          _ssWasCanceledBy = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_6b660d05e4c0025dff47119642875ca2EntityRecord() {
ChangedAttributes = new BitArray(17,true);
OptimizedAttributes = new BitArray(17,false);
_ssId = 0L;
_ssOrderApprovalId = 0L;
_ssLevelNumber = 0;
_ssEntraRoleId = 0L;
_ssAssignedTo = "";
_ssAssignedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssApprovalStatusId = 0;
_ssApprovedBy = "";
_ssApprovedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssRejectedBy = "";
_ssRejectedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssIsComplement = false;
_ssIsReassigned = false;
_ssIsSubstituteFor = "";
_ssToModifyBy = "";
_ssToModifyOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssWasCanceledBy = "";
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
ssId = r.ReadLongInteger(index++, "OrderApprovalLevel.Id", 0L);
ssOrderApprovalId = r.ReadEntityReferenceLongInteger(index++, "OrderApprovalLevel.OrderApprovalId", 0L);
ssLevelNumber = r.ReadInteger(index++, "OrderApprovalLevel.LevelNumber", 0);
ssEntraRoleId = r.ReadEntityReferenceLongInteger(index++, "OrderApprovalLevel.EntraRoleId", 0L);
ssAssignedTo = r.ReadEntityReferenceText(index++, "OrderApprovalLevel.AssignedTo", "");
ssAssignedOn = r.ReadDateTime(index++, "OrderApprovalLevel.AssignedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssApprovalStatusId = r.ReadEntityReference(index++, "OrderApprovalLevel.ApprovalStatusId", 0);
ssApprovedBy = r.ReadEntityReferenceText(index++, "OrderApprovalLevel.ApprovedBy", "");
ssApprovedOn = r.ReadDateTime(index++, "OrderApprovalLevel.ApprovedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssRejectedBy = r.ReadEntityReferenceText(index++, "OrderApprovalLevel.RejectedBy", "");
ssRejectedOn = r.ReadDateTime(index++, "OrderApprovalLevel.RejectedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssIsComplement = r.ReadBoolean(index++, "OrderApprovalLevel.IsComplement", false);
ssIsReassigned = r.ReadBoolean(index++, "OrderApprovalLevel.IsReassigned", false);
ssIsSubstituteFor = r.ReadEntityReferenceText(index++, "OrderApprovalLevel.IsSubstituteFor", "");
ssToModifyBy = r.ReadEntityReferenceText(index++, "OrderApprovalLevel.ToModifyBy", "");
ssToModifyOn = r.ReadDateTime(index++, "OrderApprovalLevel.ToModifyOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssWasCanceledBy = r.ReadEntityReferenceText(index++, "OrderApprovalLevel.WasCanceledBy", "");
ChangedAttributes = new BitArray(17,false);
OptimizedAttributes = new BitArray(17,false);
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
public void ReadIM(EN_6b660d05e4c0025dff47119642875ca2EntityRecord r) {
this = r;
}


public static bool operator == (EN_6b660d05e4c0025dff47119642875ca2EntityRecord a, EN_6b660d05e4c0025dff47119642875ca2EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssOrderApprovalId != b.ssOrderApprovalId) return false;
if (a.ssLevelNumber != b.ssLevelNumber) return false;
if (a.ssEntraRoleId != b.ssEntraRoleId) return false;
if (a.ssAssignedTo != b.ssAssignedTo) return false;
if (a.ssAssignedOn != b.ssAssignedOn) return false;
if (a.ssApprovalStatusId != b.ssApprovalStatusId) return false;
if (a.ssApprovedBy != b.ssApprovedBy) return false;
if (a.ssApprovedOn != b.ssApprovedOn) return false;
if (a.ssRejectedBy != b.ssRejectedBy) return false;
if (a.ssRejectedOn != b.ssRejectedOn) return false;
if (a.ssIsComplement != b.ssIsComplement) return false;
if (a.ssIsReassigned != b.ssIsReassigned) return false;
if (a.ssIsSubstituteFor != b.ssIsSubstituteFor) return false;
if (a.ssToModifyBy != b.ssToModifyBy) return false;
if (a.ssToModifyOn != b.ssToModifyOn) return false;
if (a.ssWasCanceledBy != b.ssWasCanceledBy) return false;
return true;
}

public static bool operator != (EN_6b660d05e4c0025dff47119642875ca2EntityRecord a, EN_6b660d05e4c0025dff47119642875ca2EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_6b660d05e4c0025dff47119642875ca2EntityRecord)) return false;
return (this == (EN_6b660d05e4c0025dff47119642875ca2EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssOrderApprovalId.GetHashCode()
 ^ ssLevelNumber.GetHashCode()
 ^ ssEntraRoleId.GetHashCode()
 ^ ssAssignedTo.GetHashCode()
 ^ ssAssignedOn.GetHashCode()
 ^ ssApprovalStatusId.GetHashCode()
 ^ ssApprovedBy.GetHashCode()
 ^ ssApprovedOn.GetHashCode()
 ^ ssRejectedBy.GetHashCode()
 ^ ssRejectedOn.GetHashCode()
 ^ ssIsComplement.GetHashCode()
 ^ ssIsReassigned.GetHashCode()
 ^ ssIsSubstituteFor.GetHashCode()
 ^ ssToModifyBy.GetHashCode()
 ^ ssToModifyOn.GetHashCode()
 ^ ssWasCanceledBy.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_6b660d05e4c0025dff47119642875ca2EntityRecord Duplicate() {
EN_6b660d05e4c0025dff47119642875ca2EntityRecord t;
t._ssId = this._ssId;
t._ssOrderApprovalId = this._ssOrderApprovalId;
t._ssLevelNumber = this._ssLevelNumber;
t._ssEntraRoleId = this._ssEntraRoleId;
t._ssAssignedTo = this._ssAssignedTo;
t._ssAssignedOn = this._ssAssignedOn;
t._ssApprovalStatusId = this._ssApprovalStatusId;
t._ssApprovedBy = this._ssApprovedBy;
t._ssApprovedOn = this._ssApprovedOn;
t._ssRejectedBy = this._ssRejectedBy;
t._ssRejectedOn = this._ssRejectedOn;
t._ssIsComplement = this._ssIsComplement;
t._ssIsReassigned = this._ssIsReassigned;
t._ssIsSubstituteFor = this._ssIsSubstituteFor;
t._ssToModifyBy = this._ssToModifyBy;
t._ssToModifyOn = this._ssToModifyOn;
t._ssWasCanceledBy = this._ssWasCanceledBy;
t.ChangedAttributes = new BitArray(17);
t.OptimizedAttributes = new BitArray(17);
for(int i = 0; i < 17; i++){
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
} else if (head == "orderapprovalid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderApprovalId")) variable.Value = ssOrderApprovalId; else variable.Optimized = true;
} else if (head == "levelnumber") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".LevelNumber")) variable.Value = ssLevelNumber; else variable.Optimized = true;
} else if (head == "entraroleid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EntraRoleId")) variable.Value = ssEntraRoleId; else variable.Optimized = true;
} else if (head == "assignedto") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AssignedTo")) variable.Value = ssAssignedTo; else variable.Optimized = true;
} else if (head == "assignedon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AssignedOn")) variable.Value = ssAssignedOn; else variable.Optimized = true;
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
} else if (head == "iscomplement") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsComplement")) variable.Value = ssIsComplement; else variable.Optimized = true;
} else if (head == "isreassigned") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsReassigned")) variable.Value = ssIsReassigned; else variable.Optimized = true;
} else if (head == "issubstitutefor") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsSubstituteFor")) variable.Value = ssIsSubstituteFor; else variable.Optimized = true;
} else if (head == "tomodifyby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ToModifyBy")) variable.Value = ssToModifyBy; else variable.Optimized = true;
} else if (head == "tomodifyon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ToModifyOn")) variable.Value = ssToModifyOn; else variable.Optimized = true;
} else if (head == "wascanceledby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".WasCanceledBy")) variable.Value = ssWasCanceledBy; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdOrderApprovalId)) {
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
if (key.Equals(IdAssignedOn)) {
return ChangedAttributes[5];
}
if (key.Equals(IdApprovalStatusId)) {
return ChangedAttributes[6];
}
if (key.Equals(IdApprovedBy)) {
return ChangedAttributes[7];
}
if (key.Equals(IdApprovedOn)) {
return ChangedAttributes[8];
}
if (key.Equals(IdRejectedBy)) {
return ChangedAttributes[9];
}
if (key.Equals(IdRejectedOn)) {
return ChangedAttributes[10];
}
if (key.Equals(IdIsComplement)) {
return ChangedAttributes[11];
}
if (key.Equals(IdIsReassigned)) {
return ChangedAttributes[12];
}
if (key.Equals(IdIsSubstituteFor)) {
return ChangedAttributes[13];
}
if (key.Equals(IdToModifyBy)) {
return ChangedAttributes[14];
}
if (key.Equals(IdToModifyOn)) {
return ChangedAttributes[15];
}
if (key.Equals(IdWasCanceledBy)) {
return ChangedAttributes[16];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdOrderApprovalId)) {
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
if (key.Equals(IdAssignedOn)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdApprovalStatusId)) {
return OptimizedAttributes[6];
}
if (key.Equals(IdApprovedBy)) {
return OptimizedAttributes[7];
}
if (key.Equals(IdApprovedOn)) {
return OptimizedAttributes[8];
}
if (key.Equals(IdRejectedBy)) {
return OptimizedAttributes[9];
}
if (key.Equals(IdRejectedOn)) {
return OptimizedAttributes[10];
}
if (key.Equals(IdIsComplement)) {
return OptimizedAttributes[11];
}
if (key.Equals(IdIsReassigned)) {
return OptimizedAttributes[12];
}
if (key.Equals(IdIsSubstituteFor)) {
return OptimizedAttributes[13];
}
if (key.Equals(IdToModifyBy)) {
return OptimizedAttributes[14];
}
if (key.Equals(IdToModifyOn)) {
return OptimizedAttributes[15];
}
if (key.Equals(IdWasCanceledBy)) {
return OptimizedAttributes[16];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdOrderApprovalId) {
return ssOrderApprovalId;
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
if (key == IdAssignedOn) {
return ssAssignedOn;
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
if (key == IdIsComplement) {
return ssIsComplement;
}
if (key == IdIsReassigned) {
return ssIsReassigned;
}
if (key == IdIsSubstituteFor) {
return ssIsSubstituteFor;
}
if (key == IdToModifyBy) {
return ssToModifyBy;
}
if (key == IdToModifyOn) {
return ssToModifyOn;
}
if (key == IdWasCanceledBy) {
return ssWasCanceledBy;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdOrderApprovalId.Key.AsGuid) {
return ssOrderApprovalId;
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
if (attributeKey == IdAssignedOn.Key.AsGuid) {
return ssAssignedOn;
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
if (attributeKey == IdIsComplement.Key.AsGuid) {
return ssIsComplement;
}
if (attributeKey == IdIsReassigned.Key.AsGuid) {
return ssIsReassigned;
}
if (attributeKey == IdIsSubstituteFor.Key.AsGuid) {
return ssIsSubstituteFor;
}
if (attributeKey == IdToModifyBy.Key.AsGuid) {
return ssToModifyBy;
}
if (attributeKey == IdToModifyOn.Key.AsGuid) {
return ssToModifyOn;
}
if (attributeKey == IdWasCanceledBy.Key.AsGuid) {
return ssWasCanceledBy;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(17);
OptimizedAttributes = new BitArray(17);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssOrderApprovalId = (long) other.AttributeGet(IdOrderApprovalId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdOrderApprovalId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdOrderApprovalId);
ssLevelNumber = (int) other.AttributeGet(IdLevelNumber);
ChangedAttributes[2] = other.ChangedAttributeGet(IdLevelNumber);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdLevelNumber);
ssEntraRoleId = (long) other.AttributeGet(IdEntraRoleId);
ChangedAttributes[3] = other.ChangedAttributeGet(IdEntraRoleId);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdEntraRoleId);
ssAssignedTo = (string) other.AttributeGet(IdAssignedTo);
ChangedAttributes[4] = other.ChangedAttributeGet(IdAssignedTo);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdAssignedTo);
ssAssignedOn = (DateTime) other.AttributeGet(IdAssignedOn);
ChangedAttributes[5] = other.ChangedAttributeGet(IdAssignedOn);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdAssignedOn);
ssApprovalStatusId = (int) other.AttributeGet(IdApprovalStatusId);
ChangedAttributes[6] = other.ChangedAttributeGet(IdApprovalStatusId);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdApprovalStatusId);
ssApprovedBy = (string) other.AttributeGet(IdApprovedBy);
ChangedAttributes[7] = other.ChangedAttributeGet(IdApprovedBy);
OptimizedAttributes[7] = other.OptimizedAttributeGet(IdApprovedBy);
ssApprovedOn = (DateTime) other.AttributeGet(IdApprovedOn);
ChangedAttributes[8] = other.ChangedAttributeGet(IdApprovedOn);
OptimizedAttributes[8] = other.OptimizedAttributeGet(IdApprovedOn);
ssRejectedBy = (string) other.AttributeGet(IdRejectedBy);
ChangedAttributes[9] = other.ChangedAttributeGet(IdRejectedBy);
OptimizedAttributes[9] = other.OptimizedAttributeGet(IdRejectedBy);
ssRejectedOn = (DateTime) other.AttributeGet(IdRejectedOn);
ChangedAttributes[10] = other.ChangedAttributeGet(IdRejectedOn);
OptimizedAttributes[10] = other.OptimizedAttributeGet(IdRejectedOn);
ssIsComplement = (bool) other.AttributeGet(IdIsComplement);
ChangedAttributes[11] = other.ChangedAttributeGet(IdIsComplement);
OptimizedAttributes[11] = other.OptimizedAttributeGet(IdIsComplement);
ssIsReassigned = (bool) other.AttributeGet(IdIsReassigned);
ChangedAttributes[12] = other.ChangedAttributeGet(IdIsReassigned);
OptimizedAttributes[12] = other.OptimizedAttributeGet(IdIsReassigned);
ssIsSubstituteFor = (string) other.AttributeGet(IdIsSubstituteFor);
ChangedAttributes[13] = other.ChangedAttributeGet(IdIsSubstituteFor);
OptimizedAttributes[13] = other.OptimizedAttributeGet(IdIsSubstituteFor);
ssToModifyBy = (string) other.AttributeGet(IdToModifyBy);
ChangedAttributes[14] = other.ChangedAttributeGet(IdToModifyBy);
OptimizedAttributes[14] = other.OptimizedAttributeGet(IdToModifyBy);
ssToModifyOn = (DateTime) other.AttributeGet(IdToModifyOn);
ChangedAttributes[15] = other.ChangedAttributeGet(IdToModifyOn);
OptimizedAttributes[15] = other.OptimizedAttributeGet(IdToModifyOn);
ssWasCanceledBy = (string) other.AttributeGet(IdWasCanceledBy);
ChangedAttributes[16] = other.ChangedAttributeGet(IdWasCanceledBy);
OptimizedAttributes[16] = other.OptimizedAttributeGet(IdWasCanceledBy);
}
} // EN_6b660d05e4c0025dff47119642875ca2EntityRecord

/// <summary>
/// RecordList type <code>OrderApprovalLevelList</code> that represents a record list of
///  <code>OrderApprovalLevel</code>
/// </summary>
public partial class RL_8ca6c146d3bf4759450b4e1f79c953ef : GenericRecordList<EN_6b660d05e4c0025dff47119642875ca2EntityRecord>, IEnumerable, IEnumerator {

protected override EN_6b660d05e4c0025dff47119642875ca2EntityRecord GetElementDefaultValue() {
return new EN_6b660d05e4c0025dff47119642875ca2EntityRecord();
}

public T[] ToArray<T>(Func<EN_6b660d05e4c0025dff47119642875ca2EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_8ca6c146d3bf4759450b4e1f79c953ef recordList, Func<EN_6b660d05e4c0025dff47119642875ca2EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_8ca6c146d3bf4759450b4e1f79c953ef(EN_6b660d05e4c0025dff47119642875ca2EntityRecord[] array) {
  RL_8ca6c146d3bf4759450b4e1f79c953ef result = new RL_8ca6c146d3bf4759450b4e1f79c953ef();
result.InnerFromArray(array);
    return result;
}

public static RL_8ca6c146d3bf4759450b4e1f79c953ef ToList<T>(T[] array, Func <T, EN_6b660d05e4c0025dff47119642875ca2EntityRecord> converter) {
  RL_8ca6c146d3bf4759450b4e1f79c953ef result = new RL_8ca6c146d3bf4759450b4e1f79c953ef();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_8ca6c146d3bf4759450b4e1f79c953ef FromRestList<T>(RestList<T> restList, Func <T, EN_6b660d05e4c0025dff47119642875ca2EntityRecord> converter) {
  RL_8ca6c146d3bf4759450b4e1f79c953ef result = new RL_8ca6c146d3bf4759450b4e1f79c953ef();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_8ca6c146d3bf4759450b4e1f79c953ef() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_6b660d05e4c0025dff47119642875ca2EntityRecord> NewList() {
return new RL_8ca6c146d3bf4759450b4e1f79c953ef();
}


} // RL_8ca6c146d3bf4759450b4e1f79c953ef
}
