using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] InvoiceApprovalLevel (6qkxj66oTkq_WXZ7abdddg)
///  <code>EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord</code> that represent
/// s <code>InvoiceApprovalLevel</code> <p>Description: </p>
/// </summary>
// Name: InvoiceApprovalLevel
public partial struct EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord : ITypedRecord<EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*8_7Ww2boDEKSjwvU54LZZQ");
internal static readonly GlobalObjectKey IdInvoiceApprovalId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*_D2p_yw+WU6RDKx7CndOCw");
internal static readonly GlobalObjectKey IdLevelNumber = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*ez2MUFIlo0qU+SNy5EyhNQ");
internal static readonly GlobalObjectKey IdAssignedTo = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*m1S2JI46gU6Le8vk7WUk5A");
internal static readonly GlobalObjectKey IdApplicationRoleId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*V5TCUWcAZkC2rDwt7a5sNQ");
internal static readonly GlobalObjectKey IdEntraJobTitle = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*0Hx6UY3lf0ivFv535qn6Ow");
internal static readonly GlobalObjectKey IdDepartmentId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*qCa54olbiEW4+9K+aUdVow");
internal static readonly GlobalObjectKey IdManagementId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*9YUqcJl9rEWtU_jnW4ba_Q");
internal static readonly GlobalObjectKey IdSubdirectionId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*dMi1ck0Yc0yqete2YfIlDA");
internal static readonly GlobalObjectKey IdEntraRoleId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*aE+Q8TYkVkm0oKyj058jXA");
internal static readonly GlobalObjectKey IdApprovalStatusId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*8Wxcjd_kU0mzC6IoYr7kfg");
internal static readonly GlobalObjectKey IdCanBeFirstApprover = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*gMEJFYHgqk+MK9WEK2Ux5Q");
internal static readonly GlobalObjectKey IdSelectsNextApprover = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*kSbrsJGIOE61tiPbnmQk6Q");
internal static readonly GlobalObjectKey IdSelectsFirstApprover = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*dnBJStld7EiIooiFyWfiEA");
internal static readonly GlobalObjectKey IdIsAccounting = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*mfKCSEwDUk+NeoM6nCGR5w");
internal static readonly GlobalObjectKey IdIsStartAccounting = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*g4BkBo_3rkGQAd5NdOH5Ig");
internal static readonly GlobalObjectKey IdApprovedBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*rtLKodzjmES4qKhQsiWCrg");
internal static readonly GlobalObjectKey IdApprovedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*+sW+oVcAX0W_nIXnpn1+Tw");
internal static readonly GlobalObjectKey IdRequestToModifyBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Zjir63uYS0iiUvDv_otQhQ");
internal static readonly GlobalObjectKey IdRequestToModifyOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*kA4Al72XxUaMvgRkWNk5lg");
internal static readonly GlobalObjectKey IdCanceledBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*jBog9w1cwUq_AWg2EwXfEw");
internal static readonly GlobalObjectKey IdCanceledOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*hbSFUrKlikCjMsF6Yav0Mg");
internal static readonly GlobalObjectKey IdNeedsContract_DEPREC = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*UJu04mzHmE271dIFmOpCKw");
internal static readonly GlobalObjectKey IdIsReassigned = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*QSOE_ynjDka0d3UrrcrhwA");
internal static readonly GlobalObjectKey IdIsSubstituteFor = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*r+iZqb79BUeUxMypynKAXw");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(25,true);
          _ssId = value;
      }
  }
}

private long _ssInvoiceApprovalId;
public long ssInvoiceApprovalId{
  get{
      return _ssInvoiceApprovalId;
  }
  set{
      if((_ssInvoiceApprovalId!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssInvoiceApprovalId = value;
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

private string _ssAssignedTo;
public string ssAssignedTo{
  get{
      return _ssAssignedTo;
  }
  set{
      if((_ssAssignedTo!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssAssignedTo = value;
      }
  }
}

private long _ssApplicationRoleId;
public long ssApplicationRoleId{
  get{
      return _ssApplicationRoleId;
  }
  set{
      if((_ssApplicationRoleId!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
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
      if((_ssEntraJobTitle!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
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
      if((_ssDepartmentId!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
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
      if((_ssManagementId!=value) || OptimizedAttributes[7]){
          ChangedAttributes[7] = true;
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
      if((_ssSubdirectionId!=value) || OptimizedAttributes[8]){
          ChangedAttributes[8] = true;
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
      if((_ssEntraRoleId!=value) || OptimizedAttributes[9]){
          ChangedAttributes[9] = true;
          _ssEntraRoleId = value;
      }
  }
}

private int _ssApprovalStatusId;
public int ssApprovalStatusId{
  get{
      return _ssApprovalStatusId;
  }
  set{
      if((_ssApprovalStatusId!=value) || OptimizedAttributes[10]){
          ChangedAttributes[10] = true;
          _ssApprovalStatusId = value;
      }
  }
}

private bool _ssCanBeFirstApprover;
public bool ssCanBeFirstApprover{
  get{
      return _ssCanBeFirstApprover;
  }
  set{
      if((_ssCanBeFirstApprover!=value) || OptimizedAttributes[11]){
          ChangedAttributes[11] = true;
          _ssCanBeFirstApprover = value;
      }
  }
}

private bool _ssSelectsNextApprover;
public bool ssSelectsNextApprover{
  get{
      return _ssSelectsNextApprover;
  }
  set{
      if((_ssSelectsNextApprover!=value) || OptimizedAttributes[12]){
          ChangedAttributes[12] = true;
          _ssSelectsNextApprover = value;
      }
  }
}

private bool _ssSelectsFirstApprover;
public bool ssSelectsFirstApprover{
  get{
      return _ssSelectsFirstApprover;
  }
  set{
      if((_ssSelectsFirstApprover!=value) || OptimizedAttributes[13]){
          ChangedAttributes[13] = true;
          _ssSelectsFirstApprover = value;
      }
  }
}

private bool _ssIsAccounting;
public bool ssIsAccounting{
  get{
      return _ssIsAccounting;
  }
  set{
      if((_ssIsAccounting!=value) || OptimizedAttributes[14]){
          ChangedAttributes[14] = true;
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
      if((_ssIsStartAccounting!=value) || OptimizedAttributes[15]){
          ChangedAttributes[15] = true;
          _ssIsStartAccounting = value;
      }
  }
}

private string _ssApprovedBy;
public string ssApprovedBy{
  get{
      return _ssApprovedBy;
  }
  set{
      if((_ssApprovedBy!=value) || OptimizedAttributes[16]){
          ChangedAttributes[16] = true;
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
      if((_ssApprovedOn!=value) || OptimizedAttributes[17]){
          ChangedAttributes[17] = true;
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
      if((_ssRequestToModifyBy!=value) || OptimizedAttributes[18]){
          ChangedAttributes[18] = true;
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
      if((_ssRequestToModifyOn!=value) || OptimizedAttributes[19]){
          ChangedAttributes[19] = true;
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
      if((_ssCanceledBy!=value) || OptimizedAttributes[20]){
          ChangedAttributes[20] = true;
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
      if((_ssCanceledOn!=value) || OptimizedAttributes[21]){
          ChangedAttributes[21] = true;
          _ssCanceledOn = value;
      }
  }
}

private bool _ssNeedsContract_DEPREC;
public bool ssNeedsContract_DEPREC{
  get{
      return _ssNeedsContract_DEPREC;
  }
  set{
      if((_ssNeedsContract_DEPREC!=value) || OptimizedAttributes[22]){
          ChangedAttributes[22] = true;
          _ssNeedsContract_DEPREC = value;
      }
  }
}

private bool _ssIsReassigned;
public bool ssIsReassigned{
  get{
      return _ssIsReassigned;
  }
  set{
      if((_ssIsReassigned!=value) || OptimizedAttributes[23]){
          ChangedAttributes[23] = true;
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
      if((_ssIsSubstituteFor!=value) || OptimizedAttributes[24]){
          ChangedAttributes[24] = true;
          _ssIsSubstituteFor = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord() {
ChangedAttributes = new BitArray(25,true);
OptimizedAttributes = new BitArray(25,false);
_ssId = 0L;
_ssInvoiceApprovalId = 0L;
_ssLevelNumber = 0;
_ssAssignedTo = "";
_ssApplicationRoleId = 0L;
_ssEntraJobTitle = "";
_ssDepartmentId = 0L;
_ssManagementId = 0L;
_ssSubdirectionId = 0L;
_ssEntraRoleId = 0L;
_ssApprovalStatusId = 0;
_ssCanBeFirstApprover = false;
_ssSelectsNextApprover = false;
_ssSelectsFirstApprover = false;
_ssIsAccounting = false;
_ssIsStartAccounting = false;
_ssApprovedBy = "";
_ssApprovedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssRequestToModifyBy = "";
_ssRequestToModifyOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssCanceledBy = "";
_ssCanceledOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssNeedsContract_DEPREC = false;
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
ssId = r.ReadLongInteger(index++, "InvoiceApprovalLevel.Id", 0L);
ssInvoiceApprovalId = r.ReadEntityReferenceLongInteger(index++, "InvoiceApprovalLevel.InvoiceApprovalId", 0L);
ssLevelNumber = r.ReadInteger(index++, "InvoiceApprovalLevel.LevelNumber", 0);
ssAssignedTo = r.ReadEntityReferenceText(index++, "InvoiceApprovalLevel.AssignedTo", "");
ssApplicationRoleId = r.ReadEntityReferenceLongInteger(index++, "InvoiceApprovalLevel.ApplicationRoleId", 0L);
ssEntraJobTitle = r.ReadText(index++, "InvoiceApprovalLevel.EntraJobTitle", "");
ssDepartmentId = r.ReadEntityReferenceLongInteger(index++, "InvoiceApprovalLevel.DepartmentId", 0L);
ssManagementId = r.ReadEntityReferenceLongInteger(index++, "InvoiceApprovalLevel.ManagementId", 0L);
ssSubdirectionId = r.ReadEntityReferenceLongInteger(index++, "InvoiceApprovalLevel.SubdirectionId", 0L);
ssEntraRoleId = r.ReadEntityReferenceLongInteger(index++, "InvoiceApprovalLevel.EntraRoleId", 0L);
ssApprovalStatusId = r.ReadEntityReference(index++, "InvoiceApprovalLevel.ApprovalStatusId", 0);
ssCanBeFirstApprover = r.ReadBoolean(index++, "InvoiceApprovalLevel.CanBeFirstApprover", false);
ssSelectsNextApprover = r.ReadBoolean(index++, "InvoiceApprovalLevel.SelectsNextApprover", false);
ssSelectsFirstApprover = r.ReadBoolean(index++, "InvoiceApprovalLevel.SelectsFirstApprover", false);
ssIsAccounting = r.ReadBoolean(index++, "InvoiceApprovalLevel.IsAccounting", false);
ssIsStartAccounting = r.ReadBoolean(index++, "InvoiceApprovalLevel.IsStartAccounting", false);
ssApprovedBy = r.ReadEntityReferenceText(index++, "InvoiceApprovalLevel.ApprovedBy", "");
ssApprovedOn = r.ReadDateTime(index++, "InvoiceApprovalLevel.ApprovedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssRequestToModifyBy = r.ReadEntityReferenceText(index++, "InvoiceApprovalLevel.RequestToModifyBy", "");
ssRequestToModifyOn = r.ReadDateTime(index++, "InvoiceApprovalLevel.RequestToModifyOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssCanceledBy = r.ReadEntityReferenceText(index++, "InvoiceApprovalLevel.CanceledBy", "");
ssCanceledOn = r.ReadDateTime(index++, "InvoiceApprovalLevel.CanceledOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssNeedsContract_DEPREC = r.ReadBoolean(index++, "InvoiceApprovalLevel.NeedsContract_DEPREC", false);
ssIsReassigned = r.ReadBoolean(index++, "InvoiceApprovalLevel.IsReassigned", false);
ssIsSubstituteFor = r.ReadEntityReferenceText(index++, "InvoiceApprovalLevel.IsSubstituteFor", "");
ChangedAttributes = new BitArray(25,false);
OptimizedAttributes = new BitArray(25,false);
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
public void ReadIM(EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord r) {
this = r;
}


public static bool operator == (EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord a, EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssInvoiceApprovalId != b.ssInvoiceApprovalId) return false;
if (a.ssLevelNumber != b.ssLevelNumber) return false;
if (a.ssAssignedTo != b.ssAssignedTo) return false;
if (a.ssApplicationRoleId != b.ssApplicationRoleId) return false;
if (a.ssEntraJobTitle != b.ssEntraJobTitle) return false;
if (a.ssDepartmentId != b.ssDepartmentId) return false;
if (a.ssManagementId != b.ssManagementId) return false;
if (a.ssSubdirectionId != b.ssSubdirectionId) return false;
if (a.ssEntraRoleId != b.ssEntraRoleId) return false;
if (a.ssApprovalStatusId != b.ssApprovalStatusId) return false;
if (a.ssCanBeFirstApprover != b.ssCanBeFirstApprover) return false;
if (a.ssSelectsNextApprover != b.ssSelectsNextApprover) return false;
if (a.ssSelectsFirstApprover != b.ssSelectsFirstApprover) return false;
if (a.ssIsAccounting != b.ssIsAccounting) return false;
if (a.ssIsStartAccounting != b.ssIsStartAccounting) return false;
if (a.ssApprovedBy != b.ssApprovedBy) return false;
if (a.ssApprovedOn != b.ssApprovedOn) return false;
if (a.ssRequestToModifyBy != b.ssRequestToModifyBy) return false;
if (a.ssRequestToModifyOn != b.ssRequestToModifyOn) return false;
if (a.ssCanceledBy != b.ssCanceledBy) return false;
if (a.ssCanceledOn != b.ssCanceledOn) return false;
if (a.ssNeedsContract_DEPREC != b.ssNeedsContract_DEPREC) return false;
if (a.ssIsReassigned != b.ssIsReassigned) return false;
if (a.ssIsSubstituteFor != b.ssIsSubstituteFor) return false;
return true;
}

public static bool operator != (EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord a, EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord)) return false;
return (this == (EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssInvoiceApprovalId.GetHashCode()
 ^ ssLevelNumber.GetHashCode()
 ^ ssAssignedTo.GetHashCode()
 ^ ssApplicationRoleId.GetHashCode()
 ^ ssEntraJobTitle.GetHashCode()
 ^ ssDepartmentId.GetHashCode()
 ^ ssManagementId.GetHashCode()
 ^ ssSubdirectionId.GetHashCode()
 ^ ssEntraRoleId.GetHashCode()
 ^ ssApprovalStatusId.GetHashCode()
 ^ ssCanBeFirstApprover.GetHashCode()
 ^ ssSelectsNextApprover.GetHashCode()
 ^ ssSelectsFirstApprover.GetHashCode()
 ^ ssIsAccounting.GetHashCode()
 ^ ssIsStartAccounting.GetHashCode()
 ^ ssApprovedBy.GetHashCode()
 ^ ssApprovedOn.GetHashCode()
 ^ ssRequestToModifyBy.GetHashCode()
 ^ ssRequestToModifyOn.GetHashCode()
 ^ ssCanceledBy.GetHashCode()
 ^ ssCanceledOn.GetHashCode()
 ^ ssNeedsContract_DEPREC.GetHashCode()
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


public EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord Duplicate() {
EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord t;
t._ssId = this._ssId;
t._ssInvoiceApprovalId = this._ssInvoiceApprovalId;
t._ssLevelNumber = this._ssLevelNumber;
t._ssAssignedTo = this._ssAssignedTo;
t._ssApplicationRoleId = this._ssApplicationRoleId;
t._ssEntraJobTitle = this._ssEntraJobTitle;
t._ssDepartmentId = this._ssDepartmentId;
t._ssManagementId = this._ssManagementId;
t._ssSubdirectionId = this._ssSubdirectionId;
t._ssEntraRoleId = this._ssEntraRoleId;
t._ssApprovalStatusId = this._ssApprovalStatusId;
t._ssCanBeFirstApprover = this._ssCanBeFirstApprover;
t._ssSelectsNextApprover = this._ssSelectsNextApprover;
t._ssSelectsFirstApprover = this._ssSelectsFirstApprover;
t._ssIsAccounting = this._ssIsAccounting;
t._ssIsStartAccounting = this._ssIsStartAccounting;
t._ssApprovedBy = this._ssApprovedBy;
t._ssApprovedOn = this._ssApprovedOn;
t._ssRequestToModifyBy = this._ssRequestToModifyBy;
t._ssRequestToModifyOn = this._ssRequestToModifyOn;
t._ssCanceledBy = this._ssCanceledBy;
t._ssCanceledOn = this._ssCanceledOn;
t._ssNeedsContract_DEPREC = this._ssNeedsContract_DEPREC;
t._ssIsReassigned = this._ssIsReassigned;
t._ssIsSubstituteFor = this._ssIsSubstituteFor;
t.ChangedAttributes = new BitArray(25);
t.OptimizedAttributes = new BitArray(25);
for(int i = 0; i < 25; i++){
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
} else if (head == "invoiceapprovalid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceApprovalId")) variable.Value = ssInvoiceApprovalId; else variable.Optimized = true;
} else if (head == "levelnumber") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".LevelNumber")) variable.Value = ssLevelNumber; else variable.Optimized = true;
} else if (head == "assignedto") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AssignedTo")) variable.Value = ssAssignedTo; else variable.Optimized = true;
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
} else if (head == "approvalstatusid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApprovalStatusId")) variable.Value = ssApprovalStatusId; else variable.Optimized = true;
} else if (head == "canbefirstapprover") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CanBeFirstApprover")) variable.Value = ssCanBeFirstApprover; else variable.Optimized = true;
} else if (head == "selectsnextapprover") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SelectsNextApprover")) variable.Value = ssSelectsNextApprover; else variable.Optimized = true;
} else if (head == "selectsfirstapprover") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SelectsFirstApprover")) variable.Value = ssSelectsFirstApprover; else variable.Optimized = true;
} else if (head == "isaccounting") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsAccounting")) variable.Value = ssIsAccounting; else variable.Optimized = true;
} else if (head == "isstartaccounting") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsStartAccounting")) variable.Value = ssIsStartAccounting; else variable.Optimized = true;
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
} else if (head == "canceledon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CanceledOn")) variable.Value = ssCanceledOn; else variable.Optimized = true;
} else if (head == "needscontract_deprec") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".NeedsContract_DEPREC")) variable.Value = ssNeedsContract_DEPREC; else variable.Optimized = true;
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
if (key.Equals(IdInvoiceApprovalId)) {
return ChangedAttributes[1];
}
if (key.Equals(IdLevelNumber)) {
return ChangedAttributes[2];
}
if (key.Equals(IdAssignedTo)) {
return ChangedAttributes[3];
}
if (key.Equals(IdApplicationRoleId)) {
return ChangedAttributes[4];
}
if (key.Equals(IdEntraJobTitle)) {
return ChangedAttributes[5];
}
if (key.Equals(IdDepartmentId)) {
return ChangedAttributes[6];
}
if (key.Equals(IdManagementId)) {
return ChangedAttributes[7];
}
if (key.Equals(IdSubdirectionId)) {
return ChangedAttributes[8];
}
if (key.Equals(IdEntraRoleId)) {
return ChangedAttributes[9];
}
if (key.Equals(IdApprovalStatusId)) {
return ChangedAttributes[10];
}
if (key.Equals(IdCanBeFirstApprover)) {
return ChangedAttributes[11];
}
if (key.Equals(IdSelectsNextApprover)) {
return ChangedAttributes[12];
}
if (key.Equals(IdSelectsFirstApprover)) {
return ChangedAttributes[13];
}
if (key.Equals(IdIsAccounting)) {
return ChangedAttributes[14];
}
if (key.Equals(IdIsStartAccounting)) {
return ChangedAttributes[15];
}
if (key.Equals(IdApprovedBy)) {
return ChangedAttributes[16];
}
if (key.Equals(IdApprovedOn)) {
return ChangedAttributes[17];
}
if (key.Equals(IdRequestToModifyBy)) {
return ChangedAttributes[18];
}
if (key.Equals(IdRequestToModifyOn)) {
return ChangedAttributes[19];
}
if (key.Equals(IdCanceledBy)) {
return ChangedAttributes[20];
}
if (key.Equals(IdCanceledOn)) {
return ChangedAttributes[21];
}
if (key.Equals(IdNeedsContract_DEPREC)) {
return ChangedAttributes[22];
}
if (key.Equals(IdIsReassigned)) {
return ChangedAttributes[23];
}
if (key.Equals(IdIsSubstituteFor)) {
return ChangedAttributes[24];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdInvoiceApprovalId)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdLevelNumber)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdAssignedTo)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdApplicationRoleId)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdEntraJobTitle)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdDepartmentId)) {
return OptimizedAttributes[6];
}
if (key.Equals(IdManagementId)) {
return OptimizedAttributes[7];
}
if (key.Equals(IdSubdirectionId)) {
return OptimizedAttributes[8];
}
if (key.Equals(IdEntraRoleId)) {
return OptimizedAttributes[9];
}
if (key.Equals(IdApprovalStatusId)) {
return OptimizedAttributes[10];
}
if (key.Equals(IdCanBeFirstApprover)) {
return OptimizedAttributes[11];
}
if (key.Equals(IdSelectsNextApprover)) {
return OptimizedAttributes[12];
}
if (key.Equals(IdSelectsFirstApprover)) {
return OptimizedAttributes[13];
}
if (key.Equals(IdIsAccounting)) {
return OptimizedAttributes[14];
}
if (key.Equals(IdIsStartAccounting)) {
return OptimizedAttributes[15];
}
if (key.Equals(IdApprovedBy)) {
return OptimizedAttributes[16];
}
if (key.Equals(IdApprovedOn)) {
return OptimizedAttributes[17];
}
if (key.Equals(IdRequestToModifyBy)) {
return OptimizedAttributes[18];
}
if (key.Equals(IdRequestToModifyOn)) {
return OptimizedAttributes[19];
}
if (key.Equals(IdCanceledBy)) {
return OptimizedAttributes[20];
}
if (key.Equals(IdCanceledOn)) {
return OptimizedAttributes[21];
}
if (key.Equals(IdNeedsContract_DEPREC)) {
return OptimizedAttributes[22];
}
if (key.Equals(IdIsReassigned)) {
return OptimizedAttributes[23];
}
if (key.Equals(IdIsSubstituteFor)) {
return OptimizedAttributes[24];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdInvoiceApprovalId) {
return ssInvoiceApprovalId;
}
if (key == IdLevelNumber) {
return ssLevelNumber;
}
if (key == IdAssignedTo) {
return ssAssignedTo;
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
if (key == IdApprovalStatusId) {
return ssApprovalStatusId;
}
if (key == IdCanBeFirstApprover) {
return ssCanBeFirstApprover;
}
if (key == IdSelectsNextApprover) {
return ssSelectsNextApprover;
}
if (key == IdSelectsFirstApprover) {
return ssSelectsFirstApprover;
}
if (key == IdIsAccounting) {
return ssIsAccounting;
}
if (key == IdIsStartAccounting) {
return ssIsStartAccounting;
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
if (key == IdCanceledOn) {
return ssCanceledOn;
}
if (key == IdNeedsContract_DEPREC) {
return ssNeedsContract_DEPREC;
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
if (attributeKey == IdInvoiceApprovalId.Key.AsGuid) {
return ssInvoiceApprovalId;
}
if (attributeKey == IdLevelNumber.Key.AsGuid) {
return ssLevelNumber;
}
if (attributeKey == IdAssignedTo.Key.AsGuid) {
return ssAssignedTo;
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
if (attributeKey == IdApprovalStatusId.Key.AsGuid) {
return ssApprovalStatusId;
}
if (attributeKey == IdCanBeFirstApprover.Key.AsGuid) {
return ssCanBeFirstApprover;
}
if (attributeKey == IdSelectsNextApprover.Key.AsGuid) {
return ssSelectsNextApprover;
}
if (attributeKey == IdSelectsFirstApprover.Key.AsGuid) {
return ssSelectsFirstApprover;
}
if (attributeKey == IdIsAccounting.Key.AsGuid) {
return ssIsAccounting;
}
if (attributeKey == IdIsStartAccounting.Key.AsGuid) {
return ssIsStartAccounting;
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
if (attributeKey == IdCanceledOn.Key.AsGuid) {
return ssCanceledOn;
}
if (attributeKey == IdNeedsContract_DEPREC.Key.AsGuid) {
return ssNeedsContract_DEPREC;
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
ChangedAttributes = new BitArray(25);
OptimizedAttributes = new BitArray(25);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssInvoiceApprovalId = (long) other.AttributeGet(IdInvoiceApprovalId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdInvoiceApprovalId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdInvoiceApprovalId);
ssLevelNumber = (int) other.AttributeGet(IdLevelNumber);
ChangedAttributes[2] = other.ChangedAttributeGet(IdLevelNumber);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdLevelNumber);
ssAssignedTo = (string) other.AttributeGet(IdAssignedTo);
ChangedAttributes[3] = other.ChangedAttributeGet(IdAssignedTo);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdAssignedTo);
ssApplicationRoleId = (long) other.AttributeGet(IdApplicationRoleId);
ChangedAttributes[4] = other.ChangedAttributeGet(IdApplicationRoleId);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdApplicationRoleId);
ssEntraJobTitle = (string) other.AttributeGet(IdEntraJobTitle);
ChangedAttributes[5] = other.ChangedAttributeGet(IdEntraJobTitle);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdEntraJobTitle);
ssDepartmentId = (long) other.AttributeGet(IdDepartmentId);
ChangedAttributes[6] = other.ChangedAttributeGet(IdDepartmentId);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdDepartmentId);
ssManagementId = (long) other.AttributeGet(IdManagementId);
ChangedAttributes[7] = other.ChangedAttributeGet(IdManagementId);
OptimizedAttributes[7] = other.OptimizedAttributeGet(IdManagementId);
ssSubdirectionId = (long) other.AttributeGet(IdSubdirectionId);
ChangedAttributes[8] = other.ChangedAttributeGet(IdSubdirectionId);
OptimizedAttributes[8] = other.OptimizedAttributeGet(IdSubdirectionId);
ssEntraRoleId = (long) other.AttributeGet(IdEntraRoleId);
ChangedAttributes[9] = other.ChangedAttributeGet(IdEntraRoleId);
OptimizedAttributes[9] = other.OptimizedAttributeGet(IdEntraRoleId);
ssApprovalStatusId = (int) other.AttributeGet(IdApprovalStatusId);
ChangedAttributes[10] = other.ChangedAttributeGet(IdApprovalStatusId);
OptimizedAttributes[10] = other.OptimizedAttributeGet(IdApprovalStatusId);
ssCanBeFirstApprover = (bool) other.AttributeGet(IdCanBeFirstApprover);
ChangedAttributes[11] = other.ChangedAttributeGet(IdCanBeFirstApprover);
OptimizedAttributes[11] = other.OptimizedAttributeGet(IdCanBeFirstApprover);
ssSelectsNextApprover = (bool) other.AttributeGet(IdSelectsNextApprover);
ChangedAttributes[12] = other.ChangedAttributeGet(IdSelectsNextApprover);
OptimizedAttributes[12] = other.OptimizedAttributeGet(IdSelectsNextApprover);
ssSelectsFirstApprover = (bool) other.AttributeGet(IdSelectsFirstApprover);
ChangedAttributes[13] = other.ChangedAttributeGet(IdSelectsFirstApprover);
OptimizedAttributes[13] = other.OptimizedAttributeGet(IdSelectsFirstApprover);
ssIsAccounting = (bool) other.AttributeGet(IdIsAccounting);
ChangedAttributes[14] = other.ChangedAttributeGet(IdIsAccounting);
OptimizedAttributes[14] = other.OptimizedAttributeGet(IdIsAccounting);
ssIsStartAccounting = (bool) other.AttributeGet(IdIsStartAccounting);
ChangedAttributes[15] = other.ChangedAttributeGet(IdIsStartAccounting);
OptimizedAttributes[15] = other.OptimizedAttributeGet(IdIsStartAccounting);
ssApprovedBy = (string) other.AttributeGet(IdApprovedBy);
ChangedAttributes[16] = other.ChangedAttributeGet(IdApprovedBy);
OptimizedAttributes[16] = other.OptimizedAttributeGet(IdApprovedBy);
ssApprovedOn = (DateTime) other.AttributeGet(IdApprovedOn);
ChangedAttributes[17] = other.ChangedAttributeGet(IdApprovedOn);
OptimizedAttributes[17] = other.OptimizedAttributeGet(IdApprovedOn);
ssRequestToModifyBy = (string) other.AttributeGet(IdRequestToModifyBy);
ChangedAttributes[18] = other.ChangedAttributeGet(IdRequestToModifyBy);
OptimizedAttributes[18] = other.OptimizedAttributeGet(IdRequestToModifyBy);
ssRequestToModifyOn = (DateTime) other.AttributeGet(IdRequestToModifyOn);
ChangedAttributes[19] = other.ChangedAttributeGet(IdRequestToModifyOn);
OptimizedAttributes[19] = other.OptimizedAttributeGet(IdRequestToModifyOn);
ssCanceledBy = (string) other.AttributeGet(IdCanceledBy);
ChangedAttributes[20] = other.ChangedAttributeGet(IdCanceledBy);
OptimizedAttributes[20] = other.OptimizedAttributeGet(IdCanceledBy);
ssCanceledOn = (DateTime) other.AttributeGet(IdCanceledOn);
ChangedAttributes[21] = other.ChangedAttributeGet(IdCanceledOn);
OptimizedAttributes[21] = other.OptimizedAttributeGet(IdCanceledOn);
ssNeedsContract_DEPREC = (bool) other.AttributeGet(IdNeedsContract_DEPREC);
ChangedAttributes[22] = other.ChangedAttributeGet(IdNeedsContract_DEPREC);
OptimizedAttributes[22] = other.OptimizedAttributeGet(IdNeedsContract_DEPREC);
ssIsReassigned = (bool) other.AttributeGet(IdIsReassigned);
ChangedAttributes[23] = other.ChangedAttributeGet(IdIsReassigned);
OptimizedAttributes[23] = other.OptimizedAttributeGet(IdIsReassigned);
ssIsSubstituteFor = (string) other.AttributeGet(IdIsSubstituteFor);
ChangedAttributes[24] = other.ChangedAttributeGet(IdIsSubstituteFor);
OptimizedAttributes[24] = other.OptimizedAttributeGet(IdIsSubstituteFor);
}
} // EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord

/// <summary>
/// RecordList type <code>InvoiceApprovalLevelList</code> that represents a record list of
///  <code>InvoiceApprovalLevel</code>
/// </summary>
public partial class RL_ceb6b480297e13460f270b15b86cd978 : GenericRecordList<EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord>, IEnumerable, IEnumerator {

protected override EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord GetElementDefaultValue() {
return new EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord();
}

public T[] ToArray<T>(Func<EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_ceb6b480297e13460f270b15b86cd978 recordList, Func<EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_ceb6b480297e13460f270b15b86cd978(EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord[] array) {
  RL_ceb6b480297e13460f270b15b86cd978 result = new RL_ceb6b480297e13460f270b15b86cd978();
result.InnerFromArray(array);
    return result;
}

public static RL_ceb6b480297e13460f270b15b86cd978 ToList<T>(T[] array, Func <T, EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord> converter) {
  RL_ceb6b480297e13460f270b15b86cd978 result = new RL_ceb6b480297e13460f270b15b86cd978();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_ceb6b480297e13460f270b15b86cd978 FromRestList<T>(RestList<T> restList, Func <T, EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord> converter) {
  RL_ceb6b480297e13460f270b15b86cd978 result = new RL_ceb6b480297e13460f270b15b86cd978();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_ceb6b480297e13460f270b15b86cd978() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord> NewList() {
return new RL_ceb6b480297e13460f270b15b86cd978();
}


} // RL_ceb6b480297e13460f270b15b86cd978
}
