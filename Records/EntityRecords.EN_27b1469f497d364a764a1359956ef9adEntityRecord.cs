using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] RequisitionApprovalLevel (7elah3c4lUuSNkmslAAGMw)
///  <code>EN_27b1469f497d364a764a1359956ef9adEntityRecord</code> that represent
/// s <code>RequisitionApprovalLevel</code> <p>Description: RequisitionApprovalLevel</p>
/// </summary>
// Name: RequisitionApprovalLevel
public partial struct EN_27b1469f497d364a764a1359956ef9adEntityRecord : ITypedRecord<EN_27b1469f497d364a764a1359956ef9adEntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*WbYHwYJ5f02AcdCme7tv1g");
internal static readonly GlobalObjectKey IdRequisitionApprovalId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*ofCvjUs_KUqxwQxBeVaSqg");
internal static readonly GlobalObjectKey IdLevelNumber = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*KXvKaWqPQU6b6_BV0JW+og");
internal static readonly GlobalObjectKey IdApplicationRoleId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*wCI7f9R3ZkG2Sp+ZzJcR+A");
internal static readonly GlobalObjectKey IdEntraJobTitle = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*VYKq9oSyK0imG_mjGmefJQ");
internal static readonly GlobalObjectKey IdDepartmentId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*HdrzbtXo0Ea5Me8k+2M9VQ");
internal static readonly GlobalObjectKey IdManagementId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*M9U92e5CvU66Y53BuQ5VEA");
internal static readonly GlobalObjectKey IdSubdirectionId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*EYVbJGbqLka73xVNso226A");
internal static readonly GlobalObjectKey IdEntraRoleId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*BI3sgCnh4UuQNbhIDqmniw");
internal static readonly GlobalObjectKey IdEntraUserName = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*h13JTzfYc065_icTcrfzVg");
internal static readonly GlobalObjectKey IdAssignedTo = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*DWr_dZVGhEOYeR1AS1_LDA");
internal static readonly GlobalObjectKey IdNeedsContract = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*J+ZDgDkaHkmqM+7xCrshLQ");
internal static readonly GlobalObjectKey IdApprovalStatusId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*yv6NUtzl2UifmaVcrF05Iw");
internal static readonly GlobalObjectKey IdApprovedBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*gNuz3Q9_9EiwwveSydjA_w");
internal static readonly GlobalObjectKey IdApprovedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*fph6T1Psokitpvkq1Z1QaA");
internal static readonly GlobalObjectKey IdRequestToModifyBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*666wwZVeWke00BwxZ+uvag");
internal static readonly GlobalObjectKey IdRequestToModifyOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*4a0IOf6XUk24RRaSSRll+A");
internal static readonly GlobalObjectKey IdCanceledBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*8rUERsI1x0KlzmgWtjqndA");
internal static readonly GlobalObjectKey IdCanceledOn_DEPREC = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*CPEIm6ZHwEae5CupyVTJZA");
internal static readonly GlobalObjectKey IdIsAccounting = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*8oqQNJ1gZUCYd1k5VSwUgQ");
internal static readonly GlobalObjectKey IdIsStartAccounting = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*d8WiNgM1iU25vAr9CaCWoQ");
internal static readonly GlobalObjectKey IdCanceledOn_ = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*9QXjsytFK0KnrFWTLhr1Fw");
internal static readonly GlobalObjectKey IdApproveAsAreaUsuaria = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*0QmJgJgwg0CknVzD9IjrEQ");
internal static readonly GlobalObjectKey IdIsMandatory = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*jI0U50z9R0KgE0HDY3j82Q");
internal static readonly GlobalObjectKey IdIsReassigned = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*MiXloBNNDEqC6K8FaPvZAA");
internal static readonly GlobalObjectKey IdIsSubstituteFor = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*kF_xweB_zE6G8XESUCFGEA");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(26,true);
          _ssId = value;
      }
  }
}

private long _ssRequisitionApprovalId;
public long ssRequisitionApprovalId{
  get{
      return _ssRequisitionApprovalId;
  }
  set{
      if((_ssRequisitionApprovalId!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssRequisitionApprovalId = value;
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

private long _ssDepartmentId;
public long ssDepartmentId{
  get{
      return _ssDepartmentId;
  }
  set{
      if((_ssDepartmentId!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssDepartmentId = value;
      }
  }
}

private long _ssManagementId;
public long ssManagementId{
  get{
      return _ssManagementId;
  }
  set{
      if((_ssManagementId!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssManagementId = value;
      }
  }
}

private long _ssSubdirectionId;
public long ssSubdirectionId{
  get{
      return _ssSubdirectionId;
  }
  set{
      if((_ssSubdirectionId!=value) || OptimizedAttributes[7]){
          ChangedAttributes[7] = true;
          _ssSubdirectionId = value;
      }
  }
}

private long _ssEntraRoleId;
public long ssEntraRoleId{
  get{
      return _ssEntraRoleId;
  }
  set{
      if((_ssEntraRoleId!=value) || OptimizedAttributes[8]){
          ChangedAttributes[8] = true;
          _ssEntraRoleId = value;
      }
  }
}

private string _ssEntraUserName;
public string ssEntraUserName{
  get{
      return _ssEntraUserName;
  }
  set{
      if((_ssEntraUserName!=value) || OptimizedAttributes[9]){
          ChangedAttributes[9] = true;
          _ssEntraUserName = value;
      }
  }
}

private string _ssAssignedTo;
public string ssAssignedTo{
  get{
      return _ssAssignedTo;
  }
  set{
      if((_ssAssignedTo!=value) || OptimizedAttributes[10]){
          ChangedAttributes[10] = true;
          _ssAssignedTo = value;
      }
  }
}

private bool _ssNeedsContract;
public bool ssNeedsContract{
  get{
      return _ssNeedsContract;
  }
  set{
      if((_ssNeedsContract!=value) || OptimizedAttributes[11]){
          ChangedAttributes[11] = true;
          _ssNeedsContract = value;
      }
  }
}

private int _ssApprovalStatusId;
public int ssApprovalStatusId{
  get{
      return _ssApprovalStatusId;
  }
  set{
      if((_ssApprovalStatusId!=value) || OptimizedAttributes[12]){
          ChangedAttributes[12] = true;
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
      if((_ssApprovedBy!=value) || OptimizedAttributes[13]){
          ChangedAttributes[13] = true;
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
      if((_ssApprovedOn!=value) || OptimizedAttributes[14]){
          ChangedAttributes[14] = true;
          _ssApprovedOn = value;
      }
  }
}

private string _ssRequestToModifyBy;
public string ssRequestToModifyBy{
  get{
      return _ssRequestToModifyBy;
  }
  set{
      if((_ssRequestToModifyBy!=value) || OptimizedAttributes[15]){
          ChangedAttributes[15] = true;
          _ssRequestToModifyBy = value;
      }
  }
}

private DateTime _ssRequestToModifyOn;
public DateTime ssRequestToModifyOn{
  get{
      return _ssRequestToModifyOn;
  }
  set{
      if((_ssRequestToModifyOn!=value) || OptimizedAttributes[16]){
          ChangedAttributes[16] = true;
          _ssRequestToModifyOn = value;
      }
  }
}

private string _ssCanceledBy;
public string ssCanceledBy{
  get{
      return _ssCanceledBy;
  }
  set{
      if((_ssCanceledBy!=value) || OptimizedAttributes[17]){
          ChangedAttributes[17] = true;
          _ssCanceledBy = value;
      }
  }
}

private bool _ssCanceledOn_DEPREC;
public bool ssCanceledOn_DEPREC{
  get{
      return _ssCanceledOn_DEPREC;
  }
  set{
      if((_ssCanceledOn_DEPREC!=value) || OptimizedAttributes[18]){
          ChangedAttributes[18] = true;
          _ssCanceledOn_DEPREC = value;
      }
  }
}

private bool _ssIsAccounting;
public bool ssIsAccounting{
  get{
      return _ssIsAccounting;
  }
  set{
      if((_ssIsAccounting!=value) || OptimizedAttributes[19]){
          ChangedAttributes[19] = true;
          _ssIsAccounting = value;
      }
  }
}

private bool _ssIsStartAccounting;
public bool ssIsStartAccounting{
  get{
      return _ssIsStartAccounting;
  }
  set{
      if((_ssIsStartAccounting!=value) || OptimizedAttributes[20]){
          ChangedAttributes[20] = true;
          _ssIsStartAccounting = value;
      }
  }
}

private DateTime _ssCanceledOn_;
public DateTime ssCanceledOn_{
  get{
      return _ssCanceledOn_;
  }
  set{
      if((_ssCanceledOn_!=value) || OptimizedAttributes[21]){
          ChangedAttributes[21] = true;
          _ssCanceledOn_ = value;
      }
  }
}

private bool _ssApproveAsAreaUsuaria;
public bool ssApproveAsAreaUsuaria{
  get{
      return _ssApproveAsAreaUsuaria;
  }
  set{
      if((_ssApproveAsAreaUsuaria!=value) || OptimizedAttributes[22]){
          ChangedAttributes[22] = true;
          _ssApproveAsAreaUsuaria = value;
      }
  }
}

private bool _ssIsMandatory;
public bool ssIsMandatory{
  get{
      return _ssIsMandatory;
  }
  set{
      if((_ssIsMandatory!=value) || OptimizedAttributes[23]){
          ChangedAttributes[23] = true;
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
      if((_ssIsReassigned!=value) || OptimizedAttributes[24]){
          ChangedAttributes[24] = true;
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
      if((_ssIsSubstituteFor!=value) || OptimizedAttributes[25]){
          ChangedAttributes[25] = true;
          _ssIsSubstituteFor = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_27b1469f497d364a764a1359956ef9adEntityRecord() {
ChangedAttributes = new BitArray(26,true);
OptimizedAttributes = new BitArray(26,false);
_ssId = 0L;
_ssRequisitionApprovalId = 0L;
_ssLevelNumber = 0;
_ssApplicationRoleId = 0L;
_ssEntraJobTitle = "";
_ssDepartmentId = 0L;
_ssManagementId = 0L;
_ssSubdirectionId = 0L;
_ssEntraRoleId = 0L;
_ssEntraUserName = "";
_ssAssignedTo = "";
_ssNeedsContract = false;
_ssApprovalStatusId = 0;
_ssApprovedBy = "";
_ssApprovedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssRequestToModifyBy = "";
_ssRequestToModifyOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssCanceledBy = "";
_ssCanceledOn_DEPREC = false;
_ssIsAccounting = false;
_ssIsStartAccounting = false;
_ssCanceledOn_ = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssApproveAsAreaUsuaria = false;
_ssIsMandatory = false;
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
ssId = r.ReadLongInteger(index++, "RequisitionApprovalLevel.Id", 0L);
ssRequisitionApprovalId = r.ReadEntityReferenceLongInteger(index++, "RequisitionApprovalLevel.RequisitionApprovalId", 0L);
ssLevelNumber = r.ReadInteger(index++, "RequisitionApprovalLevel.LevelNumber", 0);
ssApplicationRoleId = r.ReadEntityReferenceLongInteger(index++, "RequisitionApprovalLevel.ApplicationRoleId", 0L);
ssEntraJobTitle = r.ReadText(index++, "RequisitionApprovalLevel.EntraJobTitle", "");
ssDepartmentId = r.ReadEntityReferenceLongInteger(index++, "RequisitionApprovalLevel.DepartmentId", 0L);
ssManagementId = r.ReadEntityReferenceLongInteger(index++, "RequisitionApprovalLevel.ManagementId", 0L);
ssSubdirectionId = r.ReadEntityReferenceLongInteger(index++, "RequisitionApprovalLevel.SubdirectionId", 0L);
ssEntraRoleId = r.ReadEntityReferenceLongInteger(index++, "RequisitionApprovalLevel.EntraRoleId", 0L);
ssEntraUserName = r.ReadText(index++, "RequisitionApprovalLevel.EntraUserName", "");
ssAssignedTo = r.ReadEntityReferenceText(index++, "RequisitionApprovalLevel.AssignedTo", "");
ssNeedsContract = r.ReadBoolean(index++, "RequisitionApprovalLevel.NeedsContract", false);
ssApprovalStatusId = r.ReadEntityReference(index++, "RequisitionApprovalLevel.ApprovalStatusId", 0);
ssApprovedBy = r.ReadEntityReferenceText(index++, "RequisitionApprovalLevel.ApprovedBy", "");
ssApprovedOn = r.ReadDateTime(index++, "RequisitionApprovalLevel.ApprovedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssRequestToModifyBy = r.ReadEntityReferenceText(index++, "RequisitionApprovalLevel.RequestToModifyBy", "");
ssRequestToModifyOn = r.ReadDateTime(index++, "RequisitionApprovalLevel.RequestToModifyOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssCanceledBy = r.ReadEntityReferenceText(index++, "RequisitionApprovalLevel.CanceledBy", "");
ssCanceledOn_DEPREC = r.ReadBoolean(index++, "RequisitionApprovalLevel.CanceledOn_DEPREC", false);
ssIsAccounting = r.ReadBoolean(index++, "RequisitionApprovalLevel.IsAccounting", false);
ssIsStartAccounting = r.ReadBoolean(index++, "RequisitionApprovalLevel.IsStartAccounting", false);
ssCanceledOn_ = r.ReadDateTime(index++, "RequisitionApprovalLevel.CanceledOn_", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssApproveAsAreaUsuaria = r.ReadBoolean(index++, "RequisitionApprovalLevel.ApproveAsAreaUsuaria", false);
ssIsMandatory = r.ReadBoolean(index++, "RequisitionApprovalLevel.IsMandatory", false);
ssIsReassigned = r.ReadBoolean(index++, "RequisitionApprovalLevel.IsReassigned", false);
ssIsSubstituteFor = r.ReadEntityReferenceText(index++, "RequisitionApprovalLevel.IsSubstituteFor", "");
ChangedAttributes = new BitArray(26,false);
OptimizedAttributes = new BitArray(26,false);
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
public void ReadIM(EN_27b1469f497d364a764a1359956ef9adEntityRecord r) {
this = r;
}


public static bool operator == (EN_27b1469f497d364a764a1359956ef9adEntityRecord a, EN_27b1469f497d364a764a1359956ef9adEntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssRequisitionApprovalId != b.ssRequisitionApprovalId) return false;
if (a.ssLevelNumber != b.ssLevelNumber) return false;
if (a.ssApplicationRoleId != b.ssApplicationRoleId) return false;
if (a.ssEntraJobTitle != b.ssEntraJobTitle) return false;
if (a.ssDepartmentId != b.ssDepartmentId) return false;
if (a.ssManagementId != b.ssManagementId) return false;
if (a.ssSubdirectionId != b.ssSubdirectionId) return false;
if (a.ssEntraRoleId != b.ssEntraRoleId) return false;
if (a.ssEntraUserName != b.ssEntraUserName) return false;
if (a.ssAssignedTo != b.ssAssignedTo) return false;
if (a.ssNeedsContract != b.ssNeedsContract) return false;
if (a.ssApprovalStatusId != b.ssApprovalStatusId) return false;
if (a.ssApprovedBy != b.ssApprovedBy) return false;
if (a.ssApprovedOn != b.ssApprovedOn) return false;
if (a.ssRequestToModifyBy != b.ssRequestToModifyBy) return false;
if (a.ssRequestToModifyOn != b.ssRequestToModifyOn) return false;
if (a.ssCanceledBy != b.ssCanceledBy) return false;
if (a.ssCanceledOn_DEPREC != b.ssCanceledOn_DEPREC) return false;
if (a.ssIsAccounting != b.ssIsAccounting) return false;
if (a.ssIsStartAccounting != b.ssIsStartAccounting) return false;
if (a.ssCanceledOn_ != b.ssCanceledOn_) return false;
if (a.ssApproveAsAreaUsuaria != b.ssApproveAsAreaUsuaria) return false;
if (a.ssIsMandatory != b.ssIsMandatory) return false;
if (a.ssIsReassigned != b.ssIsReassigned) return false;
if (a.ssIsSubstituteFor != b.ssIsSubstituteFor) return false;
return true;
}

public static bool operator != (EN_27b1469f497d364a764a1359956ef9adEntityRecord a, EN_27b1469f497d364a764a1359956ef9adEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_27b1469f497d364a764a1359956ef9adEntityRecord)) return false;
return (this == (EN_27b1469f497d364a764a1359956ef9adEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssRequisitionApprovalId.GetHashCode()
 ^ ssLevelNumber.GetHashCode()
 ^ ssApplicationRoleId.GetHashCode()
 ^ ssEntraJobTitle.GetHashCode()
 ^ ssDepartmentId.GetHashCode()
 ^ ssManagementId.GetHashCode()
 ^ ssSubdirectionId.GetHashCode()
 ^ ssEntraRoleId.GetHashCode()
 ^ ssEntraUserName.GetHashCode()
 ^ ssAssignedTo.GetHashCode()
 ^ ssNeedsContract.GetHashCode()
 ^ ssApprovalStatusId.GetHashCode()
 ^ ssApprovedBy.GetHashCode()
 ^ ssApprovedOn.GetHashCode()
 ^ ssRequestToModifyBy.GetHashCode()
 ^ ssRequestToModifyOn.GetHashCode()
 ^ ssCanceledBy.GetHashCode()
 ^ ssCanceledOn_DEPREC.GetHashCode()
 ^ ssIsAccounting.GetHashCode()
 ^ ssIsStartAccounting.GetHashCode()
 ^ ssCanceledOn_.GetHashCode()
 ^ ssApproveAsAreaUsuaria.GetHashCode()
 ^ ssIsMandatory.GetHashCode()
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


public EN_27b1469f497d364a764a1359956ef9adEntityRecord Duplicate() {
EN_27b1469f497d364a764a1359956ef9adEntityRecord t;
t._ssId = this._ssId;
t._ssRequisitionApprovalId = this._ssRequisitionApprovalId;
t._ssLevelNumber = this._ssLevelNumber;
t._ssApplicationRoleId = this._ssApplicationRoleId;
t._ssEntraJobTitle = this._ssEntraJobTitle;
t._ssDepartmentId = this._ssDepartmentId;
t._ssManagementId = this._ssManagementId;
t._ssSubdirectionId = this._ssSubdirectionId;
t._ssEntraRoleId = this._ssEntraRoleId;
t._ssEntraUserName = this._ssEntraUserName;
t._ssAssignedTo = this._ssAssignedTo;
t._ssNeedsContract = this._ssNeedsContract;
t._ssApprovalStatusId = this._ssApprovalStatusId;
t._ssApprovedBy = this._ssApprovedBy;
t._ssApprovedOn = this._ssApprovedOn;
t._ssRequestToModifyBy = this._ssRequestToModifyBy;
t._ssRequestToModifyOn = this._ssRequestToModifyOn;
t._ssCanceledBy = this._ssCanceledBy;
t._ssCanceledOn_DEPREC = this._ssCanceledOn_DEPREC;
t._ssIsAccounting = this._ssIsAccounting;
t._ssIsStartAccounting = this._ssIsStartAccounting;
t._ssCanceledOn_ = this._ssCanceledOn_;
t._ssApproveAsAreaUsuaria = this._ssApproveAsAreaUsuaria;
t._ssIsMandatory = this._ssIsMandatory;
t._ssIsReassigned = this._ssIsReassigned;
t._ssIsSubstituteFor = this._ssIsSubstituteFor;
t.ChangedAttributes = new BitArray(26);
t.OptimizedAttributes = new BitArray(26);
for(int i = 0; i < 26; i++){
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
} else if (head == "requisitionapprovalid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionApprovalId")) variable.Value = ssRequisitionApprovalId; else variable.Optimized = true;
} else if (head == "levelnumber") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".LevelNumber")) variable.Value = ssLevelNumber; else variable.Optimized = true;
} else if (head == "applicationroleid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApplicationRoleId")) variable.Value = ssApplicationRoleId; else variable.Optimized = true;
} else if (head == "entrajobtitle") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EntraJobTitle")) variable.Value = ssEntraJobTitle; else variable.Optimized = true;
} else if (head == "departmentid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DepartmentId")) variable.Value = ssDepartmentId; else variable.Optimized = true;
} else if (head == "managementid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ManagementId")) variable.Value = ssManagementId; else variable.Optimized = true;
} else if (head == "subdirectionid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SubdirectionId")) variable.Value = ssSubdirectionId; else variable.Optimized = true;
} else if (head == "entraroleid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EntraRoleId")) variable.Value = ssEntraRoleId; else variable.Optimized = true;
} else if (head == "entrausername") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EntraUserName")) variable.Value = ssEntraUserName; else variable.Optimized = true;
} else if (head == "assignedto") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AssignedTo")) variable.Value = ssAssignedTo; else variable.Optimized = true;
} else if (head == "needscontract") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".NeedsContract")) variable.Value = ssNeedsContract; else variable.Optimized = true;
} else if (head == "approvalstatusid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApprovalStatusId")) variable.Value = ssApprovalStatusId; else variable.Optimized = true;
} else if (head == "approvedby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApprovedBy")) variable.Value = ssApprovedBy; else variable.Optimized = true;
} else if (head == "approvedon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApprovedOn")) variable.Value = ssApprovedOn; else variable.Optimized = true;
} else if (head == "requesttomodifyby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequestToModifyBy")) variable.Value = ssRequestToModifyBy; else variable.Optimized = true;
} else if (head == "requesttomodifyon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequestToModifyOn")) variable.Value = ssRequestToModifyOn; else variable.Optimized = true;
} else if (head == "canceledby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CanceledBy")) variable.Value = ssCanceledBy; else variable.Optimized = true;
} else if (head == "canceledon_deprec") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CanceledOn_DEPREC")) variable.Value = ssCanceledOn_DEPREC; else variable.Optimized = true;
} else if (head == "isaccounting") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsAccounting")) variable.Value = ssIsAccounting; else variable.Optimized = true;
} else if (head == "isstartaccounting") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsStartAccounting")) variable.Value = ssIsStartAccounting; else variable.Optimized = true;
} else if (head == "canceledon_") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CanceledOn_")) variable.Value = ssCanceledOn_; else variable.Optimized = true;
} else if (head == "approveasareausuaria") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApproveAsAreaUsuaria")) variable.Value = ssApproveAsAreaUsuaria; else variable.Optimized = true;
} else if (head == "ismandatory") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsMandatory")) variable.Value = ssIsMandatory; else variable.Optimized = true;
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
if (key.Equals(IdRequisitionApprovalId)) {
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
if (key.Equals(IdDepartmentId)) {
return ChangedAttributes[5];
}
if (key.Equals(IdManagementId)) {
return ChangedAttributes[6];
}
if (key.Equals(IdSubdirectionId)) {
return ChangedAttributes[7];
}
if (key.Equals(IdEntraRoleId)) {
return ChangedAttributes[8];
}
if (key.Equals(IdEntraUserName)) {
return ChangedAttributes[9];
}
if (key.Equals(IdAssignedTo)) {
return ChangedAttributes[10];
}
if (key.Equals(IdNeedsContract)) {
return ChangedAttributes[11];
}
if (key.Equals(IdApprovalStatusId)) {
return ChangedAttributes[12];
}
if (key.Equals(IdApprovedBy)) {
return ChangedAttributes[13];
}
if (key.Equals(IdApprovedOn)) {
return ChangedAttributes[14];
}
if (key.Equals(IdRequestToModifyBy)) {
return ChangedAttributes[15];
}
if (key.Equals(IdRequestToModifyOn)) {
return ChangedAttributes[16];
}
if (key.Equals(IdCanceledBy)) {
return ChangedAttributes[17];
}
if (key.Equals(IdCanceledOn_DEPREC)) {
return ChangedAttributes[18];
}
if (key.Equals(IdIsAccounting)) {
return ChangedAttributes[19];
}
if (key.Equals(IdIsStartAccounting)) {
return ChangedAttributes[20];
}
if (key.Equals(IdCanceledOn_)) {
return ChangedAttributes[21];
}
if (key.Equals(IdApproveAsAreaUsuaria)) {
return ChangedAttributes[22];
}
if (key.Equals(IdIsMandatory)) {
return ChangedAttributes[23];
}
if (key.Equals(IdIsReassigned)) {
return ChangedAttributes[24];
}
if (key.Equals(IdIsSubstituteFor)) {
return ChangedAttributes[25];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdRequisitionApprovalId)) {
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
if (key.Equals(IdDepartmentId)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdManagementId)) {
return OptimizedAttributes[6];
}
if (key.Equals(IdSubdirectionId)) {
return OptimizedAttributes[7];
}
if (key.Equals(IdEntraRoleId)) {
return OptimizedAttributes[8];
}
if (key.Equals(IdEntraUserName)) {
return OptimizedAttributes[9];
}
if (key.Equals(IdAssignedTo)) {
return OptimizedAttributes[10];
}
if (key.Equals(IdNeedsContract)) {
return OptimizedAttributes[11];
}
if (key.Equals(IdApprovalStatusId)) {
return OptimizedAttributes[12];
}
if (key.Equals(IdApprovedBy)) {
return OptimizedAttributes[13];
}
if (key.Equals(IdApprovedOn)) {
return OptimizedAttributes[14];
}
if (key.Equals(IdRequestToModifyBy)) {
return OptimizedAttributes[15];
}
if (key.Equals(IdRequestToModifyOn)) {
return OptimizedAttributes[16];
}
if (key.Equals(IdCanceledBy)) {
return OptimizedAttributes[17];
}
if (key.Equals(IdCanceledOn_DEPREC)) {
return OptimizedAttributes[18];
}
if (key.Equals(IdIsAccounting)) {
return OptimizedAttributes[19];
}
if (key.Equals(IdIsStartAccounting)) {
return OptimizedAttributes[20];
}
if (key.Equals(IdCanceledOn_)) {
return OptimizedAttributes[21];
}
if (key.Equals(IdApproveAsAreaUsuaria)) {
return OptimizedAttributes[22];
}
if (key.Equals(IdIsMandatory)) {
return OptimizedAttributes[23];
}
if (key.Equals(IdIsReassigned)) {
return OptimizedAttributes[24];
}
if (key.Equals(IdIsSubstituteFor)) {
return OptimizedAttributes[25];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdRequisitionApprovalId) {
return ssRequisitionApprovalId;
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
if (key == IdDepartmentId) {
return ssDepartmentId;
}
if (key == IdManagementId) {
return ssManagementId;
}
if (key == IdSubdirectionId) {
return ssSubdirectionId;
}
if (key == IdEntraRoleId) {
return ssEntraRoleId;
}
if (key == IdEntraUserName) {
return ssEntraUserName;
}
if (key == IdAssignedTo) {
return ssAssignedTo;
}
if (key == IdNeedsContract) {
return ssNeedsContract;
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
if (key == IdRequestToModifyBy) {
return ssRequestToModifyBy;
}
if (key == IdRequestToModifyOn) {
return ssRequestToModifyOn;
}
if (key == IdCanceledBy) {
return ssCanceledBy;
}
if (key == IdCanceledOn_DEPREC) {
return ssCanceledOn_DEPREC;
}
if (key == IdIsAccounting) {
return ssIsAccounting;
}
if (key == IdIsStartAccounting) {
return ssIsStartAccounting;
}
if (key == IdCanceledOn_) {
return ssCanceledOn_;
}
if (key == IdApproveAsAreaUsuaria) {
return ssApproveAsAreaUsuaria;
}
if (key == IdIsMandatory) {
return ssIsMandatory;
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
if (attributeKey == IdRequisitionApprovalId.Key.AsGuid) {
return ssRequisitionApprovalId;
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
if (attributeKey == IdDepartmentId.Key.AsGuid) {
return ssDepartmentId;
}
if (attributeKey == IdManagementId.Key.AsGuid) {
return ssManagementId;
}
if (attributeKey == IdSubdirectionId.Key.AsGuid) {
return ssSubdirectionId;
}
if (attributeKey == IdEntraRoleId.Key.AsGuid) {
return ssEntraRoleId;
}
if (attributeKey == IdEntraUserName.Key.AsGuid) {
return ssEntraUserName;
}
if (attributeKey == IdAssignedTo.Key.AsGuid) {
return ssAssignedTo;
}
if (attributeKey == IdNeedsContract.Key.AsGuid) {
return ssNeedsContract;
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
if (attributeKey == IdRequestToModifyBy.Key.AsGuid) {
return ssRequestToModifyBy;
}
if (attributeKey == IdRequestToModifyOn.Key.AsGuid) {
return ssRequestToModifyOn;
}
if (attributeKey == IdCanceledBy.Key.AsGuid) {
return ssCanceledBy;
}
if (attributeKey == IdCanceledOn_DEPREC.Key.AsGuid) {
return ssCanceledOn_DEPREC;
}
if (attributeKey == IdIsAccounting.Key.AsGuid) {
return ssIsAccounting;
}
if (attributeKey == IdIsStartAccounting.Key.AsGuid) {
return ssIsStartAccounting;
}
if (attributeKey == IdCanceledOn_.Key.AsGuid) {
return ssCanceledOn_;
}
if (attributeKey == IdApproveAsAreaUsuaria.Key.AsGuid) {
return ssApproveAsAreaUsuaria;
}
if (attributeKey == IdIsMandatory.Key.AsGuid) {
return ssIsMandatory;
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
ChangedAttributes = new BitArray(26);
OptimizedAttributes = new BitArray(26);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssRequisitionApprovalId = (long) other.AttributeGet(IdRequisitionApprovalId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdRequisitionApprovalId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdRequisitionApprovalId);
ssLevelNumber = (int) other.AttributeGet(IdLevelNumber);
ChangedAttributes[2] = other.ChangedAttributeGet(IdLevelNumber);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdLevelNumber);
ssApplicationRoleId = (long) other.AttributeGet(IdApplicationRoleId);
ChangedAttributes[3] = other.ChangedAttributeGet(IdApplicationRoleId);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdApplicationRoleId);
ssEntraJobTitle = (string) other.AttributeGet(IdEntraJobTitle);
ChangedAttributes[4] = other.ChangedAttributeGet(IdEntraJobTitle);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdEntraJobTitle);
ssDepartmentId = (long) other.AttributeGet(IdDepartmentId);
ChangedAttributes[5] = other.ChangedAttributeGet(IdDepartmentId);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdDepartmentId);
ssManagementId = (long) other.AttributeGet(IdManagementId);
ChangedAttributes[6] = other.ChangedAttributeGet(IdManagementId);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdManagementId);
ssSubdirectionId = (long) other.AttributeGet(IdSubdirectionId);
ChangedAttributes[7] = other.ChangedAttributeGet(IdSubdirectionId);
OptimizedAttributes[7] = other.OptimizedAttributeGet(IdSubdirectionId);
ssEntraRoleId = (long) other.AttributeGet(IdEntraRoleId);
ChangedAttributes[8] = other.ChangedAttributeGet(IdEntraRoleId);
OptimizedAttributes[8] = other.OptimizedAttributeGet(IdEntraRoleId);
ssEntraUserName = (string) other.AttributeGet(IdEntraUserName);
ChangedAttributes[9] = other.ChangedAttributeGet(IdEntraUserName);
OptimizedAttributes[9] = other.OptimizedAttributeGet(IdEntraUserName);
ssAssignedTo = (string) other.AttributeGet(IdAssignedTo);
ChangedAttributes[10] = other.ChangedAttributeGet(IdAssignedTo);
OptimizedAttributes[10] = other.OptimizedAttributeGet(IdAssignedTo);
ssNeedsContract = (bool) other.AttributeGet(IdNeedsContract);
ChangedAttributes[11] = other.ChangedAttributeGet(IdNeedsContract);
OptimizedAttributes[11] = other.OptimizedAttributeGet(IdNeedsContract);
ssApprovalStatusId = (int) other.AttributeGet(IdApprovalStatusId);
ChangedAttributes[12] = other.ChangedAttributeGet(IdApprovalStatusId);
OptimizedAttributes[12] = other.OptimizedAttributeGet(IdApprovalStatusId);
ssApprovedBy = (string) other.AttributeGet(IdApprovedBy);
ChangedAttributes[13] = other.ChangedAttributeGet(IdApprovedBy);
OptimizedAttributes[13] = other.OptimizedAttributeGet(IdApprovedBy);
ssApprovedOn = (DateTime) other.AttributeGet(IdApprovedOn);
ChangedAttributes[14] = other.ChangedAttributeGet(IdApprovedOn);
OptimizedAttributes[14] = other.OptimizedAttributeGet(IdApprovedOn);
ssRequestToModifyBy = (string) other.AttributeGet(IdRequestToModifyBy);
ChangedAttributes[15] = other.ChangedAttributeGet(IdRequestToModifyBy);
OptimizedAttributes[15] = other.OptimizedAttributeGet(IdRequestToModifyBy);
ssRequestToModifyOn = (DateTime) other.AttributeGet(IdRequestToModifyOn);
ChangedAttributes[16] = other.ChangedAttributeGet(IdRequestToModifyOn);
OptimizedAttributes[16] = other.OptimizedAttributeGet(IdRequestToModifyOn);
ssCanceledBy = (string) other.AttributeGet(IdCanceledBy);
ChangedAttributes[17] = other.ChangedAttributeGet(IdCanceledBy);
OptimizedAttributes[17] = other.OptimizedAttributeGet(IdCanceledBy);
ssCanceledOn_DEPREC = (bool) other.AttributeGet(IdCanceledOn_DEPREC);
ChangedAttributes[18] = other.ChangedAttributeGet(IdCanceledOn_DEPREC);
OptimizedAttributes[18] = other.OptimizedAttributeGet(IdCanceledOn_DEPREC);
ssIsAccounting = (bool) other.AttributeGet(IdIsAccounting);
ChangedAttributes[19] = other.ChangedAttributeGet(IdIsAccounting);
OptimizedAttributes[19] = other.OptimizedAttributeGet(IdIsAccounting);
ssIsStartAccounting = (bool) other.AttributeGet(IdIsStartAccounting);
ChangedAttributes[20] = other.ChangedAttributeGet(IdIsStartAccounting);
OptimizedAttributes[20] = other.OptimizedAttributeGet(IdIsStartAccounting);
ssCanceledOn_ = (DateTime) other.AttributeGet(IdCanceledOn_);
ChangedAttributes[21] = other.ChangedAttributeGet(IdCanceledOn_);
OptimizedAttributes[21] = other.OptimizedAttributeGet(IdCanceledOn_);
ssApproveAsAreaUsuaria = (bool) other.AttributeGet(IdApproveAsAreaUsuaria);
ChangedAttributes[22] = other.ChangedAttributeGet(IdApproveAsAreaUsuaria);
OptimizedAttributes[22] = other.OptimizedAttributeGet(IdApproveAsAreaUsuaria);
ssIsMandatory = (bool) other.AttributeGet(IdIsMandatory);
ChangedAttributes[23] = other.ChangedAttributeGet(IdIsMandatory);
OptimizedAttributes[23] = other.OptimizedAttributeGet(IdIsMandatory);
ssIsReassigned = (bool) other.AttributeGet(IdIsReassigned);
ChangedAttributes[24] = other.ChangedAttributeGet(IdIsReassigned);
OptimizedAttributes[24] = other.OptimizedAttributeGet(IdIsReassigned);
ssIsSubstituteFor = (string) other.AttributeGet(IdIsSubstituteFor);
ChangedAttributes[25] = other.ChangedAttributeGet(IdIsSubstituteFor);
OptimizedAttributes[25] = other.OptimizedAttributeGet(IdIsSubstituteFor);
}
} // EN_27b1469f497d364a764a1359956ef9adEntityRecord

/// <summary>
/// RecordList type <code>RequisitionApprovalLevelList</code> that represents a record list of
///  <code>RequisitionApprovalLevel</code>
/// </summary>
public partial class RL_75b7c1c818327cb126543d6d6a18a3c3 : GenericRecordList<EN_27b1469f497d364a764a1359956ef9adEntityRecord>, IEnumerable, IEnumerator {

protected override EN_27b1469f497d364a764a1359956ef9adEntityRecord GetElementDefaultValue() {
return new EN_27b1469f497d364a764a1359956ef9adEntityRecord();
}

public T[] ToArray<T>(Func<EN_27b1469f497d364a764a1359956ef9adEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_75b7c1c818327cb126543d6d6a18a3c3 recordList, Func<EN_27b1469f497d364a764a1359956ef9adEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_75b7c1c818327cb126543d6d6a18a3c3(EN_27b1469f497d364a764a1359956ef9adEntityRecord[] array) {
  RL_75b7c1c818327cb126543d6d6a18a3c3 result = new RL_75b7c1c818327cb126543d6d6a18a3c3();
result.InnerFromArray(array);
    return result;
}

public static RL_75b7c1c818327cb126543d6d6a18a3c3 ToList<T>(T[] array, Func <T, EN_27b1469f497d364a764a1359956ef9adEntityRecord> converter) {
  RL_75b7c1c818327cb126543d6d6a18a3c3 result = new RL_75b7c1c818327cb126543d6d6a18a3c3();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_75b7c1c818327cb126543d6d6a18a3c3 FromRestList<T>(RestList<T> restList, Func <T, EN_27b1469f497d364a764a1359956ef9adEntityRecord> converter) {
  RL_75b7c1c818327cb126543d6d6a18a3c3 result = new RL_75b7c1c818327cb126543d6d6a18a3c3();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_75b7c1c818327cb126543d6d6a18a3c3() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_27b1469f497d364a764a1359956ef9adEntityRecord> NewList() {
return new RL_75b7c1c818327cb126543d6d6a18a3c3();
}


} // RL_75b7c1c818327cb126543d6d6a18a3c3
}
