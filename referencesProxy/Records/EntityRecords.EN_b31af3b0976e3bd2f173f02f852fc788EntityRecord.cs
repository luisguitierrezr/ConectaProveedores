using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {

/// <summary>
/// [ReferenceEntity] ApprovalProcess (BQ7hhZBj5USMc8Mkyhm2Zg)
///  <code>EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord</code> that represent
/// s <code>ApprovalProcess</code> <p>Description: Approval Process</p>
/// </summary>
// Name: ApprovalProcess
public partial struct EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord : ITypedRecord<EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("9NBgF2cKUEmD22aS2k06Pg*UL_G_ahFm0icgEDvEWsXRQ");
internal static readonly GlobalObjectKey IdProcessTypeId = GlobalObjectKey.Parse("9NBgF2cKUEmD22aS2k06Pg*ME0CxAbkKU6ANLqoTJ29Fw");
internal static readonly GlobalObjectKey IdSpecialWorkflowId = GlobalObjectKey.Parse("9NBgF2cKUEmD22aS2k06Pg*yEVnu5nkCk663Ne8vxWdCA");
internal static readonly GlobalObjectKey IdApprovalProcessTypeId = GlobalObjectKey.Parse("9NBgF2cKUEmD22aS2k06Pg*1v_02Y6qnE6C9Z1nff2xSQ");
internal static readonly GlobalObjectKey IdRegionId = GlobalObjectKey.Parse("9NBgF2cKUEmD22aS2k06Pg*FrtJotfOD0e03R_yi_uD0g");
internal static readonly GlobalObjectKey IdAccountingRegionId = GlobalObjectKey.Parse("9NBgF2cKUEmD22aS2k06Pg*X_iwQ8Utc0Cyx1xcm7qesQ");
internal static readonly GlobalObjectKey IdGroup = GlobalObjectKey.Parse("9NBgF2cKUEmD22aS2k06Pg*fiiOzQ0U1kOkvPPAblj7WA");
internal static readonly GlobalObjectKey IdCode = GlobalObjectKey.Parse("9NBgF2cKUEmD22aS2k06Pg*R+m_8hT2dUKyJDUmZFU7Dg");
internal static readonly GlobalObjectKey IdVersion = GlobalObjectKey.Parse("9NBgF2cKUEmD22aS2k06Pg*zVLkGjggGE6SLqfwyc65wQ");
internal static readonly GlobalObjectKey IdDescription = GlobalObjectKey.Parse("9NBgF2cKUEmD22aS2k06Pg*9XIhBwPXzkGJRRRye8c3Jw");
internal static readonly GlobalObjectKey IdIsActive = GlobalObjectKey.Parse("9NBgF2cKUEmD22aS2k06Pg*BfbDaLd7bU6iscz68mUePA");
internal static readonly GlobalObjectKey IdIsSpecial = GlobalObjectKey.Parse("9NBgF2cKUEmD22aS2k06Pg*e70Tn5xaQkOPAxOYMQC9zQ");
internal static readonly GlobalObjectKey IdIsDonation = GlobalObjectKey.Parse("9NBgF2cKUEmD22aS2k06Pg*UywJzNkm0U2gIJPDu7JPNw");
internal static readonly GlobalObjectKey IdIsCxPCorporativo_DEPREC = GlobalObjectKey.Parse("9NBgF2cKUEmD22aS2k06Pg*PqqjLE6Nt0WIvq9gR2lvhA");
internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("9NBgF2cKUEmD22aS2k06Pg*oTwIza3k_UCYm70xFPWLDQ");
internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("9NBgF2cKUEmD22aS2k06Pg*GdhmOkWem0WewIz7vaUYtg");
internal static readonly GlobalObjectKey IdUpdatedBy = GlobalObjectKey.Parse("9NBgF2cKUEmD22aS2k06Pg*MwgbTUANeUu+aDqIg+3E7Q");
internal static readonly GlobalObjectKey IdUpdatedOn = GlobalObjectKey.Parse("9NBgF2cKUEmD22aS2k06Pg*WqEChMKjaEqy+k2GUyYxLg");
internal static readonly GlobalObjectKey IdIsSelectFirstApprover = GlobalObjectKey.Parse("9NBgF2cKUEmD22aS2k06Pg*whFCzppjK0uSqRKUDetjxQ");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(19,true);
          _ssId = value;
      }
  }
}

private long _ssProcessTypeId;
public long ssProcessTypeId{
  get{
      return _ssProcessTypeId;
  }
  set{
      if((_ssProcessTypeId!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssProcessTypeId = value;
      }
  }
}

private long _ssSpecialWorkflowId;
public long ssSpecialWorkflowId{
  get{
      return _ssSpecialWorkflowId;
  }
  set{
      if((_ssSpecialWorkflowId!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssSpecialWorkflowId = value;
      }
  }
}

private int _ssApprovalProcessTypeId;
public int ssApprovalProcessTypeId{
  get{
      return _ssApprovalProcessTypeId;
  }
  set{
      if((_ssApprovalProcessTypeId!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssApprovalProcessTypeId = value;
      }
  }
}

private long _ssRegionId;
public long ssRegionId{
  get{
      return _ssRegionId;
  }
  set{
      if((_ssRegionId!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssRegionId = value;
      }
  }
}

private long _ssAccountingRegionId;
public long ssAccountingRegionId{
  get{
      return _ssAccountingRegionId;
  }
  set{
      if((_ssAccountingRegionId!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssAccountingRegionId = value;
      }
  }
}

private string _ssGroup;
public string ssGroup{
  get{
      return _ssGroup;
  }
  set{
      if((_ssGroup!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssGroup = value;
      }
  }
}

private string _ssCode;
public string ssCode{
  get{
      return _ssCode;
  }
  set{
      if((_ssCode!=value) || OptimizedAttributes[7]){
          ChangedAttributes[7] = true;
          _ssCode = value;
      }
  }
}

private int _ssVersion;
public int ssVersion{
  get{
      return _ssVersion;
  }
  set{
      if((_ssVersion!=value) || OptimizedAttributes[8]){
          ChangedAttributes[8] = true;
          _ssVersion = value;
      }
  }
}

private string _ssDescription;
public string ssDescription{
  get{
      return _ssDescription;
  }
  set{
      if((_ssDescription!=value) || OptimizedAttributes[9]){
          ChangedAttributes[9] = true;
          _ssDescription = value;
      }
  }
}

private bool _ssIsActive;
public bool ssIsActive{
  get{
      return _ssIsActive;
  }
  set{
      if((_ssIsActive!=value) || OptimizedAttributes[10]){
          ChangedAttributes[10] = true;
          _ssIsActive = value;
      }
  }
}

private bool _ssIsSpecial;
public bool ssIsSpecial{
  get{
      return _ssIsSpecial;
  }
  set{
      if((_ssIsSpecial!=value) || OptimizedAttributes[11]){
          ChangedAttributes[11] = true;
          _ssIsSpecial = value;
      }
  }
}

private bool _ssIsDonation;
public bool ssIsDonation{
  get{
      return _ssIsDonation;
  }
  set{
      if((_ssIsDonation!=value) || OptimizedAttributes[12]){
          ChangedAttributes[12] = true;
          _ssIsDonation = value;
      }
  }
}

private bool _ssIsCxPCorporativo_DEPREC;
public bool ssIsCxPCorporativo_DEPREC{
  get{
      return _ssIsCxPCorporativo_DEPREC;
  }
  set{
      if((_ssIsCxPCorporativo_DEPREC!=value) || OptimizedAttributes[13]){
          ChangedAttributes[13] = true;
          _ssIsCxPCorporativo_DEPREC = value;
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

private bool _ssIsSelectFirstApprover;
public bool ssIsSelectFirstApprover{
  get{
      return _ssIsSelectFirstApprover;
  }
  set{
      if((_ssIsSelectFirstApprover!=value) || OptimizedAttributes[18]){
          ChangedAttributes[18] = true;
          _ssIsSelectFirstApprover = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord() {
ChangedAttributes = new BitArray(19,true);
OptimizedAttributes = new BitArray(19,false);
_ssId = 0L;
_ssProcessTypeId = 0L;
_ssSpecialWorkflowId = 0L;
_ssApprovalProcessTypeId = 0;
_ssRegionId = 0L;
_ssAccountingRegionId = 0L;
_ssGroup = "";
_ssCode = "";
_ssVersion = 0;
_ssDescription = "";
_ssIsActive = false;
_ssIsSpecial = false;
_ssIsDonation = false;
_ssIsCxPCorporativo_DEPREC = false;
_ssCreatedBy = "";
_ssCreatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssUpdatedBy = "";
_ssUpdatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssIsSelectFirstApprover = false;
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
ssId = r.ReadLongInteger(index++, "ApprovalProcess.Id", 0L);
ssProcessTypeId = r.ReadEntityReferenceLongInteger(index++, "ApprovalProcess.ProcessTypeId", 0L);
ssSpecialWorkflowId = r.ReadEntityReferenceLongInteger(index++, "ApprovalProcess.SpecialWorkflowId", 0L);
ssApprovalProcessTypeId = r.ReadEntityReference(index++, "ApprovalProcess.ApprovalProcessTypeId", 0);
ssRegionId = r.ReadEntityReferenceLongInteger(index++, "ApprovalProcess.RegionId", 0L);
ssAccountingRegionId = r.ReadEntityReferenceLongInteger(index++, "ApprovalProcess.AccountingRegionId", 0L);
ssGroup = r.ReadText(index++, "ApprovalProcess.Group", "");
ssCode = r.ReadText(index++, "ApprovalProcess.Code", "");
ssVersion = r.ReadInteger(index++, "ApprovalProcess.Version", 0);
ssDescription = r.ReadText(index++, "ApprovalProcess.Description", "");
ssIsActive = r.ReadBoolean(index++, "ApprovalProcess.IsActive", false);
ssIsSpecial = r.ReadBoolean(index++, "ApprovalProcess.IsSpecial", false);
ssIsDonation = r.ReadBoolean(index++, "ApprovalProcess.IsDonation", false);
ssIsCxPCorporativo_DEPREC = r.ReadBoolean(index++, "ApprovalProcess.IsCxPCorporativo_DEPREC", false);
ssCreatedBy = r.ReadEntityReferenceText(index++, "ApprovalProcess.CreatedBy", "");
ssCreatedOn = r.ReadDateTime(index++, "ApprovalProcess.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssUpdatedBy = r.ReadEntityReferenceText(index++, "ApprovalProcess.UpdatedBy", "");
ssUpdatedOn = r.ReadDateTime(index++, "ApprovalProcess.UpdatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssIsSelectFirstApprover = r.ReadBoolean(index++, "ApprovalProcess.IsSelectFirstApprover", false);
ChangedAttributes = new BitArray(19,false);
OptimizedAttributes = new BitArray(19,false);
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
public void ReadIM(EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord r) {
this = r;
}


public static bool operator == (EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord a, EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssProcessTypeId != b.ssProcessTypeId) return false;
if (a.ssSpecialWorkflowId != b.ssSpecialWorkflowId) return false;
if (a.ssApprovalProcessTypeId != b.ssApprovalProcessTypeId) return false;
if (a.ssRegionId != b.ssRegionId) return false;
if (a.ssAccountingRegionId != b.ssAccountingRegionId) return false;
if (a.ssGroup != b.ssGroup) return false;
if (a.ssCode != b.ssCode) return false;
if (a.ssVersion != b.ssVersion) return false;
if (a.ssDescription != b.ssDescription) return false;
if (a.ssIsActive != b.ssIsActive) return false;
if (a.ssIsSpecial != b.ssIsSpecial) return false;
if (a.ssIsDonation != b.ssIsDonation) return false;
if (a.ssIsCxPCorporativo_DEPREC != b.ssIsCxPCorporativo_DEPREC) return false;
if (a.ssCreatedBy != b.ssCreatedBy) return false;
if (a.ssCreatedOn != b.ssCreatedOn) return false;
if (a.ssUpdatedBy != b.ssUpdatedBy) return false;
if (a.ssUpdatedOn != b.ssUpdatedOn) return false;
if (a.ssIsSelectFirstApprover != b.ssIsSelectFirstApprover) return false;
return true;
}

public static bool operator != (EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord a, EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord)) return false;
return (this == (EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssProcessTypeId.GetHashCode()
 ^ ssSpecialWorkflowId.GetHashCode()
 ^ ssApprovalProcessTypeId.GetHashCode()
 ^ ssRegionId.GetHashCode()
 ^ ssAccountingRegionId.GetHashCode()
 ^ ssGroup.GetHashCode()
 ^ ssCode.GetHashCode()
 ^ ssVersion.GetHashCode()
 ^ ssDescription.GetHashCode()
 ^ ssIsActive.GetHashCode()
 ^ ssIsSpecial.GetHashCode()
 ^ ssIsDonation.GetHashCode()
 ^ ssIsCxPCorporativo_DEPREC.GetHashCode()
 ^ ssCreatedBy.GetHashCode()
 ^ ssCreatedOn.GetHashCode()
 ^ ssUpdatedBy.GetHashCode()
 ^ ssUpdatedOn.GetHashCode()
 ^ ssIsSelectFirstApprover.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord Duplicate() {
EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord t;
t._ssId = this._ssId;
t._ssProcessTypeId = this._ssProcessTypeId;
t._ssSpecialWorkflowId = this._ssSpecialWorkflowId;
t._ssApprovalProcessTypeId = this._ssApprovalProcessTypeId;
t._ssRegionId = this._ssRegionId;
t._ssAccountingRegionId = this._ssAccountingRegionId;
t._ssGroup = this._ssGroup;
t._ssCode = this._ssCode;
t._ssVersion = this._ssVersion;
t._ssDescription = this._ssDescription;
t._ssIsActive = this._ssIsActive;
t._ssIsSpecial = this._ssIsSpecial;
t._ssIsDonation = this._ssIsDonation;
t._ssIsCxPCorporativo_DEPREC = this._ssIsCxPCorporativo_DEPREC;
t._ssCreatedBy = this._ssCreatedBy;
t._ssCreatedOn = this._ssCreatedOn;
t._ssUpdatedBy = this._ssUpdatedBy;
t._ssUpdatedOn = this._ssUpdatedOn;
t._ssIsSelectFirstApprover = this._ssIsSelectFirstApprover;
t.ChangedAttributes = new BitArray(19);
t.OptimizedAttributes = new BitArray(19);
for(int i = 0; i < 19; i++){
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
} else if (head == "processtypeid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProcessTypeId")) variable.Value = ssProcessTypeId; else variable.Optimized = true;
} else if (head == "specialworkflowid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SpecialWorkflowId")) variable.Value = ssSpecialWorkflowId; else variable.Optimized = true;
} else if (head == "approvalprocesstypeid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApprovalProcessTypeId")) variable.Value = ssApprovalProcessTypeId; else variable.Optimized = true;
} else if (head == "regionid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RegionId")) variable.Value = ssRegionId; else variable.Optimized = true;
} else if (head == "accountingregionid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AccountingRegionId")) variable.Value = ssAccountingRegionId; else variable.Optimized = true;
} else if (head == "group") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Group")) variable.Value = ssGroup; else variable.Optimized = true;
} else if (head == "code") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Code")) variable.Value = ssCode; else variable.Optimized = true;
} else if (head == "version") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Version")) variable.Value = ssVersion; else variable.Optimized = true;
} else if (head == "description") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Description")) variable.Value = ssDescription; else variable.Optimized = true;
} else if (head == "isactive") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsActive")) variable.Value = ssIsActive; else variable.Optimized = true;
} else if (head == "isspecial") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsSpecial")) variable.Value = ssIsSpecial; else variable.Optimized = true;
} else if (head == "isdonation") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsDonation")) variable.Value = ssIsDonation; else variable.Optimized = true;
} else if (head == "iscxpcorporativo_deprec") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsCxPCorporativo_DEPREC")) variable.Value = ssIsCxPCorporativo_DEPREC; else variable.Optimized = true;
} else if (head == "createdby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedBy")) variable.Value = ssCreatedBy; else variable.Optimized = true;
} else if (head == "createdon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedOn")) variable.Value = ssCreatedOn; else variable.Optimized = true;
} else if (head == "updatedby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdatedBy")) variable.Value = ssUpdatedBy; else variable.Optimized = true;
} else if (head == "updatedon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdatedOn")) variable.Value = ssUpdatedOn; else variable.Optimized = true;
} else if (head == "isselectfirstapprover") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsSelectFirstApprover")) variable.Value = ssIsSelectFirstApprover; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdProcessTypeId)) {
return ChangedAttributes[1];
}
if (key.Equals(IdSpecialWorkflowId)) {
return ChangedAttributes[2];
}
if (key.Equals(IdApprovalProcessTypeId)) {
return ChangedAttributes[3];
}
if (key.Equals(IdRegionId)) {
return ChangedAttributes[4];
}
if (key.Equals(IdAccountingRegionId)) {
return ChangedAttributes[5];
}
if (key.Equals(IdGroup)) {
return ChangedAttributes[6];
}
if (key.Equals(IdCode)) {
return ChangedAttributes[7];
}
if (key.Equals(IdVersion)) {
return ChangedAttributes[8];
}
if (key.Equals(IdDescription)) {
return ChangedAttributes[9];
}
if (key.Equals(IdIsActive)) {
return ChangedAttributes[10];
}
if (key.Equals(IdIsSpecial)) {
return ChangedAttributes[11];
}
if (key.Equals(IdIsDonation)) {
return ChangedAttributes[12];
}
if (key.Equals(IdIsCxPCorporativo_DEPREC)) {
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
if (key.Equals(IdIsSelectFirstApprover)) {
return ChangedAttributes[18];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdProcessTypeId)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdSpecialWorkflowId)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdApprovalProcessTypeId)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdRegionId)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdAccountingRegionId)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdGroup)) {
return OptimizedAttributes[6];
}
if (key.Equals(IdCode)) {
return OptimizedAttributes[7];
}
if (key.Equals(IdVersion)) {
return OptimizedAttributes[8];
}
if (key.Equals(IdDescription)) {
return OptimizedAttributes[9];
}
if (key.Equals(IdIsActive)) {
return OptimizedAttributes[10];
}
if (key.Equals(IdIsSpecial)) {
return OptimizedAttributes[11];
}
if (key.Equals(IdIsDonation)) {
return OptimizedAttributes[12];
}
if (key.Equals(IdIsCxPCorporativo_DEPREC)) {
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
if (key.Equals(IdIsSelectFirstApprover)) {
return OptimizedAttributes[18];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdProcessTypeId) {
return ssProcessTypeId;
}
if (key == IdSpecialWorkflowId) {
return ssSpecialWorkflowId;
}
if (key == IdApprovalProcessTypeId) {
return ssApprovalProcessTypeId;
}
if (key == IdRegionId) {
return ssRegionId;
}
if (key == IdAccountingRegionId) {
return ssAccountingRegionId;
}
if (key == IdGroup) {
return ssGroup;
}
if (key == IdCode) {
return ssCode;
}
if (key == IdVersion) {
return ssVersion;
}
if (key == IdDescription) {
return ssDescription;
}
if (key == IdIsActive) {
return ssIsActive;
}
if (key == IdIsSpecial) {
return ssIsSpecial;
}
if (key == IdIsDonation) {
return ssIsDonation;
}
if (key == IdIsCxPCorporativo_DEPREC) {
return ssIsCxPCorporativo_DEPREC;
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
if (key == IdIsSelectFirstApprover) {
return ssIsSelectFirstApprover;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdProcessTypeId.Key.AsGuid) {
return ssProcessTypeId;
}
if (attributeKey == IdSpecialWorkflowId.Key.AsGuid) {
return ssSpecialWorkflowId;
}
if (attributeKey == IdApprovalProcessTypeId.Key.AsGuid) {
return ssApprovalProcessTypeId;
}
if (attributeKey == IdRegionId.Key.AsGuid) {
return ssRegionId;
}
if (attributeKey == IdAccountingRegionId.Key.AsGuid) {
return ssAccountingRegionId;
}
if (attributeKey == IdGroup.Key.AsGuid) {
return ssGroup;
}
if (attributeKey == IdCode.Key.AsGuid) {
return ssCode;
}
if (attributeKey == IdVersion.Key.AsGuid) {
return ssVersion;
}
if (attributeKey == IdDescription.Key.AsGuid) {
return ssDescription;
}
if (attributeKey == IdIsActive.Key.AsGuid) {
return ssIsActive;
}
if (attributeKey == IdIsSpecial.Key.AsGuid) {
return ssIsSpecial;
}
if (attributeKey == IdIsDonation.Key.AsGuid) {
return ssIsDonation;
}
if (attributeKey == IdIsCxPCorporativo_DEPREC.Key.AsGuid) {
return ssIsCxPCorporativo_DEPREC;
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
if (attributeKey == IdIsSelectFirstApprover.Key.AsGuid) {
return ssIsSelectFirstApprover;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(19);
OptimizedAttributes = new BitArray(19);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssProcessTypeId = (long) other.AttributeGet(IdProcessTypeId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdProcessTypeId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdProcessTypeId);
ssSpecialWorkflowId = (long) other.AttributeGet(IdSpecialWorkflowId);
ChangedAttributes[2] = other.ChangedAttributeGet(IdSpecialWorkflowId);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdSpecialWorkflowId);
ssApprovalProcessTypeId = (int) other.AttributeGet(IdApprovalProcessTypeId);
ChangedAttributes[3] = other.ChangedAttributeGet(IdApprovalProcessTypeId);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdApprovalProcessTypeId);
ssRegionId = (long) other.AttributeGet(IdRegionId);
ChangedAttributes[4] = other.ChangedAttributeGet(IdRegionId);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdRegionId);
ssAccountingRegionId = (long) other.AttributeGet(IdAccountingRegionId);
ChangedAttributes[5] = other.ChangedAttributeGet(IdAccountingRegionId);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdAccountingRegionId);
ssGroup = (string) other.AttributeGet(IdGroup);
ChangedAttributes[6] = other.ChangedAttributeGet(IdGroup);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdGroup);
ssCode = (string) other.AttributeGet(IdCode);
ChangedAttributes[7] = other.ChangedAttributeGet(IdCode);
OptimizedAttributes[7] = other.OptimizedAttributeGet(IdCode);
ssVersion = (int) other.AttributeGet(IdVersion);
ChangedAttributes[8] = other.ChangedAttributeGet(IdVersion);
OptimizedAttributes[8] = other.OptimizedAttributeGet(IdVersion);
ssDescription = (string) other.AttributeGet(IdDescription);
ChangedAttributes[9] = other.ChangedAttributeGet(IdDescription);
OptimizedAttributes[9] = other.OptimizedAttributeGet(IdDescription);
ssIsActive = (bool) other.AttributeGet(IdIsActive);
ChangedAttributes[10] = other.ChangedAttributeGet(IdIsActive);
OptimizedAttributes[10] = other.OptimizedAttributeGet(IdIsActive);
ssIsSpecial = (bool) other.AttributeGet(IdIsSpecial);
ChangedAttributes[11] = other.ChangedAttributeGet(IdIsSpecial);
OptimizedAttributes[11] = other.OptimizedAttributeGet(IdIsSpecial);
ssIsDonation = (bool) other.AttributeGet(IdIsDonation);
ChangedAttributes[12] = other.ChangedAttributeGet(IdIsDonation);
OptimizedAttributes[12] = other.OptimizedAttributeGet(IdIsDonation);
ssIsCxPCorporativo_DEPREC = (bool) other.AttributeGet(IdIsCxPCorporativo_DEPREC);
ChangedAttributes[13] = other.ChangedAttributeGet(IdIsCxPCorporativo_DEPREC);
OptimizedAttributes[13] = other.OptimizedAttributeGet(IdIsCxPCorporativo_DEPREC);
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
ssIsSelectFirstApprover = (bool) other.AttributeGet(IdIsSelectFirstApprover);
ChangedAttributes[18] = other.ChangedAttributeGet(IdIsSelectFirstApprover);
OptimizedAttributes[18] = other.OptimizedAttributeGet(IdIsSelectFirstApprover);
}
} // EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord

/// <summary>
/// RecordList type <code>ApprovalProcessList</code> that represents a record list of
///  <code>ApprovalProcess</code>
/// </summary>
public partial class RL_ce09c545b541edeabab89435c34c64f0 : GenericRecordList<EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord>, IEnumerable, IEnumerator {

protected override EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord GetElementDefaultValue() {
return new EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord();
}

public T[] ToArray<T>(Func<EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_ce09c545b541edeabab89435c34c64f0 recordList, Func<EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_ce09c545b541edeabab89435c34c64f0(EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord[] array) {
  RL_ce09c545b541edeabab89435c34c64f0 result = new RL_ce09c545b541edeabab89435c34c64f0();
result.InnerFromArray(array);
    return result;
}

public static RL_ce09c545b541edeabab89435c34c64f0 ToList<T>(T[] array, Func <T, EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord> converter) {
  RL_ce09c545b541edeabab89435c34c64f0 result = new RL_ce09c545b541edeabab89435c34c64f0();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_ce09c545b541edeabab89435c34c64f0 FromRestList<T>(RestList<T> restList, Func <T, EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord> converter) {
  RL_ce09c545b541edeabab89435c34c64f0 result = new RL_ce09c545b541edeabab89435c34c64f0();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_ce09c545b541edeabab89435c34c64f0() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord> NewList() {
return new RL_ce09c545b541edeabab89435c34c64f0();
}


} // RL_ce09c545b541edeabab89435c34c64f0
}
