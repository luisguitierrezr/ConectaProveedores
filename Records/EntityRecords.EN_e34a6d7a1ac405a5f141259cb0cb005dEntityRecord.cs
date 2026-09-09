using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [ReferenceEntity] User_Extended_Internal (f6CaFxf2ZkqkUsZjmcyLLw)
///  <code>EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord</code> that represent
/// s <code>User_Extended_Internal</code> <p>Description: Extension of the User table to keep the data
///  of the Telcel employees.</p>
/// </summary>
// Name: User_Extended_Internal
public partial struct EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord : ITypedRecord<EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*xMqvRE_JbkuoMwCPL9tpPg");
internal static readonly GlobalObjectKey IdEmployeeNumber = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*wa_r8xyxNUCnjgGIH25C6Q");
internal static readonly GlobalObjectKey IdManagedBy = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*aRPHDqQ4DkuNxyuLRkHsYA");
internal static readonly GlobalObjectKey IdRegionId = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*fMZybe3xFUmRCDl5o+qSzw");
internal static readonly GlobalObjectKey IdDepartmentId = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*2Rs502_XXkqqjzEfqJpetQ");
internal static readonly GlobalObjectKey IdManagementId = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*cAMcHqRX3E+bdLiZJM_iyg");
internal static readonly GlobalObjectKey IdSubdirectionId = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*wCuEmzrcWUS8s6j5oQ3ajw");
internal static readonly GlobalObjectKey IdTelcelDirectionId = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*2h8tfkqMqUm1yZdOhE5Vrg");
internal static readonly GlobalObjectKey IdCity = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*VU06pQGG7Uipi4BGMIRPlA");
internal static readonly GlobalObjectKey IdJobTitle = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*4Rgpc_Jj6UuC4Kh9VL8Osg");
internal static readonly GlobalObjectKey IdEntraRoleId = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*LBAPKCT6DkaY+gPgEvYJLw");
internal static readonly GlobalObjectKey IdonPremisesDistinguishedName = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*i6bjpUWiuESyGAYSMO7yPw");
internal static readonly GlobalObjectKey IdHasRolesAssigned = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*mPPynAbiEEmOPpGPJ18zUw");
internal static readonly GlobalObjectKey IdLastSync = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*9VbcflhockaevVWReMV8aQ");
internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*Kaegf73w20CTh2iJf9lhGg");
internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*gpA0ZOMheEGpIhx6Z163TA");
internal static readonly GlobalObjectKey IdUpdatedBy = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*1TSCzBh5r0yGbPyjEVYwpA");
internal static readonly GlobalObjectKey IdUpdatedOn = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*+6pRQIP5AU+afSa3rdkwXw");
internal static readonly GlobalObjectKey IdEntraId = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*LYHoZabRnkuJlAJjBwBmgg");
internal static readonly GlobalObjectKey IdTelcelDireccion = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*EWaazkozm0qzZ6N_SxYZKw");

private string _ssId;
public string ssId{
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

private string _ssEmployeeNumber;
public string ssEmployeeNumber{
  get{
      return _ssEmployeeNumber;
  }
  set{
      if((_ssEmployeeNumber!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssEmployeeNumber = value;
      }
  }
}

private string _ssManagedBy;
public string ssManagedBy{
  get{
      return _ssManagedBy;
  }
  set{
      if((_ssManagedBy!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssManagedBy = value;
      }
  }
}

private long _ssRegionId;
public long ssRegionId{
  get{
      return _ssRegionId;
  }
  set{
      if((_ssRegionId!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssRegionId = value;
      }
  }
}

private long _ssDepartmentId;
public long ssDepartmentId{
  get{
      return _ssDepartmentId;
  }
  set{
      if((_ssDepartmentId!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
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
      if((_ssManagementId!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
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
      if((_ssSubdirectionId!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssSubdirectionId = value;
      }
  }
}

private long _ssTelcelDirectionId;
public long ssTelcelDirectionId{
  get{
      return _ssTelcelDirectionId;
  }
  set{
      if((_ssTelcelDirectionId!=value) || OptimizedAttributes[7]){
          ChangedAttributes[7] = true;
          _ssTelcelDirectionId = value;
      }
  }
}

private string _ssCity;
public string ssCity{
  get{
      return _ssCity;
  }
  set{
      if((_ssCity!=value) || OptimizedAttributes[8]){
          ChangedAttributes[8] = true;
          _ssCity = value;
      }
  }
}

private string _ssJobTitle;
public string ssJobTitle{
  get{
      return _ssJobTitle;
  }
  set{
      if((_ssJobTitle!=value) || OptimizedAttributes[9]){
          ChangedAttributes[9] = true;
          _ssJobTitle = value;
      }
  }
}

private long _ssEntraRoleId;
public long ssEntraRoleId{
  get{
      return _ssEntraRoleId;
  }
  set{
      if((_ssEntraRoleId!=value) || OptimizedAttributes[10]){
          ChangedAttributes[10] = true;
          _ssEntraRoleId = value;
      }
  }
}

private string _ssonPremisesDistinguishedName;
public string ssonPremisesDistinguishedName{
  get{
      return _ssonPremisesDistinguishedName;
  }
  set{
      if((_ssonPremisesDistinguishedName!=value) || OptimizedAttributes[11]){
          ChangedAttributes[11] = true;
          _ssonPremisesDistinguishedName = value;
      }
  }
}

private bool _ssHasRolesAssigned;
public bool ssHasRolesAssigned{
  get{
      return _ssHasRolesAssigned;
  }
  set{
      if((_ssHasRolesAssigned!=value) || OptimizedAttributes[12]){
          ChangedAttributes[12] = true;
          _ssHasRolesAssigned = value;
      }
  }
}

private DateTime _ssLastSync;
public DateTime ssLastSync{
  get{
      return _ssLastSync;
  }
  set{
      if((_ssLastSync!=value) || OptimizedAttributes[13]){
          ChangedAttributes[13] = true;
          _ssLastSync = value;
      }
  }
}

private string _ssCreatedBy;
public string ssCreatedBy{
  get{
      return _ssCreatedBy;
  }
  set{
      if((_ssCreatedBy!=value) || OptimizedAttributes[14]){
          ChangedAttributes[14] = true;
          _ssCreatedBy = value;
      }
  }
}

private DateTime _ssCreatedOn;
public DateTime ssCreatedOn{
  get{
      return _ssCreatedOn;
  }
  set{
      if((_ssCreatedOn!=value) || OptimizedAttributes[15]){
          ChangedAttributes[15] = true;
          _ssCreatedOn = value;
      }
  }
}

private string _ssUpdatedBy;
public string ssUpdatedBy{
  get{
      return _ssUpdatedBy;
  }
  set{
      if((_ssUpdatedBy!=value) || OptimizedAttributes[16]){
          ChangedAttributes[16] = true;
          _ssUpdatedBy = value;
      }
  }
}

private DateTime _ssUpdatedOn;
public DateTime ssUpdatedOn{
  get{
      return _ssUpdatedOn;
  }
  set{
      if((_ssUpdatedOn!=value) || OptimizedAttributes[17]){
          ChangedAttributes[17] = true;
          _ssUpdatedOn = value;
      }
  }
}

private string _ssEntraId;
public string ssEntraId{
  get{
      return _ssEntraId;
  }
  set{
      if((_ssEntraId!=value) || OptimizedAttributes[18]){
          ChangedAttributes[18] = true;
          _ssEntraId = value;
      }
  }
}

private string _ssTelcelDireccion;
public string ssTelcelDireccion{
  get{
      return _ssTelcelDireccion;
  }
  set{
      if((_ssTelcelDireccion!=value) || OptimizedAttributes[19]){
          ChangedAttributes[19] = true;
          _ssTelcelDireccion = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord() {
ChangedAttributes = new BitArray(20,true);
OptimizedAttributes = new BitArray(20,false);
_ssId = "";
_ssEmployeeNumber = "";
_ssManagedBy = "";
_ssRegionId = 0L;
_ssDepartmentId = 0L;
_ssManagementId = 0L;
_ssSubdirectionId = 0L;
_ssTelcelDirectionId = 0L;
_ssCity = "";
_ssJobTitle = "";
_ssEntraRoleId = 0L;
_ssonPremisesDistinguishedName = "";
_ssHasRolesAssigned = false;
_ssLastSync = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssCreatedBy = "";
_ssCreatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssUpdatedBy = "";
_ssUpdatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssEntraId = "";
_ssTelcelDireccion = "";
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
ssId = r.ReadEntityReferenceText(index++, "User_Extended_Internal.Id", "");
ssEmployeeNumber = r.ReadText(index++, "User_Extended_Internal.EmployeeNumber", "");
ssManagedBy = r.ReadEntityReferenceText(index++, "User_Extended_Internal.ManagedBy", "");
ssRegionId = r.ReadEntityReferenceLongInteger(index++, "User_Extended_Internal.RegionId", 0L);
ssDepartmentId = r.ReadEntityReferenceLongInteger(index++, "User_Extended_Internal.DepartmentId", 0L);
ssManagementId = r.ReadEntityReferenceLongInteger(index++, "User_Extended_Internal.ManagementId", 0L);
ssSubdirectionId = r.ReadEntityReferenceLongInteger(index++, "User_Extended_Internal.SubdirectionId", 0L);
ssTelcelDirectionId = r.ReadEntityReferenceLongInteger(index++, "User_Extended_Internal.TelcelDirectionId", 0L);
ssCity = r.ReadText(index++, "User_Extended_Internal.City", "");
ssJobTitle = r.ReadText(index++, "User_Extended_Internal.JobTitle", "");
ssEntraRoleId = r.ReadEntityReferenceLongInteger(index++, "User_Extended_Internal.EntraRoleId", 0L);
ssonPremisesDistinguishedName = r.ReadText(index++, "User_Extended_Internal.onPremisesDistinguishedName", "");
ssHasRolesAssigned = r.ReadBoolean(index++, "User_Extended_Internal.HasRolesAssigned", false);
ssLastSync = r.ReadDateTime(index++, "User_Extended_Internal.LastSync", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssCreatedBy = r.ReadEntityReferenceText(index++, "User_Extended_Internal.CreatedBy", "");
ssCreatedOn = r.ReadDateTime(index++, "User_Extended_Internal.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssUpdatedBy = r.ReadEntityReferenceText(index++, "User_Extended_Internal.UpdatedBy", "");
ssUpdatedOn = r.ReadDateTime(index++, "User_Extended_Internal.UpdatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssEntraId = r.ReadText(index++, "User_Extended_Internal.EntraId", "");
ssTelcelDireccion = r.ReadText(index++, "User_Extended_Internal.TelcelDireccion", "");
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
public void ReadIM(EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord r) {
this = r;
}


public static bool operator == (EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord a, EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssEmployeeNumber != b.ssEmployeeNumber) return false;
if (a.ssManagedBy != b.ssManagedBy) return false;
if (a.ssRegionId != b.ssRegionId) return false;
if (a.ssDepartmentId != b.ssDepartmentId) return false;
if (a.ssManagementId != b.ssManagementId) return false;
if (a.ssSubdirectionId != b.ssSubdirectionId) return false;
if (a.ssTelcelDirectionId != b.ssTelcelDirectionId) return false;
if (a.ssCity != b.ssCity) return false;
if (a.ssJobTitle != b.ssJobTitle) return false;
if (a.ssEntraRoleId != b.ssEntraRoleId) return false;
if (a.ssonPremisesDistinguishedName != b.ssonPremisesDistinguishedName) return false;
if (a.ssHasRolesAssigned != b.ssHasRolesAssigned) return false;
if (a.ssLastSync != b.ssLastSync) return false;
if (a.ssCreatedBy != b.ssCreatedBy) return false;
if (a.ssCreatedOn != b.ssCreatedOn) return false;
if (a.ssUpdatedBy != b.ssUpdatedBy) return false;
if (a.ssUpdatedOn != b.ssUpdatedOn) return false;
if (a.ssEntraId != b.ssEntraId) return false;
if (a.ssTelcelDireccion != b.ssTelcelDireccion) return false;
return true;
}

public static bool operator != (EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord a, EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord)) return false;
return (this == (EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssEmployeeNumber.GetHashCode()
 ^ ssManagedBy.GetHashCode()
 ^ ssRegionId.GetHashCode()
 ^ ssDepartmentId.GetHashCode()
 ^ ssManagementId.GetHashCode()
 ^ ssSubdirectionId.GetHashCode()
 ^ ssTelcelDirectionId.GetHashCode()
 ^ ssCity.GetHashCode()
 ^ ssJobTitle.GetHashCode()
 ^ ssEntraRoleId.GetHashCode()
 ^ ssonPremisesDistinguishedName.GetHashCode()
 ^ ssHasRolesAssigned.GetHashCode()
 ^ ssLastSync.GetHashCode()
 ^ ssCreatedBy.GetHashCode()
 ^ ssCreatedOn.GetHashCode()
 ^ ssUpdatedBy.GetHashCode()
 ^ ssUpdatedOn.GetHashCode()
 ^ ssEntraId.GetHashCode()
 ^ ssTelcelDireccion.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord Duplicate() {
EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord t;
t._ssId = this._ssId;
t._ssEmployeeNumber = this._ssEmployeeNumber;
t._ssManagedBy = this._ssManagedBy;
t._ssRegionId = this._ssRegionId;
t._ssDepartmentId = this._ssDepartmentId;
t._ssManagementId = this._ssManagementId;
t._ssSubdirectionId = this._ssSubdirectionId;
t._ssTelcelDirectionId = this._ssTelcelDirectionId;
t._ssCity = this._ssCity;
t._ssJobTitle = this._ssJobTitle;
t._ssEntraRoleId = this._ssEntraRoleId;
t._ssonPremisesDistinguishedName = this._ssonPremisesDistinguishedName;
t._ssHasRolesAssigned = this._ssHasRolesAssigned;
t._ssLastSync = this._ssLastSync;
t._ssCreatedBy = this._ssCreatedBy;
t._ssCreatedOn = this._ssCreatedOn;
t._ssUpdatedBy = this._ssUpdatedBy;
t._ssUpdatedOn = this._ssUpdatedOn;
t._ssEntraId = this._ssEntraId;
t._ssTelcelDireccion = this._ssTelcelDireccion;
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
} else if (head == "employeenumber") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EmployeeNumber")) variable.Value = ssEmployeeNumber; else variable.Optimized = true;
} else if (head == "managedby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ManagedBy")) variable.Value = ssManagedBy; else variable.Optimized = true;
} else if (head == "regionid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RegionId")) variable.Value = ssRegionId; else variable.Optimized = true;
} else if (head == "departmentid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DepartmentId")) variable.Value = ssDepartmentId; else variable.Optimized = true;
} else if (head == "managementid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ManagementId")) variable.Value = ssManagementId; else variable.Optimized = true;
} else if (head == "subdirectionid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SubdirectionId")) variable.Value = ssSubdirectionId; else variable.Optimized = true;
} else if (head == "telceldirectionid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TelcelDirectionId")) variable.Value = ssTelcelDirectionId; else variable.Optimized = true;
} else if (head == "city") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".City")) variable.Value = ssCity; else variable.Optimized = true;
} else if (head == "jobtitle") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".JobTitle")) variable.Value = ssJobTitle; else variable.Optimized = true;
} else if (head == "entraroleid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EntraRoleId")) variable.Value = ssEntraRoleId; else variable.Optimized = true;
} else if (head == "onpremisesdistinguishedname") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".onPremisesDistinguishedName")) variable.Value = ssonPremisesDistinguishedName; else variable.Optimized = true;
} else if (head == "hasrolesassigned") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".HasRolesAssigned")) variable.Value = ssHasRolesAssigned; else variable.Optimized = true;
} else if (head == "lastsync") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".LastSync")) variable.Value = ssLastSync; else variable.Optimized = true;
} else if (head == "createdby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedBy")) variable.Value = ssCreatedBy; else variable.Optimized = true;
} else if (head == "createdon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedOn")) variable.Value = ssCreatedOn; else variable.Optimized = true;
} else if (head == "updatedby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdatedBy")) variable.Value = ssUpdatedBy; else variable.Optimized = true;
} else if (head == "updatedon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdatedOn")) variable.Value = ssUpdatedOn; else variable.Optimized = true;
} else if (head == "entraid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EntraId")) variable.Value = ssEntraId; else variable.Optimized = true;
} else if (head == "telceldireccion") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TelcelDireccion")) variable.Value = ssTelcelDireccion; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdEmployeeNumber)) {
return ChangedAttributes[1];
}
if (key.Equals(IdManagedBy)) {
return ChangedAttributes[2];
}
if (key.Equals(IdRegionId)) {
return ChangedAttributes[3];
}
if (key.Equals(IdDepartmentId)) {
return ChangedAttributes[4];
}
if (key.Equals(IdManagementId)) {
return ChangedAttributes[5];
}
if (key.Equals(IdSubdirectionId)) {
return ChangedAttributes[6];
}
if (key.Equals(IdTelcelDirectionId)) {
return ChangedAttributes[7];
}
if (key.Equals(IdCity)) {
return ChangedAttributes[8];
}
if (key.Equals(IdJobTitle)) {
return ChangedAttributes[9];
}
if (key.Equals(IdEntraRoleId)) {
return ChangedAttributes[10];
}
if (key.Equals(IdonPremisesDistinguishedName)) {
return ChangedAttributes[11];
}
if (key.Equals(IdHasRolesAssigned)) {
return ChangedAttributes[12];
}
if (key.Equals(IdLastSync)) {
return ChangedAttributes[13];
}
if (key.Equals(IdCreatedBy)) {
return ChangedAttributes[14];
}
if (key.Equals(IdCreatedOn)) {
return ChangedAttributes[15];
}
if (key.Equals(IdUpdatedBy)) {
return ChangedAttributes[16];
}
if (key.Equals(IdUpdatedOn)) {
return ChangedAttributes[17];
}
if (key.Equals(IdEntraId)) {
return ChangedAttributes[18];
}
if (key.Equals(IdTelcelDireccion)) {
return ChangedAttributes[19];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdEmployeeNumber)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdManagedBy)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdRegionId)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdDepartmentId)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdManagementId)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdSubdirectionId)) {
return OptimizedAttributes[6];
}
if (key.Equals(IdTelcelDirectionId)) {
return OptimizedAttributes[7];
}
if (key.Equals(IdCity)) {
return OptimizedAttributes[8];
}
if (key.Equals(IdJobTitle)) {
return OptimizedAttributes[9];
}
if (key.Equals(IdEntraRoleId)) {
return OptimizedAttributes[10];
}
if (key.Equals(IdonPremisesDistinguishedName)) {
return OptimizedAttributes[11];
}
if (key.Equals(IdHasRolesAssigned)) {
return OptimizedAttributes[12];
}
if (key.Equals(IdLastSync)) {
return OptimizedAttributes[13];
}
if (key.Equals(IdCreatedBy)) {
return OptimizedAttributes[14];
}
if (key.Equals(IdCreatedOn)) {
return OptimizedAttributes[15];
}
if (key.Equals(IdUpdatedBy)) {
return OptimizedAttributes[16];
}
if (key.Equals(IdUpdatedOn)) {
return OptimizedAttributes[17];
}
if (key.Equals(IdEntraId)) {
return OptimizedAttributes[18];
}
if (key.Equals(IdTelcelDireccion)) {
return OptimizedAttributes[19];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdEmployeeNumber) {
return ssEmployeeNumber;
}
if (key == IdManagedBy) {
return ssManagedBy;
}
if (key == IdRegionId) {
return ssRegionId;
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
if (key == IdTelcelDirectionId) {
return ssTelcelDirectionId;
}
if (key == IdCity) {
return ssCity;
}
if (key == IdJobTitle) {
return ssJobTitle;
}
if (key == IdEntraRoleId) {
return ssEntraRoleId;
}
if (key == IdonPremisesDistinguishedName) {
return ssonPremisesDistinguishedName;
}
if (key == IdHasRolesAssigned) {
return ssHasRolesAssigned;
}
if (key == IdLastSync) {
return ssLastSync;
}
if (key == IdCreatedBy) {
return ssCreatedBy;
}
if (key == IdCreatedOn) {
return ssCreatedOn;
}
if (key == IdUpdatedBy) {
return ssUpdatedBy;
}
if (key == IdUpdatedOn) {
return ssUpdatedOn;
}
if (key == IdEntraId) {
return ssEntraId;
}
if (key == IdTelcelDireccion) {
return ssTelcelDireccion;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdEmployeeNumber.Key.AsGuid) {
return ssEmployeeNumber;
}
if (attributeKey == IdManagedBy.Key.AsGuid) {
return ssManagedBy;
}
if (attributeKey == IdRegionId.Key.AsGuid) {
return ssRegionId;
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
if (attributeKey == IdTelcelDirectionId.Key.AsGuid) {
return ssTelcelDirectionId;
}
if (attributeKey == IdCity.Key.AsGuid) {
return ssCity;
}
if (attributeKey == IdJobTitle.Key.AsGuid) {
return ssJobTitle;
}
if (attributeKey == IdEntraRoleId.Key.AsGuid) {
return ssEntraRoleId;
}
if (attributeKey == IdonPremisesDistinguishedName.Key.AsGuid) {
return ssonPremisesDistinguishedName;
}
if (attributeKey == IdHasRolesAssigned.Key.AsGuid) {
return ssHasRolesAssigned;
}
if (attributeKey == IdLastSync.Key.AsGuid) {
return ssLastSync;
}
if (attributeKey == IdCreatedBy.Key.AsGuid) {
return ssCreatedBy;
}
if (attributeKey == IdCreatedOn.Key.AsGuid) {
return ssCreatedOn;
}
if (attributeKey == IdUpdatedBy.Key.AsGuid) {
return ssUpdatedBy;
}
if (attributeKey == IdUpdatedOn.Key.AsGuid) {
return ssUpdatedOn;
}
if (attributeKey == IdEntraId.Key.AsGuid) {
return ssEntraId;
}
if (attributeKey == IdTelcelDireccion.Key.AsGuid) {
return ssTelcelDireccion;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(20);
OptimizedAttributes = new BitArray(20);
if (other == null) return;
ssId = (string) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssEmployeeNumber = (string) other.AttributeGet(IdEmployeeNumber);
ChangedAttributes[1] = other.ChangedAttributeGet(IdEmployeeNumber);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdEmployeeNumber);
ssManagedBy = (string) other.AttributeGet(IdManagedBy);
ChangedAttributes[2] = other.ChangedAttributeGet(IdManagedBy);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdManagedBy);
ssRegionId = (long) other.AttributeGet(IdRegionId);
ChangedAttributes[3] = other.ChangedAttributeGet(IdRegionId);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdRegionId);
ssDepartmentId = (long) other.AttributeGet(IdDepartmentId);
ChangedAttributes[4] = other.ChangedAttributeGet(IdDepartmentId);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdDepartmentId);
ssManagementId = (long) other.AttributeGet(IdManagementId);
ChangedAttributes[5] = other.ChangedAttributeGet(IdManagementId);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdManagementId);
ssSubdirectionId = (long) other.AttributeGet(IdSubdirectionId);
ChangedAttributes[6] = other.ChangedAttributeGet(IdSubdirectionId);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdSubdirectionId);
ssTelcelDirectionId = (long) other.AttributeGet(IdTelcelDirectionId);
ChangedAttributes[7] = other.ChangedAttributeGet(IdTelcelDirectionId);
OptimizedAttributes[7] = other.OptimizedAttributeGet(IdTelcelDirectionId);
ssCity = (string) other.AttributeGet(IdCity);
ChangedAttributes[8] = other.ChangedAttributeGet(IdCity);
OptimizedAttributes[8] = other.OptimizedAttributeGet(IdCity);
ssJobTitle = (string) other.AttributeGet(IdJobTitle);
ChangedAttributes[9] = other.ChangedAttributeGet(IdJobTitle);
OptimizedAttributes[9] = other.OptimizedAttributeGet(IdJobTitle);
ssEntraRoleId = (long) other.AttributeGet(IdEntraRoleId);
ChangedAttributes[10] = other.ChangedAttributeGet(IdEntraRoleId);
OptimizedAttributes[10] = other.OptimizedAttributeGet(IdEntraRoleId);
ssonPremisesDistinguishedName = (string) other.AttributeGet(IdonPremisesDistinguishedName);
ChangedAttributes[11] = other.ChangedAttributeGet(IdonPremisesDistinguishedName);
OptimizedAttributes[11] = other.OptimizedAttributeGet(IdonPremisesDistinguishedName);
ssHasRolesAssigned = (bool) other.AttributeGet(IdHasRolesAssigned);
ChangedAttributes[12] = other.ChangedAttributeGet(IdHasRolesAssigned);
OptimizedAttributes[12] = other.OptimizedAttributeGet(IdHasRolesAssigned);
ssLastSync = (DateTime) other.AttributeGet(IdLastSync);
ChangedAttributes[13] = other.ChangedAttributeGet(IdLastSync);
OptimizedAttributes[13] = other.OptimizedAttributeGet(IdLastSync);
ssCreatedBy = (string) other.AttributeGet(IdCreatedBy);
ChangedAttributes[14] = other.ChangedAttributeGet(IdCreatedBy);
OptimizedAttributes[14] = other.OptimizedAttributeGet(IdCreatedBy);
ssCreatedOn = (DateTime) other.AttributeGet(IdCreatedOn);
ChangedAttributes[15] = other.ChangedAttributeGet(IdCreatedOn);
OptimizedAttributes[15] = other.OptimizedAttributeGet(IdCreatedOn);
ssUpdatedBy = (string) other.AttributeGet(IdUpdatedBy);
ChangedAttributes[16] = other.ChangedAttributeGet(IdUpdatedBy);
OptimizedAttributes[16] = other.OptimizedAttributeGet(IdUpdatedBy);
ssUpdatedOn = (DateTime) other.AttributeGet(IdUpdatedOn);
ChangedAttributes[17] = other.ChangedAttributeGet(IdUpdatedOn);
OptimizedAttributes[17] = other.OptimizedAttributeGet(IdUpdatedOn);
ssEntraId = (string) other.AttributeGet(IdEntraId);
ChangedAttributes[18] = other.ChangedAttributeGet(IdEntraId);
OptimizedAttributes[18] = other.OptimizedAttributeGet(IdEntraId);
ssTelcelDireccion = (string) other.AttributeGet(IdTelcelDireccion);
ChangedAttributes[19] = other.ChangedAttributeGet(IdTelcelDireccion);
OptimizedAttributes[19] = other.OptimizedAttributeGet(IdTelcelDireccion);
}
} // EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord

/// <summary>
/// RecordList type <code>User_Extended_InternalList</code> that represents a record list of
///  <code>User_Extended_Internal</code>
/// </summary>
public partial class RL_5adb40c67e70229326f58a0f743d05eb : GenericRecordList<EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord>, IEnumerable, IEnumerator {

protected override EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord GetElementDefaultValue() {
return new EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord();
}

public T[] ToArray<T>(Func<EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_5adb40c67e70229326f58a0f743d05eb recordList, Func<EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_5adb40c67e70229326f58a0f743d05eb(EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord[] array) {
  RL_5adb40c67e70229326f58a0f743d05eb result = new RL_5adb40c67e70229326f58a0f743d05eb();
result.InnerFromArray(array);
    return result;
}

public static RL_5adb40c67e70229326f58a0f743d05eb ToList<T>(T[] array, Func <T, EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord> converter) {
  RL_5adb40c67e70229326f58a0f743d05eb result = new RL_5adb40c67e70229326f58a0f743d05eb();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_5adb40c67e70229326f58a0f743d05eb FromRestList<T>(RestList<T> restList, Func <T, EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord> converter) {
  RL_5adb40c67e70229326f58a0f743d05eb result = new RL_5adb40c67e70229326f58a0f743d05eb();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_5adb40c67e70229326f58a0f743d05eb() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord> NewList() {
return new RL_5adb40c67e70229326f58a0f743d05eb();
}


} // RL_5adb40c67e70229326f58a0f743d05eb
}
