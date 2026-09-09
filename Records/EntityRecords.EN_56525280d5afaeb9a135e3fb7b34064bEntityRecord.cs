using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] FolioApprovalLevel (oPtEU6g7ok2RvCU+7Fc4FA)
///  <code>EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord</code> that represent
/// s <code>FolioApprovalLevel</code> <p>Description: </p>
/// </summary>
// Name: FolioApprovalLevel
public partial struct EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord : ITypedRecord<EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*wOqWK04iFU+9DEm0lawkSQ");
internal static readonly GlobalObjectKey IdFolioApprovalId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*2f_UrT12pkqOwg+xsaGk5w");
internal static readonly GlobalObjectKey IdLevelNumber = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*23WM5qw6yUuQJxQFUF+zsg");
internal static readonly GlobalObjectKey IdApplicationRoleId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*UmXFWXyQcU2pCRPopJTBjA");
internal static readonly GlobalObjectKey IdEntraJobTitle = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*jDzjsjij9kmmSASTb6kr0Q");
internal static readonly GlobalObjectKey IdEntraRoleId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*0b4c18k1JEGYn9e0z6JsvA");
internal static readonly GlobalObjectKey IdDepartmentId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*WcaVEhTsfkWB58zyL12Lxw");
internal static readonly GlobalObjectKey IdAssignedTo = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*y1Hbb4MzP0q+fQo8QSL3Iw");
internal static readonly GlobalObjectKey IdApprovalStatusId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*iEEcLuxkqku0OnMvBb0Ezg");
internal static readonly GlobalObjectKey IdIsMandatory = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*usJ0dLHCOU2wzzVifpdE1Q");
internal static readonly GlobalObjectKey IdIsReassigned = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*XoS_yEQHQkm8YGMgjaHMiA");
internal static readonly GlobalObjectKey IdApprovedBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*3jFfMD65oUKSwemVdDeIRg");
internal static readonly GlobalObjectKey IdApprovedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*av523tGdmkeGrItQ8XY2_A");
internal static readonly GlobalObjectKey IdCanceledBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Lv60+kbwN0SqXx2ZbyYwiA");
internal static readonly GlobalObjectKey IdCanceledOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*5+BmQVjzm02BuWD89oLmmg");
internal static readonly GlobalObjectKey IdRejectedBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*FkSBh71w0ki6oGGazoB6KQ");
internal static readonly GlobalObjectKey IdRejectedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Lrlk9lYV8kSQ3sXbhyeyKw");
internal static readonly GlobalObjectKey IdIsSubstituteFor = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*vwQfHJEEvUaUfEsnAKwZyQ");
internal static readonly GlobalObjectKey IdRejectReason = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*JWBzEDuehkWSm1U42DSb3Q");
internal static readonly GlobalObjectKey IdIsInvoiceApproval = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Q2eqXk0MM0ue_NNhquOp4g");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(20,true);
          _ssId = value;
      }
  }
}

private long _ssFolioApprovalId;
public long ssFolioApprovalId{
  get{
      return _ssFolioApprovalId;
  }
  set{
      if((_ssFolioApprovalId!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssFolioApprovalId = value;
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

private string _ssEntraJobTitle;
public string ssEntraJobTitle{
  get{
      return _ssEntraJobTitle;
  }
  set{
      if((_ssEntraJobTitle!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssEntraJobTitle = value;
      }
  }
}

private long _ssEntraRoleId;
public long ssEntraRoleId{
  get{
      return _ssEntraRoleId;
  }
  set{
      if((_ssEntraRoleId!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssEntraRoleId = value;
      }
  }
}

private long _ssDepartmentId;
public long ssDepartmentId{
  get{
      return _ssDepartmentId;
  }
  set{
      if((_ssDepartmentId!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssDepartmentId = value;
      }
  }
}

private string _ssAssignedTo;
public string ssAssignedTo{
  get{
      return _ssAssignedTo;
  }
  set{
      if((_ssAssignedTo!=value) || OptimizedAttributes[7]){
          ChangedAttributes[7] = true;
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
      if((_ssApprovalStatusId!=value) || OptimizedAttributes[8]){
          ChangedAttributes[8] = true;
          _ssApprovalStatusId = value;
      }
  }
}

private bool _ssIsMandatory;
public bool ssIsMandatory{
  get{
      return _ssIsMandatory;
  }
  set{
      if((_ssIsMandatory!=value) || OptimizedAttributes[9]){
          ChangedAttributes[9] = true;
          _ssIsMandatory = value;
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

private string _ssApprovedBy;
public string ssApprovedBy{
  get{
      return _ssApprovedBy;
  }
  set{
      if((_ssApprovedBy!=value) || OptimizedAttributes[11]){
          ChangedAttributes[11] = true;
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
      if((_ssApprovedOn!=value) || OptimizedAttributes[12]){
          ChangedAttributes[12] = true;
          _ssApprovedOn = value;
      }
  }
}

private string _ssCanceledBy;
public string ssCanceledBy{
  get{
      return _ssCanceledBy;
  }
  set{
      if((_ssCanceledBy!=value) || OptimizedAttributes[13]){
          ChangedAttributes[13] = true;
          _ssCanceledBy = value;
      }
  }
}

private DateTime _ssCanceledOn;
public DateTime ssCanceledOn{
  get{
      return _ssCanceledOn;
  }
  set{
      if((_ssCanceledOn!=value) || OptimizedAttributes[14]){
          ChangedAttributes[14] = true;
          _ssCanceledOn = value;
      }
  }
}

private string _ssRejectedBy;
public string ssRejectedBy{
  get{
      return _ssRejectedBy;
  }
  set{
      if((_ssRejectedBy!=value) || OptimizedAttributes[15]){
          ChangedAttributes[15] = true;
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
      if((_ssRejectedOn!=value) || OptimizedAttributes[16]){
          ChangedAttributes[16] = true;
          _ssRejectedOn = value;
      }
  }
}

private string _ssIsSubstituteFor;
public string ssIsSubstituteFor{
  get{
      return _ssIsSubstituteFor;
  }
  set{
      if((_ssIsSubstituteFor!=value) || OptimizedAttributes[17]){
          ChangedAttributes[17] = true;
          _ssIsSubstituteFor = value;
      }
  }
}

private string _ssRejectReason;
public string ssRejectReason{
  get{
      return _ssRejectReason;
  }
  set{
      if((_ssRejectReason!=value) || OptimizedAttributes[18]){
          ChangedAttributes[18] = true;
          _ssRejectReason = value;
      }
  }
}

private bool _ssIsInvoiceApproval;
public bool ssIsInvoiceApproval{
  get{
      return _ssIsInvoiceApproval;
  }
  set{
      if((_ssIsInvoiceApproval!=value) || OptimizedAttributes[19]){
          ChangedAttributes[19] = true;
          _ssIsInvoiceApproval = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord() {
ChangedAttributes = new BitArray(20,true);
OptimizedAttributes = new BitArray(20,false);
_ssId = 0L;
_ssFolioApprovalId = 0L;
_ssLevelNumber = 0;
_ssApplicationRoleId = 0L;
_ssEntraJobTitle = "";
_ssEntraRoleId = 0L;
_ssDepartmentId = 0L;
_ssAssignedTo = "";
_ssApprovalStatusId = 0;
_ssIsMandatory = false;
_ssIsReassigned = false;
_ssApprovedBy = "";
_ssApprovedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssCanceledBy = "";
_ssCanceledOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssRejectedBy = "";
_ssRejectedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssIsSubstituteFor = "";
_ssRejectReason = "";
_ssIsInvoiceApproval = false;
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
ssId = r.ReadLongInteger(index++, "FolioApprovalLevel.Id", 0L);
ssFolioApprovalId = r.ReadEntityReferenceLongInteger(index++, "FolioApprovalLevel.FolioApprovalId", 0L);
ssLevelNumber = r.ReadInteger(index++, "FolioApprovalLevel.LevelNumber", 0);
ssApplicationRoleId = r.ReadEntityReferenceLongInteger(index++, "FolioApprovalLevel.ApplicationRoleId", 0L);
ssEntraJobTitle = r.ReadText(index++, "FolioApprovalLevel.EntraJobTitle", "");
ssEntraRoleId = r.ReadEntityReferenceLongInteger(index++, "FolioApprovalLevel.EntraRoleId", 0L);
ssDepartmentId = r.ReadEntityReferenceLongInteger(index++, "FolioApprovalLevel.DepartmentId", 0L);
ssAssignedTo = r.ReadEntityReferenceText(index++, "FolioApprovalLevel.AssignedTo", "");
ssApprovalStatusId = r.ReadEntityReference(index++, "FolioApprovalLevel.ApprovalStatusId", 0);
ssIsMandatory = r.ReadBoolean(index++, "FolioApprovalLevel.IsMandatory", false);
ssIsReassigned = r.ReadBoolean(index++, "FolioApprovalLevel.IsReassigned", false);
ssApprovedBy = r.ReadEntityReferenceText(index++, "FolioApprovalLevel.ApprovedBy", "");
ssApprovedOn = r.ReadDateTime(index++, "FolioApprovalLevel.ApprovedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssCanceledBy = r.ReadEntityReferenceText(index++, "FolioApprovalLevel.CanceledBy", "");
ssCanceledOn = r.ReadDateTime(index++, "FolioApprovalLevel.CanceledOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssRejectedBy = r.ReadEntityReferenceText(index++, "FolioApprovalLevel.RejectedBy", "");
ssRejectedOn = r.ReadDateTime(index++, "FolioApprovalLevel.RejectedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssIsSubstituteFor = r.ReadEntityReferenceText(index++, "FolioApprovalLevel.IsSubstituteFor", "");
ssRejectReason = r.ReadText(index++, "FolioApprovalLevel.RejectReason", "");
ssIsInvoiceApproval = r.ReadBoolean(index++, "FolioApprovalLevel.IsInvoiceApproval", false);
ChangedAttributes = new BitArray(20,false);
OptimizedAttributes = new BitArray(20,false);
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
public void ReadIM(EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord r) {
this = r;
}


public static bool operator == (EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord a, EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssFolioApprovalId != b.ssFolioApprovalId) return false;
if (a.ssLevelNumber != b.ssLevelNumber) return false;
if (a.ssApplicationRoleId != b.ssApplicationRoleId) return false;
if (a.ssEntraJobTitle != b.ssEntraJobTitle) return false;
if (a.ssEntraRoleId != b.ssEntraRoleId) return false;
if (a.ssDepartmentId != b.ssDepartmentId) return false;
if (a.ssAssignedTo != b.ssAssignedTo) return false;
if (a.ssApprovalStatusId != b.ssApprovalStatusId) return false;
if (a.ssIsMandatory != b.ssIsMandatory) return false;
if (a.ssIsReassigned != b.ssIsReassigned) return false;
if (a.ssApprovedBy != b.ssApprovedBy) return false;
if (a.ssApprovedOn != b.ssApprovedOn) return false;
if (a.ssCanceledBy != b.ssCanceledBy) return false;
if (a.ssCanceledOn != b.ssCanceledOn) return false;
if (a.ssRejectedBy != b.ssRejectedBy) return false;
if (a.ssRejectedOn != b.ssRejectedOn) return false;
if (a.ssIsSubstituteFor != b.ssIsSubstituteFor) return false;
if (a.ssRejectReason != b.ssRejectReason) return false;
if (a.ssIsInvoiceApproval != b.ssIsInvoiceApproval) return false;
return true;
}

public static bool operator != (EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord a, EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord)) return false;
return (this == (EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssFolioApprovalId.GetHashCode()
 ^ ssLevelNumber.GetHashCode()
 ^ ssApplicationRoleId.GetHashCode()
 ^ ssEntraJobTitle.GetHashCode()
 ^ ssEntraRoleId.GetHashCode()
 ^ ssDepartmentId.GetHashCode()
 ^ ssAssignedTo.GetHashCode()
 ^ ssApprovalStatusId.GetHashCode()
 ^ ssIsMandatory.GetHashCode()
 ^ ssIsReassigned.GetHashCode()
 ^ ssApprovedBy.GetHashCode()
 ^ ssApprovedOn.GetHashCode()
 ^ ssCanceledBy.GetHashCode()
 ^ ssCanceledOn.GetHashCode()
 ^ ssRejectedBy.GetHashCode()
 ^ ssRejectedOn.GetHashCode()
 ^ ssIsSubstituteFor.GetHashCode()
 ^ ssRejectReason.GetHashCode()
 ^ ssIsInvoiceApproval.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord Duplicate() {
EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord t;
t._ssId = this._ssId;
t._ssFolioApprovalId = this._ssFolioApprovalId;
t._ssLevelNumber = this._ssLevelNumber;
t._ssApplicationRoleId = this._ssApplicationRoleId;
t._ssEntraJobTitle = this._ssEntraJobTitle;
t._ssEntraRoleId = this._ssEntraRoleId;
t._ssDepartmentId = this._ssDepartmentId;
t._ssAssignedTo = this._ssAssignedTo;
t._ssApprovalStatusId = this._ssApprovalStatusId;
t._ssIsMandatory = this._ssIsMandatory;
t._ssIsReassigned = this._ssIsReassigned;
t._ssApprovedBy = this._ssApprovedBy;
t._ssApprovedOn = this._ssApprovedOn;
t._ssCanceledBy = this._ssCanceledBy;
t._ssCanceledOn = this._ssCanceledOn;
t._ssRejectedBy = this._ssRejectedBy;
t._ssRejectedOn = this._ssRejectedOn;
t._ssIsSubstituteFor = this._ssIsSubstituteFor;
t._ssRejectReason = this._ssRejectReason;
t._ssIsInvoiceApproval = this._ssIsInvoiceApproval;
t.ChangedAttributes = new BitArray(20);
t.OptimizedAttributes = new BitArray(20);
for(int i = 0; i < 20; i++){
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
} else if (head == "folioapprovalid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioApprovalId")) variable.Value = ssFolioApprovalId; else variable.Optimized = true;
} else if (head == "levelnumber") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".LevelNumber")) variable.Value = ssLevelNumber; else variable.Optimized = true;
} else if (head == "applicationroleid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApplicationRoleId")) variable.Value = ssApplicationRoleId; else variable.Optimized = true;
} else if (head == "entrajobtitle") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EntraJobTitle")) variable.Value = ssEntraJobTitle; else variable.Optimized = true;
} else if (head == "entraroleid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EntraRoleId")) variable.Value = ssEntraRoleId; else variable.Optimized = true;
} else if (head == "departmentid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DepartmentId")) variable.Value = ssDepartmentId; else variable.Optimized = true;
} else if (head == "assignedto") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AssignedTo")) variable.Value = ssAssignedTo; else variable.Optimized = true;
} else if (head == "approvalstatusid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApprovalStatusId")) variable.Value = ssApprovalStatusId; else variable.Optimized = true;
} else if (head == "ismandatory") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsMandatory")) variable.Value = ssIsMandatory; else variable.Optimized = true;
} else if (head == "isreassigned") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsReassigned")) variable.Value = ssIsReassigned; else variable.Optimized = true;
} else if (head == "approvedby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApprovedBy")) variable.Value = ssApprovedBy; else variable.Optimized = true;
} else if (head == "approvedon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApprovedOn")) variable.Value = ssApprovedOn; else variable.Optimized = true;
} else if (head == "canceledby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CanceledBy")) variable.Value = ssCanceledBy; else variable.Optimized = true;
} else if (head == "canceledon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CanceledOn")) variable.Value = ssCanceledOn; else variable.Optimized = true;
} else if (head == "rejectedby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RejectedBy")) variable.Value = ssRejectedBy; else variable.Optimized = true;
} else if (head == "rejectedon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RejectedOn")) variable.Value = ssRejectedOn; else variable.Optimized = true;
} else if (head == "issubstitutefor") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsSubstituteFor")) variable.Value = ssIsSubstituteFor; else variable.Optimized = true;
} else if (head == "rejectreason") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RejectReason")) variable.Value = ssRejectReason; else variable.Optimized = true;
} else if (head == "isinvoiceapproval") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsInvoiceApproval")) variable.Value = ssIsInvoiceApproval; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdFolioApprovalId)) {
return ChangedAttributes[1];
}
if (key.Equals(IdLevelNumber)) {
return ChangedAttributes[2];
}
if (key.Equals(IdApplicationRoleId)) {
return ChangedAttributes[3];
}
if (key.Equals(IdEntraJobTitle)) {
return ChangedAttributes[4];
}
if (key.Equals(IdEntraRoleId)) {
return ChangedAttributes[5];
}
if (key.Equals(IdDepartmentId)) {
return ChangedAttributes[6];
}
if (key.Equals(IdAssignedTo)) {
return ChangedAttributes[7];
}
if (key.Equals(IdApprovalStatusId)) {
return ChangedAttributes[8];
}
if (key.Equals(IdIsMandatory)) {
return ChangedAttributes[9];
}
if (key.Equals(IdIsReassigned)) {
return ChangedAttributes[10];
}
if (key.Equals(IdApprovedBy)) {
return ChangedAttributes[11];
}
if (key.Equals(IdApprovedOn)) {
return ChangedAttributes[12];
}
if (key.Equals(IdCanceledBy)) {
return ChangedAttributes[13];
}
if (key.Equals(IdCanceledOn)) {
return ChangedAttributes[14];
}
if (key.Equals(IdRejectedBy)) {
return ChangedAttributes[15];
}
if (key.Equals(IdRejectedOn)) {
return ChangedAttributes[16];
}
if (key.Equals(IdIsSubstituteFor)) {
return ChangedAttributes[17];
}
if (key.Equals(IdRejectReason)) {
return ChangedAttributes[18];
}
if (key.Equals(IdIsInvoiceApproval)) {
return ChangedAttributes[19];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdFolioApprovalId)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdLevelNumber)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdApplicationRoleId)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdEntraJobTitle)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdEntraRoleId)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdDepartmentId)) {
return OptimizedAttributes[6];
}
if (key.Equals(IdAssignedTo)) {
return OptimizedAttributes[7];
}
if (key.Equals(IdApprovalStatusId)) {
return OptimizedAttributes[8];
}
if (key.Equals(IdIsMandatory)) {
return OptimizedAttributes[9];
}
if (key.Equals(IdIsReassigned)) {
return OptimizedAttributes[10];
}
if (key.Equals(IdApprovedBy)) {
return OptimizedAttributes[11];
}
if (key.Equals(IdApprovedOn)) {
return OptimizedAttributes[12];
}
if (key.Equals(IdCanceledBy)) {
return OptimizedAttributes[13];
}
if (key.Equals(IdCanceledOn)) {
return OptimizedAttributes[14];
}
if (key.Equals(IdRejectedBy)) {
return OptimizedAttributes[15];
}
if (key.Equals(IdRejectedOn)) {
return OptimizedAttributes[16];
}
if (key.Equals(IdIsSubstituteFor)) {
return OptimizedAttributes[17];
}
if (key.Equals(IdRejectReason)) {
return OptimizedAttributes[18];
}
if (key.Equals(IdIsInvoiceApproval)) {
return OptimizedAttributes[19];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdFolioApprovalId) {
return ssFolioApprovalId;
}
if (key == IdLevelNumber) {
return ssLevelNumber;
}
if (key == IdApplicationRoleId) {
return ssApplicationRoleId;
}
if (key == IdEntraJobTitle) {
return ssEntraJobTitle;
}
if (key == IdEntraRoleId) {
return ssEntraRoleId;
}
if (key == IdDepartmentId) {
return ssDepartmentId;
}
if (key == IdAssignedTo) {
return ssAssignedTo;
}
if (key == IdApprovalStatusId) {
return ssApprovalStatusId;
}
if (key == IdIsMandatory) {
return ssIsMandatory;
}
if (key == IdIsReassigned) {
return ssIsReassigned;
}
if (key == IdApprovedBy) {
return ssApprovedBy;
}
if (key == IdApprovedOn) {
return ssApprovedOn;
}
if (key == IdCanceledBy) {
return ssCanceledBy;
}
if (key == IdCanceledOn) {
return ssCanceledOn;
}
if (key == IdRejectedBy) {
return ssRejectedBy;
}
if (key == IdRejectedOn) {
return ssRejectedOn;
}
if (key == IdIsSubstituteFor) {
return ssIsSubstituteFor;
}
if (key == IdRejectReason) {
return ssRejectReason;
}
if (key == IdIsInvoiceApproval) {
return ssIsInvoiceApproval;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdFolioApprovalId.Key.AsGuid) {
return ssFolioApprovalId;
}
if (attributeKey == IdLevelNumber.Key.AsGuid) {
return ssLevelNumber;
}
if (attributeKey == IdApplicationRoleId.Key.AsGuid) {
return ssApplicationRoleId;
}
if (attributeKey == IdEntraJobTitle.Key.AsGuid) {
return ssEntraJobTitle;
}
if (attributeKey == IdEntraRoleId.Key.AsGuid) {
return ssEntraRoleId;
}
if (attributeKey == IdDepartmentId.Key.AsGuid) {
return ssDepartmentId;
}
if (attributeKey == IdAssignedTo.Key.AsGuid) {
return ssAssignedTo;
}
if (attributeKey == IdApprovalStatusId.Key.AsGuid) {
return ssApprovalStatusId;
}
if (attributeKey == IdIsMandatory.Key.AsGuid) {
return ssIsMandatory;
}
if (attributeKey == IdIsReassigned.Key.AsGuid) {
return ssIsReassigned;
}
if (attributeKey == IdApprovedBy.Key.AsGuid) {
return ssApprovedBy;
}
if (attributeKey == IdApprovedOn.Key.AsGuid) {
return ssApprovedOn;
}
if (attributeKey == IdCanceledBy.Key.AsGuid) {
return ssCanceledBy;
}
if (attributeKey == IdCanceledOn.Key.AsGuid) {
return ssCanceledOn;
}
if (attributeKey == IdRejectedBy.Key.AsGuid) {
return ssRejectedBy;
}
if (attributeKey == IdRejectedOn.Key.AsGuid) {
return ssRejectedOn;
}
if (attributeKey == IdIsSubstituteFor.Key.AsGuid) {
return ssIsSubstituteFor;
}
if (attributeKey == IdRejectReason.Key.AsGuid) {
return ssRejectReason;
}
if (attributeKey == IdIsInvoiceApproval.Key.AsGuid) {
return ssIsInvoiceApproval;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(20);
OptimizedAttributes = new BitArray(20);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssFolioApprovalId = (long) other.AttributeGet(IdFolioApprovalId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdFolioApprovalId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdFolioApprovalId);
ssLevelNumber = (int) other.AttributeGet(IdLevelNumber);
ChangedAttributes[2] = other.ChangedAttributeGet(IdLevelNumber);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdLevelNumber);
ssApplicationRoleId = (long) other.AttributeGet(IdApplicationRoleId);
ChangedAttributes[3] = other.ChangedAttributeGet(IdApplicationRoleId);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdApplicationRoleId);
ssEntraJobTitle = (string) other.AttributeGet(IdEntraJobTitle);
ChangedAttributes[4] = other.ChangedAttributeGet(IdEntraJobTitle);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdEntraJobTitle);
ssEntraRoleId = (long) other.AttributeGet(IdEntraRoleId);
ChangedAttributes[5] = other.ChangedAttributeGet(IdEntraRoleId);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdEntraRoleId);
ssDepartmentId = (long) other.AttributeGet(IdDepartmentId);
ChangedAttributes[6] = other.ChangedAttributeGet(IdDepartmentId);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdDepartmentId);
ssAssignedTo = (string) other.AttributeGet(IdAssignedTo);
ChangedAttributes[7] = other.ChangedAttributeGet(IdAssignedTo);
OptimizedAttributes[7] = other.OptimizedAttributeGet(IdAssignedTo);
ssApprovalStatusId = (int) other.AttributeGet(IdApprovalStatusId);
ChangedAttributes[8] = other.ChangedAttributeGet(IdApprovalStatusId);
OptimizedAttributes[8] = other.OptimizedAttributeGet(IdApprovalStatusId);
ssIsMandatory = (bool) other.AttributeGet(IdIsMandatory);
ChangedAttributes[9] = other.ChangedAttributeGet(IdIsMandatory);
OptimizedAttributes[9] = other.OptimizedAttributeGet(IdIsMandatory);
ssIsReassigned = (bool) other.AttributeGet(IdIsReassigned);
ChangedAttributes[10] = other.ChangedAttributeGet(IdIsReassigned);
OptimizedAttributes[10] = other.OptimizedAttributeGet(IdIsReassigned);
ssApprovedBy = (string) other.AttributeGet(IdApprovedBy);
ChangedAttributes[11] = other.ChangedAttributeGet(IdApprovedBy);
OptimizedAttributes[11] = other.OptimizedAttributeGet(IdApprovedBy);
ssApprovedOn = (DateTime) other.AttributeGet(IdApprovedOn);
ChangedAttributes[12] = other.ChangedAttributeGet(IdApprovedOn);
OptimizedAttributes[12] = other.OptimizedAttributeGet(IdApprovedOn);
ssCanceledBy = (string) other.AttributeGet(IdCanceledBy);
ChangedAttributes[13] = other.ChangedAttributeGet(IdCanceledBy);
OptimizedAttributes[13] = other.OptimizedAttributeGet(IdCanceledBy);
ssCanceledOn = (DateTime) other.AttributeGet(IdCanceledOn);
ChangedAttributes[14] = other.ChangedAttributeGet(IdCanceledOn);
OptimizedAttributes[14] = other.OptimizedAttributeGet(IdCanceledOn);
ssRejectedBy = (string) other.AttributeGet(IdRejectedBy);
ChangedAttributes[15] = other.ChangedAttributeGet(IdRejectedBy);
OptimizedAttributes[15] = other.OptimizedAttributeGet(IdRejectedBy);
ssRejectedOn = (DateTime) other.AttributeGet(IdRejectedOn);
ChangedAttributes[16] = other.ChangedAttributeGet(IdRejectedOn);
OptimizedAttributes[16] = other.OptimizedAttributeGet(IdRejectedOn);
ssIsSubstituteFor = (string) other.AttributeGet(IdIsSubstituteFor);
ChangedAttributes[17] = other.ChangedAttributeGet(IdIsSubstituteFor);
OptimizedAttributes[17] = other.OptimizedAttributeGet(IdIsSubstituteFor);
ssRejectReason = (string) other.AttributeGet(IdRejectReason);
ChangedAttributes[18] = other.ChangedAttributeGet(IdRejectReason);
OptimizedAttributes[18] = other.OptimizedAttributeGet(IdRejectReason);
ssIsInvoiceApproval = (bool) other.AttributeGet(IdIsInvoiceApproval);
ChangedAttributes[19] = other.ChangedAttributeGet(IdIsInvoiceApproval);
OptimizedAttributes[19] = other.OptimizedAttributeGet(IdIsInvoiceApproval);
}
} // EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord

/// <summary>
/// RecordList type <code>FolioApprovalLevelList</code> that represents a record list of
///  <code>FolioApprovalLevel</code>
/// </summary>
public partial class RL_4391d3239f28e5f33772aaade6de0b0d : GenericRecordList<EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord>, IEnumerable, IEnumerator {

protected override EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord GetElementDefaultValue() {
return new EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord();
}

public T[] ToArray<T>(Func<EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_4391d3239f28e5f33772aaade6de0b0d recordList, Func<EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_4391d3239f28e5f33772aaade6de0b0d(EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord[] array) {
  RL_4391d3239f28e5f33772aaade6de0b0d result = new RL_4391d3239f28e5f33772aaade6de0b0d();
result.InnerFromArray(array);
    return result;
}

public static RL_4391d3239f28e5f33772aaade6de0b0d ToList<T>(T[] array, Func <T, EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord> converter) {
  RL_4391d3239f28e5f33772aaade6de0b0d result = new RL_4391d3239f28e5f33772aaade6de0b0d();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_4391d3239f28e5f33772aaade6de0b0d FromRestList<T>(RestList<T> restList, Func <T, EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord> converter) {
  RL_4391d3239f28e5f33772aaade6de0b0d result = new RL_4391d3239f28e5f33772aaade6de0b0d();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_4391d3239f28e5f33772aaade6de0b0d() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord> NewList() {
return new RL_4391d3239f28e5f33772aaade6de0b0d();
}


} // RL_4391d3239f28e5f33772aaade6de0b0d
}
