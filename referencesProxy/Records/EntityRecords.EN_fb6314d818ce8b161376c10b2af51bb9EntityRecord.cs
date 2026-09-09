using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {

/// <summary>
/// [ReferenceEntity] ApprovalProcessMatrix (XOhcXr413kCffFdR6716eQ)
///  <code>EN_fb6314d818ce8b161376c10b2af51bb9EntityRecord</code> that represent
/// s <code>ApprovalProcessMatrix</code> <p>Description: Approval Process Matrix</p>
/// </summary>
// Name: ApprovalProcessMatrix
public partial struct EN_fb6314d818ce8b161376c10b2af51bb9EntityRecord : ITypedRecord<EN_fb6314d818ce8b161376c10b2af51bb9EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("9NBgF2cKUEmD22aS2k06Pg*zeRLR_jA3kqlYCVNsTyxWw");
internal static readonly GlobalObjectKey IdProcessTypeId = GlobalObjectKey.Parse("9NBgF2cKUEmD22aS2k06Pg*Gf8993TlqEOgqhyDRSqFtw");
internal static readonly GlobalObjectKey IdRegion = GlobalObjectKey.Parse("9NBgF2cKUEmD22aS2k06Pg*AL1vk0KE2k+qhx9GtbJDgQ");
internal static readonly GlobalObjectKey IdArea = GlobalObjectKey.Parse("9NBgF2cKUEmD22aS2k06Pg*QKTTUxl4wE2tZZ7UFf96gQ");
internal static readonly GlobalObjectKey IdTelcelDirection = GlobalObjectKey.Parse("9NBgF2cKUEmD22aS2k06Pg*L7zthkTw2Eawraa5aU3BuA");
internal static readonly GlobalObjectKey IdApprovalProcessId = GlobalObjectKey.Parse("9NBgF2cKUEmD22aS2k06Pg*TVqu6jjHi0uqaUk2QFKfFg");
internal static readonly GlobalObjectKey IdIsActive = GlobalObjectKey.Parse("9NBgF2cKUEmD22aS2k06Pg*kiCOJSUgH0GgJ3XjIS2UXg");
internal static readonly GlobalObjectKey IdIsDonation_DEPREC = GlobalObjectKey.Parse("9NBgF2cKUEmD22aS2k06Pg*utche5_3pEKqimlUKQyfJA");
internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("9NBgF2cKUEmD22aS2k06Pg*tQmr9EnK9kWAoeld9rnopg");
internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("9NBgF2cKUEmD22aS2k06Pg*aqkDPiZXeEqPRvAbACmcGg");
internal static readonly GlobalObjectKey IdUpdatedBy = GlobalObjectKey.Parse("9NBgF2cKUEmD22aS2k06Pg*i2hGdH_NLE6r5JpcipmccQ");
internal static readonly GlobalObjectKey IdUpdatedOn = GlobalObjectKey.Parse("9NBgF2cKUEmD22aS2k06Pg*YwrKoyhiMEi0Hw3G0aY6fg");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(12,true);
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

private string _ssRegion;
public string ssRegion{
  get{
      return _ssRegion;
  }
  set{
      if((_ssRegion!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssRegion = value;
      }
  }
}

private string _ssArea;
public string ssArea{
  get{
      return _ssArea;
  }
  set{
      if((_ssArea!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssArea = value;
      }
  }
}

private string _ssTelcelDirection;
public string ssTelcelDirection{
  get{
      return _ssTelcelDirection;
  }
  set{
      if((_ssTelcelDirection!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssTelcelDirection = value;
      }
  }
}

private long _ssApprovalProcessId;
public long ssApprovalProcessId{
  get{
      return _ssApprovalProcessId;
  }
  set{
      if((_ssApprovalProcessId!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssApprovalProcessId = value;
      }
  }
}

private bool _ssIsActive;
public bool ssIsActive{
  get{
      return _ssIsActive;
  }
  set{
      if((_ssIsActive!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssIsActive = value;
      }
  }
}

private bool _ssIsDonation_DEPREC;
public bool ssIsDonation_DEPREC{
  get{
      return _ssIsDonation_DEPREC;
  }
  set{
      if((_ssIsDonation_DEPREC!=value) || OptimizedAttributes[7]){
          ChangedAttributes[7] = true;
          _ssIsDonation_DEPREC = value;
      }
  }
}

private string _ssCreatedBy;
public string ssCreatedBy{
  get{
      return _ssCreatedBy;
  }
  set{
      if((_ssCreatedBy!=value) || OptimizedAttributes[8]){
          ChangedAttributes[8] = true;
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
      if((_ssCreatedOn!=value) || OptimizedAttributes[9]){
          ChangedAttributes[9] = true;
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
      if((_ssUpdatedBy!=value) || OptimizedAttributes[10]){
          ChangedAttributes[10] = true;
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
      if((_ssUpdatedOn!=value) || OptimizedAttributes[11]){
          ChangedAttributes[11] = true;
          _ssUpdatedOn = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_fb6314d818ce8b161376c10b2af51bb9EntityRecord() {
ChangedAttributes = new BitArray(12,true);
OptimizedAttributes = new BitArray(12,false);
_ssId = 0L;
_ssProcessTypeId = 0L;
_ssRegion = "";
_ssArea = "";
_ssTelcelDirection = "";
_ssApprovalProcessId = 0L;
_ssIsActive = false;
_ssIsDonation_DEPREC = false;
_ssCreatedBy = "";
_ssCreatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssUpdatedBy = "";
_ssUpdatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
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
ssId = r.ReadLongInteger(index++, "ApprovalProcessMatrix.Id", 0L);
ssProcessTypeId = r.ReadEntityReferenceLongInteger(index++, "ApprovalProcessMatrix.ProcessTypeId", 0L);
ssRegion = r.ReadText(index++, "ApprovalProcessMatrix.Region", "");
ssArea = r.ReadText(index++, "ApprovalProcessMatrix.Area", "");
ssTelcelDirection = r.ReadText(index++, "ApprovalProcessMatrix.TelcelDirection", "");
ssApprovalProcessId = r.ReadEntityReferenceLongInteger(index++, "ApprovalProcessMatrix.ApprovalProcessId", 0L);
ssIsActive = r.ReadBoolean(index++, "ApprovalProcessMatrix.IsActive", false);
ssIsDonation_DEPREC = r.ReadBoolean(index++, "ApprovalProcessMatrix.IsDonation_DEPREC", false);
ssCreatedBy = r.ReadEntityReferenceText(index++, "ApprovalProcessMatrix.CreatedBy", "");
ssCreatedOn = r.ReadDateTime(index++, "ApprovalProcessMatrix.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssUpdatedBy = r.ReadEntityReferenceText(index++, "ApprovalProcessMatrix.UpdatedBy", "");
ssUpdatedOn = r.ReadDateTime(index++, "ApprovalProcessMatrix.UpdatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ChangedAttributes = new BitArray(12,false);
OptimizedAttributes = new BitArray(12,false);
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
public void ReadIM(EN_fb6314d818ce8b161376c10b2af51bb9EntityRecord r) {
this = r;
}


public static bool operator == (EN_fb6314d818ce8b161376c10b2af51bb9EntityRecord a, EN_fb6314d818ce8b161376c10b2af51bb9EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssProcessTypeId != b.ssProcessTypeId) return false;
if (a.ssRegion != b.ssRegion) return false;
if (a.ssArea != b.ssArea) return false;
if (a.ssTelcelDirection != b.ssTelcelDirection) return false;
if (a.ssApprovalProcessId != b.ssApprovalProcessId) return false;
if (a.ssIsActive != b.ssIsActive) return false;
if (a.ssIsDonation_DEPREC != b.ssIsDonation_DEPREC) return false;
if (a.ssCreatedBy != b.ssCreatedBy) return false;
if (a.ssCreatedOn != b.ssCreatedOn) return false;
if (a.ssUpdatedBy != b.ssUpdatedBy) return false;
if (a.ssUpdatedOn != b.ssUpdatedOn) return false;
return true;
}

public static bool operator != (EN_fb6314d818ce8b161376c10b2af51bb9EntityRecord a, EN_fb6314d818ce8b161376c10b2af51bb9EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_fb6314d818ce8b161376c10b2af51bb9EntityRecord)) return false;
return (this == (EN_fb6314d818ce8b161376c10b2af51bb9EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssProcessTypeId.GetHashCode()
 ^ ssRegion.GetHashCode()
 ^ ssArea.GetHashCode()
 ^ ssTelcelDirection.GetHashCode()
 ^ ssApprovalProcessId.GetHashCode()
 ^ ssIsActive.GetHashCode()
 ^ ssIsDonation_DEPREC.GetHashCode()
 ^ ssCreatedBy.GetHashCode()
 ^ ssCreatedOn.GetHashCode()
 ^ ssUpdatedBy.GetHashCode()
 ^ ssUpdatedOn.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_fb6314d818ce8b161376c10b2af51bb9EntityRecord Duplicate() {
EN_fb6314d818ce8b161376c10b2af51bb9EntityRecord t;
t._ssId = this._ssId;
t._ssProcessTypeId = this._ssProcessTypeId;
t._ssRegion = this._ssRegion;
t._ssArea = this._ssArea;
t._ssTelcelDirection = this._ssTelcelDirection;
t._ssApprovalProcessId = this._ssApprovalProcessId;
t._ssIsActive = this._ssIsActive;
t._ssIsDonation_DEPREC = this._ssIsDonation_DEPREC;
t._ssCreatedBy = this._ssCreatedBy;
t._ssCreatedOn = this._ssCreatedOn;
t._ssUpdatedBy = this._ssUpdatedBy;
t._ssUpdatedOn = this._ssUpdatedOn;
t.ChangedAttributes = new BitArray(12);
t.OptimizedAttributes = new BitArray(12);
for(int i = 0; i < 12; i++){
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
} else if (head == "region") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Region")) variable.Value = ssRegion; else variable.Optimized = true;
} else if (head == "area") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Area")) variable.Value = ssArea; else variable.Optimized = true;
} else if (head == "telceldirection") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TelcelDirection")) variable.Value = ssTelcelDirection; else variable.Optimized = true;
} else if (head == "approvalprocessid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApprovalProcessId")) variable.Value = ssApprovalProcessId; else variable.Optimized = true;
} else if (head == "isactive") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsActive")) variable.Value = ssIsActive; else variable.Optimized = true;
} else if (head == "isdonation_deprec") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsDonation_DEPREC")) variable.Value = ssIsDonation_DEPREC; else variable.Optimized = true;
} else if (head == "createdby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedBy")) variable.Value = ssCreatedBy; else variable.Optimized = true;
} else if (head == "createdon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedOn")) variable.Value = ssCreatedOn; else variable.Optimized = true;
} else if (head == "updatedby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdatedBy")) variable.Value = ssUpdatedBy; else variable.Optimized = true;
} else if (head == "updatedon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdatedOn")) variable.Value = ssUpdatedOn; else variable.Optimized = true;
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
if (key.Equals(IdRegion)) {
return ChangedAttributes[2];
}
if (key.Equals(IdArea)) {
return ChangedAttributes[3];
}
if (key.Equals(IdTelcelDirection)) {
return ChangedAttributes[4];
}
if (key.Equals(IdApprovalProcessId)) {
return ChangedAttributes[5];
}
if (key.Equals(IdIsActive)) {
return ChangedAttributes[6];
}
if (key.Equals(IdIsDonation_DEPREC)) {
return ChangedAttributes[7];
}
if (key.Equals(IdCreatedBy)) {
return ChangedAttributes[8];
}
if (key.Equals(IdCreatedOn)) {
return ChangedAttributes[9];
}
if (key.Equals(IdUpdatedBy)) {
return ChangedAttributes[10];
}
if (key.Equals(IdUpdatedOn)) {
return ChangedAttributes[11];
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
if (key.Equals(IdRegion)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdArea)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdTelcelDirection)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdApprovalProcessId)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdIsActive)) {
return OptimizedAttributes[6];
}
if (key.Equals(IdIsDonation_DEPREC)) {
return OptimizedAttributes[7];
}
if (key.Equals(IdCreatedBy)) {
return OptimizedAttributes[8];
}
if (key.Equals(IdCreatedOn)) {
return OptimizedAttributes[9];
}
if (key.Equals(IdUpdatedBy)) {
return OptimizedAttributes[10];
}
if (key.Equals(IdUpdatedOn)) {
return OptimizedAttributes[11];
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
if (key == IdRegion) {
return ssRegion;
}
if (key == IdArea) {
return ssArea;
}
if (key == IdTelcelDirection) {
return ssTelcelDirection;
}
if (key == IdApprovalProcessId) {
return ssApprovalProcessId;
}
if (key == IdIsActive) {
return ssIsActive;
}
if (key == IdIsDonation_DEPREC) {
return ssIsDonation_DEPREC;
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
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdProcessTypeId.Key.AsGuid) {
return ssProcessTypeId;
}
if (attributeKey == IdRegion.Key.AsGuid) {
return ssRegion;
}
if (attributeKey == IdArea.Key.AsGuid) {
return ssArea;
}
if (attributeKey == IdTelcelDirection.Key.AsGuid) {
return ssTelcelDirection;
}
if (attributeKey == IdApprovalProcessId.Key.AsGuid) {
return ssApprovalProcessId;
}
if (attributeKey == IdIsActive.Key.AsGuid) {
return ssIsActive;
}
if (attributeKey == IdIsDonation_DEPREC.Key.AsGuid) {
return ssIsDonation_DEPREC;
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
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(12);
OptimizedAttributes = new BitArray(12);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssProcessTypeId = (long) other.AttributeGet(IdProcessTypeId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdProcessTypeId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdProcessTypeId);
ssRegion = (string) other.AttributeGet(IdRegion);
ChangedAttributes[2] = other.ChangedAttributeGet(IdRegion);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdRegion);
ssArea = (string) other.AttributeGet(IdArea);
ChangedAttributes[3] = other.ChangedAttributeGet(IdArea);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdArea);
ssTelcelDirection = (string) other.AttributeGet(IdTelcelDirection);
ChangedAttributes[4] = other.ChangedAttributeGet(IdTelcelDirection);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdTelcelDirection);
ssApprovalProcessId = (long) other.AttributeGet(IdApprovalProcessId);
ChangedAttributes[5] = other.ChangedAttributeGet(IdApprovalProcessId);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdApprovalProcessId);
ssIsActive = (bool) other.AttributeGet(IdIsActive);
ChangedAttributes[6] = other.ChangedAttributeGet(IdIsActive);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdIsActive);
ssIsDonation_DEPREC = (bool) other.AttributeGet(IdIsDonation_DEPREC);
ChangedAttributes[7] = other.ChangedAttributeGet(IdIsDonation_DEPREC);
OptimizedAttributes[7] = other.OptimizedAttributeGet(IdIsDonation_DEPREC);
ssCreatedBy = (string) other.AttributeGet(IdCreatedBy);
ChangedAttributes[8] = other.ChangedAttributeGet(IdCreatedBy);
OptimizedAttributes[8] = other.OptimizedAttributeGet(IdCreatedBy);
ssCreatedOn = (DateTime) other.AttributeGet(IdCreatedOn);
ChangedAttributes[9] = other.ChangedAttributeGet(IdCreatedOn);
OptimizedAttributes[9] = other.OptimizedAttributeGet(IdCreatedOn);
ssUpdatedBy = (string) other.AttributeGet(IdUpdatedBy);
ChangedAttributes[10] = other.ChangedAttributeGet(IdUpdatedBy);
OptimizedAttributes[10] = other.OptimizedAttributeGet(IdUpdatedBy);
ssUpdatedOn = (DateTime) other.AttributeGet(IdUpdatedOn);
ChangedAttributes[11] = other.ChangedAttributeGet(IdUpdatedOn);
OptimizedAttributes[11] = other.OptimizedAttributeGet(IdUpdatedOn);
}
} // EN_fb6314d818ce8b161376c10b2af51bb9EntityRecord

/// <summary>
/// RecordList type <code>ApprovalProcessMatrixList</code> that represents a record list of
///  <code>ApprovalProcessMatrix</code>
/// </summary>
public partial class RL_71e77bce372759eaceec0362eaabe42d : GenericRecordList<EN_fb6314d818ce8b161376c10b2af51bb9EntityRecord>, IEnumerable, IEnumerator {

protected override EN_fb6314d818ce8b161376c10b2af51bb9EntityRecord GetElementDefaultValue() {
return new EN_fb6314d818ce8b161376c10b2af51bb9EntityRecord();
}

public T[] ToArray<T>(Func<EN_fb6314d818ce8b161376c10b2af51bb9EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_71e77bce372759eaceec0362eaabe42d recordList, Func<EN_fb6314d818ce8b161376c10b2af51bb9EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_71e77bce372759eaceec0362eaabe42d(EN_fb6314d818ce8b161376c10b2af51bb9EntityRecord[] array) {
  RL_71e77bce372759eaceec0362eaabe42d result = new RL_71e77bce372759eaceec0362eaabe42d();
result.InnerFromArray(array);
    return result;
}

public static RL_71e77bce372759eaceec0362eaabe42d ToList<T>(T[] array, Func <T, EN_fb6314d818ce8b161376c10b2af51bb9EntityRecord> converter) {
  RL_71e77bce372759eaceec0362eaabe42d result = new RL_71e77bce372759eaceec0362eaabe42d();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_71e77bce372759eaceec0362eaabe42d FromRestList<T>(RestList<T> restList, Func <T, EN_fb6314d818ce8b161376c10b2af51bb9EntityRecord> converter) {
  RL_71e77bce372759eaceec0362eaabe42d result = new RL_71e77bce372759eaceec0362eaabe42d();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_71e77bce372759eaceec0362eaabe42d() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_fb6314d818ce8b161376c10b2af51bb9EntityRecord> NewList() {
return new RL_71e77bce372759eaceec0362eaabe42d();
}


} // RL_71e77bce372759eaceec0362eaabe42d
}
