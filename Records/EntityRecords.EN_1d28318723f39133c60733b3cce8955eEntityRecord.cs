using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [ReferenceEntity] ApprovalProcessLevel (EYG7AdthcEmNyvb0i_AriA)
///  <code>EN_1d28318723f39133c60733b3cce8955eEntityRecord</code> that represent
/// s <code>ApprovalProcessLevel</code> <p>Description: Approval Process Level</p>
/// </summary>
// Name: ApprovalProcessLevel
public partial struct EN_1d28318723f39133c60733b3cce8955eEntityRecord : ITypedRecord<EN_1d28318723f39133c60733b3cce8955eEntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("9NBgF2cKUEmD22aS2k06Pg*WInocyMYpUq7Ww2QzSaeJg");
internal static readonly GlobalObjectKey IdApprovalProcessId = GlobalObjectKey.Parse("9NBgF2cKUEmD22aS2k06Pg*XQjxiKMPpUKumk9Qgz2Tyw");
internal static readonly GlobalObjectKey IdLevelNumber = GlobalObjectKey.Parse("9NBgF2cKUEmD22aS2k06Pg*aQyZy1VSA0O6vjIprAKAHg");
internal static readonly GlobalObjectKey IdApplicationRoleId = GlobalObjectKey.Parse("9NBgF2cKUEmD22aS2k06Pg*vUFIgAMhTkyhqaqnusF6KA");
internal static readonly GlobalObjectKey IdIsApplicant = GlobalObjectKey.Parse("9NBgF2cKUEmD22aS2k06Pg*tW6iMo48+EyZMFbm7FkGTg");
internal static readonly GlobalObjectKey IdIsFirstApprover = GlobalObjectKey.Parse("9NBgF2cKUEmD22aS2k06Pg*xrtG7EOn5U+gSjUmyJRW5A");
internal static readonly GlobalObjectKey IdJobTitle = GlobalObjectKey.Parse("9NBgF2cKUEmD22aS2k06Pg*qZ5Cgp1ohEe5Ps3rAicqsQ");
internal static readonly GlobalObjectKey IdEntraRoleId = GlobalObjectKey.Parse("9NBgF2cKUEmD22aS2k06Pg*UhIeZ0niUka_fNageV274g");
internal static readonly GlobalObjectKey IdDepartmentId = GlobalObjectKey.Parse("9NBgF2cKUEmD22aS2k06Pg*j6FSi_ESr0y9aX2zHwAh5A");
internal static readonly GlobalObjectKey IdManagementId = GlobalObjectKey.Parse("9NBgF2cKUEmD22aS2k06Pg*hfesU5UxY0aEp2VGmeDxCw");
internal static readonly GlobalObjectKey IdSubdirectionId = GlobalObjectKey.Parse("9NBgF2cKUEmD22aS2k06Pg*QimLqbkPqUyqnIYc3mCo7Q");
internal static readonly GlobalObjectKey IdMinAmount = GlobalObjectKey.Parse("9NBgF2cKUEmD22aS2k06Pg*ihMHWc_ovUiXMGfNR7HCpg");
internal static readonly GlobalObjectKey IdMaxAmount = GlobalObjectKey.Parse("9NBgF2cKUEmD22aS2k06Pg*WtHfeBp_RU2T2zqObg0PDg");
internal static readonly GlobalObjectKey IdIsActive = GlobalObjectKey.Parse("9NBgF2cKUEmD22aS2k06Pg*UQTMBBalWUOCACp1N5g96w");
internal static readonly GlobalObjectKey IdExcludeRegion_DEPREC = GlobalObjectKey.Parse("9NBgF2cKUEmD22aS2k06Pg*OTKDUg1KHUmYoOrkYEyQdw");
internal static readonly GlobalObjectKey IdOnlyRegion = GlobalObjectKey.Parse("9NBgF2cKUEmD22aS2k06Pg*LoXNE5bVvUmtszkdK0Ud+A");
internal static readonly GlobalObjectKey IdWithoutContract = GlobalObjectKey.Parse("9NBgF2cKUEmD22aS2k06Pg*aWO7J8NFGUCiRHyG1bmHEg");
internal static readonly GlobalObjectKey IdNeedsProofOfForeignResidence = GlobalObjectKey.Parse("9NBgF2cKUEmD22aS2k06Pg*TghihFhiB0CsLZ2a57gO8A");
internal static readonly GlobalObjectKey IdNeedsContract = GlobalObjectKey.Parse("9NBgF2cKUEmD22aS2k06Pg*9dWX5TKRrEyPwaIN0suAKw");
internal static readonly GlobalObjectKey IdIsAccounting_DEPREC = GlobalObjectKey.Parse("9NBgF2cKUEmD22aS2k06Pg*mM401sVvfEmN_SobD+8CUg");
internal static readonly GlobalObjectKey IdIsStartAccounting = GlobalObjectKey.Parse("9NBgF2cKUEmD22aS2k06Pg*xgtUGU8FMkW0Qa53BbX_1w");
internal static readonly GlobalObjectKey IdCanBeFirstApprover = GlobalObjectKey.Parse("9NBgF2cKUEmD22aS2k06Pg*DMAgB0A19E6Z7qRXdbZ3aQ");
internal static readonly GlobalObjectKey IdSelectsNextApprover = GlobalObjectKey.Parse("9NBgF2cKUEmD22aS2k06Pg*_AmbMlbGoE++mKSi7CIPwg");
internal static readonly GlobalObjectKey IdSelectsFirstApprover = GlobalObjectKey.Parse("9NBgF2cKUEmD22aS2k06Pg*_tKreXo+IUmtkdq4htDWgg");
internal static readonly GlobalObjectKey IdIsExclude = GlobalObjectKey.Parse("9NBgF2cKUEmD22aS2k06Pg*V9Ijkkpa_EuJS6XLiizzag");
internal static readonly GlobalObjectKey IdIsMandatory = GlobalObjectKey.Parse("9NBgF2cKUEmD22aS2k06Pg*A_lBDPmeEEKk4fsi_fIMtA");

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

private long _ssApprovalProcessId;
public long ssApprovalProcessId{
  get{
      return _ssApprovalProcessId;
  }
  set{
      if((_ssApprovalProcessId!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssApprovalProcessId = value;
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

private bool _ssIsApplicant;
public bool ssIsApplicant{
  get{
      return _ssIsApplicant;
  }
  set{
      if((_ssIsApplicant!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssIsApplicant = value;
      }
  }
}

private bool _ssIsFirstApprover;
public bool ssIsFirstApprover{
  get{
      return _ssIsFirstApprover;
  }
  set{
      if((_ssIsFirstApprover!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssIsFirstApprover = value;
      }
  }
}

private string _ssJobTitle;
public string ssJobTitle{
  get{
      return _ssJobTitle;
  }
  set{
      if((_ssJobTitle!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
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
      if((_ssEntraRoleId!=value) || OptimizedAttributes[7]){
          ChangedAttributes[7] = true;
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
      if((_ssDepartmentId!=value) || OptimizedAttributes[8]){
          ChangedAttributes[8] = true;
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
      if((_ssManagementId!=value) || OptimizedAttributes[9]){
          ChangedAttributes[9] = true;
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
      if((_ssSubdirectionId!=value) || OptimizedAttributes[10]){
          ChangedAttributes[10] = true;
          _ssSubdirectionId = value;
      }
  }
}

private decimal _ssMinAmount;
public decimal ssMinAmount{
  get{
      return _ssMinAmount;
  }
  set{
      if((_ssMinAmount!=value) || OptimizedAttributes[11]){
          ChangedAttributes[11] = true;
          _ssMinAmount = value;
      }
  }
}

private decimal _ssMaxAmount;
public decimal ssMaxAmount{
  get{
      return _ssMaxAmount;
  }
  set{
      if((_ssMaxAmount!=value) || OptimizedAttributes[12]){
          ChangedAttributes[12] = true;
          _ssMaxAmount = value;
      }
  }
}

private bool _ssIsActive;
public bool ssIsActive{
  get{
      return _ssIsActive;
  }
  set{
      if((_ssIsActive!=value) || OptimizedAttributes[13]){
          ChangedAttributes[13] = true;
          _ssIsActive = value;
      }
  }
}

private string _ssExcludeRegion_DEPREC;
public string ssExcludeRegion_DEPREC{
  get{
      return _ssExcludeRegion_DEPREC;
  }
  set{
      if((_ssExcludeRegion_DEPREC!=value) || OptimizedAttributes[14]){
          ChangedAttributes[14] = true;
          _ssExcludeRegion_DEPREC = value;
      }
  }
}

private string _ssOnlyRegion;
public string ssOnlyRegion{
  get{
      return _ssOnlyRegion;
  }
  set{
      if((_ssOnlyRegion!=value) || OptimizedAttributes[15]){
          ChangedAttributes[15] = true;
          _ssOnlyRegion = value;
      }
  }
}

private bool _ssWithoutContract;
public bool ssWithoutContract{
  get{
      return _ssWithoutContract;
  }
  set{
      if((_ssWithoutContract!=value) || OptimizedAttributes[16]){
          ChangedAttributes[16] = true;
          _ssWithoutContract = value;
      }
  }
}

private bool _ssNeedsProofOfForeignResidence;
public bool ssNeedsProofOfForeignResidence{
  get{
      return _ssNeedsProofOfForeignResidence;
  }
  set{
      if((_ssNeedsProofOfForeignResidence!=value) || OptimizedAttributes[17]){
          ChangedAttributes[17] = true;
          _ssNeedsProofOfForeignResidence = value;
      }
  }
}

private bool _ssNeedsContract;
public bool ssNeedsContract{
  get{
      return _ssNeedsContract;
  }
  set{
      if((_ssNeedsContract!=value) || OptimizedAttributes[18]){
          ChangedAttributes[18] = true;
          _ssNeedsContract = value;
      }
  }
}

private bool _ssIsAccounting_DEPREC;
public bool ssIsAccounting_DEPREC{
  get{
      return _ssIsAccounting_DEPREC;
  }
  set{
      if((_ssIsAccounting_DEPREC!=value) || OptimizedAttributes[19]){
          ChangedAttributes[19] = true;
          _ssIsAccounting_DEPREC = value;
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

private bool _ssCanBeFirstApprover;
public bool ssCanBeFirstApprover{
  get{
      return _ssCanBeFirstApprover;
  }
  set{
      if((_ssCanBeFirstApprover!=value) || OptimizedAttributes[21]){
          ChangedAttributes[21] = true;
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
      if((_ssSelectsNextApprover!=value) || OptimizedAttributes[22]){
          ChangedAttributes[22] = true;
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
      if((_ssSelectsFirstApprover!=value) || OptimizedAttributes[23]){
          ChangedAttributes[23] = true;
          _ssSelectsFirstApprover = value;
      }
  }
}

private bool _ssIsExclude;
public bool ssIsExclude{
  get{
      return _ssIsExclude;
  }
  set{
      if((_ssIsExclude!=value) || OptimizedAttributes[24]){
          ChangedAttributes[24] = true;
          _ssIsExclude = value;
      }
  }
}

private bool _ssIsMandatory;
public bool ssIsMandatory{
  get{
      return _ssIsMandatory;
  }
  set{
      if((_ssIsMandatory!=value) || OptimizedAttributes[25]){
          ChangedAttributes[25] = true;
          _ssIsMandatory = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_1d28318723f39133c60733b3cce8955eEntityRecord() {
ChangedAttributes = new BitArray(26,true);
OptimizedAttributes = new BitArray(26,false);
_ssId = 0L;
_ssApprovalProcessId = 0L;
_ssLevelNumber = 0;
_ssApplicationRoleId = 0L;
_ssIsApplicant = false;
_ssIsFirstApprover = false;
_ssJobTitle = "";
_ssEntraRoleId = 0L;
_ssDepartmentId = 0L;
_ssManagementId = 0L;
_ssSubdirectionId = 0L;
_ssMinAmount = 0.0M;
_ssMaxAmount = 0.0M;
_ssIsActive = false;
_ssExcludeRegion_DEPREC = "";
_ssOnlyRegion = "";
_ssWithoutContract = false;
_ssNeedsProofOfForeignResidence = false;
_ssNeedsContract = false;
_ssIsAccounting_DEPREC = false;
_ssIsStartAccounting = false;
_ssCanBeFirstApprover = false;
_ssSelectsNextApprover = false;
_ssSelectsFirstApprover = false;
_ssIsExclude = false;
_ssIsMandatory = false;
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
ssId = r.ReadLongInteger(index++, "ApprovalProcessLevel.Id", 0L);
ssApprovalProcessId = r.ReadEntityReferenceLongInteger(index++, "ApprovalProcessLevel.ApprovalProcessId", 0L);
ssLevelNumber = r.ReadInteger(index++, "ApprovalProcessLevel.LevelNumber", 0);
ssApplicationRoleId = r.ReadEntityReferenceLongInteger(index++, "ApprovalProcessLevel.ApplicationRoleId", 0L);
ssIsApplicant = r.ReadBoolean(index++, "ApprovalProcessLevel.IsApplicant", false);
ssIsFirstApprover = r.ReadBoolean(index++, "ApprovalProcessLevel.IsFirstApprover", false);
ssJobTitle = r.ReadText(index++, "ApprovalProcessLevel.JobTitle", "");
ssEntraRoleId = r.ReadEntityReferenceLongInteger(index++, "ApprovalProcessLevel.EntraRoleId", 0L);
ssDepartmentId = r.ReadEntityReferenceLongInteger(index++, "ApprovalProcessLevel.DepartmentId", 0L);
ssManagementId = r.ReadEntityReferenceLongInteger(index++, "ApprovalProcessLevel.ManagementId", 0L);
ssSubdirectionId = r.ReadEntityReferenceLongInteger(index++, "ApprovalProcessLevel.SubdirectionId", 0L);
ssMinAmount = r.ReadDecimal(index++, "ApprovalProcessLevel.MinAmount", 0.0M);
ssMaxAmount = r.ReadDecimal(index++, "ApprovalProcessLevel.MaxAmount", 0.0M);
ssIsActive = r.ReadBoolean(index++, "ApprovalProcessLevel.IsActive", false);
ssExcludeRegion_DEPREC = r.ReadText(index++, "ApprovalProcessLevel.ExcludeRegion_DEPREC", "");
ssOnlyRegion = r.ReadText(index++, "ApprovalProcessLevel.OnlyRegion", "");
ssWithoutContract = r.ReadBoolean(index++, "ApprovalProcessLevel.WithoutContract", false);
ssNeedsProofOfForeignResidence = r.ReadBoolean(index++, "ApprovalProcessLevel.NeedsProofOfForeignResidence", false);
ssNeedsContract = r.ReadBoolean(index++, "ApprovalProcessLevel.NeedsContract", false);
ssIsAccounting_DEPREC = r.ReadBoolean(index++, "ApprovalProcessLevel.IsAccounting_DEPREC", false);
ssIsStartAccounting = r.ReadBoolean(index++, "ApprovalProcessLevel.IsStartAccounting", false);
ssCanBeFirstApprover = r.ReadBoolean(index++, "ApprovalProcessLevel.CanBeFirstApprover", false);
ssSelectsNextApprover = r.ReadBoolean(index++, "ApprovalProcessLevel.SelectsNextApprover", false);
ssSelectsFirstApprover = r.ReadBoolean(index++, "ApprovalProcessLevel.SelectsFirstApprover", false);
ssIsExclude = r.ReadBoolean(index++, "ApprovalProcessLevel.IsExclude", false);
ssIsMandatory = r.ReadBoolean(index++, "ApprovalProcessLevel.IsMandatory", false);
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
public void ReadIM(EN_1d28318723f39133c60733b3cce8955eEntityRecord r) {
this = r;
}


public static bool operator == (EN_1d28318723f39133c60733b3cce8955eEntityRecord a, EN_1d28318723f39133c60733b3cce8955eEntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssApprovalProcessId != b.ssApprovalProcessId) return false;
if (a.ssLevelNumber != b.ssLevelNumber) return false;
if (a.ssApplicationRoleId != b.ssApplicationRoleId) return false;
if (a.ssIsApplicant != b.ssIsApplicant) return false;
if (a.ssIsFirstApprover != b.ssIsFirstApprover) return false;
if (a.ssJobTitle != b.ssJobTitle) return false;
if (a.ssEntraRoleId != b.ssEntraRoleId) return false;
if (a.ssDepartmentId != b.ssDepartmentId) return false;
if (a.ssManagementId != b.ssManagementId) return false;
if (a.ssSubdirectionId != b.ssSubdirectionId) return false;
if (a.ssMinAmount != b.ssMinAmount) return false;
if (a.ssMaxAmount != b.ssMaxAmount) return false;
if (a.ssIsActive != b.ssIsActive) return false;
if (a.ssExcludeRegion_DEPREC != b.ssExcludeRegion_DEPREC) return false;
if (a.ssOnlyRegion != b.ssOnlyRegion) return false;
if (a.ssWithoutContract != b.ssWithoutContract) return false;
if (a.ssNeedsProofOfForeignResidence != b.ssNeedsProofOfForeignResidence) return false;
if (a.ssNeedsContract != b.ssNeedsContract) return false;
if (a.ssIsAccounting_DEPREC != b.ssIsAccounting_DEPREC) return false;
if (a.ssIsStartAccounting != b.ssIsStartAccounting) return false;
if (a.ssCanBeFirstApprover != b.ssCanBeFirstApprover) return false;
if (a.ssSelectsNextApprover != b.ssSelectsNextApprover) return false;
if (a.ssSelectsFirstApprover != b.ssSelectsFirstApprover) return false;
if (a.ssIsExclude != b.ssIsExclude) return false;
if (a.ssIsMandatory != b.ssIsMandatory) return false;
return true;
}

public static bool operator != (EN_1d28318723f39133c60733b3cce8955eEntityRecord a, EN_1d28318723f39133c60733b3cce8955eEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_1d28318723f39133c60733b3cce8955eEntityRecord)) return false;
return (this == (EN_1d28318723f39133c60733b3cce8955eEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssApprovalProcessId.GetHashCode()
 ^ ssLevelNumber.GetHashCode()
 ^ ssApplicationRoleId.GetHashCode()
 ^ ssIsApplicant.GetHashCode()
 ^ ssIsFirstApprover.GetHashCode()
 ^ ssJobTitle.GetHashCode()
 ^ ssEntraRoleId.GetHashCode()
 ^ ssDepartmentId.GetHashCode()
 ^ ssManagementId.GetHashCode()
 ^ ssSubdirectionId.GetHashCode()
 ^ ssMinAmount.GetHashCode()
 ^ ssMaxAmount.GetHashCode()
 ^ ssIsActive.GetHashCode()
 ^ ssExcludeRegion_DEPREC.GetHashCode()
 ^ ssOnlyRegion.GetHashCode()
 ^ ssWithoutContract.GetHashCode()
 ^ ssNeedsProofOfForeignResidence.GetHashCode()
 ^ ssNeedsContract.GetHashCode()
 ^ ssIsAccounting_DEPREC.GetHashCode()
 ^ ssIsStartAccounting.GetHashCode()
 ^ ssCanBeFirstApprover.GetHashCode()
 ^ ssSelectsNextApprover.GetHashCode()
 ^ ssSelectsFirstApprover.GetHashCode()
 ^ ssIsExclude.GetHashCode()
 ^ ssIsMandatory.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_1d28318723f39133c60733b3cce8955eEntityRecord Duplicate() {
EN_1d28318723f39133c60733b3cce8955eEntityRecord t;
t._ssId = this._ssId;
t._ssApprovalProcessId = this._ssApprovalProcessId;
t._ssLevelNumber = this._ssLevelNumber;
t._ssApplicationRoleId = this._ssApplicationRoleId;
t._ssIsApplicant = this._ssIsApplicant;
t._ssIsFirstApprover = this._ssIsFirstApprover;
t._ssJobTitle = this._ssJobTitle;
t._ssEntraRoleId = this._ssEntraRoleId;
t._ssDepartmentId = this._ssDepartmentId;
t._ssManagementId = this._ssManagementId;
t._ssSubdirectionId = this._ssSubdirectionId;
t._ssMinAmount = this._ssMinAmount;
t._ssMaxAmount = this._ssMaxAmount;
t._ssIsActive = this._ssIsActive;
t._ssExcludeRegion_DEPREC = this._ssExcludeRegion_DEPREC;
t._ssOnlyRegion = this._ssOnlyRegion;
t._ssWithoutContract = this._ssWithoutContract;
t._ssNeedsProofOfForeignResidence = this._ssNeedsProofOfForeignResidence;
t._ssNeedsContract = this._ssNeedsContract;
t._ssIsAccounting_DEPREC = this._ssIsAccounting_DEPREC;
t._ssIsStartAccounting = this._ssIsStartAccounting;
t._ssCanBeFirstApprover = this._ssCanBeFirstApprover;
t._ssSelectsNextApprover = this._ssSelectsNextApprover;
t._ssSelectsFirstApprover = this._ssSelectsFirstApprover;
t._ssIsExclude = this._ssIsExclude;
t._ssIsMandatory = this._ssIsMandatory;
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
} else if (head == "approvalprocessid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApprovalProcessId")) variable.Value = ssApprovalProcessId; else variable.Optimized = true;
} else if (head == "levelnumber") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".LevelNumber")) variable.Value = ssLevelNumber; else variable.Optimized = true;
} else if (head == "applicationroleid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApplicationRoleId")) variable.Value = ssApplicationRoleId; else variable.Optimized = true;
} else if (head == "isapplicant") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsApplicant")) variable.Value = ssIsApplicant; else variable.Optimized = true;
} else if (head == "isfirstapprover") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsFirstApprover")) variable.Value = ssIsFirstApprover; else variable.Optimized = true;
} else if (head == "jobtitle") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".JobTitle")) variable.Value = ssJobTitle; else variable.Optimized = true;
} else if (head == "entraroleid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EntraRoleId")) variable.Value = ssEntraRoleId; else variable.Optimized = true;
} else if (head == "departmentid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DepartmentId")) variable.Value = ssDepartmentId; else variable.Optimized = true;
} else if (head == "managementid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ManagementId")) variable.Value = ssManagementId; else variable.Optimized = true;
} else if (head == "subdirectionid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SubdirectionId")) variable.Value = ssSubdirectionId; else variable.Optimized = true;
} else if (head == "minamount") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MinAmount")) variable.Value = ssMinAmount; else variable.Optimized = true;
} else if (head == "maxamount") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MaxAmount")) variable.Value = ssMaxAmount; else variable.Optimized = true;
} else if (head == "isactive") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsActive")) variable.Value = ssIsActive; else variable.Optimized = true;
} else if (head == "excluderegion_deprec") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ExcludeRegion_DEPREC")) variable.Value = ssExcludeRegion_DEPREC; else variable.Optimized = true;
} else if (head == "onlyregion") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OnlyRegion")) variable.Value = ssOnlyRegion; else variable.Optimized = true;
} else if (head == "withoutcontract") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".WithoutContract")) variable.Value = ssWithoutContract; else variable.Optimized = true;
} else if (head == "needsproofofforeignresidence") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".NeedsProofOfForeignResidence")) variable.Value = ssNeedsProofOfForeignResidence; else variable.Optimized = true;
} else if (head == "needscontract") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".NeedsContract")) variable.Value = ssNeedsContract; else variable.Optimized = true;
} else if (head == "isaccounting_deprec") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsAccounting_DEPREC")) variable.Value = ssIsAccounting_DEPREC; else variable.Optimized = true;
} else if (head == "isstartaccounting") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsStartAccounting")) variable.Value = ssIsStartAccounting; else variable.Optimized = true;
} else if (head == "canbefirstapprover") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CanBeFirstApprover")) variable.Value = ssCanBeFirstApprover; else variable.Optimized = true;
} else if (head == "selectsnextapprover") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SelectsNextApprover")) variable.Value = ssSelectsNextApprover; else variable.Optimized = true;
} else if (head == "selectsfirstapprover") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SelectsFirstApprover")) variable.Value = ssSelectsFirstApprover; else variable.Optimized = true;
} else if (head == "isexclude") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsExclude")) variable.Value = ssIsExclude; else variable.Optimized = true;
} else if (head == "ismandatory") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsMandatory")) variable.Value = ssIsMandatory; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdApprovalProcessId)) {
return ChangedAttributes[1];
}
if (key.Equals(IdLevelNumber)) {
return ChangedAttributes[2];
}
if (key.Equals(IdApplicationRoleId)) {
return ChangedAttributes[3];
}
if (key.Equals(IdIsApplicant)) {
return ChangedAttributes[4];
}
if (key.Equals(IdIsFirstApprover)) {
return ChangedAttributes[5];
}
if (key.Equals(IdJobTitle)) {
return ChangedAttributes[6];
}
if (key.Equals(IdEntraRoleId)) {
return ChangedAttributes[7];
}
if (key.Equals(IdDepartmentId)) {
return ChangedAttributes[8];
}
if (key.Equals(IdManagementId)) {
return ChangedAttributes[9];
}
if (key.Equals(IdSubdirectionId)) {
return ChangedAttributes[10];
}
if (key.Equals(IdMinAmount)) {
return ChangedAttributes[11];
}
if (key.Equals(IdMaxAmount)) {
return ChangedAttributes[12];
}
if (key.Equals(IdIsActive)) {
return ChangedAttributes[13];
}
if (key.Equals(IdExcludeRegion_DEPREC)) {
return ChangedAttributes[14];
}
if (key.Equals(IdOnlyRegion)) {
return ChangedAttributes[15];
}
if (key.Equals(IdWithoutContract)) {
return ChangedAttributes[16];
}
if (key.Equals(IdNeedsProofOfForeignResidence)) {
return ChangedAttributes[17];
}
if (key.Equals(IdNeedsContract)) {
return ChangedAttributes[18];
}
if (key.Equals(IdIsAccounting_DEPREC)) {
return ChangedAttributes[19];
}
if (key.Equals(IdIsStartAccounting)) {
return ChangedAttributes[20];
}
if (key.Equals(IdCanBeFirstApprover)) {
return ChangedAttributes[21];
}
if (key.Equals(IdSelectsNextApprover)) {
return ChangedAttributes[22];
}
if (key.Equals(IdSelectsFirstApprover)) {
return ChangedAttributes[23];
}
if (key.Equals(IdIsExclude)) {
return ChangedAttributes[24];
}
if (key.Equals(IdIsMandatory)) {
return ChangedAttributes[25];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdApprovalProcessId)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdLevelNumber)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdApplicationRoleId)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdIsApplicant)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdIsFirstApprover)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdJobTitle)) {
return OptimizedAttributes[6];
}
if (key.Equals(IdEntraRoleId)) {
return OptimizedAttributes[7];
}
if (key.Equals(IdDepartmentId)) {
return OptimizedAttributes[8];
}
if (key.Equals(IdManagementId)) {
return OptimizedAttributes[9];
}
if (key.Equals(IdSubdirectionId)) {
return OptimizedAttributes[10];
}
if (key.Equals(IdMinAmount)) {
return OptimizedAttributes[11];
}
if (key.Equals(IdMaxAmount)) {
return OptimizedAttributes[12];
}
if (key.Equals(IdIsActive)) {
return OptimizedAttributes[13];
}
if (key.Equals(IdExcludeRegion_DEPREC)) {
return OptimizedAttributes[14];
}
if (key.Equals(IdOnlyRegion)) {
return OptimizedAttributes[15];
}
if (key.Equals(IdWithoutContract)) {
return OptimizedAttributes[16];
}
if (key.Equals(IdNeedsProofOfForeignResidence)) {
return OptimizedAttributes[17];
}
if (key.Equals(IdNeedsContract)) {
return OptimizedAttributes[18];
}
if (key.Equals(IdIsAccounting_DEPREC)) {
return OptimizedAttributes[19];
}
if (key.Equals(IdIsStartAccounting)) {
return OptimizedAttributes[20];
}
if (key.Equals(IdCanBeFirstApprover)) {
return OptimizedAttributes[21];
}
if (key.Equals(IdSelectsNextApprover)) {
return OptimizedAttributes[22];
}
if (key.Equals(IdSelectsFirstApprover)) {
return OptimizedAttributes[23];
}
if (key.Equals(IdIsExclude)) {
return OptimizedAttributes[24];
}
if (key.Equals(IdIsMandatory)) {
return OptimizedAttributes[25];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdApprovalProcessId) {
return ssApprovalProcessId;
}
if (key == IdLevelNumber) {
return ssLevelNumber;
}
if (key == IdApplicationRoleId) {
return ssApplicationRoleId;
}
if (key == IdIsApplicant) {
return ssIsApplicant;
}
if (key == IdIsFirstApprover) {
return ssIsFirstApprover;
}
if (key == IdJobTitle) {
return ssJobTitle;
}
if (key == IdEntraRoleId) {
return ssEntraRoleId;
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
if (key == IdMinAmount) {
return ssMinAmount;
}
if (key == IdMaxAmount) {
return ssMaxAmount;
}
if (key == IdIsActive) {
return ssIsActive;
}
if (key == IdExcludeRegion_DEPREC) {
return ssExcludeRegion_DEPREC;
}
if (key == IdOnlyRegion) {
return ssOnlyRegion;
}
if (key == IdWithoutContract) {
return ssWithoutContract;
}
if (key == IdNeedsProofOfForeignResidence) {
return ssNeedsProofOfForeignResidence;
}
if (key == IdNeedsContract) {
return ssNeedsContract;
}
if (key == IdIsAccounting_DEPREC) {
return ssIsAccounting_DEPREC;
}
if (key == IdIsStartAccounting) {
return ssIsStartAccounting;
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
if (key == IdIsExclude) {
return ssIsExclude;
}
if (key == IdIsMandatory) {
return ssIsMandatory;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdApprovalProcessId.Key.AsGuid) {
return ssApprovalProcessId;
}
if (attributeKey == IdLevelNumber.Key.AsGuid) {
return ssLevelNumber;
}
if (attributeKey == IdApplicationRoleId.Key.AsGuid) {
return ssApplicationRoleId;
}
if (attributeKey == IdIsApplicant.Key.AsGuid) {
return ssIsApplicant;
}
if (attributeKey == IdIsFirstApprover.Key.AsGuid) {
return ssIsFirstApprover;
}
if (attributeKey == IdJobTitle.Key.AsGuid) {
return ssJobTitle;
}
if (attributeKey == IdEntraRoleId.Key.AsGuid) {
return ssEntraRoleId;
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
if (attributeKey == IdMinAmount.Key.AsGuid) {
return ssMinAmount;
}
if (attributeKey == IdMaxAmount.Key.AsGuid) {
return ssMaxAmount;
}
if (attributeKey == IdIsActive.Key.AsGuid) {
return ssIsActive;
}
if (attributeKey == IdExcludeRegion_DEPREC.Key.AsGuid) {
return ssExcludeRegion_DEPREC;
}
if (attributeKey == IdOnlyRegion.Key.AsGuid) {
return ssOnlyRegion;
}
if (attributeKey == IdWithoutContract.Key.AsGuid) {
return ssWithoutContract;
}
if (attributeKey == IdNeedsProofOfForeignResidence.Key.AsGuid) {
return ssNeedsProofOfForeignResidence;
}
if (attributeKey == IdNeedsContract.Key.AsGuid) {
return ssNeedsContract;
}
if (attributeKey == IdIsAccounting_DEPREC.Key.AsGuid) {
return ssIsAccounting_DEPREC;
}
if (attributeKey == IdIsStartAccounting.Key.AsGuid) {
return ssIsStartAccounting;
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
if (attributeKey == IdIsExclude.Key.AsGuid) {
return ssIsExclude;
}
if (attributeKey == IdIsMandatory.Key.AsGuid) {
return ssIsMandatory;
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
ssApprovalProcessId = (long) other.AttributeGet(IdApprovalProcessId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdApprovalProcessId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdApprovalProcessId);
ssLevelNumber = (int) other.AttributeGet(IdLevelNumber);
ChangedAttributes[2] = other.ChangedAttributeGet(IdLevelNumber);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdLevelNumber);
ssApplicationRoleId = (long) other.AttributeGet(IdApplicationRoleId);
ChangedAttributes[3] = other.ChangedAttributeGet(IdApplicationRoleId);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdApplicationRoleId);
ssIsApplicant = (bool) other.AttributeGet(IdIsApplicant);
ChangedAttributes[4] = other.ChangedAttributeGet(IdIsApplicant);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdIsApplicant);
ssIsFirstApprover = (bool) other.AttributeGet(IdIsFirstApprover);
ChangedAttributes[5] = other.ChangedAttributeGet(IdIsFirstApprover);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdIsFirstApprover);
ssJobTitle = (string) other.AttributeGet(IdJobTitle);
ChangedAttributes[6] = other.ChangedAttributeGet(IdJobTitle);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdJobTitle);
ssEntraRoleId = (long) other.AttributeGet(IdEntraRoleId);
ChangedAttributes[7] = other.ChangedAttributeGet(IdEntraRoleId);
OptimizedAttributes[7] = other.OptimizedAttributeGet(IdEntraRoleId);
ssDepartmentId = (long) other.AttributeGet(IdDepartmentId);
ChangedAttributes[8] = other.ChangedAttributeGet(IdDepartmentId);
OptimizedAttributes[8] = other.OptimizedAttributeGet(IdDepartmentId);
ssManagementId = (long) other.AttributeGet(IdManagementId);
ChangedAttributes[9] = other.ChangedAttributeGet(IdManagementId);
OptimizedAttributes[9] = other.OptimizedAttributeGet(IdManagementId);
ssSubdirectionId = (long) other.AttributeGet(IdSubdirectionId);
ChangedAttributes[10] = other.ChangedAttributeGet(IdSubdirectionId);
OptimizedAttributes[10] = other.OptimizedAttributeGet(IdSubdirectionId);
ssMinAmount = (decimal) other.AttributeGet(IdMinAmount);
ChangedAttributes[11] = other.ChangedAttributeGet(IdMinAmount);
OptimizedAttributes[11] = other.OptimizedAttributeGet(IdMinAmount);
ssMaxAmount = (decimal) other.AttributeGet(IdMaxAmount);
ChangedAttributes[12] = other.ChangedAttributeGet(IdMaxAmount);
OptimizedAttributes[12] = other.OptimizedAttributeGet(IdMaxAmount);
ssIsActive = (bool) other.AttributeGet(IdIsActive);
ChangedAttributes[13] = other.ChangedAttributeGet(IdIsActive);
OptimizedAttributes[13] = other.OptimizedAttributeGet(IdIsActive);
ssExcludeRegion_DEPREC = (string) other.AttributeGet(IdExcludeRegion_DEPREC);
ChangedAttributes[14] = other.ChangedAttributeGet(IdExcludeRegion_DEPREC);
OptimizedAttributes[14] = other.OptimizedAttributeGet(IdExcludeRegion_DEPREC);
ssOnlyRegion = (string) other.AttributeGet(IdOnlyRegion);
ChangedAttributes[15] = other.ChangedAttributeGet(IdOnlyRegion);
OptimizedAttributes[15] = other.OptimizedAttributeGet(IdOnlyRegion);
ssWithoutContract = (bool) other.AttributeGet(IdWithoutContract);
ChangedAttributes[16] = other.ChangedAttributeGet(IdWithoutContract);
OptimizedAttributes[16] = other.OptimizedAttributeGet(IdWithoutContract);
ssNeedsProofOfForeignResidence = (bool) other.AttributeGet(IdNeedsProofOfForeignResidence);
ChangedAttributes[17] = other.ChangedAttributeGet(IdNeedsProofOfForeignResidence);
OptimizedAttributes[17] = other.OptimizedAttributeGet(IdNeedsProofOfForeignResidence);
ssNeedsContract = (bool) other.AttributeGet(IdNeedsContract);
ChangedAttributes[18] = other.ChangedAttributeGet(IdNeedsContract);
OptimizedAttributes[18] = other.OptimizedAttributeGet(IdNeedsContract);
ssIsAccounting_DEPREC = (bool) other.AttributeGet(IdIsAccounting_DEPREC);
ChangedAttributes[19] = other.ChangedAttributeGet(IdIsAccounting_DEPREC);
OptimizedAttributes[19] = other.OptimizedAttributeGet(IdIsAccounting_DEPREC);
ssIsStartAccounting = (bool) other.AttributeGet(IdIsStartAccounting);
ChangedAttributes[20] = other.ChangedAttributeGet(IdIsStartAccounting);
OptimizedAttributes[20] = other.OptimizedAttributeGet(IdIsStartAccounting);
ssCanBeFirstApprover = (bool) other.AttributeGet(IdCanBeFirstApprover);
ChangedAttributes[21] = other.ChangedAttributeGet(IdCanBeFirstApprover);
OptimizedAttributes[21] = other.OptimizedAttributeGet(IdCanBeFirstApprover);
ssSelectsNextApprover = (bool) other.AttributeGet(IdSelectsNextApprover);
ChangedAttributes[22] = other.ChangedAttributeGet(IdSelectsNextApprover);
OptimizedAttributes[22] = other.OptimizedAttributeGet(IdSelectsNextApprover);
ssSelectsFirstApprover = (bool) other.AttributeGet(IdSelectsFirstApprover);
ChangedAttributes[23] = other.ChangedAttributeGet(IdSelectsFirstApprover);
OptimizedAttributes[23] = other.OptimizedAttributeGet(IdSelectsFirstApprover);
ssIsExclude = (bool) other.AttributeGet(IdIsExclude);
ChangedAttributes[24] = other.ChangedAttributeGet(IdIsExclude);
OptimizedAttributes[24] = other.OptimizedAttributeGet(IdIsExclude);
ssIsMandatory = (bool) other.AttributeGet(IdIsMandatory);
ChangedAttributes[25] = other.ChangedAttributeGet(IdIsMandatory);
OptimizedAttributes[25] = other.OptimizedAttributeGet(IdIsMandatory);
}
} // EN_1d28318723f39133c60733b3cce8955eEntityRecord

/// <summary>
/// RecordList type <code>ApprovalProcessLevelList</code> that represents a record list of
///  <code>ApprovalProcessLevel</code>
/// </summary>
public partial class RL_be2041fc5a275dcf5504e8e79ebd2184 : GenericRecordList<EN_1d28318723f39133c60733b3cce8955eEntityRecord>, IEnumerable, IEnumerator {

protected override EN_1d28318723f39133c60733b3cce8955eEntityRecord GetElementDefaultValue() {
return new EN_1d28318723f39133c60733b3cce8955eEntityRecord();
}

public T[] ToArray<T>(Func<EN_1d28318723f39133c60733b3cce8955eEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_be2041fc5a275dcf5504e8e79ebd2184 recordList, Func<EN_1d28318723f39133c60733b3cce8955eEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_be2041fc5a275dcf5504e8e79ebd2184(EN_1d28318723f39133c60733b3cce8955eEntityRecord[] array) {
  RL_be2041fc5a275dcf5504e8e79ebd2184 result = new RL_be2041fc5a275dcf5504e8e79ebd2184();
result.InnerFromArray(array);
    return result;
}

public static RL_be2041fc5a275dcf5504e8e79ebd2184 ToList<T>(T[] array, Func <T, EN_1d28318723f39133c60733b3cce8955eEntityRecord> converter) {
  RL_be2041fc5a275dcf5504e8e79ebd2184 result = new RL_be2041fc5a275dcf5504e8e79ebd2184();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_be2041fc5a275dcf5504e8e79ebd2184 FromRestList<T>(RestList<T> restList, Func <T, EN_1d28318723f39133c60733b3cce8955eEntityRecord> converter) {
  RL_be2041fc5a275dcf5504e8e79ebd2184 result = new RL_be2041fc5a275dcf5504e8e79ebd2184();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_be2041fc5a275dcf5504e8e79ebd2184() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_1d28318723f39133c60733b3cce8955eEntityRecord> NewList() {
return new RL_be2041fc5a275dcf5504e8e79ebd2184();
}


} // RL_be2041fc5a275dcf5504e8e79ebd2184
}
