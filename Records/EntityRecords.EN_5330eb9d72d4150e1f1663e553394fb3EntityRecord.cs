using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [ReferenceEntity] AccountableGuide (UikfqIjV6k+5cX7xE7Hd5w)
///  <code>EN_5330eb9d72d4150e1f1663e553394fb3EntityRecord</code> that represent
/// s <code>AccountableGuide</code> <p>Description: Accountable Guide</p>
/// </summary>
// Name: AccountableGuide
public partial struct EN_5330eb9d72d4150e1f1663e553394fb3EntityRecord : ITypedRecord<EN_5330eb9d72d4150e1f1663e553394fb3EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*0jYvwsM9pE6OA4O6n_gG3Q");
internal static readonly GlobalObjectKey IdSupplierId = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*xS9VFywclU6WDOZ+D_ohHA");
internal static readonly GlobalObjectKey IdProject_Asset_ServiceId = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*yFVdmbNEIkOzF9a5YL0mhA");
internal static readonly GlobalObjectKey IdRegionId = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*JQkH53+QI0KS+8+Iq8D1dg");
internal static readonly GlobalObjectKey IdAccountName = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*xJNLXfyqakKIjZ_iZ+NATA");
internal static readonly GlobalObjectKey IdAccount = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*XzdwDBEFjES3ykJGE3H0GQ");
internal static readonly GlobalObjectKey IdCostCenterSAPId = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*1FUx6jRMAUClrVI5OgLzDQ");
internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*gt57iHU3Q0CL538aJ9U8Ow");
internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*vwhKjYdhV0Gq2ZdQ2Dlpvg");
internal static readonly GlobalObjectKey IdUpdatedOn = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*ObyXIPNPCUKva7grYtBEhQ");
internal static readonly GlobalObjectKey IdUpdatedBy = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*7kBkFbuNc0qBBQNkV+9deQ");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(11,true);
          _ssId = value;
      }
  }
}

private long _ssSupplierId;
public long ssSupplierId{
  get{
      return _ssSupplierId;
  }
  set{
      if((_ssSupplierId!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssSupplierId = value;
      }
  }
}

private long _ssProject_Asset_ServiceId;
public long ssProject_Asset_ServiceId{
  get{
      return _ssProject_Asset_ServiceId;
  }
  set{
      if((_ssProject_Asset_ServiceId!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssProject_Asset_ServiceId = value;
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

private string _ssAccountName;
public string ssAccountName{
  get{
      return _ssAccountName;
  }
  set{
      if((_ssAccountName!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssAccountName = value;
      }
  }
}

private string _ssAccount;
public string ssAccount{
  get{
      return _ssAccount;
  }
  set{
      if((_ssAccount!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssAccount = value;
      }
  }
}

private long _ssCostCenterSAPId;
public long ssCostCenterSAPId{
  get{
      return _ssCostCenterSAPId;
  }
  set{
      if((_ssCostCenterSAPId!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssCostCenterSAPId = value;
      }
  }
}

private DateTime _ssCreatedOn;
public DateTime ssCreatedOn{
  get{
      return _ssCreatedOn;
  }
  set{
      if((_ssCreatedOn!=value) || OptimizedAttributes[7]){
          ChangedAttributes[7] = true;
          _ssCreatedOn = value;
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

private DateTime _ssUpdatedOn;
public DateTime ssUpdatedOn{
  get{
      return _ssUpdatedOn;
  }
  set{
      if((_ssUpdatedOn!=value) || OptimizedAttributes[9]){
          ChangedAttributes[9] = true;
          _ssUpdatedOn = value;
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


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_5330eb9d72d4150e1f1663e553394fb3EntityRecord() {
ChangedAttributes = new BitArray(11,true);
OptimizedAttributes = new BitArray(11,false);
_ssId = 0L;
_ssSupplierId = 0L;
_ssProject_Asset_ServiceId = 0L;
_ssRegionId = 0L;
_ssAccountName = "";
_ssAccount = "";
_ssCostCenterSAPId = 0L;
_ssCreatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssCreatedBy = "";
_ssUpdatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssUpdatedBy = "";
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
ssId = r.ReadLongInteger(index++, "AccountableGuide.Id", 0L);
ssSupplierId = r.ReadEntityReferenceLongInteger(index++, "AccountableGuide.SupplierId", 0L);
ssProject_Asset_ServiceId = r.ReadEntityReferenceLongInteger(index++, "AccountableGuide.Project_Asset_ServiceId", 0L);
ssRegionId = r.ReadEntityReferenceLongInteger(index++, "AccountableGuide.RegionId", 0L);
ssAccountName = r.ReadText(index++, "AccountableGuide.AccountName", "");
ssAccount = r.ReadText(index++, "AccountableGuide.Account", "");
ssCostCenterSAPId = r.ReadEntityReferenceLongInteger(index++, "AccountableGuide.CostCenterSAPId", 0L);
ssCreatedOn = r.ReadDateTime(index++, "AccountableGuide.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssCreatedBy = r.ReadEntityReferenceText(index++, "AccountableGuide.CreatedBy", "");
ssUpdatedOn = r.ReadDateTime(index++, "AccountableGuide.UpdatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssUpdatedBy = r.ReadEntityReferenceText(index++, "AccountableGuide.UpdatedBy", "");
ChangedAttributes = new BitArray(11,false);
OptimizedAttributes = new BitArray(11,false);
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
public void ReadIM(EN_5330eb9d72d4150e1f1663e553394fb3EntityRecord r) {
this = r;
}


public static bool operator == (EN_5330eb9d72d4150e1f1663e553394fb3EntityRecord a, EN_5330eb9d72d4150e1f1663e553394fb3EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssSupplierId != b.ssSupplierId) return false;
if (a.ssProject_Asset_ServiceId != b.ssProject_Asset_ServiceId) return false;
if (a.ssRegionId != b.ssRegionId) return false;
if (a.ssAccountName != b.ssAccountName) return false;
if (a.ssAccount != b.ssAccount) return false;
if (a.ssCostCenterSAPId != b.ssCostCenterSAPId) return false;
if (a.ssCreatedOn != b.ssCreatedOn) return false;
if (a.ssCreatedBy != b.ssCreatedBy) return false;
if (a.ssUpdatedOn != b.ssUpdatedOn) return false;
if (a.ssUpdatedBy != b.ssUpdatedBy) return false;
return true;
}

public static bool operator != (EN_5330eb9d72d4150e1f1663e553394fb3EntityRecord a, EN_5330eb9d72d4150e1f1663e553394fb3EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_5330eb9d72d4150e1f1663e553394fb3EntityRecord)) return false;
return (this == (EN_5330eb9d72d4150e1f1663e553394fb3EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssSupplierId.GetHashCode()
 ^ ssProject_Asset_ServiceId.GetHashCode()
 ^ ssRegionId.GetHashCode()
 ^ ssAccountName.GetHashCode()
 ^ ssAccount.GetHashCode()
 ^ ssCostCenterSAPId.GetHashCode()
 ^ ssCreatedOn.GetHashCode()
 ^ ssCreatedBy.GetHashCode()
 ^ ssUpdatedOn.GetHashCode()
 ^ ssUpdatedBy.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_5330eb9d72d4150e1f1663e553394fb3EntityRecord Duplicate() {
EN_5330eb9d72d4150e1f1663e553394fb3EntityRecord t;
t._ssId = this._ssId;
t._ssSupplierId = this._ssSupplierId;
t._ssProject_Asset_ServiceId = this._ssProject_Asset_ServiceId;
t._ssRegionId = this._ssRegionId;
t._ssAccountName = this._ssAccountName;
t._ssAccount = this._ssAccount;
t._ssCostCenterSAPId = this._ssCostCenterSAPId;
t._ssCreatedOn = this._ssCreatedOn;
t._ssCreatedBy = this._ssCreatedBy;
t._ssUpdatedOn = this._ssUpdatedOn;
t._ssUpdatedBy = this._ssUpdatedBy;
t.ChangedAttributes = new BitArray(11);
t.OptimizedAttributes = new BitArray(11);
for(int i = 0; i < 11; i++){
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
} else if (head == "supplierid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SupplierId")) variable.Value = ssSupplierId; else variable.Optimized = true;
} else if (head == "project_asset_serviceid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Project_Asset_ServiceId")) variable.Value = ssProject_Asset_ServiceId; else variable.Optimized = true;
} else if (head == "regionid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RegionId")) variable.Value = ssRegionId; else variable.Optimized = true;
} else if (head == "accountname") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AccountName")) variable.Value = ssAccountName; else variable.Optimized = true;
} else if (head == "account") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Account")) variable.Value = ssAccount; else variable.Optimized = true;
} else if (head == "costcentersapid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CostCenterSAPId")) variable.Value = ssCostCenterSAPId; else variable.Optimized = true;
} else if (head == "createdon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedOn")) variable.Value = ssCreatedOn; else variable.Optimized = true;
} else if (head == "createdby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedBy")) variable.Value = ssCreatedBy; else variable.Optimized = true;
} else if (head == "updatedon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdatedOn")) variable.Value = ssUpdatedOn; else variable.Optimized = true;
} else if (head == "updatedby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdatedBy")) variable.Value = ssUpdatedBy; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdSupplierId)) {
return ChangedAttributes[1];
}
if (key.Equals(IdProject_Asset_ServiceId)) {
return ChangedAttributes[2];
}
if (key.Equals(IdRegionId)) {
return ChangedAttributes[3];
}
if (key.Equals(IdAccountName)) {
return ChangedAttributes[4];
}
if (key.Equals(IdAccount)) {
return ChangedAttributes[5];
}
if (key.Equals(IdCostCenterSAPId)) {
return ChangedAttributes[6];
}
if (key.Equals(IdCreatedOn)) {
return ChangedAttributes[7];
}
if (key.Equals(IdCreatedBy)) {
return ChangedAttributes[8];
}
if (key.Equals(IdUpdatedOn)) {
return ChangedAttributes[9];
}
if (key.Equals(IdUpdatedBy)) {
return ChangedAttributes[10];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdSupplierId)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdProject_Asset_ServiceId)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdRegionId)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdAccountName)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdAccount)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdCostCenterSAPId)) {
return OptimizedAttributes[6];
}
if (key.Equals(IdCreatedOn)) {
return OptimizedAttributes[7];
}
if (key.Equals(IdCreatedBy)) {
return OptimizedAttributes[8];
}
if (key.Equals(IdUpdatedOn)) {
return OptimizedAttributes[9];
}
if (key.Equals(IdUpdatedBy)) {
return OptimizedAttributes[10];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdSupplierId) {
return ssSupplierId;
}
if (key == IdProject_Asset_ServiceId) {
return ssProject_Asset_ServiceId;
}
if (key == IdRegionId) {
return ssRegionId;
}
if (key == IdAccountName) {
return ssAccountName;
}
if (key == IdAccount) {
return ssAccount;
}
if (key == IdCostCenterSAPId) {
return ssCostCenterSAPId;
}
if (key == IdCreatedOn) {
return ssCreatedOn;
}
if (key == IdCreatedBy) {
return ssCreatedBy;
}
if (key == IdUpdatedOn) {
return ssUpdatedOn;
}
if (key == IdUpdatedBy) {
return ssUpdatedBy;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdSupplierId.Key.AsGuid) {
return ssSupplierId;
}
if (attributeKey == IdProject_Asset_ServiceId.Key.AsGuid) {
return ssProject_Asset_ServiceId;
}
if (attributeKey == IdRegionId.Key.AsGuid) {
return ssRegionId;
}
if (attributeKey == IdAccountName.Key.AsGuid) {
return ssAccountName;
}
if (attributeKey == IdAccount.Key.AsGuid) {
return ssAccount;
}
if (attributeKey == IdCostCenterSAPId.Key.AsGuid) {
return ssCostCenterSAPId;
}
if (attributeKey == IdCreatedOn.Key.AsGuid) {
return ssCreatedOn;
}
if (attributeKey == IdCreatedBy.Key.AsGuid) {
return ssCreatedBy;
}
if (attributeKey == IdUpdatedOn.Key.AsGuid) {
return ssUpdatedOn;
}
if (attributeKey == IdUpdatedBy.Key.AsGuid) {
return ssUpdatedBy;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(11);
OptimizedAttributes = new BitArray(11);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssSupplierId = (long) other.AttributeGet(IdSupplierId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdSupplierId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdSupplierId);
ssProject_Asset_ServiceId = (long) other.AttributeGet(IdProject_Asset_ServiceId);
ChangedAttributes[2] = other.ChangedAttributeGet(IdProject_Asset_ServiceId);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdProject_Asset_ServiceId);
ssRegionId = (long) other.AttributeGet(IdRegionId);
ChangedAttributes[3] = other.ChangedAttributeGet(IdRegionId);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdRegionId);
ssAccountName = (string) other.AttributeGet(IdAccountName);
ChangedAttributes[4] = other.ChangedAttributeGet(IdAccountName);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdAccountName);
ssAccount = (string) other.AttributeGet(IdAccount);
ChangedAttributes[5] = other.ChangedAttributeGet(IdAccount);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdAccount);
ssCostCenterSAPId = (long) other.AttributeGet(IdCostCenterSAPId);
ChangedAttributes[6] = other.ChangedAttributeGet(IdCostCenterSAPId);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdCostCenterSAPId);
ssCreatedOn = (DateTime) other.AttributeGet(IdCreatedOn);
ChangedAttributes[7] = other.ChangedAttributeGet(IdCreatedOn);
OptimizedAttributes[7] = other.OptimizedAttributeGet(IdCreatedOn);
ssCreatedBy = (string) other.AttributeGet(IdCreatedBy);
ChangedAttributes[8] = other.ChangedAttributeGet(IdCreatedBy);
OptimizedAttributes[8] = other.OptimizedAttributeGet(IdCreatedBy);
ssUpdatedOn = (DateTime) other.AttributeGet(IdUpdatedOn);
ChangedAttributes[9] = other.ChangedAttributeGet(IdUpdatedOn);
OptimizedAttributes[9] = other.OptimizedAttributeGet(IdUpdatedOn);
ssUpdatedBy = (string) other.AttributeGet(IdUpdatedBy);
ChangedAttributes[10] = other.ChangedAttributeGet(IdUpdatedBy);
OptimizedAttributes[10] = other.OptimizedAttributeGet(IdUpdatedBy);
}
} // EN_5330eb9d72d4150e1f1663e553394fb3EntityRecord

/// <summary>
/// RecordList type <code>AccountableGuideList</code> that represents a record list of
///  <code>AccountableGuide</code>
/// </summary>
public partial class RL_55668fc56c75170ede12463abfca794f : GenericRecordList<EN_5330eb9d72d4150e1f1663e553394fb3EntityRecord>, IEnumerable, IEnumerator {

protected override EN_5330eb9d72d4150e1f1663e553394fb3EntityRecord GetElementDefaultValue() {
return new EN_5330eb9d72d4150e1f1663e553394fb3EntityRecord();
}

public T[] ToArray<T>(Func<EN_5330eb9d72d4150e1f1663e553394fb3EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_55668fc56c75170ede12463abfca794f recordList, Func<EN_5330eb9d72d4150e1f1663e553394fb3EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_55668fc56c75170ede12463abfca794f(EN_5330eb9d72d4150e1f1663e553394fb3EntityRecord[] array) {
  RL_55668fc56c75170ede12463abfca794f result = new RL_55668fc56c75170ede12463abfca794f();
result.InnerFromArray(array);
    return result;
}

public static RL_55668fc56c75170ede12463abfca794f ToList<T>(T[] array, Func <T, EN_5330eb9d72d4150e1f1663e553394fb3EntityRecord> converter) {
  RL_55668fc56c75170ede12463abfca794f result = new RL_55668fc56c75170ede12463abfca794f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_55668fc56c75170ede12463abfca794f FromRestList<T>(RestList<T> restList, Func <T, EN_5330eb9d72d4150e1f1663e553394fb3EntityRecord> converter) {
  RL_55668fc56c75170ede12463abfca794f result = new RL_55668fc56c75170ede12463abfca794f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_55668fc56c75170ede12463abfca794f() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_5330eb9d72d4150e1f1663e553394fb3EntityRecord> NewList() {
return new RL_55668fc56c75170ede12463abfca794f();
}


} // RL_55668fc56c75170ede12463abfca794f
}
